using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("72423E8F-8011-11D2-BE79-00A0C9A83DA3")]
[CoClass(typeof(ShellSearchAssistantOCClass))]
public interface ShellSearchAssistantOC : ISearchAssistantOC3, _SearchAssistantEvents_Event
{
}
