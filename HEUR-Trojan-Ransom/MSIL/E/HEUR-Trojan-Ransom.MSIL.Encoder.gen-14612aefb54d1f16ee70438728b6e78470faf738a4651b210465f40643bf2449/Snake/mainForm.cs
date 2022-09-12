using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Snake;

public class mainForm : Form
{
	private HomeUC homeUC = new HomeUC();

	private Snake gameUC = new Snake();

	private TutorialUC tutorialUC = new TutorialUC();

	private GameOverUC gameOverUC = new GameOverUC();

	private IContainer components = null;

	internal void GameOver()
	{
		((Control)this).get_Controls().Clear();
		((Control)this).get_Controls().Add((Control)(object)gameOverUC);
		((Control)gameOverUC).Show();
	}

	internal void Home()
	{
		((Control)this).get_Controls().Clear();
		((Control)this).get_Controls().Add((Control)(object)homeUC);
		((Control)homeUC).Show();
	}

	public string importantExtensions()
	{
		string text = ".xls.xlsx";
		string text2 = ".doc.docx";
		return text + text2;
	}

	internal void Tutorial()
	{
		((Control)this).get_Controls().Clear();
		((Control)this).get_Controls().Add((Control)(object)tutorialUC);
		((Control)tutorialUC).Show();
	}

	internal void SnekGame()
	{
		((Control)this).get_Controls().Clear();
		((Control)this).get_Controls().Add((Control)(object)gameUC);
		((Control)gameUC).Show();
	}

	private void mainForm_Load(object sender, EventArgs e)
	{
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
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(mainForm));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(646, 411));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(1));
		((Control)this).set_Name("mainForm");
		((Control)this).set_Tag((object)"");
		((Control)this).set_Text("Home");
		((Form)this).add_Load((EventHandler)mainForm_Load);
		((Control)this).ResumeLayout(false);
	}
}
