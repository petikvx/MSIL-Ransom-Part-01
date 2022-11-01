using System;

namespace AForge.Video;

public class VideoSourceErrorEventArgs : EventArgs
{
	private string description;

	public string Description => description;

	public VideoSourceErrorEventArgs(string description)
	{
		this.description = description;
	}
}
