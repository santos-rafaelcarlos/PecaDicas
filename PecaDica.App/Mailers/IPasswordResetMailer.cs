using Mvc.Mailer;
using PecaDica.App.Mailers.Models;

namespace PecaDica.App.Mailers
{ 
    public interface IPasswordResetMailer
    {
			MvcMailMessage PasswordReset(MailerModel model);
	}
}