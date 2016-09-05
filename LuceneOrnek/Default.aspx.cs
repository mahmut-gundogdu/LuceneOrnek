using LuceneSearchEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LuceneOrnek
{
    public partial class Default : System.Web.UI.Page
    {
        LuceneEngine engine = new LuceneEngine();
        protected void Page_Load(object sender, EventArgs e)
        {




            //
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {

            engine.DeleteAllDocuments();

            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "Apple Iphone 6", Description = "Lorem ipsum" });
            products.Add(new Product() { Id = 2, Name = "MacBook Air" });
            products.Add(new Product() { Id = 3, Name = "Sony Xperia Z Ultra", Description = "dolor amet" });
            products.Add(new Product() { Id = 4, Name = "Samsung Ultra HD Tv" });
            products.Add(new Product() { Id = 5, Name = "Asus Zenphone 6" });
            products.Add(new Product() { Id = 6, Name = "Sony Xperia Z 3" });
            products.Add(new Product() { Id = 7, Name = "Sony Playstation 3" });

            engine.AddToIndex(products);
        }

        protected void btnAra_Click(object sender, EventArgs e)
        {
            //var result = engine.Search("Name", txtAra.Text);
            var result = engine.SearchAllField(txtAra.Text);
            this.gvData.DataSource = result;
            this.DataBind();
        }
    }
}