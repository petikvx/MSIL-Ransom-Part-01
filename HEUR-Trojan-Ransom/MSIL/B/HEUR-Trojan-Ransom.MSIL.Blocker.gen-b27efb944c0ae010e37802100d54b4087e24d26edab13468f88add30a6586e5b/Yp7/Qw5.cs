using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using y5N;

namespace Yp7;

[DesignerGenerated]
public class Qw5 : Form
{
	private IContainer components;

	private int m_ChildFormNumber;

	[field: AccessedThroughProperty("ToolTip")]
	internal virtual ToolTip ToolTip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StatusStrip")]
	internal virtual StatusStrip StatusStrip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MenuStrip1")]
	internal virtual MenuStrip MenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AddNewToolStripMenuItem")]
	internal virtual ToolStripMenuItem AddNewToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InformationToolStripMenuItem")]
	internal virtual ToolStripMenuItem InformationToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem AddNewStudentToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddNewStudentToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b0F;
			ToolStripMenuItem addNewStudentToolStripMenuItem = _AddNewStudentToolStripMenuItem;
			if (addNewStudentToolStripMenuItem != null)
			{
				((ToolStripItem)addNewStudentToolStripMenuItem).remove_Click(eventHandler);
			}
			_AddNewStudentToolStripMenuItem = value;
			addNewStudentToolStripMenuItem = _AddNewStudentToolStripMenuItem;
			if (addNewStudentToolStripMenuItem != null)
			{
				((ToolStripItem)addNewStudentToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AddNewSubjectToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddNewSubjectToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = f9Z;
			ToolStripMenuItem addNewSubjectToolStripMenuItem = _AddNewSubjectToolStripMenuItem;
			if (addNewSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)addNewSubjectToolStripMenuItem).remove_Click(eventHandler);
			}
			_AddNewSubjectToolStripMenuItem = value;
			addNewSubjectToolStripMenuItem = _AddNewSubjectToolStripMenuItem;
			if (addNewSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)addNewSubjectToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AddNewClassToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddNewClassToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = s7Z;
			ToolStripMenuItem addNewClassToolStripMenuItem = _AddNewClassToolStripMenuItem;
			if (addNewClassToolStripMenuItem != null)
			{
				((ToolStripItem)addNewClassToolStripMenuItem).remove_Click(eventHandler);
			}
			_AddNewClassToolStripMenuItem = value;
			addNewClassToolStripMenuItem = _AddNewClassToolStripMenuItem;
			if (addNewClassToolStripMenuItem != null)
			{
				((ToolStripItem)addNewClassToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SearchStudentToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SearchStudentToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = q3M;
			ToolStripMenuItem searchStudentToolStripMenuItem = _SearchStudentToolStripMenuItem;
			if (searchStudentToolStripMenuItem != null)
			{
				((ToolStripItem)searchStudentToolStripMenuItem).remove_Click(eventHandler);
			}
			_SearchStudentToolStripMenuItem = value;
			searchStudentToolStripMenuItem = _SearchStudentToolStripMenuItem;
			if (searchStudentToolStripMenuItem != null)
			{
				((ToolStripItem)searchStudentToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FindStudentDetailsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _FindStudentDetailsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ri0;
			ToolStripMenuItem findStudentDetailsToolStripMenuItem = _FindStudentDetailsToolStripMenuItem;
			if (findStudentDetailsToolStripMenuItem != null)
			{
				((ToolStripItem)findStudentDetailsToolStripMenuItem).remove_Click(eventHandler);
			}
			_FindStudentDetailsToolStripMenuItem = value;
			findStudentDetailsToolStripMenuItem = _FindStudentDetailsToolStripMenuItem;
			if (findStudentDetailsToolStripMenuItem != null)
			{
				((ToolStripItem)findStudentDetailsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SearchSubjectToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SearchSubjectToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = f3L;
			ToolStripMenuItem searchSubjectToolStripMenuItem = _SearchSubjectToolStripMenuItem;
			if (searchSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)searchSubjectToolStripMenuItem).remove_Click(eventHandler);
			}
			_SearchSubjectToolStripMenuItem = value;
			searchSubjectToolStripMenuItem = _SearchSubjectToolStripMenuItem;
			if (searchSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)searchSubjectToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FindClassDetailsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _FindClassDetailsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ri3;
			ToolStripMenuItem findClassDetailsToolStripMenuItem = _FindClassDetailsToolStripMenuItem;
			if (findClassDetailsToolStripMenuItem != null)
			{
				((ToolStripItem)findClassDetailsToolStripMenuItem).remove_Click(eventHandler);
			}
			_FindClassDetailsToolStripMenuItem = value;
			findClassDetailsToolStripMenuItem = _FindClassDetailsToolStripMenuItem;
			if (findClassDetailsToolStripMenuItem != null)
			{
				((ToolStripItem)findClassDetailsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AddNewSubjectToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _AddNewSubjectToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Yq4;
			ToolStripMenuItem addNewSubjectToolStripMenuItem = _AddNewSubjectToolStripMenuItem1;
			if (addNewSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)addNewSubjectToolStripMenuItem).remove_Click(eventHandler);
			}
			_AddNewSubjectToolStripMenuItem1 = value;
			addNewSubjectToolStripMenuItem = _AddNewSubjectToolStripMenuItem1;
			if (addNewSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)addNewSubjectToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = r9C;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem UserToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _UserToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Em7;
			ToolStripMenuItem userToolStripMenuItem = _UserToolStripMenuItem;
			if (userToolStripMenuItem != null)
			{
				((ToolStripItem)userToolStripMenuItem).remove_Click(eventHandler);
			}
			_UserToolStripMenuItem = value;
			userToolStripMenuItem = _UserToolStripMenuItem;
			if (userToolStripMenuItem != null)
			{
				((ToolStripItem)userToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	public Qw5()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		((Form)this).add_AutoSizeChanged((EventHandler)Aw7);
		((Form)this).add_FormClosed(new FormClosedEventHandler(Aw6));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Xf7));
		((Form)this).add_Load((EventHandler)g5C);
		Aq1();
	}

	[DebuggerNonUserCode]
	protected override void Sr8(bool Nm3)
	{
		try
		{
			if (Nm3 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Nm3);
		}
	}

	[DebuggerStepThrough]
	private void Aq1()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
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
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected O, but got Unknown
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected O, but got Unknown
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Qw5));
		StatusStrip = new StatusStrip();
		ToolStripStatusLabel = new ToolStripStatusLabel();
		ToolTip = new ToolTip(components);
		MenuStrip1 = new MenuStrip();
		AddNewToolStripMenuItem = new ToolStripMenuItem();
		AddNewStudentToolStripMenuItem = new ToolStripMenuItem();
		AddNewSubjectToolStripMenuItem = new ToolStripMenuItem();
		AddNewClassToolStripMenuItem = new ToolStripMenuItem();
		AddNewSubjectToolStripMenuItem1 = new ToolStripMenuItem();
		InformationToolStripMenuItem = new ToolStripMenuItem();
		SearchStudentToolStripMenuItem = new ToolStripMenuItem();
		FindStudentDetailsToolStripMenuItem = new ToolStripMenuItem();
		SearchSubjectToolStripMenuItem = new ToolStripMenuItem();
		FindClassDetailsToolStripMenuItem = new ToolStripMenuItem();
		Button1 = new Button();
		UserToolStripMenuItem = new ToolStripMenuItem();
		((Control)StatusStrip).SuspendLayout();
		((Control)MenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)StatusStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel });
		((Control)StatusStrip).set_Location(new Point(0, 395));
		((Control)StatusStrip).set_Name("StatusStrip");
		StatusStrip.set_Padding(new Padding(2, 0, 19, 0));
		((Control)StatusStrip).set_Size(new Size(786, 22));
		((Control)StatusStrip).set_TabIndex(7);
		((Control)StatusStrip).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel).set_Name("ToolStripStatusLabel");
		((ToolStripItem)ToolStripStatusLabel).set_Size(new Size(39, 17));
		((ToolStripItem)ToolStripStatusLabel).set_Text("Status");
		((ToolStrip)MenuStrip1).set_BackColor(Color.LightSkyBlue);
		((ToolStrip)MenuStrip1).set_Font(new Font("Segoe UI", 9f, (FontStyle)1));
		MenuStrip1.set_GripStyle((ToolStripGripStyle)1);
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)AddNewToolStripMenuItem,
			(ToolStripItem)InformationToolStripMenuItem,
			(ToolStripItem)UserToolStripMenuItem
		});
		((Control)MenuStrip1).set_Location(new Point(0, 0));
		((Control)MenuStrip1).set_Name("MenuStrip1");
		((Control)MenuStrip1).set_Padding(new Padding(8, 2, 0, 2));
		((ToolStrip)MenuStrip1).set_RenderMode((ToolStripRenderMode)2);
		((Control)MenuStrip1).set_Size(new Size(786, 24));
		((Control)MenuStrip1).set_TabIndex(9);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripDropDownItem)AddNewToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)AddNewStudentToolStripMenuItem,
			(ToolStripItem)AddNewSubjectToolStripMenuItem,
			(ToolStripItem)AddNewClassToolStripMenuItem,
			(ToolStripItem)AddNewSubjectToolStripMenuItem1
		});
		((ToolStripItem)AddNewToolStripMenuItem).set_Name("AddNewToolStripMenuItem");
		((ToolStripItem)AddNewToolStripMenuItem).set_Size(new Size(70, 20));
		((ToolStripItem)AddNewToolStripMenuItem).set_Text("Add New");
		((ToolStripItem)AddNewStudentToolStripMenuItem).set_Name("AddNewStudentToolStripMenuItem");
		((ToolStripItem)AddNewStudentToolStripMenuItem).set_Size(new Size(173, 22));
		((ToolStripItem)AddNewStudentToolStripMenuItem).set_Text("Add New Student");
		((ToolStripItem)AddNewSubjectToolStripMenuItem).set_Name("AddNewSubjectToolStripMenuItem");
		((ToolStripItem)AddNewSubjectToolStripMenuItem).set_Size(new Size(173, 22));
		((ToolStripItem)AddNewSubjectToolStripMenuItem).set_Text("Add New Subject");
		((ToolStripItem)AddNewClassToolStripMenuItem).set_Name("AddNewClassToolStripMenuItem");
		((ToolStripItem)AddNewClassToolStripMenuItem).set_Size(new Size(173, 22));
		((ToolStripItem)AddNewClassToolStripMenuItem).set_Text("Add New Class");
		((ToolStripItem)AddNewSubjectToolStripMenuItem1).set_Name("AddNewSubjectToolStripMenuItem1");
		((ToolStripItem)AddNewSubjectToolStripMenuItem1).set_Size(new Size(173, 22));
		((ToolStripItem)AddNewSubjectToolStripMenuItem1).set_Text("Add New Course");
		((ToolStripDropDownItem)InformationToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)SearchStudentToolStripMenuItem,
			(ToolStripItem)FindStudentDetailsToolStripMenuItem,
			(ToolStripItem)SearchSubjectToolStripMenuItem,
			(ToolStripItem)FindClassDetailsToolStripMenuItem
		});
		((ToolStripItem)InformationToolStripMenuItem).set_Name("InformationToolStripMenuItem");
		((ToolStripItem)InformationToolStripMenuItem).set_Size(new Size(86, 20));
		((ToolStripItem)InformationToolStripMenuItem).set_Text("Information");
		((ToolStripItem)SearchStudentToolStripMenuItem).set_Name("SearchStudentToolStripMenuItem");
		((ToolStripItem)SearchStudentToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)SearchStudentToolStripMenuItem).set_Text("Find Student ");
		((ToolStripItem)FindStudentDetailsToolStripMenuItem).set_Name("FindStudentDetailsToolStripMenuItem");
		((ToolStripItem)FindStudentDetailsToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)FindStudentDetailsToolStripMenuItem).set_Text("Find Student Details");
		((ToolStripItem)SearchSubjectToolStripMenuItem).set_Name("SearchSubjectToolStripMenuItem");
		((ToolStripItem)SearchSubjectToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)SearchSubjectToolStripMenuItem).set_Text("Find Subject Details");
		((ToolStripItem)FindClassDetailsToolStripMenuItem).set_Name("FindClassDetailsToolStripMenuItem");
		((ToolStripItem)FindClassDetailsToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)FindClassDetailsToolStripMenuItem).set_Text("Find Class Details");
		((Control)Button1).set_Anchor((AnchorStyles)9);
		((ButtonBase)Button1).set_AutoSize(true);
		((ButtonBase)Button1).set_BackColor(Color.LightSkyBlue);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(2);
		((ButtonBase)Button1).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(255, 224, 192));
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Location(new Point(676, 0));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(105, 29));
		((Control)Button1).set_TabIndex(11);
		((ButtonBase)Button1).set_Text("Logout");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ToolStripItem)UserToolStripMenuItem).set_Name("UserToolStripMenuItem");
		((ToolStripItem)UserToolStripMenuItem).set_Size(new Size(45, 20));
		((ToolStripItem)UserToolStripMenuItem).set_Text("User");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 15f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MintCream);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(786, 417));
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("MENUS");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("MENUS");
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)StatusStrip).ResumeLayout(false);
		((Control)StatusStrip).PerformLayout();
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void x8X(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Form val = new Form();
		val.set_MdiParent((Form)(object)this);
		checked
		{
			m_ChildFormNumber++;
			val.set_Text("Window " + Conversions.ToString(m_ChildFormNumber));
			((Control)val).Show();
		}
	}

	private void Yi2(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)y2E.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	internal static byte[] Mt8(int Nz7, int Dm0)
	{
		if (Nz7 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Dm0 + 1];
			for (int i = 0; i <= Dm0; i++)
			{
				int num = Nz7 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Ez4(array, Dm0);
		}
	}

	private void Xa0(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)y2E.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void i4K(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void m2F(object sender, EventArgs e)
	{
	}

	private void a7B(object sender, EventArgs e)
	{
	}

	private void Tw0(object sender, EventArgs e)
	{
	}

	internal static byte[] Ez4(int[] Qk4, int w4C)
	{
		checked
		{
			byte[] array = new byte[w4C + 1];
			int num = Qk4.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Qk4[i];
			}
			return array;
		}
	}

	private void x1Q(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)0);
	}

	private void g3H(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)2);
	}

	private void Kb6(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)1);
	}

	private void Lq3(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)3);
	}

	private void Hf8(object sender, EventArgs e)
	{
		Form[] mdiChildren = ((Form)this).get_MdiChildren();
		foreach (Form val in mdiChildren)
		{
			val.Close();
		}
	}

	private void b0F(object sender, EventArgs e)
	{
		((Form)y2E.Forms.AddmisionForm).set_MdiParent((Form)(object)this);
		((Control)y2E.Forms.AddmisionForm).Show();
	}

	private void Aw7(object sender, EventArgs e)
	{
	}

	private void Aw6(object sender, FormClosedEventArgs e)
	{
		((Control)y2E.Forms.LoginForm1).Show();
		((Control)this).Hide();
	}

	private void Xf7(object sender, FormClosingEventArgs e)
	{
		((Control)y2E.Forms.LoginForm1).Show();
		((Control)this).Hide();
	}

	private void g5C(object sender, EventArgs e)
	{
		((ButtonBase)Button1).set_Text(y2E.Forms.LoginForm1.UsernameTextBox.get_Text() + " Logout");
	}

	private void f9Z(object sender, EventArgs e)
	{
		((Form)y2E.Forms.Subject).set_MdiParent((Form)(object)this);
		((Control)y2E.Forms.Subject).Show();
	}

	private void s7Z(object sender, EventArgs e)
	{
		((Form)y2E.Forms.ClassDetail).set_MdiParent((Form)(object)this);
		((Control)y2E.Forms.ClassDetail).Show();
	}

	private void q3M(object sender, EventArgs e)
	{
		((Form)y2E.Forms.SearchForm).set_MdiParent((Form)(object)this);
		((Control)y2E.Forms.SearchForm).Show();
	}

	private void Ri0(object sender, EventArgs e)
	{
		((Form)y2E.Forms.AddmisionForm1).set_MdiParent((Form)(object)this);
		((Control)y2E.Forms.AddmisionForm1).Show();
	}

	private void f3L(object sender, EventArgs e)
	{
		((Form)y2E.Forms.Subject1).set_MdiParent((Form)(object)this);
		((Control)y2E.Forms.Subject1).Show();
	}

	private void Ri3(object sender, EventArgs e)
	{
		((Form)y2E.Forms.ClassDetail1).set_MdiParent((Form)(object)this);
		((Control)y2E.Forms.ClassDetail1).Show();
	}

	private void Yq4(object sender, EventArgs e)
	{
		((Form)y2E.Forms.Course).set_MdiParent((Form)(object)this);
		((Control)y2E.Forms.Course).Show();
	}

	private void r9C(object sender, EventArgs e)
	{
		((TextBoxBase)y2E.Forms.LoginForm1.TextBox1).Clear();
		y2E.Forms.LoginForm1.ComboBox1.ResetText();
		((TextBoxBase)y2E.Forms.LoginForm1.UsernameTextBox).Clear();
		((Control)y2E.Forms.LoginForm1).Show();
		((Form)this).Close();
	}

	internal static byte g9Y(byte b8B, byte[] j9N, int Zc7, int x1E)
	{
		b8B = (byte)(b8B ^ checked((byte)(j9N[unchecked(x1E % j9N.Length)] ^ ((x1E + unchecked(Zc7 % j9N.Length)) & Zc7))));
		return b8B;
	}

	private void Em7(object sender, EventArgs e)
	{
		((Control)y2E.Forms.AddUser).Show();
	}
}
