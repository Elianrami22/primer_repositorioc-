using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicioR
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            int fecha1, fecha2, edad;
            fecha1 = Convert.ToInt32(txtnacimiento.Text);
            fecha2 = Convert.ToInt32(txtañoactual.Text);

            edad = fecha2 - fecha1;
            lblresultado.Text = System.Convert.ToString(edad);
        }
        
        protected void btncalculo_Click(object sender, EventArgs e)
        {
            double valor, ganancia, valorTo;

            valor = Convert.ToInt32(txtvalorinver.Text);
            lblvalorinvert.Text = System.Convert.ToString(valor);

            ganancia = valor * 0.02;
            lblresul.Text = System.Convert.ToString(ganancia);

            valorTo = valor + ganancia;
            lblresultado1.Text = System.Convert.ToString(valorTo);

        }

        


        protected void btncalculodefini_Click(object sender, EventArgs e)
        {
            double c1, c2, c3, ef, tf, promedio, p_calificacionesf, p_exFinal, p_traFinal,cal_final;

            c1 = Convert.ToDouble(txtnota1.Text);
            c2 = Convert.ToDouble(txtnota2.Text);
            c3 = Convert.ToDouble(txtnota3.Text);
            ef = Convert.ToDouble(txtexmenfinal.Text);
            tf = Convert.ToDouble(txttrabajofinal.Text);

            promedio = (c1 + c2 + c3) / 3;
            p_calificacionesf = promedio * 0.55;

            p_exFinal = ef * 0.30;
            p_traFinal = tf * 0.15;

            cal_final = p_calificacionesf + p_exFinal + p_traFinal;

            lbldefinitiva.Text = System.Convert.ToString(cal_final);



        }

        protected void btnporcentaje_Click(object sender, EventArgs e)
        {
            int ch, cm, t_alumnos, ph, pm;

            ch = Convert.ToInt32(txtChombres.Text);
            cm = Convert.ToInt32(txtcmujeres.Text);

            t_alumnos = cm + ch;
            pm = cm * 100 / t_alumnos;
            ph = ch * 100 / t_alumnos;

            lblporcenm.Text = System.Convert.ToString(pm);
            lblporcenh.Text = System.Convert.ToString(ph);
        }
    }
}