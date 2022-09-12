using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;

namespace chicken;

public class Form3 : Form
{
	public delegate void del1();

	public static Form1 form1;

	public static bool start = false;

	[CompilerGenerated]
	private bool lWORpZeHvPRdYNnYaeehFBFJsHnXA;

	public static string linlauncher = "mrlinpatch.bin";

	private IContainer kIRxdvplOwoJsmagcKCtTAqXYlCQ;

	private Label XJdmepMaRYKlbXjQBhsAOOWHILEQ;

	private bool sbWkZgOGsqrpSKwnMrqDJFMnHJKH
	{
		[CompilerGenerated]
		get
		{
			return lWORpZeHvPRdYNnYaeehFBFJsHnXA;
		}
		[CompilerGenerated]
		set
		{
			lWORpZeHvPRdYNnYaeehFBFJsHnXA = value;
		}
	}

	public Form3()
	{
		tSSxvWKRPTkncrJVVkMRgnrXomxK();
	}

	private void jaPlWWOyHHWCseOSkFVpIOuiGohA()
	{
	}

	private void kGwdjalUpEDNWgasgGnJPKkrJWOCb(object sender, EventArgs e)
	{
		Labelchange("패치 준비 중입니다. \r\n잠시만 기다려 주세요.");
		NrNTeTusZlMYqaIjPANvjqYhljih();
	}

	private void NrNTeTusZlMYqaIjPANvjqYhljih()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		Labelchange("패치 다운로드 중입니다. \r\n잠시만 기다려 주세요.");
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.3; WOW64; Trident/7.0)");
		string fileName = string.Format("patch.zip", Path.GetFileName(oTzCbQahDtBcmUHskeqoGKJDqscS("patch")));
		try
		{
			webClient.DownloadFileCompleted += zOxGcidzjtwiyrCpkRirKMdkzOLeA;
			webClient.DownloadFileAsync(new Uri(oTzCbQahDtBcmUHskeqoGKJDqscS("patch")), fileName);
		}
		catch (Exception ex)
		{
			sbWkZgOGsqrpSKwnMrqDJFMnHJKH = false;
			MessageBox.Show(ex.Message, ex.GetType().FullName, (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void zOxGcidzjtwiyrCpkRirKMdkzOLeA(object sender, AsyncCompletedEventArgs e)
	{
		if (e.Cancelled)
		{
			sbWkZgOGsqrpSKwnMrqDJFMnHJKH = false;
			Labelchange("다운로드가 실패 하였습니다." + e.Error!.Message.ToString());
		}
		else
		{
			sbWkZgOGsqrpSKwnMrqDJFMnHJKH = true;
			Labelchange("패치 다운로드 완료되었습니다. \r\n잠시만 기다려 주세요.");
		}
		if (sbWkZgOGsqrpSKwnMrqDJFMnHJKH)
		{
			Thread.Sleep(300);
			if (!cNCEXSDvEAjJLnHsRONNOwyAHiogA("patch.zip", Application.get_StartupPath() + "\\", isDeleteZipFile: true))
			{
				Labelchange("패치 압축 풀기에 실패 하였습니다. \r\n운영자에게 문의 주세요.");
			}
			else
			{
				tdbmGXkgblQFfSvxKjynmiFWeTcq();
			}
		}
	}

	private bool cNCEXSDvEAjJLnHsRONNOwyAHiogA(string zipFilePath, string unZipTargetFolderPath, bool isDeleteZipFile)
	{
		Labelchange("패치 압축을 푸는중 입니다. \r\n잠시만 기다려 주세요.");
		bool result = false;
		if (File.Exists(zipFilePath))
		{
			ZipInputStream zipInputStream = new ZipInputStream(File.OpenRead(zipFilePath));
			try
			{
				ZipEntry nextEntry;
				while ((nextEntry = zipInputStream.GetNextEntry()) != null)
				{
					string directoryName = Path.GetDirectoryName(nextEntry.Name);
					string? fileName = Path.GetFileName(nextEntry.Name);
					Directory.CreateDirectory(unZipTargetFolderPath + directoryName);
					if (!(fileName != string.Empty))
					{
						continue;
					}
					FileStream fileStream = File.Create(unZipTargetFolderPath + nextEntry.Name);
					byte[] array = new byte[2048];
					while (true)
					{
						int num = zipInputStream.Read(array, 0, array.Length);
						if (num <= 0)
						{
							break;
						}
						fileStream.Write(array, 0, num);
					}
					fileStream.Close();
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			finally
			{
				zipInputStream.Close();
			}
			if (isDeleteZipFile)
			{
				try
				{
					Labelchange("패치파일 삭제를 시작합니다. \r\n잠시만 기다려 주세요.");
					FileInfo fileInfo = new FileInfo(zipFilePath);
					if (fileInfo.Exists)
					{
						fileInfo.Attributes = FileAttributes.Normal;
						fileInfo.Delete();
					}
					Labelchange("패치파일 삭제 완료. \r\n잠시만 기다려 주세요.");
					return result;
				}
				catch
				{
					return result;
				}
			}
		}
		return result;
	}

	private string CtQXAfuhBMDkWjUjGlkkkqDURwoCA(string string_0)
	{
		string result = null;
		int num = string_0.LastIndexOf('\\');
		if (num > 0)
		{
			result = string_0.Substring(0, num);
		}
		else
		{
			num = string_0.LastIndexOf('/');
			if (num > 0)
			{
				result = string_0.Substring(0, num);
			}
		}
		return result;
	}

	public void patchrun()
	{
		Labelchange("패치를 묶는중 입니다. \r\n잠시만 기다려 주세요.");
		Process? process = Process.Start(new ProcessStartInfo
		{
			FileName = linlauncher,
			UseShellExecute = false
		});
		process!.WaitForExit();
		process!.Close();
		Labelchange("패치 적용이 완료 되었습니다. \r\n곧 메세지창이 자동 종료됩니다.");
		Thread.Sleep(3000);
		new del1((((Form)this).get_Owner() as Form1).Decrementer)();
		Form1.PatchButton = true;
		IntPtr hWnd = Form1.FindWindow(null, "Patch_Updating");
		if (hWnd.ToString() != "0")
		{
			Thread.Sleep(1000);
			Form1.SendMessage(hWnd, 16u, 0, 0);
		}
	}

	private string oTzCbQahDtBcmUHskeqoGKJDqscS(string type)
	{
		return Form2.webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("[/", "").Split(new string[1] { "[/patch]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	private void tdbmGXkgblQFfSvxKjynmiFWeTcq()
	{
		byte[] dgxFXeizGZYvpnLEqfqrVpzmkKmQA = MSAUTUPHneiORKmKBtJIyxNHIUTV.DgxFXeizGZYvpnLEqfqrVpzmkKmQA;
		FileStream fileStream = new FileStream(new FileInfo(linlauncher).FullName, FileMode.Create);
		fileStream.Write(dgxFXeizGZYvpnLEqfqrVpzmkKmQA, 0, dgxFXeizGZYvpnLEqfqrVpzmkKmQA.Length);
		fileStream.Close();
		Thread.Sleep(3000);
		patchrun();
	}

	public static void Message(string ment, string subject)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(ment, subject);
	}

	public void Labelchange(string ment)
	{
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Enabled(false);
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Text(ment);
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Enabled(true);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && kIRxdvplOwoJsmagcKCtTAqXYlCQ != null)
		{
			kIRxdvplOwoJsmagcKCtTAqXYlCQ.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void tSSxvWKRPTkncrJVVkMRgnrXomxK()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
		XJdmepMaRYKlbXjQBhsAOOWHILEQ = new Label();
		((Control)this).SuspendLayout();
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_BackColor(Color.Transparent);
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Font(new Font("굴림", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)129));
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_ForeColor(Color.White);
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Location(new Point(28, 29));
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Name("label1");
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Size(new Size(241, 44));
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackColor(SystemColors.Info);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(291, 92));
		((Control)this).get_Controls().Add((Control)(object)XJdmepMaRYKlbXjQBhsAOOWHILEQ);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form3");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Patch_Updating");
		((Form)this).set_TransparencyKey(SystemColors.Info);
		((Form)this).add_Load((EventHandler)kGwdjalUpEDNWgasgGnJPKkrJWOCb);
		((Control)this).ResumeLayout(false);
	}
}
