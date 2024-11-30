using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight
{
    internal class Tree
    {
        private int x;
        private int y;
        private TreeType treeType;

        public Tree(int x, int y, TreeType treeType)
        {
            this.x = x;
            this.y = y;
            this.treeType = treeType;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing tree at ({x}, {y}) with texture {treeType.Texture}");
        }
    }
}
