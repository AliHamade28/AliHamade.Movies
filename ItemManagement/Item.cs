using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    internal class Movie
    {
       
        string name;
       
        

        public Movie(string name)
        {
            this.name = name;
            
             
        }

      

        public void SetName(string name)
        {
            this.name = name;
        }
       
        public string getName()
        {
            return name;
        }
       

        public static void Main(string[] args)
        {
            int choice;
            List<string> M = new List<string>(); 

    
            

            void printOptions()
            {
                Console.WriteLine("Please Choose the action you want to perform !");
                Console.WriteLine("1: Create item");
                Console.WriteLine("2: Update item");
                Console.WriteLine("3: Delete item");
                Console.WriteLine("4: Display item");
                Console.WriteLine("5: Exit \n");
            }

            do
            {
                printOptions();
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Please enter the name of the Movie you want to Add !");
                        string name=Console.ReadLine();
                      

                        M.Add(name);
                        

                        break;

                        case 2:
                        Console.WriteLine("Please enter the name of the Movie you want to Update!");
                        string Uname = Console.ReadLine();
                        Console.WriteLine("Please enter the new name to be updated");
                        string NewName = Console.ReadLine();
                        if (M.Contains(Uname))
                        {
                          int index = M.IndexOf(Uname);
                            M[index]= NewName;
                        }

                        break;

                        case 3:
                        Console.WriteLine("Please enter the name of the Movie you want to Delete !");
                        string Dname = Console.ReadLine();

                        if (M.Contains(Dname))
                        {
                            M.Remove(Dname);
                        }
                        else
                        {
                            Console.WriteLine("Movie not found!");
                        }



                        break;

                        case 4:
                        foreach(var i in M)
                        {
                          Console.WriteLine("List of Movies: "+i);
                        }
                        

                        break;

                       
                }
                
            } while (choice != 5);

           
           


        }

    }
}
