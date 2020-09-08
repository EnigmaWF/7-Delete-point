using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Delete_point
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*7. Дана символьная строка, в которой имеется хотя бы одна ","
                 Напишите программу, которая преобразует строку, удаляя из 
                 нее все точки, предшедствующие первой запятой*/
            string s = Convert.ToString(textBox1.Text);  //ввод строки
            string n = ""; //строковая переменная 
            if (s.IndexOf(Convert.ToChar(",")) != -1) //если в строке есть запятая, тогда
            {
                for (int i = 0; i < s.IndexOf(Convert.ToChar(",")); i++) //от i=0 до первого вхождения запятой
                {
                    n = (s.Substring(0, s.IndexOf(Convert.ToChar(",")))).Replace(".", "");
                    //заменяем все . на "ничего" в строке s (начиная с 0 элемента, заканчивая первым вхождением запятой)
                }
                label1.Text = "" + n + s.Substring(s.IndexOf(Convert.ToChar(",")));
                /*выводим n(строка с 0 элемента, заканчивая первым вхождением запятой строки s)
                  +
                  строка s (начиная с первого вхождения запятой и до конца строки*/
            }
            else //если в строке нет запятых
            {
                label1.Text = "" + s; //выводим строку без изменений
            }
        }
    }
}
