using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[CoClass(typeof(FoldersClass))]
[Guid("C7C3F5A3-88A3-11D0-ABCB-00A0C90FFFC0")]
public interface Folders : IFolderCollection
{
}
