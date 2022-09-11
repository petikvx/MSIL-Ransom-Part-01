using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;

namespace Mysqlx.Resultset;

internal sealed class FetchDoneMoreResultsets : IMessage, IMessage<FetchDoneMoreResultsets>, IEquatable<FetchDoneMoreResultsets>, IDeepCloneable<FetchDoneMoreResultsets>
{
	private static readonly MessageParser<FetchDoneMoreResultsets> messageParser_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<FetchDoneMoreResultsets> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class21.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public FetchDoneMoreResultsets()
	{
	}

	[DebuggerNonUserCode]
	public FetchDoneMoreResultsets(FetchDoneMoreResultsets other)
		: this()
	{
	}

	[DebuggerNonUserCode]
	public FetchDoneMoreResultsets Clone()
	{
		return new FetchDoneMoreResultsets(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<FetchDoneMoreResultsets>)this).Equals(obj as FetchDoneMoreResultsets);
	}

	[DebuggerNonUserCode]
	bool IEquatable<FetchDoneMoreResultsets>.Equals(FetchDoneMoreResultsets other)
	{
		if (other == null)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		return 1;
	}

	[DebuggerNonUserCode]
	string object.ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return 0;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(FetchDoneMoreResultsets other)
	{
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			input.SkipLastField();
		}
	}

	static FetchDoneMoreResultsets()
	{
		Strings.CreateGetStringDelegate(typeof(FetchDoneMoreResultsets));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397026), getString_0(107397021)).Replace(getString_0(107396984), getString_0(107396979)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396974)))
		{
			throw new SecurityException(getString_0(107396949));
		}
		messageParser_0 = new MessageParser<FetchDoneMoreResultsets>(() => new FetchDoneMoreResultsets());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
