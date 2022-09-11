#define DEBUG
using System;
using System.Diagnostics;
using System.IO;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C1255198513;

namespace C3904355907;

internal sealed class C3865851505 : Stream
{
	private Stream C3554254475;

	private readonly bool C3554254475;

	private C1255198513.C1993550816 C3554254475;

	private byte[] C3554254475 = null;

	public override bool CanRead => !this.C3554254475;

	public override bool CanSeek => false;

	public override bool CanWrite => this.C3554254475;

	public override long Length
	{
		get
		{
			Debug.Assert(condition: false);
			throw new NotSupportedException();
		}
	}

	public override long Position
	{
		get
		{
			Debug.Assert(condition: false);
			throw new NotSupportedException();
		}
		set
		{
			Debug.Assert(condition: false);
			throw new NotSupportedException();
		}
	}

	public C3865851505(Stream stream_0, bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		if (stream_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.co());
		}
		this.C3554254475 = stream_0;
		this.C3554254475 = bool_0;
		this.C3554254475 = new C1255198513.C1993550816(byte_0, byte_1);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (this.C3554254475 != null)
			{
				this.C3554254475.Dispose();
				this.C3554254475 = null;
				this.C3554254475.Close();
				this.C3554254475 = null;
			}
			C3554254475 = null;
		}
		base.Dispose(disposing);
	}

	public override void Flush()
	{
		Debug.Assert(this.C3554254475 != null);
		if (this.C3554254475 && this.C3554254475 != null)
		{
			this.C3554254475.Flush();
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		Debug.Assert(condition: false);
		throw new NotImplementedException();
	}

	public override void SetLength(long value)
	{
		Debug.Assert(condition: false);
		throw new NotImplementedException();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (this.C3554254475)
		{
			throw new InvalidOperationException();
		}
		int num = this.C3554254475.Read(buffer, offset, count);
		this.C3554254475.C3904355907(buffer, offset, num);
		return num;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3187964512());
		}
		if (count != 0)
		{
			if (!this.C3554254475)
			{
				throw new InvalidOperationException();
			}
			if (C3554254475 == null || C3554254475.Length < count)
			{
				C3554254475 = new byte[count];
			}
			Array.Copy(buffer, offset, C3554254475, 0, count);
			this.C3554254475.C3554254475(C3554254475, 0, count);
			this.C3554254475.Write(C3554254475, 0, count);
		}
	}
}
