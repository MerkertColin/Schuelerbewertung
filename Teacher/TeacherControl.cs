using MySql.Data.MySqlClient;

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Schuelerbewertung {
    public partial class TeacherControl : UserControl {

        public TeacherControl() {
            InitializeComponent();

            DataSource = new TeacherControlDataSource();

            var conString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", "192.168.0.241", "schuelergruppierung", "niklas_degner", "knilz");
            var con = new MySqlConnection();
            con.ConnectionString = conString;
            con.Open();
            var commandStudent = con.CreateCommand();

            //commandStudent.CommandText = "SELECT * FROM schueler LEFT JOIN schueler_durchschnitt ON schueler.SchuelerID = schueler_durchschnitt.SchuelerID";
            commandStudent.CommandText = "SELECT SchuelerID, Vorname, Name, avgKat1, avgKat2, avgKat3, avgKat4, avgKat5, avgKat6, avgKat7 FROM schueler_durchschnitt";
            var dt = new DataTable();
            dt.Load(commandStudent.ExecuteReader());

            dataGridView.DataSource = dt;

            fillTreeView(con);
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TeacherControlDataSource DataSource {
            get => dataSource;
            set {
                if (dataSource != value) {
                    dataSource = value;

                    initializeDataBindings();
                }
            }
        }

        private void fillTreeView(MySqlConnection con) {
            treeView.Nodes.Add("Alle Schüler");

            var commandProjects = con.CreateCommand();
            commandProjects.CommandText = "SELECT * FROM projekte";
            var projects = new DataTable();
            projects.Load(commandProjects.ExecuteReader());

			var commandGroups = con.CreateCommand();
            commandGroups.CommandText = "SELECT * FROM gruppen";
			var groups = new DataTable();
			groups.Load(commandGroups.ExecuteReader());

			foreach (var project in projects.AsEnumerable()) {
                treeView.Nodes.Add(project["ProjektName"].ToString());
                var projectID = (int)project["ProjektID"];

                foreach (var group in groups.AsEnumerable()) {
                    if ((int)group["ProjektID"] == projectID) {
                        treeView.Nodes[treeView.Nodes.Count - 1].Nodes.Add(group["GruppenName"].ToString());
                    }
                }
            }

            foreach (var project in dataSource.Projects) {
                treeView.Nodes.Add(project.ProjectName);

                foreach (var group in project.Groups) {
                    treeView.Nodes[treeView.Nodes.Count - 1].Nodes.Add(group);
                }
            }

            treeView.ExpandAll();
        }

        private void initializeDataBindings() {
            //dataGridView.DataBindings.Add(nameof(dataGridView.DataSource), dataSource, nameof(dataSource.TableData));
        }

        private void handleTreeViewNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {

        }

        private void handleCreateProjectButtonClick(object sender, EventArgs e) {
            createProject();
        }

        private void createProject() {
            using (var projectForm = new ProjectForm()) {
                projectForm.ShowDialog();
            }
        }

        private TeacherControlDataSource dataSource;

    }
}
