﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kt_4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    public partial class kt_4Entities : DbContext
    {
        private static kt_4Entities _context;
        public kt_4Entities()
            : base("name=kt_4Entities")
        {
        }
        public static kt_4Entities GetContext()
        {
            if (_context == null)
                _context = new kt_4Entities();
            return _context;
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        // Добавляем метод для проверки существования пользователя
        public bool UserExists(string username, string password)
        {
            // Реализуйте соответствующий код запроса к базе данных для проверки пользователя
            var user = Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);
            return user != null;
        }

        // Добавляем метод для регистрации нового пользователя
        public bool RegisterUser(string username, string password, string email)
        {
            try
            {
                // Реализуйте соответствующий код запроса к базе данных для вставки нового пользователя
                Users.Add(new Users { Username = username, PasswordHash = password, Email = email });
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Обработайте исключение, если не удалось зарегистрировать пользователя
                // (например, если пользователь с таким именем уже существует)
                return false;
            }
        }


        public virtual DbSet<Billing> Billing { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}