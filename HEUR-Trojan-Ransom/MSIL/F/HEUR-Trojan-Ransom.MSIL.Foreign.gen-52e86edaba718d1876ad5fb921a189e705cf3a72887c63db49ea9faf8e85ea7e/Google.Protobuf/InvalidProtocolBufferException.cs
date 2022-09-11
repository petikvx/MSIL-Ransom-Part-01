using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf;

public sealed class InvalidProtocolBufferException : IOException
{
	[NonSerialized]
	internal static GetString getString_0;

	internal InvalidProtocolBufferException(string message)
		: base(message)
	{
	}

	internal InvalidProtocolBufferException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	internal static InvalidProtocolBufferException MoreDataAvailable()
	{
		return new InvalidProtocolBufferException(getString_0(107369088));
	}

	internal static InvalidProtocolBufferException TruncatedMessage()
	{
		return new InvalidProtocolBufferException(getString_0(107368991));
	}

	internal static InvalidProtocolBufferException NegativeSize()
	{
		return new InvalidProtocolBufferException(getString_0(107369197));
	}

	internal static InvalidProtocolBufferException MalformedVarint()
	{
		return new InvalidProtocolBufferException(getString_0(107368555));
	}

	internal static InvalidProtocolBufferException InvalidTag()
	{
		return new InvalidProtocolBufferException(getString_0(107368490));
	}

	internal static InvalidProtocolBufferException InvalidBase64(Exception innerException)
	{
		return new InvalidProtocolBufferException(getString_0(107368421), innerException);
	}

	internal static InvalidProtocolBufferException InvalidEndTag()
	{
		return new InvalidProtocolBufferException(getString_0(107368392));
	}

	internal static InvalidProtocolBufferException RecursionLimitExceeded()
	{
		return new InvalidProtocolBufferException(getString_0(107368343));
	}

	internal static InvalidProtocolBufferException JsonRecursionLimitExceeded()
	{
		return new InvalidProtocolBufferException(getString_0(107368669));
	}

	internal static InvalidProtocolBufferException SizeLimitExceeded()
	{
		return new InvalidProtocolBufferException(getString_0(107367991));
	}

	internal static InvalidProtocolBufferException InvalidMessageStreamTag()
	{
		return new InvalidProtocolBufferException(getString_0(107367833));
	}

	static InvalidProtocolBufferException()
	{
		Strings.CreateGetStringDelegate(typeof(InvalidProtocolBufferException));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399738), getString_0(107399733)).Replace(getString_0(107399696), getString_0(107399691)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399686)))
		{
			throw new SecurityException(getString_0(107399661));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
