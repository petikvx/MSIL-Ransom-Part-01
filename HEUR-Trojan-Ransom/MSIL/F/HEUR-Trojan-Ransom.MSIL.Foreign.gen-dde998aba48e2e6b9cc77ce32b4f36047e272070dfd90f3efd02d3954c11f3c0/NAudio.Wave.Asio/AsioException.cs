using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.Asio;

internal sealed class AsioException : Exception
{
	private AsioError error;

	[NonSerialized]
	internal static GetString _0088;

	public AsioError Error
	{
		get
		{
			return error;
		}
		set
		{
			error = value;
			Data[_0088(107414496)] = error;
		}
	}

	public AsioException()
	{
	}

	public AsioException(string message)
		: base(message)
	{
	}

	public AsioException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public static string getErrorName(AsioError error)
	{
		return Enum.GetName(typeof(AsioError), error);
	}

	static AsioException()
	{
		Strings.CreateGetStringDelegate(typeof(AsioException));
	}
}
