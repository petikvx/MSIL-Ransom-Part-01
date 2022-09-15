using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public sealed class ServerNameList
{
	private readonly IList m_serverNameList;

	public IList ServerNames => m_serverNameList;

	public ServerNameList(IList serverNameList)
	{
		if (serverNameList == null)
		{
			throw new ArgumentNullException("serverNameList");
		}
		m_serverNameList = serverNameList;
	}

	public void Encode(Stream output)
	{
		MemoryStream memoryStream = new MemoryStream();
		short[] array = TlsUtilities.EmptyShorts;
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
		int i = (int)memoryStream.Length;
		TlsUtilities.CheckUint16(i);
		TlsUtilities.WriteUint16(i, output);
		Streams.WriteBufTo(memoryStream, output);
	}

	public static ServerNameList Parse(Stream input)
	{
		MemoryStream memoryStream = new MemoryStream(TlsUtilities.ReadOpaque16(input, 1), writable: false);
		short[] array = TlsUtilities.EmptyShorts;
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

	private static short[] CheckNameType(short[] nameTypesSeen, short nameType)
	{
		if (Arrays.Contains(nameTypesSeen, nameType))
		{
			return null;
		}
		return Arrays.Append(nameTypesSeen, nameType);
	}
}
