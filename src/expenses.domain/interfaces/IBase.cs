namespace expenses.domain.interfaces
{
    public interface IBase
    {
        int Id { get; set; }
        DateTime UpdateDate { get; set; }
        bool Removed { get; set; }
    }
}