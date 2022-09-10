using System;
using System.Reflection;
using Quest.PowerGUI.ScriptRunner;

namespace Runner;

internal class AppDomainInitialize : MarshalByRefObject
{
	public void Init()
	{
		AppDomain.CurrentDomain.UnhandledException += Loader.AppDomain_UnhandledException;
		AppDomain.CurrentDomain.AssemblyResolve += Loader.AppDomain_AssemblyResolve;
		Init_0();
	}

	private void Init_0()
	{
		ProductFolder.Init(Assembly.GetExecutingAssembly().Location);
	}
}
