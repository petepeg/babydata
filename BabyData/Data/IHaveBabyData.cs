namespace BabyData.Data
{
    public interface IHaveBabyData
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid BabyId { get; set; }
    }
}
