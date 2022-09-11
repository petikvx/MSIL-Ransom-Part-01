using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Management.Automation;
using System.Timers;
using System.Windows.Forms;

namespace ik.PowerShell;

public class ProgressForm : Form
{
	private struct ProgressData
	{
		internal Label lblActivity;

		internal Label lblStatus;

		internal ProgressBar objProgressBar;

		internal Label lblRemainingTime;

		internal Label lblOperation;

		internal int ActivityId;

		internal int ParentActivityId;

		internal int Depth;
	}

	private ConsoleColor ProgressBarColor = ConsoleColor.DarkCyan;

	private Timer timer = new Timer();

	private int barNumber = -1;

	private int barValue = -1;

	private bool inTick;

	private List<ProgressData> progressDataList = new List<ProgressData>();

	private Color DrawingColor(ConsoleColor color)
	{
		return color switch
		{
			ConsoleColor.Black => Color.Black, 
			ConsoleColor.DarkBlue => ColorTranslator.FromHtml("#000080"), 
			ConsoleColor.DarkGreen => ColorTranslator.FromHtml("#008000"), 
			ConsoleColor.DarkCyan => ColorTranslator.FromHtml("#008080"), 
			ConsoleColor.DarkRed => ColorTranslator.FromHtml("#800000"), 
			ConsoleColor.DarkMagenta => ColorTranslator.FromHtml("#800080"), 
			ConsoleColor.DarkYellow => ColorTranslator.FromHtml("#808000"), 
			ConsoleColor.Gray => ColorTranslator.FromHtml("#C0C0C0"), 
			ConsoleColor.DarkGray => ColorTranslator.FromHtml("#808080"), 
			ConsoleColor.Blue => Color.Blue, 
			ConsoleColor.Green => ColorTranslator.FromHtml("#00FF00"), 
			ConsoleColor.Cyan => Color.Cyan, 
			ConsoleColor.Red => Color.Red, 
			ConsoleColor.Magenta => Color.Magenta, 
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

	private void TimeTick(object sender, ElapsedEventArgs e)
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

	private void AddBar(ref ProgressData pd, int position)
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
		pd.lblActivity = new Label();
		((Control)pd.lblActivity).set_Left(5);
		((Control)pd.lblActivity).set_Top(104 * position + 10);
		((Control)pd.lblActivity).set_Width(780);
		((Control)pd.lblActivity).set_Height(16);
		((Control)pd.lblActivity).set_Font(new Font(((Control)pd.lblActivity).get_Font(), (FontStyle)1));
		((Control)pd.lblActivity).set_Text("");
		((Control)this).get_Controls().Add((Control)(object)pd.lblActivity);
		pd.lblStatus = new Label();
		((Control)pd.lblStatus).set_Left(25);
		((Control)pd.lblStatus).set_Top(104 * position + 26);
		((Control)pd.lblStatus).set_Width(760);
		((Control)pd.lblStatus).set_Height(16);
		((Control)pd.lblStatus).set_Text("");
		((Control)this).get_Controls().Add((Control)(object)pd.lblStatus);
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
		pd.lblRemainingTime = new Label();
		((Control)pd.lblRemainingTime).set_Left(5);
		((Control)pd.lblRemainingTime).set_Top(104 * position + 72);
		((Control)pd.lblRemainingTime).set_Width(780);
		((Control)pd.lblRemainingTime).set_Height(16);
		((Control)pd.lblRemainingTime).set_Text("");
		((Control)this).get_Controls().Add((Control)(object)pd.lblRemainingTime);
		pd.lblOperation = new Label();
		((Control)pd.lblOperation).set_Left(25);
		((Control)pd.lblOperation).set_Top(104 * position + 88);
		((Control)pd.lblOperation).set_Width(760);
		((Control)pd.lblOperation).set_Height(16);
		((Control)pd.lblOperation).set_Text("");
		((Control)this).get_Controls().Add((Control)(object)pd.lblOperation);
	}

	public int GetCount()
	{
		return progressDataList.Count;
	}

	public ProgressForm()
	{
		InitializeComponent();
	}

	public ProgressForm(ConsoleColor BarColor)
	{
		ProgressBarColor = BarColor;
		InitializeComponent();
	}

	public void Update(ProgressRecord objRecord)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
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
				((Control)this).get_Controls().Remove((Control)(object)progressDataList[num].lblActivity);
				((Control)this).get_Controls().Remove((Control)(object)progressDataList[num].lblStatus);
				((Control)this).get_Controls().Remove((Control)(object)progressDataList[num].objProgressBar);
				((Control)this).get_Controls().Remove((Control)(object)progressDataList[num].lblRemainingTime);
				((Control)this).get_Controls().Remove((Control)(object)progressDataList[num].lblOperation);
				((Component)(object)progressDataList[num].lblActivity).Dispose();
				((Component)(object)progressDataList[num].lblStatus).Dispose();
				((Component)(object)progressDataList[num].objProgressBar).Dispose();
				((Component)(object)progressDataList[num].lblRemainingTime).Dispose();
				((Component)(object)progressDataList[num].lblOperation).Dispose();
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
					((Control)progressDataList[j].lblActivity).set_Top(104 * j + 10);
					((Control)progressDataList[j].lblStatus).set_Top(104 * j + 26);
					((Control)progressDataList[j].objProgressBar).set_Top(104 * j + 47);
					((Control)progressDataList[j].lblRemainingTime).set_Top(104 * j + 72);
					((Control)progressDataList[j].lblOperation).set_Top(104 * j + 88);
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
			ProgressData pd = default(ProgressData);
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
					((Control)progressDataList[m].lblActivity).set_Top(104 * m + 10);
					((Control)progressDataList[m].lblStatus).set_Top(104 * m + 26);
					((Control)progressDataList[m].objProgressBar).set_Top(104 * m + 47);
					((Control)progressDataList[m].lblRemainingTime).set_Top(104 * m + 72);
					((Control)progressDataList[m].lblOperation).set_Top(104 * m + 88);
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
			((Control)progressDataList[num].lblActivity).set_Text(objRecord.get_Activity());
		}
		else
		{
			((Control)progressDataList[num].lblActivity).set_Text("");
		}
		if (!string.IsNullOrEmpty(objRecord.get_StatusDescription()))
		{
			((Control)progressDataList[num].lblStatus).set_Text(objRecord.get_StatusDescription());
		}
		else
		{
			((Control)progressDataList[num].lblStatus).set_Text("");
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
			((Control)progressDataList[num].lblRemainingTime).set_Text("Remaining time: " + $"{(int)timeSpan.TotalHours:00}:{timeSpan.Minutes:00}:{timeSpan.Seconds:00}");
		}
		else
		{
			((Control)progressDataList[num].lblRemainingTime).set_Text("");
		}
		if (!string.IsNullOrEmpty(objRecord.get_CurrentOperation()))
		{
			((Control)progressDataList[num].lblOperation).set_Text(objRecord.get_CurrentOperation());
		}
		else
		{
			((Control)progressDataList[num].lblOperation).set_Text("");
		}
		Application.DoEvents();
	}
}
