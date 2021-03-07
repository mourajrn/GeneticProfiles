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
            this.dataGridProfiles = new System.Windows.Forms.DataGridView();
            this.comboProfiles = new System.Windows.Forms.ComboBox();
            this.labelProfiles = new System.Windows.Forms.Label();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.buttonCreateOrModify = new System.Windows.Forms.Button();
            this.buttonRemoveProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.Font = new System.Drawing.Font("Artifakt Element", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.Location = new System.Drawing.Point(17, 43);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(112, 35);
            this.textTitle.TabIndex = 1;
            // 
            // textLength
            // 
            this.textLength.Font = new System.Drawing.Font("Artifakt Element", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLength.Location = new System.Drawing.Point(214, 43);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(112, 35);
            this.textLength.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.labelTitle.Location = new System.Drawing.Point(12, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(54, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.labelLength.Location = new System.Drawing.Point(209, 12);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(77, 28);
            this.labelLength.TabIndex = 2;
            this.labelLength.Text = "Length";
            // 
            // dataGridProfiles
            // 
            this.dataGridProfiles.AllowUserToAddRows = false;
            this.dataGridProfiles.AllowUserToDeleteRows = false;
            this.dataGridProfiles.AllowUserToResizeColumns = false;
            this.dataGridProfiles.AllowUserToResizeRows = false;
            this.dataGridProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridProfiles.Location = new System.Drawing.Point(17, 148);
            this.dataGridProfiles.Name = "dataGridProfiles";
            this.dataGridProfiles.RowHeadersWidth = 51;
            this.dataGridProfiles.RowTemplate.Height = 24;
            this.dataGridProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProfiles.Size = new System.Drawing.Size(309, 317);
            this.dataGridProfiles.TabIndex = 7;
            this.dataGridProfiles.SelectionChanged += new System.EventHandler(this.dataGridProfiles_SelectionChanged);
            // 
            // comboProfiles
            // 
            this.comboProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfiles.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.comboProfiles.FormattingEnabled = true;
            this.comboProfiles.Location = new System.Drawing.Point(102, 93);
            this.comboProfiles.Name = "comboProfiles";
            this.comboProfiles.Size = new System.Drawing.Size(145, 36);
            this.comboProfiles.TabIndex = 5;
            this.comboProfiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboProfiles_KeyPress);
            // 
            // labelProfiles
            // 
            this.labelProfiles.AutoSize = true;
            this.labelProfiles.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.labelProfiles.Location = new System.Drawing.Point(12, 96);
            this.labelProfiles.Name = "labelProfiles";
            this.labelProfiles.Size = new System.Drawing.Size(84, 28);
            this.labelProfiles.TabIndex = 4;
            this.labelProfiles.Text = "Profiles";
            // 
            // buttonAssign
            // 
            this.buttonAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssign.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonAssign.Location = new System.Drawing.Point(253, 93);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(34, 36);
            this.buttonAssign.TabIndex = 6;
            this.buttonAssign.Text = "+";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // buttonCreateOrModify
            // 
            this.buttonCreateOrModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateOrModify.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonCreateOrModify.Location = new System.Drawing.Point(17, 471);
            this.buttonCreateOrModify.Name = "buttonCreateOrModify";
            this.buttonCreateOrModify.Size = new System.Drawing.Size(309, 36);
            this.buttonCreateOrModify.TabIndex = 8;
            this.buttonCreateOrModify.Text = "Create Span";
            this.buttonCreateOrModify.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveProfile
            // 
            this.buttonRemoveProfile.Enabled = false;
            this.buttonRemoveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveProfile.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonRemoveProfile.Location = new System.Drawing.Point(292, 93);
            this.buttonRemoveProfile.Name = "buttonRemoveProfile";
            this.buttonRemoveProfile.Size = new System.Drawing.Size(34, 36);
            this.buttonRemoveProfile.TabIndex = 9;
            this.buttonRemoveProfile.Text = "-";
            this.buttonRemoveProfile.UseVisualStyleBackColor = true;
            this.buttonRemoveProfile.Click += new System.EventHandler(this.buttonRemoveProfile_Click);
            // 
            // AddSpans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 519);
            this.Controls.Add(this.buttonRemoveProfile);
            this.Controls.Add(this.buttonCreateOrModify);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.comboProfiles);
            this.Controls.Add(this.dataGridProfiles);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelProfiles);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.textTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddSpans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create spans";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.DataGridView dataGridProfiles;
        private System.Windows.Forms.ComboBox comboProfiles;
        private System.Windows.Forms.Label labelProfiles;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Button buttonCreateOrModify;
        private System.Windows.Forms.Button buttonRemoveProfile;
    }
}