using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Authentication;

public class RequestMessagePublicKey : RequestMessage
{
	public byte[] PublicKeyAlgorithmName { get; private set; }

	public byte[] PublicKeyData { get; private set; }

	public byte[] Signature { get; set; }

	protected override int BufferCapacity
	{
		get
		{
			int bufferCapacity = base.BufferCapacity;
			bufferCapacity++;
			bufferCapacity += 4;
			bufferCapacity += PublicKeyAlgorithmName.Length;
			bufferCapacity += 4;
			bufferCapacity += PublicKeyData.Length;
			if (Signature != null)
			{
				bufferCapacity += 4;
				bufferCapacity += Signature.Length;
			}
			return bufferCapacity;
		}
	}

	public RequestMessagePublicKey(ServiceName serviceName, string username, string keyAlgorithmName, byte[] keyData)
		: base(serviceName, username, "publickey")
	{
		PublicKeyAlgorithmName = SshData.Ascii.GetBytes(keyAlgorithmName);
		PublicKeyData = keyData;
	}

	public RequestMessagePublicKey(ServiceName serviceName, string username, string keyAlgorithmName, byte[] keyData, byte[] signature)
		: this(serviceName, username, keyAlgorithmName, keyData)
	{
		Signature = signature;
	}

	protected override void SaveData()
	{
		base.SaveData();
		Write(Signature != null);
		WriteBinaryString(PublicKeyAlgorithmName);
		WriteBinaryString(PublicKeyData);
		if (Signature != null)
		{
			WriteBinaryString(Signature);
		}
	}
}
