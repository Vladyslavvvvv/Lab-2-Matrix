namespace Lab_2_Matrix
{
    partial class Matrix
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.buttonCreateMatrix = new System.Windows.Forms.Button();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMinElement = new System.Windows.Forms.TextBox();
            this.textBoxMaxElement = new System.Windows.Forms.TextBox();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelSaddle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrix";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRows.Location = new System.Drawing.Point(710, 110);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(198, 29);
            this.labelRows.TabIndex = 2;
            this.labelRows.Text = "Number of rows";
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumns.Location = new System.Drawing.Point(710, 10);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(239, 29);
            this.labelColumns.TabIndex = 3;
            this.labelColumns.Text = "Number of columns";
            // 
            // buttonCreateMatrix
            // 
            this.buttonCreateMatrix.AutoSize = true;
            this.buttonCreateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateMatrix.Location = new System.Drawing.Point(710, 400);
            this.buttonCreateMatrix.Name = "buttonCreateMatrix";
            this.buttonCreateMatrix.Size = new System.Drawing.Size(199, 39);
            this.buttonCreateMatrix.TabIndex = 4;
            this.buttonCreateMatrix.Text = "Create a matrix";
            this.buttonCreateMatrix.UseVisualStyleBackColor = true;
            this.buttonCreateMatrix.Click += new System.EventHandler(this.buttonCreateMatrix_Click);
            // 
            // textBoxRows
            // 
            this.textBoxRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRows.Location = new System.Drawing.Point(720, 150);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(100, 34);
            this.textBoxRows.TabIndex = 5;
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxColumns.Location = new System.Drawing.Point(720, 50);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(100, 34);
            this.textBoxColumns.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(710, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "The min element";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(710, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "The max element";
            // 
            // textBoxMinElement
            // 
            this.textBoxMinElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinElement.Location = new System.Drawing.Point(720, 250);
            this.textBoxMinElement.Name = "textBoxMinElement";
            this.textBoxMinElement.Size = new System.Drawing.Size(100, 34);
            this.textBoxMinElement.TabIndex = 9;
            // 
            // textBoxMaxElement
            // 
            this.textBoxMaxElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxElement.Location = new System.Drawing.Point(720, 350);
            this.textBoxMaxElement.Name = "textBoxMaxElement";
            this.textBoxMaxElement.Size = new System.Drawing.Size(100, 34);
            this.textBoxMaxElement.TabIndex = 10;
            // 
            // labelMatrix
            // 
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMatrix.Location = new System.Drawing.Point(10, 50);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(186, 20);
            this.labelMatrix.TabIndex = 11;
            this.labelMatrix.Text = "Here will be your matrix";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(10, 420);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(421, 20);
            this.labelSum.TabIndex = 13;
            this.labelSum.Text = "Sum of elements in rows with negative elements:";
            // 
            // labelSaddle
            // 
            this.labelSaddle.AutoSize = true;
            this.labelSaddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSaddle.Location = new System.Drawing.Point(10, 390);
            this.labelSaddle.Name = "labelSaddle";
            this.labelSaddle.Size = new System.Drawing.Size(187, 20);
            this.labelSaddle.TabIndex = 14;
            this.labelSaddle.Text = "Saddle point found at";
            // 
            // Matrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.labelSaddle);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelMatrix);
            this.Controls.Add(this.textBoxMaxElement);
            this.Controls.Add(this.textBoxMinElement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxColumns);
            this.Controls.Add(this.textBoxRows);
            this.Controls.Add(this.buttonCreateMatrix);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.label1);
            this.Name = "Matrix";
            this.Text = "Matrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Button buttonCreateMatrix;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMinElement;
        private System.Windows.Forms.TextBox textBoxMaxElement;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelSaddle;
    }
}

