using System.Collections.Generic;
using System.Linq;

namespace Google.Protobuf.Reflection;

public sealed class TypeRegistry
{
	private class Builder
	{
		private readonly Dictionary<string, MessageDescriptor> types;

		private readonly HashSet<string> fileDescriptorNames;

		internal Builder()
		{
			types = new Dictionary<string, MessageDescriptor>();
			fileDescriptorNames = new HashSet<string>();
		}

		internal void AddFile(FileDescriptor fileDescriptor)
		{
			if (!fileDescriptorNames.Add(fileDescriptor.Name))
			{
				return;
			}
			foreach (FileDescriptor dependency in fileDescriptor.Dependencies)
			{
				AddFile(dependency);
			}
			foreach (MessageDescriptor messageType in fileDescriptor.MessageTypes)
			{
				AddMessage(messageType);
			}
		}

		private void AddMessage(MessageDescriptor messageDescriptor)
		{
			foreach (MessageDescriptor nestedType in messageDescriptor.NestedTypes)
			{
				AddMessage(nestedType);
			}
			types[messageDescriptor.FullName] = messageDescriptor;
		}

		internal TypeRegistry Build()
		{
			return new TypeRegistry(types);
		}
	}

	private readonly Dictionary<string, MessageDescriptor> fullNameToMessageMap;

	public static TypeRegistry Empty { get; } = new TypeRegistry(new Dictionary<string, MessageDescriptor>());


	private TypeRegistry(Dictionary<string, MessageDescriptor> fullNameToMessageMap)
	{
		this.fullNameToMessageMap = fullNameToMessageMap;
	}

	public MessageDescriptor Find(string fullName)
	{
		fullNameToMessageMap.TryGetValue(fullName, out var value);
		return value;
	}

	public static TypeRegistry FromFiles(params FileDescriptor[] fileDescriptors)
	{
		return FromFiles((IEnumerable<FileDescriptor>)fileDescriptors);
	}

	public static TypeRegistry FromFiles(IEnumerable<FileDescriptor> fileDescriptors)
	{
		ProtoPreconditions.CheckNotNull(fileDescriptors, "fileDescriptors");
		Builder builder = new Builder();
		foreach (FileDescriptor fileDescriptor in fileDescriptors)
		{
			builder.AddFile(fileDescriptor);
		}
		return builder.Build();
	}

	public static TypeRegistry FromMessages(params MessageDescriptor[] messageDescriptors)
	{
		return FromMessages((IEnumerable<MessageDescriptor>)messageDescriptors);
	}

	public static TypeRegistry FromMessages(IEnumerable<MessageDescriptor> messageDescriptors)
	{
		ProtoPreconditions.CheckNotNull(messageDescriptors, "messageDescriptors");
		return FromFiles(messageDescriptors.Select((MessageDescriptor md) => md.File));
	}
}
