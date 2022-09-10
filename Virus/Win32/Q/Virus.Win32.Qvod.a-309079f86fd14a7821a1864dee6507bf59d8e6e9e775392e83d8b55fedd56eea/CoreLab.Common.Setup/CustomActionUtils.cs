using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CoreLab.Common.Setup;

internal class CustomActionUtils
{
	public const string LogFileName = "Install.log";

	public static void ShowMessage(string exception, bool logSaved, string productName)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			productName = ((productName == null || productName == "") ? "" : (productName.Trim() + " "));
			string text = Environment.NewLine + Environment.NewLine + "Please contact Core Lab support team if you cannot solve the problem.";
			if (logSaved)
			{
				string text2 = text;
				text = text2 + Environment.NewLine + "\"Install.log\" file saved in " + productName + "installation folder.";
			}
			if (productName != "")
			{
				productName = "Core Lab " + productName;
			}
			text = text + Environment.NewLine + Environment.NewLine + "This is not a fatal error, setup will continue after you press OK.";
			MessageBox.Show(exception + text, productName + "Setup Error", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		catch
		{
		}
	}

	public static bool WriteError(string directory, string customActionName, Exception ex)
	{
		return WriteError(directory, customActionName, null, ex);
	}

	public static bool WriteError(string directory, string customActionName, string productName, Exception ex)
	{
		try
		{
			string text = directory;
			char directorySeparatorChar = Path.DirectorySeparatorChar;
			if (!text.EndsWith(directorySeparatorChar.ToString()))
			{
				string text2 = directory;
				char directorySeparatorChar2 = Path.DirectorySeparatorChar;
				directory = text2 + directorySeparatorChar2;
			}
			string path = directory + "Install.log";
			using (StreamWriter streamWriter = new StreamWriter(path, append: true))
			{
				streamWriter.WriteLine("--- Custom action error: " + customActionName);
				if (productName != null)
				{
					streamWriter.WriteLine("Product name: " + productName);
				}
				streamWriter.WriteLine("Date: " + DateTime.Now.ToString("G"));
				streamWriter.WriteLine("Environment");
				streamWriter.WriteLine("  Operating System: " + Environment.OSVersion.ToString());
				streamWriter.WriteLine("  .NET Framework: " + Environment.Version.ToString());
				streamWriter.WriteLine("Assembly: " + Assembly.GetExecutingAssembly().FullName);
				streamWriter.WriteLine("Exception");
				streamWriter.WriteLine("  Message: " + ex.Message);
				streamWriter.WriteLine("  Type: " + ((object)ex).GetType().FullName);
				streamWriter.WriteLine("  StackTrace:" + ex.StackTrace);
				if (ex is CustomActionException)
				{
					streamWriter.WriteLine("  CustomMessage: " + ((CustomActionException)ex).Hypothesis);
				}
				else if (ex is Win32Exception)
				{
					Win32Exception ex2 = (Win32Exception)ex;
					streamWriter.WriteLine("  ErrorCode: " + ex2.ErrorCode);
					streamWriter.WriteLine("  NativeErrorCode: " + ex2.NativeErrorCode);
				}
				if (ex.InnerException != null)
				{
					streamWriter.WriteLine("  Inner Exception");
					streamWriter.WriteLine("    Message: " + ex.Message);
					streamWriter.WriteLine("    Type: " + ((object)ex).GetType().FullName);
					if (ex is Win32Exception)
					{
						Win32Exception ex3 = (Win32Exception)ex;
						streamWriter.WriteLine("  ErrorCode: " + ex3.ErrorCode);
						streamWriter.WriteLine("  NativeErrorCode: " + ex3.NativeErrorCode);
					}
					streamWriter.WriteLine("    StackTrace:" + ex.StackTrace);
				}
				streamWriter.WriteLine();
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool CheckIdeExists(string regKey, string value)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(regKey);
			if (registryKey != null)
			{
				string text = (string)registryKey.GetValue(value, "");
				return text != "" && Directory.Exists(text);
			}
			return false;
		}
		catch (SecurityException ex)
		{
			throw new CustomActionException(ex, "Insufficient privileges to read from registry.");
		}
	}
}
