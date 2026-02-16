namespace MVC_Music.ViewModels
{
    /// <summary>
    /// Interface for my own email service
    /// </summary>
    public interface IPersonalEmailSender
    {
        Task SendOneAsync(string name, string email, string subject, string htmlMessage);
        Task SendToManyAsync(EmailMessage emailMessage);
    }
}
