namespace OXGame 
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 30);
            button1.Name = "button1";
            button1.Size = new Size(124, 120);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(166, 30);
            button2.Name = "button2";
            button2.Size = new Size(124, 120);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(296, 29);
            button3.Name = "button3";
            button3.Size = new Size(124, 120);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(34, 156);
            button4.Name = "button4";
            button4.Size = new Size(124, 120);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(166, 156);
            button5.Name = "button5";
            button5.Size = new Size(124, 120);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(294, 155);
            button6.Name = "button6";
            button6.Size = new Size(124, 120);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button2_Click;
            // 
            // button7
            // 
            button7.Location = new Point(34, 282);
            button7.Name = "button7";
            button7.Size = new Size(124, 120);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button2_Click;
            // 
            // button8
            // 
            button8.Location = new Point(166, 282);
            button8.Name = "button8";
            button8.Size = new Size(124, 120);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button2_Click;
            // 
            // button9
            // 
            button9.Location = new Point(294, 282);
            button9.Name = "button9";
            button9.Size = new Size(124, 120);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(477, 30);
            label1.Name = "label1";
            label1.Size = new Size(137, 50);
            label1.TabIndex = 10;
            label1.Text = "Player";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.IBeam;
            label2.Font = new Font("Microsoft JhengHei UI", 64F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(477, 94);
            label2.Name = "label2";
            label2.Size = new Size(128, 135);
            label2.TabIndex = 11;
            label2.Text = "X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 429);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Tic-Tac-Toe Game, by S1125566";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label label2;
    }
}