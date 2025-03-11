namespace lab2_task2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textC = new TextBox();
            textB = new TextBox();
            textA = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(575, 120);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 138);
            label2.Name = "label2";
            label2.Size = new Size(238, 20);
            label2.TabIndex = 1;
            label2.Text = "Введите сумму денег на счёте A: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 205);
            label3.Name = "label3";
            label3.Size = new Size(445, 20);
            label3.TabIndex = 2;
            label3.Text = "Введите необходимую величину ежемесячного увеличения B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 277);
            label4.Name = "label4";
            label4.Size = new Size(376, 20);
            label4.TabIndex = 3;
            label4.Text = "Введите сумму C, которую нужно превысить вкладу: ";
            // 
            // button1
            // 
            button1.Location = new Point(235, 346);
            button1.Name = "button1";
            button1.Size = new Size(119, 41);
            button1.TabIndex = 4;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textC
            // 
            textC.Location = new Point(181, 300);
            textC.Name = "textC";
            textC.Size = new Size(238, 27);
            textC.TabIndex = 5;
            // 
            // textB
            // 
            textB.Location = new Point(181, 228);
            textB.Name = "textB";
            textB.Size = new Size(238, 27);
            textB.TabIndex = 6;
            // 
            // textA
            // 
            textA.Location = new Point(181, 161);
            textA.Name = "textA";
            textA.Size = new Size(238, 27);
            textA.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(textA);
            Controls.Add(textB);
            Controls.Add(textC);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Калькулятор денег";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textC;
        private TextBox textB;
        private TextBox textA;
    }
}
