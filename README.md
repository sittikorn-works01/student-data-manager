# student-data-manager

ขั้นตอนการโคลนโปรเจคต์สำหรับทดลองใช้งาน

1.ดาวน์โหลดไฟล์โปรเจกต์ลงเครื่องคอมพิวเตอร์ของคุณ

2.เปิดโปรเจกต์ใน Visual Studio -> ไปที่เมนู Tools -> NuGet Package Manager -> Package Manager Console แล้วพิมพ์คำสั่ง: PM> Update-Database

หากระบบไม่รู้จักคำสั่ง update-database: ให้ไปที่เมนู Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution... -> ค้นหาคำว่า Microsoft.EntityFrameworkCore.Tools -> เลือกโปรเจกต์ของคุณ -> แล้วกด Install จากนั้นให้ลองพิมพ์คำสั่ง Update-Database อีกครั้ง

3.กดรันโปรแกรมเพื่อใช้งาน
