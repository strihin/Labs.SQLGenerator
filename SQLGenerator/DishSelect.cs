using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLGenerator
{
    public partial class DishSelect : Form
    {
        public List<CheckBox> CheckBoxes { get; set; }
        private const string _sqlPattern = "SELECT * FROM RecipesTable WHERE\n";
        private const string _productNotNull = "({0}<>0) AND ";
        private const string _typePattern = "(type = '{0}') AND ";
        public List<string> Products { get; set; }
       
        public DishSelect()
        {
            InitializeComponent();

            CheckBoxes = new List<CheckBox> { cbAll, cbFirst, cbSecond, cbSalad, cbDessert };
            Products = new List<string> { "apple", "carrot", "banana", "garlic", "sugar" };
        }

        private void btnGenerateSQL_Click(object sender, EventArgs e)
        {
            // Если не выбран ни один продукт, вместо запроса пустая строка
            if (clbProducts.CheckedIndices.Count == 0)
            {
                rtbSQL.Text = string.Empty;
                return;
            }
            
            // Добавление продуктов в запрос
            rtbSQL.Text = _sqlPattern;
            foreach (int index in clbProducts.CheckedIndices)
            {
                rtbSQL.Text += string.Format(_productNotNull, Products[index]);
                rtbSQL.Text += "\n";
            }

            var checkBoxes = CheckBoxes.Where(checkBox => checkBox.Checked).ToList();
            
            // Если выбраны все типы блюд, к запросу они не добавляются
            if( checkBoxes.Count != CheckBoxes.Count)
            {

                if ( checkBoxes.Count == CheckBoxes.Count - 1 || CheckBoxes[0].Checked == true )
                {
                    rtbSQL.Text += string.Format(_typePattern, CheckBoxes[0].Text);
                    rtbSQL.Text = rtbSQL.Text.Remove(rtbSQL.Text.LastIndexOf("AND"));
                    SaveSqlToFile(rtbSQL.Text);
                    return;
                }
                foreach (var checkBox in checkBoxes)
                {
                    rtbSQL.Text += string.Format(_typePattern, checkBox.Text);
                    rtbSQL.Text += "\n";
                }    
            }

            rtbSQL.Text = rtbSQL.Text.Remove(rtbSQL.Text.LastIndexOf("AND"));

            SaveSqlToFile(rtbSQL.Text);
        }

        /// <summary>
        /// Метод сохранение строки sql-запроса в файл
        /// </summary>
        /// <param name="sql">sql-запрос</param>
        private static void SaveSqlToFile(string sql)
        {
           /* using (var streamWriter = new StreamWriter("SQL.txt"))
            {
                streamWriter.WriteLine(sql);
            }
            */
            StreamWriter SW = new StreamWriter(new FileStream("SQL.txt", FileMode.Append, FileAccess.Write));
            SW.WriteLine(sql);
            SW.Close();
        }
    }
}
