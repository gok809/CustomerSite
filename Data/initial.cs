using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.Data
{
    public class initial
    {
        public static void Initialize(Service_Context context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var Customers = new Customer[]
            {
            new Customer{Cs_idx=0,Id="Carson",Pw="Alexander",Join_date=DateTime.Parse("2005-09-01"),Login_date=DateTime.Parse("2012-09-01")},
            new Customer{Cs_idx=1,Id="Meredith",Pw="Alonso",Join_date=DateTime.Parse("2002-09-01"),Login_date=DateTime.Parse("2012-09-01")},
            new Customer{Cs_idx=2,Id="Arturo",Pw="Anand",Join_date=DateTime.Parse("2003-09-01"),Login_date=DateTime.Parse("2009-09-01")},
            new Customer{Cs_idx=3,Id="Gytis",Pw="Barzdukas",Join_date=DateTime.Parse("2002-09-01"),Login_date=DateTime.Parse("2014-09-01")},
            new Customer{Cs_idx=4,Id="Yan",Pw="Li",Join_date=DateTime.Parse("2002-09-01"),Login_date=DateTime.Parse("2015-09-01")},
            new Customer{Cs_idx=5,Id="Peggy",Pw="Justice",Join_date=DateTime.Parse("2001-09-01"),Login_date=DateTime.Parse("2008-09-01")},
            new Customer{Cs_idx=6,Id="Laura",Pw="Norman",Join_date=DateTime.Parse("2003-09-01"),Login_date=DateTime.Parse("2003-09-01")},
            new Customer{Cs_idx=7,Id="Nino",Pw="Olivetto",Join_date=DateTime.Parse("2005-09-01"),Login_date=DateTime.Parse("2013-09-01")}
            };
            foreach (Customer s in Customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();

            var Questions = new Question[]
            {
            new Question{Qs_idx=1050,Cs_idx=0,Ad_idx=0,Title="Chemistry",Content="안녕하세요.",Quest_date=DateTime.Parse("2012-09-01")},
            new Question{Qs_idx=4022,Cs_idx=1,Ad_idx=0,Title="Microeconomics",Content="서버구매했는데 질문있어요.",Quest_date=DateTime.Parse("2011-09-01")},
            new Question{Qs_idx=4041,Cs_idx=2,Ad_idx=1,Title="Macroeconomics",Content="xxx오류가 나는데 어떻게 해야하나요?",Quest_date=DateTime.Parse("2010-09-01")},
            new Question{Qs_idx=1045,Cs_idx=3,Ad_idx=1,Title="Calculus",Content="질문있어요.",Quest_date=DateTime.Parse("2014-09-01")},
            new Question{Qs_idx=3141,Cs_idx=4,Ad_idx=3,Title="Trigonometry",Content="오류가나요",Quest_date=DateTime.Parse("2013-09-01")},
            new Question{Qs_idx=2021,Cs_idx=5,Ad_idx=2,Title="Composition",Content="해결해주세요.",Quest_date=DateTime.Parse("2015-09-01")},
            new Question{Qs_idx=2042,Cs_idx=6,Ad_idx=2,Title="Literature",Content="어떻게 해야하죠?",Quest_date=DateTime.Parse("2016-09-01")}
            };
            foreach (Question c in Questions)
            {
                context.Questions.Add(c);
            }
            context.SaveChanges();

            var Admins = new Admin[]
            {
            new Admin{Ad_idx=0,Ad_id="미지정",Ad_pw="alwlwjd123",Ad_level=0,Login_count=0,Ad_login_date=DateTime.Parse("2016-06-01")},
            new Admin{Ad_idx=1,Ad_id="rhksflwk1",Ad_pw="alwlwjd123",Ad_level=99,Login_count=0,Ad_login_date=DateTime.Parse("2016-06-01")},
            new Admin{Ad_idx=2,Ad_id="rhksflwk2",Ad_pw="alwlwjd123",Ad_level=99,Login_count=0,Ad_login_date=DateTime.Parse("2016-06-01")},
            new Admin{Ad_idx=3,Ad_id="rhksflwk3",Ad_pw="alwlwjd123",Ad_level=88,Login_count=0,Ad_login_date=DateTime.Parse("2016-06-01")},
            new Admin{Ad_idx=4,Ad_id="rhksflwk4",Ad_pw="alwlwjd123",Ad_level=88,Login_count=0,Ad_login_date=DateTime.Parse("2016-06-01")},
            };
            foreach (Admin e in Admins)
            {
                context.Admins.Add(e);
            }
            context.SaveChanges();

            var Orders = new Order[]
            {
            new Order{Or_idx=0,Cs_idx=1,Sv_idx=0,Total_Price=1000000,Order_quentity=1,Price_type="card",Order_date=DateTime.Parse("2016-06-01")},
            new Order{Or_idx=1,Cs_idx=5,Sv_idx=1,Total_Price=103200,Order_quentity=2,Price_type="card",Order_date=DateTime.Parse("2015-06-01")},
            new Order{Or_idx=2,Cs_idx=3,Sv_idx=2,Total_Price=1540000,Order_quentity=3,Price_type="card",Order_date=DateTime.Parse("2002-06-01")},
            new Order{Or_idx=3,Cs_idx=2,Sv_idx=3,Total_Price=1443000,Order_quentity=4,Price_type="card",Order_date=DateTime.Parse("2014-06-01")},
            new Order{Or_idx=4,Cs_idx=4,Sv_idx=4,Total_Price=45948499,Order_quentity=5,Price_type="card",Order_date=DateTime.Parse("2011-06-01")},
            };
            foreach (Order e in Orders)
            {
                context.Orders.Add(e);
            }
            context.SaveChanges();

            var Servers = new Server[]
            {
            new Server{Sv_idx=0,Sv_name="test1",Sv_type="hosting",Sv_info="test_hosting",Price=10000,Enrollment_date=DateTime.Parse("2015-06-01")},
            new Server{Sv_idx=1,Sv_name="test2",Sv_type="hosting",Sv_info="test_hosting",Price=900000,Enrollment_date=DateTime.Parse("2013-06-01")},
            new Server{Sv_idx=2,Sv_name="test3",Sv_type="cloud",Sv_info="test_cloud",Price=140000,Enrollment_date=DateTime.Parse("2012-06-01")},
            new Server{Sv_idx=3,Sv_name="test4",Sv_type="hosting",Sv_info="test_hosting",Price=90000,Enrollment_date=DateTime.Parse("2011-06-01")},
            new Server{Sv_idx=4,Sv_name="test5",Sv_type="hosting",Sv_info="test_hosting",Price=130000,Enrollment_date=DateTime.Parse("2017-06-01")},
            new Server{Sv_idx=5,Sv_name="test6",Sv_type="cloud",Sv_info="test_cloud",Price=40000,Enrollment_date=DateTime.Parse("2016-06-01")},
            new Server{Sv_idx=6,Sv_name="test7",Sv_type="cloud",Sv_info="test_cloud",Price=50000,Enrollment_date=DateTime.Parse("2018-06-01")},
            };
            foreach (Server e in Servers)
            {
                context.Servers.Add(e);
            }
            context.SaveChanges();
        }
    }
}
