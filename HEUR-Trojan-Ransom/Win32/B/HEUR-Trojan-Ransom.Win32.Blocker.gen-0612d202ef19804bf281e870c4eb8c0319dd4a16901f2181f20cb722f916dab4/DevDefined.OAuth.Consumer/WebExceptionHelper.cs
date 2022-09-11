using System;
using System.Net;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Utility;

namespace DevDefined.OAuth.Consumer;

public static class WebExceptionHelper
{
	public static bool TryWrapException(IOAuthContext requestContext, WebException webEx, out OAuthException authException, Action<string> responseBodyAction)
	{
		try
		{
			string text = webEx.Response.ReadToEnd();
			responseBodyAction?.Invoke(text);
			if (text.Contains("oauth_problem"))
			{
				OAuthProblemReport oAuthProblemReport = new OAuthProblemReport(text);
				authException = new OAuthException(oAuthProblemReport.ProblemAdvice ?? oAuthProblemReport.Problem, webEx)
				{
					Context = requestContext,
					Report = oAuthProblemReport
				};
				return true;
			}
		}
		catch
		{
		}
		authException = new OAuthException();
		return false;
	}
}
