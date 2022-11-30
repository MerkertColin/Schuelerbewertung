using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Schuelerbewertung {
    public class ManualGroupCreationControlDataSource : INotifyPropertyChanged {
        public ManualGroupCreationControlDataSource(DataTable studentTable) {
            foreach (var item in studentTable.AsEnumerable()) {
                Students.Add(new Student() {
                    StudentID = Convert.ToInt32(item["SchuelerID"]),
                    Name = Convert.ToString(item["Name"]),
                    FirstName = Convert.ToString(item["Vorname"]),
                    Class = Convert.ToInt32(item["Klasse"]) 
                });
            }
        }

        /// <summary> Liste aller Schüler </summary>
        public List<Student> Students {
            get => students;
            set {
                if (students != value) {
                    students = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary> Liste der erstellen Gruppen </summary>
        public List<Group> Groups {
            get => groups;
            set {
                if (groups != value) {
                    groups = value;
                    OnPropertyChanged();
                }
            }
        }

        public int GroupCount => (int)Math.Ceiling(students.Count / 4.0);

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Group> groups = new List<Group>();
		private List<Student> students = new List<Student>();
	}
}
