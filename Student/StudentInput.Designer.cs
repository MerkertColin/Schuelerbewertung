
namespace Schuelerbewertung.Student
{
    partial class StudentInput
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbStudentName = new System.Windows.Forms.Label();
            this.flpCriteriaDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStudentName.Location = new System.Drawing.Point(3, 10);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(75, 27);
            this.lbStudentName.TabIndex = 0;
            this.lbStudentName.Text = "Name";
            // 
            // flpCriteriaDisplay
            // 
            this.flpCriteriaDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpCriteriaDisplay.AutoScroll = true;
            this.flpCriteriaDisplay.AutoSize = true;
            this.flpCriteriaDisplay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCriteriaDisplay.Location = new System.Drawing.Point(4, 41);
            this.flpCriteriaDisplay.Name = "flpCriteriaDisplay";
            this.flpCriteriaDisplay.Size = new System.Drawing.Size(642, 106);
            this.flpCriteriaDisplay.TabIndex = 1;
            this.flpCriteriaDisplay.WrapContents = false;
            // 
            // StudentInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flpCriteriaDisplay);
            this.Controls.Add(this.lbStudentName);
            this.Name = "StudentInput";
            this.Size = new System.Drawing.Size(649, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.FlowLayoutPanel flpCriteriaDisplay;
    }
}
