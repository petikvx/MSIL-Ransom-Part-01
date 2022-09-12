namespace Renci.SshNet.Messages.Connection;

internal class BreakRequestInfo : RequestInfo
{
	public const string Name = "break";

	public override string RequestName => "break";

	public uint BreakLength { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4;

	public BreakRequestInfo()
	{
		base.WantReply = true;
	}

	public BreakRequestInfo(uint breakLength)
		: this()
	{
		BreakLength = breakLength;
	}

	protected override void LoadData()
	{
		base.LoadData();
		BreakLength = ReadUInt32();
	}

	protected override void SaveData()
	{
		base.SaveData();
		Write(BreakLength);
	}
}
