using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("EAB22AC1-30C1-11CF-A7EB-0000C05BAE0B")]
[CoClass(typeof(WebBrowser_V1Class))]
public interface WebBrowser_V1 : IWebBrowser, DWebBrowserEvents_Event
{
}
