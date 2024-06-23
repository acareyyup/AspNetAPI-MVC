namespace NLayer.Core.DTOs
{
    public abstract record BaseDto
    {
        public int Id { get; init; }
        public DateTime CreatedDate { get; init; }
    }
}
