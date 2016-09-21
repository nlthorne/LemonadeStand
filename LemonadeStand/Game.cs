namespace LemonadeStand
{
    public class Game
    {
        Day day;
        Store store;
        Player player;
        Weather weather;
        Customer customer;
        
        

        public Game()
        {
            day = new Day();
            store = new Store();
            player = new Player();
            weather = new Weather();
            customer = new Customer();
        }
        public void RunGame()
        {

        }
        public void MainMenu()
        {

        }
    }
}