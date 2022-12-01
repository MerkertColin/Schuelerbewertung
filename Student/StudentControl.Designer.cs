
namespace Schuelerbewertung
{
    partial class StudentControl
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
            this.flpStudentDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flpButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpStudentDisplay
            // 
            this.flpStudentDisplay.AutoScroll = true;
            this.flpStudentDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpStudentDisplay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpStudentDisplay.Location = new System.Drawing.Point(3, 3);
            this.flpStudentDisplay.Name = "flpStudentDisplay";
            this.flpStudentDisplay.Size = new System.Drawing.Size(737, 408);
            this.flpStudentDisplay.TabIndex = 0;
            this.flpStudentDisplay.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flpStudentDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.2049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.7951F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 449);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flpButton
            // 
            this.flpButton.Controls.Add(this.btnSubmit);
            this.flpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButton.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButton.Location = new System.Drawing.Point(3, 417);
            this.flpButton.Name = "flpButton";
            this.flpButton.Size = new System.Drawing.Size(737, 29);
            this.flpButton.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(630, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Abschicken";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(743, 449);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpStudentDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpButton;
        private System.Windows.Forms.Button btnSubmit;
    }
}
