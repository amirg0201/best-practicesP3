using Best_Practices.ModelBuilders;
using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.Factories
{
    public class FordEscapeCreator : VehicleCreator
    {
        public override Vehicle Create()
        {
            // DOC: Implementación específica solicitada por el Arquitecto
            return new CarBuilder()
                .SetBrand("Ford")
                .SetModel("Escape")
                .SetColor("Red")
                .Build();
        }
    }
}
