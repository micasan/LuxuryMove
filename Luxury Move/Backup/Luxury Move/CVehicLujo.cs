using System;
namespace Luxury_Move
{
    public class CVehicLujo:CVehiculo
    {
        private static double seguro;
        private bool rastreador;
        
        public static void setSeguro(double garantia)
        {
            CVehicLujo.seguro = garantia;
        }
        public CVehicLujo(string dom, string tipo, bool rastSat): base(dom, tipo)
        {
            this.rastreador = rastSat;
            this.setCosto(5000.0D);
        }
        public double darPresupuesto(ushort dias)
        {
            return (CVehicLujo.seguro+this.getCosto() * dias) * 1.21D;
            
        }
        public string darDatos(ushort dias)
        {
            string retorno = "Seguro: $" + Convert.ToString(CVehicLujo.seguro);
            retorno += "\nDominio: " + base.getDominio();
            retorno += "\n" + this.darDatosAuxiliares();
            retorno += " - Rastreador Satelital: ";
            if (this.rastreador) retorno += "Si";
            else retorno += "No";
            retorno += "\nPresupuesto: $" + Convert.ToString(this.darPresupuesto(dias));
            return retorno;
        }

    }
}
