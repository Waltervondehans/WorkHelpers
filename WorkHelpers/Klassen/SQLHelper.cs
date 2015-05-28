using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkHelpers.Klassen
{
    public static class SQLHelper
    {
        public static Table getTableFromCreateStatement(string createStatement) {
            Table table = new Table();
            string[] columns = Regex.Split(createStatement, "\n");// createStatement.Split(',');
            foreach (string s in columns)
            {
                if (s.Contains("(") && s.Contains("CREATE"))
                {
                    //erste Zeile
                    string[] werte = s.Split(' ');//CREATE TABLE [dbo].[DimCountry]([ImportID] [bigint] NULL
                    string[] w = werte[2].Split('(');//[dbo].[DimCountry](\r\n\t[ImportID]
                    string[] x = w[0].Split('.');//[dbo].[DimCountry]
                    table.Schema = StringHelper.cleanupSQL(x[1]);
                    table.Name = StringHelper.cleanupSQL(x[0]);
                    try
                    {
                        string c = w[1] + " " + werte[3] + " " + werte[4];
                        if (c.Length > 3)
                        {
                            Column column = getColumnInfos(c);
                        }
                    }
                    catch 
                    {
                    }
                }
                else
                {
                    if (s.Length > 3)
                    {
                        Column column = getColumnInfos(s);
                        table.Cokumns.Add(column);
                    }
                }
            }
            return table;
        }

        private static Column getColumnInfos(string s)
        {
            s = StringHelper.cleanupSQL(s);
            //[(]{1}[ ]*[0-9]{1,2}[ ]*[,]{1}[ ]*[0-9]{1,2}[ ]*[)]
            s=Regex.Replace(s,"[ ]*[)]",")");//(9,6 )->(9,6)
            s=Regex.Replace(s, "[(][ ]*","(");//( 9,6)->(9,6)
            s = Regex.Replace(s, "[,][ ]*", ",");//(9, 6)->(9,6)
            s = Regex.Replace(s, "[ ]*[,]", ",");//(9 ,6)->(9,6)
            string[] werte = s.Split(' ');
            Column column = new Column();
            column.Name = werte[0];
            column.Datatyp = werte[1];
            column.isNullable = werte[2] == "NULL" ? true : false;
            return column;
        }
    }
}
