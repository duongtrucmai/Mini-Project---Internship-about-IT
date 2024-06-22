using System.Reflection;

namespace WebApplication8_PDF.Models;

public class User
{
    public string Tên { get; set; } = null!;
    public string Họ { get; set; } = null!;
       public string Sđt { get; set; } = null!;
    public string ĐịaChỉ { get; set; } = null!;

    public Dictionary<string, string?> ToDict()
    {
        return GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
          .ToDictionary(prop => prop.Name, prop =>
          {
              if (prop.GetValue(this, null) is DateTime date)
              {
                  return date.ToShortDateString();
              }
              return prop.GetValue(this, null)?.ToString();
          });
    }
}
