using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class Panda
        {
            public string Name { get; set; }
            public List<Panda> Friends { get; set; }

            public Panda(string name)
            {
                this.Name = name;
                Friends = new List<Panda>();
            }
        }

        class SocialNetwork
        {
            public List<Panda> Users { get; set; }
            public SocialNetwork()
            {
                Users = new List<Panda>();
            }

            public Panda this[string name]
            {
                get
                {
                    return Users.Where(x => x.Name == name).FirstOrDefault();
                }
            }
        }

        static void Main(string[] args)
        {
            SocialNetwork sn = new SocialNetwork();
            sn.Users.Add(new Panda("Panda 1"));
            sn.Users.Add(new Panda("Panda 2"));
            sn.Users.Add(new Panda("Panda 3"));
            sn.Users.Add(new Panda("Panda 4"));
            sn.Users.Add(new Panda("Panda 5"));
            sn.Users.Add(new Panda("Panda 6"));
            
            sn["Panda 1"].Friends.Add(sn["Panda 2"]);
            sn["Panda 2"].Friends.Add(sn["Panda 1"]);

            sn["Panda 3"].Friends.Add(sn["Panda 2"]);
            sn["Panda 2"].Friends.Add(sn["Panda 3"]);

            sn["Panda 4"].Friends.Add(sn["Panda 2"]);
            sn["Panda 2"].Friends.Add(sn["Panda 4"]);

            sn["Panda 5"].Friends.Add(sn["Panda 6"]);
            sn["Panda 6"].Friends.Add(sn["Panda 5"]);

            sn["Panda 1"].Friends.Add(sn["Panda 5"]);
            sn["Panda 5"].Friends.Add(sn["Panda 1"]);

            bool res = CheckFriendConnectionBFS("Panda 1", "Panda 6", sn);
            Console.WriteLine(res);
            Console.WriteLine("Finished BFS");
            Console.WriteLine();

            res = CheckFriendConnectionDFS("Panda 1", "Panda 6", sn);
            Console.WriteLine(res);
            Console.WriteLine("Finished DFS");
            Console.WriteLine();


            res = CheckFriendConnectionDFSRecursive(sn["Panda 1"], "Panda 6", new HashSet<Panda>());
            Console.WriteLine(res);
            Console.WriteLine("Finished Recursive DFS");

        }

        static bool CheckFriendConnectionBFS(string name1, string name2, SocialNetwork sn)
        {
            Queue<Panda> q = new Queue<Panda>();
            HashSet<Panda> visited = new HashSet<Panda>();

            q.Enqueue(sn[name1]);
            visited.Add(sn[name1]);

            Console.WriteLine("Starting from " + name1);
            while(q.Count > 0)
            {
                Panda current = q.Dequeue();
                Console.WriteLine("Currently at " + current.Name);
                foreach(Panda friend in current.Friends)
                {
                    if(friend.Name == name2)
                    {
                        return true;
                    }

                    if (!visited.Contains(friend))
                    {
                        Console.WriteLine("Added friend " + friend.Name);
                        q.Enqueue(friend);
                        visited.Add(friend);
                    }
                }
            }

            return false;
        }


        static bool CheckFriendConnectionDFS(string name1, string name2, SocialNetwork sn)
        {
            Stack<Panda> q = new Stack<Panda>();
            HashSet<Panda> visited = new HashSet<Panda>();

            q.Push(sn[name1]);
            visited.Add(sn[name1]);

            Console.WriteLine("Starting from " + name1);
            while (q.Count > 0)
            {
                Panda current = q.Pop();
                Console.WriteLine("Currently at " + current.Name);
                foreach (Panda friend in current.Friends)
                {
                    if (friend.Name == name2)
                    {
                        return true;
                    }

                    if (!visited.Contains(friend))
                    {
                        Console.WriteLine("Added friend " + friend.Name);
                        q.Push(friend);
                        visited.Add(friend);
                    }
                }
            }

            return false;
        }
        
        static bool CheckFriendConnectionDFSRecursive(Panda current, string target, HashSet<Panda> visited)
        {
            Console.WriteLine("Currently at " + current.Name);
            visited.Add(current);

            foreach(Panda friend in current.Friends)
            {
                if(!visited.Contains(friend))
                {
                    if (friend.Name == target)
                    {
                        return true;
                    }

                    Console.WriteLine("Checking friend " + friend.Name);

                    visited.Add(friend);
                    if(CheckFriendConnectionDFSRecursive(friend, target, visited))
                    {
                        return true;
                    }

                    Console.WriteLine("Finished checking friend " + friend.Name);
                }
            }

            return false;
        }
    }
}
