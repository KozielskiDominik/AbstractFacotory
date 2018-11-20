using AbstractFactory.Champions;
using AbstractFactory.Creatures;
using System;

namespace AbstractFactory
{
    public class InfernoFactory : ITownsFactory
    {
        public IChampion CreateChampion()
        {
            return new Lucifer();
        }

        public ICreature CreateCreature()
        {
            return new Imp();
        }
    }
}
