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

public class SettingWindow : Window, INotifyPropertyChanged, IComponentConnector
{
	private string publicKey;

	private string product;

	private string productVersion;

	private string publicKeyID;

	internal Button bt_importPublicKey;

	internal Button bt_OK;

	internal Button bt_Cancel;

	private bool _contentLoaded;

	public string PublicKey
	{
		get
		{
			return publicKey;
		}
		set
		{
			if (value != publicKey)
			{
				publicKey = value;
				Notify("PublicKey");
			}
		}
	}

	public string Product
	{
		get
		{
			return product;
		}
		set
		{
			if (value != product)
			{
				product = value;
				Notify("Product");
			}
		}
	}

	public string ProductVersion
	{
		get
		{
			return productVersion;
		}
		set
		{
			if (value != productVersion)
			{
				productVersion = value;
				Notify("ProductVersion");
			}
		}
	}

	public string PublicKeyID
	{
		get
		{
			return publicKeyID;
		}
		set
		{
			if (value != publicKeyID)
			{
				publicKeyID = value;
				Notify("PublicKeyID");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public SettingWindow()
	{
		InitializeComponent();
		((FrameworkElement)this).set_DataContext((object)this);
	}

	private void bt_OK_Click(object sender, RoutedEventArgs e)
	{
		((Window)this).set_DialogResult((bool?)true);
	}

	private void Notify(string propName)
	{
		if (this.PropertyChanged != null)
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}
	}

	private void bt_importPublicKey_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_DefaultExt(".xml");
		((FileDialog)val).set_Filter(Resources.XML_File_Type);
		((FileDialog)val).set_Title(Resources.DialogTitle_SelectPublicKey);
		if (((CommonDialog)val).ShowDialog((Window)(object)this) == true)
		{
			using (StreamReader streamReader = File.OpenText(((FileDialog)val).get_FileName()))
			{
				PublicKey = streamReader.ReadToEnd();
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/Islem Dekontunuz;component/settingwindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			bt_importPublicKey = (Button)target;
			((ButtonBase)bt_importPublicKey).add_Click(new RoutedEventHandler(bt_importPublicKey_Click));
			break;
		case 2:
			bt_OK = (Button)target;
			((ButtonBase)bt_OK).add_Click(new RoutedEventHandler(bt_OK_Click));
			break;
		case 3:
			bt_Cancel = (Button)target;
			break;
		}
	}
}
