using LSD_233_DAW_DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSD_233_DAW_DAL
{
    public class InitialSeed
    {
        private readonly RoleManager<ProjectRole> _roleManager;

        public InitialSeed(RoleManager<ProjectRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async void CreateRoles()
        {
            string[] roleNames = {
                                "Admin",
                                "Fan"
                                };

            foreach (var roleName in roleNames)
            {
                var role = new ProjectRole
                {
                    Name = roleName
                };
                _roleManager.CreateAsync(role).Wait();
            }
        }
    }
}
