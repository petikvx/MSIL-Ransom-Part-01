using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpObjectFactory
{
	private readonly BcpgInputStream bcpgIn;

	public PgpObjectFactory(Stream inputStream)
	{
		bcpgIn = BcpgInputStream.Wrap(inputStream);
	}

	public PgpObjectFactory(byte[] bytes)
		: this(new MemoryStream(bytes, writable: false))
	{
	}

	public PgpObject NextPgpObject()
	{
		PacketTag packetTag = bcpgIn.NextPacketTag();
		if (packetTag == (PacketTag)(-1))
		{
			return null;
		}
		switch (packetTag)
		{
		case PacketTag.Experimental1:
		case PacketTag.Experimental2:
		case PacketTag.Experimental3:
		case PacketTag.Experimental4:
			return new PgpExperimental(bcpgIn);
		case PacketTag.Signature:
		{
			IList list2 = Platform.CreateArrayList();
			while (bcpgIn.NextPacketTag() == PacketTag.Signature)
			{
				try
				{
					list2.Add(new PgpSignature(bcpgIn));
				}
				catch (PgpException ex3)
				{
					throw new IOException("can't create signature object: " + ex3);
				}
			}
			PgpSignature[] array2 = new PgpSignature[list2.Count];
			for (int j = 0; j < list2.Count; j++)
			{
				array2[j] = (PgpSignature)list2[j];
			}
			return new PgpSignatureList(array2);
		}
		case PacketTag.PublicKeyEncryptedSession:
		case PacketTag.SymmetricKeyEncryptedSessionKey:
			return new PgpEncryptedDataList(bcpgIn);
		case PacketTag.OnePassSignature:
		{
			IList list = Platform.CreateArrayList();
			while (bcpgIn.NextPacketTag() == PacketTag.OnePassSignature)
			{
				try
				{
					list.Add(new PgpOnePassSignature(bcpgIn));
				}
				catch (PgpException ex2)
				{
					throw new IOException("can't create one pass signature object: " + ex2);
				}
			}
			PgpOnePassSignature[] array = new PgpOnePassSignature[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				array[i] = (PgpOnePassSignature)list[i];
			}
			return new PgpOnePassSignatureList(array);
		}
		case PacketTag.SecretKey:
			try
			{
				return new PgpSecretKeyRing(bcpgIn);
			}
			catch (PgpException ex)
			{
				throw new IOException("can't create secret key object: " + ex);
			}
		case PacketTag.PublicKey:
			return new PgpPublicKeyRing(bcpgIn);
		case PacketTag.CompressedData:
			return new PgpCompressedData(bcpgIn);
		default:
			throw new IOException("unknown object in stream " + bcpgIn.NextPacketTag());
		case PacketTag.Marker:
			return new PgpMarker(bcpgIn);
		case PacketTag.LiteralData:
			return new PgpLiteralData(bcpgIn);
		}
	}

	[Obsolete("Use NextPgpObject() instead")]
	public object NextObject()
	{
		return NextPgpObject();
	}

	public IList AllPgpObjects()
	{
		IList list = Platform.CreateArrayList();
		PgpObject value;
		while ((value = NextPgpObject()) != null)
		{
			list.Add(value);
		}
		return list;
	}
}
