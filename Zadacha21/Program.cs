int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)) ,2);
Console.WriteLine(distance);

