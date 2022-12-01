
namespace Schuelerbewertung.Student
{
    partial class CriteriaSliderControl
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
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.nbNumberBox = new System.Windows.Forms.NumericUpDown();
            this.trbSlider = new System.Windows.Forms.TrackBar();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.nbNumberBox);
            this.gbCategory.Controls.Add(this.trbSlider);
            this.gbCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCategory.Location = new System.Drawing.Point(3, 3);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(508, 80);
            this.gbCategory.TabIndex = 0;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Category";
            // 
            // nbNumberBox
            // 
            this.nbNumberBox.Location = new System.Drawing.Point(377, 29);
            this.nbNumberBox.Name = "nbNumberBox";
            this.nbNumberBox.Size = new System.Drawing.Size(120, 26);
            this.nbNumberBox.TabIndex = 1;
            this.nbNumberBox.ValueChanged += new System.EventHandler(this.nbNumberBox_ValueChanged);
            // 
            // trbSlider
            // 
            this.trbSlider.LargeChange = 10;
            this.trbSlider.Location = new System.Drawing.Point(6, 29);
            this.trbSlider.Maximum = 100;
            this.trbSlider.Name = "trbSlider";
            this.trbSlider.Size = new System.Drawing.Size(365, 45);
            this.trbSlider.TabIndex = 0;
            this.trbSlider.TickFrequency = 10;
            this.trbSlider.Scroll += new System.EventHandler(this.trbSlider_Scroll);
            // 
            // CriteriaSliderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCategory);
            this.Name = "CriteriaSliderControl";
            this.Size = new System.Drawing.Size(514, 89);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.NumericUpDown nbNumberBox;
        private System.Windows.Forms.TrackBar trbSlider;
    }
}
