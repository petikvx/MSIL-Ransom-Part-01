using System;
using System.Collections.Generic;
using Renci.SshNet.Common;

namespace Renci.SshNet;

internal class ClientAuthentication : IClientAuthentication
{
	private class AuthenticationState
	{
		private readonly IList<IAuthenticationMethod> _supportedAuthenticationMethods;

		private readonly Dictionary<IAuthenticationMethod, int> _authenticationMethodPartialSuccessRegister;

		private readonly List<IAuthenticationMethod> _failedAuthenticationMethods;

		public AuthenticationState(IList<IAuthenticationMethod> supportedAuthenticationMethods)
		{
			_supportedAuthenticationMethods = supportedAuthenticationMethods;
			_failedAuthenticationMethods = new List<IAuthenticationMethod>();
			_authenticationMethodPartialSuccessRegister = new Dictionary<IAuthenticationMethod, int>();
		}

		public void RecordFailure(IAuthenticationMethod authenticationMethod)
		{
			_failedAuthenticationMethods.Add(authenticationMethod);
		}

		public void RecordPartialSuccess(IAuthenticationMethod authenticationMethod)
		{
			if (_authenticationMethodPartialSuccessRegister.TryGetValue(authenticationMethod, out var value))
			{
				value = (_authenticationMethodPartialSuccessRegister[authenticationMethod] = value + 1);
			}
			else
			{
				_authenticationMethodPartialSuccessRegister.Add(authenticationMethod, 1);
			}
		}

		public int GetPartialSuccessCount(IAuthenticationMethod authenticationMethod)
		{
			if (_authenticationMethodPartialSuccessRegister.TryGetValue(authenticationMethod, out var value))
			{
				return value;
			}
			return 0;
		}

		public List<IAuthenticationMethod> GetSupportedAuthenticationMethods(string[] allowedAuthenticationMethods)
		{
			List<IAuthenticationMethod> list = new List<IAuthenticationMethod>();
			foreach (IAuthenticationMethod supportedAuthenticationMethod in _supportedAuthenticationMethods)
			{
				string name = supportedAuthenticationMethod.Name;
				for (int i = 0; i < allowedAuthenticationMethods.Length; i++)
				{
					if (allowedAuthenticationMethods[i] == name)
					{
						list.Add(supportedAuthenticationMethod);
						break;
					}
				}
			}
			return list;
		}

		public IEnumerable<IAuthenticationMethod> GetActiveAuthenticationMethods(List<IAuthenticationMethod> matchingAuthenticationMethods)
		{
			List<IAuthenticationMethod> skippedAuthenticationMethods = new List<IAuthenticationMethod>();
			for (int i = 0; i < matchingAuthenticationMethods.Count; i++)
			{
				IAuthenticationMethod authenticationMethod = matchingAuthenticationMethods[i];
				if (!_failedAuthenticationMethods.Contains(authenticationMethod))
				{
					if (_authenticationMethodPartialSuccessRegister.ContainsKey(authenticationMethod))
					{
						skippedAuthenticationMethods.Add(authenticationMethod);
					}
					else
					{
						yield return authenticationMethod;
					}
				}
			}
			foreach (IAuthenticationMethod item in skippedAuthenticationMethods)
			{
				yield return item;
			}
		}
	}

	private readonly int _partialSuccessLimit;

	internal int PartialSuccessLimit => _partialSuccessLimit;

	public ClientAuthentication(int partialSuccessLimit)
	{
		if (partialSuccessLimit < 1)
		{
			throw new ArgumentOutOfRangeException("partialSuccessLimit", "Cannot be less than one.");
		}
		_partialSuccessLimit = partialSuccessLimit;
	}

	public void Authenticate(IConnectionInfoInternal connectionInfo, ISession session)
	{
		if (connectionInfo == null)
		{
			throw new ArgumentNullException("connectionInfo");
		}
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		session.RegisterMessage("SSH_MSG_USERAUTH_FAILURE");
		session.RegisterMessage("SSH_MSG_USERAUTH_SUCCESS");
		session.RegisterMessage("SSH_MSG_USERAUTH_BANNER");
		session.UserAuthenticationBannerReceived += connectionInfo.UserAuthenticationBannerReceived;
		try
		{
			SshAuthenticationException authenticationException = null;
			IAuthenticationMethod authenticationMethod = connectionInfo.CreateNoneAuthenticationMethod();
			if (authenticationMethod.Authenticate(session) != 0 && !TryAuthenticate(session, new AuthenticationState(connectionInfo.AuthenticationMethods), authenticationMethod.AllowedAuthentications, ref authenticationException))
			{
				throw authenticationException;
			}
		}
		finally
		{
			session.UserAuthenticationBannerReceived -= connectionInfo.UserAuthenticationBannerReceived;
			session.UnRegisterMessage("SSH_MSG_USERAUTH_FAILURE");
			session.UnRegisterMessage("SSH_MSG_USERAUTH_SUCCESS");
			session.UnRegisterMessage("SSH_MSG_USERAUTH_BANNER");
		}
	}

	private bool TryAuthenticate(ISession session, AuthenticationState authenticationState, string[] allowedAuthenticationMethods, ref SshAuthenticationException authenticationException)
	{
		if (allowedAuthenticationMethods.Length == 0)
		{
			authenticationException = new SshAuthenticationException("No authentication methods defined on SSH server.");
			return false;
		}
		List<IAuthenticationMethod> supportedAuthenticationMethods = authenticationState.GetSupportedAuthenticationMethods(allowedAuthenticationMethods);
		if (supportedAuthenticationMethods.Count == 0)
		{
			authenticationException = new SshAuthenticationException(string.Format("No suitable authentication method found to complete authentication ({0}).", string.Join(",", allowedAuthenticationMethods)));
			return false;
		}
		foreach (IAuthenticationMethod activeAuthenticationMethod in authenticationState.GetActiveAuthenticationMethods(supportedAuthenticationMethods))
		{
			if (authenticationState.GetPartialSuccessCount(activeAuthenticationMethod) >= _partialSuccessLimit)
			{
				authenticationException = new SshAuthenticationException($"Reached authentication attempt limit for method ({activeAuthenticationMethod.Name}).");
				continue;
			}
			AuthenticationResult authenticationResult = activeAuthenticationMethod.Authenticate(session);
			switch (authenticationResult)
			{
			case AuthenticationResult.Success:
				authenticationException = null;
				break;
			case AuthenticationResult.PartialSuccess:
				authenticationState.RecordPartialSuccess(activeAuthenticationMethod);
				if (TryAuthenticate(session, authenticationState, activeAuthenticationMethod.AllowedAuthentications, ref authenticationException))
				{
					authenticationResult = AuthenticationResult.Success;
				}
				break;
			case AuthenticationResult.Failure:
				authenticationState.RecordFailure(activeAuthenticationMethod);
				authenticationException = new SshAuthenticationException($"Permission denied ({activeAuthenticationMethod.Name}).");
				break;
			}
			if (authenticationResult != 0)
			{
				continue;
			}
			return true;
		}
		return false;
	}
}
