using System;
using DevDefined.OAuth.Provider;

namespace DevDefined.OAuth.Framework;

public class AccessDeniedException : Exception
{
	private readonly AccessOutcome _outcome;

	public AccessOutcome Outcome => _outcome;

	public AccessDeniedException(AccessOutcome outcome)
		: this(outcome, null)
	{
	}

	public AccessDeniedException(AccessOutcome outcome, string message)
		: base(message)
	{
		_outcome = outcome;
	}
}
