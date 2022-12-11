namespace FitnessAndSPABooking.Core.Constrains

{
    public class GlobalConstants
    {
        public const string SystemName = "FitnesAndSPABooking";

        public const string AdministratorRoleName = "Administrator";

        public const string SalonManagerRoleName = "Manager";

        public const string CloudName = "SPA-booking";

        public static class AccountsSeeding
        {
            public const string Password = "123456";

            public const string AdminEmail = "admin@admin.com";

            public const string SalonManagerEmail = "manager@manager.com";

            public const string UserEmail = "user@user.com";
        }

        public static class DataValidations
        {
            public const int TitleMaxLength = 60;

            public const int TitleMinLength = 5;

            public const int ContentMaxLength = 3500;

            public const int ContentMinLength = 700;

            public const int NameMaxLength = 40;

            public const int NameMinLength = 2;

            public const int DescriptionMaxLength = 700;

            public const int DescriptionMinLength = 50;

            public const int AddressMaxLength = 100;

            public const int AddressMinLength = 5;
        }

        public static class ErrorMessages
        {
            public const string Title = "Title have to be between 5 and 60 characters.";

            public const string Content = "Content have to be between 700 and 3500 characters.";

            public const string Author = "Author name have to be between 2 and 40 characters.";

            public const string Name = "Name have to be between 2 and 40 characters.";

            public const string Description = "Description have to be between 50 and 700 characters.";

            public const string Address = "Address have to be between 5 and 100 characters.";

            public const string Image = "Please select a JPG, JPEG or PNG image smaller than 1MB.";

            public const string DateTime = "Please select a valid DATE and TIME from the calendar on the left.";

            public const string Rating = "Please choose stars from 1 to 5.";
        }

        public static class DateTimeFormats
        {
            public const string DateFormat = "dd-MM-yyyy";

            public const string TimeFormat = "h:mmtt";

            public const string DateTimeFormat = "dd-MM-yyyy h:mmtt";
        }

        public static class Images
        {
            public const string Index = "https://www.planetfitness.com/sites/default/files/styles/gallery_full_image/public/2018-12/i_Planet%20Fitness%20Haltom%20City-5.jpg?itok=fCfg7uB3";

            public const string CoverBackground = "C:\\Users\\PC\\Desktop\\FitnesAndSpaFolder";

            public const string Footer = "C:\\Users\\PC\\Desktop\\FitnesAndSpaFolder";

            public const string Error404 = "C:\\Users\\PC\\Desktop\\FitnesAndSpaFolder";

            public const string CloudinaryMissing = "C:\\Users\\PC\\Desktop\\FitnesAndSpaFolder";

            // Blogs
            public const string Fitness = "C:\\Users\\PC\\Desktop\\FitnesAndSpaFolder";

            public const string SPA = "C:\\Users\\PC\\Desktop\\FitnesAndSpaFolder";

           
            // Categories
            public const string Pools = "https://th.bing.com/th/id/OIP.p0Q2tOyqNbAv4jti-POq6wHaHa?pid=ImgDet&rs=1";

            public const string SPAMassage = "https://www.lakesidehotel.co.uk/wp-content/uploads/2020/07/spa-treatment-room-scaled.jpg";

            public const string SPAFace = "https://th.bing.com/th/id/OIP.DMgIIl80f8dszWwPqaVgowHaE8?pid=ImgDet&rs=1";
           
            public const string Body = "https://th.bing.com/th/id/R.b08eeac164714728aefee084957002d8?rik=wYlpPzw6xhcIig&pid=ImgRaw&r=0";

            // Salon
            public const string SPAAndFitnes = "https://th.bing.com/th/id/R.a8404a3356d2da42013ffa58275fae30?rik=yTVllqpiuTO5mg&pid=ImgRaw&r=0";

        }

        public static class SeededDataCounts
        {
            public const int BlogPosts = 2;

            public const int Categories = 4;

            public const int Services = 55;

            public const int Cities = 1;

            public const int Salons = 1;

            public const int Appointments = 54;
        }
    }
}


