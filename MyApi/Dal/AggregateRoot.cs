namespace MyApi.Dal
{
    public abstract class AggregateRoot
    {
        public DateTime CreateTime { get; set; }
        public Guid CreatorId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid? UpdatorId { get; set; }
        public bool IsDelete { get; set; }
        public DateTime?  DeleteTime{ get; set; }
        public Guid? DeleterId { get; set; }
    }
}
