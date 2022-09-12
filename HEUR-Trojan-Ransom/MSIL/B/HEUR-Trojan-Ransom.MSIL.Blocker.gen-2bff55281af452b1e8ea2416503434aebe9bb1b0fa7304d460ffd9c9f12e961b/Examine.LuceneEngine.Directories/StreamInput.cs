using System;
using System.IO;
using System.Security;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Directories;

[SecuritySafeCritical]
public class StreamInput : Stream
{
	public IndexInput Input
	{
		[SecuritySafeCritical]
		get;
		[SecuritySafeCritical]
		set;
	}

	public override bool CanRead => true;

	public override bool CanSeek => true;

	public override bool CanWrite => false;

	public override long Length
	{
		[SecuritySafeCritical]
		get
		{
			return Input.Length();
		}
	}

	public override long Position
	{
		[SecuritySafeCritical]
		get
		{
			return Input.GetFilePointer();
		}
		[SecuritySafeCritical]
		set
		{
			Input.Seek(value);
		}
	}

	[SecuritySafeCritical]
	public StreamInput(IndexInput input)
	{
		Input = input;
	}

	public override void Flush()
	{
	}

	[SecuritySafeCritical]
	public override int Read(byte[] buffer, int offset, int count)
	{
		long filePointer = Input.GetFilePointer();
		long num = Input.Length();
		if (count > num - filePointer)
		{
			count = (int)(num - filePointer);
		}
		Input.ReadBytes(buffer, offset, count);
		return (int)(Input.GetFilePointer() - filePointer);
	}

	[SecuritySafeCritical]
	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			Input.Seek(offset);
			break;
		case SeekOrigin.Current:
			Input.Seek(Input.GetFilePointer() + offset);
			break;
		case SeekOrigin.End:
			throw new NotImplementedException();
		}
		return Input.GetFilePointer();
	}

	public override void SetLength(long value)
	{
		throw new NotImplementedException();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}

	[SecuritySafeCritical]
	public override void Close()
	{
		Input.Close();
		base.Close();
	}
}
