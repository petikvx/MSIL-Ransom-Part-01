using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Google.Protobuf.Reflection;

public sealed class OneofDescriptor : DescriptorBase
{
	private readonly OneofDescriptorProto proto;

	private MessageDescriptor containingType;

	private IList<FieldDescriptor> fields;

	private readonly OneofAccessor accessor;

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
		PropertyInfo? property = containingType.ClrType.GetProperty(clrName + "Case");
		if (property == null)
		{
			throw new DescriptorValidationException(this, $"Property {clrName}Case not found in {containingType.ClrType}");
		}
		MethodInfo method = containingType.ClrType.GetMethod("Clear" + clrName);
		if (method == null)
		{
			throw new DescriptorValidationException(this, $"Method Clear{clrName} not found in {containingType.ClrType}");
		}
		return new OneofAccessor(property, method, this);
	}
}
