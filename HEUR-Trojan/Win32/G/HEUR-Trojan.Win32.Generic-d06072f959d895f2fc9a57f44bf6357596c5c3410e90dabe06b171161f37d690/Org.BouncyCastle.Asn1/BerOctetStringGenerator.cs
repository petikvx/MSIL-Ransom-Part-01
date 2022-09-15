using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1;

public class BerOctetStringGenerator : BerGenerator
{
	private class BufferedBerOctetStream : BaseOutputStream
	{
		private byte[] _buf;

		private int _off;

		private readonly BerOctetStringGenerator _gen;

		private readonly DerOutputStream _derOut;

		internal BufferedBerOctetStream(BerOctetStringGenerator gen, byte[] buf)
		{
			_gen = gen;
			_buf = buf;
			_off = 0;
			_derOut = new DerOutputStream(_gen.Out);
		}

		public override void WriteByte(byte b)
		{
			_buf[_off++] = b;
			if (_off == _buf.Length)
			{
				DerOctetString.Encode(_derOut, _buf, 0, _off);
				_off = 0;
			}
		}

		public override void Write(byte[] b, int off, int len)
		{
			int num = _buf.Length;
			int num2 = num - _off;
			if (len < num2)
			{
				Array.Copy(b, off, _buf, _off, len);
				_off += len;
				return;
			}
			int num3 = 0;
			if (_off > 0)
			{
				Array.Copy(b, off, _buf, _off, num2);
				num3 += num2;
				DerOctetString.Encode(_derOut, _buf, 0, num);
			}
			int num4;
			while ((num4 = len - num3) >= num)
			{
				DerOctetString.Encode(_derOut, b, off + num3, num);
				num3 += num;
			}
			Array.Copy(b, off + num3, _buf, 0, num4);
			_off = num4;
		}

		public override void Close()
		{
			if (_off != 0)
			{
				DerOctetString.Encode(_derOut, _buf, 0, _off);
			}
			_gen.WriteBerEnd();
			base.Close();
		}
	}

	public BerOctetStringGenerator(Stream outStream)
		: base(outStream)
	{
		WriteBerHeader(36);
	}

	public BerOctetStringGenerator(Stream outStream, int tagNo, bool isExplicit)
		: base(outStream, tagNo, isExplicit)
	{
		WriteBerHeader(36);
	}

	public Stream GetOctetOutputStream()
	{
		return GetOctetOutputStream(new byte[1000]);
	}

	public Stream GetOctetOutputStream(int bufSize)
	{
		if (bufSize >= 1)
		{
			return GetOctetOutputStream(new byte[bufSize]);
		}
		return GetOctetOutputStream();
	}

	public Stream GetOctetOutputStream(byte[] buf)
	{
		return new BufferedBerOctetStream(this, buf);
	}
}
