using Facturacion.MaterialUI.MaterialSkinUI;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class main : MaterialForm
    {
        MaterialSkinUI materialSkinUI = new MaterialSkinUI();

        public main()
        {
            InitializeComponent();

            materialSkinUI.MaterialSkin(this);

        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cmsDataSet.Tercero' Puede moverla o quitarla según sea necesario.
            // this.terceroTableAdapter.Fill(this.cmsDataSet.Tercero);
            // TODO: esta línea de código carga datos en la tabla 'cmsDataSet.Tercero' Puede moverla o quitarla según sea necesario.
            // this.terceroTableAdapter.Fill(this.cmsDataSet.Tercero);

        }
    }
}
