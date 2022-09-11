using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns1;

[DesignerGenerated]
public class chatopcoes : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("LinkLabel2")]
	private LinkLabel _LinkLabel2;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual LinkLabel LinkLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
			if (_LinkLabel2 != null)
			{
				_LinkLabel2.remove_LinkClicked(val);
			}
			_LinkLabel2 = value;
			if (_LinkLabel2 != null)
			{
				_LinkLabel2.add_LinkClicked(val);
			}
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.remove_LinkClicked(val);
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.add_LinkClicked(val);
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = TextBox1_TextChanged;
			KeyEventHandler val = new KeyEventHandler(TextBox1_KeyDown);
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).remove_TextChanged(eventHandler);
				((Control)_TextBox1).remove_KeyDown(val);
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).add_TextChanged(eventHandler);
				((Control)_TextBox1).add_KeyDown(val);
			}
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	[DebuggerNonUserCode]
	public chatopcoes()
	{
		((Form)this).add_Load((EventHandler)Form12_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(chatopcoes));
		GroupBox2 = new GroupBox();
		LinkLabel2 = new LinkLabel();
		LinkLabel1 = new LinkLabel();
		GroupBox1 = new GroupBox();
		Label2 = new Label();
		Button1 = new Button();
		TextBox1 = new TextBox();
		Label1 = new Label();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox2).get_Controls().Add((Control)(object)LinkLabel2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)GroupBox2).set_Dock((DockStyle)1);
		((Control)GroupBox2).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox = GroupBox2;
		Point location = new Point(0, 142);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox2 = GroupBox2;
		Size size = new Size(358, 122);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox2).set_TabIndex(3);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Informações e link:");
		((Label)LinkLabel2).set_AutoSize(true);
		((Control)LinkLabel2).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		LinkLabel linkLabel = LinkLabel2;
		location = new Point(57, 71);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel2).set_Name("LinkLabel2");
		LinkLabel linkLabel2 = LinkLabel2;
		size = new Size(218, 29);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel2).set_TabIndex(1);
		LinkLabel2.set_TabStop(true);
		LinkLabel2.set_Text("Excluir esta conta");
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		LinkLabel linkLabel3 = LinkLabel1;
		location = new Point(57, 31);
		((Control)linkLabel3).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel4 = LinkLabel1;
		size = new Size(243, 29);
		((Control)linkLabel4).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(0);
		LinkLabel1.set_TabStop(true);
		LinkLabel1.set_Text("Sair da minha conta");
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).set_Dock((DockStyle)1);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox3 = GroupBox1;
		location = new Point(0, 0);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox4 = GroupBox1;
		size = new Size(358, 142);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox1).set_TabIndex(2);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Minha Conta.");
		Label2.set_AutoSize(true);
		Label label = Label2;
		location = new Point(230, 23);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		size = new Size(19, 29);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text(".");
		((Control)Label2).set_Visible(false);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button = Button1;
		location = new Point(227, 90);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(119, 35);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Ok");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)TextBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox textBox = TextBox1;
		location = new Point(17, 58);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(329, 26);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label1;
		location = new Point(13, 34);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(170, 20);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Editar ou mudar nome:");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		size = new Size(358, 289);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		size = new Size(374, 328);
		((Form)this).set_MaximumSize(size);
		((Form)this).set_MinimizeBox(false);
		size = new Size(374, 328);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("chatopcoes");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SATWNEYT CHAT OPÇÕES DA CONTA");
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_KeyCode() == 8)
		{
			((TextBoxBase)TextBox1).set_ReadOnly(false);
			Label2.set_Text("b");
		}
		if ((int)e.get_KeyCode() == 13)
		{
			Label2.set_Text("a");
		}
		if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) & ((int)e.get_KeyCode() == 13))
		{
			Interaction.MsgBox((object)"Digite seu nome !!!", (MsgBoxStyle)48, (object)null);
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		MyProject.Forms.chatdesk.TextBox1.set_Text(TextBox1.get_Text());
		MyProject.Forms.chatdesk.Label7.set_Text(TextBox1.get_Text());
		if (((double)TextBox1.get_Text().Count() > Conversions.ToDouble("23")) & (Operators.CompareString(Label2.get_Text(), "a", false) == 0))
		{
			((TextBoxBase)TextBox1).set_ReadOnly(true);
			((TextBoxBase)TextBox1).set_BackColor(Color.White);
			Interaction.MsgBox((object)"ATENÇÃO: No maxímo de linhas para digitar seu nome é 23 ", (MsgBoxStyle)48, (object)null);
			Label2.set_Text("b");
			((TextBoxBase)TextBox1).set_ReadOnly(true);
		}
		if ((double)TextBox1.get_Text().Count() > Conversions.ToDouble("24"))
		{
			((TextBoxBase)TextBox1).set_ReadOnly(true);
			((TextBoxBase)TextBox1).set_BackColor(Color.White);
		}
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Form)this).Close();
		((Control)MyProject.Forms.chatdesk).Show();
		((Control)MyProject.Forms.chatdesk.Panel3).set_Visible(true);
		((TextBoxBase)MyProject.Forms.chatdesk.RichTextBox2).Clear();
		TextBox1.set_Text("");
		MyProject.Forms.chatdesk.TextBox1.set_Text("");
	}

	private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		MsgBoxResult val = Interaction.MsgBox((object)"Você tem certeza quer excluir sua conta ???", (MsgBoxStyle)68, (object)null);
		if ((int)val == 6)
		{
			((Form)this).Close();
			((Control)MyProject.Forms.chatdesk).Show();
			((Control)MyProject.Forms.chatdesk.Panel3).set_Visible(true);
			((TextBoxBase)MyProject.Forms.chatdesk.RichTextBox2).Clear();
			TextBox1.set_Text("");
			MyProject.Forms.chatdesk.TextBox1.set_Text("");
		}
	}

	private void Form12_Load(object sender, EventArgs e)
	{
		TextBox1.set_Text(MyProject.Forms.chatdesk.Label7.get_Text());
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox1.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Digite seu nome !!!", (MsgBoxStyle)48, (object)null);
			return;
		}
		((Form)this).Close();
		try
		{
			MyProject.Forms.chatdesk.Label7.set_Text(TextBox1.get_Text());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
