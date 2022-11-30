using MySql.Data.MySqlClient;

using System;
using System.ComponentModel;
using System.Data;
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
            // schueler_durchschnitt
            //commandStudent.CommandText = "SELECT * FROM schueler LEFT JOIN schueler_durchschnitt ON schueler.SchuelerID = schueler_durchschnitt.SchuelerID";
            commandStudent.CommandText = "SELECT SchuelerID, Vorname, Name, avgKat1, avgKat2, avgKat3, avgKat4, avgKat5, avgKat6, avgKat7 FROM schueler_durchschnitt";
            var dt = new DataTable();
            dt.Load(commandStudent.ExecuteReader());

            var commandProjects = con.CreateCommand();
            commandProjects.CommandText = "SELECT * FROM projekte LEFT JOIN gruppen ON projekte.ProjektID = gruppen.ProjektID";
            var groups = new DataTable();
            groups.Load(commandProjects.ExecuteReader());

            //DataGridView dgv = new DataGridView();

            dataGridView.DataSource = dt;
            //dgv.DataSource = dt;

            fillTreeView();
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

        private void fillTreeView() {
            treeView.Nodes.Add("Alle Schüler");

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
