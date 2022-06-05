using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace stajDefteri
{
    public partial class Form1 : Form
    {
        string allText;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path2 = @"C:\\stajdefterim\\stajDefterim" + dateDate.Value.Date.ToShortDateString() + ".txt";
            allText = "Tarih: " + dateDate.Value.ToString() + " Başlık: " + tbTitle.Text + " Özet: " + tbSummary.Text + " Yapılan İş: " + tbJobText.Text;
            File.WriteAllText(path2, allText);
            MessageBox.Show("Günlük iş eklenildi.");
        }
    }
}