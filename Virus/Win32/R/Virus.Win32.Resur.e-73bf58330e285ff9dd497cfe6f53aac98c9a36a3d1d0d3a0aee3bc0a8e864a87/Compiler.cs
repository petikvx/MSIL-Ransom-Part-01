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
			Evidence evidence = new Evidence(AppDomain.CurrentDomain.get_Evidence());
			appDomain = AppDomain.CreateDomain("Compiler", evidence, appDomainSetup);
			JScriptCompiler jScriptCompiler = (JScriptCompiler)appDomain.CreateInstance(Assembly.GetAssembly(typeof(JScriptCompiler))!.FullName, "JScriptCompiler")!.Unwrap();
			return jScriptCompiler.Run(args);
		}
		catch (Exception ex)
		{
			Console.WriteLine(JScriptCompiler.Localize("INTERNAL COMPILER ERROR", ex.Message));
			return 10;
		}
		catch
		{
			Console.WriteLine(JScriptCompiler.Localize("INTERNAL COMPILER ERROR"));
			return 10;
		}
	}
}
