namespace Schuelerbewertung {
	public class Student {
		public int StudentID { get; set; }
		public string Name { get; set; }
		public string FirstName { get; set; }
		public int Class { get; set; }

		public override string ToString() {
			return string.Format("{0}, {1}", Name, FirstName);
		}
	}
}
