using System;
public class Test
{
	public static void Main()
	{

		float height = 3;
		float width = height;
		float depth = height;
		float radius = 5;
		float bottom = 5;//三角形の底辺
		float triHeight = 12;//三角形の高さ
		Box box = new Box(width, height, depth);
		Console.WriteLine("立方体\n体積:" + box.GetVolume());
		Console.WriteLine("表面積:" + box.GetSurface() + "\n");

		Cylinder cylinder = new Cylinder(radius, height);
		Console.WriteLine("円柱\n体積:" + cylinder.GetVolume());
		Console.WriteLine("表面積:" + cylinder.GetSurface() + "\n");

		Sphere sphere = new Sphere(radius);
		Console.WriteLine("球\n体積:" + sphere.GetVolume());
		Console.WriteLine("表面積:" + sphere.GetSurface() + "\n");

		TriangularPrism triangularPrism = new TriangularPrism(bottom, triHeight, height);
		Console.WriteLine("三角柱\n体積:" + triangularPrism.GetVolume());
		Console.WriteLine("表面積:" + triangularPrism.GetSurface());
	}
}
public class Box
{
	private float width;
	private float height;
	private float depth;
	public Box(float width, float height, float depth)
	{
		this.width = width;
		this.height = height;
		this.depth = depth;
	}
	public float GetSurface()
	{

		return (width * height + height * depth + depth * width) * 2;
	}
	public float GetVolume()
	{
		return width * height * depth;
	}
}
public class Cylinder
{
	private float radius;
	private float height;
	public Cylinder(float radius, float height)
	{
		this.radius = radius;
		this.height = height;
	}
	public float GetSurface()
	{
		return (float)(2 * Math.PI * radius * radius + 2 * Math.PI * height * radius);
	}
	public float GetVolume()//
	{
		return (float)(radius * radius * Math.PI * height);
	}
}
public class Sphere
{
	float radius;
	public Sphere(float radius)
	{
		this.radius = radius;
	}
	public float GetSurface()
	{
		return (float)(4 * radius *radius * Math.PI );//
	}
	public float GetVolume()
	{
		return (float)(4 * Math.PI * radius * radius * radius /3);
	}
}
public class TriangularPrism
{
	float bottom;
	float triHeight;
	float height;
	float tri;
	public TriangularPrism(float bottom, float triHeight, float height)
	{
		this.bottom = bottom;
		this.triHeight = triHeight;
		this.height = height;
		this.tri = triHeight * bottom / 2;
	}
	public float GetSurface()//hyoumennseki
	{
		return tri * 2 + (bottom * height) + (triHeight * height) + (float)Math.Sqrt(bottom * bottom + triHeight * triHeight) * height;
	}
	public float GetVolume()//taiseki
	{
		return tri * height;
	}
}
