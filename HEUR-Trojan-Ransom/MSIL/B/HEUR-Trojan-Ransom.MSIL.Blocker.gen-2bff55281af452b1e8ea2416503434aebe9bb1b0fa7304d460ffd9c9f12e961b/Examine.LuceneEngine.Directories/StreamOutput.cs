using System;
using System.IO;
using System.Security;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Directories;

[SecuritySafeCritical]
public class StreamOutput : Stream
{
	public IndexOutput Output
	{
		[SecuritySafeCritical]
		get;
		[SecuritySafeCritical]
		set;
	}

	public override bool CanRead => false;

	public override bool CanSeek => true;

	public override bool CanWrite => true;

	public override long Length
	{
		[SecuritySafeCritical]
		get
		{
			return Output.Length();
		}
	}

	public override long Position
	{
		[SecuritySafeCritical]
		get
		{
			return Output.GetFilePointer();
		}
		[SecuritySafeCritical]
		set
		{
			Output.Seek(value);
		}
	}

	[SecuritySafeCritical]
	public StreamOutput(IndexOutput output)
	{
		Output = output;
	}

	[SecuritySafeCritical]
	public override void Flush()
	{
		Output.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}

	[SecuritySafeCritical]
	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			Output.Seek(offset);
			break;
		case SeekOrigin.Current:
			Output.Seek(Output.GetFilePointer() + offset);
			break;
		case SeekOrigin.End:
			throw new NotImplementedException();
		}
		return Output.GetFilePointer();
	}

	public override void SetLength(long value)
	{
		throw new NotImplementedException();
	}

	[SecuritySafeCritical]
	public override void Write(byte[] buffer, int offset, int count)
	{
		Output.WriteBytes(buffer, offset, count);
	}

	[SecuritySafeCritical]
	public override void Close()
	{
		Output.Flush();
		Output.Close();
		base.Close();
	}
}
