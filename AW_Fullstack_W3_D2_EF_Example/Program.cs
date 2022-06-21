using System;
using AW_Fullstack_W3_D2_EF_Example.Models;
using System.Linq;

namespace AW_Fullstack_W3_D2_EF_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (LearningDiaryContext testiYhteys = new LearningDiaryContext())
            {
                var taulu = testiYhteys.Topics.Select(topikki => topikki);
                Topic uusi = new Topic()
                {
                    Id = 1,
                    Description = "Testi",
                    Title = "Title",
                    TimeToMaster = 3,
                    TimeSpent = 2,
                    StartLearningDate = DateTime.Now,
                    InProgress = false
                };
                testiYhteys.Topics.Add(uusi);
                testiYhteys.SaveChanges();

                taulu = testiYhteys.Topics.Select(topikki => topikki);
                foreach(var rivi in taulu)
                {
                    Console.WriteLine(rivi.Description);
                }

                //Console.WriteLine(taulu);
            }
        }
    }
}
