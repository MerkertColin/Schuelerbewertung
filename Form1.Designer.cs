
namespace Schuelerbewertung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentProjectView = new Schuelerbewertung.Student.StudentProjectControl();
            this.loginView = new Schuelerbewertung.Student.LoginControl();
            this.SuspendLayout();
            // 
            // studentProjectView
            // 
            this.studentProjectView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentProjectView.Location = new System.Drawing.Point(0, 0);
            this.studentProjectView.Name = "studentProjectView";
            this.studentProjectView.Size = new System.Drawing.Size(800, 450);
            this.studentProjectView.TabIndex = 0;
            this.studentProjectView.Visible = false;
            // 
            // loginView
            // 
            this.loginView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginView.Location = new System.Drawing.Point(0, 0);
            this.loginView.Name = "loginView";
            this.loginView.Size = new System.Drawing.Size(800, 450);
            this.loginView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginView);
            this.Controls.Add(this.studentProjectView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Student.StudentProjectControl studentProjectView;
        private Student.LoginControl loginView;
    }
}

