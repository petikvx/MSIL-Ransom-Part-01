using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[CoClass(typeof(IWshEnvironment_ClassClass))]
[Guid("F935DC29-1CF0-11D0-ADB9-00C04FD58A0B")]
public interface IWshEnvironment_Class : IWshEnvironment
{
}
