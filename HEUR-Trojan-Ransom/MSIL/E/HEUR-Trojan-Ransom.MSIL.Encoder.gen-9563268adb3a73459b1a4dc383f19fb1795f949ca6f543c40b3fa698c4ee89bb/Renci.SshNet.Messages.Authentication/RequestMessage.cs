using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Authentication;

[Message("SSH_MSG_USERAUTH_REQUEST", 50)]
public abstract class RequestMessage : Message
{
	internal const int AuthenticationMessageCode = 50;

	private readonly byte[] _serviceName;

	private readonly byte[] _userName;

	private readonly byte[] _methodNameBytes;

	private readonly string _methodName;

	public byte[] Username => _userName;

	public byte[] ServiceName => _serviceName;

	public virtual string MethodName => _methodName;

	protected override int BufferCapacity => base.BufferCapacity + 4 + Username.Length + 4 + ServiceName.Length + 4 + _methodNameBytes.Length;

	protected RequestMessage(ServiceName serviceName, string username, string methodName)
	{
		_serviceName = serviceName.ToArray();
		_userName = SshData.Utf8.GetBytes(username);
		_methodNameBytes = SshData.Ascii.GetBytes(methodName);
		_methodName = methodName;
	}

	protected override void LoadData()
	{
		throw new InvalidOperationException("Load data is not supported.");
	}

	protected override void SaveData()
	{
		WriteBinaryString(_userName);
		WriteBinaryString(_serviceName);
		WriteBinaryString(_methodNameBytes);
	}

	internal override void Process(Session session)
	{
		throw new NotImplementedException();
	}
}
