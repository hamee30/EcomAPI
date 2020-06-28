using Ecommerce.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ecommerce.Controllers
{
    public class CategoryController : ApiController
    {

     //   ecommEntities context = new ecommEntities();

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/Category/GetCategoryList")]
        public JObject GetCategoryList()
        {
            //JObject details;
            //JArray usr = new JArray();
            //var emailList = context.Categories.AsNoTracking();
            //int i = 1;
            //foreach (Category bk in emailList)
            //{
            //    details = new JObject(
            //       new JProperty("s_no", i++),
            //       new JProperty("Id", bk.Id),
            //       new JProperty("Name", bk.category_name)
            //      );

            //    usr.Add(details);

            //}

            JObject final = new JObject(
              new JProperty("CategoryList", ""));
            return final;



        }

        }
}
