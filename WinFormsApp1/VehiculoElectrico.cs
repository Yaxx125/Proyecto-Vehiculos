using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesVehiculos
{
    class VehiculoElectrico : Vehiculo, IVehiculoElectrico
    {
        public int Bateria { get; set; }

        public void CargaBateria()
        {
            MessageBox.Show("Cargando bateria...");
            MessageBox.Show("Bateria cargada");
        }

        public override void Moverse()
        {
            MessageBox.Show($"Vehiculo electrico se está moviendo, carga : {Bateria}% ");
        }
    }
}
