# Học lập trình .NET - Phần 2 - Các kiểu dữ liệu trong .NET

# Đây là câu hỏi trong video 2

Giới thiệu về hệ thống kiểu, cách khai báo biến trong .NET

* Câu hỏi:
- Câu lệnh nào sau đây không hợp lệ?
    int x;
    int x, y = 10;
    var x;
    var y = 10;
    var x, y = 10;

- Kiểu dữ liệu nào là cha của tất cả các kiểu dữ liệu khác?
    object
    dynamic
    System.Object
    System.ValueType

- Câu lệnh nào sau đây không hợp lệ?
    string s = @"abc".ToUpper();
    string s = "abc".ToUpper();
    string s = $"{"abc".ToUpper}";
    string s = $"abc".ToUpper();
    string s = "abc.ToUpper()";
	
---

# Đây là câu trả lời

### Giới thiệu về hệ thống kiểu và cách khai báo biến trong .NET

#### Hệ thống kiểu trong .NET

Hệ thống kiểu trong .NET rất phong phú và mạnh mẽ, bao gồm các kiểu giá trị (value types) và kiểu tham chiếu (reference types).

1. **Kiểu giá trị**:
   - Các kiểu dữ liệu cơ bản như `int`, `float`, `double`, `bool`, `char`, `struct`, và `enum`.
   - Các kiểu này được lưu trữ trực tiếp trong vùng nhớ stack, và chúng thường có hiệu suất truy cập nhanh.

2. **Kiểu tham chiếu**:
   - Bao gồm các kiểu dữ liệu như `string`, `class`, `interface`, `array`, và `delegate`.
   - Các kiểu này được lưu trữ trên heap và tham chiếu tới địa chỉ của đối tượng thực sự.

#### Khai báo biến trong .NET

Khai báo biến trong .NET rất linh hoạt, và bạn có thể sử dụng từ khóa `var` để cho phép trình biên dịch suy diễn kiểu dựa trên giá trị được gán cho biến.

Ví dụ:
```csharp
int x;               // Khai báo biến kiểu int nhưng không khởi tạo
int x, y = 10;       // Khai báo biến x kiểu int và y kiểu int với giá trị khởi tạo là 10
var y = 10;          // Khai báo biến y với kiểu được suy diễn là int
```

### Trả lời các câu hỏi

#### Câu lệnh nào sau đây không hợp lệ?

- `int x;` => Hợp lệ.
- `int x, y = 10;` => Hợp lệ.
- `var x;` => Không hợp lệ vì `var` yêu cầu phải có giá trị khởi tạo để trình biên dịch có thể suy diễn kiểu.
- `var y = 10;` => Hợp lệ.
- `var x, y = 10;` => Không hợp lệ vì `var` không hỗ trợ khai báo nhiều biến trong một câu lệnh.

**Câu trả lời**: `var x;` và `var x, y = 10;`

#### Kiểu dữ liệu nào là cha của tất cả các kiểu dữ liệu khác?

- `object` => Đúng.
- `dynamic` => Sai, `dynamic` là một từ khóa cho phép bỏ qua kiểm tra kiểu tại thời điểm biên dịch nhưng nó vẫn là kiểu `System.Object` tại thời điểm runtime.
- `System.Object` => Đúng, `System.Object` là tên đầy đủ của `object`.
- `System.ValueType` => Sai, `System.ValueType` là cha của tất cả các kiểu giá trị nhưng không phải cha của tất cả các kiểu dữ liệu.

**Câu trả lời**: `object` và `System.Object`

#### Câu lệnh nào sau đây không hợp lệ?

- `string s = @"abc".ToUpper();` => Hợp lệ, chuỗi nguyên văn (@) vẫn có thể gọi phương thức.
- `string s = "abc".ToUpper();` => Hợp lệ.
- `string s = $"{"abc".ToUpper}";` => Không hợp lệ vì cú pháp interpolated string không đúng.
- `string s = $"abc".ToUpper();` => Hợp lệ.
- `string s = "abc.ToUpper()";` => Không hợp lệ vì `"abc.ToUpper()"` là chuỗi ký tự không gọi phương thức `ToUpper`.

**Câu trả lời**: `string s = $"{"abc".ToUpper}";` và `string s = "abc.ToUpper()";`
