using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scnet
{
    internal class main
    {
        public static void printSwimmerInfo(Swimmer s)
        {
            Console.WriteLine(
                "Hi, Im {0}!\nI swim for {1} in {2}.\nMy most recent meet was the {3} in {4}, on {5}. This meet course was {6}.",
                s.Name,
                s.Team.Name,
                s.Location,
                s.MostRecentMeet.Name,
                s.MostRecentMeet.Location,
                s.MostRecentMeet.Date,
                s.MostRecentMeet.Course
            );

            Console.WriteLine("These are all my previous teams:");
            foreach (Team team in s.AllTeams)
            {
                Console.WriteLine("{0} (ID: {1}) - {2}", team.Name, team.ID, team.Description);
            }

            Console.WriteLine("These are all my previous meets:");
            foreach (Meet meet in s.AllMeets)
            {
                Console.WriteLine("{0} (ID: {1}) - {2}", meet.Name, meet.ID, meet.Location);
            }
        }
        public static void Main(string[] args)
        {

            Swimmer s = new Swimmer(/*ENTER YOUR SWIMMER'S NUMBER FROM URL*/1234567);
            var w = System.Diagnostics.Stopwatch.StartNew();
            printSwimmerInfo(s);
            w.Stop();
            Console.WriteLine("Execution time (ms): {0}", w.ElapsedMilliseconds);
        }
    }
}
