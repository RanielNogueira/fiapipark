using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IPark.Domain;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace IPark.UI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UserLogin([FromBody]Usuario usuario)
        {

            try
            {
                if (Validacao(usuario.Email,usuario.Senha))
                {

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, "Usuário logado"),
                        new Claim(ClaimTypes.PrimarySid, "1"),
                        new Claim(ClaimTypes.Email, usuario.Email),
                    };

                    var claimsIdentity = new ClaimsIdentity(
                                      claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        new AuthenticationProperties
                        {
                            IsPersistent = true,
                            ExpiresUtc = DateTime.Now.AddMinutes(30)
                        });

                    return Ok();
                }
                else
                {
                    return BadRequest(new { message = "Usuário ou Senha não conferem!" });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e });
            }

        }

        [HttpGet("sair")]
        public async Task<IActionResult> Sair()
        {
            try
            {
                await HttpContext.SignOutAsync(
    CookieAuthenticationDefaults.AuthenticationScheme);
                return RedirectToAction("Index", "Login");
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }

        }

        private bool Validacao(string email, string senha)
        {
            if(!String.IsNullOrWhiteSpace(email) && !String.IsNullOrWhiteSpace(senha))
            {
                if (email == "admin@ipark.com.br" && senha == "fiap123")
                    return true;
                else
                    return false;
            }

            return false;
        }
    }
}