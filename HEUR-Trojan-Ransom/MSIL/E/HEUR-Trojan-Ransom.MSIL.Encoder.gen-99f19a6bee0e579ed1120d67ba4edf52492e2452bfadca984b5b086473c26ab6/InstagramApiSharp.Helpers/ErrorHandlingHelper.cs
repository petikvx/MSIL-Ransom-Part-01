using System;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;

namespace InstagramApiSharp.Helpers;

internal static class ErrorHandlingHelper
{
	internal static BadStatusResponse GetBadStatusFromJsonString(string json)
	{
		BadStatusResponse badStatusResponse = new BadStatusResponse();
		try
		{
			if (json == "Oops, an error occurred\n")
			{
				badStatusResponse.Message = json;
				return badStatusResponse;
			}
			badStatusResponse = JsonConvert.DeserializeObject<BadStatusResponse>(json);
			return badStatusResponse;
		}
		catch (Exception ex)
		{
			badStatusResponse.Message = ex.Message;
			return badStatusResponse;
		}
	}
}
