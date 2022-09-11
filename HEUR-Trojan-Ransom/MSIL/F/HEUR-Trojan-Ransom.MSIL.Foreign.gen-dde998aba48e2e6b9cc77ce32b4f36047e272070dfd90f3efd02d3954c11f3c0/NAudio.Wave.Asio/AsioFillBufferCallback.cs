using System;

namespace NAudio.Wave.Asio;

public delegate void AsioFillBufferCallback(IntPtr[] inputChannels, IntPtr[] outputChannels);
