using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LPR381_GroupProject_Group_P2_V1.DataLayer;
using LPR381_GroupProject_Group_P2_V1.BusinessLogic;

namespace LPR381_GroupProject_Group_P2_V1
{
    public partial class Calculator : Form
    {
        DataHandler dh = new DataHandler();
        BusinessOpperations bo = new BusinessOpperations();
        

        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            // The file dialog willl be used to import the information from the text file to the program
            OpenFileDialog ofd = new OpenFileDialog();

            // Gives a title the opened dialog box
            ofd.Title = "Open Text File";

            // Filters the files to only allow the user to add a text file
            ofd.Filter = "Text File|*.txt";

            // The following shows the file dialog
            // The following checks if the user opened a file
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // ----- Note if only the name is wanted we can use ofd.SafeFileName

                // Call the read function to read the selectedd text file.

                string text = dh.ReadTextFile(ofd.FileName);

                // The following formats the text file data into the proper arrays
                var (objectiveFunction_arr, constraints_arr, sign_arr) = bo.ConvertTextFormat(text);

                // Transfer array info to text boxes
                txt_ObjectiveFunction.Text = objectiveFunction_arr[0];
                txt_SignRestriction.Text = sign_arr[0];

                // There can be multiple constraints the function helps convert the array into a string.
                txt_Constraint.Text = bo.ConvertArrToString(constraints_arr);
                

            }
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            string objFunc = txt_ObjectiveFunction.Text.TrimEnd('\r', '\n');
            string constraints = txt_Constraint.Text.TrimEnd('\r', '\n');
            string signRes = txt_SignRestriction.Text.TrimEnd('\r', '\n');

            // The following creates all the possible binary constraints
            var (bin_arr, binCount) = bo.AddBinCon(signRes);

            var (canonical_table, table_row_count, table_column_count, func_type, var_count) = bo.GetCanonalTable(objFunc, constraints, bin_arr, signRes, binCount);

            dgv_Tables.Rows.Clear();

            dgv_Tables.ColumnCount = table_column_count + 1;

            

            for (int i = 0; i <= (table_row_count); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv_Tables);

                for (int j = 0; j <= table_column_count; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            row.Cells[j].Value = "Table" + 1;
                        }
                        else
                        {
                            if (j <= var_count)
                            {
                                row.Cells[j].Value = "x" + j;
                            }
                            else if (j == table_column_count)
                            {
                                row.Cells[j].Value = "RHS";
                            }
                            else
                            {
                                row.Cells[j].Value = "s" + (j - var_count) + "/" + "e" + (j - var_count);
                            }
                        }
                        
                    }
                    else
                    {
                        if (j == 0)
                        {
                            if (i == 1)
                            {
                                if (func_type == "max")
                                {
                                    row.Cells[j].Value = "max z";
                                }
                                else if (func_type == "min")
                                {
                                    row.Cells[j].Value = "min z";
                                }
                                else
                                {
                                    row.Cells[j].Value = "N/A";
                                }
                            }
                            else
                            {
                                row.Cells[j].Value = "Constraint " + (i - 1);
                            }
                        }
                        else
                        {
                            row.Cells[j].Value = canonical_table[i - 1, j - 1];
                        }
                        
                    }
                    
                }

                dgv_Tables.Rows.Add(row);
                
            }
        }
    }
}
