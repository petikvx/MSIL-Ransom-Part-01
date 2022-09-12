using System;

namespace VanillaStub.Helpers.Services.StreamLibrary.src;

public class PointerHelper
{
	private int _offset;

	public IntPtr Pointer { get; }

	public int TotalLength { get; }

	public int Offset
	{
		get
		{
			return _offset;
		}
		set
		{
			if (value < 0)
			{
				throw new Exception("Offset must be >= 1");
			}
			if (value >= TotalLength)
			{
				throw new Exception("Offset cannot go outside of the reserved buffer space");
			}
			_offset = value;
		}
	}

	public PointerHelper(IntPtr pointer, int Length)
	{
		TotalLength = Length;
		Pointer = pointer;
	}

	public void Copy(IntPtr Source, int SourceOffset, int SourceLength)
	{
		if (CheckBoundries(Offset, SourceLength))
		{
			throw new AccessViolationException("Cannot write outside of the buffer space");
		}
		NativeMethods.memcpy(new IntPtr(Pointer.ToInt64() + Offset), new IntPtr(Source.ToInt64() + SourceOffset), (uint)SourceLength);
	}

	private bool CheckBoundries(int offset, int length)
	{
		return offset + length > TotalLength;
	}
}
