using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSystem
{
    static class Program
    {
        //            [Computer1 - root======]      ------->    [Computer2 - root======]      ------->     [Computer3 - root======]     
        //            /        /       \     \                  /        /        \    \                   /        /         \    \ 
        //    MotherBoard   Processor  Ram   Drive      MotherBoard   Processor    Ram  Drive     MotherBoard   Processor     Ram  Drive
        //      /   / \       /  \     /  \     \         /   /  \       /  \     /  \     \         /   /  \       /   \     /  \     \
        //   G35 775 DDR2  xeon  775 ddr2 4gb   HDD     H61 1155 DDR3  Pent 1155 ddr3 8gb   SSD   x370 АМ4 DDR4 Ryzen5 AM4  ddr4 8gb   SSD 
        private static void Main()
        {
            #region Signature
            Console.WriteLine("Система хранения компьютеров и их комплектующих");
            Console.WriteLine("Проект студента КНИТУ-КАИ, гр. 4217 Замалетдинов Б.М. , since 2021 ");
            Console.WriteLine();
            #endregion

            #region Specification
            Dictionary<string, List<string>> Specification = new Dictionary<string, List<string>>();

            #region Sockets
            Specification.Add("Socket", new List<string>
            {
                "AM2",
                "AM2plus",
                "AM3",
                "AM3plus",
                "AM4",
                "TR4",
                "SP3",
                "775",
                "1156",
                "1155",
                "1151",
                "1150",
                "1366",
                "2066"
            });

            #endregion


            #region Type memory
            Specification.Add("Type memory", new List<string>
            {
                "DDR2",
                "DDR3",
                "DDR4"
               
            });
            #endregion

            #region Type drive
            Specification.Add("Drive", new List<string>
            {
                "HDD",
                "SSD"

            });
            #endregion

           

            #endregion

            #region Computer1
            TreeNode root1 = new TreeNode("Computer_1");

            root1.listOF.AddRange(new List<TreeNode>
            {
                new TreeNode("Motherboard"),
                new TreeNode("Processor"),
                new TreeNode("Ram"),
                new TreeNode("Videocard"),
                new TreeNode("Drive")
            });

            TreeNode Motherboard = root1.listOF.Find(item => item.Name == "Motherboard");
            Motherboard.listOF.AddRange(new List<Motherboard>
            {
                new Motherboard("Asus","Strix B350-f Gaming", "AM4", "DDR4", Specification)

            });

            TreeNode Processor = root1.listOF.Find(item => item.Name == "Processor");
            Processor.listOF.AddRange(new List<Processor>
            {
                new Processor("AMD","Ryzen 5 2600", "AM4", 6, Specification)

            });

            TreeNode Ram = root1.listOF.Find(item => item.Name == "Ram");
            Ram.listOF.AddRange(new List<Ram>
            {
                new Ram("HyperX","Fury Black", "DDR4", 8, Specification)

            });

            TreeNode Videocard = root1.listOF.Find(item => item.Name == "Videocard");
            Videocard.listOF.AddRange(new List<Videocard>
            {
                new Videocard("Colorful","RTX 3060", "GDDR6", 12),
                new Videocard("Palit","RTX 3060", "GDDR6", 12)

            });

            TreeNode Drive = root1.listOF.Find(item => item.Name == "Drive");
            Drive.listOF.AddRange(new List<Drive>
            {
                new Drive("Samsung","950 Evo", "SSD", "Sata", 256, Specification)

            });

            #endregion
            
            #region Computer2
            
            TreeNode root2 = new TreeNode("Computer_2");

            root2.listOF.AddRange(new List<TreeNode>
            {
                new TreeNode("Motherboard2"),
                new TreeNode("Processor2"),
                new TreeNode("Ram2"),
                new TreeNode("Videocard2"),
                new TreeNode("Drive2")
            });

            TreeNode Motherboard2 = root2.listOF.Find(item => item.Name == "Motherboard2");
            Motherboard2.listOF.AddRange(new List<Motherboard>
            {
                new Motherboard("Biostar","G31-M7 TE", "775", "DDR2", Specification)

            });

            TreeNode Processor2 = root2.listOF.Find(item => item.Name == "Processor2");
            Processor2.listOF.AddRange(new List<Processor>
            {
                new Processor("Intel","Xeon E5430", "775", 4, Specification)

            });

            TreeNode Ram2 = root2.listOF.Find(item => item.Name == "Ram2");
            Ram2.listOF.AddRange(new List<Ram>
            {
                new Ram("Patriot","PSD22G80026", "DDR2", 4, Specification)

            });

            TreeNode Videocard2 = root2.listOF.Find(item => item.Name == "Videocard2");
            Videocard2.listOF.AddRange(new List<Videocard>
            {
                new Videocard("MSI","GTX 650", "GDDR5", 2),

            });

            TreeNode Drive2 = root2.listOF.Find(item => item.Name == "Drive2");
            Drive2.listOF.AddRange(new List<Drive>
            {
                new Drive("Western Digital","WD3200AAJS", "HDD", "IDE", 320, Specification)

            });
            
            #endregion 

            #region Computer3
            
            TreeNode root3 = new TreeNode("Computer_3");

            root3.listOF.AddRange(new List<TreeNode>
            {
                new TreeNode("Motherboard3"),
                new TreeNode("Processor3"),
                new TreeNode("Ram3"),
                new TreeNode("Videocard3"),
                new TreeNode("Drive3")
            });

            TreeNode Motherboard3 = root3.listOF.Find(item => item.Name == "Motherboard3");
            Motherboard3.listOF.AddRange(new List<Motherboard>
            {
                new Motherboard("Asus","H61M-K", "1155", "DDR3", Specification)

            });

            TreeNode Processor3 = root3.listOF.Find(item => item.Name == "Processor3");
            Processor3.listOF.AddRange(new List<Processor>
            {
                new Processor("Intel","Pentium G640", "1155", 2, Specification)

            });

            TreeNode Ram3 = root3.listOF.Find(item => item.Name == "Ram3");
            Ram3.listOF.AddRange(new List<Ram>
            {
                new Ram("Kingston","KVR13N9S6", "DDR3", 2, Specification),
                new Ram("HP","500670-B21", "DDR3", 2, Specification)

            });

            TreeNode Videocard3 = root3.listOF.Find(item => item.Name == "Videocard3");
            Videocard3.listOF.AddRange(new List<Videocard>
            {
                new Videocard("Gigabyte","GTX 1080ti", "GDDR5X", 11),
                

            });

            TreeNode Drive3 = root3.listOF.Find(item => item.Name == "Drive3");
            Drive3.listOF.AddRange(new List<Drive>
            {
                new Drive("Seagate","ST500DM009", "HDD", "Sata", 500, Specification)

            });
           
            #endregion

            #region SingleNode
            SingleList<TreeNode> ComputerList = new SingleList<TreeNode>();

            ComputerList.AddTop(1, root1); // Добавление 
            ComputerList.AddEnd(2, root2);
            ComputerList.AddEnd(3, root3);



            SingleNode<TreeNode> iter = ComputerList.top;
            while (iter != null)
            {
                Console.WriteLine("——————————————————————————————————————————————————————————————————");
                iter.Value.Print();
                iter = iter.Next;
                Console.WriteLine();
                
            }
            

            
            //root1.Print();
            #endregion

            


         
        }
    }
}
