using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models
{
  public class ParksLookupApiContext : DbContext
  {
    public ParksLookupApiContext(DbContextOptions<ParksLookupApiContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, ParkName = "Joshua Tree", Desination = "National Park", StatesCode = "CA", Address = "74485 National Park Drive, Twentynine Palms, CA 92277-3597", Description = "Joshua Tree National Park is open year-round. There are few facilities within the park's approximately 800,000 acres, making Joshua Tree a true desert wilderness just a few hours outside Los Angeles, San Diego, Las Vegas, and Phoenix. About 2.8 million visitors come to the park each year to enjoy activities such as hiking, camping, photography, rock climbing, and simply enjoying the serene desert scenery. The busy season in Joshua Tree runs from October through May.", Weather = "Days are typically clear with less than 25% humidity. Temperatures are most comfortable in the spring and fall, with an average highs around 85°F (29°C) and average lows around 50°F (10°C) respectively. Winter brings cooler days, around 60°F (15°C), and freezing nights. It occasionally snows at higher elevations. Summers are hot, over 100°F (38°C) during the day and not cooling much below 75°F (24°C) at night.", WebsiteUrl = "https://www.nps.gov/jotr/index.htm" }, 
          new Park { ParkId = 2, ParkName = "Death Valley", Desination = "National Park", StatesCode = "CA, NV", Address = "Death Valley, CA 92328", Description = "Death Valley is the largest U.S. National Park outside Alaska at 3.4 million acres. Nearly 1000 miles of paved and dirt roads provide access to locations both popular and remote. Even so, 91% of the park is protected as officially designated Wilderness. That wild country includes low valley floors crusted with barren salt flats, rugged mountains rising as much as 11,000 feet, deep and winding canyons, rolling sand dunes, and spring-fed oases. Whether you have an afternoon or a week, careful planning will help make your visit safe and enjoyable.", Weather = "AUTUMN arrives in late October, with warm but pleasant temperatures and generally clear skies. WINTER has cool days, chilly nights and rarely, rainstorms. With snow capping the high peaks and low angled winter light, this season is especially beautiful for exploring the valley. SPRINGTIME is the most popular time to visit Death Valley. Besides warm and sunny days, the possibility of spring wildflowers is a big attraction. SUMMER starts early in Death Valley. By May the valley is too hot for most visitors.", WebsiteUrl = "https://www.nps.gov/deva/index.htm" },
          new Park { ParkId = 3, ParkName = "Fort Vancouver", Desination = "National Historic Site", StatesCode = "OR, WA", Address = "1501 E Evergreen Blvd, Vancouver, WA 98661", Description = "Located on the north bank of the Columbia River, in sight of snowy mountain peaks and a vibrant urban landscape, this park has a rich cultural past. From a frontier fur trading post, to a powerful military legacy, the magic of flight, and the origin of the American Pacific Northwest, history is shared at four unique sites. Discover stories of transition, settlement, conflict, and community.", Weather = "Fort Vancouver National Historic Site is located in a mild, temperate climate. However, in the case of severe weather, park alerts posted on the park's website will provide information about emergency closures.", WebsiteUrl = "https://www.nps.gov/fova/index.htm" },
          new Park { ParkId = 4, ParkName = "Glen Canyon", Desination = "National Recreation Area", StatesCode = "AZ, UT", Address = "691 Scenic View Rd., Page, AZ 86040", Description = "Encompassing over 1.25 million acres, Glen Canyon National Recreation Area offers unparalleled opportunities for water-based & backcountry recreation. The recreation area stretches for hundreds of miles from Lees Ferry in Arizona to the Orange Cliffs of southern Utah, encompassing scenic vistas, geologic wonders, and a vast panorama of human history.", Weather = "", WebsiteUrl = "https://www.nps.gov/glca/index.htm" },
          new Park { ParkId = 5, ParkName = "Yellowstone", Desination = "National Park", StatesCode = "ID, MT, WY", Address = "Yellowstone National Park, WY 82190", Description = "On March 1, 1872, Yellowstone became the first national park for all to enjoy the unique hydrothermal and geologic wonders. During the month of March, the park is commemorating 25 years since the reintroduction of the wolf to the ecosystem.", Weather = "Yellowstone's weather can vary quite a bit, even in a single day. In the summer, daytime highs can exceed 70°F (25°C), only to drop 20 or more degrees when a thunderstorm rolls through. It can snow during any month of the year, and winter lows frequently drop below 0°F (-18°C), especially at night. Bring a range of clothing options, including a warm jacket and rain gear, even in the summer.", WebsiteUrl = "https://www.nps.gov/yell/index.htm" }
        );

        builder.Entity<User>()
        .HasData(
          new User { Id = 1, FirstName = "Admin", LastName = "User", Username = "admin", Password = "admin", Role = Role.Admin },
          new User { Id = 2, FirstName = "Normal", LastName = "User", Username = "user", Password = "user", Role = Role.User } 
        );  
    }      
  }
}