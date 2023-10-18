void cube(int number){
    double[] sqr = new double[number];
    for (int i = 1; i < number; i++){
            sqr[i] = Math.Pow (i, 3);
            Console.WriteLine($"{sqr[i]}");
            }
    }
cube(9);