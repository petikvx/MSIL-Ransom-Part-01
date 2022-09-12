using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

[Message("SSH_MSG_GLOBAL_REQUEST", 80)]
public class GlobalRequestMessage : Message
{
	private byte[] _requestName;

	public string RequestName => SshData.Ascii.GetString(_requestName, 0, _requestName.Length);

	public bool WantReply { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + _requestName.Length + 1;

	public GlobalRequestMessage()
	{
	}

	internal GlobalRequestMessage(byte[] requestName, bool wantReply)
	{
		_requestName = requestName;
		WantReply = wantReply;
	}

	protected override void LoadData()
	{
		_requestName = ReadBinary();
		WantReply = ReadBoolean();
	}

	protected override void SaveData()
	{
		WriteBinaryString(_requestName);
		Write(WantReply);
	}

	internal override void Process(Session session)
	{
		session.OnGlobalRequestReceived(this);
	}
}
