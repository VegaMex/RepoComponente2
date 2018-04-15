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

        public void setEscolaridad(string escolaridad) {
            rtxt_escolaridad.Text = escolaridad;
        }

        public void setPonencia(string ponencia) {
            rtxt_ponencias.Text = ponencia;
        }

        public void setInvestigacion(string investigacion) {
            rtxt_investigacion.Text = investigacion;
        }

        public void setFoto(string path) {
            pictureBox_foto.Image = Image.FromFile(path);
        }

        private void label1_Click(object sender, EventArgs e) {
            
        }

        private void ContenedorDatos_Load(object sender, EventArgs e) {
            rtxt_descripcion.ReadOnly = true;
            rtxt_descripcion.BackColor = this.BackColor;
            rtxt_escolaridad.ReadOnly = true;
            rtxt_escolaridad.BackColor = this.BackColor;
            rtxt_ponencias.ReadOnly = true;
            rtxt_ponencias.BackColor = this.BackColor;
            rtxt_investigacion.ReadOnly = true;
            rtxt_investigacion.BackColor = this.BackColor;
        }
    }
}
