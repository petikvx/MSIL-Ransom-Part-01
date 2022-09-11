using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

public sealed class EnumValueDescriptor : DescriptorBase
{
	private readonly EnumDescriptor enumDescriptor;

	private readonly EnumValueDescriptorProto proto;

	[NonSerialized]
	internal static GetString getString_1;

	internal EnumValueDescriptorProto Proto => proto;

	public override string Name => proto.Name;

	public int Number => Proto.Number;

	public EnumDescriptor EnumDescriptor => enumDescriptor;

	public CustomOptions CustomOptions
	{
		get
		{
			EnumValueOptions options = Proto.Options;
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

	internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index)
		: base(file, parent.FullName + getString_1(107400231) + proto.Name, index)
	{
		this.proto = proto;
		enumDescriptor = parent;
		file.DescriptorPool.AddSymbol(this);
		file.DescriptorPool.AddEnumValueByNumber(this);
	}

	static EnumValueDescriptor()
	{
		Strings.CreateGetStringDelegate(typeof(EnumValueDescriptor));
	}
}
