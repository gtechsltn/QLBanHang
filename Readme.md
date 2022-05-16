# Phần mềm quản lý bán hàng
## Công nghệ / kỹ thuật sử dụng trong dự án:
+ Windows 10
+ Visual Studio 2022
+ .NET Framework 4.7.2
+ ADO.NET

## 3rd party
+ Guna.UI2.WinForms (guna2.dll)

## Hướng dẫn cách chạy chương trình
+ Tạo Database trên SQL Server 2014
  + Tìm đường dẫn đến thư mục SQL Data
  + Copy tệp .mdf vào thư mục SQL Data
  + Attach DB vào SQL Server
+ Dùng VS 2022 mở tệp QLBanHang.sln
+ Thay đổi connection string cho phù hợp với SQL Server trên máy
+ F5 để chạy chương trình

# Lỗi thường gặp của sinh viên
+ Không tạo tệp Readme.md
+ Không tạo tệp .gitignore
+ Không đưa các thư viện bên ngoài ra 1 folder riêng, mà lại đưa luôn vào thư mục bin/Debug, bin/Release
+ Không tạo script để tạo database và đưa lên github
+ Không có hướng dẫn cho developer khác để cộng tác với code của mình (nhận code, đẩy code lên, build solution)
