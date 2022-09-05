//Bir fonksiyon; mutlaka bir interface'a bağlı olmamalı. Fakat eğer bir interface'i implemente ettiği için geliyorsa mutlaka kullanılmalı.

public interface IMessage
{
    string From { get; set; }
    string To { get; set; }
    string Subject { get; set; }
    string Body { get; set; }



}

public interface IVideoMessage : IMessage
{
    int VideoDuration { get; set; }
    string VideoFormat { get; set; }
}

public interface IImageMessage: IMessage
{
    int ImageBytes { get; set; }
    string ImageType { get; set; }
}


public class TextMessage : IMessage
{
    public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

public class VideoMessage : IVideoMessage
{
    public int VideoDuration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string VideoFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
