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

        public void treeViewDrives(TreeView mytreeview , TreeNode nodeToAddTo)
        {
            string[] drives = Environment.GetLogicalDrives();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            mytreeview.PathSeparator = @"\";
            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                int driveImage;
                switch (di.DriveType)
                {

                    case DriveType.CDRom:
                        driveImage = 3;

                        break;
                    case DriveType.Network:
                        driveImage = 6;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 8;
                        break;
                    case DriveType.Unknown:
                        driveImage = 8;
                        break;
                    default:
                        driveImage = 2;
                        break;




                }

                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");

                nodeToAddTo.Nodes.Add(node);
            }

        }
     



        } //end class
    } //end namespace

