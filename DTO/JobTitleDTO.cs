namespace asp_master_job.DTO
{
    public class JobTitleDTO
    {
        public int Id { get; set; }

        public string Code { get; set; } = null!;

        public string? Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
