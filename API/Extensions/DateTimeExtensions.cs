﻿namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateOnly date)
        {
            var today = DateOnly.FromDateTime(DateTime.UtcNow);
            int age = today.Year - date.Year;

            if (date > today.AddYears(-age)) age--;

            return age; 
        }
    }
}
