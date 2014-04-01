﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dibware.Template.Infrastructure.SqlDataAccess.UnitOfWork;


namespace Dibware.Template.Infrastructure.SqlDataAccessTests.Initialisers
{
    public class WebsiteDbContextInitialiser : DropCreateDatabaseAlways<WebsiteDbContext>
    {
        /// <summary>
        /// Seeds the specified database context.
        /// </summary>
        /// <param name="databaseContext">The database context.</param>
        protected override void Seed(WebsiteDbContext databaseContext)
        {
            SeedRoles(ref databaseContext);
            SeedUsers(ref databaseContext);

            // Commit attachments
            databaseContext.Commit();
        }

        /// <summary>
        /// Seeds the specified database context with roles.
        /// </summary>
        /// <param name="databaseContext">The database context.</param>
        protected static void SeedRoles(ref WebsiteDbContext databaseContext)
        {
            //// Create Roles
            //var roleAdmin = new Role
            //{
            //    Key = RoleData.RoleAdmin.Key,
            //    Name = RoleData.RoleAdmin.Name
            //};
            //var rolePrivate = new Role
            //{
            //    Key = RoleData.RolePrivate.Key,
            //    Name = RoleData.RolePrivate.Name
            //};
            //var roleOrganisation = new Role
            //{
            //    Key = RoleData.RoleOrganisation.Key,
            //    Name = RoleData.RoleOrganisation.Name
            //};
            //var roleBusiness = new Role
            //{
            //    Key = RoleData.RoleBusiness.Key,
            //    Name = RoleData.RoleBusiness.Name
            //};
            //var roleUnknown = new Role
            //{
            //    Key = RoleData.RoleUnknown.Key,
            //    Name = RoleData.RoleUnknown.Name
            //};

            //// Add Roles
            //databaseContext.Attach(roleAdmin);
            //databaseContext.Attach(rolePrivate);
            //databaseContext.Attach(roleOrganisation);
            //databaseContext.Attach(roleBusiness);
            //databaseContext.Attach(roleUnknown);
        }

        /// <summary>
        /// Seeds the specified database context with users.
        /// </summary>
        /// <param name="databaseContext">The database context.</param>
        protected static void SeedUsers(ref WebsiteDbContext databaseContext)
        {
            //// Create Users
            //var userDave = new User
            //{
            //    Guid = UserData.UserDave.Guid,
            //    Password = UserData.UserDave.Password,
            //    Name = UserData.UserDave.Name,
            //    UserName = UserData.UserDave.UserName
            //};
            //var userJane = new User
            //{
            //    Guid = UserData.UserJane.Guid,
            //    Password = UserData.UserJane.Password,
            //    Name = UserData.UserJane.Name,
            //    UserName = UserData.UserJane.UserName
            //};
            //var userPete = new User
            //{
            //    Guid = UserData.UserPete.Guid,
            //    Password = UserData.UserPete.Password,
            //    Name = UserData.UserPete.Name,
            //    UserName = UserData.UserPete.UserName
            //};

            //// Add Users
            //databaseContext.Attach(userDave);
            //databaseContext.Attach(userJane);
            //databaseContext.Attach(userPete);
        }
    }
}