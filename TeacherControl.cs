using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Schuelerbewertung {
    public partial class TeacherControl : UserControl {

        public TeacherControl() {
            InitializeComponent();

            DataSource = new TeacherControlDataSource();

            fillTreeView();
        }

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
            foreach (var project in dataSource.Projects) {
                treeView.Nodes.Add(project.ProjectName);

                foreach (var group in project.Groups) {
                    treeView.Nodes[treeView.Nodes.Count - 1].Nodes.Add(group);
                }
            }

            treeView.ExpandAll();
        }

        private void initializeDataBindings() {
            dataGridView.DataBindings.Add(nameof(dataGridView.DataSource), dataSource, nameof(dataSource.TableData));
        }

        private void handleTreeViewNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
          
        }

        private void handleCreateProjectButtonClick(object sender, EventArgs e) {

        }

        private TeacherControlDataSource dataSource;

    }
}
