﻿using System;
using System.Collections.Generic;
using System.Linq;
using WingtipToys.Models;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Logic;

namespace WingtipToys
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using(ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                string cartStr = String.Format("Cart ({0})", usersShoppingCart.GetCount());
                cartCount.InnerText = cartStr;
            }
        }
        public IQueryable<Category> GetCategories()
        {
            var _db = new WingtipToys.Models.ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query; 
        }
    }
}