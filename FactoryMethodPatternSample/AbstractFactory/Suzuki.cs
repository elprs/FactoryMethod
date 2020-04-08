using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSample.AbstractFactory
{
    // Suzuki produces SX4 and Swift cars in multiple factories

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
