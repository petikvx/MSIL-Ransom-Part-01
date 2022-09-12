using System.Runtime.InteropServices;
using stdole;

[ComImport]
[Guid("BEF6E003-A874-101A-8BBA-00AA00300CAB")]
[CoClass(typeof(StdFontClass))]
public interface StdFont : Font, FontEvents_Event
{
}
