using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Authentication;

internal class RequestMessageHost : RequestMessage
{
	public byte[] PublicKeyAlgorithm { get; private set; }

	public byte[] PublicHostKey { get; private set; }

	public byte[] ClientHostName { get; private set; }

	public byte[] ClientUsername { get; private set; }

	public byte[] Signature { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + PublicKeyAlgorithm.Length + 4 + PublicHostKey.Length + 4 + ClientHostName.Length + 4 + ClientUsername.Length + 4 + Signature.Length;

	public RequestMessageHost(ServiceName serviceName, string username, string publicKeyAlgorithm, byte[] publicHostKey, string clientHostName, string clientUsername, byte[] signature)
		: base(serviceName, username, "hostbased")
	{
		PublicKeyAlgorithm = SshData.Ascii.GetBytes(publicKeyAlgorithm);
		PublicHostKey = publicHostKey;
		ClientHostName = SshData.Ascii.GetBytes(clientHostName);
		ClientUsername = SshData.Utf8.GetBytes(clientUsername);
		Signature = signature;
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(PublicKeyAlgorithm);
		WriteBinaryString(PublicHostKey);
		WriteBinaryString(ClientHostName);
		WriteBinaryString(ClientUsername);
		WriteBinaryString(Signature);
	}
}
