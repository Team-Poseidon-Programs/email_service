using System.Net;
using System.Net.Mail;

namespace Email_Service.Controllers
{
    public class Email_Sender
    {
        public void Email_Method(string email, int status)
        {
            string subject = "";
            string body = "";


            switch(status)
            {
                case 0:
                    subject = "Your appointment status of Poseidon healthcare";
                    body = "Your appointment for visit poseidon health care is booked successfully.\nPlease wait for doctor to accept your appointment";
                    break;
                case 1:
                    subject = "Your appointment status of Poseidon healthcare";
                    body = "Your Appointment for visit poseidon health care is accepted.\nKindly check your status on Poseidon Healthcare website";
                    break;
                case 4:
                    subject = "Your appointment status of Poseidon healthcare";
                    body = "Sorry to inform you.Your Appointment for visit poseidon health care is Rejected.\nPlease book other appointment";
                    break;                    
            }
            MailMessage message = new MailMessage();

            message = new MailMessage("healthcareposeidon@gmail.com", email);

            message.Subject = subject;
            message.Body = body;

            SmtpClient client = new SmtpClient();

            client.Host = "smtp.gmail.com";

            client.Port = 587;

            client.Credentials = new NetworkCredential("healthcareposeidon@gmail.com", "xqllhshwscxxwqjp");

            client.UseDefaultCredentials = false;

            client.EnableSsl = true;

            try
            {
                client.Send(message);
                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }

            message.Dispose();
            client.Dispose();

        }
    }
}