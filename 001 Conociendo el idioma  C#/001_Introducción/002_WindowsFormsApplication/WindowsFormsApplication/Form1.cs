using System;

// El programa muestra en el  textBox1  "Hello World"

namespace WindowsFormsApplication
{
    public partial class Form1 
    {
        // Haga clic en controlador de eventos del botón (Handler).
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
