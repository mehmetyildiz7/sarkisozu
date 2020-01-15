using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyEvernote.Entities;
using System.IO;

namespace MyEvernote.DataAccessLayer.EntityFramework
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            // Adding admin user..
            User admin = new User()
            {
                Email = "necocakici@gmail.com",
                IsAdmin = true,
                Username = "necocakici",
                Password = "123456",
            };

            // Adding standart user..
            User standartUser = new User()
            {
                Email = "aliduru@gmail.com",
                IsAdmin = false,
                Username = "aliduru",
                Password = "654321",
            };

            context.Users.Add(admin);
            context.Users.Add(standartUser);

            context.SaveChanges();

            // Sanatçı ekleniyor...

            Artist meekMill = new Artist() { Name = "Meek Mill" };
            Artist lilWayne = new Artist() { Name = "Lil Wayne" };

            context.Artists.Add(meekMill);
            context.Artists.Add(lilWayne);

            // album ekleniyor

            Album championships = new Album() { Name = "Championships", Artist = meekMill, ReleaseDate = new DateTime(2019, 6, 30), SongCount = 17 };

            context.Albums.Add(championships);

            // Şarkı ekleniyor..

            Song intro = new Song() { Lyrics = File.ReadAllText(Directory.GetCurrentDirectory() + "Ceviriler/Intro.txt"), Name = "Intro", ProducerName = "Oz", Album = championships };

            context.SaveChanges();
        }
    }
}
