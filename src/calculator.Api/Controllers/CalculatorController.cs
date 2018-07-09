using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using calculator.Service;

namespace calculator.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CalculatorController : Controller
    {
        [HttpGet("{score}")]
        public object Grade(int score)
        {
            var gradeCalculator = new GradeCalculator();
            var grade = gradeCalculator.CalculateGrade(score);
            return new { score = score, grade = grade };
        }
    }
}
