using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[CoClass(typeof(DrivesClass))]
[Guid("C7C3F5A1-88A3-11D0-ABCB-00A0C90FFFC0")]
public interface Drives : IDriveCollection
{
}
