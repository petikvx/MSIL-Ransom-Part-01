using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio;

public sealed class MmException : Exception
{
	private MmResult result;

	private string function;

	[NonSerialized]
	internal static GetString _0014;

	public MmResult Result => result;

	public MmException(MmResult result, string function)
		: base(ErrorMessage(result, function))
	{
		this.result = result;
		this.function = function;
	}

	private static string ErrorMessage(MmResult result, string function)
	{
		return string.Format(_0014(107396130), result, function);
	}

	public static void Try(MmResult result, string function)
	{
		if (result != 0)
		{
			throw new MmException(result, function);
		}
	}

	static MmException()
	{
		Strings.CreateGetStringDelegate(typeof(MmException));
	}
}
