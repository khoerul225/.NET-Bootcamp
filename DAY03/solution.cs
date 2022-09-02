 
 namespace quiz04_dotnet
 {
    class Solution
    {
 public static void DisplayList(List<string> list)
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
            var A = new List<string>();
            var B = new List<string>();
            Console.Write("Input List A (input 'x' untuk selesai): ");
            A = InputList();
            Console.Write("List A Tersimpan: ");
            DisplayList(A);
            Console.WriteLine();
            Console.Write("Input List B (tekan 'x' untuk selesai): ");
            B = InputList();
            Console.Write("List B Tersimpan: ");
            DisplayList(B);
            Console.Write("Element yang sama\t\t\t: ");
            DisplayList(Intersect(A, B));
            Console.Write("Merge element\t\t\t\t: ");
            DisplayList(Union(A, B));
            Console.Write("Element di A yang tidak sama dengan B\t: ");
            DisplayList(Except(A, B));
            Console.Write("Element yang tidak sama di A dan B\t: ");
            DisplayList(Distinct(A, B));
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
        public static void Soal2()
        {
            Console.WriteLine("---------------------------");
            var A = new List<string>();
            Console.Write("Input List A (input 'x' untuk selesai): ");
            A = InputList();
            Console.Write("Input\t: ");
            DisplayList(A);
            Console.Write("Output\t: ");
            DisplayList(Reverse(A));
        }
        public static List<string> Reverse(List<string> A)
        {
            A.Reverse();
            return A;
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
            DisplayList(RemoveDuplicate(A));
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
            DisplayList(ListAddReverse(A, B));
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
