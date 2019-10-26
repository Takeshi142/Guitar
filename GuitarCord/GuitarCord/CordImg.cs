using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarCord
{

    public partial class CordImg : Form
    {
        private Point mousePoint;
        public CordImg()
        {
            InitializeComponent();
        }
        //埋め込みリソースを使ってパスを指定pictureBoxに表示
        public void ViewCord(string folderName,string fileName)
        {
            var assembly                  = Assembly.GetExecutingAssembly();
            var resourceName              = string.Format("GuitarCord.Resources.{0}.{1}.jpg", folderName, fileName);
            if(fileName != null)this.Text = fileName;
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                Bitmap bitmap = new Bitmap(stream);
                if (bitmap != null)
                {
                    this.imgCord.Image = bitmap;
                    Show();
                }
                else
                {
                    MessageBox.Show("選択されたコードが存在しません");
                }
            }
        }



        //現在マウスドラックでフォームを移動させる処理---------------------------
        private void CordImg_Load(object sender, EventArgs e)
        {
            imgCord.MouseDown += new MouseEventHandler(CordImg_MouseDown);
            imgCord.MouseMove += new MouseEventHandler(CordImg_MouseMove);
        }
        private void CordImg_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePoint = new Point(e.X, e.Y);
            }
        }
        private void CordImg_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }
        //フォームダブルクリックで閉じる
        private void ImgCord_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ImgCord_Click(object sender, EventArgs e)
        {

        }
    }
}
