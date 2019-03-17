﻿using System;
using System.Collections.Generic;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Reporting.Abstractions;

namespace Diary.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class NotificatorController : ControllerBase {
        private readonly IDailyBirthdayNotificator _birthdayNotificator;

        public NotificatorController(IDailyBirthdayNotificator dailyBirthdayNotificator) {
            _birthdayNotificator = dailyBirthdayNotificator;
        }

        [HttpPost("RunBirthday")]
        public void RunBirthdayNotifications() {
            _birthdayNotificator.Run();
        }

        [HttpPost("StopBirthday")]
        public void StopBirthdayNotifications() {
            _birthdayNotificator.Stop();
        }

        [HttpGet]
        public ActionResult<string> Get() {
            return Ok("ok!");
        }

        [HttpGet("Status")]
        public ActionResult<string> GetStatus() {
            return Ok("ok status!");
        }
    }
}
