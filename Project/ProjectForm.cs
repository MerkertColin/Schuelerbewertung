using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Schuelerbewertung {
    public partial class ProjectForm : Form {
        public ProjectForm() {
            InitializeComponent();

            projectCreationControl1.DataSource.PropertyChanged += handleDataSourcePropertyChanged;

            manualGroupCreationControl1.DataSource = new ManualGroupCreationControlDataSource(projectCreationControl1.DataSource.GetStudents());
        }

        private void handleDataSourcePropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(projectCreationControl1.DataSource.EnableNextPage)) {
                nextPageButton.Enabled = projectCreationControl1.DataSource.EnableNextPage;
            }
        }

        private void handleNextPageButtonClick(object sender, EventArgs e) {
            if (projectCreationControl1.DataSource.ManualGeneration) {
                projectCreationControl1.Visible = false;
                manualGroupCreationControl1.Visible = true;

                if (manualGroupCreationControl1.DataSource.Groups.Count < manualGroupCreationControl1.DataSource.GroupCount) {
                    manualGroupCreationControl1.NextPage();
                } else {
					// Gruppen an die Datenbank schicken
					this.Close();
                }
            } else {
                // Gruppen erstellen und an die Datenbank schicken
                this.Close();
            }
        }
    }
}
