using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSample
{
    abstract class Ingredient
    {
        public abstract decimal Cost();
    }

    class Burger : Ingredient
    {
        public override decimal Cost()
        {
            return 2.0m;
        }
    }

    class Cheese : Ingredient
    {
        public override decimal Cost()
        {
            return 0.8m;
        }
    }

    class Lettuce : Ingredient
    {
        public override decimal Cost()
        {
            return 0.1m;
        }
    }

    class Tzatziki : Ingredient
    {
        public override decimal Cost()
        {
            return 0.0m;
        }
    }

    class Bread : Ingredient
    {
        public override decimal Cost()
        {
            return 0.5m;
        }
    }
}
