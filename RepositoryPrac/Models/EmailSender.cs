using Microsoft.AspNetCore.Identity.UI.Services;

namespace RepositoryPrac.Models
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }

        public Task GenerateEmailConfirmationTokenAsync(dynamic user)
        { return Task.CompletedTask; }
    }
}
