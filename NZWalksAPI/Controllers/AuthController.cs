using Microsoft.AspNetCore.Mvc;
using NZWalksAPI.Repositories;

namespace NZWalksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly ITokenHandler tokenHandler;

        public AuthController(IUserRepository userRepository , ITokenHandler tokenHandler)
        {
            this.userRepository = userRepository;
            this.tokenHandler = tokenHandler;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync(Models.DTO.LoginRequest loginRequest)
        {
            //Validate the incoming request


            //check user is authenticated
            //check username and password

           var user = await userRepository.AuthenticateAsync(loginRequest.UserName,
               loginRequest.Password);

            if (user!= null)
            {
                //generate a jwt token
            var token =  await tokenHandler.CreateTokenAsync(user);
                return Ok(token);
            }
            return BadRequest("Username and password is incorrect");


        }
    }
}
