using System;
using System.Collections.Generic;
using Domain.Models;
using Domain.Services.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Diary.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class FriendController : ControllerBase
    {

        private readonly IFriendService _friendService;

        public FriendController(IFriendService friendService)
        {
            _friendService = friendService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<FriendModel>> Get() {
            return Ok(_friendService.GetFriendsByDayOfBirth(DateTime.Today));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string name) {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post() {

            _friendService.AddFriend(new FriendModel
            {
                DateOfBirth = DateTime.Now,
                Name = "TestName"
            });
        }

        // PUT api/values/5
        [HttpPut()]
        public void Put() {
        }
    }
}
