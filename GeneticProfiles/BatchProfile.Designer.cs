
namespace GeneticProfiles
{
    partial class BatchProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchProfile));
            this.comboProfiles = new System.Windows.Forms.ComboBox();
            this.labelProfiles = new System.Windows.Forms.Label();
            this.buttonAddProfile = new System.Windows.Forms.Button();
            this.buttonRemoveProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboProfiles
            // 
            this.comboProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfiles.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.comboProfiles.FormattingEnabled = true;
            this.comboProfiles.Location = new System.Drawing.Point(102, 12);
            this.comboProfiles.Name = "comboProfiles";
            this.comboProfiles.Size = new System.Drawing.Size(403, 36);
            this.comboProfiles.TabIndex = 7;
            // 
            // labelProfiles
            // 
            this.labelProfiles.AutoSize = true;
            this.labelProfiles.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.labelProfiles.Location = new System.Drawing.Point(9, 16);
            this.labelProfiles.Name = "labelProfiles";
            this.labelProfiles.Size = new System.Drawing.Size(84, 28);
            this.labelProfiles.TabIndex = 6;
            this.labelProfiles.Text = "Profiles";
            // 
            // buttonAddProfile
            // 
            this.buttonAddProfile.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonAddProfile.Location = new System.Drawing.Point(14, 61);
            this.buttonAddProfile.Name = "buttonAddProfile";
            this.buttonAddProfile.Size = new System.Drawing.Size(233, 45);
            this.buttonAddProfile.TabIndex = 8;
            this.buttonAddProfile.Text = "Add";
            this.buttonAddProfile.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveProfile
            // 
            this.buttonRemoveProfile.Font = new System.Drawing.Font("Artifakt Element", 12F);
            this.buttonRemoveProfile.Location = new System.Drawing.Point(253, 61);
            this.buttonRemoveProfile.Name = "buttonRemoveProfile";
            this.buttonRemoveProfile.Size = new System.Drawing.Size(252, 45);
            this.buttonRemoveProfile.TabIndex = 8;
            this.buttonRemoveProfile.Text = "Remove";
            this.buttonRemoveProfile.UseVisualStyleBackColor = true;
            // 
            // BatchProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 122);
            this.Controls.Add(this.buttonRemoveProfile);
            this.Controls.Add(this.buttonAddProfile);
            this.Controls.Add(this.comboProfiles);
            this.Controls.Add(this.labelProfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BatchProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Profiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboProfiles;
        private System.Windows.Forms.Label labelProfiles;
        private System.Windows.Forms.Button buttonAddProfile;
        private System.Windows.Forms.Button buttonRemoveProfile;
    }
}