using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace WindowsFormsApplication1;

public class loading_form : Form
{
	private int recomended_size = 3554;

	public static Thread thread1;

	private IContainer components = null;

	private MetroProgressBar progressBar1;

	private MetroLabel metroLabel1;

	private MetroLabel metroLabel2;

	public PictureBox pictureBox1;

	public loading_form()
	{
		InitializeComponent();
		Form1.ld = this;
		pictureBox1.set_ImageLocation(update_app.folder_path + "\\giphy.gif");
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		((ProgressBar)progressBar1).set_Maximum(recomended_size);
		thread1 = new Thread((ThreadStart)delegate
		{
			CaluculateAll((ProgressBar)(object)progressBar1);
		});
		thread1.Start();
	}

	public void close_this_form()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		try
		{
			thread1.Abort();
		}
		catch
		{
		}
		try
		{
			object obj2 = _003C_003Ec._003C_003E9__3_0;
			if (obj2 == null)
			{
				MethodInvoker val = delegate
				{
					thread1.Abort();
				};
				obj2 = (object)val;
				_003C_003Ec._003C_003E9__3_0 = val;
			}
			((Control)this).Invoke((Delegate)obj2);
		}
		catch
		{
		}
		((Control)this).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Form)this).Close();
		});
	}

	public static long DirSize(DirectoryInfo d)
	{
		long num = 0L;
		FileInfo[] files = d.GetFiles();
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			num += fileInfo.Length;
		}
		DirectoryInfo[] directories = d.GetDirectories();
		DirectoryInfo[] array2 = directories;
		foreach (DirectoryInfo d2 in array2)
		{
			num += DirSize(d2);
		}
		return num;
	}

	private void CaluculateAll(ProgressBar progressBar)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005d: Expected O, but got Unknown
		MethodInvoker val = default(MethodInvoker);
		while (true)
		{
			try
			{
				int num = Convert.ToInt32(DirSize(new DirectoryInfo(Directory.GetCurrentDirectory())));
				num /= 100000;
				Math.Pow(num, num);
				try
				{
					ProgressBar obj = progressBar;
					MethodInvoker obj2 = val;
					if (obj2 == null)
					{
						MethodInvoker val2 = delegate
						{
							progressBar.PerformStep();
						};
						MethodInvoker val3 = val2;
						val = val2;
						obj2 = val3;
					}
					((Control)obj).Invoke((Delegate)(object)obj2);
				}
				catch
				{
					progressBar.PerformStep();
				}
				Thread.Sleep(500);
				if (num >= recomended_size)
				{
					break;
				}
			}
			catch
			{
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(loading_form));
		progressBar1 = new MetroProgressBar();
		metroLabel1 = new MetroLabel();
		pictureBox1 = new PictureBox();
		metroLabel2 = new MetroLabel();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)progressBar1).set_Location(new Point(33, 281));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(259, 23));
		((Control)progressBar1).set_TabIndex(0);
		((Control)metroLabel1).set_AutoSize(true);
		((Control)metroLabel1).set_BackColor(Color.Transparent);
		metroLabel1.FontWeight = MetroLabelWeight.Regular;
		((Control)metroLabel1).set_Location(new Point(94, 307));
		((Control)metroLabel1).set_Name("metroLabel1");
		((Control)metroLabel1).set_Size(new Size(120, 19));
		metroLabel1.Style = MetroColorStyle.Brown;
		((Control)metroLabel1).set_TabIndex(1);
		((Control)metroLabel1).set_Text("Downloading Files");
		metroLabel1.UseStyleColors = true;
		((Control)pictureBox1).set_Dock((DockStyle)5);
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(335, 335));
		pictureBox1.set_TabIndex(2);
		pictureBox1.set_TabStop(false);
		((Control)metroLabel2).set_AutoSize(true);
		((Control)metroLabel2).set_BackColor(Color.Transparent);
		metroLabel2.FontWeight = MetroLabelWeight.Regular;
		((Control)metroLabel2).set_Location(new Point(63, 9));
		((Control)metroLabel2).set_Name("metroLabel2");
		((Control)metroLabel2).set_Size(new Size(205, 19));
		metroLabel2.Style = MetroColorStyle.Brown;
		((Control)metroLabel2).set_TabIndex(3);
		((Control)metroLabel2).set_Text("Welcome to Poshmark Pro Tools");
		metroLabel2.UseStyleColors = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(335, 335));
		((Control)this).get_Controls().Add((Control)(object)metroLabel2);
		((Control)this).get_Controls().Add((Control)(object)metroLabel1);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("loading_form");
		((Control)this).set_Text("loading_form");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
