/*4️⃣Create a MaxLength Attribute for Field Validation
Problem Statement: Define a field-level attribute MaxLength(int value) that restricts the
maximum length of a string field.
Requirements:
● Apply it to a User class field (Username).
● Validate length in the constructor.
● Throw ArgumentException if the limit is exceeded.*/
using System;
using System.Reflection;
namespace FieldValidation
{
    public class User
    {
        [MaxLength(8)]
        public string Username;

        public User(string username)
        {
            // Get field info
            FieldInfo field = typeof(User).GetField("Username");

            // Get MaxLength attribute
            MaxLengthAttribute attr = field.GetCustomAttribute<MaxLengthAttribute>();

            // Validate length
            if (attr != null && username.Length > attr.Length)
            {
                throw new ArgumentException(
                    $"Username length should not exceed : {attr.Length}");
            }

            Username = username;
        }
    }

}