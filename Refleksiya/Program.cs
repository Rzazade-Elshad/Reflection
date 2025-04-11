using Refleksiya;
using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        Type usertype = typeof(User);
        User user1 = (User)Activator.CreateInstance(usertype);

        FieldInfo field1 = usertype.GetField("ID", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
        field1.SetValue(user1, 1);
        FieldInfo field2 = usertype.GetField("Name", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
        field2.SetValue(user1, "Elsad");
        FieldInfo field3 = usertype.GetField("SurName", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
        field3.SetValue(user1, "Rzazade");
        FieldInfo field4 = usertype.GetField("age", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
        field4.SetValue(user1, 20);



        MethodInfo methodInfo = usertype.GetMethod("GetFullNme");
        methodInfo.Invoke(user1, null);

        MethodInfo method = usertype.GetMethod("ChangeAge");
        method.Invoke(null, new object[] {25 } );
     



    }
}
