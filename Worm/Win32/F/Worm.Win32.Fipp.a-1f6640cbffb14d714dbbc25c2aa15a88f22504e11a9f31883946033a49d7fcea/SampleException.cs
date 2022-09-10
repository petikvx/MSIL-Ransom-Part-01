using System;

public class SampleException : ApplicationException
{
	public override string Message
	{
		get
		{
			string empty = string.Empty;
			empty = "Generic application error. Enable\n";
			return empty + "debug output for detailed information.";
		}
	}
}
