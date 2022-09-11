#define DEBUG
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;

namespace C3904355907;

public sealed class C1993550816 : Stream
{
	private readonly Stream m_C3554254475;

	private readonly bool m_C3554254475;

	private HashAlgorithm m_C3554254475;

	private byte[] m_C3554254475 = null;

	public override bool CanRead => !this.m_C3554254475;

	public override bool CanSeek => false;

	public override bool CanWrite => this.m_C3554254475;

	public override long Length => this.m_C3554254475.Length;

	public override long Position
	{
		get
		{
			return this.m_C3554254475.Position;
		}
		set
		{
			Debug.Assert(condition: false);
			throw new NotSupportedException();
		}
	}

	[SpecialName]
	public byte[] C3554254475()
	{
		return this.m_C3554254475;
	}

	public C1993550816(Stream stream_0, bool bool_0, HashAlgorithm hashAlgorithm_0)
	{
		if (stream_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cd());
		}
		this.m_C3554254475 = stream_0;
		this.m_C3554254475 = bool_0;
		this.m_C3554254475 = hashAlgorithm_0 ?? new SHA256Managed();
		if (this.m_C3554254475 == null)
		{
			Debug.Assert(condition: false);
		}
		else if (!this.m_C3554254475.CanReuseTransform || !this.m_C3554254475.CanTransformMultipleBlocks)
		{
			Debug.Assert(condition: false);
			this.m_C3554254475 = null;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (this.m_C3554254475 != null)
			{
				try
				{
					this.m_C3554254475.TransformFinalBlock(global::C3554254475.C2137352139.C3554254475, 0, 0);
					this.m_C3554254475 = this.m_C3554254475.Hash;
					this.m_C3554254475.Clear();
				}
				catch (Exception)
				{
					Debug.Assert(condition: false);
				}
				this.m_C3554254475 = null;
			}
			this.m_C3554254475.Close();
		}
		base.Dispose(disposing);
	}

	public override void Flush()
	{
		this.m_C3554254475.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		Debug.Assert(condition: false);
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		Debug.Assert(condition: false);
		throw new NotSupportedException();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (this.m_C3554254475)
		{
			Debug.Assert(condition: false);
			throw new InvalidOperationException();
		}
		int i = this.m_C3554254475.Read(buffer, offset, count);
		for (int num = i; i < count; i += num)
		{
			if (num == 0)
			{
				break;
			}
			num = this.m_C3554254475.Read(buffer, offset + i, count - i);
		}
		byte[] array = new byte[buffer.Length];
		Array.Copy(buffer, array, buffer.Length);
		if (this.m_C3554254475 != null && i > 0)
		{
			this.m_C3554254475.TransformBlock(buffer, offset, i, buffer, offset);
		}
		Debug.Assert(global::C3554254475.C2137352139.C3554254475(buffer, array));
		return i;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (!this.m_C3554254475)
		{
			Debug.Assert(condition: false);
			throw new InvalidOperationException();
		}
		byte[] array = new byte[buffer.Length];
		Array.Copy(buffer, array, buffer.Length);
		if (this.m_C3554254475 != null && count > 0)
		{
			this.m_C3554254475.TransformBlock(buffer, offset, count, buffer, offset);
		}
		Debug.Assert(global::C3554254475.C2137352139.C3554254475(buffer, array));
		this.m_C3554254475.Write(buffer, offset, count);
	}
}
