using System;
using K4os.Compression.LZ4.Engine;
using K4os.Compression.LZ4.Internal;

namespace K4os.Compression.LZ4.Encoders;

public class LZ4ChainDecoder : UnmanagedResources, IDisposable, ILZ4Decoder
{
	private unsafe readonly LZ4_xx.LZ4_streamDecode_t* _context;

	private readonly int _blockSize;

	private unsafe readonly byte* _outputBuffer;

	private readonly int _outputLength;

	private int _outputIndex;

	public int BlockSize => _blockSize;

	public int BytesReady => _outputIndex;

	public unsafe LZ4ChainDecoder(int blockSize, int extraBlocks)
	{
		blockSize = Mem.RoundUp(Math.Max(blockSize, 1024), 1024);
		extraBlocks = Math.Max(extraBlocks, 0);
		_blockSize = blockSize;
		_outputLength = 65536 + (1 + extraBlocks) * _blockSize + 8;
		_outputIndex = 0;
		_outputBuffer = (byte*)Mem.Alloc(_outputLength + 8);
		_context = (LZ4_xx.LZ4_streamDecode_t*)Mem.AllocZero(sizeof(LZ4_xx.LZ4_streamDecode_t));
	}

	public unsafe int Decode(byte* source, int length, int blockSize)
	{
		if (blockSize <= 0)
		{
			blockSize = _blockSize;
		}
		Prepare(blockSize);
		int num = DecodeBlock(source, length, _outputBuffer + _outputIndex, blockSize);
		if (num < 0)
		{
			throw new InvalidOperationException();
		}
		_outputIndex += num;
		return num;
	}

	public unsafe int Inject(byte* source, int length)
	{
		if (length <= 0)
		{
			return 0;
		}
		if (length > Math.Max(_blockSize, 65536))
		{
			throw new InvalidOperationException();
		}
		if (_outputIndex + length < _outputLength)
		{
			Mem.Move(_outputBuffer + _outputIndex, source, length);
			_outputIndex = ApplyDict(_outputIndex + length);
		}
		else if (length >= 65536)
		{
			Mem.Move(_outputBuffer, source, length);
			_outputIndex = ApplyDict(length);
		}
		else
		{
			int num = Math.Min(65536 - length, _outputIndex);
			Mem.Move(_outputBuffer, _outputBuffer + _outputIndex - num, num);
			Mem.Move(_outputBuffer + num, source, length);
			_outputIndex = ApplyDict(num + length);
		}
		return length;
	}

	public unsafe void Drain(byte* target, int offset, int length)
	{
		offset = _outputIndex + offset;
		if (offset < 0 || length < 0 || offset + length > _outputIndex)
		{
			throw new InvalidOperationException();
		}
		Mem.Move(target, _outputBuffer + offset, length);
	}

	private void Prepare(int blockSize)
	{
		if (_outputIndex + blockSize > _outputLength)
		{
			_outputIndex = CopyDict(_outputIndex);
		}
	}

	private unsafe int CopyDict(int index)
	{
		int num = Math.Max(index - 65536, 0);
		int num2 = index - num;
		Mem.Move(_outputBuffer, _outputBuffer + num, num2);
		LZ4_xx.LZ4_setStreamDecode(_context, _outputBuffer, num2);
		return num2;
	}

	private unsafe int ApplyDict(int index)
	{
		int num = Math.Max(index - 65536, 0);
		int dictSize = index - num;
		LZ4_xx.LZ4_setStreamDecode(_context, _outputBuffer + num, dictSize);
		return index;
	}

	private unsafe int DecodeBlock(byte* source, int sourceLength, byte* target, int targetLength)
	{
		return LZ4_xx.LZ4_decompress_safe_continue(_context, source, target, sourceLength, targetLength);
	}

	protected unsafe override void ReleaseUnmanaged()
	{
		base.ReleaseUnmanaged();
		Mem.Free(_context);
		Mem.Free(_outputBuffer);
	}
}
