using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MiniGameEngine;

public class ClassPictures
{
	public int X;

	public int Y;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBoxCard")]
	[CompilerGenerated]
	private PictureBox pictureBox_0;

	public virtual PictureBox PictureBoxCard
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_0 = value;
		}
	}

	public static string String_0 => "55544638456E636F64";

	public static string String_1 => "497758784579";

	public ClassPictures(int X, int Y, PictureBox PictureBoxCard)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		this.X = X;
		this.Y = Y;
		this.PictureBoxCard = PictureBoxCard;
	}

	public void PictureBoxCard_MouseClick(object sender, MouseEventArgs e)
	{
	}

	public static object ParamF()
	{
		return new object[3];
	}
}
