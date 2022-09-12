using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns10;

public class GClass1
{
	public Random random_0;

	public PictureBox pictureBox_0;

	public int int_0;

	public bool bool_0;

	private int int_1;

	private int int_2;

	private int int_3;

	public Random random_1;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public GClass1()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		random_0 = new Random();
		pictureBox_0 = new PictureBox();
		int_0 = 0;
		bool_0 = false;
		int_1 = 0;
		int_3 = random_0.Next(500, 800);
		random_1 = new Random();
		int_4 = random_1.Next(1, 7);
		int_5 = 1;
		int_6 = 2;
	}

	public void Animation()
	{
		pictureBox_0.set_Image((Image)null);
		((Control)pictureBox_0).Refresh();
		pictureBox_0.set_Image((Image)null);
		((Control)pictureBox_0).Refresh();
		pictureBox_0.set_Image((Image)null);
		((Control)pictureBox_0).Refresh();
		pictureBox_0.set_Image((Image)null);
		((Control)pictureBox_0).Refresh();
	}

	public void MovementForward()
	{
		checked
		{
			int_0++;
			((Control)pictureBox_0).set_Left(((Control)pictureBox_0).get_Left() + 13);
			if (int_0 == 15)
			{
				Class2.Forms.Form1.tMovement.Stop();
				Class2.Forms.Form1.tAnimation.Stop();
				int_0 = 0;
				pictureBox_0.set_Image((Image)null);
				((Control)pictureBox_0).Refresh();
				ShootEnemy();
			}
		}
	}

	public void MovementBackwards()
	{
		checked
		{
			int_0++;
			((Control)pictureBox_0).set_Left(((Control)pictureBox_0).get_Left() - 13);
			if (int_0 == 15)
			{
				Class2.Forms.Form1.tMovement.Stop();
				Class2.Forms.Form1.tAnimation.Stop();
				bool_0 = false;
				pictureBox_0.set_Image((Image)null);
				((Control)pictureBox_0).Refresh();
				int_0 = 0;
			}
		}
	}

	public void ShootMyself()
	{
		if (int_5 != int_4)
		{
			Class2.Forms.Form1.JokerFaceTransition.Start();
		}
		else if (int_5 == int_4)
		{
			BulletHit_MySelf();
		}
	}

	public void BulletMiss_MySelf()
	{
		checked
		{
			int_0++;
			Class2.Forms.Form1.pbJoker.set_Image((Image)null);
			if (int_0 == 4)
			{
				Class2.Forms.Form1.JokerFaceTransition.Stop();
				Class2.Forms.Form1.pbJoker.set_Image((Image)null);
				int_0 = 0;
				int_5++;
				CylinderImage();
			}
		}
	}

	public void BulletHit_MySelf()
	{
		Class2.Forms.Form1.pbJoker.set_Image((Image)null);
		Class2.Forms.Form1.Blinking.Stop();
		Class2.Forms.Form1.pbMysterion.set_Image((Image)null);
		Class2.Forms.EnterNameForm.string_0 = "Loser";
		((Control)Class2.Forms.EnterNameForm).Show();
	}

	public void ShootEnemy()
	{
		if (int_5 != int_4)
		{
			BulletMiss_Enemy();
		}
		else if (int_5 == int_4)
		{
			BulletHit_Enemy();
		}
	}

	public void BulletMiss_Enemy()
	{
		checked
		{
			int_6--;
			Class2.Forms.Form1.lblChances.set_Text("Chances: " + Conversions.ToString(int_6));
			if (int_6 == 0)
			{
				Class2.Forms.Form1.pbMysterion.set_Image((Image)null);
				((Control)Class2.Forms.Form1.pbLaser).set_Visible(true);
				Class2.Forms.Form1.LaserEye.Start();
				Class2.Forms.Form1.tMovement.Stop();
				Class2.Forms.Form1.tAnimation.Stop();
				Class2.Forms.Form1.Blinking.Stop();
				Class2.Forms.EnterNameForm.string_0 = "Loser";
				((Control)Class2.Forms.EnterNameForm).Show();
			}
			else
			{
				int_5++;
				CylinderImage();
				bool_0 = true;
				int_0 = 0;
				Class2.Forms.Form1.tMovement.Start();
				Class2.Forms.Form1.tAnimation.Start();
			}
		}
	}

	public void BulletHit_Enemy()
	{
		pictureBox_0.set_Image((Image)null);
		Class2.Forms.Form1.Blinking.Stop();
		Class2.Forms.Form1.pbMysterion.set_Image((Image)null);
		Class2.Forms.EnterNameForm.string_0 = "Winner";
		((Control)Class2.Forms.EnterNameForm).Show();
	}

	public void Blink()
	{
		checked
		{
			int_2++;
			if (int_2 == 5)
			{
				Class2.Forms.Form1.Blinking.set_Interval(200);
				Class2.Forms.Form1.pbMysterion.set_Image((Image)null);
				((Control)Class2.Forms.Form1.pbMysterion).Refresh();
			}
			else if (int_2 > 5)
			{
				Class2.Forms.Form1.Blinking.set_Interval(int_3);
				Class2.Forms.Form1.pbMysterion.set_Image((Image)null);
				((Control)Class2.Forms.Form1.pbMysterion).Refresh();
				int_2 = 0;
			}
		}
	}

	public void LaserHit()
	{
		((Control)Class2.Forms.Form1.pbLaser).set_Left(checked(((Control)Class2.Forms.Form1.pbLaser).get_Left() - 13));
		if (((Control)Class2.Forms.Form1.pbLaser).get_Bounds().IntersectsWith(((Control)pictureBox_0).get_Bounds()))
		{
			Class2.Forms.Form1.LaserEye.Stop();
			((Control)Class2.Forms.Form1.pbLaser).set_Visible(false);
			pictureBox_0.set_Image((Image)null);
			((Control)pictureBox_0).Refresh();
		}
	}

	public object BulletRandomLocation()
	{
		int_4 = random_1.Next(1, 6);
		return int_4;
	}

	public void CylinderImage()
	{
		if (int_5 == 1)
		{
			Class2.Forms.Form1.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.Form1.pbCylinder).Refresh();
		}
		else if (int_5 == 2)
		{
			Class2.Forms.Form1.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.Form1.pbCylinder).Refresh();
		}
		else if (int_5 == 3)
		{
			Class2.Forms.Form1.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.Form1.pbCylinder).Refresh();
		}
		else if (int_5 == 4)
		{
			Class2.Forms.Form1.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.Form1.pbCylinder).Refresh();
		}
		else if (int_5 == 5)
		{
			Class2.Forms.Form1.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.Form1.pbCylinder).Refresh();
		}
		else if (int_5 == 6)
		{
			Class2.Forms.Form1.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.Form1.pbCylinder).Refresh();
		}
	}

	public void SaveDetails()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		string text = Class2.Forms.EnterNameForm.txtName.get_Text();
		if (Operators.CompareString(text, "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter your initials", (MsgBoxStyle)0, (object)null);
			return;
		}
		string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Saved Games\\SouthParkRoulette.csv";
		string[] array = new string[1];
		bool flag = false;
		checked
		{
			if (!File.Exists(path))
			{
				if (Operators.CompareString(Class2.Forms.EnterNameForm.string_0, "Winner", false) == 0)
				{
					array[0] = text + ",1,0,0";
				}
				else
				{
					array[0] = text + ",0,1,0";
				}
			}
			else
			{
				array = File.ReadAllLines(path);
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string[] array2 = array[i].Split(new char[1] { ',' });
					if (Operators.CompareString(array2[0], text, false) == 0)
					{
						flag = true;
						if (Operators.CompareString(Class2.Forms.EnterNameForm.string_0, "Winner", false) == 0)
						{
							array[i] = array2[0] + "," + Conversions.ToString(Conversions.ToDouble(array2[1]) + 1.0) + "," + array2[2];
						}
						else
						{
							array[i] = array2[0] + "," + array2[1] + "," + Conversions.ToString(Conversions.ToDouble(array2[2]) + 1.0);
						}
					}
				}
				if (!flag)
				{
					Array.Resize(ref array, array.Length + 1);
					array[array.Length - 1] = text + ",1,0,0";
				}
			}
			File.WriteAllLines(path, array);
			((Form)Class2.Forms.EnterNameForm).Close();
			((Form)Class2.Forms.Form1).Close();
			((Control)Class2.Forms.MainMenu).Show();
			((Control)Class2.Forms.LeaderBoardForm).Show();
		}
	}
}
