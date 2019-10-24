namespace ThreeTierMgtSystem_1701_02_17_09_19_
{
    partial class Hash_SHA_256
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_SaltHash_TextBox = new System.Windows.Forms.TextBox();
            this.m_UserInput_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_SaltSHA256Hash_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plain Text: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salt :";
            // 
            // m_SaltHash_TextBox
            // 
            this.m_SaltHash_TextBox.Location = new System.Drawing.Point(112, 91);
            this.m_SaltHash_TextBox.Name = "m_SaltHash_TextBox";
            this.m_SaltHash_TextBox.Size = new System.Drawing.Size(416, 22);
            this.m_SaltHash_TextBox.TabIndex = 3;
            // 
            // m_UserInput_TextBox
            // 
            this.m_UserInput_TextBox.Location = new System.Drawing.Point(112, 50);
            this.m_UserInput_TextBox.Name = "m_UserInput_TextBox";
            this.m_UserInput_TextBox.Size = new System.Drawing.Size(416, 22);
            this.m_UserInput_TextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hash SHA-256";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // m_SaltSHA256Hash_TextBox
            // 
            this.m_SaltSHA256Hash_TextBox.Location = new System.Drawing.Point(112, 131);
            this.m_SaltSHA256Hash_TextBox.Name = "m_SaltSHA256Hash_TextBox";
            this.m_SaltSHA256Hash_TextBox.Size = new System.Drawing.Size(416, 22);
            this.m_SaltSHA256Hash_TextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hash :";
            // 
            // Hash_SHA_256
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 218);
            this.Controls.Add(this.m_SaltSHA256Hash_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_UserInput_TextBox);
            this.Controls.Add(this.m_SaltHash_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Hash_SHA_256";
            this.Text = "Hash_SHA_256";
            this.Load += new System.EventHandler(this.Hash_SHA_256_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_SaltHash_TextBox;
        private System.Windows.Forms.TextBox m_UserInput_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_SaltSHA256Hash_TextBox;
        private System.Windows.Forms.Label label4;
    }
}