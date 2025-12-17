# Ngày 1–2: Làm quen

## Mục tiêu
- Cài đặt môi trường .NET + editor (VS Code + Ionide hoặc Visual Studio).
- Viết và chạy được chương trình F# đầu tiên.
- Hiểu biến/binding, hàm, kiểu cơ bản, immutable data.

## Nội dung chính
- Cài đặt: `dotnet --version` để kiểm tra; cài Ionide (VS Code) hoặc workload F# (Visual Studio).
- Tạo project console: `dotnet new console -lang F# -n HelloFSharp`.
- Viết “Hello World” trong `Program.fs`, chạy với `dotnet run`.
- Binding và kiểu cơ bản: `let name = "F#"` (string), `let age = 30` (int), `let isActive = true` (bool).
- Hàm cơ bản: `let add x y = x + y`; gọi bằng `add 2 3`.
- Immutability: dùng `let` (binding mới) thay vì gán lại; nếu cần, tạo biến mới từ giá trị cũ.

## Bài tập
- In ra “Hello <tên bạn>” và số tuổi, thử đổi sang string interpolation: `$"Hello {name}, {age}"`.
- Viết hàm `square`, `isEven`, `greet name`.
- Tạo danh sách tên (list of string) và in từng tên bằng `List.iter`.
- Thử sửa một giá trị bằng cách tạo binding mới (không dùng `mutable`).

## Tài nguyên
- F# docs: https://learn.microsoft.com/dotnet/fsharp/tour
- Ionide: https://marketplace.visualstudio.com/items?itemName=Ionide.Ionide-fsharp
