using System;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for basePage
/// </summary>
public abstract class BasePage : System.Web.UI.Page
{
    private IDataAccessLayer _Data;

	public BasePage()
	{
	    var d = this.GetDAL();
    }

}

public static class BaseExtensionMethods
{

    public static IDataAccessLayer GetDAL(this Page page)
    {
        return GetDAL();
    }

    public static IDataAccessLayer GetDAL(this Controller ctl)
    {
        return GetDAL();
    }

    private static IDataAccessLayer GetDAL()
    {
        return new DataAccessLayer();
    }

}