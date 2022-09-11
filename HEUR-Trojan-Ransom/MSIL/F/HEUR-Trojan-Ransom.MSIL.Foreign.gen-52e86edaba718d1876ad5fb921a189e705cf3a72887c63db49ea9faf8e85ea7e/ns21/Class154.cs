using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Transactions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns2;

namespace ns21;

internal sealed class Class154
{
	private static Hashtable hashtable_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static Class143 smethod_0(Transaction transaction_0)
	{
		lock (hashtable_0.SyncRoot)
		{
			return (Class143)hashtable_0[transaction_0.GetHashCode()];
		}
	}

	public static void smethod_1(Class143 class143_0)
	{
		lock (hashtable_0.SyncRoot)
		{
			hashtable_0[class143_0.currentTransaction.BaseTransaction.GetHashCode()] = class143_0;
		}
	}

	public static void smethod_2(Transaction transaction_0)
	{
		lock (hashtable_0.SyncRoot)
		{
			hashtable_0.Remove(transaction_0.GetHashCode());
		}
	}

	static Class154()
	{
		Strings.CreateGetStringDelegate(typeof(Class154));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398435), getString_0(107398430)).Replace(getString_0(107398393), getString_0(107398388)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398383)))
		{
			throw new SecurityException(getString_0(107398358));
		}
		hashtable_0 = new Hashtable();
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
