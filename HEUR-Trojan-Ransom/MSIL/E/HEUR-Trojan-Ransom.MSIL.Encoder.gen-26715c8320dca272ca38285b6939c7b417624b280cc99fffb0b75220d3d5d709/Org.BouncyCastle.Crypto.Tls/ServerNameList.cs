using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls;

public class ServerNameList
{
	protected readonly IList mServerNameList;

	public virtual IList ServerNames => mServerNameList;

	public ServerNameList(IList serverNameList)
	{
		if (serverNameList == null)
		{
			throw new ArgumentNullException("serverNameList");
		}
		mServerNameList = serverNameList;
	}

	public virtual void Encode(Stream output)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] array = TlsUtilities.EmptyBytes;
		foreach (ServerName serverName in ServerNames)
		{
			array = CheckNameType(array, serverName.NameType);
			if (array != null)
			{
				serverName.Encode(memoryStream);
				continue;
			}
			throw new TlsFatalAlert(80);
		}
		TlsUtilities.CheckUint16(memoryStream.Length);
		TlsUtilities.WriteUint16((int)memoryStream.Length, output);
		Streams.WriteBufTo(memoryStream, output);
	}

	public static ServerNameList Parse(Stream input)
	{
		int num = TlsUtilities.ReadUint16(input);
		if (num < 1)
		{
			throw new TlsFatalAlert(50);
		}
		byte[] buffer = TlsUtilities.ReadFully(num, input);
		MemoryStream memoryStream = new MemoryStream(buffer, writable: false);
		byte[] array = TlsUtilities.EmptyBytes;
		IList list = Platform.CreateArrayList();
		while (memoryStream.Position < memoryStream.Length)
		{
			ServerName serverName = ServerName.Parse(memoryStream);
			array = CheckNameType(array, serverName.NameType);
			if (array != null)
			{
				list.Add(serverName);
				continue;
			}
			throw new TlsFatalAlert(47);
		}
		return new ServerNameList(list);
	}

	private static byte[] CheckNameType(byte[] nameTypesSeen, byte nameType)
	{
		if (NameType.IsValid(nameType) && !Arrays.Contains(nameTypesSeen, nameType))
		{
			return Arrays.Append(nameTypesSeen, nameType);
		}
		return null;
	}
}
