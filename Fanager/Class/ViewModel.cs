using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fanager.Class
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<IFolder> Folders { get; set; }

        public ViewModel()
        {
            Folders = new ObservableCollection<IFolder>();
        }

        public void Initialize()
        {
            Folder grp1 = new Folder() { FullPath = "/a/", FolderLabel = "Folder 1" };
            Folder grp2 = new Folder() { FullPath = "/a/", FolderLabel = "Folder 2" };
            Folder grp3 = new Folder() { FullPath = "/a/", FolderLabel = "Folder 3" };
            Folder grp4 = new Folder() { FullPath = "/a/", FolderLabel = "Folder 4" };

            //grp1
            grp1.Add(new File() { FullPath = "/a/", FolderLabel = "File 01" });
            grp1.Add(new File() { FullPath = "/a/", FolderLabel = "File 02" });
            grp1.Add(new File() { FullPath = "/a/", FolderLabel = "File 03" });

            //grp2
            grp2.Add(new File() { FullPath = "/a/", FolderLabel = "File 04" });
            grp2.Add(new File() { FullPath = "/a/", FolderLabel = "File 05" });
            grp2.Add(new File() { FullPath = "/a/", FolderLabel = "File 06" });

            //grp3
            grp3.Add(new File() { FullPath = "/a/", FolderLabel = "File 07" });
            grp3.Add(new File() { FullPath = "/a/", FolderLabel = "File 08" });
            grp3.Add(new File() { FullPath = "/a/", FolderLabel = "File 09" });

            //grp4
            grp4.Add(new File() { FullPath = "/a/", FolderLabel = "File 10" });
            grp4.Add(new File() { FullPath = "/a/", FolderLabel = "File 11" });
            grp4.Add(new File() { FullPath = "/a/", FolderLabel = "File 12" });

            grp4.Add(grp1);
            grp2.Add(grp4);

            Folders.Add(new File() { FullPath = "/a/", FolderLabel = "File 100" });
            Folders.Add(grp1);
            Folders.Add(grp2);
            Folders.Add(grp3);

        }

        public event PropertyChangedEventHandler PropertyChanged;
        void NotifiyPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
