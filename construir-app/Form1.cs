﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace construir_app
{
    public partial class frmDiscos : Form
    {


        private List<Disco> listaDisco;
        public frmDiscos()
        {
            InitializeComponent();
            this.Size = new Size(1463, 680);
        }
       

        private void frmDiscos_Load(object sender, EventArgs e)
        {
            DiscoService service = new DiscoService();
            listaDisco = service.listar();
            dgvDiscos.DataSource = listaDisco;

            //OCULTO LA VISIBILIDAD DE LA COLUMNA URLIMAGENTAPA
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;



            cargarImagen(listaDisco[0].UrlImagenTapa);
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagenTapa);
        }


        private void cargarImagen (string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxDisco.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }

        }

    }
}
