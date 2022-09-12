using System;

namespace Renci.SshNet.Messages;

[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public sealed class MessageAttribute : Attribute
{
	public string Name { get; set; }

	public byte Number { get; set; }

	public MessageAttribute(string name, byte number)
	{
		Name = name;
		Number = number;
	}
}
