using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSystem
{
    class Ram : TreeNode
    {
        public string Maker;
        public string Model;
        Dictionary<string, string> Specification = new Dictionary<string, string>();
        public double Size;
        public Ram(string name, string model,  string ddr, double size, Dictionary<string, List<string>> specification) : base(name)
        {
            this.Maker = name;
            this.Model = model;
            this.Size = size;

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
            Console.WriteLine($"        - Size: {Size} gb");
        }
    }
}

