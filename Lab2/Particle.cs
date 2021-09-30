using System;
using Lab2.Geometry2D;

namespace Lab2.Particles
{
	abstract class Particle
	{
		private Point position = new Point();
		private Vector direction = new Vector();
		public double Speed { get; protected set; }

		public Point Position
		{
			get => new Point(position.X, position.Y);
			set => position = value;
		}

		public Vector Direction
		{
			get => new Vector(direction.DX, direction.DY);
			set => direction = value;
		}

		public Particle() 
		{
			position.SetCoords(0, 0);
			direction.Set(0, 0);
			Speed = 0;
		}

		public Particle(Point position, Vector direction, double speed)
		{
			Position = position;
			Direction = direction;
			Speed = speed;
		}

		public Particle(Particle p) // copy constructor
		{
			Position = p.Position;
			Direction = p.Direction;
			Speed = p.Speed;
		}

		public void SetCoords(double? px, double? py)
		{
			position.SetCoords(px, py);
			throw new NotImplementedException();
		}

		public void GetCoords(out double px, out double py)
		{
			position.GetCoords(out px,out py);
			throw new NotImplementedException();
		}

		public void SetDirection(double dx, double dy)
		{
			direction.Set(dx, dy);
			throw new NotImplementedException();
		}

		public void GetDirection(out double dx, out double dy)
		{
			dx = Direction.DX;
			dy = Direction.DY;
			direction.Set(dx, dy);
			throw new NotImplementedException();
		}

		public void Drift(double time)
		{
			// I don't know how to implementation about this part 
			if (time == 0)
			{
				double i = Direction.DX;
				double j = Direction.DY;
				double v = Speed;
				double distance_moved_in_X_direction = i * v * time;
				double distance_moved_in_Y_direction = j * v * time;
			}
			else
			{
				
			}
			throw new NotImplementedException();
		}

		public void SetRandomDirection(double r1, double r2)
		{
			double dx = 2 * r1 - 1;
			double dy = Math.Sqrt(1 - dx * dx) * Math.Cos(2 * Math.PI * r2);
			direction.Set(dx, dy);
		}
		public abstract void Update(double frequency, double speed, Polarization pol);
		public override string ToString()
		{
			return $"Position: {Position}\n" +
				   $"Direction: {Direction}\n" +
				   $"Speed: {Speed}\n";
		}
	}
}
