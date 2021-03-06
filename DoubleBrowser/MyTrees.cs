﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Collections;
<<<<<<< HEAD

=======
using System.
>>>>>>> f018f1c6836c6aeb94fa697ea71e72a8428c42f8


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
        //TODO:  Create new drive methiod based upon below 2/21/21
        public void PopulateTreeView(string Epath, string INodeImage, TreeView mytreeview)
        {
            try
            {
                TreeNode rootNode;

                //DirectoryInfo info = new DirectoryInfo(@"../..");

                // Console.WriteLine("GetFolderPath: {5}", Environment.GetFolderPath(Environment.SpecialFolder.System));
                DirectoryInfo info = new DirectoryInfo(@Epath);
                if (info.Exists)
                {

                    rootNode = new TreeNode(info.Name, 1, 1)
                    {
                        Tag = info,
                        ImageKey = INodeImage
                    };
                    GetSubDirectories(info.GetDirectories(), rootNode);
                    mytreeview.Nodes.Add(rootNode);
                }
            }
<<<<<<< HEAD

            catch (IOException e) { MessageBox.Show(e.Message, "IO Exception" + e.Source.ToString(), MessageBoxButtons.OK); }

            catch (UnauthorizedAccessException e) { //MessageBox.Show(e.Message, "UA Exception" + e.Source.ToString(), MessageBoxButtons.OK); 
                return;
            }

            catch (Exception e) { MessageBox.Show(e.Message.ToString(), e.Source.ToString(), MessageBoxButtons.OK); }

        } //end Populatetreeviw

        private void GetSubDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            string tPath = "";
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                tPath = subDir.Name.ToString().Replace(@"\\", @"\");

                aNode = new TreeNode(tPath, 0, 0)
                {
                    Tag = subDir,
                    ImageKey = "folder"
                };
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetSubDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

=======

            catch (IOException e) { MessageBox.Show(e.Message, "IO Exception" + e.Source.ToString(), MessageBoxButtons.OK); }

            catch (UnauthorizedAccessException e) { //MessageBox.Show(e.Message, "UA Exception" + e.Source.ToString(), MessageBoxButtons.OK); 
                return;
            }

            catch (Exception e) { MessageBox.Show(e.Message.ToString(), e.Source.ToString(), MessageBoxButtons.OK); }

        } //end Populatetreeviw

        private void GetSubDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            string tPath = "";
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                tPath = subDir.Name.ToString().Replace(@"\\", @"\");

                aNode = new TreeNode(tPath, 0, 0)
                {
                    Tag = subDir,
                    ImageKey = "folder"
                };
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetSubDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

>>>>>>> f018f1c6836c6aeb94fa697ea71e72a8428c42f8

        public void TreeViewDrives(TreeView mytreeview)
        {
            try
            {
                //string[] drives = Environment.GetLogicalDrives();
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                mytreeview.PathSeparator = @"\";
<<<<<<< HEAD
                string mtimage = "Folder";
=======
>>>>>>> f018f1c6836c6aeb94fa697ea71e72a8428c42f8
                foreach (DriveInfo drive in allDrives)
                {
                    // DriveInfo di = new DriveInfo(drive);
                    int driveImage;
<<<<<<< HEAD
                    
=======
                    string mtimage = "Folder";
>>>>>>> f018f1c6836c6aeb94fa697ea71e72a8428c42f8
                    switch (drive.DriveType)
                    {

                        case DriveType.CDRom:
                            driveImage = 3;
<<<<<<< HEAD
                            mtimage = "CD";
=======
                            mtimage = CD;
>>>>>>> f018f1c6836c6aeb94fa697ea71e72a8428c42f8

                            break;
                        case DriveType.Network:
                            driveImage = 6;
<<<<<<< HEAD
                            mtimage = "LocalDrive";
                            break;
                        case DriveType.Removable:
                            driveImage = 8;
                            mtimage = "USBDrive";
=======
                            mtimage = LocalDrive;
                            break;
                        case DriveType.Removable:
                            driveImage = 8;
                            mtimage = USBDrive;
>>>>>>> f018f1c6836c6aeb94fa697ea71e72a8428c42f8
                            break;
                        case DriveType.NoRootDirectory:
                            driveImage = 8;
                            break;
                        case DriveType.Fixed:
                            driveImage = 8;
                            sHFILEINFO
<<<<<<< HEAD
                            mtimage = "LocalDrive";
=======
                            mtimage = LocalDrive;
>>>>>>> f018f1c6836c6aeb94fa697ea71e72a8428c42f8
                            break;
                        default:
                            driveImage = 2;
                            break;




                    }
                    TreeNode node = new TreeNode();
                    if(drive.IsReady){
                    // TreeNode snode = new TreeNode(drive.VolumeLabel);
                    string dLabel = drive.RootDirectory.Name +" "+ drive.VolumeLabel;
                    if (dLabel == "" || dLabel == null) { dLabel = drive.RootDirectory.Name.ToString(); }
                    //TreeNode node = new TreeNode(dLabel, driveImage, driveImage);
                   
                    node.Tag=drive.RootDirectory.Name.ToString();
                    node.Text = dLabel;
                    node.ImageKey = mtimage;
                       
                        }else{
                        node.Tag=drive.RootDirectory.Name.ToString();
                        node.Text = drive.RootDirectory.Name.ToString();
                        node.ImageKey = mtimage;
<<<<<<< HEAD
                        //node.ImageKey = drive.Equals.;
=======
                        node.ImageKey = drive.Equals.;
>>>>>>> f018f1c6836c6aeb94fa697ea71e72a8428c42f8
                        
                    }

                    //    if (drive.IsReady == true)
                    //    {
                    //        TreeNode bNode;
                    //        DirectoryInfo[] subs = drive.RootDirectory.GetDirectories();

                    //        node.Nodes.Add(drive.RootDirectory.FullName);
                    //        if (subs != null)
                    //        {
                    //            foreach (DirectoryInfo subDir in subs)
                    //            {
                    //                string tPath = subDir.Name.ToString().Replace(@"\\", @"\");

                    //                bNode = new TreeNode(tPath, 0, 0);
                    //                bNode.Tag = subDir;
                    //                bNode.ImageKey = mtimage;
                    //                subs = subDir.GetDirectories();
                    //                if (subs.Length != 0)
                    //                {
                    //                    GetSubDirectories(subs, bNode);
                    //                }
                    //                mytreeview.Nodes.Add(bNode);
                    //            }
                    //        }

                    //    }
                    //    else
                    //    {
                    //        node.Nodes.Add("...");
                    //    }

                        mytreeview.Nodes.Add(node);
                    }
                
            }
            catch (System.NullReferenceException ex) { return; }
            catch (IOException ex) { return; }
        }//end of treeDriveView



        //public void ListViewFill(ListView SelectedListView , TreeView myTreeView)
        //{
        //    SelectedListView.Clear();



        //}





    } //end class
    
}//end namespace

