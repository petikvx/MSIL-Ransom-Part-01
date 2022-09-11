using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using MySqlX.Sessions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns18;
using ns19;
using ns21;
using ns22;
using ns3;
using ns9;

namespace ns8;

internal abstract class Class79 : IDisposable
{
	protected Stream stream_0;

	internal Class48 class48_0;

	private bool bool_0;

	protected MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0;

	[CompilerGenerated]
	private Enum23 enum23_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Enum23 SessionState
	{
		[CompilerGenerated]
		get
		{
			return enum23_0;
		}
		[CompilerGenerated]
		protected set
		{
			enum23_0 = value;
		}
	}

	public Class79(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_1)
	{
		mySqlConnectionStringBuilder_0 = mySqlConnectionStringBuilder_1;
	}

	protected abstract void vmethod_0();

	public abstract void vmethod_1();

	internal abstract Class85 vmethod_2();

	protected Class112 method_0()
	{
		return Class191.smethod_1(getString_0(107407827));
	}

	public static Class79 smethod_0(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_1)
	{
		Class79 @class = new XInternalSession(mySqlConnectionStringBuilder_1);
		int num = 0;
		while (true)
		{
			try
			{
				@class.vmethod_0();
				smethod_1(@class, mySqlConnectionStringBuilder_1.CharacterSet);
				return @class;
			}
			catch (IOException)
			{
				if (num++ >= 5)
				{
					throw;
				}
			}
		}
	}

	public Class54 method_1(string string_0, params object[] object_0)
	{
		vmethod_2().vmethod_1(string_0, object_0);
		return new Class54(this);
	}

	public Class51 method_2(string string_0)
	{
		vmethod_2().vmethod_1(string_0);
		return new Class51(this);
	}

	public Class52 method_3(string string_0, object[] object_0)
	{
		vmethod_2().vmethod_1(string_0, object_0);
		return new Class52(this);
	}

	public object method_4(string string_0)
	{
		ReadOnlyCollection<Class55> readOnlyCollection = method_2(string_0).method_2();
		if (readOnlyCollection.Count == 0)
		{
			throw new MySqlException(getString_0(107407798));
		}
		return readOnlyCollection[0][0];
	}

	private static void smethod_1(Class79 class79_0, string string_0)
	{
		if (class79_0.method_5().method_0(8, 0, 1))
		{
			class79_0.method_2(getString_0(107407745) + string_0 + getString_0(107407871));
			Class55 @class = class79_0.method_2(getString_0(107407745) + string_0 + getString_0(107407871)).method_4();
			if (@class != null)
			{
				string text = @class.method_0(getString_0(107407736));
				class79_0.method_1(getString_0(107407711) + text + getString_0(107407871));
			}
			else
			{
				class79_0.method_1(getString_0(107407670));
			}
		}
	}

	internal Struct23 method_5()
	{
		return Struct23.smethod_0(method_2(getString_0(107407605)).method_4().method_0(getString_0(107388431)));
	}

	void IDisposable.Dispose()
	{
		vmethod_3(bool_1: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void vmethod_3(bool bool_1)
	{
		if (!bool_0)
		{
			bool_0 = true;
		}
	}

	static Class79()
	{
		Strings.CreateGetStringDelegate(typeof(Class79));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397781), getString_0(107397776)).Replace(getString_0(107397739), getString_0(107397734)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397729)))
		{
			throw new SecurityException(getString_0(107397704));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
