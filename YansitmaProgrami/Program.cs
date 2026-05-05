using System;

namespace YansitmaProgrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Üçgenin köşe noktaları
            double[,] A = { { 2 }, { 3 }, { 1 } };
            double[,] B = { { 7 }, { 3 }, { 1 } };
            double[,] C = { { 2 }, { 5 }, { 1 } };

            // Doğru denklemi: 5y = 0.25x + 3.25 -> y = 0.05x + 0.65
            double m = 0.05; // eğim
            double c = 0.65; // y-eksenini kestiği nokta

            // Yansıma matrisi hesaplama
            double[,] reflectionMatrix = CalculateReflectionMatrix(m, c);

            // Yansıyan noktaları hesapla
            double[,] A_reflected = MultiplyMatrix(reflectionMatrix, A);
            double[,] B_reflected = MultiplyMatrix(reflectionMatrix, B);
            double[,] C_reflected = MultiplyMatrix(reflectionMatrix, C);

            // Sonuçları ekrana yazdır
            Console.WriteLine("Orijinal Noktalar:");
            PrintPoint("A", A);
            PrintPoint("B", B);
            PrintPoint("C", C);

            Console.WriteLine("\nYansıtılmış Noktalar:");
            PrintPoint("A'", A_reflected);
            PrintPoint("B'", B_reflected);
            PrintPoint("C'", C_reflected);
        }

        static double[,] CalculateReflectionMatrix(double m, double c)
        {
            // Yansıma matrisini hesapla
            double d = Math.Sqrt(1 + m * m);
            double[,] reflectionMatrix = {
                { (1 - m * m) / (1 + m * m), (2 * m) / (1 + m * m), (-2 * m * c) / (1 + m * m) },
                { (2 * m) / (1 + m * m), (m * m - 1) / (1 + m * m), (2 * c) / (1 + m * m) },
                { 0, 0, 1 }
            };
            return reflectionMatrix;
        }

        static double[,] MultiplyMatrix(double[,] matrix1, double[,] matrix2)
        {
            // Matris çarpma işlemi
            double[,] result = new double[3, 1];
            for (int i = 0; i < 3; i++)
            {
                result[i, 0] = 0;
                for (int j = 0; j < 3; j++)
                {
                    result[i, 0] += matrix1[i, j] * matrix2[j, 0];
                }
            }
            return result;
        }

        static void PrintPoint(string name, double[,] point)
        {
            // Noktaları ekrana yazdır
            Console.WriteLine($"{name} ({point[0, 0]:F2}, {point[1, 0]:F2})");
        }
    }
}


