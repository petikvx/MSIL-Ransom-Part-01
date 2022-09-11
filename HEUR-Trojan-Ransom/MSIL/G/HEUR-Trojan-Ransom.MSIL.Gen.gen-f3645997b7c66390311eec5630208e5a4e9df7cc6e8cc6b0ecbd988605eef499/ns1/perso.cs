using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.PowerPacks;
using ns0;

namespace ns1;

[DesignerGenerated]
public class perso : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("ShapeContainer1")]
	private ShapeContainer _ShapeContainer1;

	[AccessedThroughProperty("RectangleShape1")]
	private RectangleShape _RectangleShape1;

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

	internal virtual PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox3 = value;
		}
	}

	internal virtual ShapeContainer ShapeContainer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ShapeContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ShapeContainer1 = value;
		}
	}

	internal virtual RectangleShape RectangleShape1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RectangleShape1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RectangleShape1 = value;
		}
	}

	[DebuggerNonUserCode]
	public perso()
	{
		((Form)this).add_Load((EventHandler)perso_Load);
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
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(perso));
		Button1 = new Button();
		Timer1 = new Timer(components);
		Label1 = new Label();
		GroupBox1 = new GroupBox();
		PictureBox3 = new PictureBox();
		ShapeContainer1 = new ShapeContainer();
		RectangleShape1 = new RectangleShape();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button = Button1;
		Point location = new Point(88, 164);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(296, 58);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Clique aqui.");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(449, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(14, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("A");
		((Control)Label1).set_Visible(false);
		((Control)GroupBox1).set_BackColor(Color.White);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ShapeContainer1);
		((Control)GroupBox1).set_Dock((DockStyle)5);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox = GroupBox1;
		location = new Point(0, 0);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(489, 234);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(4);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("ESCANEAMENTO PERSONALIZADO");
		PictureBox3.set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		PictureBox pictureBox = PictureBox3;
		location = new Point(176, 39);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox2 = PictureBox3;
		size = new Size(111, 104);
		((Control)pictureBox2).set_Size(size);
		PictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox3.set_TabIndex(14);
		PictureBox3.set_TabStop(false);
		ShapeContainer shapeContainer = ShapeContainer1;
		location = new Point(3, 25);
		((Control)shapeContainer).set_Location(location);
		ShapeContainer shapeContainer2 = ShapeContainer1;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)shapeContainer2).set_Margin(margin);
		((Control)ShapeContainer1).set_Name("ShapeContainer1");
		ShapeContainer1.get_Shapes().AddRange((Shape[])(object)new Shape[1] { (Shape)RectangleShape1 });
		ShapeContainer shapeContainer3 = ShapeContainer1;
		size = new Size(483, 206);
		((Control)shapeContainer3).set_Size(size);
		((Control)ShapeContainer1).set_TabIndex(15);
		((Control)ShapeContainer1).set_TabStop(false);
		RectangleShape rectangleShape = RectangleShape1;
		location = new Point(169, 9);
		((SimpleShape)rectangleShape).set_Location(location);
		((Shape)RectangleShape1).set_Name("RectangleShape1");
		RectangleShape rectangleShape2 = RectangleShape1;
		size = new Size(117, 112);
		((SimpleShape)rectangleShape2).set_Size(size);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(489, 234);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		size = new Size(505, 273);
		((Form)this).set_MaximumSize(size);
		((Form)this).set_MinimizeBox(false);
		size = new Size(505, 273);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("perso");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SATWNEYT PERSONALIZAÇÃO");
		((Control)GroupBox1).ResumeLayout(false);
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		try
		{
			if ((int)((CommonDialog)MyProject.Forms.Tools0.FolderBrowserDialog1).ShowDialog() == 1)
			{
				MyProject.Forms.Load2.Label1.set_Text("Fazer Varredura Personalizada");
				try
				{
					MySettingsProperty.Settings.Perso = "B";
					Label1.set_Text("B");
					((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Tools0.ProgressBarScanner.set_Value(MyProject.Forms.Tools0.ProgressBarScanner.get_Minimum());
				try
				{
					StreamWriter streamWriter = new StreamWriter("C:\\Satwneyt\\segundo.inf");
					streamWriter.Write("");
					streamWriter.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\segundo.inf");
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter2 = new StreamWriter("C:\\Satwneyt\\minuto.inf");
					streamWriter2.Write("");
					streamWriter2.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\minuto.inf");
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter3 = new StreamWriter("C:\\Satwneyt\\hora.inf");
					streamWriter3.Write("");
					streamWriter3.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\hora.inf");
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter4 = new StreamWriter("C:\\Satwneyt\\dia.inf");
					streamWriter4.Write("");
					streamWriter4.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\dia.inf");
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter5 = new StreamWriter("C:\\Satwneyt\\mes.inf");
					streamWriter5.Write("");
					streamWriter5.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\mes.inf");
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter6 = new StreamWriter("C:\\Satwneyt\\ano.inf");
					streamWriter6.Write("");
					streamWriter6.Close();
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\satwneyt\\ano.inf");
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
				try
				{
					StreamWriter streamWriter7 = new StreamWriter("C:\\Satwneyt\\tdv.inf");
					streamWriter7.Write("");
					streamWriter7.Close();
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					ProjectData.ClearProjectError();
				}
				MyProject.Forms.Tools0.ListBox1.get_Items().Clear();
				MyProject.Forms.Tools0.ListBox2.get_Items().Clear();
				((Control)MyProject.Forms.Tools0.Button2).set_Enabled(false);
				((Control)MyProject.Forms.Tools0.Button1).set_Enabled(false);
				try
				{
					MyProject.Forms.Tools0.ProgressBarScanner.set_Value(MyProject.Forms.Tools0.ProgressBarScanner.get_Minimum());
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					ProjectData.ClearProjectError();
				}
				string[] directories = Directory.GetDirectories(MyProject.Forms.Tools0.FolderBrowserDialog1.get_SelectedPath().ToString());
				foreach (string text in directories)
				{
					string[] files = Directory.GetFiles(text.ToString());
					foreach (string text2 in files)
					{
						MyProject.Forms.Tools0.ListBox1.get_Items().Add((object)text2);
					}
				}
				MyProject.Forms.Tools0.crotime.Start();
				MyProject.Forms.Tools0.crotime.set_Enabled(true);
				Timer1.set_Enabled(true);
				Timer1.Start();
				MyProject.Forms.Tools0.Label7.set_Text("00:00:00");
				MyProject.Forms.Tools0.crotime.Start();
				MyProject.Forms.Tools0.crotime.set_Enabled(true);
				try
				{
					MyProject.Forms.Tools0.Timer1.set_Enabled(true);
					MyProject.Forms.Tools0.Timer1.Start();
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					MyProject.Forms.Tools0.Timer1.Start();
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				MyProject.Forms.Tools0.TextBoxScanner.set_Text("C:\\");
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			((Control)MyProject.Forms.janela.PanelTelaError).set_Visible(true);
			((Control)MyProject.Forms.janela.PanelTelaError).set_Dock((DockStyle)5);
			((Form)MyProject.Forms.Tools0).Close();
			((Form)this).set_WindowState((FormWindowState)0);
			((Control)MyProject.Forms.janela.PanelTela).set_BackColor(Color.Red);
			MyProject.Forms.janela.Label2.set_Text("Error 404");
			((Control)MyProject.Forms.janela.Label2).set_ForeColor(Color.Red);
			((Control)MyProject.Forms.janela.PictureBoxProtegido).set_Visible(false);
			((Control)MyProject.Forms.janela.PictureBoxAtencao).set_Visible(false);
			((Control)MyProject.Forms.janela.PictureBoxEmRisco).set_Visible(false);
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory("C:\\desativar");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)5);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory("C:\\atencao", (DeleteDirectoryOption)4);
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			MyProject.Forms.Load2.FileSystemWatcher1.EnableRaisingEvents = false;
			ProjectData.ClearProjectError();
		}
		try
		{
			MyProject.Forms.Tools0.detected.set_Text("0");
			((Control)MyProject.Forms.Tools0.detected).set_ForeColor(Color.Black);
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			MyProject.Forms.Tools0.GroupBox2.set_Text("Fazer personalizado");
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		MyProject.Forms.Tools0.Label7.set_Text("00:00:00");
	}

	private void perso_Load(object sender, EventArgs e)
	{
		Label1.set_Text(MySettingsProperty.Settings.Perso.ToString());
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Label1.set_Text("B");
		Label1.set_Text(MySettingsProperty.Settings.Perso.ToString());
		if (Operators.CompareString(Label1.get_Text(), "B", false) == 0)
		{
			try
			{
				MySettingsProperty.Settings.Perso = "B";
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				((Form)this).Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Timer1.Stop();
			Timer1.set_Enabled(false);
		}
	}
}
