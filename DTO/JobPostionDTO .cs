namespace asp_master_job.DTO
{
    public class JobPositionDTO
    {
        public int Id { get; set; }

        public string? Code { get; set; }

        public string? Name { get; set; }

        public int TitleId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
