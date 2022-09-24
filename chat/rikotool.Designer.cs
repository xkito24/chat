namespace chat
{
    partial class rikotool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rikotool));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tool1 = new System.Windows.Forms.Button();
            this.tool3 = new System.Windows.Forms.Button();
            this.tool4 = new System.Windows.Forms.Button();
            this.tool2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::chat.Properties.Resources.rikotool;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hãy chọn thứ bạn cần";
            // 
            // tool1
            // 
            this.tool1.Location = new System.Drawing.Point(160, 33);
            this.tool1.Name = "tool1";
            this.tool1.Size = new System.Drawing.Size(75, 23);
            this.tool1.TabIndex = 2;
            this.tool1.Text = "Chơi SMC";
            this.tool1.UseVisualStyleBackColor = true;
            this.tool1.Click += new System.EventHandler(this.tool1_Click);
            // 
            // tool3
            // 
            this.tool3.Location = new System.Drawing.Point(160, 84);
            this.tool3.Name = "tool3";
            this.tool3.Size = new System.Drawing.Size(75, 23);
            this.tool3.TabIndex = 3;
            this.tool3.Text = "Máy Tính";
            this.tool3.UseVisualStyleBackColor = true;
            this.tool3.Click += new System.EventHandler(this.tool3_Click);
            // 
            // tool4
            // 
            this.tool4.Location = new System.Drawing.Point(316, 84);
            this.tool4.Name = "tool4";
            this.tool4.Size = new System.Drawing.Size(75, 23);
            this.tool4.TabIndex = 4;
            this.tool4.Text = "Thoát";
            this.tool4.UseVisualStyleBackColor = true;
            this.tool4.Click += new System.EventHandler(this.tool4_Click);
            // 
            // tool2
            // 
            this.tool2.Location = new System.Drawing.Point(316, 33);
            this.tool2.Name = "tool2";
            this.tool2.Size = new System.Drawing.Size(75, 23);
            this.tool2.TabIndex = 5;
            this.tool2.Text = "Chơi Caro";
            this.tool2.UseVisualStyleBackColor = true;
            this.tool2.Click += new System.EventHandler(this.tool2_Click);
            // 
            // rikotool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chat.Properties.Resources.blank;
            this.ClientSize = new System.Drawing.Size(439, 129);
            this.Controls.Add(this.tool2);
            this.Controls.Add(this.tool4);
            this.Controls.Add(this.tool3);
            this.Controls.Add(this.tool1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rikotool";
            this.Text = "Riko Tool";
            this.Load += new System.EventHandler(this.rikotool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button tool1;
        private Button tool3;
        private Button tool4;
        private Button tool2;
    }
}