using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicioR
{
    public partial class Formulario2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnproceso_Click(object sender, EventArgs e)
        {
            
                double sueldo, v1, v2, v3, comision, to_ventas, pago_final;

                sueldo = Convert.ToDouble(txtsueldo.Text);
                v1 = Convert.ToDouble(txtventa1.Text);
                v2 = Convert.ToDouble(txtventa2.Text);
                v3 = Convert.ToDouble(txtventa3.Text);

                to_ventas = v1 + v2 + v3;
                comision = to_ventas * 0.10;
                pago_final = comision + sueldo;

                lblcomision.Text = System.Convert.ToString(comision);
                lblsuledob.Text = System.Convert.ToString(pago_final);


            }

        protected void btncalcular1_Click(object sender, EventArgs e)
        {
            
                double totalCompra, totalPagar, descuento;

                totalCompra = Convert.ToDouble(txtvalorcompra.Text);

                descuento = totalCompra * 0.15;
                totalPagar = totalCompra - descuento;

                lbltopagar.Text = Convert.ToString(totalPagar);
            }
        }
    }
    
