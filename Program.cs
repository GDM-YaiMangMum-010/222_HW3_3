using System;

class Program
{
    static void Main(string[] args)
    {
        double c1x,c1y,c2x,c2y,c1r,c2r;
        c1x = double.Parse(Console.ReadLine());
        c1y = double.Parse(Console.ReadLine());
        c2x = double.Parse(Console.ReadLine());
        c2y = double.Parse(Console.ReadLine());
        c1r = double.Parse(Console.ReadLine());
        c2r = double.Parse(Console.ReadLine());

        Vector2 v_c1 = new Vector2(c1x,c1y);
        Vector2 v_c2 = new Vector2(c2x,c2y);

        Circle2 c_c1 = new Circle2(v_c1,c1r);
        Circle2 c_c2 = new Circle2(v_c2,c2r);

        double magnitude = Math.Sqrt((v_c2.x-v_c1.x) * (v_c2.x-v_c1.x) + (v_c2.y-v_c1.y) * (v_c2.y-v_c1.y));
        double sum_r = c1r+c2r;
        if(magnitude > sum_r)
        {
        }
        else
        {
            
        }
    }
}