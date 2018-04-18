using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class ContenedorDatos: UserControl
    {
        public ContenedorDatos()
        {
            InitializeComponent();
        }



        public void setNombre(string nombre) {
            lbl_nombre.Text = nombre;
        }

        public void setDescripcion(string descripcion) {
            rtxt_descripcion.Text = descripcion;
        }


        public void setPonencia(string ponencia) {
            rtxt_ponencias.Text = ponencia;
        }

        public void setInvestigacion(string investigacion) {
            rtxt_investigacion.Text = investigacion;
        }

        public void setFoto(string path) {

            try {
                pictureBox_foto.Image = Image.FromFile(path);
            } catch (Exception) {
                
            }
            
        }

        public void setEscolaridad(string[]imagenes, List<string[]> instituciones) {

            ListViewGroup inst = new ListViewGroup("Instituciones", HorizontalAlignment.Left);

            listaview.View = View.SmallIcon;

            ImageList listaimagenes = new ImageList();

            listaimagenes.ImageSize = new Size(32, 32);

            try {

                foreach (var item in imagenes) {
                    listaimagenes.Images.Add(Image.FromFile(item));
                }

            } catch (Exception) {
                
            }

            listaview.SmallImageList = listaimagenes;

            for (int i = 0; i < instituciones.Count; i++) {
                listaview.Items.Add(new ListViewItem(instituciones[i], i, inst));
            }

            listaview.Groups.Add(inst);

        }

        private void label1_Click(object sender, EventArgs e) {
            
        }

        private void ContenedorDatos_Load(object sender, EventArgs e) {
            rtxt_descripcion.ReadOnly = true;
            rtxt_descripcion.BackColor = this.BackColor;
            rtxt_ponencias.ReadOnly = true;
            rtxt_ponencias.BackColor = this.BackColor;
            rtxt_investigacion.ReadOnly = true;
            rtxt_investigacion.BackColor = this.BackColor;
            rtxt_escolaridad.BackColor = this.BackColor;
            listaview.BackColor = this.BackColor;
        }

        private void listaview_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void listaview_MouseClick(object sender, MouseEventArgs e) {
            rtxt_escolaridad.Text = listaview.SelectedItems[0].SubItems[1].Text;
        }
    }
}
