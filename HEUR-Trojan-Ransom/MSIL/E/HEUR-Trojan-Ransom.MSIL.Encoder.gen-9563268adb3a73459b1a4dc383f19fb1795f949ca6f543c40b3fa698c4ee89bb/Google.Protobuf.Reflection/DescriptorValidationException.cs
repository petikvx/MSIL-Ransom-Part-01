using System;

namespace Google.Protobuf.Reflection;

public sealed class DescriptorValidationException : Exception
{
	private readonly string name;

	private readonly string description;

	public string ProblemSymbolName => name;

	public string Description => description;

	internal DescriptorValidationException(IDescriptor problemDescriptor, string description)
		: base(problemDescriptor.FullName + ": " + description)
	{
		name = problemDescriptor.FullName;
		this.description = description;
	}

	internal DescriptorValidationException(IDescriptor problemDescriptor, string description, Exception cause)
		: base(problemDescriptor.FullName + ": " + description, cause)
	{
		name = problemDescriptor.FullName;
		this.description = description;
	}
}
