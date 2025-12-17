// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello World!"

// let name = "F#"
// let age = 30
// let isActive = true
// printfn "Name: %s, Age: %d, Active: %b" name age isActive

printfn "-------------------------------"
// Exercise:
// - In ra “Hello <tên bạn>” và số tuổi, thử đổi sang string interpolation: `$"Hello {name}, {age}"`.
let username = "F#"
let age = 30

printfn $"Hello {username}, Age: {age}"
printfn "-------------------------------"

// - Viết hàm `square`, `isEven`, `greet name`.
let square x = x * x
let isEven x = x % 2 = 0

printfn "Square of 5: %d" (square 5)
printfn "Is 4 even? %b" (isEven 4)
printfn "Is 5 even? %b" (isEven 5)
printfn "-------------------------------"

// - Tạo danh sách tên (list of string) và in từng tên bằng `List.iter`.
let names = ["Alice"; "Bob"; "Charlie"]
List.iter (printfn "Name: %s") names
printfn "-------------------------------"

// -- Thử sửa một giá trị bằng cách tạo binding mới (không dùng `mutable`).
let originalValue = 10
let newValue = originalValue + 5
printfn "Original Value: %d, New Value: %d" originalValue newValue
printfn "-------------------------------"