using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class X509LogoTypeExtension : X509Extension
{
	private const string szOID_LOGO_TYPES = "1.3.6.1.5.5.7.1.12";

	private const byte OctetStringTag = 4;

	private const byte ObjectIdentifierTag = 6;

	private const byte StringTag = 22;

	private const byte SequenceTag = 48;

	private const byte DirectTag = 160;

	private const byte IndirectTag = 161;

	private const byte AudioLogoTypeDataTag = 161;

	private List<X509Logo> m_logos = new List<X509Logo>();

	private bool m_decodePathComplete;

	public List<X509Logo> Logos => m_logos;

	public void TryDecodeExtension()
	{
		try
		{
			DecodeExtension();
		}
		catch (Exception ex)
		{
			if (InfoCardTrace.IsFatal(ex))
			{
				InfoCardService.Crash(ex);
			}
			InfoCardTrace.TraceAndLogException(ex);
		}
		m_decodePathComplete = true;
	}

	public X509LogoTypeExtension(byte[] rawData)
		: base("1.3.6.1.5.5.7.1.12", rawData, critical: false)
	{
	}

	public static X509LogoTypeExtension FromCertificate(X509Certificate2 certificate)
	{
		if (certificate.Extensions != null && certificate.Extensions["1.3.6.1.5.5.7.1.12"] != null)
		{
			return new X509LogoTypeExtension(certificate.Extensions["1.3.6.1.5.5.7.1.12"]!.RawData);
		}
		return null;
	}

	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
		base.CopyFrom(asnEncodedData);
		base.Critical = false;
		m_decodePathComplete = false;
	}

	public override string ToString()
	{
		return base.ToString();
	}

	private void DecodeExtension()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(new MemoryStream(base.RawData));
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		VerifyByte(binaryReader.ReadByte(), 48);
		ReadAsnByteLength(binaryReader);
		while (true)
		{
			if (!ReachedEndPosition(binaryReader.BaseStream.Position, binaryReader.BaseStream.Length))
			{
				Dictionary<Oid, byte[]> dictionary = new Dictionary<Oid, byte[]>();
				List<string> list = new List<string>();
				X509LogoType x509LogoType = (X509LogoType)binaryReader.ReadByte();
				_ = binaryReader.BaseStream.Position;
				long num = ReadAsnByteLength(binaryReader);
				long num2 = binaryReader.BaseStream.Position + num;
				if (X509LogoType.Subject == x509LogoType || X509LogoType.Issuer == x509LogoType)
				{
					byte b = binaryReader.ReadByte();
					VerifyByte(b, new byte[2] { 160, 161 });
					ReadAsnByteLength(binaryReader);
					if (161 == b)
					{
						break;
					}
					VerifyByte(binaryReader.ReadByte(), 48);
					ReadAsnByteLength(binaryReader);
					b = binaryReader.ReadByte();
					bool flag;
					if (161 == b)
					{
						flag = false;
						InfoCardTrace.TraceAndLogException((Exception)(object)new LogoValidationException(SR.GetString("LogoUnsupportedAudio")));
						VerifyByte(binaryReader.ReadByte(), 48);
					}
					else
					{
						flag = true;
						VerifyByte(b, 48);
					}
					ReadAsnByteLength(binaryReader);
					VerifyByte(binaryReader.ReadByte(), 48);
					ReadAsnByteLength(binaryReader);
					VerifyByte(binaryReader.ReadByte(), 22);
					int count = ReadAsnByteLength(binaryReader);
					string @string = aSCIIEncoding.GetString(binaryReader.ReadBytes(count));
					VerifyByte(binaryReader.ReadByte(), 48);
					count = ReadAsnByteLength(binaryReader);
					long endPosition = binaryReader.BaseStream.Position + count;
					while (!ReachedEndPosition(binaryReader.BaseStream.Position, endPosition))
					{
						VerifyByte(binaryReader.ReadByte(), 48);
						count = ReadAsnByteLength(binaryReader);
						VerifyByte(binaryReader.ReadByte(), 48);
						count = ReadAsnByteLength(binaryReader);
						long position = binaryReader.BaseStream.Position + count;
						Oid key = ReadObjectIdentifier(binaryReader);
						binaryReader.BaseStream.Position = position;
						VerifyByte(binaryReader.ReadByte(), 4);
						count = ReadAsnByteLength(binaryReader);
						byte[] array2 = (dictionary[key] = binaryReader.ReadBytes(count));
					}
					VerifyByte(binaryReader.ReadByte(), 48);
					count = ReadAsnByteLength(binaryReader);
					long endPosition2 = binaryReader.BaseStream.Position + count;
					while (!ReachedEndPosition(binaryReader.BaseStream.Position, endPosition2))
					{
						VerifyByte(binaryReader.ReadByte(), 22);
						count = ReadAsnByteLength(binaryReader);
						list.Add(aSCIIEncoding.GetString(binaryReader.ReadBytes(count)));
					}
					if (binaryReader.BaseStream.Position != num2)
					{
						binaryReader.BaseStream.Position = num2;
					}
					if (flag)
					{
						m_logos.Add(new X509ImageLogo(x509LogoType, @string, dictionary, list));
					}
					continue;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new LogoValidationException(SR.GetString("LogoUnsupportedType")));
			}
			return;
		}
		throw InfoCardTrace.ThrowHelperError((Exception)(object)new LogoValidationException(SR.GetString("LogoUnsupportedIndirectReferences")));
	}

	private void VerifyByte(byte input, byte[] expected)
	{
		foreach (byte b in expected)
		{
			if (b == input)
			{
				return;
			}
		}
		throw InfoCardTrace.ThrowHelperError((Exception)(object)new LogoValidationException(SR.GetString("LogoInvalidLogoType")));
	}

	private void VerifyByte(byte input, byte expected)
	{
		if (input != expected)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new LogoValidationException(SR.GetString("LogoInvalidLogoType")));
		}
	}

	private bool ReachedEndPosition(long currentPosition, long endPosition)
	{
		if (currentPosition > endPosition)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new LogoValidationException(SR.GetString("LogoInvalidCertificateLength")));
		}
		return currentPosition == endPosition;
	}

	private int ReadAsnByteLength(BinaryReader br)
	{
		byte b = br.ReadByte();
		if ((b & 0x80) == 0)
		{
			return b;
		}
		int num = b & 0x7F;
		if (num >= 1 && num <= 4)
		{
			byte[] array = br.ReadBytes(b & 0x7F);
			int num2 = 0;
			byte[] array2 = array;
			foreach (byte b2 in array2)
			{
				num2 = b2 + (num2 << 8);
			}
			return num2;
		}
		throw InfoCardTrace.ThrowHelperError((Exception)(object)new LogoValidationException(SR.GetString("LogoInvalidAsnLength")));
	}

	private Oid ReadObjectIdentifier(BinaryReader br)
	{
		VerifyByte(br.ReadByte(), 6);
		int num = ReadAsnByteLength(br);
		byte[] array = br.ReadBytes(num);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("{0}.{1}.", (int)array[0] / 40, (int)array[0] % 40);
		for (int i = 1; i < num; i++)
		{
			stringBuilder.Append(array[i].ToString(CultureInfo.InvariantCulture));
			if (i != num - 1)
			{
				stringBuilder.Append('.');
			}
		}
		return new Oid(stringBuilder.ToString());
	}
}
