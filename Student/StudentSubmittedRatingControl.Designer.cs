
namespace Schuelerbewertung.Student
{
    partial class StudentSubmittedRatingControl
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
            this.dgvSubmittedRatings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmittedRatings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubmittedRatings
            // 
            this.dgvSubmittedRatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubmittedRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubmittedRatings.Location = new System.Drawing.Point(0, 0);
            this.dgvSubmittedRatings.Name = "dgvSubmittedRatings";
            this.dgvSubmittedRatings.RowTemplate.Height = 25;
            this.dgvSubmittedRatings.Size = new System.Drawing.Size(523, 244);
            this.dgvSubmittedRatings.TabIndex = 0;
            // 
            // StudentSubmittedRatingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSubmittedRatings);
            this.Name = "StudentSubmittedRatingControl";
            this.Size = new System.Drawing.Size(523, 244);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmittedRatings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubmittedRatings;
    }
}
