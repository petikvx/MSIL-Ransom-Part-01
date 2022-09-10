using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class _____________________________________________________________ : Form
{
	private IContainer m__;

	[AccessedThroughProperty("l")]
	private Label m___;

	[AccessedThroughProperty("b")]
	private Button ___;

	internal virtual Label _
	{
		get
		{
			return this.m___;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m___ = value;
		}
	}

	internal virtual Button __
	{
		get
		{
			return ___;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ______;
			if (___ != null)
			{
				((Control)___).remove_Click(eventHandler);
			}
			___ = value;
			if (___ != null)
			{
				((Control)___).add_Click(eventHandler);
			}
		}
	}

	public _____________________________________________________________()
	{
		_();
	}

	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.m__ != null)
			{
				this.m__.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private unsafe void _()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		int ______________ = default(int);
		int num2 = default(int);
		Padding margin = default(Padding);
		while (true)
		{
			this._ = new Label();
			__ = new Button();
			((Control)this).SuspendLayout();
			nint num = (nint)Type.EmptyTypes.LongLength + 4;
			while (true)
			{
				switch (num)
				{
				case 7:
				{
					((Control)this._).set_Name(_003CModule_003E.____<string>(2567499604u));
					Label obj6 = this._;
					Size size = new Size(192, 20);
					((Control)obj6).set_Size(size);
					______________ = _003CModule_003E._______________;
					if ((0xE0000000u & ((uint)______________ % 443397530u)) != 0 || num2 != -22051)
					{
						((Control)this._).set_TabIndex(0);
						this._.set_Text(_003CModule_003E.____<string>(1419836613u));
						num = (nint)Type.EmptyTypes.LongLength + 0;
						break;
					}
					goto case 1;
				}
				case 1:
				{
					Label obj4 = this._;
					((Padding)(ref margin))._002Ector(4, 0, 4, 0);
					((Control)obj4).set_Margin(margin);
					num2 = (int)((nint)Type.EmptyTypes.LongLength + 21781);
					num = (nint)Type.EmptyTypes.LongLength + 7;
					break;
				}
				case 6:
					((Control)this).get_Controls().Add((Control)(object)__);
					((Control)this).get_Controls().Add((Control)(object)this._);
					num = sizeof(int) + -2;
					break;
				case 5:
				{
					((Control)__).set_TabIndex(1);
					((ButtonBase)__).set_Text(_003CModule_003E.___<string>(2758317222u));
					int num3 = num2;
					num2 = -15706;
					if (num3 != 2848)
					{
						((ButtonBase)__).set_UseVisualStyleBackColor(true);
						SizeF autoScaleDimensions = new SizeF(9f, 20f);
						((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
						if (num2 == -6710 && 16726 != ______________ * 10 + 5433 + ______________ * 6)
						{
							goto end_IL_0269;
						}
					}
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					Size size = new Size(426, 148);
					((Form)this).set_ClientSize(size);
					goto case 6;
				}
				default:
				{
					this._.set_AutoSize(true);
					Label obj5 = this._;
					Point location = new Point(120, 12);
					((Control)obj5).set_Location(location);
					num = sizeof(byte) + 0;
					break;
				}
				case 3:
				{
					Button obj2 = __;
					((Padding)(ref margin))._002Ector(4, 5, 4, 5);
					((Control)obj2).set_Margin(margin);
					if (num2 == -22110)
					{
						int _________ = _003CModule_003E.__________;
						if (-(_________ * 1879048192) != -812169384)
						{
							goto case 1;
						}
					}
					((Control)__).set_Name(_003CModule_003E.____<string>(3878451389u));
					Button obj3 = __;
					Size size = new Size(390, 98);
					((Control)obj3).set_Size(size);
					num2 = (int)((nint)Type.EmptyTypes.LongLength + 21981);
					num = sizeof(float) + 1;
					break;
				}
				case 0:
				{
					Button obj = __;
					Point location = new Point(18, 38);
					((Control)obj).set_Location(location);
					num2 = sizeof(float) + -6962;
					goto case 3;
				}
				case 2:
					((Form)this).set_FormBorderStyle((FormBorderStyle)3);
					((Padding)(ref margin))._002Ector(4, 5, 4, 5);
					((Form)this).set_Margin(margin);
					((Form)this).set_MaximizeBox(false);
					((Form)this).set_MinimizeBox(false);
					((Control)this).set_Name(_003CModule_003E.___<string>(1346864658u));
					((Control)this).ResumeLayout(false);
					((Control)this).PerformLayout();
					return;
				}
				continue;
				end_IL_0269:
				break;
			}
		}
	}

	private void ______(object sender, EventArgs e)
	{
		_____________________________________________________________________________.____________();
	}
}
