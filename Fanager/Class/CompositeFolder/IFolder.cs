using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fanager.Class
{
    public abstract class IFolder
    {
        public string FullPath { get; set; }
        public string FolderLabel { get; set; }

        public abstract void Add(IFolder c);
    }
}
