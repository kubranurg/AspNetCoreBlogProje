﻿using EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Concrate
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=KUBRA;database=CoreBlogDb;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Match>().
            //    HasOne(x => x.HomeTeam).
            //    WithMany(y => y.HomeMatches).
            //    HasForeignKey(z => z.HomeTeamID).
            //    OnDelete(DeleteBehavior.ClientSetNull);
            //modelBuilder.Entity<Match>().
            //    HasOne(x => x.GuestTeam).
            //    WithMany(y => y.AwayMatches).
            //    HasForeignKey(z => z.GuestTeamID).
            //    OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>().
                HasOne(x => x.SenderUser).
                WithMany(y => y.WriterSender).
                HasForeignKey(z => z.SenderID).
                OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Message2>().
                HasOne(x => x.ReceiverUser).
                WithMany(y => y.WriterReceiver).
                HasForeignKey(z => z.ReceiverID).
                OnDelete(DeleteBehavior.ClientSetNull);
            //HomeMatch--> WriterSender
            //AwayTeam--> WriterReceiver

            //HomeTeam --> SenderUser
            //GuestTeam --> ReceiverUser

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRayting> BlogRayting { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Messagee> Messages { get; set; }
        public DbSet<Message2> Message2s { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
