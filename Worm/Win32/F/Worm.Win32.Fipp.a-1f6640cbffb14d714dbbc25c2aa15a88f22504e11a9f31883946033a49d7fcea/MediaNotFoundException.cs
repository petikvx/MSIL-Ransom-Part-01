public class MediaNotFoundException : SampleException
{
	private string mediaFile;

	public override string Message
	{
		get
		{
			string empty = string.Empty;
			empty = "Could not load required media.";
			if (mediaFile.Length > 0)
			{
				empty += $"\r\nFile: {mediaFile}";
			}
			return empty;
		}
	}

	public MediaNotFoundException(string filename)
	{
		mediaFile = filename;
	}

	public MediaNotFoundException()
	{
		mediaFile = string.Empty;
	}
}
