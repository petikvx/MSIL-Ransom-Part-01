using System;
using System.Net.Http;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Classes;

public class Result<T> : IResult<T>
{
	public bool Succeeded { get; }

	public T Value { get; }

	public ResultInfo Info { get; } = new ResultInfo("");


	public Result(bool succeeded, T value, ResultInfo info)
	{
		Succeeded = succeeded;
		Value = value;
		Info = info;
	}

	public Result(bool succeeded, ResultInfo info)
	{
		Succeeded = succeeded;
		Info = info;
	}

	public Result(bool succeeded, T value)
	{
		Succeeded = succeeded;
		Value = value;
	}
}
public static class Result
{
	public static IResult<T> Success<T>(T resValue)
	{
		return new Result<T>(succeeded: true, resValue, new ResultInfo(ResponseType.OK, "No errors detected"));
	}

	public static IResult<T> Success<T>(string successMsg, T resValue)
	{
		return new Result<T>(succeeded: true, resValue, new ResultInfo(ResponseType.OK, successMsg));
	}

	public static IResult<T> Fail<T>(Exception exception)
	{
		return new Result<T>(succeeded: false, default(T), new ResultInfo(exception));
	}

	public static IResult<T> Fail<T>(string errMsg)
	{
		return new Result<T>(succeeded: false, default(T), new ResultInfo(errMsg));
	}

	public static IResult<T> Fail<T>(string errMsg, T resValue)
	{
		return new Result<T>(succeeded: false, resValue, new ResultInfo(errMsg));
	}

	public static IResult<T> Fail<T>(Exception exception, T resValue)
	{
		return new Result<T>(succeeded: false, resValue, new ResultInfo(exception));
	}

	public static IResult<T> Fail<T>(Exception exception, T resValue, ResponseType responseType)
	{
		return new Result<T>(succeeded: false, resValue, new ResultInfo(exception, responseType));
	}

	public static IResult<T> Fail<T>(ResultInfo info, T resValue)
	{
		return new Result<T>(succeeded: false, resValue, info);
	}

	public static IResult<T> Fail<T>(string errMsg, ResponseType responseType, T resValue)
	{
		return new Result<T>(succeeded: false, resValue, new ResultInfo(responseType, errMsg));
	}

	public static IResult<T> UnExpectedResponse<T>(HttpResponseMessage response, string json)
	{
		if (string.IsNullOrEmpty(json))
		{
			ResultInfo info = new ResultInfo(ResponseType.UnExpectedResponse, $"Unexpected response status: {response.StatusCode}");
			return new Result<T>(succeeded: false, default(T), info);
		}
		BadStatusResponse badStatusFromJsonString = ErrorHandlingHelper.GetBadStatusFromJsonString(json);
		ResultInfo info2 = new ResultInfo(GetResponseType(badStatusFromJsonString), badStatusFromJsonString)
		{
			Challenge = badStatusFromJsonString.Challenge
		};
		return new Result<T>(succeeded: false, default(T), info2);
	}

	public static IResult<T> UnExpectedResponse<T>(HttpResponseMessage response, string message, string json)
	{
		if (string.IsNullOrEmpty(json))
		{
			ResultInfo info = new ResultInfo(ResponseType.UnExpectedResponse, $"{message}\r\nUnexpected response status: {response.StatusCode}");
			return new Result<T>(succeeded: false, default(T), info);
		}
		BadStatusResponse badStatusFromJsonString = ErrorHandlingHelper.GetBadStatusFromJsonString(json);
		ResultInfo info2 = new ResultInfo(GetResponseType(badStatusFromJsonString), message)
		{
			Challenge = badStatusFromJsonString.Challenge
		};
		return new Result<T>(succeeded: false, default(T), info2);
	}

	private static ResponseType GetResponseType(BadStatusResponse status)
	{
		ResponseType result = ResponseType.UnExpectedResponse;
		if (!string.IsNullOrWhiteSpace(status.ErrorType))
		{
			switch (status.ErrorType)
			{
			case "checkpoint_challenge_required":
				result = ResponseType.ChallengeRequired;
				break;
			case "Sorry, too many requests.Please try again later":
				result = ResponseType.RequestsLimit;
				break;
			case "login_required":
				result = ResponseType.LoginRequired;
				break;
			case "sentry_block":
				result = ResponseType.SentryBlock;
				break;
			case "checkpoint_logged_out":
				result = ResponseType.CheckPointRequired;
				break;
			case "inactive user":
			case "inactive_user":
				result = ResponseType.InactiveUser;
				break;
			}
		}
		if (!status.IsOk() && status.Message.Contains("wait a few minutes"))
		{
			result = ResponseType.RequestsLimit;
		}
		if (!string.IsNullOrEmpty(status.Message) && status.Message.Contains("consent_required"))
		{
			result = ResponseType.ConsentRequired;
		}
		if (!string.IsNullOrEmpty(status.FeedbackTitle) && status.FeedbackTitle.ToLower().Contains("action blocked"))
		{
			result = ResponseType.ActionBlocked;
		}
		if (!string.IsNullOrEmpty(status.Message) && status.Message.Contains("login_required"))
		{
			result = ResponseType.LoginRequired;
		}
		if (!string.IsNullOrEmpty(status.Message) && status.Message.ToLower().Contains("media not found or unavailable"))
		{
			result = ResponseType.MediaNotFound;
		}
		if (!string.IsNullOrEmpty(status.FeedbackTitle) && status.FeedbackTitle.ToLower().Contains("commenting is Off"))
		{
			result = ResponseType.CommentingIsDisabled;
		}
		if (!string.IsNullOrEmpty(status.Message) && status.Message.ToLower().Contains("already liked"))
		{
			result = ResponseType.AlreadyLiked;
		}
		if (!string.IsNullOrEmpty(status.FeedbackMessage) && status.FeedbackMessage.ToLower().Contains("post you were viewing has been deleted"))
		{
			result = ResponseType.DeletedPost;
		}
		if (!string.IsNullOrEmpty(status.Message) && status.Message.ToLower().Contains("you cannot like this"))
		{
			result = ResponseType.CantLike;
		}
		if (status.Payload != null && !string.IsNullOrEmpty(status.Payload.Message) && status.Payload.Message.ToLower().Contains("media is not accessible"))
		{
			result = ResponseType.DeletedPost;
		}
		if (status.Spam)
		{
			result = ResponseType.Spam;
		}
		if (status == null || status.Message?.IndexOf("challenge_required") != -1)
		{
			result = ResponseType.ChallengeRequired;
		}
		return result;
	}
}
