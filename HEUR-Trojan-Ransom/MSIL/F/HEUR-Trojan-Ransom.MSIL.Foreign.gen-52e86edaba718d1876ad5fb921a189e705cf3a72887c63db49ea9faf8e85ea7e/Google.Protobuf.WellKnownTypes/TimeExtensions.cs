using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public static class TimeExtensions
{
	[NonSerialized]
	internal static GetString getString_0;

	public static Timestamp ToTimestamp(this DateTime dateTime)
	{
		return Timestamp.FromDateTime(dateTime);
	}

	public static Timestamp ToTimestamp(this DateTimeOffset dateTimeOffset)
	{
		return Timestamp.FromDateTimeOffset(dateTimeOffset);
	}

	public static Duration ToDuration(this TimeSpan timeSpan)
	{
		return Duration.FromTimeSpan(timeSpan);
	}

	static TimeExtensions()
	{
		Strings.CreateGetStringDelegate(typeof(TimeExtensions));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399991), getString_0(107399986)).Replace(getString_0(107399949), getString_0(107399944)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399939)))
		{
			throw new SecurityException(getString_0(107399914));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
