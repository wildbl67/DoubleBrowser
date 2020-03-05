using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleBrowser
{
    class MyTrees
    {
        const string Folder = "folder";
        const string LocalDrive = "drive";
        const string NetworkDrive = "network";
        const string CD = "cdrom";
        const string USBDrive = "usb";

        public TreeNodeCollection nodeCollection;

        public void treeViewDrives(TreeView mytreeview)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            mytreeview.PathSeparator = @"\";
            foreach (DriveInfo drive in allDrives)
            {
                switch (drive.DriveType.ToString())
                {

                    case "CDROM":


                        break;





                }
            }

        }
     



        } //end class
    } //end namespace

