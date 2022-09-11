using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Expr;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns2;

namespace Mysqlx.Crud;

internal sealed class UpdateOperation : IMessage, IMessage<UpdateOperation>, IEquatable<UpdateOperation>, IDeepCloneable<UpdateOperation>
{
	[DebuggerNonUserCode]
	internal static class Class34
	{
		internal enum Enum20
		{
			[OriginalName("NONE_UpdateType")]
			const_0,
			[OriginalName("SET")]
			const_1,
			[OriginalName("ITEM_REMOVE")]
			const_2,
			[OriginalName("ITEM_SET")]
			const_3,
			[OriginalName("ITEM_REPLACE")]
			const_4,
			[OriginalName("ITEM_MERGE")]
			const_5,
			[OriginalName("ARRAY_INSERT")]
			const_6,
			[OriginalName("ARRAY_APPEND")]
			const_7,
			[OriginalName("MERGE_PATCH")]
			const_8
		}
	}

	private static readonly MessageParser<UpdateOperation> messageParser_0;

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private ColumnIdentifier columnIdentifier_0;

	public const int int_1 = 2;

	private Class34.Enum20 enum20_0;

	public const int int_2 = 3;

	private Mysqlx.Expr.Expr expr_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<UpdateOperation> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class32.Descriptor.MessageTypes[5];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public ColumnIdentifier Source
	{
		get
		{
			return columnIdentifier_0;
		}
		set
		{
			columnIdentifier_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Class34.Enum20 Operation
	{
		get
		{
			return enum20_0;
		}
		set
		{
			enum20_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr Value
	{
		get
		{
			return expr_0;
		}
		set
		{
			expr_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public UpdateOperation()
	{
	}

	[DebuggerNonUserCode]
	public UpdateOperation(UpdateOperation other)
		: this()
	{
		Source = ((other.columnIdentifier_0 != null) ? other.Source.Clone() : null);
		enum20_0 = other.enum20_0;
		Value = ((other.expr_0 != null) ? other.Value.Clone() : null);
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public UpdateOperation Clone()
	{
		return new UpdateOperation(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<UpdateOperation>)this).Equals(obj as UpdateOperation);
	}

	[DebuggerNonUserCode]
	bool IEquatable<UpdateOperation>.Equals(UpdateOperation other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Source, other.Source))
		{
			return false;
		}
		if (Operation != other.Operation)
		{
			return false;
		}
		if (!object.Equals(Value, other.Value))
		{
			return false;
		}
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (columnIdentifier_0 != null)
		{
			num ^= Source.GetHashCode();
		}
		if (Operation != 0)
		{
			num ^= Operation.GetHashCode();
		}
		if (expr_0 != null)
		{
			num ^= Value.GetHashCode();
		}
		if (unknownFieldSet_0 != null)
		{
			num ^= unknownFieldSet_0.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	string object.ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		if (columnIdentifier_0 != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Source);
		}
		if (Operation != 0)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Operation);
		}
		if (expr_0 != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Value);
		}
		if (unknownFieldSet_0 != null)
		{
			unknownFieldSet_0.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (columnIdentifier_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Source);
		}
		if (Operation != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Operation);
		}
		if (expr_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Value);
		}
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(UpdateOperation other)
	{
		if (other == null)
		{
			return;
		}
		if (other.columnIdentifier_0 != null)
		{
			if (columnIdentifier_0 == null)
			{
				columnIdentifier_0 = new ColumnIdentifier();
			}
			Source.MergeFrom(other.Source);
		}
		if (other.Operation != 0)
		{
			Operation = other.Operation;
		}
		if (other.expr_0 != null)
		{
			if (expr_0 == null)
			{
				expr_0 = new Mysqlx.Expr.Expr();
			}
			Value.MergeFrom(other.Value);
		}
		unknownFieldSet_0 = UnknownFieldSet.MergeFrom(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				unknownFieldSet_0 = UnknownFieldSet.MergeFieldFrom(unknownFieldSet_0, input);
				break;
			case 26u:
				if (expr_0 == null)
				{
					expr_0 = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage(expr_0);
				break;
			case 16u:
				enum20_0 = (Class34.Enum20)input.ReadEnum();
				break;
			case 10u:
				if (columnIdentifier_0 == null)
				{
					columnIdentifier_0 = new ColumnIdentifier();
				}
				input.ReadMessage(columnIdentifier_0);
				break;
			}
		}
	}

	static UpdateOperation()
	{
		Strings.CreateGetStringDelegate(typeof(UpdateOperation));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397438), getString_0(107397433)).Replace(getString_0(107397396), getString_0(107397391)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397386)))
		{
			throw new SecurityException(getString_0(107397361));
		}
		messageParser_0 = new MessageParser<UpdateOperation>(() => new UpdateOperation());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
