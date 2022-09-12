using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

internal class SignalRequestInfo : RequestInfo
{
	private byte[] _signalName;

	public const string Name = "signal";

	public override string RequestName => "signal";

	public string SignalName
	{
		get
		{
			return SshData.Ascii.GetString(_signalName, 0, _signalName.Length);
		}
		private set
		{
			_signalName = SshData.Ascii.GetBytes(value);
		}
	}

	protected override int BufferCapacity => base.BufferCapacity + 4 + _signalName.Length;

	public SignalRequestInfo()
	{
		base.WantReply = false;
	}

	public SignalRequestInfo(string signalName)
		: this()
	{
		SignalName = signalName;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_signalName = ReadBinary();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_signalName);
	}
}
