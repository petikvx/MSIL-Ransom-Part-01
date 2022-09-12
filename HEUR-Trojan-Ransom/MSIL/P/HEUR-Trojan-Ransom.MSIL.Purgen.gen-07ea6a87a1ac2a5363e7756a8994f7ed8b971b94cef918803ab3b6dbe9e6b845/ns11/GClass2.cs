using System;
using System.Drawing;
using System.Windows.Forms;
using ns10;
using ns3;

namespace ns11;

public class GClass2 : GClass1
{
	public Random random_2;

	public int int_8;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public GClass2()
	{
		random_2 = new Random();
		int_8 = random_2.Next(1, 3);
		bool_2 = true;
		bool_3 = true;
	}

	public void CylinderImageMultiPlayer()
	{
		if (int_5 == 1)
		{
			Class2.Forms.MultiPlayer.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.MultiPlayer.pbCylinder).Refresh();
		}
		else if (int_5 == 2)
		{
			Class2.Forms.MultiPlayer.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.MultiPlayer.pbCylinder).Refresh();
		}
		else if (int_5 == 3)
		{
			Class2.Forms.MultiPlayer.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.MultiPlayer.pbCylinder).Refresh();
		}
		else if (int_5 == 4)
		{
			Class2.Forms.MultiPlayer.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.MultiPlayer.pbCylinder).Refresh();
		}
		else if (int_5 == 5)
		{
			Class2.Forms.MultiPlayer.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.MultiPlayer.pbCylinder).Refresh();
		}
		else if (int_5 == 6)
		{
			Class2.Forms.MultiPlayer.pbCylinder.set_Image((Image)null);
			((Control)Class2.Forms.MultiPlayer.pbCylinder).Refresh();
		}
	}

	public void MovementForwardPlayer1()
	{
		checked
		{
			int_0++;
			((Control)pictureBox_0).set_Left(((Control)pictureBox_0).get_Left() + 13);
			if (int_0 == 15)
			{
				Class2.Forms.MultiPlayer.tMovement.Stop();
				Class2.Forms.MultiPlayer.tAnimation.Stop();
				int_0 = 0;
				pictureBox_0.set_Image((Image)null);
				((Control)pictureBox_0).Refresh();
				ShootEnemyPlayer1();
			}
		}
	}

	public void MovementBackwardsPlayer1()
	{
		checked
		{
			int_0++;
			((Control)pictureBox_0).set_Left(((Control)pictureBox_0).get_Left() - 13);
			if (int_0 == 15)
			{
				Class2.Forms.MultiPlayer.tMovement.Stop();
				Class2.Forms.MultiPlayer.tAnimation.Stop();
				bool_0 = false;
				pictureBox_0.set_Image((Image)null);
				((Control)pictureBox_0).Refresh();
				int_0 = 0;
				bool_2 = false;
				if (bool_3)
				{
					bool_1 = false;
					Class2.Forms.MultiPlayer.lblWhosTurn.set_Text("Player 2's turn");
				}
				else if (!bool_2 & !bool_3)
				{
					bool_2 = true;
					bool_3 = true;
					bool_1 = false;
					Class2.Forms.MultiPlayer.lblWhosTurn.set_Text("Player 2's turn");
				}
				else
				{
					bool_1 = true;
					Class2.Forms.MultiPlayer.lblWhosTurn.set_Text("Player 1's turn");
				}
			}
		}
	}

	public void ShootEnemyPlayer1()
	{
		if (int_5 != int_4)
		{
			BulletMiss_EnemyPlayer1();
		}
		else if (int_5 == int_4)
		{
			BulletHit_EnemyPlayer1();
		}
	}

	public void ShootMyselfPlayer1()
	{
		if (int_5 != int_4)
		{
			Class2.Forms.MultiPlayer.JokerFaceTransition.Start();
		}
		else if (int_5 == int_4)
		{
			BulletHit_MySelfPlayer1();
		}
	}

	public void BulletHit_MySelfPlayer1()
	{
		Class2.Forms.MultiPlayer.pbJoker.set_Image((Image)null);
		Class2.Forms.MultiPlayer.pbSecondPlayer.set_Image((Image)null);
		Class2.Forms.SomeoneWon.lblWinner.set_Text("Player 2");
		((Control)Class2.Forms.SomeoneWon).Show();
	}

	public void BulletMiss_MySelfPlayer1()
	{
		checked
		{
			int_0++;
			Class2.Forms.MultiPlayer.pbJoker.set_Image((Image)null);
			if (int_0 == 4)
			{
				Class2.Forms.MultiPlayer.JokerFaceTransition.Stop();
				Class2.Forms.MultiPlayer.pbJoker.set_Image((Image)null);
				int_0 = 0;
				int_5++;
				CylinderImageMultiPlayer();
				if (bool_3)
				{
					bool_1 = false;
					Class2.Forms.MultiPlayer.lblWhosTurn.set_Text("Player 2's turn");
				}
				else
				{
					bool_1 = true;
					Class2.Forms.MultiPlayer.lblWhosTurn.set_Text("Player 1's turn");
				}
			}
		}
	}

	public void BulletMiss_EnemyPlayer1()
	{
		checked
		{
			int_5++;
			CylinderImageMultiPlayer();
			bool_0 = true;
			int_0 = 0;
			Class2.Forms.MultiPlayer.tMovement.Start();
			Class2.Forms.MultiPlayer.tAnimation.Start();
		}
	}

	public void BulletHit_EnemyPlayer1()
	{
		pictureBox_0.set_Image((Image)null);
		Class2.Forms.MultiPlayer.pbSecondPlayer.set_Image((Image)null);
		Class2.Forms.SomeoneWon.lblWinner.set_Text("Player 1");
		((Control)Class2.Forms.SomeoneWon).Show();
	}

	public void MovementForwardPlayer2()
	{
		checked
		{
			int_0++;
			((Control)pictureBox_0).set_Left(((Control)pictureBox_0).get_Left() - 13);
			if (int_0 == 15)
			{
				Class2.Forms.MultiPlayer.tMovement.Stop();
				Class2.Forms.MultiPlayer.tAnimation.Stop();
				int_0 = 0;
				pictureBox_0.set_Image((Image)null);
				((Control)pictureBox_0).Refresh();
				ShootEnemyPlayer2();
			}
		}
	}

	public void MovementBackwardsPlayer2()
	{
		checked
		{
			int_0++;
			((Control)pictureBox_0).set_Left(((Control)pictureBox_0).get_Left() + 13);
			if (int_0 == 15)
			{
				Class2.Forms.MultiPlayer.tMovement.Stop();
				Class2.Forms.MultiPlayer.tAnimation.Stop();
				bool_0 = false;
				pictureBox_0.set_Image((Image)null);
				((Control)pictureBox_0).Refresh();
				int_0 = 0;
				bool_3 = false;
				if (bool_2)
				{
					bool_1 = true;
					Class2.Forms.MultiPlayer.lblWhosTurn.set_Text("Player 1's turn");
				}
				else if (!bool_2 & !bool_3)
				{
					bool_2 = true;
					bool_3 = true;
					bool_1 = true;
					Class2.Forms.MultiPlayer.lblWhosTurn.set_Text("Player 1's turn");
				}
				else
				{
					bool_1 = false;
					Class2.Forms.MultiPlayer.lblWhosTurn.set_Text("Player 2's turn");
				}
			}
		}
	}

	public void ShootEnemyPlayer2()
	{
		if (int_5 != int_4)
		{
			BulletMiss_EnemyPlayer2();
		}
		else if (int_5 == int_4)
		{
			BulletHit_EnemyPlayer2();
		}
	}

	public void ShootMyselfPlayer2()
	{
		if (int_5 != int_4)
		{
			Class2.Forms.MultiPlayer.JokerFaceTransition.Start();
		}
		else if (int_5 == int_4)
		{
			BulletHit_MySelfPlayer2();
		}
	}

	public void BulletHit_MySelfPlayer2()
	{
		Class2.Forms.MultiPlayer.pbJoker.set_Image((Image)null);
		Class2.Forms.MultiPlayer.pbSecondPlayer.set_Image((Image)null);
		Class2.Forms.SomeoneWon.lblWinner.set_Text("Player 1");
		((Control)Class2.Forms.SomeoneWon).Show();
	}

	public void BulletMiss_MySelfPlayer2()
	{
		checked
		{
			int_0++;
			Class2.Forms.MultiPlayer.pbSecondPlayer.set_Image((Image)null);
			if (int_0 == 4)
			{
				Class2.Forms.MultiPlayer.JokerFaceTransition.Stop();
				Class2.Forms.MultiPlayer.pbSecondPlayer.set_Image((Image)null);
				int_0 = 0;
				int_5++;
				CylinderImageMultiPlayer();
				if (bool_2)
				{
					bool_1 = true;
					Class2.Forms.MultiPlayer.lblWhosTurn.set_Text("Player 1's turn");
				}
				else
				{
					bool_1 = false;
					Class2.Forms.MultiPlayer.lblWhosTurn.set_Text("Player 2's turn");
				}
			}
		}
	}

	public void BulletMiss_EnemyPlayer2()
	{
		checked
		{
			int_5++;
			CylinderImageMultiPlayer();
			bool_0 = true;
			int_0 = 0;
			Class2.Forms.MultiPlayer.tMovement.Start();
			Class2.Forms.MultiPlayer.tAnimation.Start();
		}
	}

	public void BulletHit_EnemyPlayer2()
	{
		pictureBox_0.set_Image((Image)null);
		Class2.Forms.MultiPlayer.pbJoker.set_Image((Image)null);
		Class2.Forms.SomeoneWon.lblWinner.set_Text("Player 2");
		((Control)Class2.Forms.SomeoneWon).Show();
	}

	public void Animation2()
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
}
