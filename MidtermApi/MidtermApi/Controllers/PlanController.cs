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
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IPlan _plan;
        
        public PlanController (IPlan plan)
        {
            _plan = plan;
        }
        
        //+ ProcessSurvey(int surveyAnswers) : int recommendationCode

        [HttpGet("{id}")]
        public async Task<ActionResult<Plan>> GetPlanAsync(int id)
        {
            Plan plan = await _plan.GetPlan(id);

            if (plan == null)
            {
                return NotFound();
            }
            return Ok(plan);
        }
    }
}