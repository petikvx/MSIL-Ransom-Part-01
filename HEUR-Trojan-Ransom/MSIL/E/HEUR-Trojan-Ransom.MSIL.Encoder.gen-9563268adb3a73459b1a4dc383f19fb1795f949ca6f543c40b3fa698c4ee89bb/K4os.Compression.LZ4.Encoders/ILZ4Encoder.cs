using System;

namespace K4os.Compression.LZ4.Encoders;

public interface ILZ4Encoder : IDisposable
{
	int BlockSize { get; }

	int BytesReady { get; }

	unsafe int Topup(byte* source, int length);

	unsafe int Encode(byte* target, int length, bool allowCopy);
}
