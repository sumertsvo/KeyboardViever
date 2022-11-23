namespace WinFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.up = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(78, 12);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(60, 60);
            this.up.TabIndex = 0;
            this.up.Text = "up";
            this.up.UseVisualStyleBackColor = true;

            this.up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up_MouseDown);
            this.up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_MouseUp);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(12, 78);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(60, 60);
            this.left.TabIndex = 1;
            this.left.Text = "left";
            this.left.UseVisualStyleBackColor = true;

            this.left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.left_MouseDown);
            this.left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_MouseUp);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(78, 78);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(60, 60);
            this.down.TabIndex = 2;
            this.down.Text = "down";
            this.down.UseVisualStyleBackColor = true;
   
            this.down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down_MouseDown);
            this.down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_MouseUp);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(144, 78);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(60, 60);
            this.right.TabIndex = 3;
            this.right.Text = "right";
            this.right.UseVisualStyleBackColor = true;

            this.right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.right_MouseDown);
            this.right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_MouseUp);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(144, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 30);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(144, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 30);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(189, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(24, 246);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 267);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.right);
            this.Controls.Add(this.down);
            this.Controls.Add(this.left);
            this.Controls.Add(this.up);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form2_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Button up;
        private Button left;
        private Button down;
        private Button right;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private RichTextBox richTextBox1;
        private Button button9;
        private System.Windows.Forms.Timer timer1;
    }
}