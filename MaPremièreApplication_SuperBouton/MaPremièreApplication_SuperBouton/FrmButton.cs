using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaPremièreApplication_SuperBouton
{
    public partial class FrmButton : Form
    {
        bool contact = false;
        
        public FrmButton()
        {
            InitializeComponent();
        }
        private void btnSuperButton_Click(object sender, EventArgs e)
        {
            Button monBouton2 = sender as Button;
            contact = false;

            if (monBouton2 != null)
            {
                monBouton2.Text = "Coucou, tu veux voir mon bouton?";
            }
            btnCible.Visible = true;

            //btnCible.Height = btnSuperButton.Height;      //identique à size, mais là on passe par la hauteur et la longueur
            //btnCible.Width = btnSuperButton.Width;

            btnCible.Size = btnSuperButton.Size;
            btnCible.Location = new Point((this.Width - btnCible.Width - 30), btnCible.Location.Y);
            btnCible.Enabled = false;
            timerCible.Start();
        }
        private void timerCible_Tick(object sender, EventArgs e)
        {
            if (!contact && this.Height > btnCible.Location.Y + btnCible.Height * 1.8)
            {
                btnCible.Location = new Point(btnCible.Location.X, btnCible.Location.Y + 1);
            }
            else
            {
                contact = true;

                if (btnSuperButton.Location.X < btnCible.Location.X)
                {
                    btnCible.Location = new Point(btnCible.Location.X - 1, btnCible.Location.Y);                    
                }
                else if ((btnSuperButton.Location.X <= btnCible.Location.X) && (btnCible.Location.Y > btnSuperButton.Location.Y + btnSuperButton.Height + 20))                    
                {
                    
                    btnCible.Location = new Point(btnCible.Location.X, btnCible.Location.Y - 1);
                    
                }
                else
                {
                    btnCible.Enabled = true;
                }
            }            
        }

        private void btnCible_EnabledChanged(object sender, EventArgs e)
        {
            //if (!btnCible.Enabled)
            
                return;
            
           DialogResult result = MessageBox.Show(
               "C'est terminé !\nRecommencer ?",
               "DL / CDI",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                btnSuperButton_Click(sender, e);
            }
        }
    }
}
