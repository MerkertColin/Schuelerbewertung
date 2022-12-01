
namespace Schuelerbewertung {
    partial class ProjectForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.nextPageButton = new System.Windows.Forms.Button();
            this.groupCreationLabel = new System.Windows.Forms.Label();
            this.projectCreationControl1 = new Schuelerbewertung.ProjectCreationControl();
            this.manualGroupCreationControl1 = new Schuelerbewertung.ManualGroupCreationControl();
            this.SuspendLayout();
            // 
            // nextPageButton
            // 
            this.nextPageButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextPageButton.Location = new System.Drawing.Point(237, 162);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(75, 23);
            this.nextPageButton.TabIndex = 1;
            this.nextPageButton.Text = "Weiter";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.handleNextPageButtonClick);
            // 
            // groupCreationLabel
            // 
            this.groupCreationLabel.AutoSize = true;
            this.groupCreationLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupCreationLabel.Location = new System.Drawing.Point(12, 9);
            this.groupCreationLabel.Name = "groupCreationLabel";
            this.groupCreationLabel.Size = new System.Drawing.Size(198, 24);
            this.groupCreationLabel.TabIndex = 2;
            this.groupCreationLabel.Text = "Gruppenerstellung";
            // 
            // projectCreationControl1
            // 
            this.projectCreationControl1.Location = new System.Drawing.Point(12, 36);
            this.projectCreationControl1.Name = "projectCreationControl1";
            this.projectCreationControl1.Size = new System.Drawing.Size(300, 120);
            this.projectCreationControl1.TabIndex = 3;
            // 
            // manualGroupCreationControl1
            // 
            this.manualGroupCreationControl1.Location = new System.Drawing.Point(12, 36);
            this.manualGroupCreationControl1.Name = "manualGroupCreationControl1";
            this.manualGroupCreationControl1.Size = new System.Drawing.Size(300, 120);
            this.manualGroupCreationControl1.TabIndex = 4;
            this.manualGroupCreationControl1.Visible = false;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 197);
            this.Controls.Add(this.manualGroupCreationControl1);
            this.Controls.Add(this.projectCreationControl1);
            this.Controls.Add(this.groupCreationLabel);
            this.Controls.Add(this.nextPageButton);
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Label groupCreationLabel;
        private ProjectCreationControl projectCreationControl1;
        private ManualGroupCreationControl manualGroupCreationControl1;
    }
}