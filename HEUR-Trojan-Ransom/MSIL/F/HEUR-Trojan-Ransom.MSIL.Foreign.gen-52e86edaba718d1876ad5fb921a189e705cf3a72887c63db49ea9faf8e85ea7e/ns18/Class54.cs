using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns21;
using ns8;

namespace ns18;

internal sealed class Class54 : Class48
{
	[CompilerGenerated]
	private readonly ReadOnlyCollection<string> readOnlyCollection_0;

	[NonSerialized]
	internal static GetString getString_1;

	public ulong RecordsAffected => ulong_0;

	public ulong AutoIncrementValue => ulong_1;

	public ReadOnlyCollection<string> GeneratedIds
	{
		[CompilerGenerated]
		get
		{
			return readOnlyCollection_0;
		}
	}

	internal Class54(Class79 class79_1)
		: base(class79_1)
	{
		if (class79_1 != null)
		{
			readOnlyCollection_0 = new ReadOnlyCollection<string>(list_1);
			class79_1.vmethod_2().vmethod_4(this);
		}
	}

	static Class54()
	{
		Strings.CreateGetStringDelegate(typeof(Class54));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107397700), getString_1(107397695)).Replace(getString_1(107397658), getString_1(107397653)));
		if (!StrongNameSignatureVerificationEx_1(uri.LocalPath, bool_2: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107397648)))
		{
			throw new SecurityException(getString_1(107397623));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_2, [MarshalAs(UnmanagedType.Bool)] out bool bool_3);
}
