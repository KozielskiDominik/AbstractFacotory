using AbstractFactory.Champions;
using AbstractFactory.Creatures;

namespace AbstractFactory
{
    public class CastleFactory : ITownsFactory
    {
        public IChampion CreateChampion()
        {
            return new Lancelot();
        }

        public ICreature CreateCreature()
        {
            return new Peasant();
        }
    }
}
