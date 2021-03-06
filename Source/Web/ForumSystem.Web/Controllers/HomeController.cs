﻿using ForumSystem.Data;
using ForumSystem.Data.Common.Repository;
using ForumSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using ForumSystem.Web.ViewModels.Home;

namespace ForumSystem.Web.Controllers
{
	public class HomeController : Controller
	{
		private IRepository<Post> posts;

		public HomeController(IRepository<Post> posts)
		{
			this.posts = posts;
		}

		public ActionResult Index()
		{
			var posts = this.posts.All().Project().To<IndexBlogPostViewModel>();
			return View(posts);
		}

	}
}