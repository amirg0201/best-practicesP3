using Best_Practices.ModelBuilders;
using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.Factories
{
    public class FordExplorerCreator : VehicleCreator
    {
        public override Vehicle Create()
        {
            return new CarBuilder()
                .SetBrand("Ford")
                .SetModel("Explorer")
                .SetColor("Blue")
                .Build();
        }
    }
}
