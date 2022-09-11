using System;

namespace RandomRansom;

internal class Particle
{
	public double loc_x = 0.0;

	public double loc_y = 0.0;

	public double force_x = 0.0;

	public double force_y = 0.0;

	public double gravity_x = 0.0;

	public double gravity_y = 0.0;

	public bool is_dead = false;

	public Particle(double x, double y, double force_x, double force_y, double gravity_x, double gravity_y)
	{
		loc_x = x;
		loc_y = y;
		this.force_x = force_x;
		this.force_y = force_y;
		this.gravity_x = gravity_x;
		this.gravity_y = gravity_y;
	}

	public void update(int W, int H, double FpsComp)
	{
		double num = 0.0 - force_x + (0.0 - gravity_x);
		double num2 = 0.0 - force_y + (0.0 - gravity_y);
		loc_x += num / 10.0;
		loc_y += num2 / 10.0;
		force_x -= (0.0 - gravity_x) / (Math.PI * (2.0 / FpsComp));
		force_y -= (0.0 - gravity_y) / (Math.PI * (2.0 / FpsComp));
		if (loc_y > (double)(H + 10))
		{
			is_dead = true;
		}
	}
}
