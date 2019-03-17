using System.Collections.Generic;
using Domain.Models;
using Domain.Services.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Diary.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class FriendController : ControllerBase {

        private readonly IFriendService _friendService;

        public FriendController(IFriendService friendService) {
            _friendService = friendService;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<FriendModel>> GetAll() {
            return Ok(_friendService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<FriendModel> Get(int id) {
            return Ok(new FriendModel());
        }

        [HttpPost]
        public void Post([FromBody] FriendModel friendModel) {
            _friendService.AddFriend(friendModel);
        }
    }
}
