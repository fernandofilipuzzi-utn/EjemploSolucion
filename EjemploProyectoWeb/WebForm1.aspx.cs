using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EjemploProyectoClases;

namespace EjemploProyectoWeb
{
public partial class WebForm1 : System.Web.UI.Page
{
    Promedio promedio;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            promedio = new Promedio();
            Session["promedio"] = promedio;
        }
        else
        {
            promedio = (Promedio)Session["promedio"];
        }
    }

    protected void btnAgregarValor_Click(object sender, EventArgs e)
    {
        int numero = Convert.ToInt32(tbValor.Text);
        promedio.RegistrarNumero(numero);
        tbValor.Text = "";            
    }

    protected void btnCalcularPromedio_Click(object sender, EventArgs e)
    {
        tbPromedio.Text = promedio.CalcularPromedio().ToString("0.00");
    }
}
}