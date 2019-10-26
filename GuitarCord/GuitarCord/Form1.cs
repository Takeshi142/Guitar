using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarCord
{

    public partial class Cord : Form
    {
        
        public Cord()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ComboBox選択時処理
        /// ListBoxにファイル名を拡張子なしで追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCord_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Foldername = this.cmbCord.Text;
            listBox.Items.Clear();
            foreach (string f in getFolderName(Foldername))
            {
               listBox.Items.Add(Path.GetFileNameWithoutExtension(f));
            }
        }
        /// <summary>
        /// 引数でResourcesからフォルダ内のすべてのファイルを取得
        /// </summary>
        /// <param name="cordName">フォルダ名</param>
        /// <returns></returns>
        private IEnumerable<string> getFolderName(string cordName)
        {
            IEnumerable<string> nameFiles = 
                System.IO.Directory.EnumerateFiles(@"Resources/"+cordName, "*",System.IO.SearchOption.AllDirectories);

            if (nameFiles != null)return nameFiles;
            else                  return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayButton_Click(object sender, EventArgs e)
        { 
            var folderName  = cmbCord.Text;
            var cordName    = listBox.Text;
            if (folderName == "" || cordName == "")
            {
                return;
            }
            else
            {
                var cordImg = new CordImg();
                cordImg.ViewCord(folderName,cordName);
            }

        }

        //試作
        //private void ViewCord(string cord, PictureBox pictureBox)
        //{
        //    var assembly = Assembly.GetExecutingAssembly();
        //    var resourceName = string.Format("GuitarCord.Resources.{0}.png", cord);

        //    using (var stream = assembly.GetManifestResourceStream(resourceName))
        //    {
        //        Bitmap bitmap = new Bitmap(stream);
        //        pictureBox.Image = bitmap;
        //    }
        //}

        //選択された文字列をつないで画像取得クラスに渡す
        //public string CordSelect(ComboBox firstCord, CheckBox sharp, ComboBox secondCord)
        //{
        //    string cord         = "";
        //    string cord2        = "";


        //    //ComboBoxのチェック
        //    if (firstCord.Text == "")
        //    {
        //        MessageBox.Show("指定してください");
        //    }
        //    else
        //    {
        //        cord            = firstCord.Text;
        //    }

        //    if (secondCord.Text != "none")
        //    { 
        //        cord2           = secondCord.Text;
        //    }

        //    //シャープのCheckBoxの判定
        //    if (sharp.Checked != false)
        //    {
        //        return cord + "#" + cord2;
        //    }
        //    else
        //    {
        //        return cord + cord2;
        //    }

        //}


        //public void GetFileName()
        //{
        //    IEnumerable<string> files =
        //    　System.IO.Directory.EnumerateFiles(@"C:\test", "*", System.IO.SearchOption.AllDirectories);
        //}
    }
}
