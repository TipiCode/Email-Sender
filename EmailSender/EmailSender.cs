using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using Tipi.Tools.Email.Config;
using Tipi.Tools.Email.Interfaces;

namespace Tipi.Tools.Email
{
    /// <summary>
    /// Class <c>EmailSender</c> serves as an interace to interact with the SmtpClient email sender,
    /// <see href="https://docs.codingtipi.com/docs/toolkit/email-sender">See More</see>
    /// </summary>
    /// <remarks>
    /// Exposes methods to interact with the email sender class.
    /// </remarks>
    public class EmailSender : IEmailSender
    {
        #region Constructors
        private readonly SenderOptions _config;
        public EmailSender(SenderOptions options)
        {
            _config = options;
        }
        #endregion

        #region Public Methods
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
        public bool SendEmailAsync(string to_email, string subject, string body)
        {
            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress(_config.EmailName, _config.User));
            mailMessage.To.Add(MailboxAddress.Parse(to_email));
            mailMessage.Subject = subject;
            mailMessage.Body = new TextPart(TextFormat.Html)
            {
                Text = body
            };

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect(_config.Server, _config.Port, _config.Ssl);
                smtpClient.Authenticate(_config.User, _config.Password);
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }

            return true;
        }
        #endregion
    }
}
