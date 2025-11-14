using BE;
using BLL;
using Microsoft.VisualBasic;

namespace Ejerciotacion_AdoDesconectado
{
    public partial class Form1 : Form
    {
        private UsuarioBLL usuarioBll = new UsuarioBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_AGREGAR_USUARIO_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese nombre", "Nombre Usuario");
            string tipo = "Huesped";
            string mail = "Example@gmail.com";
            UsuarioBE usuarioBe = new UsuarioBE(
                nombre,
                tipo,
                mail
                );
            usuarioBll.Agregar(usuarioBe);

        }

        private void Actualizar()
        {

        }


    }
}
