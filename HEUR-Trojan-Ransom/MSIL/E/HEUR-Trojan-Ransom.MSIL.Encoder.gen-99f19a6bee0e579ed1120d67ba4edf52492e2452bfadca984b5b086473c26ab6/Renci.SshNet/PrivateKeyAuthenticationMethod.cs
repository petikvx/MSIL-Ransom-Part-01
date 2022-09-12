using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using Renci.SshNet.Common;
using Renci.SshNet.Messages;
using Renci.SshNet.Messages.Authentication;

namespace Renci.SshNet;

public class PrivateKeyAuthenticationMethod : AuthenticationMethod, IDisposable
{
	private class SignatureData : SshData
	{
		private readonly RequestMessagePublicKey _message;

		private readonly byte[] _sessionId;

		private readonly byte[] _serviceName;

		private readonly byte[] _authenticationMethod;

		protected override int BufferCapacity => base.BufferCapacity + 4 + _sessionId.Length + 1 + 4 + _message.Username.Length + 4 + _serviceName.Length + 4 + _authenticationMethod.Length + 1 + 4 + _message.PublicKeyAlgorithmName.Length + 4 + _message.PublicKeyData.Length;

		public SignatureData(RequestMessagePublicKey message, byte[] sessionId)
		{
			_message = message;
			_sessionId = sessionId;
			_serviceName = ServiceName.Connection.ToArray();
			_authenticationMethod = SshData.Ascii.GetBytes("publickey");
		}

		protected override void LoadData()
		{
			throw new NotImplementedException();
		}

		protected override void SaveData()
		{
			WriteBinaryString(_sessionId);
			Write(50);
			WriteBinaryString(_message.Username);
			WriteBinaryString(_serviceName);
			WriteBinaryString(_authenticationMethod);
			Write(1);
			WriteBinaryString(_message.PublicKeyAlgorithmName);
			WriteBinaryString(_message.PublicKeyData);
		}
	}

	private AuthenticationResult _authenticationResult = AuthenticationResult.Failure;

	private EventWaitHandle _authenticationCompleted = new ManualResetEvent(initialState: false);

	private bool _isSignatureRequired;

	private bool _isDisposed;

	public override string Name => "publickey";

	public ICollection<PrivateKeyFile> KeyFiles { get; private set; }

	public PrivateKeyAuthenticationMethod(string username, params PrivateKeyFile[] keyFiles)
		: base(username)
	{
		if (keyFiles == null)
		{
			throw new ArgumentNullException("keyFiles");
		}
		KeyFiles = new Collection<PrivateKeyFile>(keyFiles);
	}

	public override AuthenticationResult Authenticate(Session session)
	{
		session.UserAuthenticationSuccessReceived += Session_UserAuthenticationSuccessReceived;
		session.UserAuthenticationFailureReceived += Session_UserAuthenticationFailureReceived;
		session.UserAuthenticationPublicKeyReceived += Session_UserAuthenticationPublicKeyReceived;
		session.RegisterMessage("SSH_MSG_USERAUTH_PK_OK");
		try
		{
			foreach (PrivateKeyFile keyFile in KeyFiles)
			{
				_authenticationCompleted.Reset();
				_isSignatureRequired = false;
				RequestMessagePublicKey requestMessagePublicKey = new RequestMessagePublicKey(ServiceName.Connection, base.Username, keyFile.HostKey.Name, keyFile.HostKey.Data);
				if (KeyFiles.Count < 2)
				{
					byte[] bytes = new SignatureData(requestMessagePublicKey, session.SessionId).GetBytes();
					requestMessagePublicKey.Signature = keyFile.HostKey.Sign(bytes);
				}
				session.SendMessage(requestMessagePublicKey);
				session.WaitOnHandle(_authenticationCompleted);
				if (_isSignatureRequired)
				{
					_authenticationCompleted.Reset();
					RequestMessagePublicKey requestMessagePublicKey2 = new RequestMessagePublicKey(ServiceName.Connection, base.Username, keyFile.HostKey.Name, keyFile.HostKey.Data);
					byte[] bytes2 = new SignatureData(requestMessagePublicKey, session.SessionId).GetBytes();
					requestMessagePublicKey2.Signature = keyFile.HostKey.Sign(bytes2);
					session.SendMessage(requestMessagePublicKey2);
				}
				session.WaitOnHandle(_authenticationCompleted);
				if (_authenticationResult == AuthenticationResult.Success)
				{
					break;
				}
			}
			return _authenticationResult;
		}
		finally
		{
			session.UserAuthenticationSuccessReceived -= Session_UserAuthenticationSuccessReceived;
			session.UserAuthenticationFailureReceived -= Session_UserAuthenticationFailureReceived;
			session.UserAuthenticationPublicKeyReceived -= Session_UserAuthenticationPublicKeyReceived;
			session.UnRegisterMessage("SSH_MSG_USERAUTH_PK_OK");
		}
	}

	private void Session_UserAuthenticationSuccessReceived(object sender, MessageEventArgs<SuccessMessage> e)
	{
		_authenticationResult = AuthenticationResult.Success;
		_authenticationCompleted.Set();
	}

	private void Session_UserAuthenticationFailureReceived(object sender, MessageEventArgs<FailureMessage> e)
	{
		if (e.Message.PartialSuccess)
		{
			_authenticationResult = AuthenticationResult.PartialSuccess;
		}
		else
		{
			_authenticationResult = AuthenticationResult.Failure;
		}
		base.AllowedAuthentications = e.Message.AllowedAuthentications;
		_authenticationCompleted.Set();
	}

	private void Session_UserAuthenticationPublicKeyReceived(object sender, MessageEventArgs<PublicKeyMessage> e)
	{
		_isSignatureRequired = true;
		_authenticationCompleted.Set();
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_isDisposed && disposing)
		{
			EventWaitHandle authenticationCompleted = _authenticationCompleted;
			if (authenticationCompleted != null)
			{
				_authenticationCompleted = null;
				authenticationCompleted.Dispose();
			}
			_isDisposed = true;
		}
	}

	~PrivateKeyAuthenticationMethod()
	{
		Dispose(disposing: false);
	}
}
