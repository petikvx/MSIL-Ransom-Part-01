using System;
using System.IO;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Encryption;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class DeflaterOutputStream : Stream
{
	protected Stream baseOutputStream_;

	private byte[] apDMpruwtLlJCAuUPtphtOimkoBl;

	private ICryptoTransform lVbZDCSFwfLClncXjlTACHMncxYf;

	protected Deflater deflater_;

	private bool qLjCPZgLGFbtOdTHfZeKXAybmNBeB;

	private bool bTxDqzfYTykLhpjxfmuYkvsFldnIA;

	private string fadWAETvizZSRUgCkkNTYgaYtAWl;

	public bool CanPatchEntries => baseOutputStream_.CanSeek;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => baseOutputStream_.CanWrite;

	public bool IsStreamOwner
	{
		get
		{
			return bTxDqzfYTykLhpjxfmuYkvsFldnIA;
		}
		set
		{
			bTxDqzfYTykLhpjxfmuYkvsFldnIA = value;
		}
	}

	public override long Length => baseOutputStream_.Length;

	public string Password
	{
		get
		{
			return fadWAETvizZSRUgCkkNTYgaYtAWl;
		}
		set
		{
			if (value == null || value.Length != 0)
			{
				fadWAETvizZSRUgCkkNTYgaYtAWl = value;
			}
			else
			{
				fadWAETvizZSRUgCkkNTYgaYtAWl = null;
			}
		}
	}

	public override long Position
	{
		get
		{
			return baseOutputStream_.Position;
		}
		set
		{
			throw new NotSupportedException("Position property not supported");
		}
	}

	public DeflaterOutputStream(Stream baseOutputStream)
		: this(baseOutputStream, new Deflater(), 512)
	{
	}

	public DeflaterOutputStream(Stream baseOutputStream, Deflater deflater)
		: this(baseOutputStream, deflater, 512)
	{
	}

	public DeflaterOutputStream(Stream baseOutputStream, Deflater deflater, int bufferSize)
	{
		bTxDqzfYTykLhpjxfmuYkvsFldnIA = true;
		if (baseOutputStream == null)
		{
			throw new ArgumentNullException("baseOutputStream");
		}
		if (!baseOutputStream.CanWrite)
		{
			throw new ArgumentException("Must support writing", "baseOutputStream");
		}
		if (deflater == null)
		{
			throw new ArgumentNullException("deflater");
		}
		if (bufferSize <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize");
		}
		baseOutputStream_ = baseOutputStream;
		apDMpruwtLlJCAuUPtphtOimkoBl = new byte[bufferSize];
		deflater_ = deflater;
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		throw new NotSupportedException("DeflaterOutputStream BeginRead not currently supported");
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		throw new NotSupportedException("BeginWrite is not supported");
	}

	public override void Close()
	{
		if (qLjCPZgLGFbtOdTHfZeKXAybmNBeB)
		{
			return;
		}
		qLjCPZgLGFbtOdTHfZeKXAybmNBeB = true;
		try
		{
			Finish();
			if (lVbZDCSFwfLClncXjlTACHMncxYf != null)
			{
				lVbZDCSFwfLClncXjlTACHMncxYf.Dispose();
				lVbZDCSFwfLClncXjlTACHMncxYf = null;
			}
		}
		finally
		{
			if (bTxDqzfYTykLhpjxfmuYkvsFldnIA)
			{
				baseOutputStream_.Close();
			}
		}
	}

	protected void Deflate()
	{
		while (!deflater_.IsNeedingInput)
		{
			int num = deflater_.Deflate(apDMpruwtLlJCAuUPtphtOimkoBl, 0, apDMpruwtLlJCAuUPtphtOimkoBl.Length);
			if (num <= 0)
			{
				break;
			}
			if (lVbZDCSFwfLClncXjlTACHMncxYf != null)
			{
				EncryptBlock(apDMpruwtLlJCAuUPtphtOimkoBl, 0, num);
			}
			baseOutputStream_.Write(apDMpruwtLlJCAuUPtphtOimkoBl, 0, num);
		}
		if (!deflater_.IsNeedingInput)
		{
			throw new SharpZipBaseException("DeflaterOutputStream can't deflate all input?");
		}
	}

	protected void EncryptBlock(byte[] buffer, int offset, int length)
	{
		lVbZDCSFwfLClncXjlTACHMncxYf.TransformBlock(buffer, 0, length, buffer, 0);
	}

	public virtual void Finish()
	{
		deflater_.Finish();
		while (!deflater_.IsFinished)
		{
			int num = deflater_.Deflate(apDMpruwtLlJCAuUPtphtOimkoBl, 0, apDMpruwtLlJCAuUPtphtOimkoBl.Length);
			if (num <= 0)
			{
				break;
			}
			if (lVbZDCSFwfLClncXjlTACHMncxYf != null)
			{
				EncryptBlock(apDMpruwtLlJCAuUPtphtOimkoBl, 0, num);
			}
			baseOutputStream_.Write(apDMpruwtLlJCAuUPtphtOimkoBl, 0, num);
		}
		if (!deflater_.IsFinished)
		{
			throw new SharpZipBaseException("Can't deflate all input?");
		}
		baseOutputStream_.Flush();
		if (lVbZDCSFwfLClncXjlTACHMncxYf != null)
		{
			lVbZDCSFwfLClncXjlTACHMncxYf.Dispose();
			lVbZDCSFwfLClncXjlTACHMncxYf = null;
		}
	}

	public override void Flush()
	{
		deflater_.Flush();
		Deflate();
		baseOutputStream_.Flush();
	}

	protected void InitializePassword(string password)
	{
		PkzipClassicManaged pkzipClassicManaged = new PkzipClassicManaged();
		byte[] rgbKey = PkzipClassic.GenerateKeys(ZipConstants.ConvertToArray(password));
		lVbZDCSFwfLClncXjlTACHMncxYf = pkzipClassicManaged.CreateEncryptor(rgbKey, null);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("DeflaterOutputStream Read not supported");
	}

	public override int ReadByte()
	{
		throw new NotSupportedException("DeflaterOutputStream ReadByte not supported");
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("DeflaterOutputStream Seek not supported");
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("DeflaterOutputStream SetLength not supported");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		deflater_.SetInput(buffer, offset, count);
		Deflate();
	}

	public override void WriteByte(byte value)
	{
		byte[] buffer = new byte[1] { value };
		Write(buffer, 0, 1);
	}
}
