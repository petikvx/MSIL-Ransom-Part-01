using System;

namespace NAudio.Utils;

[AttributeUsage(AttributeTargets.Field)]
public sealed class FieldDescriptionAttribute : Attribute
{
	public string Description { get; private set; }

	public FieldDescriptionAttribute(string description)
	{
		Description = description;
	}

	public override string ToString()
	{
		return Description;
	}
}
