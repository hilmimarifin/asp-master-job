using asp_master_job.DTO;
using asp_master_job.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp_master_job.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobTitleController : ControllerBase
    {
        private readonly MasterJobContext MasterJobContext;

        public JobTitleController(MasterJobContext MasterJobContext)
        {
            this.MasterJobContext = MasterJobContext;
        }

        [HttpGet("/job-title")]
        public async Task<ActionResult<List<JobTitleDTO>>> Get()
        {
            var List = await MasterJobContext.Jobtitles.Select(
                title => new JobTitleDTO
                {
                    Id = title.Id,
                    Name = title.Name,
                    Code= title.Code,
                }
            ).ToListAsync();

            if (List.Count < 0)
            {
                return NotFound();
            }
            else
            {
                return List;
            }
        }

    }
}
