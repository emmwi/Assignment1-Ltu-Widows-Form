namespace cashRegistry
{
    partial class CashRegistryForm1
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(60, 121);
            label1.Name = "label1";
            label1.Size = new Size(70, 36);
            label1.TabIndex = 0;
            label1.Text = "Pris";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(60, 255);
            label2.Name = "label2";
            label2.Size = new Size(143, 36);
            label2.TabIndex = 1;
            label2.Text = "Betalning";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(64, 0, 0);
            textBox1.Location = new Point(60, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 44);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            textBox2.ForeColor = Color.FromArgb(64, 0, 0);
            textBox2.Location = new Point(60, 299);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(342, 44);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(60, 410);
            button1.Name = "button1";
            button1.Size = new Size(342, 77);
            button1.TabIndex = 4;
            button1.Text = "Räkna";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BackColor = SystemColors.Info;
            listBox1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            listBox1.ForeColor = Color.FromArgb(64, 0, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 36;
            listBox1.Location = new Point(506, 165);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(567, 472);
            listBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(64, 0, 0);
            button2.Location = new Point(791, 708);
            button2.Name = "button2";
            button2.Size = new Size(282, 70);
            button2.TabIndex = 6;
            button2.Text = "Avsluta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CashRegistryForm1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1157, 883);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CashRegistryForm1";
            Text = "CashRegsitryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
    }
}
