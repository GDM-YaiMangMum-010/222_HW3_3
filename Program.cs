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
        if(magnitude == sum_r)
        {
            double dx = c1x - c2x;
            double dy = c1y - c2y;
            double d = Math.Sqrt(dx*dx + dy*dy);

            double a = (c1r * c1r - c2r * c2r + d * d) / (2 * d);
            double h = Math.Sqrt(c1r * c1r - a * a);
            Vector2 v_a1 = new Vector2(c1x + a * (c2x - c1x) / d, c1y + a * (c2y - c1y) / d);

            Console.WriteLine(v_a1.x);
            Console.WriteLine(v_a1.y);
        }
        else
        {
            double dx = c1x - c2x;
            double dy = c1y - c2y;
            double d = Math.Sqrt(dx*dx + dy*dy);

            double a = (c1r * c1r - c2r * c2r + d * d) / (2 * d);
            double h = Math.Sqrt(c1r * c1r - a * a);
            
            double c3x = c1x + a * (c2x - c1x) / d;
            double c3y = c1y + a * (c2y - c1y) / d;
            
            Vector2 intersec1 = new Vector2((c3x + h * (c2y - c1y) / d), (c3y - h * (c2x - c1x) / d));
            Vector2 intersec2 = new Vector2((c3x - h * (c2y - c1y) / d), (c3y + h * (c2x - c1x) / d));
            
            Console.WriteLine(intersec1.x);
            Console.WriteLine(intersec1.y);
            Console.WriteLine(intersec2.x);
            Console.WriteLine(intersec2.y);

        }
    }

}