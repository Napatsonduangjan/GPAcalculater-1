namespace GPA.TT
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxGPA_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGPAx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMAXGPA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMINGPA = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxGPA_input
            // 
            this.textBoxGPA_input.Location = new System.Drawing.Point(187, 39);
            this.textBoxGPA_input.Name = "textBoxGPA_input";
            this.textBoxGPA_input.Size = new System.Drawing.Size(150, 31);
            this.textBoxGPA_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "GPA INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "GPAx";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxGPAx
            // 
            this.textBoxGPAx.Location = new System.Drawing.Point(155, 53);
            this.textBoxGPAx.Name = "textBoxGPAx";
            this.textBoxGPAx.Size = new System.Drawing.Size(150, 31);
            this.textBoxGPAx.TabIndex = 4;
            this.textBoxGPAx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxMINGPA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxMAXGPA);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxGPAx);
            this.groupBox1.Location = new System.Drawing.Point(37, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 239);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUTPUT";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "MAX GPA";
            // 
            // textBoxMAXGPA
            // 
            this.textBoxMAXGPA.Location = new System.Drawing.Point(155, 104);
            this.textBoxMAXGPA.Name = "textBoxMAXGPA";
            this.textBoxMAXGPA.Size = new System.Drawing.Size(150, 31);
            this.textBoxMAXGPA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "MIN GPA";
            // 
            // textBoxMINGPA
            // 
            this.textBoxMINGPA.Location = new System.Drawing.Point(155, 165);
            this.textBoxMINGPA.Name = "textBoxMINGPA";
            this.textBoxMINGPA.Size = new System.Drawing.Size(150, 31);
            this.textBoxMINGPA.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGPA_input);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBoxGPA_input;
        private Label label1;
        private Label label2;
        private TextBox textBoxGPAx;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBoxMINGPA;
        private Label label3;
        private TextBox textBoxMAXGPA;
        private Button button2;
    }
}