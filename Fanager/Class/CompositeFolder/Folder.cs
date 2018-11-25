using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fanager.Class
{
    public class Folder : IFolder
    {
        public List<IFolder> Children { set; get; }

        public Folder()
        {
            Children = new List<IFolder>();
        }

        public override void Add(IFolder component)
        {
            Children.Add(component);
        }
    }
}
