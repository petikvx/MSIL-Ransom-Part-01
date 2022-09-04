using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("729FE2F8-1EA8-11D1-8F85-00C04FC2FBE1")]
[CoClass(typeof(ShellUIHelperClass))]
public interface ShellUIHelper : IShellUIHelper
{
}
