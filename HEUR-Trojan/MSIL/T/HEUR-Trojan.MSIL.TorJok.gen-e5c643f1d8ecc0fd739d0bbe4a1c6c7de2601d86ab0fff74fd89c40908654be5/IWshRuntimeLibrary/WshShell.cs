using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[CoClass(typeof(WshShellClass))]
[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
public interface WshShell : IWshShell3
{
}
