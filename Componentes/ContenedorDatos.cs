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


        /// <summary>
        /// Coloca el nombre de la persona.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        public void setNombre(string nombre) {
            lbl_nombre.Text = nombre;
        }

        /// <summary>
        /// Coloca la descripción de la persona.
        /// </summary>
        /// <param name="descripcion">Texto de descripción.</param>
        public void setDescripcion(string descripcion) {
            rtxt_descripcion.Text = descripcion;
        }

        /// <summary>
        /// Coloca la ponencia de la persona.
        /// </summary>
        /// <param name="ponencia">Texto de ponencia.</param>
        public void setPonencia(string ponencia) {
            rtxt_ponencias.Text = ponencia;
        }

        /// <summary>
        /// Coloca la investigación de la persona.
        /// </summary>
        /// <param name="investigacion">Texto de investigación.</param>
        public void setInvestigacion(string investigacion) {
            rtxt_investigacion.Text = investigacion;
        }

        /// <summary>
        /// Coloca la foto a través de una ruta de archivo espeficicada.
        /// </summary>
        /// <param name="path">Ruta de archivo de imagen.</param>
        public void setFoto(string path) {

            try {
                pictureBox_foto.Image = Image.FromFile(path);
            } catch (Exception) {
                
            }
            
        }

        /// <summary>
        /// Coloca una lista de las escuelas en el historial académico de la persona, incluyendo el logo de la misma
        /// y una descripción del título recibido.
        /// </summary>
        /// <param name="imagenes">Arreglo con las rutas de las imágenes de los logos de las escuelas.</param>
        /// <param name="instituciones">Lista de arreglos, cada uno de ellos debe contener el nombre de la escuela
        /// y el título recibido en la misma.</param>
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

        /// <summary>
        /// Evento para ver el título recibido en cada escuela.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaview_MouseClick(object sender, MouseEventArgs e) {
            rtxt_escolaridad.Text = listaview.SelectedItems[0].SubItems[1].Text;
        }
    }
}
