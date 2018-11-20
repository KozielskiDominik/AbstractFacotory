using System;

namespace AbstractFactory
{
    partial class Program
    {
        public static void Main()
        {
            // Create and run the African animal world
            ITownsFactory inferno = new InfernoFactory();
            TownClient town = new TownClient(inferno);
            town.ShowArmy();

            ITownsFactory castle = new CastleFactory();
            town = new TownClient(castle);
            town.ShowArmy();

            ITownsFactory fortress = new FortressFactory();
            town = new TownClient(fortress);
            town.ShowArmy();

            Console.ReadKey();
        }
    }
}
