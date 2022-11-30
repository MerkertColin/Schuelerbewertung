using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Schuelerbewertung {
    public class TeacherControlDataSource : INotifyPropertyChanged {

        public TeacherControlDataSource() {

        }

        public BindingList<TabelData> TableData {
            get => tableData;
            set {
                if (tableData != value) {
                    tableData = value;
                    OnPropertyChanged();
                }    
            }
        }

        public BindingList<ProjectData> Projects {
            get => projects;
            set {
                if (projects != value) {
                    projects = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private BindingList<TabelData> tableData = new BindingList<TabelData>();
        private BindingList<ProjectData> projects = new BindingList<ProjectData>();
    }
}
