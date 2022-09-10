using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenNETCF.Desktop.Communication;

public sealed class CERegistryKey : MarshalByRefObject, IDisposable
{
	private enum KeyDisposition
	{
		REG_CREATED_NEW_KEY = 1,
		REG_OPENED_EXISTING_KEY
	}

	private enum KeyType
	{
		String = 1,
		ExpandString = 2,
		Binary = 3,
		DWord = 4,
		MultiString = 7
	}

	private const int ERROR_NO_MORE_ITEMS = 259;

	private uint m_handle;

	private string m_name;

	private bool m_writable;

	private bool m_isroot;

	public string Name => m_name;

	public int SubKeyCount
	{
		get
		{
			if (CheckHKey())
			{
				char[] array = new char[256];
				int lpcbClass = array.Length;
				if (CeRegQueryInfoKey(m_handle, array, ref lpcbClass, 0, out var cSubkey, out var _, out var _, out var _, out var _, out var _, 0, 0) != 0)
				{
					throw new ExternalException("Error retrieving registry properties");
				}
				return cSubkey;
			}
			throw new ObjectDisposedException("The RegistryKey being manipulated is closed (closed keys cannot be accessed).");
		}
	}

	public int ValueCount
	{
		get
		{
			if (CheckHKey())
			{
				char[] array = new char[256];
				int lpcbClass = array.Length;
				if (CeRegQueryInfoKey(m_handle, array, ref lpcbClass, 0, out var _, out var _, out var _, out var cValueNames, out var _, out var _, 0, 0) != 0)
				{
					throw new ExternalException("Error retrieving registry properties");
				}
				return cValueNames;
			}
			throw new ObjectDisposedException("The RegistryKey being manipulated is closed (closed keys cannot be accessed).");
		}
	}

	internal CERegistryKey(uint rootKey, string name, bool writable, bool isroot)
	{
		m_handle = rootKey;
		m_writable = writable;
		m_name = name;
		m_isroot = isroot;
	}

	public override string ToString()
	{
		if (!CheckHKey())
		{
			throw new ObjectDisposedException("The RegistryKey being manipulated is closed (closed keys cannot be accessed).");
		}
		return m_name + " [0x" + m_handle.ToString("X") + "]";
	}

	public void Close()
	{
		if (!m_isroot && CheckHKey())
		{
			if (CeRegCloseKey(m_handle) != 0)
			{
				throw new ExternalException("Error closing RegistryKey");
			}
			m_handle = 0u;
		}
	}

	public CERegistryKey CreateSubKey(string subkey)
	{
		if (CheckHKey())
		{
			if (subkey != null)
			{
				if (subkey.Length < 256)
				{
					uint phkResult = 0u;
					uint lpdwDisposition = 0u;
					if (CeRegCreateKeyEx(m_handle, subkey, 0, null, 0, 0, IntPtr.Zero, ref phkResult, ref lpdwDisposition) != 0)
					{
						throw new ExternalException("An error occured creating the registry key.");
					}
					return new CERegistryKey(phkResult, m_name + "\\" + subkey, m_writable, isroot: false);
				}
				throw new ArgumentException("The length of the specified subkey is longer than the maximum length allowed (255 characters).");
			}
			throw new ArgumentNullException("The specified subkey is null.");
		}
		throw new ObjectDisposedException("The CERegistryKey on which this method is being invoked is closed (closed keys cannot be accessed).");
	}

	public CERegistryKey OpenSubKey(string name)
	{
		return OpenSubKey(name, writable: false);
	}

	public CERegistryKey OpenSubKey(string name, bool writable)
	{
		if (CheckHKey())
		{
			if (name != null)
			{
				if (name.Length < 256)
				{
					uint phkResult = 0u;
					if (CeRegOpenKeyEx(m_handle, name, 0, 0, ref phkResult) == 0)
					{
						return new CERegistryKey(phkResult, m_name + "\\" + name, writable, isroot: false);
					}
					return null;
				}
				throw new ArgumentException("The length of the specified subkey is longer than the maximum length allowed (255 characters).");
			}
			throw new ArgumentNullException("name is null.");
		}
		throw new ObjectDisposedException("The CERegistryKey being manipulated is closed (closed keys cannot be accessed).");
	}

	public void DeleteSubKey(string subkey)
	{
		DeleteSubKey(subkey, throwOnMissingSubKey: true);
	}

	public void DeleteSubKey(string subkey, bool throwOnMissingSubKey)
	{
		if (subkey != null && !(subkey == ""))
		{
			if (CheckHKey())
			{
				if (CeRegDeleteKey(m_handle, subkey) != 0 && throwOnMissingSubKey)
				{
					throw new ArgumentException("The specified subkey is not a valid reference to a registry key");
				}
				return;
			}
			throw new ObjectDisposedException("The CERegistryKey on which this method is being invoked is closed (closed keys cannot be accessed).");
		}
		throw new ArgumentNullException("The subkey is null");
	}

	public void DeleteSubKeyTree(string subkey)
	{
		DeleteSubKey(subkey, throwOnMissingSubKey: true);
	}

	public string[] GetSubKeyNames()
	{
		if (CheckHKey())
		{
			ArrayList arrayList = new ArrayList();
			int num = 0;
			char[] array = new char[256];
			int iKeyNameLen = array.Length;
			for (int num2 = CeRegEnumKeyEx(m_handle, 0, array, ref iKeyNameLen, 0, null, 0, 0); num2 != 259; num2 = CeRegEnumKeyEx(m_handle, num, array, ref iKeyNameLen, 0, null, 0, 0))
			{
				arrayList.Add(new string(array).Substring(0, iKeyNameLen));
				num++;
				iKeyNameLen = array.Length;
			}
			arrayList.Sort();
			return (string[])arrayList.ToArray(typeof(string));
		}
		throw new ObjectDisposedException("The CERegistryKey being manipulated is closed (closed keys cannot be accessed).");
	}

	public object GetValue(string name)
	{
		return GetValue(name, null);
	}

	public object GetValue(string name, object defaultValue)
	{
		if (CheckHKey())
		{
			KeyType lpType = (KeyType)0;
			int lpcbData = 0;
			int num = CeRegQueryValueEx(m_handle, name, 0, ref lpType, null, ref lpcbData);
			if (num == 87)
			{
				return defaultValue;
			}
			byte[] array = new byte[lpcbData];
			num = CeRegQueryValueEx(m_handle, name, 0, ref lpType, array, ref lpcbData);
			switch (lpType)
			{
			case KeyType.String:
			case KeyType.ExpandString:
			{
				string string2 = Encoding.Unicode.GetString(array, 0, lpcbData);
				char[] trimChars = new char[1];
				return string2.TrimEnd(trimChars);
			}
			case KeyType.Binary:
				return array;
			case KeyType.DWord:
				return BitConverter.ToUInt32(array, 0);
			default:
				return defaultValue;
			case KeyType.MultiString:
			{
				string @string = Encoding.Unicode.GetString(array, 0, lpcbData);
				char[] trimChars = new char[1];
				string text = @string.TrimEnd(trimChars);
				trimChars = new char[1];
				return text.Split(trimChars);
			}
			}
		}
		throw new ObjectDisposedException("The RegistryKey being manipulated is closed (closed keys cannot be accessed).");
	}

	public void SetValue(string name, object value)
	{
		if (CheckHKey())
		{
			KeyType keyType = (KeyType)0;
			byte[] array;
			int lpcbData;
			switch (value.GetType().ToString())
			{
			case "System.UInt32":
				keyType = KeyType.DWord;
				array = BitConverter.GetBytes((uint)value);
				goto IL_0108;
			case "System.Int32":
				keyType = KeyType.DWord;
				array = BitConverter.GetBytes((int)value);
				goto IL_0108;
			case "System.Byte[]":
				keyType = KeyType.Binary;
				array = (byte[])value;
				goto IL_0108;
			case "System.String[]":
			{
				StringBuilder stringBuilder = new StringBuilder();
				string[] array2 = (string[])value;
				foreach (string text in array2)
				{
					stringBuilder.Append(text + '\0');
				}
				stringBuilder.Append('\0');
				keyType = KeyType.MultiString;
				array = Encoding.Unicode.GetBytes(stringBuilder.ToString());
				goto IL_0108;
			}
			case "System.String":
				keyType = KeyType.String;
				array = Encoding.Unicode.GetBytes((string)value + '\0');
				goto IL_0108;
			default:
				{
					throw new ArgumentException("value is not a supported type");
				}
				IL_0108:
				lpcbData = array.Length;
				if (CeRegSetValueEx(m_handle, name, 0, keyType, array, lpcbData) != 0)
				{
					throw new ExternalException("Error writing to the RegistryKey");
				}
				break;
			}
			return;
		}
		throw new ObjectDisposedException("The RegistryKey being manipulated is closed (closed keys cannot be accessed).");
	}

	public void DeleteValue(string name)
	{
		DeleteValue(name, throwOnMissingValue: true);
	}

	public void DeleteValue(string name, bool throwOnMissingValue)
	{
		if (m_writable)
		{
			if (CheckHKey())
			{
				if (name == null)
				{
					throw new ArgumentException("name is null");
				}
				int num = CeRegDeleteValue(m_handle, name);
				if (num == 87 && throwOnMissingValue)
				{
					throw new ArgumentException("name is not a valid reference to a value (and throwOnMissingValue is true) or name is null");
				}
				return;
			}
			throw new ObjectDisposedException("The RegistryKey being manipulated is closed (closed keys cannot be accessed).");
		}
		throw new UnauthorizedAccessException("Cannot delete a value from a RegistryKey opened as ReadOnly.");
	}

	public string[] GetValueNames()
	{
		if (CheckHKey())
		{
			ArrayList arrayList = new ArrayList();
			int num = 0;
			char[] array = new char[256];
			int iValueNameLen = array.Length;
			while (CeRegEnumValue(m_handle, num, array, ref iValueNameLen, 0, 0, null, 0) != 259)
			{
				arrayList.Add(new string(array));
				num++;
				iValueNameLen = array.Length;
			}
			arrayList.Sort();
			return (string[])arrayList.ToArray(typeof(string));
		}
		throw new ObjectDisposedException("The RegistryKey being manipulated is closed (closed keys cannot be accessed).");
	}

	private bool CheckHKey()
	{
		if (m_handle == 0)
		{
			return false;
		}
		return true;
	}

	public void Dispose()
	{
		Close();
	}

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int CeRegOpenKeyEx(uint hKey, string lpSubKey, int ulOptions, int samDesired, ref uint phkResult);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int CeRegCreateKeyEx(uint hKey, string lpSubKey, int lpReserved, string lpClass, int dwOptions, int samDesired, IntPtr lpSecurityAttributes, ref uint phkResult, ref uint lpdwDisposition);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int CeRegEnumKeyEx(uint hKey, int iIndex, char[] sKeyName, ref int iKeyNameLen, int iReservedZero, byte[] sClassName, int iClassNameLenZero, int iFiletimeZero);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int CeRegEnumValue(uint hKey, int iIndex, char[] sValueName, ref int iValueNameLen, int iReservedZero, int iTypeZero, byte[] byData, int iDataLenZero);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int CeRegQueryInfoKey(uint hKey, char[] lpClass, ref int lpcbClass, int reservedZero, out int cSubkey, out int iMaxSubkeyLen, out int lpcbMaxSubkeyClassLen, out int cValueNames, out int iMaxValueNameLen, out int iMaxValueLen, int securityDescriptorZero, int lastWriteTimeZero);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int CeRegQueryValueEx(uint hKey, string lpValueName, int lpReserved, ref KeyType lpType, byte[] lpData, ref int lpcbData);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int CeRegSetValueEx(uint hKey, string lpValueName, int lpReserved, KeyType lpType, byte[] lpData, int lpcbData);

	[DllImport("rapi.dll", SetLastError = true)]
	private static extern int CeRegCloseKey(uint hKey);

	[DllImport("rapi.dll", SetLastError = true)]
	private static extern int CeRegDeleteKey(uint hKey, string keyName);

	[DllImport("rapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int CeRegDeleteValue(uint hKey, string valueName);
}
