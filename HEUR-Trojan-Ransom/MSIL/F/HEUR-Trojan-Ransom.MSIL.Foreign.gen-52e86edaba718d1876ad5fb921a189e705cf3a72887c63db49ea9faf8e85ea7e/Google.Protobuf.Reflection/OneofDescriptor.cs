using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

public sealed class OneofDescriptor : DescriptorBase
{
	private readonly OneofDescriptorProto proto;

	private MessageDescriptor containingType;

	private IList<FieldDescriptor> fields;

	private readonly OneofAccessor accessor;

	[NonSerialized]
	internal static GetString getString_1;

	public override string Name => proto.Name;

	public MessageDescriptor ContainingType => containingType;

	public IList<FieldDescriptor> Fields => fields;

	public OneofAccessor Accessor => accessor;

	public CustomOptions CustomOptions
	{
		get
		{
			OneofOptions options = proto.Options;
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

	internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName)
		: base(file, file.ComputeFullName(parent, proto.Name), index)
	{
		this.proto = proto;
		containingType = parent;
		file.DescriptorPool.AddSymbol(this);
		accessor = CreateAccessor(clrName);
	}

	internal void CrossLink()
	{
		List<FieldDescriptor> list = new List<FieldDescriptor>();
		foreach (FieldDescriptor item in ContainingType.Fields.InDeclarationOrder())
		{
			if (item.ContainingOneof == this)
			{
				list.Add(item);
			}
		}
		fields = new ReadOnlyCollection<FieldDescriptor>(list);
	}

	private OneofAccessor CreateAccessor(string clrName)
	{
		PropertyInfo? property = containingType.ClrType.GetProperty(clrName + getString_1(107471902));
		if (property == null)
		{
			throw new DescriptorValidationException(this, string.Format(getString_1(107471925), clrName, containingType.ClrType));
		}
		MethodInfo method = containingType.ClrType.GetMethod(getString_1(107471848) + clrName);
		if (method == null)
		{
			throw new DescriptorValidationException(this, string.Format(getString_1(107471839), clrName, containingType.ClrType));
		}
		return new OneofAccessor(property, method, this);
	}

	static OneofDescriptor()
	{
		Strings.CreateGetStringDelegate(typeof(OneofDescriptor));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107400720), getString_1(107400715)).Replace(getString_1(107400678), getString_1(107400673)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107400668)))
		{
			throw new SecurityException(getString_1(107400643));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
