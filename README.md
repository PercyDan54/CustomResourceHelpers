# ArknightsResources - Custom Resource Helpers
本库提供了对与明日方舟相关资源的自定义读取方式。

## 目标框架
.NET Standard 2.0, .NET 6 与 .NET 7。

### **不同目标框架的差异**
.NET 7及以上版本的接口定义使用了[静态抽象成员](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/interface#static-abstract-and-virtual-members)，导致方法签名改变，如果使用了本库，应该考虑使用条件编译等方法避免二进制不兼容。

## 构建
.NET CLI 与 Visual Studio 2022皆可。

## 安装
目前尚未发布到NuGet，请通过[GitHub Packages](https://github.com/ArknightsResources/CustomResourceHelpers/pkgs/nuget/ArknightsResources.CustomResourceHelpers)下载安装。

## 许可
MIT 许可证