using System.Collections.Generic;

namespace youknowcaliber.Edge;

internal sealed class Bookmarks
{
	public static extern List<Bookmark> Get(string sBookmarks);

	public extern Bookmarks();
}
