using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftNews.Models
{
    public class NewsManager
    {
        private static List<News> GetNews()
        {
            var news = new List<News>();

            news.Add(new News("bds", NewsCategory.Business, "Gía nhà đất đang tăng", "Giá nhà khu chung cư VinHome đang tăng mạnh"));
            news.Add(new News("ttck", NewsCategory.Business, "Cổ phiếu công nghệ tăng trưởng","Giá cổ phiếu của Apple và Amazon tăng trưởng mạnh"));
            news.Add(new News("gv", NewsCategory.Business, "Giá vàng giảm 2 triệu", "Có nên đầu tư vàng vào thời điểm này"));

            news.Add(new News("covid", NewsCategory.Heath, "Đã kiểm soạt được Covid-19 ở Việt Nam", "Trong 7 ngày liên tiếp không có thêm ca mắc mới"));
            news.Add(new News("skdd", NewsCategory.Heath, "Dinh dưỡng cần thiết để cao hơn", "Một số sản phẩm giúp tăng chiều cao"));
            news.Add(new News("sksl", NewsCategory.Heath, "Kiến thức phổ cập về an toàn ", "Phổ cập về an toàn tình dục tại trường học từ THCS trở lên"));

            news.Add(new News("pat", NewsCategory.Hitech, "Iphone 12", "Màn hình iphone 12 không được update"));
            news.Add(new News("lap", NewsCategory.Hitech, "Huawei Mate D15", "Giá cả phù hợp trong tầm 15 triệu"));
            news.Add(new News("pk", NewsCategory.Hitech, "Tai nghe Sony không dây", "Âm thanh tuyệt đỉnh"));

            news.Add(new News("vn", NewsCategory.Showbiz, "30 chưa phải là hết", "Chuyển thể sang bản Việt Nam"));
            news.Add(new News("asia", NewsCategory.Showbiz, "Muốn Gặp Anh", "Bộ phim có yếu tố xuyên không hay 2019-2020"));
            news.Add(new News("hollywood", NewsCategory.Showbiz, "The New Mutans", "Khời chiếu từ 3/9/2020"));

            news.Add(new News("football", NewsCategory.Sport, "Messi rời Barca", "Ai có thể thế chỗ Messi tại Barca"));
            news.Add(new News("speed", NewsCategory.Sport, "Mẫu xe mới của Ferrari", "Tốc độ kỷ lục mới"));
            news.Add(new News("fighting", NewsCategory.Sport, "UFC", "Trận đấu giữa Jack Nguyễn và Pacman"));

            news.Add(new News("hotspot", NewsCategory.TheWorld, "Mỹ và Trung Quốc", "Đòn trừng phạt giữa 2 nước"));
            news.Add(new News("qs", NewsCategory.TheWorld, "Chiến hạm Mỹ vào biển Đông", "Trung Quốc thử tên lửa tại biển Đông"));
            news.Add(new News("discover", NewsCategory.TheWorld, "Cực quang ở Bắc Cực", "Thời điểm có thể ngắm cực quang đẹp nhất trong năm"));


            return news;
        }

        public static void GetAllNews(ObservableCollection<News> news)
        {
            var allNews = GetNews();
            news.Clear();
            allNews.ForEach(p => news.Add(p));
        }

        public static void GetNewsByCategory(ObservableCollection<News> news, NewsCategory newsCategory)
        {
            var allNews = GetNews();
            var filteredNews = allNews.Where(p => p.Category == newsCategory).ToList();
            news.Clear();
            filteredNews.ForEach(p => news.Add(p));
        }

        public static void GetNewsByName(ObservableCollection<News> news, string name)
        {
            var allNews = GetNews();
            var filteredNews = allNews.Where(p => p.Name == name).ToList();
            news.Clear();
            filteredNews.ForEach(p => news.Add(p));
        }
    }
}
