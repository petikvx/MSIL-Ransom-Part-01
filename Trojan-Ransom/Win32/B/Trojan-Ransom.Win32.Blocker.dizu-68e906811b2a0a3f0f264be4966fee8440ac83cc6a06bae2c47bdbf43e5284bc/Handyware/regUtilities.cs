using Microsoft.Win32;

namespace Handyware;

public class regUtilities
{
	public bool RenameSubKey(RegistryKey parentKey, string subKeyName, string newSubKeyName)
	{
		CopyKey(parentKey, subKeyName, newSubKeyName);
		parentKey.DeleteSubKeyTree(subKeyName);
		return true;
	}

	public bool CopyKey(RegistryKey parentKey, string keyNameToCopy, string newKeyName)
	{
		RegistryKey destinationKey = parentKey.CreateSubKey(newKeyName);
		RegistryKey sourceKey = parentKey.OpenSubKey(keyNameToCopy);
		RecurseCopyKey(sourceKey, destinationKey);
		return true;
	}

	private void RecurseCopyKey(RegistryKey sourceKey, RegistryKey destinationKey)
	{
		string[] valueNames = sourceKey.GetValueNames();
		foreach (string name in valueNames)
		{
			object value = sourceKey.GetValue(name);
			RegistryValueKind valueKind = sourceKey.GetValueKind(name);
			destinationKey.SetValue(name, value, valueKind);
		}
		valueNames = sourceKey.GetSubKeyNames();
		foreach (string text in valueNames)
		{
			RegistryKey sourceKey2 = sourceKey.OpenSubKey(text);
			RegistryKey destinationKey2 = destinationKey.CreateSubKey(text);
			RecurseCopyKey(sourceKey2, destinationKey2);
		}
	}
}
