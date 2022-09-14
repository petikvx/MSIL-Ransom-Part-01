using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[CoClass(typeof(IWshShortcut_ClassClass))]
[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
public interface IWshShortcut_Class : IWshShortcut
{
}
