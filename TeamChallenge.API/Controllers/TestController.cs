﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamChallenge.Core;
using TeamChallenge.Core.Models;

namespace TeamChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext context;

        public TestController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var listData = context.TestDatas.ToList();
            return Ok(listData);
        }

        [HttpPost]
        public IActionResult Post([FromBody] TestData testData)
        {
            context.TestDatas.Add(testData);
            context.SaveChanges();
            return Created("", testData);
        }
    }
}
