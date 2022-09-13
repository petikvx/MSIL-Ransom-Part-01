namespace youknowcaliber;

public class GetFiles
{
	public class Folders : IFolders
	{
		public extern string Source { get; private set; }

		public extern string Target { get; private set; }

		public extern Folders(string source, string target);
	}

	public extern GetFiles();
}
