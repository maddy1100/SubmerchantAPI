using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PAM;
using SubmerchantAPI.Filters;
using SubmerchantAPI.Middlewares;

namespace SubmerchantAPI.Controllers
{
    [Route("api/Authentication")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class LoginController : ControllerBase
    {
        private IdentityService _identityService;
        private ITokenManager _tokenManager;

        public LoginController(IdentityService identityService, ITokenManager tokenManager)
        {
            _identityService = identityService;
            _tokenManager = tokenManager;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> AuthenticateAsync(User request)
        {
            //before generating the token checking the user is valid user or not by calling ValidateUserAsync
            //if the user is valid calling the GenerateTokenAsync method to get the token from PAM service
            var jwtTokens = await _identityService.LoginUserAsync(request);
            if (jwtTokens == null)
                return StatusCode(403,"Credentials entered are not valid");
            else if (jwtTokens.AccessToken == string.Empty && jwtTokens.RefreshToken == string.Empty && jwtTokens.IdToken == string.Empty)
                return StatusCode(403, "Credentials entered are not valid");
            else
                return Ok(jwtTokens);
        }

        [HttpPost("extendsession")]
        public async Task<IActionResult> ExtendSessionAync(string refreshToken)
        {
            var jwtTokens = await _identityService.ExtendSessionAsync(refreshToken);
            return Ok(jwtTokens);
        }

        [HttpPost("logout")]
        public async Task<IActionResult> CancelAccessToken()
        {
            await _tokenManager.DeactivateCurrentAsync();
            return NoContent();
        }

    }
}