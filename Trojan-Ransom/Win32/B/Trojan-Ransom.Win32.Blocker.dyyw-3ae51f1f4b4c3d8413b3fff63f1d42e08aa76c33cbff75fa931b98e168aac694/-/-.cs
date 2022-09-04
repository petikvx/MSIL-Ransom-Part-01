using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using _0001;
using Microsoft.CSharp;

namespace _0020
{
	internal class _000E
	{
		private static _0011 m__0020 = new _0011();

		public string _0020(string _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0011, IL_0173, IL_0178, IL_017e, IL_0182, IL_0187, IL_018d, IL_0193, IL_019b, IL_01a1, IL_01a8, IL_01ae
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Incompatible stack heights: 0 vs 2
			//IL_001b: Incompatible stack heights: 1 vs 0
			//IL_00de: Incompatible stack heights: 1 vs 0
			//IL_00ec: Incompatible stack heights: 0 vs 1
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Incompatible stack heights: 0 vs 1
			//IL_0182: Incompatible stack heights: 1 vs 0
			//IL_019a: Incompatible stack heights: 0 vs 2
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Incompatible stack heights: 0 vs 1
			string environmentVariable = Environment.GetEnvironmentVariable(_0020);
			Type typeFromHandle = typeof(_000E);
			MethodInfo methodInfo = null;
			MethodInfo[] methods = typeFromHandle.GetMethods();
			foreach (MethodInfo methodInfo2 in methods)
			{
				ParameterInfo[] parameters = methodInfo2.GetParameters();
				if (parameters.Length == 3 && (object)parameters[0].ParameterType == Type.GetType(_002E._0020(675028622, 1838531952, 741860206)))
				{
					_ = methodInfo2.Name;
					methodInfo = methodInfo2;
					break;
				}
			}
			object obj = Activator.CreateInstance(typeFromHandle);
			object[] parameters2 = new object[3]
			{
				1,
				environmentVariable,
				_002E._0020(1982182987, 1838531964, 741860216)
			};
			object obj2 = methodInfo.Invoke(obj, parameters2);
			return (string)obj2;
		}

		public string _0020(int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_000d, IL_017b, IL_0180, IL_0189, IL_018f, IL_0194, IL_019a, IL_019e, IL_01a4
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Incompatible stack heights: 1 vs 0
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Incompatible stack heights: 1 vs 2
			//IL_0195: Incompatible stack heights: 2 vs 0
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Incompatible stack heights: 0 vs 1
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			if (this._0020(_002E._0020(437504873, 1838531848, 741860188)).Replace(_002E._0020(749696622, 1838531856, 741860220), _002E._0020(438263815, 1838531856, 741860212)).Replace(_002E._0020(461182837, 1838531864, 741860220), _002E._0020(1914744146, 1838531864, 741860212)) == _002E._0020(42159413, 1838531874, 741860210) || this._0020(_002E._0020(601689249, 1838531898, 741860204)).Replace(_002E._0020(1787499744, 1838531906, 741860220), _002E._0020(697920879, 1838531906, 741860212)).Replace(_002E._0020(962635777, 1838531914, 741860220), _002E._0020(1972909865, 1838531914, 741860212)) != _002E._0020(781066975, 1838531914, 741860212))
			{
				return _002E._0020(744306887, 1838531926, 741860216);
			}
			return _002E._0020(389202195, 1838531930, 741860208);
		}

		public string _0020(double _0020, string _0001, string _0002)
		{
			//Discarded unreachable code: IL_000b, IL_0014, IL_00a6, IL_00ab, IL_00b1, IL_00b8, IL_00be, IL_00c0, IL_00c6, IL_00cc, IL_00d2, IL_00d7
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 1 vs 0
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Incompatible stack heights: 0 vs 2
			//IL_00cd: Incompatible stack heights: 1 vs 0
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected O, but got Unknown
			if (_0001 != null && _0001.ToString() == _002E._0020(2060459941, 1838532036, 741860216))
			{
				return _002E._0020(1683176541, 1838532048, 741860216);
			}
			return _002E._0020(273109208, 1838532056, 741860220) + _0001 + _002E._0020(4400542, 1838532064, 741860220);
		}

		public string _0020(int _0020, string _0001, string _0002)
		{
			//Discarded unreachable code: IL_0005, IL_002d, IL_0082, IL_0087, IL_008d, IL_0093, IL_009a, IL_00a0, IL_00a5, IL_00ab
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 1 vs 0
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Incompatible stack heights: 0 vs 1
			//IL_00a0: Incompatible stack heights: 1 vs 0
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			if (_0001 == null && _0001.ToString() == _002E._0020(1896130922, 1838532024, 741860204))
			{
				return _0001 + _0020;
			}
			return _0001 + _0002;
		}

		public string _0020(long _0020, string _0001, string _0002)
		{
			//Discarded unreachable code: IL_001c, IL_006d, IL_0072, IL_007a, IL_0080, IL_0083, IL_0088, IL_008e
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Incompatible stack heights: 0 vs 1
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Incompatible stack heights: 0 vs 1
			//IL_0089: Incompatible stack heights: 1 vs 0
			if (_0001.ToString() == _002E._0020(1059211585, 1838532000, 741860178))
			{
				return _0001 + _0020;
			}
			return _0001 + _0002;
		}

		public static string _0020(byte[] _0020, string _0001, string _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0030, IL_0035, IL_003a, IL_003e, IL_0044, IL_004c, IL_0052
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Incompatible stack heights: 0 vs 1
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Incompatible stack heights: 0 vs 2
			return Encoding.Unicode.GetString(_000E._0001(_0020, _0001, _0002));
		}

		public static byte[] _0001(byte[] _0020, string _0001, string _0002)
		{
			//Discarded unreachable code: IL_0010, IL_001d, IL_00c9, IL_00ce, IL_00d3, IL_00d9, IL_00df, IL_00e5, IL_00eb
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0021: Incompatible stack heights: 1 vs 0
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Incompatible stack heights: 0 vs 2
			//IL_00ee: Expected O, but got I4
			MemoryStream stream = new MemoryStream(_0020);
			MemoryStream memoryStream = new MemoryStream();
			Rijndael rijndael = Rijndael.Create();
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(_0001, Encoding.ASCII.GetBytes(_0002));
			rijndael.Key = passwordDeriveBytes.GetBytes(32);
			rijndael.IV = passwordDeriveBytes.GetBytes(16);
			ICryptoTransform transform = rijndael.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			_0025 _00252 = new _0025(cryptoStream);
			byte[] array = new byte[2048];
			int num;
			do
			{
				num = _00252.Read(array, 0, array.Length);
				memoryStream.Write(array, 0, num);
			}
			while (num > 0);
			_00252.Close();
			memoryStream.Flush();
			memoryStream.Close();
			return memoryStream.ToArray();
		}

		public static string _0001(string _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0031, IL_0084, IL_0089, IL_008e, IL_009c, IL_00a2, IL_00a8, IL_00ae
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Incompatible stack heights: 2 vs 0
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Incompatible stack heights: 2 vs 1
			//IL_0089: Incompatible stack heights: 2 vs 0
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Incompatible stack heights: 1 vs 0
			//IL_00a9: Incompatible stack heights: 0 vs 1
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			return BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(_0002(_0020))).Replace(_002E._0020(1005071044, 1838531710, 741860214), _002E._0020(1902203912, 1838531710, 741860212));
		}

		private static byte[] _0002(string _0020)
		{
			//Discarded unreachable code: IL_000b, IL_0019, IL_002f, IL_0042, IL_0047, IL_004b, IL_0051, IL_0057, IL_005d, IL_0061, IL_0066, IL_006c
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 1 vs 0
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Incompatible stack heights: 1 vs 0
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Incompatible stack types: I8 vs I4
			//IL_0061: Incompatible stack types: I vs I8
			return new ASCIIEncoding().GetBytes(_0020);
		}

		private static string _0020(byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0011, IL_0021, IL_0044, IL_0049, IL_004e, IL_0054, IL_0057, IL_005d, IL_0062
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Incompatible stack heights: 1 vs 0
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_0058: Incompatible stack heights: 1 vs 0
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got I8
			return new ASCIIEncoding().GetString(_0020, 0, _0020.Length);
		}

		public static object _0020(string _0020, string _0001, string _0002, string[] _0003, object[] _0004)
		{
			//Discarded unreachable code: IL_0005, IL_0019, IL_00af, IL_00b4, IL_00ba, IL_00c0, IL_00c6, IL_00cb
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Incompatible stack heights: 1 vs 0
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_004e: Incompatible stack heights: 1 vs 0
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Incompatible stack heights: 0 vs 1
			//IL_00c6: Incompatible stack heights: 1 vs 0
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				CSharpCodeProvider val = new CSharpCodeProvider();
				ICodeCompiler val2 = ((CodeDomProvider)val).CreateCompiler();
				CompilerParameters val3 = new CompilerParameters();
				foreach (string value in _0003)
				{
					val3.get_ReferencedAssemblies().Add(value);
				}
				val3.set_GenerateInMemory(true);
				CompilerResults val4 = val2.CompileAssemblyFromSource(val3, _0020);
				if (!val4.get_Errors().get_HasErrors())
				{
					object obj = val4.get_CompiledAssembly().CreateInstance(_0001);
					if (obj != null)
					{
						return obj.GetType().InvokeMember(_0002, BindingFlags.InvokeMethod, null, obj, _0004);
					}
				}
			}
			catch
			{
			}
			return null;
		}

		public static object _0020(string _0020, string _0001, string[] _0002, object[] _0003)
		{
			//Discarded unreachable code: IL_0005, IL_001e, IL_0059, IL_005e, IL_0064, IL_006a, IL_0070, IL_0078, IL_007d
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Incompatible stack heights: 1 vs 0
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Incompatible stack heights: 0 vs 1
			//IL_0078: Incompatible stack heights: 1 vs 0
			string text = _002E._0020(243536837, 1838531704, 741860146);
			return _000E._0020(_0020, text, _0001, _0002, _0003);
		}
	}
	internal class _000F
	{
		protected Timer _0020;

		private Timer m__0001;

		public _000F()
		{
			//Discarded unreachable code: IL_0005, IL_001a, IL_0023, IL_0086, IL_008b, IL_0091, IL_009e, IL_00a4, IL_00a9, IL_00af, IL_00b5, IL_00bb
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Incompatible stack heights: 0 vs 2
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Incompatible stack heights: 0 vs 1
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Incompatible stack heights: 0 vs 1
			//IL_00b6: Incompatible stack heights: 1 vs 0
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			this._0020 = new Timer();
			this._0020.AutoReset = true;
			this._0020.Interval = 1000.0;
			this._0020.Elapsed += _0020;
			this._0020.Start();
		}

		private void _0020(object _0020, ElapsedEventArgs _0001)
		{
			//Discarded unreachable code: IL_000a, IL_0013, IL_001b, IL_0037, IL_003c, IL_0040, IL_0045, IL_004b, IL_0051, IL_0057
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Incompatible stack heights: 0 vs 3
			//IL_0046: Incompatible stack heights: 3 vs 0
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			if (Debugger.get_IsAttached())
			{
				this._0020.Stop();
				this._0020();
			}
		}

		private void _0020()
		{
			//Discarded unreachable code: IL_000b, IL_0018, IL_0081, IL_0086, IL_008b, IL_0094, IL_009a, IL_00a0, IL_00a6
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Incompatible stack heights: 0 vs 2
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0093: Incompatible stack heights: 0 vs 1
			this.m__0001 = new Timer();
			this.m__0001.Interval = _0020(3000, 678, 8000);
			this.m__0001.Elapsed += _0001;
			this.m__0001.AutoReset = false;
			this.m__0001.Start();
		}

		private void _0001(object _0020, ElapsedEventArgs _0001)
		{
			//Discarded unreachable code: IL_000b, IL_0015, IL_003a, IL_003f, IL_0045, IL_0048, IL_004e, IL_0054, IL_005c, IL_0062, IL_0067
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Incompatible stack heights: 0 vs 1
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Incompatible stack heights: 0 vs 1
			//IL_005d: Incompatible stack heights: 1 vs 0
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			_0002(26, 16, 55);
		}

		private double _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0016, IL_0037, IL_003c, IL_0042, IL_0048, IL_004d, IL_0053, IL_005f, IL_0064
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Incompatible stack heights: 0 vs 1
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Incompatible stack heights: 0 vs 1
			Random random = new Random();
			return Convert.ToDouble(random.Next(_0020, _0002));
		}

		private string _0001(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_001d, IL_0038, IL_003d, IL_0043, IL_0049, IL_004c, IL_0052, IL_0056, IL_005b
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Incompatible stack heights: 0 vs 1
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got I
			Random random = new Random();
			return random.Next(_0020, _0002).ToString();
		}

		private void _0002(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0012, IL_0160, IL_0165, IL_0168, IL_016e, IL_0178, IL_017d, IL_0183, IL_018c, IL_0192, IL_0198
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Incompatible stack heights: 0 vs 1
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Incompatible stack heights: 1 vs 0
			string text;
			if ((text = this._0001(_0001 + 10, _0002 - 10, _0020 + 10)) != null)
			{
				if (text == _0028._0020(218897349, 827227479, 1435834056))
				{
					throw new ArgumentException(_0028._0020(1896103000, 827227423, 1435834080));
				}
				if (text == _0028._0020(214196889, 827227475, 1435834056))
				{
					throw new ArgumentNullException(_0028._0020(781507238, 827227603, 1435833984));
				}
				if (text == _0028._0020(1351069225, 827227471, 1435834056))
				{
					throw new FormatException(_0028._0020(358185677, 827227537, 1435833998));
				}
				if (text == _0028._0020(1219751143, 827227467, 1435834056))
				{
					throw new NotSupportedException(_0028._0020(1974838175, 827227553, 1435834108));
				}
			}
			Environment.Exit(0);
			Environment.Exit(0);
		}
	}
	internal class _0010
	{
		public static _000F _0020;
	}
	internal class _0011
	{
		public _0011()
		{
			//Discarded unreachable code: IL_0005, IL_000d, IL_0031, IL_004e, IL_0053, IL_0058, IL_005e, IL_0063, IL_0069, IL_006d, IL_0073
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 1 vs 0
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Incompatible stack heights: 0 vs 1
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Incompatible stack heights: 0 vs 1
			if (_0010._0020 == null)
			{
				_0010._0020 = new _000F();
			}
		}
	}
	[CompilerGenerated]
	internal class _0012
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1024)]
		private struct _0013
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
		private struct _0014
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 40)]
		private struct _0015
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 76)]
		private struct _0016
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
		private struct _0017
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 116)]
		private struct _0018
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 120)]
		private struct _0019
		{
		}

		internal static _0013 _0020/* Not supported: data(00 00 00 00 96 30 07 77 2C 61 0E EE BA 51 09 99 19 C4 6D 07 8F F4 6A 70 35 A5 63 E9 A3 95 64 9E 32 88 DB 0E A4 B8 DC 79 1E E9 D5 E0 88 D9 D2 97 2B 4C B6 09 BD 7C B1 7E 07 2D B8 E7 91 1D BF 90 64 10 B7 1D F2 20 B0 6A 48 71 B9 F3 DE 41 BE 84 7D D4 DA 1A EB E4 DD 6D 51 B5 D4 F4 C7 85 D3 83 56 98 6C 13 C0 A8 6B 64 7A F9 62 FD EC C9 65 8A 4F 5C 01 14 D9 6C 06 63 63 3D 0F FA F5 0D 08 8D C8 20 6E 3B 5E 10 69 4C E4 41 60 D5 72 71 67 A2 D1 E4 03 3C 47 D4 04 4B FD 85 0D D2 6B B5 0A A5 FA A8 B5 35 6C 98 B2 42 D6 C9 BB DB 40 F9 BC AC E3 6C D8 32 75 5C DF 45 CF 0D D6 DC 59 3D D1 AB AC 30 D9 26 3A 00 DE 51 80 51 D7 C8 16 61 D0 BF B5 F4 B4 21 23 C4 B3 56 99 95 BA CF 0F A5 BD B8 9E B8 02 28 08 88 05 5F B2 D9 0C C6 24 E9 0B B1 87 7C 6F 2F 11 4C 68 58 AB 1D 61 C1 3D 2D 66 B6 90 41 DC 76 06 71 DB 01 BC 20 D2 98 2A 10 D5 EF 89 85 B1 71 1F B5 B6 06 A5 E4 BF 9F 33 D4 B8 E8 A2 C9 07 78 34 F9 00 0F 8E A8 09 96 18 98 0E E1 BB 0D 6A 7F 2D 3D 6D 08 97 6C 64 91 01 5C 63 E6 F4 51 6B 6B 62 61 6C 1C D8 30 65 85 4E 00 62 F2 ED 95 06 6C 7B A5 01 1B C1 F4 08 82 57 C4 0F F5 C6 D9 B0 65 50 E9 B7 12 EA B8 BE 8B 7C 88 B9 FC DF 1D DD 62 49 2D DA 15 F3 7C D3 8C 65 4C D4 FB 58 61 B2 4D CE 51 B5 3A 74 00 BC A3 E2 30 BB D4 41 A5 DF 4A D7 95 D8 3D 6D C4 D1 A4 FB F4 D6 D3 6A E9 69 43 FC D9 6E 34 46 88 67 AD D0 B8 60 DA 73 2D 04 44 E5 1D 03 33 5F 4C 0A AA C9 7C 0D DD 3C 71 05 50 AA 41 02 27 10 10 0B BE 86 20 0C C9 25 B5 68 57 B3 85 6F 20 09 D4 66 B9 9F E4 61 CE 0E F9 DE 5E 98 C9 D9 29 22 98 D0 B0 B4 A8 D7 C7 17 3D B3 59 81 0D B4 2E 3B 5C BD B7 AD 6C BA C0 20 83 B8 ED B6 B3 BF 9A 0C E2 B6 03 9A D2 B1 74 39 47 D5 EA AF 77 D2 9D 15 26 DB 04 83 16 DC 73 12 0B 63 E3 84 3B 64 94 3E 6A 6D 0D A8 5A 6A 7A 0B CF 0E E4 9D FF 09 93 27 AE 00 0A B1 9E 07 7D 44 93 0F F0 D2 A3 08 87 68 F2 01 1E FE C2 06 69 5D 57 62 F7 CB 67 65 80 71 36 6C 19 E7 06 6B 6E 76 1B D4 FE E0 2B D3 89 5A 7A DA 10 CC 4A DD 67 6F DF B9 F9 F9 EF BE 8E 43 BE B7 17 D5 8E B0 60 E8 A3 D6 D6 7E 93 D1 A1 C4 C2 D8 38 52 F2 DF 4F F1 67 BB D1 67 57 BC A6 DD 06 B5 3F 4B 36 B2 48 DA 2B 0D D8 4C 1B 0A AF F6 4A 03 36 60 7A 04 41 C3 EF 60 DF 55 DF 67 A8 EF 8E 6E 31 79 BE 69 46 8C B3 61 CB 1A 83 66 BC A0 D2 6F 25 36 E2 68 52 95 77 0C CC 03 47 0B BB B9 16 02 22 2F 26 05 55 BE 3B BA C5 28 0B BD B2 92 5A B4 2B 04 6A B3 5C A7 FF D7 C2 31 CF D0 B5 8B 9E D9 2C 1D AE DE 5B B0 C2 64 9B 26 F2 63 EC 9C A3 6A 75 0A 93 6D 02 A9 06 09 9C 3F 36 0E EB 85 67 07 72 13 57 00 05 82 4A BF 95 14 7A B8 E2 AE 2B B1 7B 38 1B B6 0C 9B 8E D2 92 0D BE D5 E5 B7 EF DC 7C 21 DF DB 0B D4 D2 D3 86 42 E2 D4 F1 F8 B3 DD 68 6E 83 DA 1F CD 16 BE 81 5B 26 B9 F6 E1 77 B0 6F 77 47 B7 18 E6 5A 08 88 70 6A 0F FF CA 3B 06 66 5C 0B 01 11 FF 9E 65 8F 69 AE 62 F8 D3 FF 6B 61 45 CF 6C 16 78 E2 0A A0 EE D2 0D D7 54 83 04 4E C2 B3 03 39 61 26 67 A7 F7 16 60 D0 4D 47 69 49 DB 77 6E 3E 4A 6A D1 AE DC 5A D6 D9 66 0B DF 40 F0 3B D8 37 53 AE BC A9 C5 9E BB DE 7F CF B2 47 E9 FF B5 30 1C F2 BD BD 8A C2 BA CA 30 93 B3 53 A6 A3 B4 24 05 36 D0 BA 93 06 D7 CD 29 57 DE 54 BF 67 D9 23 2E 7A 66 B3 B8 4A 61 C4 02 1B 68 5D 94 2B 6F 2A 37 BE 0B B4 A1 8E 0C C3 1B DF 05 5A 8D EF 02 2D) */;

		internal static _0014 _0020/* Not supported: data(78 56 34 12 89 67 45 23 90 78 56 34) */;

		internal static _0015 _0020/* Not supported: data(00 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 08 00 00 00 08 00 00 00 08 00 00 00 20 00 00 00 20 00 00 00) */;

		internal static _0015 _0001/* Not supported: data(00 00 00 00 04 00 00 00 05 00 00 00 06 00 00 00 04 00 00 00 10 00 00 00 10 00 00 00 20 00 00 00 80 00 00 00 02 01 00 00) */;

		internal static _0015 _0002/* Not supported: data(00 00 00 00 08 00 00 00 10 00 00 00 20 00 00 00 10 00 00 00 20 00 00 00 80 00 00 00 80 00 00 00 02 01 00 00 02 01 00 00) */;

		internal static _0015 _0003/* Not supported: data(00 00 00 00 04 00 00 00 08 00 00 00 20 00 00 00 10 00 00 00 20 00 00 00 80 00 00 00 00 01 00 00 00 04 00 00 00 10 00 00) */;

		internal static _0015 _0004/* Not supported: data(00 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00) */;

		internal static _0016 _0020/* Not supported: data(10 00 00 00 11 00 00 00 12 00 00 00 00 00 00 00 08 00 00 00 07 00 00 00 09 00 00 00 06 00 00 00 0A 00 00 00 05 00 00 00 0B 00 00 00 04 00 00 00 0C 00 00 00 03 00 00 00 0D 00 00 00 02 00 00 00 0E 00 00 00 01 00 00 00 0F 00 00 00) */;

		internal static _0017 _0020/* Not supported: data(00 08 04 0C 02 0A 06 0E 01 09 05 0D 03 0B 07 0F) */;

		internal static _0018 _0020/* Not supported: data(03 00 00 00 04 00 00 00 05 00 00 00 06 00 00 00 07 00 00 00 08 00 00 00 09 00 00 00 0A 00 00 00 0B 00 00 00 0D 00 00 00 0F 00 00 00 11 00 00 00 13 00 00 00 17 00 00 00 1B 00 00 00 1F 00 00 00 23 00 00 00 2B 00 00 00 33 00 00 00 3B 00 00 00 43 00 00 00 53 00 00 00 63 00 00 00 73 00 00 00 83 00 00 00 A3 00 00 00 C3 00 00 00 E3 00 00 00 02 01 00 00) */;

		internal static _0018 _0001/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 03 00 00 00 03 00 00 00 03 00 00 00 03 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 05 00 00 00 05 00 00 00 05 00 00 00 05 00 00 00 00 00 00 00) */;

		internal static _0019 _0020/* Not supported: data(01 00 00 00 02 00 00 00 03 00 00 00 04 00 00 00 05 00 00 00 07 00 00 00 09 00 00 00 0D 00 00 00 11 00 00 00 19 00 00 00 21 00 00 00 31 00 00 00 41 00 00 00 61 00 00 00 81 00 00 00 C1 00 00 00 01 01 00 00 81 01 00 00 01 02 00 00 01 03 00 00 01 04 00 00 01 06 00 00 01 08 00 00 01 0C 00 00 01 10 00 00 01 18 00 00 01 20 00 00 01 30 00 00 01 40 00 00 01 60 00 00) */;

		internal static _0019 _0001/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 01 00 00 00 02 00 00 00 02 00 00 00 03 00 00 00 03 00 00 00 04 00 00 00 04 00 00 00 05 00 00 00 05 00 00 00 06 00 00 00 06 00 00 00 07 00 00 00 07 00 00 00 08 00 00 00 08 00 00 00 09 00 00 00 09 00 00 00 0A 00 00 00 0A 00 00 00 0B 00 00 00 0B 00 00 00 0C 00 00 00 0C 00 00 00 0D 00 00 00 0D 00 00 00) */;

		internal static _0014 _0001/* Not supported: data(03 00 00 00 03 00 00 00 0B 00 00 00) */;

		internal static _0014 _0002/* Not supported: data(02 00 00 00 03 00 00 00 07 00 00 00) */;

		internal static _0016 _0001/* Not supported: data(10 00 00 00 11 00 00 00 12 00 00 00 00 00 00 00 08 00 00 00 07 00 00 00 09 00 00 00 06 00 00 00 0A 00 00 00 05 00 00 00 0B 00 00 00 04 00 00 00 0C 00 00 00 03 00 00 00 0D 00 00 00 02 00 00 00 0E 00 00 00 01 00 00 00 0F 00 00 00) */;
	}
	internal static class _001A
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0018, IL_0103, IL_0120, IL_013f, IL_0160, IL_0166, IL_017b, IL_0185, IL_01a3, IL_01a8, IL_01af, IL_01b5, IL_01bb, IL_01c0
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 1 vs 0
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 1 vs 2
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Incompatible stack heights: 1 vs 0
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Expected O, but got Unknown
			lock (_001A.m__0020)
			{
				int key = _0020 ^ 0x6A7F4D41;
				if (_001A.m__0020 != null && _001A.m__0020.ContainsKey(key))
				{
					return _001A.m__0020[key];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				using (Stream stream = executingAssembly.GetManifestResourceStream("2b0dc057db82432b98281aaa35629b92"))
				{
					byte[] buffer = new byte[stream.Length];
					stream.Read(buffer, 0, Convert.ToInt32(stream.Length));
				}
				int num = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num2 = BitConverter.ToInt32(publicKeyToken, 0);
					int num3 = BitConverter.ToInt32(publicKeyToken, 4);
					num ^= num2 ^ num3;
				}
				else
				{
					num ^= 0x511194FA;
				}
				int num4 = _0002 ^ 0x27BD9F38;
				byte[] array = new byte[num4];
				int num5 = 0;
				int num6 = num;
				/*Error near IL_0101: Could not find block for branch target IL_0116*/;
			}
		}
	}
	internal static class _001B
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0010, IL_0018, IL_0031, IL_01af, IL_01b4, IL_01b7, IL_01bd, IL_01c3, IL_01c7, IL_01cc
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 2
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 1 vs 0
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Incompatible stack heights: 1 vs 0
			//IL_01c7: Incompatible stack heights: 0 vs 1
			//IL_01cf: Expected O, but got I
			lock (_001B.m__0020)
			{
				int num = _0020 ^ 0x3CF0CD64;
				if (_001B.m__0020 != null && _001B.m__0020.ContainsKey(num))
				{
					return _001B.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("3070e3b704fe4e8ab723447d7b5dd7f9"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x4532F1D8;
				}
				int num5 = _0002 ^ 0x606100F0;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_001B.m__0020 == null)
				{
					_001B.m__0020 = new Dictionary<int, string>();
				}
				_001B.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _001C
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_001f, IL_01a0, IL_01a5, IL_01ab, IL_01b1, IL_01b6, IL_01c2, IL_01c8, IL_01ce, IL_01d4
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Incompatible stack heights: 0 vs 1
			lock (_001C.m__0020)
			{
				int num = _0020 ^ 0x39629C93;
				if (_001C.m__0020 != null && _001C.m__0020.ContainsKey(num))
				{
					return _001C.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("83eab863d77f4a8fa4dfaded603bbfba"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x4C45F288;
				}
				int num5 = _0002 ^ 0x3CB79989;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_001C.m__0020 == null)
				{
					_001C.m__0020 = new Dictionary<int, string>();
				}
				_001C.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _001D
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_001c, IL_019d, IL_01a2, IL_01b7, IL_01bc, IL_01c2, IL_01c8, IL_01ce
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_01b7: Incompatible stack heights: 0 vs 3
			//IL_01c9: Incompatible stack heights: 3 vs 0
			lock (_001D.m__0020)
			{
				int num = _0020 ^ 0x5587C672;
				if (_001D.m__0020 != null && _001D.m__0020.ContainsKey(num))
				{
					return _001D.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("e55b9cfb4ac343d598658cf9a4f79f99"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x3D9B2324;
				}
				int num5 = _0002 ^ 0x2EEBE30;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_001D.m__0020 == null)
				{
					_001D.m__0020 = new Dictionary<int, string>();
				}
				_001D.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _001E
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0011, IL_01a8, IL_01ad, IL_01b2, IL_01b7, IL_01b9, IL_01bf, IL_01c2, IL_01c8, IL_01ca, IL_01d0
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Incompatible stack heights: 0 vs 1
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Incompatible stack heights: 0 vs 1
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Incompatible stack heights: 0 vs 1
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Incompatible stack heights: 0 vs 1
			//IL_01cb: Incompatible stack heights: 1 vs 0
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			lock (_001E.m__0020)
			{
				int num = _0020 ^ 0x183C00CD;
				if (_001E.m__0020 != null && _001E.m__0020.ContainsKey(num))
				{
					return _001E.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("6644cb0ca1df471eb687eca3ef024e2c"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x49C55C3C;
				}
				int num5 = _0002 ^ 0x506829D1;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_001E.m__0020 == null)
				{
					_001E.m__0020 = new Dictionary<int, string>();
				}
				_001E.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _001F
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_001f, IL_019d, IL_01a2, IL_01a8, IL_01ac, IL_01b1, IL_01b7
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 1 vs 0
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Incompatible stack heights: 1 vs 0
			lock (_001F.m__0020)
			{
				int num = _0020 ^ 0x28E1E683;
				if (_001F.m__0020 != null && _001F.m__0020.ContainsKey(num))
				{
					return _001F.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("22756921d4644dc6a1cd71763586662b"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x107BCE31;
				}
				int num5 = _0002 ^ 0x6BD11CE2;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_001F.m__0020 == null)
				{
					_001F.m__0020 = new Dictionary<int, string>();
				}
				_001F.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal class _0027 : _0022
	{
		private static readonly uint m__0020 = 65521u;

		private uint m__0001;

		public _0027()
		{
			//Discarded unreachable code: IL_0016, IL_002d, IL_003d, IL_0042, IL_0047, IL_004b, IL_0051, IL_0057
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 2
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Incompatible stack heights: 0 vs 1
			_0001();
		}

		[SpecialName]
		public long _0020()
		{
			//Discarded unreachable code: IL_0011, IL_001e, IL_0029, IL_002e, IL_0034, IL_003a, IL_0040, IL_0045
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Incompatible stack heights: 0 vs 2
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected I8, but got Unknown
			return this.m__0001;
		}

		public void _0001()
		{
			//Discarded unreachable code: IL_0005, IL_0025, IL_0030, IL_0035, IL_003b, IL_0041, IL_0048, IL_004e, IL_0054, IL_0057, IL_005c
			//IL_0020: Incompatible stack heights: 1 vs 0
			//IL_0027: Incompatible stack types: I8 vs I
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_0057: Incompatible stack heights: 1 vs 0
			this.m__0001 = 1u;
		}

		public void _0020(int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0067, IL_006c, IL_0072, IL_007c, IL_0082, IL_0085, IL_008b, IL_0090, IL_0096, IL_009c
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Incompatible stack heights: 0 vs 2
			//IL_0086: Incompatible stack heights: 2 vs 1
			//IL_0097: Incompatible stack heights: 1 vs 0
			uint num = this.m__0001 & 0xFFFFu;
			uint num2 = this.m__0001 >> 16;
			num = (uint)((int)num + (_0020 & 0xFF)) % _0027.m__0020;
			num2 = (num + num2) % _0027.m__0020;
			this.m__0001 = (num2 << 16) + num;
		}

		public void _0020(byte[] _0020)
		{
			//Discarded unreachable code: IL_000b, IL_0013, IL_0034, IL_0039, IL_0040, IL_0046, IL_004c, IL_0057, IL_005d, IL_0062
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Incompatible stack heights: 0 vs 1
			this._0020(_0020, 0, _0020.Length);
		}

		public void _0020(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000a, IL_0019, IL_0166, IL_016b, IL_0171, IL_0177, IL_017c, IL_0180, IL_0186, IL_018c
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0021: Incompatible stack heights: 1 vs 0
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Incompatible stack heights: 0 vs 1
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			if (_0020 == null)
			{
				throw new ArgumentNullException(_2._0020(1938898257, 1165095393, 1390012032));
			}
			if (_0001 < 0 || _0002 < 0 || _0001 + _0002 > _0020.Length)
			{
				throw new ArgumentOutOfRangeException();
			}
			uint num = this.m__0001 & 0xFFFFu;
			uint num2 = this.m__0001 >> 16;
			while (_0002 > 0)
			{
				int num3 = 3800;
				if (num3 > _0002)
				{
					num3 = _0002;
				}
				_0002 -= num3;
				while (--num3 >= 0)
				{
					num += (uint)(_0020[_0001++] & 0xFF);
					num2 += num;
				}
				num %= _0027.m__0020;
				num2 %= _0027.m__0020;
			}
			this.m__0001 = (num2 << 16) | num;
		}
	}
	internal class _002D
	{
		public static int _0020 = 9;

		public static int _0001 = 1;

		public static int _0002 = -1;

		public static int _0003 = 0;

		public static int _0004 = 8;

		private static int m__0005 = 1;

		private static int m__0006 = 4;

		private static int m__0007 = 8;

		private static int _0008 = 0;

		private static int _0009 = 1;

		private static int _002E = 16;

		private static int _0028 = 20;

		private static int _0029 = 28;

		private static int _002A = 30;

		private static int _003D = 127;

		private int _002C;

		private bool m__0020;

		private int _0021;

		private int _002F;

		private @_ m__0020;

		private _005B m__0020;

		public _002D()
			: this(_002D._0002, _0001: false)
		{
		}//Discarded unreachable code: IL_0005, IL_001f, IL_0033, IL_0038, IL_003c, IL_0042, IL_0048, IL_004e, IL_0053, IL_0059, IL_005e
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Incompatible stack heights: 1 vs 0
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Incompatible stack heights: 0 vs 1
		//IL_0054: Incompatible stack heights: 1 vs 0


		public _002D(int _0020)
			: this(_0020, _0001: false)
		{
		}//Discarded unreachable code: IL_0005, IL_0028, IL_002d, IL_0033, IL_0036, IL_003c, IL_003f, IL_0044, IL_004a, IL_0050
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Incompatible stack heights: 1 vs 0
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Incompatible stack heights: 0 vs 1
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Incompatible stack heights: 1 vs 2
		//IL_0045: Incompatible stack heights: 2 vs 0


		public _002D(int _0020, bool _0001)
		{
			//Discarded unreachable code: IL_0005, IL_0010, IL_0022, IL_00d8, IL_00dd, IL_00df, IL_00e5, IL_00ea, IL_00f0, IL_00f6, IL_00fc
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Incompatible stack heights: 2 vs 1
			//IL_001d: Incompatible stack heights: 1 vs 0
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 2 vs 1
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Incompatible stack heights: 2 vs 0
			//IL_00eb: Incompatible stack heights: 1 vs 0
			//IL_00f7: Incompatible stack heights: 0 vs 1
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			if (_0020 == _002D._0002)
			{
				_0020 = 6;
			}
			else if (_0020 < _002D._0003 || _0020 > _002D._0020)
			{
				throw new ArgumentOutOfRangeException(_8._0020(181917124, 1150566320, 643771143));
			}
			this.m__0020 = new @_();
			this.m__0020 = new _005B(this.m__0020);
			this.m__0020 = _0001;
			this._0020(_0026._0020);
			this._0020(_0020);
			this._0020();
		}

		public void _0020()
		{
			//Discarded unreachable code: IL_000b, IL_0053, IL_0058, IL_005a, IL_005f, IL_0064, IL_006a, IL_0070, IL_0076, IL_007e, IL_0084
			//IL_000f: Incompatible stack heights: 0 vs 1
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Incompatible stack heights: 0 vs 1
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Incompatible stack heights: 1 vs 0
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Incompatible stack heights: 0 vs 1
			_0021 = (this.m__0020 ? _002E : _0008);
			_002F = 0;
			this.m__0020._0020();
			this.m__0020._0020();
		}

		[SpecialName]
		public int _0001()
		{
			//Discarded unreachable code: IL_0005, IL_0012, IL_002d, IL_0032, IL_0038, IL_0043, IL_0049, IL_004e, IL_0054
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_001c: Incompatible stack heights: 1 vs 0
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0049: Incompatible stack heights: 1 vs 0
			return this.m__0020._0002();
		}

		[SpecialName]
		public int _0002()
		{
			//Discarded unreachable code: IL_0011, IL_0020, IL_0029, IL_0037, IL_003c, IL_003f, IL_0045, IL_0049, IL_004f, IL_0054, IL_005a
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_004a: Incompatible stack heights: 1 vs 0
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			return this.m__0020._0003();
		}

		[SpecialName]
		public int _0003()
		{
			//Discarded unreachable code: IL_0005, IL_001a, IL_0034, IL_0039, IL_003f, IL_0045, IL_004e, IL_0053
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Incompatible stack heights: 1 vs 0
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Incompatible stack heights: 0 vs 1
			//IL_004e: Incompatible stack heights: 1 vs 0
			return _002F;
		}

		public void _0004()
		{
			//Discarded unreachable code: IL_000a, IL_0029, IL_0041, IL_0046, IL_0048, IL_004e, IL_0054, IL_005a, IL_0061, IL_0066
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 1 vs 0
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Incompatible stack heights: 0 vs 1
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Incompatible stack heights: 0 vs 1
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			_0021 |= _002D.m__0006;
		}

		public void _0005()
		{
			//Discarded unreachable code: IL_0017, IL_002a, IL_004e, IL_0053, IL_0056, IL_005c, IL_0067, IL_006d, IL_0072, IL_0078
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 0 vs 2
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Incompatible stack heights: 0 vs 1
			_0021 |= _002D.m__0006 | _002D.m__0007;
		}

		[SpecialName]
		public bool _0006()
		{
			//Discarded unreachable code: IL_0005, IL_0022, IL_0040, IL_0045, IL_004a, IL_004c, IL_0052, IL_0058, IL_005c, IL_0062, IL_0068, IL_006e
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Incompatible stack heights: 1 vs 0
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Incompatible stack heights: 0 vs 1
			//IL_0063: Incompatible stack heights: 0 vs 1
			//IL_0069: Incompatible stack heights: 1 vs 0
			if (_0021 == _002A)
			{
				return this.m__0020._0003();
			}
			return false;
		}

		[SpecialName]
		public bool _0007()
		{
			//Discarded unreachable code: IL_0005, IL_0026, IL_003b, IL_0040, IL_0046, IL_004c, IL_0052, IL_0057, IL_005e, IL_0064
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 1 vs 0
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Incompatible stack heights: 0 vs 2
			//IL_0052: Incompatible stack heights: 1 vs 0
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Incompatible stack heights: 0 vs 1
			return this.m__0020._0009();
		}

		public void _0020(byte[] _0020)
		{
			//Discarded unreachable code: IL_0010, IL_0019, IL_0031, IL_0036, IL_003c, IL_0042, IL_0047, IL_004d, IL_0050, IL_0056, IL_005c
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_0020: Incompatible stack heights: 1 vs 0
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Incompatible stack heights: 1 vs 0
			//IL_0057: Incompatible stack heights: 0 vs 1
			this._0020(_0020, 0, _0020.Length);
		}

		public void _0020(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_001e, IL_007d, IL_0082, IL_0088, IL_008e, IL_0099, IL_009e
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 1 vs 0
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Incompatible stack heights: 0 vs 2
			if ((_0021 & _002D.m__0007) != 0)
			{
				throw new InvalidOperationException(_8._0020(865524420, 1150566382, 643771195));
			}
			this.m__0020._0001(_0020, _0001, _0002);
		}

		public void _0020(int _0020)
		{
			//Discarded unreachable code: IL_001c, IL_00a8, IL_00ad, IL_00bc, IL_00c2, IL_00c7, IL_00cd, IL_00d3
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Incompatible stack heights: 0 vs 1
			if (_0020 == _002D._0002)
			{
				_0020 = 6;
			}
			else if (_0020 < _002D._0003 || _0020 > _002D._0020)
			{
				throw new ArgumentOutOfRangeException(_8._0020(1987174416, 1150566356, 643771143));
			}
			if (_002C != _0020)
			{
				_002C = _0020;
				this.m__0020._0020(_0020);
			}
		}

		public void _0020(_0026 _0020)
		{
			//Discarded unreachable code: IL_0005, IL_000d, IL_0020, IL_0039, IL_003e, IL_0044, IL_0049, IL_004f, IL_0055, IL_005b
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Incompatible stack heights: 0 vs 2
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_0027: Incompatible stack heights: 1 vs 0
			//IL_0044: Incompatible stack heights: 1 vs 0
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			this.m__0020._0020(_0020);
		}

		public int _0001(byte[] _0020)
		{
			//Discarded unreachable code: IL_000b, IL_0018, IL_0020, IL_003d, IL_0042, IL_004b, IL_0051, IL_0057, IL_005c
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Incompatible stack heights: 0 vs 1
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Incompatible stack heights: 0 vs 1
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Incompatible stack heights: 0 vs 1
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			return _0001(_0020, 0, _0020.Length);
		}

		public int _0001(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_001c, IL_039c, IL_03a1, IL_03a6, IL_03a9, IL_03af, IL_03b3, IL_03b9, IL_03bf
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Incompatible stack heights: 2 vs 0
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_02e9: Incompatible stack heights: 2 vs 0
			//IL_02f6: Incompatible stack heights: 0 vs 2
			//IL_02f6: Incompatible stack heights: 2 vs 0
			//IL_03a1: Incompatible stack heights: 2 vs 0
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03aa: Incompatible stack heights: 0 vs 1
			//IL_03af: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ba: Incompatible stack heights: 1 vs 0
			int num = _0002;
			if (_0021 == _003D)
			{
				throw new InvalidOperationException(_8._0020(1212882469, 1150566318, 643771167));
			}
			if (_0021 < _002E)
			{
				int num2 = _002D._0004 + 112 << 8;
				int num3 = _002C - 1 >> 1;
				if (num3 < 0 || num3 > 3)
				{
					num3 = 3;
				}
				num2 |= num3 << 6;
				if ((_0021 & _002D.m__0005) != 0)
				{
					num2 |= 0x20;
				}
				num2 += 31 - num2 % 31;
				this.m__0020._0003(num2);
				if ((_0021 & _002D.m__0005) != 0)
				{
					int num4 = this.m__0020._0002();
					this.m__0020._0001();
					this.m__0020._0003(num4 >> 16);
					this.m__0020._0003(num4 & 0xFFFF);
				}
				_0021 = _002E | (_0021 & (_002D.m__0006 | _002D.m__0007));
			}
			while (true)
			{
				int num5 = this.m__0020._0001(_0020, _0001, _0002);
				_0001 += num5;
				_002F += num5;
				_0002 -= num5;
				if (_0002 == 0 || _0021 == _002A)
				{
					break;
				}
				if (this.m__0020._0003((_0021 & _002D.m__0006) != 0, (_0021 & _002D.m__0007) != 0))
				{
					continue;
				}
				if (_0021 == _002E)
				{
					return num - _0002;
				}
				if (_0021 == _0028)
				{
					if (_002C != _002D._0003)
					{
						for (int num6 = 8 + (-this.m__0020._0001() & 7); num6 > 0; num6 -= 10)
						{
							this.m__0020._0020(2, 10);
						}
					}
					_0021 = _002E;
				}
				else if (_0021 == _0029)
				{
					this.m__0020._0002();
					if (!this.m__0020)
					{
						int num7 = this.m__0020._0002();
						this.m__0020._0003(num7 >> 16);
						this.m__0020._0003(num7 & 0xFFFF);
					}
					_0021 = _002A;
				}
			}
			return num - _0002;
		}

		public void _0002(byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0018, IL_0021, IL_002b, IL_003f, IL_0044, IL_004a, IL_004c, IL_0052, IL_0057, IL_005d, IL_005f, IL_0065
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Incompatible stack heights: 0 vs 1
			//IL_001c: Incompatible stack heights: 2 vs 0
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Incompatible stack heights: 0 vs 1
			//IL_0052: Incompatible stack heights: 2 vs 0
			//IL_0058: Incompatible stack heights: 1 vs 0
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Incompatible stack heights: 0 vs 1
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			_0002(_0020, 0, _0020.Length);
		}

		public void _0002(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_001a, IL_004a, IL_004f, IL_0057, IL_005c, IL_0062, IL_0066, IL_006c, IL_0070, IL_0076, IL_007c
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Incompatible stack heights: 0 vs 1
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Incompatible stack heights: 0 vs 1
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Incompatible stack heights: 0 vs 2
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Incompatible stack heights: 0 vs 1
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Incompatible stack heights: 0 vs 1
			//IL_0071: Incompatible stack heights: 1 vs 0
			//IL_0077: Incompatible stack heights: 2 vs 0
			if (_0021 != _0008)
			{
				throw new InvalidOperationException();
			}
			_0021 = _0009;
			this.m__0020._0020(_0020, _0001, _0002);
		}
	}
	internal class _0020
	{
		internal enum _0001
		{
			_0020 = 1,
			_0001 = 2,
			_0002 = 16,
			_0003 = 32,
			_0004 = 256,
			_0005 = -1
		}

		internal enum _0002
		{
			_0020 = 0,
			_0001 = 1,
			_0002 = 2,
			_0003 = 3,
			_0004 = 4,
			_0005 = -1
		}

		internal enum _0003
		{
			_0020 = 0,
			_0001 = 1,
			_0002 = 2,
			_0003 = 3,
			_0004 = 32768,
			_0005 = -1
		}

		internal enum _0004
		{
			_0020 = 1,
			_0001,
			_0002
		}

		internal enum _0005
		{
			_0020 = 1,
			_0001,
			_0002,
			_0003,
			_0004,
			_0005,
			_0006,
			_0007,
			_0008,
			_0009,
			_002E,
			_0028,
			_0029,
			_002A
		}

		internal enum _0006
		{
			_0020 = 1,
			_0001,
			_0002,
			_0003,
			_0004,
			_0005,
			_0006
		}

		internal enum _0007
		{
			_0020 = 1,
			_0001 = 2,
			_0002 = 4,
			_0003 = 8,
			_0004 = 0x10,
			_0005 = 0x20,
			_0006 = 0x40,
			_0007 = 0x80
		}

		internal enum _0008
		{
			_0020 = 1,
			_0001 = 2,
			_0002 = 4,
			_0003 = 8,
			_0004 = 16,
			_0005 = 32,
			_0006 = 983103
		}

		internal enum _0009
		{
			_0020 = 1,
			_0001 = 2,
			_0002 = 4,
			_0003 = 8,
			_0004 = 16,
			_0005 = 32,
			_0006 = 64,
			_0007 = 128,
			_0008 = 256,
			_0009 = 983551
		}

		internal struct _0021
		{
			internal int _0020;

			internal string _0020;

			internal string _0001;

			internal int _0001;

			internal int _0002;
		}

		internal struct _0028
		{
			internal int _0020;

			internal int _0001;

			internal int _0002;

			internal string _0020;

			internal string _0001;

			internal int _0003;

			internal string _0002;

			internal string _0003;

			internal string _0004;
		}

		internal enum _0029
		{
			_0020,
			_0001,
			_0002,
			_0003
		}

		internal struct _002A
		{
			internal _0029 _0020;

			internal int _0020;
		}

		internal struct _002C
		{
			internal string _0020;
		}

		internal struct _002E
		{
			internal int _0020;

			internal int _0001;

			internal int _0002;

			internal int _0003;

			internal int _0004;

			internal int _0005;

			internal int _0006;
		}

		internal enum _003D
		{
			_0020 = 1,
			_0001
		}

		internal const int _0020 = 983040;

		internal const int _0001 = int.MinValue;

		internal const int _0002 = 122;

		internal const int _0003 = -1;

		[DllImport("advapi32.dll")]
		internal static extern int LockServiceDatabase(int _0020);

		[DllImport("advapi32.dll")]
		internal static extern bool UnlockServiceDatabase(int _0020);

		[DllImport("kernel32.dll")]
		internal static extern void CopyMemory(IntPtr _0020, _002A[] _0001, int _0002);

		[DllImport("advapi32.dll")]
		internal static extern bool ChangeServiceConfigA(int _0020, _0001 _0001, int _0002, int _0003, string _0004, string _0005, int _0006, string _0007, string _0008, string _0009, string _002E);

		[DllImport("advapi32.dll")]
		internal static extern bool ChangeServiceConfig2A(int _0020, _003D _0001, [MarshalAs(UnmanagedType.Struct)] ref _002C _0002);

		[DllImport("advapi32.dll")]
		internal static extern bool ChangeServiceConfig2A(int _0020, _003D _0001, [MarshalAs(UnmanagedType.Struct)] ref _0021 _0002);

		[DllImport("advapi32.dll")]
		internal static extern int OpenServiceA(int _0020, string _0001, _0009 _0002);

		[DllImport("advapi32.dll")]
		internal static extern int OpenSCManagerA(string _0020, string _0001, _0008 _0002);

		[DllImport("advapi32.dll")]
		internal static extern bool CloseServiceHandle(int _0020);

		[DllImport("advapi32.dll")]
		internal static extern bool QueryServiceConfigA(int _0020, [MarshalAs(UnmanagedType.Struct)] ref _0028 _0001, int _0002, int _0003);
	}
	internal class _000A
	{
		private const int m__0020 = 0;

		private const int m__0001 = 1;

		private const int _0002 = 2;

		private const int _0003 = 3;

		private const int _0004 = 4;

		private const int _0005 = 5;

		private static readonly int[] m__0020 = new int[3] { 3, 3, 11 };

		private static readonly int[] m__0001 = new int[3] { 2, 3, 7 };

		private byte[] m__0020;

		private byte[] m__0001;

		private _000B m__0020;

		private int _0006;

		private int _0007;

		private int _0008;

		private int _0009;

		private int _002E;

		private int _0028;

		private byte m__0020;

		private int _0029;

		private static readonly int[] _0002 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};

		public bool _0020(_003B _0020)
		{
			//Discarded unreachable code: IL_000b, IL_0014, IL_029a, IL_029f, IL_02a5, IL_02aa, IL_02b0, IL_02b6, IL_02bc
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02be: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				switch (_0006)
				{
				default:
					continue;
				case 0:
					_0007 = _0020._0020(5);
					if (_0007 < 0)
					{
						return false;
					}
					_0007 += 257;
					_0020._0001(5);
					_0006 = 1;
					goto case 1;
				case 1:
					_0008 = _0020._0020(5);
					if (_0008 < 0)
					{
						return false;
					}
					_0008++;
					_0020._0001(5);
					_002E = _0007 + _0008;
					this.m__0001 = new byte[_002E];
					_0006 = 2;
					goto case 2;
				case 2:
					_0009 = _0020._0020(4);
					if (_0009 < 0)
					{
						return false;
					}
					_0009 += 4;
					_0020._0001(4);
					this.m__0020 = new byte[19];
					_0029 = 0;
					_0006 = 3;
					goto case 3;
				case 3:
					while (_0029 < _0009)
					{
						int num2 = _0020._0020(3);
						if (num2 < 0)
						{
							return false;
						}
						_0020._0001(3);
						this.m__0020[_0002[_0029]] = (byte)num2;
						_0029++;
					}
					this.m__0020 = new _000B(this.m__0020);
					this.m__0020 = null;
					_0029 = 0;
					_0006 = 4;
					goto case 4;
				case 4:
				{
					int num;
					while (((num = this.m__0020._0020(_0020)) & -16) == 0)
					{
						this.m__0001[_0029++] = (this.m__0020 = (byte)num);
						if (_0029 == _002E)
						{
							return true;
						}
					}
					if (num < 0)
					{
						return false;
					}
					if (num >= 17)
					{
						this.m__0020 = 0;
					}
					else if (_0029 == 0)
					{
						throw new Exception();
					}
					_0028 = num - 16;
					_0006 = 5;
					break;
				}
				case 5:
					break;
				}
				int num3 = _000A.m__0001[_0028];
				int num4 = _0020._0020(num3);
				if (num4 < 0)
				{
					return false;
				}
				_0020._0001(num3);
				num4 += _000A.m__0020[_0028];
				if (_0029 + num4 > _002E)
				{
					throw new Exception();
				}
				while (num4-- > 0)
				{
					this.m__0001[_0029++] = this.m__0020;
				}
				if (_0029 == _002E)
				{
					break;
				}
				_0006 = 4;
			}
			return true;
		}

		public _000B _0020()
		{
			//Discarded unreachable code: IL_0005, IL_0010, IL_001d, IL_004c, IL_0051, IL_0057, IL_005d, IL_0063, IL_0067, IL_006c, IL_0072, IL_0078, IL_007e
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 1 vs 0
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Incompatible stack heights: 0 vs 1
			//IL_0079: Incompatible stack heights: 1 vs 0
			//IL_0083: Expected O, but got Unknown
			byte[] array = new byte[_0007];
			Array.Copy(this.m__0001, 0, array, 0, _0007);
			return new _000B(array);
		}

		public _000B _0001()
		{
			//Discarded unreachable code: IL_0022, IL_005f, IL_0064, IL_0069, IL_0074, IL_007a, IL_0080, IL_0084, IL_008a
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Incompatible stack heights: 0 vs 1
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Incompatible stack heights: 0 vs 1
			//IL_0085: Incompatible stack heights: 1 vs 0
			byte[] array = new byte[_0008];
			Array.Copy(this.m__0001, _0007, array, 0, _0008);
			return new _000B(array);
		}
	}
	internal class _000B
	{
		private static int m__0020;

		private short[] m__0020;

		public static _000B _0020;

		public static _000B _0001;

		static _000B()
		{
			//Discarded unreachable code: IL_0011, IL_001e, IL_0172, IL_0177, IL_0186, IL_018c, IL_0192, IL_0196, IL_019b, IL_01a1
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Incompatible stack heights: 1 vs 0
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Incompatible stack heights: 0 vs 1
			_000B.m__0020 = 15;
			try
			{
				byte[] array = new byte[288];
				int num = 0;
				while (num < 144)
				{
					array[num++] = 8;
				}
				while (num < 256)
				{
					array[num++] = 9;
				}
				while (num < 280)
				{
					array[num++] = 7;
				}
				while (num < 288)
				{
					array[num++] = 8;
				}
				_000B._0020 = new _000B(array);
				array = new byte[32];
				num = 0;
				while (num < 32)
				{
					array[num++] = 5;
				}
				_0001 = new _000B(array);
			}
			catch (Exception)
			{
				throw new ApplicationException(_0007._0020(100644963, 1156238994, 1504702793));
			}
		}

		public _000B(byte[] _0020)
		{
			//Discarded unreachable code: IL_000a, IL_0027, IL_0043, IL_0048, IL_004e, IL_0053, IL_0059, IL_005e
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 3
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Incompatible stack heights: 0 vs 1
			this._0020(_0020);
		}

		private void _0020(byte[] _0020)
		{
			//Discarded unreachable code: IL_000a, IL_0017, IL_03f0, IL_03f5, IL_03fb, IL_0401, IL_0406, IL_040c, IL_0412, IL_0418, IL_041b, IL_0421
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Incompatible stack heights: 0 vs 1
			//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_0401: Incompatible stack heights: 0 vs 1
			//IL_0419: Unknown result type (might be due to invalid IL or missing references)
			//IL_041a: Unknown result type (might be due to invalid IL or missing references)
			//IL_041a: Incompatible stack heights: 0 vs 1
			//IL_041c: Incompatible stack heights: 1 vs 0
			int[] array = new int[_000B.m__0020 + 1];
			int[] array2 = new int[_000B.m__0020 + 1];
			foreach (int num in _0020)
			{
				if (num > 0)
				{
					array[num]++;
				}
			}
			int num2 = 0;
			int num3 = 512;
			for (int j = 1; j <= _000B.m__0020; j++)
			{
				array2[j] = num2;
				num2 += array[j] << 16 - j;
				if (j >= 10)
				{
					int num4 = array2[j] & 0x1FF80;
					int num5 = num2 & 0x1FF80;
					num3 += num5 - num4 >> 16 - j;
				}
			}
			if (num2 != 65536)
			{
				throw new Exception(_0007._0020(1913765748, 1156239060, 1504702801));
			}
			this.m__0020 = new short[num3];
			int num6 = 512;
			for (int num7 = _000B.m__0020; num7 >= 10; num7--)
			{
				int num8 = num2 & 0x1FF80;
				num2 -= array[num7] << 16 - num7;
				int num9 = num2 & 0x1FF80;
				for (int k = num9; k < num8; k += 128)
				{
					this.m__0020[_005D._0020(k)] = (short)((-num6 << 4) | num7);
					num6 += 1 << num7 - 9;
				}
			}
			for (int l = 0; l < _0020.Length; l++)
			{
				int num10 = _0020[l];
				if (num10 == 0)
				{
					continue;
				}
				num2 = array2[num10];
				int num11 = _005D._0020(num2);
				if (num10 <= 9)
				{
					do
					{
						this.m__0020[num11] = (short)((l << 4) | num10);
						num11 += 1 << num10;
					}
					while (num11 < 512);
				}
				else
				{
					int num12 = this.m__0020[num11 & 0x1FF];
					int num13 = 1 << (num12 & 0xF);
					num12 = -(num12 >> 4);
					do
					{
						this.m__0020[num12 | (num11 >> 9)] = (short)((l << 4) | num10);
						num11 += 1 << num10;
					}
					while (num11 < num13);
				}
				array2[num10] = num2 + (1 << 16 - num10);
			}
		}

		public int _0020(_003B _0020)
		{
			//Discarded unreachable code: IL_0017, IL_001f, IL_00ef, IL_00f4, IL_00fa, IL_0100, IL_0102, IL_0108, IL_010d, IL_0114, IL_011a
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Incompatible stack heights: 0 vs 1
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Incompatible stack heights: 0 vs 1
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected I4, but got Unknown
			int num;
			int num2;
			if ((num = _0020._0020(9)) >= 0)
			{
				if ((num2 = this.m__0020[num]) >= 0)
				{
					_0020._0001(num2 & 0xF);
					return num2 >> 4;
				}
				int num3 = -(num2 >> 4);
				int num4 = num2 & 0xF;
				if ((num = _0020._0020(num4)) >= 0)
				{
					num2 = this.m__0020[num3 | (num >> 9)];
					_0020._0001(num2 & 0xF);
					return num2 >> 4;
				}
				int num5 = _0020._0020();
				num = _0020._0020(num5);
				num2 = this.m__0020[num3 | (num >> 9)];
				if ((num2 & 0xF) <= num5)
				{
					_0020._0001(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			int num6 = _0020._0020();
			num = _0020._0020(num6);
			num2 = this.m__0020[num];
			if (num2 >= 0 && (num2 & 0xF) <= num6)
			{
				_0020._0001(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
	}
	internal class _000C : Exception
	{
		public _000C()
		{
		}//Discarded unreachable code: IL_001c, IL_0033, IL_0038, IL_003e, IL_0044, IL_004a, IL_0050, IL_0056, IL_005b, IL_0061
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Incompatible stack heights: 0 vs 2
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Incompatible stack heights: 0 vs 1


		public _000C(string _0020)
			: base(_0020)
		{
		}//Discarded unreachable code: IL_0005, IL_0022, IL_003b, IL_0040, IL_0045, IL_0047, IL_004d, IL_0053, IL_0059
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Incompatible stack heights: 0 vs 1
		//IL_002e: Incompatible stack heights: 1 vs 0
		//IL_0040: Incompatible stack heights: 1 vs 0
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)

	}
	internal class _000D
	{
		private static readonly string m__0020 = _0009._0020(1833414710, 1159332157, 1893247387);

		private static readonly string m__0001 = _0009._0020(810016494, 1159332131, 1893247389);

		private static readonly string m__0002 = _0009._0020(371334914, 1159332309, 1893247385);

		private static HybridDictionary m__0020 = null;

		private static ResourceManager m__0020 = null;

		private static _0011 m__0020 = new _0011();

		private static bool m__0020 = false;

		[SpecialName]
		private static bool _0020()
		{
			//Discarded unreachable code: IL_0005, IL_0048, IL_004d, IL_0053, IL_005f, IL_0064, IL_0066, IL_006c, IL_0070, IL_0076
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Incompatible stack heights: 2 vs 0
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Incompatible stack heights: 2 vs 1
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Incompatible stack heights: 0 vs 1
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Incompatible stack heights: 0 vs 1
			//IL_0071: Incompatible stack heights: 1 vs 0
			return bool.Parse(_0009._0020(399738695, 1159332779, 1893247385));
		}

		private static bool _0020(string[] _0020)
		{
			//Discarded unreachable code: IL_0016, IL_001e, IL_01cf, IL_01d4, IL_01d6, IL_01dc, IL_01df, IL_01e4, IL_01e7, IL_01ed
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Incompatible stack heights: 2 vs 1
			//IL_01df: Incompatible stack heights: 0 vs 2
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Incompatible stack heights: 0 vs 1
			//IL_01e8: Incompatible stack heights: 2 vs 0
			if (_0009._0020(19357588, 1159332835, 1893247385).ToLower() == _0009._0020(1150844799, 1159332843, 1893247387) && _0020 != null && _0020.Length > 0)
			{
				string text = _0009._0020(1438950323, 1159332843, 1893247379);
				string text2 = _0009._0020(1638790906, 1159332843, 1893247379);
				bool flag = bool.Parse(_0009._0020(978828669, 1159332765, 1893247385));
				string text3 = _0009._0020(1166860211, 1159332765, 1893247379);
				_002F._0023 _0023 = (bool.Parse(_0009._0020(226454848, 1159332741, 1893247387)) ? _002F._0023._0020 : _002F._0023._0001);
				if (_0020[0] == _0009._0020(71682369, 1159332789, 1893247363))
				{
					string location = Assembly.GetEntryAssembly()!.Location;
					if (_002F._0020(location, text, text2, flag, _0004: true, text3, _0023))
					{
						return _000D._0020();
					}
					Environment.Exit(5);
				}
				if (_0020[0] == _0009._0020(1240149276, 1159332769, 1893247367))
				{
					if (_002F._0020(text, _0001: true))
					{
						return _000D._0020();
					}
					Environment.Exit(5);
				}
			}
			return true;
		}

		[STAThread]
		private static void _0001(string[] _0020)
		{
			//Discarded unreachable code: IL_000a, IL_0012, IL_001c, IL_009c, IL_00a1, IL_00a3, IL_00a9, IL_00ae, IL_00b4, IL_00ba, IL_00c1, IL_00c7, IL_00cb, IL_00d1
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0017: Incompatible stack heights: 1 vs 0
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 0 vs 2
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Incompatible stack heights: 0 vs 1
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Incompatible stack heights: 0 vs 1
			if (_000D._0020(_0020))
			{
				_000E obj = new _000E();
				if (!(obj._0020(DateTime.Now.Millisecond) != _0009._0020(6156323, 1159332857, 1893247383)))
				{
					AppDomain currentDomain = AppDomain.CurrentDomain;
					currentDomain.AssemblyResolve += _000D._0020;
					_0002(_0020);
				}
			}
		}

		private static void _0002(string[] _0020)
		{
			//Discarded unreachable code: IL_0011, IL_0019, IL_007c, IL_0081, IL_0085, IL_008a, IL_0099, IL_009f, IL_00a5
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 2
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Incompatible stack heights: 0 vs 1
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Incompatible stack heights: 1 vs 0
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			byte[] array = _000D._0020(_0009._0020(764991440, 1159332669, 1893247443));
			if (array == null)
			{
				throw new Exception(_0009._0020(1360775782, 1159332861, 1893247443));
			}
			_000D._0020((Assembly)_000D._0020(array), _0020);
			array = null;
		}

		private static object _0020(byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0014, IL_001b, IL_00a2, IL_00a7, IL_00b0, IL_00b6, IL_00b8, IL_00be, IL_00c4, IL_00c9
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 1 vs 0
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Incompatible stack heights: 0 vs 2
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Incompatible stack heights: 1 vs 0
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			try
			{
				_000E obj = new _000E();
				if (obj._0020(DateTime.Now.Millisecond) != _0009._0020(1312260097, 1159332733, 1893247383))
				{
					return null;
				}
				return Assembly.Load(_0020);
			}
			catch (Exception)
			{
				return null;
			}
		}

		private static Assembly _0001()
		{
			//Discarded unreachable code: IL_0005, IL_0012, IL_001e, IL_0090, IL_0095, IL_0098, IL_009d, IL_00a0, IL_00a6, IL_00a9, IL_00af
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_0019: Incompatible stack heights: 1 vs 0
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Incompatible stack heights: 0 vs 1
			//IL_00aa: Incompatible stack heights: 1 vs 0
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			Assembly assembly = null;
			try
			{
				byte[] array = _0020(_0009._0020(933586430, 1159332721, 1893247369));
				if (array == null)
				{
					return null;
				}
				MemoryStream memoryStream = new MemoryStream(array);
				return Assembly.Load(memoryStream.ToArray());
			}
			catch
			{
				return null;
			}
		}

		private static void _0020(Assembly _0020, string[] _0001)
		{
			//Discarded unreachable code: IL_000b, IL_0019, IL_002a, IL_0063, IL_0068, IL_006e, IL_0079, IL_007e, IL_0084
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 1 vs 0
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			MethodInfo entryPoint = _0020.EntryPoint;
			ParameterInfo[] parameters = entryPoint.GetParameters();
			object[] parameters2 = null;
			if (parameters != null && parameters.Length > 0)
			{
				parameters2 = new object[1] { _0001 };
			}
			entryPoint.Invoke(null, parameters2);
		}

		[Obfuscation(StripAfterObfuscation = false, Feature = "cw method body protection", Exclude = true)]
		private static Assembly _0020(object _0020, ResolveEventArgs _0001)
		{
			//Discarded unreachable code: IL_0016, IL_002a, IL_002f, IL_0035, IL_003b, IL_0041, IL_0043, IL_0048
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Incompatible stack heights: 0 vs 3
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Incompatible stack heights: 0 vs 1
			return _000D._0020(_0001);
		}

		private static Assembly _0020(ResolveEventArgs _0020)
		{
			//Discarded unreachable code: IL_0010, IL_001b, IL_0046, IL_004b, IL_004f, IL_0055, IL_0059, IL_005e, IL_0064, IL_006a, IL_0070, IL_0076
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 0 vs 2
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Incompatible stack heights: 0 vs 1
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Incompatible stack heights: 0 vs 1
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Incompatible stack heights: 1 vs 0
			if (_000D.m__0020)
			{
				return null;
			}
			return (Assembly)_0003(_0020.Name);
		}

		[SpecialName]
		public static string _0002()
		{
			//Discarded unreachable code: IL_000b, IL_001a, IL_0021, IL_0033, IL_0038, IL_0041, IL_0047, IL_004d, IL_0050, IL_0055, IL_005b
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 1 vs 0
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Incompatible stack heights: 0 vs 1
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Incompatible stack heights: 2 vs 1
			//IL_0050: Incompatible stack heights: 0 vs 2
			//IL_0056: Incompatible stack heights: 2 vs 0
			return Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		}

		private static byte[] _0020(string _0020)
		{
			//Discarded unreachable code: IL_000b, IL_001d, IL_0027, IL_00e0, IL_00e5, IL_00ed, IL_00f3, IL_00f9, IL_00fe
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Incompatible stack heights: 1 vs 0
			//IL_00f9: Incompatible stack heights: 0 vs 1
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			byte[] array = null;
			if (_000D.m__0020 == null)
			{
				_000D.m__0020 = new ResourceManager(_0009._0020(661644598, 1159332475, 1893247443), typeof(_000D).Assembly);
			}
			try
			{
				_000D.m__0020 = true;
				string text = _0001(_0020);
				return _000E._0001((byte[])_000D.m__0020.GetObject(_000E._0001(text)), _0009._0020(1639244766, 1159332553, 1893247485), _0009._0020(721077208, 1159332703, 1893247485));
			}
			finally
			{
				_000D.m__0020 = false;
			}
		}

		private static string _0001(string _0020)
		{
			//Discarded unreachable code: IL_0005, IL_000d, IL_0144, IL_0149, IL_014b, IL_0150, IL_0158, IL_015e, IL_0164, IL_016a, IL_0170
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 1 vs 0
			//IL_0023: Incompatible stack heights: 1 vs 0
			//IL_0029: Incompatible stack heights: 0 vs 1
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Incompatible stack heights: 1 vs 0
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Expected O, but got Unknown
			string text = _0020;
			text = text.Replace(_0009._0020(454890988, 1159332343, 1893247377), _0009._0020(1473864193, 1159332339, 1893247383));
			text = text.Replace(_0009._0020(1839879233, 1159332349, 1893247377), _0009._0020(334239139, 1159332345, 1893247383));
			text = text.Replace(_0009._0020(548005736, 1159332245, 1893247367), _0009._0020(1560034073, 1159332241, 1893247383));
			text = text.Replace(_0009._0020(2096185355, 1159332237, 1893247367), _0009._0020(1016323893, 1159332233, 1893247383));
			return text.Replace(_0009._0020(80140947, 1159332287, 1893247389), _0009._0020(609655576, 1159332283, 1893247383));
		}

		private static byte[] _0020(StringDictionary _0020)
		{
			//Discarded unreachable code: IL_0011, IL_002a, IL_0263, IL_0268, IL_0274, IL_027a, IL_0280, IL_0286, IL_028b, IL_0290, IL_0292, IL_0298
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 0 vs 2
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Unknown result type (might be due to invalid IL or missing references)
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Incompatible stack heights: 1 vs 0
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Incompatible stack heights: 0 vs 1
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Incompatible stack types: I8 vs I
			string text = null;
			byte[] array = null;
			string text2 = _0020[_000D.m__0001];
			string text3 = _0020[_000D.m__0020];
			bool flag = text2.ToLower().Equals(_0009._0020(448212061, 1159332341, 1893247389));
			AppDomain currentDomain = AppDomain.CurrentDomain;
			StringCollection stringCollection = new StringCollection();
			text = currentDomain.SetupInformation.ApplicationBase;
			if (!flag)
			{
				text = Path.Combine(text, text2);
			}
			stringCollection.Add(text);
			stringCollection.Add(Path.Combine(text, text3));
			array = _000D._0020(stringCollection, text3);
			if (array != null)
			{
				return array;
			}
			stringCollection = new StringCollection();
			text = currentDomain.SetupInformation.get_PrivateBinPath();
			if (text == null || text.Trim().Length <= 0)
			{
				return null;
			}
			string[] array2 = text.Split(new char[1] { Path.PathSeparator });
			for (int i = 0; i < array2.Length; i++)
			{
				text = array2[i].Trim(' ', '\t', Path.PathSeparator);
				if (!Path.IsPathRooted(text))
				{
					text = Path.Combine(currentDomain.SetupInformation.ApplicationBase, text);
				}
				if (!flag)
				{
					text = Path.Combine(text, text2);
				}
				stringCollection.Add(text);
				stringCollection.Add(Path.Combine(text, text3));
			}
			return _000D._0020(stringCollection, text3);
		}

		private static byte[] _0020(StringCollection _0020, string _0001)
		{
			//Discarded unreachable code: IL_0016, IL_001e, IL_005d, IL_0062, IL_0068, IL_0072, IL_0077, IL_007d
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Incompatible stack heights: 0 vs 1
			//IL_0078: Incompatible stack heights: 1 vs 0
			for (int i = 0; i < _0020.Count; i++)
			{
				string text = Path.Combine(_0020[i], _0001 + _000D.m__0002);
				if (File.Exists(text))
				{
					return _0002(text);
				}
			}
			return null;
		}

		private static byte[] _0002(string _0020)
		{
			//Discarded unreachable code: IL_001c, IL_002f, IL_006b, IL_0070, IL_0076, IL_007c, IL_007f, IL_0084, IL_008c, IL_0092, IL_0098, IL_009e
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 1 vs 0
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Incompatible stack heights: 0 vs 1
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Incompatible stack heights: 0 vs 1
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Incompatible stack heights: 0 vs 1
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Incompatible stack heights: 1 vs 0
			FileStream fileStream = null;
			byte[] array = null;
			try
			{
				fileStream = File.OpenRead(_0020);
				array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				fileStream.Flush();
				return array;
			}
			finally
			{
				fileStream?.Close();
				fileStream = null;
			}
		}

		private static object _0003(string _0020)
		{
			//Discarded unreachable code: IL_0005, IL_001e, IL_0179, IL_017e, IL_0189, IL_018e, IL_0191, IL_0197, IL_019d
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_0026: Incompatible stack heights: 2 vs 0
			//IL_002c: Incompatible stack heights: 0 vs 2
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Incompatible stack heights: 0 vs 1
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Incompatible stack heights: 0 vs 1
			//IL_0198: Incompatible stack heights: 1 vs 0
			if (_0020 == null)
			{
				return null;
			}
			if (_000D.m__0020 == null)
			{
				_000D.m__0020 = new HybridDictionary();
			}
			_0020 = _0020.Trim();
			string key = _0020.ToLower();
			if (_000D.m__0020[key] != null)
			{
				return (Assembly)_000D.m__0020[key];
			}
			StringDictionary stringDictionary = _0004(_0020);
			string text = stringDictionary[_000D.m__0020];
			byte[] array = null;
			if (text.ToLower().Equals(_0009._0020(1846363682, 1159332295, 1893247361)))
			{
				Assembly assembly = _0001();
				_000D.m__0020[key] = assembly;
				return assembly;
			}
			array = _000D._0020(_0020);
			if (array == null)
			{
				array = _000D._0020(text);
			}
			if (array == null)
			{
				try
				{
					array = _000D._0020(stringDictionary);
				}
				catch
				{
					array = null;
				}
			}
			if (array == null)
			{
				return null;
			}
			object obj2 = _000D._0020(array);
			array = null;
			_000D.m__0020[key] = obj2;
			return obj2;
		}

		private static StringDictionary _0004(string _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0014, IL_00e7, IL_00ec, IL_00f2, IL_00f8, IL_00fe, IL_0106, IL_010b
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 1 vs 0
			//IL_00db: Incompatible stack heights: 1 vs 0
			//IL_00e0: Incompatible stack heights: 0 vs 1
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Incompatible stack heights: 0 vs 1
			//IL_0106: Incompatible stack heights: 1 vs 0
			StringDictionary stringDictionary = new StringDictionary();
			string[] array = _0020.Split(new char[1] { ',' });
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Trim(' ', ',').Split(new char[1] { '=' });
				if (array2.Length < 2)
				{
					stringDictionary.Add(_000D.m__0020, array2[0]);
					continue;
				}
				stringDictionary.Add(array2[0].Trim(' ', '='), array2[1].Trim(' ', '='));
			}
			return stringDictionary;
		}
	}
	internal interface _0022
	{
		[SpecialName]
		long _0020();

		void _0001();

		void _0020(int _0020);

		void _0020(byte[] _0020);

		void _0020(byte[] _0020, int _0001, int _0002);
	}
	internal class _0024 : _0022
	{
		private static readonly uint m__0020 = uint.MaxValue;

		public static readonly uint[] _0020 = new uint[256]
		{
			0u, 1996959894u, 3993919788u, 2567524794u, 124634137u, 1886057615u, 3915621685u, 2657392035u, 249268274u, 2044508324u,
			3772115230u, 2547177864u, 162941995u, 2125561021u, 3887607047u, 2428444049u, 498536548u, 1789927666u, 4089016648u, 2227061214u,
			450548861u, 1843258603u, 4107580753u, 2211677639u, 325883990u, 1684777152u, 4251122042u, 2321926636u, 335633487u, 1661365465u,
			4195302755u, 2366115317u, 997073096u, 1281953886u, 3579855332u, 2724688242u, 1006888145u, 1258607687u, 3524101629u, 2768942443u,
			901097722u, 1119000684u, 3686517206u, 2898065728u, 853044451u, 1172266101u, 3705015759u, 2882616665u, 651767980u, 1373503546u,
			3369554304u, 3218104598u, 565507253u, 1454621731u, 3485111705u, 3099436303u, 671266974u, 1594198024u, 3322730930u, 2970347812u,
			795835527u, 1483230225u, 3244367275u, 3060149565u, 1994146192u, 31158534u, 2563907772u, 4023717930u, 1907459465u, 112637215u,
			2680153253u, 3904427059u, 2013776290u, 251722036u, 2517215374u, 3775830040u, 2137656763u, 141376813u, 2439277719u, 3865271297u,
			1802195444u, 476864866u, 2238001368u, 4066508878u, 1812370925u, 453092731u, 2181625025u, 4111451223u, 1706088902u, 314042704u,
			2344532202u, 4240017532u, 1658658271u, 366619977u, 2362670323u, 4224994405u, 1303535960u, 984961486u, 2747007092u, 3569037538u,
			1256170817u, 1037604311u, 2765210733u, 3554079995u, 1131014506u, 879679996u, 2909243462u, 3663771856u, 1141124467u, 855842277u,
			2852801631u, 3708648649u, 1342533948u, 654459306u, 3188396048u, 3373015174u, 1466479909u, 544179635u, 3110523913u, 3462522015u,
			1591671054u, 702138776u, 2966460450u, 3352799412u, 1504918807u, 783551873u, 3082640443u, 3233442989u, 3988292384u, 2596254646u,
			62317068u, 1957810842u, 3939845945u, 2647816111u, 81470997u, 1943803523u, 3814918930u, 2489596804u, 225274430u, 2053790376u,
			3826175755u, 2466906013u, 167816743u, 2097651377u, 4027552580u, 2265490386u, 503444072u, 1762050814u, 4150417245u, 2154129355u,
			426522225u, 1852507879u, 4275313526u, 2312317920u, 282753626u, 1742555852u, 4189708143u, 2394877945u, 397917763u, 1622183637u,
			3604390888u, 2714866558u, 953729732u, 1340076626u, 3518719985u, 2797360999u, 1068828381u, 1219638859u, 3624741850u, 2936675148u,
			906185462u, 1090812512u, 3747672003u, 2825379669u, 829329135u, 1181335161u, 3412177804u, 3160834842u, 628085408u, 1382605366u,
			3423369109u, 3138078467u, 570562233u, 1426400815u, 3317316542u, 2998733608u, 733239954u, 1555261956u, 3268935591u, 3050360625u,
			752459403u, 1541320221u, 2607071920u, 3965973030u, 1969922972u, 40735498u, 2617837225u, 3943577151u, 1913087877u, 83908371u,
			2512341634u, 3803740692u, 2075208622u, 213261112u, 2463272603u, 3855990285u, 2094854071u, 198958881u, 2262029012u, 4057260610u,
			1759359992u, 534414190u, 2176718541u, 4139329115u, 1873836001u, 414664567u, 2282248934u, 4279200368u, 1711684554u, 285281116u,
			2405801727u, 4167216745u, 1634467795u, 376229701u, 2685067896u, 3608007406u, 1308918612u, 956543938u, 2808555105u, 3495958263u,
			1231636301u, 1047427035u, 2932959818u, 3654703836u, 1088359270u, 936918000u, 2847714899u, 3736837829u, 1202900863u, 817233897u,
			3183342108u, 3401237130u, 1404277552u, 615818150u, 3134207493u, 3453421203u, 1423857449u, 601450431u, 3009837614u, 3294710456u,
			1567103746u, 711928724u, 3020668471u, 3272380065u, 1510334235u, 755167117u
		};

		private uint m__0001;

		[SpecialName]
		public long _0020()
		{
			//Discarded unreachable code: IL_0005, IL_000f, IL_0028, IL_002d, IL_0031, IL_0037, IL_003d, IL_0043, IL_0048
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 1 vs 3
			//IL_001b: Incompatible stack heights: 1 vs 0
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Incompatible stack heights: 1 vs 0
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected I8, but got Unknown
			return this.m__0001;
		}

		[SpecialName]
		public void _0020(long _0020)
		{
			//Discarded unreachable code: IL_0005, IL_000f, IL_0026, IL_002b, IL_0030, IL_0036, IL_003c
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 1 vs 0
			//IL_002b: Incompatible stack heights: 1 vs 0
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			this.m__0001 = (uint)_0020;
		}

		public void _0001()
		{
			//Discarded unreachable code: IL_000a, IL_001a, IL_002b, IL_0030, IL_0036, IL_003b, IL_0041, IL_0044, IL_004a, IL_0050
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Incompatible stack heights: 0 vs 1
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			this.m__0001 = 0u;
		}

		public void _0020(int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0012, IL_006c, IL_0071, IL_0075, IL_007b, IL_0081, IL_0086, IL_008c, IL_0092
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 2 vs 1
			//IL_001b: Incompatible stack heights: 1 vs 0
			//IL_007c: Incompatible stack heights: 1 vs 0
			//IL_0081: Incompatible stack heights: 2 vs 0
			//IL_008d: Incompatible stack heights: 0 vs 1
			this.m__0001 ^= _0024.m__0020;
			this.m__0001 = _0024._0020[(this.m__0001 ^ _0020) & 0xFF] ^ (this.m__0001 >> 8);
			this.m__0001 ^= _0024.m__0020;
		}

		public void _0020(byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_000e, IL_001d, IL_0037, IL_003c, IL_003f, IL_0045, IL_004d, IL_0053, IL_0058
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 1 vs 0
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Incompatible stack heights: 1 vs 2
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Incompatible stack heights: 0 vs 1
			//IL_0053: Incompatible stack heights: 1 vs 0
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			this._0020(_0020, 0, _0020.Length);
		}

		public void _0020(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_001c, IL_0113, IL_0118, IL_011e, IL_0126, IL_012c, IL_0131, IL_0133, IL_0139
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Incompatible stack heights: 0 vs 1
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Incompatible stack heights: 0 vs 1
			if (_0020 == null)
			{
				throw new ArgumentNullException(_3._0020(866368586, 777721449, 683799930));
			}
			if (_0001 < 0 || _0002 < 0 || _0001 + _0002 > _0020.Length)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.m__0001 ^= _0024.m__0020;
			while (--_0002 >= 0)
			{
				this.m__0001 = _0024._0020[(this.m__0001 ^ _0020[_0001++]) & 0xFF] ^ (this.m__0001 >> 8);
			}
			this.m__0001 ^= _0024.m__0020;
		}
	}
	internal class _0025 : Stream
	{
		protected _005C _0020;

		protected byte[] _0020;

		protected int _0020;

		private byte[] m__0001 = new byte[1];

		protected Stream _0020;

		protected byte[] _0002;

		private uint[] m__0020;

		public _0025(Stream _0020)
			: this(_0020, new _005C(), 4096)
		{
		}//Discarded unreachable code: IL_0005, IL_0012, IL_002f, IL_0049, IL_004e, IL_0053, IL_0059, IL_005f, IL_0065, IL_0068, IL_006e
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Incompatible stack heights: 0 vs 1
		//IL_0032: Incompatible stack heights: 2 vs 0
		//IL_004e: Incompatible stack heights: 2 vs 0
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Incompatible stack heights: 0 vs 1


		public _0025(Stream _0020, _005C _0001)
			: this(_0020, _0001, 4096)
		{
		}//Discarded unreachable code: IL_000b, IL_0013, IL_0031, IL_0036, IL_003c, IL_0044, IL_004a, IL_004f, IL_0055, IL_0058, IL_005e
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Incompatible stack heights: 1 vs 0
		//IL_0045: Incompatible stack heights: 0 vs 3
		//IL_004a: Incompatible stack heights: 1 vs 0
		//IL_0050: Incompatible stack heights: 3 vs 0
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Incompatible stack heights: 0 vs 1
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)


		public _0025(Stream _0020, _005C _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_001b, IL_00bb, IL_00c0, IL_00c5, IL_00cb, IL_00cf, IL_00d5, IL_00db
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Incompatible stack heights: 1 vs 0
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 1 vs 2
			//IL_00c0: Incompatible stack heights: 1 vs 0
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Incompatible stack heights: 0 vs 1
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			this._0020 = _0020;
			this._0020 = _0001;
			try
			{
				this._0020 = (int)_0020.Length;
			}
			catch (Exception)
			{
				this._0020 = 0;
			}
			if (_0002 <= 0)
			{
				throw new ArgumentOutOfRangeException(_5._0020(766581381, 146259295, 651487842));
			}
			this._0020 = new byte[_0002];
		}

		[SpecialName]
		public override bool get_CanRead()
		{
			//Discarded unreachable code: IL_0005, IL_002d, IL_0032, IL_003a, IL_003f, IL_0042, IL_0048, IL_004e
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Incompatible stack heights: 1 vs 0
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0049: Incompatible stack heights: 1 vs 0
			return this._0020.CanRead;
		}

		[SpecialName]
		public override bool get_CanSeek()
		{
			//Discarded unreachable code: IL_0005, IL_0016, IL_001d, IL_002c, IL_0031, IL_0035, IL_003a, IL_0040, IL_0044, IL_004a
			//IL_0011: Incompatible stack heights: 1 vs 0
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Incompatible stack heights: 1 vs 0
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Incompatible stack heights: 0 vs 1
			return this._0020.CanSeek;
		}

		[SpecialName]
		public override bool get_CanWrite()
		{
			//Discarded unreachable code: IL_000b, IL_0014, IL_0027, IL_002c, IL_0032, IL_0038, IL_003a, IL_0040, IL_0046, IL_0049, IL_004e
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Incompatible stack heights: 0 vs 1
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Incompatible stack heights: 0 vs 2
			return this._0020.CanWrite;
		}

		[SpecialName]
		public override long get_Length()
		{
			//Discarded unreachable code: IL_000b, IL_001d, IL_002e, IL_0033, IL_0039, IL_003f, IL_0045, IL_0050, IL_0055
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 2
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Incompatible stack heights: 0 vs 1
			return this._0020;
		}

		[SpecialName]
		public override long get_Position()
		{
			//Discarded unreachable code: IL_001c, IL_0033, IL_0038, IL_003e, IL_0044, IL_0049
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 2
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected I8, but got Unknown
			return this._0020.Position;
		}

		[SpecialName]
		public override void set_Position(long _0020)
		{
			//Discarded unreachable code: IL_000b, IL_0032, IL_0037, IL_003c, IL_0042, IL_0045, IL_004b, IL_004e, IL_0054
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 2 vs 0
			//IL_0037: Incompatible stack heights: 2 vs 0
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Incompatible stack heights: 0 vs 1
			this._0020.Position = _0020;
		}

		public override void Flush()
		{
			//Discarded unreachable code: IL_0010, IL_002d, IL_0032, IL_0038, IL_0043, IL_0048, IL_004e, IL_0054, IL_0057, IL_005d, IL_0063
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Incompatible stack heights: 0 vs 1
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Incompatible stack heights: 0 vs 1
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_005e: Incompatible stack heights: 1 vs 0
			this._0020.Flush();
		}

		public override long Seek(long _0020, SeekOrigin _0001)
		{
			//Discarded unreachable code: IL_000a, IL_0018, IL_0021, IL_0033, IL_0038, IL_003d, IL_0043, IL_0048, IL_004b, IL_0051
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Incompatible stack heights: 0 vs 1
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Incompatible stack heights: 0 vs 1
			//IL_004c: Incompatible stack heights: 1 vs 0
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected I8, but got Unknown
			return this._0020.Seek(_0020, _0001);
		}

		public override void SetLength(long _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0021, IL_002a, IL_004a, IL_004f, IL_0055, IL_005b, IL_0061, IL_0066
			//IL_001c: Incompatible stack heights: 1 vs 0
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Incompatible stack heights: 1 vs 0
			//IL_0061: Incompatible stack heights: 1 vs 0
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			this._0020.SetLength(_0020);
		}

		public override void Write(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0011, IL_0027, IL_0040, IL_0045, IL_004b, IL_0050, IL_0056, IL_005c
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Incompatible stack heights: 1 vs 0
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Incompatible stack heights: 1 vs 0
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			this._0020.Write(_0020, _0001, _0002);
		}

		public override void WriteByte(byte _0020)
		{
			//Discarded unreachable code: IL_0005, IL_001d, IL_002d, IL_0032, IL_0038, IL_003c, IL_0041, IL_0045, IL_004b
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 2 vs 0
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 2 vs 1
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Incompatible stack types: O vs I8
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_0046: Incompatible stack heights: 2 vs 0
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			this._0020.WriteByte(_0020);
		}

		[SpecialName]
		public virtual int _0020()
		{
			//Discarded unreachable code: IL_0017, IL_0036, IL_003b, IL_0040, IL_0043, IL_0049, IL_0050, IL_0056
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Incompatible stack heights: 0 vs 1
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected I4, but got Unknown
			if (!this._0020._0008())
			{
				return 1;
			}
			return 0;
		}

		public override void Close()
		{
			//Discarded unreachable code: IL_0005, IL_0020, IL_003c, IL_0041, IL_0047, IL_004e, IL_0054, IL_005a, IL_005c, IL_0061
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Incompatible stack heights: 3 vs 0
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Incompatible stack heights: 0 vs 1
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Incompatible stack heights: 0 vs 1
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Incompatible stack heights: 0 vs 1
			//IL_005c: Incompatible stack heights: 3 vs 0
			this._0020.Close();
		}

		protected void _0001()
		{
			//Discarded unreachable code: IL_0010, IL_001e, IL_00d9, IL_00de, IL_00e1, IL_00e7, IL_00ec, IL_00f3, IL_00f9, IL_00ff, IL_0105
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Incompatible stack heights: 1 vs 0
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Incompatible stack heights: 0 vs 2
			//IL_00fa: Incompatible stack heights: 1 vs 0
			//IL_0100: Incompatible stack heights: 0 vs 1
			this._0020 = this._0020.Read(this._0020, 0, this._0020.Length);
			if (this._0002 != null)
			{
				_0020(this._0020, 0, this._0020.Length);
			}
			if (this._0020 <= 0)
			{
				throw new ApplicationException(_5._0020(1365432992, 146259419, 651487814));
			}
			this._0020._0001(this._0020, 0, this._0020);
		}

		public override int ReadByte()
		{
			//Discarded unreachable code: IL_0016, IL_0029, IL_004f, IL_0054, IL_0056, IL_005c, IL_0061, IL_0064, IL_006a, IL_0070
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 1 vs 0
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Incompatible stack heights: 2 vs 1
			//IL_0065: Incompatible stack heights: 0 vs 2
			//IL_006b: Incompatible stack heights: 2 vs 0
			int num = Read(this.m__0001, 0, 1);
			if (num > 0)
			{
				return this.m__0001[0] & 0xFF;
			}
			return -1;
		}

		public override int Read(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0013, IL_0022, IL_00f8, IL_00fd, IL_0100, IL_0106, IL_010c, IL_0112, IL_0118, IL_011d, IL_0123
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_0029: Incompatible stack heights: 1 vs 0
			//IL_00d9: Incompatible stack heights: 1 vs 0
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Incompatible stack heights: 1 vs 0
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected I4, but got Unknown
			while (true)
			{
				int num;
				try
				{
					num = this._0020._0002(_0020, _0001, _0002);
				}
				catch (Exception ex)
				{
					throw new _000C(ex.ToString());
				}
				if (num > 0)
				{
					return num;
				}
				if (this._0020._0007())
				{
					throw new _000C(_5._0020(1369311492, 146259387, 651487826));
				}
				if (this._0020._0008())
				{
					return 0;
				}
				if (!this._0020._0006())
				{
					break;
				}
				this._0001();
			}
			throw new InvalidOperationException(_5._0020(1355199040, 146259437, 651487834));
		}

		public long _0020(long _0020)
		{
			//Discarded unreachable code: IL_0005, IL_001e, IL_0096, IL_009b, IL_009e, IL_00a4, IL_00a9, IL_00af, IL_00b4, IL_00ba, IL_00c0
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 1 vs 0
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Incompatible stack heights: 1 vs 0
			//IL_00aa: Incompatible stack heights: 1 vs 0
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Incompatible stack heights: 1 vs 0
			//IL_00bb: Incompatible stack heights: 0 vs 1
			if (_0020 < 0)
			{
				throw new ArgumentOutOfRangeException(_5._0020(842506968, 146259289, 651487858));
			}
			int num = 2048;
			if (_0020 < num)
			{
				num = (int)_0020;
			}
			byte[] array = new byte[num];
			return this._0020.Read(array, 0, array.Length);
		}

		protected byte _0002()
		{
			//Discarded unreachable code: IL_0005, IL_001b, IL_003f, IL_0044, IL_004a, IL_0050, IL_0053, IL_0059, IL_005e, IL_0061, IL_0067
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Incompatible stack heights: 0 vs 1
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Incompatible stack heights: 0 vs 1
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Incompatible stack heights: 0 vs 1
			uint num = (this.m__0020[2] & 0xFFFFu) | 2u;
			return (byte)(num * (num ^ 1) >> 8);
		}

		protected void _0020(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0017, IL_0061, IL_0066, IL_006c, IL_0072, IL_0076, IL_007c, IL_0082, IL_0089, IL_008e
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 2 vs 0
			//IL_002a: Incompatible stack heights: 1 vs 2
			//IL_0059: Incompatible stack heights: 1 vs 0
			//IL_005e: Incompatible stack heights: 0 vs 1
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Incompatible stack heights: 0 vs 1
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Incompatible stack heights: 0 vs 1
			//IL_0089: Incompatible stack heights: 1 vs 0
			for (int i = _0001; i < _0001 + _0002; i++)
			{
				_0020[i] ^= this._0002();
				this._0020(_0020[i]);
			}
		}

		protected void _0020(string _0020)
		{
			//Discarded unreachable code: IL_000b, IL_0019, IL_0026, IL_0066, IL_006b, IL_0070, IL_0078, IL_007e, IL_0084
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 1 vs 0
			//IL_005b: Incompatible stack heights: 1 vs 0
			//IL_0063: Incompatible stack heights: 0 vs 1
			//IL_006b: Incompatible stack heights: 1 vs 0
			//IL_0079: Incompatible stack heights: 0 vs 2
			//IL_007f: Incompatible stack heights: 2 vs 0
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			this.m__0020 = new uint[3] { 305419896u, 591751049u, 878082192u };
			for (int i = 0; i < _0020.Length; i++)
			{
				this._0020((byte)_0020[i]);
			}
		}

		private uint _0020(uint _0020, byte _0001)
		{
			//Discarded unreachable code: IL_000b, IL_0018, IL_0022, IL_003d, IL_0042, IL_0048, IL_004e, IL_0062, IL_0067, IL_006d
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Incompatible stack heights: 0 vs 1
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Incompatible stack heights: 0 vs 1
			//IL_0068: Incompatible stack heights: 1 vs 0
			return _0024._0020[(_0020 ^ _0001) & 0xFF] ^ (_0020 >> 8);
		}

		protected void _0020(byte _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0091, IL_0096, IL_009c, IL_00a1, IL_00a7, IL_00af, IL_00b5
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Incompatible stack heights: 0 vs 1
			this.m__0020[0] = this._0020(this.m__0020[0], _0020);
			this.m__0020[1] = this.m__0020[1] + (byte)this.m__0020[0];
			this.m__0020[1] = this.m__0020[1] * 134775813 + 1;
			this.m__0020[2] = this._0020(this.m__0020[2], (byte)(this.m__0020[1] >> 24));
		}
	}
	internal enum _0026
	{
		_0020,
		_0001,
		_0002
	}
	internal class _002F
	{
		internal enum _0023
		{
			_0020 = 2,
			_0001
		}

		[DllImport("advapi32.dll")]
		internal static extern IntPtr OpenSCManager(string _0020, string _0001, int _0002);

		[DllImport("Advapi32.dll")]
		internal static extern IntPtr CreateService(IntPtr _0020, string _0001, string _0002, int _0003, int _0004, int _0005, int _0006, string _0007, string _0008, int _0009, string _002E, string _0028, string _0029);

		[DllImport("advapi32.dll")]
		internal static extern void CloseServiceHandle(IntPtr _0020);

		[DllImport("advapi32.dll")]
		internal static extern int StartService(IntPtr _0020, int _0001, string _0002);

		[DllImport("advapi32.dll", SetLastError = true)]
		internal static extern IntPtr OpenService(IntPtr _0020, string _0001, int _0002);

		[DllImport("advapi32.dll")]
		internal static extern int DeleteService(IntPtr _0020);

		[DllImport("kernel32.dll")]
		internal static extern int GetLastError();

		internal static bool _0020(string _0020, string _0001, string _0002, bool _0003, bool _0004, string _0005, _0023 _0006)
		{
			//Discarded unreachable code: IL_000b, IL_002c, IL_027b, IL_0280, IL_0286, IL_028f, IL_0294, IL_0296, IL_029c
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Incompatible stack heights: 1 vs 0
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Incompatible stack heights: 0 vs 1
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Incompatible stack heights: 0 vs 1
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Expected I4, but got Unknown
			int num = 2;
			int num2 = 16;
			int num3 = 1;
			int num4 = 983040;
			int num5 = 1;
			int num6 = 2;
			int num7 = 4;
			int num8 = 8;
			int num9 = 16;
			int num10 = 32;
			int num11 = 64;
			int num12 = 128;
			int num13 = 256;
			int num14 = num4 | num5 | num6 | num7 | num8 | num9 | num10 | num11 | num12 | num13;
			try
			{
				IntPtr intPtr = OpenSCManager(null, null, num);
				if (intPtr.ToInt32() != 0)
				{
					IntPtr intPtr2 = CreateService(intPtr, _0001, _0002, num14, num2, (int)_0006, num3, _0020, null, 0, null, null, null);
					if (intPtr2.ToInt32() != 0)
					{
						if (_0005 != _0._0020(1655251075, 1516187863, 1219784438) && !_002F._0020(_0001, _0005))
						{
							_002F._0002(_0._0020(799516885, 1516187801, 1219784372), _0004);
						}
						if (_0003 && StartService(intPtr2, 0, null) == 0)
						{
							_002F._0002(_0._0020(1567723247, 1516187815, 1219784408), _0004);
						}
						_002F._0003(_0._0020(1198330337, 1516187747, 1219784394), _0004);
						CloseServiceHandle(intPtr);
						return true;
					}
					_002F._0001(_0._0020(777159751, 1516187863, 1219784390), _0004);
					CloseServiceHandle(intPtr);
				}
				else
				{
					_002F._0001(_0._0020(1027633533, 1516187695, 1219784378), _0004);
				}
			}
			catch (Exception ex)
			{
				_002F._0001(ex.ToString(), _0004);
			}
			return false;
		}

		internal static bool _0020(string _0020, bool _0001)
		{
			//Discarded unreachable code: IL_0005, IL_0014, IL_001e, IL_0161, IL_0166, IL_016c, IL_016f, IL_0175, IL_017b, IL_0185, IL_018a
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0022: Incompatible stack heights: 1 vs 0
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Incompatible stack heights: 0 vs 1
			//IL_0176: Incompatible stack heights: 1 vs 0
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Incompatible stack heights: 0 vs 1
			//IL_0185: Incompatible stack heights: 1 vs 0
			try
			{
				int num = 1073741824;
				IntPtr intPtr = OpenSCManager(null, null, num);
				if (intPtr.ToInt32() != 0)
				{
					int num2 = 65536;
					IntPtr intPtr2 = OpenService(intPtr, _0020, num2);
					if (intPtr2.ToInt32() != 0)
					{
						if (DeleteService(intPtr2) != 0)
						{
							_0003(_0._0020(1137674752, 1516188109, 1219784374), _0001);
							CloseServiceHandle(intPtr);
							return true;
						}
						_002F._0001(_0._0020(21726743, 1516188035, 1219784384), _0001);
						CloseServiceHandle(intPtr);
						return false;
					}
					_002F._0001(_0._0020(1705840515, 1516187995, 1219784398), _0001);
				}
				else
				{
					_002F._0001(_0._0020(608335244, 1516187911, 1219784378), _0001);
				}
			}
			catch (Exception ex)
			{
				_002F._0001(ex.ToString(), _0001);
			}
			return false;
		}

		internal static bool _0020(string _0020, string _0001)
		{
			//Discarded unreachable code: IL_000b, IL_0017, IL_0021, IL_002f, IL_018e, IL_0193, IL_0199, IL_019d, IL_01a3, IL_01a5, IL_01ab, IL_01b1, IL_01b6
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Incompatible stack heights: 2 vs 1
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 2
			//IL_0024: Incompatible stack heights: 1 vs 0
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Incompatible stack heights: 2 vs 1
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Incompatible stack heights: 0 vs 1
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Incompatible stack heights: 2 vs 0
			if (_0001 == _0._0020(1469596910, 1516188173, 1219784438))
			{
				return true;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = false;
			_0020._002C _002C = default(_0020._002C);
			_002C._0020 = _0001;
			try
			{
				num = global::_0020._0020.OpenSCManagerA(null, null, global::_0020._0020._0008._0006);
				if (num < 1)
				{
					return false;
				}
				num2 = global::_0020._0020.LockServiceDatabase(num);
				if (num2 < 1)
				{
					return false;
				}
				num3 = global::_0020._0020.OpenServiceA(num, _0020, global::_0020._0020._0009._0009);
				if (num3 < 1)
				{
					return false;
				}
				return global::_0020._0020.ChangeServiceConfig2A(num3, global::_0020._0020._003D._0020, ref _002C);
			}
			catch
			{
			}
			finally
			{
				if (num3 > 0)
				{
					global::_0020._0020.CloseServiceHandle(num3);
				}
				if (num2 > 0)
				{
					global::_0020._0020.UnlockServiceDatabase(num2);
				}
				if (num != 0)
				{
					global::_0020._0020.CloseServiceHandle(num);
				}
			}
			return false;
		}

		internal static void _0001(string _0020, bool _0001)
		{
			//Discarded unreachable code: IL_000b, IL_0014, IL_004f, IL_0054, IL_005a, IL_0060, IL_0066, IL_0071, IL_0076
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Incompatible stack heights: 0 vs 1
			_0003(_0._0020(677553774, 1516188173, 1219784440) + _0020, _0001);
		}

		internal static void _0002(string _0020, bool _0001)
		{
			//Discarded unreachable code: IL_0016, IL_001f, IL_004e, IL_0053, IL_0057, IL_005c, IL_005f, IL_0065, IL_006b, IL_006e, IL_0074, IL_0078, IL_007e, IL_0084
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Incompatible stack heights: 0 vs 1
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Incompatible stack heights: 0 vs 1
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Incompatible stack heights: 0 vs 1
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Incompatible stack heights: 0 vs 1
			//IL_0079: Incompatible stack heights: 1 vs 0
			_0003(_0._0020(669710182, 1516188191, 1219784420) + _0020, _0001);
		}

		internal static void _0003(string _0020, bool _0001)
		{
			//Discarded unreachable code: IL_0005, IL_002e, IL_0033, IL_0039, IL_003d, IL_0043, IL_0046, IL_004c, IL_0052, IL_0057
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 1 vs 0
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Incompatible stack heights: 0 vs 1
			//IL_0052: Incompatible stack heights: 1 vs 0
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			if (!_0001)
			{
				Console.WriteLine(_0020);
			}
		}
	}
	internal class _003A
	{
		private static int m__0020 = 32768;

		private static int m__0001 = _003A.m__0020 - 1;

		private byte[] m__0020 = new byte[_003A.m__0020];

		private int m__0002;

		private int _0003;

		public void _0020(int _0020)
		{
			//Discarded unreachable code: IL_000a, IL_00a9, IL_00ae, IL_00b1, IL_00b7, IL_00bd, IL_00c3, IL_00c9, IL_00ce
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Incompatible stack heights: 0 vs 2
			//IL_001f: Incompatible stack heights: 2 vs 0
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Incompatible stack heights: 1 vs 0
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Incompatible stack heights: 1 vs 2
			//IL_00c9: Incompatible stack heights: 0 vs 1
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			if (_0003++ == _003A.m__0020)
			{
				throw new InvalidOperationException(_6._0020(166933424, 1202018024, 649543878));
			}
			this.m__0020[this.m__0002++] = (byte)_0020;
			this.m__0002 &= _003A.m__0001;
		}

		private void _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_0015, IL_0068, IL_006d, IL_0070, IL_0076, IL_007b, IL_007f, IL_0085, IL_008b
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Incompatible stack heights: 0 vs 2
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Incompatible stack heights: 0 vs 1
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Incompatible stack heights: 0 vs 1
			while (_0001-- > 0)
			{
				this.m__0020[this.m__0002++] = this.m__0020[_0020++];
				this.m__0002 &= _003A.m__0001;
				_0020 &= _003A.m__0001;
			}
		}

		public void _0020(int _0020, int _0001)
		{
			//Discarded unreachable code: IL_001c, IL_0169, IL_016e, IL_0174, IL_017a, IL_0180, IL_0185, IL_018b
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			if ((_0003 += _0020) > _003A.m__0020)
			{
				throw new InvalidOperationException(_6._0020(1978012218, 1202018046, 649543878));
			}
			int num = (this.m__0002 - _0001) & _003A.m__0001;
			int num2 = _003A.m__0020 - _0020;
			if (num <= num2 && this.m__0002 < num2)
			{
				if (_0020 <= _0001)
				{
					Array.Copy(this.m__0020, num, this.m__0020, this.m__0002, _0020);
					this.m__0002 += _0020;
				}
				else
				{
					while (_0020-- > 0)
					{
						this.m__0020[this.m__0002++] = this.m__0020[num++];
					}
				}
			}
			else
			{
				this._0020(num, _0020, _0001);
			}
		}

		public int _0020(_003B _0020, int _0001)
		{
			//Discarded unreachable code: IL_000a, IL_001e, IL_0028, IL_00c2, IL_00c7, IL_00cc, IL_00d2, IL_00d7, IL_00dd, IL_00e3
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_0023: Incompatible stack heights: 1 vs 0
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Incompatible stack heights: 0 vs 1
			//IL_00d8: Incompatible stack heights: 1 vs 0
			_0001 = Math.Min(Math.Min(_0001, _003A.m__0020 - _0003), _0020._0001());
			int num = _003A.m__0020 - this.m__0002;
			int num2;
			if (_0001 > num)
			{
				num2 = _0020._0020(this.m__0020, this.m__0002, num);
				if (num2 == num)
				{
					num2 += _0020._0020(this.m__0020, 0, _0001 - num);
				}
			}
			else
			{
				num2 = _0020._0020(this.m__0020, this.m__0002, _0001);
			}
			this.m__0002 = (this.m__0002 + num2) & _003A.m__0001;
			_0003 += num2;
			return num2;
		}

		public void _0020(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0020, IL_0071, IL_0076, IL_007c, IL_0083, IL_0088, IL_008e, IL_0094
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Incompatible stack heights: 1 vs 0
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Incompatible stack heights: 1 vs 0
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			if (_0003 > 0)
			{
				throw new InvalidOperationException();
			}
			if (_0002 > _003A.m__0020)
			{
				_0001 += _0002 - _003A.m__0020;
				_0002 = _003A.m__0020;
			}
			Array.Copy(_0020, _0001, this.m__0020, 0, _0002);
			this.m__0002 = _0002 & _003A.m__0001;
		}

		public int _0020()
		{
			//Discarded unreachable code: IL_000b, IL_0029, IL_002e, IL_0034, IL_003e, IL_0044, IL_0048, IL_004d, IL_0053, IL_0059
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 1
			return _003A.m__0020 - _0003;
		}

		public int _0001()
		{
			//Discarded unreachable code: IL_000b, IL_001a, IL_0030, IL_0035, IL_0039, IL_003f, IL_0043, IL_0049, IL_004f, IL_0053, IL_0058
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Incompatible stack heights: 0 vs 1
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Incompatible stack heights: 0 vs 1
			return _0003;
		}

		public int _0001(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0016, IL_001f, IL_00ae, IL_00b3, IL_00b6, IL_00bc, IL_00c2, IL_00c6, IL_00cb, IL_00cd, IL_00d3
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 2
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Incompatible stack heights: 1 vs 0
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Incompatible stack heights: 0 vs 1
			int num = this.m__0002;
			if (_0002 > _0003)
			{
				_0002 = _0003;
			}
			else
			{
				num = (this.m__0002 - _0003 + _0002) & _003A.m__0001;
			}
			int num2 = _0002;
			int num3 = _0002 - num;
			if (num3 > 0)
			{
				Array.Copy(this.m__0020, _003A.m__0020 - num3, _0020, _0001, num3);
				_0001 += num3;
				_0002 = num;
			}
			Array.Copy(this.m__0020, num - _0002, _0020, _0001, _0002);
			_0003 -= num2;
			if (_0003 < 0)
			{
				throw new InvalidOperationException();
			}
			return num2;
		}

		public void _0002()
		{
			//Discarded unreachable code: IL_0005, IL_0023, IL_0036, IL_003b, IL_003f, IL_0044, IL_004a, IL_004e, IL_0054, IL_0058, IL_005e, IL_0064
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 1 vs 0
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Incompatible stack heights: 1 vs 0
			_0003 = (this.m__0002 = 0);
		}
	}
	internal class _003B
	{
		private byte[] m__0020;

		private int m__0020;

		private int m__0001;

		private uint m__0020;

		private int m__0002;

		public int _0020(int _0020)
		{
			//Discarded unreachable code: IL_000a, IL_0015, IL_00b0, IL_00b5, IL_00bb, IL_00c0, IL_00c6, IL_00c8, IL_00ce, IL_00d6, IL_00dc
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 1 vs 0
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Incompatible stack heights: 0 vs 1
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Incompatible stack heights: 0 vs 1
			if (this.m__0002 < _0020)
			{
				if (this.m__0020 == this.m__0001)
				{
					return -1;
				}
				this.m__0020 |= (uint)(((this.m__0020[this.m__0020++] & 0xFF) | ((this.m__0020[this.m__0020++] & 0xFF) << 8)) << this.m__0002);
				this.m__0002 += 16;
			}
			return (int)(this.m__0020 & ((1 << _0020) - 1));
		}

		public void _0001(int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_000c, IL_0015, IL_0025, IL_004f, IL_0054, IL_0058, IL_005e, IL_0063, IL_0066, IL_006c, IL_0072
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_0020: Incompatible stack heights: 1 vs 0
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Incompatible stack heights: 1 vs 0
			//IL_0065: Incompatible stack heights: 0 vs 1
			//IL_0067: Incompatible stack heights: 1 vs 0
			//IL_006d: Incompatible stack heights: 0 vs 1
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			this.m__0020 >>= _0020;
			this.m__0002 -= _0020;
		}

		public int _0002(int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_001b, IL_002d, IL_0036, IL_0052, IL_0057, IL_005d, IL_005f, IL_0065, IL_006b, IL_0071, IL_0077, IL_007a, IL_007f
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_0023: Incompatible stack heights: 1 vs 0
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Incompatible stack heights: 0 vs 1
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Incompatible stack heights: 0 vs 2
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Incompatible stack heights: 0 vs 1
			int num = this._0020(_0020);
			if (num >= 0)
			{
				_0001(_0020);
			}
			return num;
		}

		[SpecialName]
		public int _0020()
		{
			//Discarded unreachable code: IL_0010, IL_0027, IL_0032, IL_0037, IL_003d, IL_0043, IL_0049, IL_004e, IL_0056, IL_005c
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Incompatible stack heights: 0 vs 1
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_0057: Incompatible stack heights: 1 vs 0
			return this.m__0002;
		}

		[SpecialName]
		public int _0001()
		{
			//Discarded unreachable code: IL_0005, IL_0012, IL_003f, IL_0044, IL_004a, IL_0050, IL_0057, IL_005c, IL_0062, IL_0068
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 1 vs 0
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Incompatible stack heights: 1 vs 0
			return this.m__0001 - this.m__0020 + (this.m__0002 >> 3);
		}

		public void _0002()
		{
			//Discarded unreachable code: IL_0010, IL_004b, IL_0050, IL_0057, IL_005d, IL_0062, IL_0064, IL_006a
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_005d: Incompatible stack heights: 0 vs 2
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Incompatible stack heights: 0 vs 1
			//IL_0065: Incompatible stack heights: 2 vs 0
			this.m__0020 >>= this.m__0002 & 7;
			this.m__0002 &= -8;
		}

		[SpecialName]
		public bool _0003()
		{
			//Discarded unreachable code: IL_0010, IL_001a, IL_0031, IL_0036, IL_003a, IL_0040, IL_0046, IL_0048, IL_004e, IL_0055, IL_005b, IL_0061, IL_0066
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_001b: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 1 vs 0
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_0049: Incompatible stack heights: 1 vs 0
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Incompatible stack heights: 0 vs 1
			return this.m__0020 == this.m__0001;
		}

		public int _0020(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0016, IL_001e, IL_01ef, IL_01f4, IL_01f9, IL_01fe, IL_0201, IL_0207, IL_020d
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Incompatible stack heights: 0 vs 3
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0202: Incompatible stack heights: 3 vs 1
			//IL_0208: Incompatible stack heights: 1 vs 0
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			if (_0002 < 0)
			{
				throw new ArgumentOutOfRangeException(_7._0020(2019924686, 1546238134, 1684223504));
			}
			if (((uint)this.m__0002 & 7u) != 0)
			{
				throw new InvalidOperationException(_7._0020(1733887366, 1546238082, 1684223546));
			}
			int num = 0;
			while (this.m__0002 > 0 && _0002 > 0)
			{
				_0020[_0001++] = (byte)this.m__0020;
				this.m__0020 >>= 8;
				this.m__0002 -= 8;
				_0002--;
				num++;
			}
			if (_0002 == 0)
			{
				return num;
			}
			int num2 = this.m__0001 - this.m__0020;
			if (_0002 > num2)
			{
				_0002 = num2;
			}
			Array.Copy(this.m__0020, this.m__0020, _0020, _0001, _0002);
			this.m__0020 += _0002;
			if (((uint)(this.m__0020 - this.m__0001) & (true ? 1u : 0u)) != 0)
			{
				this.m__0020 = this.m__0020[this.m__0020++] & 0xFFu;
				this.m__0002 = 8;
			}
			return num + _0002;
		}

		public void _0004()
		{
			//Discarded unreachable code: IL_0005, IL_0015, IL_0049, IL_004e, IL_0054, IL_0059, IL_005f, IL_0065, IL_006b, IL_0070
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Incompatible stack heights: 0 vs 1
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Incompatible stack heights: 0 vs 1
			//IL_0060: Incompatible stack heights: 1 vs 0
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Incompatible stack heights: 0 vs 1
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			this.m__0020 = (uint)(this.m__0020 = (this.m__0001 = (this.m__0002 = 0)));
		}

		public void _0001(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0014, IL_0113, IL_0118, IL_011e, IL_0124, IL_012a, IL_012f
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Incompatible stack heights: 1 vs 0
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Incompatible stack heights: 1 vs 0
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			if (this.m__0020 < this.m__0001)
			{
				throw new InvalidOperationException(_7._0020(280534318, 1546238160, 1684223554));
			}
			int num = _0001 + _0002;
			if (0 > _0001 || _0001 > num || num > _0020.Length)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (((uint)_0002 & (true ? 1u : 0u)) != 0)
			{
				this.m__0020 |= (uint)((_0020[_0001++] & 0xFF) << this.m__0002);
				this.m__0002 += 8;
			}
			this.m__0020 = _0020;
			this.m__0020 = _0001;
			this.m__0001 = num;
		}
	}
	internal class _003F
	{
		public const bool _0020 = false;

		public const int _0020 = 0;

		public const int _0001 = 1;

		public const int _0002 = 2;

		public const int _0003 = 32;

		public const int _0004 = 8;

		public const int _0005 = 258;

		public const int _0006 = 3;

		public const int _0007 = 15;

		public const int _0008 = 32768;

		public const int _0009 = 32767;

		public const int _002E = 15;

		public const int _0028 = 32768;

		public const int _0029 = 32767;

		public const int _002A = 5;

		public const int _003D = 262;

		public const int _002C = 32506;

		public const int _0021 = 65536;

		public const int _002F = 0;

		public const int _0023 = 1;

		public const int _0022 = 2;

		public static int _0027 = Math.Min(65535, 65531);

		public static int[] _0020 = new int[10] { 0, 4, 4, 4, 4, 8, 8, 8, 32, 32 };

		public static int[] _0001 = new int[10] { 0, 4, 5, 6, 4, 16, 16, 32, 128, 258 };

		public static int[] _0002 = new int[10] { 0, 8, 16, 32, 16, 32, 128, 128, 258, 258 };

		public static int[] _0003 = new int[10] { 0, 4, 8, 32, 16, 32, 128, 256, 1024, 4096 };

		public static int[] _0004 = new int[10] { 0, 1, 1, 1, 1, 2, 2, 2, 2, 2 };
	}
	internal class _005B : _003F
	{
		private new static int m__0020 = 4096;

		private new int m__0001;

		private new short[] m__0020;

		private new short[] m__0001;

		private new int m__0002;

		private new int m__0003;

		private new bool m__0020;

		private new int m__0004;

		private new int m__0005;

		private new int m__0006;

		private new byte[] m__0020;

		private new _0026 m__0020;

		private new int m__0007;

		private new int m__0008;

		private new int m__0009;

		private new int _002E;

		private new int _0028;

		private new byte[] m__0001;

		private new int _0029;

		private new int _002A;

		private new int _003D;

		private new @_ m__0020;

		private new _005D m__0020;

		private new _0027 m__0020;

		public _005B(@_ _0020)
		{
			//Discarded unreachable code: IL_001c, IL_008d, IL_0092, IL_0098, IL_00a3, IL_00a9, IL_00ae, IL_00b4
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Incompatible stack heights: 0 vs 1
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			this.m__0020 = _0020;
			this.m__0020 = new _005D(_0020);
			this.m__0020 = new _0027();
			this.m__0020 = new byte[65536];
			this.m__0020 = new short[32768];
			this.m__0001 = new short[32768];
			this.m__0004 = (this.m__0005 = 1);
		}

		public new void _0020()
		{
			//Discarded unreachable code: IL_0005, IL_0019, IL_00a1, IL_00a6, IL_00ac, IL_00b1, IL_00b4, IL_00ba, IL_00c0
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 1 vs 0
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Incompatible stack heights: 0 vs 1
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			this.m__0020._0020();
			this.m__0020._0001();
			this.m__0004 = (this.m__0005 = 1);
			this.m__0006 = 0;
			_0029 = 0;
			this.m__0020 = false;
			this.m__0003 = 2;
			for (int i = 0; i < 32768; i++)
			{
				this.m__0020[i] = 0;
			}
			for (int j = 0; j < 32768; j++)
			{
				this.m__0001[j] = 0;
			}
		}

		public new void _0001()
		{
			//Discarded unreachable code: IL_000b, IL_0018, IL_002a, IL_002f, IL_0035, IL_003a, IL_0048, IL_004e
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 1 vs 0
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Incompatible stack heights: 1 vs 0
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Incompatible stack heights: 0 vs 1
			this.m__0020._0001();
		}

		[SpecialName]
		public new int _0002()
		{
			//Discarded unreachable code: IL_0005, IL_000e, IL_0024, IL_0039, IL_003e, IL_0041, IL_0046, IL_004a, IL_0050, IL_0056
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_0027: Incompatible stack heights: 1 vs 0
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Incompatible stack heights: 1 vs 2
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Incompatible stack heights: 0 vs 1
			//IL_0051: Incompatible stack heights: 2 vs 0
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			return (int)this.m__0020._0020();
		}

		[SpecialName]
		public new int _0003()
		{
			//Discarded unreachable code: IL_0011, IL_0018, IL_0028, IL_002d, IL_0033, IL_0038, IL_003b, IL_0041, IL_0046, IL_004c
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Incompatible stack heights: 0 vs 1
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Incompatible stack heights: 0 vs 1
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Incompatible stack heights: 0 vs 1
			return _0029;
		}

		[SpecialName]
		public new _0026 _0004()
		{
			//Discarded unreachable code: IL_0005, IL_0013, IL_0028, IL_002d, IL_0033, IL_003d, IL_0043, IL_0048, IL_004a, IL_0050
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_0016: Incompatible stack heights: 1 vs 0
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Incompatible stack heights: 0 vs 2
			//IL_0043: Incompatible stack heights: 1 vs 0
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Incompatible stack heights: 0 vs 1
			//IL_004b: Incompatible stack heights: 2 vs 0
			return this.m__0020;
		}

		[SpecialName]
		public new void _0020(_0026 _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0011, IL_001c, IL_0039, IL_003e, IL_0044, IL_0051, IL_0056, IL_005c, IL_0062, IL_0068
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Incompatible stack heights: 0 vs 1
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Incompatible stack heights: 0 vs 3
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Incompatible stack heights: 0 vs 1
			//IL_005d: Incompatible stack heights: 1 vs 0
			this.m__0020 = _0020;
		}

		public new void _0020(int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_001a, IL_01a1, IL_01a6, IL_01a9, IL_01af, IL_01b4, IL_01ba
			//IL_000f: Incompatible stack heights: 2 vs 0
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Incompatible stack heights: 2 vs 0
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Incompatible stack heights: 2 vs 1
			//IL_01b5: Incompatible stack heights: 1 vs 0
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			_002E = _003F._0020[_0020];
			this.m__0008 = _003F._0001[_0020];
			this.m__0009 = _003F._0002[_0020];
			this.m__0007 = _003F._0003[_0020];
			if (_003F._0004[_0020] == _0028)
			{
				return;
			}
			switch (_0028)
			{
			case 0:
				if (this.m__0005 > this.m__0004)
				{
					this.m__0020._0020(this.m__0020, this.m__0004, this.m__0005 - this.m__0004, _0003: false);
					this.m__0004 = this.m__0005;
				}
				_0005();
				break;
			case 1:
				if (this.m__0005 > this.m__0004)
				{
					this.m__0020._0001(this.m__0020, this.m__0004, this.m__0005 - this.m__0004, _0003: false);
					this.m__0004 = this.m__0005;
				}
				break;
			case 2:
				if (this.m__0020)
				{
					this.m__0020._0004(this.m__0020[this.m__0005 - 1] & 0xFF);
				}
				if (this.m__0005 > this.m__0004)
				{
					this.m__0020._0001(this.m__0020, this.m__0004, this.m__0005 - this.m__0004, _0003: false);
					this.m__0004 = this.m__0005;
				}
				this.m__0020 = false;
				this.m__0003 = 2;
				break;
			}
			_0028 = _003F._0004[_0020];
		}

		private new void _0005()
		{
			//Discarded unreachable code: IL_0010, IL_0047, IL_004c, IL_004f, IL_0055, IL_0059, IL_005f, IL_0064
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Incompatible stack heights: 0 vs 2
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 1 vs 0
			//IL_005f: Incompatible stack heights: 0 vs 1
			this.m__0001 = (this.m__0020[this.m__0005] << 5) ^ this.m__0020[this.m__0005 + 1];
		}

		private new int _0006()
		{
			//Discarded unreachable code: IL_001c, IL_008d, IL_0092, IL_0094, IL_009a, IL_00a3, IL_00a8, IL_00ae
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002e: Incompatible stack heights: 1 vs 0
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Incompatible stack heights: 0 vs 1
			//IL_00a9: Incompatible stack heights: 1 vs 0
			int num = ((this.m__0001 << 5) ^ this.m__0020[this.m__0005 + 2]) & 0x7FFF;
			short num2 = (this.m__0001[this.m__0005 & 0x7FFF] = this.m__0020[num]);
			this.m__0020[num] = (short)this.m__0005;
			this.m__0001 = num;
			return num2 & 0xFFFF;
		}

		private new void _0007()
		{
			//Discarded unreachable code: IL_0005, IL_000e, IL_001c, IL_002c, IL_00fb, IL_0100, IL_0103, IL_0109, IL_010f, IL_0114, IL_011c, IL_0122, IL_0128
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 1 vs 0
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Incompatible stack heights: 0 vs 1
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Incompatible stack heights: 0 vs 1
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Incompatible stack heights: 0 vs 1
			Array.Copy(this.m__0020, 32768, this.m__0020, 0, 32768);
			this.m__0002 -= 32768;
			this.m__0005 -= 32768;
			this.m__0004 -= 32768;
			for (int i = 0; i < 32768; i++)
			{
				int num = this.m__0020[i] & 0xFFFF;
				this.m__0020[i] = (short)((num >= 32768) ? (num - 32768) : 0);
			}
			for (int j = 0; j < 32768; j++)
			{
				int num2 = this.m__0001[j] & 0xFFFF;
				this.m__0001[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
			}
		}

		public new void _0008()
		{
			//Discarded unreachable code: IL_0005, IL_0113, IL_0118, IL_011e, IL_0120, IL_0126, IL_0131, IL_0136, IL_013c
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 1 vs 0
			//IL_00e0: Incompatible stack heights: 1 vs 0
			//IL_00fe: Incompatible stack heights: 0 vs 1
			//IL_00fe: Incompatible stack heights: 1 vs 0
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Incompatible stack heights: 0 vs 2
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Incompatible stack heights: 0 vs 1
			//IL_0131: Incompatible stack heights: 1 vs 0
			if (this.m__0005 >= 65274)
			{
				_0007();
			}
			while (this.m__0006 < 262 && _002A < _003D)
			{
				int num = 65536 - this.m__0006 - this.m__0005;
				if (num > _003D - _002A)
				{
					num = _003D - _002A;
				}
				Array.Copy(this.m__0001, _002A, this.m__0020, this.m__0005 + this.m__0006, num);
				this.m__0020._0020(this.m__0001, _002A, num);
				_002A += num;
				_0029 += num;
				this.m__0006 += num;
			}
			if (this.m__0006 >= 3)
			{
				_0005();
			}
		}

		private new bool _0001(int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_000f, IL_001e, IL_0027, IL_0292, IL_0297, IL_029f, IL_02a5, IL_02ab, IL_02af, IL_02b4, IL_02bc, IL_02c2
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_002d: Incompatible stack heights: 0 vs 1
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Incompatible stack heights: 1 vs 0
			//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Incompatible stack heights: 0 vs 1
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			int num = this.m__0007;
			int num2 = this.m__0009;
			short[] array = this.m__0001;
			int num3 = this.m__0005;
			int num4 = this.m__0005 + this.m__0003;
			int num5 = Math.Max(this.m__0003, 2);
			int num6 = Math.Max(this.m__0005 - 32506, 0);
			int num7 = this.m__0005 + 258 - 1;
			byte b = this.m__0020[num4 - 1];
			byte b2 = this.m__0020[num4];
			if (num5 >= _002E)
			{
				num >>= 2;
			}
			if (num2 > this.m__0006)
			{
				num2 = this.m__0006;
			}
			do
			{
				if (this.m__0020[_0020 + num5] != b2 || this.m__0020[_0020 + num5 - 1] != b || this.m__0020[_0020] != this.m__0020[num3] || this.m__0020[_0020 + 1] != this.m__0020[num3 + 1])
				{
					continue;
				}
				int num8 = _0020 + 2;
				num3 += 2;
				while (this.m__0020[++num3] == this.m__0020[++num8] && this.m__0020[++num3] == this.m__0020[++num8] && this.m__0020[++num3] == this.m__0020[++num8] && this.m__0020[++num3] == this.m__0020[++num8] && this.m__0020[++num3] == this.m__0020[++num8] && this.m__0020[++num3] == this.m__0020[++num8] && this.m__0020[++num3] == this.m__0020[++num8] && this.m__0020[++num3] == this.m__0020[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					this.m__0002 = _0020;
					num4 = num3;
					num5 = num3 - this.m__0005;
					if (num5 >= num2)
					{
						break;
					}
					b = this.m__0020[num4 - 1];
					b2 = this.m__0020[num4];
				}
				num3 = this.m__0005;
			}
			while ((_0020 = array[_0020 & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
			this.m__0003 = Math.Min(num5, this.m__0006);
			return this.m__0003 >= 3;
		}

		public new void _0020(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000a, IL_001b, IL_0025, IL_00ae, IL_00b3, IL_00b7, IL_00bd, IL_00c3, IL_00ce, IL_00d3
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Incompatible stack heights: 1 vs 0
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Incompatible stack heights: 0 vs 1
			this.m__0020._0020(_0020, _0001, _0002);
			if (_0002 >= 3)
			{
				if (_0002 > 32506)
				{
					_0001 += _0002 - 32506;
					_0002 = 32506;
				}
				Array.Copy(_0020, _0001, this.m__0020, this.m__0005, _0002);
				_0005();
				_0002--;
				while (--_0002 > 0)
				{
					_0006();
					this.m__0005++;
				}
				this.m__0005 += 2;
				this.m__0004 = this.m__0005;
			}
		}

		private new bool _0020(bool _0020, bool _0001)
		{
			//Discarded unreachable code: IL_000a, IL_0017, IL_001f, IL_00bd, IL_00c2, IL_00c4, IL_00c9, IL_00cf, IL_00d2, IL_00d8
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 0 vs 2
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Incompatible stack heights: 2 vs 1
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_0023: Incompatible stack heights: 1 vs 0
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Incompatible stack heights: 0 vs 1
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Incompatible stack heights: 0 vs 1
			//IL_00d3: Incompatible stack heights: 1 vs 0
			if (!_0020 && this.m__0006 == 0)
			{
				return false;
			}
			this.m__0005 += this.m__0006;
			this.m__0006 = 0;
			int num = this.m__0005 - this.m__0004;
			if (num >= _003F._0027 || (this.m__0004 < 32768 && num >= 32506) || _0020)
			{
				bool flag = _0001;
				if (num > _003F._0027)
				{
					num = _003F._0027;
					flag = false;
				}
				this.m__0020._0020(this.m__0020, this.m__0004, num, flag);
				this.m__0004 += num;
				return !flag;
			}
			return true;
		}

		private new bool _0001(bool _0020, bool _0001)
		{
			//Discarded unreachable code: IL_0011, IL_0021, IL_0227, IL_022c, IL_0235, IL_023b, IL_0241, IL_0246, IL_024c
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Incompatible stack heights: 0 vs 2
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			if (this.m__0006 < 262 && !_0020)
			{
				return false;
			}
			while (this.m__0006 >= 262 || _0020)
			{
				if (this.m__0006 == 0)
				{
					this.m__0020._0001(this.m__0020, this.m__0004, this.m__0005 - this.m__0004, _0001);
					this.m__0004 = this.m__0005;
					return false;
				}
				if (this.m__0005 > 65274)
				{
					_0007();
				}
				int num;
				if (this.m__0006 >= 3 && (num = _0006()) != 0 && this.m__0020 != _0026._0002 && this.m__0005 - num <= 32506 && this._0001(num))
				{
					this.m__0020._0020(this.m__0005 - this.m__0002, this.m__0003);
					this.m__0006 -= this.m__0003;
					if (this.m__0003 <= this.m__0008 && this.m__0006 >= 3)
					{
						while (--this.m__0003 > 0)
						{
							this.m__0005++;
							_0006();
						}
						this.m__0005++;
					}
					else
					{
						this.m__0005 += this.m__0003;
						if (this.m__0006 >= 2)
						{
							_0005();
						}
					}
					this.m__0003 = 2;
				}
				else
				{
					this.m__0020._0004(this.m__0020[this.m__0005] & 0xFF);
					this.m__0005++;
					this.m__0006--;
					if (this.m__0020._0002())
					{
						bool flag = _0001 && this.m__0006 == 0;
						this.m__0020._0001(this.m__0020, this.m__0004, this.m__0005 - this.m__0004, flag);
						this.m__0004 = this.m__0005;
						return !flag;
					}
				}
			}
			return true;
		}

		private new bool _0002(bool _0020, bool _0001)
		{
			//Discarded unreachable code: IL_0017, IL_0023, IL_02ab, IL_02b0, IL_02b5, IL_02bb, IL_02c1, IL_02c6, IL_02cc, IL_02d2
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_003b: Incompatible stack heights: 1 vs 0
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Incompatible stack heights: 0 vs 1
			if (this.m__0006 < 262 && !_0020)
			{
				return false;
			}
			while (this.m__0006 >= 262 || _0020)
			{
				if (this.m__0006 == 0)
				{
					if (this.m__0020)
					{
						this.m__0020._0004(this.m__0020[this.m__0005 - 1] & 0xFF);
					}
					this.m__0020 = false;
					this.m__0020._0001(this.m__0020, this.m__0004, this.m__0005 - this.m__0004, _0001);
					this.m__0004 = this.m__0005;
					return false;
				}
				if (this.m__0005 >= 65274)
				{
					_0007();
				}
				int num = this.m__0002;
				int num2 = this.m__0003;
				if (this.m__0006 >= 3)
				{
					int num3 = _0006();
					if (this.m__0020 != _0026._0002 && num3 != 0 && this.m__0005 - num3 <= 32506 && this._0001(num3) && this.m__0003 <= 5 && (this.m__0020 == _0026._0001 || (this.m__0003 == 3 && this.m__0005 - this.m__0002 > _005B.m__0020)))
					{
						this.m__0003 = 2;
					}
				}
				if (num2 >= 3 && this.m__0003 <= num2)
				{
					this.m__0020._0020(this.m__0005 - 1 - num, num2);
					num2 -= 2;
					do
					{
						this.m__0005++;
						this.m__0006--;
						if (this.m__0006 >= 3)
						{
							_0006();
						}
					}
					while (--num2 > 0);
					this.m__0005++;
					this.m__0006--;
					this.m__0020 = false;
					this.m__0003 = 2;
				}
				else
				{
					if (this.m__0020)
					{
						this.m__0020._0004(this.m__0020[this.m__0005 - 1] & 0xFF);
					}
					this.m__0020 = true;
					this.m__0005++;
					this.m__0006--;
				}
				if (this.m__0020._0002())
				{
					int num4 = this.m__0005 - this.m__0004;
					if (this.m__0020)
					{
						num4--;
					}
					bool flag = _0001 && this.m__0006 == 0 && !this.m__0020;
					this.m__0020._0001(this.m__0020, this.m__0004, num4, flag);
					this.m__0004 += num4;
					return !flag;
				}
			}
			return true;
		}

		public new bool _0003(bool _0020, bool _0001)
		{
			//Discarded unreachable code: IL_000b, IL_0015, IL_0031, IL_0117, IL_011c, IL_0120, IL_0126, IL_0129, IL_012f, IL_0136, IL_013c, IL_013f, IL_0144
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 0 vs 2
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Incompatible stack heights: 0 vs 1
			//IL_0137: Incompatible stack heights: 1 vs 0
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Incompatible stack heights: 0 vs 1
			bool flag2;
			do
			{
				_0008();
				bool flag = _0020 && _002A == _003D;
				flag2 = _0028 switch
				{
					0 => this._0020(flag, _0001), 
					1 => this._0001(flag, _0001), 
					2 => _0002(flag, _0001), 
					_ => throw new InvalidOperationException(global::_0001._0020._0020(1511942956, 45778964, 1292324762)), 
				};
			}
			while (this.m__0020._0003() && flag2);
			return flag2;
		}

		public new void _0001(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_0014, IL_0023, IL_00c4, IL_00c9, IL_00cc, IL_00d2, IL_00d8, IL_00da, IL_00e0, IL_00e6, IL_00ed, IL_00f2
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 1 vs 0
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Incompatible stack heights: 1 vs 0
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			if (_002A < _003D)
			{
				throw new InvalidOperationException(global::_0001._0020._0020(990349894, 45778998, 1292324852));
			}
			int num = _0001 + _0002;
			if (0 > _0001 || _0001 > num || num > _0020.Length)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.m__0001 = _0020;
			_002A = _0001;
			_003D = num;
		}

		public new bool _0009()
		{
			//Discarded unreachable code: IL_0005, IL_0014, IL_001d, IL_003e, IL_0043, IL_0049, IL_004e, IL_0054, IL_005a, IL_0060, IL_0066
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 1 vs 0
			//IL_002a: Incompatible stack heights: 1 vs 0
			//IL_0049: Incompatible stack heights: 1 vs 0
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Incompatible stack heights: 1 vs 0
			//IL_0061: Incompatible stack heights: 0 vs 1
			return _003D == _002A;
		}
	}
	internal class _005C
	{
		private const int m__0020 = 0;

		private const int m__0001 = 1;

		private const int m__0002 = 2;

		private const int m__0003 = 3;

		private const int m__0004 = 4;

		private const int m__0005 = 5;

		private const int m__0006 = 6;

		private const int m__0007 = 7;

		private const int m__0008 = 8;

		private const int m__0009 = 9;

		private const int m__002E = 10;

		private const int m__0028 = 11;

		private const int m__0029 = 12;

		private static int[] m__0020 = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		private static int[] m__0001 = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		private static int[] m__0002 = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		private static int[] m__0003 = new int[30]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13
		};

		private int _002A;

		private int _003D;

		private int _002C;

		private int _0021;

		private int _002F;

		private int _0023;

		private bool m__0020;

		private int _0022;

		private int _0027;

		private bool m__0001;

		private _003B m__0020;

		private _003A m__0020;

		private _000A m__0020;

		private _000B m__0020;

		private _000B m__0001;

		private _0027 m__0020;

		public _005C()
			: this(_0020: false)
		{
		}//Discarded unreachable code: IL_000b, IL_001f, IL_0027, IL_0035, IL_003a, IL_0041, IL_0046, IL_004c, IL_0052, IL_0058
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Incompatible stack heights: 0 vs 1
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Incompatible stack heights: 0 vs 1
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Incompatible stack heights: 0 vs 1
		//IL_0047: Incompatible stack heights: 1 vs 0
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)


		public _005C(bool _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0010, IL_001b, IL_006b, IL_0070, IL_0076, IL_007b, IL_007f, IL_0085, IL_0088, IL_008e, IL_0094
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0025: Incompatible stack heights: 1 vs 0
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Incompatible stack heights: 0 vs 1
			//IL_0087: Incompatible stack heights: 0 vs 1
			this.m__0001 = _0020;
			this.m__0020 = new _0027();
			this.m__0020 = new _003B();
			this.m__0020 = new _003A();
			_002A = (_0020 ? 2 : 0);
		}

		public void _0020()
		{
			//Discarded unreachable code: IL_0005, IL_000e, IL_0023, IL_0086, IL_008b, IL_0090, IL_0096, IL_009c, IL_00a2, IL_00a8, IL_00ae
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 2
			//IL_0019: Incompatible stack heights: 1 vs 0
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Incompatible stack heights: 1 vs 0
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Incompatible stack heights: 0 vs 1
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			_002A = (this.m__0001 ? 2 : 0);
			_0027 = (_0022 = 0);
			this.m__0020._0004();
			this.m__0020._0002();
			this.m__0020 = null;
			this.m__0020 = null;
			this.m__0001 = null;
			this.m__0020 = false;
			this.m__0020._0001();
		}

		private bool _0001()
		{
			//Discarded unreachable code: IL_000b, IL_0013, IL_002c, IL_012c, IL_0131, IL_0136, IL_0139, IL_013f, IL_0144, IL_014a, IL_014f, IL_0155, IL_015b
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0027: Incompatible stack heights: 1 vs 0
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Incompatible stack heights: 1 vs 0
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Incompatible stack heights: 0 vs 1
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Incompatible stack heights: 1 vs 0
			int num = this.m__0020._0020(16);
			if (num < 0)
			{
				return false;
			}
			this.m__0020._0001(16);
			num = ((num << 8) | (num >> 8)) & 0xFFFF;
			if (num % 31 != 0)
			{
				throw new FormatException(global::_0001._0005._0020(899463774, 1058578224, 808739560));
			}
			if ((num & 0xF00) != _002D._0004 << 8)
			{
				throw new FormatException(global::_0001._0005._0020(1944531894, 1058578180, 808739570));
			}
			if ((num & 0x20) == 0)
			{
				_002A = 2;
			}
			else
			{
				_002A = 1;
				_002C = 32;
			}
			return true;
		}

		private bool _0002()
		{
			//Discarded unreachable code: IL_0017, IL_0024, IL_007e, IL_0083, IL_0088, IL_008e, IL_0094, IL_009c, IL_00a2
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Incompatible stack heights: 0 vs 1
			while (_002C > 0)
			{
				int num = this.m__0020._0020(8);
				if (num < 0)
				{
					return false;
				}
				this.m__0020._0001(8);
				_003D = (_003D << 8) | num;
				_002C -= 8;
			}
			return false;
		}

		private bool _0003()
		{
			//Discarded unreachable code: IL_0005, IL_0017, IL_0333, IL_0338, IL_033e, IL_0344, IL_034a, IL_0350, IL_035e, IL_0363
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 1 vs 0
			//IL_0314: Incompatible stack heights: 1 vs 0
			//IL_0328: Incompatible stack heights: 0 vs 1
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Incompatible stack heights: 0 vs 1
			//IL_035e: Incompatible stack heights: 1 vs 0
			int num = this.m__0020._0020();
			while (num >= 258)
			{
				switch (_002A)
				{
				case 7:
				{
					int num2;
					while (((num2 = this.m__0020._0020(this.m__0020)) & -256) == 0)
					{
						this.m__0020._0020(num2);
						if (--num < 258)
						{
							return true;
						}
					}
					if (num2 < 257)
					{
						if (num2 < 0)
						{
							return false;
						}
						this.m__0001 = null;
						this.m__0020 = null;
						_002A = 2;
						return true;
					}
					try
					{
						_0021 = _005C.m__0020[num2 - 257];
						_002C = _005C.m__0001[num2 - 257];
					}
					catch (Exception)
					{
						throw new FormatException(global::_0001._0005._0020(2020394227, 1058578312, 808739560));
					}
					goto case 8;
				}
				case 8:
					if (_002C > 0)
					{
						_002A = 8;
						int num3 = this.m__0020._0020(_002C);
						if (num3 < 0)
						{
							return false;
						}
						this.m__0020._0001(_002C);
						_0021 += num3;
					}
					_002A = 9;
					goto case 9;
				case 9:
				{
					int num2 = this.m__0001._0020(this.m__0020);
					if (num2 < 0)
					{
						return false;
					}
					try
					{
						_002F = _005C.m__0002[num2];
						_002C = _005C.m__0003[num2];
					}
					catch (Exception)
					{
						throw new FormatException(global::_0001._0005._0020(480944036, 1058578278, 808739564));
					}
					goto case 10;
				}
				case 10:
					if (_002C > 0)
					{
						_002A = 10;
						int num4 = this.m__0020._0020(_002C);
						if (num4 < 0)
						{
							return false;
						}
						this.m__0020._0001(_002C);
						_002F += num4;
					}
					break;
				default:
					throw new FormatException();
				}
				this.m__0020._0020(_0021, _002F);
				num -= _0021;
				_002A = 7;
			}
			return true;
		}

		private bool _0004()
		{
			//Discarded unreachable code: IL_0005, IL_0019, IL_0176, IL_017b, IL_0181, IL_0184, IL_018a, IL_0190, IL_0195
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 2 vs 0
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_009e: Incompatible stack heights: 2 vs 0
			//IL_00b1: Incompatible stack heights: 0 vs 2
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Incompatible stack heights: 0 vs 1
			//IL_0190: Incompatible stack heights: 2 vs 0
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Expected I4, but got Unknown
			while (_002C > 0)
			{
				int num = this.m__0020._0020(8);
				if (num < 0)
				{
					return false;
				}
				this.m__0020._0001(8);
				_003D = (_003D << 8) | num;
				_002C -= 8;
			}
			if ((int)this.m__0020._0020() != _003D)
			{
				throw new FormatException(global::_0001._0005._0020(802480660, 1058578368, 808739582) + (int)this.m__0020._0020() + global::_0001._0005._0020(15075507, 1058578366, 808739532) + _003D);
			}
			_002A = 12;
			return false;
		}

		private bool _0005()
		{
			//Discarded unreachable code: IL_000b, IL_0018, IL_03c6, IL_03cb, IL_03d1, IL_03d6, IL_03dc, IL_03e2, IL_03eb, IL_03f1
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e6: Incompatible stack heights: 0 vs 2
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Expected I4, but got I8
			switch (_002A)
			{
			case 0:
				return _0001();
			case 1:
				return _0002();
			case 11:
				return _0004();
			case 2:
			{
				if (this.m__0020)
				{
					if (this.m__0001)
					{
						_002A = 12;
						return false;
					}
					this.m__0020._0002();
					_002C = 32;
					_002A = 11;
					return true;
				}
				int num = this.m__0020._0020(3);
				if (num < 0)
				{
					return false;
				}
				this.m__0020._0001(3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					this.m__0020 = true;
				}
				switch (num >> 1)
				{
				case 0:
					this.m__0020._0002();
					_002A = 3;
					break;
				case 1:
					this.m__0020 = _000B._0020;
					this.m__0001 = _000B._0001;
					_002A = 7;
					break;
				case 2:
					this.m__0020 = new _000A();
					_002A = 6;
					break;
				default:
					throw new FormatException(global::_0001._0005._0020(1284292109, 1058577962, 808739552) + num);
				}
				return true;
			}
			case 3:
				if ((_0023 = this.m__0020._0020(16)) < 0)
				{
					return false;
				}
				this.m__0020._0001(16);
				_002A = 4;
				goto case 4;
			case 4:
			{
				int num3 = this.m__0020._0020(16);
				if (num3 < 0)
				{
					return false;
				}
				this.m__0020._0001(16);
				if (num3 != (_0023 ^ 0xFFFF))
				{
					throw new FormatException(global::_0001._0005._0020(1825088843, 1058578424, 808739572));
				}
				_002A = 5;
				goto case 5;
			}
			case 5:
			{
				int num2 = this.m__0020._0020(this.m__0020, _0023);
				_0023 -= num2;
				if (_0023 == 0)
				{
					_002A = 2;
					return true;
				}
				return !this.m__0020._0003();
			}
			case 6:
				if (!this.m__0020._0020(this.m__0020))
				{
					return false;
				}
				this.m__0020 = this.m__0020._0020();
				this.m__0001 = this.m__0020._0001();
				_002A = 7;
				goto case 7;
			case 7:
			case 8:
			case 9:
			case 10:
				return _0003();
			case 12:
				return false;
			default:
				throw new FormatException();
			}
		}

		public void _0020(byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0018, IL_0024, IL_0034, IL_0039, IL_003c, IL_0042, IL_0047, IL_004d
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_001f: Incompatible stack heights: 1 vs 0
			//IL_0027: Incompatible stack heights: 0 vs 2
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 1 vs 0
			this._0020(_0020, 0, _0020.Length);
		}

		public void _0020(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0010, IL_001c, IL_00c6, IL_00cb, IL_00d1, IL_00d6, IL_00d9, IL_00df
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 2
			//IL_0025: Incompatible stack heights: 1 vs 0
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Incompatible stack heights: 0 vs 1
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			if (!_0007())
			{
				throw new InvalidOperationException();
			}
			this.m__0020._0020(_0020, _0001, _0002);
			if ((int)this.m__0020._0020() != _003D)
			{
				throw new ArgumentException(global::_0001._0005._0020(2013253791, 1058578000, 808739566));
			}
			this.m__0020._0001();
			this.m__0020._0020(_0020, _0001, _0002);
			_002A = 2;
		}

		public void _0001(byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0013, IL_001c, IL_0025, IL_0034, IL_0039, IL_003f, IL_0045, IL_004a, IL_0050, IL_0056
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 0 vs 3
			//IL_0020: Incompatible stack heights: 2 vs 0
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Incompatible stack heights: 2 vs 0
			_0001(_0020, 0, _0020.Length);
		}

		public void _0001(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_0041, IL_0046, IL_0049, IL_004f, IL_0054, IL_0057, IL_005d, IL_0063, IL_0069
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Incompatible stack heights: 1 vs 0
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_004f: Incompatible stack heights: 1 vs 0
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Incompatible stack heights: 0 vs 1
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			this.m__0020._0001(_0020, _0001, _0002);
			_0027 += _0002;
		}

		public int _0002(byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0012, IL_0022, IL_0042, IL_0047, IL_004d, IL_0053, IL_0059, IL_005e, IL_0063, IL_0069
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Incompatible stack heights: 0 vs 2
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Incompatible stack heights: 0 vs 1
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected I4, but got Unknown
			return _0002(_0020, 0, _0020.Length);
		}

		public int _0002(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_001a, IL_0139, IL_013e, IL_0144, IL_014a, IL_014f, IL_0155, IL_015b
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Incompatible stack heights: 1 vs 0
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Incompatible stack heights: 1 vs 0
			if (_0002 < 0)
			{
				throw new ArgumentOutOfRangeException(global::_0001._0005._0020(1239905822, 1058578040, 808739528));
			}
			if (_0002 == 0)
			{
				return 0;
			}
			int num = 0;
			do
			{
				if (_002A != 11)
				{
					int num2 = this.m__0020._0001(_0020, _0001, _0002);
					this.m__0020._0020(_0020, _0001, num2);
					_0001 += num2;
					num += num2;
					_0022 += num2;
					_0002 -= num2;
					if (_0002 == 0)
					{
						return num;
					}
				}
			}
			while (_0005() || (this.m__0020._0001() > 0 && _002A != 11));
			return num;
		}

		[SpecialName]
		public bool _0006()
		{
			//Discarded unreachable code: IL_0005, IL_0014, IL_001e, IL_002d, IL_0032, IL_0038, IL_0040, IL_0046, IL_0050, IL_0055
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_0019: Incompatible stack heights: 1 vs 0
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Incompatible stack heights: 0 vs 1
			//IL_0050: Incompatible stack heights: 1 vs 0
			return this.m__0020._0003();
		}

		[SpecialName]
		public bool _0007()
		{
			//Discarded unreachable code: IL_000a, IL_0026, IL_0045, IL_004a, IL_0050, IL_0052, IL_0058, IL_005e, IL_0063, IL_0069
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Incompatible stack heights: 0 vs 1
			//IL_0021: Incompatible stack heights: 1 vs 0
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Incompatible stack heights: 1 vs 0
			//IL_0064: Incompatible stack heights: 0 vs 1
			if (_002A == 1)
			{
				return _002C == 0;
			}
			return false;
		}

		[SpecialName]
		public bool _0008()
		{
			//Discarded unreachable code: IL_000a, IL_0018, IL_0041, IL_0046, IL_004c, IL_004e, IL_0053, IL_0059, IL_005e, IL_0064, IL_0070, IL_0076
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0021: Incompatible stack heights: 1 vs 0
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Incompatible stack heights: 0 vs 1
			//IL_0054: Incompatible stack heights: 1 vs 0
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Incompatible stack heights: 0 vs 1
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Incompatible stack heights: 0 vs 3
			//IL_0071: Incompatible stack heights: 1 vs 0
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected I4, but got Unknown
			if (_002A == 12)
			{
				return this.m__0020._0001() == 0;
			}
			return false;
		}

		[SpecialName]
		public int _0009()
		{
			//Discarded unreachable code: IL_0016, IL_0047, IL_004c, IL_0051, IL_0057, IL_005e, IL_0064
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Incompatible stack heights: 0 vs 2
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			if (!_0007())
			{
				return (int)this.m__0020._0020();
			}
			return _003D;
		}

		[SpecialName]
		public int _002E()
		{
			//Discarded unreachable code: IL_0005, IL_002c, IL_0031, IL_0039, IL_003f, IL_0043, IL_0049, IL_004e, IL_0054
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 2
			//IL_0038: Incompatible stack heights: 0 vs 2
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Incompatible stack heights: 0 vs 1
			return _0022;
		}

		[SpecialName]
		public int _0028()
		{
			//Discarded unreachable code: IL_0010, IL_002b, IL_003d, IL_0042, IL_0045, IL_004b, IL_0051, IL_0058, IL_005e, IL_0062, IL_0067, IL_006d
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Incompatible stack heights: 0 vs 1
			//IL_0068: Incompatible stack heights: 1 vs 0
			return _0027 - _0029();
		}

		[SpecialName]
		public int _0029()
		{
			//Discarded unreachable code: IL_0005, IL_0012, IL_0023, IL_002c, IL_003d, IL_0042, IL_0046, IL_004c, IL_0052, IL_0057, IL_005d, IL_0063, IL_0068, IL_006e
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 3 vs 1
			//IL_001e: Incompatible stack heights: 3 vs 0
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Incompatible stack heights: 3 vs 1
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Incompatible stack heights: 3 vs 1
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Incompatible stack heights: 1 vs 0
			//IL_0052: Incompatible stack heights: 3 vs 0
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Incompatible stack heights: 0 vs 1
			return this.m__0020._0001();
		}
	}
	internal class _005D
	{
		internal class _007B
		{
			public short[] _0020;

			public short[] _0001;

			public byte[] _0020;

			public int[] _0020;

			public int _0020;

			public int _0001;

			public int _0002;

			private _005D m__0020;

			public _007B(_005D _0020, int _0001, int _0002, int _0003)
			{
				//Discarded unreachable code: IL_000b, IL_0017, IL_005b, IL_0060, IL_0063, IL_0069, IL_006d, IL_0073, IL_0079, IL_007b, IL_0080
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Incompatible stack heights: 0 vs 1
				//IL_0020: Incompatible stack heights: 1 vs 0
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Incompatible stack heights: 0 vs 1
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Incompatible stack heights: 1 vs 0
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				this.m__0020 = _0020;
				this._0020 = _0002;
				this._0002 = _0003;
				this._0020 = new short[_0001];
				this._0020 = new int[_0003];
			}

			public void _0020()
			{
				//Discarded unreachable code: IL_0022, IL_0061, IL_0066, IL_0068, IL_006d, IL_0073, IL_0076, IL_007c, IL_0082, IL_0085, IL_008b
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_0029: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Incompatible stack heights: 0 vs 2
				//IL_0068: Incompatible stack heights: 0 vs 1
				//IL_006e: Incompatible stack heights: 1 vs 0
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Incompatible stack heights: 0 vs 1
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Incompatible stack heights: 0 vs 1
				for (int i = 0; i < this._0020.Length; i++)
				{
					this._0020[i] = 0;
				}
				this._0001 = null;
				this._0020 = null;
			}

			public void _0020(int _0020)
			{
				//Discarded unreachable code: IL_0005, IL_0014, IL_004d, IL_0052, IL_0059, IL_005f, IL_0064, IL_006a, IL_006c, IL_0072, IL_0078
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_001f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0020: Incompatible stack heights: 0 vs 1
				//IL_0058: Incompatible stack heights: 0 vs 2
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Incompatible stack heights: 0 vs 1
				this.m__0020._0020._0020(this._0001[_0020] & 0xFFFF, this._0020[_0020]);
			}

			public void _0001()
			{
				//Discarded unreachable code: IL_0005, IL_0015, IL_0022, IL_0060, IL_0065, IL_006a, IL_0070, IL_007f, IL_0085, IL_0088, IL_008e
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Unknown result type (might be due to invalid IL or missing references)
				//IL_0017: Unknown result type (might be due to invalid IL or missing references)
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001b: Incompatible stack heights: 0 vs 1
				//IL_001d: Incompatible stack heights: 1 vs 0
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				//IL_0030: Incompatible stack heights: 0 vs 1
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Incompatible stack heights: 0 vs 3
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Incompatible stack heights: 0 vs 1
				//IL_0089: Incompatible stack heights: 3 vs 0
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				bool flag = true;
				for (int i = 0; i < this._0020.Length; i++)
				{
					if (this._0020[i] != 0)
					{
						flag = false;
					}
				}
				if (!flag)
				{
					throw new Exception();
				}
			}

			public void _0020(short[] _0020, byte[] _0001)
			{
				//Discarded unreachable code: IL_0005, IL_0021, IL_0032, IL_0037, IL_003f, IL_0044, IL_004a, IL_0050, IL_0056, IL_005c
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Incompatible stack heights: 0 vs 1
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				//IL_0022: Incompatible stack heights: 0 vs 1
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003b: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Incompatible stack heights: 0 vs 1
				//IL_0051: Incompatible stack heights: 1 vs 0
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				this._0001 = _0020;
				this._0020 = _0001;
			}

			public void _0002()
			{
				//Discarded unreachable code: IL_0010, IL_0022, IL_00d3, IL_00d8, IL_00de, IL_00e4, IL_00ea, IL_00f6, IL_00fb
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Incompatible stack heights: 0 vs 1
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Unknown result type (might be due to invalid IL or missing references)
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Incompatible stack heights: 0 vs 2
				//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f5: Incompatible stack heights: 0 vs 1
				_ = this._0020.Length;
				int[] array = new int[this._0002];
				int num = 0;
				this._0001 = new short[this._0020.Length];
				for (int i = 0; i < this._0002; i++)
				{
					array[i] = num;
					num += this._0020[i] << 15 - i;
				}
				for (int j = 0; j < this._0001; j++)
				{
					int num2 = this._0020[j];
					if (num2 > 0)
					{
						this._0001[j] = _005D._0020(array[num2 - 1]);
						array[num2 - 1] += 1 << 16 - num2;
					}
				}
			}

			private void _0020(int[] _0020)
			{
				//Discarded unreachable code: IL_0005, IL_0012, IL_001a, IL_0028, IL_021f, IL_0224, IL_022a, IL_0230, IL_0235, IL_023b
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Incompatible stack heights: 0 vs 1
				//IL_0012: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_001b: Incompatible stack heights: 0 vs 1
				//IL_0023: Incompatible stack heights: 1 vs 0
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				//IL_0029: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Incompatible stack heights: 1 vs 0
				//IL_0063: Incompatible stack heights: 0 vs 1
				//IL_0224: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Incompatible stack heights: 1 vs 2
				//IL_0236: Incompatible stack heights: 2 vs 0
				//IL_023b: Unknown result type (might be due to invalid IL or missing references)
				//IL_023c: Unknown result type (might be due to invalid IL or missing references)
				//IL_023e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0240: Unknown result type (might be due to invalid IL or missing references)
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0242: Unknown result type (might be due to invalid IL or missing references)
				//IL_0244: Unknown result type (might be due to invalid IL or missing references)
				this._0020 = new byte[this._0020.Length];
				int num = _0020.Length / 2;
				int num2 = (num + 1) / 2;
				int num3 = 0;
				for (int i = 0; i < this._0002; i++)
				{
					this._0020[i] = 0;
				}
				int[] array = new int[num];
				array[num - 1] = 0;
				for (int num4 = num - 1; num4 >= 0; num4--)
				{
					if (_0020[2 * num4 + 1] != -1)
					{
						int num5 = array[num4] + 1;
						if (num5 > this._0002)
						{
							num5 = this._0002;
							num3++;
						}
						array[_0020[2 * num4]] = (array[_0020[2 * num4 + 1]] = num5);
					}
					else
					{
						int num6 = array[num4];
						this._0020[num6 - 1]++;
						this._0020[_0020[2 * num4]] = (byte)array[num4];
					}
				}
				if (num3 == 0)
				{
					return;
				}
				int num7 = this._0002 - 1;
				while (true)
				{
					if (this._0020[--num7] != 0)
					{
						do
						{
							this._0020[num7]--;
							this._0020[++num7]++;
							num3 -= 1 << this._0002 - 1 - num7;
						}
						while (num3 > 0 && num7 < this._0002 - 1);
						if (num3 <= 0)
						{
							break;
						}
					}
				}
				this._0020[this._0002 - 1] += num3;
				this._0020[this._0002 - 2] -= num3;
				int num8 = 2 * num2;
				for (int num9 = this._0002; num9 != 0; num9--)
				{
					int num10 = this._0020[num9 - 1];
					while (num10 > 0)
					{
						int num11 = 2 * _0020[num8++];
						if (_0020[num11 + 1] == -1)
						{
							this._0020[_0020[num11]] = (byte)num9;
							num10--;
						}
					}
				}
			}

			public void _0003()
			{
				//Discarded unreachable code: IL_0005, IL_0575, IL_057a, IL_0581, IL_0587, IL_058a, IL_0590, IL_0593, IL_0599, IL_059f, IL_05a4, IL_05aa, IL_05b0
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Incompatible stack heights: 1 vs 0
				//IL_0102: Incompatible stack heights: 1 vs 0
				//IL_010e: Incompatible stack heights: 0 vs 1
				//IL_0591: Unknown result type (might be due to invalid IL or missing references)
				//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05a9: Incompatible stack heights: 0 vs 1
				//IL_05ab: Incompatible stack heights: 1 vs 0
				int num = this._0020.Length;
				int[] array = new int[num];
				int num2 = 0;
				int num3 = 0;
				for (int i = 0; i < num; i++)
				{
					int num4 = this._0020[i];
					if (num4 != 0)
					{
						int num5 = num2++;
						int num6;
						while (num5 > 0 && this._0020[array[num6 = (num5 - 1) / 2]] > num4)
						{
							array[num5] = array[num6];
							num5 = num6;
						}
						array[num5] = i;
						num3 = i;
					}
				}
				while (num2 < 2)
				{
					int num7 = ((num3 < 2) ? (++num3) : 0);
					array[num2++] = num7;
				}
				this._0001 = Math.Max(num3 + 1, this._0020);
				int num8 = num2;
				int[] array2 = new int[4 * num2 - 2];
				int[] array3 = new int[2 * num2 - 1];
				int num9 = num8;
				for (int j = 0; j < num2; j++)
				{
					int num10 = (array2[2 * j] = array[j]);
					array2[2 * j + 1] = -1;
					array3[j] = this._0020[num10] << 8;
					array[j] = j;
				}
				do
				{
					int num11 = array[0];
					int num12 = array[--num2];
					int num13 = 0;
					int num14;
					for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
					{
						if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
						{
							num14++;
						}
						array[num13] = array[num14];
						num13 = num14;
					}
					int num15 = array3[num12];
					while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
					{
						array[num14] = array[num13];
					}
					array[num14] = num12;
					int num16 = array[0];
					num12 = num9++;
					array2[2 * num12] = num11;
					array2[2 * num12 + 1] = num16;
					int num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
					num15 = (array3[num12] = array3[num11] + array3[num16] - num17 + 1);
					num13 = 0;
					for (num14 = 1; num14 < num2; num14 = num13 * 2 + 1)
					{
						if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
						{
							num14++;
						}
						array[num13] = array[num14];
						num13 = num14;
					}
					while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
					{
						array[num14] = array[num13];
					}
					array[num14] = num12;
				}
				while (num2 > 1);
				if (array[0] != array2.Length / 2 - 1)
				{
					throw new Exception(global::_0001._0002._0020(615586022, 1391113536, 71029));
				}
				_0020(array2);
			}

			public int _0004()
			{
				//Discarded unreachable code: IL_0011, IL_0019, IL_005a, IL_005f, IL_0062, IL_0068, IL_006d, IL_0073
				//IL_0012: Unknown result type (might be due to invalid IL or missing references)
				//IL_0012: Incompatible stack heights: 0 vs 1
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Incompatible stack heights: 0 vs 1
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Incompatible stack heights: 0 vs 1
				//IL_006e: Incompatible stack heights: 1 vs 0
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				int num = 0;
				for (int i = 0; i < this._0020.Length; i++)
				{
					num += this._0020[i] * this._0020[i];
				}
				return num;
			}

			public void _0020(_007B _0020)
			{
				//Discarded unreachable code: IL_000b, IL_001a, IL_013f, IL_0144, IL_014a, IL_014f, IL_0153, IL_0159
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Incompatible stack heights: 0 vs 1
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Unknown result type (might be due to invalid IL or missing references)
				//IL_0024: Incompatible stack heights: 0 vs 1
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Incompatible stack heights: 0 vs 1
				//IL_015b: Unknown result type (might be due to invalid IL or missing references)
				int num = -1;
				int num2 = 0;
				while (num2 < this._0001)
				{
					int num3 = 1;
					int num4 = this._0020[num2];
					int num5;
					int num6;
					if (num4 == 0)
					{
						num5 = 138;
						num6 = 3;
					}
					else
					{
						num5 = 6;
						num6 = 3;
						if (num != num4)
						{
							_0020._0020[num4]++;
							num3 = 0;
						}
					}
					num = num4;
					num2++;
					while (num2 < this._0001 && num == this._0020[num2])
					{
						num2++;
						if (++num3 >= num5)
						{
							break;
						}
					}
					if (num3 < num6)
					{
						_0020._0020[num] += (short)num3;
					}
					else if (num != 0)
					{
						_0020._0020[_005D.m__0004]++;
					}
					else if (num3 <= 10)
					{
						_0020._0020[_0005]++;
					}
					else
					{
						_0020._0020[_0006]++;
					}
				}
			}

			public void _0001(_007B _0020)
			{
				//Discarded unreachable code: IL_0005, IL_000d, IL_0019, IL_011c, IL_0121, IL_0123, IL_0128, IL_012b, IL_0131, IL_0137
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0011: Unknown result type (might be due to invalid IL or missing references)
				//IL_0012: Unknown result type (might be due to invalid IL or missing references)
				//IL_0021: Incompatible stack heights: 1 vs 0
				//IL_00a2: Incompatible stack heights: 1 vs 0
				//IL_00c6: Incompatible stack heights: 1 vs 0
				//IL_00ec: Incompatible stack heights: 1 vs 0
				//IL_0109: Incompatible stack heights: 1 vs 0
				//IL_0116: Incompatible stack heights: 0 vs 1
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_012c: Incompatible stack heights: 1 vs 0
				int num = -1;
				int num2 = 0;
				while (num2 < this._0001)
				{
					int num3 = 1;
					int num4 = this._0020[num2];
					int num5;
					int num6;
					if (num4 == 0)
					{
						num5 = 138;
						num6 = 3;
					}
					else
					{
						num5 = 6;
						num6 = 3;
						if (num != num4)
						{
							_0020._0020(num4);
							num3 = 0;
						}
					}
					num = num4;
					num2++;
					while (num2 < this._0001 && num == this._0020[num2])
					{
						num2++;
						if (++num3 >= num5)
						{
							break;
						}
					}
					if (num3 < num6)
					{
						while (num3-- > 0)
						{
							_0020._0020(num);
						}
					}
					else if (num != 0)
					{
						_0020._0020(_005D.m__0004);
						this.m__0020._0020._0020(num3 - 3, 2);
					}
					else if (num3 <= 10)
					{
						_0020._0020(_0005);
						this.m__0020._0020._0020(num3 - 3, 3);
					}
					else
					{
						_0020._0020(_0006);
						this.m__0020._0020._0020(num3 - 11, 7);
					}
				}
			}
		}

		private static int m__0020;

		private static int m__0001;

		private static int m__0002;

		private static int m__0003;

		private static int m__0004;

		private static int _0005;

		private static int _0006;

		private static int _0007;

		private static int[] m__0020;

		private static byte[] m__0020;

		public @_ _0020;

		private _007B m__0020;

		private _007B m__0001;

		private _007B m__0002;

		private short[] m__0020;

		private byte[] m__0001;

		private int _0008;

		private int _0009;

		private static short[] m__0001;

		private static byte[] m__0002;

		private static short[] m__0002;

		private static byte[] m__0003;

		static _005D()
		{
			//Discarded unreachable code: IL_0022, IL_01ad, IL_01b2, IL_01b5, IL_01ba, IL_01c0, IL_01c6, IL_01cd, IL_01d3, IL_01d9
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Incompatible stack heights: 0 vs 1
			//IL_01bb: Incompatible stack heights: 1 vs 0
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Incompatible stack heights: 0 vs 1
			//IL_01d4: Incompatible stack heights: 1 vs 0
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			_005D.m__0020 = 16384;
			_005D.m__0001 = 286;
			_005D.m__0002 = 30;
			_005D.m__0003 = 19;
			_005D.m__0004 = 16;
			_0005 = 17;
			_0006 = 18;
			_0007 = 256;
			_005D.m__0020 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			_005D.m__0020 = new byte[16]
			{
				0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
				5, 13, 3, 11, 7, 15
			};
			_005D.m__0001 = new short[_005D.m__0001];
			_005D.m__0002 = new byte[_005D.m__0001];
			int num = 0;
			while (num < 144)
			{
				_005D.m__0001[num] = _0020(48 + num << 8);
				_005D.m__0002[num++] = 8;
			}
			while (num < 256)
			{
				_005D.m__0001[num] = _0020(256 + num << 7);
				_005D.m__0002[num++] = 9;
			}
			while (num < 280)
			{
				_005D.m__0001[num] = _0020(-256 + num << 9);
				_005D.m__0002[num++] = 7;
			}
			while (num < _005D.m__0001)
			{
				_005D.m__0001[num] = _0020(-88 + num << 8);
				_005D.m__0002[num++] = 8;
			}
			_005D.m__0002 = new short[_005D.m__0002];
			_005D.m__0003 = new byte[_005D.m__0002];
			for (num = 0; num < _005D.m__0002; num++)
			{
				_005D.m__0002[num] = _0020(num << 11);
				_005D.m__0003[num] = 5;
			}
		}

		public _005D(@_ _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0011, IL_001e, IL_0099, IL_009e, IL_00a3, IL_00aa, IL_00b0, IL_00b6, IL_00bc, IL_00c2
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_0027: Incompatible stack heights: 1 vs 0
			//IL_009e: Incompatible stack heights: 1 vs 0
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Incompatible stack heights: 0 vs 1
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Incompatible stack heights: 0 vs 1
			//IL_00bd: Incompatible stack heights: 1 vs 0
			this._0020 = _0020;
			this.m__0020 = new _007B(this, _005D.m__0001, 257, 15);
			this.m__0001 = new _007B(this, _005D.m__0002, 1, 15);
			this.m__0002 = new _007B(this, _005D.m__0003, 4, 7);
			this.m__0020 = new short[_005D.m__0020];
			this.m__0001 = new byte[_005D.m__0020];
		}

		public static short _0020(int _0020)
		{
			//Discarded unreachable code: IL_000b, IL_0019, IL_0027, IL_0062, IL_0067, IL_0069, IL_006e, IL_0073, IL_0079, IL_007f
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Incompatible stack heights: 0 vs 1
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 2
			//IL_0022: Incompatible stack heights: 1 vs 0
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Incompatible stack heights: 0 vs 1
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Incompatible stack heights: 0 vs 2
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Incompatible stack heights: 2 vs 0
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected I4, but got Unknown
			return (short)((_005D.m__0020[_0020 & 0xF] << 12) | (_005D.m__0020[(_0020 >> 4) & 0xF] << 8) | (_005D.m__0020[(_0020 >> 8) & 0xF] << 4) | _005D.m__0020[_0020 >> 12]);
		}

		public void _0020()
		{
			//Discarded unreachable code: IL_0005, IL_005a, IL_005f, IL_0065, IL_0069, IL_006f, IL_0074, IL_007c, IL_0082, IL_0088
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 1 vs 0
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Incompatible stack heights: 0 vs 2
			//IL_006f: Incompatible stack heights: 1 vs 0
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Incompatible stack heights: 0 vs 2
			//IL_0083: Incompatible stack heights: 2 vs 0
			_0008 = 0;
			_0009 = 0;
			this.m__0020._0020();
			this.m__0001._0020();
			this.m__0002._0020();
		}

		private int _0001(int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0021, IL_004c, IL_0051, IL_0057, IL_005d, IL_0060, IL_0066, IL_006b
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Incompatible stack heights: 0 vs 1
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Incompatible stack heights: 0 vs 1
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			if (_0020 == 255)
			{
				return 285;
			}
			int num = 257;
			while (_0020 >= 8)
			{
				num += 4;
				_0020 >>= 1;
			}
			return num + _0020;
		}

		private int _0002(int _0020)
		{
			//Discarded unreachable code: IL_000b, IL_0014, IL_0046, IL_004b, IL_0051, IL_0057, IL_005f, IL_0065, IL_0067, IL_006c, IL_0072
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0027: Incompatible stack heights: 1 vs 0
			//IL_003c: Incompatible stack heights: 1 vs 0
			//IL_0040: Incompatible stack heights: 0 vs 1
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Incompatible stack heights: 0 vs 1
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Incompatible stack heights: 0 vs 1
			//IL_0067: Incompatible stack heights: 1 vs 0
			int num = 0;
			while (_0020 >= 4)
			{
				num += 2;
				_0020 >>= 1;
			}
			return num + _0020;
		}

		public void _0003(int _0020)
		{
			//Discarded unreachable code: IL_000b, IL_0014, IL_001c, IL_0023, IL_00e0, IL_00e5, IL_00e9, IL_00ef, IL_00f6, IL_00fc, IL_0101, IL_0107, IL_010d
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Incompatible stack heights: 0 vs 1
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 0 vs 2
			//IL_0027: Incompatible stack heights: 1 vs 0
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Incompatible stack heights: 0 vs 1
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Incompatible stack heights: 1 vs 0
			//IL_0108: Incompatible stack heights: 0 vs 1
			this.m__0002._0002();
			this.m__0020._0002();
			this.m__0001._0002();
			this._0020._0020(this.m__0020._0001 - 257, 5);
			this._0020._0020(this.m__0001._0001 - 1, 5);
			this._0020._0020(_0020 - 4, 4);
			for (int i = 0; i < _0020; i++)
			{
				this._0020._0020(this.m__0002._0020[_005D.m__0020[i]], 3);
			}
			this.m__0020._0001(this.m__0002);
			this.m__0001._0001(this.m__0002);
		}

		public void _0001()
		{
			//Discarded unreachable code: IL_000b, IL_0027, IL_00fb, IL_0100, IL_0106, IL_010e, IL_0114, IL_0119
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Incompatible stack heights: 0 vs 1
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Incompatible stack heights: 0 vs 1
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < _0008; i++)
			{
				int num = this.m__0001[i] & 0xFF;
				int num2 = this.m__0020[i];
				if (num2-- != 0)
				{
					int num3 = _0001(num);
					this.m__0020._0020(num3);
					int num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						this._0020._0020(num & ((1 << num4) - 1), num4);
					}
					int num5 = _0002(num2);
					this.m__0001._0020(num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						this._0020._0020(num2 & ((1 << num4) - 1), num4);
					}
				}
				else
				{
					this.m__0020._0020(num);
				}
			}
			this.m__0020._0020(_0007);
		}

		public void _0020(byte[] _0020, int _0001, int _0002, bool _0003)
		{
			//Discarded unreachable code: IL_001c, IL_0071, IL_0076, IL_007c, IL_0082, IL_0085, IL_008b, IL_0091, IL_0097, IL_009a, IL_009f
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_0084: Incompatible stack heights: 0 vs 2
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Incompatible stack heights: 0 vs 1
			this._0020._0020(_0003 ? 1 : 0, 3);
			this._0020._0002();
			this._0020._0001(_0002);
			this._0020._0001(~_0002);
			this._0020._0020(_0020, _0001, _0002);
			this._0020();
		}

		public void _0001(byte[] _0020, int _0001, int _0002, bool _0003)
		{
			//Discarded unreachable code: IL_000b, IL_0013, IL_001d, IL_01e3, IL_01e8, IL_01ee, IL_01f1, IL_01f6, IL_01fd, IL_0203, IL_0209
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0021: Incompatible stack heights: 1 vs 0
			//IL_00b0: Incompatible stack heights: 1 vs 0
			//IL_00b3: Incompatible stack heights: 0 vs 1
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Incompatible stack heights: 0 vs 1
			//IL_01f1: Incompatible stack heights: 1 vs 0
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Incompatible stack heights: 0 vs 1
			this.m__0020._0020[_0007]++;
			this.m__0020._0003();
			this.m__0001._0003();
			this.m__0020._0020(this.m__0002);
			this.m__0001._0020(this.m__0002);
			this.m__0002._0003();
			int num = 4;
			for (int num2 = 18; num2 > num; num2--)
			{
				if (this.m__0002._0020[_005D.m__0020[num2]] > 0)
				{
					num = num2 + 1;
				}
			}
			int num3 = 14 + num * 3 + this.m__0002._0004() + this.m__0020._0004() + this.m__0001._0004() + _0009;
			int num4 = _0009;
			for (int i = 0; i < _005D.m__0001; i++)
			{
				num4 += this.m__0020._0020[i] * _005D.m__0002[i];
			}
			for (int j = 0; j < _005D.m__0002; j++)
			{
				num4 += this.m__0001._0020[j] * _005D.m__0003[j];
			}
			if (num3 >= num4)
			{
				num3 = num4;
			}
			if (_0001 >= 0 && _0002 + 4 < num3 >> 3)
			{
				this._0020(_0020, _0001, _0002, _0003);
			}
			else if (num3 == num4)
			{
				this._0020._0020(2 + (_0003 ? 1 : 0), 3);
				this.m__0020._0020(_005D.m__0001, _005D.m__0002);
				this.m__0001._0020(_005D.m__0002, _005D.m__0003);
				this._0001();
				this._0020();
			}
			else
			{
				this._0020._0020(4 + (_0003 ? 1 : 0), 3);
				this._0003(num);
				this._0001();
				this._0020();
			}
		}

		public bool _0002()
		{
			//Discarded unreachable code: IL_001c, IL_0035, IL_003a, IL_003d, IL_0043, IL_0049, IL_004f, IL_0055, IL_005a, IL_0060
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Incompatible stack heights: 0 vs 2
			//IL_005b: Incompatible stack heights: 2 vs 0
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected I4, but got Unknown
			return _0008 + 16 >= _005D.m__0020;
		}

		public bool _0004(int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_000d, IL_006f, IL_0074, IL_0079, IL_007f, IL_0085, IL_008b, IL_0090, IL_0096
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Incompatible stack heights: 1 vs 0
			//IL_001c: Incompatible stack heights: 0 vs 1
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Incompatible stack heights: 2 vs 1
			//IL_008b: Incompatible stack heights: 0 vs 2
			//IL_0091: Incompatible stack heights: 2 vs 0
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			this.m__0020[_0008] = 0;
			this.m__0001[_0008++] = (byte)_0020;
			this.m__0020._0020[_0020]++;
			return _0002();
		}

		public bool _0020(int _0020, int _0001)
		{
			//Discarded unreachable code: IL_000b, IL_0019, IL_0026, IL_00ea, IL_00ef, IL_00f5, IL_0101, IL_0106, IL_010c
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0029: Incompatible stack heights: 0 vs 1
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Incompatible stack heights: 0 vs 1
			//IL_0107: Incompatible stack heights: 1 vs 0
			this.m__0020[_0008] = (short)_0020;
			this.m__0001[_0008++] = (byte)(_0001 - 3);
			int num = this._0001(_0001 - 3);
			this.m__0020._0020[num]++;
			if (num >= 265 && num < 285)
			{
				_0009 += (num - 261) / 4;
			}
			int num2 = _0002(_0020 - 1);
			this.m__0001._0020[num2]++;
			if (num2 >= 4)
			{
				_0009 += num2 / 2 - 1;
			}
			return _0002();
		}
	}
	internal class _007D
	{
		protected byte[] _0020;

		private int m__0020;

		private int m__0001;

		private uint m__0020;

		private int m__0002;

		public _007D()
			: this(4096)
		{
		}//Discarded unreachable code: IL_0005, IL_0010, IL_001f, IL_002d, IL_0032, IL_0038, IL_003e, IL_0044, IL_004a, IL_004d, IL_0052
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Incompatible stack heights: 0 vs 1
		//IL_0015: Incompatible stack heights: 1 vs 0
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Incompatible stack heights: 0 vs 2
		//IL_004c: Incompatible stack heights: 0 vs 1
		//IL_004d: Incompatible stack heights: 1 vs 0
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)


		public _007D(int _0020)
		{
			//Discarded unreachable code: IL_000a, IL_0023, IL_0047, IL_004c, IL_0052, IL_0058, IL_005e, IL_0064, IL_0068, IL_006d
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 2 vs 0
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Incompatible stack heights: 2 vs 1
			//IL_002f: Incompatible stack heights: 0 vs 2
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Incompatible stack heights: 0 vs 1
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			this._0020 = new byte[_0020];
		}

		public void _0020()
		{
			//Discarded unreachable code: IL_0005, IL_000e, IL_003d, IL_0042, IL_004c, IL_0052, IL_0058, IL_005e, IL_0063
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 1 vs 0
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_005e: Incompatible stack heights: 1 vs 0
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			this.m__0020 = (this.m__0001 = (this.m__0002 = 0));
		}

		public void _0020(int _0020)
		{
			//Discarded unreachable code: IL_000b, IL_0040, IL_0045, IL_004b, IL_0056, IL_005c, IL_005f, IL_0065, IL_006d, IL_0073, IL_0078, IL_007e
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Incompatible stack heights: 0 vs 1
			//IL_0073: Incompatible stack heights: 0 vs 1
			//IL_0079: Incompatible stack heights: 1 vs 0
			this._0020[this.m__0001++] = (byte)_0020;
		}

		public void _0001(int _0020)
		{
			//Discarded unreachable code: IL_0010, IL_0018, IL_005d, IL_0062, IL_0068, IL_006e, IL_0074, IL_007b, IL_0081, IL_0086, IL_008b
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0021: Incompatible stack heights: 1 vs 0
			//IL_007a: Incompatible stack heights: 0 vs 2
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Incompatible stack heights: 0 vs 2
			this._0020[this.m__0001++] = (byte)_0020;
			this._0020[this.m__0001++] = (byte)(_0020 >> 8);
		}

		public void _0002(int _0020)
		{
			//Discarded unreachable code: IL_000b, IL_0016, IL_00aa, IL_00af, IL_00b5, IL_00ba, IL_00c0, IL_00c8, IL_00ce, IL_00d4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 2 vs 0
			//IL_0028: Incompatible stack heights: 2 vs 0
			//IL_00b5: Incompatible stack heights: 2 vs 0
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Incompatible stack heights: 0 vs 1
			this._0020[this.m__0001++] = (byte)_0020;
			this._0020[this.m__0001++] = (byte)(_0020 >> 8);
			this._0020[this.m__0001++] = (byte)(_0020 >> 16);
			this._0020[this.m__0001++] = (byte)(_0020 >> 24);
		}

		public void _0020(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_0015, IL_001f, IL_0035, IL_005b, IL_0060, IL_0065, IL_006b, IL_006d, IL_0073, IL_0076, IL_007c
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Incompatible stack heights: 0 vs 2
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Incompatible stack heights: 0 vs 1
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Incompatible stack heights: 0 vs 1
			//IL_006c: Incompatible stack heights: 0 vs 1
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Incompatible stack heights: 0 vs 1
			Array.Copy(_0020, _0001, this._0020, this.m__0001, _0002);
			this.m__0001 += _0002;
		}

		[SpecialName]
		public int _0001()
		{
			//Discarded unreachable code: IL_0011, IL_002a, IL_0033, IL_0038, IL_003e, IL_0044, IL_004a, IL_004f, IL_0055, IL_005b
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 1 vs 0
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Incompatible stack heights: 1 vs 0
			//IL_0050: Incompatible stack heights: 0 vs 1
			//IL_0056: Incompatible stack heights: 1 vs 0
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected I4, but got O
			return this.m__0002;
		}

		public void _0002()
		{
			//Discarded unreachable code: IL_000b, IL_0014, IL_001d, IL_0092, IL_0097, IL_009d, IL_00a3, IL_00a6, IL_00ac, IL_00b2, IL_00b6, IL_00bb
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 1 vs 0
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Incompatible stack heights: 0 vs 1
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Incompatible stack heights: 0 vs 1
			if (this.m__0002 > 0)
			{
				this._0020[this.m__0001++] = (byte)this.m__0020;
				if (this.m__0002 > 8)
				{
					this._0020[this.m__0001++] = (byte)(this.m__0020 >> 8);
				}
			}
			this.m__0020 = 0u;
			this.m__0002 = 0;
		}

		public void _0020(int _0020, int _0001)
		{
			//Discarded unreachable code: IL_0005, IL_001b, IL_002b, IL_00bd, IL_00c2, IL_00c4, IL_00ca, IL_00cd, IL_00d2, IL_00d8
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_0020: Incompatible stack heights: 1 vs 0
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_002d: Incompatible stack heights: 0 vs 1
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Incompatible stack heights: 0 vs 1
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Incompatible stack heights: 0 vs 1
			//IL_00d3: Incompatible stack heights: 1 vs 0
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			this.m__0020 |= (uint)(_0020 << this.m__0002);
			this.m__0002 += _0001;
			if (this.m__0002 >= 16)
			{
				this._0020[this.m__0001++] = (byte)this.m__0020;
				this._0020[this.m__0001++] = (byte)(this.m__0020 >> 8);
				this.m__0020 >>= 16;
				this.m__0002 -= 16;
			}
		}

		public void _0003(int _0020)
		{
			//Discarded unreachable code: IL_000b, IL_001f, IL_0059, IL_005e, IL_0061, IL_0067, IL_006d, IL_0073, IL_0079, IL_007e
			//IL_001a: Incompatible stack heights: 2 vs 0
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 2 vs 1
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Incompatible stack heights: 1 vs 0
			//IL_0079: Incompatible stack heights: 2 vs 1
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			this._0020[this.m__0001++] = (byte)(_0020 >> 8);
			this._0020[this.m__0001++] = (byte)_0020;
		}

		[SpecialName]
		public bool _0003()
		{
			//Discarded unreachable code: IL_0005, IL_001a, IL_0032, IL_0037, IL_003b, IL_0041, IL_0046, IL_004c, IL_004f, IL_0055
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Incompatible stack heights: 1 vs 0
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Incompatible stack heights: 1 vs 0
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Incompatible stack heights: 1 vs 0
			return this.m__0001 == 0;
		}

		public int _0001(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_001b, IL_00ca, IL_00cf, IL_00d3, IL_00d8, IL_00db, IL_00e1, IL_00e7, IL_00eb, IL_00f1
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 1 vs 0
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Incompatible stack heights: 1 vs 2
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Incompatible stack heights: 0 vs 1
			//IL_00e2: Incompatible stack heights: 2 vs 0
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Incompatible stack heights: 0 vs 1
			if (this.m__0002 >= 8)
			{
				this._0020[this.m__0001++] = (byte)this.m__0020;
				this.m__0020 >>= 8;
				this.m__0002 -= 8;
			}
			if (_0002 > this.m__0001 - this.m__0020)
			{
				_0002 = this.m__0001 - this.m__0020;
				Array.Copy(this._0020, this.m__0020, _0020, _0001, _0002);
				this.m__0020 = 0;
				this.m__0001 = 0;
			}
			else
			{
				Array.Copy(this._0020, this.m__0020, _0020, _0001, _0002);
				this.m__0020 += _0002;
			}
			return _0002;
		}

		public byte[] _0004()
		{
			//Discarded unreachable code: IL_0005, IL_000f, IL_0026, IL_0062, IL_0067, IL_006d, IL_0070, IL_0075, IL_0077, IL_007d, IL_0081, IL_0087
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Incompatible stack heights: 0 vs 1
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Incompatible stack heights: 0 vs 1
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Incompatible stack heights: 0 vs 1
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Incompatible stack heights: 0 vs 1
			//IL_0082: Incompatible stack heights: 1 vs 0
			byte[] array = new byte[this.m__0001 - this.m__0020];
			Array.Copy(this._0020, this.m__0020, array, 0, array.Length);
			this.m__0020 = 0;
			this.m__0001 = 0;
			return array;
		}
	}
	internal class _002B : Stream
	{
		private static _0011 m__0020 = new _0011();

		protected byte[] _0020;

		protected _002D _0020;

		protected Stream _0020;

		public _002B(Stream _0020)
			: this(_0020, new _002D(), 512)
		{
		}//Discarded unreachable code: IL_001c, IL_002a, IL_0041, IL_0046, IL_004c, IL_0053, IL_0058, IL_005e, IL_0064
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Incompatible stack heights: 0 vs 1
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Incompatible stack heights: 0 vs 1
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Incompatible stack heights: 0 vs 1


		public _002B(Stream _0020, _002D _0001)
			: this(_0020, _0001, 512)
		{
		}//Discarded unreachable code: IL_0005, IL_000f, IL_002e, IL_0033, IL_0038, IL_003e, IL_0042, IL_0048, IL_004b, IL_0051, IL_0057
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Incompatible stack heights: 0 vs 1
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Incompatible stack heights: 0 vs 1
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Incompatible stack heights: 0 vs 1
		//IL_0052: Incompatible stack heights: 1 vs 0


		public _002B(Stream _0020, _002D _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_007c, IL_0081, IL_0084, IL_008a, IL_008e, IL_0094, IL_0098, IL_009d
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Incompatible stack heights: 0 vs 1
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Incompatible stack heights: 0 vs 1
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Incompatible stack heights: 0 vs 1
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			this._0020 = _0020;
			if (_0002 <= 0)
			{
				throw new InvalidOperationException(_4._0020(428638988, 1119881459, 369172972));
			}
			this._0020 = new byte[_0002];
			this._0020 = _0001;
		}

		[SpecialName]
		public override bool get_CanRead()
		{
			//Discarded unreachable code: IL_0005, IL_0014, IL_002d, IL_0032, IL_0035, IL_003b, IL_003e, IL_0043, IL_0047, IL_004d, IL_0053, IL_0056, IL_005c
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Incompatible stack heights: 0 vs 2
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 1 vs 0
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			return this._0020.CanRead;
		}

		[SpecialName]
		public override bool get_CanSeek()
		{
			//Discarded unreachable code: IL_0005, IL_0015, IL_002f, IL_0034, IL_0037, IL_003d, IL_0043, IL_0049, IL_004f, IL_0054
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 2 vs 0
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Incompatible stack heights: 0 vs 1
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_004f: Incompatible stack heights: 2 vs 0
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			return this._0020.CanSeek;
		}

		[SpecialName]
		public override bool get_CanWrite()
		{
			//Discarded unreachable code: IL_000b, IL_0013, IL_001c, IL_002b, IL_0030, IL_0035, IL_003b, IL_0041, IL_0044, IL_004a, IL_004f, IL_0055
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Incompatible stack heights: 0 vs 1
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected I4, but got Unknown
			return this._0020.CanWrite;
		}

		[SpecialName]
		public override long get_Length()
		{
			//Discarded unreachable code: IL_0005, IL_000e, IL_0029, IL_002e, IL_0038, IL_003e, IL_0043, IL_004c, IL_0052, IL_0055, IL_005b, IL_0061
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Incompatible stack heights: 0 vs 1
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Incompatible stack heights: 0 vs 2
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Incompatible stack heights: 0 vs 1
			//IL_0056: Incompatible stack heights: 3 vs 0
			//IL_005c: Incompatible stack heights: 2 vs 3
			return this._0020.Length;
		}

		[SpecialName]
		public override long get_Position()
		{
			//Discarded unreachable code: IL_0005, IL_0015, IL_0029, IL_0037, IL_003c, IL_0042, IL_0047, IL_004d, IL_0052, IL_0058, IL_005e
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Incompatible stack heights: 1 vs 0
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Incompatible stack heights: 1 vs 2
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Incompatible stack heights: 1 vs 0
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Incompatible stack heights: 0 vs 1
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected I8, but got I
			return this._0020.Position;
		}

		[SpecialName]
		public override void set_Position(long _0020)
		{
			//Discarded unreachable code: IL_0011, IL_0031, IL_0036, IL_003c, IL_0042, IL_0047, IL_004c, IL_0052, IL_0058, IL_005e, IL_0064
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Incompatible stack heights: 0 vs 1
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Incompatible stack heights: 0 vs 2
			this._0020.Position = _0020;
		}

		public override long Seek(long _0020, SeekOrigin _0001)
		{
			//Discarded unreachable code: IL_000b, IL_0036, IL_0047, IL_004c, IL_0051, IL_0057, IL_005d, IL_0062, IL_0067, IL_006a, IL_0070, IL_0076
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Incompatible stack heights: 1 vs 0
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Incompatible stack heights: 0 vs 1
			//IL_006b: Incompatible stack heights: 1 vs 0
			return this._0020.Seek(_0020, _0001);
		}

		public override void SetLength(long _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0016, IL_0037, IL_003c, IL_0047, IL_004d, IL_0053, IL_0058, IL_005e
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 1 vs 0
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Incompatible stack heights: 1 vs 0
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			this._0020.SetLength(_0020);
		}

		public override int ReadByte()
		{
			//Discarded unreachable code: IL_0005, IL_0016, IL_0036, IL_003b, IL_0046, IL_004b, IL_0051, IL_0057
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Incompatible stack heights: 2 vs 0
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_0025: Incompatible stack heights: 1 vs 0
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Incompatible stack heights: 2 vs 1
			//IL_0052: Incompatible stack heights: 1 vs 0
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			return this._0020.ReadByte();
		}

		public override int Read(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_0022, IL_0039, IL_003e, IL_0043, IL_0049, IL_0058, IL_005e
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 1 vs 0
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Incompatible stack heights: 0 vs 1
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected I4, but got Unknown
			return this._0020.Read(_0020, _0001, _0002);
		}

		protected void _0020()
		{
			//Discarded unreachable code: IL_000a, IL_0024, IL_00c8, IL_00cd, IL_00d2, IL_00d8, IL_00de, IL_00e4, IL_00e6, IL_00ec
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_0019: Incompatible stack heights: 1 vs 0
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Incompatible stack heights: 0 vs 1
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			while (!this._0020._0007())
			{
				int num = this._0020._0001(this._0020, 0, this._0020.Length);
				if (num <= 0)
				{
					break;
				}
				this._0020.Write(this._0020, 0, num);
			}
			if (!this._0020._0007())
			{
				throw new ApplicationException(_4._0020(1362334943, 1119881363, 369172932));
			}
		}

		public override void Flush()
		{
			//Discarded unreachable code: IL_0005, IL_000e, IL_001c, IL_0042, IL_0047, IL_004d, IL_0053, IL_005b, IL_0060, IL_0063, IL_0069
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Incompatible stack heights: 1 vs 0
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Incompatible stack heights: 0 vs 1
			//IL_0064: Incompatible stack heights: 1 vs 0
			this._0020._0004();
			_0020();
			this._0020.Flush();
		}

		public virtual void _0001()
		{
			//Discarded unreachable code: IL_000b, IL_0012, IL_0024, IL_00e5, IL_00ea, IL_00ed, IL_00f2, IL_00f8, IL_00fe
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Incompatible stack heights: 1 vs 2
			//IL_001f: Incompatible stack heights: 2 vs 0
			//IL_0025: Incompatible stack heights: 1 vs 2
			//IL_0091: Incompatible stack heights: 1 vs 0
			//IL_00a4: Incompatible stack heights: 0 vs 1
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Incompatible stack heights: 1 vs 0
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			this._0020._0005();
			while (!this._0020._0006())
			{
				int num = this._0020._0001(this._0020, 0, this._0020.Length);
				if (num <= 0)
				{
					break;
				}
				this._0020.Write(this._0020, 0, num);
			}
			if (!this._0020._0006())
			{
				throw new ApplicationException(_4._0020(322055266, 1119881379, 369172932));
			}
			this._0020.Flush();
		}

		public override void Close()
		{
			//Discarded unreachable code: IL_000b, IL_0039, IL_003e, IL_0044, IL_0046, IL_004c, IL_0052, IL_0057
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0045: Incompatible stack heights: 0 vs 1
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			_0001();
			this._0020.Close();
		}

		public override void WriteByte(byte _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0018, IL_002c, IL_004d, IL_0052, IL_0059, IL_005f, IL_0065, IL_006a, IL_006e, IL_0074
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0021: Incompatible stack heights: 1 vs 0
			//IL_0033: Incompatible stack heights: 1 vs 3
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Incompatible stack heights: 1 vs 0
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Incompatible stack heights: 0 vs 1
			Write(new byte[1] { _0020 }, 0, 1);
		}

		public override void Write(byte[] _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0014, IL_001c, IL_0044, IL_0049, IL_004f, IL_0055, IL_005b, IL_0061, IL_0068, IL_006d
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 1 vs 0
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Incompatible stack heights: 0 vs 1
			//IL_0068: Incompatible stack heights: 1 vs 0
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			this._0020._0020(_0020, _0001, _0002);
			this._0020();
		}
	}
}
namespace _0001
{
	internal static class _0001
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_001c, IL_0024, IL_01a1, IL_01a6, IL_01ab, IL_01b1, IL_01bb, IL_01c1
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Incompatible stack heights: 0 vs 1
			lock (global::_0001._0001.m__0020)
			{
				int num = _0020 ^ 0x67134800;
				if (global::_0001._0001.m__0020 != null && global::_0001._0001.m__0020.ContainsKey(num))
				{
					return global::_0001._0001.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("30d422652e2140ebac1436f8d139d6ab"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x58B9ACC6;
				}
				int num5 = _0002 ^ 0x77B69DB0;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (global::_0001._0001.m__0020 == null)
				{
					global::_0001._0001.m__0020 = new Dictionary<int, string>();
				}
				global::_0001._0001.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0002
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000a, IL_001e, IL_01a1, IL_01a6, IL_01ac, IL_01b3, IL_01b9, IL_01be
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 2
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_0022: Incompatible stack heights: 2 vs 0
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Incompatible stack heights: 0 vs 1
			lock (global::_0001._0002.m__0020)
			{
				int num = _0020 ^ 0x31925239;
				if (global::_0001._0002.m__0020 != null && global::_0001._0002.m__0020.ContainsKey(num))
				{
					return global::_0001._0002.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("1c49b602083d48f29a4664e8373dedcd"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x52EAB540;
				}
				int num5 = _0002 ^ 0x11579;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (global::_0001._0002.m__0020 == null)
				{
					global::_0001._0002.m__0020 = new Dictionary<int, string>();
				}
				global::_0001._0002.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0003
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000a, IL_0012, IL_001b, IL_0027, IL_01ab, IL_01b0, IL_01b2, IL_01b8, IL_01bd, IL_01c5, IL_01cb
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_0016: Incompatible stack heights: 1 vs 0
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Incompatible stack heights: 0 vs 1
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Incompatible stack heights: 0 vs 1
			lock (_0003.m__0020)
			{
				int num = _0020 ^ 0x28454778;
				if (_0003.m__0020 != null && _0003.m__0020.ContainsKey(num))
				{
					return _0003.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("b5d92629480443ddb274d723ca21343c"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x547F0ED5;
				}
				int num5 = _0002 ^ 0xB348F9E;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0003.m__0020 == null)
				{
					_0003.m__0020 = new Dictionary<int, string>();
				}
				_0003.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0004
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0017, IL_002b, IL_01a8, IL_01ad, IL_01b3, IL_01b7, IL_01bd, IL_01c1, IL_01c6, IL_01cc, IL_01d2
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Incompatible stack heights: 0 vs 1
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Incompatible stack heights: 1 vs 0
			//IL_01cd: Incompatible stack heights: 0 vs 1
			lock (_0004.m__0020)
			{
				int num = _0020 ^ 0x11BF7243;
				if (_0004.m__0020 != null && _0004.m__0020.ContainsKey(num))
				{
					return _0004.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("ff7cc66d0855408cb294b98e3a70edab"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x2FE01B11;
				}
				int num5 = _0002 ^ 0x29462538;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0004.m__0020 == null)
				{
					_0004.m__0020 = new Dictionary<int, string>();
				}
				_0004.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0005
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0018, IL_019a, IL_019f, IL_01a5, IL_01aa, IL_01ad, IL_01b3
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_001b: Incompatible stack heights: 1 vs 0
			//IL_01a5: Incompatible stack heights: 1 vs 0
			//IL_01ac: Incompatible stack heights: 0 vs 1
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected O, but got I4
			lock (_0005.m__0020)
			{
				int num = _0020 ^ 0x4860D359;
				if (_0005.m__0020 != null && _0005.m__0020.ContainsKey(num))
				{
					return _0005.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("924b85aea7b54c0ba4930f5b25b987bf"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x3F189F04;
				}
				int num5 = _0002 ^ 0x303462C6;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0005.m__0020 == null)
				{
					_0005.m__0020 = new Dictionary<int, string>();
				}
				_0005.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0006
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0013, IL_01ab, IL_01b0, IL_01b3, IL_01b8, IL_01be, IL_01c4, IL_01ca, IL_01cf, IL_01d5
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Incompatible stack heights: 0 vs 2
			//IL_0020: Incompatible stack heights: 1 vs 0
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Incompatible stack heights: 0 vs 1
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Incompatible stack heights: 0 vs 1
			//IL_01d0: Incompatible stack heights: 1 vs 0
			lock (_0006.m__0020)
			{
				int num = _0020 ^ 0x16CB0B19;
				if (_0006.m__0020 != null && _0006.m__0020.ContainsKey(num))
				{
					return _0006.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("d60a8c568add432c938a6286ea26585d"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x6BCEB57D;
				}
				int num5 = _0002 ^ 0x1EEB5905;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0006.m__0020 == null)
				{
					_0006.m__0020 = new Dictionary<int, string>();
				}
				_0006.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0007
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0010, IL_001f, IL_019d, IL_01a2, IL_01a8, IL_01ac, IL_01b1, IL_01b5, IL_01bb, IL_01c1, IL_01c7
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Incompatible stack heights: 0 vs 2
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Incompatible stack heights: 0 vs 1
			//IL_01c2: Incompatible stack heights: 2 vs 0
			lock (_0007.m__0020)
			{
				int num = _0020 ^ 0x5F72DCD2;
				if (_0007.m__0020 != null && _0007.m__0020.ContainsKey(num))
				{
					return _0007.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("eb1e4a3e7df04feea048d3a236cec661"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x44EACED4;
				}
				int num5 = _0002 ^ 0x59AFF117;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0007.m__0020 == null)
				{
					_0007.m__0020 = new Dictionary<int, string>();
				}
				_0007.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0008
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0010, IL_0021, IL_01a4, IL_01a9, IL_01ab, IL_01b1, IL_01b4, IL_01b9, IL_01bc, IL_01c2, IL_01c8
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_0025: Incompatible stack heights: 1 vs 0
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Incompatible stack heights: 0 vs 2
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Incompatible stack heights: 1 vs 0
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Incompatible stack heights: 0 vs 1
			//IL_01c3: Incompatible stack heights: 1 vs 0
			lock (_0008.m__0020)
			{
				int num = _0020 ^ 0x794DDA21;
				if (_0008.m__0020 != null && _0008.m__0020.ContainsKey(num))
				{
					return _0008.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("a3133c11698d425e986d3b6c7cc96baf"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x3700BBC;
				}
				int num5 = _0002 ^ 0x6CAC985D;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0008.m__0020 == null)
				{
					_0008.m__0020 = new Dictionary<int, string>();
				}
				_0008.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0027
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0017, IL_0027, IL_01ab, IL_01b0, IL_01b2, IL_01b7, IL_01bb, IL_01c1, IL_01c7, IL_01cd, IL_01d3
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Incompatible stack heights: 0 vs 1
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Incompatible stack heights: 0 vs 2
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Incompatible stack heights: 0 vs 1
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Incompatible stack heights: 0 vs 1
			//IL_01c8: Incompatible stack heights: 1 vs 0
			lock (_0027.m__0020)
			{
				int num = _0020 ^ 0x651B169E;
				if (_0027.m__0020 != null && _0027.m__0020.ContainsKey(num))
				{
					return _0027.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("21e72a7ebe274dbdb422e4cfec5ac298"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x4FBF49C;
				}
				int num5 = _0002 ^ 0x396E0D70;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0027.m__0020 == null)
				{
					_0027.m__0020 = new Dictionary<int, string>();
				}
				_0027.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0020
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0010, IL_0199, IL_019e, IL_01a2, IL_01a8, IL_01ae, IL_01b3
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Incompatible stack heights: 0 vs 1
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Incompatible stack heights: 1 vs 0
			//IL_01ae: Incompatible stack heights: 0 vs 1
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Expected O, but got Unknown
			lock (global::_0001._0020.m__0020)
			{
				int num = _0020 ^ 0x11800639;
				if (global::_0001._0020.m__0020 != null && global::_0001._0020.m__0020.ContainsKey(num))
				{
					return global::_0001._0020.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("bd23d6cc57e94104a21ff2e703f2bd8b"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x2BA8814;
				}
				int num5 = _0002 ^ 0x4D074FB8;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (global::_0001._0020.m__0020 == null)
				{
					global::_0001._0020.m__0020 = new Dictionary<int, string>();
				}
				global::_0001._0020.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0009
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_001d, IL_019f, IL_01a4, IL_01a6, IL_01ab, IL_01b1, IL_01b7, IL_01bd
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 2
			//IL_0020: Incompatible stack heights: 1 vs 0
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Incompatible stack heights: 1 vs 0
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Expected O, but got Unknown
			lock (_0009.m__0020)
			{
				int num = _0020 ^ 0x55A5D56A;
				if (_0009.m__0020 != null && _0009.m__0020.ContainsKey(num))
				{
					return _0009.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("34bc8c6c3c284ea8ba351dadfb90dc97"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x451A03AB;
				}
				int num5 = _0002 ^ 0x70D8A993;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0009.m__0020 == null)
				{
					_0009.m__0020 = new Dictionary<int, string>();
				}
				_0009.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0021
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_0013, IL_019b, IL_01a0, IL_01a6, IL_01ac, IL_01b1, IL_01b7, IL_01bf, IL_01c5
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_001c: Incompatible stack heights: 1 vs 0
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Incompatible stack heights: 0 vs 1
			lock (_0021.m__0020)
			{
				int num = _0020 ^ 0x6C49BE40;
				if (_0021.m__0020 != null && _0021.m__0020.ContainsKey(num))
				{
					return _0021.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("146f43c319a6410cbd6a02ad1c826de2"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x49A56267;
				}
				int num5 = _0002 ^ 0x22F848D;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0021.m__0020 == null)
				{
					_0021.m__0020 = new Dictionary<int, string>();
				}
				_0021.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0022
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_001c, IL_002b, IL_01ab, IL_01b0, IL_01b7, IL_01bd, IL_01c2, IL_01c8, IL_01ce
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_0030: Incompatible stack heights: 0 vs 2
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Incompatible stack heights: 0 vs 1
			lock (_0022.m__0020)
			{
				int num = _0020 ^ 0x1CA9D8CD;
				if (_0022.m__0020 != null && _0022.m__0020.ContainsKey(num))
				{
					return _0022.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("9b7223f65e88492893c34cb4c1a3e791"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x6236EB01;
				}
				int num5 = _0002 ^ 0x68301EAC;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0022.m__0020 == null)
				{
					_0022.m__0020 = new Dictionary<int, string>();
				}
				_0022.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0023
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0016, IL_0020, IL_01a2, IL_01a7, IL_01ad, IL_01b4, IL_01ba, IL_01c2, IL_01c7, IL_01cb, IL_01d1, IL_01d7
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Incompatible stack heights: 0 vs 2
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Incompatible stack heights: 0 vs 1
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Incompatible stack heights: 0 vs 1
			//IL_01cc: Incompatible stack heights: 1 vs 0
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected O, but got Unknown
			lock (_0023.m__0020)
			{
				int num = _0020 ^ 0x1942D971;
				if (_0023.m__0020 != null && _0023.m__0020.ContainsKey(num))
				{
					return _0023.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("3b98430d668341cba5f5c68cf9da4007"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x39002AF9;
				}
				int num5 = _0002 ^ 0x393CC686;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0023.m__0020 == null)
				{
					_0023.m__0020 = new Dictionary<int, string>();
				}
				_0023.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0024
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000a, IL_0013, IL_0197, IL_019c, IL_01a2, IL_01aa, IL_01b0, IL_01b2, IL_01b7, IL_01bd, IL_01c3, IL_01c9
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 1 vs 0
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Incompatible stack heights: 0 vs 1
			//IL_01be: Incompatible stack heights: 0 vs 2
			//IL_01c4: Incompatible stack heights: 2 vs 0
			lock (_0024.m__0020)
			{
				int num = _0020 ^ 0x19649DC4;
				if (_0024.m__0020 != null && _0024.m__0020.ContainsKey(num))
				{
					return _0024.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("7b6f515f15c94cee98577c65f1894bc4"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x7450F618;
				}
				int num5 = _0002 ^ 0x4D278F0B;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0024.m__0020 == null)
				{
					_0024.m__0020 = new Dictionary<int, string>();
				}
				_0024.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0028
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_0015, IL_0024, IL_01a6, IL_01ab, IL_01b7, IL_01bd, IL_01c3, IL_01c9, IL_01d6, IL_01db
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Incompatible stack heights: 1 vs 0
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Incompatible stack heights: 2 vs 0
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Incompatible stack heights: 2 vs 3
			//IL_01d6: Incompatible stack heights: 1 vs 2
			lock (_0028.m__0020)
			{
				int num = _0020 ^ 0x654F6309;
				if (_0028.m__0020 != null && _0028.m__0020.ContainsKey(num))
				{
					return _0028.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("943c3435185f4723a05f40921b83b632"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x314E7DA1;
				}
				int num5 = _0002 ^ 0x559516CC;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0028.m__0020 == null)
				{
					_0028.m__0020 = new Dictionary<int, string>();
				}
				_0028.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _0029
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0010, IL_01a4, IL_01a9, IL_01af, IL_01b6, IL_01bc, IL_01bf, IL_01c4, IL_01ca, IL_01d0, IL_01d6
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Incompatible stack heights: 0 vs 1
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Incompatible stack heights: 0 vs 1
			//IL_01d1: Incompatible stack heights: 1 vs 0
			lock (_0029.m__0020)
			{
				int num = _0020 ^ 0x7E06CDE1;
				if (_0029.m__0020 != null && _0029.m__0020.ContainsKey(num))
				{
					return _0029.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("2f5c63f7af3743d8ba3dfc0c5f5d8127"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x2246B2C4;
				}
				int num5 = _0002 ^ 0x3E38E43;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_0029.m__0020 == null)
				{
					_0029.m__0020 = new Dictionary<int, string>();
				}
				_0029.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _002A
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0016, IL_0029, IL_01a5, IL_01aa, IL_01b0, IL_01b6, IL_01b9, IL_01bf, IL_01c7, IL_01cd, IL_01d2
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Incompatible stack heights: 0 vs 1
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Incompatible stack heights: 0 vs 2
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected O, but got I4
			lock (_002A.m__0020)
			{
				int num = _0020 ^ 0x52CC761F;
				if (_002A.m__0020 != null && _002A.m__0020.ContainsKey(num))
				{
					return _002A.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("565b4b2532f84ab2a4537e61b7379ff3"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x4EC389F8;
				}
				int num5 = _0002 ^ 0x3EF1206C;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_002A.m__0020 == null)
				{
					_002A.m__0020 = new Dictionary<int, string>();
				}
				_002A.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _002C
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0029, IL_01a6, IL_01ab, IL_01b1, IL_01b7, IL_01bc, IL_01c2
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Incompatible stack heights: 1 vs 0
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Incompatible stack heights: 1 vs 0
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			lock (_002C.m__0020)
			{
				int num = _0020 ^ 0x70ABA92F;
				if (_002C.m__0020 != null && _002C.m__0020.ContainsKey(num))
				{
					return _002C.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("b42ee5d4360640019da18bdc342c081e"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x562C0C69;
				}
				int num5 = _0002 ^ 0x552435C8;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_002C.m__0020 == null)
				{
					_002C.m__0020 = new Dictionary<int, string>();
				}
				_002C.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _002E
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_019c, IL_01a1, IL_01aa, IL_01b0, IL_01b5, IL_01b8, IL_01be
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Incompatible stack heights: 1 vs 0
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Incompatible stack heights: 0 vs 1
			//IL_01b0: Incompatible stack heights: 1 vs 0
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Incompatible stack heights: 0 vs 1
			lock (_002E.m__0020)
			{
				int num = _0020 ^ 0x63F1A369;
				if (_002E.m__0020 != null && _002E.m__0020.ContainsKey(num))
				{
					return _002E.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("f3896e3d14df4ed6ac445dd15244a9b9"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x6D95C57C;
				}
				int num5 = _0002 ^ 0x2C37E374;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_002E.m__0020 == null)
				{
					_002E.m__0020 = new Dictionary<int, string>();
				}
				_002E.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _002F
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_0005, IL_0013, IL_0027, IL_01a4, IL_01a9, IL_01b0, IL_01b6, IL_01bf, IL_01c5, IL_01ca
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Incompatible stack heights: 0 vs 2
			//IL_001c: Incompatible stack heights: 0 vs 1
			//IL_0022: Incompatible stack heights: 1 vs 0
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Incompatible stack heights: 0 vs 1
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Incompatible stack heights: 0 vs 1
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Incompatible stack heights: 0 vs 2
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Expected O, but got I4
			lock (_002F.m__0020)
			{
				int num = _0020 ^ 0x452B71AA;
				if (_002F.m__0020 != null && _002F.m__0020.ContainsKey(num))
				{
					return _002F.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("1cd5dd47d36349daa4fd202f40fc2303"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x5C4F0435;
				}
				int num5 = _0002 ^ 0x547408B0;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_002F.m__0020 == null)
				{
					_002F.m__0020 = new Dictionary<int, string>();
				}
				_002F.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
	internal static class _003D
	{
		private static readonly object m__0020 = new object();

		private static Dictionary<int, string> m__0020;

		internal static string _0020(int _0020, int _0001, int _0002)
		{
			//Discarded unreachable code: IL_000b, IL_0017, IL_001f, IL_0028, IL_01a4, IL_01a9, IL_01af, IL_01b5, IL_01c1, IL_01c7, IL_01cd, IL_01d3, IL_01d8, IL_01dd, IL_01e3
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 1 vs 0
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Incompatible stack heights: 0 vs 1
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Incompatible stack heights: 0 vs 2
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Incompatible stack heights: 0 vs 1
			//IL_01d3: Incompatible stack heights: 1 vs 0
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Incompatible stack heights: 2 vs 0
			lock (_003D.m__0020)
			{
				int num = _0020 ^ 0x6B917A79;
				if (_003D.m__0020 != null && _003D.m__0020.ContainsKey(num))
				{
					return _003D.m__0020[num];
				}
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream("82e033807cfe4cfea2d4dc262a7d27d9"))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = _0001;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x61D1101;
				}
				int num5 = _0002 ^ 0x569C92CE;
				byte[] array2 = new byte[num5];
				int num6 = 0;
				for (int i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				byte[] array3 = new byte[num5];
				Random random = new Random(num);
				random.NextBytes(array3);
				for (int j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				string @string = Encoding.Unicode.GetString(array2);
				if (_003D.m__0020 == null)
				{
					_003D.m__0020 = new Dictionary<int, string>();
				}
				_003D.m__0020.Add(num, @string);
				return @string;
			}
		}
	}
}
