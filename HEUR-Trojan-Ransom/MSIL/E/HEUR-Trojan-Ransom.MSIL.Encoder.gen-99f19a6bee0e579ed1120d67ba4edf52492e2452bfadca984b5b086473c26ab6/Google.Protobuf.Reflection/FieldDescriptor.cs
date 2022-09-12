using System;
using System.Reflection;

namespace Google.Protobuf.Reflection;

public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor>
{
	private EnumDescriptor enumType;

	private MessageDescriptor messageType;

	private FieldType fieldType;

	private readonly string propertyName;

	private IFieldAccessor accessor;

	public MessageDescriptor ContainingType { get; }

	public OneofDescriptor ContainingOneof { get; }

	public string JsonName { get; }

	internal FieldDescriptorProto Proto { get; }

	public override string Name => Proto.Name;

	public IFieldAccessor Accessor => accessor;

	public bool IsRepeated => Proto.Label == FieldDescriptorProto.Types.Label.Repeated;

	public bool IsMap
	{
		get
		{
			if (fieldType == FieldType.Message && messageType.Proto.Options != null)
			{
				return messageType.Proto.Options.MapEntry;
			}
			return false;
		}
	}

	public bool IsPacked
	{
		get
		{
			if (Proto.Options != null)
			{
				return Proto.Options.Packed;
			}
			return true;
		}
	}

	public FieldType FieldType => fieldType;

	public int FieldNumber => Proto.Number;

	public EnumDescriptor EnumType
	{
		get
		{
			if (fieldType != FieldType.Enum)
			{
				throw new InvalidOperationException("EnumType is only valid for enum fields.");
			}
			return enumType;
		}
	}

	public MessageDescriptor MessageType
	{
		get
		{
			if (fieldType != FieldType.Message)
			{
				throw new InvalidOperationException("MessageType is only valid for message fields.");
			}
			return messageType;
		}
	}

	public CustomOptions CustomOptions
	{
		get
		{
			FieldOptions options = Proto.Options;
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

	internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName)
		: base(file, file.ComputeFullName(parent, proto.Name), index)
	{
		Proto = proto;
		if (proto.Type != 0)
		{
			fieldType = GetFieldTypeFromProtoType(proto.Type);
		}
		if (FieldNumber <= 0)
		{
			throw new DescriptorValidationException(this, "Field numbers must be positive integers.");
		}
		ContainingType = parent;
		if (proto.OneofIndex != -1)
		{
			if (proto.OneofIndex < 0 || proto.OneofIndex >= parent.Proto.OneofDecl.Count)
			{
				throw new DescriptorValidationException(this, $"FieldDescriptorProto.oneof_index is out of range for type {parent.Name}");
			}
			ContainingOneof = parent.Oneofs[proto.OneofIndex];
		}
		file.DescriptorPool.AddSymbol(this);
		this.propertyName = propertyName;
		JsonName = ((Proto.JsonName == "") ? JsonFormatter.ToJsonName(Proto.Name) : Proto.JsonName);
	}

	private static FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type)
	{
		return type switch
		{
			FieldDescriptorProto.Types.Type.Double => FieldType.Double, 
			FieldDescriptorProto.Types.Type.Float => FieldType.Float, 
			FieldDescriptorProto.Types.Type.Int64 => FieldType.Int64, 
			FieldDescriptorProto.Types.Type.Uint64 => FieldType.UInt64, 
			FieldDescriptorProto.Types.Type.Int32 => FieldType.Int32, 
			FieldDescriptorProto.Types.Type.Fixed64 => FieldType.Fixed64, 
			FieldDescriptorProto.Types.Type.Fixed32 => FieldType.Fixed32, 
			FieldDescriptorProto.Types.Type.Bool => FieldType.Bool, 
			FieldDescriptorProto.Types.Type.String => FieldType.String, 
			FieldDescriptorProto.Types.Type.Group => FieldType.Group, 
			FieldDescriptorProto.Types.Type.Message => FieldType.Message, 
			FieldDescriptorProto.Types.Type.Bytes => FieldType.Bytes, 
			FieldDescriptorProto.Types.Type.Uint32 => FieldType.UInt32, 
			FieldDescriptorProto.Types.Type.Enum => FieldType.Enum, 
			FieldDescriptorProto.Types.Type.Sfixed32 => FieldType.SFixed32, 
			FieldDescriptorProto.Types.Type.Sfixed64 => FieldType.SFixed64, 
			FieldDescriptorProto.Types.Type.Sint32 => FieldType.SInt32, 
			FieldDescriptorProto.Types.Type.Sint64 => FieldType.SInt64, 
			_ => throw new ArgumentException("Invalid type specified"), 
		};
	}

	public int CompareTo(FieldDescriptor other)
	{
		if (other.ContainingType != ContainingType)
		{
			throw new ArgumentException("FieldDescriptors can only be compared to other FieldDescriptors for fields of the same message type.");
		}
		return FieldNumber - other.FieldNumber;
	}

	internal void CrossLink()
	{
		if (Proto.TypeName != "")
		{
			IDescriptor descriptor = base.File.DescriptorPool.LookupSymbol(Proto.TypeName, this);
			if (Proto.Type != 0)
			{
				if (descriptor is MessageDescriptor)
				{
					fieldType = FieldType.Message;
				}
				else
				{
					if (!(descriptor is EnumDescriptor))
					{
						throw new DescriptorValidationException(this, $"\"{Proto.TypeName}\" is not a type.");
					}
					fieldType = FieldType.Enum;
				}
			}
			if (fieldType == FieldType.Message)
			{
				if (!(descriptor is MessageDescriptor))
				{
					throw new DescriptorValidationException(this, $"\"{Proto.TypeName}\" is not a message type.");
				}
				messageType = (MessageDescriptor)descriptor;
				if (Proto.DefaultValue != "")
				{
					throw new DescriptorValidationException(this, "Messages can't have default values.");
				}
			}
			else
			{
				if (fieldType != FieldType.Enum)
				{
					throw new DescriptorValidationException(this, "Field with primitive type has type_name.");
				}
				if (!(descriptor is EnumDescriptor))
				{
					throw new DescriptorValidationException(this, $"\"{Proto.TypeName}\" is not an enum type.");
				}
				enumType = (EnumDescriptor)descriptor;
			}
		}
		else if (fieldType == FieldType.Message || fieldType == FieldType.Enum)
		{
			throw new DescriptorValidationException(this, "Field with message or enum type missing type_name.");
		}
		base.File.DescriptorPool.AddFieldByNumber(this);
		if (ContainingType != null && ContainingType.Proto.Options != null && ContainingType.Proto.Options.MessageSetWireFormat)
		{
			throw new DescriptorValidationException(this, "MessageSet format is not supported.");
		}
		accessor = CreateAccessor();
	}

	private IFieldAccessor CreateAccessor()
	{
		if (propertyName == null)
		{
			return null;
		}
		PropertyInfo property = ContainingType.ClrType.GetProperty(propertyName);
		if (property == null)
		{
			throw new DescriptorValidationException(this, $"Property {propertyName} not found in {ContainingType.ClrType}");
		}
		if (!IsMap)
		{
			if (!IsRepeated)
			{
				return new SingleFieldAccessor(property, this);
			}
			return new RepeatedFieldAccessor(property, this);
		}
		return new MapFieldAccessor(property, this);
	}
}
