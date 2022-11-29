using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Schuelerbewertung {
    public class ProjectCreationControlDataSource : INotifyPropertyChanged {

        public int GroupSize {
            get => groupSize;
            set {
                if (groupSize != value) {
                    groupSize = value;
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private int groupSize;
        private bool automaticGeneration = true;
        private bool randomGeneration = false;
        private bool manualGeneration = false;
    }
}
