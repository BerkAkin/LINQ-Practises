using System.Linq;

namespace LinqConsoleApp.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            using (var context = new LinqDbContext())
            {
                if (context.Students.Any())
                {
                    return;
                }
                else
                {
                    context.Students.AddRange(
                        new Student()
                        {
                            Name = "Berk",
                            Surname = "Akın",
                            ClassId = 12

                        },
                        new Student()
                        {
                            Name = "Deniz",
                            Surname = "Arda",
                            ClassId = 13
                        },
                        new Student()
                        {
                            Name = "Umut",
                            Surname = "Maden",
                            ClassId = 14
                        },
                        new Student()
                        {
                            Name = "Deniz",
                            Surname = "Tok",
                            ClassId = 15
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}