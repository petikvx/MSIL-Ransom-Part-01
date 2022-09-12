using System;
using System.Threading;
using Renci.SshNet.Messages;
using Renci.SshNet.Messages.Authentication;

namespace Renci.SshNet;

public class NoneAuthenticationMethod : AuthenticationMethod, IDisposable
{
	private AuthenticationResult _authenticationResult = AuthenticationResult.Failure;

	private EventWaitHandle _authenticationCompleted = new AutoResetEvent(initialState: false);

	private bool _isDisposed;

	public override string Name => "none";

	public NoneAuthenticationMethod(string username)
		: base(username)
	{
	}

	public override AuthenticationResult Authenticate(Session session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		session.UserAuthenticationSuccessReceived += Session_UserAuthenticationSuccessReceived;
		session.UserAuthenticationFailureReceived += Session_UserAuthenticationFailureReceived;
		try
		{
			session.SendMessage(new RequestMessageNone(ServiceName.Connection, base.Username));
			session.WaitOnHandle(_authenticationCompleted);
		}
		finally
		{
			session.UserAuthenticationSuccessReceived -= Session_UserAuthenticationSuccessReceived;
			session.UserAuthenticationFailureReceived -= Session_UserAuthenticationFailureReceived;
		}
		return _authenticationResult;
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
				authenticationCompleted.Dispose();
				_authenticationCompleted = null;
			}
			_isDisposed = true;
		}
	}

	~NoneAuthenticationMethod()
	{
		Dispose(disposing: false);
	}
}
