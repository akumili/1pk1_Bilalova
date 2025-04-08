using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_21_05
{
    internal class TrainSystem
    {
        private readonly Dictionary<int, string> seats;

        public TrainSustem (int totalSeats)
        {
            seats = new Dictionary<int, string>();
            for (int i = 1; i <= totalSeats; i++)
            {
                seats[i] = null; //  изначально свободны dct vtcnf
            }
        }

        // Резервирвируем билет
        public void ReserveTicket(int seatNumber, string passengerName)
        {
            if (seats.ContainsKey(seatNumber) && seats[seatNumber] == null)
            {
                seats[seatNumber] = passengerName;
                Console.WriteLine($"Место уже {seatNumber} зарезервировано для {passengerName}.");
            }
            else
            {
                Console.WriteLine($"Ошибка: Место {seatNumber} занято или не существует.");
            }
        }

        // Освобождеаем место
        public void ReleaseTicket(int seatNumber)
        {
            if (seats.ContainsKey(seatNumber) && seats[seatNumber] != null)
            {
                Console.WriteLine($"Место {seatNumber} освобождено.");
                seats[seatNumber] = null;
            }
            else
            {
                Console.WriteLine($"Ошибка: Место {seatNumber} уже свободно/не существует.");
            }
        }

        // Отчет о занятых местах
        public void ShowReservedSeats()
        {
            Console.WriteLine("Занятые места:");
            foreach (var seat in seats)
            {
                if (seat.Value != null)
                {
                    Console.WriteLine($"Место {seat.Key}: {seat.Value}");
                }
            }
        }
    }
}


