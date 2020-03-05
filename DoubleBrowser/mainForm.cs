using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Collections;

namespace DoubleBrowser
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();


            //this.treeViewLeft.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.treeViewLeft_MouseClick);
        }

        private void PopulateTreeView(string Epath, string INodeImage,TreeView mytreeview)
        {
            try
            {
                TreeNode rootNode;
                
                //DirectoryInfo info = new DirectoryInfo(@"../..");

                // Console.WriteLine("GetFolderPath: {5}", Environment.GetFolderPath(Environment.SpecialFolder.System));
                DirectoryInfo info = new DirectoryInfo(@Epath);
                if (info.Exists)
                {

                    rootNode = new TreeNode(info.Name, 1,1);
                    rootNode.Tag = info;
                    rootNode.ImageKey = INodeImage;
                    GetDirectories(info.GetDirectories(), rootNode);
                    mytreeview.Nodes.Add(rootNode);
                }
            }

            catch (IOException e) { MessageBox.Show(e.Message, "IO Exception" + e.Source.ToString(), MessageBoxButtons.OK); }

            catch (UnauthorizedAccessException e) { MessageBox.Show(e.Message, "UA Exception" + e.Source.ToString(), MessageBoxButtons.OK); }

            catch (Exception e) { MessageBox.Show(e.Message.ToString(), e.Source.ToString(), MessageBoxButtons.OK); }

        } //end Populatetreeviw

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            string tPath = "";
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                tPath = subDir.Name.ToString().Replace(@"\\",@"\");

                aNode = new TreeNode(tPath, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }



        private void treeViewLeft_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            {
                TreeNode newSelected = e.Node;
                listViewLeft.Items.Clear();
                DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;
                Icon iconForFile = SystemIcons.WinLogo;

                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {

                    item = new ListViewItem(dir.Name, 0);

                    item.ImageKey = dir.Extension;


                    //iconForFile = Icon.ExtractAssociatedIcon(dir.FullName);
                    subItems = new ListViewItem.ListViewSubItem[] {

                        new ListViewItem.ListViewSubItem(item, "Directory"),
                       new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())
                    };
                    item.SubItems.AddRange(subItems);
                    listViewLeft.Items.Add(item);
                }
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                    imageListIcons.Images.Add(file.Extension, iconForFile);
                    item = new ListViewItem(file.Name, 1);
                    item.ImageKey = file.Extension;
                    subItems = new ListViewItem.ListViewSubItem[]
                        { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())};

                    item.SubItems.AddRange(subItems);
                    listViewLeft.Items.Add(item);
                }

                listViewLeft.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)

        {
            TreeNode lib = new TreeNode("My Computer", 0, 0);
            TreeNode libright = new TreeNode("My Computer", 0, 0);

            lib.ImageKey = "desktop";
            libright.ImageKey = "desktop";
            treeViewLeft.Nodes.Add(lib);
            treeViewRight.Nodes.Add(libright);
            try
            {

                string fpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string pPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string cPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                //  string access = Directory.GetAccessControl(pPath).ToString();
                //  Console.WriteLine("Path check " + pPath);
                //  Console.WriteLine("Path Access" + access);



                lib.Nodes.Add(fpath);
                PopulateTreeView(fpath, "desktop",treeViewLeft);
               PopulateTreeView(pPath, "documents",treeViewLeft);
                PopulateTreeView(cPath, "music", treeViewLeft);
                PopulateTreeView(fpath, "desktop", treeViewRight);
                PopulateTreeView(pPath, "documents", treeViewRight);
                PopulateTreeView(cPath, "music", treeViewRight);

                //treeDrives(treeViewLeft);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(),"Load exception" + ex.InnerException.ToString(),MessageBoxButtons.OK); }
            //PopulateTreeView(pPath);
            //lib.Nodes.Add(PopulateTreeView(cPath,"music"));
            




        }

        /// <summary>
        /// 
        /// </summary>
        private void treeDrives(TreeView mytree)
        {




            DriveInfo[] allDrives = DriveInfo.GetDrives();
            Console.WriteLine("Lenght d " + allDrives.Length);
            foreach (DriveInfo d in allDrives)
            {

                /*string dPath = d.Name.ToString();
                string access = Directory.GetAccessControl(dPath).ToString();
                string dType = d.DriveType.ToString();*/
                string path = @d.Name.ToString();
                Console.WriteLine("Drive Name " + path);
                Console.WriteLine("Drive type " + d.DriveType);


                PopulateTreeView(d.Name.ToString(),"drive",mytree);




            }

        }
    }
}
