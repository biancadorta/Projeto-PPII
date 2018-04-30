using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class DragDrop : Form
    {
        public DragDrop()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DragDrop_Load(object sender, EventArgs e)
        {
            pic1.AllowDrop = true;
            pic2.AllowDrop = true;
            pic3.AllowDrop = true;
            pic4.AllowDrop = true;
            pic5.AllowDrop = true;
            pic6.AllowDrop = true;
            pic7.AllowDrop = true;
            pic8.AllowDrop = true;
        }

        private void picbMercurio_MouseClick(object sender, MouseEventArgs e)
        {
          //  this.DoDragDrop();
        }

        private void pic1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;               
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void picbMercurio_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.DoDragDrop(pic.BackgroundImage, DragDropEffects.Copy| DragDropEffects.None);
        }

        private void pic1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb1 = (PictureBox)sender;
            pb1.BackColor = Color.Transparent;
            pb1.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);           
        }

        private void pic1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pic1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pic1.BackgroundImage != null)
            {
                if (pic1.BackgroundImage.Equals(picbMercurio.BackgroundImage))
                    MessageBox.Show("Acertouu");
                else
                    MessageBox.Show("Errou");
            }
        }

        private void picMarte_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.DoDragDrop(pic.BackgroundImage, DragDropEffects.Copy | DragDropEffects.None);
        }

        private void picSaturno_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.DoDragDrop(pic.BackgroundImage, DragDropEffects.Copy | DragDropEffects.None);

        }

        private void picVenus_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.DoDragDrop(pic.BackgroundImage, DragDropEffects.Copy | DragDropEffects.None);
        }

        private void picJupiter_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.DoDragDrop(pic.BackgroundImage, DragDropEffects.Copy | DragDropEffects.None);
        }

        private void picNetuno_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.DoDragDrop(pic.BackgroundImage, DragDropEffects.Copy | DragDropEffects.None);
        }

        private void picTerra_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.DoDragDrop(pic.BackgroundImage, DragDropEffects.Copy | DragDropEffects.None);
        }

        private void pic2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pic3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pic4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pic5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pic6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pic7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pic8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void pic2_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb1 = (PictureBox)sender;
            pb1.BackColor = Color.Transparent;
            pb1.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pic3_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb1 = (PictureBox)sender;
            pb1.BackColor = Color.Transparent;
            pb1.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pic4_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb1 = (PictureBox)sender;
            pb1.BackColor = Color.Transparent;
            pb1.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pic5_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb1 = (PictureBox)sender;
            pb1.BackColor = Color.Transparent;
            pb1.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pic6_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb1 = (PictureBox)sender;
            pb1.BackColor = Color.Transparent;
            pb1.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pic7_DragDrop(object sender, DragEventArgs e)
        {
            dragDrop(sender,e);
        }

        private void dragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb1 = (PictureBox)sender;
            pb1.BackColor = Color.Transparent;
            pb1.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pic8_DragDrop(object sender, DragEventArgs e)
        {
            dragDrop(sender, e);
        }

        private void pic1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pic1.BackgroundImage != null)
            {
                if (pic1.BackgroundImage.Equals(picbMercurio.BackgroundImage))
                    picValida.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/certoo.jpg");
                else                    
                    picValida.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/erradoo.jpg"); 
                   
            }
        }

        private void pic2_MouseMove(object sender, MouseEventArgs e)
        {
            if(pic2.BackgroundImage != null)
            { 
                if(pic2.BackgroundImage.Equals(picVenus.BackgroundImage))
                    picValida2.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/certoo.jpg");
                else
                    picValida2.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/erradoo.jpg");
            }
        }

        private void pic3_MouseMove(object sender, MouseEventArgs e)
        {
            if (pic3.BackgroundImage != null)
            {
                if(pic3.BackgroundImage.Equals(picTerra.BackgroundImage))
                    picValida3.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/certoo.jpg");
                else
                    picValida3.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/erradoo.jpg");
            }
        }

        private void pic7_Click(object sender, EventArgs e)
        {

        }

        private void pic3_Click(object sender, EventArgs e)
        {

        }

        private void pic4_MouseMove(object sender, MouseEventArgs e)
        {
            if (pic4.BackgroundImage != null)
            {
                if (pic4.BackgroundImage.Equals(picMarte.BackgroundImage))
                    picValida4.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/certoo.jpg");
                else
                    picValida4.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/erradoo.jpg");
            }
        }

        private void pic5_MouseMove(object sender, MouseEventArgs e)
        {
            if(pic5.BackgroundImage != null)
            {
                if(pic5.BackgroundImage.Equals(picJupiter.BackgroundImage))
                    picValida5.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/certoo.jpg"); 
                else
                    picValida5.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/erradoo.jpg"); 
            }
        }

        private void pic6_MouseMove(object sender, MouseEventArgs e)
        {
            if (pic6.BackgroundImage != null)
            {
                if(pic6.BackgroundImage.Equals(picSaturno.BackgroundImage))
                    picValida6.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/certoo.jpg");
                else
                    picValida6.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/erradoo.jpg");

            }
        }

        private void pic8_MouseMove(object sender, MouseEventArgs e)
        {
            if (pic8.BackgroundImage != null)
            {
                if(pic8.BackgroundImage.Equals(picNetuno.BackgroundImage))
                    picValida8.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/certoo.jpg");
                else
                    picValida8.BackgroundImage = Image.FromFile("E:/3º Semestre/PPII/imagens s2/erradoo.jpg");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
