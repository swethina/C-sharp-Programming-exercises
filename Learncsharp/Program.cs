using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learncsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Fibonnaci();
            String str = Console.ReadLine();
            Console.WriteLine(reverseString(str));
            Palindrome(str);
            reverseWords(str);
            reverseEachword(str);
            OCCURANCES();
            RemoveDuplicates();
            subString();
            ARRAY();
            int[] arr = { 1, 2, 3, 4, 5 };
            RightArrayRotation(arr);
            Prime();
            Sum();
            int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            twoDto1D(array);
            int n = Convert.ToInt32(Console.ReadLine());
            fizzBuzz(n);
            AddNote(" ggs","Hello");
        }

        // How to reverse a string?
        public static string reverseString(string str)

        {
            String r = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                r += str[i];
            }
            return r;

        }

        //How to find if the given string is a palindrome or not?
        public static void Palindrome(string str)
        {
            if (str == reverseString(str))
            {
                Console.WriteLine("is a Palindrome");
            }
            else
            {
                Console.WriteLine("not a Palindrome");
            }
        }


        //Fibonacci
        public static void Fibonnaci() //0,1,1,2,3,5,8,13,21...
                                       // prev + next

        {
            int prev = 0;
            int next = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(next);
                if (next == 0)
                {
                    prev = 0;
                    next = 1;
                }
                else
                {
                    int temp = next;
                    // temp = 1
                    //temp= 1
                    // temp = 2

                    next = next + prev;
                    //next = 1 + 0 = 1
                    //next = 1 + 1 = 2
                    // next = 2 + 1 = 3
                    prev = temp;
                    // prev = 1
                    // prev = 1
                    // prev = 2
                }
            }
        }

        //How to reverse the order of words in a given string?
        public static string reverseWords(string str)
        {
            //using list Hi Swetha ->Swetha Hi
            List<String> str1 = str.Split(' ').ToList();
            List<String> str2 = new List<string>();

            for (int i = str1.Count - 1; i >= 0; i--)
            {
                str2.Add(str1[i]);
            }
            /* foreach(String str3 in str2)
             {
                 Console.WriteLine(str3);
             }*/

            String fina = String.Join(' ', str2);
            Console.WriteLine(fina);
            return fina;



        }
       // How to reverse each word in a given string?
        public static string reverseEachword(string str)
        {
            // String str = "Hi Swetha"; // to change to ih ahtews
            List<String> list1 = str.Split(' ').ToList();
            List<String> list2 = new List<String>();
            for (int i = 0; i < list1.Count; i++)
            {
                list2.Add(reverseString(list1[i]));

            }
            String final = String.Join(" ", list2);
            Console.WriteLine(final);
            return final;
        }

        // How to count the occurrence of each character in a string?
        public static void OCCURANCES()
        {
            
            String str = "occu";
            int count = 1;

            IDictionary<char, int> dict1 = new Dictionary<char, int>();
            foreach (var i in str)
            {
                if (dict1.ContainsKey(i))
                {
                    dict1[i] = count + 1;
                }
                else
                {
                    dict1.Add(i, count);
                }
            }

            foreach (var c in dict1)
            {
                Console.WriteLine(c.Key + " appears " + c.Value + " times");
     

            }


        }

        // How to remove duplicate characters from a string?
        public static void RemoveDuplicates()
        {

            String str = "aashitha";//output = hello
            String str1 = "";
                for (int i = 0; i < str.Length; i++)
            {
                if(!str1.Contains(str[i]))
                {
                    str1 += str[i];
                }
            }
                Console.WriteLine(str1);
        }

        //: How to find all possible substring of a given string?
        public static void subString()
        {
            String str = "abc";
            //String str1 = "";
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }
        //Left array rotation
        public static void ARRAY()
        {
            int[] array1 = new int[] { 1, 2, 4, 5, 6 };
            int size = array1.Length;
            for (int i = size -1; i > 0; --i)
            {
                // Console.WriteLine(array1.Length - 1);
                int temp = array1[size - 1];
                array1[size - 1] = array1[i - 1];
                array1[i - 1]= temp;
            }

            foreach (int num in array1)
            {
                Console.Write(num + " ");
            }
        }
        //Right array rotation
        public static void RightArrayRotation(int[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size-1; ++i)
            {
                int temp = arr[0];
                arr[0]= arr[i+1];
                arr[i+1]= temp;

            }
            foreach (int num in arr)
            {
                Console.Write(num + "");
            }

        }

        //How to find if a positive integer is a prime number or not?
        public static void Prime()
        {
            int num = Convert.ToInt32(Console.ReadLine());
           
            var sqrt = (int)(Math.Floor(Math.Sqrt(num)));

            if (num == 0)
                Console.WriteLine("Not prime");
            else if (num == 1)
                Console.WriteLine("Not prime");
            else if (num % 2 == 0)
                Console.WriteLine("Not prime");
            for (int i = 3; i <= sqrt; i +=2)
            {
                if (num % i == 0)
                    Console.WriteLine("Not prime");
                else
                    Console.WriteLine("Prime");
            }
            
}
        // How to find the sum of digits of a positive integer?
        public static void Sum()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
           while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
            

        }
        //How to convert a two-dimensional array to a one-dimensional array?
        public static void  twoDto1D(int[,] array)
        {
            int index = 0;
            int[] array1= new int[array.GetLength(1)* array.GetLength(0)];
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {

                    array1[index]= array[j,i];
                    Console.WriteLine(array1[index] + " ");
                    index++;
                    
                }

            }
        
        }

        //Prints numbers 1 to 100.
        //Prints "Fizz" for multiples of three.
        //Prints "Buzz" for multiples of five.
        //Prints "FizzBuzz" for multiples of both three and five.
        public static void fizzBuzz(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                        {
                    Console.WriteLine("fIZZbUZZ");
                 }
                else if ((i % 3 == 0) && (!(i % 5 == 0))){
                    Console.WriteLine("fIZZ");
             }
                else if ((!(i % 3 == 0)) && ((i % 5 == 0)))
                {
                    Console.WriteLine("BuzZZ");
                }


                else if ((!(i % 3 == 0)) && (!(i % 5 == 0)))
                {
                    Console.WriteLine(i);
                }
            }

                }
        public  static void AddNote(String state, String name)
        {
            Dictionary<String, String> note = new Dictionary<String, String>();
            
                if (state == "active")
                {
                    note.Add(state, name); 
                }
                else if (state == "completed")
            {
                    note.Add(state, name);


                }
                else if (state == "others")
                {
                    note.Add(state, name);

                }
                else if (state == " ")
                {
                    Console.WriteLine("Name cannot be empty");


                }
                else
                {
                Console.WriteLine("Invalid state"+ state);


                }

            }

        }
    }
        



    





               
            
        

        

        
    

    


    
    
        
    

