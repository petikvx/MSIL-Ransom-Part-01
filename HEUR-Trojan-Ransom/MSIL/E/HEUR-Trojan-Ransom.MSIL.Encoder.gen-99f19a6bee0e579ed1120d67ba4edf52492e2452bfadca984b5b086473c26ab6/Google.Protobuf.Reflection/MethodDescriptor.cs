namespace Google.Protobuf.Reflection;

public sealed class MethodDescriptor : DescriptorBase
{
	private readonly MethodDescriptorProto proto;

	private readonly ServiceDescriptor service;

	private MessageDescriptor inputType;

	private MessageDescriptor outputType;

	public ServiceDescriptor Service => service;

	public MessageDescriptor InputType => inputType;

	public MessageDescriptor OutputType => outputType;

	public bool IsClientStreaming => proto.ClientStreaming;

	public bool IsServerStreaming => proto.ServerStreaming;

	public CustomOptions CustomOptions
	{
		get
		{
			MethodOptions options = Proto.Options;
			object obj;
			if (options == null)
			{
				obj = null;
			}
			else
			{
				obj = options.CustomOptions;
				if (obj != null)
				{
					goto IL_0020;
				}
			}
			obj = CustomOptions.Empty;
			goto IL_0020;
			IL_0020:
			return (CustomOptions)obj;
		}
	}

	internal MethodDescriptorProto Proto => proto;

	public override string Name => proto.Name;

	internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index)
		: base(file, parent.FullName + "." + proto.Name, index)
	{
		this.proto = proto;
		service = parent;
		file.DescriptorPool.AddSymbol(this);
	}

	internal void CrossLink()
	{
		IDescriptor descriptor = base.File.DescriptorPool.LookupSymbol(Proto.InputType, this);
		if (!(descriptor is MessageDescriptor))
		{
			throw new DescriptorValidationException(this, "\"" + Proto.InputType + "\" is not a message type.");
		}
		inputType = (MessageDescriptor)descriptor;
		descriptor = base.File.DescriptorPool.LookupSymbol(Proto.OutputType, this);
		if (!(descriptor is MessageDescriptor))
		{
			throw new DescriptorValidationException(this, "\"" + Proto.OutputType + "\" is not a message type.");
		}
		outputType = (MessageDescriptor)descriptor;
	}
}
