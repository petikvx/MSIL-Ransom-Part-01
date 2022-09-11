using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns13;
using ns15;
using ns21;
using ns9;

namespace ns22;

internal abstract class Class112
{
	private Class169 class169_0;

	protected byte[] byte_0;

	[NonSerialized]
	internal static GetString getString_0;

	protected MySqlConnectionStringBuilder Settings => class169_0.Settings;

	protected Version ServerVersion => new Version(class169_0.Version.Major, class169_0.Version.Minor, class169_0.Version.Build);

	internal Enum37 Flags => class169_0.Flags;

	protected Encoding Encoding => class169_0.Encoding;

	public abstract string PluginName { get; }

	internal static Class112 smethod_0(string string_0, Class169 class169_1, byte[] byte_1)
	{
		if (string_0 == getString_0(107369016))
		{
			class169_1.imethod_3(bool_0: true);
			throw new MySqlException(Class121.OldPasswordsNotSupported);
		}
		Class112 obj = Class191.smethod_1(string_0) ?? throw new MySqlException(string.Format(Class121.UnknownAuthenticationMethod, string_0));
		obj.class169_0 = class169_1;
		obj.vmethod_0(byte_1);
		return obj;
	}

	protected virtual void vmethod_0(byte[] byte_1)
	{
		byte_0 = byte_1;
	}

	protected virtual void vmethod_1()
	{
	}

	protected virtual void vmethod_2(Exception exception_0)
	{
		throw new MySqlException(string.Format(Class121.AuthenticationFailed, Settings.Server, vmethod_5(), PluginName, exception_0.Message), exception_0);
	}

	protected virtual void vmethod_3()
	{
	}

	protected virtual byte[] vmethod_4(byte[] byte_1)
	{
		return null;
	}

	internal void method_0(bool bool_0)
	{
		vmethod_1();
		Class167 packet = class169_0.Packet;
		packet.method_19(vmethod_5());
		method_1(packet);
		if (((Flags & Enum37.flag_3) > (Enum37)0uL || bool_0) && !string.IsNullOrEmpty(Settings.Database))
		{
			packet.method_19(Settings.Database);
		}
		if (bool_0)
		{
			packet.method_14(8L, 2);
		}
		if ((Flags & Enum37.flag_19) != (Enum37)0uL)
		{
			packet.method_19(PluginName);
		}
		class169_0.method_13();
		class169_0.method_1(packet);
		packet = method_2();
		byte[] buffer = packet.Buffer;
		if (PluginName == getString_0(107369147) && buffer[0] == 1)
		{
			method_4(new byte[1] { buffer[1] });
		}
		if (buffer[0] == 254)
		{
			if (packet.IsLastPacket)
			{
				class169_0.imethod_3(bool_0: true);
				throw new MySqlException(Class121.OldPasswordsNotSupported);
			}
			method_3(packet);
		}
		class169_0.method_4(bool_0: false);
		vmethod_3();
	}

	private void method_1(Class167 class167_0)
	{
		bool flag = (Flags & Enum37.flag_15) > (Enum37)0uL;
		object obj = vmethod_6();
		if (obj is string)
		{
			if (flag)
			{
				class167_0.method_17((string)obj);
			}
			else
			{
				class167_0.method_19((string)obj);
			}
			return;
		}
		if (obj == null)
		{
			class167_0.method_3(0);
			return;
		}
		if (!(obj is byte[]))
		{
			throw new MySqlException(getString_0(107369023) + obj.GetType());
		}
		class167_0.method_4(obj as byte[]);
	}

	private Class167 method_2()
	{
		try
		{
			return class169_0.method_3();
		}
		catch (MySqlException exception_)
		{
			vmethod_2(exception_);
			return null;
		}
	}

	private void method_3(Class167 class167_0)
	{
		class167_0.method_1();
		string string_ = class167_0.method_23();
		byte[] array = new byte[class167_0.Length - class167_0.Position];
		Array.Copy(class167_0.Buffer, class167_0.Position, array, 0, array.Length);
		smethod_0(string_, class169_0, array).method_4();
	}

	private void method_4(byte[] byte_1 = null)
	{
		Class167 @class = class169_0.Packet;
		@class.method_0();
		byte[] array = vmethod_4(byte_1);
		while (array != null)
		{
			@class.method_0();
			@class.method_4(array);
			class169_0.method_1(@class);
			@class = method_2();
			if (@class.Buffer[0] != 1)
			{
				return;
			}
			byte[] array2 = new byte[@class.Length - 1];
			Array.Copy(@class.Buffer, 1, array2, 0, array2.Length);
			array = vmethod_4(array2);
		}
		method_2();
	}

	public virtual string vmethod_5()
	{
		return Settings.UserID;
	}

	public virtual object vmethod_6()
	{
		return null;
	}

	static Class112()
	{
		Strings.CreateGetStringDelegate(typeof(Class112));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398019), getString_0(107398014)).Replace(getString_0(107397977), getString_0(107397972)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397967)))
		{
			throw new SecurityException(getString_0(107397942));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
