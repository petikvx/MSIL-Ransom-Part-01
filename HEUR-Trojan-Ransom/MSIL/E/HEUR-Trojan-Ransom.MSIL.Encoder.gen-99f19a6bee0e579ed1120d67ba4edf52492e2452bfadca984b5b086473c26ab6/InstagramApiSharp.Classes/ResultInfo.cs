using System;
using System.Text.RegularExpressions;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Classes;

public class ResultInfo
{
	public Exception Exception { get; }

	public string Message { get; }

	public ResponseType ResponseType { get; }

	public bool Timeout { get; internal set; }

	public bool NeedsChallenge { get; internal set; }

	public DateTime? ActionBlockEnd { get; internal set; }

	public InstaChallengeLoginInfo Challenge { get; internal set; }

	public ResultInfo(string message)
	{
		Message = message;
		HandleMessages(message);
	}

	public ResultInfo(Exception exception)
	{
		Exception = exception;
		Message = exception?.Message;
		ResponseType = ResponseType.InternalException;
		HandleMessages(Message);
	}

	public ResultInfo(Exception exception, ResponseType responseType)
	{
		Exception = exception;
		Message = exception?.Message;
		ResponseType = responseType;
		HandleMessages(Message);
	}

	public ResultInfo(ResponseType responseType, string errorMessage)
	{
		ResponseType = responseType;
		Message = errorMessage;
		HandleMessages(errorMessage);
	}

	public ResultInfo(ResponseType responseType, BadStatusResponse status)
	{
		Message = status?.Message;
		Challenge = status?.Challenge;
		ResponseType = responseType;
		HandleMessages(Message);
		ResponseType responseType2 = ResponseType;
		if ((uint)(responseType2 - 13) <= 1u)
		{
			if (status != null && !string.IsNullOrEmpty(status.FeedbackMessage) && status.FeedbackMessage.ToLower().Contains("this block will expire on"))
			{
				if (DateTime.TryParse(new Regex("(\\d+)[-.\\/](\\d+)[-.\\/](\\d+)").Match(status.FeedbackMessage).ToString(), out var result))
				{
					ActionBlockEnd = result;
				}
			}
			else
			{
				ActionBlockEnd = null;
			}
		}
		else
		{
			ActionBlockEnd = null;
		}
	}

	public void HandleMessages(string errorMessage)
	{
		if (errorMessage.Contains("task was canceled"))
		{
			Timeout = true;
		}
		if (errorMessage.ToLower().Contains("challenge"))
		{
			NeedsChallenge = true;
		}
	}

	public override string ToString()
	{
		return ResponseType.ToString() + ": " + Message + ".";
	}
}
