// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Report report = new Report(new MMSSender());
Report rp2 = new Report(new MailSender());
Report rp3 = new Report(new MMSSender());


public class Report
{
   ISender sender;

    public Report(ISender sender)
    {
        this.sender = sender;
    }

    public void Send(string to)
    {
       
        sender.Send(to);
    }
}
public interface ISender
{
    void Send(string to);
}
public class MailSender: ISender
{
    public void Send(string to)
    {
        Console.WriteLine($"{to} adresine rapor gönderildi");
    }
}

public class WhatsappSender : ISender
{
    public void Send(string to)
    {
        Console.WriteLine($"{to} adresine rapor Whatsapp ile gönderildi");
    }
}

public class MMSSender : ISender
{
    public void Send(string to)
    {
        Console.WriteLine($"{to} adresine rapor MMS ile gönderildi");
    }
}