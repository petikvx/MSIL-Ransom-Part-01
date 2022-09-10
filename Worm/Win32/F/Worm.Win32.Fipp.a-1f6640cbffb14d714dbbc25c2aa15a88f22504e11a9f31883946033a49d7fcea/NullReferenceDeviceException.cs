public class NullReferenceDeviceException : SampleException
{
	public override string Message
	{
		get
		{
			string empty = string.Empty;
			empty = "Warning: Nothing will be rendered.\n";
			empty += "The reference rendering device was selected, but your\n";
			empty += "computer only has a reduced-functionality reference device\n";
			empty += "installed.  Install the DirectX SDK to get the full\n";
			return empty + "reference device.\n";
		}
	}
}
