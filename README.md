# Flight Management System   

Đây là đồ án môn **Lập trình cơ sở dữ liệu** – ngành **Công nghệ Thông tin** tại **Trường Đại học Mở TP. Hồ Chí Minh**.  
Đề tài xây dựng một hệ thống quản lý chuyến bay với giao diện ứng dụng desktop, áp dụng mô hình 3 lớp và kết nối cơ sở dữ liệu.  

---

## 📌 Giới thiệu
Hệ thống hỗ trợ quản lý thông tin chuyến bay, hành khách, vé và các nghiệp vụ cơ bản của một chương trình đặt vé.  
Người dùng có thể:
- Quản lý thông tin chuyến bay (tạo, sửa, xóa).
- Quản lý sân bay, tuyến bay.
- Quản lý khách hàng và vé.
- Tra cứu chuyến bay theo thời gian, điểm đi, điểm đến.
- Đăng nhập và phân quyền người dùng.

---

## 🏗️ Kiến trúc hệ thống
Dự án được xây dựng theo mô hình **3-layer architecture**:
- **DTO (Data Transfer Object):** Lớp trung gian chứa các đối tượng dữ liệu.
- **DAO (Data Access Object):** Xử lý truy vấn và kết nối cơ sở dữ liệu.
- **BLL (Business Logic Layer):** Xử lý nghiệp vụ.
- **GUI (Windows Forms Application):** Giao diện chính cho người dùng.

---

## ⚙️ Công nghệ sử dụng
- **Ngôn ngữ:** C# (.NET Framework / WinForms)
- **Cơ sở dữ liệu:** SQL Server
- **IDE:** Visual Studio
- **Quản lý mã nguồn:** GitHub

---

## 🗄️ Cơ sở dữ liệu
CSDL được thiết kế với các bảng chính:
- `CHUYENBAY` – thông tin chuyến bay
- `SANBAY` – thông tin sân bay
- `TUYENBAY` – quản lý tuyến đường bay
- `VECHUYENBAY` – thông tin vé
- `HANHKHACH` – thông tin hành khách
- `NGUOIDUNG` – quản lý người dùng hệ thống
