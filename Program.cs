using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {

        // Exercise 1 : Student Grade Manager

        // create collection with grades

        List<int> grades = new List<int>
        {
            85,
            92,
            78,
            95,
            88,
            70,
            100,
            65
        };


        // Print collection

        Console.WriteLine("Grades:");

        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }


        // Count

        Console.WriteLine($"Count: {grades.Count}");


        // First and last grade

        Console.WriteLine($"First Grade: {grades[0]}");
        Console.WriteLine($"Last Grade: {grades[^1]}");


        // Sort ascending

        grades.Sort();

        Console.WriteLine("Sorted Grades:");

        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }


        // first grade abv 50

        int FirstAbv50 =
            grades.First(grade => grade > 90);

        Console.WriteLine(
            $"\nFirst grade above 90: {FirstAbv50}"
        );


        // All grades below 75

        List<int> BlowGrades =
            grades.Where(grade => grade < 75).ToList();

        Console.WriteLine("Below Grades:");

        foreach (int grade in BlowGrades)
        {
            Console.WriteLine(grade);
        }


        // Remove all Below grades

        grades.RemoveAll(grade => grade < 75);

        Console.WriteLine("Grades after removing BelowGrades:");

        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }


        // Check if any grade = 100

        bool has100 = grades.Contains(100);

        Console.WriteLine(
            $"Contains 100: {has100}"
        );


        // Create List of string

        List<string> gradeMessages =
            grades.Select(
                grade => $"Grade: {grade}"
            ).ToList();

        Console.WriteLine("Grade Messages:");

        foreach (string msg in gradeMessages)
        {
            Console.WriteLine(msg);
        }



        // Exercise 2 : Leaderboard


        SortedDictionary<int, string> leaderboard =
            new SortedDictionary<int, string>();


        leaderboard.Add(500, "Ahmed");
        leaderboard.Add(200, "Sara");
        leaderboard.Add(800, "Ali");
        leaderboard.Add(350, "Mona");


        // Print all entries

        Console.WriteLine("Leaderboard:");

        foreach (var player in leaderboard)
        {
            Console.WriteLine(
                $"{player.Key} = {player.Value}"
            );
        }


        // first key and first val

        Console.WriteLine(
            $"First Score: {leaderboard.First().Key}"
        );

        Console.WriteLine(
            $"First Player: {leaderboard.First().Value}"
        );


        // checks if score exists

        Console.WriteLine(
            $"Score 500 exists: {leaderboard.ContainsKey(500)}"
        );


        // Safely get player with score 999

        if (leaderboard.TryGetValue(999, out string player999))
        {
            Console.WriteLine(
                $"Player with score 999: {player999}"
            );
        }
        else
        {
            Console.WriteLine(
                "Player with score 999: Not Found"
            );
        }


        // Remove score 200

        leaderboard.Remove(200);

        Console.WriteLine("\nLeaderboard after remove:");

        foreach (var player in leaderboard)
        {
            Console.WriteLine(
                $"{player.Key} = {player.Value}"
            );
        }



        // Exercise 3 : Phone Book

        Dictionary<string, string> phoneBook =
            new Dictionary<string, string>();


        // Add 4 contacts

        phoneBook.Add("Mohamed", "01011111111");
        phoneBook.Add("Amr", "01022222222");
        phoneBook.Add("Ali", "01033333333");
        phoneBook.Add("Hasan", "01044444444");


        // Add new contact using []

        phoneBook["Hasan"] = "01055555555";


        // Try adding duplicate using Add

        try
        {
            phoneBook.Add(
                "Mohamed",
                "01111111111"
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"Add duplicate error: {ex.Message}"
            );
        }


        // Try adding duplicate using TryAdd

        bool added =
            phoneBook.TryAdd(
                "Mohamed",
                "01111111111"
            );

        Console.WriteLine(
            $"TryAdd dublicat successed {added}"
        );


        // Search for contact that doesn't exist

        if (phoneBook.ContainsKey("Omar"))
        {
            Console.WriteLine(
                $"Omar phone: {phoneBook["Omar"]}"
            );
        }
        else
        {
            Console.WriteLine(
                "Omar not found"
            );
        }


        // Get contact with fallback

        string phone =
            phoneBook.GetValueOrDefault(
                "Omar",
                "Not Found"
            );

        Console.WriteLine(
            $"Omar: {phone}"
        );


        // Print all Keys

        Console.WriteLine("\nAll Names:");

        foreach (string key in phoneBook.Keys)
        {
            Console.Write($"{key} ");
        }


        // Print all Values

        Console.WriteLine("\n\nAll Phone Numbers:");

        foreach (string value in phoneBook.Values)
        {
            Console.Write($"{value} ");
        }



        // Exercise 4 : Unique Email Validator


        HashSet<string> emails =
            new HashSet<string>(
                StringComparer.OrdinalIgnoreCase
            );


        // Add emails

        emails.Add("ahmed@test.com");
        emails.Add("AHMED@test.com");
        emails.Add("sara@test.com");
        emails.Add("Sara@Test.Com");


        // Print count

        Console.WriteLine(
            $"\nEmail Count: {emails.Count}"
        );


      //  Count is 2 because hashset doest not allow duplicates val 


        // Set A

        HashSet<int> setA =
            new HashSet<int>
            {
                1,
                2,
                3,
                4,
                5
            };


        // Set B

        HashSet<int> setB =
            new HashSet<int>
            {
                4,
                5,
                6,
                7,
                8
            };


        // UnionWith

        HashSet<int> union =
            new HashSet<int>(setA);

        union.UnionWith(setB);

        Console.WriteLine("\nUnion:");

        foreach (int number in union)
        {
            Console.Write($"{number} ");
        }


        // IntersectWith

        HashSet<int> intersect =
            new HashSet<int>(setA);

        intersect.IntersectWith(setB);

        Console.WriteLine("\nIntersect:");

        foreach (int number in intersect)
        {
            Console.Write($"{number} ");
        }


        // ExceptWith

        HashSet<int> except =
            new HashSet<int>(setA);

        except.ExceptWith(setB);

        Console.WriteLine("\nExcept:");

        foreach (int number in except)
        {
            Console.Write($"{number} ");
        }


        // IsSubsetOf

        HashSet<int> smallSet =
            new HashSet<int>
            {
                1,
                2
            };

        Console.WriteLine(
            $"\nIs {1,2} subset of Set A: " +
            $"{smallSet.IsSubsetOf(setA)}"
        );


    }
}