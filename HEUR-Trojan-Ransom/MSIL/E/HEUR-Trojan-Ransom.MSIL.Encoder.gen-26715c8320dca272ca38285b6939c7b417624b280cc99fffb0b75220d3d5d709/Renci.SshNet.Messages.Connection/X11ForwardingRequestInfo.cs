using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

internal class X11ForwardingRequestInfo : RequestInfo
{
	private byte[] _authenticationProtocol;

	public const string Name = "x11-req";

	public override string RequestName => "x11-req";

	public bool IsSingleConnection { get; set; }

	public string AuthenticationProtocol
	{
		get
		{
			return SshData.Ascii.GetString(_authenticationProtocol, 0, _authenticationProtocol.Length);
		}
		private set
		{
			_authenticationProtocol = SshData.Ascii.GetBytes(value);
		}
	}

	public byte[] AuthenticationCookie { get; set; }

	public uint ScreenNumber { get; set; }

	protected override int BufferCapacity => base.BufferCapacity + 1 + 4 + _authenticationProtocol.Length + 4 + AuthenticationCookie.Length + 4;

	public X11ForwardingRequestInfo()
	{
		base.WantReply = true;
	}

	public X11ForwardingRequestInfo(bool isSingleConnection, string protocol, byte[] cookie, uint screenNumber)
		: this()
	{
		IsSingleConnection = isSingleConnection;
		AuthenticationProtocol = protocol;
		AuthenticationCookie = cookie;
		ScreenNumber = screenNumber;
	}

	protected override void LoadData()
	{
		base.LoadData();
		IsSingleConnection = ReadBoolean();
		_authenticationProtocol = ReadBinary();
		AuthenticationCookie = ReadBinary();
		ScreenNumber = ReadUInt32();
	}

	protected override void SaveData()
	{
		base.SaveData();
		Write(IsSingleConnection);
		WriteBinaryString(_authenticationProtocol);
		WriteBinaryString(AuthenticationCookie);
		Write(ScreenNumber);
	}
}
