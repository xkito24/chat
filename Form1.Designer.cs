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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Head = new System.Windows.Forms.RichTextBox();
            this.RikoEmote = new System.Windows.Forms.PictureBox();
            this.Send = new System.Windows.Forms.Button();
            this.playSMC = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Topic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RikoEmote)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::chat.Properties.Resources.wallpp;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::chat.Properties.Resources.blank;
            this.pictureBox2.Location = new System.Drawing.Point(-10, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 341);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Head
            // 
            this.Head.Location = new System.Drawing.Point(125, 174);
            this.Head.Name = "Head";
            this.Head.ReadOnly = true;
            this.Head.Size = new System.Drawing.Size(247, 132);
            this.Head.TabIndex = 2;
            this.Head.Text = "Hỏi Riko-chan bất kì thứ gì, Riko sẽ trả lời bạn!!( miễn là cô ấy biết)";
            this.Head.TextChanged += new System.EventHandler(this.Head_TextChanged);
            // 
            // RikoEmote
            // 
            this.RikoEmote.Location = new System.Drawing.Point(12, 183);
            this.RikoEmote.Name = "RikoEmote";
            this.RikoEmote.Size = new System.Drawing.Size(100, 91);
            this.RikoEmote.TabIndex = 3;
            this.RikoEmote.TabStop = false;
            this.RikoEmote.Click += new System.EventHandler(this.RikoEmote_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(12, 355);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 4;
            this.Send.Text = "Gửi";
            this.Send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // playSMC
            // 
            this.playSMC.Location = new System.Drawing.Point(12, 384);
            this.playSMC.Name = "playSMC";
            this.playSMC.Size = new System.Drawing.Size(75, 23);
            this.playSMC.TabIndex = 5;
            this.playSMC.Text = "Chơi SMC";
            this.playSMC.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 442);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(125, 356);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(247, 80);
            this.Input.TabIndex = 7;
            this.Input.Text = "Nhắn cho Riko-chan 1 thứ gì đó...";
            this.Input.Click += new System.EventHandler(this.Input_Click);
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            this.Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            this.Input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_KeyUp);
            // 
            // Topic
            // 
            this.Topic.Location = new System.Drawing.Point(12, 413);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(75, 23);
            this.Topic.TabIndex = 8;
            this.Topic.Text = "Topic";
            this.Topic.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 485);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.playSMC);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.RikoEmote);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RikoEmote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RichTextBox Head;
        private PictureBox RikoEmote;
        private Button Send;
        private Button playSMC;
        private Button Exit;
        private RichTextBox Input;
        private Button Topic;
    }
}