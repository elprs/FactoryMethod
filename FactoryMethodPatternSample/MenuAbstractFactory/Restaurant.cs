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


    //Please, help me to find the mistakes : 

    #region ===== unfruitful attemts ============== 
    

    //try 1


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

        //try 2

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

  
        //try 3

    //class FamilyMenu
    //{
    //    public AdultPortion AdultPortion1 { get; }
    //    public AdultPortion AdultPortion2 { get; }
    //    public ChildPortion ChildPortion1 { get; }
    //    public ChildPortion ChildPortion2 { get; }


    //    public FamilyMenu(AdultPortion mainDish1, ChildPortion mainDish2, AdultPortion dessertDish1, ChildPortion dessertDish2)
    //    {
    //        AdultPortion1 = mainDish1;
    //        AdultPortion2 = dessertDish1;
    //        ChildPortion1 = mainDish2;
    //        ChildPortion2 = dessertDish2;
    //    }

    //    public void GiveGifts()
    //    {
    //        ChildPortion1.Gift(); //why does it give two "I have a toy " ? (from the main menu)
    //        ChildPortion2.Gift();
    //    }


    //    public override string ToString()
    //    {
    //        return $"The {AdultPortion1.GetType().Name} with the {AdultPortion2.GetType().Name} comes as an offer with children's meals at the total cost of {AdultPortion1.Price + AdultPortion2.Price + ChildPortion1.Price + ChildPortion2.Price }";
    //    }
    //}


    //    //client&Demo based on try 3 of familyMenu : 

    ////client 
    //class MenuProduction
    //{

    //    private DishesDepartment _dishes;

        
    //    public MenuProduction(DishesDepartment dishes)
    //    {
    //       _dishes = dishes;
    //    }

    //    public FamilyMenu CreateMenu()
    //    {
    //        var main1 = _dishes.MakeAdultPortion();
    //        var main2 = _dishes.MakeChildPortion();
    //        var dessert1 = _dishes.MakeAdultPortion();
    //        var dessert2 = _dishes.MakeChildPortion();


    //        return new FamilyMenu(main1, main2, dessert1, dessert2);
    //    }

    //}


    //class AbstractFactoryDemo
    //{
    //    public static void Demo()
    //    {
    //        var happymeal = new MenuProduction(new MainDish());
    //        var familyMenu = happymeal.CreateMenu();
            
    //        Console.WriteLine($"Your meal is {familyMenu.ToString()}");
    //        familyMenu.GiveGifts();

    //        Console.Read();

    //    }
    //}


    #endregion


}
