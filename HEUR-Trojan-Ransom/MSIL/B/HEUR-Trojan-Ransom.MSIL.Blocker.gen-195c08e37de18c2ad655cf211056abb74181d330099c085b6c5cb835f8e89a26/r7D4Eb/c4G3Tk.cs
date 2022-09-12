using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Ba95Nn;
using Microsoft.VisualBasic.CompilerServices;

namespace r7D4Eb;

[DesignerGenerated]
public class c4G3Tk : Form
{
	internal sealed class n7E4Ze
	{
		internal SqlConnection j;

		internal object x;

		internal object M;

		internal object I;

		internal object u;

		internal object T;

		internal object L;

		internal object S;

		internal object c;

		internal object Q;

		internal object V;

		internal n7E4Ze()
		{
		}
	}

	private n6R9Wx.d5ZJx9 J;

	public c4G3Tk()
	{
		Yx28Xq();
	}

	protected override void Ep01Kd(bool bool_0)
	{
		try
		{
			if (bool_0 && J.c != null)
			{
				J.c.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(bool_0);
		}
	}

	private void Yx28Xq()
	{
		object obj = new Container();
		J.c = obj as IContainer;
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Form)this).set_Text("Form1");
	}
}
