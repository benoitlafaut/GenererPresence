namespace GenererPresence
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
            monthCalendar1 = new MonthCalendar();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            RTB1 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 32);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(18, 206);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(227, 499);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(251, 206);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(228, 499);
            listBox2.TabIndex = 2;
            listBox2.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(257, 32);
            button1.Name = "button1";
            button1.Size = new Size(113, 51);
            button1.TabIndex = 3;
            button1.Text = "Générate text";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RTB1
            // 
            RTB1.Location = new Point(408, 32);
            RTB1.Name = "RTB1";
            RTB1.Size = new Size(322, 538);
            RTB1.TabIndex = 4;
            RTB1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(408, 576);
            button2.Name = "button2";
            button2.Size = new Size(113, 51);
            button2.TabIndex = 5;
            button2.Text = "Save in Clipboard";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(260, 134);
            button3.Name = "button3";
            button3.Size = new Size(110, 46);
            button3.TabIndex = 6;
            button3.Text = "Open Input Tireurs";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(260, 193);
            button4.Name = "button4";
            button4.Size = new Size(110, 46);
            button4.TabIndex = 7;
            button4.Text = "Recharger";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 754);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(RTB1);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private RichTextBox RTB1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
