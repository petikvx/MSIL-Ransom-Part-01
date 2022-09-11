using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace HWIDGrabber;

internal class HWDI
{
	public static string GetMachineGuid()
	{
		string text = "SOFTWARE\\Microsoft\\Cryptography";
		string text2 = "MachineGuid";
		using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
		using RegistryKey registryKey2 = registryKey.OpenSubKey(text);
		if (registryKey2 == null)
		{
			throw new KeyNotFoundException($"Key Not Found: {text}");
		}
		object value = registryKey2.GetValue(text2);
		if (value == null)
		{
			throw new IndexOutOfRangeException($"Index Not Found: {text2}");
		}
		return value.ToString();
	}
}
