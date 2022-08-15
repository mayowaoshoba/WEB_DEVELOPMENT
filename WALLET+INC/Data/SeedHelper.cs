using WALLET_INC.Data.Entities;

namespace WALLET_INC.Data
{
    public static class SeedHelper
    {
        public static async Task InitializeData(ApplicationDbContext context
            )
        {
           
            if (!context.Customers.Any())
            {


                context.Customers.Add(new Customer
                {
                    FirstName = "Mayowa",
                    LastName = "Oshoba",
                    MiddleName= "Rufai",
                    Gender = GenderEnum.Male,
                    MaritalStatus = MaritalStatusEnum.Single,
                    DateofBirth = DateTime.Now.AddYears(-20),
                    Country = "NIgeria",
                    State = "Lagos",
                    City = "Ikorodu"
                });


                context.Customers.Add(new Customer
                {
                    FirstName = "Olayinka",
                    LastName = "Olatunji",
                    MiddleName = "Michael",
                    Gender = GenderEnum.Male,
                    MaritalStatus = MaritalStatusEnum.Married,
                    DateofBirth = DateTime.Now.AddYears(-30),
                    Country = "Ghana",
                    State = "Accra",
                    City = "Tema"
                });

                await context.SaveChangesAsync();
            }

            }
        }
    }

