using System;
using System.Runtime.Serialization;

namespace DevDefined.OAuth.Framework;

public class OAuthException : Exception
{
	public OAuthProblemReport Report { get; set; }

	public IOAuthContext Context { get; set; }

	public OAuthException()
	{
	}

	public OAuthException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public OAuthException(IOAuthContext context, string problem, string advice)
		: base(advice)
	{
		Context = context;
		Report = new OAuthProblemReport
		{
			Problem = problem,
			ProblemAdvice = advice
		};
	}

	public OAuthException(IOAuthContext context, string problem, string advice, Exception innerException)
		: base(advice, innerException)
	{
		Context = context;
		Report = new OAuthProblemReport
		{
			Problem = problem,
			ProblemAdvice = advice
		};
	}

	public OAuthException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
