using Microsoft.EntityFrameworkCore;

namespace ValorantWebsite.Models
{
    public class ValorantDbContext : DbContext
    {
        public ValorantDbContext(DbContextOptions<ValorantDbContext> options) : base(options) { }

        public DbSet<Agent> Agents => Set<Agent>();
        /**/
        public DbSet<AgentRole> AgentRoles => Set<AgentRole>();
        public DbSet<Map> Maps => Set<Map>();
        public DbSet<Weapon> Weapons => Set<Weapon>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AgentRole>().HasData(
                new AgentRole { AgentRoleId = "Duel", AgentRoleName = "Duelist" },
                new AgentRole { AgentRoleId = "Init", AgentRoleName = "Initiator" },
                new AgentRole { AgentRoleId = "Cont", AgentRoleName = "Controller" },
                new AgentRole { AgentRoleId = "Sent", AgentRoleName = "Sentinel" }
                );

            modelBuilder.Entity<Map>().HasData(
                new Map
                {
                    MapID = "asce",
                    MapName = "Ascent",
                    MapLocation = "Venice, Italy",
                    MapImage = "Loading_Screen_Ascent.png",
                    MinimapImage = "Ascent_Minimap.png"
                },
                new Map
                {
                    MapID = "bind",
                    MapName = "Bind",
                    MapLocation = "Rabat, Morocco",
                    MapImage = "Loading_Screen_Bind.png",
                    MinimapImage = "Bind_Minimap.png"
                },
                new Map
                {
                    MapID = "bree",
                    MapName = "Breeze",
                    MapLocation = "Bermuda Triangle, Atlantic Ocean",
                    MapImage = "Loading_Screen_Breeze.png",
                    MinimapImage = "Breeze_Minimap.png"
                },
                new Map
                {
                    MapID = "frac",
                    MapName = "Fracture",
                    MapLocation = "Santa Fe County, New Mexico, USA",
                    MapImage = "Loading_Screen_Fracture.png",
                    MinimapImage = "Fracture_Minimap.png"
                },
                new Map
                {
                    MapID = "have",
                    MapName = "Haven",
                    MapLocation = "Thimphu, Bhutan",
                    MapImage = "Loading_Screen_Haven.png",
                    MinimapImage = "Haven_Minimap.png"
                },
                new Map
                {
                    MapID = "iceb",
                    MapName = "Icebox",
                    MapLocation = "Bennett Island, Russia",
                    MapImage = "Loading_Screen_Icebox.png",
                    MinimapImage = "Icebox_Minimap.png"
                },
                new Map
                {
                    MapID = "lotu",
                    MapName = "Lotus",
                    MapLocation = "Western Ghats, India",
                    MapImage = "Loading_Screen_Lotus.png",
                    MinimapImage = "Lotus_Minimap.png"
                },
                new Map
                {
                    MapID = "pear",
                    MapName = "Pearl",
                    MapLocation = "Lisbon, Portugal",
                    MapImage = "Loading_Screen_Pearl.png",
                    MinimapImage = "Pearl_Minimap.png"
                },
                new Map
                {
                    MapID = "spli",
                    MapName = "Split",
                    MapLocation = "Tokyo, Japan",
                    MapImage = "Loading_Screen_Split.png",
                    MinimapImage = "Split_Minimap.png"
                },
                new Map
                {
                    MapID = "suns",
                    MapName = "Sunset",
                    MapLocation = "Los Angeles, California, USA",
                    MapImage = "Loading_Screen_Sunset.png",
                    MinimapImage = "Sunset_Minimap.png"
                }
                );

            modelBuilder.Entity<Weapon>().HasData(
                new Weapon
                {
                    WeaponID = 1,
                    WeaponName = "Classic",
                    WeaponType = "Sidearm",
                    CreditCost = 0,
                    WeaponImage = "Classic.png",
                    MagazineSize = 12,
                    ReserveSize = 36
                },
                new Weapon
                {
                    WeaponID = 2,
                    WeaponName = "Shorty",
                    WeaponType = "Sidearm",
                    CreditCost = 300,
                    WeaponImage = "Shorty.png",
                    MagazineSize = 2,
                    ReserveSize = 6
                },
                new Weapon
                {
                    WeaponID = 3,
                    WeaponName = "Frenzy",
                    WeaponType = "Sidearm",
                    CreditCost = 450,
                    WeaponImage = "Frenzy.png",
                    MagazineSize = 13,
                    ReserveSize = 39
                },
                new Weapon
                {
                    WeaponID = 4,
                    WeaponName = "Ghost",
                    WeaponType = "Sidearm",
                    CreditCost = 500,
                    WeaponImage = "Ghost.png",
                    MagazineSize = 15,
                    ReserveSize = 45
                },
                new Weapon
                {
                    WeaponID = 5,
                    WeaponName = "Sheriff",
                    WeaponType = "Sidearm",
                    CreditCost = 800,
                    WeaponImage = "Sheriff.png",
                    MagazineSize = 6,
                    ReserveSize = 24
                },
                new Weapon
                {
                    WeaponID = 6,
                    WeaponName = "Stinger",
                    WeaponType = "SMG",
                    CreditCost = 1100,
                    WeaponImage = "Stinger.png",
                    MagazineSize = 20,
                    ReserveSize = 60
                },
                new Weapon
                {
                    WeaponID = 7,
                    WeaponName = "Spectre",
                    WeaponType = "SMG",
                    CreditCost = 1600,
                    WeaponImage = "Spectre.png",
                    MagazineSize = 30,
                    ReserveSize = 90
                },
                new Weapon
                {
                    WeaponID = 8,
                    WeaponName = "Bucky",
                    WeaponType = "Shotgun",
                    CreditCost = 850,
                    WeaponImage = "Bucky.png",
                    MagazineSize = 5,
                    ReserveSize = 10
                },
                new Weapon
                {
                    WeaponID = 9,
                    WeaponName = "Judge",
                    WeaponType = "Shotgun",
                    CreditCost = 1850,
                    WeaponImage = "Judge.png",
                    MagazineSize = 5,
                    ReserveSize = 15
                },
                new Weapon
                {
                    WeaponID = 10,
                    WeaponName = "Bulldog",
                    WeaponType = "Rifle",
                    CreditCost = 2050,
                    WeaponImage = "Bulldog.png",
                    MagazineSize = 24,
                    ReserveSize = 72
                },
                new Weapon
                {
                    WeaponID = 11,
                    WeaponName = "Guardian",
                    WeaponType = "Rifle",
                    CreditCost = 2250,
                    WeaponImage = "Guardian.png",
                    MagazineSize = 12,
                    ReserveSize = 36
                },
                new Weapon
                {
                    WeaponID = 12,
                    WeaponName = "Phantom",
                    WeaponType = "Rifle",
                    CreditCost = 2900,
                    WeaponImage = "Phantom.png",
                    MagazineSize = 30,
                    ReserveSize = 60
                },
                new Weapon
                {
                    WeaponID = 13,
                    WeaponName = "Vandal",
                    WeaponType = "Rifle",
                    CreditCost = 2900,
                    WeaponImage = "Vandal.png",
                    MagazineSize = 25,
                    ReserveSize = 50
                },
                new Weapon
                {
                    WeaponID = 14,
                    WeaponName = "Marshall",
                    WeaponType = "Sniper",
                    CreditCost = 950,
                    WeaponImage = "Marshall.png",
                    MagazineSize = 5,
                    ReserveSize = 15
                },
                new Weapon
                {
                    WeaponID = 15,
                    WeaponName = "Outlaw",
                    WeaponType = "Sniper",
                    CreditCost = 2400,
                    WeaponImage = "Outlaw.png",
                    MagazineSize = 2,
                    ReserveSize = 10
                },
                new Weapon
                {
                    WeaponID = 16,
                    WeaponName = "Operator",
                    WeaponType = "Sniper",
                    CreditCost = 4700,
                    WeaponImage = "Operator.png",
                    MagazineSize = 5,
                    ReserveSize = 10
                },
                new Weapon
                {
                    WeaponID = 17,
                    WeaponName = "Ares",
                    WeaponType = "Machine Gun",
                    CreditCost = 1600,
                    WeaponImage = "Ares.png",
                    MagazineSize = 50,
                    ReserveSize = 100
                },
                new Weapon
                {
                    WeaponID = 18,
                    WeaponName = "Odin",
                    WeaponType = "Machine Gun",
                    CreditCost = 3200,
                    WeaponImage = "Odin.png",
                    MagazineSize = 100,
                    ReserveSize = 200
                },
                new Weapon
                {
                    WeaponID = 19,
                    WeaponName = "Knife",
                    WeaponType = "Melee",
                    CreditCost = 0,
                    WeaponImage = "Knife.png",
                    MagazineSize = 0,
                    ReserveSize = 0
                }
                );
        }

    }
}
