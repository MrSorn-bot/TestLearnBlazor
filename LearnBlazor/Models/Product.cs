namespace LearnBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<Product_Prop> ProductProperties { get; set; }
    }
}
//}
//namespace LearnBlazor.Models
//{
//    public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public double Price { get; set; }
//        public bool IsActive { get; set; }
//        public Days ProductProperties { get; set; }

//    }

//    public enum Days
//    {
//        None,
//        Monday,  // 1
//        Tuesday,  // 2
//        Wednesday,  // 4
//        Thursday,  // 8

//        Friday,  // 16
//        Saturday,  // 32
//        Sunday,  // 64
//        Weekend
//    }




//}
