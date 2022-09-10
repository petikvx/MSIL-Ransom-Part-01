namespace OpenNETCF.Desktop.Communication;

public sealed class CERegistry
{
	public static readonly CERegistryKey LocalMachine = new CERegistryKey(2147483650u, "\\HKEY_LOCAL_MACHINE", writable: true, isroot: true);

	public static readonly CERegistryKey CurrentUser = new CERegistryKey(2147483649u, "\\HKEY_CURRENT_USER", writable: true, isroot: true);

	public static readonly CERegistryKey ClassesRoot = new CERegistryKey(2147483648u, "\\HKEY_CLASSES_ROOT", writable: true, isroot: true);

	public static readonly CERegistryKey Users = new CERegistryKey(2147483651u, "\\HKEY_USERS", writable: true, isroot: true);
}
