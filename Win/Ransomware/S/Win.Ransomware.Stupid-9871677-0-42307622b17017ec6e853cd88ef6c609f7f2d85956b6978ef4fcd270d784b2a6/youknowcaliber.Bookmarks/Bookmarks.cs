using System.Collections.Generic;

namespace youknowcaliber.Bookmarks;

internal class Bookmarks
{
	public static extern List<Bookmark> Get(string BrowserDir);

	public extern Bookmarks();
}
