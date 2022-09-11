using System;
using Google.Protobuf.Reflection;

namespace Google.Protobuf;

public interface IMessage<T> : IEquatable<T>, IDeepCloneable<T>, IMessage where T : IMessage<T>
{
	void MergeFrom(T message);
}
public interface IMessage
{
	MessageDescriptor Descriptor { get; }

	void MergeFrom(CodedInputStream input);

	void WriteTo(CodedOutputStream output);

	int CalculateSize();
}
