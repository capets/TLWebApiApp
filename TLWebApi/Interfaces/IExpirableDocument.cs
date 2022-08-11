namespace TLWebApi.Interfaces
{
    public interface IExpirableDocument : IDocument
    {
        DateTime ExpiryDate { get; set; }
    }
}
