using System;
namespace Luxury_Move
{
    public class CControladora
    {
        public static void Main()
        {
            CFlota sucursal = new CFlota();
            char opcion;
            string auxDom;
            double auxMonto;
            do
            {
                opcion = Convert.ToChar(CInterfaz.darOpcion().ToUpper());
                //.ToUpper() Convierte la cadena a MAYÚSCULAS.
                switch (opcion)
                {
                    case 'E':
                        auxMonto = Convert.ToSingle(CInterfaz.pedirDato("Seguro de garantía ($)"));
                        CVehicLujo.setSeguro(auxMonto);
                        //Lo correcto sería que CComplejo tenga un método setSeguro()
                        break;
                    case 'A':
                        auxDom = CInterfaz.pedirDato("Dominio");
                        string auxTipo = CInterfaz.pedirDato("Gama");
                        auxMonto = Convert.ToSingle(CInterfaz.pedirDato("Costo de alquiler diario ($)"));
                        bool auxRastSat = Convert.ToBoolean(CInterfaz.pedirDato("¿Tiene rastreador satelital [true-false]"));
                        if (!sucursal.registrar(auxDom, auxTipo, auxMonto,auxRastSat ))
                        {
                            CInterfaz.mostrarInfo("Vehículo Preexistente");
                        }
                        break;
                    case 'P':
                        ushort auxDias = Convert.ToUInt16(CInterfaz.pedirDato("Cantidad de días a alquilar"));
                        auxDom = CInterfaz.pedirDato("Dominio");
                        CInterfaz.mostrarInfo(sucursal.darDatos(auxDom, auxDias));
                        break;
                    case 'R':
                        auxDom = CInterfaz.pedirDato("Dominio");
                        if (!sucursal.remover(auxDom))
                        {
                            CInterfaz.mostrarInfo("Vehículo Inexistente");
                        }
                        break;
                    case 'S':
                        break;
                    default:
                        CInterfaz.mostrarInfo("Opción inválida");
                        break;
                }
            } while (opcion != 'S');
        }
    }
}

