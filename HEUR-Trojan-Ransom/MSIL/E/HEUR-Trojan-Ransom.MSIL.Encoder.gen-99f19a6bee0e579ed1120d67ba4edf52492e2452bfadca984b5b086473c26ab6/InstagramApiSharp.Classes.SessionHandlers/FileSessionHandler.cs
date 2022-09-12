using System.IO;
using InstagramApiSharp.API;

namespace InstagramApiSharp.Classes.SessionHandlers;

public class FileSessionHandler : ISessionHandler
{
	public IInstaApi InstaApi { get; set; }

	public string FilePath { get; set; }

	public void Load()
	{
		if (File.Exists(FilePath))
		{
			using (FileStream data = File.OpenRead(FilePath))
			{
				InstaApi.LoadStateDataFromStream(data);
			}
		}
	}

	public void Save()
	{
		using Stream stream = InstaApi.GetStateDataAsStream();
		using FileStream destination = File.Create(FilePath);
		stream.Seek(0L, SeekOrigin.Begin);
		stream.CopyTo(destination);
	}
}
