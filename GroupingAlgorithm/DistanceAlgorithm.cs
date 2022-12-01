using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices.ComTypes;

namespace GroupingAlgorithm
{
    static class DistanceAlgorithm
    {
        /// <summary>
        /// Bildet Gruppen mit 4 Mitgliedern aus übergebenem DataTable.
        /// </summary>
        /// <param name="fillTable">DataTable soll nach Distanz der einzelnen Schüler zum Ursprung sortiert sein.
        /// Erste Spalte = SchuelerID.</param>
        public static List<GroupOfPupils> BuildGroups(DataTable fillTable)
        {
            List<Pupil> pupils = new List<Pupil>();
            List<GroupOfPupils> groups = new List<GroupOfPupils>();

            //bereiten Daten in leichter zu verarbeitende Form auf
            foreach (DataRow row in fillTable.Rows)
            {
                pupils.Add(new Pupil(row));
            }

            //eigentliches Erstellen der Gruppe
            foreach (Pupil pup in pupils)
            {
                if (pup.hasPartner == false)
                {
                    GroupOfPupils pupsGroup = new GroupOfPupils();
                    //muss manuell gemacht werden, da wir später mit Mittelwert arbeiten und dieser nicht in der Schülerklasse gefunden werden kann
                    pup.hasPartner = true;
                    pupsGroup.member.Add(pup);

                    //ermitteln Schüler mit größter Distanz
                    AddNeigbours(pup, pupils, pupsGroup, DistanceEnum.farthest);

                    //suchen Mitte und finden 2 nächste Nachbarn
                    AddNeigbours(GetMiddlePoint(pupsGroup.member[0], pupsGroup.member[1]), pupils, pupsGroup, DistanceEnum.nearest, 2);

                    groups.Add(pupsGroup);
                }
            }

            return groups;
        }

        /// <summary>
        /// Findet Nachbarn zu übergebenem Schüler und speichert diese in übergebener Gruppe.
        /// </summary>
        /// <param name="puppy">Schüler dessen Nachbar gesucht wird. Muss der Gruppe manuell zugefügt werden.</param>
        /// <param name="ClassMembers">Liste der Schüler aus der Nachbarn gesucht werden sollen.</param>
        /// <param name="gr">Gruppe in die Schüler eingetragen werden sollen.</param>
        /// <param name="dist">Sollen nächster oder entferntester Nachbar gesucht werden.</param>
        /// <param name="numberOfNeighbours">Wieviele Nachbarn soll man suchen. Standardmäßig 1.</param>
        public static void AddNeigbours(Pupil puppy, List<Pupil> ClassMembers, GroupOfPupils gr, DistanceEnum dist, int numberOfNeighbours = 1)
        { 
            for (int i = 0; i < numberOfNeighbours; i++)
            {
                Pair potentialPair = new Pair();
                Pair bestPair = new Pair(0);

                //Startdistanz darf bei nächstem Nachbarn nicht 0 sein, sonst finden wir keinen besseren Nachbarn
                if (dist == DistanceEnum.nearest)
                    bestPair.Distance = 1000000;


                foreach (Pupil member in ClassMembers)
                {
                    if (member.hasPartner == false && member.Identifier != puppy.Identifier)
                    {
                        potentialPair.Pupil1 = puppy;
                        potentialPair.Pupil2 = member;
                        potentialPair.Distance = GetDistance(member, puppy);

                        switch (dist)
                        {
                            case DistanceEnum.nearest:
                                if (potentialPair.Distance <= bestPair.Distance)
                                    bestPair = potentialPair;
                                break;
                            case DistanceEnum.farthest:
                                if (potentialPair.Distance >= bestPair.Distance)
                                    bestPair = potentialPair;
                                break;
                        }
                    }
                }

                //Damit Schüler nicht 2-Mal gepairt werden
                ClassMembers.Find(x => x.Identifier == bestPair.Pupil2.Identifier).hasPartner = true;

                gr.member.Add(ClassMembers.Find(x => x.Identifier == bestPair.Pupil2.Identifier));
            }
        }


        public static double GetDistance(DataRow row1, DataRow row2)
        {
            Pupil point1 = new Pupil(row1);
            Pupil point2 = new Pupil(row2);

            return GetDistance(point1, point2);
        }

        /// <summary>
        /// Berechnet euklidischen Abstand zweier Schüler zueinander.
        /// </summary>
        /// <returns>Ergebnis.</returns>
        public static double GetDistance(Pupil point1, Pupil point2)
        {
            double dist = 0;
            for (int i = 0; i < point1.Coordinates.Count; i++)
            {
                dist += Math.Pow(point1.Coordinates[i] - point2.Coordinates[i], 2);
            }

            return Math.Sqrt(dist);
        }

        
        public static Pupil GetMiddlePoint(DataRow row1, DataRow row2)
        {
            Pupil point1 = new Pupil(row1);
            Pupil point2 = new Pupil(row2);

            return GetMiddlePoint(point1, point2);
        }

        /// <summary>
        /// Berechnet Punkt zwischen 2 Schülern und gibt diesen zurück.
        /// </summary>
        /// <returns>Mittelpunkt beider Schüler.</returns>
        public static Pupil GetMiddlePoint(Pupil point1, Pupil point2)
        {
            Pupil middlePoint = new Pupil();

            middlePoint.Identifier = $"{point1.Identifier}_{point2.Identifier}";

            for (int i = 0; i < point1.Coordinates.Count; i++)
            {
                middlePoint.Coordinates.Add((point1.Coordinates[i] + point2.Coordinates[i]) / 2);
            }

            return middlePoint;
        }


    }

    
}
