namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        //Navigation property :A Region can have many Walks
        // IEnumerable<Walk> type is used to represent a collection of related Walk entities in a one-to-many relationship.
        public IEnumerable<Walk> Walks { get; set; }


    }
}
