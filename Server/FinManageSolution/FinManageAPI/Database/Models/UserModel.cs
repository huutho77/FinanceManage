using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FinManageAPI.Database.Model;

[BsonDiscriminator("users")]
public class UserModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = String.Empty;

    [BsonElement("username")]
    public string UserName { get; set; } = String.Empty;
    [BsonElement("password")]
    public string Password { get; set; } = String.Empty;

    [BsonElement("firstName")]
    public string FirstName { get; set; } = String.Empty;

    [BsonElement("lastName")]
    public string LastName { get; set; } = String.Empty;

    [BsonElement("createdAt")]
    public DateTime CreatedDate { get; set; } = DateTime.Today;

    [BsonElement("udpatedAt")]
    public DateTime UpdatedDate { get; set; } = DateTime.Today;

    [BsonElement("salaryAmount")]
    public double SalaryAmount { get; set; } = 0;

    [BsonElement("spendLimitDaily")]
    public double SpendLimitDaily { get; set; } = 0;
}