using System;
using System.IO;

namespace Org.BouncyCastle.Tls;

public sealed class ServerName
{
	private readonly short nameType;

	private readonly byte[] nameData;

	public byte[] NameData => nameData;

	public short NameType => nameType;

	public ServerName(short nameType, byte[] nameData)
	{
		if (!TlsUtilities.IsValidUint8(nameType))
		{
			throw new ArgumentException("must be from 0 to 255", "nameType");
		}
		if (nameData == null)
		{
			throw new ArgumentNullException("nameData");
		}
		if (nameData.Length < 1 || !TlsUtilities.IsValidUint16(nameData.Length))
		{
			throw new ArgumentException("must have length from 1 to 65535", "nameData");
		}
		this.nameType = nameType;
		this.nameData = nameData;
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(nameType, output);
		TlsUtilities.WriteOpaque16(nameData, output);
	}

	public static ServerName Parse(Stream input)
	{
		short num = TlsUtilities.ReadUint8(input);
		byte[] array = TlsUtilities.ReadOpaque16(input, 1);
		return new ServerName(num, array);
	}
}
