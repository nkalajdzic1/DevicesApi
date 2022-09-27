using DevicesApi.Core.Entities;

namespace DevicesApi.Infrastructure.Data.Seeders
{
    public class RandomEntitySeeder
    {
        public static List<RandomEntity> RandomEntitiesSeeds = new()
        {
            new RandomEntity() { Id = 1, Name = "Random1", Description = "None" },
            new RandomEntity() { Id = 2, Name = "Random2", Description = "None" },
            new RandomEntity() { Id = 3, Name = "Random3", Description = "None" }
        };
    }
}
