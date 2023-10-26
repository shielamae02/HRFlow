﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers
{
    [Authorize(Roles = "/api/department")]
    [ApiController]
    [Route("/api/department")]
    public class DepartmentController : ControllerBase
    {
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(ILogger<DepartmentController> logger)
        {
            _logger = logger ??
                throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public Task<IActionResult> GetDepartments()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{departmentId}")]
        public Task<IActionResult> GetDepartment([FromRoute] Guid departmentId)
        {
            throw new NotImplementedException();
        }
    }
}
