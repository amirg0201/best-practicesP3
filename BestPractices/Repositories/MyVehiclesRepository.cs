using Best_Practices.Infraestructure.Singletons;
using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Repositories
{
    public class MyVehiclesRepository : IVehicleRepository
    {
        private readonly VehicleCollection _memoryCollection;

        public MyVehiclesRepository()
        {
            _memoryCollection = VehicleCollection.Instance;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _memoryCollection.Vehicles.Add(vehicle);
        }

        public Vehicle Find(string id)
        {
           // DOC: Programación defensiva. Evita crash si el ID no es un GUID válido.
            if (Guid.TryParse(id, out Guid guidId))
            {
                return _memoryCollection.Vehicles.FirstOrDefault(v => v.ID.Equals(guidId));
            }
            return null;
        }

        public ICollection<Vehicle> GetVehicles()
        {
            return _memoryCollection.Vehicles;
        }

        
    }
}
