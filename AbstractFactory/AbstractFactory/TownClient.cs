namespace AbstractFactory
{
    class TownClient
    {
        private IChampion champion;
        private ICreature creature;

        public TownClient(ITownsFactory factory)
        {
            champion = factory.CreateChampion();
            creature = factory.CreateCreature();
        }
        public void ShowArmy()
        {
            champion.ShowArmy(creature);
        }
    }
}
