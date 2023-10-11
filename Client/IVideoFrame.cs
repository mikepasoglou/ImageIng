namespace ImageIng.Client
{
    public interface IVideoFrame
    {
        int Width { get; }

        int Height { get; }

        string Format { get; }

        void Serialize(Stream pipe);

        Task SerializeAsync(Stream pipe, CancellationToken token);
    }
}
