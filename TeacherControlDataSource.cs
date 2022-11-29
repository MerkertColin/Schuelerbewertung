using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Schuelerbewertung {
    public class TeacherControlDataSource : INotifyPropertyChanged {

        public TeacherControlDataSource() {
            TableData.Add(new TabelData() { Name = "Colin" });
            TableData.Add(new TabelData() { Name = "Niklas" });
            TableData.Add(new TabelData() { Name = "Udo" });

            projects.Add(new ProjectData() { ProjectName = "Projekt 1", Groups = new List<string>() { "Gruppe 1", "Gruppe 2", "Gruppe 3" } });
            projects.Add(new ProjectData() { ProjectName = "Projekt 2", Groups = new List<string>() { "Gruppe 1", "Gruppe 2", "Gruppe 3" } });
            projects.Add(new ProjectData() { ProjectName = "Projekt 3", Groups = new List<string>() { "Gruppe 1", "Gruppe 2", "Gruppe 3" } });
            projects.Add(new ProjectData() { ProjectName = "Projekt 4", Groups = new List<string>() { "Gruppe 1", "Gruppe 2", "Gruppe 3" } });
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
