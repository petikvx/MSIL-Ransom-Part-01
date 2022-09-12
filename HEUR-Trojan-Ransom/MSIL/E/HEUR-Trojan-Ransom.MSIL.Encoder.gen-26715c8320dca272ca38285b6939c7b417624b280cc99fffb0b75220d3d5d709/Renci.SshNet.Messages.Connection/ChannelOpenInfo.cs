using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

public abstract class ChannelOpenInfo : SshData
{
	public abstract string ChannelType { get; }

	protected override void LoadData()
	{
	}

	protected override void SaveData()
	{
	}
}
