using System;

namespace FactoryGirlSpike.Poco
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Admin { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} FirstName: {2}, LastName: {3}, Admin: {4}, Email: {5}",
                new object[] { GetType().FullName, GetHashCode(), FirstName, LastName, Admin, Email });
        }
    }
}
