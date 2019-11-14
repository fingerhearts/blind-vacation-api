using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MidtermApi.Models;
using MidtermApi.Models.Interfaces;

namespace MidtermApi.Controllers
{
    /// <summary>
    /// This controller is implementing the IPlan interface to be able to use the 'GetPlan' method in the
    /// 'GetPlanAsync' method. The 'GetPlanAsync' method is taking in 'answers' which is a code based off of the 
    /// response the user entered while taking the survey. We create a new instance of plan called 'plan' and 
    /// set the specific vacation package to that variable. If the specific vacation package doesnt exist then return not found. 
    /// Otherwise, if it does exist return a status code 200 with the 'plan' (vacation package).
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IPlan _plan;
        
        public PlanController (IPlan plan)
        {
            _plan = plan;
        }


        [HttpGet("{answers}")]
        public async Task<ActionResult<Plan>> GetPlanAsync(string answers)
        {
            Plan plan = await _plan.GetPlan(answers);

            if (plan == null)
            {
                return NotFound();
            }
            return Ok(plan);
        }
    }
}