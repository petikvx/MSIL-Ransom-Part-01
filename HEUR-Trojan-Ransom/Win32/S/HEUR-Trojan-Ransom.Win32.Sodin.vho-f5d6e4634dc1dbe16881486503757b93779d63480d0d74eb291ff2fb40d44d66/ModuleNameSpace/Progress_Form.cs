using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Management.Automation;
using System.Timers;
using System.Windows.Forms;

namespace ModuleNameSpace;

public class Progress_Form : Form
{
	private struct Progress_Data
	{
		internal Label lbActivity;

		internal Label lbStatus;

		internal ProgressBar objProgressBar;

		internal Label lbRemainingTime;

		internal Label lbOperation;

		internal int ActivityId;

		internal int ParentActivityId;

		internal int Depth;
	}

	private ConsoleColor ProgressBarColor = ConsoleColor.DarkCyan;

	private Timer timer = new Timer();

	private int barNumber = -1;

	private int barValue = -1;

	private bool inTick;

	private List<Progress_Data> progressDataList = new List<Progress_Data>();

	private Color DrawingColor(ConsoleColor color)
	{
		return color switch
		{
			ConsoleColor.Black => Color.Black, 
			ConsoleColor.Blue => Color.Blue, 
			ConsoleColor.Cyan => Color.Cyan, 
			ConsoleColor.DarkBlue => ColorTranslator.FromHtml("#000080"), 
			ConsoleColor.DarkGray => ColorTranslator.FromHtml("#808080"), 
			ConsoleColor.DarkGreen => ColorTranslator.FromHtml("#008000"), 
			ConsoleColor.DarkCyan => ColorTranslator.FromHtml("#008080"), 
			ConsoleColor.DarkMagenta => ColorTranslator.FromHtml("#800080"), 
			ConsoleColor.DarkRed => ColorTranslator.FromHtml("#800000"), 
			ConsoleColor.DarkYellow => ColorTranslator.FromHtml("#808000"), 
			ConsoleColor.Gray => ColorTranslator.FromHtml("#C0C0C0"), 
			ConsoleColor.Green => ColorTranslator.FromHtml("#00FF00"), 
			ConsoleColor.Magenta => Color.Magenta, 
			ConsoleColor.Red => Color.Red, 
			ConsoleColor.White => Color.White, 
			_ => Color.Yellow, 
		};
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((ScrollableControl)this).set_AutoScroll(true);
		((Control)this).set_Text(AppDomain.CurrentDomain.FriendlyName);
		((Control)this).set_Height(147);
		((Control)this).set_Width(800);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_ControlBox(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout();
		timer.Elapsed += TimeTick;
		timer.Interval = 50.0;
		timer.AutoReset = true;
		timer.Start();
	}

	private void TimeTick(object source, ElapsedEventArgs e)
	{
		if (inTick)
		{
			return;
		}
		inTick = true;
		if (barNumber >= 0)
		{
			if (barValue >= 0)
			{
				progressDataList[barNumber].objProgressBar.set_Value(barValue);
				barValue = -1;
			}
			((Control)progressDataList[barNumber].objProgressBar).Refresh();
		}
		inTick = false;
	}

	private void AddBar(ref Progress_Data pd, int position)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		pd.lbActivity = new Label();
		((Control)pd.lbActivity).set_Left(5);
		((Control)pd.lbActivity).set_Top(104 * position + 10);
		((Control)pd.lbActivity).set_Width(780);
		((Control)pd.lbActivity).set_Height(16);
		((Control)pd.lbActivity).set_Font(new Font(((Control)pd.lbActivity).get_Font(), (FontStyle)1));
		((Control)pd.lbActivity).set_Text("");
		((Control)this).get_Controls().Add((Control)(object)pd.lbActivity);
		pd.lbStatus = new Label();
		((Control)pd.lbStatus).set_Left(25);
		((Control)pd.lbStatus).set_Top(104 * position + 26);
		((Control)pd.lbStatus).set_Width(760);
		((Control)pd.lbStatus).set_Height(16);
		((Control)pd.lbStatus).set_Text("");
		((Control)this).get_Controls().Add((Control)(object)pd.lbStatus);
		pd.objProgressBar = new ProgressBar();
		pd.objProgressBar.set_Value(0);
		pd.objProgressBar.set_Style((ProgressBarStyle)0);
		((Control)pd.objProgressBar).set_ForeColor(DrawingColor(ProgressBarColor));
		if (pd.Depth < 15)
		{
			((Control)pd.objProgressBar).set_Size(new Size(740 - 30 * pd.Depth, 20));
			((Control)pd.objProgressBar).set_Left(25 + 30 * pd.Depth);
		}
		else
		{
			((Control)pd.objProgressBar).set_Size(new Size(290, 20));
			((Control)pd.objProgressBar).set_Left(475);
		}
		((Control)pd.objProgressBar).set_Top(104 * position + 47);
		((Control)this).get_Controls().Add((Control)(object)pd.objProgressBar);
		pd.lbRemainingTime = new Label();
		((Control)pd.lbRemainingTime).set_Left(5);
		((Control)pd.lbRemainingTime).set_Top(104 * position + 72);
		((Control)pd.lbRemainingTime).set_Width(780);
		((Control)pd.lbRemainingTime).set_Height(16);
		((Control)pd.lbRemainingTime).set_Text("");
		((Control)this).get_Controls().Add((Control)(object)pd.lbRemainingTime);
		pd.lbOperation = new Label();
		((Control)pd.lbOperation).set_Left(25);
		((Control)pd.lbOperation).set_Top(104 * position + 88);
		((Control)pd.lbOperation).set_Width(760);
		((Control)pd.lbOperation).set_Height(16);
		((Control)pd.lbOperation).set_Text("");
		((Control)this).get_Controls().Add((Control)(object)pd.lbOperation);
	}

	public int GetCount()
	{
		return progressDataList.Count;
	}

	public Progress_Form()
	{
		InitializeComponent();
	}

	public Progress_Form(ConsoleColor BarColor)
	{
		ProgressBarColor = BarColor;
		InitializeComponent();
	}

	public void Update(ProgressRecord objRecord)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		if (objRecord == null)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < progressDataList.Count; i++)
		{
			if (progressDataList[i].ActivityId == objRecord.get_ActivityId())
			{
				num = i;
				break;
			}
		}
		if ((int)objRecord.get_RecordType() == 1)
		{
			if (num >= 0)
			{
				if (barNumber == num)
				{
					barNumber = -1;
				}
				((Control)this).get_Controls().Remove((Control)(object)progressDataList[num].lbActivity);
				((Control)this).get_Controls().Remove((Control)(object)progressDataList[num].lbStatus);
				((Control)this).get_Controls().Remove((Control)(object)progressDataList[num].objProgressBar);
				((Control)this).get_Controls().Remove((Control)(object)progressDataList[num].lbRemainingTime);
				((Control)this).get_Controls().Remove((Control)(object)progressDataList[num].lbOperation);
				((Component)(object)progressDataList[num].lbActivity).Dispose();
				((Component)(object)progressDataList[num].lbStatus).Dispose();
				((Component)(object)progressDataList[num].objProgressBar).Dispose();
				((Component)(object)progressDataList[num].lbRemainingTime).Dispose();
				((Component)(object)progressDataList[num].lbOperation).Dispose();
				progressDataList.RemoveAt(num);
			}
			if (progressDataList.Count == 0)
			{
				timer.Stop();
				timer.Dispose();
				((Form)this).Close();
			}
			else if (num >= 0)
			{
				for (int j = num; j < progressDataList.Count; j++)
				{
					((Control)progressDataList[j].lbActivity).set_Top(104 * j + 10);
					((Control)progressDataList[j].lbStatus).set_Top(104 * j + 26);
					((Control)progressDataList[j].objProgressBar).set_Top(104 * j + 47);
					((Control)progressDataList[j].lbRemainingTime).set_Top(104 * j + 72);
					((Control)progressDataList[j].lbOperation).set_Top(104 * j + 88);
				}
				if (104 * progressDataList.Count + 43 <= Screen.FromControl((Control)(object)this).get_Bounds().Height)
				{
					((Control)this).set_Height(104 * progressDataList.Count + 43);
					((Form)this).set_Location(new Point((Screen.FromControl((Control)(object)this).get_Bounds().Width - ((Control)this).get_Width()) / 2, (Screen.FromControl((Control)(object)this).get_Bounds().Height - ((Control)this).get_Height()) / 2));
				}
				else
				{
					((Control)this).set_Height(Screen.FromControl((Control)(object)this).get_Bounds().Height);
					((Form)this).set_Location(new Point((Screen.FromControl((Control)(object)this).get_Bounds().Width - ((Control)this).get_Width()) / 2, 0));
				}
			}
			return;
		}
		if (num < 0)
		{
			Progress_Data pd = default(Progress_Data);
			pd.ActivityId = objRecord.get_ActivityId();
			pd.ParentActivityId = objRecord.get_ParentActivityId();
			pd.Depth = 0;
			int num2 = -1;
			int num3 = -1;
			if (pd.ParentActivityId >= 0)
			{
				for (int k = 0; k < progressDataList.Count; k++)
				{
					if (progressDataList[k].ActivityId == pd.ParentActivityId)
					{
						num3 = k;
						break;
					}
				}
			}
			if (num3 >= 0)
			{
				pd.Depth = progressDataList[num3].Depth + 1;
				for (int l = num3 + 1; l < progressDataList.Count; l++)
				{
					if (progressDataList[l].Depth < pd.Depth || (progressDataList[l].Depth == pd.Depth && progressDataList[l].ParentActivityId != pd.ParentActivityId))
					{
						num2 = l;
						break;
					}
				}
			}
			if (num2 == -1)
			{
				AddBar(ref pd, progressDataList.Count);
				num = progressDataList.Count;
				progressDataList.Add(pd);
			}
			else
			{
				AddBar(ref pd, num2);
				num = num2;
				progressDataList.Insert(num2, pd);
				for (int m = num + 1; m < progressDataList.Count; m++)
				{
					((Control)progressDataList[m].lbActivity).set_Top(104 * m + 10);
					((Control)progressDataList[m].lbStatus).set_Top(104 * m + 26);
					((Control)progressDataList[m].objProgressBar).set_Top(104 * m + 47);
					((Control)progressDataList[m].lbRemainingTime).set_Top(104 * m + 72);
					((Control)progressDataList[m].lbOperation).set_Top(104 * m + 88);
				}
			}
			if (104 * progressDataList.Count + 43 <= Screen.FromControl((Control)(object)this).get_Bounds().Height)
			{
				((Control)this).set_Height(104 * progressDataList.Count + 43);
				((Form)this).set_Location(new Point((Screen.FromControl((Control)(object)this).get_Bounds().Width - ((Control)this).get_Width()) / 2, (Screen.FromControl((Control)(object)this).get_Bounds().Height - ((Control)this).get_Height()) / 2));
			}
			else
			{
				((Control)this).set_Height(Screen.FromControl((Control)(object)this).get_Bounds().Height);
				((Form)this).set_Location(new Point((Screen.FromControl((Control)(object)this).get_Bounds().Width - ((Control)this).get_Width()) / 2, 0));
			}
		}
		if (!string.IsNullOrEmpty(objRecord.get_Activity()))
		{
			((Control)progressDataList[num].lbActivity).set_Text(objRecord.get_Activity());
		}
		else
		{
			((Control)progressDataList[num].lbActivity).set_Text("");
		}
		if (!string.IsNullOrEmpty(objRecord.get_StatusDescription()))
		{
			((Control)progressDataList[num].lbStatus).set_Text(objRecord.get_StatusDescription());
		}
		else
		{
			((Control)progressDataList[num].lbStatus).set_Text("");
		}
		if (objRecord.get_PercentComplete() >= 0 && objRecord.get_PercentComplete() <= 100)
		{
			if (objRecord.get_PercentComplete() < 100)
			{
				progressDataList[num].objProgressBar.set_Value(objRecord.get_PercentComplete() + 1);
			}
			else
			{
				progressDataList[num].objProgressBar.set_Value(99);
			}
			((Control)progressDataList[num].objProgressBar).set_Visible(true);
			barNumber = num;
			barValue = objRecord.get_PercentComplete();
		}
		else if (objRecord.get_PercentComplete() > 100)
		{
			progressDataList[num].objProgressBar.set_Value(0);
			((Control)progressDataList[num].objProgressBar).set_Visible(true);
			barNumber = num;
			barValue = 0;
		}
		else
		{
			((Control)progressDataList[num].objProgressBar).set_Visible(false);
			if (barNumber == num)
			{
				barNumber = -1;
			}
		}
		if (objRecord.get_SecondsRemaining() >= 0)
		{
			TimeSpan timeSpan = new TimeSpan(0, 0, objRecord.get_SecondsRemaining());
			((Control)progressDataList[num].lbRemainingTime).set_Text("Remaining time: " + $"{(int)timeSpan.TotalHours:00}:{timeSpan.Minutes:00}:{timeSpan.Seconds:00}");
		}
		else
		{
			((Control)progressDataList[num].lbRemainingTime).set_Text("");
		}
		if (!string.IsNullOrEmpty(objRecord.get_CurrentOperation()))
		{
			((Control)progressDataList[num].lbOperation).set_Text(objRecord.get_CurrentOperation());
		}
		else
		{
			((Control)progressDataList[num].lbOperation).set_Text("");
		}
		Application.DoEvents();
	}
}
