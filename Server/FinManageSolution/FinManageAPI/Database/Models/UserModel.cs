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

    [BsonElement("firstname")]
    public string FirstName { get; set; } = String.Empty;

    [BsonElement("lastname")]
    public string LastName { get; set; } = String.Empty;
}