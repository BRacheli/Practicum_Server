using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.Common.DTOs;
using MyProject.Services.Interfaces;

namespace MyProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService= userService;
        }

        //Get
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _userService.GetAllAsync();
        }

        //Get
        [HttpGet("{tz}")]
        public async Task<ActionResult<UserDTO>> Get(string tz)
        {
            var user=await _userService.GetByTzAsync(tz);
            if (user is null)
            {
                return NotFound();
            }
            return user;
        }

        //POST
        [HttpPost]
        public async Task <ActionResult<UserDTO>> Post([FromBody] UserModel userModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _userService.AddAsync(new UserDTO { FirstName = userModel.FirstName, LastName = userModel.LastName, Tz = userModel.Tz, BirthDate = userModel.BirthDate, Gender = userModel.Gender, HMO = userModel.HMO, Parent_1_tz = userModel.Parent_1_tz });
        }

        //PUT
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDTO>>Put(int id, [FromBody]UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _userService.UpdateAsync(new UserDTO { Id=id, FirstName=userModel.FirstName,LastName=userModel.LastName,Tz=userModel.Tz,BirthDate=userModel.BirthDate,Gender=userModel.Gender,HMO=userModel.HMO,Parent_1_tz=userModel.Parent_1_tz });
        }

        //DELETE
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }
    }
}
