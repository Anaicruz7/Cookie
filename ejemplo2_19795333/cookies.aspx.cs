using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo2_19795333
{
	public partial class cookies : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Response.Redirect
                (
            "Cokkie2ConfirmProduct.aspx" + "?ddlCategory=" + ddlCategory.SelectedValue + "&ddlSupplier=" + ddlSupplier.SelectedValue + "&txtProducto=" + txtProduct.Text + "&txtDescripcion=" + txtDescripcion.Text + "&txtImagen=" + txtImagen.Text + "&decprice=" + txtPrice.Text + "&byNumberInStock=" + txtNumberInStock.Text + "&byNumberOnOrder=" + txtNumberOnOrder.Text + "&byReorderLevel=" + txtNumberOnOrder.Text);
        }
    }
}