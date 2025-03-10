using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ConsoleApp1
{

    public enum DoorState
    {
        Closed,
        Open,
        Locked,
        PartiallyOpen
    }

    public class Door
    {
        private DoorState currentState;

        public Door()
        {
            currentState = DoorState.Closed; 
        }

        public void Open()
        {
            if (currentState == DoorState.Closed)
            {
                Console.WriteLine("Pintu dibuka.");
                currentState = DoorState.Open;
            }
            else if (currentState == DoorState.PartiallyOpen)
            {
                Console.WriteLine("Pintu sekarang terbuka sepenuhnya.");
                currentState = DoorState.Open;
            }
            else if (currentState == DoorState.Locked)
            {
                Console.WriteLine("Pintu terkunci! Buka kunci dulu.");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka.");
            }
        }

        public void Close()
        {
            if (currentState == DoorState.Open)
            {
                Console.WriteLine("Pintu ditutup.");
                currentState = DoorState.Closed;
            }
            else if (currentState == DoorState.PartiallyOpen)
            {
                Console.WriteLine("Pintu ditutup dari posisi terbuka sebagian.");
                currentState = DoorState.Closed;
            }
            else
            {
                Console.WriteLine("Pintu sudah tertutup.");
            }
        }

        public void Lock()
        {
            if (currentState == DoorState.Closed)
            {
                Console.WriteLine("Pintu dikunci.");
                currentState = DoorState.Locked;
            }
            else
            {
                Console.WriteLine("Tidak bisa mengunci! Pintu harus dalam keadaan tertutup.");
            }
        }

        public void Unlock()
        {
            if (currentState == DoorState.Locked)
            {
                Console.WriteLine("Pintu tidak lagi terkunci.");
                currentState = DoorState.Closed;
            }
            else
            {
                Console.WriteLine("Pintu tidak dalam keadaan terkunci.");
            }
        }

        public void PartiallyOpen()
        {
            if (currentState == DoorState.Closed)
            {
                Console.WriteLine("Pintu dibuka sebagian.");
                currentState = DoorState.PartiallyOpen;
            }
            else if (currentState == DoorState.Open)
            {
                Console.WriteLine("Pintu ditutup sebagian.");
                currentState = DoorState.PartiallyOpen;
            }
            else
            {
                Console.WriteLine("Tidak bisa membuka sebagian dari kondisi saat ini.");
            }
        }

        public void ShowState()
        {
            Console.WriteLine($"Status pintu saat ini: {currentState}");
        }
    }


}