using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _591RentPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rentData = new List<Rent>
{
    // 中正區 (10 筆)
    new Rent { Area = "中正區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 15000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "新成屋", BuildingAge = "1年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 8, Floor = "3樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "熱水器" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "中正區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 12000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡1-5年", BuildingAge = "3年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 6, Floor = "5樓以上", Furniture = "部分家具", Equipment = new List<string> { "洗衣機" }, OtherConditions = new List<string> { "可養寵物" } },
    new Rent { Area = "中正區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 35000, DepositMonths = 2, BuildingType = "公寓", HouseCondition = "屋齡6-10年", BuildingAge = "7年", Rooms = 2, Halls = 1, Bathrooms = 1, AreaPings = 25, Floor = "2樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "冰箱", "電視" }, OtherConditions = new List<string> { "有停車位" } },
    new Rent { Area = "中正區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 18000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡11-15年", BuildingAge = "12年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 10, Floor = "1樓", Furniture = "無家具", Equipment = new List<string> { "熱水器" }, OtherConditions = new List<string> { "女性專用" } },
    new Rent { Area = "中正區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 10000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡16-20年", BuildingAge = "18年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 5, Floor = "地下室", Furniture = "部分家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string>() },
    new Rent { Area = "中正區", RentalType = "整租", RentalCategory = "商業", RentAmount = 45000, DepositMonths = 2, BuildingType = "店面", HouseCondition = "新成屋", BuildingAge = "2年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 30, Floor = "1樓", Furniture = "無家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "中正區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 22000, DepositMonths = 2, BuildingType = "大樓", HouseCondition = "屋齡21年以上", BuildingAge = "25年", Rooms = 1, Halls = 1, Bathrooms = 1, AreaPings = 12, Floor = "頂樓", Furniture = "全套家具", Equipment = new List<string> { "洗衣機", "冰箱" }, OtherConditions = new List<string> { "有停車位" } },
    new Rent { Area = "中正區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 14000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡1-5年", BuildingAge = "4年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 7, Floor = "4樓", Furniture = "部分家具", Equipment = new List<string> { "熱水器", "電視" }, OtherConditions = new List<string>() },
    new Rent { Area = "中正區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 40000, DepositMonths = 2, BuildingType = "透天厝", HouseCondition = "屋齡6-10年", BuildingAge = "8年", Rooms = 3, Halls = 2, Bathrooms = 2, AreaPings = 40, Floor = "1樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "洗衣機", "冰箱" }, OtherConditions = new List<string> { "可養寵物" } },
    new Rent { Area = "中正區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 9000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡11-15年", BuildingAge = "13年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 4, Floor = "2樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string> { "近捷運" } },

    // 大安區 (10 筆，高租金區)
    new Rent { Area = "大安區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 25000, DepositMonths = 2, BuildingType = "大樓", HouseCondition = "新成屋", BuildingAge = "1年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 12, Floor = "5樓以上", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "熱水器", "洗衣機" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "大安區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 60000, DepositMonths = 2, BuildingType = "公寓", HouseCondition = "屋齡1-5年", BuildingAge = "2年", Rooms = 3, Halls = 2, Bathrooms = 2, AreaPings = 35, Floor = "10樓", Furniture = "全套家具", Equipment = new List<string> { "冰箱", "電視" }, OtherConditions = new List<string> { "有停車位" } },
    new Rent { Area = "大安區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 20000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡6-10年", BuildingAge = "6年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 8, Floor = "3樓", Furniture = "部分家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string> { "女性專用" } },
    new Rent { Area = "大安區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 18000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡11-15年", BuildingAge = "14年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 10, Floor = "1樓", Furniture = "無家具", Equipment = new List<string> { "熱水器" }, OtherConditions = new List<string>() },
    new Rent { Area = "大安區", RentalType = "整租", RentalCategory = "商業", RentAmount = 80000, DepositMonths = 2, BuildingType = "店面", HouseCondition = "新成屋", BuildingAge = "3年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 50, Floor = "1樓", Furniture = "無家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "大安區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 30000, DepositMonths = 2, BuildingType = "大樓", HouseCondition = "屋齡16-20年", BuildingAge = "17年", Rooms = 1, Halls = 1, Bathrooms = 1, AreaPings = 15, Floor = "頂樓", Furniture = "全套家具", Equipment = new List<string> { "洗衣機", "冰箱" }, OtherConditions = new List<string> { "可養寵物" } },
    new Rent { Area = "大安區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 22000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡21年以上", BuildingAge = "22年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 7, Floor = "4樓", Furniture = "部分家具", Equipment = new List<string> { "電視" }, OtherConditions = new List<string> { "有停車位" } },
    new Rent { Area = "大安區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 55000, DepositMonths = 2, BuildingType = "透天厝", HouseCondition = "屋齡1-5年", BuildingAge = "5年", Rooms = 2, Halls = 1, Bathrooms = 2, AreaPings = 30, Floor = "2樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "熱水器" }, OtherConditions = new List<string>() },
    new Rent { Area = "大安區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 16000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡6-10年", BuildingAge = "9年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 9, Floor = "地下室", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "大安區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 28000, DepositMonths = 2, BuildingType = "公寓", HouseCondition = "屋齡11-15年", BuildingAge = "11年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 13, Floor = "6樓", Furniture = "部分家具", Equipment = new List<string> { "洗衣機" }, OtherConditions = new List<string> { "女性專用" } },

    // 中山區 (5 筆)
    new Rent { Area = "中山區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 32000, DepositMonths = 2, BuildingType = "大樓", HouseCondition = "新成屋", BuildingAge = "1年", Rooms = 2, Halls = 1, Bathrooms = 1, AreaPings = 20, Floor = "5樓以上", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "冰箱" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "中山區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 19000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡1-5年", BuildingAge = "4年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 10, Floor = "3樓", Furniture = "部分家具", Equipment = new List<string> { "熱水器" }, OtherConditions = new List<string>() },
    new Rent { Area = "中山區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 15000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡6-10年", BuildingAge = "7年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 6, Floor = "1樓", Furniture = "無家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string> { "可養寵物" } },
    new Rent { Area = "中山區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 11000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡11-15年", BuildingAge = "12年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 5, Floor = "2樓", Furniture = "部分家具", Equipment = new List<string>() , OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "中山區", RentalType = "整租", RentalCategory = "商業", RentAmount = 50000, DepositMonths = 2, BuildingType = "店面", HouseCondition = "屋齡16-20年", BuildingAge = "18年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 25, Floor = "1樓", Furniture = "無家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string>() },

    // 松山區 (5 筆)
    new Rent { Area = "松山區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 17000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "新成屋", BuildingAge = "2年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 9, Floor = "4樓", Furniture = "全套家具", Equipment = new List<string> { "洗衣機", "電視" }, OtherConditions = new List<string> { "有停車位" } },
    new Rent { Area = "松山區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 38000, DepositMonths = 2, BuildingType = "公寓", HouseCondition = "屋齡1-5年", BuildingAge = "3年", Rooms = 2, Halls = 1, Bathrooms = 2, AreaPings = 28, Floor = "頂樓", Furniture = "全套家具", Equipment = new List<string> { "熱水器", "冰箱" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "松山區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 13000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡6-10年", BuildingAge = "8年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 7, Floor = "地下室", Furniture = "部分家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string>() },
    new Rent { Area = "松山區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 9500, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡11-15年", BuildingAge = "15年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 4, Floor = "1樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string> { "女性專用" } },
    new Rent { Area = "松山區", RentalType = "整租", RentalCategory = "工業", RentAmount = 25000, DepositMonths = 2, BuildingType = "廠房", HouseCondition = "屋齡21年以上", BuildingAge = "30年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 40, Floor = "1樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string>() },

    // 信義區 (5 筆，高檔區)
    new Rent { Area = "信義區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 70000, DepositMonths = 2, BuildingType = "大樓", HouseCondition = "新成屋", BuildingAge = "1年", Rooms = 3, Halls = 2, Bathrooms = 2, AreaPings = 45, Floor = "15樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "熱水器", "洗衣機", "冰箱", "電視" }, OtherConditions = new List<string> { "近捷運", "有停車位" } },
    new Rent { Area = "信義區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 32000, DepositMonths = 2, BuildingType = "公寓", HouseCondition = "屋齡1-5年", BuildingAge = "2年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 14, Floor = "5樓以上", Furniture = "全套家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string>() },
    new Rent { Area = "信義區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 24000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡6-10年", BuildingAge = "5年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 9, Floor = "3樓", Furniture = "部分家具", Equipment = new List<string> { "熱水器" }, OtherConditions = new List<string> { "可養寵物" } },
    new Rent { Area = "信義區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 20000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡11-15年", BuildingAge = "13年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 11, Floor = "2樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "信義區", RentalType = "整租", RentalCategory = "商業", RentAmount = 100000, DepositMonths = 2, BuildingType = "店面", HouseCondition = "新成屋", BuildingAge = "4年", Rooms = 0, Halls = 0, Bathrooms = 2, AreaPings = 60, Floor = "1樓", Furniture = "無家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string> { "有停車位" } },

    // 大同區 (5 筆)
    new Rent { Area = "大同區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 14000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡16-20年", BuildingAge = "19年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 8, Floor = "1樓", Furniture = "部分家具", Equipment = new List<string> { "洗衣機" }, OtherConditions = new List<string>() },
    new Rent { Area = "大同區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 28000, DepositMonths = 2, BuildingType = "大樓", HouseCondition = "屋齡21年以上", BuildingAge = "26年", Rooms = 2, Halls = 1, Bathrooms = 1, AreaPings = 22, Floor = "4樓", Furniture = "全套家具", Equipment = new List<string> { "冰箱", "電視" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "大同區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 11000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "新成屋", BuildingAge = "1年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 5, Floor = "地下室", Furniture = "無家具", Equipment = new List<string> { "熱水器" }, OtherConditions = new List<string>() },
    new Rent { Area = "大同區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 8000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡1-5年", BuildingAge = "3年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 4, Floor = "2樓", Furniture = "部分家具", Equipment = new List<string>() , OtherConditions = new List<string> { "可養寵物" } },
    new Rent { Area = "大同區", RentalType = "整租", RentalCategory = "商業", RentAmount = 35000, DepositMonths = 2, BuildingType = "店面", HouseCondition = "屋齡6-10年", BuildingAge = "9年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 20, Floor = "1樓", Furniture = "無家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string>() },

    // 萬華區 (5 筆，老區，低租金)
    new Rent { Area = "萬華區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 9000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡11-15年", BuildingAge = "14年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 4, Floor = "3樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string>() },
    new Rent { Area = "萬華區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 13000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡16-20年", BuildingAge = "17年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 7, Floor = "1樓", Furniture = "部分家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "萬華區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 25000, DepositMonths = 2, BuildingType = "透天厝", HouseCondition = "屋齡21年以上", BuildingAge = "35年", Rooms = 2, Halls = 1, Bathrooms = 1, AreaPings = 18, Floor = "2樓", Furniture = "全套家具", Equipment = new List<string> { "熱水器", "洗衣機" }, OtherConditions = new List<string>() },
    new Rent { Area = "萬華區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 7000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "新成屋", BuildingAge = "2年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 3, Floor = "頂樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string> { "女性專用" } },
    new Rent { Area = "萬華區", RentalType = "整租", RentalCategory = "商業", RentAmount = 20000, DepositMonths = 2, BuildingType = "店面", HouseCondition = "屋齡1-5年", BuildingAge = "4年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 15, Floor = "1樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string>() },

    // 內湖區 (5 筆，科技園區)
    new Rent { Area = "內湖區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 34000, DepositMonths = 2, BuildingType = "大樓", HouseCondition = "屋齡6-10年", BuildingAge = "6年", Rooms = 2, Halls = 1, Bathrooms = 2, AreaPings = 25, Floor = "5樓以上", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "冰箱", "電視" }, OtherConditions = new List<string> { "有停車位" } },
    new Rent { Area = "內湖區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 16000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡11-15年", BuildingAge = "12年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 9, Floor = "4樓", Furniture = "部分家具", Equipment = new List<string> { "熱水器" }, OtherConditions = new List<string>() },
    new Rent { Area = "內湖區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 12000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡16-20年", BuildingAge = "18年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 6, Floor = "2樓", Furniture = "無家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "內湖區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 10000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡21年以上", BuildingAge = "24年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 5, Floor = "1樓", Furniture = "部分家具", Equipment = new List<string>() , OtherConditions = new List<string>() },
    new Rent { Area = "內湖區", RentalType = "整租", RentalCategory = "工業", RentAmount = 30000, DepositMonths = 2, BuildingType = "廠房", HouseCondition = "新成屋", BuildingAge = "1年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 35, Floor = "1樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string> { "有停車位" } },

    // 南港區 (5 筆)
    new Rent { Area = "南港區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 15000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡1-5年", BuildingAge = "3年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 8, Floor = "3樓", Furniture = "全套家具", Equipment = new List<string> { "洗衣機" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "南港區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 29000, DepositMonths = 2, BuildingType = "公寓", HouseCondition = "屋齡6-10年", BuildingAge = "7年", Rooms = 2, Halls = 1, Bathrooms = 1, AreaPings = 20, Floor = "頂樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "熱水器" }, OtherConditions = new List<string>() },
    new Rent { Area = "南港區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 10500, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡11-15年", BuildingAge = "11年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 5, Floor = "地下室", Furniture = "部分家具", Equipment = new List<string> { "冰箱" }, OtherConditions = new List<string>() },
    new Rent { Area = "南港區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 8500, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡16-20年", BuildingAge = "16年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 4, Floor = "2樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string> { "可養寵物" } },
    new Rent { Area = "南港區", RentalType = "整租", RentalCategory = "商業", RentAmount = 22000, DepositMonths = 2, BuildingType = "店面", HouseCondition = "屋齡21年以上", BuildingAge = "28年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 18, Floor = "1樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string>() },

    // 文山區 (5 筆，住宅區)
    new Rent { Area = "文山區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 26000, DepositMonths = 2, BuildingType = "透天厝", HouseCondition = "新成屋", BuildingAge = "1年", Rooms = 3, Halls = 2, Bathrooms = 2, AreaPings = 30, Floor = "1樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "洗衣機", "電視" }, OtherConditions = new List<string> { "有停車位" } },
    new Rent { Area = "文山區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 14000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡1-5年", BuildingAge = "5年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 7, Floor = "4樓", Furniture = "部分家具", Equipment = new List<string> { "熱水器" }, OtherConditions = new List<string>() },
    new Rent { Area = "文山區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 10000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡6-10年", BuildingAge = "8年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 5, Floor = "1樓", Furniture = "無家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "文山區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 7500, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡11-15年", BuildingAge = "13年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 3, Floor = "2樓", Furniture = "部分家具", Equipment = new List<string>() , OtherConditions = new List<string>() },
    new Rent { Area = "文山區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 22000, DepositMonths = 2, BuildingType = "大樓", HouseCondition = "屋齡16-20年", BuildingAge = "19年", Rooms = 2, Halls = 1, Bathrooms = 1, AreaPings = 16, Floor = "3樓", Furniture = "全套家具", Equipment = new List<string> { "冰箱" }, OtherConditions = new List<string> { "可養寵物" } },

    // 北投區 (5 筆，郊區)
    new Rent { Area = "北投區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 12000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡21年以上", BuildingAge = "32年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 6, Floor = "地下室", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string>() },
    new Rent { Area = "北投區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 20000, DepositMonths = 2, BuildingType = "透天厝", HouseCondition = "新成屋", BuildingAge = "2年", Rooms = 2, Halls = 1, Bathrooms = 1, AreaPings = 15, Floor = "1樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "熱水器" }, OtherConditions = new List<string> { "有停車位" } },
    new Rent { Area = "北投區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 8000, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "屋齡1-5年", BuildingAge = "4年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 4, Floor = "頂樓", Furniture = "部分家具", Equipment = new List<string> { "洗衣機" }, OtherConditions = new List<string>() },
    new Rent { Area = "北投區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 6000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡6-10年", BuildingAge = "9年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 3, Floor = "5樓以上", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "北投區", RentalType = "整租", RentalCategory = "農地", RentAmount = 15000, DepositMonths = 1, BuildingType = "農舍", HouseCondition = "屋齡11-15年", BuildingAge = "12年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 50, Floor = "1樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string>() },

    // 士林區 (5 筆)
    new Rent { Area = "士林區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 24000, DepositMonths = 2, BuildingType = "大樓", HouseCondition = "屋齡16-20年", BuildingAge = "17年", Rooms = 2, Halls = 1, Bathrooms = 2, AreaPings = 18, Floor = "4樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "冰箱", "電視" }, OtherConditions = new List<string> { "可養寵物" } },
    new Rent { Area = "士林區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 11000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡21年以上", BuildingAge = "25年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 5, Floor = "2樓", Furniture = "部分家具", Equipment = new List<string> { "熱水器" }, OtherConditions = new List<string>() },
    new Rent { Area = "士林區", RentalType = "雅房", RentalCategory = "住宅", RentAmount = 8500, DepositMonths = 1, BuildingType = "大樓", HouseCondition = "新成屋", BuildingAge = "1年", Rooms = 0, Halls = 0, Bathrooms = 1, AreaPings = 4, Floor = "1樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣" }, OtherConditions = new List<string> { "近捷運" } },
    new Rent { Area = "士林區", RentalType = "分租", RentalCategory = "住宅", RentAmount = 5500, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "屋齡1-5年", BuildingAge = "3年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 3, Floor = "3樓", Furniture = "無家具", Equipment = new List<string>() , OtherConditions = new List<string>() },
    new Rent { Area = "士林區", RentalType = "整租", RentalCategory = "住宅", RentAmount = 18000, DepositMonths = 2, BuildingType = "透天厝", HouseCondition = "屋齡6-10年", BuildingAge = "10年", Rooms = 3, Halls = 1, Bathrooms = 1, AreaPings = 12, Floor = "1樓", Furniture = "部分家具", Equipment = new List<string> { "洗衣機" }, OtherConditions = new List<string> { "有停車位" } }
};



            // 列出每個區域中「房間數 >= 2 且透天厝」的租金平均數

            var re = rentData.Where(x => x.Rooms >= 2).ToList();
            var temp = re.GroupBy(x => x.Area)
                         .Select(x => new
                         {
                             x.Key,
                             AvgRentPrice = x.Average(y => y.RentAmount)
                         })
                         .OrderByDescending(x => x.AvgRentPrice)
                         .ToList();





            // new Rent { Area = "中正區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 15000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "新成屋", BuildingAge = "1年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 8, Floor = "3樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "熱水器" }, OtherConditions = new List<string> { "近捷運" } },

            //情境： 你的好友想在中山區或松山區找一個經濟實惠的套房，預算不超過 20000 元，偏好空間大的房子。他希望你幫他列出前 3 個最適合的選擇，並告訴他每個房子的地點、租金和大小。如果這兩個區域完全沒有符合條件的房子，請簡單告訴他“目前沒有合適的選擇”。你該怎麼幫他整理這些資訊？

            Console.WriteLine("題目1");
            var result = rentData
                .Where(x => x.Area == "中山區" || x.Area == "松山區")
                .Where(x => x.RentAmount <= 20000)
                .OrderByDescending(x => x.AreaPings)
                .Take(3)
                .Select((x, index) => $"推薦TOP{index + 1}：地點[{x.Area}]，租金[{x.RentAmount}]元，坪數[{x.AreaPings}]坪。")
                .ToList();
            if (result.Any())
            {
                Console.WriteLine(string.Join("\r\n", result));
            }
            else
            {
                Console.WriteLine("目前沒有合適的選擇");
            }

            //情境： 你的表弟即將到大安區工作，急需一間有全套家具且靠近捷運站的雅房。他問你能不能幫他找第一個符合條件的房子，並把房子的所有細節列出來，還想知道裡面的設備是按數量多少排序的。你該如何幫他找到這個理想居所？

            Console.WriteLine("題目2");
            var result2 = rentData.Where(x => x.Area == "大安區")
                                  .Where(x => x.Furniture == "全套家具")
                                  .Where(x => x.RentalType == "雅房")
                                  .Where(x => x.OtherConditions.Any(g => g == "近捷運"))
                                  .OrderByDescending(x => x.Equipment.Count)
                                  .ToList();
            if (result2.Count > 0)
            {
                for (int i = 0; i < result2.Count; i++)
                {
                    Console.WriteLine($"推薦{i + 1}：");
                    foreach (PropertyInfo property in typeof(Rent).GetProperties())
                    {

                        if (typeof(IEnumerable<string>).IsAssignableFrom(property.PropertyType))
                        {
                            IEnumerable<string> datas = (IEnumerable<string>)property.GetValue(result2[i]);
                            string res = string.Join(",", datas);
                            Console.WriteLine($"{property.Name}：{res}");
                        }
                        else
                        {
                            Console.WriteLine($"{property.Name}：{property.GetValue(result2[i])}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("目前沒有合適的選擇");
            }


            //情境： 一位客戶托你找台北市最貴的住宅出租物件，想知道是哪些房子達到這個價格，並列出它們的所在區域和樓層。
            //他還好奇是否有商業用房比這個價格還高，想讓你確認一下。你該怎麼查出這些頂級房源並給他回饋？

            Console.WriteLine("題目3");
            int residentHousePrice = (int)rentData
                .Where(x => x.RentalCategory == "住宅")
                .Max(y => y.RentAmount);
            var result3 = rentData
                .Where(x => x.RentalCategory == "住宅")
                .Where(x => x.RentAmount == residentHousePrice)
                .Select((x, index) => $"高級住宅{index + 1}：地點[{x.Area}]，樓層[{x.Floor}]，價格[{x.RentAmount}]元。")
                .ToList();
            var resultBussiness = rentData
                .Where(x => x.RentalCategory == "商業")
                .Any(x => x.RentAmount == residentHousePrice);

            if (result.Any())
            {
                Console.WriteLine(string.Join("\r\n", result3));
            }
            else
            {
                Console.WriteLine("目前沒有合適的選擇");
            }
            string higherBusinessHouse = resultBussiness ? "是" : "否";
            Console.WriteLine("是否有更高租金的商業用房？" + "\"" + higherBusinessHouse + "\"");

            //1.5           2
            //情境： 你的房東協會要求你調查台北市所有房源的平均押金月數，然後找出每一間所需支付的押金月數大於等於這個所有房源的平均租金，
            //告訴他們這些房子分佈在哪些區域，以及每個區域有多少間這樣的房子，但只關注區域內有超過一間的。你該怎麼計算並整理這些資料？
            Console.WriteLine();
            Console.WriteLine("題目4");
            int averageRentMonth = (int)Math.Ceiling((decimal)rentData.Sum(x => x.DepositMonths) / rentData.Count);

            int averageRent = (int)rentData.Where(x => x.DepositMonths >= averageRentMonth)
                                           .Average(x => x.RentAmount);

            var depositMoreThanEverageList = rentData.Where(x => x.DepositMonths >= averageRentMonth)
                                                     .GroupBy(x => x.Area)
                                                     .Where(group => group.Count() >= 2)
                                                     .Select(x => new
                                                     {
                                                         x.Key,
                                                         zoneHouseAmount = x.Count()
                                                     })
                                                     .OrderByDescending(x => x.zoneHouseAmount);

            Console.WriteLine($"台北市全部租屋平均押金月數：{averageRentMonth}個月(無條件進位)。");
            Console.WriteLine($"大於此月數的所有房源，其平均租金為 {averageRent} 元。");
            Console.WriteLine("並分布於");
            foreach (var group in depositMoreThanEverageList)
            {
                Console.WriteLine($"區域: {group.Key}，符合條件數量： {group.zoneHouseAmount} 案");
            }

            // new Rent { Area = "中正區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 15000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "新成屋", BuildingAge = "1年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 8, Floor = "3樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "熱水器" }, OtherConditions = new List<string> { "近捷運" } },
            //情境： 一位大學生朋友計畫在內湖區或南港區租個小雅房，屋子最好是近幾年蓋的（1 - 5 年），
            //他希望你幫他列出格局（房間加廳）最多的前 5 個選擇，並告訴他每間的格局和租金。
            //如果文山區也有類似條件，他想知道有沒有這樣的選項。你該怎麼幫他找到這些房源？

            Console.WriteLine();
            Console.WriteLine("題目5");
            var result5 = rentData.Where(x => x.Area == "內湖區" || x.Area == "南港區")
                                  .Where(x => x.RentalType == "雅房")
                                  .Where(x => x.HouseCondition == "屋齡1-5年")
                                  .OrderByDescending(x => x.Halls + x.Rooms)
                                  .Take(5)
                                  .Select((x, index) => $"選項{index + 1}：地區{x.Area}，格局：{x.Halls}廳{x.Rooms}房，租金：{x.RentAmount}元");
            if (result5.Any())
            {
                Console.WriteLine(string.Join("\r\n", result5));
            }
            else
            {
                Console.WriteLine("目前沒有合適的選擇");
            }

            var viceResult5 = rentData.Where(x => x.Area == "文山區")
                                  .Where(x => x.RentalType == "雅房")
                                  .Where(x => x.HouseCondition == "屋齡1-5年")
                                  .Count();

            if (viceResult5 > 0)
            {
                Console.WriteLine($"文山區有符合條件的雅房{viceResult5}間。");
            }
            else
            {
                Console.WriteLine("文山區目前沒有符合條件的雅房。");
            }


            //情境： 你的創業夥伴想在內湖區租一個工業用空間，條件是必須有停車位。他問你是否有這樣的房子，如果有，幫他列出所有符合條件的選項，
            //並按屋齡從新到舊排序，告訴他每間的屋齡和租金。你該怎麼幫他確認並整理這些資訊？
            Console.WriteLine();
            Console.WriteLine("題目6");





            //情境： 你的房地產顧問公司要準備一份報告，分析不同租賃類型（像整租或套房）的市場行情。請幫忙列出每種類型的平均租金和最大坪數，
            //只挑出平均租金超過 20000 元的類型，並按最大坪數從大到小排序，告訴他們每種類型的行情概況。你該怎麼分析這些數據？




            //情境： 一位家電銷售員想知道台北市哪個區域的租屋最多人裝冷氣，於是你決定查出所有有冷氣的房子，
            //然後按區域統計這些房子的比例（有冷氣的數量除以總數），列出比例最高的 3 個區域和對應的比例數據。你該怎麼調查並整理這個資訊？
            Console.WriteLine();
            Console.WriteLine("題目8");

            // 1.先按區域groupby 2.select 3.orderbydecending

            var result8 = rentData.GroupBy(x => x.Area)
                                  .Select((x, index) =>
                                  {
                                      int airdconditionCount = x.Where(y => y.Equipment.Any(g => g == "冷氣")).Count();
                                      double areaCount = x.Count();
                                      var data = new
                                      {
                                          x.Key,
                                          percentage = ((airdconditionCount / areaCount) * 100).ToString("F2") + "%",

                                      };

                                      return data;

                                  })
                                  .OrderByDescending(x => x.percentage)
                                  .Select((x, index) => $"排名{index + 1}：{x.Key}，比例{x.percentage}。")
                                  .Take(3);
            Console.WriteLine("台北市租屋有冷氣房源比例區域：");
            Console.WriteLine(string.Join("\r\n", result8));

            //情境9： 你的親戚想租一間有全套家具且條件特別多的房子（至少兩個額外條件，如近捷運），他希望你幫他找出最常見的額外條件是什麼，
            //然後列出所有符合該條件的房子，並按租金從低到高排序，告訴他每個房子的條件和租金。你該怎麼幫他找到這些理想選擇？

            //情境10： 你的房產投資團隊想研究不同屋況（像新成屋或老屋）的房屋特點。請幫忙按屋況分類，找出每種屋況下設備的多樣性（不同設備種類數），只挑出多樣性超過 3 種的屋況，並按平均租金從高到低排序，告訴他們每種屋況的平均租金和設備多樣性。你該怎麼分析這些房屋特徵？
            //情境11： 一位客戶指定優先考慮“洗衣機”、“冰箱”和“電視”這三種設備的房子，他想知道哪些區域的房子最常配備這些設備。請幫他按區域統計這些優先設備的總數量，列出數量最多的 4 個區域和對應的統計數據。你該怎麼幫他找出這些熱門區域？
            //情境12： 你的房東朋友想知道租屋市場上最熱門的額外條件和設備是什麼，於是你決定分析所有房屋的額外條件和設備，找出前 3 個出現最頻繁的項目，然後列出滿足這些項目的所有房子，按坪數分類每個項目的子群，告訴他每個子群的平均租金和坪數範圍。你該怎麼挖掘這些市場趨勢？

            // new Rent { Area = "中正區", RentalType = "套房", RentalCategory = "住宅", RentAmount = 15000, DepositMonths = 1, BuildingType = "公寓", HouseCondition = "新成屋", BuildingAge = "1年", Rooms = 1, Halls = 0, Bathrooms = 1, AreaPings = 8, Floor = "3樓", Furniture = "全套家具", Equipment = new List<string> { "冷氣", "熱水器" }, OtherConditions = new List<string> { "近捷運" } },
            //情境13： 一位投資者想知道每個樓層類型下租金的中位數（中間值），他只感興趣於中位數超過 15000 元的樓層，接著想知道這些樓層的房子常見的設備有哪些。請幫他列出這些樓層類型，並統計每個樓層上設備的出現比例（超過一半的設備），告訴他樓層和對應的比例。你該怎麼計算並整理這些數據？

            Console.WriteLine();
            Console.WriteLine("題目13");

            var floorList = rentData.GroupBy(x => x.Floor)
                                    .Where(x =>
                                    {
                                        double median = x.Select(y => (double)y.RentAmount).Median();
                                        return median > 15000;
                                    })
                                    .Select(x =>
                                    {


                                        var data = new
                                        {

                                        };

                                        return data;
                                    }
                                    );

            //情境： 你的數據分析團隊要研究台北市不同區域和租賃類型的租金穩定性。請幫忙按區域和租賃類型分類，計算每個組合的租金總額和租金變異數（租金差異程度），只挑出變異數超過 10000 的組合，然後統計這些組合中獨特的額外條件數量，按總租金從高到低排序，告訴他們每個組合的細節。你該怎麼分析這些租金波動？
            //情境： 你的房東協會收到競爭對手的最新租屋數據（假設租金比現有數據高 10 %），你需要將這兩個數據集合併，比較每對相同順序的房子租金差（新 - 舊），找出差額超過 5000 元的配對，然後按區域分類，計算每個區域的平均差額，再找出這些區域中最常見的設備，告訴他們區域、平均差額和頂級設備。你該怎麼整合並分析這些競爭數據？
            //情境： 一位預算有限的租客想找租金低的房子，問你能幫他列出從最便宜開始的房源，直到租金超過 25000 元為止。接著，他想知道這些房源中最常見的額外條件有哪些（出現超過 2 次的），並按坪數分類這些條件下的子群，計算每個子群的租金標準差（差異程度），列出標準差最低的子群和對應的條件、坪數範圍。你該怎麼幫他找到性價比高的選擇？
            //情境： 你的建築師朋友想研究不同建築類型（如公寓或大樓）的設備配置。請幫他按建築類型分類，找出每種類型下獨特的設備集合，然後篩選出至少有 3 種獨特設備的類型，計算這些類型的平均屋齡（按年數），按屋齡從老到新排序，告訴他每種類型、平均屋齡和獨特設備列表。你該怎麼整理這些建築數據？
            //情境： 一位女性租客只考慮適合女性的房子（有“女性專用”標籤），她想知道這些房子和沒有該標籤的房子有哪些共通的設備。請幫她找出這兩類房子的共同設備，然後計算這些共同設備在兩類房子的總租金（租金加押金費用）總和，只列出總和超過 50000 元的設備和對應總額。你該怎麼幫她分析設備共性？
            //情境： 你的房產顧問要分析不同屋況和樓層組合下的租金性價比。請幫他按屋況和樓層分類，計算每個組合的租金與坪數比率的中位數和平均值，只挑出中位數比率超過 1500 的組合，然後統計這些組合中一致擁有的額外條件和設備（全有該項的組合），按中位數比率從高到低排序，告訴他每個組合的詳細數據。你該怎麼深入挖掘這些性價比資訊？
            //情境： 一位投資者給你三個租金預算（10000、30000、50000 元）和兩個目標區域（信義區、北投區），他想知道每個預算下這些區域的房屋分佈情況。請幫他按預算和區域分類，計算每個組合的房屋數量和平均坪數，排除房屋數少於 2 的組合，然後根據坪數和預算計算每組合的潛在價值（坪數 * 預算），列出價值最高的 10 個組合，告訴他每個組合的詳細情況。你該怎麼幫他規劃投資策略？

            Console.ReadKey();
        }
    }
}
