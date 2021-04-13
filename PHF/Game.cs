using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHF {
    public interface IComputerStrategy {
        Game.Move GetMove();
    }

    public class RandomStrategy : IComputerStrategy {
        private Game.Move[] _computerMoves = new Game.Move[] { Game.Move.Paper, Game.Move.Rock, Game.Move.Scissors };
        private Random _random = new Random();

        public Game.Move GetMove() {
            return _computerMoves[_random.Next(0, 3)];
        }
    }

    public class Game {
        private static Game _instance = new Game();
        private static IComputerStrategy _strategy = new RandomStrategy();

        private Scoring _score = new Scoring();

        public static Game Instance {
            get {
                return _instance;
            }
        }

        public static IComputerStrategy ComputerStrategy {
            get {
                return _strategy;
            }
            // for testing
            set {
                _strategy = value;
            }
        }

        public Scoring Score => _score;

        private Game() {

        }

        public Outcome Play(Move move) {
            var humanMove = move;
            var computerMove = _strategy.GetMove();

            if (win(humanMove, computerMove)) {
                _score.HumanWin();
                return new Outcome(humanMove, computerMove, "Ai castigat!");
            }
            if (win(computerMove, humanMove)) {
                _score.ComputerWin();
                return new Outcome(humanMove, computerMove, "Ai pierdut!");
            }

            return new Outcome(humanMove, computerMove, "Egalitate");
        }

        private bool win(Move move1, Move move2) {
            if (move1 == Move.Rock && move2 == Move.Scissors) return true;
            if (move1 == Move.Paper && move2 == Move.Rock) return true;
            if (move1 == Move.Scissors && move2 == Move.Paper) return true;
            return false;
        }

        public enum Move {
            Rock, Paper, Scissors
        }

        public class Outcome {
            private Move _humanMove;
            private Move _computerMove;
            private string _text;

            public Move HumanMove => _humanMove;
            public Move ComputerMove => _computerMove;
            public string Text => _text;

            public Outcome(Move humanMove, Move computerMove, string text) {
                _humanMove = humanMove;
                _computerMove = computerMove;
                _text = text;
            }
        }

        public class Scoring {
            private int _human = 0;
            private int _computer = 0;

            public int Human => _human;
            public int Computer => _computer;

            public void HumanWin() {
                _human++;
            }

            public void ComputerWin() {
                _computer++;
            }
        }
    }
}
