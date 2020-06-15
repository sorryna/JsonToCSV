# การอ่านไฟล์ Text ในรูปแบบของ Json เพื่อเขียนไฟล์ CSV

## Query ข้อมูลจาก DataBase
* กำหนดพื้นที่ที่ต้องการ
* จะได้ List ของ reccords ตามพื้นที่

## อ่านไฟล์
* ใน แต่ละ reccord จะมี ตัวแปรที่ระบุชื่อของ โฟลเดอร์ และชื่อ ไฟลล์
* ค้นหาและอ่านไฟลล์ ตาม path ของแต่ละ reccord
* map Json To Models(Community, Building, Household)

## เขียนไฟลล์
* สร้าง Model ที่ต้องการ (ForExport)
* สามารถสร้างตัวแปร เพิ่มใน model ForExport
* map ค่าตัวแปร จาก Models(Community, Building, Household) to model ForExport
* เอา model ForExport มาเขียนไฟลล์

## Platform and Nuget
* [dotnet](https://dotnet.microsoft.com/download/visual-studio-sdks)
* [MongoDB.Driver](https://www.nuget.org/packages/MongoDB.Driver)
* [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json)
* [CsvHelper](https://www.nuget.org/packages/CsvHelper)