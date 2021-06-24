using System;
using System.Collections.Generic;
using System.Linq;


namespace Airline
{
    class Program
    {



        public enum SeatPosition
        {
            Aisle,
            Middle,
            Window
        }
        public struct Seat
        {
            public string SeatNumber; // 10a, 10b, 10c, 10d ..10f
            public SeatPosition SeatPosition; // window(a & f), middle(b & e), aisle (c & d)
            public bool IsAvailable;  //aisle not available
        }

        public class Plane
        {

            const int NumberRows = 10;
            const int TotalSeats = NumberRows * SeatPerRow;
            const int SeatPerRow = 6;
            public string TailNumber = "NN8040";
            public string FlightNumber = "1";
            public Seat[] Seats = new Seat[TotalSeats];

            public Plane()
            {

                string[] letter = { "A", "B", "C", "D", "E", "F" };

                for (int i = 0; i < TotalSeats;)
                {
                    for (int j = 1; j < SeatPerRow + 1; j++)
                    {
                        Seats[i].SeatNumber = $"{i+ 1}{letter[j - 1]}";
                        if (j == 1 || j == 6)
                        {
                            Seats[i].SeatPosition = SeatPosition.Window;
                            Seats[i].IsAvailable = true;
                        }
                        if (j == 2 || j == 5)
                        {
                            Seats[i].SeatPosition = SeatPosition.Middle;
                            Seats[i].IsAvailable = true;
                        }
                        if (j == 3 || j == 4)
                        {
                            Seats[i].SeatPosition = SeatPosition.Aisle;
                            Seats[i].IsAvailable = false;
                        }
                        i++;
                    }
                }
            }
            public void PrintAvailableSeats()
            {
                Console.WriteLine("Seat Available:");
                foreach (Seat seat in Seats)
                {
                    if (seat.IsAvailable)
                    {
                        Console.WriteLine($"{seat.SeatNumber} : {seat.SeatPosition}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Plane NelnetPrivate = new Plane();
            NelnetPrivate.PrintAvailableSeats();

        }

        // class constructors in C#


    }
}
