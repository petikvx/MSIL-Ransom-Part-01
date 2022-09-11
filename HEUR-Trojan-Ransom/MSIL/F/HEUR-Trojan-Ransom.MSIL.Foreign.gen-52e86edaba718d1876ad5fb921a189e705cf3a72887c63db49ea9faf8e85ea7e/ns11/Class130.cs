using System;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns0;

namespace ns11;

internal sealed class Class130 : IDisposable
{
	private IntPtr intptr_0;

	private IntPtr intptr_1;

	[NonSerialized]
	internal static GetString getString_0;

	public IntPtr View => intptr_1;

	public Class130(string string_0, IntPtr intptr_2)
	{
		intptr_0 = Class128.OpenFileMapping(2u, bool_0: false, string_0);
		if (intptr_0 == IntPtr.Zero)
		{
			throw new MySqlException(getString_0(107357247) + string_0);
		}
		intptr_1 = Class128.MapViewOfFile(intptr_0, 2u, 0u, 0u, intptr_2);
	}

	void object.Finalize()
	{
		try
		{
			vmethod_0(bool_0: false);
		}
		finally
		{
			base.Finalize();
		}
	}

	void IDisposable.Dispose()
	{
		vmethod_0(bool_0: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void vmethod_0(bool bool_0)
	{
		if (bool_0)
		{
			if (intptr_1 != IntPtr.Zero)
			{
				Class128.UnmapViewOfFile(intptr_1);
				intptr_1 = IntPtr.Zero;
			}
			if (intptr_0 != IntPtr.Zero)
			{
				Class128.CloseHandle(intptr_0);
				intptr_0 = IntPtr.Zero;
			}
		}
	}

	static Class130()
	{
		Strings.CreateGetStringDelegate(typeof(Class130));
	}
}
