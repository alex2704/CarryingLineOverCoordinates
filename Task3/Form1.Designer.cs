namespace Task3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.Transfer_btn = new System.Windows.Forms.Button();
            this.draw_myCurve_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Clear_btn = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.Clear_btn);
            this.panel.Controls.Add(this.Transfer_btn);
            this.panel.Controls.Add(this.draw_myCurve_btn);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(966, 100);
            this.panel.TabIndex = 0;
            // 
            // Transfer_btn
            // 
            this.Transfer_btn.Location = new System.Drawing.Point(287, 20);
            this.Transfer_btn.Name = "Transfer_btn";
            this.Transfer_btn.Size = new System.Drawing.Size(230, 61);
            this.Transfer_btn.TabIndex = 1;
            this.Transfer_btn.Text = "перенести прямую";
            this.Transfer_btn.UseVisualStyleBackColor = true;
            this.Transfer_btn.Click += new System.EventHandler(this.Transfer_btn_Click);
            // 
            // draw_myCurve_btn
            // 
            this.draw_myCurve_btn.Location = new System.Drawing.Point(20, 20);
            this.draw_myCurve_btn.Name = "draw_myCurve_btn";
            this.draw_myCurve_btn.Size = new System.Drawing.Size(215, 61);
            this.draw_myCurve_btn.TabIndex = 0;
            this.draw_myCurve_btn.Text = "нарисовать кривую";
            this.draw_myCurve_btn.UseVisualStyleBackColor = true;
            this.draw_myCurve_btn.Click += new System.EventHandler(this.draw_myCurve_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(585, 20);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(187, 61);
            this.Clear_btn.TabIndex = 2;
            this.Clear_btn.Text = "Очистить";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 561);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button draw_myCurve_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Transfer_btn;
        private System.Windows.Forms.Button Clear_btn;
    }
}

