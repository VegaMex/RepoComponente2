using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vista2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
          contenedorDatos1.BackColor = this.BackColor;

            string[] imagenes1 = new string[3] { @"F:\CUARTO\Tópicos Avanzados de Programación\1 UNIDAD 3\SoluciónComponente2\Escuelas\logo_itc.png",
                @"F:\CUARTO\Tópicos Avanzados de Programación\1 UNIDAD 3\SoluciónComponente2\Escuelas\logo_itesm.png",
            @"F:\CUARTO\Tópicos Avanzados de Programación\1 UNIDAD 3\SoluciónComponente2\Escuelas\logo_upv.gif"};
            List<string[]> escuelas1 = new List<string[]>();
            escuelas1.Add(new string[2] { "ITCelaya", "Se graduó con honores como Licenciado en Informática." });
            escuelas1.Add(new string[2] { "ITESM", "Se graduó como Maestro en Administración de Tecnologías de la Información." });
            escuelas1.Add(new string[2] { "UPV", "Recibió los títulos de Máster en Computación Paralela y Distribuída y Doctor en Informática. Por su trabajo de Tesis doctoral, recibió la distinción Cum Laude." });
            contenedorDatos1.setEscolaridad(imagenes1, escuelas1);
            contenedorDatos1.setFoto(@"F:\CUARTO\Tópicos Avanzados de Programación\1 UNIDAD 3\SoluciónComponente2\Escuelas\persona1.jpg");
            contenedorDatos1.setNombre("Himer Avila George");
            contenedorDatos1.setDescripcion("Rápidamente descubrió su vocación por la investigación, por tal motivo, se enfocó en sus estudios de posgrado.");
            contenedorDatos1.setPonencia("Tiene al menos 10 certificaciones reconocidas por la industria (de empresas como Microsoft, Adobe y Oracle.\n\n" +
                "Ha participado en el diseño de planes y programas de estudio a nivel licenciatura y maestría; ha sido evaluador de proyectos y evaluador de planes y porgramas de estudio en el área de computación.");
            contenedorDatos1.setInvestigacion("Sus intereses de investigación incluyen: la aplicación de técnicas de aprendizaje máquina y procesamiento de imágenes en áreas como la salud, \n" +
                "agricultura, seguridad alimentaria, entre otras. La aceleración de algoritmos utilizando técnicas de computación paralela y distribuida, y la ingeniería de software.");

        }
    }
}
