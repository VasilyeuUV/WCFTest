
namespace ServerOnWindowsForms
{
    partial class MainForm
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
            this.tbMain = new System.Windows.Forms.TextBox();
            this.btnSeverStart = new System.Windows.Forms.Button();
            this.btnServerStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMain.Location = new System.Drawing.Point(12, 12);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.ReadOnly = true;
            this.tbMain.Size = new System.Drawing.Size(358, 193);
            this.tbMain.TabIndex = 0;
            // 
            // btnSeverStart
            // 
            this.btnSeverStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeverStart.Location = new System.Drawing.Point(12, 211);
            this.btnSeverStart.Name = "btnSeverStart";
            this.btnSeverStart.Size = new System.Drawing.Size(137, 38);
            this.btnSeverStart.TabIndex = 1;
            this.btnSeverStart.Text = "Server Start";
            this.btnSeverStart.UseVisualStyleBackColor = true;
            // 
            // btnServerStop
            // 
            this.btnServerStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServerStop.Location = new System.Drawing.Point(233, 211);
            this.btnServerStop.Name = "btnServerStop";
            this.btnServerStop.Size = new System.Drawing.Size(137, 38);
            this.btnServerStop.TabIndex = 2;
            this.btnServerStop.Text = "Server Stop";
            this.btnServerStop.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.btnServerStop);
            this.Controls.Add(this.btnSeverStart);
            this.Controls.Add(this.tbMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Button btnSeverStart;
        private System.Windows.Forms.Button btnServerStop;
    }
}

