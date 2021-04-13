using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHF {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            humanScoreLabel.Text = Game.Instance.Score.Human.ToString();
            computerScoreLabel.Text = Game.Instance.Score.Computer.ToString();
            outcomeLabel.Text = "Alege-ti mutarea pentru a incepe";
        }

        private void rockButton_Click(object sender, EventArgs e) {
            var outcome = Game.Instance.Play(Game.Move.Rock);

            updateView(outcome);
        }

        private void paperButton_Click(object sender, EventArgs e) {
            var outcome = Game.Instance.Play(Game.Move.Paper);

            updateView(outcome);
        }

        private void scissorButton_Click(object sender, EventArgs e) {
            var outcome = Game.Instance.Play(Game.Move.Scissors);

            updateView(outcome);
        }

        private void updateView(Game.Outcome outcome) {
            outcomeLabel.Text = outcome.Text;
            pictureBox1.Image = getImage(outcome.HumanMove);
            pictureBox2.Image = getImage(outcome.ComputerMove);
            humanScoreLabel.Text = Game.Instance.Score.Human.ToString();
            computerScoreLabel.Text = Game.Instance.Score.Computer.ToString();
        }

        private Bitmap getImage(Game.Move move) {
            return (Bitmap)Properties.Resources.ResourceManager.GetObject(move.ToString());
        }
    }
}
