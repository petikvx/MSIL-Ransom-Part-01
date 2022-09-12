using System;
using System.Text;
using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

internal class ExecRequestInfo : RequestInfo
{
	private byte[] _command;

	public const string Name = "exec";

	public override string RequestName => "exec";

	public string Command => Encoding.GetString(_command, 0, _command.Length);

	public Encoding Encoding { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + _command.Length;

	public ExecRequestInfo()
	{
		base.WantReply = true;
	}

	public ExecRequestInfo(string command, Encoding encoding)
		: this()
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		_command = encoding.GetBytes(command);
		Encoding = encoding;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_command = ReadBinary();
		Encoding = SshData.Utf8;
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_command);
	}
}
