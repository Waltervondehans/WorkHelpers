using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHelpers.Klassen
{
    public static class SQLHelper
    {
        public static Table getTableFromCreateStatement(string createStatement) {
            Table table = new Table();
            string[] columns = createStatement.Split(',');
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
                    Column column = getColumnInfos(w[1] + " " + werte[3] + " " + werte[4]);
                }
                else
                {
                    Column column = getColumnInfos(s);
                    table.Cokumns.Add(column);
                }
            }
            return table;
        }

        private static Column getColumnInfos(string s)
        {
            s = StringHelper.cleanupSQL(s);
            string[] werte = s.Split(' ');
            Column column = new Column();
            column.Name = werte[0];
            column.Datatyp = werte[1];
            column.isNullable = werte[2] == "NULL" ? true : false;
            return column;
        }
    }
}
