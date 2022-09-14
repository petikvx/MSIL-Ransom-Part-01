using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[CoClass(typeof(WshNetworkClass))]
[Guid("24BE5A31-EDFE-11D2-B933-00104B365C9F")]
public interface WshNetwork : IWshNetwork2
{
}
