using System;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns5;

namespace ns6;

internal sealed class Class46 : Class45
{
	internal static readonly string string_0;

	internal static readonly string string_1;

	private static bool? nullable_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static void smethod_0(uint uint_0)
	{
		Class46 @class = new Class46();
		@class.method_0(uint_0);
	}

	public static void smethod_1(string string_2)
	{
		Class46 @class = new Class46();
		@class.method_1(string_2);
	}

	protected override void vmethod_0(Class49 class49_0)
	{
		class49_0.method_6();
	}

	protected unsafe override bool vmethod_1()
	{
		void* ptr = stackalloc byte[2];
		*(bool*)ptr = smethod_2();
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	private unsafe static bool smethod_2()
	{
		void* ptr = stackalloc byte[3];
		*(bool*)ptr = !nullable_0.HasValue;
		if (*(bool*)ptr)
		{
			smethod_3();
		}
		((byte*)ptr)[1] = (nullable_0.Value ? ((byte)1) : ((byte)0));
		((byte*)ptr)[2] = ((byte*)ptr)[1];
		return ((byte*)ptr)[2] != 0;
	}

	private unsafe static void smethod_3()
	{
		void* ptr = stackalloc byte[3];
		RegistryKey registryKey = null;
		try
		{
			string subkey = getString_0(107384116) + string_1 + getString_0(107384135) + string_0;
			registryKey = Registry.CurrentUser.CreateSubKey(subkey);
			object value = registryKey.GetValue(getString_0(107384130));
			*(bool*)ptr = value == null;
			if (*(bool*)ptr)
			{
				registryKey.SetValue(getString_0(107384130), bool.FalseString);
				((byte*)ptr)[1] = (smethod_4() ? ((byte)1) : ((byte)0));
				registryKey.SetValue(getString_0(107384130), ((bool*)((byte*)ptr + 1))->ToString(), RegistryValueKind.String);
				nullable_0 = ((byte*)ptr)[1] != 0;
			}
			else
			{
				nullable_0 = Convert.ToBoolean(value);
			}
		}
		catch
		{
			nullable_0 = false;
		}
		finally
		{
			((byte*)ptr)[2] = ((registryKey != null) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[2] != 0)
			{
				registryKey.Close();
			}
		}
	}

	private unsafe static bool smethod_4()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		void* ptr = stackalloc byte[2];
		Form3 form = new Form3();
		try
		{
			((Form)form).ShowDialog();
			*(bool*)ptr = (int)((Form)form).get_DialogResult() == 6;
		}
		finally
		{
			((IDisposable)(object)form)?.Dispose();
		}
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	static Class46()
	{
		Strings.CreateGetStringDelegate(typeof(Class46));
		string_0 = getString_0(107397186);
		string_1 = getString_0(107387056);
	}
}
