# Học lập trình .NET - phần 1 - Cài đặt Visual Studio và viết chương trình .NET đầu tiên

# Các câu hỏi trong video 1

Trong bài này chúng ta sẽ tìm hiểu về công cụ lập trình .NET Visual Studio và viết chương trình đầu tiên.

* Mục tiêu:
- Biết cách cài đặt Visual Studio 2022 (VS).
- Hiểu về cách tổ chức các project và solution trong VS.
- Có khả năng tạo và viết một chương trình console đơn giản.
- Hiểu cơ bản cấu trúc một chương trình C#.

* Bài tập:
- Tải về và cài đặt Visual Studio 2022 (VS), nhớ chọn mục ".NET desktop development".
- Tạo một chương trình dạng Console, sử dụng .NET 8, cho phép nhập vào 5 số nguyên và in ra số lớn nhất trong 5 số (sử dụng cấu trúc if ()).
- Tìm hiểu các quy tắc đặt tên định danh trong C# và trả lời những câu hỏi sau:
  + Những ký tự nào được phép sử dụng khi đặt tên định danh?
  + Tên định danh trong C# có phân biệt chữ hoa chữ thường hay không?
  + Có thể đặt tên biến bằng các ký tự tiếng Việt không (ă, â, ư, ô, ắ, ê, ế, ề...)?

* Tham khảo: 

https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names

---

# Đây là bài làm:

### 2. Tạo một chương trình dạng Console:

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Nhập vào 5 số nguyên:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Số thứ {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine($"Số lớn nhất là: {max}");
    }
}
```

### 3. Quy tắc đặt tên định danh trong C#:

#### Những ký tự nào được phép sử dụng khi đặt tên định danh?

Tên định danh có thể bắt đầu bằng chữ cái hoặc dấu gạch dưới (`_`) và có thể chứa các chữ cái, chữ số, hoặc dấu gạch dưới.

#### Tên định danh trong C# có phân biệt chữ hoa chữ thường hay không?

Có, C# phân biệt chữ hoa chữ thường. Ví dụ, `myVariable` và `MyVariable` được xem là hai định danh khác nhau.

#### Có thể đặt tên biến bằng các ký tự tiếng Việt không (ă, â, ư, ô, ắ, ê, ế, ề...)?

Có, bạn có thể sử dụng các ký tự Unicode trong tên định danh, bao gồm các ký tự tiếng Việt. Tuy nhiên, việc này không được khuyến khích trong thực tế lập trình quốc tế vì có thể gây khó khăn cho những người không quen với ngôn ngữ đó.
