using System.Collections.Generic;

namespace Schuelerbewertung {
    public class ProjectData {
        public string ProjectName { get; set; }

        public List<string> Groups {
            get => groups;
            set => groups = value;
        }

        private List<string> groups = new List<string>();
    }
}
