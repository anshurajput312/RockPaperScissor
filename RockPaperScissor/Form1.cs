namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        public string[] Choice = { "Rock", "Paper", "Scissor" };
        int pscore = 0;
        int cscore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                txtWinner.Text = "Ties!!!";
            }

            if (pChoice == "Paper" && cChoice == "Rock")
            {
                txtWinner.Text = "Player wins!!!";
                pscore++;
                lblscorep.Text = pscore.ToString();
            }
            if (pChoice == "Rock" && cChoice == "Scissor")
            {
                txtWinner.Text = "Player wins!!!";
                pscore++;
                lblscorep.Text = pscore.ToString();
            }
            if (pChoice == "Scissor" && cChoice == "Paper")
            {
                txtWinner.Text = "Player wins!!!";
                pscore++;
                lblscorep.Text = pscore.ToString();
            }

            if (cChoice == "Paper" && pChoice == "Rock")
            {
                txtWinner.Text = "Computer wins!!!";
                cscore++;
                lblscorec.Text = cscore.ToString();
            }
            if (cChoice == "Rock" && pChoice == "Scissor")
            {
                txtWinner.Text = "Computer wins!!!";
                cscore++;
                lblscorec.Text = cscore.ToString();
            }
            if (cChoice == "Scissor" && pChoice == "Paper")
            {
                txtWinner.Text = "Computer wins!!!";
                cscore++;
                lblscorec.Text = cscore.ToString();
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
            //  player1Index = 0;
            GetWinner(0);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            //player1Index = 1;
            GetWinner(1);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            //player1Index = 2;
            GetWinner(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblc.Text = "";
            lblP.Text = "";
            txtWinner.Text = "";
            pctBxP.Text = "";
            pctBxc.Text = "";
            lblscorep.Text = "";
            lblscorec.Text = "";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblscorep_Click(object sender, EventArgs e)
        {

        }

        private void lblscorec_Click(object sender, EventArgs e)
        {

        }



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    player1Index = 0;
        //    computerIndex = new Random().Next(0, 3);


        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    player1Index = 0;
        //    computerIndex = new Random().Next(0, 3);
        //}
    }
}
