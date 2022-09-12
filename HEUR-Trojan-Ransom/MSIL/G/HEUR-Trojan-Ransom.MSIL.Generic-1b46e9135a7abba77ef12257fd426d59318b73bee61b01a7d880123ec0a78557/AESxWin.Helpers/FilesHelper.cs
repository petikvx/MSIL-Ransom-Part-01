using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using A6yJVNZuoAn9NC1LAS;
using SharpAESCrypt;

namespace AESxWin.Helpers;

public static class FilesHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEncryptFileAsync_003Ed__0))]
	[DebuggerStepThrough]
	public static Task EncryptFileAsync(this string path, string password)
	{
		//Discarded unreachable code: IL_0005, IL_0021
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 6;
		_003CEncryptFileAsync_003Ed__0 stateMachine = default(_003CEncryptFileAsync_003Ed__0);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 8:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto default;
			default:
				_ = 0;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 2;
					continue;
				}
				num2 = 0;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_002a;
				}
				goto case 6;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 6:
				stateMachine = new _003CEncryptFileAsync_003Ed__0();
				num = 3;
				continue;
			case 0:
			case 5:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num = 7;
				continue;
			case 3:
				stateMachine.path = path;
				num = 1;
				continue;
			case 1:
				stateMachine.password = password;
				num2 = 8;
				goto IL_002a;
			case 7:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 9;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					break;
				}
				goto IL_002a;
			case 9:
				break;
				IL_002a:
				num = num2;
				continue;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EncryptFileAsync(this string path, string password, bool deleteOriginal)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(116))
		{
			return;
		}
		try
		{
			global::SharpAESCrypt.SharpAESCrypt.Encrypt(password, path, path + S7EI44sMaZQ92MiG6X.pA2PN5iOW(256));
			if (deleteOriginal)
			{
				try
				{
					File.Delete(path);
					return;
				}
				catch
				{
					return;
				}
			}
		}
		catch (Exception ex)
		{
			string text = DateTime.Now.ToString(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2224));
			string path2 = Path.Combine(S7EI44sMaZQ92MiG6X.pA2PN5iOW(212), text + S7EI44sMaZQ92MiG6X.pA2PN5iOW(224));
			Log.WriteLog(path2, ex.ToString());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CEncryptFilesAsync_003Ed__2))]
	public static Task EncryptFilesAsync(this IEnumerable<string> paths, string password)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_003CEncryptFilesAsync_003Ed__2 stateMachine = new _003CEncryptFilesAsync_003Ed__2();
		stateMachine.paths = paths;
		stateMachine.password = password;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDecryptFileAsync_003Ed__3))]
	[DebuggerStepThrough]
	public static Task DecryptFileAsync(this string path, string password)
	{
		//Discarded unreachable code: IL_0005, IL_0031
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 1;
		int num = (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 6 : 3);
		_003CDecryptFileAsync_003Ed__3 stateMachine = default(_003CDecryptFileAsync_003Ed__3);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 1:
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					goto case 2;
				default:
					num3 = 2;
					goto IL_0036;
				case 2:
					stateMachine._003C_003E1__state = -1;
					goto case 5;
				case 4:
					_003C_003Et__builder.Start(ref stateMachine);
					num = 9;
					break;
				case 7:
					stateMachine.path = path;
					num3 = 8;
					goto IL_0036;
				case 8:
					stateMachine.password = password;
					num3 = 1;
					goto IL_0036;
				case 0:
				case 3:
					goto IL_00c9;
				case 5:
				case 6:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num3 = 4;
					goto IL_0036;
				case 9:
					{
						return stateMachine._003C_003Et__builder.Task;
					}
					IL_0036:
					num = num3;
					break;
				}
				break;
				IL_00c9:
				stateMachine = new _003CDecryptFileAsync_003Ed__3();
				num2 = 7;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string RemoveExtension(this string path)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return Path.ChangeExtension(path, "")!.TrimEnd(new char[1] { '.' });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CDecryptFilesAsync_003Ed__5))]
	public static Task DecryptFilesAsync(this IEnumerable<string> paths, string password)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_003CDecryptFilesAsync_003Ed__5 stateMachine = new _003CDecryptFilesAsync_003Ed__5();
		stateMachine.paths = paths;
		stateMachine.password = password;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<string> GetFolderFilesPaths(this string folder, bool followSubDirs = true)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		List<string> list = new List<string>();
		try
		{
			if (!Directory.Exists(folder))
			{
				return list;
			}
			if (followSubDirs)
			{
				string[] directories = Directory.GetDirectories(folder);
				if (directories != null)
				{
					string[] array = directories;
					foreach (string folder2 in array)
					{
						list.AddRange(folder2.GetFolderFilesPaths());
					}
				}
			}
			string[] files = Directory.GetFiles(folder);
			if (files != null)
			{
				list.AddRange(files);
			}
		}
		catch
		{
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<string> ParseExtensions(this string extentions)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		List<string> list = new List<string>();
		string value = Regex.Match(extentions, S7EI44sMaZQ92MiG6X.pA2PN5iOW(2228)).Value;
		if (!string.IsNullOrWhiteSpace(value))
		{
			extentions = extentions.Replace(value, string.Empty);
		}
		MatchCollection matchCollection = Regex.Matches(extentions, S7EI44sMaZQ92MiG6X.pA2PN5iOW(2232));
		foreach (object item in matchCollection)
		{
			list.Add(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2236) + item.ToString());
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckExtension(this string path, IEnumerable<string> extensions)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		if (extensions == null)
		{
			return true;
		}
		if (extensions.Count() == 0)
		{
			return true;
		}
		foreach (string extension in extensions)
		{
			if (path.ToLower().EndsWith(extension.ToLower()))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckExtension(this string path, string[] extensions)
	{
		//Discarded unreachable code: IL_0005, IL_00e5, IL_01a5
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_005e: Incompatible stack heights: 0 vs 1
		int num = 7;
		bool result = default(bool);
		bool flag = default(bool);
		string text = default(string);
		int num6 = default(int);
		bool flag3 = default(bool);
		string[] array = default(string[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 5:
						break;
					case 3:
					case 11:
						goto IL_001e;
					case 9:
						result = true;
						goto case 6;
					case 10:
						goto IL_0052;
					case 1:
					case 2:
						result = true;
						num3 = 12;
						continue;
					case 0:
						goto IL_00a8;
					case 4:
						goto IL_015a;
					case 7:
						goto IL_0178;
					case 8:
						goto IL_018c;
					default:
						goto IL_01f3;
					case 6:
					case 12:
					case 13:
					case 14:
						return result;
					}
					goto IL_0011;
					IL_01f3:
					num2 = 5;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto IL_018c;
					IL_018c:
					result = false;
					num = 14;
					goto end_IL_01ae;
					IL_0178:
					flag = extensions == null;
					num2 = 10;
					break;
					IL_00a8:
					try
					{
						bool flag2 = path.ToLower().EndsWith(text.ToLower());
						_ = 1;
						int num4;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num4 = 3;
							if (false)
							{
								goto IL_00d9;
							}
							goto IL_00ee;
						}
						int num5 = 2;
						goto IL_00f2;
						IL_011b:
						result = true;
						num4 = 4;
						if (false)
						{
							return result;
						}
						goto IL_00ee;
						IL_00ee:
						num5 = num4;
						goto IL_00f2;
						IL_00f2:
						switch (num5)
						{
						case 0:
						case 3:
							break;
						default:
							goto IL_011b;
						case 4:
							return result;
						}
						goto IL_00d9;
						IL_00d9:
						if (flag2)
						{
							goto IL_011b;
						}
					}
					catch
					{
					}
					num6++;
					num2 = 3;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto IL_015a;
					IL_0052:
					if (flag)
					{
						_ = 0;
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num2 = 13;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								break;
							}
							goto IL_0011;
						}
						num3 = 1;
						continue;
					}
					flag3 = extensions.Count() == 0;
					num3 = 4;
					continue;
					IL_015a:
					if (flag3)
					{
						num2 = 9;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
					}
					else
					{
						array = extensions;
					}
					goto IL_0011;
					IL_0011:
					num6 = 0;
					num = 11;
					goto end_IL_01ae;
					IL_001e:
					if (num6 >= array.Length)
					{
						num3 = 8;
						continue;
					}
					text = array[num6];
					num3 = 0;
				}
				continue;
				end_IL_01ae:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DriveInfo[] GetDrives()
	{
		//Discarded unreachable code: IL_0005, IL_0067
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 5;
		DriveInfo[] result = default(DriveInfo[]);
		IEnumerable<DriveInfo> enumerable = default(IEnumerable<DriveInfo>);
		while (true)
		{
			int num2;
			int num3;
			switch (num)
			{
			default:
				result = enumerable.ToArray();
				num2 = 0;
				goto IL_006c;
			case 6:
				if (enumerable == null)
				{
					goto IL_0043;
				}
				_ = 1;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num2 = 1;
					goto IL_006c;
				}
				num3 = 4;
				break;
			case 1:
			case 2:
				if (enumerable.Any())
				{
					goto default;
				}
				goto IL_0043;
			case 5:
				enumerable = from a in DriveInfo.GetDrives()
					where a.DriveType == DriveType.Fixed
					select a;
				num2 = 6;
				goto IL_006c;
			case 0:
			case 7:
				{
					return result;
				}
				IL_006c:
				num3 = num2;
				break;
				IL_0043:
				result = null;
				num2 = 7;
				goto IL_006c;
			}
			num = num3;
		}
	}

	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
