using System;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Transactions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns2;
using ns21;
using ns9;

namespace ns0;

internal sealed class Class152
{
	public Class139 class139_0;

	public Transaction transaction_0;

	public Class181 class181_0;

	public int int_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Class152(Class139 class139_1, Transaction transaction_1, Class181 class181_1)
	{
		class139_0 = class139_1;
		transaction_0 = transaction_1;
		class181_0 = class181_1;
	}

	public void method_0(SinglePhaseEnlistment singlePhaseEnlistment_0)
	{
		Class143 class143_ = class139_0.class143_0;
		lock (class143_)
		{
			int_0 = Thread.CurrentThread.ManagedThreadId;
			while (class139_0.Reader != null)
			{
				Thread.Sleep(100);
			}
			class181_0.Rollback();
			singlePhaseEnlistment_0.Aborted();
			Class154.smethod_2(transaction_0);
			class143_.currentTransaction = null;
			if (class139_0.State == ConnectionState.Closed)
			{
				class139_0.method_7();
			}
			int_0 = 0;
		}
	}

	public void method_1(SinglePhaseEnlistment singlePhaseEnlistment_0)
	{
		class181_0.Commit();
		singlePhaseEnlistment_0.Committed();
		Class154.smethod_2(transaction_0);
		class139_0.class143_0.currentTransaction = null;
		if (class139_0.State == ConnectionState.Closed)
		{
			class139_0.method_7();
		}
	}

	static Class152()
	{
		Strings.CreateGetStringDelegate(typeof(Class152));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398429), getString_0(107398424)).Replace(getString_0(107398387), getString_0(107398382)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398377)))
		{
			throw new SecurityException(getString_0(107398352));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
