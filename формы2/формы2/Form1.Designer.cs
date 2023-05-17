namespace формы2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlus = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelDiscr = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(16, 23);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(60, 60);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 33);
            this.label1.MaximumSize = new System.Drawing.Size(100, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "x^2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelPlus
            // 
            this.labelPlus.Font = new System.Drawing.Font("Bradley Hand ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlus.Location = new System.Drawing.Point(138, 23);
            this.labelPlus.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(54, 60);
            this.labelPlus.TabIndex = 2;
            this.labelPlus.Text = "+";
            this.labelPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(198, 23);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(60, 60);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // labelB
            // 
            this.labelB.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(264, 33);
            this.labelB.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(50, 50);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "x";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 23);
            this.label2.MaximumSize = new System.Drawing.Size(100, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(380, 23);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(60, 60);
            this.textBoxC.TabIndex = 6;
            this.textBoxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // labelDiscr
            // 
            this.labelDiscr.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscr.Location = new System.Drawing.Point(12, 253);
            this.labelDiscr.Name = "labelDiscr";
            this.labelDiscr.Size = new System.Drawing.Size(500, 100);
            this.labelDiscr.TabIndex = 7;
            this.labelDiscr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(22, 117);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(444, 79);
            this.buttonCalc.TabIndex = 8;
            this.buttonCalc.Text = "CALCULATE";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 656);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelDiscr);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelDiscr;
        private System.Windows.Forms.Button buttonCalc;
    }
}

