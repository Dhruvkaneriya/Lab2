﻿using System;
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

		/// <summary>
		/// The default constructor sets the particle position and direction vector to (0,0)
		/// and the speed to 0.
		/// </summary>
		public Particle() 
		{
			Position.SetCoords(0, 0);
			Direction.Set(0, 0);
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
		/// <summary>
		/// Sets the particle's position in 2D space
		/// </summary>
		/// <param name="px">The x coordinate</param>
		/// <param name="py">The y coordinate</param>
		public void SetCoords(double? px, double? py)
		{
			// Implementation here
			Position.SetCoords(px, py);
			throw new NotImplementedException();
		}
		/// <summary>
		/// Get the x and y position coordinates of the particle
		/// </summary>
		/// <param name="px">The x coordinate</param>
		/// <param name="py">The y coordinate</param>
		public void GetCoords(out double px, out double py)
		{
			// Implementation here
			Position.GetCoords(out px,out py);
			throw new NotImplementedException();
		}
		/// <summary>
		/// Sets the particle's direction vector
		/// </summary>
		/// <param name="dx">The x component of the direction vector</param>
		/// <param name="dy">The y component of the direction vector</param>
		/// <exception cref="ArgumentOutOfRangeException">Throws if the x or y component is > 1 or < -1."</exception>
		public void SetDirection(double dx, double dy)
		{
			// Implementation here
			Direction.Set(dx, dy);
			throw new NotImplementedException();
		}
		/// <summary>
		/// Get the x and y components of the particle direction vector
		/// </summary>
		/// <param name="dx">The x coordinate</param>
		/// <param name="dy">The y coordinate</param>
		public void GetDirection(out double dx, out double dy)
		{
			// Implementation here
			dx = Direction.DX;
			dy = Direction.DY;
			Direction.Set(dx, dy);
			throw new NotImplementedException();
		}
		/// <summary>
		/// Drifts (moves) the particle in space
		/// </summary>
		/// <param name="time">The amount of time the particle drifts</param>
		public void Drift(double time)
		{
			// Implementation here
			if (time == 0)
			{
				position.SetCoords(x, y);
				direction.Set(i, j);
				Speed v = 0;

			}
			else
			{
				double distance_moved_in_X_direction = i * v * t;
				double distance_moved_in_Y_direction = j * v * t;
			}
			throw new NotImplementedException();
		}
		/// <summary>
		/// Gives the particle a random direction vector
		/// </summary>
		/// <param name="r1">A random number in the interval [0,1]</param>
		/// <param name="r2">A random number in the interval [0,1]</param>
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
