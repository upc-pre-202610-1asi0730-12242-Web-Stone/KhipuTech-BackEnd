using System.Text.Json.Serialization;
using WebStone.Khiputech.Platform.Shared.Domain.Model.Entities;

namespace WebStone.Khiputech.Platform.Iam.Domain.Model.Aggregates;


public partial class User
{

    public User() { }


    public User(string username, string passwordHash, string type, string permissions)
    {
        Username = username;
        PasswordHash = passwordHash;
        Type = type;
        Permissions = permissions;
    }


    public int Id { get; private set; }


    public string Username { get; private set; } = string.Empty;


    [JsonIgnore]
    public string PasswordHash { get; private set; } = string.Empty;

    public string Type { get; private set; } = "public";

    public string Permissions { get; private set; } = string.Empty;

    public User UpdateUsername(string username)
    {
        Username = username;
        return this;
    }

    public User UpdatePasswordHash(string passwordHash)
    {
        PasswordHash = passwordHash;
        return this;
    }

    public User UpdateType(string type)
    {
        Type = type;
        return this;
    }
    
    public User UpdatePermissions(string permissions)
    {
        Permissions = permissions;
        return this;
    }
}