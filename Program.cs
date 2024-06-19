using System;

class Program
{
    static void Main()
    {
        // Nhập số lượng phần tử trong mảng
        Console.Write("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Khởi tạo mảng
        int[] array = new int[n];

        // Nhập các phần tử của mảng từ người dùng
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Tìm phần tử lớn nhất trong mảng
        int largestElement = array[0];
        for (int i = 1; i < n; i++)
        {
            if (array[i] > largestElement)
            {
                largestElement = array[i];
            }
        }

        // In ra phần tử lớn nhất trong mảng
        Console.WriteLine($"The largest element in the array is: {largestElement}");
    }
}

    }
}