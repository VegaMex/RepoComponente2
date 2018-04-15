using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            contenedorDatos2.descripcion("Establecer AutoEllipsis a true para mostrar el texto que se extiende más allá del ancho de la Label cuando el usuario se desplaza sobre el control con el mouse. Si AutoSize es true, la etiqueta aumentará hasta ajustarse al texto y los puntos suspensivos no aparecerán.");
        }
    }
}
