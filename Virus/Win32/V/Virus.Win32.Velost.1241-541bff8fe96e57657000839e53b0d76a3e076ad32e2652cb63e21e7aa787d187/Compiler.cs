using System;
using System.Reflection;
using System.Security.Policy;

internal class Compiler
{
	public static int Main(string[] args)
	{
		AppDomainSetup appDomainSetup = new AppDomainSetup();
		appDomainSetup.set_PrivateBinPath("");
		appDomainSetup.set_PrivateBinPathProbe("*");
		try
		{
			AppDomain appDomain = null;
			appDomain = AppDomain.CreateDomain("Compiler", (Evidence)null, appDomainSetup);
			JScriptCompiler jScriptCompiler = (JScriptCompiler)appDomain.CreateInstance(Assembly.GetAssembly(typeof(JScriptCompiler))!.FullName, "JScriptCompiler")!.Unwrap();
			return jScriptCompiler.Run(args);
		}
		catch (Exception ex)
		{
			Console.WriteLine(JScriptCompiler.Localize("INTERNAL COMPILER ERROR", ex.Message));
			return 10;
		}
	}
}
