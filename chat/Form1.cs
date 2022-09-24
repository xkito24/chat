using System;
using System.Diagnostics;
using System.Net.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace chat
{
    public partial class Form1 : Form
    {
        // c = câu hỏi mặc định
        // sc = câu hỏi thường gặp
        int bond = 51;
        string user = "bạn";
        int c1 = 1; // câu hỏi tên
        string rslt = "";
        int sc = 0; // hỏi sức khỏe
        int sc1 = 0; // hỏi thời tiết
        int ssc = 0; // đã biết thời tiết
        int sc2 = 0;
        int c2 = 1;
        int blockempty = 0;
   
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
        {
            // core---------------------------------------------------------------------------------------------------
            // công thức in text ra sẽ là  In text > tính số bond > hiện số bond > biểu cảm (gán giá trị cho câu hỏi nếu có)
            //------------------------------------------------------------------------------------------------------

            // làm quen

            if (Input.Text.ContainsAny("làm quen", "lam quen") && c2 == 1)
            {
                if (bond > 40)
                {
                    Head.Text = "Được chứ, Riko sẽ làm quen với " + user; bond = bond + 5; rikobond.Text = bond.ToString(); c2 = 0;
                    if (c1 == 1)
                    {
                        RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoaim.png");
                        rslt = Interaction.InputBox("Bạn muốn riko gọi bạn là gì?", "Nhập tên", "Nhập tên bạn vào đây");
                        user = rslt;
        
                        Head.Text = "Vậy riko sẽ gọi bạn là " + user;
                        c1 = 0;
                        c2 = 0;

                    }
                }
                else
                {
                    Head.Text = "Riko không muốn làm quen với người lạ"; bond = bond + 2; rikobond.Text = bond.ToString();
                }
            }
            else
            if (Input.Text.ContainsAny("làm quen ", "lam quen"))
            { Head.Text = "Riko đã làm quen với bạn rồi"; }
            


                //sức khỏe
                if (Input.Text.ContainsAny("khỏe không", "khỏe ko", "khoe ko", "khoe khong", "how are you?", "how are you"))
            {
                if (bond > 50)
                {
                    if (sc == 0)
                    {
                        Head.Text = " Riko vẫn khỏe đó" +
                            " Còn bạn thì sao"; bond = bond + 5; rikobond.Text = bond.ToString();
                        Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikolove.png");

                    }
                    else
                    { Head.Text = " Riko vẫn khỏe đó"; bond = bond + 5; rikobond.Text = bond.ToString(); Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikolove.png"); }

                }
                else
                    Head.Text = user + "và Riko không thân với nhau"; rikobond.Text = bond.ToString();  Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogaze.png"); 

            }


            if (Input.Text.ContainsAny("khỏe chứ", "khoe chu", "vẫn khỏe", "van khỏe", "tôi khỏe", user + "khỏe", "mình khỏe", "toi khoe") && sc == 0)
            {
                Head.Text = " thật tuyệt khi " + user + " vẫn khỏe"; bond = bond + 5; rikobond.Text = bond.ToString();
                sc++;
                Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogo.png");
            }
            // empty input
            if (Input.Text.Length == 0 && blockempty == 0 )
            {
                if (bond > 50) { Head.Text = "Chắc là bạn quên nhập gì rồi"; bond = bond - 4; rikobond.Text = bond.ToString(); Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoconfuse.png"); }
                if (bond <= 50) { Head.Text = "Bạn không nhắn gì à?"; bond = bond - 4; rikobond.Text = bond.ToString(); RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikostun.png"); }
                if (bond < 45) { Head.Text = "Oiii không đùa đó nha"; bond = bond - 10; rikobond.Text = bond.ToString(); RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikostun.png"); }
                if (bond < 30) { Head.Text = "Riko không thích ai đó ấn nút gửi mà không có chữ liên tục như vậy"; bond = bond - 10; rikobond.Text = bond.ToString(); Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikorun.png"); }


            }
            // xin chào
            if (Input.Text.ContainsAny("hello", "hi", "xin chào", "chào", "có ai không", "hú", "co ai khong", "hello riko", "hi riko", "helo"))
            {
                if (bond > 70) { Head.Text = "Riko-chan chào " + user + " nha"; bond = bond + 5; rikobond.Text = bond.ToString(); }
                if (bond >= 50 && bond <= 70)
                {
                    RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoaim.png");
                    Head.Text = "Xin chào " +
                       "nhân tiện cho Riko biết tên bạn nhé  "; bond = bond + 5; rikobond.Text = bond.ToString();
                }
                if (bond < 50) { Head.Text = "Chào"; bond = bond + 5; rikobond.Text = bond.ToString(); }
                if (c1 == 1)

                {

                    rslt = Interaction.InputBox("Bạn muốn riko gọi bạn là gì?", "Nhập tên", "Nhập tên bạn vào đây");
                    user = rslt;
                    Head.Text = "Vậy riko sẽ gọi bạn là " + user;
                    c1 = 0;

                }
            } // hỏi tên
            if (Input.Text.ContainsAny("what is your name?", "what's your name", "what's your name? ", "what's your name ?", "what is your name?", "ten ban la gi", "tên bạn là gì", "ban ten gi", "bạn tên gì", "tên bạn là gì", "ban ten gi?", "bạn tên gì?", "tên bạn là gì", "ban ten gi ?", "bạn tên gì ?", "em ten gi", "em ten gi?", "em ten gi ?", "em tên gì ?", "em tên gì", "em tên gì?"))
            {
                if (bond > 0 && bond < 120) { Head.Text = "Tên của mình là Riko"; }
                if (c1 == 1)
                {
                    RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoaim.png");
                    rslt = Interaction.InputBox("Bạn muốn riko gọi bạn là gì?", "Nhập tên", "Nhập tên bạn vào đây");
                    user = rslt;
                    Head.Text = "Vậy riko sẽ gọi bạn là " + user;
                    c1 = 0;
                }
            }
            if (Input.Text.ContainsAny(" nay riko", "này riko", "hey riko", "riko nay", "riko này", "riko nay"))
            {
                if (bond > 70) { Head.Text = "Riko-chan đây, " + user + " có điều gì muốn nói với riko à"; rikobond.Text = bond.ToString(); RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogo.png"); }
                if (bond >= 50 && bond <= 70) { Head.Text = "Riko đây"; rikobond.Text = bond.ToString(); RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogo.png"); }
                if (bond < 50) { Head.Text = "Có gì không"; rikobond.Text = bond.ToString(); RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogaze.png"); }
            }
            // máy tính riko
            if (Input.Text.ContainsAny("cong", "cộng", "trừ", "tru", "nhân", "nhan", "chia", "+", "-", "*", "/", "math"))
            {
                if (bond > 50)
                {
                    DialogResult dlgResult = MessageBox.Show("Vì không có thơi gian nên riko tạm dùng máy tính nhé", "Nàyyyy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlgResult == DialogResult.Yes)
                    {
                        blockempty = 1;
                        this.Hide();
                        rikocalc f2 = new rikocalc();
                        f2.ShowDialog();
                        this.Show();
                        bond = bond + 5;
                        Head.Text = "Hello, chắc bạn đã tính xong rồi nhỉ";
                        RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoaim.png");
                    }
                }
                else
                {
                    Head.Text = "Máy tính là của Riko, bạn không được dùng";

                }
            } 
            // câu hỏi tư topic
            // riko thời tiết

            if (Input.Text.ContainsAny("thời tiết", "thoi tiet") && ssc == 1) { Head.Text = "Có lẽ Riko đã biết thời tiết rồi, trông hay thật ấy"; }
            if (Input.Text.ContainsAny("thời tiết", "thoi tiet") && ssc == 0)
            {
                RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoconfuse.png");
                if (bond > 90) { Head.Text = "Riko rất muốn biết ở bên ngoài như thế nào " + user + " có thể kể cho Riko biết không"; bond = bond + 5; rikobond.Text = bond.ToString(); }
                if (bond > 50) { Head.Text = "Riko không biết thời tiết bên ngoài thế nào, vậy " + user + " biết chứ"; bond = bond + 5; rikobond.Text = bond.ToString(); }
                if (bond < 50) { Head.Text = "Bên ngoài trông như thế nào ?"; bond = bond + 5; rikobond.Text = bond.ToString(); }
            }
            //trời xấu
            if (Input.Text.ContainsAny("troi ko dep", "troi khong dep", "trời ko đẹp", "trời không đẹp", "trời xấu", "troi xau") && sc1 == 0)
            { Head.Text = "ra là vậy, có vẻ bên ngoài không như riko tưởng tượng"; rikobond.Text = bond.ToString(); ssc = 1; sc1 = 1; RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikocry.png"); }
           // trời đẹp
            if (Input.Text.ContainsAny("troi dep", "troi xanh", "trời  đẹp", "trời xanh", "trời mưa", "troi mua", "trời trong xanh", "troi trong xanh") && sc1 == 0)
  { Head.Text = "Không ngờ bên ngoài trông như vậy, Riko cũng muốn xem"; bond = bond + 10; rikobond.Text = bond.ToString(); ssc = 1; sc1 = 1; RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikolove.png"); }

            // cái này chặn việc người dùng nhập bậy bạ
            if (Input.CanFocus && rslt != user)
            {
                Input.Focus();
                if (bond > 90) { Head.Text = "Riko không hiểu"; bond = bond - 5; rikobond.Text = bond.ToString(); RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoconfuse.png"); }
                if (bond > 50) { Head.Text = "Riko không hiểu bạn nói gì"; bond = bond - 5; rikobond.Text = bond.ToString(); RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikostun.png"); }
                if (bond < 30) { Head.Text = "Bạn viết cái gì vậy"; bond = bond - 5; rikobond.Text = bond.ToString(); RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogaze.png"); }
            }

            // tán gẫu ngẫu nhiên
            if (Input.Text.ContainsAny("muốn nói chuyện", "tám chuyện", "noi chuyen", "topic"))
            {
                if (bond > 45 )
                {   
                    Random rnd = new Random();
                    int rn = rnd.Next(1, 10);
                    bond = bond + 10; rikobond.Text = bond.ToString();
                    if (rn == 2) { Head.Text = " Riko là 1 Vtuber, thường xuất hiện trong các sự kiện của SMC"; RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoaim.png"); }
                    if (rn == 3) { Head.Text = "SMC là 1 game rất hay đó " + user + " biết chứ, tuy ít người chơi nhưng trải nghiệm rất tuyệt"; RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogo.png"); }
                    if (rn == 4) { Head.Text = "Riko rất muốn lái 1 chiếc Mecha, có lẽ Riko 1 ngày nào đó sẽ có cơ hội lái 1 chiếc"; RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoaim.png"); }
                    if (rn == 5) { Head.Text = "Riko chỉ là nhân vật bị chôm bởi Nguyễn Thanh Dũng và sử dụng cho mục đích làm đồ án"; RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogaze.png"); }
                    if (rn == 6) { Head.Text = "Hệ thống bond của riko sẽ tăng giảm tùy vào những gì người dùng hỏi, cái này ý tưởng từ Yakuza Kiwami 1"; }
                    if (rn == 7) { Head.Text = "Tác giả rất muốn thêm vài tính nào vào cho Riko, nhưng có vẻ 2 cái đồ án và ví tiền siêu hạn hẹp khiến Tác giả không có nhiều thời gian cho lắm(hoặc đây là lười)"; RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikostun.png"); }
                    if (rn == 8) { Head.Text = "GIáo Viên Hutech cực đỉnh"; RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogo.png"); }
                    if (rn == 9) { Head.Text = "Có lẽ sau khi chấm đồ án, tác giả sẽ tự quyết định có phát triển tiếp không (khả năng cao là không)"; RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogaze.png"); }
                }
                else
                    Head.Text = "Riko không muốn nói chuyện với bạn";
            }    
            // hỏi ngày giờ
            if(Input.Text.ContainsAny("mấy giờ", "may gio", "may h", "mấy h", "what time", "mấy giờ?", "may gio", "mấy h?", "may h?", "ngày bao nhiêu", "ngay bao nhieu", "ngày bao nhiêu ?", "ngay bao nhieu ?"))
            {
                if (bond > 45)
                {
                    DateTime d = new DateTime();
                    d = DateTime.Now;
                    RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogo.png");
                    Head.Text = d.ToString(" HH:mm:ss" + "dd.MM.yyyy"); bond = bond + 4; rikobond.Text = bond.ToString();
                }
                else
                { Head.Text = user + "có đồng hồ, tự đi mà coi"; RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikorun.png"); }    
            }

            //cheat test hệ thống bond
            if (Input.Text.Contains("ntddeptrai")) { bond = 120; Head.Text = "bạn đã cheat tăng bond"; rikobond.Text = bond.ToString(); }
            if (Input.Text.Contains("ntdxautrai")) { bond = 1; Head.Text = "bạn đã cheat giảm bond"; rikobond.Text = bond.ToString(); }
            // giới hạn số bond
            if (bond < 0) { bond = 0; rikobond.Text = bond.ToString(); }
            if (bond > 120) { bond = 120; rikobond.Text = bond.ToString(); }
            // nếu bond ở mức 0
            if (bond == 0)
            {
                DialogResult Getout = MessageBox.Show("Riko chan đã ghét bạn, nên đã đuổi bạn đi", "byeeeee", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (Getout == DialogResult.OK)
                    this.Close();
            }
        }
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        private void RikoEmote_Click(object sender, EventArgs e)
        {
          RikoEmote.SizeMode = PictureBoxSizeMode.StretchImage;
            /* RikoEmote.Image = null;
             RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoaim.png");
             RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoconfuse.png");
             RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikocry.png");
             RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogaze.png");
             RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikogo.png");
             RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikolove.png");
             RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikorun.png");
             RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikostun.png");
           */
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
            blockempty = 0;
            Head.Text = String.Empty;
                Input.Text = String.Empty;
            



        }
        int i = 1;
        private void Input_Click(object sender, EventArgs e)
        { // ấn vào để clear phần input 1 lần 
            rikobond.Text = bond.ToString();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // thử nghiệm chức năng cooldown và nó fail
        }

        private void Topic_Click(object sender, EventArgs e)
        {

        
        }

        private void playSMC_Click(object sender, EventArgs e)
        {

            blockempty = 1;
            this.Hide();
            rikotool f3 = new rikotool();
            f3.ShowDialog();   
            Head.Text = "Riko xin lỗi " + user + "nhiều vì thời gian phát triển ngắn nên không có nhiều công cụ";
            RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikocry.png");
            bond = bond + 5;
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }
    }
}