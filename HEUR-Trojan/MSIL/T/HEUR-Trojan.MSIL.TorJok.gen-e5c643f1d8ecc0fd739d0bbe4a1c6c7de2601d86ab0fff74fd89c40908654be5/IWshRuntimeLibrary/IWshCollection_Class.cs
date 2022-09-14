using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[CoClass(typeof(IWshCollection_ClassClass))]
[Guid("F935DC27-1CF0-11D0-ADB9-00C04FD58A0B")]
public interface IWshCollection_Class : IWshCollection
{
}
