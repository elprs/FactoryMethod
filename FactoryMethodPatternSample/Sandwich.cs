using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSample
{
    abstract class Sandwich
    {
        public List<Ingredient> Ingredients { get; }

        public decimal TotalCost => Ingredients.Sum(ingredient => ingredient.Cost());

        public Sandwich()
        {
            Ingredients = SelectIngredients();
        }

        protected abstract List<Ingredient> SelectIngredients();
    }

    class Souvlaki : Sandwich
    {
        protected override List<Ingredient> SelectIngredients()
        {
            return new List<Ingredient>
            {
                new Bread(),
                new Burger(),
                new Tzatziki()
            };
        }
    }

}
