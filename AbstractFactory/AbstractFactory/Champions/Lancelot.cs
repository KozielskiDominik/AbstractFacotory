using System;

namespace AbstractFactory.Champions
{
    class Lancelot : IChampion
    {
        public void ShowArmy(ICreature creature)
        {
            Console.WriteLine(GetType().Name + " has " + creature.GetType().Name);
        }
    }
}
