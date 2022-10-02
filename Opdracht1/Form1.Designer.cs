namespace Opdracht1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(381, 167);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(50, 20);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "label1";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(369, 202);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 35);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "button1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb1;
        private Button bt1;
    }
}