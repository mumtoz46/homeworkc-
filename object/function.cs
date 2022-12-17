public class Math
{
 public double pi = 3.14;
 public double E = 2.71;
 public  double Abs(double value)
 {
    if (value > 0 )
    {
        return value;
    }
    else
    {
        return value*-1;
    }
 }
 public  float Abs(float value)
 {
   if (value > 0 )
    {
        return value;
    }
    else
    {
        return value*-1;
    }
 }
 public  short Abs(short value)
 {
       if (value > 0 )
    {
        return (short)value;
    }
    else
    {
        return (short)(value*-1);
    }
 }
 public  int Abs(int value)
 {
   if (value < 0)
   {
    return value*-1;
   }
   else
   {
    return value;
   }
 }
 public  double Pow(double x, double y)
 {
    double sum=1;
    for (int i=1;i<y;i++)
    {
        sum = sum*x;
    }
    return sum;
 }
 public  int Sqrt(double d)
 {
    int j=0;
    for (int i=1;i<d;i++)
    {
        if (i*i==d)
        j = i;
    }
    return j;

 }
 public  int Max(int val1, int val2)
 {
    if (val1>val2)
    {
        return val1;
    }
    else
    {
        return val2;
    }
 }
 public int Min(int val1, int val2)
 {
    if (val1<val2)
    {
        return val1;
    }
    else
    {
        return val2;
    }
 }
} 