namespace Tabla_Multiplicar_6_2_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Numero.Text, out int numero))
            {
                MostrarTabla(numero);
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void MostrarTabla(int numero)
        {
            // Limpiar el área de texto antes de mostrar la nueva tabla
            lst_Tabla.Items.Clear();

            // Generar y mostrar la tabla de multiplicar en el área de texto

            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                lst_Tabla.Items.Add($"{numero} x {i} = {resultado}");
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}