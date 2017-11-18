namespace Perceptron
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.labWeights = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labLr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Location = new System.Drawing.Point(12, 60);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(689, 311);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // labWeights
            // 
            this.labWeights.AutoSize = true;
            this.labWeights.Location = new System.Drawing.Point(21, 9);
            this.labWeights.Name = "labWeights";
            this.labWeights.Size = new System.Drawing.Size(0, 13);
            this.labWeights.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(364, -2);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(192, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // labLr
            // 
            this.labLr.AutoSize = true;
            this.labLr.Location = new System.Drawing.Point(562, 9);
            this.labLr.Name = "labLr";
            this.labLr.Size = new System.Drawing.Size(13, 13);
            this.labLr.TabIndex = 3;
            this.labLr.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Learning rate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labLr);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.labWeights);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Perceptron example";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label labWeights;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labLr;
        private System.Windows.Forms.Label label2;
    }
}

