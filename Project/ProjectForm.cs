using GroupingAlgorithm;

using MySql.Data.MySqlClient;

using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Schuelerbewertung {
	public partial class ProjectForm : Form {

		public ProjectForm() {
            InitializeComponent();

            projectCreationControl1.DataSource.PropertyChanged += handleDataSourcePropertyChanged;

            manualGroupCreationControl1.DataSource = new ManualGroupCreationControlDataSource(projectCreationControl1.DataSource.GetStudents());

            var groups = DistanceAlgorithm.BuildGroups(projectCreationControl1.DataSource.GetStudents());

            var conString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", "192.168.0.241", "schuelergruppierung", "niklas_degner", "knilz");
            var con = new MySqlConnection();
            con.ConnectionString = conString;
            con.Open();
        }

        private void handleDataSourcePropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(projectCreationControl1.DataSource.EnableNextPage)) {
                nextPageButton.Enabled = projectCreationControl1.DataSource.EnableNextPage;
            }
        }

        private void handleNextPageButtonClick(object sender, EventArgs e) {
            var groups = DistanceAlgorithm.BuildGroups(projectCreationControl1.DataSource.GetStudents());

            var conString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", "192.168.0.241", "schuelergruppierung", "niklas_degner", "knilz");
            var con = new MySqlConnection();
            con.ConnectionString = conString;
            con.Open();

            var groupCount = 1;

            if (projectCreationControl1.DataSource.ManualGeneration) {
                projectCreationControl1.Visible = false;
                manualGroupCreationControl1.Visible = true;

                if (manualGroupCreationControl1.DataSource.Students.Count > 4) {
                    manualGroupCreationControl1.NextPage();
                } else {
                    manualGroupCreationControl1.NextPage();
                    // Gruppen an die Datenbank schicken

                    var insertProject = con.CreateCommand();
                    insertProject.CommandText = string.Format(
                        "INSERT INTO projekte (ProjektName, ErstellDatum, KlassenID) VALUES ('{0}', '{1}', {2})",
                        "Projekt Test",
                        string.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        1
                    );

                    insertProject.ExecuteNonQuery();

                    var currentProject = con.CreateCommand();
                    currentProject.CommandText = "SELECT MAX(ProjektID) AS PROJECT_ID FROM projekte";
                    var dt = new DataTable();
                    dt.Load(currentProject.ExecuteReader());

                    projektID = dt.Rows[0].Field<int>("PROJECT_ID");

                    foreach (var group in manualGroupCreationControl1.DataSource.Groups) {
                        var insertGroup = con.CreateCommand();
                        insertGroup.CommandText = string.Format(
                            "INSERT INTO gruppen (ProjektID, GruppenName, Sch1, Sch2, Sch3, Sch4) VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')",
                            projektID,
                            string.Format("Gruppe {0}", groupCount),
                            group.Students[0].StudentID,
                            group.Students[1].StudentID,
                            group.Students[2].StudentID,
                            group.Students[3].StudentID
                        );

                        insertGroup.ExecuteNonQuery();
                        groupCount++;
                    }

                    this.Close();
                }
            }

            if (projectCreationControl1.DataSource.AutomaticGeneration) {
                var insertProject = con.CreateCommand();
                insertProject.CommandText = string.Format(
                    "INSERT INTO projekte (ProjektName, ErstellDatum, KlassenID) VALUES ('{0}', '{1}', {2})", 
                    "Projekt Test", 
                    string.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), 
                    1
                );

                insertProject.ExecuteNonQuery();

                var currentProject = con.CreateCommand();
                currentProject.CommandText = "SELECT MAX(ProjektID) AS PROJECT_ID FROM projekte";
                var dt = new DataTable();
                dt.Load(currentProject.ExecuteReader());

                projektID = dt.Rows[0].Field<int>("PROJECT_ID");

                foreach (var group in groups) {
                    var insertGroup = con.CreateCommand();
                    insertGroup.CommandText = string.Format(
                        "INSERT INTO gruppen (ProjektID, GruppenName, Sch1, Sch2, Sch3, Sch4) VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')",
                        projektID,
                        string.Format("Gruppe {0}", groupCount),
                        group.member[0].Identifier,
                        group.member[1].Identifier,
                        group.member[2].Identifier,
                        group.member[3].Identifier
                    );

                    insertGroup.ExecuteNonQuery();
                    groupCount++;
                }
                
                this.Close();
            }
        }

        private int projektID;
    }
}
