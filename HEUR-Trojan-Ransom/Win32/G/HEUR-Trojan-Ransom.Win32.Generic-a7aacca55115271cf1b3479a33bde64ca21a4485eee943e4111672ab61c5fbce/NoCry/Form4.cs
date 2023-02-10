using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NoCry;

[DesignerGenerated]
public class Form4 : Form
{
	private IContainer components;

	public static List<string> listenc = new List<string>();

	internal virtual ListBox ListBox1
	{
		[CompilerGenerated]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(ListBox1_MouseDown);
			ListBox listBox = _ListBox1;
			if (listBox != null)
			{
				((Control)listBox).remove_MouseDown(val);
			}
			_ListBox1 = value;
			listBox = _ListBox1;
			if (listBox != null)
			{
				((Control)listBox).add_MouseDown(val);
			}
		}
	}

	[field: AccessedThroughProperty("ContextMenuStrip1")]
	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem OpenLocationToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OpenLocationToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = OpenLocationToolStripMenuItem_Click;
			ToolStripMenuItem openLocationToolStripMenuItem = _OpenLocationToolStripMenuItem;
			if (openLocationToolStripMenuItem != null)
			{
				((ToolStripItem)openLocationToolStripMenuItem).remove_Click(eventHandler);
			}
			_OpenLocationToolStripMenuItem = value;
			openLocationToolStripMenuItem = _OpenLocationToolStripMenuItem;
			if (openLocationToolStripMenuItem != null)
			{
				((ToolStripItem)openLocationToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	public Form4()
	{
		((Form)this).add_Load((EventHandler)Form4_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		components = new Container();
		ListBox1 = new ListBox();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		OpenLocationToolStripMenuItem = new ToolStripMenuItem();
		((Control)ContextMenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		ListBox1.set_BackColor(Color.Maroon);
		((Control)ListBox1).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)ListBox1).set_Dock((DockStyle)5);
		ListBox1.set_Font(new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListBox1.set_ForeColor(Color.White);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox1.set_ItemHeight(14);
		((Control)ListBox1).set_Location(new Point(0, 0));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(427, 323));
		((Control)ListBox1).set_TabIndex(0);
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)OpenLocationToolStripMenuItem });
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		((Control)ContextMenuStrip1).set_Size(new Size(169, 26));
		((ToolStripItem)OpenLocationToolStripMenuItem).set_BackColor(Color.Maroon);
		((ToolStripItem)OpenLocationToolStripMenuItem).set_ForeColor(Color.White);
		((ToolStripItem)OpenLocationToolStripMenuItem).set_Name("OpenLocationToolStripMenuItem");
		((ToolStripItem)OpenLocationToolStripMenuItem).set_Size(new Size(168, 22));
		((ToolStripItem)OpenLocationToolStripMenuItem).set_Text("Open file location");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(427, 323));
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Encrypted Files");
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 172:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_0032;
						case 4:
							goto IL_004a;
						case 5:
							goto IL_005f;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0061:
					if (!enumerator.MoveNext())
					{
						break;
					}
					current = enumerator.Current;
					goto IL_004a;
					IL_005f:
					num = 5;
					goto IL_0061;
					IL_0032:
					num = 3;
					enumerator = listenc.GetEnumerator();
					goto IL_0061;
					IL_004a:
					num = 4;
					ListBox1.get_Items().Add((object)current);
					goto IL_005f;
					IL_000b:
					num = 2;
					((Form)this).set_Text("Encrypted Files (" + Conversions.ToString(listenc.Count) + ")");
					goto IL_0032;
					end_IL_0001_2:
					break;
				}
				num = 6;
				((IDisposable)enumerator).Dispose();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 172;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void OpenLocationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("explorer.exe", Conversions.ToString(Operators.AddObject((object)"/select,", ListBox1.get_SelectedItem())));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ListBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 2097152)
		{
			ListBox1.set_SelectedIndex(ListBox1.IndexFromPoint(e.get_X(), e.get_Y()));
		}
	}
}
