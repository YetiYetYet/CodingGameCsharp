
namespace CodingameCSharp
{
    internal class Program
    {
        // Attribute visible from other class
        #region question1
        // Str is  visible from B ?
        class A
        {
            private string str;
            public string str2;
        };

        class B : A
        {
            
        }
        // False
        // Explain : We need a getter or a setter
        
        #endregion

        // Garbage Collector
        #region question2
        // Does garbage collection guarantee that a program will not run out of memory?
        // False 
        // The purpose of garbage collection (GC) is to identify and discard objects that are no longer needed by a program
        // , so that their resources can be reclaimed and reused.
        #endregion
        
        //Bitwise Shift Operators (Decalage de bit)
        #region question3
        // What the result of 1 << 2
        // 4
        // 0001 << 2 == 0100 (4)
        // 1 << 1 = 2; 1 << 2 = 4; 1 << 3 = 8; 1 << 4 = 16...
        #endregion
        
        //floating point inaccuracy (sum("-1.001", "1.01") return 0.0090000000000000012 why ?
        #region question4
        // Initial code :
        class Calculator 
        {
            /// Sums an Array of numbers.
            /// <returns> the exact sum of numbers </returns>
            public static string Sum(params string[] numbers) // Param permet juste de mettre des argument directement Sum(1,2,5,8)
            {
                double total = 0;
                foreach (var number in numbers)
                {
                    total = total + double.Parse(number);
                }

                return total.ToString();
            }
            
        }
        // Reponse :
        class CalculatorModified
        {
            /// Sums an Array of numbers.
            /// <returns> the exact sum of numbers </returns>
            public static string Sum(params string[] numbers) // Param permet juste de mettre des argument directement Sum(1,2,5,8)
            {
                decimal total = 0;
                foreach (String number in numbers)
                {
                    total = total + Decimal.Parse(number);
                }

                return total.ToString();
            }
        }
        // Explain : 
        // Use Decimal if you want precise floating value
        // For example : A certain loss of precision is acceptable in many scientific calculations because of the practical limits of the physical problem or artifact being measured. Loss of precision is not acceptable in finance.
        #endregion
        
        // name of System.Text wich allows to concatenante efficiently string of characters
        #region question5
        // Type the name of a class belonging to the namespace System.Text wich allows to concatenante efficiently string of characters
        //Response : StringBuilder
        #endregion

        // What does the following code displays ?
        #region question6
        public static void question6()
        {
            string[] fruits = {"apple", "orange", "apricot", "kiwi"};
            List<string> list = new List<string>(fruits);
            IEnumerable<string> query = list.Where(c => c.Length == 4);
            list.Remove("kiwi");
            Console.WriteLine(query.Count());
        }
        // response : 0
        #endregion

        // What the value of s ?
        #region question7
        public static void question7()
        {
            string s = "A";
            s.ToLower();
            Console.WriteLine(s);
        }
        // explain : ToLower return a copy of this string
        #endregion
        
        //General Contract of GetHashCode
        #region question8
        // The general contract of GetHashCode says that two objects having the same hashcode must be equals
        // Response : False
        // If two objects have the same hashcode then they are NOT necessarily equal. Otherwise you will have discovered the perfect hash function.
        // But the opposite is true: if the objects are equal, then they must have the same hashcode.
        #endregion
        
        // SQLDataReader sdr[0]
        #region question9
        // What is the 0 in sdr[0] ?
        public static void question9()
        {
            /*private SqlCommand cmd = new SqlCommand("SELECT col1 FROM table1", conn);
            private SqlDataReader sdr = cmd.ExecuteReader();
            if(sdr.Read())
            {
                string s = sdr[0];
            }*/
        }
        
        // response : Not sure but probably the first line in the SqlDataReader
        // https://docs.microsoft.com/fr-fr/dotnet/framework/data/adonet/retrieving-data-using-a-datareader
        #endregion
        
        // SortedDictionary iterating over values
        #region question10
        // What is the sequence obtained by iterating over sd.values ?
        static void question10()
        {
            SortedDictionary<int, int> sd = new SortedDictionary<int, int>();
            sd[3] = 3;
            sd[2] = 1;
            sd[1] = 2;
            foreach (var value in sd.Values)
            {
                Console.WriteLine(value);
            }
        }
        // Response : 2 1 3 
        //Explain : Represents a collection of key/value pairs that are sorted on the key.
        #endregion
        
        // value return by Read() when end of stream is reached
        #region question 11
        // What is the value returned by Read() when the end of a stream has been reached ?
        // Response : -1
        #endregion
        
        // Exeption belongs to the .Net API for C#
        #region question12
        /* Which exception(s) belongs to the .Net API for C#
         Yes -> NullReferenceException : C# base
         Yes -> IndexOutOfRangeExeption : Que sur dotnet
         No -> NullPointerExeption */
        
        #endregion
        
        // HashSet = value return by HhashSet.Count ?
        #region question13
        // What is the value returned by hashSet.Count ?
        static void question13()
        {
            var hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(1);
            hashSet.Add(2);
            Console.WriteLine("Question 13 : " + hashSet.Count());
        }
        // Response : 2
        // Explain : HashSet is a set of collection that contains no duplicate elements and there is no specific order for the elements stored in it.
        #endregion
        
        // What is the value returned by hashSet.Count ?
        #region question14
        // What is the value returned by hashSet.Count ?
        static void question14()
        {
            var list = new List<int>(2);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            Console.WriteLine("Question 14 : " + list.Count());
        }
        // Response : 3
        // Explain : First argument is the capacity before resize the list (never seen an example of this use)
        #endregion
        
        // i++
        #region Question15
        public static void question15()
        {
            int i = 0;
            Console.WriteLine("question15 = " + i++);
        }
        // Response : 0
        // Explain : The result of x++ is the value of x before the operation
        #endregion
        
        // WaterTank, concurrent threads (Not resolved)
        #region question16
        /*A WaterTankMonitor aims at monitoring the acces to a Watertank, wich is either "empty" or "full" (i.e "not Empty")
         An instance of WaterTankMonitor is shared by concurrent threads, operating at random periods of time and in an unpredictable order.
         These threads belong to one of these two families :
            - the consumers (They want to empty the water tank) or,
            - the provider (they want to fill the water tank)
        The problem is to make sure that the producers will not try to fill the tank if it's full and that the consumers will not try to get water from the tank if it's empty.
        Update WaterTankMonitor to implement an elegant solution.*/

        public class WaterTankMonitor
        {
            /// The water tank that this class monitors
            private WaterTank tank;

            public WaterTankMonitor(WaterTank tank)
            {
                this.tank = tank;
            }

            public void Empty()
            {
                while (tank.IsEmpty())
                {
                    
                }
                tank.SetEmpty(true);
            }

            public void Fill()
            {
                while (!tank.IsEmpty())
                {
                    
                }
                tank.SetEmpty(false);
            }
        }

        public class WaterTank
        {
            private bool empty = true;

            public virtual bool IsEmpty()
            {
                return empty;
            }

            public virtual void SetEmpty(bool isEmtpy)
            {
                empty = isEmtpy;
            }
        }

        public static void question16()
        {
            WaterTank tank = new WaterTank();
            WaterTankMonitor monitor = new WaterTankMonitor(tank);
            monitor.Fill();
            monitor.Empty();
        }
        #endregion
        
        // Universe-formula found path of a file in nested sub-folder
        #region question17
        public class question17
        {
            public static string LocateUniverseFormula()
            {
                string dir = @"C:\Users\yeti9\Desktop\All Project\Project_NET\CodinGameCSharp\CodingameCSharp\CodingameCSharp\tmp\documents";
                var files = Directory.GetFiles(dir, "universe-formula", SearchOption.AllDirectories);
                if (files.Length > 0)
                {
                    return files[0];
                }
                else
                {
                    return null;
                }
            }
        }
        

        #endregion
        
        //You are implementing a method wich returns an array of files belongings to a folder.
        //Among these options, which behavior is usually the most appropriate in case of an ampty folder ?
        #region question18
        //You are implementing a method wich returns an array of files belongings to a folder.
        //Among these options, which behavior is usually the most appropriate in case of an empty folder ?
        // -> The method should throw an exception
        // -> The method should return null
        // -> The method should return an empty array
        
        //response : Empty Array (C# do this for his function) Microsoft officially recommends in its Guidelines for Collections to 'NOT return null values from methods returning collections'.
        #endregion
        
        // Type the name of the design pattern illustrated nby this piece of code (one world only)
        #region question19
        /*
            private FileStream fin = new FileStream("X.zip", FileMode.Create);
            private BufferedStream bin = new BufferedStream(fin);
            private GZipStream zin = new GZipStream(bin);
        */

        // response : Decorator
        #endregion

        // Singleton Type the name of the design pattern illustrated nby this piece of code (one world only)
        #region question20
        public sealed class question20
        {
            private static volatile question20 instance;
            private static object syncRoot = new object();
            
            private question20(){}

            public static question20 Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (syncRoot)
                        {
                            if (instance == null)
                                instance = new question20();
                        }
                    }
                    return instance;
                }
            }
        }
        // Response : Singleton
        #endregion

        // Interface (ArrayList or IList
        #region question21
        // Among the method declarations, which is usually the preferred one ?
        // -> public ArrayList GetOrders()
        // -> public IList GetOrders()
        
        // response : Probably Ilist cause it's "type safe" and have more performance
        #endregion
        
        /// <summary>
        /// Test 30/03/2021
        /// </summary>

        
        public static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            // var str1 = b.str not working
            var str2 = b.str2;
            Console.WriteLine(1 << 2);
            
            Console.WriteLine(Calculator.Sum("-1,001", "1,01"));
            Console.WriteLine(CalculatorModified.Sum("-1,001", "1,01"));
            question6();
            question7();
            question10();
            question13();
            question14();
            question15();
            question16();
            Console.WriteLine(question17.LocateUniverseFormula());
        }
    }
}