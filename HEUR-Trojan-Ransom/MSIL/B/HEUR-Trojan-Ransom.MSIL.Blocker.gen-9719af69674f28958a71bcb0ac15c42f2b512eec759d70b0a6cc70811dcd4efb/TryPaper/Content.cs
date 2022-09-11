using System;

namespace TryPaper;

public class Content : IContent
{
	public string Data { get; set; }

	public static Content FromUrl(string url)
	{
		Content content = new Content();
		content.Data = url;
		return content;
	}

	public static Content FromByteArray(byte[] data)
	{
		Content content = new Content();
		content.Data = Convert.ToBase64String(data);
		return content;
	}

	public static Content FromPageReferences(params int[] pages)
	{
		string data = string.Format(strings.PageUriFormat, string.Join(",", pages));
		Content content = new Content();
		content.Data = data;
		return content;
	}
}
