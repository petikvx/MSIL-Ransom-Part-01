using System;
using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Provider.Inspectors;

public class XAuthValidationInspector : IContextInspector
{
	private readonly Func<string, bool> _validateModeFunc;

	private readonly Func<string, string, bool> _authenticateFunc;

	public XAuthValidationInspector(Func<string, bool> validateModeFunc, Func<string, string, bool> authenticateFunc)
	{
		_validateModeFunc = validateModeFunc;
		_authenticateFunc = authenticateFunc;
	}

	public void InspectContext(ProviderPhase phase, IOAuthContext context)
	{
		if (phase == ProviderPhase.CreateAccessToken)
		{
			string xAuthMode = context.XAuthMode;
			if (string.IsNullOrEmpty(xAuthMode))
			{
				throw Error.EmptyXAuthMode(context);
			}
			if (!_validateModeFunc(xAuthMode))
			{
				throw Error.InvalidXAuthMode(context);
			}
			string xAuthUsername = context.XAuthUsername;
			if (string.IsNullOrEmpty(xAuthUsername))
			{
				throw Error.EmptyXAuthUsername(context);
			}
			string xAuthPassword = context.XAuthPassword;
			if (string.IsNullOrEmpty(xAuthPassword))
			{
				throw Error.EmptyXAuthPassword(context);
			}
			if (!_authenticateFunc(xAuthUsername, xAuthPassword))
			{
				throw Error.FailedXAuthAuthentication(context);
			}
		}
	}
}
