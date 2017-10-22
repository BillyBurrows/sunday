using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WilliamBurrowsumb.Core.Controllers;
using WilliamBurrowsumb.Core.Models;

namespace WilliamBurrowsumb.Core.Controllers
{
   public class RatesSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        // GET: RatesSurface
        public ActionResult Get()
        {
             var db = new Umbraco.Core.Persistence.Database("TheBeerHouse");

           

              var listobj = db.Fetch<TableModel>(";EXEC wsp_anntableV1");


             return PartialView("RatesPartial", listobj);
           // return PartialView("RatesPartial");
        }

        [HttpPost]
        public ActionResult HandelFormSubmit(int id)
        {
            var db = new Umbraco.Core.Persistence.Database("TheBeerHouse");

            //       var listobj = db.Fetch<ContactFormViewModel>(";EXEC ContactQry");

            var listobj = db.Fetch<TableModel>(";EXEC wsp_anntableV2 @0", id);


            return PartialView("RatesPartial", listobj);
        }
    }
}