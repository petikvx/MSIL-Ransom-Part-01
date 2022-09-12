using System;

namespace K4os.Compression.LZ4.Encoders;

public interface ILZ4Decoder : IDisposable
{
	int BlockSize { get; }

	int BytesReady { get; }

	unsafe int Decode(byte* source, int length, int blockSize = 0);

	unsafe int Inject(byte* source, int length);

	unsafe void Drain(byte* target, int offset, int length);
}
