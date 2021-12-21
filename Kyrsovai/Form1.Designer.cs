
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.tbPower = new System.Windows.Forms.TrackBar();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.tbTick = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.lblRaz = new System.Windows.Forms.Label();
            this.tbPow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(10, 527);
            this.tbSpreading.Maximum = 359;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(170, 45);
            this.tbSpreading.TabIndex = 2;
            this.tbSpreading.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // tbPower
            // 
            this.tbPower.Location = new System.Drawing.Point(197, 527);
            this.tbPower.Maximum = 325;
            this.tbPower.Minimum = 125;
            this.tbPower.Name = "tbPower";
            this.tbPower.Size = new System.Drawing.Size(170, 45);
            this.tbPower.TabIndex = 4;
            this.tbPower.Value = 125;
            this.tbPower.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(388, 527);
            this.tbSpeed.Maximum = 20;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(182, 45);
            this.tbSpeed.TabIndex = 6;
            this.tbSpeed.Value = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll_1);
            // 
            // tbTick
            // 
            this.tbTick.Location = new System.Drawing.Point(620, 527);
            this.tbTick.Maximum = 100;
            this.tbTick.Minimum = 10;
            this.tbTick.Name = "tbTick";
            this.tbTick.Size = new System.Drawing.Size(152, 45);
            this.tbTick.TabIndex = 7;
            this.tbTick.Value = 10;
            this.tbTick.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(18, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Разброс ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Радиус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Скорость";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Частицы в тик";
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(10, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(913, 488);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.Click += new System.EventHandler(this.picDisplay_Click);
            // 
            // lblRaz
            // 
            this.lblRaz.AutoSize = true;
            this.lblRaz.Location = new System.Drawing.Point(126, 507);
            this.lblRaz.Name = "lblRaz";
            this.lblRaz.Size = new System.Drawing.Size(0, 13);
            this.lblRaz.TabIndex = 12;
            // 
            // tbPow
            // 
            this.tbPow.AutoSize = true;
            this.tbPow.Location = new System.Drawing.Point(316, 506);
            this.tbPow.Name = "tbPow";
            this.tbPow.Size = new System.Drawing.Size(0, 13);
            this.tbPow.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 575);
            this.Controls.Add(this.tbPow);
            this.Controls.Add(this.lblRaz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTick);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbPower);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "-";
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.TrackBar tbPower;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.TrackBar tbTick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Label lblRaz;
        private System.Windows.Forms.Label tbPow;
    }
}

