namespace LPR381_GroupProject_Group_P2_V1
{
    partial class Calculator
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
            this.btn_import = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_CP = new System.Windows.Forms.RadioButton();
            this.rb_BB_Napsack = new System.Windows.Forms.RadioButton();
            this.rb_BB_Simplex = new System.Windows.Forms.RadioButton();
            this.rb_PSorDS = new System.Windows.Forms.RadioButton();
            this.txt_ObjectiveFunction = new System.Windows.Forms.TextBox();
            this.txt_Constraint = new System.Windows.Forms.TextBox();
            this.txt_SignRestriction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.dgv_Tables = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Optimize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tables)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(48, 335);
            this.btn_import.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(300, 75);
            this.btn_import.TabIndex = 0;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_CP);
            this.groupBox1.Controls.Add(this.rb_BB_Napsack);
            this.groupBox1.Controls.Add(this.rb_BB_Simplex);
            this.groupBox1.Controls.Add(this.rb_PSorDS);
            this.groupBox1.Location = new System.Drawing.Point(48, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(300, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose an algorithm:";
            // 
            // rb_CP
            // 
            this.rb_CP.AutoSize = true;
            this.rb_CP.Location = new System.Drawing.Point(20, 176);
            this.rb_CP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_CP.Name = "rb_CP";
            this.rb_CP.Size = new System.Drawing.Size(129, 24);
            this.rb_CP.TabIndex = 5;
            this.rb_CP.TabStop = true;
            this.rb_CP.Text = "Cutting Plane";
            this.rb_CP.UseVisualStyleBackColor = true;
            // 
            // rb_BB_Napsack
            // 
            this.rb_BB_Napsack.AutoSize = true;
            this.rb_BB_Napsack.Location = new System.Drawing.Point(20, 126);
            this.rb_BB_Napsack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_BB_Napsack.Name = "rb_BB_Napsack";
            this.rb_BB_Napsack.Size = new System.Drawing.Size(243, 24);
            this.rb_BB_Napsack.TabIndex = 4;
            this.rb_BB_Napsack.TabStop = true;
            this.rb_BB_Napsack.Text = "Branch and Bound (Napsack)";
            this.rb_BB_Napsack.UseVisualStyleBackColor = true;
            // 
            // rb_BB_Simplex
            // 
            this.rb_BB_Simplex.AutoSize = true;
            this.rb_BB_Simplex.Location = new System.Drawing.Point(20, 76);
            this.rb_BB_Simplex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_BB_Simplex.Name = "rb_BB_Simplex";
            this.rb_BB_Simplex.Size = new System.Drawing.Size(236, 24);
            this.rb_BB_Simplex.TabIndex = 3;
            this.rb_BB_Simplex.TabStop = true;
            this.rb_BB_Simplex.Text = "Branch and Bound (Simplex)";
            this.rb_BB_Simplex.UseVisualStyleBackColor = true;
            // 
            // rb_PSorDS
            // 
            this.rb_PSorDS.AutoSize = true;
            this.rb_PSorDS.Location = new System.Drawing.Point(20, 26);
            this.rb_PSorDS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_PSorDS.Name = "rb_PSorDS";
            this.rb_PSorDS.Size = new System.Drawing.Size(240, 24);
            this.rb_PSorDS.TabIndex = 2;
            this.rb_PSorDS.TabStop = true;
            this.rb_PSorDS.Text = "Primal Simplex / Dual Simplex";
            this.rb_PSorDS.UseVisualStyleBackColor = true;
            // 
            // txt_ObjectiveFunction
            // 
            this.txt_ObjectiveFunction.Location = new System.Drawing.Point(378, 125);
            this.txt_ObjectiveFunction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ObjectiveFunction.Name = "txt_ObjectiveFunction";
            this.txt_ObjectiveFunction.Size = new System.Drawing.Size(300, 26);
            this.txt_ObjectiveFunction.TabIndex = 2;
            // 
            // txt_Constraint
            // 
            this.txt_Constraint.Location = new System.Drawing.Point(378, 180);
            this.txt_Constraint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Constraint.Multiline = true;
            this.txt_Constraint.Name = "txt_Constraint";
            this.txt_Constraint.Size = new System.Drawing.Size(300, 88);
            this.txt_Constraint.TabIndex = 3;
            // 
            // txt_SignRestriction
            // 
            this.txt_SignRestriction.Location = new System.Drawing.Point(378, 300);
            this.txt_SignRestriction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SignRestriction.Name = "txt_SignRestriction";
            this.txt_SignRestriction.Size = new System.Drawing.Size(300, 26);
            this.txt_SignRestriction.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Objective Function";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Constraints:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sign Restrictions:";
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(378, 335);
            this.btn_Calc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(300, 75);
            this.btn_Calc.TabIndex = 8;
            this.btn_Calc.Text = "Calculate";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // dgv_Tables
            // 
            this.dgv_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tables.Location = new System.Drawing.Point(48, 465);
            this.dgv_Tables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Tables.Name = "dgv_Tables";
            this.dgv_Tables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_Tables.RowHeadersWidth = 51;
            this.dgv_Tables.RowTemplate.Height = 24;
            this.dgv_Tables.Size = new System.Drawing.Size(1012, 348);
            this.dgv_Tables.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(534, 82);
            this.label5.TabIndex = 11;
            this.label5.Text = "LPR Calculator";
            // 
            // btn_Optimize
            // 
            this.btn_Optimize.Location = new System.Drawing.Point(698, 335);
            this.btn_Optimize.Name = "btn_Optimize";
            this.btn_Optimize.Size = new System.Drawing.Size(300, 75);
            this.btn_Optimize.TabIndex = 12;
            this.btn_Optimize.Text = "button1";
            this.btn_Optimize.UseVisualStyleBackColor = true;
            this.btn_Optimize.Click += new System.EventHandler(this.btn_Optimize_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 879);
            this.Controls.Add(this.btn_Optimize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_Tables);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SignRestriction);
            this.Controls.Add(this.txt_Constraint);
            this.Controls.Add(this.txt_ObjectiveFunction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_import);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_CP;
        private System.Windows.Forms.RadioButton rb_BB_Napsack;
        private System.Windows.Forms.RadioButton rb_BB_Simplex;
        private System.Windows.Forms.RadioButton rb_PSorDS;
        private System.Windows.Forms.TextBox txt_ObjectiveFunction;
        private System.Windows.Forms.TextBox txt_Constraint;
        private System.Windows.Forms.TextBox txt_SignRestriction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.DataGridView dgv_Tables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Optimize;
    }
}