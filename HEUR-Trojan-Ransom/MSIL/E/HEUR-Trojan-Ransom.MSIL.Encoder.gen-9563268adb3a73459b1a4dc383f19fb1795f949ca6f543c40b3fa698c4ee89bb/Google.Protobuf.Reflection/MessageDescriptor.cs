using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Google.Protobuf.Reflection;

public sealed class MessageDescriptor : DescriptorBase
{
	public sealed class FieldCollection
	{
		private readonly MessageDescriptor messageDescriptor;

		public FieldDescriptor this[int number] => messageDescriptor.FindFieldByNumber(number) ?? throw new KeyNotFoundException("No such field number");

		public FieldDescriptor this[string name] => messageDescriptor.FindFieldByName(name) ?? throw new KeyNotFoundException("No such field name");

		internal FieldCollection(MessageDescriptor messageDescriptor)
		{
			this.messageDescriptor = messageDescriptor;
		}

		public IList<FieldDescriptor> InDeclarationOrder()
		{
			return messageDescriptor.fieldsInDeclarationOrder;
		}

		public IList<FieldDescriptor> InFieldNumberOrder()
		{
			return messageDescriptor.fieldsInNumberOrder;
		}

		internal IDictionary<string, FieldDescriptor> ByJsonName()
		{
			return messageDescriptor.jsonFieldMap;
		}
	}

	private static readonly HashSet<string> WellKnownTypeNames = new HashSet<string> { "google/protobuf/any.proto", "google/protobuf/api.proto", "google/protobuf/duration.proto", "google/protobuf/empty.proto", "google/protobuf/wrappers.proto", "google/protobuf/timestamp.proto", "google/protobuf/field_mask.proto", "google/protobuf/source_context.proto", "google/protobuf/struct.proto", "google/protobuf/type.proto" };

	private readonly IList<FieldDescriptor> fieldsInDeclarationOrder;

	private readonly IList<FieldDescriptor> fieldsInNumberOrder;

	private readonly IDictionary<string, FieldDescriptor> jsonFieldMap;

	public override string Name => Proto.Name;

	internal DescriptorProto Proto { get; }

	public Type ClrType { get; }

	public MessageParser Parser { get; }

	internal bool IsWellKnownType
	{
		get
		{
			if (base.File.Package == "google.protobuf")
			{
				return WellKnownTypeNames.Contains(base.File.Name);
			}
			return false;
		}
	}

	internal bool IsWrapperType
	{
		get
		{
			if (base.File.Package == "google.protobuf")
			{
				return base.File.Name == "google/protobuf/wrappers.proto";
			}
			return false;
		}
	}

	public MessageDescriptor ContainingType { get; }

	public FieldCollection Fields { get; }

	public IList<MessageDescriptor> NestedTypes { get; }

	public IList<EnumDescriptor> EnumTypes { get; }

	public IList<OneofDescriptor> Oneofs { get; }

	public CustomOptions CustomOptions
	{
		get
		{
			MessageOptions options = Proto.Options;
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

	internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo)
		: base(file, file.ComputeFullName(parent, proto.Name), typeIndex)
	{
		MessageDescriptor messageDescriptor = this;
		Proto = proto;
		Parser = generatedCodeInfo?.Parser;
		ClrType = generatedCodeInfo?.ClrType;
		ContainingType = parent;
		Oneofs = DescriptorUtil.ConvertAndMakeReadOnly(proto.OneofDecl, (OneofDescriptorProto oneof, int index) => new OneofDescriptor(oneof, file, messageDescriptor, index, generatedCodeInfo.OneofNames[index]));
		NestedTypes = DescriptorUtil.ConvertAndMakeReadOnly(proto.NestedType, (DescriptorProto type, int index) => new MessageDescriptor(type, file, messageDescriptor, index, generatedCodeInfo.NestedTypes[index]));
		EnumTypes = DescriptorUtil.ConvertAndMakeReadOnly(proto.EnumType, (EnumDescriptorProto type, int index) => new EnumDescriptor(type, file, messageDescriptor, index, generatedCodeInfo.NestedEnums[index]));
		fieldsInDeclarationOrder = DescriptorUtil.ConvertAndMakeReadOnly(proto.Field, delegate(FieldDescriptorProto field, int index)
		{
			FileDescriptor fileDescriptor = file;
			MessageDescriptor parent2 = messageDescriptor;
			GeneratedClrTypeInfo generatedClrTypeInfo = generatedCodeInfo;
			return new FieldDescriptor(field, fileDescriptor, parent2, index, (generatedClrTypeInfo != null) ? generatedClrTypeInfo.PropertyNames[index] : null);
		});
		fieldsInNumberOrder = new ReadOnlyCollection<FieldDescriptor>(fieldsInDeclarationOrder.OrderBy((FieldDescriptor field) => field.FieldNumber).ToArray());
		jsonFieldMap = CreateJsonFieldMap(fieldsInNumberOrder);
		file.DescriptorPool.AddSymbol(this);
		Fields = new FieldCollection(this);
	}

	private static ReadOnlyDictionary<string, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields)
	{
		Dictionary<string, FieldDescriptor> dictionary = new Dictionary<string, FieldDescriptor>();
		foreach (FieldDescriptor field in fields)
		{
			dictionary[field.Name] = field;
			dictionary[field.JsonName] = field;
		}
		return new ReadOnlyDictionary<string, FieldDescriptor>(dictionary);
	}

	public FieldDescriptor FindFieldByName(string name)
	{
		return base.File.DescriptorPool.FindSymbol<FieldDescriptor>(base.FullName + "." + name);
	}

	public FieldDescriptor FindFieldByNumber(int number)
	{
		return base.File.DescriptorPool.FindFieldByNumber(this, number);
	}

	public T FindDescriptor<T>(string name) where T : class, IDescriptor
	{
		return base.File.DescriptorPool.FindSymbol<T>(base.FullName + "." + name);
	}

	internal void CrossLink()
	{
		foreach (MessageDescriptor nestedType in NestedTypes)
		{
			nestedType.CrossLink();
		}
		foreach (FieldDescriptor item in fieldsInDeclarationOrder)
		{
			item.CrossLink();
		}
		foreach (OneofDescriptor oneof in Oneofs)
		{
			oneof.CrossLink();
		}
	}
}
