using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Schuelerbewertung {
    public class ProjectCreationControlDataSource : INotifyPropertyChanged {
        public ProjectCreationControlDataSource() {
            var conString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", "192.168.0.241", "schuelergruppierung", "niklas_degner", "knilz");
            var con = new MySqlConnection();
            con.ConnectionString = conString;
            con.Open();
            var commandStudent = con.CreateCommand();
            commandStudent.CommandText = "SELECT * FROM schueler";
            dt = new DataTable();
            dt.Load(commandStudent.ExecuteReader());
        }

        public int GroupSize {
            get => groupSize;
            set {
                if (groupSize != value) {
                    groupSize = value;

                    EnableNextPage = value != 0;

                    OnPropertyChanged();
                }
            }
        }

        public bool AutomaticGeneration {
            get => automaticGeneration;
            set {
                if (automaticGeneration != value) {
                    automaticGeneration = value;

                    if (automaticGeneration) {
                        RandomGeneration = false;
                        ManualGeneration = false;
                    }

                    OnPropertyChanged();
                }
            }
        }

        public bool RandomGeneration {
            get => randomGeneration;
            set {
                if (randomGeneration != value) {
                    randomGeneration = value;

                    if (randomGeneration) {
                        AutomaticGeneration = false;
                        ManualGeneration = false;
                    }

                    OnPropertyChanged();
                }
            }
        }

        public bool ManualGeneration {
            get => manualGeneration;
            set {
                if (manualGeneration != value) {
                    manualGeneration = value;

                    if (manualGeneration) {
                        AutomaticGeneration = false;
                        RandomGeneration = false;
                    }

                    OnPropertyChanged();
                }
            }
        }

        public bool EnableNextPage {
            get => enableNextPage;
            set {
                if (enableNextPage != value) {
                    enableNextPage = value;
                    OnPropertyChanged();
                }
            }
        }

        public DataTable GetStudents() => dt;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private int groupSize = 4;
        private bool automaticGeneration = true;
        private bool randomGeneration = false;
        private bool manualGeneration = false;
        private bool enableNextPage = true;
        private DataTable dt;
    }
}
