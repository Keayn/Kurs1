
namespace Kyrsovai
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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbPower = new System.Windows.Forms.TrackBar();
            this.lblPower = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(913, 386);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(12, 420);
            this.tbSpreading.Maximum = 359;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(170, 45);
            this.tbSpreading.TabIndex = 2;
            this.tbSpreading.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(189, 420);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 13);
            this.lblDirection.TabIndex = 3;
            // 
            // tbPower
            // 
            this.tbPower.Location = new System.Drawing.Point(244, 420);
            this.tbPower.Maximum = 325;
            this.tbPower.Minimum = 125;
            this.tbPower.Name = "tbPower";
            this.tbPower.Size = new System.Drawing.Size(170, 45);
            this.tbPower.TabIndex = 4;
            this.tbPower.Value = 125;
            this.tbPower.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(402, 420);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(0, 13);
            this.lblPower.TabIndex = 5;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(504, 420);
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(104, 45);
            this.tbSpeed.TabIndex = 6;
            this.tbSpeed.Value = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(668, 420);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(121, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 466);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.tbPower);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Частица";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbPower;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

