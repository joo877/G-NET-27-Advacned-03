using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Collection_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List

            //List<int> grads = [85, 92, 78, 95, 88, 70, 100, 65];

            // print all grades

            //foreach (var grad in grads)
            //{
            //    Console.WriteLine(grad);
            //}

            // count of list

            //Console.WriteLine($" Count : {grads.Count}");

            // first and last grade

            //Console.WriteLine(grads[0]);
            //Console.WriteLine(grads[^1]);



            // sort the list

            //grads.Sort();
            //foreach (var grad in grads)
            //{
            //    Console.WriteLine(grad);
            //}

            //Get the first grade above 90

            //Console.WriteLine( grads.Find(x => x > 90 ));

            // Get all grades below 75 (failing grades)

            //List<int> SuccessGrades = grads.FindAll(x => x < 75);
            //foreach (var grade in SuccessGrades)
            //{
            //    Console.WriteLine(grade);
            //}


            //Remove all failing grades (below 75)

            //grads.RemoveAll(x => x < 75);
            //foreach (var grad in grads)
            //{
            //    Console.WriteLine(grad);
            //}


            //Check if any grade equals 100

            //Console.WriteLine(grads.Contains(100));

            //List<string> marks = grads.ConvertAll(x =>$"Grade:{x.ToString()} " );
            //foreach (var mark in marks)
            //{
            //    Console.WriteLine(mark);
            //}
            #endregion

            #region SortedList
            //SortedList<int, string> LeaderBoard = new()
            //{

            //    [500] = "Ahmed",
            //    [200]= "Sara",
            //    [800]= "Ali",
            //    [350]= "Mona"


            //};

            //foreach (var item in LeaderBoard)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(LeaderBoard.Keys[0]);
            //Console.WriteLine(LeaderBoard.Values[0]);



            //Console.WriteLine(LeaderBoard.ContainsKey(500));


            //Console.WriteLine(LeaderBoard.TryGetValue(999,out string? player));

            //LeaderBoard.Remove(200);
            //foreach (var item in LeaderBoard)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Dictionary
            //Dictionary<string, string> contacts = new()
            //{

            //    ["yousef"] = "01012345678",
            //    ["mohamed"] = "01087654321",
            //    ["sara"] = "01055555555",
            //    ["mona"] = "01099999999"




            //};

            //contacts["salma"]= "01011111111";

            //contacts.Add("salma", "0121123111");

            //if (contacts.TryAdd("salma", "0121123111"))
            //    Console.WriteLine("added successfully");

            //else
            //    Console.WriteLine("key already exists");



            //Console.WriteLine(contacts.ContainsKey("joo")) ;

            //Console.WriteLine(contacts.GetValueOrDefault("Ahmed", "Not Found"));

            //foreach (var item in contacts.Keys)
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (var item in contacts.Values)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region HashSet
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{

            //    "ahmed@test.com",
            //    "AHMED@test.com", 
            //    "sara@test.com",
            //    "Sara@Test.Com"


            //};

            ////Console.WriteLine(emails.Count); // print 2  because of case insensitivity and hashset does not allow duplicates (unique key)


            //HashSet<int> A = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //HashSet<int> B = new HashSet<int>() { 4, 5, 6, 7, 8 };
            ////A.UnionWith(B);
            ////A.IntersectWith(B);
            ////A.ExceptWith(B);

            ////foreach (var item in A)
            ////{
            ////    Console.WriteLine(item);
            ////}



            //HashSet<int> C = new HashSet<int>() { 1, 2};

            //Console.WriteLine(C.IsSubsetOf(A));// true
            #endregion

            #region Queue

            //Queue<string> files = new Queue<string>();

            //files.Enqueue("Report.pdf");
            //files.Enqueue("Invoice.pdf");
            //files.Enqueue("Letter.docx");
            //files.Enqueue("Resume.pdf");
            //files.Enqueue("Photo.jpg");

            //Console.WriteLine(files.Count);

            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //Console.WriteLine(files.Peek());

            //Console.WriteLine($"print:{files.Dequeue()}");

          //  Queue<int> emtyQ= new Queue<int>();
          //if( emtyQ.TryDequeue(out int x))
          //      Console.WriteLine(x);
          //  Console.WriteLine("filed Dequeue");
            #endregion
        }
    }
}
