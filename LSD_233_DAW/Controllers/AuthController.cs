using LSD_233_DAW_BLL.Interfaces;
using LSD_233_DAW_BLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSD_233_DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthManager _authManager;

        public AuthController(IAuthManager authManager)
        {
            _authManager = authManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterModel model) => Ok(await _authManager.Register(model));

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel model) => Ok(await _authManager.Login(model));

        [HttpPost("Refresh")]
        public async Task<IActionResult> Refresh([FromBody] RefreshModel refreshModel) => Ok(await _authManager.Refresh(refreshModel));
    }
}
