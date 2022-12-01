
namespace Schuelerbewertung {
    partial class ProjectCreationControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupSizeSpinEdit = new System.Windows.Forms.NumericUpDown();
            this.automaticRadioButton = new System.Windows.Forms.RadioButton();
            this.randomRadioButton = new System.Windows.Forms.RadioButton();
            this.manuelRadioButton = new System.Windows.Forms.RadioButton();
            this.groupSizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupSizeSpinEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSizeSpinEdit
            // 
            this.groupSizeSpinEdit.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.groupSizeSpinEdit.Location = new System.Drawing.Point(221, 15);
            this.groupSizeSpinEdit.Name = "groupSizeSpinEdit";
            this.groupSizeSpinEdit.Size = new System.Drawing.Size(75, 23);
            this.groupSizeSpinEdit.TabIndex = 1;
            this.groupSizeSpinEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.groupSizeSpinEdit.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // automaticRadioButton
            // 
            this.automaticRadioButton.AutoSize = true;
            this.automaticRadioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.automaticRadioButton.Location = new System.Drawing.Point(3, 66);
            this.automaticRadioButton.Name = "automaticRadioButton";
            this.automaticRadioButton.Size = new System.Drawing.Size(93, 19);
            this.automaticRadioButton.TabIndex = 2;
            this.automaticRadioButton.TabStop = true;
            this.automaticRadioButton.Text = "Automatisch";
            this.automaticRadioButton.UseVisualStyleBackColor = true;
            // 
            // randomRadioButton
            // 
            this.randomRadioButton.AutoSize = true;
            this.randomRadioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.randomRadioButton.Location = new System.Drawing.Point(103, 66);
            this.randomRadioButton.Name = "randomRadioButton";
            this.randomRadioButton.Size = new System.Drawing.Size(65, 19);
            this.randomRadioButton.TabIndex = 3;
            this.randomRadioButton.TabStop = true;
            this.randomRadioButton.Text = "Zufällig";
            this.randomRadioButton.UseVisualStyleBackColor = true;
            // 
            // manuelRadioButton
            // 
            this.manuelRadioButton.AutoSize = true;
            this.manuelRadioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manuelRadioButton.Location = new System.Drawing.Point(203, 66);
            this.manuelRadioButton.Name = "manuelRadioButton";
            this.manuelRadioButton.Size = new System.Drawing.Size(68, 19);
            this.manuelRadioButton.TabIndex = 4;
            this.manuelRadioButton.TabStop = true;
            this.manuelRadioButton.Text = "Manuell";
            this.manuelRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupSizeLabel
            // 
            this.groupSizeLabel.AutoSize = true;
            this.groupSizeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupSizeLabel.Location = new System.Drawing.Point(3, 17);
            this.groupSizeLabel.Name = "groupSizeLabel";
            this.groupSizeLabel.Size = new System.Drawing.Size(91, 15);
            this.groupSizeLabel.TabIndex = 6;
            this.groupSizeLabel.Text = "Gruppengröße:";
            // 
            // ProjectCreationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupSizeLabel);
            this.Controls.Add(this.manuelRadioButton);
            this.Controls.Add(this.randomRadioButton);
            this.Controls.Add(this.automaticRadioButton);
            this.Controls.Add(this.groupSizeSpinEdit);
            this.Name = "ProjectCreationControl";
            this.Size = new System.Drawing.Size(300, 120);
            ((System.ComponentModel.ISupportInitialize)(this.groupSizeSpinEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown groupSizeSpinEdit;
        private System.Windows.Forms.RadioButton automaticRadioButton;
        private System.Windows.Forms.RadioButton randomRadioButton;
        private System.Windows.Forms.RadioButton manuelRadioButton;
        private System.Windows.Forms.Label groupSizeLabel;
    }
}
