using System.Collections.Generic;

namespace Schuelerbewertung {
	public class Group {
		public int GroupID {
			get; set;
		}

		public int ProjectID {
			get; set;
		}

		public string GroupName {
			get; set;
		}

		public List<Student> Students {
			get; set;
		}
	}
}
