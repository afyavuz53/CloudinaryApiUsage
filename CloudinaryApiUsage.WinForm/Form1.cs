using CloudinaryApiUsage.WinForm.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudinaryApiUsage.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hepsi (*.*)|*.*|Jpeg (*.jfif)|*.jfif|Jpeg (*.jpg)|*.jpg|PNG (*.png*)|*.png";
            openFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog.FileName))
            {
                pbResim.Image = Image.FromFile(openFileDialog.FileName);
                pbResim.Tag = openFileDialog.FileName;
            }
        }

        [Obsolete]
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var newUrl = Upload.UploadImage(pbResim.Tag.ToString());
            tbUrlPath.Text = newUrl;
        }
    }
}
