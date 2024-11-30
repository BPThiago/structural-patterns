using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight
{
    internal class TreeFactory
    {
        private Dictionary<string, TreeType> treeTypes = new Dictionary<string, TreeType>();

        public TreeType GetTreeType(string texture)
        {
            if (!treeTypes.ContainsKey(texture))
            {
                treeTypes.Add(texture, new TreeType(texture));
            }
            return treeTypes[texture];
        }
    }
}
