namespace ФОРМЫ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonBruh = new System.Windows.Forms.Button();
            this.labelBruh = new System.Windows.Forms.Label();
            this.buttonSayHitler = new System.Windows.Forms.Button();
            this.labelHitler = new System.Windows.Forms.Label();
            this.buttonSayAsu = new System.Windows.Forms.Button();
            this.labelApologize = new System.Windows.Forms.Label();
            this.buttonPuk = new System.Windows.Forms.Button();
            this.labelPuk = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBruh
            // 
            this.buttonBruh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBruh.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBruh.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonBruh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBruh.Location = new System.Drawing.Point(12, 12);
            this.buttonBruh.Name = "buttonBruh";
            this.buttonBruh.Size = new System.Drawing.Size(353, 183);
            this.buttonBruh.TabIndex = 0;
            this.buttonBruh.UseVisualStyleBackColor = false;
            this.buttonBruh.Click += new System.EventHandler(this.buttonSayBruh_Click);
            // 
            // labelBruh
            // 
            this.labelBruh.AutoSize = true;
            this.labelBruh.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBruh.Location = new System.Drawing.Point(371, 12);
            this.labelBruh.MinimumSize = new System.Drawing.Size(100, 100);
            this.labelBruh.Name = "labelBruh";
            this.labelBruh.Size = new System.Drawing.Size(100, 100);
            this.labelBruh.TabIndex = 1;
            // 
            // buttonSayHitler
            // 
            this.buttonSayHitler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSayHitler.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSayHitler.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonSayHitler.Location = new System.Drawing.Point(12, 201);
            this.buttonSayHitler.Name = "buttonSayHitler";
            this.buttonSayHitler.Size = new System.Drawing.Size(353, 183);
            this.buttonSayHitler.TabIndex = 2;
            this.buttonSayHitler.UseVisualStyleBackColor = false;
            this.buttonSayHitler.Click += new System.EventHandler(this.buttonSayHitler_Click);
            // 
            // labelHitler
            // 
            this.labelHitler.AutoSize = true;
            this.labelHitler.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHitler.Location = new System.Drawing.Point(371, 201);
            this.labelHitler.MinimumSize = new System.Drawing.Size(100, 100);
            this.labelHitler.Name = "labelHitler";
            this.labelHitler.Size = new System.Drawing.Size(100, 100);
            this.labelHitler.TabIndex = 3;
            // 
            // buttonSayAsu
            // 
            this.buttonSayAsu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSayAsu.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSayAsu.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonSayAsu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSayAsu.Location = new System.Drawing.Point(12, 390);
            this.buttonSayAsu.Name = "buttonSayAsu";
            this.buttonSayAsu.Size = new System.Drawing.Size(353, 183);
            this.buttonSayAsu.TabIndex = 4;
            this.buttonSayAsu.UseVisualStyleBackColor = false;
            this.buttonSayAsu.Click += new System.EventHandler(this.buttonSayAsu_Click);
            // 
            // labelApologize
            // 
            this.labelApologize.AutoSize = true;
            this.labelApologize.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApologize.Location = new System.Drawing.Point(371, 390);
            this.labelApologize.MinimumSize = new System.Drawing.Size(100, 100);
            this.labelApologize.Name = "labelApologize";
            this.labelApologize.Size = new System.Drawing.Size(100, 100);
            this.labelApologize.TabIndex = 5;
            // 
            // buttonPuk
            // 
            this.buttonPuk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPuk.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPuk.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonPuk.Image = ((System.Drawing.Image)(resources.GetObject("buttonPuk.Image")));
            this.buttonPuk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPuk.Location = new System.Drawing.Point(12, 579);
            this.buttonPuk.Name = "buttonPuk";
            this.buttonPuk.Size = new System.Drawing.Size(353, 183);
            this.buttonPuk.TabIndex = 6;
            this.buttonPuk.UseVisualStyleBackColor = false;
            this.buttonPuk.Click += new System.EventHandler(this.buttonPuk_Click);
            // 
            // labelPuk
            // 
            this.labelPuk.AutoSize = true;
            this.labelPuk.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuk.Location = new System.Drawing.Point(371, 579);
            this.labelPuk.MinimumSize = new System.Drawing.Size(100, 100);
            this.labelPuk.Name = "labelPuk";
            this.labelPuk.Size = new System.Drawing.Size(100, 100);
            this.labelPuk.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(747, 289);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(179, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 775);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPuk);
            this.Controls.Add(this.buttonPuk);
            this.Controls.Add(this.labelApologize);
            this.Controls.Add(this.buttonSayAsu);
            this.Controls.Add(this.labelHitler);
            this.Controls.Add(this.buttonSayHitler);
            this.Controls.Add(this.labelBruh);
            this.Controls.Add(this.buttonBruh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBruh;
        private System.Windows.Forms.Label labelBruh;
        private System.Windows.Forms.Button buttonSayHitler;
        private System.Windows.Forms.Label labelHitler;
        private System.Windows.Forms.Button buttonSayAsu;
        private System.Windows.Forms.Label labelApologize;
        private System.Windows.Forms.Button buttonPuk;
        private System.Windows.Forms.Label labelPuk;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

