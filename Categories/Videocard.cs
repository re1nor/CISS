using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSystem
{
    class Videocard : TreeNode
    {
        public string Maker;
        public string Model;
        public string TypeVMemory;
        public int Size;

        public Videocard(string name, string model, string vmemory, int size) : base(name)
        {
            this.Maker = name;
            this.Model = model;
            this.TypeVMemory = vmemory;
            this.Size = size;
        }
        public override void Print()
        {
            Console.WriteLine($"        - {Maker} {Model} \n" +
                              $"        - Size: {Size} gb \n" +
                              $"        - Type Memory: { TypeVMemory}");
        }
    }
}

