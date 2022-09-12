using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

internal class TcpIpForwardGlobalRequestMessage : GlobalRequestMessage
{
	private byte[] _addressToBind;

	public string AddressToBind
	{
		get
		{
			return SshData.Utf8.GetString(_addressToBind, 0, _addressToBind.Length);
		}
		private set
		{
			_addressToBind = SshData.Utf8.GetBytes(value);
		}
	}

	public uint PortToBind { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + _addressToBind.Length + 4;

	public TcpIpForwardGlobalRequestMessage(string addressToBind, uint portToBind)
		: base(SshData.Ascii.GetBytes("tcpip-forward"), wantReply: true)
	{
		AddressToBind = addressToBind;
		PortToBind = portToBind;
	}

	protected override void LoadData()
	{
		throw new NotImplementedException();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_addressToBind);
		Write(PortToBind);
	}
}
