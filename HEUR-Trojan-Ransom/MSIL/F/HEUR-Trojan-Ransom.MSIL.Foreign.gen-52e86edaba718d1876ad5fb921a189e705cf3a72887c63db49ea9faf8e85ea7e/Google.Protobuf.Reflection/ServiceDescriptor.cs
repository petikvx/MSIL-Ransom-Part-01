using System;
using System.Collections.Generic;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

public sealed class ServiceDescriptor : DescriptorBase
{
	private readonly ServiceDescriptorProto proto;

	private readonly IList<MethodDescriptor> methods;

	[NonSerialized]
	internal static GetString getString_1;

	public override string Name => proto.Name;

	internal ServiceDescriptorProto Proto => proto;

	public IList<MethodDescriptor> Methods => methods;

	public CustomOptions CustomOptions
	{
		get
		{
			ServiceOptions options = Proto.Options;
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

	internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index)
		: base(file, file.ComputeFullName(null, proto.Name), index)
	{
		ServiceDescriptor parent = this;
		this.proto = proto;
		methods = DescriptorUtil.ConvertAndMakeReadOnly(proto.Method, (MethodDescriptorProto method, int i) => new MethodDescriptor(method, file, parent, i));
		file.DescriptorPool.AddSymbol(this);
	}

	public MethodDescriptor FindMethodByName(string name)
	{
		return base.File.DescriptorPool.FindSymbol<MethodDescriptor>(base.FullName + getString_1(107400330) + name);
	}

	internal void CrossLink()
	{
		foreach (MethodDescriptor method in methods)
		{
			method.CrossLink();
		}
	}

	static ServiceDescriptor()
	{
		Strings.CreateGetStringDelegate(typeof(ServiceDescriptor));
	}
}
