namespace quiz04_dotnet
{
    class Solution
    {
        public static void ReadInt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");

            }
            Console.WriteLine();
        }
        ///Perbaikan
        ///
        public static void a()
        {
            int[] arr = new int[10];

        }
        public static void Soal1p()
        {
            Console.Write("Masukan :");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] mat = new int[n];
            int [] s = mat.Distinct().ToArray();            
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Output");      
            Console.WriteLine(n);
        }



    public static void DisplayList(List<string> list)
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static void DisplayListt(List<int> list)
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static void DisplayListC(List<char> list)
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static void DisplayDic(Dictionary<string, int> dic)
        {
            foreach (var i in dic)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static List<string> InputList()
        {
            var list = new List<string>();
            bool done = false;
            while (!done)
            {
                string x = Console.ReadLine();
                if (x != "x" && x != "")
                {
                    list.Add(x);
                }
                else if (x == "")
                {
                    continue;
                }
                else
                {
                    done = true;
                }
            }
            return list;
        }
        public static void Soal1()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("--------------N01----------");
            Console.WriteLine("---------------------------");

            var hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };

            var r1 = new HashSet<int>(hs1);
            IEnumerable<int> both1 = r1.Intersect(hs2);
            Console.WriteLine("A irisan B)");
            foreach (var item in both1)
                Console.Write($"{item} ");
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            var r2 = new HashSet<int>(hs1);
            IEnumerable<int> both2 = r2.Union(hs2);
            Console.WriteLine("A union B");
            foreach (var item in both2)
                Console.Write($"{((short)item)}");
            both2 = r2.Union(hs1);
            Console.WriteLine(short.MinValue);
    
                
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            // union => 1,2,3,4,5,6,9
            var r3 = new HashSet<int>(hs1);
            IEnumerable<int> both3 = r3.Except(hs2);
            Console.WriteLine("A yang tidak sama dengan B");
            var both4 = r3.Except(hs1);
            foreach (var item in both3)
                Console.Write($"{item} ");
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            var r4 = new HashSet<int>(hs1);
            r4.SymmetricExceptWith(hs2); //output 3,4,5,6,9
            //Convert hashset to list
            Console.WriteLine("Yang tidak sama di A & B");
            var myNumber = r4.ToList();
            foreach (var item in myNumber)
                Console.Write($"{item} ");
            Console.WriteLine();
            Console.WriteLine("---------------------------");
        }

        public static void Soal2()
        {
            List<int> Soal2a = new List<int>();
            Soal2a.Add(1);
            Soal2a.Add(2);
            Soal2a.Add(3);
            Soal2a.Add(4);
            Console.WriteLine();
            Console.WriteLine("input");
            foreach (int x in Soal2a)
            { Console.Write($"{x} "); }
            Console.WriteLine();
            Console.WriteLine("output");
            Soal2a.Reverse();
            foreach (int y in Soal2a) { Console.Write($"{y} "); }
            Console.WriteLine();
            ///Pembatas
            List<string> Soal2b = new List<string>();
            Soal2b.Add("A");
            Soal2b.Add("BB");
            Soal2b.Add("CCC");
            Soal2b.Add("DDDD");

            Console.WriteLine();
            Console.WriteLine("input");
            foreach (string i in Soal2b)
            { Console.Write($"{i} "); }
            Console.WriteLine();
            Console.WriteLine("output");
            Soal2b.Reverse();
            foreach (string k in Soal2b) { Console.Write($"{k} "); }
            Console.WriteLine();
            Console.WriteLine();

        }


        public static void hitungBuah(string buah)
        {
            int apel = 0;
            int semangka = 0;
            string[] x = buah.Split(',');
            for (int i = 0; i < x.Length; i++)
            {
                string[] n = x[i].Split(':');
                if (n[0] == "apel")
                {
                    apel += int.Parse(n[1]);
                }
                if (n[0] == "semangka")
                {
                    semangka += int.Parse(n[1]);
                }
            }
            Console.WriteLine($"apel={apel}\tsemangka={semangka}");
        }
        public static List<string> Intersect(List<string> A, List<string> B)
        {
            var intersect = A.Intersect(B).ToList();
            return intersect;
        }
        public static List<string> Union(List<string> A, List<string> B)
        {
            var union = A.Union(B).ToList();
            union.Sort();
            return union;
        }
        public static List<string> Except(List<string> A, List<string> B)
        {
            var except = A.Except(B).ToList();
            return except;
        }
        public static List<string> Distinct(List<string> A, List<string> B)
        {
            var distinct = Union(A, B).Except(Intersect(A, B)).ToList();
            return distinct;
        }

        public static List<string> Reverse(List<string> A)
        {
            A.Reverse();
            return A;
        }

        public  static void InitHasSet()
        {
            var hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };
            var r1 = new HashSet<int>(hs1);
            IEnumerable<int> both1 = r1.Intersect(hs2);
            Console.WriteLine("-----r1---");
            foreach (var item in both1)
                Console.WriteLine(item);

        }

        public static void Soal3()
        {
            Console.WriteLine("---------------------------");
            var A = new List<string>();
            Console.Write("Input List A (input 'x' untuk selesai): ");
            A = InputList();
            Console.Write("Input\t: ");
            DisplayList(A);
            Console.Write("Output\t: ");

            DisplayList(A);
        }

        public static void Soal3b()
        {
            HashSet<int> evenNumbers = new HashSet<int>() { 1, 1, 2, 3, 4, 1, 2, 3 };
            for (int i = 0; i <evenNumbers.Count; i++)
            {
                // Populate numbers with just even numbers.
                evenNumbers.Add(i * 2);
            }
            HashSet<int> oddNumbers = new HashSet<int>() { 1, 2, 3, 4 };
            for (int i = 0; i <oddNumbers.Count ; i++)
            {

                // Populate oddNumbers with just odd numbers.
                oddNumbers.Add((i * 2) + 1);
            }



            // Create a new HashSet populated with even numbers.
            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            Console.WriteLine("numbers UnionWith oddNumbers...");
            numbers.UnionWith(oddNumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);
            DisplaySet(numbers);
        }

        private static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
        public static List<string> RemoveDuplicate(List<string> A)
        {
            var unique = A.Distinct().ToList();
            return unique;
        }
        public static void Soal4()
        {
            Console.WriteLine("---------------------------");
            var A = new List<string>();
            Console.Write("Input List A (input 'x' untuk selesai): ");
            A = InputList();
            Console.Write("Input\t: ");
            DisplayList(A);
            Console.Write("Output\t: ");
            DisplayList(FindLongestSequence(A));
        }
        public static List<string> FindLongestSequence(List<string> A)
        {
            var list = new List<string>();
            int count = 1;
            int tempcount = 1;
            int start = 0;
            for (int i = 1; i < A.Count; i++)
            {
                if (Convert.ToUInt32(A[i]) >= Convert.ToUInt32(A[i - 1]))
                {
                    count++;
                    if (i == A.Count - 1)
                    {
                        if (tempcount < count)
                        {
                            tempcount = count;
                            start = i - tempcount + 1;
                        }
                    }
                }
                else
                {
                    if (tempcount < count)
                    {
                        tempcount = count;
                        start = i - tempcount;
                    }
                    count = 1;
                }
            }
            for (int i = start; i < start + tempcount; i++)
            {
                list.Add(A[i]);
            }
            return list;
        }
        public static void Soal5()
        {
            Console.WriteLine("---------------------------");
            var A = new List<string> { "Mangga", "Apel", "Melon", "Pisang", "Sirsak", "Tomat", "Nanas", "Nangka", "Timun", "Mangga" };
            var B = new List<string> { "Bayam", "Wortel", "Kangkung", "Mangga", "Tomat", "Kembang Kol", "Nangka", "Timun" };
            Console.Write("Same\t\t: ");
            DisplayList(Intersect(A, B));
            Console.Write("Different\t: ");
            DisplayList(Distinct(A, B));
        }
        public static void Soal6()
        {
            Console.WriteLine("---------------------------");
            var A = new List<string>();
            Console.Write("Input List A (input 'x' untuk selesai): ");
            A = InputList();
            Console.Write("Input\t: ");
            DisplayList(A);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            A.Sort();
            int count = 1;
            for (int i = 0; i < A.Count; i++)
            {
                string x = A[i];
                if (i < A.Count - 1 && x == A[i + 1])
                {
                    count++;
                }
                else if (i == A.Count - 1 && x == A[i - 1])
                {
                    dic.Add(x, count);
                }
                else
                {
                    dic.Add(x, count);
                    count = 1;
                }
            }
            Console.Write("Result\t: ");
            DisplayDic(dic);
            Console.Write("Output\t: ");
            foreach (var i in dic)
            {
                if (i.Value == dic.Values.Max())
                {
                    Console.Write($"{i.Key} ");
                }
            }
        }
        public static void Soal7()
        {
            Console.WriteLine("---------------------------");
            var A = new List<string>();
            var B = new List<string>();
            Console.Write("Input List A (input 'x' untuk selesai): ");
            A = InputList();
            Console.Write("A\t: ");
            DisplayList(A);
            Console.Write("Input List B (input 'x' untuk selesai): ");
            B = InputList();
            Console.Write("B\t: ");
            DisplayList(B);
            Console.Write("Output\t: ");
            DisplayList(ListAddition(A, B));
        }
        public static List<string> ListAddition(List<string> A, List<string> B)
        {
            string a = "";
            string b = "";
            var R = new List<string>();
            foreach (var i in A)
            {
                a += i;
            }
            foreach (var i in B)
            {
                b += i;
            }
            int numbA = Convert.ToInt32(a);
            int numbB = Convert.ToInt32(b);
            int numbR = numbA + numbB;
            string r = Convert.ToString(numbR);
            for (int i = 0; i < r.Length; i++)
            {
                R.Add(Convert.ToString(r[i]));
            }
            return R;
        }
        public static void Soal8()
        {
            Console.WriteLine("---------------------------");
            var B = new List<int>();
            List<int> A = new List<int>();
            A.Add(1);
            A.Add(2);
            A.Add(3);
            Console.WriteLine();
            Console.WriteLine("input");
            foreach (int x in A)
            { Console.Write($"{x} "); }
            Console.WriteLine();
            Console.WriteLine("output");
            A.Reverse();
            foreach (int y in A) { Console.Write($"{y} "); }
            Console.WriteLine();


        }
        public static List<string> ListAddReverse(List<string> A, List<string> B)
        {
            string a = "";
            string b = "";
            var R = new List<string>();
            foreach (var i in A)
            {
                a += i;
            }
            A.Reverse();
            foreach (var i in B)
            {
                b += i;
            }
            B.Reverse();
            int numbA = Convert.ToInt32(a);
            int numbB = Convert.ToInt32(b);
            int numbR = numbA + numbB;
            string r = Convert.ToString(numbR);
            for (int i = 0; i < r.Length; i++)
            {
                R.Add(Convert.ToString(r[i]));
            }
            R.Reverse();
            return R;
        }
        public static void Soal9()
        {

            Console.WriteLine("---------------------------");
            Console.Write("Input1\t: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Count\t: ");
            int c = Convert.ToInt32(Console.ReadLine());
            DisplayList(CountSequence(x, c));
        }
        public static List<string> CountSequence(int currentValue, int sequenceLength)
        {
            var A = new List<string>();
            for (int i = currentValue; i < currentValue + sequenceLength; i++)
            {
                A.Add(Convert.ToString(i));
            }
            return A;
        }


    }
}