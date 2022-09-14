using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
[CoClass(typeof(IWshShell_ClassClass))]
public interface IWshShell_Class : IWshShell3
{
}
