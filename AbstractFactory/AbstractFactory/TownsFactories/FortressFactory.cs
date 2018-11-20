using AbstractFactory.Champions;
using AbstractFactory.Creatures;

namespace AbstractFactory
{
    public class FortressFactory : ITownsFactory
    {
        public IChampion CreateChampion()
        {
            return new Halon();
        }
        public ICreature CreateCreature()
        {
            return new Gnoll();
        }
    }
}
