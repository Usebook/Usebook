using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace UseBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {       
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbooks wbks = app.Workbooks;
            _Workbook _wbk = wbks.Add(System.IO.Directory.GetCurrentDirectory()+"\\excel\\45F-48F座位图.xlsx");

            Sheets shs = _wbk.Sheets;
            _Worksheet[] _wsh = new Worksheet[4];
            for (int i=0; i<_wbk.Sheets.Count; i++)
            {
                _wsh[i] = (_Worksheet)shs.get_Item(i+1);
            }

            MessageBox.Show(_wsh[0].Range.g);


            MessageBox.Show("等一下");
            
        }
    }
}
