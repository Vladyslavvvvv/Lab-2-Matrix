using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_Matrix
{
    public partial class Matrix : Form
    {
        private Random random = new Random();

        public Matrix()
        {
            InitializeComponent();
        }

        private int SumOfRowsWithNegativeElements(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool hasNegative = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }
                if (hasNegative)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }

        private string FindSaddlePoints(int[,] matrix)
        {
            string saddlePoints = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int value = matrix[i, j];
                    bool isSaddlePoint = true;

                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (value < matrix[i, k])
                        {
                            isSaddlePoint = false;
                            break;
                        }
                    }

                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        if (value > matrix[k, j])
                        {
                            isSaddlePoint = false;
                            break;
                        }
                    }

                    if (isSaddlePoint)
                    {
                        saddlePoints += $"({i + 1}, {j + 1})";
                    }
                }
            }

            return saddlePoints;
        }

        private void GenerateMatrix(int rows, int columns, int min, int max)
        {
            int[,] matrix = new int[rows, columns];
            string matrixDisplay = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(min, max);
                    matrixDisplay += matrix[i, j].ToString().PadRight(5);
                }
                matrixDisplay += "\n";
            }

            labelMatrix.Text = matrixDisplay;

            int sum = SumOfRowsWithNegativeElements(matrix);
            labelSum.Text = $"Sum of elements in rows with negative elements: {sum}";

            string saddlePoints = FindSaddlePoints(matrix);
            labelSaddle.Text = $"Saddle point found at: {saddlePoints}\t";
        }

        private void buttonCreateMatrix_Click(object sender, EventArgs e)
        {
            bool rowsValid = int.TryParse(textBoxRows.Text, out int rows);
            bool columnsValid = int.TryParse(textBoxColumns.Text, out int columns);
            bool minValid = int.TryParse(textBoxMinElement.Text, out int min);
            bool maxValid = int.TryParse(textBoxMaxElement.Text, out int max);

            if (!rowsValid || !columnsValid || !minValid || !maxValid || rows <= 0 || columns <= 0)
            {
                MessageBox.Show("Enter only whole numbers in all fields. The number of rows and columns elements cannot be negative or zero.");
                return;
            }

            GenerateMatrix(rows, columns, min, max);
        }
    }
}