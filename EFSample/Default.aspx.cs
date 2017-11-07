using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFSample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (TECHNETEntities db = new TECHNETEntities())
            {
                Articoli art = db.Articolis.Where((x) => x.CodArt == "ART001").FirstOrDefault();

                txtSample.Text = art.DesArt;
            }
        }
    }
}