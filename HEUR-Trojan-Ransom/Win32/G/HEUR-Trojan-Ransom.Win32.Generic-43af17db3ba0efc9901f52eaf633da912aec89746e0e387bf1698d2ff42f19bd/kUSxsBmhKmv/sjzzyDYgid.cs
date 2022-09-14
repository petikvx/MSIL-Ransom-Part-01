using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace kUSxsBmhKmv;

public sealed class sjzzyDYgid
{
	[NonSerialized]
	internal static GetString getString_0;

	public void edqfKcUOIXCaqq(string DYktPjquQLOid, HashSet<string> oDmNEQoRXPe, out Dictionary<ulong, oslEfjNgXXNB> QiEcubdfypQAw, out Dictionary<ulong, oslEfjNgXXNB> fEOFalLEyOMDLnW)
	{
		fEOFalLEyOMDLnW = new Dictionary<ulong, oslEfjNgXXNB>();
		QiEcubdfypQAw = new Dictionary<ulong, oslEfjNgXXNB>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr oEeYMbBDaJCj = IntPtr.Zero;
		try
		{
			UAmXJDQYbTNDU(DYktPjquQLOid, fEOFalLEyOMDLnW);
			CwifRxQwTDOsUY(DYktPjquQLOid, out oEeYMbBDaJCj);
			JTYrbjDyQFCIyA(oEeYMbBDaJCj);
			KFzUFEhYiXbW(ref intptr_, oEeYMbBDaJCj);
			WRhvwiKLQSM(intptr_, ref QiEcubdfypQAw, oDmNEQoRXPe, fEOFalLEyOMDLnW, oEeYMbBDaJCj);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107397689), ex);
		}
		finally
		{
			if (oEeYMbBDaJCj.ToInt32() != -1)
			{
				YPozjngzQs.CloseHandle(oEeYMbBDaJCj);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void UAmXJDQYbTNDU(string string_0, Dictionary<ulong, oslEfjNgXXNB> dictionary_0)
	{
		string text = getString_0(107397652) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = YPozjngzQs.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			YPozjngzQs.MwxJKPNSghjaz wHdepBOIowsXdI = default(YPozjngzQs.MwxJKPNSghjaz);
			if (YPozjngzQs.GetFileInformationByHandle(intPtr, out wHdepBOIowsXdI))
			{
				ulong num = wHdepBOIowsXdI.YPUOLqlNqRFP;
				ulong key = (num << 32) | wHdepBOIowsXdI.iTSnQeSDAOMA;
				oslEfjNgXXNB value = new oslEfjNgXXNB(text, 0uL);
				dictionary_0.Add(key, value);
			}
			YPozjngzQs.CloseHandle(intPtr);
		}
	}

	private void CwifRxQwTDOsUY(string AfALPjTgaxwRuz, out IntPtr oEeYMbBDaJCj)
	{
		string string_ = getString_0(107397652) + AfALPjTgaxwRuz;
		oEeYMbBDaJCj = YPozjngzQs.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void WRhvwiKLQSM(IntPtr intptr_0, ref Dictionary<ulong, oslEfjNgXXNB> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, oslEfjNgXXNB> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		YPozjngzQs.ZeroMemory(intPtr, 65544);
		uint jOsTXMiHbONIkPZMt = 0u;
		while (YPozjngzQs.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(YPozjngzQs.WJTnxMpwzsrxx), intPtr, 65544, out jOsTXMiHbONIkPZMt, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (jOsTXMiHbONIkPZMt > 60)
			{
				YPozjngzQs.lLcyuHHXTcNO lLcyuHHXTcNO = new YPozjngzQs.lLcyuHHXTcNO(intptr_2);
				if (0 != (lLcyuHHXTcNO.XzwTySWWZu & 0x10))
				{
					if (dictionary_1.ContainsKey(lLcyuHHXTcNO.hTwsGlYBhKak))
					{
						throw new Exception(string.Format(getString_0(107364331), lLcyuHHXTcNO.hTwsGlYBhKak, lLcyuHHXTcNO.BRNPsBTqGfQj));
					}
					dictionary_1.Add(lLcyuHHXTcNO.hTwsGlYBhKak, new oslEfjNgXXNB(lLcyuHHXTcNO.BRNPsBTqGfQj, lLcyuHHXTcNO.nzELpMuvziofyW));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(lLcyuHHXTcNO.BRNPsBTqGfQj);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(lLcyuHHXTcNO.hTwsGlYBhKak))
						{
							dictionary_0.Add(lLcyuHHXTcNO.hTwsGlYBhKak, new oslEfjNgXXNB(lLcyuHHXTcNO.BRNPsBTqGfQj, lLcyuHHXTcNO.nzELpMuvziofyW));
						}
						else
						{
							oslEfjNgXXNB oslEfjNgXXNB2 = dictionary_0[lLcyuHHXTcNO.hTwsGlYBhKak];
							if (0 != string.Compare(lLcyuHHXTcNO.BRNPsBTqGfQj, oslEfjNgXXNB2.Name, ignoreCase: true))
							{
								Console.WriteLine(getString_0(107364294), lLcyuHHXTcNO.hTwsGlYBhKak, lLcyuHHXTcNO.BRNPsBTqGfQj, oslEfjNgXXNB2.Name);
								throw new Exception(string.Format(getString_0(107364331), lLcyuHHXTcNO.hTwsGlYBhKak, lLcyuHHXTcNO.BRNPsBTqGfQj));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + lLcyuHHXTcNO.YzSqECEghWmI);
				jOsTXMiHbONIkPZMt -= lLcyuHHXTcNO.YzSqECEghWmI;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void JTYrbjDyQFCIyA(IntPtr intptr_0)
	{
		YPozjngzQs.iThKKoyFnhi structure = default(YPozjngzQs.iThKKoyFnhi);
		structure.vPVYUJqBAtmhtz = 8388608uL;
		structure.ycIAFIhfPLuj = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		YPozjngzQs.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		YPozjngzQs.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void KFzUFEhYiXbW(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint hqNGzLdkOuBI = 0u;
		YPozjngzQs.yiUHJbxbUorDr ivKhmXfqqJRw = default(YPozjngzQs.yiUHJbxbUorDr);
		if (YPozjngzQs.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out ivKhmXfqqJRw, sizeof(YPozjngzQs.yiUHJbxbUorDr), out hqNGzLdkOuBI, IntPtr.Zero))
		{
			YPozjngzQs.WJTnxMpwzsrxx structure = default(YPozjngzQs.WJTnxMpwzsrxx);
			structure.yEpBQSfsRYJ = 0uL;
			structure.ecQtHTEkTQOzSnmP = 0L;
			structure.oUXHLtJyzDxW = ivKhmXfqqJRw.ngVkVSzaQPTE;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			YPozjngzQs.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static sjzzyDYgid()
	{
		Strings.CreateGetStringDelegate(typeof(sjzzyDYgid));
	}
}
