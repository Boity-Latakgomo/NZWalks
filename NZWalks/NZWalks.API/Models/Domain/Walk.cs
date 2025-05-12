namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }

        //RegionId is a foreign key that stores the Id of the related Region. It's just a Guid used by EF Core and the database to link the walk to a region.
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        //This is a navigation property.It allows you to access the full Region object related to the Walk in your C# code (e.g., walk.Region.Name).
        public Region Region { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
