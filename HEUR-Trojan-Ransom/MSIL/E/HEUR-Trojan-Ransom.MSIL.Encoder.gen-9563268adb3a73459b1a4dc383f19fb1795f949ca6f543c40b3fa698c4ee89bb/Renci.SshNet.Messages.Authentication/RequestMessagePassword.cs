namespace Renci.SshNet.Messages.Authentication;

internal class RequestMessagePassword : RequestMessage
{
	public byte[] Password { get; private set; }

	public byte[] NewPassword { get; private set; }

	protected override int BufferCapacity
	{
		get
		{
			int bufferCapacity = base.BufferCapacity;
			bufferCapacity++;
			bufferCapacity += 4;
			bufferCapacity += Password.Length;
			if (NewPassword != null)
			{
				bufferCapacity += 4;
				bufferCapacity += NewPassword.Length;
			}
			return bufferCapacity;
		}
	}

	public RequestMessagePassword(ServiceName serviceName, string username, byte[] password)
		: base(serviceName, username, "password")
	{
		Password = password;
	}

	public RequestMessagePassword(ServiceName serviceName, string username, byte[] password, byte[] newPassword)
		: this(serviceName, username, password)
	{
		NewPassword = newPassword;
	}

	protected override void SaveData()
	{
		base.SaveData();
		Write(NewPassword != null);
		WriteBinaryString(Password);
		if (NewPassword != null)
		{
			WriteBinaryString(NewPassword);
		}
	}
}
