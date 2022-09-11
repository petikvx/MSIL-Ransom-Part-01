using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

public sealed class MethodDescriptor : DescriptorBase
{
	private readonly MethodDescriptorProto proto;

	private readonly ServiceDescriptor service;

	private MessageDescriptor inputType;

	private MessageDescriptor outputType;

	[NonSerialized]
	internal static GetString getString_1;

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
		: base(file, parent.FullName + getString_1(107400308) + proto.Name, index)
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
			throw new DescriptorValidationException(this, getString_1(107411417) + Proto.InputType + getString_1(107472475));
		}
		inputType = (MessageDescriptor)descriptor;
		descriptor = base.File.DescriptorPool.LookupSymbol(Proto.OutputType, this);
		if (!(descriptor is MessageDescriptor))
		{
			throw new DescriptorValidationException(this, getString_1(107411417) + Proto.OutputType + getString_1(107472475));
		}
		outputType = (MessageDescriptor)descriptor;
	}

	static MethodDescriptor()
	{
		Strings.CreateGetStringDelegate(typeof(MethodDescriptor));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107400711), getString_1(107400706)).Replace(getString_1(107400669), getString_1(107400664)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107400659)))
		{
			throw new SecurityException(getString_1(107400634));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
