using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.IO.IsolatedStorage;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.MemoryManagement;
using SmartAssembly.SmartExceptionsCore;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns5;

internal sealed class Class29
{
	static string smethod_0(Class40.Class44 class44_0)
	{
		return class44_0.string_2;
	}

	static void smethod_1(Class24 class24_0, EventHandler eventHandler_0)
	{
		EventHandler eventHandler = class24_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class24_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	static Class48 smethod_2()
	{
		ulong[] ulong_ = Class29.smethod_144(Class49.string_1);
		Dictionary<string, ulong> dictionary = new Dictionary<string, ulong>();
		try
		{
			string[] fileNames = Class49.isolatedStorageFile_0.GetFileNames(Class49.string_2 + "\\*.bin");
			foreach (string text in fileNames)
			{
				string text2 = Path.GetFileNameWithoutExtension(text);
				string string_ = Path.Combine(Class49.string_2, text);
				ulong[] array = Class29.smethod_144(string_);
				string string_2 = Path.Combine(Class49.string_2, text2 + ".txt");
				IsolatedStorageFileStream isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = Class29.smethod_17(FileAccess.Read, FileMode.Open, string_2);
					byte[] array2 = new byte[isolatedStorageFileStream.Length];
					isolatedStorageFileStream.Read(array2, 0, array2.Length);
					text2 = Class49.encoding_0.GetString(array2);
				}
				catch (FileNotFoundException)
				{
					text2 = Class49.encoding_0.GetString(Convert.FromBase64String(text2.Replace('@', '\\')));
				}
				finally
				{
					isolatedStorageFileStream?.Close();
				}
				dictionary[text2] = array[0];
			}
		}
		catch (DirectoryNotFoundException)
		{
		}
		return new Class48(ulong_, dictionary);
	}

	static bool smethod_3(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class24_0.method_7();
	}

	static void smethod_4(Class51 class51_0)
	{
		if (!Class51.bool_0)
		{
			Class51.Class53 @class = new Class51.Class53();
			@class.class51_0 = class51_0;
			@class.class48_0 = Class29.smethod_204();
			Thread thread = new Thread(@class.method_0);
			thread.IsBackground = true;
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			AppDomain.CurrentDomain.ProcessExit += class51_0.method_0;
			Class51.bool_0 = true;
		}
	}

	static void smethod_5(Exception exception_0)
	{
		Class29.smethod_42(exception_0, new object[0]);
	}

	static void smethod_6(Class10.Class17.Class18 class18_0)
	{
		int num = class18_0.short_0.Length;
		int[] array = new int[num];
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < num; i++)
		{
			int num4 = class18_0.short_0[i];
			if (num4 != 0)
			{
				int num5 = num2++;
				int num6;
				while (num5 > 0 && class18_0.short_0[array[num6 = (num5 - 1) / 2]] > num4)
				{
					array[num5] = array[num6];
					num5 = num6;
				}
				array[num5] = i;
				num3 = i;
			}
		}
		while (num2 < 2)
		{
			int num7 = ((num3 < 2) ? (++num3) : 0);
			array[num2++] = num7;
		}
		class18_0.int_1 = Math.Max(num3 + 1, class18_0.int_0);
		int num8 = num2;
		int[] array2 = new int[4 * num2 - 2];
		int[] array3 = new int[2 * num2 - 1];
		int num9 = num8;
		for (int j = 0; j < num2; j++)
		{
			int num10 = (array2[2 * j] = array[j]);
			array2[2 * j + 1] = -1;
			array3[j] = class18_0.short_0[num10] << 8;
			array[j] = j;
		}
		do
		{
			int num11 = array[0];
			int num12 = array[--num2];
			int num13 = 0;
			int num14;
			for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
			{
				if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
				{
					num14++;
				}
				array[num13] = array[num14];
				num13 = num14;
			}
			int num15 = array3[num12];
			while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
			{
				array[num14] = array[num13];
			}
			array[num14] = num12;
			int num16 = array[0];
			num12 = num9++;
			array2[2 * num12] = num11;
			array2[2 * num12 + 1] = num16;
			int num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
			num15 = (array3[num12] = array3[num11] + array3[num16] - num17 + 1);
			num13 = 0;
			for (num14 = 1; num14 < num2; num14 = num13 * 2 + 1)
			{
				if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
				{
					num14++;
				}
				array[num13] = array[num14];
				num13 = num14;
			}
			while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
			{
				array[num14] = array[num13];
			}
			array[num14] = num12;
		}
		while (num2 > 1);
		Class29.smethod_28(array2, class18_0);
	}

	static void smethod_7(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.image_0 = (Image)(object)Class29.smethod_211("current");
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	static void smethod_8(Class10.Class19 class19_0)
	{
		Array.Copy(class19_0.byte_0, 32768, class19_0.byte_0, 0, 32768);
		class19_0.int_1 -= 32768;
		class19_0.int_4 -= 32768;
		class19_0.int_3 -= 32768;
		for (int i = 0; i < 32768; i++)
		{
			int num = class19_0.short_0[i] & 0xFFFF;
			class19_0.short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
		}
		for (int j = 0; j < 32768; j++)
		{
			int num2 = class19_0.short_1[j] & 0xFFFF;
			class19_0.short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
		}
	}

	static void smethod_9(Form0 form0_0)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		((Control)form0_0.panel_0).SuspendLayout();
		((Control)form0_0.panel_1).SuspendLayout();
		((Control)form0_0).SuspendLayout();
		Class29.smethod_74(form0_0.control1_0, Enum1.const_1);
		Class29.smethod_74(form0_0.control1_1, Enum1.const_1);
		((Control)form0_0.checkBox_0).set_Anchor((AnchorStyles)6);
		((ButtonBase)form0_0.checkBox_0).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.checkBox_0).set_Location(new Point(22, 98));
		((Control)form0_0.checkBox_0).set_Size(new Size(226, 16));
		((Control)form0_0.checkBox_0).set_TabIndex(13);
		((Control)form0_0.checkBox_0).set_Text("Ignore this error and attempt to &continue.");
		form0_0.checkBox_0.add_CheckedChanged((EventHandler)form0_0.method_5);
		((Control)form0_0.label_0).set_Anchor((AnchorStyles)14);
		form0_0.label_0.set_FlatStyle((FlatStyle)3);
		((Control)form0_0.label_0).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)form0_0.label_0).set_Location(new Point(20, 124));
		((Control)form0_0.label_0).set_Size(new Size(381, 16));
		((Control)form0_0.label_0).set_Text(string.Format("Please tell {0} about this problem.", "[Unknown company]"));
		((Control)form0_0.button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_0).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_0).set_Size(new Size(75, 24));
		((Control)form0_0.button_0).set_Location(new Point(400 - ((Control)form0_0.button_0).get_Width(), 205));
		((Control)form0_0.button_0).set_TabIndex(4);
		((Control)form0_0.button_0).set_Text("&Don't Send");
		((Control)form0_0.button_0).add_Click((EventHandler)form0_0.method_2);
		((Control)form0_0.button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_1).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_1).set_Size(new Size(105, 24));
		((Control)form0_0.button_1).set_Location(new Point(((Control)form0_0.button_0).get_Left() - ((Control)form0_0.button_1).get_Width() - 6, 205));
		((Control)form0_0.button_1).set_TabIndex(3);
		((Control)form0_0.button_1).set_Text("&Send Error Report");
		((Control)form0_0.button_1).add_Click((EventHandler)form0_0.method_1);
		((Control)form0_0.button_6).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_6).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_6).set_Size(new Size(64, 24));
		((Control)form0_0.button_6).set_Location(new Point(((Control)form0_0.button_1).get_Left() - ((Control)form0_0.button_6).get_Width() - 6, 205));
		((Control)form0_0.button_6).set_TabIndex(14);
		((Control)form0_0.button_6).set_Text("De&bug");
		((Control)form0_0.button_6).set_Visible(false);
		((Control)form0_0.button_6).add_Click((EventHandler)form0_0.method_12);
		((Control)form0_0.label_1).set_Anchor((AnchorStyles)14);
		form0_0.label_1.set_FlatStyle((FlatStyle)3);
		((Control)form0_0.label_1).set_Location(new Point(20, 140));
		((Control)form0_0.label_1).set_Size(new Size(381, 55));
		((Control)form0_0.label_1).set_Text(string.Format("To help improve the software you use, {0} is interested in learning more about this error. We have created a report about the error for you to send to us.", "[Unknown company]"));
		((Control)form0_0.class32_0).set_Anchor((AnchorStyles)13);
		((Control)form0_0.class32_0).set_Location(new Point(20, 69));
		((Control)form0_0.class32_0).set_Size(new Size(381, 13));
		((Control)form0_0.button_2).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_2).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_2).set_Size(new Size(80, 24));
		((Control)form0_0.button_2).set_Location(new Point(400 - ((Control)form0_0.button_2).get_Width(), 205));
		((Control)form0_0.button_2).set_TabIndex(7);
		((Control)form0_0.button_2).set_Text("&Cancel");
		((Control)form0_0.button_2).add_Click((EventHandler)form0_0.method_3);
		((Control)form0_0.button_3).set_Anchor((AnchorStyles)10);
		((Control)form0_0.button_3).set_Enabled(false);
		((ButtonBase)form0_0.button_3).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_3).set_Size(new Size(105, 24));
		((Control)form0_0.button_3).set_Location(new Point(((Control)form0_0.button_2).get_Left() - ((Control)form0_0.button_3).get_Width() - 6, 205));
		((Control)form0_0.button_3).set_TabIndex(6);
		((Control)form0_0.button_3).set_Text("&OK");
		((Control)form0_0.button_3).add_Click((EventHandler)form0_0.method_4);
		((Control)form0_0.button_4).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_4).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_4).set_Location(((Control)form0_0.button_3).get_Location());
		((Control)form0_0.button_4).set_Size(((Control)form0_0.button_3).get_Size());
		((Control)form0_0.button_4).set_TabIndex(5);
		((Control)form0_0.button_4).set_Text("&Retry");
		((Control)form0_0.button_4).set_Visible(false);
		((Control)form0_0.button_4).add_Click((EventHandler)form0_0.method_10);
		((Control)form0_0.button_5).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_5).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_5).set_Location(((Control)form0_0.button_3).get_Location());
		((Control)form0_0.button_5).set_Size(((Control)form0_0.button_3).get_Size());
		((Control)form0_0.button_5).set_TabIndex(5);
		((Control)form0_0.button_5).set_Text("Save Report");
		((Control)form0_0.button_5).set_Visible(false);
		((Control)form0_0.button_5).add_Click((EventHandler)form0_0.method_0);
		((Control)form0_0.control3_0).set_Location(new Point(87, 146));
		((Control)form0_0.control3_0).set_Visible(false);
		((Control)form0_0.control0_0).SetBounds(24, 72, 368, 16);
		((Control)form0_0.control0_1).SetBounds(24, 96, 368, 16);
		((Control)form0_0.control0_2).SetBounds(24, 120, 368, 16);
		((Control)form0_0.control0_3).SetBounds(24, 144, 368, 16);
		((Control)form0_0.control2_0).set_Anchor((AnchorStyles)6);
		((Control)form0_0.control2_0).SetBounds(20, 444, 120, 32);
		((Control)form0_0.panel_0).get_Controls().AddRange((Control[])(object)new Control[8]
		{
			(Control)form0_0.button_6,
			(Control)form0_0.checkBox_0,
			(Control)form0_0.label_0,
			(Control)form0_0.button_0,
			(Control)form0_0.button_1,
			(Control)form0_0.label_1,
			(Control)form0_0.class32_0,
			form0_0.control1_0
		});
		((Control)form0_0.panel_0).set_Size(new Size(413, 240));
		((Control)form0_0.panel_0).set_TabIndex(0);
		((Control)form0_0.panel_1).get_Controls().AddRange((Control[])(object)new Control[10]
		{
			(Control)form0_0.button_2,
			(Control)form0_0.button_3,
			(Control)form0_0.button_4,
			(Control)form0_0.button_5,
			form0_0.control3_0,
			form0_0.control1_1,
			form0_0.control0_0,
			form0_0.control0_1,
			form0_0.control0_2,
			form0_0.control0_3
		});
		((Control)form0_0.panel_1).set_Size(new Size(413, 240));
		((Control)form0_0.panel_1).set_TabIndex(2);
		((Control)form0_0.panel_1).set_Visible(false);
		((Form)form0_0).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)form0_0).set_ClientSize(new Size(434, 488));
		((Form)form0_0).set_ControlBox(false);
		((Control)form0_0).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			form0_0.control2_0,
			(Control)form0_0.panel_0,
			(Control)form0_0.panel_1
		});
		((Form)form0_0).set_FormBorderStyle((FormBorderStyle)1);
		((Form)form0_0).set_ShowInTaskbar(false);
		((Form)form0_0).set_MinimizeBox(false);
		((Form)form0_0).set_MaximizeBox(false);
		((Form)form0_0).set_StartPosition((FormStartPosition)1);
		((Control)form0_0).set_Text("Server.packed");
		if (((Control)form0_0).get_Text().Length == 0)
		{
			((Control)form0_0).set_Text("Error Reporting");
		}
		try
		{
			((Form)form0_0).set_TopMost(true);
		}
		catch
		{
		}
		((Control)form0_0.panel_0).ResumeLayout(false);
		((Control)form0_0.panel_1).ResumeLayout(false);
		((Control)form0_0).ResumeLayout(false);
		((Control)form0_0.button_4).BringToFront();
		((Control)form0_0.button_5).BringToFront();
		((Form)form0_0).set_Size(new Size(419, 264));
		((Control)form0_0.panel_1).set_Dock((DockStyle)5);
		((Control)form0_0.panel_0).set_Dock((DockStyle)5);
	}

	static Class33 smethod_10()
	{
		if (Class33.class33_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class33))
				{
					continue;
				}
				try
				{
					Class33.class33_0 = (Class33)Activator.CreateInstance(type, nonPublic: true);
					if (Class33.class33_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return Class33.class33_0;
	}

	static Assembly[] smethod_11(Class24 class24_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class29.smethod_164() };
		}
	}

	static void smethod_12(Class10.Class19 class19_0)
	{
		if (class19_0.int_4 >= 65274)
		{
			Class29.smethod_8(class19_0);
		}
		while (class19_0.int_5 < 262 && class19_0.int_7 < class19_0.int_8)
		{
			int num = 65536 - class19_0.int_5 - class19_0.int_4;
			if (num > class19_0.int_8 - class19_0.int_7)
			{
				num = class19_0.int_8 - class19_0.int_7;
			}
			Array.Copy(class19_0.byte_1, class19_0.int_7, class19_0.byte_0, class19_0.int_4 + class19_0.int_5, num);
			class19_0.int_7 += num;
			class19_0.int_6 += num;
			class19_0.int_5 += num;
		}
		if (class19_0.int_5 >= 3)
		{
			Class29.smethod_213(class19_0);
		}
	}

	static string smethod_13(string string_0)
	{
		byte[] bytes = Class49.encoding_0.GetBytes(string_0);
		string text = Convert.ToBase64String(bytes).Replace('\\', '@');
		if (text.Length > 50)
		{
			byte[] b = Class49.hashAlgorithm_0.ComputeHash(bytes);
			string path = new Guid(b).ToString().Substring(0, 18);
			string text2 = Path.Combine(Class49.string_2, path);
			text = text2 + ".bin";
			string string_ = text2 + ".txt";
			IsolatedStorageFileStream isolatedStorageFileStream = null;
			try
			{
				isolatedStorageFileStream = Class29.smethod_17(FileAccess.Write, FileMode.CreateNew, string_);
				isolatedStorageFileStream.Write(bytes, 0, bytes.Length);
			}
			catch (IOException)
			{
			}
			finally
			{
				isolatedStorageFileStream?.Close();
			}
		}
		else
		{
			text = Path.Combine(Class49.string_2, text + ".bin");
		}
		return text;
	}

	static void smethod_14(Class40 class40_0, Enum2 enum2_0, string string_0, string string_1)
	{
		class40_0.delegate3_0?.Invoke(class40_0, new EventArgs4(enum2_0, string_0, string_1));
	}

	static void smethod_15(IWebProxy iwebProxy_0, Class45 class45_0)
	{
		class45_0.iwebProxy_0 = iwebProxy_0;
	}

	[DllImport("gdi32.dll")]
	static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	static void smethod_16(int int_0, Class10.Stream0 stream0_0)
	{
		Class29.smethod_25(int_0, stream0_0);
		Class29.smethod_25(int_0 >> 16, stream0_0);
	}

	static IsolatedStorageFileStream smethod_17(FileAccess fileAccess_0, FileMode fileMode_0, string string_0)
	{
		return new IsolatedStorageFileStream(string_0, fileMode_0, fileAccess_0, FileShare.None, Class49.isolatedStorageFile_0);
	}

	static void smethod_18(Exception exception_0, object object_0, object object_1)
	{
		Class29.smethod_42(exception_0, new object[2] { object_0, object_1 });
	}

	static int smethod_19(Class10.Class16 class16_0, byte[] byte_0)
	{
		int num = 0;
		int num2 = byte_0.Length;
		int num3 = num2;
		while (true)
		{
			int num4 = Class29.smethod_181(class16_0.class20_0, byte_0, num, num2);
			num += num4;
			class16_0.long_0 += num4;
			num2 -= num4;
			if (num2 == 0 || class16_0.int_0 == 30)
			{
				break;
			}
			Class10.Class19 class19_ = class16_0.class19_0;
			bool bool_ = (class16_0.int_0 & 4) != 0;
			bool bool_2 = (class16_0.int_0 & 8) != 0;
			if (Class29.smethod_155(bool_, bool_2, class19_))
			{
				continue;
			}
			if (class16_0.int_0 != 16)
			{
				if (class16_0.int_0 == 20)
				{
					for (int num5 = 8 + (-Class29.smethod_117(class16_0.class20_0) & 7); num5 > 0; num5 -= 10)
					{
						Class29.smethod_106(class16_0.class20_0, 2, 10);
					}
					class16_0.int_0 = 16;
				}
				else if (class16_0.int_0 == 28)
				{
					Class29.smethod_122(class16_0.class20_0);
					class16_0.int_0 = 30;
				}
				continue;
			}
			return num3 - num2;
		}
		return num3 - num2;
	}

	static void smethod_20(Class45 class45_0, Delegate4 delegate4_0)
	{
		if (class45_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService1 uploadReportLoginService = new UploadReportLoginService1();
				if (class45_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class45_0.iwebProxy_0);
				}
				class45_0.string_2 = uploadReportLoginService.GetServerURL(class45_0.string_1);
				if (class45_0.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (class45_0.string_2 == "ditto")
				{
					class45_0.string_2 = Class45.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate4_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate4_0(class45_0.string_2.StartsWith("ERR") ? class45_0.string_2 : "OK");
	}

	static void smethod_21(Class10.Class19 class19_0, byte[] byte_0)
	{
		class19_0.byte_1 = byte_0;
		class19_0.int_7 = 0;
		class19_0.int_8 = byte_0.Length;
	}

	static bool smethod_22(Class24 class24_0, string string_0)
	{
		try
		{
			byte[] byte_ = class24_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class29.smethod_175(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class29.smethod_103(byte_2, "<RSAKeyValue><Modulus>lkDxqBuIcgpdBAwh556xapPCo6rxZwhr8W4DUJcOwkCJLbW025KFyM1tzV7TvxPm7F3hodp/A/rXYt1ABbF52ZGUNZ7+JCSibwr4hOcDrkejKKqGkZ3ZlQREZsJ4mTKtyyCIZRmv8KhssXGHXPab1qNup+gHs3eCMrGyf3t7Umk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes("{92D2F7FD-A57F-4267-8A28-6C0BFBF28D32}");
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
			return true;
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	static void smethod_23(Class10.Class16 class16_0)
	{
		class16_0.int_0 |= 12;
	}

	static void smethod_24(int int_0, Class10.Class17 class17_0)
	{
		Class29.smethod_114(class17_0.class18_2);
		Class29.smethod_114(class17_0.class18_0);
		Class29.smethod_114(class17_0.class18_1);
		Class29.smethod_106(class17_0.class20_0, class17_0.class18_0.int_1 - 257, 5);
		Class29.smethod_106(class17_0.class20_0, class17_0.class18_1.int_1 - 1, 5);
		Class29.smethod_106(class17_0.class20_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class29.smethod_106(class17_0.class20_0, (int)class17_0.class18_2.byte_0[Class10.Class17.int_0[i]], 3);
		}
		Class29.smethod_113(class17_0.class18_0, class17_0.class18_2);
		Class29.smethod_113(class17_0.class18_1, class17_0.class18_2);
	}

	static void smethod_25(int int_0, Class10.Stream0 stream0_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static bool smethod_26(Class10.Class19 class19_0, int int_0)
	{
		int num = 128;
		int num2 = 128;
		short[] short_ = class19_0.short_1;
		int int_ = class19_0.int_4;
		int num3 = class19_0.int_4 + class19_0.int_2;
		int num4 = Math.Max(class19_0.int_2, 2);
		int num5 = Math.Max(class19_0.int_4 - 32506, 0);
		int num6 = class19_0.int_4 + 258 - 1;
		byte b = class19_0.byte_0[num3 - 1];
		byte b2 = class19_0.byte_0[num3];
		if (num4 >= 8)
		{
			num >>= 2;
		}
		if (num2 > class19_0.int_5)
		{
			num2 = class19_0.int_5;
		}
		do
		{
			if (class19_0.byte_0[int_0 + num4] != b2 || class19_0.byte_0[int_0 + num4 - 1] != b || class19_0.byte_0[int_0] != class19_0.byte_0[int_] || class19_0.byte_0[int_0 + 1] != class19_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num7 = int_0 + 2;
			int_ += 2;
			while (class19_0.byte_0[++int_] == class19_0.byte_0[++num7] && class19_0.byte_0[++int_] == class19_0.byte_0[++num7] && class19_0.byte_0[++int_] == class19_0.byte_0[++num7] && class19_0.byte_0[++int_] == class19_0.byte_0[++num7] && class19_0.byte_0[++int_] == class19_0.byte_0[++num7] && class19_0.byte_0[++int_] == class19_0.byte_0[++num7] && class19_0.byte_0[++int_] == class19_0.byte_0[++num7] && class19_0.byte_0[++int_] == class19_0.byte_0[++num7] && int_ < num6)
			{
			}
			if (int_ > num3)
			{
				class19_0.int_1 = int_0;
				num3 = int_;
				num4 = int_ - class19_0.int_4;
				if (num4 >= num2)
				{
					break;
				}
				b = class19_0.byte_0[num3 - 1];
				b2 = class19_0.byte_0[num3];
			}
			int_ = class19_0.int_4;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num5 && --num != 0);
		class19_0.int_2 = Math.Min(num4, class19_0.int_5);
		return class19_0.int_2 >= 3;
	}

	static void smethod_27(Class10.Class12 class12_0, int int_0)
	{
		class12_0.uint_0 >>= int_0;
		class12_0.int_2 -= int_0;
	}

	static void smethod_28(int[] int_0, Class10.Class17.Class18 class18_0)
	{
		class18_0.byte_0 = new byte[class18_0.short_0.Length];
		int num = int_0.Length / 2;
		int num2 = (num + 1) / 2;
		int num3 = 0;
		for (int i = 0; i < class18_0.int_3; i++)
		{
			class18_0.int_2[i] = 0;
		}
		int[] array = new int[num];
		array[num - 1] = 0;
		for (int num4 = num - 1; num4 >= 0; num4--)
		{
			if (int_0[2 * num4 + 1] != -1)
			{
				int num5 = array[num4] + 1;
				if (num5 > class18_0.int_3)
				{
					num5 = class18_0.int_3;
					num3++;
				}
				array[int_0[2 * num4]] = (array[int_0[2 * num4 + 1]] = num5);
			}
			else
			{
				int num6 = array[num4];
				class18_0.int_2[num6 - 1]++;
				class18_0.byte_0[int_0[2 * num4]] = (byte)array[num4];
			}
		}
		if (num3 == 0)
		{
			return;
		}
		int num7 = class18_0.int_3 - 1;
		while (true)
		{
			if (class18_0.int_2[--num7] != 0)
			{
				do
				{
					class18_0.int_2[num7]--;
					class18_0.int_2[++num7]++;
					num3 -= 1 << class18_0.int_3 - 1 - num7;
				}
				while (num3 > 0 && num7 < class18_0.int_3 - 1);
				if (num3 <= 0)
				{
					break;
				}
			}
		}
		class18_0.int_2[class18_0.int_3 - 1] += num3;
		class18_0.int_2[class18_0.int_3 - 2] -= num3;
		int num8 = 2 * num2;
		for (int num9 = class18_0.int_3; num9 != 0; num9--)
		{
			int num10 = class18_0.int_2[num9 - 1];
			while (num10 > 0)
			{
				int num11 = 2 * int_0[num8++];
				if (int_0[num11 + 1] == -1)
				{
					class18_0.byte_0[int_0[num11]] = (byte)num9;
					num10--;
				}
			}
		}
	}

	static byte[] smethod_29(byte[] byte_0, string string_0)
	{
		if (string_0.StartsWith("{"))
		{
			Class39.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
			return null;
		}
		RijndaelManaged rijndaelManaged = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		byte[] result;
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(string_0);
			rijndaelManaged.GenerateKey();
			rijndaelManaged.GenerateIV();
			byte[] array = new byte[48];
			Buffer.BlockCopy(rijndaelManaged.Key, 0, array, 0, 32);
			Buffer.BlockCopy(rijndaelManaged.IV, 0, array, 32, 16);
			memoryStream = new MemoryStream();
			try
			{
				byte[] array2 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
				memoryStream.WriteByte(1);
				memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
				memoryStream.Write(array2, 0, array2.Length);
			}
			catch (CryptographicException)
			{
				try
				{
					byte[] array3 = new byte[16];
					byte[] array4 = new byte[16];
					Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
					Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
					byte[] array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
					byte[] array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
					memoryStream.WriteByte(2);
					memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
					memoryStream.Write(array5, 0, array5.Length);
					memoryStream.Write(array6, 0, array6.Length);
					memoryStream.Write(array7, 0, array7.Length);
					goto end_IL_00ad;
				}
				catch (CryptographicException)
				{
					Class39.string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
					result = null;
				}
				goto end_IL_0027;
				end_IL_00ad:;
			}
			cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			result = memoryStream.ToArray();
			end_IL_0027:;
		}
		catch (Exception ex3)
		{
			Class39.string_0 = "ERR 2004: " + ex3.Message;
			result = null;
		}
		finally
		{
			rijndaelManaged?.Clear();
			rSACryptoServiceProvider?.Clear();
			memoryStream?.Close();
			cryptoStream?.Close();
		}
		return result;
	}

	static int smethod_30(int int_0, Class10.Class17 class17_0)
	{
		if (int_0 == 255)
		{
			return 285;
		}
		int num = 257;
		while (int_0 >= 8)
		{
			num += 4;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static byte[] smethod_31(int int_0, byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			Class10.Stream0 stream = new Class10.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class10.Class16 class16_2 = new Class10.Class16();
				DateTime now = DateTime.Now;
				long num3 = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
				uint[] array8 = new uint[256]
				{
					0u, 1996959894u, 3993919788u, 2567524794u, 124634137u, 1886057615u, 3915621685u, 2657392035u, 249268274u, 2044508324u,
					3772115230u, 2547177864u, 162941995u, 2125561021u, 3887607047u, 2428444049u, 498536548u, 1789927666u, 4089016648u, 2227061214u,
					450548861u, 1843258603u, 4107580753u, 2211677639u, 325883990u, 1684777152u, 4251122042u, 2321926636u, 335633487u, 1661365465u,
					4195302755u, 2366115317u, 997073096u, 1281953886u, 3579855332u, 2724688242u, 1006888145u, 1258607687u, 3524101629u, 2768942443u,
					901097722u, 1119000684u, 3686517206u, 2898065728u, 853044451u, 1172266101u, 3705015759u, 2882616665u, 651767980u, 1373503546u,
					3369554304u, 3218104598u, 565507253u, 1454621731u, 3485111705u, 3099436303u, 671266974u, 1594198024u, 3322730930u, 2970347812u,
					795835527u, 1483230225u, 3244367275u, 3060149565u, 1994146192u, 31158534u, 2563907772u, 4023717930u, 1907459465u, 112637215u,
					2680153253u, 3904427059u, 2013776290u, 251722036u, 2517215374u, 3775830040u, 2137656763u, 141376813u, 2439277719u, 3865271297u,
					1802195444u, 476864866u, 2238001368u, 4066508878u, 1812370925u, 453092731u, 2181625025u, 4111451223u, 1706088902u, 314042704u,
					2344532202u, 4240017532u, 1658658271u, 366619977u, 2362670323u, 4224994405u, 1303535960u, 984961486u, 2747007092u, 3569037538u,
					1256170817u, 1037604311u, 2765210733u, 3554079995u, 1131014506u, 879679996u, 2909243462u, 3663771856u, 1141124467u, 855842277u,
					2852801631u, 3708648649u, 1342533948u, 654459306u, 3188396048u, 3373015174u, 1466479909u, 544179635u, 3110523913u, 3462522015u,
					1591671054u, 702138776u, 2966460450u, 3352799412u, 1504918807u, 783551873u, 3082640443u, 3233442989u, 3988292384u, 2596254646u,
					62317068u, 1957810842u, 3939845945u, 2647816111u, 81470997u, 1943803523u, 3814918930u, 2489596804u, 225274430u, 2053790376u,
					3826175755u, 2466906013u, 167816743u, 2097651377u, 4027552580u, 2265490386u, 503444072u, 1762050814u, 4150417245u, 2154129355u,
					426522225u, 1852507879u, 4275313526u, 2312317920u, 282753626u, 1742555852u, 4189708143u, 2394877945u, 397917763u, 1622183637u,
					3604390888u, 2714866558u, 953729732u, 1340076626u, 3518719985u, 2797360999u, 1068828381u, 1219638859u, 3624741850u, 2936675148u,
					906185462u, 1090812512u, 3747672003u, 2825379669u, 829329135u, 1181335161u, 3412177804u, 3160834842u, 628085408u, 1382605366u,
					3423369109u, 3138078467u, 570562233u, 1426400815u, 3317316542u, 2998733608u, 733239954u, 1555261956u, 3268935591u, 3050360625u,
					752459403u, 1541320221u, 2607071920u, 3965973030u, 1969922972u, 40735498u, 2617837225u, 3943577151u, 1913087877u, 83908371u,
					2512341634u, 3803740692u, 2075208622u, 213261112u, 2463272603u, 3855990285u, 2094854071u, 198958881u, 2262029012u, 4057260610u,
					1759359992u, 534414190u, 2176718541u, 4139329115u, 1873836001u, 414664567u, 2282248934u, 4279200368u, 1711684554u, 285281116u,
					2405801727u, 4167216745u, 1634467795u, 376229701u, 2685067896u, 3608007406u, 1308918612u, 956543938u, 2808555105u, 3495958263u,
					1231636301u, 1047427035u, 2932959818u, 3654703836u, 1088359270u, 936918000u, 2847714899u, 3736837829u, 1202900863u, 817233897u,
					3183342108u, 3401237130u, 1404277552u, 615818150u, 3134207493u, 3453421203u, 1423857449u, 601450431u, 3009837614u, 3294710456u,
					1567103746u, 711928724u, 3020668471u, 3272380065u, 1510334235u, 755167117u
				};
				uint num4 = uint.MaxValue;
				uint num5 = uint.MaxValue;
				int num6 = 0;
				int num7 = byte_0.Length;
				while (--num7 >= 0)
				{
					num5 = array8[(num5 ^ byte_0[num6++]) & 0xFF] ^ (num5 >> 8);
				}
				num5 ^= num4;
				Class29.smethod_16(67324752, stream);
				Class29.smethod_25(20, stream);
				Class29.smethod_25(0, stream);
				Class29.smethod_25(8, stream);
				Class29.smethod_16((int)num3, stream);
				Class29.smethod_16((int)num5, stream);
				long position3 = stream.Position;
				Class29.smethod_16(0, stream);
				Class29.smethod_16(byte_0.Length, stream);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class29.smethod_25(bytes.Length, stream);
				Class29.smethod_25(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class29.smethod_55(byte_0, class16_2);
				while (!Class29.smethod_115(class16_2))
				{
					byte[] array9 = new byte[512];
					int num8 = Class29.smethod_19(class16_2, array9);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				Class29.smethod_23(class16_2);
				while (!Class29.smethod_154(class16_2))
				{
					byte[] array10 = new byte[512];
					int num9 = Class29.smethod_19(class16_2, array10);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long num10 = Class29.smethod_133(class16_2);
				Class29.smethod_16(33639248, stream);
				Class29.smethod_25(20, stream);
				Class29.smethod_25(20, stream);
				Class29.smethod_25(0, stream);
				Class29.smethod_25(8, stream);
				Class29.smethod_16((int)num3, stream);
				Class29.smethod_16((int)num5, stream);
				Class29.smethod_16((int)num10, stream);
				Class29.smethod_16(byte_0.Length, stream);
				Class29.smethod_25(bytes.Length, stream);
				Class29.smethod_25(0, stream);
				Class29.smethod_25(0, stream);
				Class29.smethod_25(0, stream);
				Class29.smethod_25(0, stream);
				Class29.smethod_16(0, stream);
				Class29.smethod_16(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class29.smethod_16(101010256, stream);
				Class29.smethod_25(0, stream);
				Class29.smethod_25(0, stream);
				Class29.smethod_25(1, stream);
				Class29.smethod_25(1, stream);
				Class29.smethod_16(46 + bytes.Length, stream);
				Class29.smethod_16((int)(30 + bytes.Length + num10), stream);
				Class29.smethod_25(0, stream);
				stream.Seek(position3, SeekOrigin.Begin);
				Class29.smethod_16((int)num10, stream);
				break;
			}
			case 1:
			{
				Class29.smethod_16(25000571, stream);
				Class29.smethod_16(byte_0.Length, stream);
				byte[] array5;
				for (int i = 0; i < byte_0.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_0.Length - i)];
					Buffer.BlockCopy(byte_0, i, array5, 0, array5.Length);
					long position = stream.Position;
					Class29.smethod_16(0, stream);
					Class29.smethod_16(array5.Length, stream);
					Class10.Class16 class16_ = new Class10.Class16();
					Class29.smethod_55(array5, class16_);
					while (!Class29.smethod_115(class16_))
					{
						byte[] array6 = new byte[512];
						int num = Class29.smethod_19(class16_, array6);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					Class29.smethod_23(class16_);
					while (!Class29.smethod_154(class16_))
					{
						byte[] array7 = new byte[512];
						int num2 = Class29.smethod_19(class16_, array7);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					Class29.smethod_16((int)Class29.smethod_133(class16_), stream);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				Class29.smethod_16(41777787, stream);
				byte[] array3 = Class29.smethod_31(1, byte_0, (byte[])null, (byte[])null);
				using (ICryptoTransform cryptoTransform2 = Class29.smethod_158(byte_1, byte_2, bool_0: false))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class29.smethod_16(58555003, stream);
				byte[] array = Class29.smethod_31(1, byte_0, (byte[])null, (byte[])null);
				using (ICryptoTransform cryptoTransform = Class29.smethod_105(bool_0: false, byte_2, byte_1))
				{
					byte[] array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
					stream.Write(array2, 0, array2.Length);
				}
				break;
			}
			}
			stream.Flush();
			stream.Close();
			return stream.ToArray();
		}
		catch (Exception ex)
		{
			Class10.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static string smethod_32()
	{
		return "Software\\Wow6432Node\\Red Gate\\" + Class29.smethod_145();
	}

	static void smethod_33(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class29.smethod_42(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static void smethod_34(string string_0, long long_0)
	{
		using IsolatedStorageFileStream isolatedStorageFileStream = Class29.smethod_17(FileAccess.ReadWrite, FileMode.OpenOrCreate, string_0);
		isolatedStorageFileStream.Position = long_0 + 8L;
		isolatedStorageFileStream.Position = long_0;
		ulong num = new BinaryReader(isolatedStorageFileStream).ReadUInt64();
		num++;
		isolatedStorageFileStream.Position = long_0;
		new BinaryWriter(isolatedStorageFileStream).Write(num);
	}

	static void smethod_35(uint uint_0)
	{
		Class52 class51_ = new Class52();
		Class29.smethod_201((Class51)class51_, uint_0);
	}

	static string smethod_36(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.string_0;
	}

	static Dictionary<string, ulong> smethod_37(Class48 class48_0)
	{
		return class48_0.dictionary_0;
	}

	static string smethod_38()
	{
		try
		{
			return Application.get_ExecutablePath();
		}
		catch
		{
			return "N/A";
		}
	}

	static void smethod_39(Class23 class23_0, Enum0 enum0_0, string string_0, string string_1)
	{
		class23_0.delegate1_0?.Invoke(class23_0, new EventArgs3(enum0_0, string_0, string_1));
	}

	static string smethod_40()
	{
		return "Software\\Red Gate\\" + Class29.smethod_145();
	}

	static bool smethod_41(Class10.Class11 class11_0)
	{
		int num = Class29.smethod_118(class11_0.class13_0);
		while (num >= 258)
		{
			switch (class11_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class29.smethod_94(class11_0.class14_0, class11_0.class12_0)) & -256) == 0)
				{
					Class29.smethod_125(class11_0.class13_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class11_0.int_6 = Class10.Class11.int_0[num2 - 257];
					class11_0.int_5 = Class10.Class11.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class11_0.class14_1 = null;
				class11_0.class14_0 = null;
				class11_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class11_0.int_5 > 0)
				{
					class11_0.int_4 = 8;
					int num4 = Class29.smethod_136(class11_0.class12_0, class11_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class29.smethod_27(class11_0.class12_0, class11_0.int_5);
					class11_0.int_6 += num4;
				}
				class11_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class29.smethod_94(class11_0.class14_1, class11_0.class12_0);
				if (num2 >= 0)
				{
					class11_0.int_7 = Class10.Class11.int_2[num2];
					class11_0.int_5 = Class10.Class11.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class11_0.int_5 > 0)
				{
					class11_0.int_4 = 10;
					int num3 = Class29.smethod_136(class11_0.class12_0, class11_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class29.smethod_27(class11_0.class12_0, class11_0.int_5);
					class11_0.int_7 += num3;
				}
				Class29.smethod_157(class11_0.class13_0, class11_0.int_6, class11_0.int_7);
				num -= class11_0.int_6;
				class11_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_42(Exception exception_0, object[] object_0)
	{
		int int_ = -1;
		int int_2 = -1;
		int num = 0;
		StackTrace stackTrace = new StackTrace(exception_0);
		try
		{
			if (exception_0.StackTrace != null)
			{
				string[] array = exception_0.StackTrace!.Split('\r', '\n');
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text.Length > 0)
					{
						num++;
					}
				}
			}
		}
		catch
		{
			num = -1;
		}
		try
		{
			if (stackTrace.FrameCount > 0)
			{
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int_ = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				int_2 = frame.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(int_, object_0, int_2, num);
			LinkedList<object> linkedList;
			if (!exception_0.Data.Contains("SmartStackFrames"))
			{
				linkedList = new LinkedList<object>();
				exception_0.Data["SmartStackFrames"] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)exception_0.Data["SmartStackFrames"];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	static void smethod_43(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class29.smethod_42(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	static bool smethod_44(Class28 class28_0)
	{
		return class28_0.bool_0;
	}

	static Exception smethod_45(EventArgs0 eventArgs0_0)
	{
		return eventArgs0_0.exception_0;
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStr)] string string_0);

	static int smethod_46(Class24.Struct10 struct10_0, Class24 class24_0)
	{
		string key = struct10_0.struct9_0.string_0.ToUpper();
		if (class24_0.dictionary_3.ContainsKey(key))
		{
			return class24_0.dictionary_3[key];
		}
		int count = class24_0.list_2.Count;
		class24_0.list_2.Add(struct10_0.struct9_0);
		class24_0.dictionary_3.Add(key, count);
		return count;
	}

	static bool smethod_47(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_0;
	}

	static bool smethod_48(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_0.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_1.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			return false;
		}
		if (publicKey2 != null)
		{
			for (int i = 0; i < publicKey2.Length; i++)
			{
				if (publicKey2[i] != publicKey[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	static void smethod_49(Exception exception_0, object object_0)
	{
		Class29.smethod_42(exception_0, new object[1] { object_0 });
	}

	static SecurityException smethod_50(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.securityException_0;
	}

	static int smethod_51(Class10.Class12 class12_0)
	{
		return class12_0.int_1 - class12_0.int_0 + (class12_0.int_2 >> 3);
	}

	static void smethod_52()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				MemoryManager.memoryManager_0 = new MemoryManager();
			}
		}
		catch
		{
		}
	}

	static void smethod_53(EventArgs2 eventArgs2_0, bool bool_0)
	{
		eventArgs2_0.bool_0 = bool_0;
	}

	static void smethod_54(Class10.Class20 class20_0, int int_0)
	{
		class20_0.byte_0[class20_0.int_1++] = (byte)int_0;
		class20_0.byte_0[class20_0.int_1++] = (byte)(int_0 >> 8);
	}

	static void smethod_55(byte[] byte_0, Class10.Class16 class16_0)
	{
		Class29.smethod_21(class16_0.class19_0, byte_0);
	}

	static object smethod_56(Class28 class28_0)
	{
		return class28_0.object_0;
	}

	static void smethod_57(Class10.Class17.Class18 class18_0, Class10.Class17.Class18 class18_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class18_0.int_1)
		{
			int num3 = 1;
			int num4 = class18_0.byte_0[num2];
			int num5;
			int num6;
			if (num4 == 0)
			{
				num5 = 138;
				num6 = 3;
			}
			else
			{
				num5 = 6;
				num6 = 3;
				if (num != num4)
				{
					class18_1.short_0[num4]++;
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class18_0.int_1 && num == class18_0.byte_0[num2])
			{
				num2++;
				if (++num3 >= num5)
				{
					break;
				}
			}
			if (num3 < num6)
			{
				class18_1.short_0[num] += (short)num3;
			}
			else if (num != 0)
			{
				class18_1.short_0[16]++;
			}
			else if (num3 <= 10)
			{
				class18_1.short_0[17]++;
			}
			else
			{
				class18_1.short_0[18]++;
			}
		}
	}

	static IDisposable smethod_58()
	{
		return new Class49.Class50(Class49.string_3);
	}

	static Class10.Class14 smethod_59(Class10.Class15 class15_0)
	{
		byte[] array = new byte[class15_0.int_4];
		Array.Copy(class15_0.byte_1, class15_0.int_3, array, 0, class15_0.int_4);
		return new Class10.Class14(array);
	}

	static int smethod_60(Class10.Class13 class13_0, Class10.Class12 class12_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class13_0.int_1), Class29.smethod_51(class12_0));
		int num = 32768 - class13_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class29.smethod_165(class12_0, class13_0.byte_0, class13_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class29.smethod_165(class12_0, class13_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class29.smethod_165(class12_0, class13_0.byte_0, class13_0.int_0, int_0);
		}
		class13_0.int_0 = (class13_0.int_0 + num2) & 0x7FFF;
		class13_0.int_1 += num2;
		return num2;
	}

	static void smethod_61()
	{
		try
		{
			if (Class29.smethod_110("v4"))
			{
				Class47.smethod_0("Platform: .NET 4.0 installed");
			}
			else if (Class29.smethod_110("v3.5"))
			{
				Class47.smethod_0("Platform: .NET 3.5 installed");
			}
			else if (Class29.smethod_110("v3.0"))
			{
				Class47.smethod_0("Platform: .NET 3.0 installed");
			}
			else if (Class29.smethod_110("v2.0.50727"))
			{
				Class47.smethod_0("Platform: .NET 2.0 installed");
			}
			else if (Class29.smethod_110("v1.1.4322"))
			{
				Class47.smethod_0("Platform: .NET 1.1 installed");
			}
			switch (Environment.OSVersion.Version.Major)
			{
			case 5:
				switch (Environment.OSVersion.Version.Minor)
				{
				case 0:
					Class47.smethod_0("Platform: Windows 2000");
					break;
				case 1:
					Class47.smethod_0("Platform: Windows XP");
					break;
				case 2:
					Class47.smethod_0("Platform: Windows 2003");
					break;
				}
				break;
			case 6:
				switch (Environment.OSVersion.Version.Minor)
				{
				case 0:
					Class47.smethod_0("Platform: Windows Vista/2008");
					break;
				case 1:
					Class47.smethod_0("Platform: Windows 7/2008 R2");
					break;
				case 2:
					Class47.smethod_0("Platform: Windows 8");
					break;
				}
				break;
			}
			Class29.smethod_189();
			Class29.smethod_62();
			Class29.smethod_71();
		}
		catch
		{
		}
	}

	static void smethod_62()
	{
		try
		{
			Class47.smethod_0("Platform Culture Name: " + CultureInfo.CurrentCulture.Name);
		}
		catch
		{
		}
	}

	static void smethod_63(Delegate4 delegate4_0, Class45 class45_0, byte[] byte_0, string string_0, string string_1, string string_2)
	{
		try
		{
			ReportingService1 reportingService = new ReportingService1(class45_0.string_2);
			if (class45_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class45_0.iwebProxy_0);
			}
			delegate4_0(reportingService.UploadReport2(class45_0.string_1, byte_0, string_0, string_1, string_2));
		}
		catch (Exception ex)
		{
			delegate4_0("ERR 2002: " + ex.Message);
		}
	}

	static void smethod_64(byte[] byte_0, short[] short_0, Class10.Class17.Class18 class18_0)
	{
		class18_0.short_1 = short_0;
		class18_0.byte_0 = byte_0;
	}

	static void smethod_65(Class40 class40_0, Delegate3 delegate3_0)
	{
		Delegate3 @delegate = class40_0.delegate3_0;
		Delegate3 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate3 value = (Delegate3)Delegate.Combine(delegate2, delegate3_0);
			@delegate = Interlocked.CompareExchange(ref class40_0.delegate3_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static void smethod_66(Class10.Class14 class14_0, byte[] byte_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				array[num]++;
			}
		}
		int num2 = 0;
		int num3 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num2;
			num2 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num4 = array2[j] & 0x1FF80;
				int num5 = num2 & 0x1FF80;
				num3 += num5 - num4 >> 16 - j;
			}
		}
		class14_0.short_0 = new short[num3];
		int num6 = 512;
		for (int num7 = 15; num7 >= 10; num7--)
		{
			int num8 = num2 & 0x1FF80;
			num2 -= array[num7] << 16 - num7;
			int num9 = num2 & 0x1FF80;
			for (int k = num9; k < num8; k += 128)
			{
				class14_0.short_0[Class29.smethod_182(k)] = (short)((-num6 << 4) | num7);
				num6 += 1 << num7 - 9;
			}
		}
		for (int l = 0; l < byte_0.Length; l++)
		{
			int num10 = byte_0[l];
			if (num10 == 0)
			{
				continue;
			}
			num2 = array2[num10];
			int num11 = Class29.smethod_182(num2);
			if (num10 <= 9)
			{
				do
				{
					class14_0.short_0[num11] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < 512);
			}
			else
			{
				int num12 = class14_0.short_0[num11 & 0x1FF];
				int num13 = 1 << (num12 & 0xF);
				num12 = -(num12 >> 4);
				do
				{
					class14_0.short_0[num12 | (num11 >> 9)] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < num13);
			}
			array2[num10] = num2 + (1 << 16 - num10);
		}
	}

	static string smethod_67()
	{
		return "SmartAssembly";
	}

	static void smethod_68(byte[] byte_0, int int_0, int int_1, bool bool_0, Class10.Class17 class17_0)
	{
		class17_0.class18_0.short_0[256]++;
		Class29.smethod_6(class17_0.class18_0);
		Class29.smethod_6(class17_0.class18_1);
		Class29.smethod_57(class17_0.class18_0, class17_0.class18_2);
		Class29.smethod_57(class17_0.class18_1, class17_0.class18_2);
		Class29.smethod_6(class17_0.class18_2);
		int num = 4;
		for (int num2 = 18; num2 > num; num2--)
		{
			if (class17_0.class18_2.byte_0[Class10.Class17.int_0[num2]] > 0)
			{
				num = num2 + 1;
			}
		}
		int num3 = 14 + num * 3 + Class29.smethod_162(class17_0.class18_2) + Class29.smethod_162(class17_0.class18_0) + Class29.smethod_162(class17_0.class18_1) + class17_0.int_2;
		int num4 = class17_0.int_2;
		for (int i = 0; i < 286; i++)
		{
			num4 += class17_0.class18_0.short_0[i] * Class10.Class17.byte_2[i];
		}
		for (int j = 0; j < 30; j++)
		{
			num4 += class17_0.class18_1.short_0[j] * Class10.Class17.byte_3[j];
		}
		if (num3 >= num4)
		{
			num3 = num4;
		}
		if (int_0 >= 0 && int_1 + 4 < num3 >> 3)
		{
			Class29.smethod_169(int_1, class17_0, int_0, byte_0, bool_0);
		}
		else if (num3 == num4)
		{
			Class29.smethod_106(class17_0.class20_0, 2 + (bool_0 ? 1 : 0), 3);
			Class10.Class17.Class18 class18_ = class17_0.class18_0;
			short[] short_ = Class10.Class17.short_1;
			byte[] byte_ = Class10.Class17.byte_2;
			Class29.smethod_64(byte_, short_, class18_);
			class18_ = class17_0.class18_1;
			short_ = Class10.Class17.short_2;
			byte_ = Class10.Class17.byte_3;
			Class29.smethod_64(byte_, short_, class18_);
			Class29.smethod_90(class17_0);
			Class29.smethod_198(class17_0);
		}
		else
		{
			Class29.smethod_106(class17_0.class20_0, 4 + (bool_0 ? 1 : 0), 3);
			Class29.smethod_24(num, class17_0);
			Class29.smethod_90(class17_0);
			Class29.smethod_198(class17_0);
		}
	}

	static void smethod_69(Form0 form0_0, ThreadStart threadStart_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static bool smethod_70(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_0;
	}

	static void smethod_71()
	{
		try
		{
			Class47.smethod_0("Platform OS Bitness: " + (Class29.smethod_72() ? 64 : 32));
		}
		catch
		{
		}
	}

	static bool smethod_72()
	{
		if (IntPtr.Size == 8)
		{
			return true;
		}
		if (Class29.smethod_159("kernel32.dll", "IsWow64Process") && Class29.IsWow64Process(Class29.GetCurrentProcess(), out bool bool_))
		{
			return bool_;
		}
		return false;
	}

	static void smethod_73(IWebProxy iwebProxy_0, Class35 class35_0)
	{
		class35_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_74(Control1 control1_0, Enum1 enum1_0)
	{
		if (control1_0.enum1_0 != enum1_0)
		{
			control1_0.enum1_0 = enum1_0;
			switch (control1_0.enum1_0)
			{
			default:
				control1_0.bitmap_0 = null;
				break;
			case Enum1.const_1:
				control1_0.bitmap_0 = Class29.smethod_211("error16");
				break;
			case Enum1.const_2:
				control1_0.bitmap_0 = Class29.smethod_211("warning16");
				break;
			}
			((Control)control1_0).Refresh();
		}
	}

	static string smethod_75(Class40.Class44 class44_0)
	{
		return class44_0.string_1;
	}

	static void smethod_76(Class32 class32_0)
	{
		try
		{
			Graphics val = ((Control)class32_0).CreateGraphics();
			try
			{
				string text = ((Control)class32_0).get_Text();
				Font font = ((Control)class32_0).get_Font();
				int width = ((Control)class32_0).get_Width();
				int num = Class29.smethod_184(font, width, val, text);
				if (num > 0)
				{
					((Control)class32_0).set_Height(num);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}

	static int smethod_77(string string_0, Font font_0, Graphics graphics_0, int int_0)
	{
		Class36.Struct11 struct11_ = new Class36.Struct11(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = Class29.SelectObject(hdc, intptr_);
		Class29.DrawText(hdc, string_0, -1, ref struct11_, 3088);
		Class29.SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct11_.int_3 - struct11_.int_1;
	}

	static string smethod_78(Class23.Class27 class27_0)
	{
		return class27_0.string_2;
	}

	static int smethod_79(Class10.Class12 class12_0)
	{
		return class12_0.int_2;
	}

	static Icon smethod_80()
	{
		int int_ = 0;
		int int_2 = 0;
		int num = Class29.ExtractIconEx(Application.get_ExecutablePath(), -1, ref int_2, ref int_2, 1);
		if (num > 0)
		{
			Class29.ExtractIconEx(Application.get_ExecutablePath(), 0, ref int_, ref int_2, 1);
			if (int_ != 0)
			{
				return Icon.FromHandle(new IntPtr(int_));
			}
		}
		return null;
	}

	static void smethod_81(int int_0, byte[] byte_0, int int_1, Class10.Class12 class12_0)
	{
		if (class12_0.int_0 < class12_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class12_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class12_0.int_2);
				class12_0.int_2 += 8;
			}
			class12_0.byte_0 = byte_0;
			class12_0.int_0 = int_1;
			class12_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static int smethod_82(Class10.Class19 class19_0)
	{
		int num = ((class19_0.int_0 << 5) ^ class19_0.byte_0[class19_0.int_4 + 2]) & 0x7FFF;
		short num2 = (class19_0.short_1[class19_0.int_4 & 0x7FFF] = class19_0.short_0[num]);
		class19_0.short_0[num] = (short)class19_0.int_4;
		class19_0.int_0 = num;
		return num2 & 0xFFFF;
	}

	static bool smethod_83(Class10.Class20 class20_0)
	{
		return class20_0.int_1 == 0;
	}

	static void smethod_84(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class29.smethod_42(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static void smethod_85(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class29.smethod_42(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static void smethod_86(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = null;
		control0_0.bool_0 = false;
		control0_0.string_0 = string.Empty;
		((Control)control0_0).Refresh();
		((Control)control0_0).set_Height(16);
	}

	static bool smethod_87(Class48 class48_0)
	{
		if (class48_0.ulong_0.Length == 0)
		{
			return class48_0.dictionary_0.Count == 0;
		}
		return false;
	}

	static void smethod_88(Class24 class24_0, EventArgs0 eventArgs0_0)
	{
		class24_0.delegate0_0?.Invoke(class24_0, eventArgs0_0);
	}

	static void smethod_89(int int_0, int int_1, byte[] byte_0, Class10.Class20 class20_0)
	{
		Array.Copy(byte_0, int_1, class20_0.byte_0, class20_0.int_1, int_0);
		class20_0.int_1 += int_0;
	}

	static void smethod_90(Class10.Class17 class17_0)
	{
		for (int i = 0; i < class17_0.int_1; i++)
		{
			int num = class17_0.byte_1[i] & 0xFF;
			int num2 = class17_0.short_0[i];
			if (num2-- != 0)
			{
				int num3 = Class29.smethod_30(num, class17_0);
				Class29.smethod_195(class17_0.class18_0, num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					Class29.smethod_106(class17_0.class20_0, num & ((1 << num4) - 1), num4);
				}
				int num5 = Class29.smethod_134(class17_0, num2);
				Class29.smethod_195(class17_0.class18_1, num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					Class29.smethod_106(class17_0.class20_0, num2 & ((1 << num4) - 1), num4);
				}
			}
			else
			{
				Class29.smethod_195(class17_0.class18_0, num);
			}
		}
		Class29.smethod_195(class17_0.class18_0, 256);
	}

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_91(Class33 class33_0)
	{
		if (class33_0 != null)
		{
			Class33.class33_0 = class33_0;
			AppDomain.CurrentDomain.UnhandledException += class33_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class33_0.method_0);
		}
	}

	static void smethod_92(string string_0, Class51 class51_0)
	{
		try
		{
			lock (Class51.object_0)
			{
				Class29.smethod_4(class51_0);
				Class29.smethod_98(string_0);
			}
		}
		catch
		{
		}
	}

	static bool smethod_93()
	{
		return Class29.smethod_116().byte_0 == 1;
	}

	static int smethod_94(Class10.Class14 class14_0, Class10.Class12 class12_0)
	{
		int num;
		int num2;
		if ((num = Class29.smethod_136(class12_0, 9)) >= 0)
		{
			if ((num2 = class14_0.short_0[num]) >= 0)
			{
				Class29.smethod_27(class12_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class29.smethod_136(class12_0, int_)) >= 0)
			{
				num2 = class14_0.short_0[num3 | (num >> 9)];
				Class29.smethod_27(class12_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num4 = Class29.smethod_79(class12_0);
			num = Class29.smethod_136(class12_0, num4);
			num2 = class14_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= num4)
			{
				Class29.smethod_27(class12_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int num5 = Class29.smethod_79(class12_0);
		num = Class29.smethod_136(class12_0, num5);
		num2 = class14_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= num5)
		{
			Class29.smethod_27(class12_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static Icon smethod_95(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".ico");
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static byte[] smethod_96(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class29.smethod_48(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class10.Stream0 stream = new Class10.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class29.smethod_212(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class29.smethod_207(stream);
			int num3 = Class29.smethod_207(stream);
			int num4 = Class29.smethod_207(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class29.smethod_212(stream);
			Class29.smethod_212(stream);
			Class29.smethod_212(stream);
			int num5 = Class29.smethod_212(stream);
			int num6 = Class29.smethod_207(stream);
			int num7 = Class29.smethod_207(stream);
			if (num6 > 0)
			{
				byte[] buffer = new byte[num6];
				stream.Read(buffer, 0, num6);
			}
			if (num7 > 0)
			{
				byte[] buffer2 = new byte[num7];
				stream.Read(buffer2, 0, num7);
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class10.Class11 class11_ = new Class10.Class11(array2);
			array = new byte[num5];
			Class29.smethod_208(array, 0, array.Length, class11_);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = Class29.smethod_212(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class29.smethod_212(stream);
					num11 = Class29.smethod_212(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class10.Class11 class11_2 = new Class10.Class11(array3);
					Class29.smethod_208(array, i, num11, class11_2);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 84, 75, 120, 210, 126, 218, 233, 171 };
				byte[] byte_2 = new byte[8] { 222, 53, 133, 36, 116, 198, 127, 247 };
				using ICryptoTransform cryptoTransform = Class29.smethod_158(byte_2, byte_, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class29.smethod_96(byte_3);
			}
			if (num8 == 3)
			{
				byte[] byte_4 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_5 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using ICryptoTransform cryptoTransform2 = Class29.smethod_105(bool_0: true, byte_4, byte_5);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class29.smethod_96(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static void smethod_97(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class29.smethod_42(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static void smethod_98(string string_0)
	{
		IDisposable disposable = null;
		try
		{
			disposable = Class29.smethod_58();
			string string_ = Class29.smethod_13(string_0);
			Class29.smethod_34(string_, 0L);
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	static bool smethod_99(Class10.Class19 class19_0)
	{
		return class19_0.int_8 == class19_0.int_7;
	}

	static void smethod_100(Control0 control0_0)
	{
		Class29.smethod_215(control0_0, string.Empty);
	}

	static int smethod_101(Class10.Class13 class13_0)
	{
		return class13_0.int_1;
	}

	static bool smethod_102(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.bool_0;
	}

	static byte[] smethod_103(byte[] byte_0, string string_0)
	{
		if (string_0.StartsWith("{"))
		{
			Class22.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
			return null;
		}
		RijndaelManaged rijndaelManaged = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(string_0);
			rijndaelManaged.GenerateKey();
			rijndaelManaged.GenerateIV();
			byte[] array = new byte[48];
			Buffer.BlockCopy(rijndaelManaged.Key, 0, array, 0, 32);
			Buffer.BlockCopy(rijndaelManaged.IV, 0, array, 32, 16);
			memoryStream = new MemoryStream();
			try
			{
				byte[] array2 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
				memoryStream.WriteByte(1);
				memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
				memoryStream.Write(array2, 0, array2.Length);
			}
			catch (CryptographicException)
			{
				try
				{
					byte[] array3 = new byte[16];
					byte[] array4 = new byte[16];
					Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
					Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
					byte[] array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
					byte[] array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
					memoryStream.WriteByte(2);
					memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
					memoryStream.Write(array5, 0, array5.Length);
					memoryStream.Write(array6, 0, array6.Length);
					memoryStream.Write(array7, 0, array7.Length);
				}
				catch (CryptographicException)
				{
					Class22.string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
					return null;
				}
			}
			cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch (Exception ex3)
		{
			Class22.string_0 = "ERR 2004: " + ex3.Message;
			return null;
		}
		finally
		{
			rijndaelManaged?.Clear();
			rSACryptoServiceProvider?.Clear();
			memoryStream?.Close();
			cryptoStream?.Close();
		}
	}

	static ulong[] smethod_104(Class48 class48_0)
	{
		return class48_0.ulong_0;
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class36.Struct11 struct11_0, int int_1);

	static ICryptoTransform smethod_105(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_0, byte_1) : symmetricAlgorithm.CreateEncryptor(byte_0, byte_1);
	}

	static void smethod_106(Class10.Class20 class20_0, int int_0, int int_1)
	{
		class20_0.uint_0 |= (uint)(int_0 << class20_0.int_2);
		class20_0.int_2 += int_1;
		if (class20_0.int_2 >= 16)
		{
			class20_0.byte_0[class20_0.int_1++] = (byte)class20_0.uint_0;
			class20_0.byte_0[class20_0.int_1++] = (byte)(class20_0.uint_0 >> 8);
			class20_0.uint_0 >>= 16;
			class20_0.int_2 -= 16;
		}
	}

	static int smethod_107(string string_0, Class24 class24_0)
	{
		try
		{
			bool flag = class24_0.char_0[0] == '\u0001';
			if (string_0 != null && string_0.Length != 0 && (!flag || string_0.Length <= 4) && (flag || string_0[0] == '#'))
			{
				int num = 0;
				int num2 = string_0.Length - 1;
				while (true)
				{
					if (num2 >= 0 && (flag || num2 != 0))
					{
						char c = string_0[num2];
						bool flag2 = false;
						for (int i = 0; i < class24_0.char_0.Length; i++)
						{
							if (class24_0.char_0[i] == c)
							{
								num = num * class24_0.char_0.Length + i;
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							break;
						}
						num2--;
						continue;
					}
					return num;
				}
				return -1;
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	static extern IntPtr GetModuleHandle(string string_0);

	static Assembly smethod_108(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class2.Struct0 @struct = new Class2.Struct0(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "e2FhMzQ0NDMwLTU3NmUtNDdiNS1iODJiLTIwZGVkZTcyODczMn0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{efca0a29-f1af-493d-9b2e-8098e742a21a},e2FhMzQ0NDMwLTU3NmUtNDdiNS1iODJiLTIwZGVkZTcyODczMn0=,[z]{efca0a29-f1af-493d-9b2e-8098e742a21a}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < array.Length - 1; i += 2)
		{
			if (array[i] == text)
			{
				text2 = array[i + 1];
				break;
			}
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			for (int j = 0; j < array.Length - 1; j += 2)
			{
				if (array[j] == text)
				{
					text2 = array[j + 1];
					break;
				}
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				int num = text2.IndexOf(']');
				string text3 = text2.Substring(1, num - 1);
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(num + 1);
			}
			Assembly result;
			lock (Class2.dictionary_0)
			{
				if (Class2.dictionary_0.ContainsKey(text2))
				{
					result = Class2.dictionary_0[text2];
				}
				else
				{
					Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
					if (manifestResourceStream == null)
					{
						goto IL_0261;
					}
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class29.smethod_96(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							flag2 = true;
						}
						catch (BadImageFormatException)
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						try
						{
							string text4 = $"{Path.GetTempPath()}{text2}\\";
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + ".dll";
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								Class29.MoveFileEx(text5, (string)null, 4);
								Class29.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class2.dictionary_0[text2] = assembly;
					result = assembly;
				}
			}
			return result;
		}
		goto IL_0261;
		IL_0261:
		return null;
	}

	static void smethod_109(IWebProxy iwebProxy_0, Class23 class23_0)
	{
		class23_0.iwebProxy_0 = iwebProxy_0;
	}

	static bool smethod_110(string string_0)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\" + string_0);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\NET Framework Setup\\NDP\\" + string_0);
			}
			return registryKey != null;
		}
		finally
		{
			registryKey?.Close();
		}
	}

	static bool smethod_111(byte[] byte_0, Class40.Class44 class44_0, Class40 class40_0)
	{
		byte[] byte_;
		bool result;
		try
		{
			byte_ = Class29.smethod_175(byte_0);
		}
		catch (Exception)
		{
			Class29.smethod_203(Class10.string_0, class40_0, Enum2.const_0);
			result = false;
			goto IL_001b;
		}
		byte[] array = Class29.smethod_29(byte_, "<RSAKeyValue><Modulus>lkDxqBuIcgpdBAwh556xapPCo6rxZwhr8W4DUJcOwkCJLbW025KFyM1tzV7TvxPm7F3hodp/A/rXYt1ABbF52ZGUNZ7+JCSibwr4hOcDrkejKKqGkZ3ZlQREZsJ4mTKtyyCIZRmv8KhssXGHXPab1qNup+gHs3eCMrGyf3t7Umk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			Class29.smethod_203(Class39.string_0, class40_0, Enum2.const_0);
			return false;
		}
		Class29.smethod_194(class40_0, Enum2.const_1);
		Class45 @class = new Class45("e2566c00-b0c1-af29-a6ee-a973783aa53a");
		if (class40_0.iwebProxy_0 != null)
		{
			Class29.smethod_15(class40_0.iwebProxy_0, @class);
		}
		Class40.Class42 class2 = new Class40.Class42(class40_0, array, @class, class44_0);
		Class29.smethod_20(@class, (Delegate4)class2.method_0);
		return class2.bool_0;
		IL_001b:
		return result;
	}

	static Type smethod_112(Class28 class28_0)
	{
		return class28_0.type_0;
	}

	static void smethod_113(Class10.Class17.Class18 class18_0, Class10.Class17.Class18 class18_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class18_0.int_1)
		{
			int num3 = 1;
			int num4 = class18_0.byte_0[num2];
			int num5;
			int num6;
			if (num4 == 0)
			{
				num5 = 138;
				num6 = 3;
			}
			else
			{
				num5 = 6;
				num6 = 3;
				if (num != num4)
				{
					Class29.smethod_195(class18_1, num4);
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class18_0.int_1 && num == class18_0.byte_0[num2])
			{
				num2++;
				if (++num3 >= num5)
				{
					break;
				}
			}
			if (num3 < num6)
			{
				while (num3-- > 0)
				{
					Class29.smethod_195(class18_1, num);
				}
			}
			else if (num != 0)
			{
				Class29.smethod_195(class18_1, 16);
				Class29.smethod_106(class18_0.class17_0.class20_0, num3 - 3, 2);
			}
			else if (num3 <= 10)
			{
				Class29.smethod_195(class18_1, 17);
				Class29.smethod_106(class18_0.class17_0.class20_0, num3 - 3, 3);
			}
			else
			{
				Class29.smethod_195(class18_1, 18);
				Class29.smethod_106(class18_0.class17_0.class20_0, num3 - 11, 7);
			}
		}
	}

	static void smethod_114(Class10.Class17.Class18 class18_0)
	{
		int[] array = new int[class18_0.int_3];
		int num = 0;
		class18_0.short_1 = new short[class18_0.short_0.Length];
		for (int i = 0; i < class18_0.int_3; i++)
		{
			array[i] = num;
			num += class18_0.int_2[i] << 15 - i;
		}
		for (int j = 0; j < class18_0.int_1; j++)
		{
			int num2 = class18_0.byte_0[j];
			if (num2 > 0)
			{
				class18_0.short_1[j] = Class29.smethod_182(array[num2 - 1]);
				array[num2 - 1] += 1 << 16 - num2;
			}
		}
	}

	static bool smethod_115(Class10.Class16 class16_0)
	{
		return Class29.smethod_99(class16_0.class19_0);
	}

	static Class36.Struct12 smethod_116()
	{
		if (!Class36.bool_0)
		{
			Class36.struct12_0 = default(Class36.Struct12);
			try
			{
				Class36.struct12_0.int_0 = Marshal.SizeOf(typeof(Class36.Struct12));
				Class29.GetVersionEx(ref Class36.struct12_0);
				Class36.bool_0 = true;
			}
			catch
			{
			}
		}
		return Class36.struct12_0;
	}

	static int smethod_117(Class10.Class20 class20_0)
	{
		return class20_0.int_2;
	}

	static int smethod_118(Class10.Class13 class13_0)
	{
		return 32768 - class13_0.int_1;
	}

	static Icon smethod_119()
	{
		try
		{
			return Class29.smethod_80();
		}
		catch (Exception)
		{
			return Class29.smethod_95("default");
		}
	}

	static void smethod_120(EventHandler eventHandler_0, Class33 class33_0)
	{
		EventHandler eventHandler = class33_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class33_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	static void smethod_121(Class10.Class12 class12_0)
	{
		class12_0.uint_0 >>= class12_0.int_2 & 7;
		class12_0.int_2 &= -8;
	}

	static void smethod_122(Class10.Class20 class20_0)
	{
		if (class20_0.int_2 > 0)
		{
			class20_0.byte_0[class20_0.int_1++] = (byte)class20_0.uint_0;
			if (class20_0.int_2 > 8)
			{
				class20_0.byte_0[class20_0.int_1++] = (byte)(class20_0.uint_0 >> 8);
			}
		}
		class20_0.uint_0 = 0u;
		class20_0.int_2 = 0;
	}

	static void smethod_123()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class29.smethod_108;
		}
		catch
		{
		}
	}

	static void smethod_124(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class33.string_0 == "1") || !Class29.smethod_10().method_2((SecurityException)exception_0))
		{
			Class29.smethod_42(exception_0, object_0);
			Class29.smethod_10().method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static void smethod_125(Class10.Class13 class13_0, int int_0)
	{
		if (class13_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class13_0.byte_0[class13_0.int_0++] = (byte)int_0;
		class13_0.int_0 &= 32767;
	}

	static bool smethod_126(Class10.Class17 class17_0)
	{
		return class17_0.int_1 >= 16384;
	}

	static bool smethod_127(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_2;
	}

	static int smethod_128()
	{
		Version version = new Version("6.8.0.121");
		return version.Major;
	}

	static string smethod_129(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	static bool smethod_130(Class23.Class27 class27_0, byte[] byte_0, Class23 class23_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class29.smethod_175(byte_0);
		}
		catch (Exception)
		{
			Class29.smethod_147(class23_0, Enum0.const_0, Class10.string_0);
			return false;
		}
		byte[] array = Class29.smethod_103(byte_, "<RSAKeyValue><Modulus>lkDxqBuIcgpdBAwh556xapPCo6rxZwhr8W4DUJcOwkCJLbW025KFyM1tzV7TvxPm7F3hodp/A/rXYt1ABbF52ZGUNZ7+JCSibwr4hOcDrkejKKqGkZ3ZlQREZsJ4mTKtyyCIZRmv8KhssXGHXPab1qNup+gHs3eCMrGyf3t7Umk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			Class29.smethod_147(class23_0, Enum0.const_0, Class22.string_0);
			return false;
		}
		Class29.smethod_193(class23_0, Enum0.const_1);
		Class35 @class = new Class35("e2566c00-b0c1-af29-a6ee-a973783aa53a");
		if (class23_0.iwebProxy_0 != null)
		{
			@class.iwebProxy_0 = class23_0.iwebProxy_0;
		}
		Class23.Class25 class2 = new Class23.Class25(class23_0, array, @class, class27_0);
		Class29.smethod_191((Delegate2)class2.method_0, @class);
		return class2.bool_0;
	}

	static bool smethod_131(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_3;
	}

	static bool smethod_132(Class10.Class15 class15_0, Class10.Class12 class12_0)
	{
		while (true)
		{
			switch (class15_0.int_2)
			{
			case 5:
			{
				int int_ = Class10.Class15.int_1[class15_0.int_7];
				int num = Class29.smethod_136(class12_0, int_);
				if (num >= 0)
				{
					Class29.smethod_27(class12_0, int_);
					num += Class10.Class15.int_0[class15_0.int_7];
					while (num-- > 0)
					{
						class15_0.byte_1[class15_0.int_8++] = class15_0.byte_2;
					}
					if (class15_0.int_8 == class15_0.int_6)
					{
						return true;
					}
					goto IL_009b;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class29.smethod_94(class15_0.class14_0, class12_0)) & -16) == 0)
				{
					class15_0.byte_1[class15_0.int_8++] = (class15_0.byte_2 = (byte)num2);
					if (class15_0.int_8 == class15_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class15_0.byte_2 = 0;
					}
					class15_0.int_7 = num2 - 16;
					class15_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class15_0.int_8 < class15_0.int_5)
				{
					int num3 = Class29.smethod_136(class12_0, 3);
					if (num3 >= 0)
					{
						Class29.smethod_27(class12_0, 3);
						class15_0.byte_0[Class10.Class15.int_9[class15_0.int_8]] = (byte)num3;
						class15_0.int_8++;
						continue;
					}
					return false;
				}
				class15_0.class14_0 = new Class10.Class14(class15_0.byte_0);
				class15_0.byte_0 = null;
				class15_0.int_8 = 0;
				class15_0.int_2 = 4;
				goto case 4;
			case 2:
				class15_0.int_5 = Class29.smethod_136(class12_0, 4);
				if (class15_0.int_5 >= 0)
				{
					class15_0.int_5 += 4;
					Class29.smethod_27(class12_0, 4);
					class15_0.byte_0 = new byte[19];
					class15_0.int_8 = 0;
					class15_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class15_0.int_4 = Class29.smethod_136(class12_0, 5);
				if (class15_0.int_4 >= 0)
				{
					class15_0.int_4++;
					Class29.smethod_27(class12_0, 5);
					class15_0.int_6 = class15_0.int_3 + class15_0.int_4;
					class15_0.byte_1 = new byte[class15_0.int_6];
					class15_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class15_0.int_3 = Class29.smethod_136(class12_0, 5);
				if (class15_0.int_3 >= 0)
				{
					class15_0.int_3 += 257;
					Class29.smethod_27(class12_0, 5);
					class15_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class15_0.int_2 = 4;
		}
	}

	static long smethod_133(Class10.Class16 class16_0)
	{
		return class16_0.long_0;
	}

	static int smethod_134(Class10.Class17 class17_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static void smethod_135()
	{
		Class29.smethod_156(Class49.string_1);
		try
		{
			string[] fileNames = Class49.isolatedStorageFile_0.GetFileNames(Class49.string_2 + "\\*.bin");
			foreach (string text in fileNames)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				string string_ = Path.Combine(Class49.string_2, text);
				Class29.smethod_156(string_);
				string string_2 = Path.Combine(Class49.string_2, fileNameWithoutExtension + ".txt");
				Class29.smethod_156(string_2);
			}
		}
		catch (DirectoryNotFoundException)
		{
		}
		try
		{
			Class49.isolatedStorageFile_0.DeleteDirectory(Class49.string_2);
		}
		catch (IsolatedStorageException)
		{
		}
		Class49.isolatedStorageFile_0.CreateDirectory(Class49.string_2);
	}

	static int smethod_136(Class10.Class12 class12_0, int int_0)
	{
		if (class12_0.int_2 < int_0)
		{
			if (class12_0.int_0 == class12_0.int_1)
			{
				return -1;
			}
			class12_0.uint_0 |= (uint)(((class12_0.byte_0[class12_0.int_0++] & 0xFF) | ((class12_0.byte_0[class12_0.int_0++] & 0xFF) << 8)) << class12_0.int_2);
			class12_0.int_2 += 16;
		}
		return (int)(class12_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_137(string string_0)
	{
		Class52 class51_ = new Class52();
		Class29.smethod_92(string_0, (Class51)class51_);
	}

	static string smethod_138(Class23.Class27 class27_0)
	{
		return class27_0.string_1;
	}

	static void smethod_139(Class41 class41_0)
	{
		if (class41_0.class48_0 == null)
		{
			class41_0.class48_0 = Class29.smethod_204();
		}
		class41_0.method_0();
		byte[] byte_ = class41_0.byte_0;
		Class40.Class44 class44_ = Class40.Class44.class44_0;
		Class29.smethod_111(byte_, class44_, (Class40)class41_0);
	}

	static bool smethod_140(Class10.Class12 class12_0)
	{
		return class12_0.int_0 == class12_0.int_1;
	}

	static void smethod_141(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class29.smethod_42(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static bool smethod_142(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_1;
	}

	static Assembly smethod_143(string string_0)
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string_0);
		if (stream != null)
		{
			int count = new BinaryReader(stream).ReadInt32();
			using DeflateStream input = new DeflateStream(stream, CompressionMode.Decompress);
			return Assembly.Load(new BinaryReader(input).ReadBytes(count));
		}
		return null;
	}

	static ulong[] smethod_144(string string_0)
	{
		ulong[] array2;
		using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(string_0, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None, Class49.isolatedStorageFile_0))
		{
			byte[] array = new byte[isolatedStorageFileStream.Length];
			isolatedStorageFileStream.Read(array, 0, array.Length);
			array2 = new ulong[array.Length / 8];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
		}
		return array2;
	}

	static string smethod_145()
	{
		return "SmartAssembly" + " " + Class29.smethod_128();
	}

	static string smethod_146(object object_0)
	{
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int num)
			{
				return num.ToString("x");
			}
			if (object_0 is long num2)
			{
				return num2.ToString("x");
			}
			if (object_0 is short num3)
			{
				return num3.ToString("x");
			}
			if (object_0 is uint num4)
			{
				return num4.ToString("x");
			}
			if (object_0 is ulong num5)
			{
				return num5.ToString("x");
			}
			if (object_0 is ushort num6)
			{
				return num6.ToString("x");
			}
			if (object_0 is byte b)
			{
				return b.ToString("x");
			}
			if (object_0 is sbyte b2)
			{
				return b2.ToString("x");
			}
			if (object_0 is IntPtr intPtr)
			{
				return intPtr.ToInt64().ToString("x");
			}
			if (object_0 is UIntPtr)
			{
				return ((UIntPtr)object_0).ToUInt64().ToString("x");
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	static void smethod_147(Class23 class23_0, Enum0 enum0_0, string string_0)
	{
		Class29.smethod_39(class23_0, enum0_0, string_0, string.Empty);
	}

	static void smethod_148(uint uint_0)
	{
		IDisposable disposable = null;
		try
		{
			disposable = Class29.smethod_58();
			Class29.smethod_34(Class49.string_1, (long)(uint_0 * 8));
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	[DllImport("user32.dll")]
	static extern int GetSystemMetrics(int int_0);

	static void smethod_149()
	{
		try
		{
			Class29.smethod_123();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_150(Class24 class24_0, Exception exception_0)
	{
		using (new Class37(class24_0.xmlWriter_0, "Exception"))
		{
			try
			{
				Type type = exception_0.GetType();
				class24_0.method_3(type);
				string value = "N/A";
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				class24_0.xmlWriter_0.WriteAttributeString("Message", value);
				string text = exception_0.StackTrace!.Trim();
				class24_0.xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class24_0.xmlWriter_0.WriteAttributeString("Method", text);
				class24_0.method_1(new Class28(exception_0, bool_1: true));
			}
			catch
			{
			}
		}
	}

	static string smethod_151(Class23.Class27 class27_0)
	{
		return class27_0.string_0;
	}

	static bool smethod_152(int int_0, int int_1, Class10.Class17 class17_0)
	{
		class17_0.short_0[class17_0.int_1] = (short)int_0;
		class17_0.byte_1[class17_0.int_1++] = (byte)(int_1 - 3);
		int num = Class29.smethod_30(int_1 - 3, class17_0);
		class17_0.class18_0.short_0[num]++;
		if (num >= 265 && num < 285)
		{
			class17_0.int_2 += (num - 261) / 4;
		}
		int num2 = Class29.smethod_134(class17_0, int_0 - 1);
		class17_0.class18_1.short_0[num2]++;
		if (num2 >= 4)
		{
			class17_0.int_2 += num2 / 2 - 1;
		}
		return Class29.smethod_126(class17_0);
	}

	static string smethod_153()
	{
		return Class29.smethod_116().string_0;
	}

	[DllImport("shell32")]
	static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	static bool smethod_154(Class10.Class16 class16_0)
	{
		if (class16_0.int_0 == 30)
		{
			return Class29.smethod_83(class16_0.class20_0);
		}
		return false;
	}

	static bool smethod_155(bool bool_0, bool bool_1, Class10.Class19 class19_0)
	{
		bool flag2;
		do
		{
			Class29.smethod_12(class19_0);
			bool flag;
			flag2 = Class29.smethod_190(flag = bool_0 && class19_0.int_7 == class19_0.int_8, class19_0, bool_1);
		}
		while (Class29.smethod_83(class19_0.class20_0) && flag2);
		return flag2;
	}

	[DllImport("kernel32.dll")]
	static extern void GetSystemInfo(ref Class36.Struct13 struct13_0);

	static void smethod_156(string string_0)
	{
		try
		{
			Class49.isolatedStorageFile_0.DeleteFile(string_0);
		}
		catch (IsolatedStorageException)
		{
		}
	}

	static void smethod_157(Class10.Class13 class13_0, int int_0, int int_1)
	{
		if ((class13_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class13_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class13_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class13_0.byte_0, num, class13_0.byte_0, class13_0.int_0, int_0);
				class13_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class13_0.byte_0[class13_0.int_0++] = class13_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class29.smethod_196(class13_0, num, int_0, int_1);
		}
	}

	static ICryptoTransform smethod_158(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	static bool smethod_159(string string_0, string string_1)
	{
		IntPtr moduleHandle = Class29.GetModuleHandle(string_0);
		if (moduleHandle == IntPtr.Zero)
		{
			return false;
		}
		return Class29.GetProcAddress(moduleHandle, string_1) != IntPtr.Zero;
	}

	static void smethod_160(Form1 form1_0)
	{
		((Control)form1_0).SuspendLayout();
		((Control)form1_0.button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)form1_0.button_1).set_FlatStyle((FlatStyle)3);
		((Control)form1_0.button_1).set_Size(new Size(100, 24));
		((Control)form1_0.button_1).set_Location(new Point(408 - ((Control)form1_0.button_1).get_Width(), 188));
		((Control)form1_0.button_1).set_TabIndex(0);
		((Control)form1_0.button_1).set_Text("&Quit");
		((Control)form1_0.button_1).add_Click((EventHandler)form1_0.method_1);
		((Control)form1_0.button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)form1_0.button_0).set_FlatStyle((FlatStyle)3);
		((Control)form1_0.button_0).set_Size(new Size(100, 24));
		((Control)form1_0.button_0).set_Location(new Point(((Control)form1_0.button_1).get_Left() - ((Control)form1_0.button_0).get_Width() - 6, 188));
		((Control)form1_0.button_0).set_TabIndex(1);
		((Control)form1_0.button_0).set_Text("&Continue");
		((Control)form1_0.button_0).add_Click((EventHandler)form1_0.method_0);
		((Control)form1_0.control2_0).set_Anchor((AnchorStyles)6);
		((Control)form1_0.control2_0).SetBounds(6, 186, 120, 32);
		Class29.smethod_74(form1_0.control1_0, Enum1.const_2);
		((Control)form1_0.class32_0).set_Anchor((AnchorStyles)13);
		((Control)form1_0.class32_0).set_Location(new Point(20, 72));
		((Control)form1_0.class32_0).set_Size(new Size(382, 13));
		((Form)form1_0).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)form1_0).set_ClientSize(new Size(418, 224));
		((Form)form1_0).set_ControlBox(false);
		((Control)form1_0).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			form1_0.control2_0,
			(Control)form1_0.button_0,
			(Control)form1_0.button_1,
			form1_0.control1_0,
			(Control)form1_0.class32_0
		});
		((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
		((Form)form1_0).set_MaximizeBox(false);
		((Form)form1_0).set_MinimizeBox(false);
		((Form)form1_0).set_ShowInTaskbar(false);
		((Form)form1_0).set_StartPosition((FormStartPosition)1);
		((Control)form1_0).ResumeLayout(false);
	}

	static bool smethod_161(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_1;
	}

	static int smethod_162(Class10.Class17.Class18 class18_0)
	{
		int num = 0;
		for (int i = 0; i < class18_0.short_0.Length; i++)
		{
			num += class18_0.short_0[i] * class18_0.byte_0[i];
		}
		return num;
	}

	static bool smethod_163(Class10.Class17 class17_0, int int_0)
	{
		class17_0.short_0[class17_0.int_1] = 0;
		class17_0.byte_1[class17_0.int_1++] = (byte)int_0;
		class17_0.class18_0.short_0[int_0]++;
		return Class29.smethod_126(class17_0);
	}

	static Assembly smethod_164()
	{
		try
		{
			return Assembly.GetExecutingAssembly();
		}
		catch
		{
			return null;
		}
	}

	static int smethod_165(Class10.Class12 class12_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class12_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class12_0.uint_0;
			class12_0.uint_0 >>= 8;
			class12_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class12_0.int_1 - class12_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class12_0.byte_0, class12_0.int_0, byte_0, int_0, int_1);
		class12_0.int_0 += int_1;
		if (((uint)(class12_0.int_0 - class12_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class12_0.uint_0 = class12_0.byte_0[class12_0.int_0++] & 0xFFu;
			class12_0.int_2 = 8;
		}
		return num + int_1;
	}

	static Exception smethod_166(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.exception_0;
	}

	static Class48 smethod_167()
	{
		using (Class29.smethod_58())
		{
			return Class29.smethod_2();
		}
	}

	static int smethod_168(int int_0, int int_1, byte[] byte_0, Class10.Class13 class13_0)
	{
		int num = class13_0.int_0;
		if (int_1 > class13_0.int_1)
		{
			int_1 = class13_0.int_1;
		}
		else
		{
			num = (class13_0.int_0 - class13_0.int_1 + int_1) & 0x7FFF;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class13_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class13_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class13_0.int_1 -= num2;
		if (class13_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static void smethod_169(int int_0, Class10.Class17 class17_0, int int_1, byte[] byte_0, bool bool_0)
	{
		Class29.smethod_106(class17_0.class20_0, bool_0 ? 1 : 0, 3);
		Class29.smethod_122(class17_0.class20_0);
		Class29.smethod_54(class17_0.class20_0, int_0);
		Class29.smethod_54(class17_0.class20_0, ~int_0);
		Class29.smethod_89(int_0, int_1, byte_0, class17_0.class20_0);
		Class29.smethod_198(class17_0);
	}

	static void smethod_170(Delegate2 delegate2_0, Class35 class35_0, string string_0, string string_1, byte[] byte_0, string string_2)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class35_0.string_2);
			if (class35_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class35_0.iwebProxy_0);
			}
			delegate2_0(reportingService.UploadReport2(class35_0.string_1, byte_0, string_1, string_0, string_2));
		}
		catch (Exception ex)
		{
			delegate2_0("ERR 2002: " + ex.Message);
		}
	}

	static string smethod_171(Class40.Class44 class44_0)
	{
		return class44_0.string_0;
	}

	static void smethod_172(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class29.smethod_42(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static bool smethod_173(EventArgs1 eventArgs1_0, string string_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class29.smethod_22(eventArgs1_0.class24_0, string_0);
	}

	[DllImport("kernel32.Dll")]
	static extern short GetVersionEx(ref Class36.Struct12 struct12_0);

	static void smethod_174(Class23 class23_0, Delegate1 delegate1_0)
	{
		Delegate1 @delegate = class23_0.delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_0);
			@delegate = Interlocked.CompareExchange(ref class23_0.delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static byte[] smethod_175(byte[] byte_0)
	{
		return Class29.smethod_31(1, byte_0, (byte[])null, (byte[])null);
	}

	static void smethod_176()
	{
		try
		{
			Class5.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_177(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static string smethod_178()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class29.smethod_40());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class29.smethod_32());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue("Path", null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	static Enum0 smethod_179(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.enum0_0;
	}

	static void smethod_180(Class24 class24_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class29.smethod_22(class24_0, tempFileName);
			string path = Class29.smethod_178();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
			if (class24_0.eventHandler_0 != null)
			{
				class24_0.eventHandler_0(class24_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			Class29.smethod_88(class24_0, new EventArgs0(exception_));
		}
	}

	static int smethod_181(Class10.Class20 class20_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class20_0.int_2 >= 8)
		{
			class20_0.byte_0[class20_0.int_1++] = (byte)class20_0.uint_0;
			class20_0.uint_0 >>= 8;
			class20_0.int_2 -= 8;
		}
		if (int_1 > class20_0.int_1 - class20_0.int_0)
		{
			int_1 = class20_0.int_1 - class20_0.int_0;
			Array.Copy(class20_0.byte_0, class20_0.int_0, byte_0, int_0, int_1);
			class20_0.int_0 = 0;
			class20_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class20_0.byte_0, class20_0.int_0, byte_0, int_0, int_1);
			class20_0.int_0 += int_1;
		}
		return int_1;
	}

	static short smethod_182(int int_0)
	{
		return (short)((Class10.Class17.byte_0[int_0 & 0xF] << 12) | (Class10.Class17.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class10.Class17.byte_0[(int_0 >> 8) & 0xF] << 4) | Class10.Class17.byte_0[int_0 >> 12]);
	}

	static void smethod_183(bool bool_0, EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_3 = bool_0;
	}

	static int smethod_184(Font font_0, int int_0, Graphics graphics_0, string string_0)
	{
		try
		{
			return Class29.smethod_77(string_0, font_0, graphics_0, int_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class29.smethod_188(int_0, font_0, string_0, graphics_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static void smethod_185(Class24 class24_0, Delegate0 delegate0_0)
	{
		Delegate0 @delegate = class24_0.delegate0_0;
		Delegate0 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate0 value = (Delegate0)Delegate.Combine(delegate2, delegate0_0);
			@delegate = Interlocked.CompareExchange(ref class24_0.delegate0_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static void smethod_186()
	{
		using (Class29.smethod_58())
		{
			Class29.smethod_135();
		}
	}

	static string smethod_187(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.string_0;
	}

	static int smethod_188(int int_0, Font font_0, string string_0, Graphics graphics_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	static void smethod_189()
	{
		try
		{
			Class47.smethod_0("Platform CPU Cores: " + Environment.ProcessorCount);
		}
		catch
		{
		}
	}

	static bool smethod_190(bool bool_0, Class10.Class19 class19_0, bool bool_1)
	{
		if (class19_0.int_5 < 262 && !bool_0)
		{
			return false;
		}
		Class10.Class17 class17_2;
		byte[] byte_;
		int int_4;
		do
		{
			if (class19_0.int_5 >= 262 || bool_0)
			{
				if (class19_0.int_5 != 0)
				{
					if (class19_0.int_4 >= 65274)
					{
						Class29.smethod_8(class19_0);
					}
					int int_ = class19_0.int_1;
					int int_2 = class19_0.int_2;
					if (class19_0.int_5 >= 3)
					{
						int num = Class29.smethod_82(class19_0);
						if (num != 0 && class19_0.int_4 - num <= 32506 && Class29.smethod_26(class19_0, num) && class19_0.int_2 <= 5 && class19_0.int_2 == 3 && class19_0.int_4 - class19_0.int_1 > 4096)
						{
							class19_0.int_2 = 2;
						}
					}
					if (int_2 >= 3 && class19_0.int_2 <= int_2)
					{
						Class10.Class17 class17_ = class19_0.class17_0;
						int int_3 = class19_0.int_4 - 1 - int_;
						Class29.smethod_152(int_3, int_2, class17_);
						int_2 -= 2;
						do
						{
							class19_0.int_4++;
							class19_0.int_5--;
							if (class19_0.int_5 >= 3)
							{
								Class29.smethod_82(class19_0);
							}
						}
						while (--int_2 > 0);
						class19_0.int_4++;
						class19_0.int_5--;
						class19_0.bool_0 = false;
						class19_0.int_2 = 2;
					}
					else
					{
						if (class19_0.bool_0)
						{
							Class29.smethod_163(class19_0.class17_0, class19_0.byte_0[class19_0.int_4 - 1] & 0xFF);
						}
						class19_0.bool_0 = true;
						class19_0.int_4++;
						class19_0.int_5--;
					}
					continue;
				}
				if (class19_0.bool_0)
				{
					Class29.smethod_163(class19_0.class17_0, class19_0.byte_0[class19_0.int_4 - 1] & 0xFF);
				}
				class19_0.bool_0 = false;
				class17_2 = class19_0.class17_0;
				byte_ = class19_0.byte_0;
				int_4 = class19_0.int_3;
				int int_5 = class19_0.int_4 - class19_0.int_3;
				Class29.smethod_68(byte_, int_4, int_5, bool_1, class17_2);
				class19_0.int_3 = class19_0.int_4;
				return false;
			}
			return true;
		}
		while (!Class29.smethod_126(class19_0.class17_0));
		int num2 = class19_0.int_4 - class19_0.int_3;
		if (class19_0.bool_0)
		{
			num2--;
		}
		bool flag = bool_1 && class19_0.int_5 == 0 && !class19_0.bool_0;
		class17_2 = class19_0.class17_0;
		byte_ = class19_0.byte_0;
		int_4 = class19_0.int_3;
		Class29.smethod_68(byte_, int_4, num2, flag, class17_2);
		class19_0.int_3 += num2;
		return !flag;
	}

	static void smethod_191(Delegate2 delegate2_0, Class35 class35_0)
	{
		if (class35_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class35_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class35_0.iwebProxy_0);
				}
				class35_0.string_2 = uploadReportLoginService.GetServerURL(class35_0.string_1);
				if (class35_0.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (class35_0.string_2 == "ditto")
				{
					class35_0.string_2 = Class35.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate2_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate2_0(class35_0.string_2.StartsWith("ERR") ? class35_0.string_2 : "OK");
	}

	static void smethod_192(Control3 control3_0, bool bool_0)
	{
		control3_0.timer_0.set_Enabled(bool_0);
		control3_0.int_0 = 0;
		((Control)control3_0).Refresh();
	}

	static void smethod_193(Class23 class23_0, Enum0 enum0_0)
	{
		Class29.smethod_147(class23_0, enum0_0, string.Empty);
	}

	static void smethod_194(Class40 class40_0, Enum2 enum2_0)
	{
		Class29.smethod_203(string.Empty, class40_0, enum2_0);
	}

	static void smethod_195(Class10.Class17.Class18 class18_0, int int_0)
	{
		Class29.smethod_106(class18_0.class17_0.class20_0, class18_0.short_1[int_0] & 0xFFFF, (int)class18_0.byte_0[int_0]);
	}

	static void smethod_196(Class10.Class13 class13_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class13_0.byte_0[class13_0.int_0++] = class13_0.byte_0[int_0++];
			class13_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_197(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class29.smethod_42(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static void smethod_198(Class10.Class17 class17_0)
	{
		class17_0.int_1 = 0;
		class17_0.int_2 = 0;
	}

	static Class10.Class14 smethod_199(Class10.Class15 class15_0)
	{
		byte[] array = new byte[class15_0.int_3];
		Array.Copy(class15_0.byte_1, 0, array, 0, class15_0.int_3);
		return new Class10.Class14(array);
	}

	static bool smethod_200()
	{
		try
		{
			Class36.Struct13 struct13_ = default(Class36.Struct13);
			Class29.GetSystemInfo(ref struct13_);
			return struct13_.ushort_0 == 9;
		}
		catch
		{
			return false;
		}
	}

	static void smethod_201(Class51 class51_0, uint uint_0)
	{
		try
		{
			lock (Class51.object_0)
			{
				Class29.smethod_4(class51_0);
				Class29.smethod_148(uint_0);
			}
		}
		catch
		{
		}
	}

	static bool smethod_202(Class10.Class11 class11_0)
	{
		switch (class11_0.int_4)
		{
		case 2:
		{
			if (class11_0.bool_0)
			{
				class11_0.int_4 = 12;
				return false;
			}
			int num = Class29.smethod_136(class11_0.class12_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class29.smethod_27(class11_0.class12_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class11_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class29.smethod_121(class11_0.class12_0);
				class11_0.int_4 = 3;
				break;
			case 1:
				class11_0.class14_0 = Class10.Class14.class14_0;
				class11_0.class14_1 = Class10.Class14.class14_1;
				class11_0.int_4 = 7;
				break;
			case 2:
				class11_0.class15_0 = new Class10.Class15();
				class11_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class11_0.int_8 = Class29.smethod_136(class11_0.class12_0, 16)) < 0)
			{
				return false;
			}
			Class29.smethod_27(class11_0.class12_0, 16);
			class11_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class29.smethod_136(class11_0.class12_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class29.smethod_27(class11_0.class12_0, 16);
			class11_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class29.smethod_60(class11_0.class13_0, class11_0.class12_0, class11_0.int_8);
			class11_0.int_8 -= num3;
			if (class11_0.int_8 == 0)
			{
				class11_0.int_4 = 2;
				return true;
			}
			return !Class29.smethod_140(class11_0.class12_0);
		}
		case 6:
			if (!Class29.smethod_132(class11_0.class15_0, class11_0.class12_0))
			{
				return false;
			}
			class11_0.class14_0 = Class29.smethod_199(class11_0.class15_0);
			class11_0.class14_1 = Class29.smethod_59(class11_0.class15_0);
			class11_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class29.smethod_41(class11_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static void smethod_203(string string_0, Class40 class40_0, Enum2 enum2_0)
	{
		Class29.smethod_14(class40_0, enum2_0, string_0, string.Empty);
	}

	static Class48 smethod_204()
	{
		using (Class29.smethod_58())
		{
			Class48 result = Class29.smethod_2();
			Class29.smethod_135();
			return result;
		}
	}

	static void smethod_205(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static Assembly smethod_206(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return Class29.smethod_143(Convert.ToBase64String(Encoding.Default.GetBytes(resolveEventArgs_0.Name.ToLowerInvariant())));
	}

	static int smethod_207(Class10.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static int smethod_208(byte[] byte_0, int int_0, int int_1, Class10.Class11 class11_0)
	{
		int num = 0;
		do
		{
			if (class11_0.int_4 != 11)
			{
				int num2 = Class29.smethod_168(int_0, int_1, byte_0, class11_0.class13_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class29.smethod_202(class11_0) || (Class29.smethod_101(class11_0.class13_0) > 0 && class11_0.int_4 != 11));
		return num;
	}

	static bool smethod_209(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_2;
	}

	static bool smethod_210()
	{
		try
		{
			return Class29.GetSystemMetrics(89) != 0;
		}
		catch
		{
			return false;
		}
	}

	static Bitmap smethod_211(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".png");
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	[DllImport("kernel32.dll")]
	static extern IntPtr GetCurrentProcess();

	static int smethod_212(Class10.Stream0 stream0_0)
	{
		return Class29.smethod_207(stream0_0) | (Class29.smethod_207(stream0_0) << 16);
	}

	static void smethod_213(Class10.Class19 class19_0)
	{
		class19_0.int_0 = (class19_0.byte_0[class19_0.int_4] << 5) ^ class19_0.byte_0[class19_0.int_4 + 1];
	}

	static void smethod_214(Class33 class33_0, Delegate1 delegate1_0)
	{
		Delegate1 @delegate = class33_0.delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_0);
			@delegate = Interlocked.CompareExchange(ref class33_0.delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static void smethod_215(Control0 control0_0, string string_0)
	{
		control0_0.string_0 = string_0;
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = (Image)(object)Class29.smethod_211((string_0.Length > 0) ? "error" : "ok");
		control0_0.bool_1 = true;
		control0_0.bool_0 = true;
		if (string_0.Length > 0)
		{
			((Control)control0_0).set_Height(100);
		}
		((Control)control0_0).Refresh();
	}
}
