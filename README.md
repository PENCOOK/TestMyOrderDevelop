# TestMyOrderDevelop
Fullstack Exam

1. System Design
จงออกแบบระบบย่อ URL พร้อม demo เช่น ย่อ http://my-order.ai/long-url/very-sub-path ให้เป็น http://shorturl.com/abcde สามารถระบุรายละเอียด เช่น

* database ใช้ SQL Server 2017
* back-end ใช้ C#.net (.net framework 4.7.2)
* front-end เป็น code on time (low-code tools)
* deployment ใช้ FTP upload file, ใช้บริการ web server (IIS10) ของ somee.com (ฟรี), เหตุผลที่เลือกใช้ คือ เรียบง่าย ถ้าเป็น production ก็ควรจะเช่า cloud server หรือ azure ไปเลย 
## ตัวอย่าง app http://cot.somee.com/pages/home
![image](https://user-images.githubusercontent.com/114844869/193455988-1fed8ad4-79c7-41ca-84c2-6b1548f2624c.png)
![image](https://user-images.githubusercontent.com/114844869/193456030-0dc422c4-5d15-4e71-ade4-d4864c995be5.png)
input Long Url และ Title สำเร็จก็จะ generate link ให้ โดยใช้บริการ api ของ apilayer.com

2. Up To You
จงออกแบบข้อสอบเอง พร้อมเฉลย อย่างน้อย 1 ข้อ
* จงสร้างระบบการตรวจสอบสถานะพัสดุอย่างง่าย
![image](https://user-images.githubusercontent.com/114844869/193456267-c61b1740-d9f3-4dc9-8fc6-8c6855e21342.png)
![image](https://user-images.githubusercontent.com/114844869/193456317-78ca7242-275d-4325-92c6-e67554e7603d.png)
เมื่อระบุเลขที่ติดตาม และ ชื่อบริษัทขนส่งสำเร็จ ก็จะแสดงสถานะให้ พร้อมกับสามารถ refresh เพื่อดูสถานะอัพเดทแบบเรียลไทม์
