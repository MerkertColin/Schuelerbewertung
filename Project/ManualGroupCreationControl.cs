using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Schuelerbewertung {
    public partial class ManualGroupCreationControl : UserControl {

        public ManualGroupCreationControl() {
            InitializeComponent();
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ManualGroupCreationControlDataSource DataSource {
            get => dataSource;
            set {
                if (dataSource != value) {
                    dataSource = value;

                    initializeComboxes();
                }
            }
        }

        public void NextPage() {
            var students = new List<Student>();
            students.Add((Student)member1ComboBox.SelectedItem);
			students.Add((Student)member2ComboBox.SelectedItem);
			students.Add((Student)member3ComboBox.SelectedItem);
			students.Add((Student)member4ComboBox.SelectedItem);

			dataSource.Groups.Add(new Group() {
                GroupName = String.Format("Gruppe {0}", dataSource.Groups.Count + 1),
                Students = students
            });

			dataSource.Students.Remove((Student)member1ComboBox.SelectedItem);
			dataSource.Students.Remove((Student)member2ComboBox.SelectedItem);
			dataSource.Students.Remove((Student)member3ComboBox.SelectedItem);
			dataSource.Students.Remove((Student)member4ComboBox.SelectedItem);

			member1ComboBox.Items.Remove(member1ComboBox.SelectedItem);
			member2ComboBox.Items.Remove(member2ComboBox.SelectedItem);
			member3ComboBox.Items.Remove(member3ComboBox.SelectedItem);
			member4ComboBox.Items.Remove(member4ComboBox.SelectedItem);

			member1ComboBox.Enabled = true;
			member2ComboBox.Enabled = true;
			member3ComboBox.Enabled = true;
			member4ComboBox.Enabled = true;
		}

		private void initializeComboxes() {
			member1ComboBox.Items.AddRange(dataSource.Students.ToArray());
			member2ComboBox.Items.AddRange(dataSource.Students.ToArray());
			member3ComboBox.Items.AddRange(dataSource.Students.ToArray());
			member4ComboBox.Items.AddRange(dataSource.Students.ToArray());
		}

        private void handleMember1ComboBoxSelectedIndexChanged(object sender, EventArgs e) {
            member2ComboBox.Items.Remove(member1ComboBox.SelectedItem);
            member3ComboBox.Items.Remove(member1ComboBox.SelectedItem);
            member4ComboBox.Items.Remove(member1ComboBox.SelectedItem);

            member1ComboBox.Enabled = false;
        }

        private void handleMember2ComboBoxSelectedIndexChanged(object sender, EventArgs e) {
			member1ComboBox.Items.Remove(member2ComboBox.SelectedItem);
			member3ComboBox.Items.Remove(member2ComboBox.SelectedItem);
			member4ComboBox.Items.Remove(member2ComboBox.SelectedItem);

			member2ComboBox.Enabled = false;
		}

        private void handleMember3ComboBoxSelectedIndexChanged(object sender, EventArgs e) {
			member1ComboBox.Items.Remove(member3ComboBox.SelectedItem);
			member2ComboBox.Items.Remove(member3ComboBox.SelectedItem);
			member4ComboBox.Items.Remove(member3ComboBox.SelectedItem);

			member3ComboBox.Enabled = false;
		}

        private void handleMember4ComboBoxSelectedIndexChanged(object sender, EventArgs e) {
			member1ComboBox.Items.Remove(member4ComboBox.SelectedItem);
			member2ComboBox.Items.Remove(member4ComboBox.SelectedItem);
			member3ComboBox.Items.Remove(member4ComboBox.SelectedItem);

			member4ComboBox.Enabled = false;
		}

        private ManualGroupCreationControlDataSource dataSource;
		
	}
}
