
namespace Tipi.Tools.Email.Interfaces
{
    /// <summary>
    /// Interface <c>IEmailSender</c> serves as an interace to implement the Class <c>EmailSender</c>,
    /// <see href="https://docs.codingtipi.com/docs/toolkit/email-sender">See More</see>
    /// </summary>
    /// <remarks>
    /// Exposes methods to interact with the email sender.
    /// </remarks>
    public interface IEmailSender
    {
        /// <summary>
        /// This method send a new email, 
        /// <see href="https://docs.codingtipi.com/docs/toolkit/email-sender/methods#send-email-async">See More</see>.
        /// </summary>
        /// <remarks>
        /// Creates a new SmtpClient and send email to address provided.
        /// </remarks>
        /// <param name="to_email">Email address to whom you want to send the email to.</param>
        /// <param name="subject">Email subject.</param>
        /// <param name="body">Email HTML content</param>
        /// <returns>
        /// Returns true if email sended correctly.
        /// </returns>
        public bool SendEmailAsync(string to_email, string subject, string body);
    }
}
