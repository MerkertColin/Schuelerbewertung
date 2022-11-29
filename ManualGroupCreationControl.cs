using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Schuelerbewertung {
    public partial class ManualGroupCreationControl : UserControl {

        public ManualGroupCreationControl() {
            InitializeComponent();
        }

        public ManualGroupCreationControlDataSource DataSource {
            get => dataSource;
            set {
                if (dataSource != value) {
                    dataSource = value;
                }
            }
        }

        private void handleNextPageButtonClick(object sender, EventArgs e) {

        }

        private ManualGroupCreationControlDataSource dataSource;

    }
}
