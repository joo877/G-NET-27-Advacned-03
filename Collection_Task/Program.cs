using System.Diagnostics;

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
        }
    }
}
