namespace Labyrinthe
{
    internal class Controller
    {
        private View view;
        private Labyrinthe labyrinthe;

        public Controller(View view, Labyrinthe labyrinthe)
        {
            this.view = view;
            this.labyrinthe = labyrinthe;
        }

        public void Run()
        {
            while (!labyrinthe.IsExit())
            {
                view.AfficherEntete();
                view.AfficherLabyrinthe(labyrinthe);
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        labyrinthe.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        labyrinthe.MoveDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        labyrinthe.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        labyrinthe.MoveRight();
                        break;
                }
            }
            view.AfficherVictoire();
        }
    }
}
