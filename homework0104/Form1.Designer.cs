
namespace homework0104
{
    partial class enteringform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backwall = new System.Windows.Forms.GroupBox();
            this.start = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backwall.SuspendLayout();
            this.SuspendLayout();
            // 
            // backwall
            // 
            this.backwall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backwall.Controls.Add(this.nametextBox);
            this.backwall.Controls.Add(this.namelabel);
            this.backwall.Controls.Add(this.start);
            this.backwall.Location = new System.Drawing.Point(0, 0);
            this.backwall.Name = "backwall";
            this.backwall.Size = new System.Drawing.Size(804, 453);
            this.backwall.TabIndex = 0;
            this.backwall.TabStop = false;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(302, 262);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(149, 69);
            this.start.TabIndex = 0;
            this.start.Text = "START!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(268, 185);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(96, 17);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Введите имя:";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(382, 185);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 2;
            // 
            // enteringform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backwall);
            this.Name = "enteringform";
            this.Text = "enteringform";
            this.backwall.ResumeLayout(false);
            this.backwall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox backwall;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Button start;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

