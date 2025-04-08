// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;


//solid principle
//IEmail

public class UserService 
{ 
   public void RegisterUser(string email, string password) 
   { 
      if (!ValidateEmail(email)) 
         throw new ValidationException("Email is not valid"); 
         var user = new User(email, password); 
  
         SendEmail(new MailMessage("mysite@email.com", email) { Subject="This is subject" }); 
   } 
   public virtual bool ValidateEmail(string email) 
   { 
     return email.Contains("@"); 
   } 
   public bool SendEmail(MailMessage message) 
   { 
     _smtpClient.Send(message); 
   } 
} 


//refactor
public interface IEmailSender
{
    void SendEmail(MailMessage message);
}

//settig / pngaturan krim email
public class SmtpEmailSender : IEmailSender
{
    private readonly Smtpclient _smtpClient;
    
    public SmtpEmailSender(Smtpclient _smtpClient)
    {
        _smtpClient = smtpClient;
    }
    
    public void SendEmail(MailMessage message);
    {
       _smtpClient.Send(message);  
    }
}

//validasi interfaceing
public interface IEmailValidasi
{
  bool ValidateEmail(string email);  
}

//fungsi validasi email
public class EmailValidasi : IEmailValidasi
{
    public bool ValidateEmail(string email);
    {
        return email.Contains("@"); 
    }
}

//class UserService
public class UserService
{
    private readonly IEmailValidasi _emailvalidasi;
    private readonly IEmailSender _emailsender;
    
    public UserService (IEmailValidasi _emailvalidasi)
    
}

public void RegisterUser(string email, string password) 
   { 
      if (!ValidateEmail(email)) 
         throw new ValidationException("Email is not valid"); 
         var user = new User(email, password); 
  
         SendEmail(new MailMessage("mysite@email.com", email) { Subject="This is subject" }); 
   } 