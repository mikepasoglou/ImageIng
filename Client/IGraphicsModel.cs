﻿using SkiaSharp;

namespace ImageIng.Client
{
    public interface IGraphicsModel : IDisposable
    {
        public int Width { get; }
        public int Height { get; }
        public SKBitmap Bitmap { get; }
        public void Advance(float delta);
        public void Draw();
    }
}
