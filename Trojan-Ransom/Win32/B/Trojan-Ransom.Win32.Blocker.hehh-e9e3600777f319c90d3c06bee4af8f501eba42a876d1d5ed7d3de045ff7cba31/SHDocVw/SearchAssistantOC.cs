using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[CoClass(typeof(SearchAssistantOCClass))]
[Guid("72423E8F-8011-11D2-BE79-00A0C9A83DA3")]
public interface SearchAssistantOC : ISearchAssistantOC3, _SearchAssistantEvents_Event
{
}
