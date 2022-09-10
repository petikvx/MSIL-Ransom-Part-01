using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class ______________________________________________________________________ : Form
{
	private IContainer m__;

	[AccessedThroughProperty("chatBox")]
	private RichTextBox m___;

	[AccessedThroughProperty("inputBox")]
	private TextBox m____;

	[AccessedThroughProperty("getChat")]
	private Timer ____;

	public string _____;

	internal virtual RichTextBox _
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

	internal virtual TextBox __
	{
		get
		{
			return this.m____;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(__________);
			if (this.m____ != null)
			{
				((Control)this.m____).remove_KeyDown(val);
			}
			this.m____ = value;
			if (this.m____ != null)
			{
				((Control)this.m____).add_KeyDown(val);
			}
		}
	}

	internal virtual Timer ___
	{
		get
		{
			return ____;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ___________;
			if (____ != null)
			{
				____.remove_Tick(eventHandler);
			}
			____ = value;
			if (____ != null)
			{
				____.add_Tick(eventHandler);
			}
		}
	}

	public ______________________________________________________________________()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)________);
		((Form)this).add_FormClosing(new FormClosingEventHandler(_________));
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

	[DebuggerStepThrough]
	private unsafe void _()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		this.m__ = new Container();
		this._ = new RichTextBox();
		__ = new TextBox();
		nint num = (nint)Type.EmptyTypes.LongLength + 8;
		int num4 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				___ = new Timer(this.m__);
				((Control)this).SuspendLayout();
				num = (nint)Type.EmptyTypes.LongLength + 0;
				break;
			case 7:
			{
				((Control)__).set_Name(_003CModule_003E._____<string>(218222871u));
				TextBox obj4 = __;
				Size size = new Size(433, 20);
				((Control)obj4).set_Size(size);
				num = ((((num4 * 1024) & -597377024) == ((628 * num4 + num4 * 396) & -597377024)) ? ((nint)Type.EmptyTypes.LongLength + 4) : (-1883304853));
				break;
			}
			case 6:
				((Control)this).get_Controls().Add((Control)(object)__);
				((Control)this).get_Controls().Add((Control)(object)this._);
				if (num2 != -9358)
				{
					goto IL_00e9;
				}
				goto case 4;
			case 4:
			{
				((Control)__).set_TabIndex(1);
				SizeF autoScaleDimensions = new SizeF(6f, 13f);
				((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
				num = sizeof(ushort) + 1;
				break;
			}
			case 3:
			{
				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
				Size size = new Size(441, 353);
				((Form)this).set_ClientSize(size);
				num2 = (int)((nint)Type.EmptyTypes.LongLength + -13792);
				num = (nint)Type.EmptyTypes.LongLength + 6;
				break;
			}
			case 2:
				((Control)this._).set_Name(_003CModule_003E.______<string>(3068409415u));
				((TextBoxBase)this._).set_ReadOnly(true);
				num2 = (int)((nint)Type.EmptyTypes.LongLength + -22855);
				num4 = 1;
				num = num4;
				break;
			case 1:
			{
				RichTextBox obj2 = this._;
				Size size = new Size(433, 318);
				((Control)obj2).set_Size(size);
				int num3 = num2;
				num2 = -28555;
				if (num3 != -22855)
				{
					goto IL_00e9;
				}
				((Control)this._).set_TabIndex(2);
				this._.set_Text(_003CModule_003E.__________(sizeof(long) + 11597, 10018, 59));
				if (num2 != 16053)
				{
					TextBox obj3 = __;
					Point location = new Point(2, 326);
					((Control)obj3).set_Location(location);
					num = sizeof(int) + 3;
					break;
				}
				goto case 7;
			}
			case 0:
			{
				RichTextBox obj = this._;
				Point location = new Point(2, 2);
				((Control)obj).set_Location(location);
				num = (nint)Type.EmptyTypes.LongLength + 2;
				break;
			}
			case 5:
				{
					((Control)this).set_Name(_003CModule_003E._____<string>(1493608640u));
					((Form)this).set_StartPosition((FormStartPosition)1);
					((Form)this).set_Text(_003CModule_003E.______<string>(2401268177u));
					((Control)this).ResumeLayout(false);
					((Control)this).PerformLayout();
					return;
				}
				IL_00e9:
				((Form)this).set_FormBorderStyle((FormBorderStyle)3);
				((Form)this).set_MaximizeBox(false);
				((Form)this).set_MinimizeBox(false);
				num = ((2018 + num2 * 1396965376 != -8211) ? ((nint)Type.EmptyTypes.LongLength + 5) : ((nint)Type.EmptyTypes.LongLength + 2133154395));
				break;
			}
		}
	}

	private void ________(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool num5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool num6);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 158:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0026;
						case 4:
							goto IL_0035;
						case 5:
							goto IL_0048;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0048:
					num = 5;
					((Form)this).set_Text(_003CModule_003E.___<string>(572214184u) + _____);
					break;
					IL_0007:
					num = 2;
					___.Start();
					switch ((nint)Type.EmptyTypes.LongLength + 0)
					{
					}
					goto IL_0026;
					IL_0026:
					num = 3;
					((Control)__).Focus();
					goto IL_0035;
					IL_0035:
					num = 4;
					((TextBoxBase)this._).set_BackColor(Color.White);
					goto IL_0048;
					end_IL_0000_2:
					break;
				}
				num = 6;
				((Form)this).set_TopMost(true);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				num5 = obj is Exception && num3 != 0;
				num6 = num2 == 0;
				_003CModule_003E._________________ = num3;
				return num5 && num6;
			}).Invoke())
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 158;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			_003CModule_003E.______________ = 796469985;
			ProjectData.ClearProjectError();
		}
	}

	private void _________(object sender, FormClosingEventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
				case 46:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				((CancelEventArgs)(object)e).Cancel = true;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 46;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private unsafe void __________(object sender, KeyEventArgs e)
	{
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Invalid comparison between Unknown and I4
		try
		{
			int num = default(int);
			int num5 = default(int);
			int ______ = default(int);
			while ((int)e.get_KeyCode() == 13)
			{
				e.set_SuppressKeyPress(true);
				int num2;
				nint num3;
				if (((6285 + 1064 * num + num * 984) & 0x54F) == 13)
				{
					num2 = sizeof(float) + -3;
					num3 = num2;
				}
				else
				{
					num2 = sizeof(ulong) + 1303441560;
					num3 = num2;
				}
				while (true)
				{
					switch (num3)
					{
					case 3:
						__________________________________.____________ = -1645271601;
						__.set_Text(__.get_Text().Replace(_003CModule_003E.___<string>(2677394803u), string.Empty));
						num = sizeof(ushort) + 32343;
						num3 = (nint)Type.EmptyTypes.LongLength + 0;
						continue;
					case 0:
					{
						num = 32345;
						int num4 = _003CModule_003E.__________;
						if ((0x10u & (uint)(((8069 + num4) * 16) ^ (5402 + 153552 * num4))) != 0)
						{
						}
						______________________________________________________________.___________(_003CModule_003E.______<string>(1053168784u) + __.get_Text() + _003CModule_003E._______<string>(1974200954u));
						if (num == 22535)
						{
							break;
						}
						this._.set_Text(this._.get_Text() + _003CModule_003E.____<string>(2062874770u) + __.get_Text() + _003CModule_003E.___<string>(1108583536u));
						if (118 * ______ + 1930 * ______ == -1697271203)
						{
							if ((______ << 9) + 182816 != 16 * ((num5 << 7) + 3036))
							{
							}
							goto default;
						}
						goto IL_018d;
					}
					default:
						if (__.get_Text().Contains(_003CModule_003E._____<string>(1052623516u)))
						{
							num3 = (nint)Type.EmptyTypes.LongLength + 3;
							continue;
						}
						goto case 0;
					case 2:
					{
						TextBox obj = __;
						______ = ______________________._______;
						obj.set_Text(_003CModule_003E.__________((int)((((32768 * ______) | -105) == -105) ? (sizeof(ulong) + 51624) : ((nint)Type.EmptyTypes.LongLength + 1719516878)), (int)((nint)Type.EmptyTypes.LongLength + 51160), (int)((nint)Type.EmptyTypes.LongLength + 109)));
						((TextBoxBase)this._).set_SelectionStart(this._.get_Text().Length);
						((TextBoxBase)this._).ScrollToCaret();
						return;
					}
					}
					break;
					IL_018d:
					num3 = sizeof(double) + -6;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private unsafe void ___________(object sender, EventArgs e)
	{
		try
		{
			((Control)this).BringToFront();
			if (!______________________________________________________________._________________________)
			{
				Application.ExitThread();
			}
			if (Operators.CompareString(_________________________________________________________________._, _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 15388), (int)((nint)Type.EmptyTypes.LongLength + 13845), sizeof(ulong) + 133), false) == 0)
			{
				return;
			}
			int num = sizeof(double) + 25595;
			nint num2 = (nint)Type.EmptyTypes.LongLength + 0;
			while (true)
			{
				switch (num2)
				{
				default:
					while (Operators.CompareString(_________________________________________________________________._, _003CModule_003E.___<string>(1277940466u), false) == 0)
					{
						if (num != 10456)
						{
							((Form)this).Close();
							Application.ExitThread();
							break;
						}
					}
					break;
				case 1:
				{
					nint num3 = (nint)Type.EmptyTypes.LongLength + 46429;
					int num4 = _003CModule_003E.__________;
					_________________________________________________________________._ = _003CModule_003E.__________(48255, (int)num3, (int)(((0x1900 & ((uint)num4 / 67108864u)) == 0) ? 15 : ((~(-(num4 * -1503395840)) == 262144 * num4) ? ((nint)Type.EmptyTypes.LongLength + -1850472152) : ((nint)Type.EmptyTypes.LongLength + 369414464))));
					((TextBoxBase)this._).set_SelectionStart(this._.get_Text().Length);
					((TextBoxBase)this._).ScrollToCaret();
					return;
				}
				}
				this._.set_Text(this._.get_Text() + _____ + _003CModule_003E._____<string>(1155842849u) + _________________________________________________________________._ + _003CModule_003E._______<string>(4016157841u));
				num2 = 1;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
