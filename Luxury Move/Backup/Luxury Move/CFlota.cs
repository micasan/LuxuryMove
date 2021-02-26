using System;
using System.Collections;
namespace Luxury_Move
{
    public class CFlota
    {
        private ArrayList parque;

        public CFlota()
        {
            this.parque = new ArrayList(0);
        }
        
        public CVehicLujo buscar(string dom)
        {
            foreach (CVehicLujo auxVLujo in this.parque)
            {
                if (auxVLujo.getDominio() == dom) return auxVLujo;
            }
            return null;
         }
        public bool registrar(string dom, string tipo, double monto, bool rastSat)
        {
            CVehicLujo auxVLujo = this.buscar(dom);
            if (auxVLujo == null)
            {
                auxVLujo = new CVehicLujo(dom, tipo, rastSat);
                auxVLujo.setCosto(monto);
                this.parque.Add(auxVLujo);
                return true;
            }
            return false;
        }
        public bool remover(string dom)
        {
            CVehicLujo auxVLujo = this.buscar(dom);
            if (auxVLujo != null) 
            {
                this.parque.Remove(auxVLujo);
                return true;
            }
            return false;
        }
        public string darDatos(string dom,ushort dias)
        {
            CVehicLujo auxVLujo = this.buscar(dom);
            if (auxVLujo != null) return auxVLujo.darDatos(dias);
            return "Vehículo NO registrado";
        }
    }
}
