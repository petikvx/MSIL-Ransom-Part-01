namespace adclicker;

internal struct AVBlockInfo
{
	public string windowCaptionMask;

	public string processNameMask;

	public AVBlockInfo(string captionMask, string processMask)
	{
		windowCaptionMask = captionMask;
		processNameMask = processMask;
	}

	public override string ToString()
	{
		string arg = ((windowCaptionMask == null) ? "null" : windowCaptionMask);
		return $"(\"{arg}\", \"{processNameMask}\")";
	}
}
