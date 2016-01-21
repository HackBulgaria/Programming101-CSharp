using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupByCount = int.Parse(ConfigurationManager.AppSettings["GroupByCount"]);
            var sourceFile = ConfigurationManager.AppSettings["SourceFile"];
            var targetFile = ConfigurationManager.AppSettings["TargetFile"];

            var students = GetStudents(sourceFile);
            Shuffle(students);
            var groups = Group(students, groupByCount);
            WriteGroups(targetFile, groups);
        }

        private static List<string> GetStudents(string fileName)
        {
            var res = new List<string>();
            using (var reader = new StreamReader(fileName))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    res.Add(line);
                }
            }

            return res;
        }

        private static void WriteGroups(string fileName, List<List<string>> groups)
        {
            using (var writer = new StreamWriter(fileName))
            {
                foreach(var group in groups)
                {
                    var line = string.Join(", ", group);
                    writer.WriteLine(line);
                }
            }
        }

        private static List<List<T>> Group<T>(List<T> list, int count)
        {
            var res = new List<List<T>>();
            for (int i = 0; i < list.Count; i += count)
            {
                var group = new List<T>();
                for (int j = i; j < Math.Min(i + count, list.Count); j++)
                {
                    group.Add(list[j]);
                }
                res.Add(group);
            }

            return res;
        }

        private static void Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
