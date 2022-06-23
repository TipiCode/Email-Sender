
namespace Tipi.Tools.Email.Config
{
    /// <summary>
    /// Class used to configure the <c>Email Sender</c> class, 
    /// <see href="https://docs.codingtipi.com/docs/toolkit/email-sender/classes#sender-options">See More</see>
    /// </summary>
    public class SenderOptions
    {
        /// <summary>
        /// Your Port provided by your hosting.
        /// </summary>
        public int Port { get; }
        /// <summary>
        /// Your SMTP Server.
        /// </summary>
        public string Server { get; }
        /// <summary>
        /// if use SSL
        /// </summary>
        public bool Ssl { get; }
        /// <summary>
        /// SMTP user name
        /// </summary>
        public string User { get; }
        /// <summary>
        /// SMTP password
        /// </summary>
        public string Password { get; }
        /// <summary>
        /// Name to display in email "From" field
        /// </summary>
        public string EmailName { get; }


        /// <summary>
        /// Constructor to initialize the <c>SenderOptions</c> object.
        /// </summary>
        /// <remarks>
        /// Takes as parameters, the Port provided by your hosting.
        /// </remarks>
        /// <param name="port">Your Port provided by your hosting.</param>
        /// <param name="server">Your SMTP Server..</param>
        /// <param name="ssl">if use SSL.</param>
        /// <param name="user">SMTP user name.</param>
        /// <param name="password">SMTP password.</param>
        /// <param name="emailName">Name to display in email "From" field.</param>
        public SenderOptions(int port, string server, bool ssl, string user, string password, string emailName)
        {
            Port = port;
            Server = server;
            Ssl = ssl;
            User = user;
            Password = password;
            EmailName = emailName;
        }
    }
}
