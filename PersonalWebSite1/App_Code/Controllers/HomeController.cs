using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.Mvc;

/// <summary>
/// Summary description for HomeController
/// </summary>
public class HomeController : Controller
{

    public ActionResult Index()
    {

        var ds = GetDataForHomePage();
        return View(ds);

    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult Index(string newValue)
    {

        if (newValue != "GOOD VALUE")
        {
            ViewData["newValue"] = newValue;
            return RedirectToAction("ValidationError");
        } else
        {
            ViewData["newValue"] = newValue;
            return View("Index");
        }

    }

    private DataSet GetDataForHomePage()
    {
        return this.GetDAL().GetData();
    }

}
