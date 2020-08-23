using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_MVC.Models;

namespace Teacher_MVC.ViewComponents
{
    public class ArticlesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"رادیو","خلاصه ای از موارد مربوط به رادیو"),
                new Article(1,"موبایل","توضیحات موارد مربوط به موبایل"),
                new Article(1,"هواپیما","خلاصه ای از موارد مربوط به ساخت هواپیما")
            };

            return View("_Articles",articles);
        }
    }
}
