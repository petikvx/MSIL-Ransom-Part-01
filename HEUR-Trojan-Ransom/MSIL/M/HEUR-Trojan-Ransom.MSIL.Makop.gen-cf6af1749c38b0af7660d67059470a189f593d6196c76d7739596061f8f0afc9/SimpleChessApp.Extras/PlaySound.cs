using System.Media;

namespace SimpleChessApp.Extras;

public static class PlaySound
{
	private static SoundPlayer wmp;

	public static void Play()
	{
		PlaySound.smethod_0(wmp);
	}

	static void smethod_0(SoundPlayer soundPlayer_0)
	{
		soundPlayer_0.Play();
	}
}
