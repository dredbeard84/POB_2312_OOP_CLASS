using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_01_классы_и_методы
{
    internal class Solution
    {
        List<Train> trains;

        public Solution()
        {
            trains = new List<Train>();
        }

        public void AddTrain(Train train)
        {
            trains.Add(train);
        }

        public void Print()
        {
            for (int i = 0; i < trains.Count - 1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (trains[i].Number > trains[j].Number)
                    {
                        Train temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                }
            }

            foreach (Train t in trains)
            {
                t.Print();
            }
        }

        public Train Find(int numberOfTrain)
        {
            for (int i = 0; i < trains.Count; i++)
            {
                if (trains[i].Number == numberOfTrain)
                {
                    return trains[i];
                }
            }
            return null;
        }

        public void PrintByDestination()
        {
            for (int i = 0; i < trains.Count - 1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (trains[i].Destination!.CompareTo(trains[j].Destination) > 0)
                    {
                        Train temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                    else if (trains[i].Destination!.CompareTo(trains[j].Destination) == 0)
                    {
                        if (trains[i].TimeOfdeparture > trains[j].TimeOfdeparture)
                        {
                            Train temp = trains[i];
                            trains[i] = trains[j];
                            trains[j] = temp;
                        }
                    }
                }
            }

            foreach (Train t in trains)
            {
                t.Print();
            }
        }
    }
}