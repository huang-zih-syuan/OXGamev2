using System.Windows.Forms;

namespace OXGame 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string playerMarker = "X";
        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text != "")
                return;
            button.Text=playerMarker;
            playerMarker = playerMarker == "X" ? "O" : "X";
            label2.Text= playerMarker;
            CheckWin();
          
        }
        private void CheckWin()
        {
            if (Check(button1,button2,button3))
            {
                return;
            }
            if (Check(button1, button4, button7))
            {
                return;
            }
            if (Check(button4, button5, button6))
            {
                return;
            }
            if (Check(button7, button8, button9))
            {
                return;
            }
            if (Check(button1, button5, button9))
            {
                return;
            }
            if (Check(button3, button5, button7))
            {
                return;
            }
            if (Check(button2, button5, button8))
            {
                return;
            }
            if (Check(button3, button6, button9))
            {
                return;
            }
        }
        private bool Check(Button btn1, Button btn2, Button btn3)
        {
            if(btn1.Text!= "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                MessageBox.Show(btn1.Text, "Winner is ");
                return true;
                
            }
            return false;
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}