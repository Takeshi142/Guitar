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

namespace GuitarCord
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameFile = this.comBox.Text;
            string[] cordNames = getCordName(nameFile);
            foreach (string f in cordNames)
            {
               listBox.Items.Add(Path.GetFileNameWithoutExtension(f));

            }
        }

        private string[] getCordName(string cordName)
        {
            string[] nameFiles =
                System.IO.Directory.GetFileSystemEntries(@"Resources/"+cordName, "*", System.IO.SearchOption.AllDirectories);
            if (nameFiles != null)
            {
                return nameFiles;
            }
            else
            {
                return null;
            }
        }

        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
