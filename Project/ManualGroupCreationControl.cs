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
                    intializeDataBindings();
                }
            }
        }

		private void initializeComboxes() {
			member1ComboBox.Items.AddRange(dataSource.Students.ToArray());
			member2ComboBox.Items.AddRange(dataSource.Students.ToArray());
			member3ComboBox.Items.AddRange(dataSource.Students.ToArray());
			member4ComboBox.Items.AddRange(dataSource.Students.ToArray());
		}

		private void intializeDataBindings() {

		}

		private void handleNextPageButtonClick(object sender, EventArgs e) {

        }

        private void handleMember1ComboBoxSelectedIndexChanged(object sender, EventArgs e) {
            member2ComboBox.Items.Remove(member1ComboBox.SelectedItem);
            member3ComboBox.Items.Remove(member1ComboBox.SelectedItem);
            member4ComboBox.Items.Remove(member1ComboBox.SelectedItem);

            member1ComboBox.Enabled = false;
        }

        private void handleMember2ComboBoxSelectedIndexChanged(object sender, EventArgs e) {

        }

        private void handleMember3ComboBoxSelectedIndexChanged(object sender, EventArgs e) {

        }

        private void handleMember4ComboBoxSelectedIndexChanged(object sender, EventArgs e) {

        }

        private ManualGroupCreationControlDataSource dataSource;
		
	}
}
