﻿using Novacode;
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


            //Word http://www.codeproject.com/Articles/660478/Csharp-Create-and-Manipulate-Word-Documents-Progra
            // Modify to suit your machine:
            string fileName = @"DocXExample.docx";

            // Create a document in memory:
            var doc = DocX.Create(fileName);

            // Insert a paragrpah:
            //doc.InsertParagraph("This is my first paragraph");

            Novacode.Table t = doc.AddTable(table.Cokumns.Count+1, 5);
            int i = 0;
            t.Rows[i].Cells[0].Paragraphs.First().Append("Spalte");
            t.Rows[i].Cells[1].Paragraphs.First().Append("SCDHash");
            t.Rows[i].Cells[2].Paragraphs.First().Append("Datentyp");
            t.Rows[i].Cells[3].Paragraphs.First().Append("nullable");
            t.Rows[i++].Cells[4].Paragraphs.First().Append("Quellspalte");
            foreach (Column column in table.Cokumns)
            {
                t.Rows[i].Cells[0].Paragraphs.First().Append(column.Name);
                t.Rows[i++].Cells[2].Paragraphs.First().Append(column.Datatyp);
            }
            doc.InsertTable(t);

            // Save to the output directory:
            doc.Save();

            // Open in Word:
            Process.Start("WINWORD.EXE", fileName);
        }

        
        
    }
}