using System.Net.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace chat
{
    public partial class Form1 : Form
    {

        int i = 1;


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Head_TextChanged(object sender, EventArgs e)
        {
            if (Input.Text.Length == 0)
            {
                Head.Text = "Bạn không nhắn gì à?";
            }

            if (Input.Text.ContainsAny("hello", "hi", "Hello"))
            {

                Head.Text = "xin chào";
            }

            if (Input.Text.ContainsAny("Riko", "riko", "rikO"))
            {

                Head.Text = "boink?";
            }
          
            if(Input.Text.ContainsAny("cong", "cộng", "trừ", "tru", "nhân", "nhan", "chia", "+","-","*","/"))
            {
                
                DialogResult dlgResult = MessageBox.Show("Vì không có thơi gian nên riko tạm dùng máy tính nhé", "Nàyyyy", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult == DialogResult.Yes)
                {
                    
                }

            }    

        }

        private void RikoEmote_Click(object sender, EventArgs e)
        {

        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Send_Click(object sender, EventArgs e)

        {
            Head.Text = String.Empty;
            Input.Text = String.Empty;




        }

        private void Input_Click(object sender, EventArgs e)
        {
            if(i == 1)
            {
                Input.Text = String.Empty;
                i = 0;
            }


        }




        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Input_KeyUp(object sender, KeyEventArgs e)
        {/*
            RichTextBox Input = ((RichTextBox)sender);
            int caretPosition = Input.SelectionStart;

            Input.Text = Input.Text.ToLower();
            Input.SelectionStart = caretPosition++;*/
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }
    }
}