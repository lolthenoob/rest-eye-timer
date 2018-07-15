namespace timerProject
{
    partial class Form2
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
            this.SECcheckBoxFar = new System.Windows.Forms.CheckBox();
            this.SECcheckBoxNear = new System.Windows.Forms.CheckBox();
            this.SECbtnDone = new System.Windows.Forms.Button();
            this.SECtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SECcheckBoxFar
            // 
            this.SECcheckBoxFar.AutoSize = true;
            this.SECcheckBoxFar.Location = new System.Drawing.Point(58, 67);
            this.SECcheckBoxFar.Name = "SECcheckBoxFar";
            this.SECcheckBoxFar.Size = new System.Drawing.Size(240, 17);
            this.SECcheckBoxFar.TabIndex = 0;
            this.SECcheckBoxFar.Text = "Look at a object 20 feet away for 20 seconds";
            this.SECcheckBoxFar.UseVisualStyleBackColor = true;
            // 
            // SECcheckBoxNear
            // 
            this.SECcheckBoxNear.AutoSize = true;
            this.SECcheckBoxNear.Location = new System.Drawing.Point(58, 117);
            this.SECcheckBoxNear.Name = "SECcheckBoxNear";
            this.SECcheckBoxNear.Size = new System.Drawing.Size(287, 17);
            this.SECcheckBoxNear.TabIndex = 1;
            this.SECcheckBoxNear.Text = "Look at a object less than 1 metre away for 20 seconds";
            this.SECcheckBoxNear.UseVisualStyleBackColor = true;
            // 
            // SECbtnDone
            // 
            this.SECbtnDone.Location = new System.Drawing.Point(146, 196);
            this.SECbtnDone.Name = "SECbtnDone";
            this.SECbtnDone.Size = new System.Drawing.Size(75, 23);
            this.SECbtnDone.TabIndex = 2;
            this.SECbtnDone.Text = "All Done";
            this.SECbtnDone.UseVisualStyleBackColor = true;
            this.SECbtnDone.Click += new System.EventHandler(this.SECbtnDone_Click);
            // 
            // SECtimer
            // 
            this.SECtimer.Interval = 1000;
            this.SECtimer.Tick += new System.EventHandler(this.SECtimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 231);
            this.Controls.Add(this.SECbtnDone);
            this.Controls.Add(this.SECcheckBoxNear);
            this.Controls.Add(this.SECcheckBoxFar);
            this.Name = "Form2";
            this.Text = "Confirmation Eye Exercise";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SECcheckBoxFar;
        private System.Windows.Forms.CheckBox SECcheckBoxNear;
        private System.Windows.Forms.Button SECbtnDone;
        public System.Windows.Forms.Timer SECtimer;
    }
}