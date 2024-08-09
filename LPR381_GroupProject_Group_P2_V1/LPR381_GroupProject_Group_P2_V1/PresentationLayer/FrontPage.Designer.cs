namespace LPR381_GroupProject_Group_P2_V1
{
    partial class Front_Page
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
            this.btn_startCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_startCalc
            // 
            this.btn_startCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_startCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startCalc.Location = new System.Drawing.Point(245, 564);
            this.btn_startCalc.Name = "btn_startCalc";
            this.btn_startCalc.Size = new System.Drawing.Size(500, 50);
            this.btn_startCalc.TabIndex = 0;
            this.btn_startCalc.Text = "Start Calculating";
            this.btn_startCalc.UseVisualStyleBackColor = true;
            this.btn_startCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 69);
            this.label5.TabIndex = 12;
            this.label5.Text = "LPR Calculator";
            // 
            // Front_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_startCalc);
            this.Name = "Front_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Front Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startCalc;
        private System.Windows.Forms.Label label5;
    }
}

