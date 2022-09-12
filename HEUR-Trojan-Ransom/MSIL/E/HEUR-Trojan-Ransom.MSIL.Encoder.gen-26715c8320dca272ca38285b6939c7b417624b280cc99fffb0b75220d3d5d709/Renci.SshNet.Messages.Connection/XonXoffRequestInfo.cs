namespace Renci.SshNet.Messages.Connection;

internal class XonXoffRequestInfo : RequestInfo
{
	public const string Name = "xon-xoff";

	public override string RequestName => "xon-xoff";

	public bool ClientCanDo { get; set; }

	protected override int BufferCapacity => base.BufferCapacity + 1;

	public XonXoffRequestInfo()
	{
		base.WantReply = false;
	}

	public XonXoffRequestInfo(bool clientCanDo)
		: this()
	{
		ClientCanDo = clientCanDo;
	}

	protected override void LoadData()
	{
		base.LoadData();
		ClientCanDo = ReadBoolean();
	}

	protected override void SaveData()
	{
		base.SaveData();
		Write(ClientCanDo);
	}
}
