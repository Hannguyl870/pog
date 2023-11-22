namespace pog
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
            this.components = new System.ComponentModel.Container();
            this.p1scorelable = new System.Windows.Forms.Label();
            this.p2scorelable = new System.Windows.Forms.Label();
            this.winlable = new System.Windows.Forms.Label();
            this.gamertimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // p1scorelable
            // 
            this.p1scorelable.AutoSize = true;
            this.p1scorelable.ForeColor = System.Drawing.Color.Snow;
            this.p1scorelable.Location = new System.Drawing.Point(338, 9);
            this.p1scorelable.Name = "p1scorelable";
            this.p1scorelable.Size = new System.Drawing.Size(14, 16);
            this.p1scorelable.TabIndex = 0;
            this.p1scorelable.Text = "0";
            // 
            // p2scorelable
            // 
            this.p2scorelable.AutoSize = true;
            this.p2scorelable.ForeColor = System.Drawing.Color.Snow;
            this.p2scorelable.Location = new System.Drawing.Point(437, 9);
            this.p2scorelable.Name = "p2scorelable";
            this.p2scorelable.Size = new System.Drawing.Size(14, 16);
            this.p2scorelable.TabIndex = 1;
            this.p2scorelable.Text = "0";
            // 
            // winlable
            // 
            this.winlable.ForeColor = System.Drawing.Color.Snow;
            this.winlable.Location = new System.Drawing.Point(338, 152);
            this.winlable.Name = "winlable";
            this.winlable.Size = new System.Drawing.Size(115, 28);
            this.winlable.TabIndex = 2;
            // 
            // gamertimer
            // 
            this.gamertimer.Enabled = true;
            this.gamertimer.Interval = 20;
            this.gamertimer.Tick += new System.EventHandler(this.gamertimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winlable);
            this.Controls.Add(this.p2scorelable);
            this.Controls.Add(this.p1scorelable);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1scorelable;
        private System.Windows.Forms.Label p2scorelable;
        private System.Windows.Forms.Label winlable;
        private System.Windows.Forms.Timer gamertimer;
    }
}

