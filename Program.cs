using System;

class Program
{
    static void Main()
    {
        const int maxSize = 20;
        double[] assets = new double[maxSize];
        int count = 0;

        Console.WriteLine("Nhập giá trị tài sản của các tỷ phú (đơn vị tỉ đô):");
        Console.WriteLine("Nhập -1 để kết thúc nhập.");

        double asset;
        do
        {
            Console.WriteLine($"Nhập giá trị tài sản thứ {count + 1}:");
            asset = double.Parse(Console.ReadLine());

            if (asset != -1)
            {
                assets[count] = asset;
                count++;
            }

        } while (asset != -1 && count < maxSize);

        if (count > 0)
        {
            double maxAsset = assets[0];
            int maxIndex = 0;

            for (int i = 1; i < count; i++)
            {
                if (assets[i] > maxAsset)
                {
                    maxAsset = assets[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine($"Giá trị tài sản lớn nhất là {maxAsset} tỉ đô.");
            Console.WriteLine($"Vị trí của tỷ phú có giá trị tài sản lớn nhất trong danh sách là {maxIndex + 1}.");
        }
        else
        {
            Console.WriteLine("Không có giá trị tài sản nào được nhập.");
        }
    }
}