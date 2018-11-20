using System;

namespace AbstractFactory.Champions
{
    class Halon : IChampion
    {
        public void ShowArmy(ICreature creature)
        {
            Console.WriteLine(GetType().Name +" has " + creature.GetType().Name);
        }
    }
}
