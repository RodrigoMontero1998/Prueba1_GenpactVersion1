using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;

namespace Proyecto1
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {

        }

        private List<String> xlsfiles= new List<string>();
        private List<String> othersfiles = new List<string>();

        private void button1_ClickAsync(object sender, EventArgs e)
        {

            string aux = procesar(textPath.Text, xlsfiles);
            if (aux != "")
            {
                string dir = textPath.Text;
                string dirxls = createFolder(dir, "Procesado");
                string dirotherfiles = createFolder(dir, "No aplicable");
                foreach (string elem in xlsfiles)
                {
                    moveFile(elem, dirxls);
                }
                foreach (string elem in othersfiles)
                {
                    moveFile(elem, dirotherfiles);
                }
                //resetear para que vuelvan aparecer los archivos
                //
                listView.Items.Clear();
                foreach (string Item in Directory.GetFiles(textPath.Text))
                {
                    FileInfo fi = new FileInfo(Item);
                    imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName));
                    if (fi.FullName.Contains(".xls"))
                    {
                        xlsfiles.Add(fi.Name);
                    }
                    else
                    {
                        othersfiles.Add(fi.Name);
                    }
                    listView.Items.Add(fi.Name, imageList.Images.Count - 1);
                }
                MessageBox.Show("Se consolidaron correctamente los archivos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true; 
            DialogResult result = folderDlg.ShowDialog();
             xlsfiles = new List<string>();
            othersfiles = new List<string>();
            listView.Items.Clear();
            if (result == DialogResult.OK)
            {
                textPath.Text = folderDlg.SelectedPath;
                foreach (string Item in Directory.GetFiles(folderDlg.SelectedPath))
                {
                    FileInfo fi = new FileInfo(Item);
                    imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName));
                    if (fi.FullName.Contains(".xls"))
                    {
                        xlsfiles.Add(fi.Name);
                    }
                    else
                    {
                        othersfiles.Add(fi.Name);
                    }
                    listView.Items.Add(fi.Name, imageList.Images.Count-1);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string createFolder(string dir, string nameFolder)
        {
            System.IO.Directory.CreateDirectory(dir+"\\"+nameFolder);
            return dir +"\\"+ nameFolder;
        }
        private void moveFile(string nameFile,string dir)
        {
            if (!System.IO.File.Exists(dir+"\\"))
            {
                System.IO.File.Move(textPath.Text+"\\"+nameFile, dir+"\\"+nameFile);
            }
               
        }

        public string procesar(string dir, List<string> listFiles)
        {
            
            List<string> inputFiles = new List<string>();
            foreach(string item in listFiles){
                inputFiles.Add(dir + "\\" + item);
            }
            if (inputFiles.Count > 0)
            {
                Workbook newWorkbook = new Workbook();
                newWorkbook.Worksheets.Clear();
                Workbook tempWorkbook = new Workbook();
                foreach (string file in inputFiles)
                {
                    tempWorkbook.LoadFromFile(file);
                    foreach (Worksheet sheet in tempWorkbook.Worksheets)
                    {
                        newWorkbook.Worksheets.AddCopy(sheet, WorksheetCopyType.CopyAll);
                    }
                }
                
                newWorkbook.SaveToFile(dir + "\\ArchivoMaestro.xlsx", ExcelVersion.Version2013);

                return dir + "\\ArchivoMaestro.xlsx";
                
            }
            else
            {
                return "";
            }
        }

       

    }
}
