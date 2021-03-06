namespace GeneticProfiles
{
    partial class AddSpans
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
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textLength = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.Font = new System.Drawing.Font("Artifakt Element", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.Location = new System.Drawing.Point(17, 43);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(112, 35);
            this.textTitle.TabIndex = 0;
            // 
            // textLength
            // 
            this.textLength.Font = new System.Drawing.Font("Artifakt Element", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLength.Location = new System.Drawing.Point(214, 43);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(112, 35);
            this.textLength.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.labelTitle.Location = new System.Drawing.Point(12, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(54, 28);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.labelLength.Location = new System.Drawing.Point(209, 12);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(77, 28);
            this.labelLength.TabIndex = 1;
            this.labelLength.Text = "Length";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(309, 305);
            this.dataGridView1.TabIndex = 2;
            // 
            // AddSpans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.textTitle);
            this.Name = "AddSpans";
            this.Text = "Create spans";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}