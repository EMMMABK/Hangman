using System;
using System.Collection.Generic;
using static System.Random;
using System.Text;

namespace Hangman
{
    internal class Program{
        private static void printHangman(int incorrect){
            if(incorrect==0){
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }else if(incorrect==1){
                Console.WriteLine("\n+---+");
                Console.WriteLine(" o   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }else if(incorrect==2){
                Console.WriteLine("\n+---+");
                Console.WriteLine(" o   |");
                Console.WriteLine(" |   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }else if(incorrect==3){
                Console.WriteLine("\n+---+");
                Console.WriteLine(" o   |");
                Console.WriteLine("/|    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }else if(incorrect==4){
                Console.WriteLine("\n+---+");
                Console.WriteLine(" o   |");
                Console.WriteLine("/|\\    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }else if(incorrect==5){
                Console.WriteLine("\n+---+");
                Console.WriteLine(" o   |");
                Console.WriteLine("/|\\    |");
                Console.WriteLine("/    |");
                Console.WriteLine("   ===");
            }
            else if(incorrect==6){
                Console.WriteLine("\n+---+");
                Console.WriteLine(" o   |");
                Console.WriteLine("/|\\    |");
                Console.WriteLine("/ \\ |");
                Console.WriteLine("   ===");
            }
        }
        
        private static 
        
        static void Main(string[] args){
            
        }       
    }    
}