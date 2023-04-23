
namespace WAPDemos
{
    partial class frmDemo02_Ordenar
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
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnArrayUnsorted = new System.Windows.Forms.Button();
            this.btnArraySortedDefault = new System.Windows.Forms.Button();
            this.btnArraySortedAscendingNumericValue = new System.Windows.Forms.Button();
            this.btnArraySortedDescendingNumericValue = new System.Windows.Forms.Button();
            this.btnArraySortedDescendingStringValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(21, 12);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(379, 216);
            this.txtConsole.TabIndex = 0;
            // 
            // btnArrayUnsorted
            // 
            this.btnArrayUnsorted.Location = new System.Drawing.Point(431, 34);
            this.btnArrayUnsorted.Name = "btnArrayUnsorted";
            this.btnArrayUnsorted.Size = new System.Drawing.Size(139, 23);
            this.btnArrayUnsorted.TabIndex = 1;
            this.btnArrayUnsorted.Text = "Array Unsorted";
            this.btnArrayUnsorted.UseVisualStyleBackColor = true;
            // 
            // btnArraySortedDefault
            // 
            this.btnArraySortedDefault.Location = new System.Drawing.Point(431, 63);
            this.btnArraySortedDefault.Name = "btnArraySortedDefault";
            this.btnArraySortedDefault.Size = new System.Drawing.Size(139, 23);
            this.btnArraySortedDefault.TabIndex = 2;
            this.btnArraySortedDefault.Text = "Array Sorted Default";
            this.btnArraySortedDefault.UseVisualStyleBackColor = true;
            // 
            // btnArraySortedAscendingNumericValue
            // 
            this.btnArraySortedAscendingNumericValue.Location = new System.Drawing.Point(431, 92);
            this.btnArraySortedAscendingNumericValue.Name = "btnArraySortedAscendingNumericValue";
            this.btnArraySortedAscendingNumericValue.Size = new System.Drawing.Size(139, 37);
            this.btnArraySortedAscendingNumericValue.TabIndex = 3;
            this.btnArraySortedAscendingNumericValue.Text = "Array Sorted Ascending of numeric value";
            this.btnArraySortedAscendingNumericValue.UseVisualStyleBackColor = true;
            // 
            // btnArraySortedDescendingNumericValue
            // 
            this.btnArraySortedDescendingNumericValue.Location = new System.Drawing.Point(431, 135);
            this.btnArraySortedDescendingNumericValue.Name = "btnArraySortedDescendingNumericValue";
            this.btnArraySortedDescendingNumericValue.Size = new System.Drawing.Size(139, 39);
            this.btnArraySortedDescendingNumericValue.TabIndex = 4;
            this.btnArraySortedDescendingNumericValue.Text = "Array Sorted Descending of numeric value";
            this.btnArraySortedDescendingNumericValue.UseVisualStyleBackColor = true;
            // 
            // btnArraySortedDescendingStringValue
            // 
            this.btnArraySortedDescendingStringValue.Location = new System.Drawing.Point(431, 180);
            this.btnArraySortedDescendingStringValue.Name = "btnArraySortedDescendingStringValue";
            this.btnArraySortedDescendingStringValue.Size = new System.Drawing.Size(139, 37);
            this.btnArraySortedDescendingStringValue.TabIndex = 5;
            this.btnArraySortedDescendingStringValue.Text = "Array Sorted Descending of string value";
            this.btnArraySortedDescendingStringValue.UseVisualStyleBackColor = true;
            // 
            // frmDemo02_Ordenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArraySortedDescendingStringValue);
            this.Controls.Add(this.btnArraySortedDescendingNumericValue);
            this.Controls.Add(this.btnArraySortedAscendingNumericValue);
            this.Controls.Add(this.btnArraySortedDefault);
            this.Controls.Add(this.btnArrayUnsorted);
            this.Controls.Add(this.txtConsole);
            this.Name = "frmDemo02_Ordenar";
            this.Text = "frmDemo02_Ordenar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnArrayUnsorted;
        private System.Windows.Forms.Button btnArraySortedDefault;
        private System.Windows.Forms.Button btnArraySortedAscendingNumericValue;
        private System.Windows.Forms.Button btnArraySortedDescendingNumericValue;
        private System.Windows.Forms.Button btnArraySortedDescendingStringValue;
    }
}