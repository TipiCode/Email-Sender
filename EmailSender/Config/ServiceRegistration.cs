using Microsoft.Extensions.DependencyInjection;
using Tipi.Tools.Email.Interfaces;

namespace Tipi.Tools.Email.Config
{
    /// <summary>
    /// Static class to provide access to service registrations,
    /// <see href="https://docs.codingtipi.com/docs/toolkit/email-sender">See More</see>
    /// </summary>
    public static class ServiceRegistration
    {
        /// <summary>
        /// This method configures the <c>EmailSender</c> class for Dependency Injection inside .Net Core, 
        /// <see href="https://docs.codingtipi.com/docs/toolkit/email-sender">See More</see>.
        /// </summary>
        /// <remarks>
        /// Configure Dependency Ijection.
        /// </remarks>
        /// <param name="services">App Service collection.</param>
        /// <param name="port">Your Port provided by your hosting.</param>
        /// <param name="server">Your SMTP Server..</param>
        /// <param name="ssl">if use SSL.</param>
        /// <param name="user">SMTP user name.</param>
        /// <param name="password">SMTP password.</param>
        /// <param name="password">SMTP password.</param>
        /// <param name="emailName">Name to display in email "From" field.</param>
        public static void ConfigureEmailSender(this IServiceCollection services, int port, string server, bool ssl, string user, string password, string emailName)
        {
            var authManager = new SenderOptions(port, server, ssl, user, password, emailName);
            services.AddSingleton(authManager);
            services.AddTransient<IEmailSender, EmailSender>();
        }
    }
}
