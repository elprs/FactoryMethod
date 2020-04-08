using System;

namespace FactoryMethodPatternSample.AbstractFactory
{
    // Suzuki produces SX4 and Swift cars in multiple factories
    class AbstractFactoryDemo
    {
        public static void Demo()
        {
            var europe = new AssemblyLine(new SX4Factory());
            var sx4 = europe.AssembleCar();
            Console.WriteLine(sx4);
            sx4.StartEngine();

            var japan = new AssemblyLine(new SwiftFactory());
            var swift = japan.AssembleCar();
            Console.WriteLine(swift);
            swift.StartEngine();

            Console.Read();
        }
    }


    // Abstract Factory
    abstract class SuzukiFactory
    {
        public abstract Frame MakeFrame();

        public abstract Engine MakeEngine();
    }

    class SX4Factory : SuzukiFactory
    {
        public override Frame MakeFrame()
        {
            return new SX4Frame();
        }

        public override Engine MakeEngine()
        {
            return new SX4Engine();
        }
    }

    class SwiftFactory : SuzukiFactory
    {
        public override Frame MakeFrame()
        {
            return new SwiftFrame();
        }

        public override Engine MakeEngine()
        {
            return new SwiftEngine();
        }
    }

    // Client
    class AssemblyLine
    {
        private SuzukiFactory _factory;

        public AssemblyLine(SuzukiFactory factory)
        {
            _factory = factory;
        }

        public Car AssembleCar()
        {
            var frame = _factory.MakeFrame();
            var engine = _factory.MakeEngine();
            return new Car(frame, engine);
        }
    }

    // Abstract Product A
    abstract class Frame
    {
        public int Weight { get; protected set; }
    }

    class SX4Frame : Frame
    {
        public SX4Frame()
        {
            Weight = 600;
        }
    }

    class SwiftFrame : Frame
    {
        public SwiftFrame()
        {
            Weight = 350;
        }
    }

    abstract class Engine
    {
        public int HP { get; protected set; }

        public abstract void Start();
    }

    class SX4Engine : Engine
    {
        public SX4Engine()
        {
            HP = 120;
        }

        public override void Start()
        {
            Console.WriteLine("Vrooom!");
        }
    }

    class SwiftEngine : Engine
    {
        public SwiftEngine()
        {
            HP = 90;
        }

        public override void Start()
        {
            Console.WriteLine("vroom...");
        }
    }

    class Car
    {
        public Frame Frame { get; }
        public Engine Engine { get; }

        public Car(Frame frame, Engine engine)
        {
            Frame = frame;
            Engine = engine;
        }

        public void StartEngine()
        {
            Engine.Start();
        }

        public override string ToString()
        {
            return $"{Frame.GetType().Name} with a weight of {Frame.Weight} and a {Engine.GetType().Name}";
        }
    }
}
