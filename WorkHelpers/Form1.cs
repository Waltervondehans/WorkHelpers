using Novacode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHelpers.Klassen;

namespace WorkHelpers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            WorkHelpers.Klassen.Table table = SQLHelper.getTableFromCreateStatement(tbSQL.Text);
            //https://docx.codeplex.com/
            //Word http://www.codeproject.com/Articles/660478/Csharp-Create-and-Manipulate-Word-Documents-Progra
            string fileName = @"DocXExample.docx";
            var doc = DocX.Create(fileName);
            //doc.InsertParagraph("This is my first paragraph");
            Novacode.Table t = doc.AddTable(table.Cokumns.Count+1, 5);
            int index = 0;

            t.Rows[index].Cells[0].Paragraphs.First().Append("Spalte");
            t.Rows[index].Cells[1].Paragraphs.First().Append("SCDHash");
            t.Rows[index].Cells[2].Paragraphs.First().Append("Datentyp");
            t.Rows[index].Cells[3].Paragraphs.First().Append("nullable");
            t.Rows[index++].Cells[4].Paragraphs.First().Append("Quellspalte");
            foreach (Column column in table.Cokumns)
            {
                t.Rows[index].Cells[0].Paragraphs.First().Append(column.Name);
                t.Rows[index++].Cells[2].Paragraphs.First().Append(column.Datatyp);
            }
            doc.InsertTable(t);

            doc.Save();

            Process.Start("WINWORD.EXE", fileName);
        }

        
        
    }
}
