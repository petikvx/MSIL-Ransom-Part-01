using System.Collections.Generic;
using System.Text;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp.Responses;

internal class SftpNameResponse : SftpResponse
{
	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.Name;

	public uint Count { get; private set; }

	public Encoding Encoding { get; private set; }

	public KeyValuePair<string, SftpFileAttributes>[] Files { get; set; }

	public SftpNameResponse(uint protocolVersion, Encoding encoding)
		: base(protocolVersion)
	{
		Files = Array<KeyValuePair<string, SftpFileAttributes>>.Empty;
		Encoding = encoding;
	}

	protected override void LoadData()
	{
		base.LoadData();
		Count = ReadUInt32();
		Files = new KeyValuePair<string, SftpFileAttributes>[Count];
		for (int i = 0; i < Count; i++)
		{
			string key = ReadString(Encoding);
			if (SupportsLongName(base.ProtocolVersion))
			{
				ReadString(Encoding);
			}
			Files[i] = new KeyValuePair<string, SftpFileAttributes>(key, ReadAttributes());
		}
	}

	protected override void SaveData()
	{
		base.SaveData();
		Write((uint)Files.Length);
		for (int i = 0; i < Files.Length; i++)
		{
			KeyValuePair<string, SftpFileAttributes> keyValuePair = Files[i];
			Write(keyValuePair.Key, Encoding);
			if (SupportsLongName(base.ProtocolVersion))
			{
				Write(0u);
			}
			Write(keyValuePair.Value.GetBytes());
		}
	}

	private static bool SupportsLongName(uint protocolVersion)
	{
		return protocolVersion <= 3;
	}
}
