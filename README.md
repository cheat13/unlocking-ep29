# Tutorial Unlocking EP29
## Create solution & setup structure 
1. สร้าง folder ที่ต้องการเก็บ solution
```
mkdir unlocking-ep29
```
2. สร้าง solution 
```
dotnet new sln -n calculator
```
3. สร้าง folder "test" ไว้เก็บ test projects
```
mkdir test
```
4. สร้าง folder "src" ไว้เก็บ source code projects ที่ทำงานจริง
```
mkdir src 
```
สุดท้ายจะได้โครงสร้างตามภาพด้านล่าง
```
unlocking-ep29
|- src
|- test
|- calculator.sln
```
## Create test project
1. ใน folder "test" สร้าง test project ชื่อว่า calculator.Test
```
dotnet new xunit -n calculator.Test
```
2. add calculator.Test เข้า solution
```
dotnet sln calculator.sln add test/calculator.Test/calculator.Test.csproj
```
สุดท้ายจะได้โครงสร้างตามภาพด้านล่าง
```
unlocking-ep29
|- src
|- test
| |-caculator.Test
|- calculator.sln
```

## Create service project
1. ใน folder "src" สร้าง test project ชื่อว่า calculator.Service
```
dotnet new classlib -n calculator.Service
```
2. add calculator.Service เข้า solution
```
dotnet sln calculator.sln add src/calculator.Service/calculator.Service.csproj
```
สุดท้ายจะได้โครงสร้างตามภาพด้านล่าง
```
unlocking-ep29
|- src
| |-calculator.Service
|- test
| |-calculator.Test
|- calculator.sln
```

## Create api project
1. ใน folder "src" สร้าง test project ชื่อว่า calculator.Api
```
dotnet new api -n calculator.Api
```
2. add calculator.Api เข้า solution
```
dotnet sln calculator.sln add test/calculator.Api/calculator.Api.csproj
```
สุดท้ายจะได้โครงสร้างตามภาพด้านล่าง
```
unlocking-ep29
|- src
| |-calculator.Api
| |-calculator.Service 
|- test
| |-calculator.Test
|- calculator.sln
```

## Create mobile project
1. ใน folder "src" สร้าง test project ชื่อว่า calculator.Api
```
ionic start calculator.MobileApp blank
```
สุดท้ายจะได้โครงสร้างตามภาพด้านล่าง
```
unlocking-ep29
|- src
| |-calculator.Api
| |-calculator.MobileApp
| |-calculator.Service 
|- test
| |-calculator.Test
|- calculator.sln
```

## How to add project reference
```
dotnet add [project file ต้นทางที่ต้องการ add] reference [project file ปลายทางที่ต้องการ add]
```
ตัวอย่างเช่น ถ้าต้องการให้ calculator.Test project สามารถใช้คำสั่งใน calculator.Service  ได้
```
dotnet add test/calculator.Test/calculator.Test.csproj reference src/calculator.Service/calculator.Service.csproj
```

## How to add package to project
```
dotnet add package [package name]
```
เช่น ถ้าต้องการ add package ชื่อว่า FluentAssertions 
```
dotnet add package FluentAssertions 
```

## How to publish project
```
dotnet publish -c release
```
