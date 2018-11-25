using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fanager.Class
{
    public class File : IFolder
    {
        public override void Add(IFolder c)
        {
            throw new Exception("Cannot add to a File");
        }
    }
}
