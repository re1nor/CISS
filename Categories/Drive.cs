using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSystem
{
    class Drive : TreeNode
    {
        public string Maker;
        public string Model;
        Dictionary<string, string> Specification = new Dictionary<string, string>();
        public string Connector;
        public double Size;
        public Drive(string name, string model, string typedrive, string connector, double size, Dictionary<string, List<string>> specification) : base(name)
        {
            this.Maker = name;
            this.Model = model;
            this.Connector = connector;
            this.Size = size;


            List<string> TypeDrive;
            specification.TryGetValue("Drive", out TypeDrive);
            string targetDrive = TypeDrive.Find(value => value == typedrive);
            this.Specification.Add("Drive", targetDrive);
        }
        public override void Print()
        {
            Console.WriteLine($"        - {Maker} {Model}");
            foreach (KeyValuePair<string, string> spec in this.Specification)
            {
                Console.WriteLine($"        - Type: {spec.Value}");
            }
            Console.WriteLine($"        - Connector: {Connector} \n" +
                              $"        - Size: {Size} gb");
        }


    }
}
