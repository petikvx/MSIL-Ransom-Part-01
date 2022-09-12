using System;

namespace InstagramApiSharp.Helpers;

internal static class WebHelper
{
	private const string StartTag = "type=\"text/javascript\">window._sharedData";

	private const string EndTag = ";</script>";

	public static bool CanReadJson(this string html)
	{
		return html.Contains("type=\"text/javascript\">window._sharedData");
	}

	public static string GetJson(this string html)
	{
		try
		{
			if (html.CanReadJson())
			{
				string text = html.Substring(html.IndexOf("type=\"text/javascript\">window._sharedData") + "type=\"text/javascript\">window._sharedData".Length);
				text = text.Substring(0, text.IndexOf(";</script>"));
				return text.Substring(text.IndexOf("=") + 2);
			}
		}
		catch (Exception ex)
		{
			("WebHelper.GetJson ex: " + ex.Message + "\r\nSource: " + ex.Source + "\r\nTrace: " + ex.StackTrace).PrintInDebug();
		}
		return null;
	}
}
