# Virusonoffnotepad

## Giới thiệu

**Virusonoffnotepad** là một ứng dụng Windows Forms được viết bằng C#, mô phỏng chức năng quét và tiêu diệt tiến trình Notepad trên máy tính. Ứng dụng này chủ yếu phục vụ mục đích học tập về quản lý tiến trình trong Windows.

## Tính năng
- Giao diện đơn giản, dễ sử dụng.
- Quét và hiển thị các tiến trình Notepad đang chạy.
- Tự động đóng (kill) tất cả các tiến trình Notepad.

## Yêu cầu hệ thống
- Windows 7 trở lên
- .NET Framework 4.7.2 trở lên

## Cài đặt
1. Clone repository về máy:
   ```bash
   git clone https://github.com/<your-username>/taplamvirus.git
   ```
2. Mở file `Virusonoffnotepad.sln` bằng Visual Studio.
3. Build project với cấu hình Debug hoặc Release.
4. Chạy ứng dụng từ Visual Studio hoặc file thực thi trong `bin/Debug` hoặc `bin/Release`.

## Sử dụng
- Nhấn nút **Scan** để quét các tiến trình Notepad (chức năng này có thể chưa hoàn thiện).
- Nhấn **Kill Virus** để đóng tất cả tiến trình Notepad đang chạy.
- Nút **Stop** hiện chưa có chức năng.

## Lưu ý
- Ứng dụng chỉ thao tác với tiến trình Notepad, không gây hại cho hệ thống.
- Không sử dụng cho mục đích phá hoại hoặc gây ảnh hưởng đến người khác.

## Đóng góp
Mọi đóng góp, báo lỗi hoặc ý tưởng mới đều được hoan nghênh! Hãy tạo issue hoặc pull request trên repository này.

## Tác giả
- Nguyễn Nha 