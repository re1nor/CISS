using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSystem
{
    class Processor : TreeNode
    {
        public string Maker;
        public string Model;
        Dictionary<string, string> Specification = new Dictionary<string, string>();
        public int Core;
        public Processor(string name, string model, string socket, int core, Dictionary<string, List<string>> specification) : base(name)
        {
            this.Maker = name;
            this.Model = model;
            this.Core = core;

            List<string> Sockets;
            specification.TryGetValue("Socket", out Sockets);
            string targetSocket = Sockets.Find(value => value == socket);
            this.Specification.Add("Socket", targetSocket);
        }
        public override void Print()
        {
            Console.WriteLine($"        - {Maker} {Model}");
            foreach (KeyValuePair<string, string> spec in this.Specification)
            {
                Console.WriteLine($"        - {spec.Key}: {spec.Value}");
            }
            Console.WriteLine($"        - Core: {Core}");
        }
    }
}
