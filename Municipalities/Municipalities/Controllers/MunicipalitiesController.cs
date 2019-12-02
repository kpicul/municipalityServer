using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Municipalities.Controllers
{
    public class MunicipalitiesController : ApiController
    {
        public MunicipalitiyList Get()
        {
            Queries db = new Queries();
            MunicipalitiyList mlist = new MunicipalitiyList();
            mlist.municipalities = db.selectMunicipalities();
            return mlist;
        }

        public string Get(int id)
        {
            return id + "";
        }
    }
}
