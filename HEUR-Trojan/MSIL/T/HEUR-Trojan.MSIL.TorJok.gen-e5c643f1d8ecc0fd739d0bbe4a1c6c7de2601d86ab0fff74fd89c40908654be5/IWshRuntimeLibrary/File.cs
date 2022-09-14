using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[Guid("C7C3F5A4-88A3-11D0-ABCB-00A0C90FFFC0")]
[CoClass(typeof(FileClass))]
public interface File : IFile
{
}
