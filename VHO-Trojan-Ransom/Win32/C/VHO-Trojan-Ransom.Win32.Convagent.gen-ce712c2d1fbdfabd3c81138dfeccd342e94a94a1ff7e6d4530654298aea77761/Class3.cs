using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.VisualBasic.ApplicationServices;

internal class Class3 : Application
{
	[SpecialName]
	[DebuggerHidden]
	internal AssemblyInfo method_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new AssemblyInfo(Assembly.GetExecutingAssembly());
	}
}
