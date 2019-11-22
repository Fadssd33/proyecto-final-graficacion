using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualC;

namespace Proyecto_Final_Graficacion
{
    public partial class Form1 : Form
    {

        private Device device;

        private CustomVertex.PositionColored[] vertex;

        int[] cameraView;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            vertex = new CustomVertex.PositionColored[200];

            cameraView = new int[3];

            cameraView[0] = 0;

            cameraView[1] = 0;

            cameraView[2] = 25;


            PresentParameters pp;
            pp = new PresentParameters();


            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard;


            device = new Device(0, DeviceType.Hardware, panel1, CreateFlags.HardwareVertexProcessing, pp);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            draw();
        }

        private void draw() { 

            device.Transform.Projection = Matrix.PerspectiveFovLH(3.14f/4, device.Viewport.Width/device.Viewport.Height,1f,1000f);

            device.Transform.View = Matrix.LookAtLH( new Vector3(cameraView[0], cameraView[1], cameraView[2]), new Vector3(0,0,-5),new Vector3(0,1,0));

            device.RenderState.Lighting= false;



            //Parte concreto superior derecho
            vertex[0] = new CustomVertex.PositionColored(new Vector3(30, 1, -30), Color.Maroon.ToArgb());
            vertex[1] = new CustomVertex.PositionColored(new Vector3(-30, 1, -30), Color.Maroon.ToArgb());
            vertex[2] = new CustomVertex.PositionColored(new Vector3(30, 1, 1), Color.Maroon.ToArgb());

            //Parte concreto superio izquierdo 
            vertex[3] = new CustomVertex.PositionColored(new Vector3(-30, 1, -30), Color.Maroon.ToArgb());
            vertex[4] = new CustomVertex.PositionColored(new Vector3(-30, 1, 1), Color.Maroon.ToArgb());
            vertex[5] = new CustomVertex.PositionColored(new Vector3(30, 1, 1), Color.Maroon.ToArgb());

      

            //frontal de arriba parte de concreto
            vertex[6] = new CustomVertex.PositionColored(new Vector3(-30, 1, 1), Color.Green.ToArgb());
            vertex[7] = new CustomVertex.PositionColored(new Vector3(-30, 0, 1), Color.Blue.ToArgb());
            vertex[8] = new CustomVertex.PositionColored(new Vector3(30, 0, 1), Color.Purple.ToArgb());

            //frontal de abajo parte de concreto
            vertex[9] = new CustomVertex.PositionColored(new Vector3(-30, 1, 1), Color.Red.ToArgb());
            vertex[10] = new CustomVertex.PositionColored(new Vector3(30, 0, 1), Color.Green.ToArgb());
            vertex[11] = new CustomVertex.PositionColored(new Vector3(30, 1, 1), Color.Navy.ToArgb());



            //concreto lado derecho inferior
            vertex[12] = new CustomVertex.PositionColored(new Vector3(-30, 1, 1), Color.Red.ToArgb());
            vertex[13] = new CustomVertex.PositionColored(new Vector3(-30, 0, -30), Color.Green.ToArgb());
            vertex[14] = new CustomVertex.PositionColored(new Vector3(-30, 0, 1), Color.Blue.ToArgb());

            //concreto lado derecho superior
            vertex[15] = new CustomVertex.PositionColored(new Vector3(-30, 1, -30), Color.DarkRed.ToArgb());
            vertex[16] = new CustomVertex.PositionColored(new Vector3(-30, 0, -30), Color.Blue.ToArgb());
            vertex[17] = new CustomVertex.PositionColored(new Vector3(-30, 1, 1), Color.Green.ToArgb());



            //Parte trasera superior derecha
            vertex[18] = new CustomVertex.PositionColored(new Vector3(-30, 1, -30), Color.Red.ToArgb());
            vertex[19]= new CustomVertex.PositionColored(new Vector3(30, 1, -30), Color.Green.ToArgb());
            vertex[20] = new CustomVertex.PositionColored(new Vector3(30, 0, -30),Color.Navy.ToArgb());

            //Parte trasera superior derecha
            vertex[21]= new CustomVertex.PositionColored(new Vector3(-30, 0, -30), Color.Red.ToArgb());
            vertex[22] = new CustomVertex.PositionColored(new Vector3(-30, 1, -30), Color.Green.ToArgb());
            vertex[23] = new CustomVertex.PositionColored(new Vector3(30, 0, -30), Color.Navy.ToArgb());



            //Parte concreto inferior derecho inferior
            vertex[24] = new CustomVertex.PositionColored(new Vector3(-30, 0, 1), Color.Red.ToArgb());
            vertex[25] = new CustomVertex.PositionColored(new Vector3(-30, 0, -30), Color.Green.ToArgb());
            vertex[26] = new CustomVertex.PositionColored(new Vector3(30, 0, 1), Color.Blue.ToArgb());

            //Parte concreto inferior izquierdo 
            vertex[27] = new CustomVertex.PositionColored(new Vector3(-30, 0, -30), Color.Red.ToArgb());
            vertex[28] = new CustomVertex.PositionColored(new Vector3(30, 0, -30), Color.Blue.ToArgb());
            vertex[29] = new CustomVertex.PositionColored(new Vector3(30, 0, 1), Color.Green.ToArgb());



            //frontal barda derecha inferior
            vertex[30] = new CustomVertex.PositionColored(new Vector3(-28, 4, 0), Color.Green.ToArgb());
            vertex[31] = new CustomVertex.PositionColored(new Vector3(-28, 1, 0), Color.Blue.ToArgb());
            vertex[32] = new CustomVertex.PositionColored(new Vector3(-3, 1, 0), Color.Purple.ToArgb());

            //frontal barda derecha inferior
            vertex[33] = new CustomVertex.PositionColored(new Vector3(-28, 4, 0), Color.Red.ToArgb());
            vertex[34] = new CustomVertex.PositionColored(new Vector3(-3, 1, 0), Color.Green.ToArgb());
            vertex[35] = new CustomVertex.PositionColored(new Vector3(-3, 4, 0), Color.Navy.ToArgb());
                

            
            //frontal barda derecha trasera
            vertex[36] = new CustomVertex.PositionColored(new Vector3(-28, 4, -1), Color.Green.ToArgb());
            vertex[37] = new CustomVertex.PositionColored(new Vector3(-28, 1, -1), Color.Blue.ToArgb());
            vertex[38] = new CustomVertex.PositionColored(new Vector3(-3, 1, -1), Color.Purple.ToArgb());

            //frontal barda derecha trasera
            vertex[39] = new CustomVertex.PositionColored(new Vector3(-28, 4, -1), Color.Red.ToArgb());
            vertex[40] = new CustomVertex.PositionColored(new Vector3(-3, 1, -1), Color.Green.ToArgb());
            vertex[41] = new CustomVertex.PositionColored(new Vector3(-3, 4, -1), Color.Navy.ToArgb());


            /*
            //frontal barda derecha inferior
            vertex[42] = new CustomVertex.PositionColored(new Vector3(-15, 4, 0), Color.Green.ToArgb());
            vertex[43] = new CustomVertex.PositionColored(new Vector3(-15, 1, 0), Color.Blue.ToArgb());
            vertex[44] = new CustomVertex.PositionColored(new Vector3(-3, 1, 0), Color.Purple.ToArgb());

            //frontal barda derecha inferior
            vertex[45] = new CustomVertex.PositionColored(new Vector3(-15, 4, 0), Color.Red.ToArgb());
            vertex[46] = new CustomVertex.PositionColored(new Vector3(-3, 1, 0), Color.Green.ToArgb());
            vertex[47] = new CustomVertex.PositionColored(new Vector3(-3, 4, 0), Color.Navy.ToArgb());

            */

            bardaDerecha();


            //dibujarPuertita();





            device.Clear(ClearFlags.Target, Color.Black, 3, 0);
            device.BeginScene();
            device.VertexFormat = CustomVertex.PositionColored.Format;

            device.DrawUserPrimitives(PrimitiveType.TriangleList, 100, vertex);

            device.EndScene();
            device.Present();

        }


        private void dibujarPuertita()
        {
            //vertex[42] = new CustomVertex.PositionColored(new Vector3(-10, 10, 0), Color.Green.ToArgb());
            //vertex[43] = new CustomVertex.PositionColored(new Vector3(-10, 1, 0), Color.Blue.ToArgb());
            //vertex[44] = new CustomVertex.PositionColored(new Vector3(-10, 1, 5), Color.Purple.ToArgb());
        }

        private void bardaDerecha()
        {
            // Parte exterior
            // inferior
            //vertex[42] = new CustomVertex.PositionColored(new Vector3(-28, 4, 0), Color.Green.ToArgb());
            //vertex[43] = new CustomVertex.PositionColored(new Vector3(-28, 1, -28), Color.Blue.ToArgb());
            //vertex[44] = new CustomVertex.PositionColored(new Vector3(-28, 1, 0), Color.Purple.ToArgb());
            vertex[42] = new CustomVertex.PositionColored(new Vector3(-28, 1, 0), Color.Green.ToArgb());
            vertex[43] = new CustomVertex.PositionColored(new Vector3(-28, 1, -28), Color.Blue.ToArgb());
            vertex[44] = new CustomVertex.PositionColored(new Vector3(-28, 4, 0), Color.Purple.ToArgb());

            // Superior
            //vertex[45] = new CustomVertex.PositionColored(new Vector3(-28, 4, 0), Color.Green.ToArgb());
            //vertex[46] = new CustomVertex.PositionColored(new Vector3(-28, 4, -28), Color.Blue.ToArgb());
            //vertex[47] = new CustomVertex.PositionColored(new Vector3(-28, 1, -28), Color.Purple.ToArgb());
            vertex[45] = new CustomVertex.PositionColored(new Vector3(-28, 1, -28), Color.Green.ToArgb());
            vertex[46] = new CustomVertex.PositionColored(new Vector3(-28, 4, -28), Color.Blue.ToArgb());
            vertex[47] = new CustomVertex.PositionColored(new Vector3(-28, 4, 0), Color.Purple.ToArgb());

            // PARTE INTERIOR BARDA
            // inferior
            //vertex[48] = new CustomVertex.PositionColored(new Vector3(-27, 4, 0), Color.Green.ToArgb());
            //vertex[49] = new CustomVertex.PositionColored(new Vector3(-27, 1, -28), Color.Blue.ToArgb());
            //vertex[50] = new CustomVertex.PositionColored(new Vector3(-27, 1, 0), Color.Purple.ToArgb());
            vertex[48] = new CustomVertex.PositionColored(new Vector3(-27, 1, 0), Color.Green.ToArgb());
            vertex[49] = new CustomVertex.PositionColored(new Vector3(-27, 1, -28), Color.Blue.ToArgb());
            vertex[50] = new CustomVertex.PositionColored(new Vector3(-27, 4, 0), Color.Purple.ToArgb());

            // Superior
            //vertex[51] = new CustomVertex.PositionColored(new Vector3(-27, 4, 0), Color.Green.ToArgb());
            //vertex[52] = new CustomVertex.PositionColored(new Vector3(-27, 4, -28), Color.Blue.ToArgb());
            //vertex[53] = new CustomVertex.PositionColored(new Vector3(-27, 1, -28), Color.Purple.ToArgb());
            vertex[51] = new CustomVertex.PositionColored(new Vector3(-27, 1, -28), Color.Green.ToArgb());
            vertex[52] = new CustomVertex.PositionColored(new Vector3(-27, 4, -28), Color.Blue.ToArgb());
            vertex[53] = new CustomVertex.PositionColored(new Vector3(-27, 4, 0), Color.Purple.ToArgb());



            // BARDA TRASERA
            // atras
            //vertex[54] = new CustomVertex.PositionColored(new Vector3(-28, 1, -28), Color.Green.ToArgb());
            //vertex[55] = new CustomVertex.PositionColored(new Vector3(-28, 4, -28), Color.Blue.ToArgb());
            //vertex[56] = new CustomVertex.PositionColored(new Vector3(28, 1, -28), Color.Purple.ToArgb());
            vertex[54] = new CustomVertex.PositionColored(new Vector3(28, 1, -28), Color.Green.ToArgb());
            vertex[55] = new CustomVertex.PositionColored(new Vector3(-28, 4, -28), Color.Blue.ToArgb());
            vertex[56] = new CustomVertex.PositionColored(new Vector3(-28, 1, -28), Color.Purple.ToArgb());
            //vertex[57] = new CustomVertex.PositionColored(new Vector3(28, 4, -28), Color.Green.ToArgb());
            //vertex[58] = new CustomVertex.PositionColored(new Vector3(-28, 4, -28), Color.Blue.ToArgb());
            //vertex[59] = new CustomVertex.PositionColored(new Vector3(28, 1, -28), Color.Purple.ToArgb());
            vertex[57] = new CustomVertex.PositionColored(new Vector3(28, 1, -28), Color.Green.ToArgb());
            vertex[58] = new CustomVertex.PositionColored(new Vector3(-28, 4, -28), Color.Blue.ToArgb());
            vertex[59] = new CustomVertex.PositionColored(new Vector3(28, 4, -28), Color.Purple.ToArgb());

            // frente
            //vertex[60] = new CustomVertex.PositionColored(new Vector3(-28, 1, -27), Color.Green.ToArgb());
            //vertex[61] = new CustomVertex.PositionColored(new Vector3(-28, 4, -27), Color.Blue.ToArgb());
            //vertex[62] = new CustomVertex.PositionColored(new Vector3(28, 1, -27), Color.Purple.ToArgb());
            vertex[60] = new CustomVertex.PositionColored(new Vector3(28, 1, -27), Color.Green.ToArgb());
            vertex[61] = new CustomVertex.PositionColored(new Vector3(-28, 4, -27), Color.Blue.ToArgb());
            vertex[62] = new CustomVertex.PositionColored(new Vector3(-28, 1, -27), Color.Purple.ToArgb());
            //vertex[63] = new CustomVertex.PositionColored(new Vector3(28, 4, -27), Color.Green.ToArgb());
            //vertex[64] = new CustomVertex.PositionColored(new Vector3(-28, 4, -27), Color.Blue.ToArgb());
            //vertex[65] = new CustomVertex.PositionColored(new Vector3(28, 1, -27), Color.Purple.ToArgb());

            vertex[63] = new CustomVertex.PositionColored(new Vector3(28, 1, -27), Color.Green.ToArgb());
            vertex[64] = new CustomVertex.PositionColored(new Vector3(28, 4, -27), Color.Blue.ToArgb());
            vertex[65] = new CustomVertex.PositionColored(new Vector3(-28, 4, -27), Color.Purple.ToArgb());

            // Barda frente izquierda
            //vertex[66] = new CustomVertex.PositionColored(new Vector3(28, 4, 0), Color.Green.ToArgb());
            //vertex[67] = new CustomVertex.PositionColored(new Vector3(28, 1, 0), Color.Blue.ToArgb());
            //vertex[68] = new CustomVertex.PositionColored(new Vector3(3, 1, 0), Color.Purple.ToArgb());
            vertex[66] = new CustomVertex.PositionColored(new Vector3(3, 1, 0), Color.Green.ToArgb());
            vertex[67] = new CustomVertex.PositionColored(new Vector3(28, 1, 0), Color.Blue.ToArgb());
            vertex[68] = new CustomVertex.PositionColored(new Vector3(28, 4, 0), Color.Purple.ToArgb());
            //vertex[69] = new CustomVertex.PositionColored(new Vector3(28, 4, 0), Color.Green.ToArgb());
            //vertex[70] = new CustomVertex.PositionColored(new Vector3(3, 1, 0), Color.Blue.ToArgb());
            //vertex[71] = new CustomVertex.PositionColored(new Vector3(3, 4, 0), Color.Purple.ToArgb());
            vertex[69] = new CustomVertex.PositionColored(new Vector3(3, 4, 0), Color.Green.ToArgb());
            vertex[70] = new CustomVertex.PositionColored(new Vector3(3, 1, 0), Color.Blue.ToArgb());
            vertex[71] = new CustomVertex.PositionColored(new Vector3(28, 4, 0), Color.Purple.ToArgb());


            // barda trasera izquierda
            //vertex[72] = new CustomVertex.PositionColored(new Vector3(28, 4, -1), Color.Green.ToArgb());
            //vertex[73] = new CustomVertex.PositionColored(new Vector3(28, 1, -1), Color.Blue.ToArgb());
            //vertex[74] = new CustomVertex.PositionColored(new Vector3(3, 1, -1), Color.Purple.ToArgb());
            vertex[72] = new CustomVertex.PositionColored(new Vector3(3, 1, -1), Color.Green.ToArgb());
            vertex[73] = new CustomVertex.PositionColored(new Vector3(28, 1, -1), Color.Blue.ToArgb());
            vertex[74] = new CustomVertex.PositionColored(new Vector3(28, 4, -1), Color.Purple.ToArgb());
            //vertex[75] = new CustomVertex.PositionColored(new Vector3(28, 4, -1), Color.Green.ToArgb());
            //vertex[76] = new CustomVertex.PositionColored(new Vector3(3, 1, -1), Color.Blue.ToArgb());
            //vertex[77] = new CustomVertex.PositionColored(new Vector3(3, 4, -1), Color.Purple.ToArgb());
            vertex[75] = new CustomVertex.PositionColored(new Vector3(3, 4, -1), Color.Green.ToArgb());
            vertex[76] = new CustomVertex.PositionColored(new Vector3(3, 1, -1), Color.Blue.ToArgb());
            vertex[77] = new CustomVertex.PositionColored(new Vector3(28, 4, -1), Color.Purple.ToArgb());

            // barda izquierda lateral fuera
            //vertex[78] = new CustomVertex.PositionColored(new Vector3(28, 4, -28), Color.Green.ToArgb());
            //vertex[79] = new CustomVertex.PositionColored(new Vector3(28, 1, 0), Color.Blue.ToArgb());
            //vertex[80] = new CustomVertex.PositionColored(new Vector3(28, 4, 0), Color.Purple.ToArgb());
            vertex[78] = new CustomVertex.PositionColored(new Vector3(28, 4, -28), Color.Green.ToArgb());
            vertex[79] = new CustomVertex.PositionColored(new Vector3(28, 1, 0), Color.Blue.ToArgb());
            vertex[80] = new CustomVertex.PositionColored(new Vector3(28, 4, 0), Color.Purple.ToArgb());
            //vertex[81] = new CustomVertex.PositionColored(new Vector3(28, 4, -28), Color.Green.ToArgb());
            //vertex[82] = new CustomVertex.PositionColored(new Vector3(28, 1, 0), Color.Blue.ToArgb());
            //vertex[83] = new CustomVertex.PositionColored(new Vector3(28, 1, -28), Color.Purple.ToArgb());
            vertex[81] = new CustomVertex.PositionColored(new Vector3(28, 1, -28), Color.Green.ToArgb());
            vertex[82] = new CustomVertex.PositionColored(new Vector3(28, 1, 0), Color.Blue.ToArgb());
            vertex[83] = new CustomVertex.PositionColored(new Vector3(28, 4, -28), Color.Purple.ToArgb());

            // Barda izquierda latera interior
            vertex[84] = new CustomVertex.PositionColored(new Vector3(27, 4, -28), Color.Green.ToArgb());
            vertex[85] = new CustomVertex.PositionColored(new Vector3(27, 1, 0), Color.Blue.ToArgb());
            vertex[86] = new CustomVertex.PositionColored(new Vector3(27, 4, 0), Color.Purple.ToArgb());
            vertex[87] = new CustomVertex.PositionColored(new Vector3(27, 1, -28), Color.Green.ToArgb());
            vertex[88] = new CustomVertex.PositionColored(new Vector3(27, 1, 0), Color.Blue.ToArgb());
            vertex[89] = new CustomVertex.PositionColored(new Vector3(27, 4, -28), Color.Purple.ToArgb());


        }
        private void btnXmas_Click_1(object sender, EventArgs e)
        {
            cameraView[0]++;
            panel1.Refresh();
        }

        private void btnXmenos_Click_1(object sender, EventArgs e)
        {
            cameraView[0]--;
            panel1.Refresh();
        }

        private void btnYmas_Click(object sender, EventArgs e)
        {
            cameraView[1]++;
            panel1.Refresh();
        }

        private void btYmenos_Click(object sender, EventArgs e)
        {
            cameraView[1]--;
            panel1.Refresh();
        }

        private void btnZmas_Click(object sender, EventArgs e)
        {
            cameraView[2]++;
            panel1.Refresh();
        }

        private void btnZmenos_Click(object sender, EventArgs e)
        {
            cameraView[2]--;
            panel1.Refresh();
        }


    }
}
