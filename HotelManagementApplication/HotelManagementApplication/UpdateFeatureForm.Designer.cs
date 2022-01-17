
namespace HotelManagementApplication
{
    partial class UpdateFeatureForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtFeatureName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(149, 53);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 40);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 40);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtFeatureName
            // 
            // 
            // 
            // 
            this.txtFeatureName.CustomButton.Image = null;
            this.txtFeatureName.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtFeatureName.CustomButton.Name = "";
            this.txtFeatureName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtFeatureName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFeatureName.CustomButton.TabIndex = 1;
            this.txtFeatureName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFeatureName.CustomButton.UseSelectable = true;
            this.txtFeatureName.CustomButton.Visible = false;
            this.txtFeatureName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFeatureName.Lines = new string[0];
            this.txtFeatureName.Location = new System.Drawing.Point(12, 12);
            this.txtFeatureName.MaxLength = 32767;
            this.txtFeatureName.Name = "txtFeatureName";
            this.txtFeatureName.PasswordChar = '\0';
            this.txtFeatureName.PromptText = "Feature Name";
            this.txtFeatureName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFeatureName.SelectedText = "";
            this.txtFeatureName.SelectionLength = 0;
            this.txtFeatureName.SelectionStart = 0;
            this.txtFeatureName.ShortcutsEnabled = true;
            this.txtFeatureName.Size = new System.Drawing.Size(252, 35);
            this.txtFeatureName.TabIndex = 26;
            this.txtFeatureName.UseSelectable = true;
            this.txtFeatureName.WaterMark = "Feature Name";
            this.txtFeatureName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFeatureName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // UpdateFeatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(276, 105);
            this.Controls.Add(this.txtFeatureName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateFeatureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateFeatureForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtFeatureName;
    }
}