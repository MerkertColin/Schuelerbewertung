namespace GroupingAlgorithm
{
    internal class Pair
    {
        public Pupil Pupil1;
        public Pupil Pupil2;

        public double Distance;

        public Pair() { }
        public Pair(double dist)
        {
            Distance = dist;
        }
        public Pair(Pupil p1, Pupil p2, double dist)
        {
            Pupil1 = p1;
            Pupil2 = p2;
            Distance = dist;
        }
    }
}
