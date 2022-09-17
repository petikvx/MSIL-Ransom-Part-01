using System.Drawing;

namespace Snakes_and_Ladders;

public static class Images
{
	private static Bitmap[] dieImages;

	static Images()
	{
		dieImages = (Bitmap[])(object)new Bitmap[7];
		for (int i = 1; i < dieImages.Length; i++)
		{
			string text = "Face_";
			text += i;
			dieImages[i] = LoadImage("Dice", text);
		}
	}

	public static Bitmap GetDieImage(int faceValue)
	{
		return dieImages[faceValue];
	}

	private static Bitmap LoadImage(string subfolderName, string imageName)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		string text = $".\\Images\\{subfolderName}\\{imageName}.png";
		return new Bitmap(text);
	}
}
