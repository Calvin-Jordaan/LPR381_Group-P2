using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LPR381_GroupProject_Group_P2_V1.BusinessLogic
{
    internal class BusinessOpperations
    {
        // The following function spilts the information read from the txt file into 3 types of arrays (Objective Function, Constraints, Sign Restrictions)
        public (string[], string[], string[]) ConvertTextFormat(string txtFileData)
        {
            // The information read from the text file
            string[] data_arr = txtFileData.Split('\n');

            // Array for the objective function
            string[] objFunc_arr = new string[1];

            // Array for the constraints
            string[] const_arr = new string[data_arr.Length - 2];

            // Array for the sign restrictions
            string[] sign_arr = new string[1];

            // Assigning the values to the correct arrays
            for (int i = 0; i <= (data_arr.Length - 1); i++)
            {
                if (i == 0)
                {
                    // The objective function will be on the first row
                    objFunc_arr[0] = data_arr[i];
                }
                else if (i == (data_arr.Length - 1))
                {
                    // The sign restrictions will be last
                    sign_arr[0] = data_arr[i];
                    
                }
                else
                {
                    // The constraints come between the objective function and the sign restrictions
                    const_arr[i - 1] = data_arr[i];
                }
            }
            return (objFunc_arr, const_arr, sign_arr);
        }


        // The following functions converts a string array into a normal string
        // It is used to display the information inside the text boxes read from the txt file
        public string ConvertArrToString(string[] arr_item)
        {
            string convertedItem = "";

            for (int i = 0; i <= (arr_item.Length - 1); i++)
            {
                if (i == (arr_item.Length - 1))
                {
                    convertedItem = convertedItem + arr_item[i];
                }
                else
                {
                    convertedItem = convertedItem + arr_item[i] + "\n";
                }
            }
            return convertedItem;
        }

        // The following creates a new array for the binary values
        public (string[,], int) AddBinCon(string sign)
        {
            string[] bin_arr = sign.Split(' ');
            string[,] binCon_arr = new string[bin_arr.Length, bin_arr.Length];
            int binCount = 0;

            for (int i = 0; i <= (bin_arr.Length - 1); i++)
            {
                for (int j = 0; j <= (bin_arr.Length - 1); j++)
                {
                    if (bin_arr[i] == "bin" && i == j)
                    {
                        binCon_arr[i, j] = "1";
                        binCount++;
                    }
                    else
                    {
                        binCon_arr[i, j] = "0";
                    }
                }
            }

            return (binCon_arr, binCount);
        }

        public (double[,], int, int, string, int) GetCanonalTable(string objFunc, string con, string[,] bin_arr, string signRes, int binCount)
        {
            string[] con_arr = con.Split('\n');
            int rowLength = objFunc.Split('\n').Length + con.Split('\n').Length + binCount;
            int columnLength = (objFunc.Split(' ').Length - 1) + (con_arr.Length) + binCount + 1;
            Console.WriteLine("Objective function count: " + objFunc.Split('\n').Length);
            Console.WriteLine("Objective function count: " + con.Split('\n').Length);

            string maxorMin_func = "";

            // The following is the dimension of the canonical array
            double[,] canonical_arr = new double[rowLength, columnLength];

            Console.WriteLine("Size of the canonical array: " + canonical_arr.Length);

            for (int i = 0; i <= (rowLength - 1); i++)
            {
                for (int j = 0; j <= (columnLength - 1); j++)
                {
                    
                    if (i == 0)
                    {
                        if (objFunc.Contains("max"))
                        {
                            maxorMin_func = "max";

                            if ((j + 1) <= (objFunc.Split(' ').Length - 1))
                            {
                                canonical_arr[i, j] = - Convert.ToDouble(objFunc.Split(' ')[j + 1]);
                            }
                            else
                            {
                                canonical_arr[i, j] = 0;
                            }
                        }
                    }
                    else if ((i - 1) <= (con_arr.Length - 1))
                    {
                        if (j <= (con_arr[0].Split(' ').Length - 2))
                        {
                            canonical_arr[i, j] = Convert.ToDouble(con_arr[i-1].Split(' ')[j]);
                        }
                        else if (j == (con_arr[0].Split(' ').Length - 2 + i))
                        {
                            // This is for the s and e variables
                            int lessThan = con.IndexOf('<');
                            int greaterThan = con.IndexOf('>');

                            if (lessThan != -1 && (greaterThan == -1 || lessThan < greaterThan))
                            {
                                canonical_arr[i, j] = 1;
                                con = con.Remove(lessThan, 1);
                            }
                            else if (greaterThan != -1 && (lessThan == -1 || greaterThan < lessThan))
                            {
                                canonical_arr[i, j] = -1;
                                con = con.Remove(greaterThan, 1);
                            }
                        }
                        else if (j == columnLength - 1)
                        {
                            canonical_arr[i, j] = Convert.ToDouble(con_arr[i-1].Split(' ')[con_arr[0].Split(' ').Length - 1].Split('=')[1]);
                        }
                        else
                        {
                            canonical_arr[i, j] = 0;
                        }
                    }
                    else
                    {
                        // Currently for binary

                        if (j <= (con_arr[0].Split(' ').Length - 2) && i - (rowLength - binCount) <= (binCount - 1) && bin_arr[i - (rowLength - binCount), j] == "1")
                        {
                            canonical_arr[i, j] = 1;
                        }
                        else if (j == (con_arr[0].Split(' ').Length - 2 + i))
                        {
                            // This is for the s and e variables
                            canonical_arr[i, j] = 1;
                        }
                        else if (j == columnLength - 1)
                        {
                            canonical_arr[i, j] = 1;
                        }
                        else
                        {
                            canonical_arr[i, j] = 0;
                        }

                    }
                }
            }


            string displayTable = displayMulti(canonical_arr, rowLength);

            Console.WriteLine(displayTable);

            return (canonical_arr, rowLength, columnLength, maxorMin_func, objFunc.Split(' ').Length - 1);
        }

        public void GetOptimalTable()
        { 
        }

        public string displayMulti(double[,] multi_arr, int rowLength)
        {
            string createdTable = "";

            string columnWidth = "     ";
            for (int i = 0; i <= (rowLength - 1); i++)
            {
                for (int j = 0; j <= ((multi_arr.Length/rowLength) - 1); j++)
                {
                    createdTable = createdTable + " | " + multi_arr[i,j] + columnWidth.Substring(multi_arr[i, j].ToString().Length) + " | ";
                }

                if (i != (rowLength - 1))
                {
                    createdTable = createdTable + "\n";
                }
                
            }

            return createdTable;
        }
    }
}


