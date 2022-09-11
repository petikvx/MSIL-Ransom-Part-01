using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

internal sealed class PackageDescriptor : IDescriptor
{
	private readonly string name;

	private readonly string fullName;

	private readonly FileDescriptor file;

	[NonSerialized]
	internal static GetString getString_0;

	public string Name => name;

	public string FullName => fullName;

	public FileDescriptor File => file;

	internal PackageDescriptor(string name, string fullName, FileDescriptor file)
	{
		this.file = file;
		this.fullName = fullName;
		this.name = name;
	}

	static PackageDescriptor()
	{
		Strings.CreateGetStringDelegate(typeof(PackageDescriptor));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400727), getString_0(107400722)).Replace(getString_0(107400685), getString_0(107400680)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400675)))
		{
			throw new SecurityException(getString_0(107400650));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
