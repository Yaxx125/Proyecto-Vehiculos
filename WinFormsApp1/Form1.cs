using GesVehiculos;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Vehiculo vehiculoActual;
        public Form1()
        {
            InitializeComponent();
            cboTipoVehiculo.SelectedIndex = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoVehiculo.SelectedItem.ToString() == "Auto" || cboTipoVehiculo.SelectedItem.ToString() == "Motocicleta")
            {
                lblPasajeros.Visible = true;
                txtPasajeros.Visible = true;
            }
            else
            {
                lblPasajeros.Visible = false;
                txtPasajeros.Visible = false;
            }


            if (cboTipoVehiculo.SelectedItem.ToString() == "Camión")
            {
                lblCapacidadCarga.Visible = true;
                txtCarga.Visible = true;
            }
            else
            {
                lblCapacidadCarga.Visible = false;
                txtCarga.Visible = false;
            }

            if (cboTipoVehiculo.SelectedItem.ToString() == "Vehiculo Electrico")
            {
                lblBateria.Visible = true;
                txtBateria.Visible = true;
                btnCargar.Visible = true;
            }
            else
            {
                lblBateria.Visible = false;
                txtBateria.Visible = false;
                btnCargar.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtMarca.Text) || (lblPasajeros.Visible && string.IsNullOrWhiteSpace(txtPasajeros.Text)) || (lblCapacidadCarga.Visible && string.IsNullOrWhiteSpace(txtCarga.Text)) || (lblBateria.Visible && string.IsNullOrWhiteSpace(txtBateria.Text)))
            {
                MessageBox.Show("Por favor, rellene los parámetros necesarios.");
            }
            else
            {
                SeleccionarVehiculo();
                MessageBox.Show("Vehiculo agregado");

                vehiculoActual.Marca = txtMarca.Text;
                vehiculoActual.Modelo = txtModelo.Text;


            }
        }

        private void btnMoverse_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            vehiculoActual.Moverse();
        }

        private void btnDetenerse_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            vehiculoActual.Detenerse();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            vehiculoActual.Iniciar();
        }

        private void SeleccionarVehiculo()
        {
            string seleccion = cboTipoVehiculo.SelectedItem.ToString();

            switch (seleccion)
            {
                case "Auto":
                    vehiculoActual = new Auto();
                    Auto auto = (Auto)vehiculoActual;
                    auto.Marca = txtMarca.Text;
                    auto.Modelo = txtModelo.Text;
                    auto.CantPasajeros = int.Parse(txtPasajeros.Text);
                    break;

                case "Motocicleta":
                    vehiculoActual = new Motocicleta();
                    Motocicleta motocicleta = (Motocicleta)vehiculoActual;
                    motocicleta.Marca = txtMarca.Text;
                    motocicleta.Modelo = txtModelo.Text;
                    motocicleta.CantidadP = int.Parse(txtPasajeros.Text);
                    break;

                case "Camión":
                    vehiculoActual = new Camion();
                    Camion camion = (Camion)vehiculoActual;
                    camion.Marca = txtMarca.Text;
                    camion.Modelo = txtModelo.Text;
                    camion.CapCarga = int.Parse(txtCarga.Text);
                    break;

                case "Vehiculo Electrico":
                    vehiculoActual = new VehiculoElectrico();
                    VehiculoElectrico electrico = (VehiculoElectrico)vehiculoActual;
                    electrico.Marca = txtMarca.Text;
                    electrico.Modelo = txtModelo.Text;
                    electrico.Bateria = int.Parse(txtBateria.Text);
                    break;

                default:
                    MessageBox.Show("Seleccione un tipo de vehículo.");
                    break;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show($"Cargando el vehiculo...");
            
        }

        private void txtBateria_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBateria.Text) || !int.TryParse(txtBateria.Text, out int porcentajeBateria))
            {
                MessageBox.Show("Por favor, ingrese un valor válido para la batería.");
                return;
            }

            if (porcentajeBateria <= 30)
            {
                MessageBox.Show($"Cargue el vehiculo, no se podrá usar");
                Close();
            }
            else
            {
                MessageBox.Show($"La bateria está en buen estado.");
            }
        }
    }
}
