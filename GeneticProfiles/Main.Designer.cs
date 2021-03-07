namespace GeneticProfiles
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSolve = new System.Windows.Forms.Button();
            this.dataGridSpans = new System.Windows.Forms.DataGridView();
            this.buttonAddSpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpans)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSolve
            // 
            this.buttonSolve.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonSolve.Location = new System.Drawing.Point(642, 399);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(146, 39);
            this.buttonSolve.TabIndex = 0;
            this.buttonSolve.Text = "Run";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // dataGridSpans
            // 
            this.dataGridSpans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSpans.Location = new System.Drawing.Point(12, 57);
            this.dataGridSpans.Name = "dataGridSpans";
            this.dataGridSpans.RowHeadersWidth = 51;
            this.dataGridSpans.RowTemplate.Height = 24;
            this.dataGridSpans.Size = new System.Drawing.Size(776, 336);
            this.dataGridSpans.TabIndex = 1;
            // 
            // buttonAddSpan
            // 
            this.buttonAddSpan.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonAddSpan.Location = new System.Drawing.Point(12, 12);
            this.buttonAddSpan.Name = "buttonAddSpan";
            this.buttonAddSpan.Size = new System.Drawing.Size(146, 39);
            this.buttonAddSpan.TabIndex = 0;
            this.buttonAddSpan.Text = "Add Span";
            this.buttonAddSpan.UseVisualStyleBackColor = true;
            this.buttonAddSpan.Click += new System.EventHandler(this.buttonAddSpan_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridSpans);
            this.Controls.Add(this.buttonAddSpan);
            this.Controls.Add(this.buttonSolve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "GeneticProfiles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.DataGridView dataGridSpans;
        private System.Windows.Forms.Button buttonAddSpan;
    }
}

