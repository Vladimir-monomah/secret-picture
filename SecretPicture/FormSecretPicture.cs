using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretPicture
{
    public partial class FormSecretPicture : Form
    {
        int secret_nr = 0;
        public FormSecretPicture()
        {
            InitializeComponent();
        }

        private void buttonShowImage1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.picture1;
            secret_nr = 0;
        }

        private void buttonShowImage2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.picture2;
            secret_nr = 0;
        }

        private void buttonShowImage3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.picture3;
            secret_nr = 0;
        }

        private void buttonShowImage4_Click(object sender, EventArgs e)
        {
            if(secret_nr==2)
                this.BackgroundImage = Properties.Resources.secret;
            else
            this.BackgroundImage = Properties.Resources.picture4;
            secret_nr = 0;
        }

        private void FormSecretPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                secret_nr = 1;
            
        }

        private void FormSecretPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (secret_nr == 1)
                if (e.X < buttonShowImage1.Location.X &&
                    e.Y < buttonShowImage1.Location.Y)
                    secret_nr = 2;
        }
    }
}
