using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[CoClass(typeof(IWshNetwork_ClassClass))]
[Guid("24BE5A31-EDFE-11D2-B933-00104B365C9F")]
public interface IWshNetwork_Class : IWshNetwork2
{
}
