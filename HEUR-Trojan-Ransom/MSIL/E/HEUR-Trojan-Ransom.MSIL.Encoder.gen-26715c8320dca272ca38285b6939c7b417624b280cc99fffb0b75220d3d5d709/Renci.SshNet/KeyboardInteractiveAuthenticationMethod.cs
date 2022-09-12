using System;
using System.Linq;
using System.Threading;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Common;
using Renci.SshNet.Messages;
using Renci.SshNet.Messages.Authentication;

namespace Renci.SshNet;

public class KeyboardInteractiveAuthenticationMethod : AuthenticationMethod, IDisposable
{
	private AuthenticationResult _authenticationResult = AuthenticationResult.Failure;

	private Session _session;

	private EventWaitHandle _authenticationCompleted = new AutoResetEvent(initialState: false);

	private Exception _exception;

	private readonly RequestMessage _requestMessage;

	private bool _isDisposed;

	public override string Name => _requestMessage.MethodName;

	public event EventHandler<AuthenticationPromptEventArgs> AuthenticationPrompt;

	public KeyboardInteractiveAuthenticationMethod(string username)
		: base(username)
	{
		_requestMessage = new RequestMessageKeyboardInteractive(ServiceName.Connection, username);
	}

	public override AuthenticationResult Authenticate(Session session)
	{
		_session = session;
		session.UserAuthenticationSuccessReceived += Session_UserAuthenticationSuccessReceived;
		session.UserAuthenticationFailureReceived += Session_UserAuthenticationFailureReceived;
		session.UserAuthenticationInformationRequestReceived += Session_UserAuthenticationInformationRequestReceived;
		session.RegisterMessage("SSH_MSG_USERAUTH_INFO_REQUEST");
		try
		{
			session.SendMessage(_requestMessage);
			session.WaitOnHandle(_authenticationCompleted);
		}
		finally
		{
			session.UnRegisterMessage("SSH_MSG_USERAUTH_INFO_REQUEST");
			session.UserAuthenticationSuccessReceived -= Session_UserAuthenticationSuccessReceived;
			session.UserAuthenticationFailureReceived -= Session_UserAuthenticationFailureReceived;
			session.UserAuthenticationInformationRequestReceived -= Session_UserAuthenticationInformationRequestReceived;
		}
		if (_exception != null)
		{
			throw _exception;
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

	private void Session_UserAuthenticationInformationRequestReceived(object sender, MessageEventArgs<InformationRequestMessage> e)
	{
		InformationRequestMessage message = e.Message;
		AuthenticationPromptEventArgs eventArgs = new AuthenticationPromptEventArgs(base.Username, message.Instruction, message.Language, message.Prompts);
		ThreadAbstraction.ExecuteThread(delegate
		{
			try
			{
				if (this.AuthenticationPrompt != null)
				{
					this.AuthenticationPrompt(this, eventArgs);
				}
				InformationResponseMessage informationResponseMessage = new InformationResponseMessage();
				foreach (string item in from r in eventArgs.Prompts
					orderby r.Id
					select r.Response)
				{
					informationResponseMessage.Responses.Add(item);
				}
				_session.SendMessage(informationResponseMessage);
			}
			catch (Exception exception)
			{
				_exception = exception;
				_authenticationCompleted.Set();
			}
		});
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

	~KeyboardInteractiveAuthenticationMethod()
	{
		Dispose(disposing: false);
	}
}
