using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _591RentPractice
{
    public class Rent
    {
        public string Area { get; set; } // 租賃地區 e.g., 大安區，信義區，內湖區，南港區，中正區 .etc
        public string RentalType { get; set; } // 租賃類型 e.g., "整租", "套房", "雅房", "分租", "店面"
        public string RentalCategory { get; set; } // 租賃類別 e.g., "住宅", "商業", "工業", "農地", "其他"
        public decimal RentAmount { get; set; } // 租金金額 e.g., 8000
        public int DepositMonths { get; set; } // 押金 e.g., 1, 2
        public string BuildingType { get; set; } // 權狀 e.g., "公寓", "大樓", "透天厝", "農舍", "店面", "廠房", "農地", "其他"
        public string HouseCondition { get; set; } // 房屋狀況 e.g., "新成屋", "屋齡1-5年", "屋齡6-10年", "屋齡11-15年", "屋齡16-20年", "屋齡21年以上"
        public string BuildingAge { get; set; } // 屋齡 e.g., "1年", "2年", "3年", "4年", "5年以上"
        public int Rooms { get; set; } // 格局 (房間數) e.g., 1, 2, 3
        public int Halls { get; set; } // 廳房 e.g., 1, 2, 3, 4
        public int Bathrooms { get; set; } // 衛浴 e.g., 1, 2
        public decimal AreaPings { get; set; } // 坪數 e.g., 15.5
        public string Floor { get; set; } // 樓層 e.g., "1樓", "2樓", "3樓", "4樓", "5樓以上", "地下室", "頂樓"
        public string Furniture { get; set; } // 傢俱 e.g., "全套家具", "部分家具", "無家具"
        public List<string> Equipment { get; set; } = new List<string>(); // 設備 e.g., "冷氣", "熱水器", "洗衣機", "冰箱", "電視"
        public List<string> OtherConditions { get; set; } = new List<string>(); // 其他 e.g., "可養寵物", "近捷運", "有停車位", "女性專用", "無"

        public Rent()
        {
            // Default constructor
        }
    }
}
