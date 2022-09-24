namespace chat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Head = new System.Windows.Forms.RichTextBox();
            this.RikoEmote = new System.Windows.Forms.PictureBox();
            this.Send = new System.Windows.Forms.Button();
            this.playSMC = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.rikobond = new System.Windows.Forms.TextBox();
            this.bondshow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RikoEmote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::chat.Properties.Resources.wallpp;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Head
            // 
            this.Head.BackColor = System.Drawing.Color.Azure;
            this.Head.ForeColor = System.Drawing.Color.Black;
            this.Head.Location = new System.Drawing.Point(23, 194);
            this.Head.Name = "Head";
            this.Head.ReadOnly = true;
            this.Head.Size = new System.Drawing.Size(184, 118);
            this.Head.TabIndex = 1;
            this.Head.Text = "Hỏi Riko-chan bất kì thứ gì, Riko sẽ trả lời bạn!!( miễn là cô ấy biết)";
            this.Head.TextChanged += new System.EventHandler(this.Head_TextChanged);
            // 
            // RikoEmote
            // 
            this.RikoEmote.Location = new System.Drawing.Point(254, 194);
            this.RikoEmote.Name = "RikoEmote";
            this.RikoEmote.Size = new System.Drawing.Size(116, 118);
            this.RikoEmote.TabIndex = 3;
            this.RikoEmote.TabStop = false;
            this.RikoEmote.Click += new System.EventHandler(this.RikoEmote_Click);
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.Transparent;
            this.Send.BackgroundImage = global::chat.Properties.Resources.mail;
            this.Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Send.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Send.ForeColor = System.Drawing.Color.Black;
            this.Send.Location = new System.Drawing.Point(233, 374);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(78, 62);
            this.Send.TabIndex = 4;
            this.Send.Text = "Gửi";
            this.Send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // playSMC
            // 
            this.playSMC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playSMC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playSMC.Image = global::chat.Properties.Resources.toolbutton;
            this.playSMC.Location = new System.Drawing.Point(5, 450);
            this.playSMC.Name = "playSMC";
            this.playSMC.Size = new System.Drawing.Size(107, 35);
            this.playSMC.TabIndex = 5;
            this.playSMC.Text = "Công cụ Riko";
            this.playSMC.UseVisualStyleBackColor = true;
            this.playSMC.Click += new System.EventHandler(this.playSMC_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.Image = global::chat.Properties.Resources.exitbutton;
            this.Exit.Location = new System.Drawing.Point(324, 450);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(58, 35);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.Azure;
            this.Input.Location = new System.Drawing.Point(23, 322);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(184, 105);
            this.Input.TabIndex = 7;
            this.Input.Text = "Nhắn cho Riko-chan 1 thứ gì đó...\n(ấn vào đây để bắt đầu)";
            this.Input.Click += new System.EventHandler(this.Input_Click);
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            this.Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            this.Input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_KeyUp);
            // 
            // rikobond
            // 
            this.rikobond.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rikobond.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.rikobond.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rikobond.Location = new System.Drawing.Point(324, 395);
            this.rikobond.Name = "rikobond";
            this.rikobond.ReadOnly = true;
            this.rikobond.Size = new System.Drawing.Size(75, 25);
            this.rikobond.TabIndex = 9;
            this.rikobond.TextChanged += new System.EventHandler(this.rikobond_TextChanged);
            // 
            // bondshow
            // 
            this.bondshow.AutoSize = true;
            this.bondshow.BackColor = System.Drawing.Color.White;
            this.bondshow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bondshow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bondshow.ForeColor = System.Drawing.Color.Navy;
            this.bondshow.Location = new System.Drawing.Point(317, 374);
            this.bondshow.Name = "bondshow";
            this.bondshow.Size = new System.Drawing.Size(93, 16);
            this.bondshow.TabIndex = 10;
            this.bondshow.Text = "Độ thân thiết";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 455);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Azure;
            this.pictureBox2.Image = global::chat.Properties.Resources.frameriko;
            this.pictureBox2.Location = new System.Drawing.Point(2, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 143);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::chat.Properties.Resources.frameriko;
            this.pictureBox3.Location = new System.Drawing.Point(2, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 151);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::chat.Properties.Resources.blank;
            this.pictureBox4.Location = new System.Drawing.Point(-3, 173);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(418, 271);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::chat.Properties.Resources.fr;
            this.pictureBox5.Location = new System.Drawing.Point(245, 183);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(137, 129);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chat.Properties.Resources.formwall;
            this.ClientSize = new System.Drawing.Size(410, 485);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bondshow);
            this.Controls.Add(this.rikobond);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.playSMC);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.RikoEmote);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Riko chat BOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RikoEmote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox Head;
        private PictureBox RikoEmote;
        private Button Send;
        private Button playSMC;
        private Button Exit;
        private RichTextBox Input;
        private TextBox rikobond;
        private Label bondshow;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}