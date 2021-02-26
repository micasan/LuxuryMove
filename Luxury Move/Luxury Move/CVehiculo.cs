using System;
namespace Luxury_Move
{
    public class CVehiculo:IComparable
    {
        private string dominio;
        private string gama;
        private double costo;

        public CVehiculo(string dom, string tipo)
        {
            this.dominio = dom;
            this.gama = tipo;
        }
        public string getDominio()
        {
            return this.dominio;
        }
        public void setCosto(double monto)
        {
            this.costo=monto;
        }
        public double getCosto()
        {
            return this.costo;
        }
        public virtual string darDatosAuxiliares()
        {
            string retorno = "Gama: " + this.gama;
            retorno += " - Costo: $" + this.costo.ToString();
            return retorno;
        }
        public int CompareTo(object obj)
        {
            if (obj is CVehiculo)
            {
                return this.dominio.CompareTo(((CVehiculo)obj).getDominio());
            }
            return int.MinValue;
        }
    }
}
