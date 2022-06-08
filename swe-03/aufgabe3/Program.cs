using System;

namespace aufgabe3
{
    struct Size
    {
	private double m_Width;
	private double m_Height;

	public Size(double Width, double Height)
	{
	    this.m_Width = 0;
	    this.m_Height = 0;

	    this.Width = Width;
	    this.Height = Height;
	}

	public double Width
	{
	    get { return this.m_Width; }
	    set {
		if (value < 0.0)
		    throw new System.ArgumentException("Width must not be negative");

		this.m_Width = value;
	    }
	}

	public double Height
	{
	    get { return this.m_Height; }
	    set {
		if (value < 0.0)
		    throw new System.ArgumentException("Height must not be negative");

		this.m_Height = value;
	    }
	}
    }

    class Program
    {
	static void Main(string[] args)
	{
	    Size foo = new Size(32, 32);

	    foo.Height = -1;

	    // foo.Width = -32.0;
	    Console.WriteLine("Size {{ w = {0}, h = {1} }}", foo.Width, foo.Height);
	}
    }
}
