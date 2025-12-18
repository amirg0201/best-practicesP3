using Best_Practices.Models;

namespace Best_Practices.Infraestructure.Factories
{
    // DOC: Clase creadora abstracta (Factory Method Pattern)
    public abstract class VehicleCreator
    {
        public abstract Vehicle Create();
    }
}