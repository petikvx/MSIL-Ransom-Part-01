using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
[CoClass(typeof(InternetExplorerClass))]
public interface InternetExplorer : IWebBrowser2, DWebBrowserEvents2_Event
{
}
