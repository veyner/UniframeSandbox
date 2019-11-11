using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UniframeSandbox.EntityObjects
{
    public class FacilityContext : DbContext
    {
        public DbSet<EntityFacility> Facilities { get; set; }
        public DbSet<EntityCoordinates> Coordinates { get; set; }
        public DbSet<EntityFacilityCommand> FacilityCommands { get; set; }
        public DbSet<EntityFacilityState> States { get; set; }
        public DbSet<EntityStateCommon> StateCommons { get; set; }
        public DbSet<EntityStateDevice> StateDevices { get; set; }
        public DbSet<EntityStateConnection> StateConnections { get; set; }
        public DbSet<EntityStateSystem> StateSystems { get; set; }
        public DbSet<EntityStateAlarm> StateAlarms { get; set; }
        public DbSet<EntityStateFacilityParameter> StateFacilityParameters { get; set; }
        public DbSet<EntityStateAlarmExt> StateAlarmsExt { get; set; }
        public DbSet<EntityStateCommonExt> StateCommonsExt { get; set; }
        public DbSet<EntityStateConnectionExt> StateConnectionsExt { get; set; }
        public DbSet<EntityStateDeviceExt> StateDevicesExt { get; set; }
        public DbSet<EntityStateSystemExt> StateSystemsExt { get; set; }

        public FacilityContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Facility.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityFacility>()
                .HasKey(x => x.FacilityId);

            modelBuilder.Entity<EntityCoordinates>()
                .HasKey(x => x.CoordinatesId);

            modelBuilder.Entity<EntityFacilityCommand>()
                .HasKey(x => x.CommandId);

            modelBuilder.Entity<EntityFacilityState>()
                .HasKey(x => x.StateId);
            modelBuilder.Entity<EntityStateCommon>()
                .HasKey(x => x.StateCommonId);
            modelBuilder.Entity<EntityStateDevice>()
                .HasKey(x => x.StateDeviceId);
            modelBuilder.Entity<EntityStateConnection>()
                .HasKey(x => x.ConnectionId);
            modelBuilder.Entity<EntityStateSystem>()
                .HasKey(x => x.StateSystemId);
            modelBuilder.Entity<EntityStateAlarm>()
                .HasKey(x => x.AlarmId);
            modelBuilder.Entity<EntityStateFacilityParameter>()
                .HasKey(x => x.StateFacilityParamId);

            modelBuilder.Entity<EntityStateAlarmExt>()
                .HasKey(x => x.AlarmId);
            modelBuilder.Entity<EntityStateCommonExt>()
                .HasKey(x => x.StateCommonId);
            modelBuilder.Entity<EntityStateConnectionExt>()
                .HasKey(x => x.ConnectionID);
            modelBuilder.Entity<EntityStateDeviceExt>()
                .HasKey(x => x.StateDeviceId);
            modelBuilder.Entity<EntityStateSystemExt>()
                .HasKey(x => x.StateSystemId);

        }
    }
}
