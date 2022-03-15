using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSystem
{
    public class Motherboard : TreeNode
    {
     
        public string Maker;
        public string Model;
        Dictionary<string, string> Specification = new Dictionary<string, string>();

        public Motherboard(string name, string model, string socket, string ddr, Dictionary<string, List<string>> specification) : base(name)
        {
            this.Maker = name;
            this.Model = model;
            List<string> Sockets;
            specification.TryGetValue("Socket", out Sockets);
            string targetSocket = Sockets.Find(value => value == socket);
            this.Specification.Add("Socket", targetSocket);

            List<string> typeMemory;
            specification.TryGetValue("Type memory", out typeMemory);
            string targetTypeMemory = typeMemory.Find(value => value == ddr);
            this.Specification.Add("Type memory", targetTypeMemory);
        }
        public override void Print()
        {
            Console.WriteLine($"        - {Maker} {Model}");
            foreach (KeyValuePair<string, string> spec in this.Specification)
            {
                Console.WriteLine($"        - {spec.Key}: {spec.Value}");
            }
            
        }
    }
}
