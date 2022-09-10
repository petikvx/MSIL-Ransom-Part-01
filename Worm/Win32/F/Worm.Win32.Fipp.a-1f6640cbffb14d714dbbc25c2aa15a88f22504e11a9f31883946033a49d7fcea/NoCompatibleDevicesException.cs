public class NoCompatibleDevicesException : SampleException
{
	public override string Message
	{
		get
		{
			string empty = string.Empty;
			empty = "This sample cannot run in a desktop\n";
			empty += "window with the current display settings.\n";
			empty += "Please change your desktop settings to a\n";
			empty += "16- or 32-bit display mode and re-run this\n";
			return empty + "sample.";
		}
	}
}
