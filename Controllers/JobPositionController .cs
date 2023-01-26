using asp_master_job.DTO;
using asp_master_job.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp_master_job.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobPositionController : ControllerBase
    {
        private readonly MasterJobContext MasterJobContext;

        public JobPositionController(MasterJobContext MasterJobContext)
        {
            this.MasterJobContext = MasterJobContext;
        }

        [HttpGet("/job-position")]
        public async Task<ActionResult<List<JobPositionDTO>>> Get()
        {
            var List = await MasterJobContext.Jobpositions.Select(
                title => new JobPositionDTO
                {
                    Id = title.Id,
                    Name = title.Name,
                    Code = title.Code,
                    TitleId = title.TitleId,
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
