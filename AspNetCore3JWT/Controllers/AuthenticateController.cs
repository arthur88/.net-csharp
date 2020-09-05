using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using AspNetCore3JWT.Data;
using AspNetCore3JWT.Models;
using System.IdentityModel.Tokens.Jwt;

namespace AspNetCore3JWT.Controllers
{
    [Route("api/[controller]")]
    public class AuthenticateController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager; //injecting userManager

        public AuthenticateController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await userManager.FindByNameAsync(model.Username); //getting the specific user.

            // below checking the user value and password. If the condition is true, then we will generate the token otherwise it will return Unauthorized response.
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var authClaims = new[] //claims
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
                // below creating signing key
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("YVBy0OLlMQG6VVVp1OH7Xzyr7gHuw1qvUC5dcGt3SBM"));

                //below - generate token
                var token = new JwtSecurityToken(
                    issuer: "http://localhost:44353",
                    audience: "http://localhost:44353",
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );
                //  returning the ok status with token and expiration time
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });

            }
            return Unauthorized();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
