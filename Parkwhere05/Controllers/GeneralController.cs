
using Parkwhere05.DAL;
using System.Net;
using System.Web.Mvc;


namespace Parkwhere05.Controllers
{
    public class GeneralController<T> : Controller where T : class
    {
        
        internal IDataGateway<T> dataGateway;
        internal GeneralController()
        {
           
        }
        public ActionResult currentlat(float coordinates)
        {
            ViewData.Model = coordinates;
            return View();
        }


        // GET: General
        virtual public ActionResult Index(int? id)
        {
            return View(dataGateway.SelectAll());
        }
      
       virtual public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T obj = dataGateway.SelectById(id);
            if (obj == null)
            {
                return HttpNotFound();
            }
            
            return View(obj);
        }

    }
}