using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SchaakModules
{
    public enum EmailErrorLevel
    {
        Ok=0,
        EmailFormatError=1,
        EncoderFallbackError=2,
        SmtpFailedRecipientsError=3,
        UnknownExceptionError=4
    }

    public class EmailSender : IEmailSender
    {
        private ILogger _Ilogger;
        private Exception _LastException;

        public EmailErrorLevel EmailErrorLevel { get; set; } 
        
        public EmailSender(ILogger ilogger)
        {
            _Ilogger = ilogger;
            EmailErrorLevel = EmailErrorLevel.Ok;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("jeroenleertouwer@gmail.com", "Go#22Jovibo")
                };

                var mess = new MailMessage(new MailAddress("DoNot@Reply.com"), new MailAddress(email))
                {
                    Subject = subject,
                    Body = message,
                    BodyEncoding = UTF8Encoding.UTF8,
                    DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                };
                smtp.Send(mess);
            }
            
            catch (EncoderFallbackException ex)
            {
                _LastException = ex;
                EmailErrorLevel = EmailErrorLevel.EncoderFallbackError;
                _Ilogger.LogTrace(ex.Message);
            }
            catch (FormatException ex)
            {
                _LastException = ex;
                EmailErrorLevel = EmailErrorLevel.EmailFormatError;
                _Ilogger.LogTrace(ex.Message);
            }
            catch (SmtpFailedRecipientsException ex)
            {
                _LastException = ex;
                EmailErrorLevel = EmailErrorLevel.SmtpFailedRecipientsError;
                _Ilogger.LogTrace(ex.Message);
            }
            catch (Exception ex)
            {
                _LastException = ex;
                EmailErrorLevel = EmailErrorLevel.UnknownExceptionError;
                _Ilogger.LogTrace(ex.Message);
            }
            return Task.CompletedTask ;
        }

        public string ErrorMessage()
        {
            if (_LastException != null)
            {
                return _LastException.Message;
            }
            else return string.Empty;
        }
    }
}
