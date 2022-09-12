using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

internal class SubsystemRequestInfo : RequestInfo
{
	private byte[] _subsystemName;

	public const string Name = "subsystem";

	public override string RequestName => "subsystem";

	public string SubsystemName
	{
		get
		{
			return SshData.Ascii.GetString(_subsystemName, 0, _subsystemName.Length);
		}
		private set
		{
			_subsystemName = SshData.Ascii.GetBytes(value);
		}
	}

	protected override int BufferCapacity => base.BufferCapacity + 4 + _subsystemName.Length;

	public SubsystemRequestInfo()
	{
		base.WantReply = true;
	}

	public SubsystemRequestInfo(string subsystem)
		: this()
	{
		SubsystemName = subsystem;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_subsystemName = ReadBinary();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_subsystemName);
	}
}
