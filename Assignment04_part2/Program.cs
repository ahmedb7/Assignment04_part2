using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // random number generator
            Random rand= new Random();
            bool[] seats = new bool[10];
            
            //To keep a separate list of seats taken         
            List<int> firstSeatsBooked = new List<int>();
            List<int> economySeatsBooked = new List<int>();
            int inputI = 0;
            char inputS = ' ';
            bool quit = false;
            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("           Please type [1] for First Class                 ");
                Console.WriteLine("           Please type [2] for Economy Class               ");
                Console.WriteLine("           Please type [3] to exit the order system        ");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("You entered: ");
                inputI = Int32.Parse(Console.ReadLine());
                switch (inputI)
                {
                    case 1:                                                
                        int seatAssign1; 
                        if (firstSeatsBooked.Count == 0) //if this is the first seat to be booked
                        {
                            seatAssign1 = rand.Next(0, 5);
                            seats[seatAssign1] = true;
                            firstSeatsBooked.Add(seatAssign1);                             
                        }
                        else
                        {
                            do //while there are available seats and current seat has not being assigned before.
                            {
                                seatAssign1 = rand.Next(0, 5);
                                if (!firstSeatsBooked.Contains(seatAssign1)) 
                                {
                                    seats[seatAssign1] = true;                                   
                                }
                                //repeat while the random seat number is already booked and there are  avaialable seats
                            } while (firstSeatsBooked.Contains(seatAssign1) && firstSeatsBooked.Count < 5);

                            if (firstSeatsBooked.Count < 5) 
                            {
                                firstSeatsBooked.Add(seatAssign1); 
                            } 
                        }
                        //
                        if (firstSeatsBooked.Count >= 5)
                        {
                            Console.WriteLine("All seats for First Class are booked!");
                            Console.WriteLine();
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine("   If it’s acceptable to be placed in the economy-class?   ");
                            Console.WriteLine("   Please type [y] for Economy Class                       ");                            
                            Console.WriteLine("   Please type [n] to exit the order systemy               ");
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                            Console.Write("You entered: ");
                            inputS = Char.Parse(Console.ReadLine());                           
                            if (inputS == 'y')
                            {
                                Console.WriteLine("Press enter to continue...");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("           Next flight leaves in 3 hours.                  ");
                                Console.WriteLine("           Press enter to continue...                      ");
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your seat is: {0}", seatAssign1 + 1);
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue...");
                        }
                        Console.ReadLine();
                        break;
                    case 2:
                        int seatAssign2;
                        if (economySeatsBooked.Count == 0) 
                        {
                            seatAssign2 = rand.Next(5, 10);
                            seats[seatAssign2] = true;
                            economySeatsBooked.Add(seatAssign2);                             
                        }
                        else
                        {
                            do //while there are available seats and current seat has not being assigned before.
                            {
                                seatAssign2 = rand.Next(5, 10);
                                if (!economySeatsBooked.Contains(seatAssign2)) 
                                {
                                    seats[seatAssign2] = true;
                                }
                                //repeat while the random seat number is already booked and there are  avaialable seats
                            } while (economySeatsBooked.Contains(seatAssign2) && economySeatsBooked.Count < 5);

                            if (economySeatsBooked.Count < 5) //if seatsBooked list is not full for Economy Class
                            {
                                economySeatsBooked.Add(seatAssign2); //Add current random-generated seat to the list.
                            }
                        }
                        if (economySeatsBooked.Count >= 5)
                        {
                            Console.WriteLine("All seats for Economy Class are booked");
                            Console.WriteLine();
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine("   If it’s acceptable to be placed in the First-class?     ");
                            Console.WriteLine("   Please type [y] for First Class                         ");
                            Console.WriteLine("   Please type [n] to exit the order systemy               ");
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                            Console.Write("You have entered: ");
                            inputS = Char.Parse(Console.ReadLine());
                            if (inputS == 'y')
                            {
                                Console.WriteLine("Press enter to continue...");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("          Next flight leaves in 3 hours.                  ");
                                Console.WriteLine("           Press enter to continue...                       ");
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your seat is: {0}", seatAssign2 + 1);
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue...");
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("ERROR:INVALID SELECTION");
                        quit = true;
                        break;
                }
            } 

            waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("                  Press any key to continue...             ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ReadKey();
            Console.Clear();
        }
        }
    }

