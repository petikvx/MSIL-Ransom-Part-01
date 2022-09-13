using System.Collections.Generic;

namespace youknowcaliber.Chromium;

internal sealed class Bookmarks
{
	public static extern List<Bookmark> Get(string sBookmarks);

	public extern Bookmarks();
}
