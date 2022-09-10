using System;

namespace Wrox.ProCSharp.Collections;

[Serializable]
public class Document
{
	private string title;

	private string content;

	public string Title => title;

	public string Content => content;

	public Document(string title, string content)
	{
		this.title = title;
		this.content = content;
	}
}
