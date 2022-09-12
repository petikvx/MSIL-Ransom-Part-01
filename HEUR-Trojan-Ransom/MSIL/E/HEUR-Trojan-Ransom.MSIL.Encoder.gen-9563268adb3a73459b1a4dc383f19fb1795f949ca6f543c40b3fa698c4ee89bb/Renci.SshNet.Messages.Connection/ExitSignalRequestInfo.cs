using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

internal class ExitSignalRequestInfo : RequestInfo
{
	private byte[] _signalName;

	private byte[] _errorMessage;

	private byte[] _language;

	public const string Name = "exit-signal";

	public override string RequestName => "exit-signal";

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

	public bool CoreDumped { get; private set; }

	public string ErrorMessage
	{
		get
		{
			return SshData.Utf8.GetString(_errorMessage, 0, _errorMessage.Length);
		}
		private set
		{
			_errorMessage = SshData.Utf8.GetBytes(value);
		}
	}

	public string Language
	{
		get
		{
			return SshData.Utf8.GetString(_language, 0, _language.Length);
		}
		private set
		{
			_language = SshData.Utf8.GetBytes(value);
		}
	}

	protected override int BufferCapacity => base.BufferCapacity + 4 + _signalName.Length + 1 + 4 + _errorMessage.Length + 4 + _language.Length;

	public ExitSignalRequestInfo()
	{
		base.WantReply = false;
	}

	public ExitSignalRequestInfo(string signalName, bool coreDumped, string errorMessage, string language)
		: this()
	{
		SignalName = signalName;
		CoreDumped = coreDumped;
		ErrorMessage = errorMessage;
		Language = language;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_signalName = ReadBinary();
		CoreDumped = ReadBoolean();
		_errorMessage = ReadBinary();
		_language = ReadBinary();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_signalName);
		Write(CoreDumped);
		Write(_errorMessage);
		Write(_language);
	}
}
