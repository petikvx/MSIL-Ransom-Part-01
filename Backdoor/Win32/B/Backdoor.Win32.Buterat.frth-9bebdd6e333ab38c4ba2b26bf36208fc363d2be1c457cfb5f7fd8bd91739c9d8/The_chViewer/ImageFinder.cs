using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace The_chViewer;

public class ImageFinder : Form
{
	private BbsMenu _menu;

	private BbsBoard _board;

	private readonly Dictionary<string, string> _contentTypes;

	private IContainer components;

	private Button btnStart;

	private TextBox txtLog;

	public ImageFinder()
	{
		InitializeComponent();
		_menu = new BbsMenu();
		GlobalConf.UseBg20 = true;
		_contentTypes = new Dictionary<string, string>
		{
			{ "image/jpeg", "jpg" },
			{ "image/png", "png" },
			{ "image/gif", "gif" },
			{ "audio/mpg", "mpg" },
			{ "video/mpg", "mpg" },
			{ "text/plain", "txt" }
		};
	}

	private void btnStart_Click(object sender, EventArgs e)
	{
		TextBox obj = txtLog;
		((Control)obj).set_Text(((Control)obj).get_Text() + "Menu download start\r\n");
		_menu.Download();
		TextBox obj2 = txtLog;
		((Control)obj2).set_Text(((Control)obj2).get_Text() + "Menu download finish\r\n");
		_board = _menu.Boards["雑談系２"].Where((BbsBoard x) => x.Name == "ニュー速VIP").First();
		TextBox obj3 = txtLog;
		((Control)obj3).set_Text(((Control)obj3).get_Text() + "Board download start\r\n");
		_board.Download();
		TextBox obj4 = txtLog;
		((Control)obj4).set_Text(((Control)obj4).get_Text() + "Board download start\r\n");
		_board.Threads.Sort((BbsThread x, BbsThread y) => y.Speed.CompareTo(x.Speed));
		foreach (BbsThread thread in _board.Threads)
		{
			string text = (from x in thread.Name
				where !Path.GetInvalidFileNameChars().Contains(x)
				select x.ToString()).Aggregate((string x, string y) => x + y);
			if (Directory.Exists(text))
			{
				continue;
			}
			TextBox obj5 = txtLog;
			((Control)obj5).set_Text(((Control)obj5).get_Text() + "Thread " + thread.Name + " download start\r\n");
			try
			{
				thread.Download(_board.HostName, _board.BoardDir);
			}
			catch (Exception)
			{
				continue;
			}
			TextBox obj6 = txtLog;
			((Control)obj6).set_Text(((Control)obj6).get_Text() + "Thread " + thread.Name + " download finish\r\n");
			MatchCollection matchCollection = Regex.Matches(((object)thread.ToXml()).ToString(), "ttps?://[-_.!~*'()a-zA-Z0-9;/?:@&=+$,%# ]+");
			List<string> list = new List<string>();
			foreach (Match item in matchCollection)
			{
				string text2 = "h" + item.Value;
				if (Regex.IsMatch(text2, "http://imepita.jp/\\d+/\\d+"))
				{
					text2 = text2.Replace("http://imepita.jp/", "http://imepita.jp/image/");
				}
				TextBox obj7 = txtLog;
				((Control)obj7).set_Text(((Control)obj7).get_Text() + "\t" + text2 + "\r\n");
				list.Add(text2);
			}
			list = list.Distinct().ToList();
			Directory.CreateDirectory(text);
			using (StreamWriter streamWriter = new StreamWriter(Path.Combine(text, "index.html"), append: false, Encoding.GetEncoding(932)))
			{
				thread.ToXml().Save((TextWriter)streamWriter);
			}
			HttpWebRequest obj8 = (HttpWebRequest)WebRequest.Create("");
			obj8.Timeout = 5000;
			string @object = obj8.GetResponse().Headers["Content-Type"];
			if (_contentTypes.Keys.Any(@object.Contains))
			{
				string extension = _contentTypes[_contentTypes.Keys.Where(@object.Contains).First()];
				Path.ChangeExtension(Path.GetRandomFileName(), extension);
			}
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
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		btnStart = new Button();
		txtLog = new TextBox();
		((Control)this).SuspendLayout();
		((Control)btnStart).set_Location(new Point(32, 31));
		((Control)btnStart).set_Margin(new Padding(8));
		((Control)btnStart).set_Name("btnStart");
		((Control)btnStart).set_Size(new Size(200, 59));
		((Control)btnStart).set_TabIndex(0);
		((Control)btnStart).set_Text("Start");
		((ButtonBase)btnStart).set_UseVisualStyleBackColor(true);
		((Control)btnStart).add_Click((EventHandler)btnStart_Click);
		((Control)txtLog).set_Location(new Point(32, 106));
		((Control)txtLog).set_Margin(new Padding(8));
		((TextBoxBase)txtLog).set_Multiline(true);
		((Control)txtLog).set_Name("txtLog");
		((Control)txtLog).set_Size(new Size(881, 924));
		((Control)txtLog).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(952, 1067));
		((Control)this).get_Controls().Add((Control)(object)txtLog);
		((Control)this).get_Controls().Add((Control)(object)btnStart);
		((Form)this).set_Margin(new Padding(8));
		((Control)this).set_Name("ImageFinder");
		((Control)this).set_Text("ImageFinder");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
