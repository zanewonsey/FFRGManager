using System.Collections.Generic;
using FFRGManagerService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CosmoSearchService.Controllers
{
    //[EnableCors("*")]
    [Route("api/[controller]")]
    [ApiController]
    public class StylistProfileController : ControllerBase
    {
        [HttpGet("/api/[controller]/singleProfile/")]
        public IActionResult Meme(string GUID)
        {
            //List<StylistProfile> l_sp = DBStuff();
            //JWscCK43/EO0daxAJTd0Ow==     
            //string queryString = "SELECT *  FROM  [dbo].[Basic_User_Info]";
            StylistProfile l_sp = new StylistProfile(GUID, "fuck me sideways","yui","",0,0,"");
            return Ok(l_sp);
        }

        [HttpGet("/api/[controller]/meme")]
        public IActionResult Meme()
        {
            List<StylistProfile> l_sp = FFRGManagerService.Database.DBAccess.DBStuff("select * from dbo.Basic_User_Info");
            return Ok(l_sp);
        }


    }
}