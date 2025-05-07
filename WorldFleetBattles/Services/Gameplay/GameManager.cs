using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldFleetBattles.Services.Players;

namespace WorldFleetBattles.Services.Gameplay
{
    public class GameManager
    {
        private IPlayer _player1;
        private IPlayer _player2;
        private IPlayer CurrentPlayer;
        private IPlayer OpponentPlayer;

        public bool IsGameOver { get; private set; }
        public GameManager(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
            CurrentPlayer = _player1;
            OpponentPlayer = _player2;
            IsGameOver = false;
        }

        public void StartGame()
        {
            Console.WriteLine("Game started!");
        }

        public void TakeTurn()
        {
            Console.WriteLine($"{CurrentPlayer.Name}'s turn.");
            bool hit = CurrentPlayer.TakeTurn(OpponentPlayer);
            Console.WriteLine(hit ? "Hit!" : "Miss!");

            if (OpponentPlayer.Fleet.AllShipsSunk)
            {
                Console.WriteLine($"{CurrentPlayer.Name} wins!");
                IsGameOver = true;
                return;
            }

            SwapPlayers();
        }

        public void RunGameLoop()
        {
            StartGame();

            while (!IsGameOver)
            {
                TakeTurn();
            }
        }
        private void SwapPlayers()
        {
            var temp = CurrentPlayer;
            CurrentPlayer = OpponentPlayer;
            OpponentPlayer = temp;
        }
    }
}
