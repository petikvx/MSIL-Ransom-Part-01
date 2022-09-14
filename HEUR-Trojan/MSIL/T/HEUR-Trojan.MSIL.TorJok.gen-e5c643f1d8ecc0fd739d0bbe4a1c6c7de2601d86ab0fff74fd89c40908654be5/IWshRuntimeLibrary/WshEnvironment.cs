using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[Guid("F935DC29-1CF0-11D0-ADB9-00C04FD58A0B")]
[CoClass(typeof(WshEnvironmentClass))]
public interface WshEnvironment : IWshEnvironment
{
}
