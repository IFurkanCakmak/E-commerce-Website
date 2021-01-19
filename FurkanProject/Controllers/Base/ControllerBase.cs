using FurkanProject.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FurkanProject
{
    public class FurkanControllerBase : Controller
    {
        /// <summary>
        /// Kullanıcı Login Kontrolü
        /// </summary>
        public bool IsLogin { get; private set; }

        /// <summary>
        /// Grişi yapmış kişinin IDsi
        /// </summary>
        public int LoginUserID { get; private set; }
        
        /// <summary>
        /// Login user entity
        /// </summary>
        public User LoginUserEntity { get; private set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if(requestContext.HttpContext.Session["LoginUserID"] != null)
            {
                //kullanıcı giriş yapmış
                IsLogin = true;
                LoginUserID = (int)requestContext.HttpContext.Session["LoginUserID"];
                LoginUserEntity = (Core.Model.Entity.User)requestContext.HttpContext.Session["LoginUser"];
            }

            base.Initialize(requestContext);
        }
    }
}