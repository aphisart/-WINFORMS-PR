namespace gwint_prototype
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
            this.hand = new System.Windows.Forms.PictureBox();
            this.playerSiege = new System.Windows.Forms.PictureBox();
            this.playerRange = new System.Windows.Forms.PictureBox();
            this.playerClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSiege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerClose)).BeginInit();
            this.SuspendLayout();
            // 
            // hand
            // 
            this.hand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hand.Location = new System.Drawing.Point(12, 665);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(960, 84);
            this.hand.TabIndex = 0;
            this.hand.TabStop = false;
            this.hand.Paint += new System.Windows.Forms.PaintEventHandler(this.hand_Paint);
            this.hand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hand_MouseDown);
            // 
            // playerSiege
            // 
            this.playerSiege.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerSiege.Location = new System.Drawing.Point(318, 561);
            this.playerSiege.Name = "playerSiege";
            this.playerSiege.Size = new System.Drawing.Size(654, 84);
            this.playerSiege.TabIndex = 1;
            this.playerSiege.TabStop = false;
            this.playerSiege.Paint += new System.Windows.Forms.PaintEventHandler(this.playerSiege_Paint);
            this.playerSiege.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerSiege_MouseDown);
            // 
            // playerRange
            // 
            this.playerRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerRange.Location = new System.Drawing.Point(318, 471);
            this.playerRange.Name = "playerRange";
            this.playerRange.Size = new System.Drawing.Size(654, 84);
            this.playerRange.TabIndex = 2;
            this.playerRange.TabStop = false;
            this.playerRange.Paint += new System.Windows.Forms.PaintEventHandler(this.playerRange_Paint);
            this.playerRange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerRange_MouseDown);
            // 
            // playerClose
            // 
            this.playerClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerClose.Location = new System.Drawing.Point(318, 381);
            this.playerClose.Name = "playerClose";
            this.playerClose.Size = new System.Drawing.Size(654, 84);
            this.playerClose.TabIndex = 3;
            this.playerClose.TabStop = false;
            this.playerClose.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            this.playerClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.playerClose);
            this.Controls.Add(this.playerRange);
            this.Controls.Add(this.playerSiege);
            this.Controls.Add(this.hand);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSiege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hand;
        private System.Windows.Forms.PictureBox playerSiege;
        private System.Windows.Forms.PictureBox playerRange;
        private System.Windows.Forms.PictureBox playerClose;
    }
}

