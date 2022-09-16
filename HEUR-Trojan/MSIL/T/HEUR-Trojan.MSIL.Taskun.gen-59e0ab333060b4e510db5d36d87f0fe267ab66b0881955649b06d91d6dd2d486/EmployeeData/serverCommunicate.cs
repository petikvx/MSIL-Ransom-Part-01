using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace EmployeeData;

public class serverCommunicate
{
	public static Screen mainDisplay;

	public static Dictionary<string, string> currentStatusfromServer()
	{
		Dictionary<string, string> result = default(Dictionary<string, string>);
		return result;
	}

	public static bool newOverideRequest()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		int num = serverCommunicate.smethod_1(serverCommunicate.smethod_0(Guid.NewGuid().GetHashCode()), 1000, 10000);
		serverCommunicate.smethod_4((object)serverCommunicate.smethod_3("Override code: \r\n", serverCommunicate.smethod_2(num), "\r\n\r\nClick OK when code has been entered"), (MsgBoxStyle)0, (object)null);
		if (serverCommunicate.smethod_5(currentStatusfromServer()["overrideCode"]) == (double)num)
		{
			serverCommunicate.smethod_4((object)"Override Request Successful", (MsgBoxStyle)64, (object)null);
			return true;
		}
		serverCommunicate.smethod_4((object)"Override Request Failed", (MsgBoxStyle)16, (object)null);
		return false;
	}

	public static string privateIP()
	{
		string string_ = serverCommunicate.smethod_6();
		IPHostEntry iphostEntry_ = serverCommunicate.smethod_7(string_);
		try
		{
			IPAddress[] array = serverCommunicate.smethod_8(iphostEntry_);
			foreach (IPAddress ipaddress_ in array)
			{
				if (serverCommunicate.smethod_9(ipaddress_) == AddressFamily.InterNetwork)
				{
					return serverCommunicate.smethod_10(ipaddress_);
				}
			}
		}
		catch (Exception exception_)
		{
			serverCommunicate.smethod_11(exception_);
			string result = "ER UNKNOWN IP";
			serverCommunicate.smethod_12();
			return result;
		}
		return "PS UNKNOWN IP";
	}

	public static void blackout()
	{
		Screen[] array = serverCommunicate.smethod_13();
		foreach (Screen screen_ in array)
		{
			blackout blackout2 = new blackout();
			serverCommunicate.smethod_14((Form)(object)blackout2, (FormStartPosition)0);
			serverCommunicate.smethod_16((Form)(object)blackout2, serverCommunicate.smethod_15(screen_).Location + (Size)new Point(100, 100));
			if (serverCommunicate.smethod_17(screen_))
			{
				mainDisplay = screen_;
			}
			serverCommunicate.smethod_18((Control)(object)blackout2);
		}
	}

	public static void showAlert(Form1 dial)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		blackout();
		serverCommunicate.smethod_14((Form)(object)dial, (FormStartPosition)0);
		serverCommunicate.smethod_16((Form)(object)dial, serverCommunicate.smethod_15(mainDisplay).Location);
		serverCommunicate.smethod_19((Form)(object)dial);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void actionLogout(object sender, EventArgs e)
	{
		serverCommunicate.smethod_20("shutdown.exe", "/l /y");
		serverCommunicate.smethod_21();
	}

	static Random smethod_0(int int_0)
	{
		return new Random(int_0);
	}

	static int smethod_1(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static string smethod_2(int int_0)
	{
		return Conversions.ToString(int_0);
	}

	static string smethod_3(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static MsgBoxResult smethod_4(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	static double smethod_5(string string_0)
	{
		return Conversions.ToDouble(string_0);
	}

	static string smethod_6()
	{
		return Dns.GetHostName();
	}

	static IPHostEntry smethod_7(string string_0)
	{
		return Dns.GetHostEntry(string_0);
	}

	static IPAddress[] smethod_8(IPHostEntry iphostEntry_0)
	{
		return iphostEntry_0.AddressList;
	}

	static AddressFamily smethod_9(IPAddress ipaddress_0)
	{
		return ipaddress_0.AddressFamily;
	}

	static string smethod_10(IPAddress ipaddress_0)
	{
		return ipaddress_0.ToString();
	}

	static void smethod_11(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_12()
	{
		ProjectData.ClearProjectError();
	}

	static Screen[] smethod_13()
	{
		return Screen.get_AllScreens();
	}

	static void smethod_14(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static Rectangle smethod_15(Screen screen_0)
	{
		return screen_0.get_Bounds();
	}

	static void smethod_16(Form form_0, Point point_0)
	{
		form_0.set_Location(point_0);
	}

	static bool smethod_17(Screen screen_0)
	{
		return screen_0.get_Primary();
	}

	static void smethod_18(Control control_0)
	{
		control_0.Show();
	}

	static DialogResult smethod_19(Form form_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return form_0.ShowDialog();
	}

	static Process smethod_20(string string_0, string string_1)
	{
		return Process.Start(string_0, string_1);
	}

	static void smethod_21()
	{
		ProjectData.EndApp();
	}
}
