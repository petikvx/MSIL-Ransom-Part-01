using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using FileEncryptor.Properties;
using Microsoft.Win32;

namespace FileEncryptor;

public class DecryptionSettingWindow : Window, INotifyPropertyChanged, IComponentConnector
{
	private string key;

	private string manifestFilePath;

	internal TextBox tb_descryptKey;

	internal TextBox tb_manifestPath;

	internal Button bt_selManifest;

	internal Button bt_importDescryptKey;

	internal Button bt_OK;

	private bool _contentLoaded;

	public string Key
	{
		get
		{
			return key;
		}
		set
		{
			if (value != key)
			{
				key = value;
				Notify("Key");
			}
		}
	}

	public string ManifestFilePath
	{
		get
		{
			return manifestFilePath;
		}
		set
		{
			if (value != manifestFilePath)
			{
				manifestFilePath = value;
				Notify("ManifestFilePath");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public DecryptionSettingWindow()
	{
		InitializeComponent();
		((FrameworkElement)this).set_DataContext((object)this);
	}

	private void Notify(string propName)
	{
		if (this.PropertyChanged != null)
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}
	}

	private void EnableSelectManifest(bool enable)
	{
		((UIElement)tb_manifestPath).set_IsEnabled(enable);
		((UIElement)bt_selManifest).set_IsEnabled(enable);
	}

	private void bt_selManifest_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_DefaultExt(".xml");
		((FileDialog)val).set_Filter(Resources.XML_File_Type);
		((FileDialog)val).set_Title(Resources.DialogTitle_SelectManifest);
		if (((CommonDialog)val).ShowDialog() == true)
		{
			ManifestFilePath = ((FileDialog)val).get_FileName();
		}
	}

	private void bt_importDescryptKey_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_DefaultExt(".xml");
		((FileDialog)val).set_Filter(Resources.XML_File_Type);
		((FileDialog)val).set_Title(Resources.DialogTitle_SelectKey);
		if (((CommonDialog)val).ShowDialog() == true)
		{
			using (StreamReader streamReader = File.OpenText(((FileDialog)val).get_FileName()))
			{
				Key = streamReader.ReadToEnd();
			}
		}
	}

	private void bt_OK_Click(object sender, RoutedEventArgs e)
	{
		((Window)this).set_DialogResult((bool?)true);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/Islem Dekontunuz;component/decryptionsettingwindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			tb_descryptKey = (TextBox)target;
			break;
		case 2:
			tb_manifestPath = (TextBox)target;
			break;
		case 3:
			bt_selManifest = (Button)target;
			((ButtonBase)bt_selManifest).add_Click(new RoutedEventHandler(bt_selManifest_Click));
			break;
		case 4:
			bt_importDescryptKey = (Button)target;
			((ButtonBase)bt_importDescryptKey).add_Click(new RoutedEventHandler(bt_importDescryptKey_Click));
			break;
		case 5:
			bt_OK = (Button)target;
			((ButtonBase)bt_OK).add_Click(new RoutedEventHandler(bt_OK_Click));
			break;
		}
	}
}
