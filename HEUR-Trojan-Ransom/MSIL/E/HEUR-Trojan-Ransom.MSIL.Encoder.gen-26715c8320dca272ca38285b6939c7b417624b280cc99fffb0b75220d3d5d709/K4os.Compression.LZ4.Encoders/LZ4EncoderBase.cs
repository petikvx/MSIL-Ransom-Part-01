using System;
using K4os.Compression.LZ4.Internal;

namespace K4os.Compression.LZ4.Encoders;

public abstract class LZ4EncoderBase : UnmanagedResources, IDisposable, ILZ4Encoder
{
	private unsafe readonly byte* _inputBuffer;

	private readonly int _inputLength;

	private readonly int _blockSize;

	private int _inputIndex;

	private int _inputPointer;

	public int BlockSize => _blockSize;

	public int BytesReady => _inputPointer - _inputIndex;

	protected unsafe LZ4EncoderBase(bool chaining, int blockSize, int extraBlocks)
	{
		blockSize = Mem.RoundUp(Math.Max(blockSize, 1024), 1024);
		extraBlocks = Math.Max(extraBlocks, 0);
		int num = (chaining ? 65536 : 0);
		_blockSize = blockSize;
		_inputLength = num + (1 + extraBlocks) * blockSize + 8;
		_inputPointer = 0;
		_inputIndex = 0;
		_inputBuffer = (byte*)Mem.Alloc(_inputLength + 8);
	}

	public unsafe int Topup(byte* source, int length)
	{
		ThrowIfDisposed();
		if (length == 0)
		{
			return 0;
		}
		int num = _inputIndex + _blockSize - _inputPointer;
		if (num <= 0)
		{
			return 0;
		}
		int num2 = Math.Min(num, length);
		Mem.Move(_inputBuffer + _inputPointer, source, num2);
		_inputPointer += num2;
		return num2;
	}

	public unsafe int Encode(byte* target, int length, bool allowCopy)
	{
		ThrowIfDisposed();
		int num = _inputPointer - _inputIndex;
		if (num <= 0)
		{
			return 0;
		}
		int num2 = EncodeBlock(_inputBuffer + _inputIndex, num, target, length);
		if (num2 <= 0)
		{
			throw new InvalidOperationException("Failed to encode chunk. Target buffer too small.");
		}
		if (allowCopy && num2 >= num)
		{
			Mem.Move(target, _inputBuffer + _inputIndex, num);
			num2 = -num;
		}
		Commit();
		return num2;
	}

	private unsafe void Commit()
	{
		_inputIndex = _inputPointer;
		if (_inputIndex + _blockSize > _inputLength)
		{
			_inputIndex = (_inputPointer = CopyDict(_inputBuffer, _inputPointer));
		}
	}

	protected unsafe abstract int EncodeBlock(byte* source, int sourceLength, byte* target, int targetLength);

	protected unsafe abstract int CopyDict(byte* target, int dictionaryLength);

	protected unsafe override void ReleaseUnmanaged()
	{
		base.ReleaseUnmanaged();
		Mem.Free(_inputBuffer);
	}
}
