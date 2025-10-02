## BÀI TẬP TUẦN 3
### Yêu cầu thiết kế ứng dụng Windows Forms bằng C# cho phép
- Đăng ký và đăng nhập người dùng
- Lưu trữ dữ liệu trong SQL Server.
- Xác thực thông tin đăng nhập và hiển thị thông tin người dùng sau khi đăng nhập thành công.

### Kiến trúc thực hiện
Ứng dụng tuân theo **Kiến trúc 3-tier**
1. **Tầng Giao diện (Presentation/UI)**
   - WinForms (`SignIn`, `SignUp`, `Home`)
   - Xử lý tương tác người dùng
2. **Tầng Nghiệp vụ (Business Logic Layer - BLL)**
   - `AuthService.cs`
   - Chứa logic xác thực, kiểm tra dữ liệu và mã hóa mật khẩu
3. **Tầng Truy cập Dữ liệu (Data Access Layer - DAL)**
   - `PlayerRepository.cs`
   - Thực hiện các truy vấn SQL và giao tiếp với CSDL
4. **Models**
   - `Player.cs` (đại diện cho thực thể người dùng)

### Công nghệ sử dụng
- Visual Studio 2022
- .NET FRAMEWORK 4.7.2
- Microsoft SQL Server

### Hướng dẫn sử dụng
1. Copy link HTTPS: https://github.com/ha1moi1/NT106.Q14-Group-1.git

   Clone dự án bằng lệnh: `git clone https://github.com/ha1moi1/NT106.Q14-Group-1.git`
2. Chạy script file `monopoly.sql` trong folder Database để tạo bảng Player.
3. Build và chạy ứng dụng.

!!! **Lưu ý:** Cần phải chạy file script sql trên Microsoft SQL Server phiên bản Developer để không bị lỗi về cơ sở dữ liệu

### Các màn hình giao diện ứng dụng
- Giao diện đăng nhập tài khoản

![Giao diện đăng nhập tài khoản](../images/SignIn.jpg "Đăng nhập")

- Giao diện đăng ký tài khoản

![Giao diện đăng ký tài khoản](../images/SignUp.jpg "Đăng ký")
  
- Giao diện sau khi đăng nhập tài khoản

![Giao diện sau đăng nhập tài khoản](../images/AfterSignUp.jpg "Sau đăng nhập")
