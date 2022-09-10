public class ResetFailedException : SampleException
{
	public override string Message
	{
		get
		{
			string empty = string.Empty;
			return "Could not reset the Direct3D device.";
		}
	}
}
