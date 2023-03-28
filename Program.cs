using System;

class Program
{
    static void Main(string[] args)
    {
        double c1x,c1y,c2x,c2y,c1r,c2r,a1x,a1y;
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
        if(magnitude == sum_r)
        {

        }
        else
        {
            double dx = c1x - c2x;
            double dy = c1y - c2y;
            double d = Math.Sqrt(dx*dx + dy*dy);
            double gamma1 = Math.Acos((c2r*c2r + d*d - c1r*c1r)/(2*c2r*d));
            double d1 = c1r*Math.Cos(gamma1);
            double h = c1r*Math.Sin(gamma1);
            double px = c1x + (c2x - c1x) / d*d1;
            double py = c1y + (c2y - c1y) / d*d1;
            Vector2 intersec1 = new Vector2(px + (-dy) / d * h, py + (+dx) / d * h);
            Vector2 intersec2 = new Vector2(px - (-dy) / d * h, py - (+dx) / d * h);
            Console.WriteLine(intersec1.x);
            Console.WriteLine(intersec1.y);
            Console.WriteLine(intersec2.x);
            Console.WriteLine(intersec2.y);
        }
    }

}