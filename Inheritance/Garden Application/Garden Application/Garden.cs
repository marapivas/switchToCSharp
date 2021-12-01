using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    internal class Garden
    {
        List<Tree> trees;
        List<Flower> flowers;

        public Garden()
        {
            this.trees = new List<Tree>();
            this.flowers = new List<Flower>();
        }

        public void addTree(Tree tree)
        { this.trees.Add(tree); }

        public void addFlower(Flower flower)
        { this.flowers.Add(flower);}

        public void water(int amountOfWater)
        {
            int numberOfThirstyFlowers = 0;
            int numberOfThirstyTrees = 0;
            int waterForplants = 0;

            foreach (Tree t in this.trees)
            {
                if (t.needsWater())
                { numberOfThirstyTrees++; }
            }
            foreach (Flower f in this.flowers)
            {
                if (f.needsWater())
                { numberOfThirstyFlowers++; }
            }
            waterForplants = amountOfWater / (numberOfThirstyFlowers + numberOfThirstyTrees);

            foreach (Tree t in this.trees)
            {
                if (t.needsWater())
                { t.WaterAmount += waterForplants * 0.4; }
            }

            foreach (Flower f in this.flowers)
            {
                if (f.needsWater())
                { f.WaterAmount += waterForplants * 0.75; }
            }

            gardenLook();
        }

        public void gardenLook()
            {
                foreach (Tree t in this.trees)
                { t.printStatus(); }
                foreach (Flower f in this.flowers)
                { f.printStatus(); }
            }
        
    }
}
