using System.Windows.Forms;

namespace BirdHuntingGame.Code;

public class BirdBox : PictureBox
{
	public string Status { get; set; }

	public string Direction { get; set; }

	public BirdBox()
	{
		Status = "Alive";
		Direction = "Forward";
	}
}
