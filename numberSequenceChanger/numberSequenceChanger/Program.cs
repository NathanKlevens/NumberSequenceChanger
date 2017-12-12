using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberSequenceChanger
{
    class Program
    {
        static void Main(string[] args)
        {

            //first ask the user for how many numbers they want to enter
            //then store that many numbers
            //once youve store the users numbers, display them on 1 line with a number in front to show what space the number is
            //EX: 1) 535 2) 7  3) 726 4) 536
            //then ask the user what option they would like to do to their number sequence
            //they can either:
            //1) swap 2 numbers in the sequence
            //2) reverse the sequence
            //3) scramble the sequence
            //4) exit
            Random randomNumberGenerator = new Random();
            bool exit = false;
            List<int> nums = new List<int>();
            //first ask the user for how many numbers they want to enter
            //then store that many numbers
            Console.WriteLine("How many #s?");
            int numAmount = int.Parse(Console.ReadLine());
            for(int i = 0; i < numAmount; i++)
            {
                Console.WriteLine("Number {0} = ", i + 1);
                int add = int.Parse(Console.ReadLine());
                nums.Add(add);
            }
            
            while(!exit)
            {
                //once youve store the users numbers, display them on 1 line with a number in front to show what space the number is
                for (int i = 0; i < nums.Count; i++)
                {
                    Console.WriteLine(i + 1 + ") " + nums[i]);
                }
                //then ask the user what option they would like to do to their number sequence
                Console.WriteLine("1) swap 2 numbers in the sequence 2) reverse the sequence 3) scramble the sequence 4) exit");
                int optionChoice = int.Parse(Console.ReadLine());

                //1) swap 2 numbers in the sequence
                if (optionChoice == 1)
                {
                    Console.WriteLine("Which numbers? (choose the number before the parentheses)");
                    int swap1 = int.Parse(Console.ReadLine());
                    int swap2 = int.Parse(Console.ReadLine());
                    int bucket = nums[swap1-1];
                    nums[swap1-1] = nums[swap2-1]; 
                    nums[swap2-1] = bucket;
                    
                }
                //2) reverse the sequence
                if(optionChoice == 2)
                {
                    for(int i = 0; i < nums.Count/2; i++)
                    {
                        int bucket = nums[i];
                        nums[i] = nums[nums.Count - 1 - i];
                        nums[nums.Count - 1 - i] = bucket;
                    }
                }
                //3) scramble the sequence
                if(optionChoice == 3)
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                     
                        int ranNum = randomNumberGenerator.Next(0, nums.Count);
                        if(i != ranNum)
                        {
                            int bucket = nums[i];
                            nums[i] = nums[ranNum];
                            nums[ranNum] = bucket;
                        }
                        else
                        {
                            i--;
                        }
                        
                    }
                }
                //4) exit
                if(optionChoice == 4)
                {
                    exit = true;
                }
            }
        }
    }
}
