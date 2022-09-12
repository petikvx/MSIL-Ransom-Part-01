using InstagramApiSharp.API;

namespace InstagramApiSharp.Classes.SessionHandlers;

public interface ISessionHandler
{
	IInstaApi InstaApi { get; set; }

	string FilePath { get; set; }

	void Load();

	void Save();
}
