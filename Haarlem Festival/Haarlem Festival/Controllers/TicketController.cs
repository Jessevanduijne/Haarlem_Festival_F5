﻿using Haarlem_Festival.Models.Domain_Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Haarlem_Festival.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
        public ActionResult Index()
        {
            List<Ticket> tickets = (List<Ticket>)Session["CurrentTickets"];
            

            return View(tickets);
        }
    }
}