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

        public string path;

        private void Form1_Load(object sender, EventArgs e) {

            if (MessageBox.Show("Por favor seleccione la carpeta donde se encuentra la solución.", "Aviso", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                    path = folderBrowserDialog1.SelectedPath;
                }

            } else {
                Application.Exit();
            }

            contenedorDatos1.BackColor = this.BackColor;

            string[] imagenes1 = new string[3] { path+@"\Pictures\logo_itc.png",
                path+@"\Pictures\logo_itesm.png",
            path+@"\Pictures\logo_upv.gif"};
            List<string[]> escuelas1 = new List<string[]>();
            escuelas1.Add(new string[2] { "ITCelaya", "Se graduó con honores como Licenciado en Informática." });
            escuelas1.Add(new string[2] { "ITESM", "Se graduó como Maestro en Administración de Tecnologías de la Información." });
            escuelas1.Add(new string[2] { "UPV", "Recibió los títulos de Máster en Computación Paralela y Distribuída y Doctor en Informática. Por su trabajo de Tesis doctoral, recibió la distinción Cum Laude." });
            contenedorDatos1.setEscolaridad(imagenes1, escuelas1);
            contenedorDatos1.setFoto(path + @"\Pictures\persona1.jpg");
            contenedorDatos1.setNombre("Himer Avila George");
            contenedorDatos1.setDescripcion("Rápidamente descubrió su vocación por la investigación, por tal motivo, se enfocó en sus estudios de posgrado.");
            contenedorDatos1.setPonencia("Tiene al menos 10 certificaciones reconocidas por la industria (de empresas como Microsoft, Adobe y Oracle.\n\n" +
                "Ha participado en el diseño de planes y programas de estudio a nivel licenciatura y maestría; ha sido evaluador de proyectos y evaluador de planes y porgramas de estudio en el área de computación.");
            contenedorDatos1.setInvestigacion("Sus intereses de investigación incluyen: la aplicación de técnicas de aprendizaje máquina y procesamiento de imágenes en áreas como la salud, \n" +
                "agricultura, seguridad alimentaria, entre otras. La aceleración de algoritmos utilizando técnicas de computación paralela y distribuida, y la ingeniería de software.");

            string[] imagenes2 = new string[3] { path+@"\Pictures\logo_itesm.png",
                path+@"\Pictures\logo_ipn.jpg" , path+@"\Pictures\logo_usal.jpg"};
            List<string[]> escuelas2 = new List<string[]>();
            escuelas2.Add(new string[2] { "ITESM", "Ingeniero Ambiental." });
            escuelas2.Add(new string[2] { "IPN", "Maestro en Ecología." });
            escuelas2.Add(new string[2] { "USAL", "Doctor en Geología." });
            contenedorDatos2.setEscolaridad(imagenes2, escuelas2);
            contenedorDatos2.setFoto(path + @"\Pictures\persona3.png");
            contenedorDatos2.setNombre("Javier Méndez Rodríguez");
            contenedorDatos2.setDescripcion("Integer non felis in ex consequat rutrum. Nam porttitor malesuada tellus nec laoreet. Maecenas a placerat tellus. Ut dapibus posuere dapibus. Proin tempus maximus enim." +
                "Donec metus orci, consequat vel condimentum at, fermentum porttitor erat. Fusce vitae nunc eget ex semper maximus et vitae quam. Mauris nec elit elementum, vulputate velit sit amet, volutpat neque. " +
                "Pellentesque id ex quis velit venenatis maximus a in libero.");
            contenedorDatos2.setPonencia("Quisque suscipit ipsum vulputate, sagittis nisi in, cursus enim. Morbi rutrum tincidunt sapien, sit amet convallis risus mattis eu. Mauris dui purus, pellentesque sit amet fermentum ut, " +
                "vestibulum venenatis ante. Quisque mi dolor, cursus placerat interdum vehicula, faucibus ac justo. Mauris faucibus euismod nulla, et euismod tortor placerat ac. Nam quis ornare tortor. Sed consequat purus at leo " +
                "semper commodo. Ut tortor quam, aliquet eget feugiat in, laoreet in erat. Nulla facilisi. Etiam at magna molestie, maximus nisl egestas, malesuada nibh. Vivamus sed nisl ac dui aliquam ultrices sit amet ac metus. Etiam sodales, " +
                "ligula et dapibus luctus, nisi ante venenatis dui, eu pharetra eros felis in ipsum.");
            contenedorDatos2.setInvestigacion("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed eget placerat risus. Duis tempus faucibus mi, eget tincidunt sapien posuere vitae. Sed tempor vestibulum hendrerit. Sed ut auctor purus. " +
                "Praesent pulvinar dui sit amet laoreet hendrerit. Mauris ut feugiat mi. Sed a enim non purus placerat molestie.");

            string[] imagenes3 = new string[3] { path+@"\Pictures\logo_ug.png", path + @"\Pictures\logo_unam.png",
            path + @"\Pictures\logo_udg.png"};
            List<string[]> escuelas3 = new List<string[]>();
            escuelas3.Add(new string[2] { "UG", "Licenciada en Letras." });
            escuelas3.Add(new string[2] { "UNAM", "Maestra en Filosofía." });
            escuelas3.Add(new string[2] { "UdG", "Doctora en Castellano." });
            contenedorDatos3.setEscolaridad(imagenes3, escuelas3);
            contenedorDatos3.setFoto(path + @"\Pictures\persona4.png");
            contenedorDatos3.setNombre("Karen Figueroa Zúñiga");
            contenedorDatos3.setDescripcion("Integer non felis in ex consequat rutrum. Nam porttitor malesuada tellus nec laoreet. Maecenas a placerat tellus. Ut dapibus posuere dapibus. Proin tempus maximus enim.");
            contenedorDatos3.setPonencia("Quisque suscipit ipsum vulputate, sagittis nisi in, cursus enim. Morbi rutrum tincidunt sapien, sit amet convallis risus mattis eu. Mauris dui purus, pellentesque sit amet fermentum ut, " +
                "vestibulum venenatis ante. Quisque mi dolor, cursus placerat interdum vehicula, faucibus ac justo. Mauris faucibus euismod nulla, et euismod tortor placerat ac. Nam quis ornare tortor. Sed consequat purus at leo " +
                "semper commodo. Ut tortor quam, aliquet eget feugiat in, laoreet in erat. Nulla facilisi. Etiam at magna molestie, maximus nisl egestas, malesuada nibh. Vivamus sed nisl ac dui aliquam ultrices sit amet ac metus. Etiam sodales, " +
                "ligula et dapibus luctus, nisi ante venenatis dui, eu pharetra eros felis in ipsum.");
            contenedorDatos3.setInvestigacion("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed eget placerat risus. Duis tempus faucibus mi, eget tincidunt sapien posuere vitae. Sed tempor vestibulum hendrerit. Sed ut auctor purus. " +
                "Praesent pulvinar dui sit amet laoreet hendrerit. Mauris ut feugiat mi. Sed a enim non purus placerat molestie." +
                "Sed sollicitudin blandit pharetra. Nulla et est eu tortor sagittis tincidunt nec eu odio. Nulla euismod facilisis ligula, vel interdum justo lacinia ac. Aenean varius dolor eu ipsum vehicula lobortis." +
                "Fusce a efficitur lectus. Nulla convallis nisl eget neque aliquam commodo ac a sem. Maecenas placerat posuere arcu nec rhoncus. Sed consectetur diam vel tellus consequat fringilla. Suspendisse sed magna ut nisi scelerisque facilisis. ");

        }

    }
}
