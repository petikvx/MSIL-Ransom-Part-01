#define DEBUG
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace C3904355907;

public sealed class C4024072794 : CryptoStream
{
	private ICryptoTransform C3554254475;

	private SymmetricAlgorithm C3554254475;

	public C4024072794(Stream stream_0, ICryptoTransform icryptoTransform_0, CryptoStreamMode cryptoStreamMode_0, SymmetricAlgorithm symmetricAlgorithm_0)
		: base(stream_0, icryptoTransform_0, cryptoStreamMode_0)
	{
		this.C3554254475 = icryptoTransform_0;
		C3554254475 = symmetricAlgorithm_0;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			base.Dispose(disposing);
		}
		catch (CryptographicException)
		{
		}
		catch (IndexOutOfRangeException)
		{
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		if (!disposing)
		{
			return;
		}
		try
		{
			if (this.C3554254475 != null)
			{
				this.C3554254475.Dispose();
				this.C3554254475 = null;
			}
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		try
		{
			if (C3554254475 != null)
			{
				C3554254475.Clear();
				C3554254475 = null;
			}
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
	}
}
