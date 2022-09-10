using System;

namespace CoreLab.Common.Setup;

internal class CustomActionException : Exception
{
	private readonly string hypothesis;

	public string Hypothesis => hypothesis;

	public CustomActionException(Exception ex, string hypothesis)
		: base((ex == null) ? string.Empty : ex.Message, ex)
	{
		this.hypothesis = hypothesis;
	}
}
