namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        public string[] Choice = { "Rock", "Paper", "Scissor" };
        int pScore = 0;
        int cScore = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public void GetWinner(int i)
        {
            var computerIndex = new Random().Next(0, 3);
            pctBxP.Image = Image.FromFile(GetPicture(i));
            pctBxc.Image = Image.FromFile(GetPicture(computerIndex));
            var pChoice = Choice[i];
            lblP.Text = pChoice;
            var cChoice = Choice[computerIndex];
            lblc.Text = cChoice;
            if (pChoice == cChoice)
            {
                txtWinner.Text = "Tie!!!";
            }
            if (pChoice == "Paper" && cChoice == "Rock")
            {
                txtWinner.Text = "You wins!!!";
                pScore++;
                lblscorep.Text = pScore.ToString();
            }
            if (pChoice == "Rock" && cChoice == "Scissor")
            {
                txtWinner.Text = "You wins!!!";
                pScore++;
                lblscorep.Text = pScore.ToString();
            }
            if (pChoice == "Scissor" && cChoice == "Paper")
            {
                txtWinner.Text = "You wins!!!";
                pScore++;
                lblscorep.Text = pScore.ToString();
            }

            if (cChoice == "Paper" && pChoice == "Rock")
            {
                txtWinner.Text = "Computer wins!!!";
                cScore++;
                lblscorec.Text = cScore.ToString();
            }
            if (cChoice == "Rock" && pChoice == "Scissor")
            {
                txtWinner.Text = "Computer wins!!!";
                cScore++;
                lblscorec.Text = cScore.ToString();
            }
            if (cChoice == "Scissor" && pChoice == "Paper")
            {
                txtWinner.Text = "Computer wins!!!";
                cScore++;
                lblscorec.Text = cScore.ToString();
            }
        }

        private string GetPicture(int i)
        {
            switch (i)
            {
                case 0:
                    return "rock.png";
                case 1:
                    return "paper.png";
                case 2:
                    return "scissor.png";
                default:
                    return "";

            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            GetWinner(0);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            GetWinner(1);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            GetWinner(2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            lblc.Text = "";
            lblP.Text = "";
            txtWinner.Text = "";
            pctBxP.Text = "";
            pctBxc.Text = "";
            lblscorep.Text = "0";
            lblscorec.Text = "0";
        }
    }
}
