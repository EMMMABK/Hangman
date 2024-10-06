using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

namespace HangmanAppTest
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
        
        private static int printWord(List<char>guessedLetters, String randomWord){
            int count = 0;
            int correctLetters = 0;
            Console.Write("\r\n");
            foreach (char i in randomWord){
                if(guessedLetters.Contains(i)){
                    Console.Write(i + " ");
                    correctLetters++;
                }else{
                    Console.Write(" ");
                }
                count++;
            }return correctLetters;
        }
        
        private static void printLines(String randomWord){
            Console.Write("\r");
            foreach(char i in randomWord){
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305");
            }
        }
        
        static void Main(string[] args){
            Console.WriteLine("My first Hangman on C#");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>");
            Random random = new Random();
            List<String> wordDictionary = new List<String> {"apple", "banana", "car", "dog", "elephant", "flower", "guitar", 
            "house", "island", "jungle", "kite", "lemon", "mountain", 
            "notebook", "ocean", "pencil", "quilt", "rainbow", "sun", 
            "tree", "umbrella", "volcano", "waterfall", "xylophone", 
            "yacht", "zebra", "airplane", "bridge", "castle", "dolphin", 
            "engine", "forest", "garden", "helicopter", "igloo", "jacket", 
            "kangaroo", "lantern", "microphone", "nebula", "octopus", 
            "penguin", "queen", "rocket", "spaceship", "telescope", 
            "universe", "village", "whale", "x-ray", "yo-yo", "zeppelin", 
            "asteroid", "bicycle", "comet", "dragon", "explorer", "fireworks", 
            "galaxy", "horizon", "iceberg", "jellyfish", "kayak", "lighthouse", 
            "meteor", "nebula", "ostrich", "pirate", "quasar", "robot", 
            "satellite", "tornado", "ufo", "volleyball", "wildflower", "xenon", 
            "yogurt", "zeppelin", "avatar", "bonfire", "cloud", "drone", "diddy"};
            int index = random.Next(wordDictionary.Count);
            string randomWord = wordDictionary[index];

            foreach (char x in randomWord){
                Console.Write("_ ");
            }
            int lengthOfWordToGuess = randomWord.Length;
            int amountOfTimesWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;

            while(amountOfTimesWrong != 6 && currentLettersRight != lengthOfWordToGuess){
                Console.Write("\nLetters:");
                foreach(char letter in currentLettersGuessed){
                    Console.Write(letter + " ");
                }
                Console.Write("\nGuess yo:");
                char letterCorrect = Console.ReadLine()[0];
                if(currentLettersGuessed.Contains(letterCorrect)){
                    Console.Write("\nThis letter you chose already");
                    printHangman(amountOfTimesWrong);
                    currentLettersRight = printWord(currentLettersGuessed, randomWord);
                    printLines(randomWord);
                }else{
                    bool right = false;
                    for (int i=0; i < randomWord.Length; i++){
                        if(letterCorrect==randomWord[i]){
                            right = true;
                        }
                    }
                    if(right){
                         currentLettersGuessed.Add(letterCorrect);
                        currentLettersRight = printWord(currentLettersGuessed, randomWord);
                        Console.Write("\r\n");
                        printLines(randomWord);
                    }else{
                        amountOfTimesWrong += 1;
                        currentLettersGuessed.Add(letterCorrect);
                        printHangman(amountOfTimesWrong);
                        currentLettersRight = printWord(currentLettersGuessed, randomWord);
                        Console.Write("\r\n");
                        printLines(randomWord);
                    }
                }
            }
            Console.WriteLine("\r\nGame over!!!");
        }       
    }    
}