using MongoDB.Driver;
using Microsoft.Extensions.Options;
using EasySite.Models;
using EasySite.Settings;

public class MongoDBService
{
    private readonly IMongoCollection<User> _users;

    public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        var client = new MongoClient(mongoDBSettings.Value.ConnectionString);
        var database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _users = database.GetCollection<User>("users");
    }

    // Example method to get all users
    public async Task<List<User>> GetUsersAsync()
    {
        return await _users.Find(user => true).ToListAsync();
    }

    // Example method to create a new user
    public async Task CreateUserAsync(User user)
    {
        await _users.InsertOneAsync(user);
    }
}
