using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSample.MenuAbstractFactory
{
    // Abstract Product A
    abstract class AdultPortion
    {
        public decimal Price { get; protected set; }
    }

    class MainAdultDish : AdultPortion
    {
        public MainAdultDish()
        {
            Price = 5.5m;
        }
    }

    class DessertAdultDish : AdultPortion
    {
        public DessertAdultDish()
        {
            Price = 4.5m;
        }
    }
    
    
    // Abstract Product Β

    abstract class ChildPortion
    {
        public decimal Price { get; protected set; }
        public abstract void Gift();

    }

    class MainChildDish : ChildPortion
    {
        public MainChildDish()
        {
            Price = 3.5m;
        }

        public override void Gift()
        {
            Console.WriteLine("I have a toy !");
        }
    }

    class DessertChildDish : ChildPortion
    {
        public DessertChildDish()
        {
            Price = 2.5m;
        }

        public override void Gift()
        {
            Console.WriteLine("I have a kinder egg...");
        }
    }


    // Abstract Factory
    abstract class DishesDepartment
    {
        public abstract AdultPortion MakeAdultPortion();
        public abstract ChildPortion MakeChildPortion();
    }

    class MainDish : DishesDepartment
    {
        public override AdultPortion MakeAdultPortion()
        {
            return new MainAdultDish();
        }

        public override ChildPortion MakeChildPortion()
        {
            return new MainChildDish();
        }
    }
    class DessertDish : DishesDepartment
    {
        public override AdultPortion MakeAdultPortion()
        {
            return new DessertAdultDish();
        }

        public override ChildPortion MakeChildPortion()
        {
            return new DessertChildDish();
        }
    }

    #region ===== unfruitful try ,  commented out code that makes SOME sense but is not completely right ============== 
    // we learn from mistakes :




    //class FamilyMenu
    //{
    //    public List<MainDish> MainDishes { get; }
    //    public List<DessertDish> DessertDishes { get; }

    //    public FamilyMenu(List<MainDish> mainDishes, List<DessertDish> dessertDishes)
    //    {
    //        MainDishes = mainDishes;
    //        DessertDishes = dessertDishes;
    //    }

    //    public void GiveGifts()
    //    {
    //        mainDishes.Gift();
    //    }

    //    public override string ToString()
    //    {
    //        return $"The {AdultPortion.GetType().Name} with the {ChildPortion.GetType().Name} comes as an offer with the total cost of {AdultPortion.Price + ChildPortion.Price} and a { ChildPortion.GetType().Name} ";
    //    }


    //}



    //class FamilyMenu
    //{
    //    //Εδω μήπως θα ηθελε αντι για τις 4 properties που ακολουθουν, ηθελε να βαλω τις 2 παραπανω κλασεις που     κληρονομουν απο το DishesDepartment ως 2 properties???? 
    //    public MainAdultDish MainAdultDish { get; }
    //    public DessertAdultDish DessertAdultDish { get; }

    //    public MainChildDish MainChildDish { get; }
    //    public DessertChildDish DessertChildDish { get; }

    //    public FamilyMenu(MainAdultDish mainAdultDish, DessertAdultDish dessertAdultDish, MainChildDish mainChildDish, DessertChildDish dessertChildDish)
    //    {
    //        MainAdultDish = mainAdultDish;
    //        DessertAdultDish = dessertAdultDish;
    //        MainChildDish = mainChildDish;
    //        DessertChildDish = dessertChildDish;
    //    }

    //    public void GiveGifts()
    //    {
    //        MainChildDish.Gift();
    //        DessertChildDish.Gift();
    //    }

    //    public override string ToString()
    //    {
    //        return $"The {MainAdultDish.GetType().Name} with the {DessertAdultDish.GetType().Name} comes as an offer with children's meals at the total cost of {MainAdultDish.Price + DessertAdultDish.Price + MainChildDish.Price + DessertChildDish.Price }";
    //    }
    //}


    ////client
    //class MenuProduction
    //{
    //    private FamilyMenu _familyMenu;


    //    public MenuProduction(FamilyMenu familyMenu)
    //    {
    //        _familyMenu = familyMenu;
    //    }

    //   public FamilyMenu CreateMenu( )
    //    {
    //        var mainDishes = AdultPortion.MakeAdultPortion();
    //        var desserts = _dessertDishDepartment.MakeChildPortion();

    //      return new FamilyMenu( mainDishes,  desserts);
    //    }

    //}

    //class AbstractFactoryDemo
    //{
    //    public  static void Demo()
    //    {
    //        var menuForTwo = new MenuProduction(new MainDishDepartment(), new DessertDishDepartment());
    //        var familyMenuForTwo = menuForTwo.CreateMenu();
    //        Console.WriteLine(familyMenuForTwo);
    //        familyMenuForTwo.ToString();
    //        Console.WriteLine("Your surprice is: ");
    //        familyMenuForTwo.GiveGifts();

    //        Console.Read();

    //    }
    //}



    #endregion


}
