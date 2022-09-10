using System.Runtime.InteropServices;

namespace Microsoft.Tools.RegAsm;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("00020406-0000-0000-C000-000000000046")]
[ComVisible(false)]
internal interface ICreateITypeLib
{
	void CreateTypeInfo();

	void SetName();

	void SetVersion();

	void SetGuid();

	void SetDocString();

	void SetHelpFileName();

	void SetHelpContext();

	void SetLcid();

	void SetLibFlags();

	void SaveAllChanges();
}
