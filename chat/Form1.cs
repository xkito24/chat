using System.Net.Security;
using Microsoft.VisualBasic;
namespace chat
{
    public partial class Form1 : Form
    {
        
        int bond = 51;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // hệ thống bond sẽ phụ thuộc vào việc người dùng hỏi gì từ đó tăng và giảm 
        // nếu người dùng nhập bất kì chứ có chứa trong ContainsAny thì bot sẽ trả lời lại
        
        private void Head_TextChanged(object sender, EventArgs e)
        { // core
            if (Input.Text.Length == 0)
            {
                if (bond >50) { Head.Text = "Chắc là bạn quên nhập gì rồi"; bond = bond - 4; rikobond.Text = bond.ToString(); }
                if (bond <= 50) { Head.Text = "Bạn không nhắn gì à?"; bond = bond - 4 ; rikobond.Text = bond.ToString();  }
                if (bond < 45) { Head.Text = "Oiii không đùa đó nha"; bond = bond - 10; rikobond.Text = bond.ToString(); }
                if (bond < 30) { Head.Text = "Riko không thích ai đó ấn nút gửi mà không có chữ liên tục như vậy"; bond = bond - 10; rikobond.Text = bond.ToString(); }


            }

            if (Input.Text.ContainsAny("hello", "hi", "xin chào", "chào", "có ai không", "hú", "co ai khong", "hello riko", "hi riko" ))
            {
                if (bond > 70) { Head.Text = "Riko-chan chào bạn nha"; bond = bond + 5; rikobond.Text = bond.ToString(); }
                 if (bond >= 50 && bond <= 70){ Head.Text = "Xin chào"; bond = bond + 5; rikobond.Text = bond.ToString();} 
                if(bond < 50) { Head.Text = "Chào"; bond = bond + 5; rikobond.Text = bond.ToString(); }
             }

            if (Input.Text.ContainsAny(" nay riko", "này riko", "hey riko", "riko nay", "riko này", "riko nay"))
            {
                if (bond > 70) { Head.Text = "Riko-chan đây,  có điều gì muốn nói với riko à"; rikobond.Text = bond.ToString(); }
                if (bond >= 50 && bond <= 70 ){ Head.Text = "Riko đây"; rikobond.Text = bond.ToString(); }
                if ( bond < 50) { Head.Text = "Có gì không"; rikobond.Text = bond.ToString(); }
            }
            if (Input.Text.ContainsAny("cong", "cộng", "trừ", "tru", "nhân", "nhan", "chia", "+", "-", "*", "/", "math"))
            {
                if (bond > 50) { 
                DialogResult dlgResult = MessageBox.Show("Vì không có thơi gian nên riko tạm dùng máy tính nhé", "Nàyyyy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlgResult == DialogResult.Yes)
                    {
                        this.Hide();
                        rikocalc f2 = new rikocalc();
                        f2.ShowDialog();
                        this.Show();
                        Head.Text = "Hello, chắc bạn đã tính xong rồi nhỉ";
                    }
                }
                else
                {
                    Head.Text = "Máy tính là của Riko, bạn không được dùng";
                }    
            }
            
            //cheat test hệ thống bond
            if (Input.Text.Contains("ntddeptrai")) { bond = 120; Head.Text= "bạn đã cheat bond"; rikobond.Text = bond.ToString(); }
            if (Input.Text.Contains("ntdxautrai")) { bond = 1; Head.Text = "bạn đã cheat bond"; rikobond.Text = bond.ToString(); }
            // giới hạn số bond
            if (bond < 0) { bond = 0; rikobond.Text = bond.ToString(); }
            if (bond > 120) { bond = 120; rikobond.Text = bond.ToString(); }
            // nếu bond ở mức 0
            if (bond == 0 ) {
                DialogResult  Getout = MessageBox.Show("Riko chan đã ghét bạn, nên đã đuổi bạn đi", "byeeeee", MessageBoxButtons.OK, MessageBoxIcon.Hand); 
               if(Getout == DialogResult.OK)
                this.Close() ; 
            }
        }
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
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
        int i = 1;
        private void Input_Click(object sender, EventArgs e)
        { // ấn vào để clear phần input 1 lần 
            if (i == 1)
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
        {

        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        { 
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }

        private void rikobond_TextChanged(object sender, EventArgs e)
        {
            
            
        }

    }
}