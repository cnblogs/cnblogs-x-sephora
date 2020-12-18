using System;
using System.Linq;

namespace cnblogs_x_sephora
{
    class Program
    {
        static void Main(string[] args)
        {
            var 优惠福利 = new[]
            {
                "2020.12.18-2021.1.3",
                "SEPHORA丝芙兰小程序新注册会员首单享满398减50或满698减100的优惠活动",
                "注册后在购物车结算页面输入口令“BKY12”（不区分大小写）即可享受优惠"
            };

            优惠福利.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();


            Console.WriteLine("圣诞「WOW」灵感礼单");
            Console.WriteLine("为TA达成年终心愿");
            Console.WriteLine();
            Console.WriteLine("圣诞节的来临，正式奏响了年末赠礼的序曲");
            Console.WriteLine("期待值满分的精选礼单，让TA在开箱时刻惊喜“WOW” ！");
            Console.WriteLine();

            var offers = new[] { 圣诞礼单Part1, 圣诞礼单Part2, 圣诞礼单Part3, 圣诞礼单Part4 };

            var offer = offers[new Random().Next(offers.Length - 1)];
            Console.WriteLine(offer.Title);
            Console.WriteLine(offer.Subtitle);
            foreach (var product in offer.Products)
            {
                Console.WriteLine(product);
            }
        }

        private static dynamic 圣诞礼单Part1 => new
        {
            Title = "灵感精选 闪耀挚礼",
            Subtitle = "热推力荐的挚爱之礼，为你开启礼赠灵感。应景又应季、色彩感满分的闪耀美礼，为节日增添气氛，更为TA献上温馨祝福！",
            Products = new[]
            {
                (Brand: "GUERLAIN", ProductName: "娇兰帝皇蜂姿抗皱赋源眼霜套装"),
                (Brand: "GIVENCHY", ProductName: "纪梵希高定香榭唇膏（星钻限量版）"),
                (Brand: "SEB", ProductName: "丝芙兰狂野愿望彩妆盘"),
                (Brand: "Dior", ProductName: "克丽丝汀迪奥真我香氛节日套装"),
                (Brand: "Wei", ProductName: "蔚蓝之美沁透滋养面膜套装")

            }
        };

        private static dynamic 圣诞礼单Part2 => new
        {
            Title = "为她选礼：经典更惊喜",
            Subtitle = "无论是闺蜜还是爱人，都值得以经典致彼此间的长久默契——典藏大牌美礼，为她带去不期而遇的惊喜！",
            Products = new[]
            {
                (Brand: "shiseido", ProductName: "资生堂新红妍肌活精华露30ml优惠套组"),
                (Brand: "SK-II", ProductName: "SK-II 晶透赋能礼盒"),
                (Brand: "Dior", ProductName: "克丽丝汀迪奥烈焰蓝金唇膏999（ 全新上市）"),
                (Brand: "ADF", ProductName: "蔻依仙境花园系列香氛-木兰诗语惠选套装")
            }
        };

        private static dynamic 圣诞礼单Part3 => new
        {
            Title = "为自己选礼：小众更特别",
            Subtitle = "了解你的喜好、懂得你心思的，总是自己——送给自己的年末节日礼，是特别的、真正适合的。抛开大众所向，将“真爱”小众系列收入囊中！",
            Products = new[]
            {
                (Brand: "ELEMIS", ProductName: "海洋胶原经典「小黄罐」卸妆膏礼盒"),
                (Brand: "SEB", ProductName: "丝芙兰狂野愿望 身体礼盒"),
                (Brand: "Marie Dalgar Color studio", ProductName: "玛丽黛佳色彩工作室醉恋复古多功能眼彩盘 微醺甜茶"),
                (Brand: "AC", ProductName: "欧珑逐爱柑香圣诞夜礼盒")
            }
        };

        private static dynamic 圣诞礼单Part4 => new
        {
            Title = "为他选礼：实用更贴心",
            Subtitle = "无需花哨，他常用的或是易忽略的好物，作为贴心问候，带给他呵护与陪伴。实用的护肤香氛礼，为他驻守魅力阵地！",
            Products = new[]
            {
                (Brand: "LOEWE", ProductName: "罗意威第7乐章男款淡香水"),
                (Brand: "MOSCHINO", ProductName: "默斯奇诺熊男友香水"),
                (Brand: "BIOTHERM", ProductName: "碧欧泉蓝钻滋养奢宠惠选套组"),
                (Brand: "LAB SERIES", ProductName: "朗仕熬夜精华乳惠选套组")
            }
        };
    }
}
