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
            this.labelTotalWeightTitle = new System.Windows.Forms.Label();
            this.labelTotalWeight = new System.Windows.Forms.Label();
            this.buttonEditSpan = new System.Windows.Forms.Button();
            this.buttonRemoveSpan = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpans)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSolve
            // 
            this.buttonSolve.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonSolve.Location = new System.Drawing.Point(642, 399);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(146, 39);
            this.buttonSolve.TabIndex = 5;
            this.buttonSolve.Text = "Run";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // dataGridSpans
            // 
            this.dataGridSpans.AllowUserToAddRows = false;
            this.dataGridSpans.AllowUserToDeleteRows = false;
            this.dataGridSpans.AllowUserToResizeColumns = false;
            this.dataGridSpans.AllowUserToResizeRows = false;
            this.dataGridSpans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSpans.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridSpans.Location = new System.Drawing.Point(12, 57);
            this.dataGridSpans.Name = "dataGridSpans";
            this.dataGridSpans.RowHeadersWidth = 51;
            this.dataGridSpans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSpans.RowTemplate.Height = 24;
            this.dataGridSpans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridSpans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSpans.Size = new System.Drawing.Size(776, 336);
            this.dataGridSpans.TabIndex = 2;
            this.dataGridSpans.SelectionChanged += new System.EventHandler(this.dataGridSpans_SelectionChanged);
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
            // labelTotalWeightTitle
            // 
            this.labelTotalWeightTitle.AutoSize = true;
            this.labelTotalWeightTitle.Font = new System.Drawing.Font("Artifakt Element", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalWeightTitle.Location = new System.Drawing.Point(12, 408);
            this.labelTotalWeightTitle.Name = "labelTotalWeightTitle";
            this.labelTotalWeightTitle.Size = new System.Drawing.Size(131, 28);
            this.labelTotalWeightTitle.TabIndex = 3;
            this.labelTotalWeightTitle.Text = "Total Weight";
            // 
            // labelTotalWeight
            // 
            this.labelTotalWeight.AutoSize = true;
            this.labelTotalWeight.Font = new System.Drawing.Font("Artifakt Element", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalWeight.Location = new System.Drawing.Point(152, 408);
            this.labelTotalWeight.Name = "labelTotalWeight";
            this.labelTotalWeight.Size = new System.Drawing.Size(0, 28);
            this.labelTotalWeight.TabIndex = 4;
            // 
            // buttonEditSpan
            // 
            this.buttonEditSpan.Enabled = false;
            this.buttonEditSpan.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonEditSpan.Location = new System.Drawing.Point(164, 12);
            this.buttonEditSpan.Name = "buttonEditSpan";
            this.buttonEditSpan.Size = new System.Drawing.Size(146, 39);
            this.buttonEditSpan.TabIndex = 1;
            this.buttonEditSpan.Text = "Edit Span";
            this.buttonEditSpan.UseVisualStyleBackColor = true;
            this.buttonEditSpan.Click += new System.EventHandler(this.buttonEditSpan_Click);
            // 
            // buttonRemoveSpan
            // 
            this.buttonRemoveSpan.Enabled = false;
            this.buttonRemoveSpan.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonRemoveSpan.Location = new System.Drawing.Point(316, 12);
            this.buttonRemoveSpan.Name = "buttonRemoveSpan";
            this.buttonRemoveSpan.Size = new System.Drawing.Size(161, 39);
            this.buttonRemoveSpan.TabIndex = 1;
            this.buttonRemoveSpan.Text = "Remove Span";
            this.buttonRemoveSpan.UseVisualStyleBackColor = true;
            this.buttonRemoveSpan.Click += new System.EventHandler(this.buttonRemoveSpan_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonSave.Location = new System.Drawing.Point(483, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 39);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonLoad.Location = new System.Drawing.Point(589, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 39);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalWeight);
            this.Controls.Add(this.labelTotalWeightTitle);
            this.Controls.Add(this.dataGridSpans);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRemoveSpan);
            this.Controls.Add(this.buttonEditSpan);
            this.Controls.Add(this.buttonAddSpan);
            this.Controls.Add(this.buttonSolve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "GeneticProfiles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.DataGridView dataGridSpans;
        private System.Windows.Forms.Button buttonAddSpan;
        private System.Windows.Forms.Label labelTotalWeightTitle;
        private System.Windows.Forms.Label labelTotalWeight;
        private System.Windows.Forms.Button buttonEditSpan;
        private System.Windows.Forms.Button buttonRemoveSpan;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}

