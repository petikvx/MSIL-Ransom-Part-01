using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Authentication;

internal class RequestMessageKeyboardInteractive : RequestMessage
{
	public byte[] Language { get; private set; }

	public byte[] SubMethods { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Language.Length + 4 + SubMethods.Length;

	public RequestMessageKeyboardInteractive(ServiceName serviceName, string username)
		: base(serviceName, username, "keyboard-interactive")
	{
		Language = Array<byte>.Empty;
		SubMethods = Array<byte>.Empty;
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(Language);
		WriteBinaryString(SubMethods);
	}
}
