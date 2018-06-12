namespace NullifyInArray
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
            this.fillButton = new System.Windows.Forms.Button();
            this.nullifyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countUpDown = new System.Windows.Forms.NumericUpDown();
            this.fillTextBox = new System.Windows.Forms.TextBox();
            this.arrayListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(157, 220);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(75, 23);
            this.fillButton.TabIndex = 0;
            this.fillButton.Text = "Ввести";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // nullifyButton
            // 
            this.nullifyButton.Location = new System.Drawing.Point(157, 310);
            this.nullifyButton.Name = "nullifyButton";
            this.nullifyButton.Size = new System.Drawing.Size(75, 23);
            this.nullifyButton.TabIndex = 2;
            this.nullifyButton.Text = "Обнулити";
            this.nullifyButton.UseVisualStyleBackColor = true;
            this.nullifyButton.Click += new System.EventHandler(this.nullifyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Масив:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кількість елементів";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введіть елемент";
            // 
            // countUpDown
            // 
            this.countUpDown.Location = new System.Drawing.Point(157, 121);
            this.countUpDown.Name = "countUpDown";
            this.countUpDown.Size = new System.Drawing.Size(75, 20);
            this.countUpDown.TabIndex = 7;
            this.countUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fillTextBox
            // 
            this.fillTextBox.Location = new System.Drawing.Point(157, 194);
            this.fillTextBox.Name = "fillTextBox";
            this.fillTextBox.Size = new System.Drawing.Size(75, 20);
            this.fillTextBox.TabIndex = 8;
            this.fillTextBox.TextChanged += new System.EventHandler(this.fillTextBox_TextChanged);
            // 
            // arrayListBox
            // 
            this.arrayListBox.FormattingEnabled = true;
            this.arrayListBox.Location = new System.Drawing.Point(15, 75);
            this.arrayListBox.Name = "arrayListBox";
            this.arrayListBox.Size = new System.Drawing.Size(120, 303);
            this.arrayListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 394);
            this.Controls.Add(this.arrayListBox);
            this.Controls.Add(this.fillTextBox);
            this.Controls.Add(this.countUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nullifyButton);
            this.Controls.Add(this.fillButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button nullifyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countUpDown;
        private System.Windows.Forms.TextBox fillTextBox;
        private System.Windows.Forms.ListBox arrayListBox;
    }
}

