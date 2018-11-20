namespace AbstractFactory
{
    public interface ITownsFactory
    {
        IChampion CreateChampion();
        ICreature CreateCreature();
    }
}
