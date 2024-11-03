using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

public class Validator
{
    public static bool Validate(object obj)
    {
        Type type = obj.GetType();
        foreach (PropertyInfo property in type.GetProperties())
        {
            foreach (
                Attribute attribute in property
                    .GetCustomAttributes(typeof(RequiredAttribute), false)
                    .Cast<Attribute>()
            )
            {
                var value = property.GetValue(obj);
                if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                {
                    Console.WriteLine($"Property '{property.Name}' is required.");
                    return false;
                }
            }
        }
        return true;
    }
}

class Program
{
    static void Main()
    {
        var user = new User { Age = 25 };
        Validator.Validate(user); // Выведет предупреждение о том, что Name обязателен
    }
}

internal class User
{
    public int Age { get; set; }
}
