
namespace Schuelerbewertung {
    partial class ManualGroupCreationControl {
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
			this.member1ComboBox = new System.Windows.Forms.ComboBox();
			this.member2ComboBox = new System.Windows.Forms.ComboBox();
			this.member3ComboBox = new System.Windows.Forms.ComboBox();
			this.member4ComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// member1ComboBox
			// 
			this.member1ComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.member1ComboBox.FormattingEnabled = true;
			this.member1ComboBox.Location = new System.Drawing.Point(176, 7);
			this.member1ComboBox.Name = "member1ComboBox";
			this.member1ComboBox.Size = new System.Drawing.Size(121, 23);
			this.member1ComboBox.TabIndex = 0;
			this.member1ComboBox.SelectedIndexChanged += new System.EventHandler(this.handleMember1ComboBoxSelectedIndexChanged);
			// 
			// member2ComboBox
			// 
			this.member2ComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.member2ComboBox.FormattingEnabled = true;
			this.member2ComboBox.Location = new System.Drawing.Point(176, 36);
			this.member2ComboBox.Name = "member2ComboBox";
			this.member2ComboBox.Size = new System.Drawing.Size(121, 23);
			this.member2ComboBox.TabIndex = 1;
			this.member2ComboBox.SelectedIndexChanged += new System.EventHandler(this.handleMember2ComboBoxSelectedIndexChanged);
			// 
			// member3ComboBox
			// 
			this.member3ComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.member3ComboBox.FormattingEnabled = true;
			this.member3ComboBox.Location = new System.Drawing.Point(176, 65);
			this.member3ComboBox.Name = "member3ComboBox";
			this.member3ComboBox.Size = new System.Drawing.Size(121, 23);
			this.member3ComboBox.TabIndex = 2;
			this.member3ComboBox.SelectedIndexChanged += new System.EventHandler(this.handleMember3ComboBoxSelectedIndexChanged);
			// 
			// member4ComboBox
			// 
			this.member4ComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.member4ComboBox.FormattingEnabled = true;
			this.member4ComboBox.Location = new System.Drawing.Point(176, 95);
			this.member4ComboBox.Name = "member4ComboBox";
			this.member4ComboBox.Size = new System.Drawing.Size(121, 23);
			this.member4ComboBox.TabIndex = 3;
			this.member4ComboBox.SelectedIndexChanged += new System.EventHandler(this.handleMember4ComboBoxSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(3, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Mitglied 1:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(3, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Mitglied 2:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(3, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Mitglied 3:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(3, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Mitglied 4:";
			// 
			// ManualGroupCreationControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.member4ComboBox);
			this.Controls.Add(this.member3ComboBox);
			this.Controls.Add(this.member2ComboBox);
			this.Controls.Add(this.member1ComboBox);
			this.Name = "ManualGroupCreationControl";
			this.Size = new System.Drawing.Size(300, 120);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox member1ComboBox;
        private System.Windows.Forms.ComboBox member2ComboBox;
        private System.Windows.Forms.ComboBox member3ComboBox;
        private System.Windows.Forms.ComboBox member4ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
