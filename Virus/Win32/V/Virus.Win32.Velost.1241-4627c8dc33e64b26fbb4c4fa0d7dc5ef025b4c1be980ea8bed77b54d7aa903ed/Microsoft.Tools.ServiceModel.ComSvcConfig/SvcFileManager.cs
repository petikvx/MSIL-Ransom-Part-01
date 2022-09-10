using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ServiceModel.Activation;
using System.ServiceModel.ComIntegration;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class SvcFileManager
{
	private enum SvcFileState
	{
		Existing,
		Added,
		Deleted
	}

	private class SvcFile
	{
		private const string factoryAttributeName = "Factory";

		private const string serviceAttributeName = "Service";

		private Guid appid;

		private Guid clsid;

		private SvcFileState state;

		private AtomicFile svcFile;

		public Guid Appid => appid;

		public Guid Clsid => clsid;

		public SvcFileState State => state;

		private SvcFile(Guid appid, Guid clsid, SvcFileState state, AtomicFile svcFile)
		{
			this.appid = appid;
			this.clsid = clsid;
			this.state = state;
			this.svcFile = svcFile;
		}

		public static SvcFile CreateNew(string webDirectoryPath, Guid appid, Guid clsid)
		{
			ComAdminAppInfo appInfo = ComAdminWrapper.GetAppInfo(appid.ToString("B"));
			if (appInfo == null)
			{
				throw Tool.CreateException(SR.GetString("CannotFindAppInfo", appid.ToString("B")), null);
			}
			ComAdminClassInfo comAdminClassInfo = appInfo.FindClass(clsid.ToString("B"));
			if (comAdminClassInfo == null)
			{
				throw Tool.CreateException(SR.GetString("CannotFindClassInfo", clsid.ToString("B")), null);
			}
			string text = webDirectoryPath + "\\" + comAdminClassInfo.Name;
			if (File.Exists(text + ".svc"))
			{
				int num = 1;
				while (File.Exists(text + "." + num.ToString(CultureInfo.InvariantCulture) + ".svc"))
				{
					num++;
				}
				text = text + "." + num.ToString(CultureInfo.InvariantCulture);
			}
			text += ".svc";
			string text2 = clsid.ToString("B") + "," + appid.ToString("B");
			using (StreamWriter streamWriter = File.CreateText(text))
			{
				streamWriter.WriteLine("<%@ServiceHost {0}=\"{1}\" {2}=\"{3}\" %>", "Factory", typeof(WasHostedComPlusFactory).FullName, "Service", text2);
			}
			return new SvcFile(appid, clsid, SvcFileState.Added, new AtomicFile(text));
		}

		private static IDictionary<string, string> ParseServiceDirective(string serviceText)
		{
			IDictionary<string, string> dictionary = null;
			try
			{
				Type type = typeof(ServiceHostFactory).Assembly.GetType("System.ServiceModel.Activation.ServiceParser");
				return (IDictionary<string, string>)type.InvokeMember("ParseServiceDirective", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, null, new object[1] { serviceText }, CultureInfo.InvariantCulture);
			}
			catch (TargetInvocationException ex)
			{
				throw ex.InnerException;
			}
		}

		public static SvcFile OpenExisting(string fileName)
		{
			if (!File.Exists(fileName))
			{
				return null;
			}
			string serviceText = null;
			using (StreamReader streamReader = File.OpenText(fileName))
			{
				serviceText = streamReader.ReadToEnd();
			}
			IDictionary<string, string> dictionary = null;
			try
			{
				dictionary = ParseServiceDirective(serviceText);
			}
			catch (Exception ex)
			{
				if (ex is NullReferenceException || ex is SEHException)
				{
					throw ex;
				}
				ToolConsole.WriteWarning(SR.GetString("SvcFileParsingFailedWithError", fileName, ex.Message));
				return null;
			}
			if (dictionary == null)
			{
				return null;
			}
			if (dictionary.ContainsKey("Factory") && dictionary.ContainsKey("Service"))
			{
				_ = dictionary["Factory"];
				Type typeFromHandle = typeof(WasHostedComPlusFactory);
				Type type = typeFromHandle.Assembly.GetType(dictionary["Factory"], throwOnError: false);
				if (type != typeFromHandle)
				{
					return null;
				}
				string text = dictionary["Service"];
				string[] array = text.Split(new char[1] { ',' });
				if (array.Length != 2)
				{
					ToolConsole.WriteWarning(SR.GetString("BadlyFormattedSvcFile", fileName));
					return null;
				}
				Guid guid;
				Guid guid2;
				try
				{
					guid = new Guid(array[0]);
					guid2 = new Guid(array[1]);
				}
				catch (FormatException)
				{
					ToolConsole.WriteWarning(SR.GetString("BadlyFormattedAppIDOrClsidInSvcFile", fileName));
					return null;
				}
				return new SvcFile(guid2, guid, SvcFileState.Existing, new AtomicFile(fileName));
			}
			return null;
		}

		public void Abort()
		{
			svcFile.Abort();
		}

		public void Commit()
		{
			svcFile.Commit();
		}

		public void Delete()
		{
			svcFile.Delete();
			state = SvcFileState.Deleted;
		}

		public void Prepare()
		{
			svcFile.Prepare();
		}
	}

	private string webDirectoryPath;

	private Dictionary<Guid, SvcFile> svcFiles;

	public SvcFileManager(string webDirectoryPath)
	{
		this.webDirectoryPath = webDirectoryPath;
		svcFiles = new Dictionary<Guid, SvcFile>();
		string[] files = Directory.GetFiles(webDirectoryPath, "*.svc");
		string[] array = files;
		foreach (string fileName in array)
		{
			SvcFile svcFile = SvcFile.OpenExisting(fileName);
			if (svcFile != null)
			{
				svcFiles.Add(svcFile.Clsid, svcFile);
			}
		}
	}

	public void Abort()
	{
		foreach (SvcFile value in svcFiles.Values)
		{
			value.Abort();
		}
	}

	public void Add(Guid appid, Guid clsid)
	{
		SvcFile value = null;
		if (!svcFiles.TryGetValue(clsid, out value))
		{
			value = SvcFile.CreateNew(webDirectoryPath, appid, clsid);
			svcFiles.Add(clsid, value);
		}
	}

	public bool Remove(Guid appid, Guid clsid)
	{
		SvcFile value = null;
		if (svcFiles.TryGetValue(clsid, out value))
		{
			if (value.State == SvcFileState.Deleted)
			{
				return true;
			}
			value.Delete();
			return true;
		}
		return false;
	}

	public void Prepare()
	{
		foreach (SvcFile value in svcFiles.Values)
		{
			value.Prepare();
		}
	}

	public void Commit()
	{
		foreach (SvcFile value in svcFiles.Values)
		{
			value.Commit();
		}
	}

	public bool ResolveClsid(Guid clsid, out Guid appid)
	{
		appid = Guid.Empty;
		if (svcFiles.TryGetValue(clsid, out var value))
		{
			if (value.State == SvcFileState.Deleted)
			{
				return false;
			}
			appid = value.Appid;
			return true;
		}
		return false;
	}
}
