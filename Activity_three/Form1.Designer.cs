namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Brazil = new System.Windows.Forms.CheckBox();
            this.Japan = new System.Windows.Forms.CheckBox();
            this.Singapore = new System.Windows.Forms.CheckBox();
            this.Korea = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Others = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(18, 20);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(105, 31);
            this.Username.TabIndex = 1;
            this.Username.Text = "Survey";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "What country would you like to go?";
            // 
            // Brazil
            // 
            this.Brazil.AutoSize = true;
            this.Brazil.Location = new System.Drawing.Point(24, 99);
            this.Brazil.Name = "Brazil";
            this.Brazil.Size = new System.Drawing.Size(51, 17);
            this.Brazil.TabIndex = 3;
            this.Brazil.Text = "Brazil";
            this.Brazil.UseVisualStyleBackColor = true;
            this.Brazil.CheckedChanged += new System.EventHandler(this.Brazil_CheckedChanged);
            // 
            // Japan
            // 
            this.Japan.AutoSize = true;
            this.Japan.Location = new System.Drawing.Point(24, 122);
            this.Japan.Name = "Japan";
            this.Japan.Size = new System.Drawing.Size(55, 17);
            this.Japan.TabIndex = 4;
            this.Japan.Text = "Japan";
            this.Japan.UseVisualStyleBackColor = true;
            this.Japan.CheckedChanged += new System.EventHandler(this.Japan_CheckedChanged);
            // 
            // Singapore
            // 
            this.Singapore.AutoSize = true;
            this.Singapore.Location = new System.Drawing.Point(211, 99);
            this.Singapore.Name = "Singapore";
            this.Singapore.Size = new System.Drawing.Size(74, 17);
            this.Singapore.TabIndex = 5;
            this.Singapore.Text = "Singapore";
            this.Singapore.UseVisualStyleBackColor = true;
            this.Singapore.CheckedChanged += new System.EventHandler(this.Singapore_CheckedChanged);
            // 
            // Korea
            // 
            this.Korea.AutoSize = true;
            this.Korea.Location = new System.Drawing.Point(211, 122);
            this.Korea.Name = "Korea";
            this.Korea.Size = new System.Drawing.Size(54, 17);
            this.Korea.TabIndex = 6;
            this.Korea.Text = "Korea";
            this.Korea.UseVisualStyleBackColor = true;
            this.Korea.CheckedChanged += new System.EventHandler(this.Korea_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "If others, Please specify.";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(22, 222);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(178, 20);
            this.textbox.TabIndex = 8;
            this.textbox.Visible = false;
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(154, 258);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(75, 46);
            this.Submitbtn.TabIndex = 9;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(250, 258);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 46);
            this.Close.TabIndex = 10;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Others
            // 
            this.Others.AutoSize = true;
            this.Others.Location = new System.Drawing.Point(24, 162);
            this.Others.Name = "Others";
            this.Others.Size = new System.Drawing.Size(57, 17);
            this.Others.TabIndex = 11;
            this.Others.Text = "Others";
            this.Others.UseVisualStyleBackColor = true;
            this.Others.CheckedChanged += new System.EventHandler(this.Others_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 316);
            this.Controls.Add(this.Others);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Korea);
            this.Controls.Add(this.Singapore);
            this.Controls.Add(this.Japan);
            this.Controls.Add(this.Brazil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Brazil;
        private System.Windows.Forms.CheckBox Japan;
        private System.Windows.Forms.CheckBox Singapore;
        private System.Windows.Forms.CheckBox Korea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.CheckBox Others;
    }
}

