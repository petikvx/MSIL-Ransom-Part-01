using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using ns0;

namespace ns1;

[DesignerGenerated]
public class Firewall : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Notpause")]
	private Timer _Notpause;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("soft")]
	private Label _soft;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("tipo")]
	private Label _tipo;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("nome")]
	private Label _nome;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("PictureBox10")]
	private PictureBox _PictureBox10;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Picrred_firewall")]
	private PictureBox _Picrred_firewall;

	internal virtual Timer Notpause
	{
		[DebuggerNonUserCode]
		get
		{
			return _Notpause;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Notpause != null)
			{
				_Notpause.remove_Tick(eventHandler);
			}
			_Notpause = value;
			if (_Notpause != null)
			{
				_Notpause.add_Tick(eventHandler);
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
			_TextBox1 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

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

	internal virtual Label soft
	{
		[DebuggerNonUserCode]
		get
		{
			return _soft;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_soft = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label tipo
	{
		[DebuggerNonUserCode]
		get
		{
			return _tipo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tipo = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label nome
	{
		[DebuggerNonUserCode]
		get
		{
			return _nome;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_nome = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
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

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
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

	internal virtual PictureBox PictureBox10
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox10 = value;
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

	internal virtual PictureBox Picrred_firewall
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picrred_firewall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picrred_firewall = value;
		}
	}

	[DebuggerNonUserCode]
	public Firewall()
	{
		((Form)this).add_Load((EventHandler)Form14_Load);
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected O, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected O, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected O, but got Unknown
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected O, but got Unknown
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected O, but got Unknown
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Expected O, but got Unknown
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Firewall));
		Notpause = new Timer(components);
		TextBox1 = new TextBox();
		Label10 = new Label();
		GroupBox2 = new GroupBox();
		soft = new Label();
		Label7 = new Label();
		tipo = new Label();
		Label6 = new Label();
		nome = new Label();
		Label3 = new Label();
		Label2 = new Label();
		GroupBox1 = new GroupBox();
		Button2 = new Button();
		Button1 = new Button();
		PictureBox10 = new PictureBox();
		Label1 = new Label();
		Picrred_firewall = new PictureBox();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)Picrred_firewall).BeginInit();
		((Control)this).SuspendLayout();
		Notpause.set_Enabled(true);
		TextBox textBox = TextBox1;
		Point location = new Point(599, 22);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox textBox2 = TextBox1;
		Size size = new Size(10, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(92);
		((Control)TextBox1).set_Visible(false);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label10;
		location = new Point(119, 52);
		((Control)label).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label2 = Label10;
		size = new Size(116, 24);
		((Control)label2).set_Size(size);
		((Control)Label10).set_TabIndex(91);
		Label10.set_Text("SATWNEYT");
		((Control)GroupBox2).get_Controls().Add((Control)(object)soft);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)tipo);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox2).get_Controls().Add((Control)(object)nome);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox2).set_ForeColor(Color.Navy);
		GroupBox groupBox = GroupBox2;
		location = new Point(8, 142);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox2 = GroupBox2;
		size = new Size(601, 149);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox2).set_TabIndex(90);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Informação e Detalhes das Ameaças");
		soft.set_AutoSize(true);
		((Control)soft).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)soft).set_ForeColor(Color.Black);
		Label obj = soft;
		location = new Point(139, 113);
		((Control)obj).set_Location(location);
		((Control)soft).set_Name("soft");
		Label obj2 = soft;
		size = new Size(133, 24);
		((Control)obj2).set_Size(size);
		((Control)soft).set_TabIndex(5);
		soft.set_Text("Desconhecido");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.FromArgb(0, 0, 192));
		Label label3 = Label7;
		location = new Point(8, 113);
		((Control)label3).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label4 = Label7;
		size = new Size(123, 24);
		((Control)label4).set_Size(size);
		((Control)Label7).set_TabIndex(4);
		Label7.set_Text("SOFTWARE:");
		tipo.set_AutoSize(true);
		((Control)tipo).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)tipo).set_ForeColor(Color.Black);
		Label obj3 = tipo;
		location = new Point(139, 76);
		((Control)obj3).set_Location(location);
		((Control)tipo).set_Name("tipo");
		Label obj4 = tipo;
		size = new Size(272, 24);
		((Control)obj4).set_Size(size);
		((Control)tipo).set_TabIndex(3);
		tipo.set_Text("Site Perigoso / Virus da internet");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.FromArgb(0, 0, 192));
		Label label5 = Label6;
		location = new Point(73, 76);
		((Control)label5).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label6 = Label6;
		size = new Size(58, 24);
		((Control)label6).set_Size(size);
		((Control)Label6).set_TabIndex(2);
		Label6.set_Text("TIPO:");
		nome.set_AutoSize(true);
		((Control)nome).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)nome).set_ForeColor(Color.Black);
		Label obj5 = nome;
		location = new Point(139, 43);
		((Control)obj5).set_Location(location);
		((Control)nome).set_Name("nome");
		Label obj6 = nome;
		size = new Size(109, 24);
		((Control)obj6).set_Size(size);
		((Control)nome).set_TabIndex(1);
		nome.set_Text("SystemHost");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.FromArgb(0, 0, 192));
		Label label7 = Label3;
		location = new Point(58, 43);
		((Control)label7).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label8 = Label3;
		size = new Size(73, 24);
		((Control)label8).set_Size(size);
		((Control)Label3).set_TabIndex(0);
		Label3.set_Text("NOME:");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Red);
		Label label9 = Label2;
		location = new Point(125, 115);
		((Control)label9).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label10 = Label2;
		size = new Size(316, 24);
		((Control)label10).set_Size(size);
		((Control)Label2).set_TabIndex(89);
		Label2.set_Text("Aviso: Site perigoso foi bloqueado !!!");
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox3 = GroupBox1;
		location = new Point(90, 297);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox4 = GroupBox1;
		size = new Size(442, 104);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox1).set_TabIndex(88);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Escolha as opções para uso:");
		Button button = Button2;
		location = new Point(232, 42);
		((Control)button).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button2 = Button2;
		size = new Size(202, 42);
		((Control)button2).set_Size(size);
		((Control)Button2).set_TabIndex(1);
		((ButtonBase)Button2).set_Text("Fechar e Remover");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button3 = Button1;
		location = new Point(24, 42);
		((Control)button3).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button4 = Button1;
		size = new Size(202, 42);
		((Control)button4).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Permitir");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)PictureBox10).set_Cursor(Cursors.get_Default());
		PictureBox10.set_Image((Image)componentResourceManager.GetObject("PictureBox10.Image"));
		PictureBox pictureBox = PictureBox10;
		location = new Point(8, 42);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox10).set_Name("PictureBox10");
		PictureBox pictureBox2 = PictureBox10;
		size = new Size(105, 97);
		((Control)pictureBox2).set_Size(size);
		PictureBox10.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox10.set_TabIndex(87);
		PictureBox10.set_TabStop(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label11 = Label1;
		location = new Point(119, 66);
		((Control)label11).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label12 = Label1;
		size = new Size(188, 55);
		((Control)label12).set_Size(size);
		((Control)Label1).set_TabIndex(86);
		Label1.set_Text("Firewall");
		((Control)Picrred_firewall).set_Dock((DockStyle)1);
		Picrred_firewall.set_Image((Image)componentResourceManager.GetObject("Picrred_firewall.Image"));
		PictureBox picrred_firewall = Picrred_firewall;
		location = new Point(0, 0);
		((Control)picrred_firewall).set_Location(location);
		((Control)Picrred_firewall).set_Name("Picrred_firewall");
		PictureBox picrred_firewall2 = Picrred_firewall;
		size = new Size(617, 28);
		((Control)picrred_firewall2).set_Size(size);
		Picrred_firewall.set_SizeMode((PictureBoxSizeMode)1);
		Picrred_firewall.set_TabIndex(85);
		Picrred_firewall.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		size = new Size(617, 415);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox10);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Picrred_firewall);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		size = new Size(623, 444);
		((Form)this).set_MaximumSize(size);
		((Form)this).set_MinimizeBox(false);
		size = new Size(623, 444);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("Firewall");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SATWNEYT_Firewall");
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)Picrred_firewall).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (nome.get_Text().Contains("satwneyt") | nome.get_Text().Contains("Satwneyt") | nome.get_Text().Contains("SATWNEYT"))
		{
			((Form)this).Close();
		}
		if (tipo.get_Text().Contains("satwneyt") | tipo.get_Text().Contains("Satwneyt") | tipo.get_Text().Contains("SATWNEYT"))
		{
			((Form)this).Close();
		}
		if (soft.get_Text().Contains("satwneyt") | soft.get_Text().Contains("Satwneyt") | soft.get_Text().Contains("SATWNEYT"))
		{
			((Form)this).Close();
		}
		if ((Operators.CompareString(nome.get_Text(), "satwneyt", false) == 0) | (Operators.CompareString(nome.get_Text(), "Satwneyt", false) == 0) | (Operators.CompareString(nome.get_Text(), "SATWNEYT", false) == 0))
		{
			((Form)this).Close();
		}
		if ((Operators.CompareString(tipo.get_Text(), "satwneyt", false) == 0) | (Operators.CompareString(tipo.get_Text(), "Satwneyt", false) == 0) | (Operators.CompareString(tipo.get_Text(), "SATWNEYT", false) == 0))
		{
			((Form)this).Close();
		}
		if ((Operators.CompareString(soft.get_Text(), "satwneyt", false) == 0) | (Operators.CompareString(soft.get_Text(), "Satwneyt", false) == 0) | (Operators.CompareString(soft.get_Text(), "SATWNEYT", false) == 0))
		{
			((Form)this).Close();
		}
		try
		{
			if (((Control)this).get_Visible())
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\S-Firewall-Info\\info\\ativar informação e detelhes agora", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((Control)this).get_Visible())
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\S-Firewall-Info\\info\\ativar informação e detelhes agora", (DeleteDirectoryOption)4);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((Control)this).get_Visible())
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\S-Firewall-Info\\info\\ativar informação e detelhes agora");
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void Form14_Load(object sender, EventArgs e)
	{
		if (nome.get_Text().Contains("satwneyt") | nome.get_Text().Contains("Satwneyt") | nome.get_Text().Contains("SATWNEYT"))
		{
			((Form)this).Close();
		}
		if (tipo.get_Text().Contains("satwneyt") | tipo.get_Text().Contains("Satwneyt") | tipo.get_Text().Contains("SATWNEYT"))
		{
			((Form)this).Close();
		}
		if (soft.get_Text().Contains("satwneyt") | soft.get_Text().Contains("Satwneyt") | soft.get_Text().Contains("SATWNEYT"))
		{
			((Form)this).Close();
		}
		if ((Operators.CompareString(nome.get_Text(), "satwneyt", false) == 0) | (Operators.CompareString(nome.get_Text(), "Satwneyt", false) == 0) | (Operators.CompareString(nome.get_Text(), "SATWNEYT", false) == 0))
		{
			((Form)this).Close();
		}
		if ((Operators.CompareString(tipo.get_Text(), "satwneyt", false) == 0) | (Operators.CompareString(tipo.get_Text(), "Satwneyt", false) == 0) | (Operators.CompareString(tipo.get_Text(), "SATWNEYT", false) == 0))
		{
			((Form)this).Close();
		}
		if ((Operators.CompareString(soft.get_Text(), "satwneyt", false) == 0) | (Operators.CompareString(soft.get_Text(), "Satwneyt", false) == 0) | (Operators.CompareString(soft.get_Text(), "SATWNEYT", false) == 0))
		{
			((Form)this).Close();
		}
		try
		{
			if (((Control)this).get_Visible())
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\S-Firewall-Info\\info\\ativar informação e detelhes agora", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((Control)this).get_Visible())
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\S-Firewall-Info\\info\\ativar informação e detelhes agora", (DeleteDirectoryOption)4);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((Control)this).get_Visible())
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\S-Firewall-Info\\info\\ativar informação e detelhes agora");
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(nome.get_Text(), (DeleteDirectoryOption)5);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(nome.get_Text(), (DeleteDirectoryOption)4);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(nome.get_Text());
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(nome.get_Text());
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((Computer)MyProject.Computer).get_Audio().Stop();
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((Control)this).get_Visible())
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\S-Firewall-Info\\info\\ativar informação e detelhes agora", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((Control)this).get_Visible())
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\S-Firewall-Info\\info\\ativar informação e detelhes agora", (DeleteDirectoryOption)4);
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((Control)this).get_Visible())
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\S-Firewall-Info\\info\\ativar informação e detelhes agora");
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
		try
		{
			tipo.set_Text("Site Perigoso / Virus da internet");
			soft.set_Text("Desconhecido");
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			((Computer)MyProject.Computer).get_Audio().Stop();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
		try
		{
			tipo.set_Text("Site Perigoso / Virus da internet");
			soft.set_Text("Desconhecido");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
