using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Timers;
using Microsoft.VisualBasic.CompilerServices;
using ns1;

public class GClass0
{
	private static Timer timer_0;

	private static Class5 class5_0;

	static GClass0()
	{
		Class7.smethod_0();
		class5_0 = new Class5();
	}

	public GClass0()
	{
		Class7.smethod_0();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0(object object_0, object object_1)
	{
		Process[] processesByName = Process.GetProcessesByName("procexp");
		checked
		{
			for (int i = 0; i < processesByName.Length; i++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName2 = Process.GetProcessesByName("SbieCtrl");
			for (int j = 0; j < processesByName2.Length; j++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName3 = Process.GetProcessesByName("SpyTheSpy");
			for (int k = 0; k < processesByName3.Length; k++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName4 = Process.GetProcessesByName("wireshark");
			for (int l = 0; l < processesByName4.Length; l++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName5 = Process.GetProcessesByName("apateDNS");
			for (int m = 0; m < processesByName5.Length; m++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName6 = Process.GetProcessesByName("IPBlocker");
			for (int n = 0; n < processesByName6.Length; n++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName7 = Process.GetProcessesByName("TiGeR-Firewall");
			for (int num = 0; num < processesByName7.Length; num++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName8 = Process.GetProcessesByName("smsniff");
			for (int num2 = 0; num2 < processesByName8.Length; num2++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName9 = Process.GetProcessesByName("exeinfoPE");
			for (int num3 = 0; num3 < processesByName9.Length; num3++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName10 = Process.GetProcessesByName("NetSnifferCs");
			for (int num4 = 0; num4 < processesByName10.Length; num4++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName11 = Process.GetProcessesByName("Sandboxie Control");
			for (int num5 = 0; num5 < processesByName11.Length; num5++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName12 = Process.GetProcessesByName("processhacker");
			for (int num6 = 0; num6 < processesByName12.Length; num6++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName13 = Process.GetProcessesByName("dnSpy");
			for (int num7 = 0; num7 < processesByName13.Length; num7++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName14 = Process.GetProcessesByName("CodeReflect");
			for (int num8 = 0; num8 < processesByName14.Length; num8++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName15 = Process.GetProcessesByName("Reflector");
			for (int num9 = 0; num9 < processesByName15.Length; num9++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName16 = Process.GetProcessesByName("ILSpy");
			for (int num10 = 0; num10 < processesByName16.Length; num10++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName17 = Process.GetProcessesByName("VGAuthService");
			for (int num11 = 0; num11 < processesByName17.Length; num11++)
			{
				ProjectData.EndApp();
			}
			Process[] processesByName18 = Process.GetProcessesByName("VBoxService");
			for (int num12 = 0; num12 < processesByName18.Length; num12++)
			{
				ProjectData.EndApp();
			}
		}
	}

	public static void smethod_1()
	{
		timer_0 = new Timer(5.0);
		timer_0.Elapsed += smethod_0;
		timer_0.Enabled = true;
	}
}
