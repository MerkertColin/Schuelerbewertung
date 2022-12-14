using System.ComponentModel;
using System.Windows.Forms;

namespace Schuelerbewertung {
    public partial class ProjectCreationControl : UserControl {

        public ProjectCreationControl() {
            InitializeComponent();

            DataSource = new ProjectCreationControlDataSource();
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ProjectCreationControlDataSource DataSource {
            get => dataSource;
            set {
                if (dataSource != value) {
                    dataSource = value;

                    intializeDataBinding();
                }
            }
        }

        private void intializeDataBinding() {
            groupSizeSpinEdit.DataBindings.Add(nameof(groupSizeSpinEdit.Value), dataSource, nameof(dataSource.GroupSize));
            automaticRadioButton.DataBindings.Add(nameof(automaticRadioButton.Checked), dataSource, nameof(dataSource.AutomaticGeneration));
            randomRadioButton.DataBindings.Add(nameof(randomRadioButton.Checked), dataSource, nameof(dataSource.RandomGeneration));
            manuelRadioButton.DataBindings.Add(nameof(manuelRadioButton.Checked), dataSource, nameof(dataSource.ManualGeneration));
        }

        private ProjectCreationControlDataSource dataSource;
    }
}
